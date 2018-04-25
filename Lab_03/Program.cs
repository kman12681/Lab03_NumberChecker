using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Hello! What is your name? ");
            string userName = Console.ReadLine();
            Console.WriteLine($"\nHi, {userName}. Let's check if a number is odd or even.");

            string input = "";

            while (true)

            {

                while (true)
                {
                    Console.Write("\nEnter a whole number between 1 and 100: ");
                    input = (Console.ReadLine());

                    if (!int.TryParse(input, out int digit))
                    {
                        Console.WriteLine("\nHey silly, that wasn't a whole number.");
                        continue;
                    }

                    else if (Convert.ToInt32(input) > 100 || Convert.ToInt32(input) < 1)
                    {
                        Console.WriteLine("\nThat number was not in the bounds, please try again.");
                        continue;
                    }
                    break;
                }

                bool success = int.TryParse(input, out int num);

                if (success)

                {

                    if (num % 2 == 1)
                    {
                        Console.WriteLine($"\n{num}, Odd");
                    }
                    else if (num % 2 == 0 && num > 60)
                    {
                        Console.WriteLine($"\n{num}, Even");
                    }
                    else if (num % 2 == 0 && num >= 26 && num <= 60)
                    {
                        Console.WriteLine("\nEven");
                    }
                    else //(num % 2 == 0 && num >= 2 && num <= 25)
                    {
                        Console.WriteLine($"\nEven and less than 25");
                    }

                    // else clause is unnecessary because one of the above conditions will be met.

                }

                string response = DoAgain();
                if (response == "N")
                    break;

            }
            Console.WriteLine($"\nThanks, {userName}. Have a great day!");
            Console.ReadKey();

        }

        static string DoAgain()

        {
            while (true) // will run program again if user enters "Y" (or "y"), will exit if "N" (or "n")

            {

                Console.Write("\nDo you want to try again? (Y or N) ");
                string input = Console.ReadLine().ToUpper();

                if (input == "Y" || input == "N")
                    return input;

                else

                {
                    Console.WriteLine("\nNot a valid entry.");
                }

            }
        }

    }
}




