using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPZ
{
    class MyOPZ
    {
        Stack<char> stack = new Stack<char>();

        public MyOPZ()
        {

        }

        public string ToOPZ(string symbols)
        {
            int id = 0;
            stack.Clear(symbols.Length);
            string result = "";
            while (id < symbols.Length)
            {
                if (symbols[id] == '(')
                {
                    stack.Push(symbols[id]);
                    id++;
                    if (id == symbols.Length)
                        break;
                    continue;
                }

                if (symbols[id] == ')')
                {

                    while (stack.Top() != '(')
                    {
                        result += stack.Pop();
                    }
                    stack.Pop();
                    id++;
                    if (id == symbols.Length)
                        break;
                    continue;
                }

                if (IsOperand(symbols[id]))
                {
                    result += symbols[id];
                    id++;
                    if (id == symbols.Length)
                        break;
                    continue;
                }

                if (Priority(symbols[id]) != -1)
                {
                    if (stack.IsEmpty())
                    {
                        stack.Push(symbols[id]);
                        id++;
                        if (id == symbols.Length)
                            break;
                    }
                    else
                    {
                        if (Priority(symbols[id]) <= Priority(stack.Top()))
                        {
                            result += stack.Pop();
                        }
                        else
                        {
                            stack.Push(symbols[id]);
                            id++;
                            if (id == symbols.Length)
                                break;
                        }
                    }
                }
            }
            while (!stack.IsEmpty())
            {
                result += stack.Pop();
            }
            return result;
        }

        public double ToCalc(string final_string)
        {
            Stack<double> stack = new Stack<double>();
            stack.Clear(final_string.Length);
            double result;
            for (int i = 0; i < final_string.Length; i++)
            {
                if (IsOperand(final_string[i]))
                {
                    stack.Push(double.Parse(final_string[i].ToString()));
                    continue;
                }
                if (Priority(final_string[i]) != -1)
                {
                    double numb1 = stack.Pop();
                    double numb2 = stack.Pop();

                    if (final_string[i] == '+')
                    {
                        double numb3 = numb1 + numb2;
                        stack.Push(numb3);
                    }
                    if (final_string[i] == '-')
                    {
                        double numb3 = numb2 - numb1;
                        stack.Push(numb3);
                    }
                    if (final_string[i] == '*')
                    {
                        double numb3 = numb2 * numb1;
                        stack.Push(numb3);
                    }
                    if (final_string[i] == '/')
                    {
                        double numb3 = numb2 / numb1;
                        stack.Push(numb3);
                    }
                    if (final_string[i] == '^')
                    {
                        double numb3 = Math.Pow(numb2, numb1);
                        stack.Push(numb3);
                    }
                }
            }
            result = stack.Pop();
            return result;
        }
        private int Priority(char value)
        {
            if (value == '(')
                return 0;
            if (value == ')')
                return 1;
            if (value == '+')
                return 2;
            if (value == '-')
                return 2;
            if (value == '*')
                return 3;
            if (value == '/')
                return 3;
            if (value == '^')
                return 4;
            return -1;
        }
        public bool IsOperand(char value)
        {
            if ((value <= 57) && (value >= 48))
                return true;
            else return false;
        }
    }
}
