namespace MozartCS
{
  partial class frmRecherchePrestAvenant
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecherchePrestAvenant));
      this.apiTGridPrestSaisie = new MozartUC.apiTGrid();
      this.Label2 = new MozartUC.apiLabel();
      this.Frame2 = new MozartUC.apiGroupBox();
      this.apiTGridPrest = new MozartUC.apiTGrid();
      this.Frame1 = new MozartUC.apiGroupBox();
      this.cmdFermer = new MozartUC.apiButton();
      this.chkPrestation = new MozartUC.apiCheckBox();
      this.chkUtil = new MozartUC.apiCheckBox();
      this.cmdAjouter = new MozartUC.apiButton();
      this.cmdSupp = new MozartUC.apiButton();
      this.Label1 = new MozartUC.apiLabel();
      this.Frame2.SuspendLayout();
      this.Frame1.SuspendLayout();
      this.SuspendLayout();
      // 
      // apiTGridPrestSaisie
      // 
      resources.ApplyResources(this.apiTGridPrestSaisie, "apiTGridPrestSaisie");
      this.apiTGridPrestSaisie.FilterBar = true;
      this.apiTGridPrestSaisie.FooterBar = true;
      this.apiTGridPrestSaisie.ForeColor = System.Drawing.Color.Black;
      this.apiTGridPrestSaisie.Name = "apiTGridPrestSaisie";
      this.apiTGridPrestSaisie.RowCellStyle += new MozartUC.apiTGrid.RowCellStyleEventHandler(this.apiTGridPrestSaisie_RowCellStyle);
      this.apiTGridPrestSaisie.CellValueChanged += new MozartUC.apiTGrid.CellValueChangedEventHandler(this.apiTGridPrestSaisie_CellValueChanged);
      // 
      // Label2
      // 
      resources.ApplyResources(this.Label2, "Label2");
      this.Label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label2.HelpContextID = 0;
      this.Label2.Name = "Label2";
      // 
      // Frame2
      // 
      resources.ApplyResources(this.Frame2, "Frame2");
      this.Frame2.BackColor = System.Drawing.Color.Wheat;
      this.Frame2.Controls.Add(this.apiTGridPrestSaisie);
      this.Frame2.Controls.Add(this.Label2);
      this.Frame2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Frame2.HelpContextID = 0;
      this.Frame2.Name = "Frame2";
      this.Frame2.TabStop = false;
      // 
      // apiTGridPrest
      // 
      resources.ApplyResources(this.apiTGridPrest, "apiTGridPrest");
      this.apiTGridPrest.FilterBar = true;
      this.apiTGridPrest.FooterBar = true;
      this.apiTGridPrest.ForeColor = System.Drawing.Color.Black;
      this.apiTGridPrest.Name = "apiTGridPrest";
      this.apiTGridPrest.DoubleClickE += new MozartUC.apiTGrid.DoubleClickEEventHandler(this.apiTGridPrest_DoubleClickE);
      this.apiTGridPrest.RowCellStyle += new MozartUC.apiTGrid.RowCellStyleEventHandler(this.apiTGridPrest_RowCellStyle);
      // 
      // Frame1
      // 
      resources.ApplyResources(this.Frame1, "Frame1");
      this.Frame1.BackColor = System.Drawing.Color.Wheat;
      this.Frame1.Controls.Add(this.apiTGridPrest);
      this.Frame1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Frame1.HelpContextID = 0;
      this.Frame1.Name = "Frame1";
      this.Frame1.TabStop = false;
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
      // chkPrestation
      // 
      this.chkPrestation.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.chkPrestation, "chkPrestation");
      this.chkPrestation.ForeColor = System.Drawing.SystemColors.ControlText;
      this.chkPrestation.HelpContextID = 0;
      this.chkPrestation.Name = "chkPrestation";
      this.chkPrestation.UseVisualStyleBackColor = false;
      this.chkPrestation.CheckedChanged += new System.EventHandler(this.chkPrestationUtil_CheckedChanged);
      // 
      // chkUtil
      // 
      this.chkUtil.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.chkUtil, "chkUtil");
      this.chkUtil.ForeColor = System.Drawing.SystemColors.ControlText;
      this.chkUtil.HelpContextID = 0;
      this.chkUtil.Name = "chkUtil";
      this.chkUtil.UseVisualStyleBackColor = false;
      this.chkUtil.CheckedChanged += new System.EventHandler(this.chkPrestationUtil_CheckedChanged);
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
      // cmdSupp
      // 
      resources.ApplyResources(this.cmdSupp, "cmdSupp");
      this.cmdSupp.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdSupp.HelpContextID = 0;
      this.cmdSupp.Image = global::MozartCS.Properties.Resources.delete_32;
      this.cmdSupp.Name = "cmdSupp";
      this.cmdSupp.Tag = "27";
      this.cmdSupp.UseVisualStyleBackColor = true;
      this.cmdSupp.Click += new System.EventHandler(this.cmdSupp_Click);
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // frmRecherchePrestAvenant
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.Frame2);
      this.Controls.Add(this.Frame1);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.chkPrestation);
      this.Controls.Add(this.chkUtil);
      this.Controls.Add(this.cmdAjouter);
      this.Controls.Add(this.cmdSupp);
      this.Controls.Add(this.Label1);
      this.Name = "frmRecherchePrestAvenant";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmRecherchePrestAvenant_Load);
      this.Frame2.ResumeLayout(false);
      this.Frame2.PerformLayout();
      this.Frame1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiTGrid apiTGridPrestSaisie;
    private MozartUC.apiLabel Label2;
    private MozartUC.apiGroupBox Frame2;
    private MozartUC.apiTGrid apiTGridPrest;
    private MozartUC.apiGroupBox Frame1;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiCheckBox chkPrestation;
    private MozartUC.apiCheckBox chkUtil;
    private MozartUC.apiButton cmdAjouter;
    private MozartUC.apiButton cmdSupp;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    private MozartUC.apiLabel Label1;

  }
}
