
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
<<<<<<< HEAD
            this.cmdJenregistre.Location = new System.Drawing.Point(125, 425);
            this.cmdJenregistre.Margin = new System.Windows.Forms.Padding(4);
            this.cmdJenregistre.Name = "cmdJenregistre";
            this.cmdJenregistre.Size = new System.Drawing.Size(143, 41);
=======
            this.cmdJenregistre.Location = new System.Drawing.Point(94, 345);
            this.cmdJenregistre.Name = "cmdJenregistre";
            this.cmdJenregistre.Size = new System.Drawing.Size(107, 33);
>>>>>>> origin/Aboubakr
            this.cmdJenregistre.TabIndex = 0;
            this.cmdJenregistre.Text = "&J\'enregistre";
            this.cmdJenregistre.UseVisualStyleBackColor = true;
            this.cmdJenregistre.Click += new System.EventHandler(this.cmdJenregistre_Click);
            // 
            // cmdSaisieBien
            // 
<<<<<<< HEAD
            this.cmdSaisieBien.Location = new System.Drawing.Point(328, 425);
            this.cmdSaisieBien.Margin = new System.Windows.Forms.Padding(4);
            this.cmdSaisieBien.Name = "cmdSaisieBien";
            this.cmdSaisieBien.Size = new System.Drawing.Size(148, 41);
=======
            this.cmdSaisieBien.Location = new System.Drawing.Point(246, 345);
            this.cmdSaisieBien.Name = "cmdSaisieBien";
            this.cmdSaisieBien.Size = new System.Drawing.Size(111, 33);
>>>>>>> origin/Aboubakr
            this.cmdSaisieBien.TabIndex = 1;
            this.cmdSaisieBien.Text = "&Voiture";
            this.cmdSaisieBien.UseVisualStyleBackColor = true;
            this.cmdSaisieBien.Click += new System.EventHandler(this.cmdSaisieBien_Click);
            // 
            // cmdVersBdd
            // 
<<<<<<< HEAD
            this.cmdVersBdd.Location = new System.Drawing.Point(769, 415);
            this.cmdVersBdd.Margin = new System.Windows.Forms.Padding(4);
            this.cmdVersBdd.Name = "cmdVersBdd";
            this.cmdVersBdd.Size = new System.Drawing.Size(159, 50);
            this.cmdVersBdd.TabIndex = 2;
            this.cmdVersBdd.Text = "&Je Valide";
            this.cmdVersBdd.UseVisualStyleBackColor = true;
            this.cmdVersBdd.Click += new System.EventHandler(this.cmdVersBdd_Click);
=======
            this.cmdVersBdd.Location = new System.Drawing.Point(577, 337);
            this.cmdVersBdd.Name = "cmdVersBdd";
            this.cmdVersBdd.Size = new System.Drawing.Size(119, 41);
            this.cmdVersBdd.TabIndex = 2;
            this.cmdVersBdd.Text = "&Je Valide";
            this.cmdVersBdd.UseVisualStyleBackColor = true;
>>>>>>> origin/Aboubakr
            // 
            // labelJemapelle
            // 
            this.labelJemapelle.AutoSize = true;
<<<<<<< HEAD
            this.labelJemapelle.Location = new System.Drawing.Point(88, 44);
            this.labelJemapelle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelJemapelle.Name = "labelJemapelle";
            this.labelJemapelle.Size = new System.Drawing.Size(87, 17);
=======
            this.labelJemapelle.Location = new System.Drawing.Point(66, 36);
            this.labelJemapelle.Name = "labelJemapelle";
            this.labelJemapelle.Size = new System.Drawing.Size(65, 13);
>>>>>>> origin/Aboubakr
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
<<<<<<< HEAD
            this.cboCidt.Location = new System.Drawing.Point(37, 64);
            this.cboCidt.Margin = new System.Windows.Forms.Padding(4);
            this.cboCidt.Name = "cboCidt";
            this.cboCidt.Size = new System.Drawing.Size(160, 24);
=======
            this.cboCidt.Location = new System.Drawing.Point(28, 52);
            this.cboCidt.Name = "cboCidt";
            this.cboCidt.Size = new System.Drawing.Size(121, 21);
>>>>>>> origin/Aboubakr
            this.cboCidt.TabIndex = 4;
            this.cboCidt.SelectedIndexChanged += new System.EventHandler(this.cboCidt_SelectedIndexChanged);
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
<<<<<<< HEAD
            this.labelNom.Location = new System.Drawing.Point(41, 146);
            this.labelNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(37, 17);
=======
            this.labelNom.Location = new System.Drawing.Point(31, 119);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(29, 13);
>>>>>>> origin/Aboubakr
            this.labelNom.TabIndex = 5;
            this.labelNom.Text = "Nom";
            this.labelNom.Click += new System.EventHandler(this.labelNom_Click);
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
<<<<<<< HEAD
            this.labelPrenom.Location = new System.Drawing.Point(41, 230);
            this.labelPrenom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(57, 17);
=======
            this.labelPrenom.Location = new System.Drawing.Point(31, 187);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(43, 13);
>>>>>>> origin/Aboubakr
            this.labelPrenom.TabIndex = 6;
            this.labelPrenom.Text = "&Prenom";
            // 
            // txtNom
            // 
<<<<<<< HEAD
            this.txtNom.Location = new System.Drawing.Point(37, 114);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(132, 22);
=======
            this.txtNom.Location = new System.Drawing.Point(28, 93);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
>>>>>>> origin/Aboubakr
            this.txtNom.TabIndex = 7;
            // 
            // txtPrenom
            // 
<<<<<<< HEAD
            this.txtPrenom.Location = new System.Drawing.Point(37, 196);
            this.txtPrenom.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(132, 22);
=======
            this.txtPrenom.Location = new System.Drawing.Point(28, 159);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(100, 20);
>>>>>>> origin/Aboubakr
            this.txtPrenom.TabIndex = 8;
            // 
            // cboVendeur
            // 
            this.cboVendeur.FormattingEnabled = true;
<<<<<<< HEAD
            this.cboVendeur.Location = new System.Drawing.Point(64, 324);
            this.cboVendeur.Margin = new System.Windows.Forms.Padding(4);
            this.cboVendeur.Name = "cboVendeur";
            this.cboVendeur.Size = new System.Drawing.Size(160, 24);
=======
            this.cboVendeur.Location = new System.Drawing.Point(48, 263);
            this.cboVendeur.Name = "cboVendeur";
            this.cboVendeur.Size = new System.Drawing.Size(121, 21);
>>>>>>> origin/Aboubakr
            this.cboVendeur.TabIndex = 9;
            // 
            // labelVendeur
            // 
            this.labelVendeur.AutoSize = true;
<<<<<<< HEAD
            this.labelVendeur.Location = new System.Drawing.Point(108, 298);
            this.labelVendeur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVendeur.Name = "labelVendeur";
            this.labelVendeur.Size = new System.Drawing.Size(62, 17);
=======
            this.labelVendeur.Location = new System.Drawing.Point(81, 242);
            this.labelVendeur.Name = "labelVendeur";
            this.labelVendeur.Size = new System.Drawing.Size(47, 13);
>>>>>>> origin/Aboubakr
            this.labelVendeur.TabIndex = 10;
            this.labelVendeur.Text = "&Vendeur";
            // 
            // gpbAgeVehicule
            // 
            this.gpbAgeVehicule.Controls.Add(this.rbOccas5etplus);
            this.gpbAgeVehicule.Controls.Add(this.rbOccas3A5);
            this.gpbAgeVehicule.Controls.Add(this.rbOcc3);
            this.gpbAgeVehicule.Controls.Add(this.rbNeuf);
<<<<<<< HEAD
            this.gpbAgeVehicule.Location = new System.Drawing.Point(484, 230);
            this.gpbAgeVehicule.Margin = new System.Windows.Forms.Padding(4);
            this.gpbAgeVehicule.Name = "gpbAgeVehicule";
            this.gpbAgeVehicule.Padding = new System.Windows.Forms.Padding(4);
            this.gpbAgeVehicule.Size = new System.Drawing.Size(267, 160);
=======
            this.gpbAgeVehicule.Location = new System.Drawing.Point(339, 187);
            this.gpbAgeVehicule.Name = "gpbAgeVehicule";
            this.gpbAgeVehicule.Size = new System.Drawing.Size(200, 130);
>>>>>>> origin/Aboubakr
            this.gpbAgeVehicule.TabIndex = 11;
            this.gpbAgeVehicule.TabStop = false;
            this.gpbAgeVehicule.Text = "Age du véhicule";
            // 
            // rbOccas5etplus
            // 
            this.rbOccas5etplus.AutoSize = true;
<<<<<<< HEAD
            this.rbOccas5etplus.Location = new System.Drawing.Point(21, 124);
            this.rbOccas5etplus.Margin = new System.Windows.Forms.Padding(4);
            this.rbOccas5etplus.Name = "rbOccas5etplus";
            this.rbOccas5etplus.Size = new System.Drawing.Size(174, 21);
=======
            this.rbOccas5etplus.Location = new System.Drawing.Point(16, 101);
            this.rbOccas5etplus.Name = "rbOccas5etplus";
            this.rbOccas5etplus.Size = new System.Drawing.Size(134, 17);
>>>>>>> origin/Aboubakr
            this.rbOccas5etplus.TabIndex = 3;
            this.rbOccas5etplus.Text = "Occasion 5 ans et Plus";
            this.rbOccas5etplus.UseVisualStyleBackColor = true;
            // 
            // rbOccas3A5
            // 
            this.rbOccas3A5.AutoSize = true;
<<<<<<< HEAD
            this.rbOccas3A5.Location = new System.Drawing.Point(21, 95);
            this.rbOccas3A5.Margin = new System.Windows.Forms.Padding(4);
            this.rbOccas3A5.Name = "rbOccas3A5";
            this.rbOccas3A5.Size = new System.Drawing.Size(198, 21);
=======
            this.rbOccas3A5.Location = new System.Drawing.Point(16, 77);
            this.rbOccas3A5.Name = "rbOccas3A5";
            this.rbOccas3A5.Size = new System.Drawing.Size(152, 17);
>>>>>>> origin/Aboubakr
            this.rbOccas3A5.TabIndex = 2;
            this.rbOccas3A5.Text = "Occasion de 3 ans a 5 ans";
            this.rbOccas3A5.UseVisualStyleBackColor = true;
            // 
            // rbOcc3
            // 
            this.rbOcc3.AutoSize = true;
<<<<<<< HEAD
            this.rbOcc3.Location = new System.Drawing.Point(21, 68);
            this.rbOcc3.Margin = new System.Windows.Forms.Padding(4);
            this.rbOcc3.Name = "rbOcc3";
            this.rbOcc3.Size = new System.Drawing.Size(147, 21);
=======
            this.rbOcc3.Location = new System.Drawing.Point(16, 55);
            this.rbOcc3.Name = "rbOcc3";
            this.rbOcc3.Size = new System.Drawing.Size(114, 17);
>>>>>>> origin/Aboubakr
            this.rbOcc3.TabIndex = 1;
            this.rbOcc3.Text = "Occasion de 3 ans";
            this.rbOcc3.UseVisualStyleBackColor = true;
            // 
            // rbNeuf
            // 
            this.rbNeuf.AutoSize = true;
            this.rbNeuf.Checked = true;
<<<<<<< HEAD
            this.rbNeuf.Location = new System.Drawing.Point(21, 38);
            this.rbNeuf.Margin = new System.Windows.Forms.Padding(4);
            this.rbNeuf.Name = "rbNeuf";
            this.rbNeuf.Size = new System.Drawing.Size(59, 21);
=======
            this.rbNeuf.Location = new System.Drawing.Point(16, 31);
            this.rbNeuf.Name = "rbNeuf";
            this.rbNeuf.Size = new System.Drawing.Size(48, 17);
>>>>>>> origin/Aboubakr
            this.rbNeuf.TabIndex = 0;
            this.rbNeuf.TabStop = true;
            this.rbNeuf.Text = "Neuf";
            this.rbNeuf.UseVisualStyleBackColor = true;
            // 
            // labelAncVeh
            // 
            this.labelAncVeh.AutoSize = true;
<<<<<<< HEAD
            this.labelAncVeh.Location = new System.Drawing.Point(853, 62);
            this.labelAncVeh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAncVeh.Name = "labelAncVeh";
            this.labelAncVeh.Size = new System.Drawing.Size(137, 17);
=======
            this.labelAncVeh.Location = new System.Drawing.Point(640, 50);
            this.labelAncVeh.Name = "labelAncVeh";
            this.labelAncVeh.Size = new System.Drawing.Size(106, 13);
>>>>>>> origin/Aboubakr
            this.labelAncVeh.TabIndex = 12;
            this.labelAncVeh.Text = "Mon ancien vehicule";
            // 
            // txtAncVehc
            // 
<<<<<<< HEAD
            this.txtAncVehc.Location = new System.Drawing.Point(857, 81);
            this.txtAncVehc.Margin = new System.Windows.Forms.Padding(4);
            this.txtAncVehc.Name = "txtAncVehc";
            this.txtAncVehc.Size = new System.Drawing.Size(132, 22);
=======
            this.txtAncVehc.Location = new System.Drawing.Point(643, 66);
            this.txtAncVehc.Name = "txtAncVehc";
            this.txtAncVehc.Size = new System.Drawing.Size(100, 20);
>>>>>>> origin/Aboubakr
            this.txtAncVehc.TabIndex = 13;
            // 
            // txtNewVehc
            // 
<<<<<<< HEAD
            this.txtNewVehc.Location = new System.Drawing.Point(452, 146);
            this.txtNewVehc.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewVehc.Name = "txtNewVehc";
            this.txtNewVehc.Size = new System.Drawing.Size(153, 22);
=======
            this.txtNewVehc.Location = new System.Drawing.Point(339, 119);
            this.txtNewVehc.Name = "txtNewVehc";
            this.txtNewVehc.Size = new System.Drawing.Size(116, 20);
>>>>>>> origin/Aboubakr
            this.txtNewVehc.TabIndex = 14;
            // 
            // labelNewVehc
            // 
            this.labelNewVehc.AutoSize = true;
<<<<<<< HEAD
            this.labelNewVehc.Location = new System.Drawing.Point(452, 123);
            this.labelNewVehc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNewVehc.Name = "labelNewVehc";
            this.labelNewVehc.Size = new System.Drawing.Size(150, 17);
=======
            this.labelNewVehc.Location = new System.Drawing.Point(339, 100);
            this.labelNewVehc.Name = "labelNewVehc";
            this.labelNewVehc.Size = new System.Drawing.Size(116, 13);
>>>>>>> origin/Aboubakr
            this.labelNewVehc.TabIndex = 15;
            this.labelNewVehc.Text = "Mon nouveau vehicule";
            // 
            // cmdCredit
            // 
<<<<<<< HEAD
            this.cmdCredit.Location = new System.Drawing.Point(552, 425);
            this.cmdCredit.Margin = new System.Windows.Forms.Padding(4);
            this.cmdCredit.Name = "cmdCredit";
            this.cmdCredit.Size = new System.Drawing.Size(124, 41);
=======
            this.cmdCredit.Location = new System.Drawing.Point(414, 345);
            this.cmdCredit.Name = "cmdCredit";
            this.cmdCredit.Size = new System.Drawing.Size(93, 33);
>>>>>>> origin/Aboubakr
            this.cmdCredit.TabIndex = 16;
            this.cmdCredit.Text = "Credit";
            this.cmdCredit.UseVisualStyleBackColor = true;
            this.cmdCredit.Click += new System.EventHandler(this.cmdCredit_Click);
            // 
            // frmIntroduction
            // 
<<<<<<< HEAD
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 554);
=======
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 450);
>>>>>>> origin/Aboubakr
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
<<<<<<< HEAD
            this.Margin = new System.Windows.Forms.Padding(4);
=======
>>>>>>> origin/Aboubakr
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