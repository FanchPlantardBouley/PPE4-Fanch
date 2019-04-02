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
            if (tbId.Text != "" || tbMdp.Text != "")
            {
                string lib;
                if (model_Kaliemie.ConnexionLocal(tbId.Text, tbMdp.Text) == "Error_local_request")
                {
                    try
                    {
                        if (model_Kaliemie.connexionWebService(tbId.Text, tbMdp.Text) == "Error_local_request") ;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.InnerException.ToString());
                    }

                }
                //lib = Model_Keliemie.ConnexionLocal(tb_identifiant.Text,Model_Keliemie.encode(tb_motDePasse.Text));
                //lib = model_Kaliemie.connexionWebService(tbId.Text, tbMdp.Text);
                //MessageBox.Show(lib);
            }
            else { lblalerte.Text = "*Tous les champs doivent être remplient"; }




        }
    }
}
