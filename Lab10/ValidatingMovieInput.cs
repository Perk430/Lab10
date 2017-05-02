using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class ValidatingMovieInput
    {
        public static string GetValidInput() // Checking the validity of the input
        {
            while (true)
            {
                string input = Console.ReadLine().ToLower();// Forcing code to accept user input if entered in caps or lowercase.
                if (input == "animated")
                    return input;
                else if (input == "comedy")//Added extra category to list (May 1, 2017)
                    return input;
                else if (input == "drama")
                    return input;
                else if (input == "horror")
                    return input;
                else if (input == "scifi")
                    return input;

            }
        }



       public static bool Continue() //Method asking if user wants to continue.
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

                if (t != "y" || t != "n") //Validating that the user actually entered a "y" for yes and an "n" for no.
                {
                    Console.Write("\nPlease Enter (y/n): ");
                }
                if (t == "y")
                {
                    Console.Clear();// Clears the console and starts over asking user to enter a category.
                    check = false;
                }

                if (t == "n")
                {
                    Console.Clear();// Clears the console and thanks the user, ending the program.
                    Console.WriteLine("Thank you for visiting!");

                    run = false;//ensuring that program does not run again
                    check = false;// Command that tells the program to exit the "do" loop.
                }
            } while (check == true);

            return run;
        }
    }
 }

