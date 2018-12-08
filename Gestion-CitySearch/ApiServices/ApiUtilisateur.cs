using Gestion_CitySearch.Modèles;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_CitySearch.ApiServices
{
    class ApiUtilisateur
    {
        #region utilisateur_login
        public static async Task<bool>Login(Utilisateur utilisateur)
        {
            if (utilisateur.username.Equals("") || utilisateur.password.Equals("")) { return false; };

            var client = new HttpClient();
            client.BaseAddress = new Uri(Constants.webUrl);

            string json = JsonConvert.SerializeObject(utilisateur);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync("/api_login", content);
            var result = await response.Content.ReadAsStringAsync();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                JObject jsonObject = JObject.Parse(result);
                if((int)jsonObject["isadmin"] == 1)
                {
                    utilisateur.id = (int)jsonObject["id"];
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region récupérer les utilisateurs
        public static async Task<List<JObject>> getUsers()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(Constants.webUrl);

            HttpResponseMessage response = await client.GetAsync("/apiAdmin_getUtilisateurs");
            var jsonresult = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<List<JObject>>(jsonresult);
            return result;
        }
        #endregion

        #region ajouter_utilisateur
        public static async Task<bool> addUtilisateur(string username, string email, string password, string isAdmin)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(Constants.webUrl);

            string json = "{\"username\":\"" + username + "\", \"email\":\"" + email + "\", \"password\":\"" + password + "\", \"isadmin\":\"" + isAdmin + "\"}";
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync("/apiAdmin_addUtilisateur", content);
            var result = await response.Content.ReadAsStringAsync();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region modifier_utilisateur
        public static async Task<bool> editUtilisateur(string id, string username, string password, string points)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(Constants.webUrl);

            string json = "{\"id\":\"" + id + "\", \"username\":\"" + username + "\", \"password\":\"" + password + "\", \"points\":\"" + points + "\"}";
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync("/apiAdmin_editUtilisateur", content);
            var result = await response.Content.ReadAsStringAsync();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region supprimer_utilisateur
        public static async Task<bool> deleteUtilisateur(string id)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(Constants.webUrl);

            string json = "{\"id\":\"" + id + "\"}";
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync("/apiAdmin_deleteUtilisateur", content);
            var result = await response.Content.ReadAsStringAsync();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}

