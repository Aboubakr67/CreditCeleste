﻿using System;
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

        private void cmdIntroduction_MouseEnter(object sender, EventArgs e)
        {
            this.cmdIntroduction.FlatAppearance.BorderColor = Color.White;
            this.cmdIntroduction.ForeColor = Color.White;
        }

        private void cmdIntroduction_MouseLeave(object sender, EventArgs e)
        {
            this.cmdIntroduction.FlatAppearance.BorderColor = Color.DodgerBlue;
            this.cmdIntroduction.ForeColor = Color.DodgerBlue;
        }

        private void cmdEtude_MouseEnter(object sender, EventArgs e)
        {
            this.cmdEtude.FlatAppearance.BorderColor = Color.White;
            this.cmdEtude.ForeColor = Color.White;
        }

        private void cmdEtude_MouseLeave(object sender, EventArgs e)
        {
            this.cmdEtude.FlatAppearance.BorderColor = Color.DodgerBlue;
            this.cmdEtude.ForeColor = Color.DodgerBlue;
        }

        private void cmdRelance_MouseEnter(object sender, EventArgs e)
        {
            this.cmdRelance.FlatAppearance.BorderColor = Color.White;
            this.cmdRelance.ForeColor = Color.White;
        }

        private void cmdRelance_MouseLeave(object sender, EventArgs e)
        {
            this.cmdRelance.FlatAppearance.BorderColor = Color.DodgerBlue;
            this.cmdRelance.ForeColor = Color.DodgerBlue;
        }
    }
}
