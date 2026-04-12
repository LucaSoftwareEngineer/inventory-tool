namespace inventory_tool.Views
{
    partial class DashboardForm
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
            this.elencoMaterialeSideButton = new System.Windows.Forms.Button();
            this.aggiungiMaterialeSideButton = new System.Windows.Forms.Button();
            this.benvenutoLabel = new System.Windows.Forms.Label();
            this.dashboardSideButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 43);
            this.panel1.TabIndex = 0;
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
            this.panel2.Location = new System.Drawing.Point(0, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 447);
            this.panel2.TabIndex = 1;
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
            // benvenutoLabel
            // 
            this.benvenutoLabel.AutoSize = true;
            this.benvenutoLabel.Location = new System.Drawing.Point(228, 65);
            this.benvenutoLabel.Name = "benvenutoLabel";
            this.benvenutoLabel.Size = new System.Drawing.Size(0, 13);
            this.benvenutoLabel.TabIndex = 2;
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
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.benvenutoLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "DashboardForm";
            this.Text = "Dashboard - Inventory Tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DashboardForm_FormClosing);
            this.Load += new System.EventHandler(this.DashboardForm_Load);
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
        private System.Windows.Forms.Button elencoMaterialeSideButton;
        private System.Windows.Forms.Button aggiungiMaterialeSideButton;
        private System.Windows.Forms.Label benvenutoLabel;
        private System.Windows.Forms.Button dashboardSideButton;
    }
}