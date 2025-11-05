namespace MozartCS
{
    partial class frmMenuGDM
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
			this.btnSendDoc = new System.Windows.Forms.Button();
			this.Frame3 = new MozartUC.apiGroupBox();
			this.lstDoc = new System.Windows.Forms.CheckedListBox();
			this.apiButton1 = new MozartUC.apiButton();
			this.apiButton2 = new MozartUC.apiButton();
			this.Frame3.SuspendLayout();
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
			this.txtResponse.Size = new System.Drawing.Size(687, 229);
			this.txtResponse.TabIndex = 5;
			this.txtResponse.Visible = false;
			// 
			// lblEmPlusResponse
			// 
			this.lblEmPlusResponse.AutoSize = true;
			this.lblEmPlusResponse.Location = new System.Drawing.Point(12, 185);
			this.lblEmPlusResponse.Name = "lblEmPlusResponse";
			this.lblEmPlusResponse.Size = new System.Drawing.Size(84, 13);
			this.lblEmPlusResponse.TabIndex = 20;
			this.lblEmPlusResponse.Text = "Réponse GDM :";
			this.lblEmPlusResponse.Visible = false;
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.Location = new System.Drawing.Point(614, 12);
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
			this.btnSendNote.Location = new System.Drawing.Point(12, 66);
			this.btnSendNote.Name = "btnSendNote";
			this.btnSendNote.Size = new System.Drawing.Size(95, 45);
			this.btnSendNote.TabIndex = 25;
			this.btnSendNote.Text = "Envoi \r\ndes informations";
			this.btnSendNote.UseVisualStyleBackColor = true;
			this.btnSendNote.Click += new System.EventHandler(this.btnSendNote_Click);
			// 
			// btnSendDoc
			// 
			this.btnSendDoc.Location = new System.Drawing.Point(346, 17);
			this.btnSendDoc.Name = "btnSendDoc";
			this.btnSendDoc.Size = new System.Drawing.Size(95, 40);
			this.btnSendDoc.TabIndex = 150;
			this.btnSendDoc.Text = "Envoi \r\ndocuments client";
			this.btnSendDoc.UseVisualStyleBackColor = true;
			this.btnSendDoc.Visible = false;
			this.btnSendDoc.Click += new System.EventHandler(this.btnSendDoc_Click);
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
			this.Frame3.Location = new System.Drawing.Point(132, 66);
			this.Frame3.Name = "Frame3";
			this.Frame3.Size = new System.Drawing.Size(437, 284);
			this.Frame3.TabIndex = 149;
			this.Frame3.TabStop = false;
			this.Frame3.Text = "Cochez les documents du client à envoyer";
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
			this.apiButton1.Visible = false;
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
			this.apiButton2.Visible = false;
			this.apiButton2.Click += new System.EventHandler(this.apiButton2_Click);
			// 
			// frmMenuGDM
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Wheat;
			this.ClientSize = new System.Drawing.Size(726, 462);
			this.Controls.Add(this.Frame3);
			this.Controls.Add(this.btnSendDoc);
			this.Controls.Add(this.btnSendNote);
			this.Controls.Add(this.lblNumTask);
			this.Controls.Add(this.txtNumTask);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.lblEmPlusResponse);
			this.Controls.Add(this.txtResponse);
			this.Name = "frmMenuGDM";
			this.Text = "Menu GDM";
			this.Load += new System.EventHandler(this.frmMenuEmPlus_Load);
			this.Frame3.ResumeLayout(false);
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
    private MozartUC.apiGroupBox Frame3;
    private MozartUC.apiButton apiButton1;
    private MozartUC.apiButton apiButton2;
    private System.Windows.Forms.Button btnSendDoc;
    private System.Windows.Forms.CheckedListBox lstDoc;
	}
}