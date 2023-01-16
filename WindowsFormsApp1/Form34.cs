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
    public partial class Form34 : Form
    {
        public Form34()
        {
            InitializeComponent();
        }

        string[] isimler = new string[100];//isimler için dizi oluşturuldu
        int sayi = 0;//dizinin index değerinin kontrolü için sayi değişkeni 
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.Text != null)//textbox'ın boş durumlarını kontrol etme
            {
                comboBox1.Items.Add(textBox1.Text);//comboboxa değer atama
                isimler[sayi] = textBox1.Text;//dizinin sayi indexine göre değer ekleme
                sayi++;//dizi için artan değer

                textBox1.Clear();
                //textBox1.Focus();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = 1;
            //listBox1.Items.Add(comboBox1.SelectedItem.ToString());
            //comboBox1.Items.Remove(comboBox1.SelectedItem.ToString());
            foreach (string isim in isimler)//isimler dizisini foreach ile döndürerek listboxa yazdırdık
            {
              
                if (isim != null && isim != "")//dizide boş olan ve null olan değerleri almadık
                {
                    if (x % 2 ==0)
                    {
                    listBox1.Items.Add(isim);
                    }
                    
                }
                x++;
            }

        }
    }
}
