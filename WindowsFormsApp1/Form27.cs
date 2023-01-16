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
    public partial class Form27 : Form
    {
        public Form27()
        {
            InitializeComponent();


   hayvanlar hayvan = new hayvanlar();

            MessageBox.Show("");


        }

        class canlı
        {
            protected string tur;
            public int cins;
            public string renk;
            public string solunum_tur;

            public canlı()
            {

            }

        }
        class hayvanlar : canlı
        {
            public string ayak;

            public hayvanlar()
            {
                MessageBox.Show("hayvanlar YAPICI METOD");
            }
        }
        class bitkiler : canlı
        {
            public string yaprak;
        }

        class köpekler : hayvanlar
        {
            public void Havla()
            {
                MessageBox.Show("HAVLAMA");
            }
        }
    }
}
