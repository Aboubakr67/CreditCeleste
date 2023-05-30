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
    public partial class frmRelance : Form
    {
        public frmRelance()
        {
            InitializeComponent();
        }

        private void dataGridRelance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridRelance.Columns[e.ColumnIndex].Name == "examiner")
            {
                int numCredit = (int)dataGridRelance.Rows[e.RowIndex].Cells["Numéro"].Value;
                double montant = (double)dataGridRelance.Rows[e.RowIndex].Cells["Montant"].Value;
                double duree = (double)dataGridRelance.Rows[e.RowIndex].Cells["Duree"].Value;

                DialogResult result = MessageBox.Show($"Voulez-vous refaire une demande pour le crédit numéro {numCredit} pour un montant de {montant} sur une durée de {duree} mois ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    FrmCredit fenCredit = new FrmCredit();
                    fenCredit.PagePrecedente = "Relance";
                    fenCredit.Show();
                    this.Hide();
                }

            }
        }

        private void frmRelance_Load(object sender, EventArgs e)
        {
            //Pour bloquer la redimension des lignes, empêchera l'utilisateur de redimensionner les lignes du contrôle DataGridView.
           // dataGridRelance.AllowUserToResizeRows = false;

            Globale.lesCreditRelance.Clear();
            Persistance.recupereConcByRegionVille(Globale.laRegion, Globale.laVille);
            string codeConcession = Globale.uneConcession.getCodeConcession();
            lblNomConcession.Text = Globale.uneConcession.getMonNomConcession();
            Persistance.affCreditRelance(codeConcession);

            dataGridRelance.Rows.Clear();

            foreach (Credit credit in Globale.lesCreditRelance)
            {

                dataGridRelance.Rows.Add(credit.getNumCredit(), credit.getNomClient(), credit.getPrenomClient(), credit.getMontant(),
                    credit.getTaux(), credit.getDuree(), credit.getMensualite());
            }
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
    }
}
