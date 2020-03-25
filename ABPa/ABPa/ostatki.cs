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
    }
}
