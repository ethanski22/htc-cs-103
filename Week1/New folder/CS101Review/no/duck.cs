using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace no
{
    class duck
    {
        public string name;
        public int age;
        public int attackdmg;

        public void honk()
        {
            age = 21;
            name = "hornky";
            MessageBox.Show(duck.name + " hornks\n" + duck.name + " is very hornky");
        }
        public void hankack()
        {
            attackdmg = 69;
            MessageBox.Show("i hankack you for " + duck.attackdmg + "damage");
        }
    }
}
