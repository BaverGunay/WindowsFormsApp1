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
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
        }

        private void Form19_Load(object sender, EventArgs e)
        {
        YardimciSinif nesne = new YardimciSinif();
        nesne.SahteOzellik=-100;
        MessageBox.Show(nesne.SahteOzellik.ToString());
        }
        class YardimciSinif
        {
            int Sayi;
            public int SahteOzellik
            {
                get
                {
                    if (Sayi > 100)
                        return Sayi / 100;
                    else
                        return Sayi;
                }
                set
                {
                    if (value < 0)
                        Sayi = 0;
                    else
                        Sayi = value;
                }
              
            }
        }

    }
}
