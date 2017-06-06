using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Allt
{
    public partial class LoginPasswordUserControl : UserControl
    {
        public string Login
        {
            get { return loginTextBox.Text; }
            private set { Login = loginTextBox.Text; }
        }

        public string Password
        {
            get { return passwordTextBox.Text; }
            private set { Password = passwordTextBox.Text; }
        }

        public LoginPasswordUserControl()
        {
            InitializeComponent();
        }

        private void LoginPasswordUderControl_Load(object sender, EventArgs e)
        {

        }
    }
}
