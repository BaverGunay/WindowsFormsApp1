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
    public partial class Form28 : Form
    {
        public Form28()
        {
            InitializeComponent();


            //metod();
            //metod(2,5);
            //bke("E", 180, 85);
            //MessageBox.Show(hesap().ToString());
            //MessageBox.Show(hesap(7).ToString());

            //int uzunlukdeger = 2;
            //int genislikdeger = 3;

            //MessageBox.Show("Çevre Hesabı: " + cevrehesaplama(1, uzunlukdeger, genislikdeger));
            //MessageBox.Show("Alan Hesabı: " + cevrehesaplama(2, uzunlukdeger, genislikdeger));

            //MessageBox.Show(faktoriyeltoplam(5).ToString());


            //MessageBox.Show(faktoriyelvetoplamhesaplama(5).ToString());
            MessageBox.Show(us_alma(3).ToString());



        }




        private void metod()// değer almayan değer döndürmeyen
        {
            int a = 5;
            int b = 6;
            int sonuc = a + b;


            MessageBox.Show("Sonuc : " + sonuc);
        }
        private void metod(int a , int b)//değer alan değer döndürmeyen
        {
            int sonuc = a + b;


            MessageBox.Show("Sonuc : " + sonuc);
        }
        private void bke(string cinsiyet, double boy, double kilo)//değer alan değer döndürmeyen
        {
            double endex = 0;
            switch (cinsiyet)
            {
                case "E":
                    endex = kilo / (boy * boy) * 10000;
                    if (endex < 18)
                    {                 
                        MessageBox.Show(" zayıf ");
                    }
                    else if (endex > 30)
                    {
                        MessageBox.Show(" Kilolu ");
                    }
                    else
                    {
                        MessageBox.Show(" Normal ");                     
                    }
                    break;
                case "K":
                    endex = kilo / (boy * boy) * 10000 * 0.9;
                    if (endex < 18)
                    {
                        MessageBox.Show(" zayıf ");
                    }
                    else if (endex > 30)
                    {
                        MessageBox.Show(" Kilolu ");
                    }
                    else
                    {
                        MessageBox.Show(" Normal ");
                    }
                    break;
            }
        }
        private int hesap()//değer almayan değer döndüren
        {
            int a = 5;
            int b = 6;
            int sonuc = a + b;

            return sonuc;
        }
        private int hesap(int c)//değer alan değer döndüren
        {
            int a = 5;
            int b = 6;
            int sonuc = a + b + c;

            return sonuc;
        }
        private int cevrehesaplama(int hesaptipi, int uzunluk, int genislik)
        {
            int sonuc = 0;
            if (hesaptipi == 1)
            {
                sonuc = 2 * (uzunluk +  genislik);
            }
            else if (hesaptipi == 2)
            {
                sonuc = uzunluk * genislik;
            }
            return sonuc;
        }


        private int faktoriyeltoplam(int fakt)
        {
            int sonuc1 = 0;
            for (int i = 1; i <= fakt; i++)
            {
                int donendeger = faktoriyelhesaplama(i);
                sonuc1 = donendeger + sonuc1;
            }

            return sonuc1;

        }
        private int faktoriyelhesaplama(int x)
        {

            int sonuc = 1;
            for (int i = 1; i <= x; i++)
            {
                sonuc = i * sonuc;
            }

            return sonuc;
        }
        private int toplambul(int x)
        {

            int sonuc = 0;
            for (int i = 1; i <= x; i++)
            {
                sonuc = i + sonuc;
            }

            return sonuc;
        } 
        private int faktoriyelvetoplamhesaplama(int x)
        {

            int sonuc = 0;
            for (int i = 1; i <= x; i++)
            {
                if (i%2==0)
                {
                    sonuc = sonuc + toplambul(i);
                }
                else
                {
                    sonuc = sonuc + faktoriyelhesaplama(i);
                }
            }

            return sonuc;
        }

        private int us_alma(int x)
        {
            int sonuc = 1;
            for (int i = 1; i <= x; i++)
            {
                sonuc = sonuc * x;
            }
            return sonuc;
        }

    }
}
