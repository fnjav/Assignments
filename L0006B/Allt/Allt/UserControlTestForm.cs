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
    public partial class UserControlTestForm : Form
    {
        public UserControlTestForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (myLogin.Login != "" || myLogin.Password != "")
            {
                label1.Text = "Information entered";
                label2.Text = "Login: " + myLogin.Login;
                label3.Text = "Password: " + myLogin.Password;
            }
            else
            {
                label1.Text = "Enter information above";
                label2.Text = "";
                label3.Text = "";
            }
        }

        private void UserControlTestForm_Load(object sender, EventArgs e)
        {

        }
    }
}
