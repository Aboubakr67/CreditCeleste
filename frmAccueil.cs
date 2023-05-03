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
    public partial class frmAccueil : Form
    {
        public frmAccueil()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // -- Création d'un concession

<<<<<<< HEAD
            // gerer ma region
            lblMaRegion.Text = Concession.maRegion;


=======
          
>>>>>>> origin/Aboubakr
            // Gestion de mon application (Nom de la personne qui a fait le projet)
            lblMonAppli.Text = Globale.monApplication;


<<<<<<< HEAD
            Globale.uneConcession = new Concession("Garage ZENNIR", "66 rue des Voyages");

            // -- Rajout du vendeur


            Vendeur unVendeur = new Vendeur("M.", "ZENNIR", "Aboubakr");

            Vendeur un2Vendeur = new Vendeur("Mme.", "Schickele", "Emma");
            Vendeur un3Vendeur = new Vendeur("Mlle.", "Bellout", "Sirine");

            // rajouter les vendeurs à la concession
            Globale.uneConcession.ajoutVendeur(unVendeur);
            Globale.uneConcession.ajoutVendeur(un2Vendeur);
            Globale.uneConcession.ajoutVendeur(un3Vendeur);


            // Il faudrait les récuperer de la base de données
            // a l'aide de la fonction gestBdd()
            //Globale.gestBdd();
=======
            //Globale.uneConcession = new Concession("Garage ZENNIR", "Grand Est", "Strasbourg");

            

    
>>>>>>> origin/Aboubakr

        }

        private void cmdIntroduction_Click(object sender, EventArgs e)
        {
            // appel de la fenetre Introduction

<<<<<<< HEAD
            frmIntroduction fenIntroduction = new frmIntroduction();

            fenIntroduction.Show();
=======
            frmChoixConcession fenChoixConcession = new frmChoixConcession();

            fenChoixConcession.Show();
>>>>>>> origin/Aboubakr
            //this.Close();      // on ferme la fenetre


            this.Hide();   // pour cacher la fenetre


        }
<<<<<<< HEAD
=======

        private void cmdEtude_Click(object sender, EventArgs e)
        {
            FrmCreditDeLaBDD fenCreditDeLaBDD = new FrmCreditDeLaBDD();
            fenCreditDeLaBDD.Show();
            this.Hide();
            
        }
>>>>>>> origin/Aboubakr
    }
}
