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
            frmIntroduction unIntroduction = new frmIntroduction();
            unIntroduction.Show();
            this.Hide();
        }

        private void cmdJenregistre_Click(object sender, EventArgs e)
        {
            frmSaisieBien unBien = new frmSaisieBien();
            unBien.Show();
            this.Hide();
        }

        private void Credit_Load(object sender, EventArgs e)
        {

        }

        private void cmdCalcul_Click(object sender, EventArgs e)
        {
            // Calculer la mensualité
            //

            Credit unCredit = new Credit(Convert.ToDouble(txtmontantFinance.Text), Convert.ToDouble(cboDureeMois.Text), Convert.ToDouble(txttaux.Text));

            txtmensualite.Text = Convert.ToString(unCredit.getMensualite());

            //
            // pour sauvegarder le credit
            //rajoute le credit à la collection des crédits
            Globale.lesCredits.Add(unCredit);


        }

        private void cmdListeCredit_Click(object sender, EventArgs e)
        {
            FrmListeCredit fenListeCredit = new FrmListeCredit();
            fenListeCredit.Show();
            this.Close();
        }
    }
}
