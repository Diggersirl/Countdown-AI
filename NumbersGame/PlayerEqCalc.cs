using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersGame
{
    class PlayerEqCalc
    {
        Algorithm a = new Algorithm();

        public int ConverttoPostfix(string tokens)
        {
            Stack<string> output = new Stack<string>();
            Stack<string> opstack = new Stack<string>();

            string[] Tokens = tokens.Split(' ');



            foreach (string token in Tokens)
            {
                if (a.isNum(token))
                {
                    output.Push(token);
                }
                else if (a.isOp(token))
                {
                    while (opstack.Count > 0 && a.isOp(opstack.Peek()))
                    {
                        if (a.Precedence(token) <= a.Precedence(opstack.Peek()) && opstack.Count > 0)
                        {
                            output.Push(opstack.Pop());
                        }
                        else
                        {
                            break;
                        }
                    }
                    opstack.Push(token);
                }

                if (token == "(")
                {
                    opstack.Push(token);
                }
                if (token == ")")
                {
                    while (opstack.Count > 0 && opstack.Peek() != "(")
                    {
                        output.Push(opstack.Pop());
                    }
                    opstack.Pop();
                }
            }
            while (opstack.Count > 0 && a.isOp(opstack.Peek()))
            {
                output.Push(opstack.Pop());
            }


            var outcopy = new Stack<string>(new Stack<string>(output.Reverse()));


            return a.Calc(outcopy);


        }


    }
}
