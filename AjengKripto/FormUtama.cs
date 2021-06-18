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
    public partial class FormUtama : Form
    {
        Koneksi koneksi = new Koneksi();
        DataTable dt = new DataTable();
        int getId, customkey;
        string jk;
        public FormUtama(int key)
        {
            InitializeComponent();
            this.customkey = key;
            refreshForm();
        }

        private void refreshForm()
        {
            viewDG();
            dg.Enabled = true;

            textNamaLengkap.Text = "";
            textTempat.Text = "";
            dateTimePickerTL.Text = "";
            rbPria.Checked = false;
            rbWanita.Checked = false;
            textKelas.Text = "";
            richtextAlamat.Text = "";

            btnCreate.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;

        }

        private void viewDG()
        {
            dt.Rows.Clear();
            dg.Refresh();
            koneksi.select("SELECT * FROM DATA");
            koneksi.adp.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                row["nama"] = CipherAlgorithmCustom.Decipher(row["nama"].ToString(), customkey);
                row["tempat_lahir"] = CipherAlgorithmCustom.Decipher(row["tempat_lahir"].ToString(), customkey);
                row["tanggal_lahir"] = CipherAlgorithmCustom.Decipher(row["tanggal_lahir"].ToString(), customkey);
                row["jenis_kelamin"] = CipherAlgorithmCustom.Decipher(row["jenis_kelamin"].ToString(), customkey);
                row["alamat"] = CipherAlgorithmCustom.Decipher(row["alamat"].ToString(), customkey);
                row["kelas"] = CipherAlgorithmCustom.Decipher(row["kelas"].ToString(), customkey);
            }
            dg.DataSource = dt;
            dg.Columns[0].Visible = false;
            dg.Columns[1].HeaderText = "Nama Lengkap";
            dg.Columns[2].HeaderText = "Tempat Lahir";
            dg.Columns[3].HeaderText = "Tanggal Lahir";
            dg.Columns[4].HeaderText = "Jenis Kelamin";
            dg.Columns[5].Visible = false;
            dg.Columns[6].HeaderText = "Kelas";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if ("".Equals(textNamaLengkap.Text) || "".Equals(textTempat.Text) || "".Equals(dateTimePickerTL.Text)
                    || "".Equals(textKelas.Text) || "".Equals(richtextAlamat.Text))
                {
                    MessageBox.Show("Data Tidak Boleh Kosong");
                }
                else if (rbPria.Checked == false && rbWanita.Checked == false)
                {
                    MessageBox.Show("Jenis Kelamin Tidak Boleh Kosong");
                }
                else
                {
                    if (rbPria.Checked) jk = "Pria";
                    else jk = "Wanita";
                    koneksi.cud("INSERT INTO DATA(nama,tempat_lahir,tanggal_lahir,jenis_kelamin,alamat,kelas) values('" 
                        + CipherAlgorithmCustom.Enchiper(textNamaLengkap.Text, customkey) +
                        "','" + CipherAlgorithmCustom.Enchiper(textTempat.Text, customkey) + "','" +
                        CipherAlgorithmCustom.Enchiper(dateTimePickerTL.Text, customkey) + "','" +
                        CipherAlgorithmCustom.Enchiper(jk, customkey) + "','" +
                        CipherAlgorithmCustom.Enchiper(richtextAlamat.Text, customkey) +
                        "','" + CipherAlgorithmCustom.Enchiper(textKelas.Text, customkey) + "')");
                    MessageBox.Show("Data Berhasil Ditambahkan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                refreshForm();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshForm();
        }

        private void rbPria_CheckedChanged(object sender, EventArgs e)
        {
            rbWanita.Checked = false;
        }

        private void rbWanita_CheckedChanged(object sender, EventArgs e)
        {
            rbPria.Checked = false;
        }

        private void dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dg.Rows[e.RowIndex];
                getId = Int32.Parse(row.Cells[0].Value.ToString());
                textNamaLengkap.Text = row.Cells[1].Value.ToString();
                textTempat.Text = row.Cells[2].Value.ToString();
                dateTimePickerTL.Text = row.Cells[3].Value.ToString();
                if (row.Cells[4].Value.ToString() == "Pria")
                {
                    rbPria.Checked = true;
                }
                else
                {
                    rbWanita.Checked = true;
                }
                textKelas.Text = row.Cells[6].Value.ToString();
                richtextAlamat.Text = row.Cells[5].Value.ToString();

                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                btnCreate.Enabled = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Apa Kamu Yakin Ingin Menghapus Data Ini ?", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (DialogResult.Yes == result)
                {
                    koneksi.cud("delete from data where id='" + getId + "'");
                    MessageBox.Show("Data Berhasil Dihapus");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                refreshForm();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if ("".Equals(textNamaLengkap.Text) || "".Equals(textTempat.Text) || "".Equals(dateTimePickerTL.Text)
                    || "".Equals(textKelas.Text) || "".Equals(richtextAlamat.Text))
                {
                    MessageBox.Show("Data Tidak Boleh Kosong");
                }
                else if (rbPria.Checked == false && rbWanita.Checked == false)
                {
                    MessageBox.Show("Jenis Kelamin Tidak Boleh Kosong");
                }
                else
                {
                    if (rbPria.Checked) jk = "Pria";
                    else jk = "Wanita";
                    koneksi.cud("UPDATE data SET nama='" + CipherAlgorithmCustom.Enchiper(textNamaLengkap.Text, customkey) + "', tempat_lahir='" + CipherAlgorithmCustom.Enchiper(textTempat.Text, customkey) + "',tanggal_lahir='" + CipherAlgorithmCustom.Enchiper(dateTimePickerTL.Text, customkey) + "',jenis_kelamin='" + CipherAlgorithmCustom.Enchiper(jk, customkey) + "', alamat='" + CipherAlgorithmCustom.Enchiper(richtextAlamat.Text, customkey) + "', kelas='" + CipherAlgorithmCustom.Enchiper(textKelas.Text, customkey) + "' WHERE id='" + getId + "'");
                    MessageBox.Show("Data Berhasil Diperbaharui");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                refreshForm();
            }
        }
    }
}
