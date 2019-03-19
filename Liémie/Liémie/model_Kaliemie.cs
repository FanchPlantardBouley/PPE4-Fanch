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
    public static class model_Kaliemie
    {
        private static connectkaliemie maConnexion;

        public static void init()
        {
            maConnexion = new connectkaliemie();
            
        }


        public static string encode(string input) //cryptage
        {
            /*byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(PasswdSaisi);
            byte[] hash = (MD5.Create()).ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();*/

            // step 1, calculate MD5 hash from input
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }

       public static string ConnexionLocal(string login, string password)
        {
            string vretour = "Error_local_request";
            password = encode(password); //cryptage

            var LQuery = maConnexion.personne_login.ToList()
                            .Where(x => x.login == login)
                           .Select(x => new { x.login, x.mp });

            foreach (var v in LQuery)
            {
                if (v.mp == password)
                { vretour = login; }
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
            JObject JsonLogin = JObject.Parse(responseFromServer);
            if (JsonLogin["nom"].ToString() != "" && JsonLogin["prenom"].ToString() != "")
            {
                string identifiant = JsonLogin["nom"].ToString() + " " + JsonLogin["prenom"].ToString();
                vretour = identifiant;
            }
            return vretour;
        }
        public static bool AjoutPersonne_login(string nom, string prenom, string remarque, int anNais, int anMort, int idNation, int idStyle)
        {
            bool vretour = true;
            try
            {
                personne_login PL = new personne_login();
                PL.positeur = nom;
                compositeurChoisi.prenomCompositeur = prenom;
                compositeurChoisi.remarque = remarque;
                compositeurChoisi.anNais = anNais;
                compositeurChoisi.anMort = anMort;
                compositeurChoisi.idNation = idNation;
                compositeurChoisi.idStyle = idStyle;
                maConnexion.COMPOSITEUR.Add(compositeurChoisi);
                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
            }
            return vretour;
        }

        public static bool AjoutPersonne(string lenom, string leprenom, string lesexe, DateTime ladatenaiss, DateTime ladatemort, string unead1, string unead2, int uncp, string uneville, string untel_fixe, string untel_port, string unmail )
        {
            bool vretour = true;
            try
            {
                personne P = new personne();
                P.nom = lenom;
                P.prenom = leprenom;
                P.sexe = lesexe;
                P.date_naiss = ladatenaiss;
                P.date_deces = ladatemort;
                P.ad1 = unead1;
                P.ad2 = unead2;
                P.cp = uncp;
                P.ville = uneville;
                P.tel_fixe = untel_fixe;
                P.tel_port = untel_port;
                P.mail = unmail;
                maConnexion.personne.Add(P);
                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
            }
            return vretour;
        }

        public static bool AjoutPersonne_login(int unid, string lelogin, string lemdp, DateTime laderniereco, int unnb)
        {
            bool vretour = true;
            try
            {
                personne_login PL = new personne_login();
                PL.id = unid;
                PL.login = lelogin;
                PL.mp = lemdp;
                PL.derniere_connexion = laderniereco;
                PL.nb_tentative_erreur = unnb;
                maConnexion.personne_login.Add(PL);
                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
            }
            return vretour;
        }

    }
}
