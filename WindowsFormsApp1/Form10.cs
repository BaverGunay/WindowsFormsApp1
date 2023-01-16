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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gonder(listBox1, listBox2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox1.Items)
            {
                listBox2.Items.Add(item);
            }
            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gonder(listBox2, listBox1);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(listBox2.Items);
            //for (int i = 0; i < listBox2.Items.Count; i++)
            //{
            //    listBox1.Items.Add(listBox2.Items[i]);
            //}
            listBox2.Items.Clear();
        }


        private void gonder(ListBox lst1, ListBox lst2)
        {
            try
            {
                ArrayList secilenler = new ArrayList();
                secilenler.AddRange(lst1.SelectedItems);
                foreach (var item in secilenler)
                {
                    lst2.Items.Add(item);
                    lst1.Items.Remove(item);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Seçim yapmalısınız. " + e.Message);
            }
        }
    }
}
