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
    public partial class zayavki : Form
    {
        int allCount;
        DateTime thisDay = DateTime.Today;
        public zayavki()
        {
            InitializeComponent();


            var dbCon = DBConn.Instance();
            dbCon.Connection = null;
            dbCon.DatabaseName = "570_abp";
            dbCon.Host = "5.187.7.31";
            if (dbCon.IsConnect())
            {
                string query = "SELECT num FROM zayvki";
                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    allCount = reader.GetInt32(0);
                    allCount += 1;
                    zayavkaLabel.Text = "Заявка №" + allCount + " от " + thisDay.ToString("d");
                }
            }
            else
            {
                MessageBox.Show("Ошибка связи с сервером");
            }




            dbCon.Close();



            dbCon.Connection = null;
            dbCon.DatabaseName = "570_abp";
            dbCon.Host = "5.187.7.31";
            if (dbCon.IsConnect())
            {
                string query = "SELECT name FROM spisokDronov";
                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    droneList.Items.Add(reader.GetValue(0).ToString());
                }
            }
            else
            {
                MessageBox.Show("Ошибка связи с сервером");
            }




        }









        private void zayavki_Load(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {

            var dbCon = DBConn.Instance();
            dbCon.Connection = null;
            dbCon.DatabaseName = "570_abp";
            dbCon.Host = "5.187.7.31";
            if (dbCon.IsConnect())
            {

                string query = "";
                try
                {

                    if (fio.Text.ToString() != ""
                       // && dataGridView1.Rows[i].Cells[1].Value.ToString() != ""
                       && droneList.SelectedItem.ToString() != ""
                       && count.Text != "")
                    {

                        query = String.Format("INSERT INTO zayvki(fio, drone, count, date_of_zakaz, date_of_change, state, num) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                            fio.Text.ToString(),
                            droneList.SelectedItem.ToString(),
                            count.Text.ToString(),
                            thisDay.ToString("d"),
                            thisDay.ToString("d"),
                            "Создан",
                            allCount.ToString());
                        var cmd = new MySqlCommand(query, dbCon.Connection);
                        cmd.ExecuteNonQuery();


                    }
                    else
                    {
                        MessageBox.Show("Ошибка добавления");
                    }

                }
                catch (MySqlException ee)
                {
                    MessageBox.Show("MysqlError: " + ee.ToString());
                }



            }
        }

        private void droneList_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(droneList.SelectedIndex.ToString());
        }
    }
}