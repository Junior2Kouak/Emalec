namespace MozartCS
{
  partial class frmGestFournitures
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestFournitures));
      this.ApiGrid = new MozartUC.apiTGrid();
      this.Command1 = new MozartUC.apiButton();
      this.cmdNouvelle = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.Label14 = new MozartUC.apiLabel();
      this.Label13 = new MozartUC.apiLabel();
      this.Label12 = new MozartUC.apiLabel();
      this.Label11 = new MozartUC.apiLabel();
      this.Label10 = new MozartUC.apiLabel();
      this.Frame1 = new MozartUC.apiGroupBox();
      this.lblTitre = new MozartUC.apiLabel();
      this.Frame1.SuspendLayout();
      this.SuspendLayout();
      // 
      // ApiGrid
      // 
      this.ApiGrid.FilterBar = true;
      this.ApiGrid.FooterBar = true;
      resources.ApplyResources(this.ApiGrid, "ApiGrid");
      this.ApiGrid.Name = "ApiGrid";
      // 
      // Command1
      // 
      resources.ApplyResources(this.Command1, "Command1");
      this.Command1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Command1.HelpContextID = 0;
      this.Command1.Name = "Command1";
      this.Command1.Tag = "19";
      this.Command1.UseVisualStyleBackColor = true;
      this.Command1.Click += new System.EventHandler(this.Command1_Click);
      // 
      // cmdNouvelle
      // 
      resources.ApplyResources(this.cmdNouvelle, "cmdNouvelle");
      this.cmdNouvelle.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdNouvelle.HelpContextID = 15;
      this.cmdNouvelle.Name = "cmdNouvelle";
      this.cmdNouvelle.Tag = "2";
      this.cmdNouvelle.UseVisualStyleBackColor = true;
      this.cmdNouvelle.Click += new System.EventHandler(this.cmdNouvelle_Click);
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
      // Label14
      // 
      this.Label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.Label14, "Label14");
      this.Label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.Label14.HelpContextID = 0;
      this.Label14.Name = "Label14";
      // 
      // Label13
      // 
      this.Label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.Label13, "Label13");
      this.Label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.Label13.HelpContextID = 0;
      this.Label13.Name = "Label13";
      // 
      // Label12
      // 
      this.Label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.Label12, "Label12");
      this.Label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.Label12.HelpContextID = 0;
      this.Label12.Name = "Label12";
      // 
      // Label11
      // 
      this.Label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.Label11, "Label11");
      this.Label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.Label11.HelpContextID = 0;
      this.Label11.Name = "Label11";
      // 
      // Label10
      // 
      this.Label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.Label10, "Label10");
      this.Label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.Label10.HelpContextID = 0;
      this.Label10.Name = "Label10";
      // 
      // Frame1
      // 
      this.Frame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.Frame1.Controls.Add(this.Label11);
      this.Frame1.Controls.Add(this.Label14);
      this.Frame1.Controls.Add(this.Label13);
      this.Frame1.Controls.Add(this.Label10);
      this.Frame1.Controls.Add(this.Label12);
      resources.ApplyResources(this.Frame1, "Frame1");
      this.Frame1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
      this.Frame1.HelpContextID = 0;
      this.Frame1.Name = "Frame1";
      this.Frame1.TabStop = false;
      // 
      // lblTitre
      // 
      this.lblTitre.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.lblTitre, "lblTitre");
      this.lblTitre.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblTitre.HelpContextID = 0;
      this.lblTitre.Name = "lblTitre";
      // 
      // frmGestFournitures
      // 
      this.AcceptButton = this.cmdFermer;
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.lblTitre);
      this.Controls.Add(this.ApiGrid);
      this.Controls.Add(this.cmdNouvelle);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.Frame1);
      this.Controls.Add(this.Command1);
      this.Name = "frmGestFournitures";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmGestFournitures_Load);
      this.Frame1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private MozartUC.apiTGrid ApiGrid;
    private MozartUC.apiButton Command1;
    private MozartUC.apiButton cmdNouvelle;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiLabel Label14;
    private MozartUC.apiLabel Label13;
    private MozartUC.apiLabel Label12;
    private MozartUC.apiLabel Label11;
    private MozartUC.apiLabel Label10;
    private MozartUC.apiGroupBox Frame1;
    private MozartUC.apiLabel lblTitre;

  }
}
