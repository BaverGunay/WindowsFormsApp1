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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            //string ad1 = "ozden";
            //string soyad1 = "kayaakar";
            //string cinsiyet1 = "E";
            //int yas1 = 44;


            //string ad2 = "ersin";
            //string soyad2 = "kayaakar";
            //string cinsiyet2 = "E";
            //int yas2 = 42;

            kisi kisi1 = new kisi();

            kisi1.ad = "ozden";
            kisi1.soyad = "kayaakar";
            kisi1.cinsiyet = "E";
            kisi1.yas = 44;

            kisi kisi2 = kisi1;

            //kisi2.ad = "ersin";
            //kisi2.soyad = "kayaakar";
            //kisi2.cinsiyet = "E";
            //kisi2.yas = 42;

            MessageBox.Show(kisi2.ad);
        }

        class kisi
        {
            public string ad { get; set; }
            public string soyad { get; set; }
            public string cinsiyet { get; set; }
            public int yas { get; set; }

        }
    }
}
