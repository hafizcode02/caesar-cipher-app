using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AjengKripto
{
    public partial class SettingForm : Form
    {
        Koneksi koneksi = new Koneksi();
        DataTable dt = new DataTable();
        public SettingForm()
        {
            InitializeComponent();
            loadData();
        }

        public void loadData()
        {
            koneksi.select("SELECT * FROM feature WHERE name='key'");
            koneksi.adp.Fill(dt);

            foreach (DataRow dtr in dt.Rows)
            {
                numericKey.Value = Int32.Parse(dtr[2].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            koneksi.cud("UPDATE feature SET value='" + numericKey.Value + "' WHERE name='key'");
            MessageBox.Show("Kunci Berhasil Diperbaharui");
        }
    }
}
