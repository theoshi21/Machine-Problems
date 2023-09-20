using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP3_1_Ignacio
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initializing variables, num for the input and rem for the checker.
            int num, rem;

            Console.WriteLine("********************");
            Console.WriteLine("Odd or Even Checker");
            Console.WriteLine("********************");

            //Getting input from user then storing it into the variable 'num'
            Console.Write("Enter a number: ");
            num = Int32.Parse(Console.ReadLine());

            //Checking whether num has a remainder using the modulo operator and storing it in the variable 'rem'.
            rem = num % 2;

            //If it has remainder, it's odd. If no remainder, it's even.
            if (rem == 1)
            {
                Console.WriteLine("\nThe number "+num+" is ODD.");
            }
            else
            {
                Console.WriteLine("\nThe number "+num+" is EVEN.");
            }

            Console.ReadKey();
        }
    }
}
