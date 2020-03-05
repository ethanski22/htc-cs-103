using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace week_4
{
    class movies
    {
        public string title { get; set; }
        public int releaseyear { get; set; }
        
        public movies (string mytitle, int myreleaseyear)
        {
            this.title = mytitle;
            this.releaseyear = myreleaseyear;
        }
        public void ShowDetails()
        {
            string info = "title: " + this.title;
            info += ("\nrelease year: " + this.releaseyear);
            MessageBox.Show(info);

        }
    }
}
