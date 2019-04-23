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
        string idUtilisateur;
        List<Panel> listPanel = new List<Panel>();
        public Status(string unIdUtilisateur)
        {
            InitializeComponent();           
            this.idUtilisateur = unIdUtilisateur;
        }

        private void Status_Load(object sender, EventArgs e)
        {
            /*listPanel.Add(pnl_menu);
            listPanel.Add(pnl_mesVisites);
            DimenssionDesPanels(908, 462);
            ToutFermerEtOuvrirCePanel(pnl_menu);*/
        }
      

        private void ToutFermerEtOuvrirCePanel(Panel monPanel)
        {
            if (listPanel.Contains(monPanel))
            {
                foreach (Panel pnl in listPanel)
                {
                    pnl.Hide();
                }
                monPanel.Show();
            }
        }

        public void DimenssionDesPanels(int h, int l)
        {
            foreach (Panel pnl in listPanel)
            {
                pnl.Size = new Size(h, l);
            }
        }


        private void btn_màjVisites_Click(object sender, EventArgs e)
        {
            if (model_Kaliemie.RapatrierMesVisites(idUtilisateur) != "")
            { MessageBox.Show(model_Kaliemie.RapatrierMesVisites(idUtilisateur)); }
            AfficherDGVMesVisites();
        }

        public void AfficherDGVMesVisites()
        {
            bs_visites.DataSource = model_Kaliemie.listVisites(idUtilisateur);
            dgv_visites.DataSource = bs_visites;
            for (int i = 0; i < dgv_visites.ColumnCount; i++)
            {
                dgv_visites.Columns[i].Visible = false;
            }
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
        }

        /*private void tsm_planningVisites_Click(object sender, EventArgs e)
        {
            ToutFermerEtOuvrirCePanel(pnl_mesVisites);
            AfficherDGVMesVisites();
        }

        private void tsm_menuPrincipal_Click(object sender, EventArgs e)
        {
            ToutFermerEtOuvrirCePanel(pnl_menu);
        }*/

        private void tsm_deconnexion_Click(object sender, EventArgs e)
        {
            Liémie l = new Liémie();
            l.Show();
            this.Hide();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


    }
}

