using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CyberCrypt;
using inventory_tool.Data;
using inventory_tool.Services;

namespace inventory_tool
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            LoginNegato.Visible = false;
            LoginEseguito.Visible = false;
        }

        private void accediButton_Click(object sender, EventArgs e)
        {
            var username = usernameInput.Text;
            var password = _SHA.SHA512Hash(passwordInput.Text);

            if (LoginService.login(username, password))
            {
                LoginNegato.Visible = false;
                LoginEseguito.Visible = true;
            } else
            {
                LoginNegato.Visible = true;
                LoginEseguito.Visible = false;
            }

        }
    }
}
