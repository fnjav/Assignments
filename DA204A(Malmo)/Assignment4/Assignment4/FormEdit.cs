using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class FormEdit : Form
    {
        public string Value { get; set; }

        public FormEdit()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Value = txtValue.Text;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
