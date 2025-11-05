namespace MozartCS
{
  partial class frmStatNbParSite
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStatNbParSite));
      this.apiTGridTot = new MozartUC.apiTGrid();
      this.apiTGridDet = new MozartUC.apiTGrid();
      this.Imprimer = new MozartUC.apiButton();
      this.cmdQuitter = new MozartUC.apiButton();
      this.Label7 = new MozartUC.apiLabel();
      this.Label3 = new MozartUC.apiLabel();
      this.Label4 = new MozartUC.apiLabel();
      this.Label6 = new MozartUC.apiLabel();
      this.Frame1 = new MozartUC.apiGroupBox();
      this.Frame1.SuspendLayout();
      this.SuspendLayout();
      // 
      // apiTGridTot
      // 
      resources.ApplyResources(this.apiTGridTot, "apiTGridTot");
      this.apiTGridTot.FilterBar = true;
      this.apiTGridTot.FooterBar = true;
      this.apiTGridTot.Name = "apiTGridTot";
      // 
      // apiTGridDet
      // 
      resources.ApplyResources(this.apiTGridDet, "apiTGridDet");
      this.apiTGridDet.FilterBar = true;
      this.apiTGridDet.FooterBar = true;
      this.apiTGridDet.Name = "apiTGridDet";
      // 
      // Imprimer
      // 
      resources.ApplyResources(this.Imprimer, "Imprimer");
      this.Imprimer.HelpContextID = 0;
      this.Imprimer.Name = "Imprimer";
      this.Imprimer.Tag = "17";
      this.Imprimer.UseVisualStyleBackColor = true;
      this.Imprimer.Click += new System.EventHandler(this.Imprimer_Click);
      // 
      // cmdQuitter
      // 
      resources.ApplyResources(this.cmdQuitter, "cmdQuitter");
      this.cmdQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdQuitter.HelpContextID = 0;
      this.cmdQuitter.Name = "cmdQuitter";
      this.cmdQuitter.Tag = "15";
      this.cmdQuitter.UseVisualStyleBackColor = true;
      this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
      // 
      // Label7
      // 
      resources.ApplyResources(this.Label7, "Label7");
      this.Label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.Label7.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label7.HelpContextID = 0;
      this.Label7.Name = "Label7";
      // 
      // Label3
      // 
      resources.ApplyResources(this.Label3, "Label3");
      this.Label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label3.HelpContextID = 0;
      this.Label3.Name = "Label3";
      // 
      // Label4
      // 
      resources.ApplyResources(this.Label4, "Label4");
      this.Label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label4.HelpContextID = 0;
      this.Label4.Name = "Label4";
      // 
      // Label6
      // 
      resources.ApplyResources(this.Label6, "Label6");
      this.Label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.Label6.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label6.HelpContextID = 0;
      this.Label6.Name = "Label6";
      // 
      // Frame1
      // 
      resources.ApplyResources(this.Frame1, "Frame1");
      this.Frame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.Frame1.Controls.Add(this.Label7);
      this.Frame1.Controls.Add(this.Label3);
      this.Frame1.Controls.Add(this.Label4);
      this.Frame1.Controls.Add(this.Label6);
      this.Frame1.HelpContextID = 0;
      this.Frame1.Name = "Frame1";
      this.Frame1.TabStop = false;
      // 
      // frmStatNbParSite
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdQuitter;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.apiTGridTot);
      this.Controls.Add(this.apiTGridDet);
      this.Controls.Add(this.Imprimer);
      this.Controls.Add(this.cmdQuitter);
      this.Controls.Add(this.Frame1);
      this.Name = "frmStatNbParSite";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmStatNbParSite_Load);
      this.Frame1.ResumeLayout(false);
      this.Frame1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private MozartUC.apiTGrid apiTGridTot;
    private MozartUC.apiTGrid apiTGridDet;
    private MozartUC.apiButton Imprimer;
    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiLabel Label7;
    private MozartUC.apiLabel Label3;
    private MozartUC.apiLabel Label4;
    private MozartUC.apiLabel Label6;
    private MozartUC.apiGroupBox Frame1;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
