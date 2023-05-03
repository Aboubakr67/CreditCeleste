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
    public partial class FrmClient : Form
    {
        public FrmClient()
        {
            InitializeComponent();
        }

        private void cmdVoiture_Click(object sender, EventArgs e)
        {
            // appel de la fenetre voiture

            //frmSaisieBien fenSaisieBien = new frmSaisieBien();

            //fenSaisieBien.Show();

            //this.Close();

            frmVoiture fenVoiture = new frmVoiture();

            fenVoiture.Show();

            this.Close();
        }

        private void cmdCredit_Click(object sender, EventArgs e)
        {
            FrmCredit unCredit = new FrmCredit();
            unCredit.Show();
            this.Hide();
        }

        private void FrmClient_Load(object sender, EventArgs e)
        {
            lblRegion.Text = Globale.laRegion;
            lblVille.Text = Globale.laVille;

            cboVendeur.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCidt.DropDownStyle = ComboBoxStyle.DropDownList;

            Persistance.recupereConcByRegionVille(Globale.laRegion, Globale.laVille);
            lblNomConcession.Text = Globale.uneConcession.getMonNomConcession();

            // -- Rajout du vendeur
            Persistance.RecupVendeurBDD(Globale.uneConcession.getCodeConcession());

            Console.WriteLine("Globale.laRegion : " + Globale.laRegion);
            Console.WriteLine("Globale.laVille : " + Globale.laVille);


            Console.WriteLine("----------------------------------------- ");
            Console.WriteLine("Concession code : " + Globale.uneConcession.getCodeConcession());
            Console.WriteLine("Concession nom : " + Globale.uneConcession.getMonNomConcession());
            Console.WriteLine("Concession tel : " + Globale.uneConcession.getTelConcession());
            Console.WriteLine("Concession email) : " + Globale.uneConcession.getMailConcession());
            Console.WriteLine("Concession region) : " + Globale.uneConcession.getRegionConcession());
            Console.WriteLine("Concession ville : " + Globale.uneConcession.getVilleConcession());
            Console.WriteLine("Concession stock : " + Globale.uneConcession.getStockVehicule());


            foreach (Vendeur xVendeur in Globale.uneConcession.getLesVendeurs())
            {
                cboVendeur.Items.Add(xVendeur.getInfosVendeurs());
            }


            if (Globale.unClientVoit != null)
            {
                cboCidt.Text = Globale.unClientVoit.getMonCidClient();
                txtNom.Text = Globale.unClientVoit.getNomClient();
                txtPrenom.Text = Globale.unClientVoit.getPrenomClient();
                txtTelCli.Text = Globale.unClientVoit.getTelClient();
                txtEmail.Text = Globale.unClientVoit.getEmailClient();
                txtNumRue.Text = Globale.unClientVoit.getNumRueClient();
                txtRue.Text = Globale.unClientVoit.getRueClient();
                txtVille.Text = Globale.unClientVoit.getVilleClient();
                txtCodePostal.Text = Globale.unClientVoit.getCodePostalClient();

                cboVendeur.Text = Globale.unClientVoit.getVendeur();
            }

        }

        private void cmdEnregistreClient_Click(object sender, EventArgs e)
        {

            if (verifSaisie())
            {
                
                if (Globale.unClientVoit == null)
                {
                    // le clientVoit n'existe pas
                    Globale.unClientVoit = new ClientVoit(cboCidt.Text, txtNom.Text, txtPrenom.Text, cboVendeur.Text, txtTelCli.Text, txtEmail.Text, txtNumRue.Text, txtRue.Text, txtVille.Text, txtCodePostal.Text);
                }
                else  // la clientVoit existe
                {
                    Globale.unClientVoit.setClientVoit(cboCidt.Text, txtNom.Text, txtPrenom.Text, cboVendeur.Text, txtTelCli.Text, txtEmail.Text, txtNumRue.Text, txtRue.Text, txtVille.Text, txtCodePostal.Text);
                }

            }


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

            if (txtTelCli.Text == "")
            {
                txtTelCli.Focus();
                MessageBox.Show("Veuillez saisir votre telephone !!!", "Erreur de saisie");
                return verif;
            }

            if(txtEmail.Text == "")
            {
                txtEmail.Focus();
                MessageBox.Show("Veuillez saisir votre email !!!", "Erreur de saisie");
                return verif;
            }

            if (txtNumRue.Text == "")
            {
                txtNumRue.Focus();
                MessageBox.Show("Veuillez saisir votre numéro de rue !!!", "Erreur de saisie");
                return verif;
            }

            if (txtRue.Text == "")
            {
                txtRue.Focus();
                MessageBox.Show("Veuillez saisir votre rue !!!", "Erreur de saisie");
                return verif;
            }

            if(txtVille.Text == "")
            {
                txtVille.Focus();
                MessageBox.Show("Veuillez saisir votre ville !!!", "Erreur de saisie");
                return verif;
            }


            if (txtCodePostal.Text == "")
            {
                txtCodePostal.Focus();
                MessageBox.Show("Veuillez saisir votre code postal !!!", "Erreur de saisie");
                return verif;
            }

            if (cboVendeur.Text == "")
            {
                cboVendeur.Focus();
                MessageBox.Show("Veuillez saisir le vendeur !!!", "Erreur de saisie");
                return verif;
            }
                      
            // a complter le reste 
            return true;

        }

    }
}
