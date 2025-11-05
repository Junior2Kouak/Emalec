namespace MozartCS
{
    partial class frmMenuPlanon
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
			this.txtResponse = new System.Windows.Forms.TextBox();
			this.lblEmPlusResponse = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.lblNumTask = new System.Windows.Forms.Label();
			this.txtNumTask = new System.Windows.Forms.TextBox();
			this.btnSendNote = new System.Windows.Forms.Button();
			this.btnTerminer = new System.Windows.Forms.Button();
			this.btnSendDoc = new System.Windows.Forms.Button();
			this.btnTest = new System.Windows.Forms.Button();
			this.Frame3 = new MozartUC.apiGroupBox();
			this.lstDoc = new System.Windows.Forms.CheckedListBox();
			this.apiButton1 = new MozartUC.apiButton();
			this.apiButton2 = new MozartUC.apiButton();
			this.FrameNote = new MozartUC.apiGroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cmdAnnule = new MozartUC.apiButton();
			this.cmdValide = new MozartUC.apiButton();
			this.txtNote = new MozartUC.apiTextBox();
			this.btnStatutDA = new System.Windows.Forms.Button();
			this.bntStatutDD = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.btnDevisClient = new System.Windows.Forms.Button();
			this.btnCreation = new System.Windows.Forms.Button();
			this.Frame3.SuspendLayout();
			this.FrameNote.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtResponse
			// 
			this.txtResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtResponse.Location = new System.Drawing.Point(12, 201);
			this.txtResponse.Multiline = true;
			this.txtResponse.Name = "txtResponse";
			this.txtResponse.ReadOnly = true;
			this.txtResponse.Size = new System.Drawing.Size(775, 275);
			this.txtResponse.TabIndex = 5;
			// 
			// lblEmPlusResponse
			// 
			this.lblEmPlusResponse.AutoSize = true;
			this.lblEmPlusResponse.Location = new System.Drawing.Point(12, 185);
			this.lblEmPlusResponse.Name = "lblEmPlusResponse";
			this.lblEmPlusResponse.Size = new System.Drawing.Size(95, 13);
			this.lblEmPlusResponse.TabIndex = 20;
			this.lblEmPlusResponse.Text = "Réponse SamFM :";
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.Location = new System.Drawing.Point(702, 12);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(85, 40);
			this.btnClose.TabIndex = 21;
			this.btnClose.Text = "Fermer";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// lblNumTask
			// 
			this.lblNumTask.AutoSize = true;
			this.lblNumTask.Location = new System.Drawing.Point(12, 12);
			this.lblNumTask.Name = "lblNumTask";
			this.lblNumTask.Size = new System.Drawing.Size(55, 13);
			this.lblNumTask.TabIndex = 24;
			this.lblNumTask.Text = "N° tâche :";
			// 
			// txtNumTask
			// 
			this.txtNumTask.Enabled = false;
			this.txtNumTask.Location = new System.Drawing.Point(12, 28);
			this.txtNumTask.Name = "txtNumTask";
			this.txtNumTask.ReadOnly = true;
			this.txtNumTask.Size = new System.Drawing.Size(153, 20);
			this.txtNumTask.TabIndex = 23;
			// 
			// btnSendNote
			// 
			this.btnSendNote.Location = new System.Drawing.Point(13, 66);
			this.btnSendNote.Name = "btnSendNote";
			this.btnSendNote.Size = new System.Drawing.Size(95, 40);
			this.btnSendNote.TabIndex = 25;
			this.btnSendNote.Text = "Envoi \r\nd\'une note";
			this.btnSendNote.UseVisualStyleBackColor = true;
			this.btnSendNote.Click += new System.EventHandler(this.btnSendNote_Click);
			// 
			// btnTerminer
			// 
			this.btnTerminer.Location = new System.Drawing.Point(523, 66);
			this.btnTerminer.Name = "btnTerminer";
			this.btnTerminer.Size = new System.Drawing.Size(95, 40);
			this.btnTerminer.TabIndex = 148;
			this.btnTerminer.Text = "Envoi \r\nCloture inter";
			this.btnTerminer.UseVisualStyleBackColor = true;
			this.btnTerminer.Click += new System.EventHandler(this.btnTerminer_Click);
			// 
			// btnSendDoc
			// 
			this.btnSendDoc.Location = new System.Drawing.Point(115, 66);
			this.btnSendDoc.Name = "btnSendDoc";
			this.btnSendDoc.Size = new System.Drawing.Size(95, 40);
			this.btnSendDoc.TabIndex = 150;
			this.btnSendDoc.Text = "Envoi \r\ndocuments client";
			this.btnSendDoc.UseVisualStyleBackColor = true;
			this.btnSendDoc.Click += new System.EventHandler(this.btnSendDoc_Click);
			// 
			// btnTest
			// 
			this.btnTest.Location = new System.Drawing.Point(196, 23);
			this.btnTest.Name = "btnTest";
			this.btnTest.Size = new System.Drawing.Size(73, 28);
			this.btnTest.TabIndex = 151;
			this.btnTest.Text = "Test";
			this.btnTest.UseVisualStyleBackColor = true;
			this.btnTest.Visible = false;
			this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
			// 
			// Frame3
			// 
			this.Frame3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.Frame3.Controls.Add(this.lstDoc);
			this.Frame3.Controls.Add(this.apiButton1);
			this.Frame3.Controls.Add(this.apiButton2);
			this.Frame3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
			this.Frame3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.Frame3.FrameColor = System.Drawing.Color.Empty;
			this.Frame3.HelpContextID = 0;
			this.Frame3.Location = new System.Drawing.Point(254, 151);
			this.Frame3.Name = "Frame3";
			this.Frame3.Size = new System.Drawing.Size(437, 284);
			this.Frame3.TabIndex = 149;
			this.Frame3.TabStop = false;
			this.Frame3.Text = "Choix des documents client";
			this.Frame3.Visible = false;
			// 
			// lstDoc
			// 
			this.lstDoc.Location = new System.Drawing.Point(12, 20);
			this.lstDoc.Name = "lstDoc";
			this.lstDoc.Size = new System.Drawing.Size(414, 212);
			this.lstDoc.TabIndex = 152;
			// 
			// apiButton1
			// 
			this.apiButton1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.apiButton1.HelpContextID = 0;
			this.apiButton1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.apiButton1.Location = new System.Drawing.Point(250, 238);
			this.apiButton1.Name = "apiButton1";
			this.apiButton1.Size = new System.Drawing.Size(84, 35);
			this.apiButton1.TabIndex = 151;
			this.apiButton1.Text = "Annuler";
			this.apiButton1.UseVisualStyleBackColor = true;
			this.apiButton1.Click += new System.EventHandler(this.apiButton1_Click);
			// 
			// apiButton2
			// 
			this.apiButton2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.apiButton2.HelpContextID = 0;
			this.apiButton2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.apiButton2.Location = new System.Drawing.Point(342, 238);
			this.apiButton2.Name = "apiButton2";
			this.apiButton2.Size = new System.Drawing.Size(84, 35);
			this.apiButton2.TabIndex = 150;
			this.apiButton2.Text = "Valider";
			this.apiButton2.UseVisualStyleBackColor = true;
			this.apiButton2.Click += new System.EventHandler(this.apiButton2_Click);
			// 
			// FrameNote
			// 
			this.FrameNote.Controls.Add(this.label1);
			this.FrameNote.Controls.Add(this.cmdAnnule);
			this.FrameNote.Controls.Add(this.cmdValide);
			this.FrameNote.Controls.Add(this.txtNote);
			this.FrameNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
			this.FrameNote.FrameColor = System.Drawing.Color.Empty;
			this.FrameNote.HelpContextID = 0;
			this.FrameNote.Location = new System.Drawing.Point(67, 288);
			this.FrameNote.Name = "FrameNote";
			this.FrameNote.Size = new System.Drawing.Size(501, 208);
			this.FrameNote.TabIndex = 147;
			this.FrameNote.TabStop = false;
			this.FrameNote.Visible = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 173);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(238, 15);
			this.label1.TabIndex = 150;
			this.label1.Text = "Saisir une observation pour le client";
			// 
			// cmdAnnule
			// 
			this.cmdAnnule.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdAnnule.HelpContextID = 0;
			this.cmdAnnule.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cmdAnnule.Location = new System.Drawing.Point(316, 169);
			this.cmdAnnule.Name = "cmdAnnule";
			this.cmdAnnule.Size = new System.Drawing.Size(84, 35);
			this.cmdAnnule.TabIndex = 149;
			this.cmdAnnule.Text = "Annuler";
			this.cmdAnnule.UseVisualStyleBackColor = true;
			this.cmdAnnule.Click += new System.EventHandler(this.cmdAnnule_Click);
			// 
			// cmdValide
			// 
			this.cmdValide.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdValide.HelpContextID = 0;
			this.cmdValide.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cmdValide.Location = new System.Drawing.Point(408, 169);
			this.cmdValide.Name = "cmdValide";
			this.cmdValide.Size = new System.Drawing.Size(84, 35);
			this.cmdValide.TabIndex = 148;
			this.cmdValide.Text = "Valider";
			this.cmdValide.UseVisualStyleBackColor = true;
			this.cmdValide.Click += new System.EventHandler(this.cmdValide_Click);
			// 
			// txtNote
			// 
			this.txtNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.txtNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.txtNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.txtNote.HelpContextID = 0;
			this.txtNote.Location = new System.Drawing.Point(8, 8);
			this.txtNote.Multiline = true;
			this.txtNote.Name = "txtNote";
			this.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtNote.Size = new System.Drawing.Size(484, 155);
			this.txtNote.TabIndex = 147;
			// 
			// btnStatutDA
			// 
			this.btnStatutDA.Location = new System.Drawing.Point(217, 66);
			this.btnStatutDA.Name = "btnStatutDA";
			this.btnStatutDA.Size = new System.Drawing.Size(95, 40);
			this.btnStatutDA.TabIndex = 152;
			this.btnStatutDA.Text = "Passage statut Devis à faire";
			this.btnStatutDA.UseVisualStyleBackColor = true;
			this.btnStatutDA.Click += new System.EventHandler(this.btnStatutDA_Click);
			// 
			// bntStatutDD
			// 
			this.bntStatutDD.Location = new System.Drawing.Point(421, 66);
			this.bntStatutDD.Name = "bntStatutDD";
			this.bntStatutDD.Size = new System.Drawing.Size(95, 40);
			this.bntStatutDD.TabIndex = 153;
			this.bntStatutDD.Text = "Passage statut Devis déposé";
			this.bntStatutDD.UseVisualStyleBackColor = true;
			this.bntStatutDD.Click += new System.EventHandler(this.bntStatutDD_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(284, 24);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(73, 28);
			this.button1.TabIndex = 154;
			this.button1.Text = "Test une DI";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Visible = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnDevisClient
			// 
			this.btnDevisClient.Location = new System.Drawing.Point(319, 66);
			this.btnDevisClient.Name = "btnDevisClient";
			this.btnDevisClient.Size = new System.Drawing.Size(95, 40);
			this.btnDevisClient.TabIndex = 155;
			this.btnDevisClient.Text = "Envoi \rDevis client";
			this.btnDevisClient.UseVisualStyleBackColor = true;
			this.btnDevisClient.Click += new System.EventHandler(this.btnDevisClient_Click);
			// 
			// btnCreation
			// 
			this.btnCreation.BackColor = System.Drawing.Color.Orange;
			this.btnCreation.Location = new System.Drawing.Point(641, 66);
			this.btnCreation.Name = "btnCreation";
			this.btnCreation.Size = new System.Drawing.Size(95, 40);
			this.btnCreation.TabIndex = 156;
			this.btnCreation.Text = "Créer la demande";
			this.btnCreation.UseVisualStyleBackColor = false;
			this.btnCreation.Visible = false;
			this.btnCreation.Click += new System.EventHandler(this.btnCreation_Click);
			// 
			// frmMenuPlanon
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Wheat;
			this.ClientSize = new System.Drawing.Size(799, 508);
			this.Controls.Add(this.btnCreation);
			this.Controls.Add(this.btnDevisClient);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.bntStatutDD);
			this.Controls.Add(this.btnStatutDA);
			this.Controls.Add(this.btnTest);
			this.Controls.Add(this.Frame3);
			this.Controls.Add(this.btnSendDoc);
			this.Controls.Add(this.btnTerminer);
			this.Controls.Add(this.FrameNote);
			this.Controls.Add(this.btnSendNote);
			this.Controls.Add(this.lblNumTask);
			this.Controls.Add(this.txtNumTask);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.lblEmPlusResponse);
			this.Controls.Add(this.txtResponse);
			this.Name = "frmMenuPlanon";
			this.Text = "Menu SamFM";
			this.Load += new System.EventHandler(this.frmMenuEmPlus_Load);
			this.Shown += new System.EventHandler(this.frmMenuPlanon_Shown);
			this.Frame3.ResumeLayout(false);
			this.FrameNote.ResumeLayout(false);
			this.FrameNote.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.Label lblEmPlusResponse;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblNumTask;
        private System.Windows.Forms.TextBox txtNumTask;
    private System.Windows.Forms.Button btnSendNote;
    private MozartUC.apiGroupBox FrameNote;
    private MozartUC.apiButton cmdAnnule;
    private MozartUC.apiButton cmdValide;
    private MozartUC.apiTextBox txtNote;
    private System.Windows.Forms.Button btnTerminer;
    private MozartUC.apiGroupBox Frame3;
    private MozartUC.apiButton apiButton1;
    private MozartUC.apiButton apiButton2;
    private System.Windows.Forms.Button btnSendDoc;
    private System.Windows.Forms.CheckedListBox lstDoc;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnTest;
		private System.Windows.Forms.Button btnStatutDA;
		private System.Windows.Forms.Button bntStatutDD;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnDevisClient;
		private System.Windows.Forms.Button btnCreation;
	}
}