namespace MozartCS
{
  partial class frmLienContactSite
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLienContactSite));
      this.ApiGrid = new MozartUC.apiTGrid();
      this.cmdValider = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.cmdCocherT = new MozartUC.apiButton();
      this.cmdDecocher = new MozartUC.apiButton();
      this.lstAction = new System.Windows.Forms.CheckedListBox();
      this.lblNbSites = new MozartUC.apiLabel();
      this.Frame3 = new MozartUC.apiGroupBox();
      this.Label14 = new MozartUC.apiLabel();
      this.Frame3.SuspendLayout();
      this.SuspendLayout();
      // 
      // ApiGrid
      // 
      resources.ApplyResources(this.ApiGrid, "ApiGrid");
      this.ApiGrid.FilterBar = true;
      this.ApiGrid.FooterBar = true;
      this.ApiGrid.Name = "ApiGrid";
      this.ApiGrid.ClickE += new MozartUC.apiTGrid.ClickEEventHandler(this.ApiGrid_ClickE);
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
      // cmdCocherT
      // 
      resources.ApplyResources(this.cmdCocherT, "cmdCocherT");
      this.cmdCocherT.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdCocherT.HelpContextID = 0;
      this.cmdCocherT.Name = "cmdCocherT";
      this.cmdCocherT.UseVisualStyleBackColor = true;
      this.cmdCocherT.Click += new System.EventHandler(this.cmdCocherT_Click);
      // 
      // cmdDecocher
      // 
      resources.ApplyResources(this.cmdDecocher, "cmdDecocher");
      this.cmdDecocher.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdDecocher.HelpContextID = 0;
      this.cmdDecocher.Name = "cmdDecocher";
      this.cmdDecocher.UseVisualStyleBackColor = true;
      this.cmdDecocher.Click += new System.EventHandler(this.cmdDecocher_Click);
      // 
      // lstAction
      // 
      resources.ApplyResources(this.lstAction, "lstAction");
      this.lstAction.Name = "lstAction";
      this.lstAction.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lstAction_ItemCheck);
      this.lstAction.Click += new System.EventHandler(this.lstAction_Click);
      // 
      // lblNbSites
      // 
      resources.ApplyResources(this.lblNbSites, "lblNbSites");
      this.lblNbSites.BackColor = System.Drawing.Color.Wheat;
      this.lblNbSites.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblNbSites.HelpContextID = 0;
      this.lblNbSites.Name = "lblNbSites";
      this.lblNbSites.Tag = "Nb sites cochés :";
      // 
      // Frame3
      // 
      resources.ApplyResources(this.Frame3, "Frame3");
      this.Frame3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.Frame3.Controls.Add(this.cmdCocherT);
      this.Frame3.Controls.Add(this.cmdDecocher);
      this.Frame3.Controls.Add(this.lstAction);
      this.Frame3.Controls.Add(this.lblNbSites);
      this.Frame3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Frame3.HelpContextID = 0;
      this.Frame3.Name = "Frame3";
      this.Frame3.TabStop = false;
      // 
      // Label14
      // 
      resources.ApplyResources(this.Label14, "Label14");
      this.Label14.BackColor = System.Drawing.Color.Wheat;
      this.Label14.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label14.HelpContextID = 0;
      this.Label14.Name = "Label14";
      // 
      // frmLienContactSite
      // 
      this.AcceptButton = this.cmdFermer;
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.ApiGrid);
      this.Controls.Add(this.cmdValider);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.Frame3);
      this.Controls.Add(this.Label14);
      this.Name = "frmLienContactSite";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmLienContactSite_Load);
      this.Frame3.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiTGrid ApiGrid;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiButton cmdCocherT;
    private MozartUC.apiButton cmdDecocher;
    private System.Windows.Forms.CheckedListBox lstAction;
    private MozartUC.apiLabel lblNbSites;
    private MozartUC.apiGroupBox Frame3;
    private MozartUC.apiLabel Label14;
    // TODO GetCodeDeclareControl cas non traitÃ© pour type VB.Line

  }
}
