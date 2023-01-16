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
    public partial class Form20 : Form
    {
        public Form20()
        {
            InitializeComponent();
        }

        private void Form20_Load(object sender, EventArgs e)
        {
            YardimciSinif nesne = new YardimciSinif();
            MessageBox.Show(nesne.Dizi[0].ToString());
            MessageBox.Show(nesne.Metot()[2].ToString());

        }

        class YardimciSinif
        {
            public int[] Dizi = { 7, 4, 3 };
            public int[] Metot()
            {
                int[] a = { 23, 45, 67 };
                return a;
            }
        }

    }
}
