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


            Movie[] MArray = new Movie[21]; // an array of objects,in this case, our movie titles and catagories

            MArray[0] = new Movie("Star Wars", "Sci Fi");
            MArray[1] = new Movie("Big Hero 6", "Animated");
            MArray[2] = new Movie("Lego Batman", "Animated");
            MArray[3] = new Movie("A Few Good Men", "Drama");
            MArray[4] = new Movie("Nightmare on Elm Street", "Horror");
            MArray[5] = new Movie("Smurfs", "Animated");
            MArray[6] = new Movie("Fences", "Drama");
            MArray[7] = new Movie("The Excorcist", "Horror");
            MArray[8] = new Movie("Hidden Figures", "Drama");
            MArray[9] = new Movie("Boss Baby", "Animated");
            MArray[10] = new Movie("Kong", "Sci Fi");
            MArray[11] = new Movie("Spongebob Squarepants", "Animated");
            MArray[12] = new Movie("Friday", "Comedy");
            MArray[13] = new Movie("The Twilight Zone", "Sci Fi");
            MArray[14] = new Movie("Next Friday", "Comedy");
            MArray[15] = new Movie("The Shining", "Horror");
            MArray[16] = new Movie("12 Angry Men", "Drama");
            MArray[17] = new Movie("The Hangover", "Comedy");
            MArray[18] = new Movie("Halloween", "Horror");
            MArray[19] = new Movie("Get Out", "Horror");
            MArray[20] = new Movie("Transformers", "Sci Fi");


            //Adding a welcome and list of catagories from which to choose for the user.
            Console.WriteLine("Welcome to the Movie Library! \n");
            Console.WriteLine("Our catagories are: Animated, Comedy, Drama, Horror and Sci Fi. \n\n");//Added a new category; Drama.

            do
            {
                Console.WriteLine("Please enter a category: \n");

                //Reading the user input (which is of a string type)

                string CategoryInput = Console.ReadLine();

                Console.WriteLine("\nThe movies we have in that category are:");//Added information to make display a little better
                Console.WriteLine("===========================================");

                foreach (Movie temp in MArray)
                {
                    if (CategoryInput.ToLower() == temp.Category1.ToLower())// matching the category and movie titles 
                        Console.WriteLine(temp.Title1);
                }

                run = ValidatingMovieInput.Continue();//Calling method asking user if he/she wants to continue

            } while (run == true);
        }
     }
}
