
namespace MozartCS
{
  partial class frmActionExecPlanif
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
      this.cmdFermer = new MozartUC.apiButton();
      this.cboClient = new MozartUC.apiCombo();
      this.lblClient = new System.Windows.Forms.Label();
      this.LabelTitre = new System.Windows.Forms.Label();
      this.lstMails = new System.Windows.Forms.ListBox();
      this.lblMails = new System.Windows.Forms.Label();
      this.btnAddMail = new System.Windows.Forms.Button();
      this.btnDeleteMail = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // cmdFermer
      // 
      this.cmdFermer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
      this.cmdFermer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.cmdFermer.Location = new System.Drawing.Point(12, 679);
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Size = new System.Drawing.Size(81, 57);
      this.cmdFermer.TabIndex = 8;
      this.cmdFermer.Tag = "15";
      this.cmdFermer.Text = "Fermer";
      this.cmdFermer.UseVisualStyleBackColor = true;
      // 
      // cboClient
      // 
      this.cboClient.Location = new System.Drawing.Point(185, 85);
      this.cboClient.Name = "cboClient";
      this.cboClient.NewValues = false;
      this.cboClient.Size = new System.Drawing.Size(466, 22);
      this.cboClient.TabIndex = 9;
      // 
      // lblClient
      // 
      this.lblClient.AutoSize = true;
      this.lblClient.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
      this.lblClient.Location = new System.Drawing.Point(134, 88);
      this.lblClient.Name = "lblClient";
      this.lblClient.Size = new System.Drawing.Size(45, 15);
      this.lblClient.TabIndex = 10;
      this.lblClient.Text = "Client :";
      // 
      // LabelTitre
      // 
      this.LabelTitre.AutoSize = true;
      this.LabelTitre.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
      this.LabelTitre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.LabelTitre.Location = new System.Drawing.Point(99, 20);
      this.LabelTitre.Name = "LabelTitre";
      this.LabelTitre.Size = new System.Drawing.Size(455, 29);
      this.LabelTitre.TabIndex = 31;
      this.LabelTitre.Text = "Gestion du mail des actions exécutées";
      // 
      // lstMails
      // 
      this.lstMails.FormattingEnabled = true;
      this.lstMails.Location = new System.Drawing.Point(185, 113);
      this.lstMails.Name = "lstMails";
      this.lstMails.Size = new System.Drawing.Size(466, 173);
      this.lstMails.TabIndex = 32;
      // 
      // lblMails
      // 
      this.lblMails.AutoSize = true;
      this.lblMails.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
      this.lblMails.Location = new System.Drawing.Point(134, 113);
      this.lblMails.Name = "lblMails";
      this.lblMails.Size = new System.Drawing.Size(43, 15);
      this.lblMails.TabIndex = 33;
      this.lblMails.Text = "Mails :";
      // 
      // btnAddMail
      // 
      this.btnAddMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnAddMail.Location = new System.Drawing.Point(657, 113);
      this.btnAddMail.Name = "btnAddMail";
      this.btnAddMail.Size = new System.Drawing.Size(29, 31);
      this.btnAddMail.TabIndex = 34;
      this.btnAddMail.Text = "+";
      this.btnAddMail.UseVisualStyleBackColor = true;
      this.btnAddMail.Click += new System.EventHandler(this.btnAddMail_Click);
      // 
      // btnDeleteMail
      // 
      this.btnDeleteMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
      this.btnDeleteMail.Location = new System.Drawing.Point(657, 255);
      this.btnDeleteMail.Name = "btnDeleteMail";
      this.btnDeleteMail.Size = new System.Drawing.Size(29, 31);
      this.btnDeleteMail.TabIndex = 35;
      this.btnDeleteMail.Text = "-";
      this.btnDeleteMail.UseVisualStyleBackColor = true;
      this.btnDeleteMail.Click += new System.EventHandler(this.btnDeleteMail_Click);
      // 
      // frmActionExecPlanif
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      this.ClientSize = new System.Drawing.Size(1226, 748);
      this.Controls.Add(this.btnDeleteMail);
      this.Controls.Add(this.btnAddMail);
      this.Controls.Add(this.lblMails);
      this.Controls.Add(this.lstMails);
      this.Controls.Add(this.LabelTitre);
      this.Controls.Add(this.lblClient);
      this.Controls.Add(this.cboClient);
      this.Controls.Add(this.cmdFermer);
      this.Name = "frmActionExecPlanif";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Gestion des actions exécutées";
      this.Load += new System.EventHandler(this.frmActionExecPlanif_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiCombo cboClient;
    private System.Windows.Forms.Label lblClient;
    internal System.Windows.Forms.Label LabelTitre;
    private System.Windows.Forms.ListBox lstMails;
    private System.Windows.Forms.Label lblMails;
    private System.Windows.Forms.Button btnAddMail;
    private System.Windows.Forms.Button btnDeleteMail;
  }
}