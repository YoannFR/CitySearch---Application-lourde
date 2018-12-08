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
    class ApiTournoi
    {
        #region récupérer les tournois
        public static async Task<List<JObject>> getTournois()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(Constants.webUrl);

            HttpResponseMessage response = await client.GetAsync("/apiAdmin_getTournois");
            var jsonresult = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<List<JObject>>(jsonresult);
            return result;
        }
        #endregion

        #region ajouter_tournoi
        public static async Task<bool> addTournoi(string nom, string recompense, DateTime date_debut, DateTime date_fin, string nbre_places)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(Constants.webUrl);

            string json = "{\"nom\":\"" + nom + "\", \"recompense\":\"" + recompense + "\", \"date_debut\":\"" + date_debut + "\", \"date_fin\":\"" + date_fin + "\", \"nbre_places\":\"" + nbre_places + "\"}";
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync("/apiAdmin_addTournoi", content);
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

        #region modifier_tournoi
        public static async Task<bool> editTournoi(string id, string nom, string recompense, string date_debut, string date_fin, string nbre_places)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(Constants.webUrl);

            string json = "{\"id\":\"" + id + "\", \"nom\":\"" + nom + "\", \"recompense\":\"" + recompense + "\", \"date_debut\":\"" + date_debut + "\", \"date_fin\":\"" + date_fin + "\", \"nbre_places\":\"" + nbre_places + "\"}";
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync("/apiAdmin_editTournoi", content);
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

        #region supprimer_tournoi
        public static async Task<bool> deleteTournoi(string id)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(Constants.webUrl);

            string json = "{\"id\":\"" + id + "\"}";
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync("/apiAdmin_deleteTournoi", content);
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
