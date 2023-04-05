
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
            this.lblMaRegion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdIntroduction
            // 
            this.cmdIntroduction.Location = new System.Drawing.Point(42, 227);
            this.cmdIntroduction.Margin = new System.Windows.Forms.Padding(4);
            this.cmdIntroduction.Name = "cmdIntroduction";
            this.cmdIntroduction.Size = new System.Drawing.Size(132, 50);
            this.cmdIntroduction.TabIndex = 0;
            this.cmdIntroduction.Text = "&Introduction";
            this.cmdIntroduction.UseVisualStyleBackColor = true;
            this.cmdIntroduction.Click += new System.EventHandler(this.cmdIntroduction_Click);
            // 
            // cmdEtude
            // 
            this.cmdEtude.Location = new System.Drawing.Point(220, 227);
            this.cmdEtude.Margin = new System.Windows.Forms.Padding(4);
            this.cmdEtude.Name = "cmdEtude";
            this.cmdEtude.Size = new System.Drawing.Size(160, 50);
            this.cmdEtude.TabIndex = 1;
            this.cmdEtude.Text = "&Etude";
            this.cmdEtude.UseVisualStyleBackColor = true;
            // 
            // cmdRelance
            // 
            this.cmdRelance.Location = new System.Drawing.Point(432, 227);
            this.cmdRelance.Margin = new System.Windows.Forms.Padding(4);
            this.cmdRelance.Name = "cmdRelance";
            this.cmdRelance.Size = new System.Drawing.Size(131, 50);
            this.cmdRelance.TabIndex = 2;
            this.cmdRelance.Text = "&Relance";
            this.cmdRelance.UseVisualStyleBackColor = true;
            // 
            // lblMonAppli
            // 
            this.lblMonAppli.AutoSize = true;
            this.lblMonAppli.Location = new System.Drawing.Point(517, 15);
            this.lblMonAppli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonAppli.Name = "lblMonAppli";
            this.lblMonAppli.Size = new System.Drawing.Size(46, 17);
            this.lblMonAppli.TabIndex = 3;
            this.lblMonAppli.Text = "label1";
            // 
            // lblMaRegion
            // 
            this.lblMaRegion.AutoSize = true;
            this.lblMaRegion.Location = new System.Drawing.Point(39, 15);
            this.lblMaRegion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaRegion.Name = "lblMaRegion";
            this.lblMaRegion.Size = new System.Drawing.Size(46, 17);
            this.lblMaRegion.TabIndex = 4;
            this.lblMaRegion.Text = "label2";
            // 
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 329);
            this.Controls.Add(this.lblMaRegion);
            this.Controls.Add(this.lblMonAppli);
            this.Controls.Add(this.cmdRelance);
            this.Controls.Add(this.cmdEtude);
            this.Controls.Add(this.cmdIntroduction);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Label lblMaRegion;
    }
}

