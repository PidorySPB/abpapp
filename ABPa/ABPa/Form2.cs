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
    public partial class Form2 : Form
    {
        DateTime thisDay = DateTime.Today;
        public Form2()
        {
            
            InitializeComponent();
            var dbCon = DBConn.Instance();
            dbCon.DatabaseName = "570_abp";
            dbCon.Host = "5.187.7.31";
            if (dbCon.IsConnect())
            {
                string query = "SELECT num_post FROM priem";
                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    label1.Text = "Поступление комплектующих №" + reader.GetString(6) + " от " + thisDay.ToString("d");
                }
            }
            else {
                MessageBox.Show("Ошибка связи с сервером");
            }
            dbCon.Close();
        }

        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void closeB_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            this.Close(); 
            
        }

        private void uploadB_Click(object sender, EventArgs e)
        {
            var dbCon = DBConn.Instance();
            dbCon.DatabaseName = "570_abp";
            dbCon.Host = "5.187.7.31";
            if (dbCon.IsConnect())
            {
                string query = "";
                for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
                {
                    // if (dataGridView1.Rows[i].Cells[0].Value.ToString() != "" && dataGridView1.Rows[i].Cells[1].Value.ToString() != "" && dataGridView1.Rows[i].Cells[2].Value.ToString() != "")
                    // {
                    query = String.Format("INSERT INTO priem(name, serial,count,employee,date) VALUES('{0}','{1}','{2}','{3}','{4}')",
                        dataGridView1.Rows[i].Cells[0].Value.ToString(),
                        dataGridView1.Rows[i].Cells[1].Value.ToString(),
                        dataGridView1.Rows[i].Cells[2].Value.ToString(),
                        nameTBox.Text.ToString(),
                        thisDay.ToString("d"));
                    var cmd = new MySqlCommand(query, dbCon.Connection);
                    var reader = cmd.ExecuteNonQuery();
                    // }
                    // else
                    // {
                    //     MessageBox.Show("Ошибка добавления");
                    // }
                    //for(int j = 0; j < 3; j++)
                    //  {
                    //  if (dataGridView1.Rows[i].Cells[j].Value != null)
                    // }
                }
            }
            else
            {
                MessageBox.Show("Ошибка с сервером");
            }
            dbCon.Close();
        }
    }
}
