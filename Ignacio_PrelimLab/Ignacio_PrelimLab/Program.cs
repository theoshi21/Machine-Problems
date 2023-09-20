using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ignacio_PrelimLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of the program you want to run:\n" +
                "[1] LeapYear\n" +
                "[2] PHPtoUSD\n"+
                "[3] Calculator");
            Console.Write("PROGRAM: ");
            int program = int.Parse(Console.ReadLine());

            Console.WriteLine();

            switch (program)
            {
                //LEAP YEAR DETERMINATOR
                case 1:
                    Console.WriteLine("-x-x- LEAP YEAR DETERMINATOR -x-x-");
                    Console.Write("Enter a year: ");
                    int year = int.Parse(Console.ReadLine());

                    if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                    {
                        Console.WriteLine($"> {year} is a leap year!");

                    }
                    else Console.WriteLine($"> {year} is NOT a leap year.");
                    break;
               
                //PHP TO USD CONVERTER
                case 2:
                    Console.WriteLine("** PHP TO USD CONVERTER **");
                    Console.Write("Enter PHP: ");
                    double php = double.Parse(Console.ReadLine());

                    double convert = php * 0.018;

                    Console.WriteLine("\nConversion Rate: (P1 : $0.018)");
                    Console.WriteLine($"PHP [P]: P{php}\nUSD [$]: ${convert}");
                    break;
                
                //CALCULATOR
                case 3:
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
                    break;
                default: Console.WriteLine("Invalid Program.");  break;
            }
            Console.ReadKey();
        }
    }
}
