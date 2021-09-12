using System;
using System.Collections.Generic;

namespace _07HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kids = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>(kids);
            int count = 0;
            
            while (queue.Count != 1)
            {
                count++;
                if (count == n)
                {
                    Console.WriteLine($"Removed {queue.Dequeue()}");
                    count = 0;
                }
                else
                {
                    queue.Enqueue(queue.Dequeue());
                }

            }
            Console.WriteLine($"Last is {queue.Dequeue()}");

        }
    }
}
