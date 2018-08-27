using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumbersGame
{
    class EasyAlgorithm
    {
        string[] ops = new string[] { "+", "-", "*", "/" };


        private int Goal { get; set; }
        private List<int> Numbers { get; set; }

        public EasyAlgorithm(int goal, List<int> numbers)
        {
            Goal = goal;
            Numbers = numbers;
        }

        //create initial solution
        public Tuple<int[], string[]> InitialState(List<int> nums)
        {

            int chosenoperand;
            int[] operands = new int[6];
            string[] operators = new string[5];
            Random choice = new Random();

            HashSet<int> selectednum = new HashSet<int>();
            int k = 0;

            while (k != Numbers.Count)
            {
                chosenoperand = choice.Next(0, Numbers.Count);

                if (selectednum.Add(chosenoperand))
                {
                    operands[k] = Numbers[chosenoperand];
                    k++;
                }
            }

              for (int i = 0; i < 5; i++)
            {
                operators[i] = ops[choice.Next(0, 4)];
            }



            for (int i = 0; i < operands.Length; i++)
            {
                for (int j = 0; j < operators.Length; j++)
                {
                    try
                    {
                        if (operands[i] % operands[i + 1] != 0 && operators[j] == "/")
                        {
                            operators[j] = ops[choice.Next(0, 3)];
                        }
                    }
                    catch (IndexOutOfRangeException)
                    {
                        break;
                    }
                }
            }

           // MessageBox.Show(Algorithm.PrintSolution(operands, operators));

            return Tuple.Create(operands, operators);
        }

        public Tuple<int[], string[]> PotentialMove(int[] operands, string[] operators)
        {

            Random choice = new Random();

            operators[choice.Next(0, operators.Length)] = ops[choice.Next(0, 3)];

            return Tuple.Create(operands, operators);
        }


        public int ConverttoPostfix(int[] operands, string[] operators)
        {
            int i = 0;


            Stack<string> output = new Stack<string>();
            Stack<string> opstack = new Stack<string>();


            do
            {
                if (i != operands.Length - 1)
                {
                    output.Push(operands[i].ToString());
                }


                //if there is an operator on the operator stack
                if (opstack.Count != 0)
                {
                    try
                    {

                        //if operator at top of operator stack has higher precedence than operator that will be added to top of stack
                        //remove all operators from oerator stack that have greater or equal precedence, then add current operator to top of operator stack
                        if (Precedence(opstack.Peek()) >= Precedence(operators[i]))
                        {

                            try
                            {
                                while (Precedence(opstack.Peek()) >= Precedence(operators[i]))
                                {
                                    output.Push(opstack.Pop());
                                }

                                opstack.Push(operators[i]);
                            }
                            catch (InvalidOperationException)
                            {
                                //if stack becomes empty, i.e all operators on stack have >= precedence to operator from input and have been pushed to operator stack,
                                //then catch empty stack exception and add current operator to top of operator stack
                                opstack.Push(operators[i]);
                            }
                        }
                        else if (Precedence(operators[i]) >= Precedence(opstack.Peek()) && i == operands.Length - 1)
                        {
                            output.Push(operators[i]);
                        }
                        else
                        {
                            opstack.Push(operators[i]);
                        }
                    }
                    catch (IndexOutOfRangeException)
                    {
                        //if opstack becomes empty, push next operator to output stack
                        output.Push(operands[i].ToString());
                    }
                }
                else
                {
                    opstack.Push(operators[i]);
                }
                //if last operand has been added to output stack then add remaining operators from operator stack to the output stack
                if (i == operands.Length - 1)
                {
                    while (opstack.Count != 0)
                    {
                        output.Push(opstack.Pop());
                    }
                }

                i++;





            } while (i != operands.Length);



            var outcopy = new Stack<string>(new Stack<string>(output.Reverse()));

            return Calc(outcopy);



        }

        public int Precedence(string op)
        {
            int precedence = 0;

            switch (op)
            {
                case "+":
                    precedence = 1;
                    break;

                case "-":
                    precedence = 1;
                    break;

                case "*":
                    precedence = 2;
                    break;

                case "/":
                    precedence = 2;
                    break;

            }

            return precedence;

        }

        public int Calc(Stack<string> solution)
        {

            Stack<int> calcstack = new Stack<int>();
            int ans = 0;

            while (solution.Count != 0)
            {
                if (isNum(solution.Peek()))
                {
                    calcstack.Push(int.Parse(solution.Pop()));
                }
                else if (isOp(solution.Peek()))
                {

                        int num1 = calcstack.Pop();
                        int num2 = calcstack.Pop();

                        string op = solution.Pop();


                        switch (op)
                        {
                            case "+":
                                ans = num2 + num1;
                                break;

                            case "-":
                                ans = num2 - num1;
                                break;

                            case "*":
                                ans = num2 * num1;
                                break;

                            case "/":
                                ans = num2 / num1;
                                break;
                        }

                        calcstack.Push(ans);

                }
            }
            return ans;
        }


        public bool isNum(string item)
        {
            int result;
            return int.TryParse(item, out result);
        }


        public bool isOp(string item)
        {
            if (item == "+" || item == "-" || item == "*" || item == "/")
            {

                return true;
            }
            else
            {
                return false;
            }

        }


        public int Eval(int value, int goaldistance)
        {
            int evalresult;


            if (value >= Goal - 10 && value <= Goal + 10)
            {
                //Goal Reached
                evalresult = 2;
            }
            else if (Goal - value < goaldistance && Goal - value >= 0)
            {
                //better solution
                evalresult = 1;
            }
            else
            {
                //worse solution
                evalresult = 0;
            }

            return evalresult;
        }


        public Tuple<int[], string[], int> GetComputerAnswer()
        {
              Random r = new Random();
            bool goalnotreached = true;
            int  initsolutionval, goaldistance;
            Tuple<int[], string[]> bestSolution = null;
            int bestSolutionVal = 0;
            
            int loops = 0;
            int[] operands;
            string[] operators;
            int j = 1;
            int k;
            goaldistance = Goal;




            


            while (goaldistance != 0 && loops != 30)
            {
                Tuple<int[], string[]> t = InitialState(Numbers);
                operands = t.Item1;
                operators = t.Item2;
                k = 0;
                StringBuilder sb = new StringBuilder();

                
                int[] opset;
                string[] operset;

                if (loops != 30)
                {
                    j = 1;
                }

                int g;


                while (j != 6)
                {
                    g = 0;

                    opset = new int[j + 1];
                    operset = new string[j];


                    while (g <= j)
                    {
                        opset[g] = operands[g];
                        if (g < j)
                        {
                            operset[g] = operators[g];
                        }
                        g++;
                    }

                    initsolutionval = ConverttoPostfix(opset, operset);

                    goaldistance = Goal - initsolutionval;


                    if (goaldistance == 0)
                    {
                        goalnotreached = false;
                        bestSolution = Tuple.Create(opset, operset);
                        bestSolutionVal = initsolutionval;
                    }


                    while (goalnotreached && k < 10)
                    {
                        Tuple<int[], string[]> move = PotentialMove(opset, operset);

                        int moveval = ConverttoPostfix(move.Item1, move.Item2);


                        switch (Eval(moveval, goaldistance))
                        {
                            case 0:
                                break;

                            case 1:                               
                                goaldistance = Goal - moveval;
                                if (Math.Abs(goaldistance) <= Math.Abs(Goal - bestSolutionVal))
                                {
                                    opset = move.Item1;
                                    operset = move.Item2;
                                    bestSolution = Tuple.Create(opset, operset);
                                    bestSolutionVal = moveval;
                                }
                          
                                break;

                            case 2:
                                goalnotreached = false;
                                if (Math.Abs(Goal - moveval) <= Math.Abs(Goal - bestSolutionVal))
                                {
                                    bestSolution = Tuple.Create(opset, operset);
                                    bestSolutionVal = moveval;
                                }
                                break;

                        }
                       // MessageBox.Show("10: Not Broken Yet");
                     k++;
                    }
                    //MessageBox.Show("11: Not Broken Yet");
                    j++;
                    goalnotreached = true;
                    k = 0;
                }
               // MessageBox.Show("12: Not Broken Yet");
                loops++;
            }
           // MessageBox.Show("Iterations: " + k + "\noperands count: "+ bestSolution.Item1);
            //MessageBox.Show(String.Format("item1: {0}\nitem2: {1}\nval: {2}",bestSolution.Item1,bestSolution.Item2,Goal - bestSolutionVal));

            return Tuple.Create(bestSolution.Item1, bestSolution.Item2, bestSolutionVal);
 
        }
    }
    
}
