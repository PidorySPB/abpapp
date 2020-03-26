using MySql.Data.MySqlClient;
using MySql.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ABPa {
    
    public partial class Form2 : Form
    {
        int allCount;
        DateTime thisDay = DateTime.Today;
        public Form2()
        {
            var dbCon = DBConn.Instance();
            dbCon.DatabaseName = "570_abp";
            dbCon.Host = "5.187.7.31";
            InitializeComponent();
            if (dbCon.IsConnect())
            {
                string query = "SELECT num_post FROM priem";
                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    allCount = reader.GetInt32(0);
                    label1.Text = "Поступление комплектующих № " + reader.GetString(0) + " от " + thisDay.ToString("d");
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
            dbCon.Connection = null;
            dbCon.DatabaseName = "570_abp";
            dbCon.Host = "5.187.7.31";
            if (dbCon.IsConnect())
            {
                allCount++;
                string query = "";
                try
                {
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                         if (dataGridView1.Rows[i].Cells[0].Value.ToString() != "" 
                           // && dataGridView1.Rows[i].Cells[1].Value.ToString() != ""
                            && dataGridView1.Rows[i].Cells[2].Value.ToString() != ""
                            && nameTBox.Text!="")
                         {
                            if ((Regex.IsMatch(dataGridView1.Rows[i].Cells[0].Value.ToString(), "\\bАКБ\\b") || Regex.IsMatch(dataGridView1.Rows[i].Cells[0].Value.ToString(), "\\bакб\\b")) && dataGridView1.Rows[i].Cells[1].Value.ToString() != "")
                            {
                                query = String.Format("INSERT INTO priem(name, serial,count,employee,date,num_post) VALUES('{0}','{1}','{2}','{3}','{4}','{5}')",
                                    dataGridView1.Rows[i].Cells[0].Value.ToString(),
                                    dataGridView1.Rows[i].Cells[1].Value.ToString(),
                                    dataGridView1.Rows[i].Cells[2].Value.ToString(),
                                    nameTBox.Text.ToString(),
                                    thisDay.ToString("d"),
                                    allCount.ToString());
                                var cmd = new MySqlCommand(query, dbCon.Connection);
                                cmd.ExecuteNonQuery();
                            } else if (!(Regex.IsMatch(dataGridView1.Rows[i].Cells[0].Value.ToString(), "\\bАКБ\\b"))){
                                query = String.Format("INSERT INTO priem(name,count,employee,date,num_post) VALUES('{0}','{1}','{2}','{3}','{4}')",
                                    dataGridView1.Rows[i].Cells[0].Value.ToString(),
                                    dataGridView1.Rows[i].Cells[2].Value.ToString(),
                                    nameTBox.Text.ToString(),
                                    thisDay.ToString("d"),
                                    allCount.ToString());
                                var cmd = new MySqlCommand(query, dbCon.Connection);
                                cmd.ExecuteNonQuery();
                            }
                         }
                         else
                         {
                             MessageBox.Show("Ошибка добавления");
                         }
                        //for(int j = 0; j < 3; j++)
                        //  {
                        //  if (dataGridView1.Rows[i].Cells[j].Value != null)
                        // }
                    }
                }catch(MySqlException ee)
                {
                    MessageBox.Show("MysqlError: " + ee.ToString());
                }
            }
            else
            {
                MessageBox.Show("Ошибка с сервером");
            }
            dbCon.Close();
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 2 || dataGridView1.CurrentCell.ColumnIndex == 1)
            {
                TextBox b = (TextBox)e.Control;
                b.KeyPress += new KeyPressEventHandler(b_KeyPress);
            }
        }
            void b_KeyPress(object senderr, KeyPressEventArgs ee)
            {
                if (!(Char.IsDigit(ee.KeyChar))){
                    if (ee.KeyChar != (char)Keys.Back)
                        ee.Handled = true;
                }
            }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                MessageBox.Show(dataGridView1.Rows[0].Cells[0].Value.ToString());
            }catch(Exception ee)
            {

            }
        }
    }
}
