using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class ValidatingMovieInput
    {
        public static string GetValidInput()
        {
            while (true)
            {
                string input = Console.ReadLine().ToLower();
                if (input == "animated")
                    return input;
                else if (input == "drama")
                    return input;
                else if (input == "horror")
                    return input;
                else if (input == "scifi")
                    return input;

            }
        }

       public static bool Continue()
        { 
            string conf;
            bool check = true;
            bool run = true;

            Console.WriteLine("\n=============================");
            Console.WriteLine("\nWould you like to search again?");
            Console.Write("\nPlease Enter (y/n): ");

            do
            {
                conf = Console.ReadLine();
                var t = conf.ToLower();

                if (t != "y" || t != "n")
                {
                    Console.Write("\nPlease Enter (y/n): ");
                }
                if (t == "y")
                {
                    Console.Clear();
                    check = false;
                }

                if (t == "n")
                {
                    Console.Clear();
                    Console.WriteLine("Thank you for visiting!");

                    run = false;
                    check = false;
                }
            } while (check == true);

            return run;
        }
    }
    }

