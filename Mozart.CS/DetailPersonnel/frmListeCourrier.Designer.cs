namespace MozartCS
{
  partial class frmListeCourrier
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListeCourrier));
      this.Command2 = new MozartUC.apiButton();
      this.Label4 = new MozartUC.apiLabel();
      this.frmAide = new MozartUC.apiGroupBox();
      this.Command1 = new MozartUC.apiButton();
      this.cboCritDest = new System.Windows.Forms.ComboBox();
      this.txtCritAuteur = new MozartUC.apiTextBox();
      this.cmdFind = new MozartUC.apiButton();
      this.txtCritRef = new MozartUC.apiTextBox();
      this.txtCritObj = new MozartUC.apiTextBox();
      this.Label8 = new MozartUC.apiLabel();
      this.Label7 = new MozartUC.apiLabel();
      this.Label3 = new MozartUC.apiLabel();
      this.label2 = new MozartUC.apiLabel();
      this.Label5 = new MozartUC.apiLabel();
      this.fraCriteres = new MozartUC.apiGroupBox();
      this.chkAll = new MozartUC.apiCheckBox();
      this.cmdSupprimer = new MozartUC.apiButton();
      this.cmdQuitter = new MozartUC.apiButton();
      this.cmdModifier = new MozartUC.apiButton();
      this.cmdNouvelle = new MozartUC.apiButton();
      this.cmdImprimer = new MozartUC.apiButton();
      this.apiGrid = new MozartUC.apiTGrid();
      this.Label1 = new MozartUC.apiLabel();
      this.frmAide.SuspendLayout();
      this.fraCriteres.SuspendLayout();
      this.SuspendLayout();
      // 
      // Command2
      // 
      resources.ApplyResources(this.Command2, "Command2");
      this.Command2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Command2.HelpContextID = 0;
      this.Command2.Name = "Command2";
      this.Command2.UseVisualStyleBackColor = true;
      this.Command2.Click += new System.EventHandler(this.Command2_Click);
      // 
      // Label4
      // 
      this.Label4.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.Label4, "Label4");
      this.Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Label4.HelpContextID = 0;
      this.Label4.Name = "Label4";
      // 
      // frmAide
      // 
      this.frmAide.Controls.Add(this.Command2);
      this.frmAide.Controls.Add(this.Label4);
      resources.ApplyResources(this.frmAide, "frmAide");
      this.frmAide.HelpContextID = 0;
      this.frmAide.Name = "frmAide";
      this.frmAide.TabStop = false;
      // 
      // Command1
      // 
      resources.ApplyResources(this.Command1, "Command1");
      this.Command1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Command1.HelpContextID = 0;
      this.Command1.Name = "Command1";
      this.Command1.UseVisualStyleBackColor = true;
      this.Command1.Click += new System.EventHandler(this.Command1_Click);
      // 
      // cboCritDest
      // 
      this.cboCritDest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      resources.ApplyResources(this.cboCritDest, "cboCritDest");
      this.cboCritDest.Items.AddRange(new object[] {
            resources.GetString("cboCritDest.Items"),
            resources.GetString("cboCritDest.Items1"),
            resources.GetString("cboCritDest.Items2"),
            resources.GetString("cboCritDest.Items3"),
            resources.GetString("cboCritDest.Items4"),
            resources.GetString("cboCritDest.Items5"),
            resources.GetString("cboCritDest.Items6")});
      this.cboCritDest.Name = "cboCritDest";
      // 
      // txtCritAuteur
      // 
      resources.ApplyResources(this.txtCritAuteur, "txtCritAuteur");
      this.txtCritAuteur.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtCritAuteur.HelpContextID = 0;
      this.txtCritAuteur.Name = "txtCritAuteur";
      // 
      // cmdFind
      // 
      this.cmdFind.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdFind.HelpContextID = 0;
      this.cmdFind.Image = global::MozartCS.Properties.Resources.Find;
      resources.ApplyResources(this.cmdFind, "cmdFind");
      this.cmdFind.Name = "cmdFind";
      this.cmdFind.Tag = "8";
      this.cmdFind.UseVisualStyleBackColor = true;
      this.cmdFind.Click += new System.EventHandler(this.cmdFind_Click);
      // 
      // txtCritRef
      // 
      resources.ApplyResources(this.txtCritRef, "txtCritRef");
      this.txtCritRef.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtCritRef.HelpContextID = 0;
      this.txtCritRef.Name = "txtCritRef";
      // 
      // txtCritObj
      // 
      resources.ApplyResources(this.txtCritObj, "txtCritObj");
      this.txtCritObj.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtCritObj.HelpContextID = 0;
      this.txtCritObj.Name = "txtCritObj";
      // 
      // Label8
      // 
      resources.ApplyResources(this.Label8, "Label8");
      this.Label8.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label8.HelpContextID = 0;
      this.Label8.Name = "Label8";
      // 
      // Label7
      // 
      resources.ApplyResources(this.Label7, "Label7");
      this.Label7.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label7.HelpContextID = 0;
      this.Label7.Name = "Label7";
      // 
      // Label3
      // 
      this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label3.HelpContextID = 0;
      resources.ApplyResources(this.Label3, "Label3");
      this.Label3.Name = "Label3";
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
      resources.ApplyResources(this.fraCriteres, "fraCriteres");
      this.fraCriteres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(218)))), ((int)(((byte)(242)))));
      this.fraCriteres.Controls.Add(this.Command1);
      this.fraCriteres.Controls.Add(this.cboCritDest);
      this.fraCriteres.Controls.Add(this.txtCritAuteur);
      this.fraCriteres.Controls.Add(this.cmdFind);
      this.fraCriteres.Controls.Add(this.txtCritRef);
      this.fraCriteres.Controls.Add(this.txtCritObj);
      this.fraCriteres.Controls.Add(this.Label8);
      this.fraCriteres.Controls.Add(this.Label7);
      this.fraCriteres.Controls.Add(this.Label3);
      this.fraCriteres.Controls.Add(this.label2);
      this.fraCriteres.Controls.Add(this.Label5);
      this.fraCriteres.HelpContextID = 0;
      this.fraCriteres.Name = "fraCriteres";
      this.fraCriteres.TabStop = false;
      // 
      // chkAll
      // 
      this.chkAll.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.chkAll, "chkAll");
      this.chkAll.ForeColor = System.Drawing.SystemColors.ControlText;
      this.chkAll.HelpContextID = 0;
      this.chkAll.Name = "chkAll";
      this.chkAll.UseVisualStyleBackColor = false;
      // 
      // cmdSupprimer
      // 
      resources.ApplyResources(this.cmdSupprimer, "cmdSupprimer");
      this.cmdSupprimer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdSupprimer.HelpContextID = 299;
      this.cmdSupprimer.Name = "cmdSupprimer";
      this.cmdSupprimer.Tag = "27";
      this.cmdSupprimer.UseVisualStyleBackColor = true;
      this.cmdSupprimer.Click += new System.EventHandler(this.cmdSupprimer_Click);
      // 
      // cmdQuitter
      // 
      resources.ApplyResources(this.cmdQuitter, "cmdQuitter");
      this.cmdQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdQuitter.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdQuitter.HelpContextID = 0;
      this.cmdQuitter.Name = "cmdQuitter";
      this.cmdQuitter.Tag = "15";
      this.cmdQuitter.UseVisualStyleBackColor = true;
      this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
      // 
      // cmdModifier
      // 
      resources.ApplyResources(this.cmdModifier, "cmdModifier");
      this.cmdModifier.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdModifier.HelpContextID = 642;
      this.cmdModifier.Name = "cmdModifier";
      this.cmdModifier.Tag = "19";
      this.cmdModifier.UseVisualStyleBackColor = true;
      this.cmdModifier.Click += new System.EventHandler(this.cmdModifier_Click);
      // 
      // cmdNouvelle
      // 
      resources.ApplyResources(this.cmdNouvelle, "cmdNouvelle");
      this.cmdNouvelle.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdNouvelle.HelpContextID = 0;
      this.cmdNouvelle.Name = "cmdNouvelle";
      this.cmdNouvelle.Tag = "2";
      this.cmdNouvelle.UseVisualStyleBackColor = true;
      this.cmdNouvelle.Click += new System.EventHandler(this.cmdNouvelle_Click);
      // 
      // cmdImprimer
      // 
      resources.ApplyResources(this.cmdImprimer, "cmdImprimer");
      this.cmdImprimer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdImprimer.HelpContextID = 0;
      this.cmdImprimer.Name = "cmdImprimer";
      this.cmdImprimer.Tag = "17";
      this.cmdImprimer.UseVisualStyleBackColor = true;
      this.cmdImprimer.Click += new System.EventHandler(this.cmdImprimer_Click);
      // 
      // apiGrid
      // 
      resources.ApplyResources(this.apiGrid, "apiGrid");
      this.apiGrid.FilterBar = true;
      this.apiGrid.FooterBar = true;
      this.apiGrid.Name = "apiGrid";
      this.apiGrid.DoubleClickE += new MozartUC.apiTGrid.DoubleClickEEventHandler(this.apiGrid_DoubleClickE);
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // frmListeCourrier
      // 
      this.AcceptButton = this.cmdFind;
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdQuitter;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.frmAide);
      this.Controls.Add(this.fraCriteres);
      this.Controls.Add(this.chkAll);
      this.Controls.Add(this.cmdSupprimer);
      this.Controls.Add(this.cmdQuitter);
      this.Controls.Add(this.cmdModifier);
      this.Controls.Add(this.cmdNouvelle);
      this.Controls.Add(this.cmdImprimer);
      this.Controls.Add(this.apiGrid);
      this.Controls.Add(this.Label1);
      this.KeyPreview = true;
      this.Name = "frmListeCourrier";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmListeCourrier_Load);
      this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form_KeyUp);
      this.frmAide.ResumeLayout(false);
      this.fraCriteres.ResumeLayout(false);
      this.fraCriteres.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton Command2;
    private MozartUC.apiLabel Label4;
    private MozartUC.apiGroupBox frmAide;
    private MozartUC.apiButton Command1;
    private System.Windows.Forms.ComboBox cboCritDest;
    private MozartUC.apiTextBox txtCritAuteur;
    private MozartUC.apiButton cmdFind;
    private MozartUC.apiTextBox txtCritRef;
    private MozartUC.apiTextBox txtCritObj;
    private MozartUC.apiLabel Label8;
    private MozartUC.apiLabel Label7;
    private MozartUC.apiLabel Label3;
    private MozartUC.apiLabel label2;
    private MozartUC.apiLabel Label5;
    private MozartUC.apiGroupBox fraCriteres;
    private MozartUC.apiCheckBox chkAll;
    private MozartUC.apiButton cmdSupprimer;
    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiButton cmdModifier;
    private MozartUC.apiButton cmdNouvelle;
    private MozartUC.apiButton cmdImprimer;
    private MozartUC.apiTGrid apiGrid;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    private MozartUC.apiLabel Label1;

  }
}
