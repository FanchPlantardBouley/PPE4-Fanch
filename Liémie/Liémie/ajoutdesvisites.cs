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
    public partial class ajoutdesvisites : Form
    {
        int unIdVisite;
        public ajoutdesvisites(int unIdVisite)
        {
            InitializeComponent();
            this.unIdVisite = unIdVisite;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void visites_Load(object sender, EventArgs e)
        {
            lbl_titre.Text = lbl_titre.Text + "id du patient : " +  unIdVisite.ToString();
            cb_cate_soins.ValueMember = "id";//permet de stocker l'identifiant
            cb_cate_soins.DisplayMember = "libel";
            bs_cate_soins.DataSource = model_Kaliemie.listecatesoins();
            cb_cate_soins.DataSource = bs_cate_soins;

        }

       

        

        private void bs_cate_soins_CurrentChanged(object sender, EventArgs e)
        {
            txt_desCategSoins.Text = ((categ_soins)bs_cate_soins.Current).libel.ToString() + ":\r\n" +
                ((categ_soins)bs_cate_soins.Current).description.ToString();
            cb_type.ValueMember = "id_type_soins";
            cb_type.DisplayMember = "libel";
            bs_type.DataSource = ((categ_soins)bs_cate_soins.Current).type_soins.ToList().OrderBy(x => x.id_type_soins);
            cb_type.DataSource = bs_type;
        }

        private void bs_type_CurrentChanged(object sender, EventArgs e)
        {
            txt_desType.Text = ((type_soins)bs_type.Current).libel.ToString() + ":\r\n" +
               ((type_soins)bs_type.Current).description.ToString();
            cb_soins.ValueMember = "id";
            cb_soins.DisplayMember = "libel";
            bs_soins.DataSource = ((type_soins)bs_type.Current).soins.ToList().OrderBy(x => x.id);
            cb_soins.DataSource = bs_soins;
        }

        private void bs_soins_CurrentChanged(object sender, EventArgs e)
        {
            lbl_coeffSoins.Text = "Coefficient " + ((soins)bs_soins.Current).coefficient.ToString();
            txt_desSoins.Text = ((soins)bs_soins.Current).libel.ToString();
        }

        private void cb_type_Format(object sender, ListControlConvertEventArgs e)
        {
            if (e.Value.ToString().Length > 30)
            {
                e.Value = e.Value.ToString().Substring(0, 30) + "...";
            }
        }

        private void cb_soins_Format(object sender, ListControlConvertEventArgs e)
        {
            if (e.Value.ToString().Length > 30)
            {
                e.Value = e.Value.ToString().Substring(0, 30) + "...";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Attention", "Ête vous sûre de vouloir valider ?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                short p = 0, r = 0;
                if (chk_prevue.Checked == true) { p = 1; }
                if (chk_realise.Checked == true) { r = 1; }
                MessageBox.Show(model_Kaliemie.AjouterSoinsVisite(unIdVisite, Convert.ToInt32(cb_cate_soins.SelectedValue),
                    Convert.ToInt32(cb_type.SelectedValue), Convert.ToInt32(cb_soins.SelectedValue), p, r));
            }
        }

        private void lbl_titre_Click(object sender, EventArgs e)
        {

        }
    }
    }

