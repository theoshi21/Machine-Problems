using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int x = 0; x < 1; x--)
            {
                Console.WriteLine("-o-o- CALCULATOR -o-o-");
                Console.WriteLine("Please enter 2 numbers: ");
                Console.Write("1st Number: "); int num1 = int.Parse(Console.ReadLine());
                Console.Write("2nd Number: "); int num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("\nWhat operator would you like to use?\n" +
                    "[1] Addition (+)\n" +
                    "[2] Subtraction (-)\n" +
                    "[3] Multiplication (x)\n" +
                    "[4] Division (/)");
                Console.WriteLine("NOTE: Choose the corresponding number for the operator.");
                Console.Write("OPERATOR: ");
                int chosenOperator = int.Parse(Console.ReadLine());

                switch (chosenOperator)
                {
                    case 1: Console.WriteLine($"\nOperator [ADDITION]\nThe answer for {num1} + {num2} is: {num1 + num2}"); break;
                    case 2: Console.WriteLine($"\nOperator [SUBTRACTION]\nThe answer for {num1} - {num2} is: {num1 - num2}"); break;
                    case 3: Console.WriteLine($"\nOperator [MULTIPLICATION]\nThe answer for {num1} x {num2} is: {num1 * num2}"); break;
                    case 4: Console.WriteLine($"\nOperator [DIVISION]\nThe answer for {num1} / {num2} is: {num1 / num2}"); break;
                    default: Console.WriteLine("Invalid operator."); break;
                }

                Console.Write("Would you like to continue? [Y/N]: ");
                string ans = Console.ReadLine();

                if (ans.ToLower() == "y") Console.Clear();
                else if (ans.ToLower() == "n") x = 2;
                else Console.WriteLine("Invalid Answer");
            }
        }
    }
}
