namespace inventory_tool.Views
{
    partial class AggiungiMaterialeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dashboardSideButton = new System.Windows.Forms.Button();
            this.aggiungiMaterialeSideButton = new System.Windows.Forms.Button();
            this.elencoMaterialeSideButton = new System.Windows.Forms.Button();
            this.descrizioneInput = new System.Windows.Forms.TextBox();
            this.quantitaInput = new System.Windows.Forms.TextBox();
            this.descrizioneLabel = new System.Windows.Forms.Label();
            this.quantitaLabel = new System.Windows.Forms.Label();
            this.aggiungiMateriale = new System.Windows.Forms.Button();
            this.esitoPositivo = new System.Windows.Forms.Label();
            this.esitoNegativo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 43);
            this.panel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 43);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inventory Tool";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.dashboardSideButton);
            this.panel2.Controls.Add(this.aggiungiMaterialeSideButton);
            this.panel2.Controls.Add(this.elencoMaterialeSideButton);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Location = new System.Drawing.Point(1, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 447);
            this.panel2.TabIndex = 4;
            // 
            // dashboardSideButton
            // 
            this.dashboardSideButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.dashboardSideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardSideButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.dashboardSideButton.Location = new System.Drawing.Point(0, 49);
            this.dashboardSideButton.Name = "dashboardSideButton";
            this.dashboardSideButton.Size = new System.Drawing.Size(200, 23);
            this.dashboardSideButton.TabIndex = 4;
            this.dashboardSideButton.Text = "Dashboard";
            this.dashboardSideButton.UseVisualStyleBackColor = false;
            this.dashboardSideButton.Click += new System.EventHandler(this.dashboardSideButton_Click);
            // 
            // aggiungiMaterialeSideButton
            // 
            this.aggiungiMaterialeSideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aggiungiMaterialeSideButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.aggiungiMaterialeSideButton.Location = new System.Drawing.Point(0, 107);
            this.aggiungiMaterialeSideButton.Name = "aggiungiMaterialeSideButton";
            this.aggiungiMaterialeSideButton.Size = new System.Drawing.Size(200, 23);
            this.aggiungiMaterialeSideButton.TabIndex = 3;
            this.aggiungiMaterialeSideButton.Text = "Aggiungi Materiale";
            this.aggiungiMaterialeSideButton.UseVisualStyleBackColor = true;
            this.aggiungiMaterialeSideButton.Click += new System.EventHandler(this.aggiungiMaterialeSideButton_Click);
            // 
            // elencoMaterialeSideButton
            // 
            this.elencoMaterialeSideButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.elencoMaterialeSideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.elencoMaterialeSideButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.elencoMaterialeSideButton.Location = new System.Drawing.Point(0, 78);
            this.elencoMaterialeSideButton.Name = "elencoMaterialeSideButton";
            this.elencoMaterialeSideButton.Size = new System.Drawing.Size(200, 23);
            this.elencoMaterialeSideButton.TabIndex = 2;
            this.elencoMaterialeSideButton.Text = "Elenco Materiale";
            this.elencoMaterialeSideButton.UseVisualStyleBackColor = false;
            this.elencoMaterialeSideButton.Click += new System.EventHandler(this.elencoMaterialeSideButton_Click);
            // 
            // descrizioneInput
            // 
            this.descrizioneInput.Location = new System.Drawing.Point(363, 99);
            this.descrizioneInput.Name = "descrizioneInput";
            this.descrizioneInput.Size = new System.Drawing.Size(100, 20);
            this.descrizioneInput.TabIndex = 5;
            // 
            // quantitaInput
            // 
            this.quantitaInput.Location = new System.Drawing.Point(363, 146);
            this.quantitaInput.Name = "quantitaInput";
            this.quantitaInput.Size = new System.Drawing.Size(100, 20);
            this.quantitaInput.TabIndex = 6;
            // 
            // descrizioneLabel
            // 
            this.descrizioneLabel.AutoSize = true;
            this.descrizioneLabel.Location = new System.Drawing.Point(289, 102);
            this.descrizioneLabel.Name = "descrizioneLabel";
            this.descrizioneLabel.Size = new System.Drawing.Size(65, 13);
            this.descrizioneLabel.TabIndex = 7;
            this.descrizioneLabel.Text = "Descrizione:";
            // 
            // quantitaLabel
            // 
            this.quantitaLabel.AutoSize = true;
            this.quantitaLabel.Location = new System.Drawing.Point(289, 149);
            this.quantitaLabel.Name = "quantitaLabel";
            this.quantitaLabel.Size = new System.Drawing.Size(50, 13);
            this.quantitaLabel.TabIndex = 8;
            this.quantitaLabel.Text = "Quantità:";
            // 
            // aggiungiMateriale
            // 
            this.aggiungiMateriale.Location = new System.Drawing.Point(292, 196);
            this.aggiungiMateriale.Name = "aggiungiMateriale";
            this.aggiungiMateriale.Size = new System.Drawing.Size(171, 23);
            this.aggiungiMateriale.TabIndex = 9;
            this.aggiungiMateriale.Text = "Aggiungi";
            this.aggiungiMateriale.UseVisualStyleBackColor = true;
            this.aggiungiMateriale.Click += new System.EventHandler(this.aggiungiMateriale_Click);
            // 
            // esitoPositivo
            // 
            this.esitoPositivo.AutoSize = true;
            this.esitoPositivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.esitoPositivo.Location = new System.Drawing.Point(292, 246);
            this.esitoPositivo.Name = "esitoPositivo";
            this.esitoPositivo.Size = new System.Drawing.Size(94, 13);
            this.esitoPositivo.TabIndex = 10;
            this.esitoPositivo.Text = "Materiale aggiunto";
            // 
            // esitoNegativo
            // 
            this.esitoNegativo.AutoSize = true;
            this.esitoNegativo.ForeColor = System.Drawing.Color.Red;
            this.esitoNegativo.Location = new System.Drawing.Point(292, 246);
            this.esitoNegativo.Name = "esitoNegativo";
            this.esitoNegativo.Size = new System.Drawing.Size(115, 13);
            this.esitoNegativo.TabIndex = 11;
            this.esitoNegativo.Text = "Materiale non aggiunto";
            // 
            // AggiungiMaterialeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.esitoNegativo);
            this.Controls.Add(this.esitoPositivo);
            this.Controls.Add(this.aggiungiMateriale);
            this.Controls.Add(this.quantitaLabel);
            this.Controls.Add(this.descrizioneLabel);
            this.Controls.Add(this.quantitaInput);
            this.Controls.Add(this.descrizioneInput);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "AggiungiMaterialeForm";
            this.Text = "Aggiungi Materiale - Inventory Tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AggiungiMaterialeForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button dashboardSideButton;
        private System.Windows.Forms.Button aggiungiMaterialeSideButton;
        private System.Windows.Forms.Button elencoMaterialeSideButton;
        private System.Windows.Forms.TextBox descrizioneInput;
        private System.Windows.Forms.TextBox quantitaInput;
        private System.Windows.Forms.Label descrizioneLabel;
        private System.Windows.Forms.Label quantitaLabel;
        private System.Windows.Forms.Button aggiungiMateriale;
        private System.Windows.Forms.Label esitoPositivo;
        private System.Windows.Forms.Label esitoNegativo;
    }
}