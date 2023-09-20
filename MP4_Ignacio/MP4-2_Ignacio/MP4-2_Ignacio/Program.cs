using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP4_2_Ignacio
{
    class Program
    {
        static void Main(string[] args)
        {
            String name;
            int score = 0;
            char a1, a2, a3, a4, a5, seeScore;

            Console.WriteLine("-- SIMPLE QUIZ--");

            Console.Write("Enter name: ");
            name = Console.ReadLine();

            Console.WriteLine("Type the letter with your corresponding answer.");
            Console.WriteLine("QUESTION #1: What is 5+10?: ");
            Console.WriteLine("a) 15\n" +
                "b) 50\n" +
                "c) 5\n" +
                "d) 20");
            Console.Write("ANSWER: ");
            a1 = Char.Parse(Console.ReadLine());
            if (a1 == 'a')
            {
                score++;
            }


            Console.WriteLine("\nQUESTION #2: What is the square root of 49?: ");
            Console.WriteLine("a) 4\n" +
               "b) 7\n" +
               "c) 5\n" +
               "d) 6");
            Console.Write("ANSWER: ");
            a2 = Char.Parse(Console.ReadLine());
            if (a2 == 'b')
            {
                score++;
            }

            Console.WriteLine("\nQUESTION #3: What is 5x2-1?");
            Console.WriteLine("a) 5\n" +
               "b) 8\n" +
               "c) 9\n" +
               "d) 3");
            Console.Write("ANSWER: ");
            a3 = Char.Parse(Console.ReadLine());
            if (a3 == 'c')
            {
                score++;
            }

            Console.WriteLine("\nQUESTION #4: If x = 3, evaluate 5x: ");
            Console.WriteLine("a) 15\n" +
               "b) 150\n" +
               "c) 8\n" +
               "d) 50");
            Console.Write("\nANSWER: ");
            a4 = Char.Parse(Console.ReadLine());
            if (a4 == 'a')
            {
                score++;
            }

            Console.WriteLine("\nQUESTION #5: What is the proper order of operation?: ");
            Console.WriteLine("a) MDAS\n" +
               "b) EMDAS\n" +
               "c) SADMEP\n" +
               "d) PEMDAS");
            Console.Write("ANSWER: ");
            a5 = Char.Parse(Console.ReadLine());
            if (a5 == 'd')
            {
                score++;
            }

            Console.WriteLine();

            Console.Write("You finished the quiz! Would you like to see your scores? [Y/N]: ");
            seeScore = Char.Parse(Console.ReadLine());

            if (seeScore == 'Y' || seeScore == 'y')
            {
                Console.WriteLine("NAME: " + name);
                Console.WriteLine("SCORE: " + score);
                if (score == 5)
                {
                    Console.WriteLine("Congrats, you got a perfect score, " + name + "!");
                }
                else Console.WriteLine("Thanks for playing.");
            }
            else if (seeScore == 'N' || seeScore == 'n')
            {
                Console.WriteLine("Thank you for playing the game!");
            }


            Console.ReadKey();
            
        }
    }
}
