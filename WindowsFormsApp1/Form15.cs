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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

    private void Form15_Load(object sender, EventArgs e)
        {
            KrediHesabi hesap1 = new KrediHesabi();
            KrediHesabi hesap2 = hesap1;
            hesap1.HesapNo = 3456;
            hesap2.HesapNo = 1111;
            MessageBox.Show(hesap1.HesapNo.ToString());
            MessageBox.Show(hesap2.HesapNo.ToString());

        }
        class KrediHesabi
        {
            public ulong HesapNo;
        }

    
    }
}
