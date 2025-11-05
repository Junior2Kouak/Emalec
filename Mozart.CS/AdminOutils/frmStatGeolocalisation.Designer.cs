namespace MozartCS
{
  partial class frmStatGeolocalisation
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStatGeolocalisation));
      this.CmdVisu = new MozartUC.apiButton();
      this.apiTGrid2 = new MozartUC.apiTGrid();
      this.Frame2 = new MozartUC.apiGroupBox();
      this.apiTGrid1 = new MozartUC.apiTGrid();
      this.cmdValider = new MozartUC.apiButton();
      this.cmdQuitter = new MozartUC.apiButton();
      this.Label7 = new System.Windows.Forms.Label();
      this.Frame2.SuspendLayout();
      this.SuspendLayout();
      // 
      // CmdVisu
      // 
      this.CmdVisu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.CmdVisu, "CmdVisu");
      this.CmdVisu.HelpContextID = 20;
      this.CmdVisu.Name = "CmdVisu";
      this.CmdVisu.Tag = "35";
      this.CmdVisu.UseVisualStyleBackColor = false;
      this.CmdVisu.Click += new System.EventHandler(this.CmdVisu_Click);
      // 
      // apiTGrid2
      // 
      this.apiTGrid2.FilterBar = true;
      this.apiTGrid2.FooterBar = true;
      resources.ApplyResources(this.apiTGrid2, "apiTGrid2");
      this.apiTGrid2.Name = "apiTGrid2";
      // 
      // Frame2
      // 
      this.Frame2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.Frame2.Controls.Add(this.apiTGrid1);
      this.Frame2.Controls.Add(this.apiTGrid2);
      resources.ApplyResources(this.Frame2, "Frame2");
      this.Frame2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Frame2.HelpContextID = 0;
      this.Frame2.Name = "Frame2";
      this.Frame2.TabStop = false;
      // 
      // apiTGrid1
      // 
      this.apiTGrid1.FilterBar = true;
      this.apiTGrid1.FooterBar = true;
      resources.ApplyResources(this.apiTGrid1, "apiTGrid1");
      this.apiTGrid1.Name = "apiTGrid1";
      // 
      // cmdValider
      // 
      this.cmdValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.cmdValider, "cmdValider");
      this.cmdValider.HelpContextID = 20;
      this.cmdValider.Name = "cmdValider";
      this.cmdValider.Tag = "66";
      this.cmdValider.UseVisualStyleBackColor = false;
      this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
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
      this.Label7.BackColor = System.Drawing.Color.Wheat;
      this.Label7.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label7.Name = "Label7";
      // 
      // frmStatGeolocalisation
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdQuitter;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.CmdVisu);
      this.Controls.Add(this.Frame2);
      this.Controls.Add(this.cmdValider);
      this.Controls.Add(this.cmdQuitter);
      this.Controls.Add(this.Label7);
      this.Name = "frmStatGeolocalisation";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmStatGeolocalisation_Load);
      this.Frame2.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton CmdVisu;
    private MozartUC.apiTGrid apiTGrid2;
    private MozartUC.apiGroupBox Frame2;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiButton cmdQuitter;
    private System.Windows.Forms.Label Label7;
    private MozartUC.apiTGrid apiTGrid1;
  }
}
