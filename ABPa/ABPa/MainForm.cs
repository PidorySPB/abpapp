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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form = new Form2();
            form.ShowDialog();
            this.Show();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            downloadForm form = new downloadForm();
            form.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ostatki form = new ostatki();
            form.ShowDialog();
            this.Show();


        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
