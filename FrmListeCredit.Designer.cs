
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdInit
            // 
            this.cmdInit.Location = new System.Drawing.Point(148, 369);
            this.cmdInit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdInit.Name = "cmdInit";
            this.cmdInit.Size = new System.Drawing.Size(200, 79);
            this.cmdInit.TabIndex = 1;
            this.cmdInit.Text = "Init";
            this.cmdInit.UseVisualStyleBackColor = true;
            this.cmdInit.Click += new System.EventHandler(this.cmdInit_Click);
            // 
            // cmdCredit
            // 
            this.cmdCredit.Location = new System.Drawing.Point(388, 369);
            this.cmdCredit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdCredit.Name = "cmdCredit";
            this.cmdCredit.Size = new System.Drawing.Size(223, 76);
            this.cmdCredit.TabIndex = 2;
            this.cmdCredit.Text = "Credit";
            this.cmdCredit.UseVisualStyleBackColor = true;
            this.cmdCredit.Click += new System.EventHandler(this.cmdCredit_Click);
            // 
            // cmdEnregistre
            // 
            this.cmdEnregistre.Location = new System.Drawing.Point(657, 369);
            this.cmdEnregistre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdEnregistre.Name = "cmdEnregistre";
            this.cmdEnregistre.Size = new System.Drawing.Size(191, 79);
            this.cmdEnregistre.TabIndex = 3;
            this.cmdEnregistre.Text = "Enregistre";
            this.cmdEnregistre.UseVisualStyleBackColor = true;
            // 
            // lsbCredit
            // 
            this.lsbCredit.FormattingEnabled = true;
            this.lsbCredit.ItemHeight = 16;
            this.lsbCredit.Location = new System.Drawing.Point(172, 46);
            this.lsbCredit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lsbCredit.Name = "lsbCredit";
            this.lsbCredit.Size = new System.Drawing.Size(648, 228);
            this.lsbCredit.TabIndex = 4;
            this.lsbCredit.SelectedIndexChanged += new System.EventHandler(this.lsbCredit_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(885, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // FrmListeCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 601);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lsbCredit);
            this.Controls.Add(this.cmdEnregistre);
            this.Controls.Add(this.cmdCredit);
            this.Controls.Add(this.cmdInit);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmListeCredit";
            this.Text = "FrmListeCredit";
            this.Load += new System.EventHandler(this.FrmListeCredit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdInit;
        private System.Windows.Forms.Button cmdCredit;
        private System.Windows.Forms.Button cmdEnregistre;
        private System.Windows.Forms.ListBox lsbCredit;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}