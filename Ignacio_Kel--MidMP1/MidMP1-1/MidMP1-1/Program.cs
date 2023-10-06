using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidMP1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First 10 Natural Numbers\n");

            int count = 0;
            for (int k = 1; k <= 10; k++)
            {
                count++;
                Console.WriteLine($"{count}) {k}");
            }
            Console.ReadKey();
        }
    }
}
