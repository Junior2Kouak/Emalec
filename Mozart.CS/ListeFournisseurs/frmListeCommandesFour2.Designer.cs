namespace MozartCS
{
  partial class frmListeCommandesFour2
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListeCommandesFour2));
      this.cmdDI = new MozartUC.apiButton();
      this.Cal = new System.Windows.Forms.DateTimePicker();
      this.cmdCloseFrame = new MozartUC.apiButton();
      this.Label9 = new MozartUC.apiLabel();
      this.Label7 = new MozartUC.apiLabel();
      this.Label6 = new MozartUC.apiLabel();
      this.Label8 = new MozartUC.apiLabel();
      this.Label24 = new MozartUC.apiLabel();
      this.Label25 = new MozartUC.apiLabel();
      this.frameLegende = new MozartUC.apiGroupBox();
      this.cmdLegende = new MozartUC.apiButton();
      this.cmdRestaurer = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.cmdSupprimer = new MozartUC.apiButton();
      this.cmdModifier = new MozartUC.apiButton();
      this.cmdNouveau = new MozartUC.apiButton();
      this.cmdVisu = new MozartUC.apiButton();
      this.cmdListeBL = new MozartUC.apiButton();
      this.apiTGrid = new MozartUC.apiTGrid();
      this.cmdDate1 = new MozartUC.apiButton();
      this.cmdDate0 = new MozartUC.apiButton();
      this.txtCritDate1 = new MozartUC.apiTextBox();
      this.txtCritDate0 = new MozartUC.apiTextBox();
      this.txtCritNumCde = new MozartUC.apiTextBox();
      this.txtCritNumDi = new MozartUC.apiTextBox();
      this.cmdFind = new MozartUC.apiButton();
      this.Label10 = new MozartUC.apiLabel();
      this.lblDateAu = new MozartUC.apiLabel();
      this.Label3 = new MozartUC.apiLabel();
      this.label2 = new MozartUC.apiLabel();
      this.Label4 = new MozartUC.apiLabel();
      this.lblPeriode = new MozartUC.apiLabel();
      this.Label5 = new MozartUC.apiLabel();
      this.fraCriteres = new MozartUC.apiGroupBox();
      this.txtCritFourn = new MozartUC.apiCombo();
      this.txtCritClient = new MozartUC.apiCombo();
      this.Label1 = new MozartUC.apiLabel();
      this.frameLegende.SuspendLayout();
      this.fraCriteres.SuspendLayout();
      this.SuspendLayout();
      // 
      // cmdDI
      // 
      resources.ApplyResources(this.cmdDI, "cmdDI");
      this.cmdDI.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdDI.HelpContextID = 0;
      this.cmdDI.Name = "cmdDI";
      this.cmdDI.Tag = "19";
      this.cmdDI.UseVisualStyleBackColor = true;
      this.cmdDI.Click += new System.EventHandler(this.cmdDI_Click);
      // 
      // Cal
      // 
      this.Cal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(132)))));
      this.Cal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      resources.ApplyResources(this.Cal, "Cal");
      this.Cal.Name = "Cal";
      this.Cal.CloseUp += new System.EventHandler(this.Cal_CloseUp);
      this.Cal.ValueChanged += new System.EventHandler(this.Cal_ValueChanged);
      // 
      // cmdCloseFrame
      // 
      this.cmdCloseFrame.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdCloseFrame.HelpContextID = 0;
      resources.ApplyResources(this.cmdCloseFrame, "cmdCloseFrame");
      this.cmdCloseFrame.Name = "cmdCloseFrame";
      this.cmdCloseFrame.UseVisualStyleBackColor = true;
      this.cmdCloseFrame.Click += new System.EventHandler(this.cmdCloseFrame_Click);
      // 
      // Label9
      // 
      resources.ApplyResources(this.Label9, "Label9");
      this.Label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.Label9.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label9.HelpContextID = 0;
      this.Label9.Name = "Label9";
      // 
      // Label7
      // 
      this.Label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.Label7.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label7.HelpContextID = 0;
      resources.ApplyResources(this.Label7, "Label7");
      this.Label7.Name = "Label7";
      // 
      // Label6
      // 
      this.Label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
      this.Label6.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label6.HelpContextID = 0;
      resources.ApplyResources(this.Label6, "Label6");
      this.Label6.Name = "Label6";
      // 
      // Label8
      // 
      this.Label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
      this.Label8.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label8.HelpContextID = 0;
      resources.ApplyResources(this.Label8, "Label8");
      this.Label8.Name = "Label8";
      // 
      // Label24
      // 
      resources.ApplyResources(this.Label24, "Label24");
      this.Label24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.Label24.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label24.HelpContextID = 0;
      this.Label24.Name = "Label24";
      // 
      // Label25
      // 
      resources.ApplyResources(this.Label25, "Label25");
      this.Label25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.Label25.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label25.HelpContextID = 0;
      this.Label25.Name = "Label25";
      // 
      // frameLegende
      // 
      this.frameLegende.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.frameLegende.Controls.Add(this.cmdCloseFrame);
      this.frameLegende.Controls.Add(this.Label9);
      this.frameLegende.Controls.Add(this.Label7);
      this.frameLegende.Controls.Add(this.Label6);
      this.frameLegende.Controls.Add(this.Label8);
      this.frameLegende.Controls.Add(this.Label24);
      this.frameLegende.Controls.Add(this.Label25);
      resources.ApplyResources(this.frameLegende, "frameLegende");
      this.frameLegende.HelpContextID = 0;
      this.frameLegende.Name = "frameLegende";
      this.frameLegende.TabStop = false;
      // 
      // cmdLegende
      // 
      resources.ApplyResources(this.cmdLegende, "cmdLegende");
      this.cmdLegende.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdLegende.HelpContextID = 0;
      this.cmdLegende.Name = "cmdLegende";
      this.cmdLegende.UseVisualStyleBackColor = true;
      this.cmdLegende.Click += new System.EventHandler(this.cmdLegende_Click);
      // 
      // cmdRestaurer
      // 
      resources.ApplyResources(this.cmdRestaurer, "cmdRestaurer");
      this.cmdRestaurer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdRestaurer.HelpContextID = 0;
      this.cmdRestaurer.Name = "cmdRestaurer";
      this.cmdRestaurer.Tag = "66";
      this.cmdRestaurer.UseVisualStyleBackColor = true;
      this.cmdRestaurer.Click += new System.EventHandler(this.cmdRestaurer_Click);
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdFermer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Tag = "15";
      this.cmdFermer.UseVisualStyleBackColor = true;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // cmdSupprimer
      // 
      resources.ApplyResources(this.cmdSupprimer, "cmdSupprimer");
      this.cmdSupprimer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdSupprimer.HelpContextID = 0;
      this.cmdSupprimer.Name = "cmdSupprimer";
      this.cmdSupprimer.Tag = "27";
      this.cmdSupprimer.UseVisualStyleBackColor = true;
      this.cmdSupprimer.Click += new System.EventHandler(this.cmdSupprimer_Click);
      // 
      // cmdModifier
      // 
      resources.ApplyResources(this.cmdModifier, "cmdModifier");
      this.cmdModifier.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdModifier.HelpContextID = 0;
      this.cmdModifier.Name = "cmdModifier";
      this.cmdModifier.Tag = "19";
      this.cmdModifier.UseVisualStyleBackColor = true;
      this.cmdModifier.Click += new System.EventHandler(this.cmdModifier_Click);
      // 
      // cmdNouveau
      // 
      resources.ApplyResources(this.cmdNouveau, "cmdNouveau");
      this.cmdNouveau.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdNouveau.HelpContextID = 0;
      this.cmdNouveau.Name = "cmdNouveau";
      this.cmdNouveau.Tag = "2";
      this.cmdNouveau.UseVisualStyleBackColor = true;
      this.cmdNouveau.Click += new System.EventHandler(this.cmdNouveau_Click);
      // 
      // cmdVisu
      // 
      resources.ApplyResources(this.cmdVisu, "cmdVisu");
      this.cmdVisu.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdVisu.HelpContextID = 0;
      this.cmdVisu.Name = "cmdVisu";
      this.cmdVisu.Tag = "4";
      this.cmdVisu.UseVisualStyleBackColor = true;
      this.cmdVisu.Click += new System.EventHandler(this.cmdVisu_Click);
      // 
      // cmdListeBL
      // 
      resources.ApplyResources(this.cmdListeBL, "cmdListeBL");
      this.cmdListeBL.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdListeBL.HelpContextID = 0;
      this.cmdListeBL.Name = "cmdListeBL";
      this.cmdListeBL.Tag = "109";
      this.cmdListeBL.UseVisualStyleBackColor = true;
      this.cmdListeBL.Click += new System.EventHandler(this.cmdListeBL_Click);
      // 
      // apiTGrid
      // 
      resources.ApplyResources(this.apiTGrid, "apiTGrid");
      this.apiTGrid.FilterBar = true;
      this.apiTGrid.FooterBar = true;
      this.apiTGrid.Name = "apiTGrid";
      this.apiTGrid.DoubleClickE += new MozartUC.apiTGrid.DoubleClickEEventHandler(this.apiTGrid_DoubleClickE);
      this.apiTGrid.RowCellStyle += new MozartUC.apiTGrid.RowCellStyleEventHandler(this.apiTGrid_RowCellStyle);
      this.apiTGrid.RowStyle += new MozartUC.apiTGrid.RowStyleEventHandler(this.apiTGrid_RowStyle);
      // 
      // cmdDate1
      // 
      this.cmdDate1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      resources.ApplyResources(this.cmdDate1, "cmdDate1");
      this.cmdDate1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdDate1.HelpContextID = 0;
      this.cmdDate1.Image = global::MozartCS.Properties.Resources.calendar;
      this.cmdDate1.Name = "cmdDate1";
      this.cmdDate1.Tag = "5";
      this.cmdDate1.UseVisualStyleBackColor = false;
      this.cmdDate1.Click += new System.EventHandler(this.CmdDate_Click);
      // 
      // cmdDate0
      // 
      this.cmdDate0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      resources.ApplyResources(this.cmdDate0, "cmdDate0");
      this.cmdDate0.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdDate0.HelpContextID = 0;
      this.cmdDate0.Image = global::MozartCS.Properties.Resources.calendar;
      this.cmdDate0.Name = "cmdDate0";
      this.cmdDate0.Tag = "5";
      this.cmdDate0.UseVisualStyleBackColor = false;
      this.cmdDate0.Click += new System.EventHandler(this.CmdDate_Click);
      // 
      // txtCritDate1
      // 
      resources.ApplyResources(this.txtCritDate1, "txtCritDate1");
      this.txtCritDate1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtCritDate1.HelpContextID = 0;
      this.txtCritDate1.Name = "txtCritDate1";
      // 
      // txtCritDate0
      // 
      resources.ApplyResources(this.txtCritDate0, "txtCritDate0");
      this.txtCritDate0.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtCritDate0.HelpContextID = 0;
      this.txtCritDate0.Name = "txtCritDate0";
      // 
      // txtCritNumCde
      // 
      resources.ApplyResources(this.txtCritNumCde, "txtCritNumCde");
      this.txtCritNumCde.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtCritNumCde.HelpContextID = 0;
      this.txtCritNumCde.Name = "txtCritNumCde";
      this.txtCritNumCde.Enter += new System.EventHandler(this.txtCritNumCde_Enter);
      this.txtCritNumCde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCritNumCde_KeyPress);
      // 
      // txtCritNumDi
      // 
      resources.ApplyResources(this.txtCritNumDi, "txtCritNumDi");
      this.txtCritNumDi.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtCritNumDi.HelpContextID = 0;
      this.txtCritNumDi.Name = "txtCritNumDi";
      this.txtCritNumDi.Enter += new System.EventHandler(this.txtCritNumDi_Enter);
      this.txtCritNumDi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCritNumDi_KeyPress);
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
      // Label10
      // 
      resources.ApplyResources(this.Label10, "Label10");
      this.Label10.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label10.HelpContextID = 0;
      this.Label10.Name = "Label10";
      // 
      // lblDateAu
      // 
      resources.ApplyResources(this.lblDateAu, "lblDateAu");
      this.lblDateAu.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblDateAu.HelpContextID = 0;
      this.lblDateAu.Name = "lblDateAu";
      // 
      // Label3
      // 
      resources.ApplyResources(this.Label3, "Label3");
      this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label3.HelpContextID = 0;
      this.Label3.Name = "Label3";
      // 
      // label2
      // 
      resources.ApplyResources(this.label2, "label2");
      this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.label2.HelpContextID = 0;
      this.label2.Name = "label2";
      // 
      // Label4
      // 
      resources.ApplyResources(this.Label4, "Label4");
      this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label4.HelpContextID = 0;
      this.Label4.Name = "Label4";
      // 
      // lblPeriode
      // 
      resources.ApplyResources(this.lblPeriode, "lblPeriode");
      this.lblPeriode.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblPeriode.HelpContextID = 0;
      this.lblPeriode.Name = "lblPeriode";
      // 
      // Label5
      // 
      this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label5.HelpContextID = 0;
      resources.ApplyResources(this.Label5, "Label5");
      this.Label5.Name = "Label5";
      // 
      // fraCriteres
      // 
      resources.ApplyResources(this.fraCriteres, "fraCriteres");
      this.fraCriteres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(218)))), ((int)(((byte)(242)))));
      this.fraCriteres.Controls.Add(this.txtCritFourn);
      this.fraCriteres.Controls.Add(this.txtCritClient);
      this.fraCriteres.Controls.Add(this.cmdDate1);
      this.fraCriteres.Controls.Add(this.cmdDate0);
      this.fraCriteres.Controls.Add(this.txtCritDate1);
      this.fraCriteres.Controls.Add(this.txtCritDate0);
      this.fraCriteres.Controls.Add(this.txtCritNumCde);
      this.fraCriteres.Controls.Add(this.txtCritNumDi);
      this.fraCriteres.Controls.Add(this.cmdFind);
      this.fraCriteres.Controls.Add(this.Label10);
      this.fraCriteres.Controls.Add(this.lblDateAu);
      this.fraCriteres.Controls.Add(this.Label3);
      this.fraCriteres.Controls.Add(this.label2);
      this.fraCriteres.Controls.Add(this.Label4);
      this.fraCriteres.Controls.Add(this.lblPeriode);
      this.fraCriteres.Controls.Add(this.Label5);
      this.fraCriteres.HelpContextID = 0;
      this.fraCriteres.Name = "fraCriteres";
      this.fraCriteres.TabStop = false;
      // 
      // txtCritFourn
      // 
      resources.ApplyResources(this.txtCritFourn, "txtCritFourn");
      this.txtCritFourn.Name = "txtCritFourn";
      // 
      // txtCritClient
      // 
      resources.ApplyResources(this.txtCritClient, "txtCritClient");
      this.txtCritClient.Name = "txtCritClient";
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // frmListeCommandesFour2
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdDI);
      this.Controls.Add(this.Cal);
      this.Controls.Add(this.frameLegende);
      this.Controls.Add(this.cmdLegende);
      this.Controls.Add(this.cmdRestaurer);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.cmdSupprimer);
      this.Controls.Add(this.cmdModifier);
      this.Controls.Add(this.cmdNouveau);
      this.Controls.Add(this.cmdVisu);
      this.Controls.Add(this.cmdListeBL);
      this.Controls.Add(this.apiTGrid);
      this.Controls.Add(this.fraCriteres);
      this.Controls.Add(this.Label1);
      this.KeyPreview = true;
      this.Name = "frmListeCommandesFour2";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmListeCommandesFour2_Load);
      this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmListeCommandesFour2_KeyUp);
      this.frameLegende.ResumeLayout(false);
      this.frameLegende.PerformLayout();
      this.fraCriteres.ResumeLayout(false);
      this.fraCriteres.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdDI;
    private System.Windows.Forms.DateTimePicker Cal;
    private MozartUC.apiButton cmdCloseFrame;
    private MozartUC.apiLabel Label9;
    private MozartUC.apiLabel Label7;
    private MozartUC.apiLabel Label6;
    private MozartUC.apiLabel Label8;
    private MozartUC.apiLabel Label24;
    private MozartUC.apiLabel Label25;
    private MozartUC.apiGroupBox frameLegende;
    private MozartUC.apiButton cmdLegende;
    private MozartUC.apiButton cmdRestaurer;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiButton cmdSupprimer;
    private MozartUC.apiButton cmdModifier;
    private MozartUC.apiButton cmdNouveau;
    private MozartUC.apiButton cmdVisu;
    private MozartUC.apiButton cmdListeBL;
    private MozartUC.apiTGrid apiTGrid;
    private MozartUC.apiButton cmdDate1;
    private MozartUC.apiButton cmdDate0;
    private MozartUC.apiTextBox txtCritDate1;
    private MozartUC.apiTextBox txtCritDate0;
    private MozartUC.apiTextBox txtCritNumCde;
    private MozartUC.apiTextBox txtCritNumDi;
    private MozartUC.apiButton cmdFind;
    private MozartUC.apiLabel Label10;
    private MozartUC.apiLabel lblDateAu;
    private MozartUC.apiLabel Label3;
    private MozartUC.apiLabel label2;
    private MozartUC.apiLabel Label4;
    private MozartUC.apiLabel lblPeriode;
    private MozartUC.apiLabel Label5;
    private MozartUC.apiGroupBox fraCriteres;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    private MozartUC.apiLabel Label1;
    private MozartUC.apiCombo txtCritFourn;
    private MozartUC.apiCombo txtCritClient;
  }
}
