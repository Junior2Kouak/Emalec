namespace MozartCS
{
  partial class frmListeDocuments
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListeDocuments));
      this.apicboCritClient = new MozartUC.apiCombo();
      this.cmdModifier = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.cmdSupprimer = new MozartUC.apiButton();
      this.txtCritNature = new MozartUC.apiTextBox();
      this.cmdFind = new MozartUC.apiButton();
      this.txtCritType = new MozartUC.apiTextBox();
      this.txtCritNumDI = new MozartUC.apiTextBox();
      this.Label3 = new MozartUC.apiLabel();
      this.lblDateAu = new MozartUC.apiLabel();
      this.Label4 = new MozartUC.apiLabel();
      this.label2 = new MozartUC.apiLabel();
      this.Label5 = new MozartUC.apiLabel();
      this.fraCriteres = new MozartUC.apiGroupBox();
      this.cmdDI = new MozartUC.apiButton();
      this.Grid = new MozartUC.apiTGrid();
      this.Label1 = new MozartUC.apiLabel();
      this.fraCriteres.SuspendLayout();
      this.SuspendLayout();
      // 
      // apicboCritClient
      // 
      resources.ApplyResources(this.apicboCritClient, "apicboCritClient");
      this.apicboCritClient.Name = "apicboCritClient";
      this.apicboCritClient.Enter += new System.EventHandler(this.txtCritClient_Enter);
      // 
      // cmdModifier
      // 
      resources.ApplyResources(this.cmdModifier, "cmdModifier");
      this.cmdModifier.HelpContextID = 0;
      this.cmdModifier.Name = "cmdModifier";
      this.cmdModifier.Tag = "19";
      this.cmdModifier.UseVisualStyleBackColor = true;
      this.cmdModifier.Click += new System.EventHandler(this.cmdModifier_Click);
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Tag = "15";
      this.cmdFermer.UseVisualStyleBackColor = true;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // cmdSupprimer
      // 
      resources.ApplyResources(this.cmdSupprimer, "cmdSupprimer");
      this.cmdSupprimer.HelpContextID = 0;
      this.cmdSupprimer.Name = "cmdSupprimer";
      this.cmdSupprimer.Tag = "27";
      this.cmdSupprimer.UseVisualStyleBackColor = true;
      this.cmdSupprimer.Click += new System.EventHandler(this.cmdSupprimer_Click);
      // 
      // txtCritNature
      // 
      resources.ApplyResources(this.txtCritNature, "txtCritNature");
      this.txtCritNature.HelpContextID = 0;
      this.txtCritNature.Name = "txtCritNature";
      this.txtCritNature.Enter += new System.EventHandler(this.txtCritNature_Enter);
      // 
      // cmdFind
      // 
      this.cmdFind.HelpContextID = 0;
      this.cmdFind.Image = global::MozartCS.Properties.Resources.Find;
      resources.ApplyResources(this.cmdFind, "cmdFind");
      this.cmdFind.Name = "cmdFind";
      this.cmdFind.Tag = "8";
      this.cmdFind.UseVisualStyleBackColor = true;
      this.cmdFind.Click += new System.EventHandler(this.cmdFind_Click);
      // 
      // txtCritType
      // 
      resources.ApplyResources(this.txtCritType, "txtCritType");
      this.txtCritType.HelpContextID = 0;
      this.txtCritType.Name = "txtCritType";
      // 
      // txtCritNumDI
      // 
      resources.ApplyResources(this.txtCritNumDI, "txtCritNumDI");
      this.txtCritNumDI.HelpContextID = 0;
      this.txtCritNumDI.Name = "txtCritNumDI";
      this.txtCritNumDI.Enter += new System.EventHandler(this.txtCritNumDI_Enter);
      // 
      // Label3
      // 
      this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label3.HelpContextID = 0;
      resources.ApplyResources(this.Label3, "Label3");
      this.Label3.Name = "Label3";
      // 
      // lblDateAu
      // 
      resources.ApplyResources(this.lblDateAu, "lblDateAu");
      this.lblDateAu.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblDateAu.HelpContextID = 0;
      this.lblDateAu.Name = "lblDateAu";
      // 
      // Label4
      // 
      resources.ApplyResources(this.Label4, "Label4");
      this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label4.HelpContextID = 0;
      this.Label4.Name = "Label4";
      // 
      // label2
      // 
      resources.ApplyResources(this.label2, "label2");
      this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.label2.HelpContextID = 0;
      this.label2.Name = "label2";
      // 
      // Label5
      // 
      resources.ApplyResources(this.Label5, "Label5");
      this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label5.HelpContextID = 0;
      this.Label5.Name = "Label5";
      // 
      // fraCriteres
      // 
      this.fraCriteres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(218)))), ((int)(((byte)(242)))));
      this.fraCriteres.Controls.Add(this.txtCritNature);
      this.fraCriteres.Controls.Add(this.cmdFind);
      this.fraCriteres.Controls.Add(this.txtCritType);
      this.fraCriteres.Controls.Add(this.txtCritNumDI);
      this.fraCriteres.Controls.Add(this.Label3);
      this.fraCriteres.Controls.Add(this.lblDateAu);
      this.fraCriteres.Controls.Add(this.Label4);
      this.fraCriteres.Controls.Add(this.label2);
      this.fraCriteres.Controls.Add(this.Label5);
      this.fraCriteres.HelpContextID = 0;
      resources.ApplyResources(this.fraCriteres, "fraCriteres");
      this.fraCriteres.Name = "fraCriteres";
      this.fraCriteres.TabStop = false;
      // 
      // cmdDI
      // 
      resources.ApplyResources(this.cmdDI, "cmdDI");
      this.cmdDI.HelpContextID = 0;
      this.cmdDI.Name = "cmdDI";
      this.cmdDI.Tag = "54";
      this.cmdDI.UseVisualStyleBackColor = true;
      this.cmdDI.Click += new System.EventHandler(this.cmdDI_Click);
      // 
      // Grid
      // 
      resources.ApplyResources(this.Grid, "Grid");
      this.Grid.FilterBar = true;
      this.Grid.FooterBar = true;
      this.Grid.Name = "Grid";
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // frmListeDocuments
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.apicboCritClient);
      this.Controls.Add(this.cmdModifier);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.cmdSupprimer);
      this.Controls.Add(this.fraCriteres);
      this.Controls.Add(this.cmdDI);
      this.Controls.Add(this.Grid);
      this.Controls.Add(this.Label1);
      this.KeyPreview = true;
      this.Name = "frmListeDocuments";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmListeDocuments_Load);
      this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmListeDocuments_KeyUp);
      this.fraCriteres.ResumeLayout(false);
      this.fraCriteres.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiCombo apicboCritClient;
    private MozartUC.apiButton cmdModifier;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiButton cmdSupprimer;
    private MozartUC.apiTextBox txtCritNature;
    private MozartUC.apiButton cmdFind;
    private MozartUC.apiTextBox txtCritType;
    private MozartUC.apiTextBox txtCritNumDI;
    private MozartUC.apiLabel Label3;
    private MozartUC.apiLabel lblDateAu;
    private MozartUC.apiLabel Label4;
    private MozartUC.apiLabel label2;
    private MozartUC.apiLabel Label5;
    private MozartUC.apiGroupBox fraCriteres;
    private MozartUC.apiButton cmdDI;
    private MozartUC.apiTGrid Grid;
    private MozartUC.apiLabel Label1;
  }
}
