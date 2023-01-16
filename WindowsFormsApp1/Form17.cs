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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void Form17_Load(object sender, EventArgs e)
        {
            EvHalki annem = new EvHalki(); //EvHalki sınıfı türünden yeni bir nesne oluşturuldu.
            annem.DogumYili = 1964; //Oluşturulan nesnenin bir özelliği girildi.
            annem.Meslek = "Ev hanımı";
            annem.Ad = "Hatice";
            annem.GozRengi = "Mavi";

            EvHalki babam = new EvHalki();
            babam.DogumYili = 1950;
            babam.Meslek = "Emekli";
            babam.Ad = "Kenan";
            babam.GozRengi = "Kahverengi";

            EvHalki kardesim = new EvHalki();
            kardesim.DogumYili = 1987;
            kardesim.Meslek = "Öğrenci";
            kardesim.Ad = "Uğur";
            kardesim.GozRengi = "Yeşil";

            annem.OzellikleriYaz();
            babam.OzellikleriYaz();
            kardesim.OzellikleriYaz();

        }


        class EvHalki
        {
            public int DogumYili;
            public string Meslek;
            public string Ad;
            public string GozRengi;
            public int Yas()
            {
                return 2022 - DogumYili;
            }
            public void OzellikleriYaz()
            {
                MessageBox.Show(Ad);
                MessageBox.Show(Yas().ToString());
                MessageBox.Show(Meslek);
                MessageBox.Show(GozRengi);
            }
        }

    }
}
