
namespace CreditCeleste
{
    partial class frmRelance
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
            this.dataGridRelance = new System.Windows.Forms.DataGridView();
            this.Numéro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Montant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Taux = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mensualite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accepter = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Refuser = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblNomConcession = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRelance)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridRelance
            // 
            this.dataGridRelance.AllowUserToAddRows = false;
            this.dataGridRelance.AllowUserToDeleteRows = false;
            this.dataGridRelance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRelance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numéro,
            this.Nom,
            this.Prenom,
            this.Montant,
            this.Taux,
            this.Duree,
            this.Mensualite,
            this.Accepter,
            this.Refuser});
            this.dataGridRelance.Location = new System.Drawing.Point(48, 117);
            this.dataGridRelance.Name = "dataGridRelance";
            this.dataGridRelance.ReadOnly = true;
            this.dataGridRelance.Size = new System.Drawing.Size(694, 292);
            this.dataGridRelance.TabIndex = 2;
            this.dataGridRelance.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRelance_CellContentClick);
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
            // lblNomConcession
            // 
            this.lblNomConcession.AutoSize = true;
            this.lblNomConcession.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomConcession.Location = new System.Drawing.Point(314, 31);
            this.lblNomConcession.Name = "lblNomConcession";
            this.lblNomConcession.Size = new System.Drawing.Size(132, 47);
            this.lblNomConcession.TabIndex = 3;
            this.lblNomConcession.Text = "label1";
            // 
            // frmRelance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNomConcession);
            this.Controls.Add(this.dataGridRelance);
            this.Name = "frmRelance";
            this.Text = "frmRelance";
            this.Load += new System.EventHandler(this.frmRelance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRelance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridRelance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numéro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Montant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Taux;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duree;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mensualite;
        private System.Windows.Forms.DataGridViewButtonColumn Accepter;
        private System.Windows.Forms.DataGridViewButtonColumn Refuser;
        private System.Windows.Forms.Label lblNomConcession;
    }
}