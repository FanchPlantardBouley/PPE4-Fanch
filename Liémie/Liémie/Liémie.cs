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

        
        private void btnValider_Click(object sender, EventArgs e)
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
                else { lblalerte.Text = "Local OK"; }
            }
            else { lblalerte.Text = "*Tous les champs doivent être remplis"; }
            
        }
    }
}
