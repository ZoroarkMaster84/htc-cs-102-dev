using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        ObservableCollection<Movie> Movies = new ObservableCollection<Movie>();
        public MainWindow()
        {
            InitializeComponent();
            lvMovies.ItemsSource = Movies;
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
            double rtscore = Convert.ToInt32(rtscoreInput.Text);

            if (Movies.Count == 0)
            {
                Movie movie = new Movie(title, releaseYear, director, length, genre, rtscore);
                Movies.Add(movie);
            }
            else
            {
                foreach (Movie film in Movies)
                {
                    if(film.Title == title )
                    {
                        MessageBox.Show("This movie already exists");
                    }
                    else
                    {
                        Movie movie = new Movie(title, releaseYear, director, length, genre, rtscore);
                        Movies.Add(movie);
                    }
                }
            }
            
        }

        private void lvMovies_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Movie selectMovie = lvMovies.SelectedItem as Movie;
            if(selectMovie != null)
            {
                selectMovie.ShowDetails();
            }
        }
    }
}
