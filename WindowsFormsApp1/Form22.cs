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
    public partial class Form22 : Form
    {
        public Form22()
        {
            InitializeComponent();

            {
                Oyuncu ahmet = new Oyuncu();
                Oyuncu osman = new Oyuncu();
            }
            Oyuncu ayse = new Oyuncu();
            Oyuncu mehmet = new Oyuncu();



            MessageBox.Show(Oyuncu.Toplam.ToString());


        }
        class Oyuncu
        {

            public static int Toplam;
            //public  int Toplam;

            static Oyuncu()
            {
                MessageBox.Show("Oyun başladı");
            }
            public Oyuncu()
            {
                Toplam++;
                MessageBox.Show("Toplam oyuncu: " + Toplam);
            }
          



        }
    }
}
