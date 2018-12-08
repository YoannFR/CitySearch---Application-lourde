using Gestion_CitySearch.ApiServices;
using MetroFramework.Forms;
using Newtonsoft.Json.Linq;
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
    public partial class AdminForm : MetroForm
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private async void AdminForm_Load(object sender, EventArgs e)
        {
            JObject response = await ApiStatistique.getStatistiques();

            if (response != null)
            {
                // Statistique - Utilisateurs
                lbl_utilisateurs.Text = (int)response["nombresUtilisateurs"] + " utilisateurs enregistrés";

                // Statistique - Objectifs
                lbl_objectifs.Text = (int)response["nombresUtilisateurs"] + " objectifs enregistrés";

                // Statistique - Tournois
                lbl_tournois.Text = (int)response["nombresTournois"] + " tournois enregistrés";

                // Statistique - Articles
                lbl_articles.Text = (int)response["nombresArticles"] + " articles enregistrés";

                // Statistique - Nombres de points
                lbl_points.Text = (int)response["nombresPointsTotal"] + " points au total";

                // Statistique - Base de donnée
                lbl_bdd.Text = (int)response["espaceDD"] + "% du disque utilisé";

                // Remplissage des DGV
                dgv_Utilisateurs.DataSource = await ApiUtilisateur.getUsers();
                dgv_Objectifs.DataSource = await ApiObjectif.getObjectifs();
                dgv_Tournois.DataSource = await ApiTournoi.getTournois();
                dgv_Articles.DataSource = await ApiArticle.getArticles();
            }
        }

        // Ajouter un utilisateur
        private async void btn_AjouterUtilisateur_Click_1(object sender, EventArgs e)
        {
            var username = txtbox_UsernameUtilisateur.Text.ToString();
            var email = txtbox_EmailUtilisateur.Text.ToString();
            var password = txtbox_PasswordUtilisateur.Text.ToString();
            var isAdmin = cbx_isAdminUtilisateur.Text.ToString();

            await ApiUtilisateur.addUtilisateur(username, email, password, isAdmin);
            dgv_Utilisateurs.DataSource = await ApiUtilisateur.getUsers();
        }

        // Modifier un utilisateur
        private async void btn_ModifierUtilisateur_Click(object sender, EventArgs e)
        {
            var id = dgv_Utilisateurs.CurrentRow.Cells[0].Value.ToString();
            var username = dgv_Utilisateurs.CurrentRow.Cells[1].Value.ToString();
            var password = dgv_Utilisateurs.CurrentRow.Cells[2].Value.ToString();
            var points = dgv_Utilisateurs.CurrentRow.Cells[3].Value.ToString();

            await ApiUtilisateur.editUtilisateur(id, username, password, points);
            dgv_Utilisateurs.DataSource = await ApiUtilisateur.getUsers();
        }

        // Supprimer un utilisateur
        private async void btn_SupprimerUtilisateur_Click(object sender, EventArgs e)
        {
            var id = dgv_Utilisateurs.CurrentRow.Cells[0].Value.ToString();
            await ApiUtilisateur.deleteUtilisateur(id);
            dgv_Utilisateurs.DataSource = await ApiUtilisateur.getUsers();
        }

        // Ajouter un objectif
        private async void btn_AjouterObjectif_Click(object sender, EventArgs e)
        {
            var nom = txtbox_NomObjectif.Text.ToString(); 
            var latitude = txtbox_LatitudeObjectif.Text.ToString();
            var longitude = txtbox_LongitudeObjectif.Text.ToString();
            var rayonactivation = txtbox_RayonActivationObjectif.Text.ToString();
            var recompense = txtbox_RecompenseObjectif.Text.ToString();

            await ApiObjectif.addObjectif(nom, latitude, longitude, rayonactivation, recompense);
            dgv_Objectifs.DataSource = await ApiObjectif.getObjectifs();
        }

        // Modifier un objectif
        private async void btn_ModifierObjectif_Click(object sender, EventArgs e)
        {
            var id = dgv_Objectifs.CurrentRow.Cells[0].Value.ToString();
            var nom = dgv_Objectifs.CurrentRow.Cells[1].Value.ToString();
            var latitude = dgv_Objectifs.CurrentRow.Cells[2].Value.ToString();
            var longitude = dgv_Objectifs.CurrentRow.Cells[3].Value.ToString();
            var rayonactivation = dgv_Objectifs.CurrentRow.Cells[4].Value.ToString();
            var recompense = dgv_Objectifs.CurrentRow.Cells[5].Value.ToString();

            await ApiObjectif.editObjectif(id, nom, latitude, longitude, rayonactivation, recompense);
            dgv_Objectifs.DataSource = await ApiObjectif.getObjectifs();
        }

        // Supprimer un objectif
        private async void btn_SupprimerObjectif_Click(object sender, EventArgs e)
        {
            var id = dgv_Objectifs.CurrentRow.Cells[0].Value.ToString();
            await ApiObjectif.deleteObjectif(id);
            dgv_Objectifs.DataSource = await ApiObjectif.getObjectifs();
        }

        // Ajouter un tournoi
        private async void btn_AjouterTournoi_Click(object sender, EventArgs e)
        {
            var nom = txtbox_NomTournoi.Text.ToString();
            var recompense = txtbox_RecompenseTournoi.Text.ToString();
            var date_debut = dtp_DebutTournoi.Value;
            var date_fin = dtp_FinTournoi.Value;
            var nbre_places = txtbox_NbrePlacesTournoi.Text.ToString();

            await ApiTournoi.addTournoi(nom, recompense, date_debut, date_fin, nbre_places);
            dgv_Tournois.DataSource = await ApiTournoi.getTournois();
        }

        // Modifier un tournoi
        private async void btn_ModifierTournoi_Click(object sender, EventArgs e)
        {
            var id = dgv_Tournois.CurrentRow.Cells[0].Value.ToString();
            var nom = dgv_Tournois.CurrentRow.Cells[1].Value.ToString();
            var recompense = dgv_Tournois.CurrentRow.Cells[2].Value.ToString();
            var date_debut = dgv_Tournois.CurrentRow.Cells[6].Value.ToString();
            var date_fin = dgv_Tournois.CurrentRow.Cells[7].Value.ToString();
            var nbre_places = dgv_Tournois.CurrentRow.Cells[5].Value.ToString();

            await ApiTournoi.editTournoi(id, nom, recompense, date_debut, date_fin, nbre_places);
            dgv_Tournois.DataSource = await ApiTournoi.getTournois();
        }

        // Supprimer un tournoi
        private async void btn_SupprimerTournoi_Click(object sender, EventArgs e)
        {
            var id = dgv_Tournois.CurrentRow.Cells[0].Value.ToString();
            await ApiTournoi.deleteTournoi(id);
            dgv_Tournois.DataSource = await ApiTournoi.getTournois();
        }

        // Ajouter un article
        private async void btn_AjouterArticle_Click(object sender, EventArgs e)
        {
            var date = dtp_DateArticle.Value;
            var titre = txtbox_TitreArticle.Text.ToString();
            var description = txtbox_DescriptionArticle.Text.ToString(); ;
            var photo = txtbox_PhotoArticle.Text.ToString(); ;

            await ApiArticle.addArticle(date, titre, description, photo);
            dgv_Articles.DataSource = await ApiArticle.getArticles();
        }

        // Modifier un article
        private async void btn_ModifierArticle_Click(object sender, EventArgs e)
        {
            var id = dgv_Articles.CurrentRow.Cells[0].Value.ToString();
            var date = dgv_Articles.CurrentRow.Cells[1].Value.ToString();
            var titre = dgv_Articles.CurrentRow.Cells[2].Value.ToString();
            var description = dgv_Articles.CurrentRow.Cells[3].Value.ToString();
            var photo = dgv_Articles.CurrentRow.Cells[4].Value.ToString();

            await ApiArticle.editArticle(id, titre, description, photo);
            dgv_Articles.DataSource = await ApiArticle.getArticles();
        }

        // Supprimer un article
        private async void btn_SupprimerArticle_Click(object sender, EventArgs e)
        {
            var id = dgv_Articles.CurrentRow.Cells[0].Value.ToString();
            await ApiArticle.deleteArticle(id);
            dgv_Articles.DataSource = await ApiArticle.getArticles();
        }
    }
}
