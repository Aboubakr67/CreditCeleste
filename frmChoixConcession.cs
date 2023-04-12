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
    public partial class frmChoixConcession : Form
    {
        public frmChoixConcession()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmdValider_Click(object sender, EventArgs e)
        {

            if(verifSaisie())
            {
               
                FrmClient fenClient = new FrmClient();

                fenClient.Show();
                //this.Close();      // on ferme la fenetre


                this.Hide();   // pour cacher la fenetre
            }
            

        }

        private void frmChoixConcession_Load(object sender, EventArgs e)
        {
            cboRegion.DropDownStyle = ComboBoxStyle.DropDownList;
            cboVille.DropDownStyle = ComboBoxStyle.DropDownList;

            Persistance.RecupConcessionRegionBDD();

            foreach (string xRegion in Globale.lesRegions)
            {
                cboRegion.Items.Add(xRegion);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cboRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (Convert.ToString(cboRegion.SelectedItem) != Globale.laRegion)
            {
                //Console.WriteLine("---------------------------------------");
                //Console.WriteLine("Rentre dans le if");
                //Console.WriteLine("cboRegion = " + cboRegion.SelectedItem);
                //Console.WriteLine("Globale.laRegion = " + Globale.laRegion);
                //Console.WriteLine("Fin if");
                //Console.WriteLine("---------------------------------------");
                cboVille.Text = "";
                Globale.lesVilles.Clear();
                cboVille.Items.Clear();
            }

            // stocke la region dans la variable globale laRegion
            Globale.laRegion = Convert.ToString(cboRegion.SelectedItem);
            Console.WriteLine(Globale.laRegion);

            Persistance.RecupConcessionVilleBDD(Globale.laRegion);
            

            foreach (string xVilles in Globale.lesVilles)
            {

                Console.WriteLine(xVilles);
                cboVille.Items.Add(xVilles);
            }
        }

        private void cboVille_SelectedIndexChanged(object sender, EventArgs e)
        {
            Globale.laVille = Convert.ToString(cboVille.SelectedItem);
            Console.WriteLine(Globale.laVille);
        }





        Boolean verifSaisie()
        {
            // permet de verifier si les champs sont correctement renseigner

            Boolean verif = false;

            if (Globale.laRegion == null)
            {
                cboRegion.Focus();
                MessageBox.Show("Veuillez selectionner votre region", "Erreur de saisie");
                return verif;
            }

            if (Globale.laVille == null)
            {
                cboVille.Focus();
                MessageBox.Show("Veuillez selectionner votre ville", "Erreur de saisie");
                return verif;
            }


            // a complter le reste 
            return true;

        }




    }
}
