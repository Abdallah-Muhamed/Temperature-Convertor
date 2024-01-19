using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Convert_Click(object sender, EventArgs e)
        {
            if (temptext == null)
            {
                MessageBox.Show("Please enter the temperature.");
                return;
            }
            if (!(cel.Checked || fah.Checked))
            {
                MessageBox.Show("Please select the temperature type (Celsius or Fahrenheit).");
                return;
            }
            if (choiceBox.SelectedItem == null)
            {
                MessageBox.Show("Please select the conversion type (Celsius or Fahrenheit).");
                return;
            }


            else
            {
                if(choiceBox.SelectedItem == "Fahrenheit" && fah.Checked) 
                {
                    resulttext.Text = temptext.Text.ToString();
                }
                else if (choiceBox.SelectedItem == "Celsius" && cel.Checked)
                {
                    resulttext.Text = temptext.Text.ToString();
                }
                else if(choiceBox.SelectedItem == "Fahrenheit" && cel.Checked)
                {
                    double res = (double.Parse(temptext.Text) - 32) * 5 / 9;
                    resulttext.Text = res.ToString();
                }
                else
                {
                    double res = (double.Parse(temptext.Text) * 9 / 5) + 32;
                    resulttext.Text = res.ToString();
                }
            }
        }

    }
}
