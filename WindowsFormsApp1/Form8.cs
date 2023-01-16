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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        private void olaysender(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtSonuc.Text += btn.Text;
        }

        private void sayisender(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtSonuc.Text += btn.Text;
        }


    }
}
