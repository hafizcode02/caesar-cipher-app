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
    public partial class MenuForm : Form
    {
        Koneksi koneksi = new Koneksi();
        DataTable dt = new DataTable();
        int Key;
        public MenuForm()
        {
            InitializeComponent();
            koneksi.select("SELECT * FROM feature WHERE name='key'");
            koneksi.adp.Fill(dt);

            foreach (DataRow dtr in dt.Rows)
            {
                Key = Int32.Parse(dtr[2].ToString());
            }
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingForm sf = new SettingForm();
            sf.ShowDialog();
        }

        private void cRUDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUtama fu = new FormUtama(Key);
            fu.ShowDialog();
        }
    }
}
