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
            lblalerte.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbId.Text = "";
            tbMdp.Text = "";
        }


        /* private void btnValider_Click(object sender, EventArgs e)
         {

         lblalerte.Text = "";
             if (tbId.Text != "" && tbMdp.Text != "")
             {
                 if (model_Kaliemie.ConnexionLocal(tbId.Text, tbMdp.Text) == "Error_local_request")
                 {

                     if (model_Kaliemie.connexionWebService(tbId.Text, tbMdp.Text) != "Ajout OK")
                     {

                         lblalerte.Text = model_Kaliemie.connexionWebService(tbId.Text, tbMdp.Text);
                     }
                     else { lblalerte.Text = "WebService OK"; }
                 }
                 else { lblalerte.Text = "Local OK";
                     Status m2 = new Status(model_Kaliemie.ConnexionLocal(tbId.Text, tbMdp.Text));
                     m2.Show();
                     this.Hide();
                 }
             }
             else { lblalerte.Text = "*Tous les champs doivent être remplis"; }

         }*/
        private void btnValider_Click(object sender, EventArgs e)
        {
            lblalerte.Text = "";

            if (tbId.Text != "" && tbMdp.Text != "")
            {
                switch (model_Kaliemie.ConnexionLocal(tbId.Text, tbMdp.Text))
                {
                    case -1:
                        switch (model_Kaliemie.connexionWebService(tbId.Text, tbMdp.Text))
                        {
                            case -1:
                                lblalerte.Text = "Votre compte n'a pas pû être ajouté au serveur local";
                                break;
                            case -2:
                                lblalerte.Text = "Le compte n'a pas été trouvez sur le serveur distant \n Identifiant ou mot de passe incorrect";
                                break;
                            default:
                                Status m1 = new Status(model_Kaliemie.ConnexionLocal(tbId.Text, tbMdp.Text));
                                m1.Show();
                                this.Hide();
                                break;
                        }
                        break;
                    case -2:
                        lblalerte.Text = "Identifiant ou mot de passe incorrect";
                        break;
                    default:
                        Status m2 = new Status(model_Kaliemie.ConnexionLocal(tbId.Text, tbMdp.Text));
                        m2.Show();
                        this.Hide();
                        break;
                }
            }
            else { lblalerte.Text = "Tous les champs doivent être remplient"; }
        }
    }
}
