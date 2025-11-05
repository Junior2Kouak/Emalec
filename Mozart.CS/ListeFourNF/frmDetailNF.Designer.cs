
namespace MozartCS
{
  partial class frmDetailNF
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetailNF));
      this.Frame2 = new MozartUC.apiGroupBox();
      this.cmdRechercher = new MozartUC.apiButton();
      this.cmdSuppFNF = new MozartUC.apiButton();
      this.apiTGridB = new MozartUC.apiTGrid();
      this.chkSortieVeh = new MozartUC.apiCheckBox();
      this.apiLabel4 = new MozartUC.apiLabel();
      this.apiLabel2 = new MozartUC.apiLabel();
      this.apiLabel1 = new MozartUC.apiLabel();
      this.lblLabels11 = new MozartUC.apiLabel();
      this.chkSTT = new MozartUC.apiCheckBox();
      this.chkMO = new MozartUC.apiCheckBox();
      this.chkFOU = new MozartUC.apiCheckBox();
      this.apiTGridActions = new MozartUC.apiTGrid();
      this.cmdFermer = new MozartUC.apiButton();
      this.cmdEnregistrer = new MozartUC.apiButton();
      this.Label1 = new MozartUC.apiLabel();
      this.frameFournitures = new MozartUC.apiGroupBox();
      this.Frame2.SuspendLayout();
      this.frameFournitures.SuspendLayout();
      this.SuspendLayout();
      // 
      // Frame2
      // 
      this.Frame2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.Frame2.Controls.Add(this.chkSortieVeh);
      this.Frame2.Controls.Add(this.apiLabel4);
      this.Frame2.Controls.Add(this.frameFournitures);
      this.Frame2.Controls.Add(this.apiLabel2);
      this.Frame2.Controls.Add(this.apiLabel1);
      this.Frame2.Controls.Add(this.lblLabels11);
      this.Frame2.Controls.Add(this.chkSTT);
      this.Frame2.Controls.Add(this.chkMO);
      this.Frame2.Controls.Add(this.chkFOU);
      this.Frame2.Controls.Add(this.apiTGridActions);
      resources.ApplyResources(this.Frame2, "Frame2");
      this.Frame2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Frame2.FrameColor = System.Drawing.Color.Empty;
      this.Frame2.HelpContextID = 0;
      this.Frame2.Name = "Frame2";
      this.Frame2.TabStop = false;
      // 
      // cmdRechercher
      // 
      this.cmdRechercher.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdRechercher.HelpContextID = 0;
      this.cmdRechercher.Image = global::MozartCS.Properties.Resources.Find;
      resources.ApplyResources(this.cmdRechercher, "cmdRechercher");
      this.cmdRechercher.Name = "cmdRechercher";
      this.cmdRechercher.Tag = "26";
      this.cmdRechercher.UseVisualStyleBackColor = true;
      this.cmdRechercher.Click += new System.EventHandler(this.cmdRechercher_Click);
      // 
      // cmdSuppFNF
      // 
      this.cmdSuppFNF.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdSuppFNF.HelpContextID = 0;
      resources.ApplyResources(this.cmdSuppFNF, "cmdSuppFNF");
      this.cmdSuppFNF.Name = "cmdSuppFNF";
      this.cmdSuppFNF.Tag = "29";
      this.cmdSuppFNF.UseVisualStyleBackColor = true;
      this.cmdSuppFNF.Click += new System.EventHandler(this.cmdSuppFNF_Click_1);
      // 
      // apiTGridB
      // 
      this.apiTGridB.FilterBar = true;
      this.apiTGridB.FooterBar = true;
      this.apiTGridB.ForeColor = System.Drawing.SystemColors.WindowText;
      resources.ApplyResources(this.apiTGridB, "apiTGridB");
      this.apiTGridB.Name = "apiTGridB";
      // 
      // chkSortieVeh
      // 
      this.chkSortieVeh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.chkSortieVeh, "chkSortieVeh");
      this.chkSortieVeh.ForeColor = System.Drawing.SystemColors.ControlText;
      this.chkSortieVeh.HelpContextID = 0;
      this.chkSortieVeh.Name = "chkSortieVeh";
      this.chkSortieVeh.UseVisualStyleBackColor = false;
      this.chkSortieVeh.CheckedChanged += new System.EventHandler(this.chkSortieVeh_CheckedChanged);
      // 
      // apiLabel4
      // 
      resources.ApplyResources(this.apiLabel4, "apiLabel4");
      this.apiLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.apiLabel4.ForeColor = System.Drawing.SystemColors.ControlText;
      this.apiLabel4.HelpContextID = 0;
      this.apiLabel4.Name = "apiLabel4";
      // 
      // apiLabel2
      // 
      resources.ApplyResources(this.apiLabel2, "apiLabel2");
      this.apiLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.apiLabel2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.apiLabel2.HelpContextID = 0;
      this.apiLabel2.Name = "apiLabel2";
      // 
      // apiLabel1
      // 
      resources.ApplyResources(this.apiLabel1, "apiLabel1");
      this.apiLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.apiLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.apiLabel1.HelpContextID = 0;
      this.apiLabel1.Name = "apiLabel1";
      // 
      // lblLabels11
      // 
      resources.ApplyResources(this.lblLabels11, "lblLabels11");
      this.lblLabels11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.lblLabels11.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels11.HelpContextID = 0;
      this.lblLabels11.Name = "lblLabels11";
      // 
      // chkSTT
      // 
      this.chkSTT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.chkSTT, "chkSTT");
      this.chkSTT.ForeColor = System.Drawing.SystemColors.ControlText;
      this.chkSTT.HelpContextID = 0;
      this.chkSTT.Name = "chkSTT";
      this.chkSTT.UseVisualStyleBackColor = false;
      // 
      // chkMO
      // 
      this.chkMO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.chkMO, "chkMO");
      this.chkMO.ForeColor = System.Drawing.SystemColors.ControlText;
      this.chkMO.HelpContextID = 0;
      this.chkMO.Name = "chkMO";
      this.chkMO.UseVisualStyleBackColor = false;
      // 
      // chkFOU
      // 
      this.chkFOU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.chkFOU, "chkFOU");
      this.chkFOU.ForeColor = System.Drawing.SystemColors.ControlText;
      this.chkFOU.HelpContextID = 0;
      this.chkFOU.Name = "chkFOU";
      this.chkFOU.UseVisualStyleBackColor = false;
      // 
      // apiTGridActions
      // 
      this.apiTGridActions.FilterBar = true;
      this.apiTGridActions.FooterBar = true;
      resources.ApplyResources(this.apiTGridActions, "apiTGridActions");
      this.apiTGridActions.Name = "apiTGridActions";
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
      // cmdEnregistrer
      // 
      resources.ApplyResources(this.cmdEnregistrer, "cmdEnregistrer");
      this.cmdEnregistrer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdEnregistrer.HelpContextID = 0;
      this.cmdEnregistrer.Name = "cmdEnregistrer";
      this.cmdEnregistrer.Tag = "29";
      this.cmdEnregistrer.UseVisualStyleBackColor = true;
      this.cmdEnregistrer.Click += new System.EventHandler(this.cmdEnregistrer_Click);
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // frameFournitures
      // 
      resources.ApplyResources(this.frameFournitures, "frameFournitures");
      this.frameFournitures.BackColor = System.Drawing.Color.Wheat;
      this.frameFournitures.Controls.Add(this.cmdRechercher);
      this.frameFournitures.Controls.Add(this.cmdSuppFNF);
      this.frameFournitures.Controls.Add(this.apiTGridB);
      this.frameFournitures.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.frameFournitures.FrameColor = System.Drawing.Color.Empty;
      this.frameFournitures.HelpContextID = 0;
      this.frameFournitures.Name = "frameFournitures";
      this.frameFournitures.TabStop = false;
      // 
      // frmDetailNF
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Wheat;
      this.Controls.Add(this.Frame2);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.cmdEnregistrer);
      this.Controls.Add(this.Label1);
      this.Name = "frmDetailNF";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmDetailNF_Load);
      this.Frame2.ResumeLayout(false);
      this.Frame2.PerformLayout();
      this.frameFournitures.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiGroupBox Frame2;
    private MozartUC.apiTGrid apiTGridActions;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiButton cmdEnregistrer;
    private MozartUC.apiLabel Label1;
    private MozartUC.apiCheckBox chkSTT;
    private MozartUC.apiCheckBox chkMO;
    private MozartUC.apiCheckBox chkFOU;
    private MozartUC.apiLabel lblLabels11;
    private MozartUC.apiLabel apiLabel2;
    private MozartUC.apiLabel apiLabel1;
    private MozartUC.apiCheckBox chkSortieVeh;
    private MozartUC.apiLabel apiLabel4;
    private MozartUC.apiTGrid apiTGridB;
    private MozartUC.apiButton cmdSuppFNF;
    private MozartUC.apiButton cmdRechercher;
    private MozartUC.apiGroupBox frameFournitures;
  }
}