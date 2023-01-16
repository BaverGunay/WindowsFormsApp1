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
    public partial class Form40 : Form
    {
        public Form40()
        {
            InitializeComponent();

                   }

        private void Form40_Load(object sender, EventArgs e)
        {

            //Yeni veri tablosu oluştur
            DataTable dt = new DataTable();
            DataColumn sütun;
            DataRow satır;

            //Sütunları oluştur
            sütun = new DataColumn("Sıra No");
            sütun.DataType = Type.GetType("System.Int32");
            //Sütunlara ekle
            dt.Columns.Add(sütun);

            //Yeni bir sütun daha  oluştur
            sütun = new DataColumn("Adı Soyadı");
            sütun.DataType = Type.GetType("System.String");
            //Sütunlara ekle
            dt.Columns.Add(sütun);

            //Yeni bir sütun daha  oluştur
            sütun = new DataColumn("Doğum Tarihi");
            sütun.DataType = Type.GetType("System.DateTime");
            //Sütunlara ekle
            dt.Columns.Add(sütun);

            //Yeni bir sütun daha  oluştur
            sütun = new DataColumn("Doğum Yeri");
            sütun.DataType = Type.GetType("System.String");
            //Sütunlara ekle
            dt.Columns.Add(sütun);

            //dataGrid kontrolünde oluşturduğumuz tabloyu göster
            dataGridView1.DataSource = dt;

            //Yeni bir satır oluştur
            satır = dt.NewRow();
            satır["Adı Soyadı"] = "Ali";
            satır["Doğum Tarihi"] = "17/11/1973";
            satır["Doğum Yeri"] = "Erzurum";
            //Veri tablomuza kontrolüne ekle
            dt.Rows.Add(satır);

            //Yeni bir satır daha oluştur
            satır = dt.NewRow();
            satır["Adı Soyadı"] = "Veli";
            satır["Doğum Tarihi"] = "5/5/1985";
            satır["Doğum Yeri"] = "Ankara";
            //Veri tablomuza kontrolüne ekle
            dt.Rows.Add(satır);
        }
    }



}
    

