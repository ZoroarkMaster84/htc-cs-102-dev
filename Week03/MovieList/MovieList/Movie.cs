using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MovieList
{
    public class Movie
    {
        public string Title;
        public int ReleaseYear;

        public Movie(string title, int releaseYear)
        {
            Title = title;
            ReleaseYear = releaseYear;
        }

        public void ShowDetails()
        {
            MessageBox.Show(Title + " was released in " + ReleaseYear);
        }
    }
}
