using System;
using System.Collections.Generic;
using System.Linq;

namespace _04MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string expresion = Console.ReadLine();
            Stack<int> result = new Stack<int>();
            for (int i = 0; i < expresion.Length; i++)
            {
                var ch = expresion[i];
                if (ch == '(')
                {
                    result.Push(i);
                }
                else if (ch == ')')
                {
                    int startindex = result.Pop();
                    string contents = expresion.Substring(startindex, i - startindex + 1);
                    Console.WriteLine(contents);
                }
                
            }
        }
    }
}
