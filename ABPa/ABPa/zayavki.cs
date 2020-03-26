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
        public zayavki()
        {
            InitializeComponent();
            int allCount;
            DateTime thisDay = DateTime.Today;
            var dbCon = DBConn.Instance();
            dbCon.Connection = null;
            dbCon.DatabaseName = "570_abp";
            dbCon.Host = "5.187.7.31";
            InitializeComponent();
            if (dbCon.IsConnect())
            {
                string query = "SELECT num FROM zayvki";
                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    allCount = reader.GetInt32(0);
                   // allCount += 1;
                    zayavkaLabel.Text = "Заявка №"+allCount + "от" + thisDay.ToString("d");
                }
            }
            else
            {
                MessageBox.Show("Ошибка связи с сервером");
            }

            dbCon.Close();
        }
    


        

        private void zayavki_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
