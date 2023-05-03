
namespace CreditCeleste
{
    partial class frmChoixConcession
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
            this.cboRegion = new System.Windows.Forms.ComboBox();
            this.cboVille = new System.Windows.Forms.ComboBox();
            this.lblRegion = new System.Windows.Forms.Label();
            this.lblVille = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboRegion
            // 
            this.cboRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRegion.FormattingEnabled = true;
            this.cboRegion.Location = new System.Drawing.Point(355, 108);
            this.cboRegion.Name = "cboRegion";
            this.cboRegion.Size = new System.Drawing.Size(211, 30);
            this.cboRegion.TabIndex = 0;
            this.cboRegion.SelectedIndexChanged += new System.EventHandler(this.cboRegion_SelectedIndexChanged);
            // 
            // cboVille
            // 
            this.cboVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVille.FormattingEnabled = true;
            this.cboVille.Location = new System.Drawing.Point(355, 196);
            this.cboVille.Name = "cboVille";
            this.cboVille.Size = new System.Drawing.Size(211, 30);
            this.cboVille.TabIndex = 1;
            this.cboVille.SelectedIndexChanged += new System.EventHandler(this.cboVille_SelectedIndexChanged);
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegion.Location = new System.Drawing.Point(208, 108);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(100, 31);
            this.lblRegion.TabIndex = 2;
            this.lblRegion.Text = "Region";
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVille.Location = new System.Drawing.Point(224, 191);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(65, 31);
            this.lblVille.TabIndex = 3;
            this.lblVille.Text = "Ville";
            this.lblVille.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(660, 58);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bienvenue, veuillez selectionner votre region et votre ville\r\n\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmdValider
            // 
            this.cmdValider.Location = new System.Drawing.Point(355, 302);
            this.cmdValider.Name = "cmdValider";
            this.cmdValider.Size = new System.Drawing.Size(188, 68);
            this.cmdValider.TabIndex = 5;
            this.cmdValider.Text = "Valider";
            this.cmdValider.UseVisualStyleBackColor = true;
            this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
            // 
            // frmChoixConcession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdValider);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblVille);
            this.Controls.Add(this.lblRegion);
            this.Controls.Add(this.cboVille);
            this.Controls.Add(this.cboRegion);
            this.Name = "frmChoixConcession";
            this.Text = "frmChoixConcession";
            this.Load += new System.EventHandler(this.frmChoixConcession_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboRegion;
        private System.Windows.Forms.ComboBox cboVille;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdValider;
    }
}