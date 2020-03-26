using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABPa
{
    public partial class PosmotrZv : Form
    {
        public PosmotrZv()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PosmotrZv_Load(object sender, EventArgs e)
        {
            var dbCon = DBConn.Instance();
            dbCon.Connection = null;
            dbCon.DatabaseName = "570_abp";
            dbCon.Host = "5.187.7.31";
            string query = "";
            if (dbCon.IsConnect())
            {


                query = String.Format("SELECT * FROM zayvki");

                var cmd = new MySqlCommand(query, dbCon.Connection);
                //cmd.ExecuteNonQuery();

                // SqlConnection dataBaseConnection = new SqlConnection(conn);
                var reader = cmd.ExecuteReader();
                List<string[]> data = new List<string[]>();
                int i = 1;
                while (reader.Read())
                {
                    data.Add(new string[7]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();
                    data[data.Count - 1][5] = reader[5].ToString();
                    data[data.Count - 1][6] = reader[6].ToString();
                }


                reader.Close();
                dbCon.Close();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                foreach (string[] s in data)
                    dataGridView1.Rows.Add(s);
            }

        }
    }
}
