namespace MozartCS
{
  partial class frmStatImpayesClient
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStatImpayesClient));
      this.chkRetard = new MozartUC.apiCheckBox();
      this.CmdObs = new MozartUC.apiButton();
      this.CmdObsMsgFermer = new MozartUC.apiButton();
      this.CmdValiderMsg = new MozartUC.apiButton();
      this.txtMsg = new MozartUC.apiTextBox();
      this.FrameMsg = new MozartUC.apiGroupBox();
      this.txtObs = new MozartUC.apiTextBox();
      this.cmdObsFermer = new MozartUC.apiButton();
      this.FrameObs = new MozartUC.apiGroupBox();
      this.ChkGroupe = new MozartUC.apiCheckBox();
      this.ChkAllClient = new MozartUC.apiCheckBox();
      this.cmdValider = new MozartUC.apiButton();
      this.lblTab10 = new MozartUC.apiLabel();
      this.lblTab8 = new MozartUC.apiLabel();
      this.lblTab9 = new MozartUC.apiLabel();
      this.lblTab15 = new MozartUC.apiLabel();
      this.lblTab7 = new MozartUC.apiLabel();
      this.lblTab5 = new MozartUC.apiLabel();
      this.lblTab6 = new MozartUC.apiLabel();
      this.lblTab4 = new MozartUC.apiLabel();
      this.lblTab3 = new MozartUC.apiLabel();
      this.lblTab2 = new MozartUC.apiLabel();
      this.lblTab1 = new MozartUC.apiLabel();
      this.lblTab0 = new MozartUC.apiLabel();
      this.Frame1 = new MozartUC.apiGroupBox();
      this.cmdDetail = new MozartUC.apiButton();
      this.cmdQuitter = new MozartUC.apiButton();
      this.cboClient = new MozartUC.apiCombo();
      this.apiTGrid = new MozartUC.apiTGrid();
      this.Label10 = new MozartUC.apiLabel();
      this.lblLabels11 = new MozartUC.apiLabel();
      this.Label11 = new MozartUC.apiLabel();
      this.FrameMsg.SuspendLayout();
      this.FrameObs.SuspendLayout();
      this.Frame1.SuspendLayout();
      this.SuspendLayout();
      // 
      // chkRetard
      // 
      this.chkRetard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
      resources.ApplyResources(this.chkRetard, "chkRetard");
      this.chkRetard.ForeColor = System.Drawing.SystemColors.ControlText;
      this.chkRetard.HelpContextID = 619;
      this.chkRetard.Name = "chkRetard";
      this.chkRetard.UseVisualStyleBackColor = false;
      this.chkRetard.CheckedChanged += new System.EventHandler(this.chkRetard_CheckedChanged);
      // 
      // CmdObs
      // 
      this.CmdObs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      resources.ApplyResources(this.CmdObs, "CmdObs");
      this.CmdObs.ForeColor = System.Drawing.SystemColors.ControlText;
      this.CmdObs.HelpContextID = 0;
      this.CmdObs.Name = "CmdObs";
      this.CmdObs.Tag = "19";
      this.CmdObs.UseVisualStyleBackColor = false;
      this.CmdObs.Click += new System.EventHandler(this.CmdObs_Click);
      // 
      // CmdObsMsgFermer
      // 
      this.CmdObsMsgFermer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.CmdObsMsgFermer.HelpContextID = 0;
      resources.ApplyResources(this.CmdObsMsgFermer, "CmdObsMsgFermer");
      this.CmdObsMsgFermer.Name = "CmdObsMsgFermer";
      this.CmdObsMsgFermer.UseVisualStyleBackColor = true;
      this.CmdObsMsgFermer.Click += new System.EventHandler(this.CmdObsMsgFermer_Click);
      // 
      // CmdValiderMsg
      // 
      this.CmdValiderMsg.ForeColor = System.Drawing.SystemColors.ControlText;
      this.CmdValiderMsg.HelpContextID = 0;
      resources.ApplyResources(this.CmdValiderMsg, "CmdValiderMsg");
      this.CmdValiderMsg.Name = "CmdValiderMsg";
      this.CmdValiderMsg.UseVisualStyleBackColor = true;
      this.CmdValiderMsg.Click += new System.EventHandler(this.CmdValiderMsg_Click);
      // 
      // txtMsg
      // 
      this.txtMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.txtMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.txtMsg.HelpContextID = 0;
      resources.ApplyResources(this.txtMsg, "txtMsg");
      this.txtMsg.Name = "txtMsg";
      // 
      // FrameMsg
      // 
      this.FrameMsg.Controls.Add(this.CmdObsMsgFermer);
      this.FrameMsg.Controls.Add(this.CmdValiderMsg);
      this.FrameMsg.Controls.Add(this.txtMsg);
      resources.ApplyResources(this.FrameMsg, "FrameMsg");
      this.FrameMsg.FrameColor = System.Drawing.Color.Empty;
      this.FrameMsg.HelpContextID = 0;
      this.FrameMsg.Name = "FrameMsg";
      this.FrameMsg.TabStop = false;
      // 
      // txtObs
      // 
      this.txtObs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.txtObs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.txtObs.HelpContextID = 0;
      resources.ApplyResources(this.txtObs, "txtObs");
      this.txtObs.Name = "txtObs";
      this.txtObs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtObs_KeyPress);
      // 
      // cmdObsFermer
      // 
      this.cmdObsFermer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdObsFermer.HelpContextID = 0;
      resources.ApplyResources(this.cmdObsFermer, "cmdObsFermer");
      this.cmdObsFermer.Name = "cmdObsFermer";
      this.cmdObsFermer.UseVisualStyleBackColor = true;
      this.cmdObsFermer.Click += new System.EventHandler(this.cmdObsFermer_Click);
      // 
      // FrameObs
      // 
      this.FrameObs.Controls.Add(this.txtObs);
      this.FrameObs.Controls.Add(this.cmdObsFermer);
      resources.ApplyResources(this.FrameObs, "FrameObs");
      this.FrameObs.FrameColor = System.Drawing.Color.Empty;
      this.FrameObs.HelpContextID = 0;
      this.FrameObs.Name = "FrameObs";
      this.FrameObs.TabStop = false;
      // 
      // ChkGroupe
      // 
      this.ChkGroupe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
      resources.ApplyResources(this.ChkGroupe, "ChkGroupe");
      this.ChkGroupe.ForeColor = System.Drawing.SystemColors.ControlText;
      this.ChkGroupe.HelpContextID = 619;
      this.ChkGroupe.Name = "ChkGroupe";
      this.ChkGroupe.UseVisualStyleBackColor = false;
      this.ChkGroupe.CheckedChanged += new System.EventHandler(this.ChkGroupe_CheckedChanged);
      // 
      // ChkAllClient
      // 
      this.ChkAllClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
      resources.ApplyResources(this.ChkAllClient, "ChkAllClient");
      this.ChkAllClient.ForeColor = System.Drawing.SystemColors.ControlText;
      this.ChkAllClient.HelpContextID = 529;
      this.ChkAllClient.Name = "ChkAllClient";
      this.ChkAllClient.UseVisualStyleBackColor = false;
      this.ChkAllClient.CheckedChanged += new System.EventHandler(this.ChkAllClient_CheckedChanged);
      // 
      // cmdValider
      // 
      this.cmdValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
      resources.ApplyResources(this.cmdValider, "cmdValider");
      this.cmdValider.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdValider.HelpContextID = 20;
      this.cmdValider.Image = global::MozartCS.Properties.Resources.ok_32;
      this.cmdValider.Name = "cmdValider";
      this.cmdValider.Tag = "66";
      this.cmdValider.UseVisualStyleBackColor = false;
      this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
      // 
      // lblTab10
      // 
      this.lblTab10.BackColor = System.Drawing.SystemColors.ButtonFace;
      resources.ApplyResources(this.lblTab10, "lblTab10");
      this.lblTab10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.lblTab10.HelpContextID = 0;
      this.lblTab10.Name = "lblTab10";
      // 
      // lblTab8
      // 
      this.lblTab8.BackColor = System.Drawing.SystemColors.ButtonFace;
      resources.ApplyResources(this.lblTab8, "lblTab8");
      this.lblTab8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.lblTab8.HelpContextID = 0;
      this.lblTab8.Name = "lblTab8";
      // 
      // lblTab9
      // 
      this.lblTab9.BackColor = System.Drawing.SystemColors.ButtonFace;
      resources.ApplyResources(this.lblTab9, "lblTab9");
      this.lblTab9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.lblTab9.HelpContextID = 0;
      this.lblTab9.Name = "lblTab9";
      // 
      // lblTab15
      // 
      this.lblTab15.BackColor = System.Drawing.SystemColors.ButtonFace;
      resources.ApplyResources(this.lblTab15, "lblTab15");
      this.lblTab15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.lblTab15.HelpContextID = 0;
      this.lblTab15.Name = "lblTab15";
      // 
      // lblTab7
      // 
      this.lblTab7.BackColor = System.Drawing.Color.White;
      resources.ApplyResources(this.lblTab7, "lblTab7");
      this.lblTab7.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblTab7.HelpContextID = 0;
      this.lblTab7.Name = "lblTab7";
      // 
      // lblTab5
      // 
      this.lblTab5.BackColor = System.Drawing.Color.White;
      resources.ApplyResources(this.lblTab5, "lblTab5");
      this.lblTab5.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblTab5.HelpContextID = 0;
      this.lblTab5.Name = "lblTab5";
      // 
      // lblTab6
      // 
      this.lblTab6.BackColor = System.Drawing.Color.White;
      resources.ApplyResources(this.lblTab6, "lblTab6");
      this.lblTab6.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblTab6.HelpContextID = 0;
      this.lblTab6.Name = "lblTab6";
      // 
      // lblTab4
      // 
      this.lblTab4.BackColor = System.Drawing.Color.White;
      resources.ApplyResources(this.lblTab4, "lblTab4");
      this.lblTab4.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblTab4.HelpContextID = 0;
      this.lblTab4.Name = "lblTab4";
      // 
      // lblTab3
      // 
      this.lblTab3.BackColor = System.Drawing.SystemColors.ButtonFace;
      resources.ApplyResources(this.lblTab3, "lblTab3");
      this.lblTab3.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblTab3.HelpContextID = 0;
      this.lblTab3.Name = "lblTab3";
      // 
      // lblTab2
      // 
      this.lblTab2.BackColor = System.Drawing.SystemColors.ButtonFace;
      resources.ApplyResources(this.lblTab2, "lblTab2");
      this.lblTab2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblTab2.HelpContextID = 0;
      this.lblTab2.Name = "lblTab2";
      // 
      // lblTab1
      // 
      this.lblTab1.BackColor = System.Drawing.SystemColors.ButtonFace;
      resources.ApplyResources(this.lblTab1, "lblTab1");
      this.lblTab1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblTab1.HelpContextID = 0;
      this.lblTab1.Name = "lblTab1";
      // 
      // lblTab0
      // 
      this.lblTab0.BackColor = System.Drawing.SystemColors.ButtonFace;
      resources.ApplyResources(this.lblTab0, "lblTab0");
      this.lblTab0.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblTab0.HelpContextID = 0;
      this.lblTab0.Name = "lblTab0";
      // 
      // Frame1
      // 
      this.Frame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      this.Frame1.Controls.Add(this.lblTab10);
      this.Frame1.Controls.Add(this.lblTab8);
      this.Frame1.Controls.Add(this.lblTab9);
      this.Frame1.Controls.Add(this.lblTab15);
      this.Frame1.Controls.Add(this.lblTab7);
      this.Frame1.Controls.Add(this.lblTab5);
      this.Frame1.Controls.Add(this.lblTab6);
      this.Frame1.Controls.Add(this.lblTab4);
      this.Frame1.Controls.Add(this.lblTab3);
      this.Frame1.Controls.Add(this.lblTab2);
      this.Frame1.Controls.Add(this.lblTab1);
      this.Frame1.Controls.Add(this.lblTab0);
      resources.ApplyResources(this.Frame1, "Frame1");
      this.Frame1.FrameColor = System.Drawing.Color.Empty;
      this.Frame1.HelpContextID = 0;
      this.Frame1.Name = "Frame1";
      this.Frame1.TabStop = false;
      // 
      // cmdDetail
      // 
      this.cmdDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      resources.ApplyResources(this.cmdDetail, "cmdDetail");
      this.cmdDetail.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdDetail.HelpContextID = 0;
      this.cmdDetail.Name = "cmdDetail";
      this.cmdDetail.Tag = "19";
      this.cmdDetail.UseVisualStyleBackColor = false;
      this.cmdDetail.Click += new System.EventHandler(this.cmdDetail_Click);
      // 
      // cmdQuitter
      // 
      resources.ApplyResources(this.cmdQuitter, "cmdQuitter");
      this.cmdQuitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      this.cmdQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdQuitter.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdQuitter.HelpContextID = 0;
      this.cmdQuitter.Name = "cmdQuitter";
      this.cmdQuitter.Tag = "15";
      this.cmdQuitter.UseVisualStyleBackColor = false;
      // 
      // cboClient
      // 
      resources.ApplyResources(this.cboClient, "cboClient");
      this.cboClient.Name = "cboClient";
      this.cboClient.NewValues = false;
      // 
      // apiTGrid
      // 
      resources.ApplyResources(this.apiTGrid, "apiTGrid");
      this.apiTGrid.FilterBar = true;
      this.apiTGrid.FooterBar = true;
      this.apiTGrid.Name = "apiTGrid";
      this.apiTGrid.RowCellClick += new MozartUC.apiTGrid.RowCellClickEventHandler(this.apiTGrid_RowCellClick);
      // 
      // Label10
      // 
      this.Label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
      resources.ApplyResources(this.Label10, "Label10");
      this.Label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
      this.Label10.HelpContextID = 0;
      this.Label10.Name = "Label10";
      // 
      // lblLabels11
      // 
      resources.ApplyResources(this.lblLabels11, "lblLabels11");
      this.lblLabels11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
      this.lblLabels11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
      this.lblLabels11.HelpContextID = 0;
      this.lblLabels11.Name = "lblLabels11";
      // 
      // Label11
      // 
      this.Label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
      resources.ApplyResources(this.Label11, "Label11");
      this.Label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
      this.Label11.HelpContextID = 0;
      this.Label11.Name = "Label11";
      // 
      // frmStatImpayesClient
      // 
      this.AcceptButton = this.cmdQuitter;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
      this.CancelButton = this.cmdQuitter;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.chkRetard);
      this.Controls.Add(this.CmdObs);
      this.Controls.Add(this.FrameMsg);
      this.Controls.Add(this.FrameObs);
      this.Controls.Add(this.ChkGroupe);
      this.Controls.Add(this.ChkAllClient);
      this.Controls.Add(this.cmdValider);
      this.Controls.Add(this.Frame1);
      this.Controls.Add(this.cmdDetail);
      this.Controls.Add(this.cmdQuitter);
      this.Controls.Add(this.cboClient);
      this.Controls.Add(this.apiTGrid);
      this.Controls.Add(this.Label10);
      this.Controls.Add(this.lblLabels11);
      this.Controls.Add(this.Label11);
      this.Name = "frmStatImpayesClient";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmStatImpayesClient_Load);
      this.FrameMsg.ResumeLayout(false);
      this.FrameMsg.PerformLayout();
      this.FrameObs.ResumeLayout(false);
      this.FrameObs.PerformLayout();
      this.Frame1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiCheckBox chkRetard;
    private MozartUC.apiButton CmdObs;
    private MozartUC.apiButton CmdObsMsgFermer;
    private MozartUC.apiButton CmdValiderMsg;
    private MozartUC.apiTextBox txtMsg;
    private MozartUC.apiGroupBox FrameMsg;
    private MozartUC.apiTextBox txtObs;
    private MozartUC.apiButton cmdObsFermer;
    private MozartUC.apiGroupBox FrameObs;
    private MozartUC.apiCheckBox ChkGroupe;
    private MozartUC.apiCheckBox ChkAllClient;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiLabel lblTab10;
    private MozartUC.apiLabel lblTab8;
    private MozartUC.apiLabel lblTab9;
    private MozartUC.apiLabel lblTab15;
    private MozartUC.apiLabel lblTab7;
    private MozartUC.apiLabel lblTab5;
    private MozartUC.apiLabel lblTab6;
    private MozartUC.apiLabel lblTab4;
    private MozartUC.apiLabel lblTab3;
    private MozartUC.apiLabel lblTab2;
    private MozartUC.apiLabel lblTab1;
    private MozartUC.apiLabel lblTab0;
    private MozartUC.apiGroupBox Frame1;
    private MozartUC.apiButton cmdDetail;
    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiCombo cboClient;
    private MozartUC.apiTGrid apiTGrid;
    private MozartUC.apiLabel Label10;
    private MozartUC.apiLabel lblLabels11;
    private MozartUC.apiLabel Label11;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
