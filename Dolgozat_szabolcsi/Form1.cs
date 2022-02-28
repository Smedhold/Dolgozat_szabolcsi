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
    public partial class Form1 : Form
    {

        public string ConnectionString { get; set; }
        public Form1()
        {
             ConnectionString =
            "Server = (localdb)\\MSSQLLocalDB;" +
            "Database = nyelviskola;" +
            "Integrated Security = True;";
        InitializeComponent();
        }   

        private void Form1_Load(object sender, EventArgs e)
        {
            dgv.Rows.Clear();
            using (var con = new SqlConnection(ConnectionString))
            {
                con.Open();
                var r = new SqlCommand(
                    "SELECT jelentkezesek.sorsz, jelentkezesek.nev, nyelvek.nyelv, vizsgak.szint " +
                    "FROM jelentkezesek, nyelvek, vizsgak " +
                    "WHERE jelentkezesek.vizsga = vizsgak.sorsz AND vizsgak.nyelvid = nyelvek.id ;", con).ExecuteReader();
                while (r.Read())
                {
                    dgv.Rows.Add(r[0], r[1], r[2], r[3]);
                }
            }
        }

        private void vizsga_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
        }

        private void ujvizsga_Click(object sender, EventArgs e)
        {
            bool alma = false;
            new FrmVizsgazo(ConnectionString, int.Parse(dgv.CurrentRow.Cells[0].Value.ToString()),alma).ShowDialog();
        }

        private void dgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            bool alma = true;
            new FrmVizsgazo(ConnectionString, int.Parse(dgv.CurrentRow.Cells[0].Value.ToString()),alma).ShowDialog();

        }
    }
    
}
