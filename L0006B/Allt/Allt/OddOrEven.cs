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
    public partial class OddOrEven : Form
    {
        public OddOrEven()
        {
            InitializeComponent();
        }        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int tmp = Convert.ToInt32(textBox1.Text);
                int odd = tmp % 2;
                switch (odd)
                {
                    case 0:
                        label2.Text = tmp + " is even";
                        break;
                    case 1:
                        label2.Text = tmp + " is odd";
                        break;
                    default:
                        label2.Text = "Something went wrong";
                        break;
                }
            }
            catch
            {
                label2.Text = "That's not an integer";
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void OddOrEven_Load(object sender, EventArgs e)
        {

        }
    }
}
