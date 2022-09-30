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
    public partial class frmIntroduction : Form
    {
        public frmIntroduction()
        {
            InitializeComponent();
        }

        private void frmIntroduction_Load(object sender, EventArgs e)
        {
            // lecture de la collection des vendeurs de la collection
            // pour afficher dans la combobox vendeur


            // comment passer la collection en variables globales  
            //  identique aux variables de sessions


            //Lire l'objet consession et récuperer les vendeur pour les mettre dans le combobox

            foreach (Vendeur xVendeur in Globale.uneConcession.getLesVendeurs())
            {
                cboVendeur.Items.Add(xVendeur.getInfosVendeurs());
            }

            if (Globale.uneVoiture != null)
            {
                txtNewVehc.Text = Globale.uneVoiture.getNomVoiture();
                txtAncVehc.Text = Globale.uneVoiture.getAncienVehicule();

                foreach (RadioButton radio in gpbAgeVehicule.Controls.OfType<RadioButton>())
                {
                    if (radio.Text == Globale.uneVoiture.getAgeVehicule())
                    {
                        radio.Checked = true;
                    }
                }
            }

            if (Globale.unClientVoit != null)
            {
                txtNom.Text = Globale.unClientVoit.getNomClient();
                txtPrenom.Text = Globale.unClientVoit.getPrenomClient();
                cboCidt.Text = Globale.unClientVoit.getMonCidClient();
                cboVendeur.Text = Globale.unClientVoit.getVendeur();
            }

            // Client unClient = new Client(); // permet de creer un client, ne devrait pas exister
            // il suffit de creer un client abstrait pour indiquer qu'on ne peut pas creer
            // creer un object client




        }

        private void cmdSaisieBien_Click(object sender, EventArgs e)
        {
            // appel de la fenetre voiture

            frmSaisieBien fenSaisieBien = new frmSaisieBien();

            fenSaisieBien.Show();

            this.Close();
        }

        private void labelNom_Click(object sender, EventArgs e)
        {

        }

        private void cmdJenregistre_Click(object sender, EventArgs e)
        {
            // -- Permet de stocker les données de l'écran vers les objets  

            
            string age = "";
            // -- Age du véhicule
            for (int i = 0; i < gpbAgeVehicule.Controls.Count; i++)
            {
                RadioButton chk = (RadioButton)gpbAgeVehicule.Controls[i];
                if (chk.Checked == true)
                {
                    age = chk.Text;
                }
                    
            }

            
            if (verifSaisie())
            {
                if (Globale.uneVoiture == null)
                {       // la voiture n'existe pas
                    Globale.uneVoiture = new Voiture(txtNewVehc.Text, age, txtAncVehc.Text);
                }
                else  // la voiture existe
                {
                    // reprendre les données textes de l'écrans
                    // et les mettre dans l'objet
                    // 
                    Globale.uneVoiture.setVoiture(txtNewVehc.Text, age, txtAncVehc.Text);
                }

                if (Globale.unClientVoit == null)
                {
                    // le clientVoit n'existe pas
                    Globale.unClientVoit = new ClientVoit(cboCidt.Text, txtNom.Text, txtPrenom.Text, cboVendeur.Text);
                }
                else  // la clientVoit existe
                {
                    Globale.unClientVoit.setClientVoit(cboCidt.Text, txtNom.Text, txtPrenom.Text, cboVendeur.Text);
                }
            }


        }

        private void cboCidt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmdCredit_Click(object sender, EventArgs e)
        {
            FrmCredit unCredit = new FrmCredit();
            unCredit.Show();
            this.Hide();
        }


        Boolean verifSaisie()
        {
            // permet de verifier si les champs sont correctement renseigner

            Boolean verif = false;

            if (cboCidt.Text == "")
            {
                cboCidt.Focus();
                MessageBox.Show("Veuillez saisir votre civilité !!!", "Erreur de saisie");
                return verif;
            }

            if (txtNom.Text == "")
            {
                txtNom.Focus();
                MessageBox.Show("Veuillez saisir votre nom !!!", "Erreur de saisie");
                return verif;
            }

            if (txtPrenom.Text == "")
            {
                txtPrenom.Focus();
                MessageBox.Show("Veuillez saisir votre prenom !!!", "Erreur de saisie");
                return verif;
            }

            if (cboVendeur.Text == "")
            {
                cboVendeur.Focus();
                MessageBox.Show("Veuillez saisir le vendeur !!!", "Erreur de saisie");
                return verif;
            }

            if (txtNewVehc.Text == "")
            {
                txtNewVehc.Focus();
                MessageBox.Show("Veuillez saisir le nouveau vehicule !!!", "Erreur de saisie");
                return verif;
            }

            if (txtAncVehc.Text == "")
            {
                txtAncVehc.Focus();
                MessageBox.Show("Veuillz saisir l'ancien vehicule !!!", "Erreur de saisie");
                return verif;
            }

            // a complter le reste 
            return true;

        }
    }
}
