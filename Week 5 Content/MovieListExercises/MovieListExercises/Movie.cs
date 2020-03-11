using System;
using System.Windows;

namespace MovieList
{
    public class Movie
    {
        public string Title
        {
            get;
            set;
        }

        public DateTime ReleaseYear
        {
            get;
            set;
        }
        public string genre
        {
            get;
            set;
        }
        public void ShowDetails()
        {
            string infoString = "Title: " + this.Title;
            infoString += "\nRelease Year: " + this.ReleaseYear;
            MessageBox.Show(infoString);
        }

        public Movie(string myTitle, DateTime myReleaseYear, string mygenre)
        {
            this.Title = myTitle;
            this.genre = mygenre;
            
        }
    }
}
