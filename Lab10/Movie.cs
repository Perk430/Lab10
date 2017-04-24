using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Movie
    {
        private string Title;
        private string Category;

        public string Title1
        {
            get
            {
                return Title;
            }
            set
            {
                Title = value;
            }

        }

        public string Category1
        {
            get
            {
                return Category;
            }
            set
            {
                Category = value;
            }
        }

        public Movie()
        {
            Title = "";
            Category = "";
        }

        public Movie(string TitleInput, string CategoryInput)
        {
            //this refers to the global variable in the class
            Title = TitleInput;
            Category = CategoryInput;
        }
    }
}
