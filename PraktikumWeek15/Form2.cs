using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PraktikumWeek15
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void checkBoxDiskon_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxDiskon.Visible = true;
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            labelSubtotal.Text = Form1.total;
        }
    }
}
