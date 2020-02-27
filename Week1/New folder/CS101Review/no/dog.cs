using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace no
{
    class dog
    {
        public string breed;
        public string name;
        public int height;
        
        public void bark()
        {
            MessageBox.Show("bark");
        }
        public void sayname()
        {
            MessageBox.Show("my name is " + name + "I am a " + breed + " And I am " + height + " in.");
        }

    }
}
