using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liémie
{
    class modele_Kaliemie
    {
        private static connectKaliemie maConnexion;
        private string utilisateurActif;
        private string mdpActif;

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



    }
}
