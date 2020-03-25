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
            Form2 form = new Form2();
            
            form.ShowDialog();
            //this.Close();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            downloadForm form = new downloadForm();
            
            form.ShowDialog();
            //this.Close();

        }
    }
}
