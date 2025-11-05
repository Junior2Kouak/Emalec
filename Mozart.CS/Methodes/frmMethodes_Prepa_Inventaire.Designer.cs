namespace MozartCS
{
    partial class frmMethodes_Prepa_Inventaire
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
            this.BtnAffectInvSite = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SFD = new System.Windows.Forms.SaveFileDialog();
            this.apiTGrid1 = new MozartUC.apiTGrid();
            this.GrpActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpActions
            // 
            this.GrpActions.Controls.Add(this.BtnAffectInvSite);
            this.GrpActions.Controls.Add(this.button1);
            this.GrpActions.Controls.Add(this.BtnClose);
            this.GrpActions.Location = new System.Drawing.Point(11, 13);
            this.GrpActions.Name = "GrpActions";
            this.GrpActions.Size = new System.Drawing.Size(97, 560);
            this.GrpActions.TabIndex = 28;
            this.GrpActions.TabStop = false;
            // 
            // BtnAffectInvSite
            // 
            this.BtnAffectInvSite.Location = new System.Drawing.Point(6, 152);
            this.BtnAffectInvSite.Name = "BtnAffectInvSite";
            this.BtnAffectInvSite.Size = new System.Drawing.Size(83, 55);
            this.BtnAffectInvSite.TabIndex = 5;
            this.BtnAffectInvSite.Text = "Affectation inventaires / sites";
            this.BtnAffectInvSite.UseVisualStyleBackColor = true;
            this.BtnAffectInvSite.Click += new System.EventHandler(this.BtnAffectInvSite_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 52);
            this.button1.TabIndex = 4;
            this.button1.Text = "Préparer inventaire";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(6, 443);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(83, 35);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.Text = "Fermer";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 24);
            this.label2.TabIndex = 27;
            this.label2.Text = "Liste des clients à inventorier";
            // 
            // SFD
            // 
            this.SFD.Filter = "Tous les fichiers Excel (*.xlsx) |*.xlsx";
            // 
            // apiTGrid1
            // 
            this.apiTGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.apiTGrid1.FilterBar = true;
            this.apiTGrid1.FooterBar = true;
            this.apiTGrid1.Location = new System.Drawing.Point(130, 50);
            this.apiTGrid1.Margin = new System.Windows.Forms.Padding(4);
            this.apiTGrid1.Name = "apiTGrid1";
            this.apiTGrid1.Size = new System.Drawing.Size(1681, 907);
            this.apiTGrid1.TabIndex = 55;
            // 
            // frmMethodes_Prepa_Inventaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1824, 982);
            this.Controls.Add(this.apiTGrid1);
            this.Controls.Add(this.GrpActions);
            this.Controls.Add(this.label2);
            this.Name = "frmMethodes_Prepa_Inventaire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Liste des clients à inventorier";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMethodes_Admin_Equipement_Load);
            this.GrpActions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox GrpActions;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SaveFileDialog SFD;
        private MozartUC.apiTGrid apiTGrid1;
        private System.Windows.Forms.Button BtnAffectInvSite;
        private System.Windows.Forms.Button button1;
    }
}