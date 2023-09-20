using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP3_2_Ignacio
{
    class Program
    {
        static void Main(string[] args)
        {

            //Initializing variables for this program
            double preGrade, midGrade, finGrade;

            Console.WriteLine("*************************");
            Console.WriteLine("SEMESTRAL GRADE to GRADE POINT EQUIVALENT");
            Console.WriteLine("*************************");

            //Taking in prelim, midterm, and final grade as input and storing them to respective variables.
            Console.Write("Enter Prelim Grade: ");
            preGrade = double.Parse(Console.ReadLine());

            Console.Write("Enter Midterm Grade: ");
            midGrade = double.Parse(Console.ReadLine());

            Console.Write("Enter Final Grade: ");
            finGrade = double.Parse(Console.ReadLine());

            //Computation for semestral grade / final term grade.
            double finTermGrade = (preGrade * 0.3) + (midGrade * 0.3) + (finGrade * 0.4);
           

            //Printing of final term grade.
            Console.WriteLine("\nYour final term grade is: " + finTermGrade+"\n");

            //Else-If statements to convert the final term grade to grade point equivalent.
            if (finTermGrade >= 97 && finTermGrade <= 100)
            {
                Console.WriteLine("Grade Point Equivalent: 1.00");
            }
            else if (finTermGrade >= 93 && finTermGrade <= 96)
            {
                Console.WriteLine("Grade Point Equivalent: 1.25");
            }
            else if (finTermGrade >= 89 && finTermGrade <= 92)
            {
                Console.WriteLine("Grade Point Equivalent: 1.50");
            }
            else if (finTermGrade >= 85 && finTermGrade <= 88)
            {
                Console.WriteLine("Grade Point Equivalent: 1.75");
            }
            else if (finTermGrade >= 82 && finTermGrade <= 84)
            {
                Console.WriteLine("Grade Point Equivalent: 2.00");
            }
            else if (finTermGrade >= 79 && finTermGrade <= 81)
            {
                Console.WriteLine("Grade Point Equivalent: 2.25");
            }
            else if (finTermGrade >= 76 && finTermGrade <= 78)
            {
                Console.WriteLine("Grade Point Equivalent: 2.50");
            }
            else if (finTermGrade >= 73 && finTermGrade <= 75)
            {
                Console.WriteLine("Grade Point Equivalent: 2.75");
            }
            else if (finTermGrade >= 70 && finTermGrade <= 72)
            {
                Console.WriteLine("Grade Point Equivalent: 3.00");
            }
            else if (finTermGrade < 70 && finTermGrade > 0)
            {
                Console.WriteLine("Grade Point Equivalent: 5.00");
            }
            else if (finTermGrade == 0)
            {
                Console.WriteLine("Grade Point Equivalent: 0.00");
            }
            else
            {
                Console.WriteLine("Grade Point Equivalent: Invalid.");
            }

            Console.ReadKey();
        }
    }
}
