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
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public string Director { get; set; }
        public double Length { get; set; }
        public string Genre { get; set; }
        public double RTScore { get; set; }

        public Movie(string title, int releaseYear, string director, double length, string genre, double rtscore)
        {
            Title = title;
            ReleaseYear = releaseYear;
            Director = director;
            Length = length;
            Genre = genre;
            RTScore = rtscore;
        }

        public void ShowDetails()
        {
            MessageBox.Show($"{Title} was released in {ReleaseYear} by {Director}. \r\n {Title} is a {Genre} that lasts {Length} hours.");
        }
    }
}
