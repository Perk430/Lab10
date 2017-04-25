using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {

            bool run = true;


            Movie[] MArray = new Movie[10]; // an array of objects

            MArray[0] = new Movie("Star Wars", "Sci Fi");
            MArray[1] = new Movie("Big Hero 6", "Animated");
            MArray[2] = new Movie("Leg Batman", "Animated");
            MArray[3] = new Movie("A Few Good Men", "Drama");
            MArray[4] = new Movie("Nightmare on Elm Street", "Horror");
            MArray[5] = new Movie("Smurfs", "Animated");
            MArray[6] = new Movie("Fences", "Drama");
            MArray[7] = new Movie("The Excorcist", "Horror");
            MArray[8] = new Movie("Hidden Figures", "Drama");
            MArray[9] = new Movie("Boss Baby", "Animated");

            do
            {
                Console.WriteLine("Please enter a category: \n");

                //Validating user input

                string CategoryInput = Console.ReadLine();

                foreach (Movie temp in MArray)
                {
                    if (CategoryInput.ToLower() == temp.Category1.ToLower())// match 
                        Console.WriteLine(temp.Title1);
                }

                run = ValidatingMovieInput.Continue();//Calling method asking user if he/she wants to continue

            } while (run == true);
        }
     }
}
