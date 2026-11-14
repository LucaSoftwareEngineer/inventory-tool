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
using inventory_tool.Views;

namespace inventory_tool
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            LoginNegato.Visible = false;
            LoginEseguito.Visible = false;
            Views.InventoryTheme.ApplyLogin(this, label1, label2, usernameInput, passwordInput,
                accediButton, LoginNegato, LoginEseguito);
        }

        private async void accediButton_Click(object sender, EventArgs e)
        {
            var username = usernameInput.Text;
            var password = _SHA.SHA512Hash(passwordInput.Text);

            if (LoginService.login(username, password))
            {
                LoginNegato.Visible = false;
                LoginEseguito.Visible = true;
                
                await Task.Delay(3000);

                DashboardForm dashboardForm = new DashboardForm();
                dashboardForm.Show();
                this.Hide();

            } else
            {
                LoginNegato.Visible = true;
                LoginEseguito.Visible = false;
            }

        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
