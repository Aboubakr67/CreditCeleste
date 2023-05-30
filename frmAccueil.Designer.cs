
namespace CreditCeleste
{
    partial class frmAccueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdIntroduction = new System.Windows.Forms.Button();
            this.cmdEtude = new System.Windows.Forms.Button();
            this.cmdRelance = new System.Windows.Forms.Button();
            this.lblMonAppli = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdIntroduction
            // 
            this.cmdIntroduction.Name = "cmdIntroduction";
            this.cmdIntroduction.TabIndex = 0;
            this.cmdIntroduction.Text = "&Introduction";
            this.cmdIntroduction.UseVisualStyleBackColor = true;
            this.cmdIntroduction.Click += new System.EventHandler(this.cmdIntroduction_Click);
            // 
            // cmdEtude
            // 
            this.cmdEtude.Name = "cmdEtude";
            this.cmdEtude.TabIndex = 1;
            this.cmdEtude.Text = "&Etude";
            this.cmdEtude.UseVisualStyleBackColor = true;
            this.cmdEtude.Click += new System.EventHandler(this.cmdEtude_Click);
            // 
            // cmdRelance
            // 
            this.cmdRelance.Name = "cmdRelance";
            this.cmdRelance.TabIndex = 2;
            this.cmdRelance.Text = "&Relance";
            this.cmdRelance.UseVisualStyleBackColor = true;
            this.cmdRelance.Click += new System.EventHandler(this.cmdRelance_Click);
            // 
            // lblMonAppli
            // 
            this.lblMonAppli.AutoSize = true;
            this.lblMonAppli.Name = "lblMonAppli";
            this.lblMonAppli.TabIndex = 3;
            this.lblMonAppli.Text = "label1";
            // 
            // frmAccueil
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblMonAppli);
            this.Controls.Add(this.cmdRelance);
            this.Controls.Add(this.cmdEtude);
            this.Controls.Add(this.cmdIntroduction);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAccueil";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdIntroduction;
        private System.Windows.Forms.Button cmdEtude;
        private System.Windows.Forms.Button cmdRelance;
        private System.Windows.Forms.Label lblMonAppli;
    }
}

