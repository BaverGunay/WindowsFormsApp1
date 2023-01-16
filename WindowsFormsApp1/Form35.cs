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
    public partial class Form35 : Form
    {
        public Form35()
        {
            InitializeComponent();
        }

        string[] isimler = new string[100];//isimler için dizi oluşturuldu
        int sayi = 0;//dizinin index değerinin kontrolü için sayi değişkeni oluşturuldu
        private void Form35_Load(object sender, EventArgs e)
        {
            listBox1.Visible = false;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.Text != null)//textbox'ın boş durumlarını kontrol etme
            {
                comboBox1.Items.Add(textBox1.Text);//comboboxa değer atama
                isimler[sayi] = textBox1.Text;//dizinin sayi indexine göre değer ekleme
                sayi++;//dizi için artan değer

                textBox1.Clear();
                textBox1.Focus();
            }

          
        }

        private void button2_Click(object sender, EventArgs e)
        {
         listBox1.Items.Clear();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                listBox1.Items.Clear();
                listBox1.Visible = true;

                //if (comboBox1.SelectedIndex == 0)
                if (comboBox1.SelectedItem.ToString() == "ISTANBUL")
                {
                    listBox1.Items.Add("Kadıköy");
                    listBox1.Items.Add("Fatih");
                    listBox1.Items.Add("Pendik");
                }
                else //if (comboBox1.SelectedIndex == 1)
                if (comboBox1.SelectedItem.ToString() == "ANKARA")
                {
                    listBox1.Items.Add("Kızılay");
                    listBox1.Items.Add("Yeni Mahalle");
                    listBox1.Items.Add("Etimesgut");
                }
                else //if (comboBox1.SelectedIndex == 2)
                if (comboBox1.SelectedItem.ToString() == "IZMIR")
                {
                    listBox1.Items.Add("Karşıyaka");
                    listBox1.Items.Add("Göztepe");
                    listBox1.Items.Add("Şirince");
                }
         

        }
    }
}
