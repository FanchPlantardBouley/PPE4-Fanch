using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;

namespace Liémie
{
    public partial class Liémie : Form
    {
        public Liémie()
        {
            InitializeComponent();
        }

        private void Liémie_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbId.Text = "";
            tbMdp.Text = "";
        }

        public static string connexion(string login, string passwd)
        {
            string vretour = "Error";
            var url = "http://www.btssio-carcouet.fr/ppe4/public/connect2/" + login + "/" + passwd + "/infirmiere";
            WebRequest request = WebRequest.Create(url);
            request.Credentials = CredentialCache.DefaultCredentials;
            WebResponse response = request.GetResponse();
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);

            string responseFromServer = reader.ReadToEnd();

            JObject JsonLogin = JObject.Parse(responseFromServer);
            if (JsonLogin["nom"].ToString() != "" && JsonLogin["prenom"].ToString() != "")
            {
                string identifiant = JsonLogin["nom"].ToString() + " " + JsonLogin["prenom"].ToString();
                vretour = identifiant;
            }
            return vretour;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            bool co = true;
            if (tbId.Text == "" || tbMdp.Text == "")
            {
                co = false;
                MessageBox.Show("L\'indentifiant et le mot de passe ne peuvent pas être vides");
                    }
                if (co) {         
            connexion(tbId.Text, tbMdp.Text);
            }
        }
    }
}
