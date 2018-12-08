namespace Gestion_CitySearch
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtbox_username = new MetroFramework.Controls.MetroTextBox();
            this.txtbox_password = new MetroFramework.Controls.MetroTextBox();
            this.btn_connexion = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 84);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(109, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Nom d\'utilisateur";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 158);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(88, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Mot de passe";
            // 
            // txtbox_username
            // 
            // 
            // 
            // 
            this.txtbox_username.CustomButton.Image = null;
            this.txtbox_username.CustomButton.Location = new System.Drawing.Point(192, 1);
            this.txtbox_username.CustomButton.Name = "";
            this.txtbox_username.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtbox_username.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbox_username.CustomButton.TabIndex = 1;
            this.txtbox_username.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbox_username.CustomButton.UseSelectable = true;
            this.txtbox_username.CustomButton.Visible = false;
            this.txtbox_username.Lines = new string[0];
            this.txtbox_username.Location = new System.Drawing.Point(23, 106);
            this.txtbox_username.MaxLength = 32767;
            this.txtbox_username.Name = "txtbox_username";
            this.txtbox_username.PasswordChar = '\0';
            this.txtbox_username.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbox_username.SelectedText = "";
            this.txtbox_username.SelectionLength = 0;
            this.txtbox_username.SelectionStart = 0;
            this.txtbox_username.ShortcutsEnabled = true;
            this.txtbox_username.Size = new System.Drawing.Size(214, 23);
            this.txtbox_username.TabIndex = 2;
            this.txtbox_username.UseSelectable = true;
            this.txtbox_username.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbox_username.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtbox_password
            // 
            // 
            // 
            // 
            this.txtbox_password.CustomButton.Image = null;
            this.txtbox_password.CustomButton.Location = new System.Drawing.Point(192, 1);
            this.txtbox_password.CustomButton.Name = "";
            this.txtbox_password.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtbox_password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbox_password.CustomButton.TabIndex = 1;
            this.txtbox_password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbox_password.CustomButton.UseSelectable = true;
            this.txtbox_password.CustomButton.Visible = false;
            this.txtbox_password.Lines = new string[0];
            this.txtbox_password.Location = new System.Drawing.Point(23, 180);
            this.txtbox_password.MaxLength = 32767;
            this.txtbox_password.Name = "txtbox_password";
            this.txtbox_password.PasswordChar = '*';
            this.txtbox_password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbox_password.SelectedText = "";
            this.txtbox_password.SelectionLength = 0;
            this.txtbox_password.SelectionStart = 0;
            this.txtbox_password.ShortcutsEnabled = true;
            this.txtbox_password.Size = new System.Drawing.Size(214, 23);
            this.txtbox_password.TabIndex = 3;
            this.txtbox_password.UseSelectable = true;
            this.txtbox_password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbox_password.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_connexion
            // 
            this.btn_connexion.Location = new System.Drawing.Point(23, 234);
            this.btn_connexion.Name = "btn_connexion";
            this.btn_connexion.Size = new System.Drawing.Size(214, 31);
            this.btn_connexion.TabIndex = 4;
            this.btn_connexion.Text = "Connexion";
            this.btn_connexion.UseSelectable = true;
            this.btn_connexion.Click += new System.EventHandler(this.btn_connexion_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 330);
            this.Controls.Add(this.btn_connexion);
            this.Controls.Add(this.txtbox_password);
            this.Controls.Add(this.txtbox_username);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "Panel - Connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtbox_username;
        private MetroFramework.Controls.MetroTextBox txtbox_password;
        private MetroFramework.Controls.MetroButton btn_connexion;
    }
}