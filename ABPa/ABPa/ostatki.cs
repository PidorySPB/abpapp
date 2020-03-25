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
    public partial class ostatki : Form
    {
        public ostatki()
        {
            InitializeComponent();
            DateTime thisDay = DateTime.Today;
            dateTimePicker1.MaxDate = thisDay;
            dateTimePicker1.Value = thisDay;

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
    }
    }
}
