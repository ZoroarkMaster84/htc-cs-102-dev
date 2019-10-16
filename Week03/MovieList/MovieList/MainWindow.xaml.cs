using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MovieList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Movie> Movies = new List<Movie>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ShowButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (Movie movie in Movies)
            {
                movie.ShowDetails();
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            string title = titleInput.Text;
            int releaseYear = Convert.ToInt32(releaseYearInput.Text);
            string director = directorInput.Text;
            double length = Convert.ToInt32(lengthInput.Text);
            string genre = genreInput.Text;

            Movie movie = new Movie(title, releaseYear, director, length, genre);
            Movies.Add(movie);
        }
    }
}
