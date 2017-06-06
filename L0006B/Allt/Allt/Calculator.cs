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
    /// <summary>
    /// Simple calculator
    /// Not too pretty code :(
    /// 
    /// BUG: C\A can't remove +, -, * or /
    /// </summary>
    public partial class Calculator : Form
    {
        string _input ="", _part1 ="", _part2 ="";     // Empty to avoid null
        char _operation; 

        /// <summary>
        /// Calculates the result
        /// </summary>
        /// <param name="c">The operation</param>
        /// <param name="a">Part 1 of the calculation</param>
        /// <param name="b">Part 2 of the calculation</param>
        /// <returns>Result as double</returns>
        private string CalculateResult(char c, string a, string b)
        {
            double d1, d2, result;
            if (a.Equals("") && b.Equals("")) // If both parts are empty
            {
                return "";
            }
            else if (a.Equals(""))          // Part 1 empty
            {
                return b;
            }
            else if (b.Equals(""))          // Part 2 empty
            {
                return a;
            }            
            d1 = double.Parse(a);
            d2 = double.Parse(b);
            switch (c)      // Actual calculation here
            {
                case '+':
                    result = d1 + d2;
                    break;
                case '-':
                    result = d1 - d2;
                    break;
                case '*':
                    result = d1 * d2;
                    break;
                case '/':
                    if (d2 == 0)
                    {
                        MessageBox.Show("Division by zero is not defined!", "Järnspikar!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return "";
                    }
                    result = d1 / d2;
                    break;
                default:            // I don't even know if this is needed
                    return "";
            }
            return result.ToString();
        }

        // Auto generated, adds 1 to input as string
        private void button1_Click(object sender, EventArgs e)
        {
            _input += "1";
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _input += "2";
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _input += "3";
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _input += "4";
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _input += "5";
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            _input += "6";
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            _input += "7";
            textBox1.Text +="7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            _input += "8";
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            _input += "9";
            textBox1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            _input += "0";
            textBox1.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            _input += "00";
            textBox1.Text += "00";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            _part1 = CalculateResult(_operation, _part1, _input);  // In case of more than one operation, 1*2*3 for example
            _input = "";                                             // There's probably lot of better way to handle multiple operations
            _operation = '+';
            textBox1.Text = _part1 + " + ";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            _part1 = CalculateResult(_operation, _part1, _input);
            _input = "";
            _operation = '-';
            textBox1.Text = _part1 + " - ";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            _part1 = CalculateResult(_operation, _part1, _input); 
            _input = "";
            _operation = '*';
            textBox1.Text = _part1 + " * ";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            _part1 = CalculateResult(_operation, _part1, _input);
            _input = "";
            _operation = '/';
            textBox1.Text = _part1 + " / ";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            _input += ".";
            textBox1.Text = _input;
        }

        // Equals
        private void button17_Click(object sender, EventArgs e)
        {
            _part2 = _input;
            _input = ""; //reset input
            _part1 = CalculateResult(_operation, _part1, _part2); // Part 1 = answer
            textBox1.Text = _part1;

        }

        // Clears everything
        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            _input = "";
            _part1 = "";
            _part2 = "";
        }

        // Removes last char
        private void button19_Click(object sender, EventArgs e)
        {
            if (_input.Length > 0)
            {
                _input = _input.Substring(0, _input.Length - 1);
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public Calculator()
        {
            InitializeComponent();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
