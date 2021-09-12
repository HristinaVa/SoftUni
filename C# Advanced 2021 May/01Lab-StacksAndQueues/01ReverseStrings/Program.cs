using System;
using System.Collections.Generic;

namespace _01ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Stack<char> reverse = new Stack<char>();
            foreach (var item in text)
            {
                reverse.Push(item);
            }
            Console.WriteLine(reverse.ToArray());
        }
    }
}
