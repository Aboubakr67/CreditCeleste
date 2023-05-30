
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
            this.txtmontantFinance = new System.Windows.Forms.TextBox();
            this.txttaux = new System.Windows.Forms.TextBox();
            this.txtmensualite = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // cmdCalcul
            // 
            this.cmdCalcul.Name = "cmdCalcul";
            this.cmdCalcul.TabIndex = 0;
            this.cmdCalcul.Text = "Calcul";
            this.cmdCalcul.UseVisualStyleBackColor = true;
            this.cmdCalcul.Click += new System.EventHandler(this.cmdCalcul_Click);
            // 
            // cmdJenregistre
            // 
            this.cmdJenregistre.Name = "cmdJenregistre";
            this.cmdJenregistre.TabIndex = 1;
            this.cmdJenregistre.Text = "J\'enregistre";
            this.cmdJenregistre.UseVisualStyleBackColor = true;
            this.cmdJenregistre.Click += new System.EventHandler(this.cmdJenregistre_Click);
            // 
            // txtmontantFinance
            // 
            this.txtmontantFinance.Name = "txtmontantFinance";
            this.txtmontantFinance.TabIndex = 3;
            this.txtmontantFinance.TextChanged += new System.EventHandler(this.txtmontantFinance_TextChanged);
            // 
            // txttaux
            // 
            this.txttaux.Name = "txttaux";
            this.txttaux.TabIndex = 5;
            // 
            // txtmensualite
            // 
            this.txtmensualite.Name = "txtmensualite";
            this.txtmensualite.TabIndex = 6;
            this.txtmensualite.TextChanged += new System.EventHandler(this.txtmensualite_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Name = "label1";
            this.label1.TabIndex = 7;
            this.label1.Text = "Montant du credit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Name = "label2";
            this.label2.TabIndex = 8;
            this.label2.Text = "Durée du mois";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Name = "label3";
            this.label3.TabIndex = 9;
            this.label3.Text = "Taux annuel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Name = "label4";
            this.label4.TabIndex = 10;
            this.label4.Text = "Mensualité";
            // 
            // cmdListeCreditBDD
            // 
            this.cmdListeCreditBDD.Name = "cmdListeCreditBDD";
            this.cmdListeCreditBDD.TabIndex = 11;
            this.cmdListeCreditBDD.Text = "Tout les crédit de la bdd";
            this.cmdListeCreditBDD.UseVisualStyleBackColor = true;
            this.cmdListeCreditBDD.Click += new System.EventHandler(this.cmdListeCredit_Click);
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Name = "lblVille";
            this.lblVille.TabIndex = 38;
            this.lblVille.Text = "label2";
            this.lblVille.Click += new System.EventHandler(this.lblVille_Click);
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.TabIndex = 37;
            this.lblRegion.Text = "label2";
            // 
            // lsbCredit
            // 
            this.lsbCredit.FormattingEnabled = true;
            this.lsbCredit.Name = "lsbCredit";
            this.lsbCredit.TabIndex = 39;
            this.lsbCredit.SelectedIndexChanged += new System.EventHandler(this.lsbCredit_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Name = "label5";
            this.label5.TabIndex = 40;
            this.label5.Text = "Liste des credits calculer";
            // 
            // cmdVoiture
            // 
            this.cmdVoiture.Name = "cmdVoiture";
            this.cmdVoiture.TabIndex = 41;
            this.cmdVoiture.Text = "Voiture";
            this.cmdVoiture.UseVisualStyleBackColor = true;
            this.cmdVoiture.Click += new System.EventHandler(this.cmdVoiture_Click);
            // 
            // cmdInitCredit
            // 
            this.cmdInitCredit.Name = "cmdInitCredit";
            this.cmdInitCredit.TabIndex = 42;
            this.cmdInitCredit.Text = "Init";
            this.cmdInitCredit.UseVisualStyleBackColor = true;
            this.cmdInitCredit.Click += new System.EventHandler(this.cmdInitCredit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Name = "label6";
            this.label6.TabIndex = 43;
            this.label6.Text = "AP";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cmdClient
            // 
            this.cmdClient.Name = "cmdClient";
            this.cmdClient.TabIndex = 2;
            this.cmdClient.Text = "&Client";
            this.cmdClient.UseVisualStyleBackColor = true;
            this.cmdClient.Click += new System.EventHandler(this.cmdIntroduction_Click);
            // 
            // cmdAccueil
            // 
            this.cmdAccueil.Name = "cmdAccueil";
            this.cmdAccueil.TabIndex = 44;
            this.cmdAccueil.Text = "Accueil";
            this.cmdAccueil.UseVisualStyleBackColor = true;
            this.cmdAccueil.Click += new System.EventHandler(this.cmdAccueil_Click);
            // 
            // txtDureeMois
            // 
            this.txtDureeMois.Name = "txtDureeMois";
            this.txtDureeMois.TabIndex = 45;
            // 
            // FrmCredit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmensualite);
            this.Controls.Add(this.txttaux);
            this.Controls.Add(this.txtmontantFinance);
            this.Controls.Add(this.cmdClient);
            this.Controls.Add(this.cmdJenregistre);
            this.Controls.Add(this.cmdCalcul);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.TextBox txtmontantFinance;
        private System.Windows.Forms.TextBox txttaux;
        private System.Windows.Forms.TextBox txtmensualite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
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
    }
}