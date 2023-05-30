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

          
            // Gestion de mon application (Nom de la personne qui a fait le projet)
            lblMonAppli.Text = Globale.monApplication;


            //Globale.uneConcession = new Concession("Garage ZENNIR", "Grand Est", "Strasbourg");

            

    

        }

        private void cmdIntroduction_Click(object sender, EventArgs e)
        {
            // appel de la fenetre Introduction

            frmChoixConcession fenChoixConcession = new frmChoixConcession();
            fenChoixConcession.PagePrecedente = "Introduction";
            fenChoixConcession.Show();
            //this.Close();      // on ferme la fenetre


            this.Hide();   // pour cacher la fenetre


        }

        private void cmdEtude_Click(object sender, EventArgs e)
        {
            //frmEtude fenEtude = new frmEtude();
            //fenEtude.Show();
            //this.Hide();

            frmChoixConcession fenChoixConcession = new frmChoixConcession();
            fenChoixConcession.PagePrecedente = "Etude";
            fenChoixConcession.Show();
            this.Hide();

        }

        private void cmdRelance_Click(object sender, EventArgs e)
        {
            frmChoixConcession fenChoixConcession = new frmChoixConcession();
            fenChoixConcession.PagePrecedente = "Relance";
            fenChoixConcession.Show();
            this.Hide();
        }
    }
}
