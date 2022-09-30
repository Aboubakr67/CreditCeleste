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
    public partial class frmSaisieBien : Form
    {
        public frmSaisieBien()
        {
            InitializeComponent();
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
                    Globale.uneVoiture = new Voiture(txtNouvVehc.Text, age, "", txtDatePremierImma.Text, txtNumImma.Text, txtNumSerie.Text, txtPuissance.Text);
                }
                else
                {   // la voiture est à modifier avec les données
                    Globale.uneVoiture.setVoiture(txtNouvVehc.Text, age, txtDatePremierImma.Text, txtNumImma.Text, txtNumSerie.Text, txtPuissance.Text);
                    // Creer la méthode setVoiture avec toutes les paramètres
                }
            }
            //MessageBox.Show(affichage);

        }

        private void cmdIntroduction_Click(object sender, EventArgs e)
        {
            frmIntroduction uneIntroduction = new frmIntroduction();
            uneIntroduction.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void frmSaisieBien_Load(object sender, EventArgs e)
        {
            //  mettre le contenu de l'object sur l'ecran
            // recuperer les elements de la voiture

            if (Globale.uneVoiture != null)
            {
                txtNouvVehc.Text = Globale.uneVoiture.getNomVoiture();
                txtDatePremierImma.Text = Globale.uneVoiture.getDatePremiereImma();
                txtNumImma.Text = Globale.uneVoiture.getNumImmatriculation();
                txtNumSerie.Text = Globale.uneVoiture.getNumSerie();
                txtPuissance.Text = Globale.uneVoiture.getPuissance();


                foreach (RadioButton radio in gpbAgeVehicule.Controls.OfType<RadioButton>())
                {
                    if (radio.Text == Globale.uneVoiture.getAgeVehicule())
                    {
                        radio.Checked = true;
                    } 
                }
                
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        Boolean verifSaisie()
        {
            // permet de verifier si les champs sont correctement renseigner

            Boolean verif = false;

            if (txtDatePremierImma.Text == "")
            {
                txtDatePremierImma.Focus();
                MessageBox.Show("Veuillz saisir la date de première immatriculation !!!", "Credit Celeste Warning");
                return verif;
            }

            if (txtPuissance.Text == "")
            {
                txtPuissance.Focus();
                MessageBox.Show("Veuillz saisir la puissance !!!");
                return verif;
            }

            if (txtNumSerie.Text == "")
            {
                txtNumSerie.Focus();
                MessageBox.Show("Veuillz saisir le numéro serie !!!");
                return verif;
            }

            if (txtNumImma.Text == "")
            {
                txtNumImma.Focus();
                MessageBox.Show("Veuillz saisir le numéro immatriculation !!!");
                return verif;
            }

            // a complter le reste 
            return true;

        }

        private void gpbAgeVehicule_Enter(object sender, EventArgs e)
        {

        }

        private void cmdCredit_Click(object sender, EventArgs e)
        {
            FrmCredit fenCredit = new FrmCredit();
            fenCredit.Show();
            this.Close();
        }

       
    }
}
