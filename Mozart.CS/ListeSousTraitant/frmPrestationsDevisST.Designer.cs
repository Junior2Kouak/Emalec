namespace MozartCS
{
  partial class frmPrestationsDevisST
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrestationsDevisST));
      this.cmdFermer = new MozartUC.apiButton();
      this.cmdValider = new MozartUC.apiButton();
      this.apiTGridPrestSaisie = new MozartUC.apiTGrid();
      this.Frame7 = new MozartUC.apiGroupBox();
      this.cmdSupp = new MozartUC.apiButton();
      this.cmdAjouter = new MozartUC.apiButton();
      this.apiTGridHaut = new MozartUC.apiTGrid();
      this.Frame1 = new MozartUC.apiGroupBox();
      this.Label1 = new MozartUC.apiLabel();
      this.txtTDHT = new MozartUC.apiLabel();
      this.Frame7.SuspendLayout();
      this.Frame1.SuspendLayout();
      this.SuspendLayout();
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Tag = "15";
      this.cmdFermer.UseVisualStyleBackColor = true;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // cmdValider
      // 
      resources.ApplyResources(this.cmdValider, "cmdValider");
      this.cmdValider.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdValider.HelpContextID = 0;
      this.cmdValider.Name = "cmdValider";
      this.cmdValider.Tag = "66";
      this.cmdValider.UseVisualStyleBackColor = true;
      this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
      // 
      // apiTGridPrestSaisie
      // 
      resources.ApplyResources(this.apiTGridPrestSaisie, "apiTGridPrestSaisie");
      this.apiTGridPrestSaisie.FilterBar = true;
      this.apiTGridPrestSaisie.FooterBar = true;
      this.apiTGridPrestSaisie.Name = "apiTGridPrestSaisie";
      this.apiTGridPrestSaisie.RowCellStyle += new MozartUC.apiTGrid.RowCellStyleEventHandler(this.apiTGridPrestSaisie_RowCellStyle);
      this.apiTGridPrestSaisie.CellValueChanging += new MozartUC.apiTGrid.CellValueChangingEventHandler(this.apiTGridPrestSaisie_CellValueChanging);
      this.apiTGridPrestSaisie.CellValueChanged += new MozartUC.apiTGrid.CellValueChangedEventHandler(this.apiTGridPrestSaisie_CellValueChanged);
      // 
      // Frame7
      // 
      this.Frame7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.Frame7.Controls.Add(this.txtTDHT);
      this.Frame7.Controls.Add(this.apiTGridPrestSaisie);
      resources.ApplyResources(this.Frame7, "Frame7");
      this.Frame7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.Frame7.HelpContextID = 0;
      this.Frame7.Name = "Frame7";
      this.Frame7.TabStop = false;
      // 
      // cmdSupp
      // 
      this.cmdSupp.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdSupp.HelpContextID = 0;
      this.cmdSupp.Image = global::MozartCS.Properties.Resources.delete_32;
      resources.ApplyResources(this.cmdSupp, "cmdSupp");
      this.cmdSupp.Name = "cmdSupp";
      this.cmdSupp.Tag = "27";
      this.cmdSupp.UseVisualStyleBackColor = true;
      this.cmdSupp.Click += new System.EventHandler(this.cmdSupp_Click);
      // 
      // cmdAjouter
      // 
      resources.ApplyResources(this.cmdAjouter, "cmdAjouter");
      this.cmdAjouter.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdAjouter.HelpContextID = 0;
      this.cmdAjouter.Image = global::MozartCS.Properties.Resources.add_32;
      this.cmdAjouter.Name = "cmdAjouter";
      this.cmdAjouter.Tag = "2";
      this.cmdAjouter.UseVisualStyleBackColor = true;
      this.cmdAjouter.Click += new System.EventHandler(this.cmdAjouter_Click);
      // 
      // apiTGridHaut
      // 
      resources.ApplyResources(this.apiTGridHaut, "apiTGridHaut");
      this.apiTGridHaut.FilterBar = true;
      this.apiTGridHaut.FooterBar = true;
      this.apiTGridHaut.Name = "apiTGridHaut";
      // 
      // Frame1
      // 
      this.Frame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.Frame1.Controls.Add(this.apiTGridHaut);
      resources.ApplyResources(this.Frame1, "Frame1");
      this.Frame1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.Frame1.HelpContextID = 0;
      this.Frame1.Name = "Frame1";
      this.Frame1.TabStop = false;
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // txtTDHT
      // 
      this.txtTDHT.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.txtTDHT, "txtTDHT");
      this.txtTDHT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.txtTDHT.HelpContextID = 0;
      this.txtTDHT.Name = "txtTDHT";
      // 
      // frmPrestationsDevisST
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.cmdValider);
      this.Controls.Add(this.Frame7);
      this.Controls.Add(this.cmdSupp);
      this.Controls.Add(this.cmdAjouter);
      this.Controls.Add(this.Frame1);
      this.Controls.Add(this.Label1);
      this.Name = "frmPrestationsDevisST";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmPrestationsDevisST_Load);
      this.Frame7.ResumeLayout(false);
      this.Frame1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiTGrid apiTGridPrestSaisie;
    private MozartUC.apiGroupBox Frame7;
    private MozartUC.apiButton cmdSupp;
    private MozartUC.apiTGrid apiTGridHaut;
    private MozartUC.apiGroupBox Frame1;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    private MozartUC.apiLabel Label1;
    private MozartUC.apiButton cmdAjouter;
    private MozartUC.apiLabel txtTDHT;
  }
}
