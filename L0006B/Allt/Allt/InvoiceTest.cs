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
    public partial class InvoiceTest : Form
    {
        public InvoiceTest()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Invoice invoice = new Invoice(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text), Convert.ToDecimal(textBox4.Text));

                richTextBox1.Text = String.Format("Number: {0}\nDescription: {1}\nQuantity: {2}\nPrice per item: {3}\nTotal cost: {4}",
                    invoice.Number, invoice.Description, invoice.Quantity, invoice.Price, invoice.GetInvoiceAmount());

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";

            }
            catch
            {
                richTextBox1.Text = "Error";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
