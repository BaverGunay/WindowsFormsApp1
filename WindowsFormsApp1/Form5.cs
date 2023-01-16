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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int s1, s2, sonuc;
            s1 = Convert.ToInt32(textBox1.Text);
            s2 = Convert.ToInt32(textBox2.Text);

            if (comboBox1.SelectedIndex == 0)
            {
                sonuc = s1 + s2;
                label1.Text = sonuc.ToString();
            }
            if (comboBox1.SelectedIndex == 1)
            {
                sonuc = s1 - s2;
                label1.Text = sonuc.ToString();
            }
            if (comboBox1.SelectedIndex == 2)
            {
                sonuc = s1 * s2;
                label1.Text = sonuc.ToString();
            }
            if (comboBox1.SelectedIndex == 3)
            {
                sonuc = s1 / s2;
                label1.Text = sonuc.ToString();
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("toplama");
            comboBox1.Items.Add("çıkarma");
            comboBox1.Items.Add("çarpma");
            comboBox1.Items.Add("bölme");
        }

        int x = 0;
        private void button1_Click(object sender, EventArgs e)
        {          
            button1.Text = (++x).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            button2.Text = (++x).ToString();
            //MessageBox.Show("TEBRİKLER");
            //this.Close();
        }

        Random r = new Random();
        int boyut = 50;

        private void button2_MouseHover(object sender, EventArgs e)
        {
            boyut += 5;
            button2.Top = r.Next(0, this.Height - 50);
            button2.Left = r.Next(0, this.Width - 50);
            button2.Width = boyut;
            button2.Height = boyut;
        }
    }
}
