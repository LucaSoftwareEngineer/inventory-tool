using System.Drawing;
using System.Windows.Forms;

namespace inventory_tool.Views
{
    internal static class InventoryTheme
    {
        private static readonly Color Canvas = Color.FromArgb(245, 247, 251);
        private static readonly Color Ink = Color.FromArgb(22, 34, 55);
        private static readonly Color Muted = Color.FromArgb(99, 115, 139);
        private static readonly Color Navy = Color.FromArgb(19, 32, 54);
        private static readonly Color Blue = Color.FromArgb(37, 99, 235);

        internal static void ApplyLogin(Form form, Label usernameLabel, Label passwordLabel,
            TextBox usernameInput, TextBox passwordInput, Button loginButton,
            Label deniedLabel, Label successLabel)
        {
            form.BackColor = Canvas;
            form.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ClientSize = new Size(520, 410);
            form.MinimumSize = new Size(480, 380);

            usernameLabel.Text = "Username";
            passwordLabel.Text = "Password";
            StyleFieldLabel(usernameLabel);
            StyleFieldLabel(passwordLabel);
            usernameLabel.SetBounds(72, 83, 376, 22);
            passwordLabel.SetBounds(72, 157, 376, 22);

            StyleTextBox(usernameInput);
            StyleTextBox(passwordInput);
            usernameInput.SetBounds(72, 110, 376, 34);
            passwordInput.SetBounds(72, 184, 376, 34);
            passwordInput.PasswordChar = '*';

            StyleButton(loginButton, Blue, Color.White);
            loginButton.SetBounds(72, 249, 376, 44);
            loginButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            form.AcceptButton = loginButton;

            StyleStatus(deniedLabel, Color.FromArgb(185, 28, 28));
            StyleStatus(successLabel, Color.FromArgb(21, 128, 61));
            deniedLabel.SetBounds(72, 316, 376, 24);
            successLabel.SetBounds(72, 316, 376, 24);
        }

        internal static void ApplyMainShell(Form form, Panel header, Panel sidebar,
            Panel brandPanel, Label brandLabel, Button dashboardButton,
            Button listButton, Button addButton, Button activeButton)
        {
            form.BackColor = Canvas;
            form.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ClientSize = new Size(1100, 700);
            form.MinimumSize = new Size(900, 600);

            header.BackColor = Color.White;
            sidebar.BackColor = Navy;
            brandPanel.BackColor = Color.White;
            brandLabel.Text = "Inventory Tool";
            brandLabel.ForeColor = Ink;
            brandLabel.Font = new Font("Segoe UI", 13F, FontStyle.Bold);

            StyleNavigationButton(dashboardButton, activeButton == dashboardButton);
            StyleNavigationButton(listButton, activeButton == listButton);
            StyleNavigationButton(addButton, activeButton == addButton);

            form.Resize += delegate { LayoutMainShell(form, header, sidebar, brandPanel, brandLabel, dashboardButton, listButton, addButton); };
            LayoutMainShell(form, header, sidebar, brandPanel, brandLabel, dashboardButton, listButton, addButton);
        }

        internal static void ApplyDashboard(Form form, Label welcomeLabel)
        {
            welcomeLabel.AutoSize = false;
            welcomeLabel.ForeColor = Ink;
            welcomeLabel.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            welcomeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            form.Resize += delegate { welcomeLabel.SetBounds(278, 124, form.ClientSize.Width - 330, 130); };
            welcomeLabel.SetBounds(278, 124, form.ClientSize.Width - 330, 130);
        }

        internal static void ApplyMaterialList(Form form, DataGridView grid)
        {
            grid.BackgroundColor = Color.White;
            grid.BorderStyle = BorderStyle.None;
            grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grid.EnableHeadersVisualStyles = false;
            grid.ColumnHeadersDefaultCellStyle.BackColor = Navy;
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grid.ColumnHeadersDefaultCellStyle.Padding = new Padding(8, 4, 8, 4);
            grid.DefaultCellStyle.BackColor = Color.White;
            grid.DefaultCellStyle.ForeColor = Ink;
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            grid.DefaultCellStyle.SelectionForeColor = Ink;
            grid.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            grid.DefaultCellStyle.Padding = new Padding(8, 5, 8, 5);
            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            grid.RowHeadersVisible = false;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.MultiSelect = false;
            grid.ReadOnly = true;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToResizeRows = false;
            grid.RowTemplate.Height = 38;
            grid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            form.Resize += delegate { grid.SetBounds(264, 104, form.ClientSize.Width - 304, form.ClientSize.Height - 144); };
            grid.SetBounds(264, 104, form.ClientSize.Width - 304, form.ClientSize.Height - 144);
        }

        internal static void ApplyAddMaterial(Form form, Label descriptionLabel, Label quantityLabel,
            TextBox descriptionInput, TextBox quantityInput, Button addButton,
            Label successLabel, Label errorLabel)
        {
            StyleFieldLabel(descriptionLabel);
            StyleFieldLabel(quantityLabel);
            StyleTextBox(descriptionInput);
            StyleTextBox(quantityInput);
            StyleButton(addButton, Blue, Color.White);
            addButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            StyleStatus(successLabel, Color.FromArgb(21, 128, 61));
            StyleStatus(errorLabel, Color.FromArgb(185, 28, 28));

            form.Resize += delegate { LayoutAddMaterial(form, descriptionLabel, quantityLabel, descriptionInput, quantityInput, addButton, successLabel, errorLabel); };
            LayoutAddMaterial(form, descriptionLabel, quantityLabel, descriptionInput, quantityInput, addButton, successLabel, errorLabel);
        }

        private static void LayoutMainShell(Form form, Panel header, Panel sidebar, Panel brandPanel,
            Label brandLabel, Button dashboardButton, Button listButton, Button addButton)
        {
            const int sidebarWidth = 228;
            const int headerHeight = 64;
            sidebar.SetBounds(0, 0, sidebarWidth, form.ClientSize.Height);
            header.SetBounds(sidebarWidth, 0, form.ClientSize.Width - sidebarWidth, headerHeight);
            brandPanel.SetBounds(0, 0, header.Width, headerHeight);
            brandLabel.Location = new Point(28, 19);

            dashboardButton.SetBounds(14, 104, sidebarWidth - 28, 46);
            listButton.SetBounds(14, 158, sidebarWidth - 28, 46);
            addButton.SetBounds(14, 212, sidebarWidth - 28, 46);
        }

        private static void LayoutAddMaterial(Form form, Label descriptionLabel, Label quantityLabel,
            TextBox descriptionInput, TextBox quantityInput, Button addButton,
            Label successLabel, Label errorLabel)
        {
            int left = 300;
            int inputWidth = form.ClientSize.Width - left - 92;
            descriptionLabel.SetBounds(left, 151, 140, 28);
            quantityLabel.SetBounds(left, 222, 140, 28);
            descriptionInput.SetBounds(left + 150, 145, inputWidth - 150, 38);
            quantityInput.SetBounds(left + 150, 216, inputWidth - 150, 38);
            addButton.SetBounds(left + 150, 284, inputWidth - 150, 44);
            successLabel.SetBounds(left + 150, 348, inputWidth - 150, 30);
            errorLabel.SetBounds(left + 150, 348, inputWidth - 150, 30);
        }

        private static void StyleNavigationButton(Button button, bool active)
        {
            StyleButton(button, active ? Blue : Navy, Color.White);
            button.TextAlign = ContentAlignment.MiddleLeft;
            button.Padding = new Padding(18, 0, 0, 0);
            button.Font = new Font("Segoe UI", 10F, active ? FontStyle.Bold : FontStyle.Regular);
        }

        private static void StyleButton(Button button, Color backColor, Color foreColor)
        {
            button.BackColor = backColor;
            button.ForeColor = foreColor;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 78, 216);
            button.UseVisualStyleBackColor = false;
            button.Cursor = Cursors.Hand;
        }

        private static void StyleFieldLabel(Label label)
        {
            label.AutoSize = false;
            label.ForeColor = Muted;
            label.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        }

        private static void StyleTextBox(TextBox textBox)
        {
            textBox.BackColor = Color.White;
            textBox.ForeColor = Ink;
            textBox.BorderStyle = BorderStyle.FixedSingle;
            textBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular);
        }

        private static void StyleStatus(Label label, Color color)
        {
            label.AutoSize = false;
            label.ForeColor = color;
            label.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
        }
    }
}
