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
    public partial class Form24 : Form
    {
        public Form24()
        {
            InitializeComponent();

            ogrenci ogr1 = new ogrenci();
            ogr1.Ad = "ALİ";
            ogr1.Not  = 20;
            ogr1.getir();

        }

        class ogrenci
        {
            public static int Ort;
            public string Ad;
            public int Not;
            public ogrenci()
            {
                Ort=50;
            }
            public void getir()
            {
                string mesaj = string.Empty;

                if (Not > Ort)
                {
                    mesaj = " ortalamanın üstünde";
                }
                else
                {
                    mesaj = " ortalamanın altında";
                }

             MessageBox.Show(Ad +  " "+ mesaj);
            }

        }
    }
}
