
namespace CreditCeleste
{
    partial class FrmListeCredit
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
            this.cmdInit = new System.Windows.Forms.Button();
            this.cmdCredit = new System.Windows.Forms.Button();
            this.cmdEnregistre = new System.Windows.Forms.Button();
            this.lsbCredit = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cmdInit
            // 
            this.cmdInit.Location = new System.Drawing.Point(111, 300);
            this.cmdInit.Name = "cmdInit";
            this.cmdInit.Size = new System.Drawing.Size(150, 64);
            this.cmdInit.TabIndex = 1;
            this.cmdInit.Text = "Init";
            this.cmdInit.UseVisualStyleBackColor = true;
            this.cmdInit.Click += new System.EventHandler(this.cmdInit_Click);
            // 
            // cmdCredit
            // 
            this.cmdCredit.Location = new System.Drawing.Point(291, 300);
            this.cmdCredit.Name = "cmdCredit";
            this.cmdCredit.Size = new System.Drawing.Size(167, 62);
            this.cmdCredit.TabIndex = 2;
            this.cmdCredit.Text = "Credit";
            this.cmdCredit.UseVisualStyleBackColor = true;
            this.cmdCredit.Click += new System.EventHandler(this.cmdCredit_Click);
            // 
            // cmdEnregistre
            // 
            this.cmdEnregistre.Location = new System.Drawing.Point(493, 300);
            this.cmdEnregistre.Name = "cmdEnregistre";
            this.cmdEnregistre.Size = new System.Drawing.Size(143, 64);
            this.cmdEnregistre.TabIndex = 3;
            this.cmdEnregistre.Text = "Enregistre";
            this.cmdEnregistre.UseVisualStyleBackColor = true;
            // 
            // lsbCredit
            // 
            this.lsbCredit.FormattingEnabled = true;
            this.lsbCredit.Location = new System.Drawing.Point(129, 37);
            this.lsbCredit.Name = "lsbCredit";
            this.lsbCredit.Size = new System.Drawing.Size(487, 186);
            this.lsbCredit.TabIndex = 4;
            this.lsbCredit.SelectedIndexChanged += new System.EventHandler(this.lsbCredit_SelectedIndexChanged);
            // 
            // FrmListeCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lsbCredit);
            this.Controls.Add(this.cmdEnregistre);
            this.Controls.Add(this.cmdCredit);
            this.Controls.Add(this.cmdInit);
            this.Name = "FrmListeCredit";
            this.Text = "FrmListeCredit";
            this.Load += new System.EventHandler(this.FrmListeCredit_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdInit;
        private System.Windows.Forms.Button cmdCredit;
        private System.Windows.Forms.Button cmdEnregistre;
        private System.Windows.Forms.ListBox lsbCredit;
    }
}