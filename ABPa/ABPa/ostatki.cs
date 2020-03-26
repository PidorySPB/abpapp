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
using MySql.Data.MySqlClient;

namespace ABPa
{
    public partial class ostatki : Form
    {
        public ostatki()
        {
            InitializeComponent();
            DateTime thisDay = DateTime.Today;
            dateTimePicker1.MaxDate = thisDay;
            dateTimePicker1.Value = thisDay;

            LoadData();
        }

        private void LoadData()
        {
            var dbCon = DBConn.Instance();
            dbCon.Connection = null;
            dbCon.DatabaseName = "570_abp";
            dbCon.Host = "5.187.7.31";
            string query = "";
            if (dbCon.IsConnect())
            {


                query = String.Format("SELECT name,SUM(count) FROM priem WHERE `date`='{0}' GROUP BY name", dateTimePicker1.Value.ToString("d"));

                var cmd = new MySqlCommand(query, dbCon.Connection);
                //cmd.ExecuteNonQuery();

                // SqlConnection dataBaseConnection = new SqlConnection(conn);
                var reader = cmd.ExecuteReader();
                List<string[]> data = new List<string[]>();
                int i = 1;
                while (reader.Read())
                {
                    data.Add(new string[3]);

                    data[data.Count - 1][0] = (i++).ToString();
                    data[data.Count - 1][1] = reader[0].ToString();
                    data[data.Count - 1][2] = reader[1].ToString();
                }


                reader.Close();
                dbCon.Close();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                foreach (string[] s in data)
                    dataGridViewOst.Rows.Add(s);
            }

        }
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            ExcelApp.Application.Workbooks.Add(Type.Missing);
            ExcelApp.Columns.ColumnWidth = 15;

            ExcelApp.Cells[1, 1] = "№п/п";
            ExcelApp.Cells[1, 2] = "Комплектующие";
            ExcelApp.Cells[1, 3] = "Остаток";


            for (int i = 0; i < dataGridViewOst.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridViewOst.RowCount; j++)
                {
                    ExcelApp.Cells[j + 2, i + 1] = (dataGridViewOst[i, j].Value).ToString();
                }
            }
            ExcelApp.Visible = true;
        }

        private void execButton_Click(object sender, EventArgs e)
        {
            // dataGridViewOst.Rows.Clear();
            // dataGridViewOst.Columns.Clear();
            int rowsCount = dataGridViewOst.Rows.Count;
            for (int i = 0; i < rowsCount; i++)
            {
                dataGridViewOst.Rows.Remove(dataGridViewOst.Rows[0]);
            }
            LoadData();
        }

        private void ostatki_Load(object sender, EventArgs e)
        {

        }
    }
    
}
