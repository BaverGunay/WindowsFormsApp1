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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty
           || textBox2.Text == string.Empty)
            {
                MessageBox.Show("boşlukları dolduralım");
                return;
            }

            try
            {
                Convert.ToInt32(textBox1.Text);
                Convert.ToInt32(textBox2.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("sayısal ifade giriniz");
                return;
            }

            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            int toplam = sayi1 + sayi2;
            label1.Text = toplam.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty
               || textBox2.Text == string.Empty)
            {
                MessageBox.Show("boşlukları dolduralım");
                return;
            }

            try
            {
                Convert.ToInt32(textBox1.Text);
                Convert.ToInt32(textBox2.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("sayısal ifade giriniz");
                return;
            }

            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            int toplam = sayi1 - sayi2;
            label1.Text = toplam.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty
              || textBox2.Text == string.Empty)
            {
                MessageBox.Show("boşlukları dolduralım");
                return;
            }

            try
            {
                Convert.ToInt32(textBox1.Text);
                Convert.ToInt32(textBox2.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("sayısal ifade giriniz");
                return;
            }

            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);

            if (sayi2 ==0)
            {
                MessageBox.Show("0 a bölme yapılamaz");
                return;
            }

            int toplam = sayi1 / sayi2;
            label1.Text = toplam.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty
            || textBox2.Text == string.Empty)
            {
                MessageBox.Show("boşlukları dolduralım");
                return;
            }

            try
            {
                Convert.ToInt32(textBox1.Text);
                Convert.ToInt32(textBox2.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("sayısal ifade giriniz");
                return;
            }

            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            int toplam = sayi1 * sayi2;
            label1.Text = toplam.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == string.Empty)
            {
                MessageBox.Show("boşlukları dolduralım");
                return;
            }

            try
            {
                Convert.ToInt32(textBox3.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("sayısal ifade giriniz");
                return;
            }

            int sayi = Convert.ToInt32(textBox3.Text);
            int carpim = 1;

            for (int i = 1; i <= sayi; i++)
            {
                carpim *= i;
            }

            label1.Text = carpim.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == string.Empty)
            {
                MessageBox.Show("boşlukları dolduralım");
                return;
            }

            try
            {
                Convert.ToInt32(textBox3.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("sayısal ifade giriniz");
                return;
            }

            int sayi = Convert.ToInt32(textBox3.Text);
            int sonuc = sayi * sayi;
            label1.Text = sonuc.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == string.Empty)
            {
                MessageBox.Show("boşlukları dolduralım");
                return;
            }

            try
            {
                Convert.ToInt32(textBox3.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("sayısal ifade giriniz");
                return;
            }

            int sayi = Convert.ToInt32(textBox3.Text);

            int sayac = 0;
            for (int i = 0; i <= sayi; i++)
            {
                sayac = sayac + i;
            }

            label1.Text = sayac.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty
    || textBox2.Text == string.Empty)
            {
                MessageBox.Show("boşlukları dolduralım");
                return;
            }

            try
            {
                Convert.ToInt32(textBox1.Text);
                Convert.ToInt32(textBox2.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("sayısal ifade giriniz");
                return;
            }

            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);

            int carpım = 1;


            for (int i = sayi1; i <= sayi2; i++)
            {
                carpım = carpım * i;
            }

            label1.Text = carpım.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty
   || textBox2.Text == string.Empty)
            {
                MessageBox.Show("boşlukları dolduralım");
                return;
            }

            try
            {
                Convert.ToInt32(textBox1.Text);
                Convert.ToInt32(textBox2.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("sayısal ifade giriniz");
                return;
            }

            int sayi1 = Convert.ToInt32(textBox1.Text);
            int us = Convert.ToInt32(textBox2.Text);

            int carpim = 1;

            for (int i = 1; i <= us; i++)
            {
                carpim = carpim * sayi1;
            }

            label1.Text = carpim.ToString();
        }
    }
}
