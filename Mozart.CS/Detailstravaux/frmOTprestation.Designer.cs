namespace MozartCS
{
  partial class frmOTprestation
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOTprestation));
      this.cmdNBDLCP = new MozartUC.apiButton();
      this.cmdBrouillon = new MozartUC.apiButton();
      this.cmdValider = new MozartUC.apiButton();
      this.txtclient = new MozartUC.apiTextBox();
      this.txtsite = new MozartUC.apiTextBox();
      this.txtnumsite = new MozartUC.apiTextBox();
      this.lblLabels14 = new MozartUC.apiLabel();
      this.lblLabels4 = new MozartUC.apiLabel();
      this.lblLabels18 = new MozartUC.apiLabel();
      this.Frame4 = new MozartUC.apiGroupBox();
      this.txtaction = new MozartUC.apiTextBox();
      this.apiTGridPrestSaisie = new MozartUC.apiTGrid();
      this.NumContrat = new MozartUC.apiGroupBox();
      this.cmdFermer = new MozartUC.apiButton();
      this.Label2 = new MozartUC.apiLabel();
      this.Frame4.SuspendLayout();
      this.NumContrat.SuspendLayout();
      this.SuspendLayout();
      // 
      // cmdNBDLCP
      // 
      this.cmdNBDLCP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
      resources.ApplyResources(this.cmdNBDLCP, "cmdNBDLCP");
      this.cmdNBDLCP.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdNBDLCP.HelpContextID = 0;
      this.cmdNBDLCP.Name = "cmdNBDLCP";
      this.cmdNBDLCP.Tag = "17";
      this.cmdNBDLCP.UseVisualStyleBackColor = false;
      this.cmdNBDLCP.Click += new System.EventHandler(this.cmdNBDLCP_Click);
      // 
      // cmdBrouillon
      // 
      resources.ApplyResources(this.cmdBrouillon, "cmdBrouillon");
      this.cmdBrouillon.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdBrouillon.HelpContextID = 0;
      this.cmdBrouillon.Name = "cmdBrouillon";
      this.cmdBrouillon.Tag = "8";
      this.cmdBrouillon.UseVisualStyleBackColor = true;
      this.cmdBrouillon.Click += new System.EventHandler(this.cmdBrouillon_Click);
      // 
      // cmdValider
      // 
      resources.ApplyResources(this.cmdValider, "cmdValider");
      this.cmdValider.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdValider.HelpContextID = 0;
      this.cmdValider.Name = "cmdValider";
      this.cmdValider.Tag = "29";
      this.cmdValider.UseVisualStyleBackColor = true;
      this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
      // 
      // txtclient
      // 
      this.txtclient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.txtclient, "txtclient");
      this.txtclient.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtclient.HelpContextID = 0;
      this.txtclient.Name = "txtclient";
      // 
      // txtsite
      // 
      this.txtsite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.txtsite, "txtsite");
      this.txtsite.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtsite.HelpContextID = 0;
      this.txtsite.Name = "txtsite";
      // 
      // txtnumsite
      // 
      resources.ApplyResources(this.txtnumsite, "txtnumsite");
      this.txtnumsite.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtnumsite.HelpContextID = 0;
      this.txtnumsite.Name = "txtnumsite";
      // 
      // lblLabels14
      // 
      this.lblLabels14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.lblLabels14, "lblLabels14");
      this.lblLabels14.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels14.HelpContextID = 0;
      this.lblLabels14.Name = "lblLabels14";
      // 
      // lblLabels4
      // 
      this.lblLabels4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.lblLabels4, "lblLabels4");
      this.lblLabels4.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels4.HelpContextID = 0;
      this.lblLabels4.Name = "lblLabels4";
      // 
      // lblLabels18
      // 
      this.lblLabels18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.lblLabels18, "lblLabels18");
      this.lblLabels18.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels18.HelpContextID = 0;
      this.lblLabels18.Name = "lblLabels18";
      // 
      // Frame4
      // 
      this.Frame4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.Frame4.Controls.Add(this.txtclient);
      this.Frame4.Controls.Add(this.txtsite);
      this.Frame4.Controls.Add(this.txtnumsite);
      this.Frame4.Controls.Add(this.lblLabels14);
      this.Frame4.Controls.Add(this.lblLabels4);
      this.Frame4.Controls.Add(this.lblLabels18);
      resources.ApplyResources(this.Frame4, "Frame4");
      this.Frame4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
      this.Frame4.HelpContextID = 0;
      this.Frame4.Name = "Frame4";
      this.Frame4.TabStop = false;
      // 
      // txtaction
      // 
      resources.ApplyResources(this.txtaction, "txtaction");
      this.txtaction.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtaction.HelpContextID = 0;
      this.txtaction.Name = "txtaction";
      // 
      // apiTGridPrestSaisie
      // 
      resources.ApplyResources(this.apiTGridPrestSaisie, "apiTGridPrestSaisie");
      this.apiTGridPrestSaisie.FilterBar = true;
      this.apiTGridPrestSaisie.FooterBar = true;
      this.apiTGridPrestSaisie.Name = "apiTGridPrestSaisie";
      this.apiTGridPrestSaisie.RowCellStyle += new MozartUC.apiTGrid.RowCellStyleEventHandler(this.apiTGridPrestSaisie_RowCellStyle);
      // 
      // NumContrat
      // 
      this.NumContrat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.NumContrat.Controls.Add(this.txtaction);
      this.NumContrat.Controls.Add(this.apiTGridPrestSaisie);
      resources.ApplyResources(this.NumContrat, "NumContrat");
      this.NumContrat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.NumContrat.HelpContextID = 0;
      this.NumContrat.Name = "NumContrat";
      this.NumContrat.TabStop = false;
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
      // Label2
      // 
      resources.ApplyResources(this.Label2, "Label2");
      this.Label2.BackColor = System.Drawing.Color.Wheat;
      this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label2.HelpContextID = 0;
      this.Label2.Name = "Label2";
      // 
      // frmOTprestation
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdNBDLCP);
      this.Controls.Add(this.cmdBrouillon);
      this.Controls.Add(this.cmdValider);
      this.Controls.Add(this.Frame4);
      this.Controls.Add(this.NumContrat);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.Label2);
      this.Name = "frmOTprestation";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmOTprestation_Load);
      this.Frame4.ResumeLayout(false);
      this.Frame4.PerformLayout();
      this.NumContrat.ResumeLayout(false);
      this.NumContrat.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdNBDLCP;
    private MozartUC.apiButton cmdBrouillon;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiTextBox txtclient;
    private MozartUC.apiTextBox txtsite;
    private MozartUC.apiTextBox txtnumsite;
    private MozartUC.apiLabel lblLabels14;
    private MozartUC.apiLabel lblLabels4;
    private MozartUC.apiLabel lblLabels18;
    private MozartUC.apiGroupBox Frame4;
    private MozartUC.apiTextBox txtaction;
    private MozartUC.apiTGrid apiTGridPrestSaisie;
    private MozartUC.apiGroupBox NumContrat;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiLabel Label2;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
