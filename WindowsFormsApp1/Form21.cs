using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form21 : Form
    {
        public Form21()
        {
            InitializeComponent();

            Deneme a = new Deneme(2, 5, 6); ;
        }


        class Deneme
        {
            public Deneme(int a, int b, int c)
            {
                MessageBox.Show((a+b+c).ToString());

            }



        }

    }
}
