using System;
using System.Collections.Generic;

namespace _08TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            Queue<string> queue = new Queue<string>();
            int carPassed = 0;

            while(input != "end")
            {
                if (input == "green")
                {
                    //int count = queue.Count;
                    for (int i = 0; i < n; i++)
                    {
                        if (queue.Count > 0)
                        {
                            Console.WriteLine($"{queue.Dequeue()} passed!");
                            carPassed++;
                        }
                        
                    }
                }
                else
                {
                    queue.Enqueue(input);
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"{carPassed} cars passed the crossroads.");
        }
    }
}
