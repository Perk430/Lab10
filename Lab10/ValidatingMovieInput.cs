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
    }
}
