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
    public partial class StudentGrades : Form
    {
        public StudentGrades()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string output ="";

            try
            {
                output = System.IO.File.ReadAllText(@"..\..\..\data.txt");
            }
            catch
            {
                // Do nothing, no file found
            }

            output += string.Format("{0};{1};{2};{3};{4}\r\n", textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            string path = @"..\..\..\data.txt";
            System.IO.File.WriteAllText(path, output);
            label6.Text = "Entry Saved";

            //Reset textboxes
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = ""; // Clear before load
            foreach (string line in System.IO.File.ReadLines(@"..\..\..\data.txt"))
            {
                string[] arr = line.Split(';');
                richTextBox1.Text += arr[0] + ", ";
                richTextBox1.Text += arr[1] + ":\t";
                richTextBox1.Text += arr[2] + "\t";
                richTextBox1.Text += arr[3] + "\t";
                richTextBox1.Text += arr[4] + "\n";
            }
            label6.Text = "File Loaded";
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveAs();
        }

        // Kopierar data.txt till valfritt ställe och namn
        private void saveAs()
        {
            label6.Text = "Saved";
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = "name.txt";
            savefile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (savefile.ShowDialog() == DialogResult.OK)
            {                
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(savefile.FileName))sw.Write(System.IO.File.ReadAllText(@"..\..\..\data.txt"));
            }
        }
    }
}
