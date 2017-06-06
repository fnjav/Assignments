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
    public partial class ExceptionThrower : Form
    {
        public ExceptionThrower()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThrowRandomException();
        }

        public void ThrowRandomException()
        {
            Random rnd = new Random();
            int rndNum = rnd.Next(0, 8);

            switch (rndNum)
            {
                case 0:
                    try
                    {
                        throw new NullReferenceException();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case 1:
                    try
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case 2:
                    try
                    {
                        throw new InvalidAsynchronousStateException();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case 3:
                    try
                    {
                        throw new InvalidExpressionException();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case 4:
                    try
                    {
                        throw new IndexOutOfRangeException();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case 5:
                    try
                    {
                        throw new InvalidOperationException();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case 6:
                    try
                    {
                        throw new ArgumentNullException();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case 7:
                    try
                    {
                        throw new AccessViolationException();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }
        }


            


    }
}
