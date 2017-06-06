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
    public partial class CompareWords : Form
    {
        public CompareWords()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Compare();
        }

        public void Compare()
        {
            if (textBox1.Text.CompareTo(textBox2.Text) == textBox2.Text.CompareTo(textBox1.Text))
            {
                label1.Text = textBox1.Text + " IS EQUAL TO " + textBox2.Text;
            }
            else if (textBox1.Text.CompareTo(textBox2.Text) < textBox2.Text.CompareTo(textBox1.Text))
            {
                label1.Text = textBox1.Text + " IS LESS THAN " + textBox2.Text;
            }
            else if (textBox1.Text.CompareTo(textBox2.Text) > textBox2.Text.CompareTo(textBox1.Text))
            {
                label1.Text = textBox1.Text + " IS GREATER THAN " + textBox2.Text;
            }
        }
    }
}
