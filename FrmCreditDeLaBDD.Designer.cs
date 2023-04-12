
namespace CreditCeleste
{
    partial class FrmCreditDeLaBDD
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
            this.lstCreditDeLaBDD = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdAccueil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstCreditDeLaBDD
            // 
            this.lstCreditDeLaBDD.FormattingEnabled = true;
            this.lstCreditDeLaBDD.Location = new System.Drawing.Point(12, 88);
            this.lstCreditDeLaBDD.Name = "lstCreditDeLaBDD";
            this.lstCreditDeLaBDD.Size = new System.Drawing.Size(776, 264);
            this.lstCreditDeLaBDD.TabIndex = 0;
            this.lstCreditDeLaBDD.SelectedIndexChanged += new System.EventHandler(this.lstCreditDeLaBDD_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(525, 63);
            this.label1.TabIndex = 1;
            this.label1.Text = "CREDIT DE LA BDD";
            // 
            // cmdAccueil
            // 
            this.cmdAccueil.Location = new System.Drawing.Point(303, 377);
            this.cmdAccueil.Name = "cmdAccueil";
            this.cmdAccueil.Size = new System.Drawing.Size(133, 50);
            this.cmdAccueil.TabIndex = 2;
            this.cmdAccueil.Text = "Retour";
            this.cmdAccueil.UseVisualStyleBackColor = true;
            this.cmdAccueil.Click += new System.EventHandler(this.cmdAccueil_Click);
            // 
            // FrmCreditDeLaBDD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdAccueil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstCreditDeLaBDD);
            this.Name = "FrmCreditDeLaBDD";
            this.Text = "FrmCreditDeLaBDD";
            this.Load += new System.EventHandler(this.FrmCreditDeLaBDD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCreditDeLaBDD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdAccueil;
    }
}