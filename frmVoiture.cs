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
<<<<<<< HEAD
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
=======
            //if (Globale.uneVoiture != null)
            //{
            //    cboxMarque.Text = Globale.uneVoiture.getMarque();
            //    cboxModele.Text = Globale.uneVoiture.getModele();
            //    cboxEnergie.Text = Globale.uneVoiture.getEnergieVehicule();
            //    cboxAnneeModele.Text = Globale.uneVoiture.getAnneeVehicule();
            //    cboxPuissance.Text = Globale.uneVoiture.getPuissance();
            //    lblFieldNumeroSerie.Text = Globale.uneVoiture.getNumSerie();
            //    lblFieldDatePremImmat.Text = Globale.uneVoiture.getDatePremiereImma();
            //    lblFieldNumeroImmat.Text = Globale.uneVoiture.getNumImmatriculation();
            //    lblprixVehicule.Text = Globale.uneVoiture.getPrixVehicule();

            //    //foreach (RadioButton radio in gpbAgeVehicule.Controls.OfType<RadioButton>())
            //    //{
            //    //    if (radio.Text == Globale.uneVoiture.getAgeVehicule())
            //    //    {
            //    //        radio.Checked = true;
            //    //    }
            //    //}

            //}

            // Interdire la saisie manuelle dans les champs comboBox
            cboxMarque.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxModele.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxAnneeModele.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxEnergie.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxPuissance.DropDownStyle = ComboBoxStyle.DropDownList;




          
            getMarquesConcession();

>>>>>>> origin/Aboubakr
        }

        private void cmdJenregistre_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            int i = 0;
            RadioButton radio = (RadioButton)gpbAgeVehicule.Controls[i];

            while ((radio.Checked == false) && (i < gpbAgeVehicule.Controls.Count - 1))
            {
                i++;
                radio = (RadioButton)gpbAgeVehicule.Controls[i];
            }

            string age = radio.Text;
=======
            //int i = 0;
            //RadioButton radio = (RadioButton)gpbAgeVehicule.Controls[i];

            //while ((radio.Checked == false) && (i < gpbAgeVehicule.Controls.Count - 1))
            //{
            //    i++;
            //    radio = (RadioButton)gpbAgeVehicule.Controls[i];
            //}

            //string age = radio.Text;
>>>>>>> origin/Aboubakr



            // Metttre les zones de textes vers l'object
            // Vers l'object voiture

            //Voiture uneVoiture = new Voiture(txtNouvVhc.text, AgeVehicule, txtDatePremierImma.Text, txtNumImma.Text, txtNumSerie.Text, txtPuissance.Text);

            // Apres verification des saisies des champs obligatoires
            if (verifSaisie())
            {
                if (Globale.uneVoiture == null)
                {
<<<<<<< HEAD
                    Globale.uneVoiture = new Voiture(cboxMarque.Text, cboxModele.Text, cboxEnergie.Text, cboxAnneeModele.Text, cboxPuissance.Text, lblFieldNumeroSerie.Text, lblFieldDatePremImmat.Text, lblFieldNumeroImmat.Text, age);
                }
                else
                {   // la voiture est à modifier avec les données
                    Globale.uneVoiture.setVoiture(cboxMarque.Text, cboxModele.Text, cboxEnergie.Text, cboxAnneeModele.Text, cboxPuissance.Text, lblFieldNumeroSerie.Text, lblFieldDatePremImmat.Text, lblFieldNumeroImmat.Text, age);
=======
                    Globale.uneVoiture = new Voiture(cboxMarque.Text, cboxModele.Text, cboxAnneeModele.Text, lblFieldDatePremImmat.Text, lblFieldNumeroImmat.Text, lblFieldNumeroSerie.Text, cboxPuissance.Text, cboxEnergie.Text, lblFieldprixVehicule.Text);
                }
                else
                {   // la voiture est à modifier avec les données
                    Globale.uneVoiture.setVoiture(cboxMarque.Text, cboxModele.Text, cboxAnneeModele.Text, lblFieldDatePremImmat.Text, lblFieldNumeroImmat.Text, lblFieldNumeroSerie.Text, cboxPuissance.Text, cboxEnergie.Text, lblFieldprixVehicule.Text);
>>>>>>> origin/Aboubakr
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

<<<<<<< HEAD
        private void cmdIntroduction_Click(object sender, EventArgs e)
        {
            frmIntroduction fenIntroduction = new frmIntroduction();
            fenIntroduction.Show();
            this.Close();
=======
        private void getMarquesConcession()
        {
            Globale.lesVoitures.Clear();
            lstVoiture.Items.Clear();
            cboxMarque.Items.Clear();
            cboxModele.Items.Clear();

            Globale.lesVoitures.Add(new Voiture("Toutes les marques"));

            cboxAnneeModele.Items.Clear();
            cboxEnergie.Items.Clear();
            cboxPuissance.Items.Clear();

            cboxModele.Enabled = false;
            cboxAnneeModele.Enabled = false;
            cboxEnergie.Enabled = false;
            cboxPuissance.Enabled = false;

            cboxModele.Text = "";
            cboxAnneeModele.Text = "";
            cboxEnergie.Text = "";
            cboxPuissance.Text = "";

            string codeConcession = Globale.uneConcession.getCodeConcession();

            Persistance.getMarquesConcession(codeConcession);

            foreach (Voiture v in Globale.lesVoitures)
            {
                if (v.getMarque() != "Toutes les marques")
                {
                
                string voiture = v.getMarque() + " " + v.getModele() + " " + v.getAnneeVehicule() + " " + v.getEnergieVehicule() + " " + v.getPuissance() + " cv";

                lstVoiture.Items.Add(voiture);

                }

                string marq = v.getMarque();

                if (!cboxMarque.Items.Contains(marq))
                {
                    cboxMarque.Items.Add(marq);
                }

            }



        }


        private void getModelesMarquesConcession()
        {
            Globale.lesVoitures.Clear();
            cboxModele.Text = "";
            lstVoiture.Items.Clear();
            cboxModele.Items.Clear();
            cboxAnneeModele.Items.Clear();
            cboxEnergie.Items.Clear();
            cboxPuissance.Items.Clear();

            cboxAnneeModele.Enabled = false;
            cboxEnergie.Enabled = false;
            cboxPuissance.Enabled = false;

            cboxAnneeModele.Text = "";
            cboxEnergie.Text = "";
            cboxPuissance.Text = "";

            string codeConcession = Globale.uneConcession.getCodeConcession();
            string marque = Convert.ToString(cboxMarque.SelectedItem);

            Persistance.getModelesMarquesConcession(codeConcession, marque);



            foreach (Voiture v in Globale.lesVoitures)
            {
                string voiture = v.getMarque() + " " + v.getModele() + " " + v.getAnneeVehicule() + " " + v.getEnergieVehicule() + " " + v.getPuissance() + " cv";
                lstVoiture.Items.Add(voiture);
                string modele = v.getModele();
                //Console.WriteLine(modele);
                if (!cboxModele.Items.Contains(modele))
                {
                    cboxModele.Items.Add(modele);
                }

            }
          
        }


        private void getAnneeModelesMarquesConcession()
        {
            Globale.lesVoitures.Clear();
            cboxAnneeModele.Text = "";
            lstVoiture.Items.Clear();
            cboxAnneeModele.Items.Clear();
            cboxEnergie.Items.Clear();
            cboxPuissance.Items.Clear();

            cboxEnergie.Enabled = false;
            cboxPuissance.Enabled = false;

            cboxEnergie.Text = "";
            cboxPuissance.Text = "";

            string codeConcession = Globale.uneConcession.getCodeConcession();
            string marque = Convert.ToString(cboxMarque.SelectedItem);
            string modele = Convert.ToString(cboxModele.SelectedItem);

            Persistance.getAnneeModelesMarquesConcession(codeConcession, marque, modele);



            foreach (Voiture v in Globale.lesVoitures)
            {
                string voiture = v.getMarque() + " " + v.getModele() + " " + v.getAnneeVehicule() + " " + v.getEnergieVehicule() + " " + v.getPuissance() + " cv";
                lstVoiture.Items.Add(voiture);
                string annee = v.getAnneeVehicule();
                //Console.WriteLine(modele);
                if (!cboxAnneeModele.Items.Contains(annee))
                {
                    cboxAnneeModele.Items.Add(annee);
                }

            }

        }

        private void getEnergieAnneeModelesMarquesConcession()
        {
            Globale.lesVoitures.Clear();
            cboxEnergie.Text = "";
            lstVoiture.Items.Clear();
            cboxEnergie.Items.Clear();
            cboxPuissance.Items.Clear();

            cboxPuissance.Enabled = false;

            cboxPuissance.Text = "";

            string codeConcession = Globale.uneConcession.getCodeConcession();
            string marque = Convert.ToString(cboxMarque.SelectedItem);
            string modele = Convert.ToString(cboxModele.SelectedItem);
            string anneeModele = Convert.ToString(cboxAnneeModele.SelectedItem);

            Persistance.getEnergieAnneeModelesMarquesConcession(codeConcession, marque, modele, anneeModele);



            foreach (Voiture v in Globale.lesVoitures)
            {
                string voiture = v.getMarque() + " " + v.getModele() + " " + v.getAnneeVehicule() + " " + v.getEnergieVehicule() + " " + v.getPuissance() + " cv";
                lstVoiture.Items.Add(voiture);

                string energie = v.getEnergieVehicule();
                //Console.WriteLine(modele);
                if (!cboxEnergie.Items.Contains(energie))
                {
                    cboxEnergie.Items.Add(energie);
                }

            }

        }

        private void getPuissanceEnergieAnneeModelesMarquesConcession()
        {
            Globale.lesVoitures.Clear();
            cboxPuissance.Text = "";
            lstVoiture.Items.Clear();
            cboxPuissance.Items.Clear();


            string codeConcession = Globale.uneConcession.getCodeConcession();
            string marque = Convert.ToString(cboxMarque.SelectedItem);
            string modele = Convert.ToString(cboxModele.SelectedItem);
            string anneeModele = Convert.ToString(cboxAnneeModele.SelectedItem);
            string energieVehicule = Convert.ToString(cboxEnergie.SelectedItem);

            Persistance.getPuissanceEnergieAnneeModelesMarquesConcession(codeConcession, marque, modele, anneeModele, energieVehicule);



            foreach (Voiture v in Globale.lesVoitures)
            {
                string voiture = v.getMarque() + " " + v.getModele() + " " + v.getAnneeVehicule() + " " + v.getEnergieVehicule() + " " + v.getPuissance() + " cv";
                lstVoiture.Items.Add(voiture);

                string puissance = v.getPuissance();
                //Console.WriteLine(modele);
                if (!cboxPuissance.Items.Contains(puissance))
                {
                    cboxPuissance.Items.Add(puissance);
                }

            }

        }

        private void cmdIntroduction_Click(object sender, EventArgs e)
        {
            FrmClient fenClient = new FrmClient();
            fenClient.Show();
 
            this.Hide();
        }

        private void cboxMarque_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboxMarque.SelectedItem.ToString() == "Toutes les marques")
            {
                string marqueSelectionnee = cboxMarque.SelectedItem.ToString();

                cboxMarque.Text = marqueSelectionnee;
                getMarquesConcession();
            } else
            {

             string marque = Convert.ToString(cboxMarque.SelectedItem);
            Console.WriteLine(marque);
            getModelesMarquesConcession();

            lblFieldDatePremImmat.Text = "";
            lblFieldNumeroImmat.Text = "";
            lblFieldNumeroSerie.Text = "";
            lblFieldprixVehicule.Text = "";

            }
            cboxModele.Enabled = true;


        }

        private void lstVoiture_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboxModele_SelectedIndexChanged(object sender, EventArgs e)
        {
            string modele = Convert.ToString(cboxModele.SelectedItem);
            getAnneeModelesMarquesConcession();
            //Console.WriteLine("Selection du modele : " + modele);

            lblFieldDatePremImmat.Text = "";
            lblFieldNumeroImmat.Text = "";
            lblFieldNumeroSerie.Text = "";
            lblFieldprixVehicule.Text = "";

            cboxAnneeModele.Enabled = true;
        }

        private void cboxAnneeModele_SelectedIndexChanged(object sender, EventArgs e)
        {

            string annee = Convert.ToString(cboxAnneeModele.SelectedItem);
            getEnergieAnneeModelesMarquesConcession();
            //Console.WriteLine("Selection de l'annee : " + annee);

            lblFieldDatePremImmat.Text = "";
            lblFieldNumeroImmat.Text = "";
            lblFieldNumeroSerie.Text = "";
            lblFieldprixVehicule.Text = "";

            cboxEnergie.Enabled = true;
            
        }

        private void cboxEnergie_SelectedIndexChanged(object sender, EventArgs e)
        {
            string puissance = Convert.ToString(cboxPuissance.SelectedItem);
            getPuissanceEnergieAnneeModelesMarquesConcession();
            //Console.WriteLine("Selection de la puissance : " + puissance);

            lblFieldDatePremImmat.Text = "";
            lblFieldNumeroImmat.Text = "";
            lblFieldNumeroSerie.Text = "";
            lblFieldprixVehicule.Text = "";

            cboxPuissance.Enabled = true;
        }

        private void cboxPuissance_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxPuissance.SelectedItem != null)
            {
                foreach (Voiture v in Globale.lesVoitures)
                {
                    lblFieldDatePremImmat.Text = v.getDatePremiereImma();
                    lblFieldNumeroImmat.Text = v.getNumImmatriculation();
                    lblFieldNumeroSerie.Text = v.getNumSerie();
                    lblFieldprixVehicule.Text = v.getPrixVehicule() + " €";
                }
                
            }

            string codeConcession = Globale.uneConcession.getCodeConcession();
            string marque = Convert.ToString(cboxMarque.SelectedItem);
            string modele = Convert.ToString(cboxModele.SelectedItem);
            string anneeModele = Convert.ToString(cboxAnneeModele.SelectedItem);
            string energieVehicule = Convert.ToString(cboxEnergie.SelectedItem);

            // Créer un PictureBox avec un nom de variable picCategorie
            PictureBox picCategorie = new PictureBox();
            picCategorie.Location = new Point(10, 10); // position de la PictureBox sur la form
            picCategorie.Size = new Size(200, 200); // taille de la PictureBox
            this.Controls.Add(picCategorie); // ajouter la PictureBox à la form

            // Appeler la méthode ChargerImages            
            //Persistance.ChargerImages(codeConcession, marque, modele, anneeModele, energieVehicule, picCategorie);





        }

        private void cmdCredit_Click(object sender, EventArgs e)
        {
            FrmCredit unCredit = new FrmCredit();
            unCredit.Show();
            this.Hide();
>>>>>>> origin/Aboubakr
        }
    }
}
