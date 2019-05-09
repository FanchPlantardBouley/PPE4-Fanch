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
    public partial class Status : Form
    {
        int idUtilisateur;
        
        public Status(int unIdUtilisateur)
        {
            InitializeComponent();           
            this.idUtilisateur = unIdUtilisateur;
           

        }

        private void Status_Load(object sender, EventArgs e)
        {
            AfficherDGVMesVisites();
        }           


        

        public void AfficherDGVMesVisites()
        {
            /*lbltest.Text = model_Kaliemie.RapatrierPatient(idUtilisateur).ToString();*/
            bs_visites.DataSource = model_Kaliemie.listVisites(idUtilisateur);
            dgv_visites.DataSource = bs_visites;
            for (int i = 0; i < dgv_visites.ColumnCount; i++)
            {
                dgv_visites.Columns[i].Visible = false;
            }
            dgv_visites.Columns["id"].Visible = true;
            dgv_visites.Columns["id"].HeaderText = "N°";
            dgv_visites.Columns["patient"].Visible = true;
            dgv_visites.Columns["patient"].HeaderText = "Patient";
            dgv_visites.Columns["date_prevue"].Visible = true;
            dgv_visites.Columns["date_prevue"].HeaderText = "Date prévue";
            dgv_visites.Columns["date_reelle"].Visible = true;
            dgv_visites.Columns["date_reelle"].HeaderText = "Date réelle";
            dgv_visites.Columns["duree"].Visible = true;
            dgv_visites.Columns["duree"].HeaderText = "Durée";
            dgv_visites.Columns["compte_rendu_infirmiere"].Visible = true;
            dgv_visites.Columns["compte_rendu_infirmiere"].HeaderText = "Compte rendu infirmiere";
            dgv_visites.Columns["compte_rendu_patient"].Visible = true;
            dgv_visites.Columns["compte_rendu_patient"].HeaderText = "Compte rendu patient";
            dgv_visites.AutoResizeColumns();
        }

    

        

        private void btnMaj_Click(object sender, EventArgs e)
        {
            if (model_Kaliemie.RapatrierMesVisites(idUtilisateur) != "")
            { MessageBox.Show(model_Kaliemie.RapatrierMesVisites(idUtilisateur)); }
            AfficherDGVMesVisites();
        }

        private void lbltest_Click(object sender, EventArgs e)
        {

        }

        private void bs_visites_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            if (dgv_visites.SelectedCells.Count > 0)
            {
                new ajoutdesvisites(((visite)bs_visites.Current).id).Show();
            }
            
        }
    }
}

