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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty
      || textBox2.Text == string.Empty
       || textBox3.Text == string.Empty
        || textBox4.Text == string.Empty
         || textBox5.Text == string.Empty)
            {
                MessageBox.Show("boşlukları dolduralım");
                return;
            }

            try
            {
                Convert.ToInt32(textBox1.Text);
                Convert.ToInt32(textBox2.Text);
                Convert.ToInt32(textBox3.Text);
                Convert.ToInt32(textBox4.Text);
                Convert.ToInt32(textBox5.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("sayısal ifade giriniz");
                return;
            }

            int[] dizi = new int[5];
            dizi[0] = Convert.ToInt32(textBox1.Text);
            dizi[1] = Convert.ToInt32(textBox2.Text);
            dizi[2] = Convert.ToInt32(textBox3.Text);
            dizi[3] = Convert.ToInt32(textBox4.Text);
            dizi[4] = Convert.ToInt32(textBox5.Text);
            label1.Text = "pozitif ";
            label2.Text = "negatif ";

            foreach (var item in dizi)
            {
                if (item > 0)
                {
                    label1.Text = label1.Text +" "+item.ToString();
                }
                else
                {
                    label2.Text = label2.Text + " " + item.ToString();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty
     || textBox2.Text == string.Empty
      || textBox3.Text == string.Empty
       || textBox4.Text == string.Empty
        || textBox5.Text == string.Empty)
            {
                MessageBox.Show("boşlukları dolduralım");
                return;
            }

            try
            {
                Convert.ToInt32(textBox1.Text);
                Convert.ToInt32(textBox2.Text);
                Convert.ToInt32(textBox3.Text);
                Convert.ToInt32(textBox4.Text);
                Convert.ToInt32(textBox5.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("sayısal ifade giriniz");
                return;
            }

            int[] dizi = new int[5];
            dizi[0] = Convert.ToInt32(textBox1.Text);
            dizi[1] = Convert.ToInt32(textBox2.Text);
            dizi[2] = Convert.ToInt32(textBox3.Text);
            dizi[3] = Convert.ToInt32(textBox4.Text);
            dizi[4] = Convert.ToInt32(textBox5.Text);

            label1.Text = "çift ";
            label2.Text = "tek ";

            foreach (var item in dizi)
            {
                if (item % 2 == 0)
                {
                    label1.Text = label1.Text + " " + item.ToString();
                }
                else
                {
                    label2.Text = label2.Text + " " + item.ToString();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty
    || textBox2.Text == string.Empty
     || textBox3.Text == string.Empty
      || textBox4.Text == string.Empty
       || textBox5.Text == string.Empty)
            {
                MessageBox.Show("boşlukları dolduralım");
                return;
            }

            try
            {
                Convert.ToInt32(textBox1.Text);
                Convert.ToInt32(textBox2.Text);
                Convert.ToInt32(textBox3.Text);
                Convert.ToInt32(textBox4.Text);
                Convert.ToInt32(textBox5.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("sayısal ifade giriniz");
                return;
            }

            int[] dizi = new int[5];
            dizi[0] = Convert.ToInt32(textBox1.Text);
            dizi[1] = Convert.ToInt32(textBox2.Text);
            dizi[2] = Convert.ToInt32(textBox3.Text);
            dizi[3] = Convert.ToInt32(textBox4.Text);
            dizi[4] = Convert.ToInt32(textBox5.Text);

            int pozitifsay = 0;
            int negatifsay = 0;

            foreach (var item in dizi)
            {
                if (item > 0)
                {
                    pozitifsay++;

                }
                else
                {
                    negatifsay++;
                }

            }

            label1.Text = "pozitif adet "+ pozitifsay;
            label2.Text = "negatif adet " + negatifsay;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty
   || textBox2.Text == string.Empty
    || textBox3.Text == string.Empty
     || textBox4.Text == string.Empty
      || textBox5.Text == string.Empty)
            {
                MessageBox.Show("boşlukları dolduralım");
                return;
            }

            try
            {
                Convert.ToInt32(textBox1.Text);
                Convert.ToInt32(textBox2.Text);
                Convert.ToInt32(textBox3.Text);
                Convert.ToInt32(textBox4.Text);
                Convert.ToInt32(textBox5.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("sayısal ifade giriniz");
                return;
            }

            int[] dizi = new int[5];
            dizi[0] = Convert.ToInt32(textBox1.Text);
            dizi[1] = Convert.ToInt32(textBox2.Text);
            dizi[2] = Convert.ToInt32(textBox3.Text);
            dizi[3] = Convert.ToInt32(textBox4.Text);
            dizi[4] = Convert.ToInt32(textBox5.Text);

            int ciftsayac = 0;
            int teksayac = 0;

            foreach (int item in dizi)
            {
                if (item % 2 == 0)
                {
                    ciftsayac++;
                }
                else
                {
                    teksayac++;
                }
            }

            label1.Text = "çift adet " + ciftsayac;
            label2.Text = "tek adet " + teksayac;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty
   || textBox2.Text == string.Empty
    || textBox3.Text == string.Empty
     || textBox4.Text == string.Empty
      || textBox5.Text == string.Empty)
            {
                MessageBox.Show("boşlukları dolduralım");
                return;
            }

            try
            {
                Convert.ToInt32(textBox1.Text);
                Convert.ToInt32(textBox2.Text);
                Convert.ToInt32(textBox3.Text);
                Convert.ToInt32(textBox4.Text);
                Convert.ToInt32(textBox5.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("sayısal ifade giriniz");
                return;
            }

            int[] dizi = new int[5];
            dizi[0] = Convert.ToInt32(textBox1.Text);
            dizi[1] = Convert.ToInt32(textBox2.Text);
            dizi[2] = Convert.ToInt32(textBox3.Text);
            dizi[3] = Convert.ToInt32(textBox4.Text);
            dizi[4] = Convert.ToInt32(textBox5.Text);

            int toplam = 0;
            decimal ort = 0;

            foreach (var item in dizi)
            {
                toplam = toplam + item;
            }
            ort = toplam / dizi.Length;
            label3.Text = "ortalama " + ort;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty
  || textBox2.Text == string.Empty
   || textBox3.Text == string.Empty
    || textBox4.Text == string.Empty
     || textBox5.Text == string.Empty)
            {
                MessageBox.Show("boşlukları dolduralım");
                return;
            }

            try
            {
                Convert.ToInt32(textBox1.Text);
                Convert.ToInt32(textBox2.Text);
                Convert.ToInt32(textBox3.Text);
                Convert.ToInt32(textBox4.Text);
                Convert.ToInt32(textBox5.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("sayısal ifade giriniz");
                return;
            }

            int[] dizi = new int[5];
            dizi[0] = Convert.ToInt32(textBox1.Text);
            dizi[1] = Convert.ToInt32(textBox2.Text);
            dizi[2] = Convert.ToInt32(textBox3.Text);
            dizi[3] = Convert.ToInt32(textBox4.Text);
            dizi[4] = Convert.ToInt32(textBox5.Text);

            int mod5 = 0;
            int mod2 = 0;

            foreach (var item in dizi)
            {
                if (item % 5 == 0)
                {
                    mod5 += item;
                }

                if (item % 2 == 0)
                {
                    mod2 += item;
                }
            }
            int sonuc = mod5 - mod2;
            label3.Text = "mod 5-2 " + sonuc;
        }
    }
}
