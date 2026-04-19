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

            using (var db = new AppDbContext())
            {
                dgvElencoMateriale.DataSource = (from m in db.Materiali
                                                join a in db.Amministratori on m.IdAmministratore equals a.Id
                                                where a.Username == UserSession.Username
                                                select new
                                                {
                                                    m.Id,
                                                    m.Descrizione,
                                                    m.Quantita,
                                                    Amministratore = a.Nome + " " + a.Cognome
                                                }).ToList();
            }

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
