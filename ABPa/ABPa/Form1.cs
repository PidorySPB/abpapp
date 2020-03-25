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
        public downloadForm()
        {
            InitializeComponent();
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
    }
}
