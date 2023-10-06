using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidMP1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*-*-AVERAGE OF GENERATED NUMBERS-*-*");

            Console.Write("How many numbers do you want to generate?: ");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            Console.WriteLine("\nGenerated Numbers:");
            for (int k = 1; k <= num; k++)
            {
                if (k == num)
                {
                    Console.Write($"{k}");
                }
                else Console.Write($"{k}, ");
                sum += k;
            }

            float average = (float)sum / (float)num;
            String ave = String.Format("\n\nAverage of Generated Number: {0:N2}", average);
            Console.WriteLine(ave);
            Console.ReadKey();
        }
    }
}
