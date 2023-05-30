using System;
using System.Windows.Forms;


namespace CreditCeleste
{
    public partial class FrmCredit : Form
    {
        public FrmCredit()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmdIntroduction_Click(object sender, EventArgs e)
        {
            FrmClient fenClient = new FrmClient();
            fenClient.Show();

            this.Hide();
        }

        public string PagePrecedente { get; set; }

        public void modifCreditRelance()
        {
            if (verifSaisieCreditRelance())
            {
                double montantCredit = 0;
                double dureeCredit = 0;
                double tauxCredit = 0;
                double mensualiteCredit = 0;

                try
                {
                    string codeValidation = "E";

                    foreach (Credit xCredit in Globale.lesCredits)
                    {

                        if (Convert.ToString(lsbCredit.SelectedItem) == xCredit.getInfos())
                        {

                            montantCredit = xCredit.getMontant();
                            dureeCredit = xCredit.getDuree();
                            tauxCredit = xCredit.getTaux();
                            mensualiteCredit = xCredit.getMensualite();

                        }

                        Persistance.relancerCredit(Convert.ToString(monNumCredit), Convert.ToString(codeValidation), Convert.ToString(mensualiteCredit), Convert.ToString(tauxCredit), Convert.ToString(dureeCredit), Convert.ToString(montantCredit));
                    }
                    MessageBox.Show("Le crédit à bien été enregistré.", "Information"); //sinon le msg saffiche 10000 x

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erreur: " + ex.Message);
                    throw;
                }
            }
    }

        private void cmdJenregistre_Click(object sender, EventArgs e)
        {
            if (PagePrecedente == "Relance")
            {
                modifCreditRelance();
                Console.WriteLine("dans le if");
            }
            else
            {
                if (verifSaisie())
                {

                    double montantCredit = 0;
                    double dureeCredit = 0;
                    double tauxCredit = 0;
                    double mensualiteCredit = 0;

                    try
                    {

                        Persistance.insertClient();

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Erreur: " + ex.Message);
                        throw;
                    }



                    try
                    {

                        foreach (Credit xCredit in Globale.lesCredits)
                        {

                            if (Convert.ToString(lsbCredit.SelectedItem) == xCredit.getInfos())
                            {
                                //Console.WriteLine(xCredit.getMontant());
                                //Console.WriteLine(xCredit.getDuree());
                                //Console.WriteLine(xCredit.getTaux());
                                ///Console.WriteLine(xCredit.getMensualite());
                                //Console.WriteLine(xCredit.getInfos());
                                //Console.WriteLine(Convert.ToString(lsbCredit.SelectedItem));
                                montantCredit = xCredit.getMontant();
                                dureeCredit = xCredit.getDuree();
                                tauxCredit = xCredit.getTaux();
                                mensualiteCredit = xCredit.getMensualite();

                            }

                            //Console.WriteLine(xCredit.getInfos());

                        }
                        int numvendeur = Persistance.RecupNumVendeurBDD();
                        int codeClient = Persistance.RecupCodeClientBDD();
                        string codeCollab = Globale.uneConcession.getCodeCollab();
                        string codeConcession = Globale.uneConcession.getCodeConcession();
                        string codeValidation = "E";
                        //Console.WriteLine("montant : " + Convert.ToString(montantCredit));
                        //Console.WriteLine("tauxCredit : " + Convert.ToString(tauxCredit));
                        //Console.WriteLine("duree : " + Convert.ToString(dureeCredit));
                        //Console.WriteLine("mensualite : " + Convert.ToString(mensualiteCredit));
                        //Console.WriteLine("num vendeur : " + numvendeur);
                        //Console.WriteLine("codeClient : " + codeClient);
                        //Console.WriteLine("codeValidation : " + codeValidation);
                        Persistance.insertCredit(Convert.ToString(montantCredit), Convert.ToString(tauxCredit), Convert.ToString(dureeCredit), Convert.ToString(mensualiteCredit), numvendeur, codeClient, codeValidation, codeCollab, codeConcession);
                        MessageBox.Show("Le crédit à bien été enregistré.", "Information");

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Erreur: " + ex.Message);
                        throw;
                    }

                }
            }
        }
        int monNumCredit;

        private void Credit_Load(object sender, EventArgs e)
        {

            if (PagePrecedente == "Relance")
            {
                PagePrecedente = "Relance";
                cmdInitCredit.Enabled = false;
                cmdVoiture.Enabled = false;
                cmdClient.Enabled = false;
                cmdListeCreditBDD.Enabled = false;
                foreach (Credit credit in Globale.lesCreditRelance)
                {
                    // Initialiser la listBox
                    lsbCredit.Items.Clear();

                    // Initialiser la collection des credits
                    Globale.lesCredits.Clear();

                    lsbCredit.Items.Add(credit.getInfos());
                    monNumCredit = credit.getNumCredit();



                }

            }

            lblRegion.Text = Globale.laRegion;
            lblVille.Text = Globale.laVille;
  

            foreach(Credit credit in Globale.lesCredits)
            {
                lsbCredit.Items.Add(credit.getInfos());
            }

            // Bloquer la saisie de champ en dehort de nombre et virgule dans les textBox
            txtmontantFinance.KeyPress += new KeyPressEventHandler(BloquerSaisieCaracteresNonAutorises);
            txtDureeMois.KeyPress += new KeyPressEventHandler(BloquerSaisieCaracteresNonAutorises);
            txttaux.KeyPress += new KeyPressEventHandler(BloquerSaisieCaracteresNonAutorises);

            // Désactiver la zone de texte "txtmensualite" pour empêcher la sélection du texte
            txtmensualite.Enabled = false;
        }
        
        private void cmdCalcul_Click(object sender, EventArgs e)
        {
            // Calculer la mensualité
            //

            Credit unCredit = new Credit(Convert.ToDouble(txtmontantFinance.Text), Convert.ToDouble(txtDureeMois.Text), Convert.ToDouble(txttaux.Text));

            txtmensualite.Text = Convert.ToString(unCredit.getMensualite());

            //
            // pour sauvegarder le credit
            //rajoute le credit à la collection des crédits
            Globale.lesCredits.Add(unCredit);


            // mettre les elements de la collection vers la listbox de l'ecran
            //

            lsbCredit.Items.Add(unCredit.getInfos());


        }

        private void cmdListeCredit_Click(object sender, EventArgs e)
        {
            FrmCreditDeLaBDD fenListeCreditBDD = new FrmCreditDeLaBDD();
            fenListeCreditBDD.Show();
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        Boolean verifSaisieCreditRelance()
        {
            Boolean verif = false;
            if (txtmontantFinance.Text == "")
            {
                txtmontantFinance.Focus();
                MessageBox.Show("Veuillez saisir le montant du credit", "Erreur de saisie");
                return verif;
            }

            if (txtDureeMois.Text == "")
            {
                txtDureeMois.Focus();
                MessageBox.Show("Veuillez saisir la duree du credit !!!", "Erreur de saisie");
                return verif;
            }

            if (txttaux.Text == "")
            {
                txttaux.Focus();
                MessageBox.Show("Veuillez saisir le taux du credit !!!", "Erreur de saisie");
                return verif;
            }

            return true;


        }
        Boolean verifSaisie()
        {
            // permet de verifier si les champs sont correctement renseigner
            Boolean verif = false;

            // Vérification que unClientVoit est initialisé
            if (Globale.unClientVoit == null)
            {
                MessageBox.Show("Les informations du client n'ont pas été saisies complètement et/ou enregistrées.", "Erreur de saisie");
                return verif;
            }


            if (txtmontantFinance.Text == "")
            {
                txtmontantFinance.Focus();
                MessageBox.Show("Veuillez saisir le montant du credit", "Erreur de saisie");
                return verif;
            }

            if (txtDureeMois.Text == "")
            {
                txtDureeMois.Focus();
                MessageBox.Show("Veuillez saisir la duree du credit !!!", "Erreur de saisie");
                return verif;
            }

            if (txttaux.Text == "")
            {
                txttaux.Focus();
                MessageBox.Show("Veuillez saisir le taux du credit !!!", "Erreur de saisie");
                return verif;
            }

            //Globale.unClientVoit = new ClientVoit();

            if (string.IsNullOrEmpty(Globale.unClientVoit.getNomClient()))
            {
                
                cmdClient.Focus();
                MessageBox.Show("Veuillez saisir le nom du client !!!", "Erreur de saisie");
                return verif;
            }

            if (Globale.unClientVoit.getPrenomClient() == "")
            {
                cmdClient.Focus();
                MessageBox.Show("Veuillez saisir le prenom du client !!!", "Erreur de saisie");
                return verif;
            }

            if (Globale.unClientVoit.getMonCidClient() == "")
            {
                cmdClient.Focus();
                MessageBox.Show("Veuillz saisir le cid du client !!!", "Erreur de saisie");
                return verif;
            }


            if (Convert.ToString(lsbCredit.SelectedItem) == "")
            {
                cmdClient.Focus();
                MessageBox.Show("Veuillez selectionner un credit !!!", "Erreur de saisie");
                return verif;
            }


            if (Globale.unClientVoit.getVendeur() == "")
            {
                cmdClient.Focus();
                MessageBox.Show("Veuillez selectionner un vendeur !!!", "Erreur de saisie");
                return verif;
            }



            // a complter le reste 
            return true;

        }

        private void cmdInitCredit_Click(object sender, EventArgs e)
        {
            // Initialiser la listBox
            lsbCredit.Items.Clear();

            // Initialiser la collection des credits
            Globale.lesCredits.Clear();
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

        private void cmdAccueil_Click(object sender, EventArgs e)
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
            //this.Close();      // on ferme la fenetre

            this.Hide();
        }

        private void lsbCredit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtmontantFinance_TextChanged(object sender, EventArgs e)
        {

        }

        // Méthode statique pour bloquer la saisie de caractères non autorisés
        public static void BloquerSaisieCaracteresNonAutorises(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void lblVille_Click(object sender, EventArgs e)
        {

        }

        private void txtmensualite_TextChanged(object sender, EventArgs e)
        {

        }
    }
   }

