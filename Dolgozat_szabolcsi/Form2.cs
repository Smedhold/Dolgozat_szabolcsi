using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dolgozat_szabolcsi
{
    public partial class Form2 : Form
    {
        public string ConnectionString { get; set; }
        public Form2()
        {
            ConnectionString =
            "Server = (localdb)\\MSSQLLocalDB;" +
            "Database = nyelviskola;" +
            "Integrated Security = True;";
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            using (var con = new SqlConnection(ConnectionString)) 
            {
                con.Open();
                var r = new SqlCommand(
                    "SELECT nyelv " +
                    "FROM nyelvek; ",con).ExecuteReader();
                while (r.Read())
                {
                    comboBox1.Items.Add(r[0]);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv2.Rows.Clear();
            using (var con = new SqlConnection(ConnectionString))
            {
                con.Open();
                var r = new SqlCommand(
                    "SELECT vizsgak.idopont, nyelvek.nyelv, vizsgak.szint " +
                    "FROM nyelvek, vizsgak " +
                    $"WHERE vizsgak.nyelvid = nyelvek.id AND nyelvek.nyelv LIKE '{comboBox1.SelectedItem}';", con).ExecuteReader();
                while (r.Read())
                {
                    dgv2.Rows.Add(r[0], r[1], r[2]);
                }
            }
        }
    }
}
