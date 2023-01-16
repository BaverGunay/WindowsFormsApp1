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
    public partial class Form26 : Form
    {
        public Form26()
        {
            InitializeComponent();

            HesapMakinesi hesap = new HesapMakinesi();
            hesap.sayi1 = 10;
            hesap.sayi2 = 10;
            hesap.oprt = "&";
            double sonuc = hesap.hesapla();
            MessageBox.Show(sonuc.ToString());

        }
        class HesapMakinesi
        {
            public double sayi1 { get; set; }
            public double sayi2 { get; set; }
            public string oprt { get; set; }

            public double hesapla()
            {
                double sonuc = 0;
                switch (oprt)
                {
                    case "+":
                        sonuc = sayi1 + sayi2;
                        break;
                    case "-":
                        sonuc = sayi1 - sayi2;
                        break;
                    case "*":
                        sonuc = sayi1 * sayi2;
                        break;
                    case "/":
                        sonuc = sayi1 / sayi2;
                        break;
                }
                return sonuc;
            }
        }

    }
}
