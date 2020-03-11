﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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
        private ObservableCollection<Movie> MovieList;

        public MainWindow()
        {
            InitializeComponent();

            MovieList = new ObservableCollection<Movie>();
            lvMovies.ItemsSource = MovieList;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Movie movieToAdd = new Movie(titleInput.Text, date.DisplayDate, genre.Text);

            MovieList.Add(movieToAdd);

            titleInput.Clear();
            genre.Clear();
            date.SelectedDate = null;
        }

        private void ShowButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (Movie m in MovieList)
            {
                m.ShowDetails();
            }
        }

        private void lvMovies_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Movie selectedMovie = lvMovies.SelectedItem as Movie;
            if (selectedMovie != null)
            {
                selectedMovie.ShowDetails();
            }
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter writer = new StreamWriter("../../TextFile1.txt");
            writer.Write(titleInput.Text + date.DisplayDate + genre.Text);
            writer.Dispose();
        }
    }
}
