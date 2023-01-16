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
    public partial class Form38 : Form
    {
        public Form38()
        {
            InitializeComponent();


            listView1.View = View.Details;
            listView1.GridLines = true;
            //listView1.FullRowSelect = true;

            listView1.Columns.Add("ADI", 100);
            listView1.Columns.Add("SOYADI", 70);
            listView1.Columns.Add("TELEFONU", 70);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] row = { textBox1.Text, textBox2.Text, textBox3.Text };
            var satir = new ListViewItem(row);
            listView1.Items.Add(satir);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            listView1.Items.Remove(listView1.SelectedItems[0]);
        }
    }
}
