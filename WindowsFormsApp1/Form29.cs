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
    public partial class Form29 : Form
    {
        public Form29()
        {
            InitializeComponent();
        }
        bool durum = false;
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Sistem Açıldı. Hoşgeldiniz.";
            label1.ForeColor = Color.Green;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Sistem Kapandı. Güle Güle.";
            label1.ForeColor = Color.Red;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            durum = !durum;
            if (durum == true)
            {
                label1.Text = "Sistem Açıldı";
                label2.Text = "Sistemi Kapat";
            }
            else
            {
                label1.Text = "Sistem Kapandı";
                label2.Text = "Sistemi Aç";
            }

        }
    }
}
