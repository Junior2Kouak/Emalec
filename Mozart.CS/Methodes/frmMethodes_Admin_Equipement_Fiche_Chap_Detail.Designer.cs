namespace MozartCS
{
    partial class frmMethodes_Admin_Equipement_Fiche_Chap_Detail
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
            this.GrpActions = new System.Windows.Forms.GroupBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.LblTitre = new System.Windows.Forms.Label();
            this.SFD = new System.Windows.Forms.SaveFileDialog();
            this.ChkActif = new System.Windows.Forms.CheckBox();
            this.LblNomFiche = new System.Windows.Forms.Label();
            this.txtNomChapitre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNumOrdreAffichage = new System.Windows.Forms.TextBox();
            this.GrpActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpActions
            // 
            this.GrpActions.Controls.Add(this.BtnSave);
            this.GrpActions.Controls.Add(this.BtnClose);
            this.GrpActions.Location = new System.Drawing.Point(11, 13);
            this.GrpActions.Name = "GrpActions";
            this.GrpActions.Size = new System.Drawing.Size(97, 196);
            this.GrpActions.TabIndex = 28;
            this.GrpActions.TabStop = false;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(8, 37);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(83, 35);
            this.BtnSave.TabIndex = 9;
            this.BtnSave.Text = "Enregistrer";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(8, 155);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(83, 35);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.Text = "Fermer";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // LblTitre
            // 
            this.LblTitre.AutoSize = true;
            this.LblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitre.Location = new System.Drawing.Point(126, 13);
            this.LblTitre.Name = "LblTitre";
            this.LblTitre.Size = new System.Drawing.Size(368, 24);
            this.LblTitre.TabIndex = 27;
            this.LblTitre.Text = "Chapitre - Fiche Equipement - Détail : ";
            // 
            // SFD
            // 
            this.SFD.Filter = "Tous les fichiers Excel (*.xlsx) |*.xlsx";
            // 
            // ChkActif
            // 
            this.ChkActif.AutoSize = true;
            this.ChkActif.Checked = true;
            this.ChkActif.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkActif.Location = new System.Drawing.Point(272, 150);
            this.ChkActif.Name = "ChkActif";
            this.ChkActif.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ChkActif.Size = new System.Drawing.Size(15, 14);
            this.ChkActif.TabIndex = 31;
            this.ChkActif.UseVisualStyleBackColor = true;
            this.ChkActif.CheckedChanged += new System.EventHandler(this.ChkActif_CheckedChanged);
            // 
            // LblNomFiche
            // 
            this.LblNomFiche.AutoSize = true;
            this.LblNomFiche.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNomFiche.Location = new System.Drawing.Point(127, 104);
            this.LblNomFiche.Name = "LblNomFiche";
            this.LblNomFiche.Size = new System.Drawing.Size(138, 16);
            this.LblNomFiche.TabIndex = 32;
            this.LblNomFiche.Text = "Libellé de la fiche :";
            // 
            // txtNomChapitre
            // 
            this.txtNomChapitre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomChapitre.Location = new System.Drawing.Point(272, 103);
            this.txtNomChapitre.Name = "txtNomChapitre";
            this.txtNomChapitre.Size = new System.Drawing.Size(450, 20);
            this.txtNomChapitre.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 16);
            this.label1.TabIndex = 35;
            this.label1.Text = "Ordre affichage :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(143, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "Actif :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtNumOrdreAffichage
            // 
            this.TxtNumOrdreAffichage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNumOrdreAffichage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumOrdreAffichage.Location = new System.Drawing.Point(272, 65);
            this.TxtNumOrdreAffichage.Name = "TxtNumOrdreAffichage";
            this.TxtNumOrdreAffichage.ReadOnly = true;
            this.TxtNumOrdreAffichage.Size = new System.Drawing.Size(137, 20);
            this.TxtNumOrdreAffichage.TabIndex = 37;
            this.TxtNumOrdreAffichage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmMethodes_Admin_Equipement_Fiche_Chap_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 221);
            this.Controls.Add(this.TxtNumOrdreAffichage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomChapitre);
            this.Controls.Add(this.LblNomFiche);
            this.Controls.Add(this.ChkActif);
            this.Controls.Add(this.GrpActions);
            this.Controls.Add(this.LblTitre);
            this.Name = "frmMethodes_Admin_Equipement_Fiche_Chap_Detail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chapitre - Fiche Equipement - Détail : ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMethodes_Admin_Equipement_Fiche_Load);
            this.GrpActions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox GrpActions;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label LblTitre;
        private System.Windows.Forms.SaveFileDialog SFD;
        private System.Windows.Forms.CheckBox ChkActif;
        private System.Windows.Forms.Label LblNomFiche;
        private System.Windows.Forms.TextBox txtNomChapitre;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNumOrdreAffichage;
    }
}