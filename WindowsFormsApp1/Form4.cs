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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Ekrana tıkladınız..!");
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            object[] sehirler = new object[] 
 { "Edirne", "Bursa", "Kocaeli", "Sakarya", "Trabzon", "Rize" };
            comboBox1.Items.AddRange(sehirler);
            comboBox1.Text = comboBox1.Items[0].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = comboBox1.Items.Count.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = comboBox1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = string.Empty;

            for (int i = 0; i < comboBox1.Items.Count; i++)
            {
                label1.Text += comboBox1.Items[i].ToString()+ "  ";
            }
        }
    }
}
