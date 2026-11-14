using inventory_tool.Data;
using inventory_tool.Services;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace inventory_tool.Views
{
    internal sealed class ModificaMaterialeForm : Form
    {
        private readonly MaterialeViewModel materiale;
        private readonly TextBox descrizioneInput;
        private readonly NumericUpDown quantitaInput;

        internal ModificaMaterialeForm(MaterialeViewModel materiale)
        {
            if (materiale == null)
            {
                throw new ArgumentNullException("materiale");
            }

            this.materiale = materiale;
            Text = "Modifica materiale";
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            ShowInTaskbar = false;
            ClientSize = new Size(480, 290);
            BackColor = Color.FromArgb(245, 247, 251);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular);

            var descrizioneLabel = new Label
            {
                AutoSize = true,
                Text = "Descrizione",
                ForeColor = Color.FromArgb(99, 115, 139),
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Location = new Point(32, 32)
            };
            descrizioneInput = new TextBox
            {
                Text = materiale.Descrizione,
                BackColor = Color.White,
                ForeColor = Color.FromArgb(22, 34, 55),
                BorderStyle = BorderStyle.FixedSingle,
                Font = new Font("Segoe UI", 11F, FontStyle.Regular),
                Location = new Point(32, 60),
                Size = new Size(416, 34)
            };

            var quantitaLabel = new Label
            {
                AutoSize = true,
                Text = "Quantità",
                ForeColor = Color.FromArgb(99, 115, 139),
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Location = new Point(32, 117)
            };
            quantitaInput = new NumericUpDown
            {
                Minimum = 1,
                Maximum = int.MaxValue,
                Value = Math.Max(1, materiale.Quantita),
                Font = new Font("Segoe UI", 11F, FontStyle.Regular),
                Location = new Point(32, 145),
                Size = new Size(416, 34),
                ThousandsSeparator = true
            };

            var annullaButton = new Button
            {
                Text = "Annulla",
                DialogResult = DialogResult.Cancel,
                Location = new Point(232, 220),
                Size = new Size(104, 40),
                BackColor = Color.White,
                ForeColor = Color.FromArgb(22, 34, 55),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            annullaButton.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);

            var salvaButton = new Button
            {
                Text = "Salva modifiche",
                Location = new Point(344, 220),
                Size = new Size(104, 40),
                BackColor = Color.FromArgb(37, 99, 235),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            salvaButton.FlatAppearance.BorderSize = 0;
            salvaButton.Click += SalvaButton_Click;

            Controls.Add(descrizioneLabel);
            Controls.Add(descrizioneInput);
            Controls.Add(quantitaLabel);
            Controls.Add(quantitaInput);
            Controls.Add(annullaButton);
            Controls.Add(salvaButton);
            AcceptButton = salvaButton;
            CancelButton = annullaButton;
        }

        private void SalvaButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(descrizioneInput.Text))
            {
                MessageBox.Show(this, "Inserisci una descrizione.", "Dato mancante",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                descrizioneInput.Focus();
                return;
            }

            try
            {
                if (!ElencoMaterialeService.UpdateMateriale(materiale.Id,
                    descrizioneInput.Text, (int)quantitaInput.Value))
                {
                    MessageBox.Show(this, "Il materiale non è più disponibile o non appartiene all'utente corrente.",
                        "Modifica non riuscita", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Impossibile salvare le modifiche: " + ex.Message,
                    "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
