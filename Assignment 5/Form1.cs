using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string input1 = txtNr1.Text;
            int nr1 = int.Parse(input1);
            string input2 = txtNr2.Text;
            int nr2 = int.Parse(input2);
            string input3 = txtNr3.Text;
            int nr3 = int.Parse(input3);

            int average = (nr1 + nr2 + nr3) / 3;

            lblAverage.Text = average.ToString();
            
        }
    }
}
