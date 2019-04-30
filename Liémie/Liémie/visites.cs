using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Liémie
{
    public partial class visites : Form
    {
        int unIdVisite;
        public visites(int unIdVisite)
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void visites_Load(object sender, EventArgs e)
        {
            cb_cate_soins.ValueMember = "id_cate";//permet de stocker l'identifiant
            cb_cate_soins.DisplayMember = "libel";
            bs_cate_soins.DataSource = model_Kaliemie.listecatesoins();
            cb_cate_soins.DataSource = bs_cate_soins;

        }

        private void cbcatesoins_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_type.ValueMember = "id_type";//permet de stocker l'identifiant
            cb_type.DisplayMember = "libel";
            bs_type.DataSource = model_Kaliemie.Typesoins(Convert.ToInt32(cb_cate_soins.ValueMember));
            cb_type.DataSource = bs_type;



        }

        private void cb_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_soins.ValueMember = "id_soins";//permet de stocker l'identifiant
            cb_soins.DisplayMember = "libel";
            bs_soins.DataSource = model_Kaliemie.listetypesoins();
            cb_soins.DataSource = bs_soins
                ;
        }
    }
    }

