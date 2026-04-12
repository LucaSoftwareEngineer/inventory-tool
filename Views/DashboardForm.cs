using inventory_tool.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory_tool.Views
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();

            if (UserSession.Ruolo != "Amministratore" && UserSession.Username == null)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }

            benvenutoLabel.Text = $"Bentornato, {UserSession.Username}! \nSeleziona un'opzione dal menu a sinistra.";
            benvenutoLabel.Font = new Font("Arial", 14, FontStyle.Bold);

        }

        private void DashboardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void aggiungiMaterialeSideButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AggiungiMaterialeForm aggiungiMaterialeForm = new AggiungiMaterialeForm();
            aggiungiMaterialeForm.Show();
        }

        private void elencoMaterialeSideButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ElencoMaterialeForm elencoMaterialeForm = new ElencoMaterialeForm();
            elencoMaterialeForm.Show();
        }

        private void dashboardSideButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardForm dashboardForm = new DashboardForm();
            dashboardForm.Show();
        }
    }
}
