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
    public partial class Form2 : Form
    {
        public Form2()
        {
            DateTime thisDay = DateTime.Today;
            InitializeComponent();
            label1.Text = "Поступление комплектующих №"+1+" от "+ thisDay.ToString("d");
        }

        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
