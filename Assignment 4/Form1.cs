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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnDetermine_Click(object sender, EventArgs e)
        {
            string input = txtPrice.Text;
            int price = int.Parse(input);

          
            double vat = price * 0.21;
            double total = vat + price;

            lblPrice.Text = price.ToString("0.00");
            lblVat.Text = vat.ToString("0.00");
            lblTotal.Text = total.ToString("0.00");
        }
    }
}
