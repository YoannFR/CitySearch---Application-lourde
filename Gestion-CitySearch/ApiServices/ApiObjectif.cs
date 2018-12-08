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
    class ApiObjectif
    {
        #region récupérer les objectifs
        public static async Task<List<JObject>> getObjectifs()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(Constants.webUrl);

            HttpResponseMessage response = await client.GetAsync("/apiAdmin_getObjectifs");
            var jsonresult = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<List<JObject>>(jsonresult);
            return result;
        }
        #endregion

        #region ajouter_objectif
        public static async Task<bool> addObjectif(string nom, string latitude, string longitude, string rayonactivation, string recompense)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(Constants.webUrl);

            string json = "{\"nom\":\"" + nom + "\", \"latitude\":\"" + latitude + "\", \"longitude\":\"" + longitude + "\", \"rayonactivation\":\"" + rayonactivation + "\", \"recompense\":\"" + recompense + "\"}";
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync("/apiAdmin_addObjectif", content);
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

        #region modifier_objectif
        public static async Task<bool> editObjectif(string id, string nom, string latitude, string longitude, string rayonactivation, string recompense)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(Constants.webUrl);

            string json = "{\"id\":\"" + id + "\", \"nom\":\"" + nom + "\", \"latitude\":\"" + latitude + "\", \"longitude\":\"" + longitude + "\", \"rayonactivation\":\"" + rayonactivation + "\", \"recompense\":\"" + recompense + "\"}";
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync("/apiAdmin_editObjectif", content);
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

        #region supprimer_objectif
        public static async Task<bool> deleteObjectif(string id)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(Constants.webUrl);

            string json = "{\"id\":\"" + id + "\"}";
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync("/apiAdmin_deleteObjectif", content);
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
