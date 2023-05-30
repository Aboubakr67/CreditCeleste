using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreditCeleste
{
    public partial class frmEtude : Form
    {
        public frmEtude()
        {
            InitializeComponent();
        }

        

        private void cmdRetour_Click(object sender, EventArgs e)
        {
            Globale.unClientVoit = null;
            Globale.uneConcession = null;
            Globale.uneVoiture = null;

            Globale.laRegion = "";
            Globale.laVille = "";

            Globale.lesCredits.Clear();
            Globale.lesRegions.Clear();
            Globale.lesVilles.Clear();
            Globale.lesCreditEtude.Clear();
            Globale.lesVoitures.Clear();


            frmAccueil fenAccueil = new frmAccueil();
            fenAccueil.Show();
            this.Hide();
        }

        private void frmEtude_Load(object sender, EventArgs e)
        {
            //Pour bloquer la redimension des lignes, empêchera l'utilisateur de redimensionner les lignes du contrôle DataGridView.
            dataGridEtude.AllowUserToResizeRows = false;

            Globale.lesCreditEtude.Clear();
            Persistance.recupereConcByRegionVille(Globale.laRegion, Globale.laVille);
            string codeConcession = Globale.uneConcession.getCodeConcession();
            lblNomConcession.Text = Globale.uneConcession.getMonNomConcession();
            Persistance.affCreditEtude(codeConcession);

            dataGridEtude.Rows.Clear();
            
            foreach (Credit credit in Globale.lesCreditEtude)
            {

                dataGridEtude.Rows.Add(credit.getNumCredit(),credit.getNomClient(), credit.getPrenomClient(), credit.getMontant(), 
                    credit.getTaux(),credit.getDuree(), credit.getMensualite());
            }
            
        }

        private void dataGridEtude_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridEtude.Columns[e.ColumnIndex].Name == "Accepter")
            {
                int numCredit = (int)dataGridEtude.Rows[e.RowIndex].Cells["Numéro"].Value;
                double montant = (double)dataGridEtude.Rows[e.RowIndex].Cells["Montant"].Value;
                double duree = (double)dataGridEtude.Rows[e.RowIndex].Cells["Duree"].Value;

                DialogResult result = MessageBox.Show($"Voulez-vous accepter le crédit {numCredit} pour un montant de {montant} sur une durée de {duree} mois ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Persistance.EtudierCredit(numCredit, "A");
                    // Code à exécuter si l'utilisateur clique sur "Oui" pour accepter le crédit.

                    //Pour supprimer le credit de la liste Globale.lesCreditEtude
                    Credit lecredit = Globale.lesCreditEtude.Find(c => c.getNumCredit() == numCredit);
                    Globale.lesCreditEtude.Remove(lecredit);

                    // Supprimer la ligne de la DataGridView
                    dataGridEtude.Rows.RemoveAt(e.RowIndex);

                    MessageBox.Show("Crédit accepté.", "Information");

                }
            }
            else if (dataGridEtude.Columns[e.ColumnIndex].Name == "Refuser")
            {
                int numCredit = (int)dataGridEtude.Rows[e.RowIndex].Cells["Numéro"].Value;
                double montant = (double)dataGridEtude.Rows[e.RowIndex].Cells["Montant"].Value;
                double duree = (double)dataGridEtude.Rows[e.RowIndex].Cells["Duree"].Value;

                DialogResult result = MessageBox.Show($"Voulez-vous refuser le crédit {numCredit} pour un montant de {montant} sur une durée de {duree} mois ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Persistance.EtudierCredit(numCredit, "R");
                    // Code à exécuter si l'utilisateur clique sur "Oui" pour refuser le crédit.

                    //Pour supprimer le credit de la liste Globale.lesCreditEtude
                    Credit lecredit = Globale.lesCreditEtude.Find(c => c.getNumCredit() == numCredit);
                    Globale.lesCreditEtude.Remove(lecredit);

                    // Supprimer la ligne de la DataGridView
                    dataGridEtude.Rows.RemoveAt(e.RowIndex);


                    MessageBox.Show("Crédit refuser.", "Information");
                }
            }
        }


    }
}
