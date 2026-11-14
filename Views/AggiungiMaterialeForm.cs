using inventory_tool.Data;
using inventory_tool.Models;
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
    public partial class AggiungiMaterialeForm : Form
    {
        public AggiungiMaterialeForm()
        {
            InitializeComponent();

            esitoPositivo.Visible = false;
            esitoNegativo.Visible = false;

            if (UserSession.Ruolo != "Amministratore" && UserSession.Username == null)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }

            InventoryTheme.ApplyMainShell(this, panel1, panel2, panel3, label1,
                dashboardSideButton, elencoMaterialeSideButton, aggiungiMaterialeSideButton,
                aggiungiMaterialeSideButton);
            InventoryTheme.ApplyAddMaterial(this, descrizioneLabel, quantitaLabel,
                descrizioneInput, quantitaInput, aggiungiMateriale, esitoPositivo, esitoNegativo);

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

        private void AggiungiMaterialeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void aggiungiMateriale_Click(object sender, EventArgs e)
        {
            var descrizione = descrizioneInput.Text;

            try
            {
                var quantita = int.Parse(quantitaInput.Text);

                if (descrizione == "" || quantita <= 0)
                {
                    esitoPositivo.Visible = false;
                    esitoNegativo.Visible = true;
                    return;
                }

                using (var db = new AppDbContext())
                {
                    var amministratore = db.Amministratori.FirstOrDefault(a => a.Username == UserSession.Username);
                    var materiale = new Materiale
                    {
                        Descrizione = descrizione,
                        Quantita = quantita,
                        Amministratore = amministratore,
                        IdAmministratore = amministratore.Id
                    };

                    try
                    {
                        db.Materiali.Add(materiale);
                        db.SaveChanges();
                        esitoPositivo.Visible = true;
                        esitoNegativo.Visible = false;
                    }
                    catch (Exception ex)
                    {
                        esitoPositivo.Visible = false;
                        esitoNegativo.Visible = true;
                    }
                }
            }
            catch (Exception ex) {
                esitoPositivo.Visible = false;
                esitoNegativo.Visible = true;
            }

        }
    }
}
