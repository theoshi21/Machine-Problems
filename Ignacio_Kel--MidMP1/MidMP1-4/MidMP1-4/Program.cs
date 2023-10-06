using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidMP1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*-*-*-CUBING PROGRAM-*-*-*");
            Console.Write("Input an integer: ");
            int num = int.Parse(Console.ReadLine());

            for (int k = 1; k <= num; k++)
            {
                int cube = k * k * k;
                Console.WriteLine($"Cube of {k}: {cube}");
            }

            Console.ReadKey();
        }
    }
}
