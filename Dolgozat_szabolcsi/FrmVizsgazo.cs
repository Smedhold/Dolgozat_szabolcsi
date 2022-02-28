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
    public partial class FrmVizsgazo : Form
    {
        public string ConnectionString { get; set; }
        public int id { get; set; }
        public bool alma { get; set; }
        public FrmVizsgazo(string ConnectionString, int id, bool alma)
        {
            this.ConnectionString = ConnectionString;
            this.id = id;
            this.alma = alma;
            InitializeComponent();
        }

        private void FrmVizsgazo_Load(object sender, EventArgs e)
        {
            using (var con = new SqlConnection(ConnectionString))
            {
                con.Open();
                var k = new SqlCommand(
                    "SELECT MAX(sorsz)+1 " +
                    "FROM jelentkezesek; ", con).ExecuteReader();
                while (k.Read())
                {
                    idtb.Text = $"{k[0]}";
                }
            }


            idtb.Enabled = false;
            if (alma == true)
            {
                uj.Enabled = false;
                using (var con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    var r = new SqlCommand(
                        "SELECT sorsz, nev, mobil, szulev " +
                        "FROM jelentkezesek " +
                        $"WHERE sorsz = {id} ;", con).ExecuteReader();
                    while (r.Read())
                    {
                        idtb.Text = $"{r[0]}";
                        nev.Text = $"{r[1]}";
                        tel.Text = $"{r[2]}";
                        szul.Text = $"{r[3]}";
                    }
                }
            }
            else
            {
                modostit.Enabled = false;
                Torles.Enabled = false;
            }
            
        }

        private void uj_Click(object sender, EventArgs e)
        {
            using (var con = new SqlConnection(ConnectionString))
            {
                con.Open();
                var r = new SqlCommand(
                    "INSERT INTO jelentkezesek(sorsz, nev, mobil, szulev) " +
                    $"VALUES('{idtb.Text}','{nev.Text}','{tel.Text}','{szul.Text}' )", con).ExecuteNonQuery();
            }
        }

        private void modostit_Click(object sender, EventArgs e)
        {
            using (var con = new SqlConnection(ConnectionString)) 
            {
                con.Open();

                var r = new SqlCommand(
                    "UPDATE jelentkezesek " +
                    $"SET nev = '{nev.Text}', mobil = '{tel.Text}', szulev ='{szul.Text}'" +
                    $"WHERE sorsz = '{idtb.Text}'; ",con).ExecuteNonQuery();
            }
        }

        private void Torles_Click(object sender, EventArgs e)
        {
            using (var con = new SqlConnection(ConnectionString))
            {
                con.Open();

                var r = new SqlCommand(
                    "DELETE FROM jelentkezesek " +                    
                    $"WHERE sorsz = '{idtb.Text}'; ", con).ExecuteNonQuery();
            }
        }
    }
}
