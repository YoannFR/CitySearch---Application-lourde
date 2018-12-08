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
    class ApiArticle
    {
        #region récupérer les articles
        public static async Task<List<JObject>> getArticles()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(Constants.webUrl);

            HttpResponseMessage response = await client.GetAsync("/apiAdmin_getArticles");
            var jsonresult = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<List<JObject>>(jsonresult);
            return result;
        }
        #endregion

        #region ajouter_article
        public static async Task<bool> addArticle(DateTime date, string titre, string description, string photo)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(Constants.webUrl);

            string json = "{\"date\":\"" + date + "\", \"titre\":\"" + titre + "\", \"description\":\"" + description + "\",\"photo\":\"" + photo + "\"}";
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync("/apiAdmin_addArticle", content);
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

        #region modifier_article
        public static async Task<bool> editArticle(string id, string titre, string description, string photo)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(Constants.webUrl);

            string json = "{\"id\":\"" + id +  "\", \"titre\":\"" + titre + "\", \"description\":\"" + description + "\",\"photo\":\"" + photo + "\"}";
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync("/apiAdmin_editArticle", content);
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

        #region supprimer_article
        public static async Task<bool> deleteArticle(string id)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(Constants.webUrl);

            string json = "{\"id\":\"" + id + "\"}";
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync("/apiAdmin_deleteArticle", content);
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
