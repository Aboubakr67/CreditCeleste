
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
            this.cmdIntroduction = new System.Windows.Forms.Button();
            this.cmdCredit = new System.Windows.Forms.Button();
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
            this.lblFieldprixVehicule = new System.Windows.Forms.Label();
            this.lblmontant = new System.Windows.Forms.Label();
            this.lstVoiture = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblDatePremImmat
            // 
            this.lblDatePremImmat.AutoSize = true;
            this.lblDatePremImmat.Location = new System.Drawing.Point(156, 37);
            this.lblDatePremImmat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatePremImmat.Name = "lblDatePremImmat";
            this.lblDatePremImmat.Size = new System.Drawing.Size(126, 13);
            this.lblDatePremImmat.TabIndex = 4;
            this.lblDatePremImmat.Text = "Date 1ère immatriculation";
            // 
            // lblNumeroImmat
            // 
            this.lblNumeroImmat.AutoSize = true;
            this.lblNumeroImmat.Location = new System.Drawing.Point(156, 104);
            this.lblNumeroImmat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumeroImmat.Name = "lblNumeroImmat";
            this.lblNumeroImmat.Size = new System.Drawing.Size(116, 13);
            this.lblNumeroImmat.TabIndex = 5;
            this.lblNumeroImmat.Text = "Numéro immatriculation";
            // 
            // lblNumeroSerie
            // 
            this.lblNumeroSerie.AutoSize = true;
            this.lblNumeroSerie.Location = new System.Drawing.Point(156, 193);
            this.lblNumeroSerie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumeroSerie.Name = "lblNumeroSerie";
            this.lblNumeroSerie.Size = new System.Drawing.Size(84, 13);
            this.lblNumeroSerie.TabIndex = 6;
            this.lblNumeroSerie.Text = "Numéro de série";
            // 
            // lblPuissance
            // 
            this.lblPuissance.AutoSize = true;
            this.lblPuissance.Location = new System.Drawing.Point(19, 215);
            this.lblPuissance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPuissance.Name = "lblPuissance";
            this.lblPuissance.Size = new System.Drawing.Size(56, 13);
            this.lblPuissance.TabIndex = 7;
            this.lblPuissance.Text = "Puissance";
            // 
            // cmdIntroduction
            // 
            this.cmdIntroduction.Location = new System.Drawing.Point(21, 339);
            this.cmdIntroduction.Name = "cmdIntroduction";
            this.cmdIntroduction.Size = new System.Drawing.Size(107, 33);
            this.cmdIntroduction.TabIndex = 19;
            this.cmdIntroduction.Text = "&Client";
            this.cmdIntroduction.UseVisualStyleBackColor = true;
            this.cmdIntroduction.Click += new System.EventHandler(this.cmdIntroduction_Click);
            // 
            // cmdCredit
            // 
            this.cmdCredit.Location = new System.Drawing.Point(175, 339);
            this.cmdCredit.Name = "cmdCredit";
            this.cmdCredit.Size = new System.Drawing.Size(107, 33);
            this.cmdCredit.TabIndex = 20;
            this.cmdCredit.Text = "Crédit";
            this.cmdCredit.UseVisualStyleBackColor = true;
            this.cmdCredit.Click += new System.EventHandler(this.cmdCredit_Click);
            // 
            // cboxMarque
            // 
            this.cboxMarque.FormattingEnabled = true;
            this.cboxMarque.Location = new System.Drawing.Point(21, 34);
            this.cboxMarque.Margin = new System.Windows.Forms.Padding(2);
            this.cboxMarque.Name = "cboxMarque";
            this.cboxMarque.Size = new System.Drawing.Size(122, 21);
            this.cboxMarque.TabIndex = 21;
            this.cboxMarque.SelectedIndexChanged += new System.EventHandler(this.cboxMarque_SelectedIndexChanged);
            // 
            // lblMarque
            // 
            this.lblMarque.AutoSize = true;
            this.lblMarque.Location = new System.Drawing.Point(18, 19);
            this.lblMarque.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMarque.Name = "lblMarque";
            this.lblMarque.Size = new System.Drawing.Size(43, 13);
            this.lblMarque.TabIndex = 22;
            this.lblMarque.Text = "Marque";
            // 
            // lblModele
            // 
            this.lblModele.AutoSize = true;
            this.lblModele.Location = new System.Drawing.Point(19, 67);
            this.lblModele.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModele.Name = "lblModele";
            this.lblModele.Size = new System.Drawing.Size(42, 13);
            this.lblModele.TabIndex = 23;
            this.lblModele.Text = "Modèle";
            // 
            // lblEnergie
            // 
            this.lblEnergie.AutoSize = true;
            this.lblEnergie.Location = new System.Drawing.Point(19, 168);
            this.lblEnergie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnergie.Name = "lblEnergie";
            this.lblEnergie.Size = new System.Drawing.Size(43, 13);
            this.lblEnergie.TabIndex = 25;
            this.lblEnergie.Text = "Énergie";
            // 
            // cboxModele
            // 
            this.cboxModele.FormattingEnabled = true;
            this.cboxModele.Location = new System.Drawing.Point(21, 82);
            this.cboxModele.Margin = new System.Windows.Forms.Padding(2);
            this.cboxModele.Name = "cboxModele";
            this.cboxModele.Size = new System.Drawing.Size(122, 21);
            this.cboxModele.TabIndex = 27;
            this.cboxModele.SelectedIndexChanged += new System.EventHandler(this.cboxModele_SelectedIndexChanged);
            // 
            // cboxEnergie
            // 
            this.cboxEnergie.FormattingEnabled = true;
            this.cboxEnergie.Location = new System.Drawing.Point(22, 183);
            this.cboxEnergie.Margin = new System.Windows.Forms.Padding(2);
            this.cboxEnergie.Name = "cboxEnergie";
            this.cboxEnergie.Size = new System.Drawing.Size(122, 21);
            this.cboxEnergie.TabIndex = 28;
            this.cboxEnergie.SelectedIndexChanged += new System.EventHandler(this.cboxEnergie_SelectedIndexChanged);
            // 
            // lblAnneeModele
            // 
            this.lblAnneeModele.AutoSize = true;
            this.lblAnneeModele.Location = new System.Drawing.Point(19, 119);
            this.lblAnneeModele.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAnneeModele.Name = "lblAnneeModele";
            this.lblAnneeModele.Size = new System.Drawing.Size(90, 13);
            this.lblAnneeModele.TabIndex = 29;
            this.lblAnneeModele.Text = "Année du modèle";
            // 
            // cboxAnneeModele
            // 
            this.cboxAnneeModele.FormattingEnabled = true;
            this.cboxAnneeModele.Location = new System.Drawing.Point(22, 134);
            this.cboxAnneeModele.Margin = new System.Windows.Forms.Padding(2);
            this.cboxAnneeModele.Name = "cboxAnneeModele";
            this.cboxAnneeModele.Size = new System.Drawing.Size(122, 21);
            this.cboxAnneeModele.TabIndex = 30;
            this.cboxAnneeModele.SelectedIndexChanged += new System.EventHandler(this.cboxAnneeModele_SelectedIndexChanged);
            // 
            // lblFieldDatePremImmat
            // 
            this.lblFieldDatePremImmat.AutoSize = true;
            this.lblFieldDatePremImmat.Location = new System.Drawing.Point(156, 54);
            this.lblFieldDatePremImmat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFieldDatePremImmat.Name = "lblFieldDatePremImmat";
            this.lblFieldDatePremImmat.Size = new System.Drawing.Size(34, 13);
            this.lblFieldDatePremImmat.TabIndex = 31;
            this.lblFieldDatePremImmat.Text = "[date]";
            // 
            // cboxPuissance
            // 
            this.cboxPuissance.FormattingEnabled = true;
            this.cboxPuissance.Location = new System.Drawing.Point(21, 230);
            this.cboxPuissance.Margin = new System.Windows.Forms.Padding(2);
            this.cboxPuissance.Name = "cboxPuissance";
            this.cboxPuissance.Size = new System.Drawing.Size(122, 21);
            this.cboxPuissance.TabIndex = 32;
            this.cboxPuissance.SelectedIndexChanged += new System.EventHandler(this.cboxPuissance_SelectedIndexChanged);
            // 
            // lblFieldNumeroImmat
            // 
            this.lblFieldNumeroImmat.AutoSize = true;
            this.lblFieldNumeroImmat.Location = new System.Drawing.Point(156, 123);
            this.lblFieldNumeroImmat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFieldNumeroImmat.Name = "lblFieldNumeroImmat";
            this.lblFieldNumeroImmat.Size = new System.Drawing.Size(40, 13);
            this.lblFieldNumeroImmat.TabIndex = 33;
            this.lblFieldNumeroImmat.Text = "[immat]";
            // 
            // lblFieldNumeroSerie
            // 
            this.lblFieldNumeroSerie.AutoSize = true;
            this.lblFieldNumeroSerie.Location = new System.Drawing.Point(156, 212);
            this.lblFieldNumeroSerie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFieldNumeroSerie.Name = "lblFieldNumeroSerie";
            this.lblFieldNumeroSerie.Size = new System.Drawing.Size(35, 13);
            this.lblFieldNumeroSerie.TabIndex = 34;
            this.lblFieldNumeroSerie.Text = "[série]";
            // 
            // lblFieldprixVehicule
            // 
            this.lblFieldprixVehicule.AutoSize = true;
            this.lblFieldprixVehicule.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFieldprixVehicule.Location = new System.Drawing.Point(385, 355);
            this.lblFieldprixVehicule.Name = "lblFieldprixVehicule";
            this.lblFieldprixVehicule.Size = new System.Drawing.Size(76, 26);
            this.lblFieldprixVehicule.TabIndex = 35;
            this.lblFieldprixVehicule.Text = "[PRIX]";
            // 
            // lblmontant
            // 
            this.lblmontant.AutoSize = true;
            this.lblmontant.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmontant.Location = new System.Drawing.Point(289, 355);
            this.lblmontant.Name = "lblmontant";
            this.lblmontant.Size = new System.Drawing.Size(102, 26);
            this.lblmontant.TabIndex = 36;
            this.lblmontant.Text = "Montant :";
            // 
            // lstVoiture
            // 
            this.lstVoiture.FormattingEnabled = true;
            this.lstVoiture.Location = new System.Drawing.Point(294, 12);
            this.lstVoiture.Name = "lstVoiture";
            this.lstVoiture.Size = new System.Drawing.Size(421, 238);
            this.lstVoiture.TabIndex = 37;
            this.lstVoiture.SelectedIndexChanged += new System.EventHandler(this.lstVoiture_SelectedIndexChanged);
            // 
            // frmVoiture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 393);
            this.Controls.Add(this.lstVoiture);
            this.Controls.Add(this.lblmontant);
            this.Controls.Add(this.lblFieldprixVehicule);
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
            this.Controls.Add(this.lblPuissance);
            this.Controls.Add(this.lblNumeroSerie);
            this.Controls.Add(this.lblNumeroImmat);
            this.Controls.Add(this.lblDatePremImmat);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmVoiture";
            this.Text = "frmVoiture";
            this.Load += new System.EventHandler(this.frmVoiture_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDatePremImmat;
        private System.Windows.Forms.Label lblNumeroImmat;
        private System.Windows.Forms.Label lblNumeroSerie;
        private System.Windows.Forms.Label lblPuissance;
        private System.Windows.Forms.Button cmdIntroduction;
        private System.Windows.Forms.Button cmdCredit;
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
        private System.Windows.Forms.Label lblFieldprixVehicule;
        private System.Windows.Forms.Label lblmontant;
        private System.Windows.Forms.ListBox lstVoiture;
    }
}