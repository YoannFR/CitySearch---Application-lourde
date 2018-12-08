using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_CitySearch.Modèles
{
    class Utilisateur
    {
        public static ArrayList collClassUtilisateur = new ArrayList();

        private int _id;
        private string _username;
        private string _password;

        public Utilisateur(string username, string password)
        {
            this._username = username;
            this._password = password;

            collClassUtilisateur.Add(this);
        }

        [JsonIgnore]
        public int id { get => _id; set => _id = value; }
        public string username { get => _username; set => _username = value; }
        public string password { get => _password; set => _password = value; }
    }
}
