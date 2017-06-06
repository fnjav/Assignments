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
    public partial class StatesForm : Form
    {
        public StatesForm()
        {
            InitializeComponent();
            
            string[] states = { "New Jersey", "Idaho", "Illinois",
                                "Indiana", "Iowa", "Kansas", "Kentucky", "Maryland",
                                "Massachusetts", "Michigan", "Wisconsin", "Wyoming",
                                "Oregon", "Pennsylvania", "Rhode Island" };

            comboBox1.Items.AddRange(states);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count > 1)
            {
                listBox1.Items.Add(comboBox1.GetItemText(comboBox1.SelectedItem).ToString());
                comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Only one remaining, form closing", "Järnspikar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                //Application.Exit(); //Stänger av hela applikationen
            }
        }
    }
}
