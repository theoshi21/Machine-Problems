using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidMP1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-*-*- FIBONACCI SEQUENCE -*-*-");
            Console.Write("Input a number to be generated: ");
            int num = int.Parse(Console.ReadLine());
        
            int prev = 0, current=1, sum;

            Console.Write($"{prev} {current} ");
            
            for(int k = 2; k < num; k++)
            {
                sum = prev + current;
                Console.Write($"{sum} ");
                prev = current;
                current = sum;
            }
           
            Console.ReadKey();
        }
    }
}
