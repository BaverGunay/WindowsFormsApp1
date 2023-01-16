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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }

        private void Form18_Load(object sender, EventArgs e)
        {
            YardimciSinif nesne = new YardimciSinif();          
            nesne.SayiBelirle(34);
            MessageBox.Show(nesne.SayiAl().ToString());

        }



        class YardimciSinif
        {
            int Sayi;
            public void SayiBelirle(int sayi)
            {
                Sayi = sayi;
            }
            public int SayiAl()
            {
                return Sayi;
            }
        }

    }
}
