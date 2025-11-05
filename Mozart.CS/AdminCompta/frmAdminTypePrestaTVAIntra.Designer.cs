
namespace MozartCS
{
  partial class frmAdminTypePrestaTVAIntra
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminTypePrestaTVAIntra));
      this.cmdFermer = new MozartUC.apiButton();
      this.Label1 = new MozartUC.apiLabel();
      this.apiGroupBox1 = new MozartUC.apiGroupBox();
      this.apiTGridPresta = new MozartUC.apiTGrid();
      this.apiGroupBox2 = new MozartUC.apiGroupBox();
      this.apiTGridCate = new MozartUC.apiTGrid();
      this.cmdAjouterTypePresta = new MozartUC.apiButton();
      this.cmdSupprTypePresta = new MozartUC.apiButton();
      this.apiGroupBox1.SuspendLayout();
      this.apiGroupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdFermer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Tag = "15";
      this.cmdFermer.UseVisualStyleBackColor = false;
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // apiGroupBox1
      // 
      resources.ApplyResources(this.apiGroupBox1, "apiGroupBox1");
      this.apiGroupBox1.BackColor = System.Drawing.Color.Wheat;
      this.apiGroupBox1.Controls.Add(this.apiTGridPresta);
      this.apiGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.apiGroupBox1.FrameColor = System.Drawing.Color.Empty;
      this.apiGroupBox1.HelpContextID = 0;
      this.apiGroupBox1.Name = "apiGroupBox1";
      this.apiGroupBox1.TabStop = false;
      // 
      // apiTGridPresta
      // 
      resources.ApplyResources(this.apiTGridPresta, "apiTGridPresta");
      this.apiTGridPresta.FilterBar = true;
      this.apiTGridPresta.FooterBar = true;
      this.apiTGridPresta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.apiTGridPresta.Name = "apiTGridPresta";
      // 
      // apiGroupBox2
      // 
      resources.ApplyResources(this.apiGroupBox2, "apiGroupBox2");
      this.apiGroupBox2.BackColor = System.Drawing.Color.Wheat;
      this.apiGroupBox2.Controls.Add(this.apiTGridCate);
      this.apiGroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.apiGroupBox2.FrameColor = System.Drawing.Color.Empty;
      this.apiGroupBox2.HelpContextID = 0;
      this.apiGroupBox2.Name = "apiGroupBox2";
      this.apiGroupBox2.TabStop = false;
      // 
      // apiTGridCate
      // 
      resources.ApplyResources(this.apiTGridCate, "apiTGridCate");
      this.apiTGridCate.FilterBar = true;
      this.apiTGridCate.FooterBar = true;
      this.apiTGridCate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.apiTGridCate.Name = "apiTGridCate";
      this.apiTGridCate.SelectionChanged += new MozartUC.apiTGrid.SelectionChangedEventHandler(this.apiTGrid1_SelectionChanged);
      // 
      // cmdAjouterTypePresta
      // 
      resources.ApplyResources(this.cmdAjouterTypePresta, "cmdAjouterTypePresta");
      this.cmdAjouterTypePresta.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdAjouterTypePresta.HelpContextID = 22;
      this.cmdAjouterTypePresta.Name = "cmdAjouterTypePresta";
      this.cmdAjouterTypePresta.Tag = "2";
      this.cmdAjouterTypePresta.UseVisualStyleBackColor = true;
      this.cmdAjouterTypePresta.Click += new System.EventHandler(this.cmdAjouterTypePresta_Click);
      // 
      // cmdSupprTypePresta
      // 
      resources.ApplyResources(this.cmdSupprTypePresta, "cmdSupprTypePresta");
      this.cmdSupprTypePresta.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdSupprTypePresta.HelpContextID = 22;
      this.cmdSupprTypePresta.Name = "cmdSupprTypePresta";
      this.cmdSupprTypePresta.Tag = "2";
      this.cmdSupprTypePresta.UseVisualStyleBackColor = true;
      this.cmdSupprTypePresta.Click += new System.EventHandler(this.cmdSupprTypePresta_Click);
      // 
      // frmAdminTypePrestaTVAIntra
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      this.Controls.Add(this.cmdSupprTypePresta);
      this.Controls.Add(this.cmdAjouterTypePresta);
      this.Controls.Add(this.apiGroupBox2);
      this.Controls.Add(this.apiGroupBox1);
      this.Controls.Add(this.Label1);
      this.Controls.Add(this.cmdFermer);
      this.Name = "frmAdminTypePrestaTVAIntra";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmAdminTypePrestaTVAIntra_Load);
      this.apiGroupBox1.ResumeLayout(false);
      this.apiGroupBox2.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiLabel Label1;
    private MozartUC.apiGroupBox apiGroupBox1;
    private MozartUC.apiTGrid apiTGridPresta;
    private MozartUC.apiGroupBox apiGroupBox2;
    private MozartUC.apiTGrid apiTGridCate;
    internal MozartUC.apiButton cmdAjouterTypePresta;
    internal MozartUC.apiButton cmdSupprTypePresta;
  }
}