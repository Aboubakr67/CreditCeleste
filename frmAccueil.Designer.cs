
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccueil));
            this.cmdIntroduction = new System.Windows.Forms.Button();
            this.cmdEtude = new System.Windows.Forms.Button();
            this.cmdRelance = new System.Windows.Forms.Button();
            this.lblMonAppli = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdIntroduction
            // 
            this.cmdIntroduction.BackColor = System.Drawing.Color.Transparent;
            this.cmdIntroduction.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.cmdIntroduction.FlatAppearance.BorderSize = 2;
            this.cmdIntroduction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cmdIntroduction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cmdIntroduction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdIntroduction.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdIntroduction.ForeColor = System.Drawing.Color.DodgerBlue;
            this.cmdIntroduction.Location = new System.Drawing.Point(13, 497);
            this.cmdIntroduction.Margin = new System.Windows.Forms.Padding(4);
            this.cmdIntroduction.Name = "cmdIntroduction";
            this.cmdIntroduction.Size = new System.Drawing.Size(276, 104);
            this.cmdIntroduction.TabIndex = 0;
            this.cmdIntroduction.Text = "&Introduction";
            this.cmdIntroduction.UseVisualStyleBackColor = false;
            this.cmdIntroduction.Click += new System.EventHandler(this.cmdIntroduction_Click);
            this.cmdIntroduction.MouseEnter += new System.EventHandler(this.cmdIntroduction_MouseEnter);
            this.cmdIntroduction.MouseLeave += new System.EventHandler(this.cmdIntroduction_MouseLeave);
            // 
            // cmdEtude
            // 
            this.cmdEtude.BackColor = System.Drawing.Color.Transparent;
            this.cmdEtude.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.cmdEtude.FlatAppearance.BorderSize = 2;
            this.cmdEtude.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cmdEtude.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cmdEtude.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdEtude.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEtude.ForeColor = System.Drawing.Color.DodgerBlue;
            this.cmdEtude.Location = new System.Drawing.Point(399, 497);
            this.cmdEtude.Margin = new System.Windows.Forms.Padding(4);
            this.cmdEtude.Name = "cmdEtude";
            this.cmdEtude.Size = new System.Drawing.Size(276, 104);
            this.cmdEtude.TabIndex = 1;
            this.cmdEtude.Text = "&Etude";
            this.cmdEtude.UseVisualStyleBackColor = false;
            this.cmdEtude.Click += new System.EventHandler(this.cmdEtude_Click);
            this.cmdEtude.MouseEnter += new System.EventHandler(this.cmdEtude_MouseEnter);
            this.cmdEtude.MouseLeave += new System.EventHandler(this.cmdEtude_MouseLeave);
            // 
            // cmdRelance
            // 
            this.cmdRelance.BackColor = System.Drawing.Color.Transparent;
            this.cmdRelance.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.cmdRelance.FlatAppearance.BorderSize = 2;
            this.cmdRelance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cmdRelance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cmdRelance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdRelance.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRelance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.cmdRelance.Location = new System.Drawing.Point(778, 497);
            this.cmdRelance.Margin = new System.Windows.Forms.Padding(4);
            this.cmdRelance.Name = "cmdRelance";
            this.cmdRelance.Size = new System.Drawing.Size(276, 104);
            this.cmdRelance.TabIndex = 2;
            this.cmdRelance.Text = "&Relance";
            this.cmdRelance.UseVisualStyleBackColor = false;
            this.cmdRelance.MouseEnter += new System.EventHandler(this.cmdRelance_MouseEnter);
            this.cmdRelance.MouseLeave += new System.EventHandler(this.cmdRelance_MouseLeave);
            // 
            // lblMonAppli
            // 
            this.lblMonAppli.BackColor = System.Drawing.Color.Transparent;
            this.lblMonAppli.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonAppli.ForeColor = System.Drawing.Color.White;
            this.lblMonAppli.Location = new System.Drawing.Point(698, 9);
            this.lblMonAppli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonAppli.Name = "lblMonAppli";
            this.lblMonAppli.Size = new System.Drawing.Size(356, 36);
            this.lblMonAppli.TabIndex = 3;
            this.lblMonAppli.Text = "Nom";
            this.lblMonAppli.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 614);
            this.Controls.Add(this.lblMonAppli);
            this.Controls.Add(this.cmdRelance);
            this.Controls.Add(this.cmdEtude);
            this.Controls.Add(this.cmdIntroduction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAccueil";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdIntroduction;
        private System.Windows.Forms.Button cmdEtude;
        private System.Windows.Forms.Button cmdRelance;
        private System.Windows.Forms.Label lblMonAppli;
    }
}

