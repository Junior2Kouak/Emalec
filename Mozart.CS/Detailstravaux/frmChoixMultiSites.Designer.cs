namespace MozartCS
{
  partial class frmChoixMultiSites
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChoixMultiSites));
			this.chkDI = new MozartUC.apiCheckBox();
			this.cboGamme = new System.Windows.Forms.ComboBox();
			this.lblLabels33 = new MozartUC.apiLabel();
			this.Frame1 = new MozartUC.apiGroupBox();
			this.cmdDecocher = new MozartUC.apiButton();
			this.cmdCocherT = new MozartUC.apiButton();
			this.cmdValider = new MozartUC.apiButton();
			this.cmdFermer = new MozartUC.apiButton();
			this.apiTGrid = new MozartUC.apiTGrid();
			this.lblNbSites = new MozartUC.apiLabel();
			this.Frame3 = new MozartUC.apiGroupBox();
			this.Label14 = new MozartUC.apiLabel();
			this.Frame1.SuspendLayout();
			this.Frame3.SuspendLayout();
			this.SuspendLayout();
			// 
			// chkDI
			// 
			this.chkDI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			resources.ApplyResources(this.chkDI, "chkDI");
			this.chkDI.ForeColor = System.Drawing.SystemColors.ControlText;
			this.chkDI.HelpContextID = 684;
			this.chkDI.Name = "chkDI";
			this.chkDI.UseVisualStyleBackColor = false;
			// 
			// cboGamme
			// 
			this.cboGamme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.cboGamme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			resources.ApplyResources(this.cboGamme, "cboGamme");
			this.cboGamme.Name = "cboGamme";
			// 
			// lblLabels33
			// 
			this.lblLabels33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			resources.ApplyResources(this.lblLabels33, "lblLabels33");
			this.lblLabels33.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLabels33.HelpContextID = 0;
			this.lblLabels33.Name = "lblLabels33";
			// 
			// Frame1
			// 
			this.Frame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.Frame1.Controls.Add(this.cboGamme);
			this.Frame1.Controls.Add(this.lblLabels33);
			resources.ApplyResources(this.Frame1, "Frame1");
			this.Frame1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.Frame1.FrameColor = System.Drawing.Color.Empty;
			this.Frame1.HelpContextID = 0;
			this.Frame1.Name = "Frame1";
			this.Frame1.TabStop = false;
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
			// cmdCocherT
			// 
			resources.ApplyResources(this.cmdCocherT, "cmdCocherT");
			this.cmdCocherT.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdCocherT.HelpContextID = 0;
			this.cmdCocherT.Name = "cmdCocherT";
			this.cmdCocherT.UseVisualStyleBackColor = true;
			this.cmdCocherT.Click += new System.EventHandler(this.cmdCocherT_Click);
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
			// apiTGrid
			// 
			resources.ApplyResources(this.apiTGrid, "apiTGrid");
			this.apiTGrid.FilterBar = true;
			this.apiTGrid.FooterBar = true;
			this.apiTGrid.ForeColor = System.Drawing.SystemColors.ControlText;
			this.apiTGrid.Name = "apiTGrid";
			this.apiTGrid.CellValueChanged += new MozartUC.apiTGrid.CellValueChangedEventHandler(this.apiTGrid_CellValueChanged);
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
			this.Frame3.Controls.Add(this.apiTGrid);
			this.Frame3.Controls.Add(this.lblNbSites);
			this.Frame3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.Frame3.FrameColor = System.Drawing.Color.Empty;
			this.Frame3.HelpContextID = 0;
			this.Frame3.Name = "Frame3";
			this.Frame3.TabStop = false;
			// 
			// Label14
			// 
			this.Label14.BackColor = System.Drawing.Color.Wheat;
			resources.ApplyResources(this.Label14, "Label14");
			this.Label14.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label14.HelpContextID = 0;
			this.Label14.Name = "Label14";
			// 
			// frmChoixMultiSites
			// 
			this.AcceptButton = this.cmdFermer;
			this.BackColor = System.Drawing.Color.Wheat;
			this.CancelButton = this.cmdFermer;
			resources.ApplyResources(this, "$this");
			this.Controls.Add(this.chkDI);
			this.Controls.Add(this.Frame1);
			this.Controls.Add(this.cmdDecocher);
			this.Controls.Add(this.cmdCocherT);
			this.Controls.Add(this.cmdValider);
			this.Controls.Add(this.cmdFermer);
			this.Controls.Add(this.Frame3);
			this.Controls.Add(this.Label14);
			this.Name = "frmChoixMultiSites";
			this.ShowInTaskbar = false;
			this.Load += new System.EventHandler(this.frmChoixMultiSites_Load);
			this.Frame1.ResumeLayout(false);
			this.Frame3.ResumeLayout(false);
			this.ResumeLayout(false);

    }

    #endregion

    private MozartUC.apiCheckBox chkDI;
    private System.Windows.Forms.ComboBox cboGamme;
    private MozartUC.apiLabel lblLabels33;
    private MozartUC.apiGroupBox Frame1;
    private MozartUC.apiButton cmdDecocher;
    private MozartUC.apiButton cmdCocherT;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiTGrid apiTGrid;
    private MozartUC.apiLabel lblNbSites;
    private MozartUC.apiGroupBox Frame3;
    private MozartUC.apiLabel Label14;
    // TODO GetCodeDeclareControl cas non traitÃ© pour type VB.Line

  }
}
