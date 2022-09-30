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
    public partial class FrmListeCredit : Form
    {
        public FrmListeCredit()
        {
            InitializeComponent();
        }

        private void lsbCredit_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void FrmListeCredit_Load(object sender, EventArgs e)
        {
            // mettre les elements de la collection vers la listbox de l'ecran
            //

            foreach (Credit xCredit in Globale.lesCredits)
            {
                lsbCredit.Items.Add(xCredit.getInfos());
            }


        }

        private void cmdInit_Click(object sender, EventArgs e)
        {
            // Initialiser la listBox
            lsbCredit.Items.Clear();

            // Initialiser la collection des credits
            Globale.lesCredits.Clear();
        }

        private void cmdCredit_Click(object sender, EventArgs e)
        {
            FrmCredit fenCredit = new FrmCredit();
            fenCredit.Show();
            this.Close();
        }
    }
}
