
namespace CreditCeleste
{
    partial class frmIntroduction
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
            this.cmdJenregistre = new System.Windows.Forms.Button();
            this.cmdSaisieBien = new System.Windows.Forms.Button();
            this.cmdVersBdd = new System.Windows.Forms.Button();
            this.labelJemapelle = new System.Windows.Forms.Label();
            this.cboCidt = new System.Windows.Forms.ComboBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.cboVendeur = new System.Windows.Forms.ComboBox();
            this.labelVendeur = new System.Windows.Forms.Label();
            this.gpbAgeVehicule = new System.Windows.Forms.GroupBox();
            this.rbOccas5etplus = new System.Windows.Forms.RadioButton();
            this.rbOccas3A5 = new System.Windows.Forms.RadioButton();
            this.rbOcc3 = new System.Windows.Forms.RadioButton();
            this.rbNeuf = new System.Windows.Forms.RadioButton();
            this.labelAncVeh = new System.Windows.Forms.Label();
            this.txtAncVehc = new System.Windows.Forms.TextBox();
            this.txtNewVehc = new System.Windows.Forms.TextBox();
            this.labelNewVehc = new System.Windows.Forms.Label();
            this.cmdCredit = new System.Windows.Forms.Button();
            this.gpbAgeVehicule.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdJenregistre
            // 
            this.cmdJenregistre.Location = new System.Drawing.Point(94, 345);
            this.cmdJenregistre.Name = "cmdJenregistre";
            this.cmdJenregistre.Size = new System.Drawing.Size(107, 33);
            this.cmdJenregistre.TabIndex = 0;
            this.cmdJenregistre.Text = "&J\'enregistre";
            this.cmdJenregistre.UseVisualStyleBackColor = true;
            this.cmdJenregistre.Click += new System.EventHandler(this.cmdJenregistre_Click);
            // 
            // cmdSaisieBien
            // 
            this.cmdSaisieBien.Location = new System.Drawing.Point(246, 345);
            this.cmdSaisieBien.Name = "cmdSaisieBien";
            this.cmdSaisieBien.Size = new System.Drawing.Size(111, 33);
            this.cmdSaisieBien.TabIndex = 1;
            this.cmdSaisieBien.Text = "&Voiture";
            this.cmdSaisieBien.UseVisualStyleBackColor = true;
            this.cmdSaisieBien.Click += new System.EventHandler(this.cmdSaisieBien_Click);
            // 
            // cmdVersBdd
            // 
            this.cmdVersBdd.Location = new System.Drawing.Point(577, 337);
            this.cmdVersBdd.Name = "cmdVersBdd";
            this.cmdVersBdd.Size = new System.Drawing.Size(119, 41);
            this.cmdVersBdd.TabIndex = 2;
            this.cmdVersBdd.Text = "&Je Valide";
            this.cmdVersBdd.UseVisualStyleBackColor = true;
            // 
            // labelJemapelle
            // 
            this.labelJemapelle.AutoSize = true;
            this.labelJemapelle.Location = new System.Drawing.Point(66, 36);
            this.labelJemapelle.Name = "labelJemapelle";
            this.labelJemapelle.Size = new System.Drawing.Size(65, 13);
            this.labelJemapelle.TabIndex = 3;
            this.labelJemapelle.Text = "&Je m\'appelle";
            // 
            // cboCidt
            // 
            this.cboCidt.FormattingEnabled = true;
            this.cboCidt.Items.AddRange(new object[] {
            "Mademoiselle",
            "Madame",
            "Monsieur"});
            this.cboCidt.Location = new System.Drawing.Point(28, 52);
            this.cboCidt.Name = "cboCidt";
            this.cboCidt.Size = new System.Drawing.Size(121, 21);
            this.cboCidt.TabIndex = 4;
            this.cboCidt.SelectedIndexChanged += new System.EventHandler(this.cboCidt_SelectedIndexChanged);
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(31, 119);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(29, 13);
            this.labelNom.TabIndex = 5;
            this.labelNom.Text = "Nom";
            this.labelNom.Click += new System.EventHandler(this.labelNom_Click);
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Location = new System.Drawing.Point(31, 187);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(43, 13);
            this.labelPrenom.TabIndex = 6;
            this.labelPrenom.Text = "&Prenom";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(28, 93);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 7;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(28, 159);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(100, 20);
            this.txtPrenom.TabIndex = 8;
            // 
            // cboVendeur
            // 
            this.cboVendeur.FormattingEnabled = true;
            this.cboVendeur.Location = new System.Drawing.Point(48, 263);
            this.cboVendeur.Name = "cboVendeur";
            this.cboVendeur.Size = new System.Drawing.Size(121, 21);
            this.cboVendeur.TabIndex = 9;
            // 
            // labelVendeur
            // 
            this.labelVendeur.AutoSize = true;
            this.labelVendeur.Location = new System.Drawing.Point(81, 242);
            this.labelVendeur.Name = "labelVendeur";
            this.labelVendeur.Size = new System.Drawing.Size(47, 13);
            this.labelVendeur.TabIndex = 10;
            this.labelVendeur.Text = "&Vendeur";
            // 
            // gpbAgeVehicule
            // 
            this.gpbAgeVehicule.Controls.Add(this.rbOccas5etplus);
            this.gpbAgeVehicule.Controls.Add(this.rbOccas3A5);
            this.gpbAgeVehicule.Controls.Add(this.rbOcc3);
            this.gpbAgeVehicule.Controls.Add(this.rbNeuf);
            this.gpbAgeVehicule.Location = new System.Drawing.Point(339, 187);
            this.gpbAgeVehicule.Name = "gpbAgeVehicule";
            this.gpbAgeVehicule.Size = new System.Drawing.Size(200, 130);
            this.gpbAgeVehicule.TabIndex = 11;
            this.gpbAgeVehicule.TabStop = false;
            this.gpbAgeVehicule.Text = "Age du véhicule";
            // 
            // rbOccas5etplus
            // 
            this.rbOccas5etplus.AutoSize = true;
            this.rbOccas5etplus.Location = new System.Drawing.Point(16, 101);
            this.rbOccas5etplus.Name = "rbOccas5etplus";
            this.rbOccas5etplus.Size = new System.Drawing.Size(134, 17);
            this.rbOccas5etplus.TabIndex = 3;
            this.rbOccas5etplus.Text = "Occasion 5 ans et Plus";
            this.rbOccas5etplus.UseVisualStyleBackColor = true;
            // 
            // rbOccas3A5
            // 
            this.rbOccas3A5.AutoSize = true;
            this.rbOccas3A5.Location = new System.Drawing.Point(16, 77);
            this.rbOccas3A5.Name = "rbOccas3A5";
            this.rbOccas3A5.Size = new System.Drawing.Size(152, 17);
            this.rbOccas3A5.TabIndex = 2;
            this.rbOccas3A5.Text = "Occasion de 3 ans a 5 ans";
            this.rbOccas3A5.UseVisualStyleBackColor = true;
            // 
            // rbOcc3
            // 
            this.rbOcc3.AutoSize = true;
            this.rbOcc3.Location = new System.Drawing.Point(16, 55);
            this.rbOcc3.Name = "rbOcc3";
            this.rbOcc3.Size = new System.Drawing.Size(114, 17);
            this.rbOcc3.TabIndex = 1;
            this.rbOcc3.Text = "Occasion de 3 ans";
            this.rbOcc3.UseVisualStyleBackColor = true;
            // 
            // rbNeuf
            // 
            this.rbNeuf.AutoSize = true;
            this.rbNeuf.Checked = true;
            this.rbNeuf.Location = new System.Drawing.Point(16, 31);
            this.rbNeuf.Name = "rbNeuf";
            this.rbNeuf.Size = new System.Drawing.Size(48, 17);
            this.rbNeuf.TabIndex = 0;
            this.rbNeuf.TabStop = true;
            this.rbNeuf.Text = "Neuf";
            this.rbNeuf.UseVisualStyleBackColor = true;
            // 
            // labelAncVeh
            // 
            this.labelAncVeh.AutoSize = true;
            this.labelAncVeh.Location = new System.Drawing.Point(640, 50);
            this.labelAncVeh.Name = "labelAncVeh";
            this.labelAncVeh.Size = new System.Drawing.Size(106, 13);
            this.labelAncVeh.TabIndex = 12;
            this.labelAncVeh.Text = "Mon ancien vehicule";
            // 
            // txtAncVehc
            // 
            this.txtAncVehc.Location = new System.Drawing.Point(643, 66);
            this.txtAncVehc.Name = "txtAncVehc";
            this.txtAncVehc.Size = new System.Drawing.Size(100, 20);
            this.txtAncVehc.TabIndex = 13;
            // 
            // txtNewVehc
            // 
            this.txtNewVehc.Location = new System.Drawing.Point(339, 119);
            this.txtNewVehc.Name = "txtNewVehc";
            this.txtNewVehc.Size = new System.Drawing.Size(116, 20);
            this.txtNewVehc.TabIndex = 14;
            // 
            // labelNewVehc
            // 
            this.labelNewVehc.AutoSize = true;
            this.labelNewVehc.Location = new System.Drawing.Point(339, 100);
            this.labelNewVehc.Name = "labelNewVehc";
            this.labelNewVehc.Size = new System.Drawing.Size(116, 13);
            this.labelNewVehc.TabIndex = 15;
            this.labelNewVehc.Text = "Mon nouveau vehicule";
            // 
            // cmdCredit
            // 
            this.cmdCredit.Location = new System.Drawing.Point(414, 345);
            this.cmdCredit.Name = "cmdCredit";
            this.cmdCredit.Size = new System.Drawing.Size(93, 33);
            this.cmdCredit.TabIndex = 16;
            this.cmdCredit.Text = "Credit";
            this.cmdCredit.UseVisualStyleBackColor = true;
            this.cmdCredit.Click += new System.EventHandler(this.cmdCredit_Click);
            // 
            // frmIntroduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 450);
            this.Controls.Add(this.cmdCredit);
            this.Controls.Add(this.labelNewVehc);
            this.Controls.Add(this.txtNewVehc);
            this.Controls.Add(this.txtAncVehc);
            this.Controls.Add(this.labelAncVeh);
            this.Controls.Add(this.gpbAgeVehicule);
            this.Controls.Add(this.labelVendeur);
            this.Controls.Add(this.cboVendeur);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.cboCidt);
            this.Controls.Add(this.labelJemapelle);
            this.Controls.Add(this.cmdVersBdd);
            this.Controls.Add(this.cmdSaisieBien);
            this.Controls.Add(this.cmdJenregistre);
            this.Name = "frmIntroduction";
            this.Text = "frmIntroduction";
            this.Load += new System.EventHandler(this.frmIntroduction_Load);
            this.gpbAgeVehicule.ResumeLayout(false);
            this.gpbAgeVehicule.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdJenregistre;
        private System.Windows.Forms.Button cmdSaisieBien;
        private System.Windows.Forms.Button cmdVersBdd;
        private System.Windows.Forms.Label labelJemapelle;
        private System.Windows.Forms.ComboBox cboCidt;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.ComboBox cboVendeur;
        private System.Windows.Forms.Label labelVendeur;
        private System.Windows.Forms.GroupBox gpbAgeVehicule;
        private System.Windows.Forms.RadioButton rbOccas3A5;
        private System.Windows.Forms.RadioButton rbOcc3;
        private System.Windows.Forms.RadioButton rbNeuf;
        private System.Windows.Forms.RadioButton rbOccas5etplus;
        private System.Windows.Forms.Label labelAncVeh;
        private System.Windows.Forms.TextBox txtAncVehc;
        private System.Windows.Forms.TextBox txtNewVehc;
        private System.Windows.Forms.Label labelNewVehc;
        private System.Windows.Forms.Button cmdCredit;
    }
}