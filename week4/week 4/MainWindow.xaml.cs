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

namespace week_4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<movies> movielist;
        public MainWindow()
        {
            InitializeComponent();
            movielist = new List<movies>();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void show_Click(object sender, RoutedEventArgs e)
        {
            foreach (movies movie in movielist)
            {
                movie.ShowDetails();            }
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            movies movie = new movies(titleinput.Text, Convert.ToInt32(releaseyearinput.Text));
            movielist.Add(movie);
            titleinput.Clear();
            releaseyearinput.Clear();
            MessageBox.Show("successfully added");
        }
    }
}
