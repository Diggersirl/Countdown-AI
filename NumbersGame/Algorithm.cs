using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersGame
{
    class Algorithm
    {
        string[] ops = new string[] { "+", "-", "*", "/" };

        private int Goal { get; set; }
        private double StartTemperature { get; set; }
        private List<int> Numbers { get; set; }

        public Algorithm()
        {

        }


        public Algorithm(int goal, double temp, List<int> numbers)
        {
            Goal = goal;
            StartTemperature = temp;
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


            while (k != nums.Count)
            {
                chosenoperand = choice.Next(0, nums.Count);

                if (selectednum.Add(chosenoperand))
                {
                    operands[k] = nums[chosenoperand];
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
                        if (operands[i] < operands[i + 1] && operators[j] == "/")
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

            return Tuple.Create(operands, operators);
        }


        public Tuple<int[], string[]> PotentialMove(int[] operands, string[] operators)
        {

            Random choice = new Random();

            operators[choice.Next(0, operators.Length)] = ops[choice.Next(0, 3)];

            return Tuple.Create(operands, operators);
        }


        //shunting yard algorithm
        public int ConverttoPostfix(int[] operands, string[] operators)
        {
            int i = 0;

            Stack<string> output = new Stack<string>();
            Stack<string> opstack = new Stack<string>();

            do
            {
                try
                {
                    if (i != operands.Length - 1)
                    {
                        output.Push(operands[i].ToString());
                    }
                }
                catch(IndexOutOfRangeException)
                {
                    return 0;
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
                                while (Precedence(opstack.Peek()) >= Precedence(operators[i]) )
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
                    try
                    {
                        opstack.Push(operators[i]);
                    }
                    catch(IndexOutOfRangeException)
                    {
                        return 0;
                    }
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
                    try
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
                    catch (InvalidOperationException e)
                    {
                        break;
                    }
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


        public double ProbabilityFunction(int newvalue, int goaldistance, double T)
        {
            if (newvalue < goaldistance && newvalue >= 0)
            {
                return 1;
            }
            else
            {
                double DeltaE = Math.Abs(goaldistance - newvalue);
                double res = Math.Pow(Math.E, -(DeltaE / T));
                return res;
            }
        }

        public double AnnealingSchedule(double temp)
        {
            //temp = temp - 0.25;
            temp = temp * 0.99;
            //temp = temp - Math.Sqrt(temp);
            return temp;

        }





        public Tuple<int[], string[], int> GetComputerAnswer()
        {
            Random r = new Random();
            bool goalnotreached = true;
            int initsolutionval, goaldistance;
            double currenttemp = StartTemperature;
            int k = 0;
            Tuple<int[], string[]> bestSolution = null;
            int bestSolutionE, moveval = 0;
            int j = 1;


            goaldistance = Goal;
            bestSolutionE = Goal;



            while (goaldistance != 0 && k != 30)
            {
                Tuple<int[], string[]> t = InitialState(Numbers);
                int[] Operands = t.Item1;
                string[] Operators = t.Item2;
                int[] operands = Operands;
                string[] operators = Operators;
                int count = 0;


                int[] opset;
                string[] operset;

                if (k != 30)
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
                        opset[g] = Operands[g];
                        if (g < j)
                        {
                            operset[g] = Operators[g];
                        }
                        g++;
                    }

                    initsolutionval = ConverttoPostfix(opset, operset);
                    goaldistance = Goal - initsolutionval;


                    if (goaldistance == 0)
                    {
                        bestSolution = t;
                        bestSolutionE = Goal - initsolutionval;
                        goalnotreached = false;
                    }


                    while (goalnotreached && currenttemp > 0.01)
                    {
                        Tuple<int[], string[]> move = PotentialMove(opset, operset);

                        moveval = ConverttoPostfix(move.Item1, move.Item2);

                        double ds = ((double)StartTemperature - (double)currenttemp) / (double)StartTemperature;
                        Random ra = new Random();

                        if (ProbabilityFunction(moveval, goaldistance, currenttemp) > ra.NextDouble())
                        {
                            opset = move.Item1;
                            operset = move.Item2;

                            goaldistance = Goal - moveval;
                        }

                        goalnotreached = (goaldistance <= 10 && goaldistance >= 0) ? false : true;

                        if (count % 2 == 0)
                        {
                            currenttemp = AnnealingSchedule(currenttemp);
                        }
                        count++;
                    }

                    if (goaldistance != 0 & Goal - moveval < bestSolutionE && Goal - moveval > 0)
                    {
                        bestSolution = Tuple.Create(opset, operset);
                        bestSolutionE = Goal - moveval;
                    }
                    else if (goaldistance == 0)
                    {
                        bestSolution = Tuple.Create(opset, operset);
                        bestSolutionE = Goal - moveval;
                    }
                    j++;
                    currenttemp = StartTemperature;
                    goalnotreached = true;
                }

                k++;

            }

            return Tuple.Create(bestSolution.Item1, bestSolution.Item2, Goal - bestSolutionE);
        }


        public static string PrintSolution(Tuple<int[], string[]> solution)
        {
            int i = 0;
            StringBuilder sb = new StringBuilder();

            while (i != solution.Item1.Length)
            {
                sb.Append(solution.Item1[i]);
                if (i != solution.Item2.Length)
                {
                    sb.Append(solution.Item2[i]);
                }
                i++;
            }

            return sb.ToString();
        }

        public static string PrintSolution(int[] operands, string[] operators)
        {
            int i = 0;
            StringBuilder sb = new StringBuilder();

            while (i != operands.Length)
            {
                sb.Append(operands[i]);
                if (i != operators.Length)
                {
                    sb.Append(operators[i]);
                }
                i++;
            }

            return sb.ToString();
        }  
    }
}
