using System;
using System.Collections.Generic;
using System.Linq;

namespace _03SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] symbols = Console.ReadLine().Split();
            Stack<string> result = new Stack<string>(symbols.Reverse());
            while (result.Count > 1)
            {
                int firstNumber = int.Parse(result.Pop());
                string operation = result.Pop();
                int secondNumber = int.Parse(result.Pop());

                if (operation == "+")
                {

                    result.Push((firstNumber + secondNumber).ToString());
                }
                else if (operation == "-")
                {
                    int sum = firstNumber - secondNumber;
                    result.Push(sum.ToString());
                }
            }
            Console.WriteLine(result.Pop());
        }
    }
}
