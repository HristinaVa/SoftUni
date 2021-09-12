
            using System;
            using System.Collections.Generic;
            using System.Linq;

namespace CSA_Reverse_Strings
    {
        class Program
        {
            static void Main(string[] args)
            {
            string input = Console.ReadLine();
            Queue<string> queue = new Queue<string>();
            while (input != "End")
            {
                
                if (input == "Paid")
                {
                    int count = queue.Count;
                    for (int i = 0; i < count; i++)
                    {

                        Console.WriteLine(queue.Dequeue());
                    }
                }
                else
                {
                    queue.Enqueue(input);
                }
                

                input = Console.ReadLine();
            }
            Console.WriteLine($"{queue.Count} people remaining.");
            }
        }
    }

    
