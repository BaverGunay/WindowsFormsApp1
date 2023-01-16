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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            SinifIsmi nesne = new SinifIsmi();

            //MessageBox.Show(nesne.ozellik1.ToString());
            //MessageBox.Show(nesne.ozellik2);
            //MessageBox.Show(nesne.ozellik3.ToString());
            MessageBox.Show(nesne.metot1(2, 5).ToString());
            nesne.metot2("Vikikitap");

        }

        class SinifIsmi
        {
            //public int ozellik1;
            //public string ozellik2;
            //public float ozellik3;
            public int metot1(int a, int b)
            {
                return a + b;
            }
            public void metot2(string a)
            {
                MessageBox.Show(a);
            }
        }

    }
}
