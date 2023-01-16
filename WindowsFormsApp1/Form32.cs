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
    public partial class Form32 : Form
    {
        public Form32()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult giriskontrol = MessageBox.Show("Giriş Yapılsın mı?", "Giriş Sistemi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            //DialogResult ile messageboxtan gelen buton değerlerini yakalayıp tutuyoruz
            //if kontrolünde ise basılan butonların kontrolleri yapılmakta
            if (giriskontrol == DialogResult.Yes)
            {
                MessageBox.Show("Giriş Başarılı");//çıkacak sonuç
            }
            else
            {
                MessageBox.Show("İşlem iptal edildi");
            }


        }
    }
}
