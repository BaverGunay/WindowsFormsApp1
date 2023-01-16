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
    public partial class Form23 : Form
    {
        public Form23()
        {
            InitializeComponent();

            var Bilgi = new Deneme("erhan", "kaya");
            var info = new Deneme("ınfo", "kaya");
            MessageBox.Show(Bilgi.ToString());
         
        }

        class Deneme
        {
            public static string ad;
            public static string soyad;
 
            public Deneme(string _ad, string _soyad)
            {
                ad = _ad;
                soyad = _soyad;
            }
            public override string ToString()
            {
                return ad + soyad;
            }

        }


    }
}
