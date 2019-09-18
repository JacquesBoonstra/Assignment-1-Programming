using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string input = txtSeconds.Text;
            int seconds = int.Parse(input);

            int hours = seconds / 3600;
            int minutes = (seconds - hours * 3600) / 60;
            int seconds2 = ((seconds - hours * 3600) / 60) * 1;

            
            string end = (hours + ":" + minutes + ":" + seconds2);
            lblEnd.Text = end;
        }
    }
}
