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
    public partial class CheckBoxTestForm : Form
    {
        public CheckBoxTestForm()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font,
                label1.Font.Style ^ FontStyle.Bold);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font,
                label1.Font.Style ^ FontStyle.Italic);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font,
                label1.Font.Style ^ FontStyle.Underline);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font,
                label1.Font.Style ^ FontStyle.Strikeout);
        }
    }
}
