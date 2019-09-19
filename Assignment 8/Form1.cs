using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string inputTShirts = txtBoxTShirts.Text;
            double inputTShirts1 = double.Parse(inputTShirts);
            string inputJeans = txtBoxJeans.Text;
            double inputJeans1 = double.Parse(inputJeans);

            double priceTShirts = inputTShirts1 * 30;
            double priceJeans = inputJeans1 * 100;
            double price = priceTShirts + priceJeans;

            string price1 = price.ToString();
            lblPrice.Text = ("$" + price1);

            double vat = price * 0.21;
            string vat1 = vat.ToString();
            lblVAT.Text = ("$" + vat1);

            double totalPrice = price + vat;
            string totalPrice1 = totalPrice.ToString();
            lblTotalPrice.Text = ("$" + totalPrice1);

            lblDate.Text = DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
