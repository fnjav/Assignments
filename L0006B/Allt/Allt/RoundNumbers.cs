using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Allt
{
    public partial class RoundNumbers : Form
    {
        public RoundNumbers()
        {
            InitializeComponent();
        }

        public int RoundToInteger(double num)
        {
            return (int)num;
        }

        public double RoundToTenths(double num)
        {
            return Math.Floor(num * 10 + 0.5) / 10;
        }

        public double RoundToHundredths(double num)
        {
            return Math.Floor(num * 100 + 0.5) / 100;
        }

        public double RoundToThousandths(double num)
        {
            return Math.Floor(num * 1000 + 0.5) / 1000;
        }



        private void button1_Click(object sender, EventArgs e)
        {            
            double tmp = Convert.ToDouble(textBox1.Text);
            label6.Text = "Original value: " + tmp;
            label2.Text = "Integer: " + RoundToInteger(tmp);
            label3.Text = "Tenths: " + RoundToTenths(tmp);
            label4.Text = "Hundredths: " + RoundToHundredths(tmp);
            label5.Text = "Thousandths: " + RoundToThousandths(tmp);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
