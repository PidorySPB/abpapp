﻿using System;
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
using MySql.Data.MySqlClient;

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
        public void OpenExcel(string path,int textbox) {
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(path);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;
            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;
            var dbCon = DBConn.Instance();
            dbCon.DatabaseName = "570_abp";
            dbCon.Host = "5.187.7.31";
            string query = "";
            if (dbCon.IsConnect())
            {
                if (textbox == 1)
                {
                    try
                    {
                        for (int i = 2; i <= rowCount; i++)
                        {

                            query = String.Format("INSERT INTO parts(name, category) VALUES('{0}','{1}')", xlRange.Cells[i, 2].Value2.ToString(), xlRange.Cells[i, 3].Value2.ToString());
                            var cmd = new MySqlCommand(query, dbCon.Connection);
                            cmd.ExecuteNonQuery();

                            /* for (int j = 1; j <= colCount; j++)
                            {

                                if (xlRange.Cells[i, j] != null && xlRange.Cells[i, j].Value2 != null)
                                    MessageBox.Show(xlRange.Cells[i, j].Value2.ToString());
                            }*/
                        }
                    }
                    catch (MySqlException err)
                    {
                        MessageBox.Show("MysqlError: " + err.ToString());
                    }
                    textBoxDron.Text = "Данные успешно добавились";
                }
                if (textbox == 0)
                {
                    for (int i = 2; i <= rowCount; i++)
                    {
                        try
                        {
                            int num;
                            if (Int32.TryParse(xlRange.Cells[i, 3].Value2.ToString(), out num))
                            {
                                query = String.Format("INSERT INTO spisokDronov(name, cost) VALUES('{0}','{1}')", xlRange.Cells[i, 2].Value2.ToString(), xlRange.Cells[i, 3].Value2.ToString());
                                var cmd = new MySqlCommand(query, dbCon.Connection);
                                cmd.ExecuteNonQuery();
                            }
                        }
                        catch (MySqlException err)
                        {
                            MessageBox.Show("MysqlError: " + err.ToString());
                            return;
                        }
                        /* for (int j = 1; j <= colCount; j++)
                        {

                            if (xlRange.Cells[i, j] != null && xlRange.Cells[i, j].Value2 != null)
                                MessageBox.Show(xlRange.Cells[i, j].Value2.ToString());
                        }*/
                    }
                    textBoxDron.Text = "Данные успешно добавились";
                }
                if (textbox == 2)
                {
                    for (int i = 2; i <= rowCount; i++)
                    {
                        try
                        {
                            int num;
                            if (Int32.TryParse(xlRange.Cells[i, 4].Value2.ToString(), out num))
                            {
                                query = String.Format("INSERT INTO technologicalMap(dron, detail, count) VALUES('{0}','{1}','{2}')", xlRange.Cells[i, 2].Value2.ToString(), xlRange.Cells[i, 3].Value2.ToString(), xlRange.Cells[i, 4].Value2.ToString());

                                var cmd = new MySqlCommand(query, dbCon.Connection);
                                cmd.ExecuteNonQuery();
                            }
                        }
                        catch (MySqlException err)
                        {
                            MessageBox.Show("MysqlError: " + err.ToString());
                            return;
                        }
                        /* for (int j = 1; j <= colCount; j++)
                        {

                            if (xlRange.Cells[i, j] != null && xlRange.Cells[i, j].Value2 != null)
                                MessageBox.Show(xlRange.Cells[i, j].Value2.ToString());
                        }*/
                    }
                    textBoxDron.Text = "Данные успешно добавились";
                }
            }
            else 
            {
                MessageBox.Show("Ошибка связи с сервером");
            }
            dbCon.Close();
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
            textBoxDron.Text = "Выбор файла";
            textBoxParts.Text = "Выбор файла";
            textBoxTech.Text = "Выбор файла";
            textBoxDron.ForeColor = Color.LightGray;
            textBoxParts.ForeColor = Color.LightGray;
            textBoxTech.ForeColor = Color.LightGray;

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
            int c = 0;
            if (textBoxDron.Text != "Выбор файла" && textBoxDron.Text != "Данные успешно добавились")
            {
                OpenExcel(textBoxDron.Text,0);
                c++;
            }
            if (textBoxParts.Text != "Выбор файла" && textBoxParts.Text!= "Данные успешно добавились")
            {
                OpenExcel(textBoxParts.Text, 1);
                c++;
            }
            if (textBoxTech.Text != "Выбор файла" && textBoxTech.Text != "Данные успешно добавились")
            {
                OpenExcel(textBoxTech.Text, 2);
                c++;
            }

            if (c == 0)
            {
                MessageBox.Show("Нужно выбрать файл");
            } 
         // if (textBoxTech.Text.Length > 0)

          //if (textBoxParts.Text.Length > 0)
        }

        private void closeB_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
