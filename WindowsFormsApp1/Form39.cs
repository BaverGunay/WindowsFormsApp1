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
    public partial class Form39 : Form
    {
        public Form39()
        {
            InitializeComponent();

    
        }

        List<Kisi> persons = new List<Kisi>();
        class Kisi
        {
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public string Sehir { get; set; }
        }


        private void Form39_Load(object sender, EventArgs e)
        {
            persons.Add(new Kisi() { Ad = "Ahmet", Soyad = "Cansever", Sehir = "İstanbul" });
            persons.Add(new Kisi() { Ad = "Mehmet", Soyad = "Sayın", Sehir = "Afyon" });
            persons.Add(new Kisi() { Ad = "Sami", Soyad = "Öztürk", Sehir = "Konya" });
            persons.Add(new Kisi() { Ad = "Rıfat", Soyad = "Seven", Sehir = "Adana" });
            persons.Add(new Kisi() { Ad = "Burak", Soyad = "Saygın", Sehir = "Rize" });
            persons.Add(new Kisi() { Ad = "Kemal", Soyad = "Işık", Sehir = "Bilecik" });
            persons.Add(new Kisi() { Ad = "Cemil", Soyad = "Kırmızı", Sehir = "Sakarya" });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Getir();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            var kisiler = persons.OrderBy(persons => persons.Ad).ToList();
            dataGridView1.DataSource = kisiler;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            Sil(index);


        }

   
        private void button4_Click(object sender, EventArgs e)
        {
            Kisi ekle = new Kisi();
            ekle.Ad = textBox1.Text.Trim();
            ekle.Soyad = textBox2.Text.Trim();
            ekle.Sehir = textBox3.Text.Trim();

            int index = dataGridView1.CurrentCell.RowIndex;
            Sil(index);

            persons.Add(ekle);
            Getir();

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            textBox1.Text = dataGridView1.CurrentRow.Cells["Ad"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["Soyad"].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells["Sehir"].Value.ToString();
        }


  

        private void button5_Click(object sender, EventArgs e)
        {
            Kisi ekle = new Kisi();
            ekle.Ad = textBox1.Text.Trim();
            ekle.Soyad = textBox2.Text.Trim();
            ekle.Sehir = textBox3.Text.Trim();

            int index = dataGridView1.CurrentCell.RowIndex;
            Sil(index);
            persons.Insert(index, ekle);
            Getir();

        }


        private void Getir()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = persons;
        }

        private void Sil(int index)
        {
            persons.RemoveAt(index);
            Getir();
        }

    }
}
