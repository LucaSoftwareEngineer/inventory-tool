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
        private TextBox ricercaInput;
        private Button cercaButton;
        private Button resetRicercaButton;
        private Button modificaButton;
        private Button rimuoviButton;
        private Label risultatiLabel;

        public ElencoMaterialeForm()
        {
            InitializeComponent();

            if (UserSession.Ruolo != "Amministratore" || string.IsNullOrWhiteSpace(UserSession.Username))
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
                return;
            }

            InventoryTheme.ApplyMainShell(this, panel1, panel2, panel3, label1,
                dashboardSideButton, elencoMaterialeSideButton, aggiungiMaterialeSideButton,
                elencoMaterialeSideButton);
            InventoryTheme.ApplyMaterialList(this, dgvElencoMateriale);
            InizializzaAzioniMateriale();
            CaricaMateriali();

        }

        private void InizializzaAzioniMateriale()
        {
            var ricercaLabel = new Label
            {
                AutoSize = true,
                Text = "Cerca per descrizione",
                ForeColor = Color.FromArgb(99, 115, 139),
                Font = new Font("Segoe UI", 9F, FontStyle.Bold)
            };
            ricercaInput = new TextBox
            {
                Font = new Font("Segoe UI", 10F, FontStyle.Regular),
                BorderStyle = BorderStyle.FixedSingle
            };
            cercaButton = CreaPulsante("Cerca", Color.FromArgb(37, 99, 235), Color.White);
            resetRicercaButton = CreaPulsante("Azzera", Color.White, Color.FromArgb(22, 34, 55));
            resetRicercaButton.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            modificaButton = CreaPulsante("Modifica selezionato", Color.FromArgb(37, 99, 235), Color.White);
            rimuoviButton = CreaPulsante("Rimuovi selezionato", Color.FromArgb(185, 28, 28), Color.White);
            modificaButton.Enabled = false;
            rimuoviButton.Enabled = false;
            risultatiLabel = new Label
            {
                AutoSize = false,
                ForeColor = Color.FromArgb(99, 115, 139),
                Font = new Font("Segoe UI", 9F, FontStyle.Regular)
            };

            Controls.Add(ricercaLabel);
            Controls.Add(ricercaInput);
            Controls.Add(cercaButton);
            Controls.Add(resetRicercaButton);
            Controls.Add(modificaButton);
            Controls.Add(rimuoviButton);
            Controls.Add(risultatiLabel);

            cercaButton.Click += delegate { CaricaMateriali(); };
            resetRicercaButton.Click += delegate
            {
                ricercaInput.Clear();
                CaricaMateriali();
            };
            ricercaInput.KeyDown += delegate (object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    CaricaMateriali();
                    e.SuppressKeyPress = true;
                }
            };
            dgvElencoMateriale.SelectionChanged += delegate { AggiornaAzioni(); };
            modificaButton.Click += ModificaMateriale_Click;
            rimuoviButton.Click += RimuoviMateriale_Click;
            Resize += delegate { DisponiAzioniMateriale(ricercaLabel); };
            DisponiAzioniMateriale(ricercaLabel);
        }

        private static Button CreaPulsante(string testo, Color sfondo, Color testoColore)
        {
            var button = new Button
            {
                Text = testo,
                BackColor = sfondo,
                ForeColor = testoColore,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 78, 216);
            return button;
        }

        private void DisponiAzioniMateriale(Label ricercaLabel)
        {
            const int left = 264;
            int availableWidth = ClientSize.Width - left - 40;
            int searchWidth = availableWidth - 216;
            ricercaLabel.SetBounds(left, 78, 260, 20);
            ricercaInput.SetBounds(left, 101, searchWidth, 36);
            cercaButton.SetBounds(left + searchWidth + 10, 99, 96, 40);
            resetRicercaButton.SetBounds(left + searchWidth + 112, 99, 104, 40);
            dgvElencoMateriale.SetBounds(left, 151, availableWidth, ClientSize.Height - 256);
            risultatiLabel.SetBounds(left, ClientSize.Height - 68, availableWidth - 340, 32);
            modificaButton.SetBounds(left + availableWidth - 328, ClientSize.Height - 70, 154, 40);
            rimuoviButton.SetBounds(left + availableWidth - 164, ClientSize.Height - 70, 164, 40);
        }

        private void CaricaMateriali()
        {
            try
            {
                var materiali = ElencoMaterialeService.GetElencoMateriale(ricercaInput.Text);
                dgvElencoMateriale.DataSource = materiali;
                if (dgvElencoMateriale.Columns.Contains("Id"))
                {
                    dgvElencoMateriale.Columns["Id"].Visible = false;
                }

                risultatiLabel.Text = materiali.Count == 0
                    ? "Nessun materiale trovato."
                    : materiali.Count == 1 ? "1 materiale" : materiali.Count + " materiali";
                AggiornaAzioni();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Impossibile caricare i materiali: " + ex.Message,
                    "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private MaterialeViewModel MaterialeSelezionato()
        {
            if (dgvElencoMateriale.CurrentRow == null)
            {
                return null;
            }

            return dgvElencoMateriale.CurrentRow.DataBoundItem as MaterialeViewModel;
        }

        private void AggiornaAzioni()
        {
            bool materialeSelezionato = MaterialeSelezionato() != null;
            modificaButton.Enabled = materialeSelezionato;
            rimuoviButton.Enabled = materialeSelezionato;
        }

        private void ModificaMateriale_Click(object sender, EventArgs e)
        {
            var materiale = MaterialeSelezionato();
            if (materiale == null)
            {
                return;
            }

            using (var form = new ModificaMaterialeForm(materiale))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    CaricaMateriali();
                }
            }
        }

        private void RimuoviMateriale_Click(object sender, EventArgs e)
        {
            var materiale = MaterialeSelezionato();
            if (materiale == null)
            {
                return;
            }

            var conferma = MessageBox.Show(this,
                "Vuoi rimuovere il materiale \"" + materiale.Descrizione + "\"?",
                "Conferma rimozione", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (conferma != DialogResult.Yes)
            {
                return;
            }

            try
            {
                if (!ElencoMaterialeService.DeleteMateriale(materiale.Id))
                {
                    MessageBox.Show(this, "Il materiale non è più disponibile o non appartiene all'utente corrente.",
                        "Rimozione non riuscita", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CaricaMateriali();
                    return;
                }

                CaricaMateriali();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Impossibile rimuovere il materiale: " + ex.Message,
                    "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
