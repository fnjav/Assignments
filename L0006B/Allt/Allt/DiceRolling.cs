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
    public partial class DiceRolling : Form
    {
        private List<int> results = new List<int>(new int[11]);

        public DiceRolling()
        {
            InitializeComponent();
        }

        public void RollDice(int numberOfRolls)
        {
            Random rnd = new Random();
            for (int i = numberOfRolls; i > 1; i--)
            {
                int roll1 = rnd.Next(1, 7);
                AddResultToList(roll1 + rnd.Next(1, 7));                
            }            
        }

        public void AddResultToList(int result)
        {
            switch(result)
            {
                case 2:
                    results[0]++;
                    break;
                case 3:
                    results[1]++;
                    break;
                case 4:
                    results[2]++;
                    break;
                case 5:
                    results[3]++;
                    break;
                case 6:
                    results[4]++;
                    break;
                case 7:
                    results[5]++;
                    break;
                case 8:
                    results[6]++;
                    break;
                case 9:
                    results[7]++;
                    break;
                case 10:
                    results[8]++;
                    break;
                case 11:
                    results[9]++;
                    break;
                case 12:
                    results[10]++;
                    break;
                default:
                    break;
            }
                
        }

        public void PrintFinalResult()
        {
            richTextBox1.Text = "Value:\t2\t3\t4\t5\t6\t7\t8\t9\t10\t11\t12\nNumber:\t";
            for (int j = 0; j < results.Count; j++)
            {

                richTextBox1.Text += results[j] + "\t";

                // Annan variant
                //richTextBox1.Text += "Number of " + (j + 2) + ":\t " + results[j] + "\n";
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            RollDice(Convert.ToInt32(textBox1.Text));
            PrintFinalResult();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
