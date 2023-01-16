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
    public partial class Form37 : Form
    {
        public Form37()
        {
            InitializeComponent();



        }

        private void Form37_Load(object sender, EventArgs e)
        {

            List<Kisi> Kisiler = new List<Kisi>();

            Kisi kisi1 = new Kisi();
            Kisi kisi2 = new Kisi();

            kisi1.Ad = "Zeytin";
            kisi1.Soyad = "Bakar";

            kisi2.Ad = "Işıl";
            kisi2.Soyad = "Gezer";


            Kisiler.Add(kisi1);
            Kisiler.Add(kisi2);


            Kisiler.Add(new Kisi()
            {
                Ad = "Yavuz",
                Soyad = "Nereden",
            });


            //foreach (var item in Kisiler)
            //{
            //    listBox1.Items.Add(item.Ad + " " + item.Soyad);
            //}

            //foreach (Kisi kisi in Kisiler)
            //{              

            //  listBox1.Items.Add(kisi.Ad + " " + kisi.Soyad);                
            //}

            dataGridView1.DataSource = Kisiler;





        }


        private class Kisi
        {
            public string Ad { get; set; }
            public string Soyad { get; set; }

        }

    }
}
