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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            Ogrenci ogr1 = new Ogrenci();
            // Nesne içerisindeki public özelliklere değer atadık. 
            ogr1.AdSoyad = "Serdar Yılmaz";
            ogr1.Numara = 134;
            ogr1.Sinif = 4;
            // Nesne içerisindeki Bilgi() metodunu çağırarak atamış olduğumuz değerleri ekrana yazdırdık.
            ogr1.Ogrenciinfo();

        }

        class Ogrenci
        {
            // Özelliklere diğer sınıflardan erişebiliriz. (Public)
            public string AdSoyad;
            public int Numara;
            public int Sinif;
            // Bilgi() metoduna diğer sınıflardan erişebiliriz. (Public)
            public void Ogrenciinfo()
            {
                MessageBox.Show(Numara+" " +AdSoyad + " " + Sinif);
            }
        }


    }
}
