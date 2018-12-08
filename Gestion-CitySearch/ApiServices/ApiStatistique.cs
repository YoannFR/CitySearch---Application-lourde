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
    class ApiStatistique
    {
        #region récupérer_statistiques
        public static async Task<JObject> getStatistiques()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(Constants.webUrl);

            HttpResponseMessage response = await client.GetAsync("/api_statistiques");
            var result = await response.Content.ReadAsStringAsync();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                JObject jsonObject = JObject.Parse(result);
                return jsonObject;
            }
            else
            {
                JObject jsonObject = null;
                return jsonObject;
            }
        }
        #endregion
    }
}
