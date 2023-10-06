using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidMP1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First 20 Odd Natural Numbers\n");

            int count = 0;
            for (int k = 1; k <= 40; k++)
            {
                if (k % 2 == 1)
                {
                    count++;
                    Console.WriteLine($"{count}) {k}");
                }
                
            }
            Console.ReadKey();
        }
    }
}
