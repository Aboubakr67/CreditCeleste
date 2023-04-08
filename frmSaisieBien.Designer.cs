
namespace CreditCeleste
{
    partial class frmSaisieBien
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
            this.cmdIntroduction = new System.Windows.Forms.Button();
            this.cmdJenregistre = new System.Windows.Forms.Button();
            this.txtDatePremierImma = new System.Windows.Forms.TextBox();
            this.txtPuissance = new System.Windows.Forms.TextBox();
            this.txtNumSerie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gpbNouveauVehicule = new System.Windows.Forms.GroupBox();
            this.txtNouvVehc = new System.Windows.Forms.TextBox();
            this.txtNumImma = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.gpbAgeVehicule = new System.Windows.Forms.GroupBox();
            this.rbOccas5etplus = new System.Windows.Forms.RadioButton();
            this.rbOccas3A5 = new System.Windows.Forms.RadioButton();
            this.rbOcc3 = new System.Windows.Forms.RadioButton();
            this.rbNeuf = new System.Windows.Forms.RadioButton();
            this.cmdCredit = new System.Windows.Forms.Button();
            this.cmdClient = new System.Windows.Forms.Button();
            this.lblVille = new System.Windows.Forms.Label();
            this.lblRegion = new System.Windows.Forms.Label();
            this.gpbNouveauVehicule.SuspendLayout();
            this.gpbAgeVehicule.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdIntroduction
            // 
            this.cmdIntroduction.Location = new System.Drawing.Point(448, 306);
            this.cmdIntroduction.Name = "cmdIntroduction";
            this.cmdIntroduction.Size = new System.Drawing.Size(145, 57);
            this.cmdIntroduction.TabIndex = 1;
            this.cmdIntroduction.Text = "Introduction";
            this.cmdIntroduction.UseVisualStyleBackColor = true;
            this.cmdIntroduction.Click += new System.EventHandler(this.cmdIntroduction_Click);
            // 
            // cmdJenregistre
            // 
            this.cmdJenregistre.Location = new System.Drawing.Point(70, 304);
            this.cmdJenregistre.Name = "cmdJenregistre";
            this.cmdJenregistre.Size = new System.Drawing.Size(129, 59);
            this.cmdJenregistre.TabIndex = 2;
            this.cmdJenregistre.Text = "&J\'enregistre";
            this.cmdJenregistre.UseVisualStyleBackColor = true;
            this.cmdJenregistre.Click += new System.EventHandler(this.cmdJenregistre_Click);
            // 
            // txtDatePremierImma
            // 
            this.txtDatePremierImma.Location = new System.Drawing.Point(21, 224);
            this.txtDatePremierImma.Name = "txtDatePremierImma";
            this.txtDatePremierImma.Size = new System.Drawing.Size(161, 20);
            this.txtDatePremierImma.TabIndex = 3;
            // 
            // txtPuissance
            // 
            this.txtPuissance.Location = new System.Drawing.Point(688, 224);
            this.txtPuissance.Name = "txtPuissance";
            this.txtPuissance.Size = new System.Drawing.Size(100, 20);
            this.txtPuissance.TabIndex = 4;
            // 
            // txtNumSerie
            // 
            this.txtNumSerie.Location = new System.Drawing.Point(499, 224);
            this.txtNumSerie.Name = "txtNumSerie";
            this.txtNumSerie.Size = new System.Drawing.Size(173, 20);
            this.txtNumSerie.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Date 1ère Immatriculation";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(700, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Puissance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(496, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Numéro de série";
            // 
            // gpbNouveauVehicule
            // 
            this.gpbNouveauVehicule.Controls.Add(this.txtNouvVehc);
            this.gpbNouveauVehicule.Location = new System.Drawing.Point(33, 21);
            this.gpbNouveauVehicule.Name = "gpbNouveauVehicule";
            this.gpbNouveauVehicule.Size = new System.Drawing.Size(195, 153);
            this.gpbNouveauVehicule.TabIndex = 11;
            this.gpbNouveauVehicule.TabStop = false;
            this.gpbNouveauVehicule.Text = "Mon nouveau vehicule";
            this.gpbNouveauVehicule.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtNouvVehc
            // 
            this.txtNouvVehc.Location = new System.Drawing.Point(24, 35);
            this.txtNouvVehc.Name = "txtNouvVehc";
            this.txtNouvVehc.Size = new System.Drawing.Size(100, 20);
            this.txtNouvVehc.TabIndex = 15;
            // 
            // txtNumImma
            // 
            this.txtNumImma.Location = new System.Drawing.Point(279, 224);
            this.txtNumImma.Name = "txtNumImma";
            this.txtNumImma.Size = new System.Drawing.Size(100, 20);
            this.txtNumImma.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(276, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "numéro immatriculation";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(248, 305);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(131, 58);
            this.btnValider.TabIndex = 14;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.button1_Click);
            // 
            // gpbAgeVehicule
            // 
            this.gpbAgeVehicule.Controls.Add(this.rbOccas5etplus);
            this.gpbAgeVehicule.Controls.Add(this.rbOccas3A5);
            this.gpbAgeVehicule.Controls.Add(this.rbOcc3);
            this.gpbAgeVehicule.Controls.Add(this.rbNeuf);
            this.gpbAgeVehicule.Location = new System.Drawing.Point(325, 56);
            this.gpbAgeVehicule.Name = "gpbAgeVehicule";
            this.gpbAgeVehicule.Size = new System.Drawing.Size(200, 130);
            this.gpbAgeVehicule.TabIndex = 17;
            this.gpbAgeVehicule.TabStop = false;
            this.gpbAgeVehicule.Text = "Age du véhicule";
            this.gpbAgeVehicule.Enter += new System.EventHandler(this.gpbAgeVehicule_Enter);
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
            // cmdCredit
            // 
            this.cmdCredit.Location = new System.Drawing.Point(642, 305);
            this.cmdCredit.Name = "cmdCredit";
            this.cmdCredit.Size = new System.Drawing.Size(133, 58);
            this.cmdCredit.TabIndex = 18;
            this.cmdCredit.Text = "Credit";
            this.cmdCredit.UseVisualStyleBackColor = true;
            this.cmdCredit.Click += new System.EventHandler(this.cmdCredit_Click);
            // 
            // cmdClient
            // 
            this.cmdClient.Location = new System.Drawing.Point(418, 385);
            this.cmdClient.Name = "cmdClient";
            this.cmdClient.Size = new System.Drawing.Size(128, 53);
            this.cmdClient.TabIndex = 19;
            this.cmdClient.Text = "Client";
            this.cmdClient.UseVisualStyleBackColor = true;
            this.cmdClient.Click += new System.EventHandler(this.cmdClient_Click);
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(740, 47);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(35, 13);
            this.lblVille.TabIndex = 38;
            this.lblVille.Text = "label2";
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(740, 21);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(35, 13);
            this.lblRegion.TabIndex = 37;
            this.lblRegion.Text = "label2";
            // 
            // frmSaisieBien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblVille);
            this.Controls.Add(this.lblRegion);
            this.Controls.Add(this.cmdClient);
            this.Controls.Add(this.cmdCredit);
            this.Controls.Add(this.gpbAgeVehicule);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNumImma);
            this.Controls.Add(this.gpbNouveauVehicule);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumSerie);
            this.Controls.Add(this.txtPuissance);
            this.Controls.Add(this.txtDatePremierImma);
            this.Controls.Add(this.cmdJenregistre);
            this.Controls.Add(this.cmdIntroduction);
            this.Name = "frmSaisieBien";
            this.Text = "frmSaisieBien";
            this.Load += new System.EventHandler(this.frmSaisieBien_Load);
            this.gpbNouveauVehicule.ResumeLayout(false);
            this.gpbNouveauVehicule.PerformLayout();
            this.gpbAgeVehicule.ResumeLayout(false);
            this.gpbAgeVehicule.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdIntroduction;
        private System.Windows.Forms.Button cmdJenregistre;
        private System.Windows.Forms.TextBox txtDatePremierImma;
        private System.Windows.Forms.TextBox txtPuissance;
        private System.Windows.Forms.TextBox txtNumSerie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gpbNouveauVehicule;
        private System.Windows.Forms.TextBox txtNumImma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.TextBox txtNouvVehc;
        private System.Windows.Forms.GroupBox gpbAgeVehicule;
        private System.Windows.Forms.RadioButton rbOccas5etplus;
        private System.Windows.Forms.RadioButton rbOccas3A5;
        private System.Windows.Forms.RadioButton rbOcc3;
        private System.Windows.Forms.RadioButton rbNeuf;
        private System.Windows.Forms.Button cmdCredit;
        private System.Windows.Forms.Button cmdClient;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label lblRegion;
    }
}