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
    public partial class PigLatin : Form
    {
        public PigLatin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void Start()
        {
            string[] arr = textBox1.Text.ToLower().Split();
            string output = "";

            foreach (string word in arr)
            {
                output += getPigLatin(word) + " ";
            }

            richTextBox1.Text += output + "\n";

        }

        private string getPigLatin(string word)
        {
            return word.Substring(1, word.Length-1) + word[0] + "ay";           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            textBox1.Text = "";
        }
    }
}
