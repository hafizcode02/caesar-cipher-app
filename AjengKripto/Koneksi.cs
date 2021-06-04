using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace AjengKripto
{
    class Koneksi
    {
        static string database = ("server = localhost; uid = root; pwd = ''; database = db_kripto_ajeng; sslMode = none;");
        public MySqlConnection koneksi = new MySqlConnection(database);
        public MySqlCommand cmd;
        public MySqlDataAdapter adp = new MySqlDataAdapter();
        public MySqlDataReader dr;
        public DataTable dt = new DataTable();

        public void select(string query)
        {
            try
            {
                dt.Clear();
                koneksi.Open();
                cmd = new MySqlCommand(query, koneksi);
                adp.SelectCommand = cmd;
                adp.Fill(dt);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                koneksi.Close();
            }
        }
        
        public void cud(string query)
        {
            try
            {
                koneksi.Open();
                cmd = new MySqlCommand(query, koneksi);
                dr = cmd.ExecuteReader();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                koneksi.Close();
            }
        }
    }
}
