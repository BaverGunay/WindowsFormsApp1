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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "uygulama başladı... başlangıç zamanı : " + DateTime.Now;

            comboBox1.Items.Add("beşiktaş");
            comboBox1.Items.Add("fenerbahçe");
            comboBox1.Items.Add("galatasaray");
            comboBox1.Items.Add("trabzon");


            listBox1.Items.Add("usa");
            listBox1.Items.Add("sscb");
            listBox1.Items.Add("çin");

            timer1.Interval = 1000;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkış yapmak istiyormusunuz..!",
                "Uyarı",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                Application.Exit();
            }

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(textBox1.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToLongTimeString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
