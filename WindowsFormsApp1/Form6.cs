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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        int saat = 0, dak = 59, san = 0, sal = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button2.Text = "DURDUR";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (button2.Text == "DURDUR" && sal != 0)
            {
                button2.Text = "SIFIRLA";
                button1.Text = "DEVAM ET";
                timer1.Stop();
            }
            else
            {
                button1.Text = "BASLAT";
                button2.Text = "DURDUR";
                saat = 0;
                dak = 0;
                san = 0;
                sal = 0;
                lblsa.Text = String.Format("{0:D2}", saat);
                lbldk.Text = String.Format("{0:D2}", dak);
                lblsan.Text = String.Format("{0:D2}", san);
                lblsal.Text = String.Format("{0:D2}", sal);
            }
        }
         private void timer1_Tick(object sender, EventArgs e)
        {
            sal++;
            if (sal == 65)
            {
                sal = 0;
                san++;
                if (san == 60)
                {
                    san = 0;
                    dak++;
                    if (dak == 60)
                    {
                        dak = 0;
                        saat++;
                    }
                }
            }

            lblsa.Text = String.Format("{0:D2}", saat);
            lbldk.Text = String.Format("{0:D2}", dak);
            lblsan.Text = String.Format("{0:D2}", san);
            lblsal.Text = String.Format("{0:D2}", sal);
        }
    }
}
