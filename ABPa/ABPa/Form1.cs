using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace ABPa
{
    public partial class downloadForm : Form
    {
        public string openFolder()
        {
            string s="";
            OpenFileDialog OPF = new OpenFileDialog();
            OPF.Filter = "Файл xls|*.xls|Файл xlsx|*.xlsx";
            if (OPF.ShowDialog() == DialogResult.OK)
            {
                s=OPF.FileName.ToString();
            }
            return s;
        }
        public void OpenExcel(string path) {
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(path);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;
            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;
            for (int i = 1; i <= rowCount; i++)
            {
                for (int j = 1; j <= colCount; j++)
                {
                 
                    if (j == 1)
                        Console.Write("\r\n"); 
                    if (xlRange.Cells[i, j] != null && xlRange.Cells[i, j].Value2 != null)
                        MessageBox.Show(xlRange.Cells[i, j].Value2.ToString()); 
                }
            } 
            GC.Collect();
            GC.WaitForPendingFinalizers();
            xlWorkbook.Close();

        }
        public downloadForm()
        {
            InitializeComponent();
            textBoxDron.ReadOnly = true;
            textBoxParts.ReadOnly = true;
            textBoxTech.ReadOnly = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
            
        private void openButtonDron_Click(object sender, EventArgs e)
        {
            textBoxDron.Text = openFolder();
        }

        private void openButtonParts_Click(object sender, EventArgs e)
        {
            textBoxParts.Text = openFolder();
        }

        private void openButtonTech_Click(object sender, EventArgs e)
        {
            textBoxTech.Text = openFolder();
        }

        private void downloadB_Click(object sender, EventArgs e)
        {
            if (textBoxDron.Text.Length > 0)
            {
                OpenExcel(textBoxDron.Text);
            }

         // if (textBoxTech.Text.Length > 0)

          //if (textBoxParts.Text.Length > 0)
        }
    }
}
