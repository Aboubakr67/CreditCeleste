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
    public partial class frmVoiture : Form
    {
        public frmVoiture()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmdVersBdd_Click(object sender, EventArgs e)
        {
            //Globale.gestBdd();
        }

        private void frmVoiture_Load(object sender, EventArgs e)
        {
            if (Globale.uneVoiture != null)
            {
                cboxMarque.Text = Globale.uneVoiture.getMarque();
                cboxModele.Text = Globale.uneVoiture.getModele();
                cboxEnergie.Text = Globale.uneVoiture.getEnergie();
                cboxAnneeModele.Text = Globale.uneVoiture.getAnneeModele();
                cboxPuissance.Text = Globale.uneVoiture.getPuissance();
                lblFieldNumeroSerie.Text = Globale.uneVoiture.getNumeroSerie();
                lblFieldDatePremImmat.Text = Globale.uneVoiture.getDatePremImmat();
                lblFieldNumeroImmat.Text = Globale.uneVoiture.getNumeroImmat();

                foreach (RadioButton radio in gpbAgeVehicule.Controls.OfType<RadioButton>())
                {
                    if (radio.Text == Globale.uneVoiture.getAgeVehicule())
                    {
                        radio.Checked = true;
                    }
                }

            }
        }

        private void cmdJenregistre_Click(object sender, EventArgs e)
        {
            int i = 0;
            RadioButton radio = (RadioButton)gpbAgeVehicule.Controls[i];

            while ((radio.Checked == false) && (i < gpbAgeVehicule.Controls.Count - 1))
            {
                i++;
                radio = (RadioButton)gpbAgeVehicule.Controls[i];
            }

            string age = radio.Text;



            // Metttre les zones de textes vers l'object
            // Vers l'object voiture

            //Voiture uneVoiture = new Voiture(txtNouvVhc.text, AgeVehicule, txtDatePremierImma.Text, txtNumImma.Text, txtNumSerie.Text, txtPuissance.Text);

            // Apres verification des saisies des champs obligatoires
            if (verifSaisie())
            {
                if (Globale.uneVoiture == null)
                {
                    Globale.uneVoiture = new Voiture(cboxMarque.Text, cboxModele.Text, cboxEnergie.Text, cboxAnneeModele.Text, cboxPuissance.Text, lblFieldNumeroSerie.Text, lblFieldDatePremImmat.Text, lblFieldNumeroImmat.Text, age);
                }
                else
                {   // la voiture est à modifier avec les données
                    Globale.uneVoiture.setVoiture(cboxMarque.Text, cboxModele.Text, cboxEnergie.Text, cboxAnneeModele.Text, cboxPuissance.Text, lblFieldNumeroSerie.Text, lblFieldDatePremImmat.Text, lblFieldNumeroImmat.Text, age);
                    // Creer la méthode setVoiture avec toutes les paramètres
                }
            }
            //MessageBox.Show(affichage);
        }

        Boolean verifSaisie()
        {
            // permet de verifier si les champs sont correctement renseigner

            Boolean verif = false;

            if (cboxMarque.Text == "")
            {
                cboxMarque.Focus();
                MessageBox.Show("Veuillez saisir la marque du véhicule");
                return verif;
            }

            if (cboxModele.Text == "")
            {
                cboxModele.Focus();
                MessageBox.Show("Veuillez saisir le modèle du véhicule");
                return verif;
            }

            if (cboxEnergie.Text == "")
            {
                cboxEnergie.Focus();
                MessageBox.Show("Veuillez saisir l'énergie du véhicule");
                return verif;
            }

            if (cboxAnneeModele.Text == "")
            {
                cboxAnneeModele.Focus();
                MessageBox.Show("Veuillez saisir l'année du modèle du véhicule");
                return verif;
            }

            if (cboxPuissance.Text == "")
            {
                cboxPuissance.Focus();
                MessageBox.Show("Veuillez saisir la puissance du véhicule");
                return verif;
            }

            // a complter le reste 
            return true;

        }

        private void cmdIntroduction_Click(object sender, EventArgs e)
        {
            frmIntroduction fenIntroduction = new frmIntroduction();
            fenIntroduction.Show();
            this.Close();
        }
    }
}
