using System;
using System.Collections;
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
    public partial class Form36 : Form
    {
        public Form36()
        {
            InitializeComponent();
        }

        ArrayList isimler = new ArrayList();
        int i = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                if (!(isimler.Contains(textBox1.Text)))
                {
                    isimler.Add(textBox1.Text);//ArrayList dizisine ekleme yapma
                    textBox1.Clear();
                    textBox1.Focus();

                }





            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isimler.Count > 0)
            {
                if (i == isimler.Count)
                    i = 0;

                i++;//dizinin son elemanını aştığında hata vereecektir

                listBox1.Items.Clear();

                foreach (string adlar in isimler)//adlar adında string bir değer oluşturarak dizinin elemanlarını surasıyla adlar değişkenine ekleme
                {
                    listBox1.Items.Add(adlar);//ArrayListte olan bütün isimleri listboxa aktarma
                }



            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!(isimler.Contains(textBox1.Text)))
            {
                isimler.Insert(isimler.Count, textBox1.Text);//belirtilen indexe textboxtan gelen değeri yazar ve diğer elemanları yeni gelen değere göre öteler
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!(isimler.Contains(textBox1.Text)))
            {
                isimler.Insert(Convert.ToInt32(textBox2.Text), textBox1.Text);//belirtilen indexe textboxtan gelen değeri yazar ve diğer elemanları yeni gelen değere göre öteler        
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!(isimler.Contains(textBox1.Text)))
            {
                isimler[Convert.ToInt32(textBox2.Text)] = textBox1.Text;//belirtilen indexe göre önceki verinin üstüne yeni veriyi yazar
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                isimler.Remove(listBox1.SelectedItem);
                //isimler.RemoveAt(listBox1.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Lütfen sçim yapınız");
            }

        }
    }
}
