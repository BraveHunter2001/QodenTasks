using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] tokens = Split(str, ' ');

            int ans = Calc(tokens);

            Console.WriteLine(ans);
        
        }

        static int Calc(string[] tokens)
        {
            Stack<int> stack = new Stack<int>();
            int counter = 0;

            for (int i = 0; i < tokens.Length; i++)
            {
                int number;
                string token = tokens[i];

                if (int.TryParse(token, out number))
                {
                    stack.Push(number);
                }
                else
                {
                    counter++;

                    int second = stack.Pop();
                    int first = stack.Pop();

                    int ans = CalcOp(token, first, second);
                    stack.Push(ans);
                }
            }

            return stack.Pop();
        }

        static int CalcOp(string op, int a, int b)
        {
            int ans;
            switch (op)
            {
                case "+":
                    ans = a + b;
                    break;
                case "-":
                    ans = a - b;
                    break;
                case "*":
                    ans = a * b;
                    break;
                case "/":
                    ans = a / b;
                    break;
                default:
                    ans = 0;
                    break;

            }

            return ans;
        }

        static string[] Split(string str, char sep)
        {
            List<string> strings = new List<string>();


            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != sep)
                {
                    sb.Append(str[i].ToString());
                }

                if (str[i] == sep || i == str.Length - 1)
                {
                    strings.Add(sb.ToString());
                    sb.Clear();
                }

            }

            return strings.ToArray();
        }
    }
}
