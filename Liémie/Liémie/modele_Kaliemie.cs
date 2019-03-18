using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using System.Net;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;

namespace Liémie
{
    class modele_Kaliemie
    {
        private static connectKaliemie maConnexion;
        
        public static void init()
        {
            maConnexion = new connectKaliemie();
        }

        
        

        public static bool valideConnexion(string id, string mp)
        {
            bool vRetour = false;
            var LQuery = maConnexion.personne_login.ToList()
                           .Where(x => x.login == id && x.mp == mp)
                           .Select(x => new { x.login, x.mp });

            foreach (var v in LQuery)
            {
                if (v.mp == mp)
                { vRetour = true; }
            }
            return vRetour;
        }

        public static string RenvoyerIdVisiteur(string idVisiteur)
        {
            string vretour = "";
            var LQuery = maConnexion.personne_login.ToList()
                           .Where(x => x.login == idVisiteur)
                           .Select(x => new { x.id });
            foreach (var v in LQuery)
            {
                vretour = v.id.ToString();
            }

            return vretour;
        }
        public static string connexionWebService(string login, string password)
        {
            string vretour = "Error_web_service_request";
            //var url = "http://172.16.4.224/service-web/app/public/connect?login=" + login + "&mdp=" + password;
            var url = "http://www.btssio-carcouet.fr/ppe4/public/connect2/" + login + "/" + password + "/infirmiere";
            WebRequest request = WebRequest.Create(url);
            request.Credentials = CredentialCache.DefaultCredentials;
            WebResponse response = request.GetResponse();
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);

            string responseFromServer = reader.ReadToEnd();
            vretour = responseFromServer;
            //JObject JsonLogin = JObject.Parse(responseFromServer);
            /*if (JsonLogin["nom"].ToString() != "" && JsonLogin["prenom"].ToString() != "")
            {
                string identifiant = JsonLogin["nom"].ToString() + " " + JsonLogin["prenom"].ToString();
                vretour = identifiant;
            }*/
            return vretour;
        }

        public static string affichepersonne()
        {
            string vretour = "";
            var LQuery = maConnexion.personne_login.ToList();
                       
            foreach (var v in LQuery)
            {
                vretour = v.id.ToString();
            }

            return vretour;
        }



    }
}
