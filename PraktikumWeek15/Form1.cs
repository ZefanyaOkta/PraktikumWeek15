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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string total;
        private void radioButtonMakanan_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMakanan.Checked == true)
            {
                groupBoxMinuman.Visible = false;
                comboBoxItems.Items.Clear();
                comboBoxItems.Items.Add("Nasi Goreng");
                comboBoxItems.Items.Add("Nasi Goreng Spesial");
                comboBoxItems.Items.Add("Nasi Goreng Pete");
                comboBoxItems.Items.Add("Ayam Bakar");
                comboBoxItems.Show();
            }
        }

        private void radioButtonMinuman_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMinuman.Checked == true)
            {
                labelNominal.Text = ". . . .";
                comboBoxItems.Items.Clear();
                groupBoxMinuman.Visible = true;
                comboBoxItems.Items.Clear();
                comboBoxItems.Items.Add("Es Teh");
                comboBoxItems.Items.Add("Teh Hangat");
                comboBoxItems.Items.Add("Nutrisari");
                comboBoxItems.Items.Add("Aqua");
            }
        }

        private void comboBoxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioButtonMakanan.Checked == true)
            {
                groupBoxMinuman.Visible = false;
                labelNominal.Text = ". . . .";
                if (comboBoxItems.SelectedIndex == 0)
                {
                    labelNominal.Text = "10.000";
                }
                if (comboBoxItems.SelectedIndex == 1)
                {
                    labelNominal.Text = "12.000";
                }
                if (comboBoxItems.SelectedIndex == 2)
                {
                    labelNominal.Text = "15.000";
                }
                if (comboBoxItems.SelectedIndex == 3)
                {
                    labelNominal.Text = "15.000";
                }
            }
        }

        private void radioButtonNormal_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMinuman.Checked == true)
            {
                labelNominal.Text = ". . . .";
                if (comboBoxItems.SelectedIndex == 0)
                {
                    labelNominal.Text = "5.000";
                }
                if (comboBoxItems.SelectedIndex == 1)
                {
                    labelNominal.Text = "3.000";
                }
                if (comboBoxItems.SelectedIndex == 2)
                {
                    labelNominal.Text = "6.000";
                }
                if (comboBoxItems.SelectedIndex == 3)
                {
                    labelNominal.Text = "2.000";
                }
            }
        }

        private void radioButtonJumbo_CheckedChanged(object sender, EventArgs e)
        {
            labelNominal.Text = ". . . .";
            if (radioButtonMinuman.Checked == true)
            {
                if (comboBoxItems.SelectedIndex == 0)
                {
                    labelNominal.Text = "7.000";
                }
                if (comboBoxItems.SelectedIndex == 1)
                {
                    labelNominal.Text = "5.000";
                }
                if (comboBoxItems.SelectedIndex == 2)
                {
                    labelNominal.Text = "10.000";
                }
                if (comboBoxItems.SelectedIndex == 3)
                {
                    labelNominal.Text = "5.000";
                }
            }
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            listBoxItems.Items.Add(comboBoxItems.SelectedItem.ToString());
            listBoxHarga.Items.Add(labelNominal.Text);
            buttonDelete.Enabled = true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonCheckOut_Click(object sender, EventArgs e)
        {
            if (listBoxItems.Items.Count == 0)
            {
                MessageBox.Show("Choose Menu !");
            }
            else
            {
                Form2 formbaru = new Form2();
                formbaru.Show();
            }
        }
    }
}
