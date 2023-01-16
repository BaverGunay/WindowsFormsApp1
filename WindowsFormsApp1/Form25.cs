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
    public partial class Form25 : Form
    {
        public Form25()
        {
            InitializeComponent();

            ogrenci ogrenci1 = new ogrenci(58);
            ogrenci1.Ad = "Bulut";
            
          
            ogrenci ogrenci2 = new ogrenci(73);
            ogrenci2.Ad = "Ali";
           
           
            ogrenci ogrenci3 = new ogrenci(92);
            ogrenci3.Ad = "Ahmet";
            

            ogrenci1.getir();
            ogrenci2.getir();
            ogrenci3.getir();
        }

        class ogrenci
        {
            public ogrenci(int _not)
            {
                Sayac++;
                ToplamNot += _not;
                Not = _not;
            }
            private static int Sayac;
            private static double ToplamNot;
            public string Ad;
            public int Not;
            private double Ort;
            public void getir()
            {              
                Ort = ToplamNot / Sayac;

                if (Sayac > 1)
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

MessageBox.Show(Ad + " Öğrenci Sayısı: " + 
    Sayac + " Ort: " + Ort+" "+mesaj );
                }
            }

        }
    }
}
