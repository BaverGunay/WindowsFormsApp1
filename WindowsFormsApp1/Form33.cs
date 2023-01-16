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
    public partial class Form33 : Form
    {
        public Form33()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!=string.Empty)
            {
            comboBox1.Items.Add(textBox1.Text);
            //MessageBox.Show("Kişi ekleme başarılı");
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = listBox1.SelectedItem.ToString();//listboxtan seçilen kişiyi labele ekleme
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox1.Text);//comboboxtan seçilen kişiyi listboxa ekleme
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = comboBox1.SelectedItem.ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = listBox1.SelectedItem.ToString();
        }
    }
}
