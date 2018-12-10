using Gestion_CitySearch.ApiServices;
using Gestion_CitySearch.Modèles;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_CitySearch
{
    public partial class LoginForm : MetroForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private async void btn_connexion_Click(object sender, EventArgs e)
        {
            Utilisateur utilisateur = new Utilisateur(txtbox_username.Text, txtbox_password.Text);
            bool result = await ApiUtilisateur.Login(utilisateur);

            if (result == true)
            {
                MetroMessageBox.Show(this, "Bravo, connexion réussi.", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Question);
                this.Hide();
                var AdminForm = new AdminForm();
                AdminForm.Closed += (s, args) => this.Close();
                AdminForm.Show();
            }
            else
            {
                MetroMessageBox.Show(this, "Oups, erreur de connexion.", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            };
        }

    }
}
