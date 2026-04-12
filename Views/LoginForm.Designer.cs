namespace inventory_tool
{
    partial class LoginForm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.accediButton = new System.Windows.Forms.Button();
            this.LoginNegato = new System.Windows.Forms.Label();
            this.LoginEseguito = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // usernameInput
            // 
            this.usernameInput.Location = new System.Drawing.Point(144, 31);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(100, 20);
            this.usernameInput.TabIndex = 2;
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(144, 94);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '*';
            this.passwordInput.Size = new System.Drawing.Size(100, 20);
            this.passwordInput.TabIndex = 3;
            // 
            // accediButton
            // 
            this.accediButton.Location = new System.Drawing.Point(44, 153);
            this.accediButton.Name = "accediButton";
            this.accediButton.Size = new System.Drawing.Size(200, 23);
            this.accediButton.TabIndex = 4;
            this.accediButton.Text = "Accedi";
            this.accediButton.UseVisualStyleBackColor = true;
            this.accediButton.Click += new System.EventHandler(this.accediButton_Click);
            // 
            // LoginNegato
            // 
            this.LoginNegato.AutoSize = true;
            this.LoginNegato.ForeColor = System.Drawing.Color.Red;
            this.LoginNegato.Location = new System.Drawing.Point(41, 195);
            this.LoginNegato.Name = "LoginNegato";
            this.LoginNegato.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LoginNegato.Size = new System.Drawing.Size(138, 13);
            this.LoginNegato.TabIndex = 5;
            this.LoginNegato.Text = "Username o password errati";
            // 
            // LoginEseguito
            // 
            this.LoginEseguito.AutoSize = true;
            this.LoginEseguito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LoginEseguito.Location = new System.Drawing.Point(44, 195);
            this.LoginEseguito.Name = "LoginEseguito";
            this.LoginEseguito.Size = new System.Drawing.Size(91, 13);
            this.LoginEseguito.TabIndex = 6;
            this.LoginEseguito.Text = "Accesso eseguito";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 237);
            this.Controls.Add(this.LoginEseguito);
            this.Controls.Add(this.LoginNegato);
            this.Controls.Add(this.accediButton);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "Login - Inventory Tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Button accediButton;
        private System.Windows.Forms.Label LoginNegato;
        private System.Windows.Forms.Label LoginEseguito;
    }
}

