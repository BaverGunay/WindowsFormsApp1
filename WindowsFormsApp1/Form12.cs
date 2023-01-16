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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {

            Tasit otomobil = new Tasit();
            // nesnemize özellik değerlerini giriyoruz
            otomobil.hiz = 220;
            otomobil.yakit = "LPG";
            otomobil.renk = "Siyah";
            otomobil.marka = "Renault";

            otomobil.tasitInfo();

        }


        public class Tasit
        {
            public String yakit;// Taşıtın yakıt tipi
            public int hiz; // Taşıtın Maximum hızı
            public String renk; // Taşıtın rengi
            public String marka; // Taşıtın markası


            public void tasitInfo()
            {
                String tasit =
                    " Taşıtın markası: " +marka + 
                    " rengi: " +renk + 
                    " yakıt tipi: " +yakit + 
                    " maximum hızı: " +hiz;
 
                MessageBox.Show(tasit);
            }

        }

    }
}
