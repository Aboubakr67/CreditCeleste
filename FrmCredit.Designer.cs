
namespace CreditCeleste
{
    partial class FrmCredit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdCalcul = new System.Windows.Forms.Button();
            this.cmdJenregistre = new System.Windows.Forms.Button();
<<<<<<< HEAD
            this.cmdIntroduction = new System.Windows.Forms.Button();
=======
>>>>>>> origin/Aboubakr
            this.txtmontantFinance = new System.Windows.Forms.TextBox();
            this.txttaux = new System.Windows.Forms.TextBox();
            this.txtmensualite = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
<<<<<<< HEAD
            this.cmdListeCredit = new System.Windows.Forms.Button();
            this.cboDureeMois = new System.Windows.Forms.ComboBox();
=======
            this.cmdListeCreditBDD = new System.Windows.Forms.Button();
            this.lblVille = new System.Windows.Forms.Label();
            this.lblRegion = new System.Windows.Forms.Label();
            this.lsbCredit = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdVoiture = new System.Windows.Forms.Button();
            this.cmdInitCredit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmdClient = new System.Windows.Forms.Button();
            this.cmdAccueil = new System.Windows.Forms.Button();
            this.txtDureeMois = new System.Windows.Forms.TextBox();
>>>>>>> origin/Aboubakr
            this.SuspendLayout();
            // 
            // cmdCalcul
            // 
<<<<<<< HEAD
            this.cmdCalcul.Location = new System.Drawing.Point(109, 333);
            this.cmdCalcul.Name = "cmdCalcul";
            this.cmdCalcul.Size = new System.Drawing.Size(115, 50);
=======
            this.cmdCalcul.Location = new System.Drawing.Point(38, 280);
            this.cmdCalcul.Name = "cmdCalcul";
            this.cmdCalcul.Size = new System.Drawing.Size(81, 28);
>>>>>>> origin/Aboubakr
            this.cmdCalcul.TabIndex = 0;
            this.cmdCalcul.Text = "Calcul";
            this.cmdCalcul.UseVisualStyleBackColor = true;
            this.cmdCalcul.Click += new System.EventHandler(this.cmdCalcul_Click);
            // 
            // cmdJenregistre
            // 
<<<<<<< HEAD
            this.cmdJenregistre.Location = new System.Drawing.Point(261, 333);
            this.cmdJenregistre.Name = "cmdJenregistre";
            this.cmdJenregistre.Size = new System.Drawing.Size(113, 50);
=======
            this.cmdJenregistre.Location = new System.Drawing.Point(672, 344);
            this.cmdJenregistre.Name = "cmdJenregistre";
            this.cmdJenregistre.Size = new System.Drawing.Size(102, 55);
>>>>>>> origin/Aboubakr
            this.cmdJenregistre.TabIndex = 1;
            this.cmdJenregistre.Text = "J\'enregistre";
            this.cmdJenregistre.UseVisualStyleBackColor = true;
            this.cmdJenregistre.Click += new System.EventHandler(this.cmdJenregistre_Click);
            // 
<<<<<<< HEAD
            // cmdIntroduction
            // 
            this.cmdIntroduction.Location = new System.Drawing.Point(568, 333);
            this.cmdIntroduction.Name = "cmdIntroduction";
            this.cmdIntroduction.Size = new System.Drawing.Size(109, 55);
            this.cmdIntroduction.TabIndex = 2;
            this.cmdIntroduction.Text = "Introduction";
            this.cmdIntroduction.UseVisualStyleBackColor = true;
            this.cmdIntroduction.Click += new System.EventHandler(this.cmdIntroduction_Click);
            // 
            // txtmontantFinance
            // 
            this.txtmontantFinance.Location = new System.Drawing.Point(302, 46);
            this.txtmontantFinance.Name = "txtmontantFinance";
            this.txtmontantFinance.Size = new System.Drawing.Size(108, 20);
            this.txtmontantFinance.TabIndex = 3;
            // 
            // txttaux
            // 
            this.txttaux.Location = new System.Drawing.Point(302, 163);
            this.txttaux.Name = "txttaux";
            this.txttaux.Size = new System.Drawing.Size(100, 20);
=======
            // txtmontantFinance
            // 
            this.txtmontantFinance.Location = new System.Drawing.Point(32, 73);
            this.txtmontantFinance.Name = "txtmontantFinance";
            this.txtmontantFinance.Size = new System.Drawing.Size(108, 20);
            this.txtmontantFinance.TabIndex = 3;
            this.txtmontantFinance.TextChanged += new System.EventHandler(this.txtmontantFinance_TextChanged);
            // 
            // txttaux
            // 
            this.txttaux.Location = new System.Drawing.Point(32, 177);
            this.txttaux.Name = "txttaux";
            this.txttaux.Size = new System.Drawing.Size(108, 20);
>>>>>>> origin/Aboubakr
            this.txttaux.TabIndex = 5;
            // 
            // txtmensualite
            // 
<<<<<<< HEAD
            this.txtmensualite.Location = new System.Drawing.Point(302, 224);
            this.txtmensualite.Name = "txtmensualite";
            this.txtmensualite.Size = new System.Drawing.Size(100, 20);
=======
            this.txtmensualite.Location = new System.Drawing.Point(32, 228);
            this.txtmensualite.Name = "txtmensualite";
            this.txtmensualite.Size = new System.Drawing.Size(108, 20);
>>>>>>> origin/Aboubakr
            this.txtmensualite.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
<<<<<<< HEAD
            this.label1.Location = new System.Drawing.Point(299, 69);
=======
            this.label1.Location = new System.Drawing.Point(29, 96);
>>>>>>> origin/Aboubakr
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Montant du credit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
<<<<<<< HEAD
            this.label2.Location = new System.Drawing.Point(299, 128);
=======
            this.label2.Location = new System.Drawing.Point(29, 148);
>>>>>>> origin/Aboubakr
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Durée du mois";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
<<<<<<< HEAD
            this.label3.Location = new System.Drawing.Point(302, 190);
=======
            this.label3.Location = new System.Drawing.Point(29, 200);
>>>>>>> origin/Aboubakr
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Taux annuel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
<<<<<<< HEAD
            this.label4.Location = new System.Drawing.Point(302, 251);
=======
            this.label4.Location = new System.Drawing.Point(29, 251);
>>>>>>> origin/Aboubakr
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mensualité";
            // 
<<<<<<< HEAD
            // cmdListeCredit
            // 
            this.cmdListeCredit.Location = new System.Drawing.Point(411, 333);
            this.cmdListeCredit.Name = "cmdListeCredit";
            this.cmdListeCredit.Size = new System.Drawing.Size(119, 55);
            this.cmdListeCredit.TabIndex = 11;
            this.cmdListeCredit.Text = "Liste des credit";
            this.cmdListeCredit.UseVisualStyleBackColor = true;
            this.cmdListeCredit.Click += new System.EventHandler(this.cmdListeCredit_Click);
            // 
            // cboDureeMois
            // 
            this.cboDureeMois.FormattingEnabled = true;
            this.cboDureeMois.Location = new System.Drawing.Point(302, 100);
            this.cboDureeMois.Name = "cboDureeMois";
            this.cboDureeMois.Size = new System.Drawing.Size(121, 21);
            this.cboDureeMois.TabIndex = 12;
=======
            // cmdListeCreditBDD
            // 
            this.cmdListeCreditBDD.Location = new System.Drawing.Point(393, 344);
            this.cmdListeCreditBDD.Name = "cmdListeCreditBDD";
            this.cmdListeCreditBDD.Size = new System.Drawing.Size(119, 55);
            this.cmdListeCreditBDD.TabIndex = 11;
            this.cmdListeCreditBDD.Text = "Tout les crédit de la bdd";
            this.cmdListeCreditBDD.UseVisualStyleBackColor = true;
            this.cmdListeCreditBDD.Click += new System.EventHandler(this.cmdListeCredit_Click);
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(12, 35);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(35, 13);
            this.lblVille.TabIndex = 38;
            this.lblVille.Text = "label2";
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(12, 9);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(35, 13);
            this.lblRegion.TabIndex = 37;
            this.lblRegion.Text = "label2";
            // 
            // lsbCredit
            // 
            this.lsbCredit.FormattingEnabled = true;
            this.lsbCredit.Location = new System.Drawing.Point(162, 79);
            this.lsbCredit.Name = "lsbCredit";
            this.lsbCredit.Size = new System.Drawing.Size(594, 238);
            this.lsbCredit.TabIndex = 39;
            this.lsbCredit.SelectedIndexChanged += new System.EventHandler(this.lsbCredit_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(299, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 26);
            this.label5.TabIndex = 40;
            this.label5.Text = "Liste des credits calculer";
            // 
            // cmdVoiture
            // 
            this.cmdVoiture.Location = new System.Drawing.Point(133, 347);
            this.cmdVoiture.Name = "cmdVoiture";
            this.cmdVoiture.Size = new System.Drawing.Size(101, 52);
            this.cmdVoiture.TabIndex = 41;
            this.cmdVoiture.Text = "Voiture";
            this.cmdVoiture.UseVisualStyleBackColor = true;
            this.cmdVoiture.Click += new System.EventHandler(this.cmdVoiture_Click);
            // 
            // cmdInitCredit
            // 
            this.cmdInitCredit.Location = new System.Drawing.Point(723, 48);
            this.cmdInitCredit.Name = "cmdInitCredit";
            this.cmdInitCredit.Size = new System.Drawing.Size(33, 25);
            this.cmdInitCredit.TabIndex = 42;
            this.cmdInitCredit.Text = "Init";
            this.cmdInitCredit.UseVisualStyleBackColor = true;
            this.cmdInitCredit.Click += new System.EventHandler(this.cmdInitCredit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(735, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "AP";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cmdClient
            // 
            this.cmdClient.Location = new System.Drawing.Point(255, 347);
            this.cmdClient.Name = "cmdClient";
            this.cmdClient.Size = new System.Drawing.Size(110, 52);
            this.cmdClient.TabIndex = 2;
            this.cmdClient.Text = "&Client";
            this.cmdClient.UseVisualStyleBackColor = true;
            this.cmdClient.Click += new System.EventHandler(this.cmdIntroduction_Click);
            // 
            // cmdAccueil
            // 
            this.cmdAccueil.Location = new System.Drawing.Point(544, 344);
            this.cmdAccueil.Name = "cmdAccueil";
            this.cmdAccueil.Size = new System.Drawing.Size(97, 55);
            this.cmdAccueil.TabIndex = 44;
            this.cmdAccueil.Text = "Accueil";
            this.cmdAccueil.UseVisualStyleBackColor = true;
            this.cmdAccueil.Click += new System.EventHandler(this.cmdAccueil_Click);
            // 
            // txtDureeMois
            // 
            this.txtDureeMois.Location = new System.Drawing.Point(32, 125);
            this.txtDureeMois.Name = "txtDureeMois";
            this.txtDureeMois.Size = new System.Drawing.Size(100, 20);
            this.txtDureeMois.TabIndex = 45;
>>>>>>> origin/Aboubakr
            // 
            // FrmCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 450);
<<<<<<< HEAD
            this.Controls.Add(this.cboDureeMois);
            this.Controls.Add(this.cmdListeCredit);
=======
            this.Controls.Add(this.txtDureeMois);
            this.Controls.Add(this.cmdAccueil);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmdInitCredit);
            this.Controls.Add(this.cmdVoiture);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lsbCredit);
            this.Controls.Add(this.lblVille);
            this.Controls.Add(this.lblRegion);
            this.Controls.Add(this.cmdListeCreditBDD);
>>>>>>> origin/Aboubakr
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmensualite);
            this.Controls.Add(this.txttaux);
            this.Controls.Add(this.txtmontantFinance);
<<<<<<< HEAD
            this.Controls.Add(this.cmdIntroduction);
=======
            this.Controls.Add(this.cmdClient);
>>>>>>> origin/Aboubakr
            this.Controls.Add(this.cmdJenregistre);
            this.Controls.Add(this.cmdCalcul);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmCredit";
            this.Text = "Credit";
            this.Load += new System.EventHandler(this.Credit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdCalcul;
        private System.Windows.Forms.Button cmdJenregistre;
<<<<<<< HEAD
        private System.Windows.Forms.Button cmdIntroduction;
=======
>>>>>>> origin/Aboubakr
        private System.Windows.Forms.TextBox txtmontantFinance;
        private System.Windows.Forms.TextBox txttaux;
        private System.Windows.Forms.TextBox txtmensualite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
<<<<<<< HEAD
        private System.Windows.Forms.Button cmdListeCredit;
        private System.Windows.Forms.ComboBox cboDureeMois;
=======
        private System.Windows.Forms.Button cmdListeCreditBDD;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.ListBox lsbCredit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cmdVoiture;
        private System.Windows.Forms.Button cmdInitCredit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cmdClient;
        private System.Windows.Forms.Button cmdAccueil;
        private System.Windows.Forms.TextBox txtDureeMois;
>>>>>>> origin/Aboubakr
    }
}