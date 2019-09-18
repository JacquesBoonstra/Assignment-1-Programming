using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string inputStart = txtStartKm.Text;
            double startKm = double.Parse(inputStart);
            string inputEnd = txtEndKm.Text;
            double endKm = double.Parse(inputEnd);
            string inputPrice = txtPriceKm.Text;
            double price = double.Parse(inputPrice);

            double exclVAT = (endKm - startKm) * price;
            string exclVAT2 = exclVAT.ToString();
            lblExcludingVat.Text = exclVAT2;

            double vat = (exclVAT * 0.21);
            string vat2 = vat.ToString();
            lblVAT.Text = vat2;

            double priceVat = (exclVAT + vat);
            string priceVat2 = priceVat.ToString();
            lblIncludingVat.Text = priceVat2;

        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            string txtBoxStartReset = ("0");
            string txtBoxEndReset = ("0");
            string txtBoxPriceReset = ("0");
            string lblExcludingVatReset = ("0");
            string lblVATReset = ("0");
            string lblIncludingVatReset = ("0");

            txtStartKm.Text = txtBoxStartReset;
            txtEndKm.Text = txtBoxEndReset;
            txtPriceKm.Text = txtBoxPriceReset;
            lblExcludingVat.Text = lblExcludingVatReset;
            lblVAT.Text = lblVATReset;
            lblIncludingVat.Text = lblExcludingVatReset;
        }
    }
}
