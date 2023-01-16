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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void Form16_Load(object sender, EventArgs e)
        {
            Dortgen d1 = new Dortgen();
            //d1.En = 20;
            //d1.Boy = 50;
            d1.EnBoyBelirle(20, 50);
            d1.Yaz();
            Dortgen d2 = new Dortgen();
            d2.Yaz();
            d2.EnBoyBelirle(25, 12);
           

        }


        class Dortgen
        {
            public int En;
            public int Boy;
            public int Alan()
            {
                int Alan = En * Boy;
                return Alan;
            }
            public void EnBoyBelirle(int en, int boy)
            {
                En = en;
                Boy = boy;
            }

            public void Yaz()
            {
                MessageBox.Show(En.ToString());
                MessageBox.Show(Boy.ToString());
                MessageBox.Show(Alan().ToString());
            }
        }

    }
}
