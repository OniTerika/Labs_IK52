using System;
using System.Collections.Generic;
using System.Linq;

namespace Sandbox
{
    class Program
    {
        static void Main()
        {

            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Random rnd = new Random();

            List<int> list = new List<int>();

            for (int i = 0; i < 50; i++)
            {
                list.Add(rnd.Next(-150, 150 + 1));
                Console.WriteLine($"{list[i]} ");
            }

            Console.WriteLine("------------------");

            List<int> sorted = list.Where(x => x >= 10 && x <= 99).OrderBy(x => x).ToList();

            for (int i = 0; i < sorted.Count; i++)
            {
                Console.Write($"{sorted[i]} ");
            }
        }
    }
}