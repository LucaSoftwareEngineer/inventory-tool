using inventory_tool.Data;
using inventory_tool.Services;
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
    public partial class ElencoMaterialeForm : Form
    {
        public ElencoMaterialeForm()
        {
            InitializeComponent();

            if (UserSession.Ruolo != "Amministratore" && UserSession.Username == null)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }

            dgvElencoMateriale.DataSource = ElencoMaterialeService.GetElencoMateriale();
            InventoryTheme.ApplyMainShell(this, panel1, panel2, panel3, label1,
                dashboardSideButton, elencoMaterialeSideButton, aggiungiMaterialeSideButton,
                elencoMaterialeSideButton);
            InventoryTheme.ApplyMaterialList(this, dgvElencoMateriale);

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

        private void ElencoMaterialeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
