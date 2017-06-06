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
    public partial class TemperatureConversion : Form
    {
        public TemperatureConversion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                label2.Text = String.Format("Celsius: {0:0.#}", (5.0 / 9) * (Convert.ToInt32(textBox1.Text) - 32));
            }
            catch (Exception ex)
            {
                label2.Text =(""+ex);
            }
            
        }
    }
}
