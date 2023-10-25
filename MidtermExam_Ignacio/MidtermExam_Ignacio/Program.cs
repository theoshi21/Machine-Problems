using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermExam_Ignacio
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] accs = {{"Kelvin", "101010","25000"}, {"Dann", "202020","10000"}, {"Shan", "303030","10000"}, {"Kym", "404040","10000"}, {"Josh", "505050","10000"}};
            bool Program = true;
            while (Program)
            {
                Console.WriteLine("ATM Program");
                Console.Write("Account: ");
                string user = Console.ReadLine();
                Console.Write("Enter Pin: ");
                int pass = int.Parse(Console.ReadLine());

                for (int i = 0; i < 5; i++)
                {
                    if (user == accs[i, 0])
                    {
                        if (Convert.ToString(pass) == accs[i, 1])
                        {
                            Console.WriteLine("\nYou're logged in! What do you want to perform?\n" + "[1] Deposit\n" + "[2] Withdraw\n" + "[3] Check balance");
                            Console.Write("ACTION: ");
                            int action = int.Parse(Console.ReadLine());
                            double money = Convert.ToDouble(accs[i, 2]);
                            switch (action)
                            {
                                case 1:
                                    Console.Write("How much would you like to deposit?: ");
                                    double deposit = double.Parse(Console.ReadLine());
                                    money += deposit;
                                    accs[i, 2] = Convert.ToString(money);
                                    Console.WriteLine($"Your BALANCE now is {accs[i,2]}.");
                                    break;
                                case 2:
                                    Console.Write("How much would you like to withdraw?: ");
                                    double withdraw = double.Parse(Console.ReadLine());
                                    Convert.ToDouble(accs[i,2]);
                                    if (withdraw <= 20000)
                                    {
                                        if (withdraw <= money)
                                        {
                                            money -= withdraw;
                                            accs[i, 2] = Convert.ToString(money);
                                            Console.WriteLine($"Your BALANCE now is {accs[i, 2]}.");
                                        }
                                        else Console.WriteLine($"You do not have enough amount. You only have {money}.");
                                    }
                                    else Console.WriteLine("Can't withdraw. The limit is only 20,000.");
                                    break;
                                case 3:
                                    Console.WriteLine($"{accs[i, 0]}, your current balance is {accs[i,2]}.");
                                    break;
                                default:
                                    Console.WriteLine("Invalid action.");
                                    break;
                            }
                            i = 5;
                        }
                    }
                    else if (user != accs[i, 0] && i == 4) Console.WriteLine("\nInvalid credentials.");
                }
                Console.Write("\nEnter 'N' to stop. Else, press anything to continue: ");
                string cont = Console.ReadLine();
                if (cont.ToLower() == "n") Program = false;
                else Console.Clear();
            }
        }
    }
}

