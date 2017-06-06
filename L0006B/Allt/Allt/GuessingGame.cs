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
    public partial class GuessingGame : Form
    {
        Random rnd = new Random();
        int value;
        int lastGuessDifference;

        public GuessingGame()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartGame();
            button1.Enabled = false;
            textBox1.ReadOnly = false;
            textBox1.Text = "";
            label2.Text = "";
        }

        public void StartGame()
        {
            this.BackColor = SystemColors.Control;            
            value = rnd.Next(1, 1001);   
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox1.SelectAll();
                try
                {
                    NextGuess(Convert.ToInt32(textBox1.Text));
                }
                catch
                {
                    label2.Text = String.Format("Error! Try again!");
                }
                e.SuppressKeyPress = true;
            }
        }

        private void NextGuess(int input)
        {
            if (input == value)
            {
                label2.Text = "Correct!";
                textBox1.ReadOnly = true;
                button1.Enabled = true;
                this.BackColor = Color.LawnGreen;
            }
            else if (input < value)
            {
                label2.Text = "Too low!";
                if (value-input > lastGuessDifference)
                {
                    this.BackColor = Color.SkyBlue;
                }
                else
                {
                    this.BackColor = Color.Red;
                }
                lastGuessDifference = value - input;
            }
            else
            {
                label2.Text = "Too high!";
                if (input-value > lastGuessDifference)
                    {
                        this.BackColor = Color.SkyBlue;
                    }
                    else
                    {
                        this.BackColor = Color.Red;
                    }
                lastGuessDifference = input - value;
            }
                  
        }

    }
}
