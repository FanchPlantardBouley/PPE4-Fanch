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

        
        private void btnValider_Click(object sender, EventArgs e)
        {
            bool co = true;
            if (tbId.Text == "" || tbMdp.Text == "")
            {
                co = false;
                MessageBox.Show("L\'indentifiant et le mot de passe ne peuvent pas être vides");
            }

            if (co) {
                string lib;
                lib = modele_Kaliemie.connexionWebService(tbId.Text, tbMdp.Text);
                MessageBox.Show(lib);
                MessageBox.Show(modele_Kaliemie.affichepersonne());}
            

            if (co)
            {
            string id = tbId.Text;
            string mdp = tbMdp.Text;
            bool test = modele_Kaliemie.valideConnexion(id, mdp);
            if (test == true)
            {
                string unId = modele_Kaliemie.RenvoyerIdVisiteur(id);
                Status f = new Status();
                f.Show();
            }
            else
            {
                MessageBox.Show(" L'identifiant ou le mot de passe est incorrect !");
            }
            }


        }
    }
}
