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
    public partial class FrmCreditDeLaBDD : Form
    {
        public FrmCreditDeLaBDD()
        {
            InitializeComponent();
        }

        private void cmdAccueil_Click(object sender, EventArgs e)
        {
            FrmCredit unCredit = new FrmCredit();
            unCredit.Show();
            this.Hide();
        }

        private void FrmCreditDeLaBDD_Load(object sender, EventArgs e)
        {
            //Persistance.affCreditEtude();


            //lstCreditDeLaBDD.Items.Clear();

            //foreach (Credit xCredit in Globale.lesCreditEtude)
            //{
            //    lstCreditDeLaBDD.Items.Add(xCredit);
            //}


        }

        private void lstCreditDeLaBDD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
