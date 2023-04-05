
namespace CreditCeleste
{
    partial class frmVoiture
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
            this.lblDatePremImmat = new System.Windows.Forms.Label();
            this.lblNumeroImmat = new System.Windows.Forms.Label();
            this.lblNumeroSerie = new System.Windows.Forms.Label();
            this.lblPuissance = new System.Windows.Forms.Label();
            this.gpbAgeVehicule = new System.Windows.Forms.GroupBox();
            this.radioVehiculeOccas5ansPlus = new System.Windows.Forms.RadioButton();
            this.radioVehiculeOccas3et5ans = new System.Windows.Forms.RadioButton();
            this.radioVehiculeOccas3ans = new System.Windows.Forms.RadioButton();
            this.radioVehiculeNeuf = new System.Windows.Forms.RadioButton();
            this.cmdJenregistre = new System.Windows.Forms.Button();
            this.cmdIntroduction = new System.Windows.Forms.Button();
            this.cmdCredit = new System.Windows.Forms.Button();
            this.cmdVersBdd = new System.Windows.Forms.Button();
            this.cboxMarque = new System.Windows.Forms.ComboBox();
            this.lblMarque = new System.Windows.Forms.Label();
            this.lblModele = new System.Windows.Forms.Label();
            this.lblEnergie = new System.Windows.Forms.Label();
            this.cboxModele = new System.Windows.Forms.ComboBox();
            this.cboxEnergie = new System.Windows.Forms.ComboBox();
            this.lblAnneeModele = new System.Windows.Forms.Label();
            this.cboxAnneeModele = new System.Windows.Forms.ComboBox();
            this.lblFieldDatePremImmat = new System.Windows.Forms.Label();
            this.cboxPuissance = new System.Windows.Forms.ComboBox();
            this.lblFieldNumeroImmat = new System.Windows.Forms.Label();
            this.lblFieldNumeroSerie = new System.Windows.Forms.Label();
            this.gpbAgeVehicule.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDatePremImmat
            // 
            this.lblDatePremImmat.AutoSize = true;
            this.lblDatePremImmat.Location = new System.Drawing.Point(766, 102);
            this.lblDatePremImmat.Name = "lblDatePremImmat";
            this.lblDatePremImmat.Size = new System.Drawing.Size(169, 17);
            this.lblDatePremImmat.TabIndex = 4;
            this.lblDatePremImmat.Text = "Date 1ère immatriculation";
            // 
            // lblNumeroImmat
            // 
            this.lblNumeroImmat.AutoSize = true;
            this.lblNumeroImmat.Location = new System.Drawing.Point(766, 185);
            this.lblNumeroImmat.Name = "lblNumeroImmat";
            this.lblNumeroImmat.Size = new System.Drawing.Size(156, 17);
            this.lblNumeroImmat.TabIndex = 5;
            this.lblNumeroImmat.Text = "Numéro immatriculation";
            // 
            // lblNumeroSerie
            // 
            this.lblNumeroSerie.AutoSize = true;
            this.lblNumeroSerie.Location = new System.Drawing.Point(505, 185);
            this.lblNumeroSerie.Name = "lblNumeroSerie";
            this.lblNumeroSerie.Size = new System.Drawing.Size(113, 17);
            this.lblNumeroSerie.TabIndex = 6;
            this.lblNumeroSerie.Text = "Numéro de série";
            // 
            // lblPuissance
            // 
            this.lblPuissance.AutoSize = true;
            this.lblPuissance.Location = new System.Drawing.Point(507, 102);
            this.lblPuissance.Name = "lblPuissance";
            this.lblPuissance.Size = new System.Drawing.Size(73, 17);
            this.lblPuissance.TabIndex = 7;
            this.lblPuissance.Text = "Puissance";
            // 
            // gpbAgeVehicule
            // 
            this.gpbAgeVehicule.Controls.Add(this.radioVehiculeOccas5ansPlus);
            this.gpbAgeVehicule.Controls.Add(this.radioVehiculeOccas3et5ans);
            this.gpbAgeVehicule.Controls.Add(this.radioVehiculeOccas3ans);
            this.gpbAgeVehicule.Controls.Add(this.radioVehiculeNeuf);
            this.gpbAgeVehicule.Location = new System.Drawing.Point(15, 278);
            this.gpbAgeVehicule.Name = "gpbAgeVehicule";
            this.gpbAgeVehicule.Size = new System.Drawing.Size(258, 151);
            this.gpbAgeVehicule.TabIndex = 16;
            this.gpbAgeVehicule.TabStop = false;
            this.gpbAgeVehicule.Text = "Âge du véhicule";
            this.gpbAgeVehicule.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioVehiculeOccas5ansPlus
            // 
            this.radioVehiculeOccas5ansPlus.AutoSize = true;
            this.radioVehiculeOccas5ansPlus.Location = new System.Drawing.Point(21, 113);
            this.radioVehiculeOccas5ansPlus.Name = "radioVehiculeOccas5ansPlus";
            this.radioVehiculeOccas5ansPlus.Size = new System.Drawing.Size(193, 21);
            this.radioVehiculeOccas5ansPlus.TabIndex = 3;
            this.radioVehiculeOccas5ansPlus.TabStop = true;
            this.radioVehiculeOccas5ansPlus.Text = "Occasion de 5 ans et plus";
            this.radioVehiculeOccas5ansPlus.UseVisualStyleBackColor = true;
            // 
            // radioVehiculeOccas3et5ans
            // 
            this.radioVehiculeOccas3et5ans.AutoSize = true;
            this.radioVehiculeOccas3et5ans.Location = new System.Drawing.Point(21, 86);
            this.radioVehiculeOccas3et5ans.Name = "radioVehiculeOccas3et5ans";
            this.radioVehiculeOccas3et5ans.Size = new System.Drawing.Size(171, 21);
            this.radioVehiculeOccas3et5ans.TabIndex = 2;
            this.radioVehiculeOccas3et5ans.TabStop = true;
            this.radioVehiculeOccas3et5ans.Text = "Occasion de 3 à 5 ans";
            this.radioVehiculeOccas3et5ans.UseVisualStyleBackColor = true;
            // 
            // radioVehiculeOccas3ans
            // 
            this.radioVehiculeOccas3ans.AutoSize = true;
            this.radioVehiculeOccas3ans.Location = new System.Drawing.Point(21, 59);
            this.radioVehiculeOccas3ans.Name = "radioVehiculeOccas3ans";
            this.radioVehiculeOccas3ans.Size = new System.Drawing.Size(147, 21);
            this.radioVehiculeOccas3ans.TabIndex = 1;
            this.radioVehiculeOccas3ans.TabStop = true;
            this.radioVehiculeOccas3ans.Text = "Occasion de 3 ans";
            this.radioVehiculeOccas3ans.UseVisualStyleBackColor = true;
            // 
            // radioVehiculeNeuf
            // 
            this.radioVehiculeNeuf.AutoSize = true;
            this.radioVehiculeNeuf.Location = new System.Drawing.Point(21, 32);
            this.radioVehiculeNeuf.Name = "radioVehiculeNeuf";
            this.radioVehiculeNeuf.Size = new System.Drawing.Size(59, 21);
            this.radioVehiculeNeuf.TabIndex = 0;
            this.radioVehiculeNeuf.TabStop = true;
            this.radioVehiculeNeuf.Text = "Neuf";
            this.radioVehiculeNeuf.UseVisualStyleBackColor = true;
            // 
            // cmdJenregistre
            // 
            this.cmdJenregistre.Location = new System.Drawing.Point(318, 287);
            this.cmdJenregistre.Margin = new System.Windows.Forms.Padding(4);
            this.cmdJenregistre.Name = "cmdJenregistre";
            this.cmdJenregistre.Size = new System.Drawing.Size(143, 41);
            this.cmdJenregistre.TabIndex = 17;
            this.cmdJenregistre.Text = "&J\'enregistre (Objet)";
            this.cmdJenregistre.UseVisualStyleBackColor = true;
            this.cmdJenregistre.Click += new System.EventHandler(this.cmdJenregistre_Click);
            // 
            // cmdIntroduction
            // 
            this.cmdIntroduction.Location = new System.Drawing.Point(318, 354);
            this.cmdIntroduction.Margin = new System.Windows.Forms.Padding(4);
            this.cmdIntroduction.Name = "cmdIntroduction";
            this.cmdIntroduction.Size = new System.Drawing.Size(143, 41);
            this.cmdIntroduction.TabIndex = 19;
            this.cmdIntroduction.Text = "&Introduction";
            this.cmdIntroduction.UseVisualStyleBackColor = true;
            this.cmdIntroduction.Click += new System.EventHandler(this.cmdIntroduction_Click);
            // 
            // cmdCredit
            // 
            this.cmdCredit.Location = new System.Drawing.Point(522, 354);
            this.cmdCredit.Margin = new System.Windows.Forms.Padding(4);
            this.cmdCredit.Name = "cmdCredit";
            this.cmdCredit.Size = new System.Drawing.Size(143, 41);
            this.cmdCredit.TabIndex = 20;
            this.cmdCredit.Text = "Crédit";
            this.cmdCredit.UseVisualStyleBackColor = true;
            // 
            // cmdVersBdd
            // 
            this.cmdVersBdd.Location = new System.Drawing.Point(522, 287);
            this.cmdVersBdd.Margin = new System.Windows.Forms.Padding(4);
            this.cmdVersBdd.Name = "cmdVersBdd";
            this.cmdVersBdd.Size = new System.Drawing.Size(143, 41);
            this.cmdVersBdd.TabIndex = 18;
            this.cmdVersBdd.Text = "&Valider";
            this.cmdVersBdd.UseVisualStyleBackColor = true;
            this.cmdVersBdd.Click += new System.EventHandler(this.cmdVersBdd_Click);
            // 
            // cboxMarque
            // 
            this.cboxMarque.FormattingEnabled = true;
            this.cboxMarque.Location = new System.Drawing.Point(15, 120);
            this.cboxMarque.Name = "cboxMarque";
            this.cboxMarque.Size = new System.Drawing.Size(161, 24);
            this.cboxMarque.TabIndex = 21;
            // 
            // lblMarque
            // 
            this.lblMarque.AutoSize = true;
            this.lblMarque.Location = new System.Drawing.Point(12, 102);
            this.lblMarque.Name = "lblMarque";
            this.lblMarque.Size = new System.Drawing.Size(56, 17);
            this.lblMarque.TabIndex = 22;
            this.lblMarque.Text = "Marque";
            // 
            // lblModele
            // 
            this.lblModele.AutoSize = true;
            this.lblModele.Location = new System.Drawing.Point(12, 185);
            this.lblModele.Name = "lblModele";
            this.lblModele.Size = new System.Drawing.Size(54, 17);
            this.lblModele.TabIndex = 23;
            this.lblModele.Text = "Modèle";
            // 
            // lblEnergie
            // 
            this.lblEnergie.AutoSize = true;
            this.lblEnergie.Location = new System.Drawing.Point(268, 102);
            this.lblEnergie.Name = "lblEnergie";
            this.lblEnergie.Size = new System.Drawing.Size(57, 17);
            this.lblEnergie.TabIndex = 25;
            this.lblEnergie.Text = "Énergie";
            // 
            // cboxModele
            // 
            this.cboxModele.FormattingEnabled = true;
            this.cboxModele.Location = new System.Drawing.Point(15, 205);
            this.cboxModele.Name = "cboxModele";
            this.cboxModele.Size = new System.Drawing.Size(161, 24);
            this.cboxModele.TabIndex = 27;
            // 
            // cboxEnergie
            // 
            this.cboxEnergie.FormattingEnabled = true;
            this.cboxEnergie.Location = new System.Drawing.Point(271, 122);
            this.cboxEnergie.Name = "cboxEnergie";
            this.cboxEnergie.Size = new System.Drawing.Size(161, 24);
            this.cboxEnergie.TabIndex = 28;
            // 
            // lblAnneeModele
            // 
            this.lblAnneeModele.AutoSize = true;
            this.lblAnneeModele.Location = new System.Drawing.Point(268, 185);
            this.lblAnneeModele.Name = "lblAnneeModele";
            this.lblAnneeModele.Size = new System.Drawing.Size(119, 17);
            this.lblAnneeModele.TabIndex = 29;
            this.lblAnneeModele.Text = "Année du modèle";
            // 
            // cboxAnneeModele
            // 
            this.cboxAnneeModele.FormattingEnabled = true;
            this.cboxAnneeModele.Location = new System.Drawing.Point(271, 205);
            this.cboxAnneeModele.Name = "cboxAnneeModele";
            this.cboxAnneeModele.Size = new System.Drawing.Size(161, 24);
            this.cboxAnneeModele.TabIndex = 30;
            // 
            // lblFieldDatePremImmat
            // 
            this.lblFieldDatePremImmat.AutoSize = true;
            this.lblFieldDatePremImmat.Location = new System.Drawing.Point(766, 123);
            this.lblFieldDatePremImmat.Name = "lblFieldDatePremImmat";
            this.lblFieldDatePremImmat.Size = new System.Drawing.Size(44, 17);
            this.lblFieldDatePremImmat.TabIndex = 31;
            this.lblFieldDatePremImmat.Text = "[date]";
            // 
            // cboxPuissance
            // 
            this.cboxPuissance.FormattingEnabled = true;
            this.cboxPuissance.Location = new System.Drawing.Point(508, 122);
            this.cboxPuissance.Name = "cboxPuissance";
            this.cboxPuissance.Size = new System.Drawing.Size(161, 24);
            this.cboxPuissance.TabIndex = 32;
            // 
            // lblFieldNumeroImmat
            // 
            this.lblFieldNumeroImmat.AutoSize = true;
            this.lblFieldNumeroImmat.Location = new System.Drawing.Point(766, 208);
            this.lblFieldNumeroImmat.Name = "lblFieldNumeroImmat";
            this.lblFieldNumeroImmat.Size = new System.Drawing.Size(53, 17);
            this.lblFieldNumeroImmat.TabIndex = 33;
            this.lblFieldNumeroImmat.Text = "[immat]";
            // 
            // lblFieldNumeroSerie
            // 
            this.lblFieldNumeroSerie.AutoSize = true;
            this.lblFieldNumeroSerie.Location = new System.Drawing.Point(505, 208);
            this.lblFieldNumeroSerie.Name = "lblFieldNumeroSerie";
            this.lblFieldNumeroSerie.Size = new System.Drawing.Size(47, 17);
            this.lblFieldNumeroSerie.TabIndex = 34;
            this.lblFieldNumeroSerie.Text = "[série]";
            // 
            // frmVoiture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 484);
            this.Controls.Add(this.lblFieldNumeroSerie);
            this.Controls.Add(this.lblFieldNumeroImmat);
            this.Controls.Add(this.cboxPuissance);
            this.Controls.Add(this.lblFieldDatePremImmat);
            this.Controls.Add(this.cboxAnneeModele);
            this.Controls.Add(this.lblAnneeModele);
            this.Controls.Add(this.cboxEnergie);
            this.Controls.Add(this.cboxModele);
            this.Controls.Add(this.lblEnergie);
            this.Controls.Add(this.lblModele);
            this.Controls.Add(this.lblMarque);
            this.Controls.Add(this.cboxMarque);
            this.Controls.Add(this.cmdCredit);
            this.Controls.Add(this.cmdIntroduction);
            this.Controls.Add(this.cmdVersBdd);
            this.Controls.Add(this.cmdJenregistre);
            this.Controls.Add(this.gpbAgeVehicule);
            this.Controls.Add(this.lblPuissance);
            this.Controls.Add(this.lblNumeroSerie);
            this.Controls.Add(this.lblNumeroImmat);
            this.Controls.Add(this.lblDatePremImmat);
            this.Name = "frmVoiture";
            this.Text = "frmVoiture";
            this.Load += new System.EventHandler(this.frmVoiture_Load);
            this.gpbAgeVehicule.ResumeLayout(false);
            this.gpbAgeVehicule.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDatePremImmat;
        private System.Windows.Forms.Label lblNumeroImmat;
        private System.Windows.Forms.Label lblNumeroSerie;
        private System.Windows.Forms.Label lblPuissance;
        private System.Windows.Forms.GroupBox gpbAgeVehicule;
        private System.Windows.Forms.RadioButton radioVehiculeOccas5ansPlus;
        private System.Windows.Forms.RadioButton radioVehiculeOccas3et5ans;
        private System.Windows.Forms.RadioButton radioVehiculeOccas3ans;
        private System.Windows.Forms.RadioButton radioVehiculeNeuf;
        private System.Windows.Forms.Button cmdJenregistre;
        private System.Windows.Forms.Button cmdIntroduction;
        private System.Windows.Forms.Button cmdCredit;
        private System.Windows.Forms.Button cmdVersBdd;
        private System.Windows.Forms.ComboBox cboxMarque;
        private System.Windows.Forms.Label lblMarque;
        private System.Windows.Forms.Label lblModele;
        private System.Windows.Forms.Label lblEnergie;
        private System.Windows.Forms.ComboBox cboxModele;
        private System.Windows.Forms.ComboBox cboxEnergie;
        private System.Windows.Forms.Label lblAnneeModele;
        private System.Windows.Forms.ComboBox cboxAnneeModele;
        private System.Windows.Forms.Label lblFieldDatePremImmat;
        private System.Windows.Forms.ComboBox cboxPuissance;
        private System.Windows.Forms.Label lblFieldNumeroImmat;
        private System.Windows.Forms.Label lblFieldNumeroSerie;
    }
}