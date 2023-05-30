
namespace CreditCeleste
{
    partial class frmEtude
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
            this.cmdRetour = new System.Windows.Forms.Button();
            this.dataGridEtude = new System.Windows.Forms.DataGridView();
            this.lblNomConcession = new System.Windows.Forms.Label();
            this.Numéro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Montant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Taux = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mensualite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accepter = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Refuser = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEtude)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdRetour
            // 
            this.cmdRetour.Location = new System.Drawing.Point(375, 395);
            this.cmdRetour.Name = "cmdRetour";
            this.cmdRetour.Size = new System.Drawing.Size(75, 43);
            this.cmdRetour.TabIndex = 0;
            this.cmdRetour.Text = "Retour";
            this.cmdRetour.UseVisualStyleBackColor = true;
            this.cmdRetour.Click += new System.EventHandler(this.cmdRetour_Click);
            // 
            // dataGridEtude
            // 
            this.dataGridEtude.AllowUserToAddRows = false;
            this.dataGridEtude.AllowUserToDeleteRows = false;
            this.dataGridEtude.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEtude.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numéro,
            this.Nom,
            this.Prenom,
            this.Montant,
            this.Taux,
            this.Duree,
            this.Mensualite,
            this.Accepter,
            this.Refuser});
            this.dataGridEtude.Location = new System.Drawing.Point(57, 84);
            this.dataGridEtude.Name = "dataGridEtude";
            this.dataGridEtude.ReadOnly = true;
            this.dataGridEtude.Size = new System.Drawing.Size(694, 292);
            this.dataGridEtude.TabIndex = 1;
            this.dataGridEtude.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEtude_CellContentClick);
            // 
            // lblNomConcession
            // 
            this.lblNomConcession.AutoSize = true;
            this.lblNomConcession.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomConcession.Location = new System.Drawing.Point(334, 22);
            this.lblNomConcession.Name = "lblNomConcession";
            this.lblNomConcession.Size = new System.Drawing.Size(132, 47);
            this.lblNomConcession.TabIndex = 2;
            this.lblNomConcession.Text = "label1";
            // 
            // Numéro
            // 
            this.Numéro.HeaderText = "Numéro";
            this.Numéro.Name = "Numéro";
            this.Numéro.ReadOnly = true;
            this.Numéro.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Numéro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Numéro.Width = 70;
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            this.Nom.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nom.Width = 70;
            // 
            // Prenom
            // 
            this.Prenom.HeaderText = "Prenom";
            this.Prenom.Name = "Prenom";
            this.Prenom.ReadOnly = true;
            this.Prenom.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Prenom.Width = 70;
            // 
            // Montant
            // 
            this.Montant.HeaderText = "Montant";
            this.Montant.Name = "Montant";
            this.Montant.ReadOnly = true;
            this.Montant.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Montant.Width = 70;
            // 
            // Taux
            // 
            this.Taux.HeaderText = "Taux";
            this.Taux.Name = "Taux";
            this.Taux.ReadOnly = true;
            this.Taux.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Taux.Width = 70;
            // 
            // Duree
            // 
            this.Duree.HeaderText = "Duree";
            this.Duree.Name = "Duree";
            this.Duree.ReadOnly = true;
            this.Duree.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Duree.Width = 70;
            // 
            // Mensualite
            // 
            this.Mensualite.HeaderText = "Mensualite";
            this.Mensualite.Name = "Mensualite";
            this.Mensualite.ReadOnly = true;
            this.Mensualite.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Mensualite.Width = 70;
            // 
            // Accepter
            // 
            this.Accepter.HeaderText = "Accepter";
            this.Accepter.Name = "Accepter";
            this.Accepter.ReadOnly = true;
            this.Accepter.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Accepter.Width = 80;
            // 
            // Refuser
            // 
            this.Refuser.HeaderText = "Refuser";
            this.Refuser.Name = "Refuser";
            this.Refuser.ReadOnly = true;
            this.Refuser.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Refuser.Width = 80;
            // 
            // frmEtude
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNomConcession);
            this.Controls.Add(this.dataGridEtude);
            this.Controls.Add(this.cmdRetour);
            this.Name = "frmEtude";
            this.Text = "frmEtude";
            this.Load += new System.EventHandler(this.frmEtude_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEtude)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdRetour;
        private System.Windows.Forms.DataGridView dataGridEtude;
        private System.Windows.Forms.Label lblNomConcession;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numéro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Montant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Taux;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duree;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mensualite;
        private System.Windows.Forms.DataGridViewButtonColumn Accepter;
        private System.Windows.Forms.DataGridViewButtonColumn Refuser;
    }
}