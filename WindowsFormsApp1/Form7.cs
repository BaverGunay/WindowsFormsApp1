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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        int a = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            a++;
            label1.Text = a.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();

            if (button2.Text == "SIFIRLA")
            {
                button2.Text = "DURDUR";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (button2.Text == "SIFIRLA")
            {
                a = 0;
                label1.Text = a.ToString();
                button1.Text = "BASLAT";
            }
            else
            {
                button2.Text = "SIFIRLA";
                button1.Text = "DEVAM ET";
                timer1.Stop();
            }
        }
    }
}
