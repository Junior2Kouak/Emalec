namespace MozartCS
{
  partial class frmListeDISTT
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListeDISTT));
      this.cmdModifier = new MozartUC.apiButton();
      this.txtCritSTF = new MozartUC.apiCombo();
      this.cmdQuitter = new MozartUC.apiButton();
      this.cmdFind = new MozartUC.apiButton();
      this.Label7 = new MozartUC.apiLabel();
      this.Label15 = new MozartUC.apiLabel();
      this.fraCriteres = new MozartUC.apiGroupBox();
      this.apiGrid = new MozartUC.apiTGrid();
      this.Label1 = new MozartUC.apiLabel();
      this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
      this.fraCriteres.SuspendLayout();
      this.SuspendLayout();
      // 
      // cmdModifier
      // 
      resources.ApplyResources(this.cmdModifier, "cmdModifier");
      this.cmdModifier.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdModifier.HelpContextID = 16;
      this.cmdModifier.Name = "cmdModifier";
      this.cmdModifier.Tag = "19";
      this.cmdModifier.UseVisualStyleBackColor = true;
      this.cmdModifier.Click += new System.EventHandler(this.cmdModifier_Click);
      // 
      // txtCritSTF
      // 
      resources.ApplyResources(this.txtCritSTF, "txtCritSTF");
      this.txtCritSTF.Name = "txtCritSTF";
      // 
      // cmdQuitter
      // 
      resources.ApplyResources(this.cmdQuitter, "cmdQuitter");
      this.cmdQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdQuitter.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdQuitter.HelpContextID = 0;
      this.cmdQuitter.Name = "cmdQuitter";
      this.cmdQuitter.Tag = "15";
      this.cmdQuitter.UseVisualStyleBackColor = true;
      this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
      // 
      // cmdFind
      // 
      this.cmdFind.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdFind.HelpContextID = 0;
      this.cmdFind.Image = global::MozartCS.Properties.Resources.Find;
      resources.ApplyResources(this.cmdFind, "cmdFind");
      this.cmdFind.Name = "cmdFind";
      this.cmdFind.Tag = "8";
      this.cmdFind.UseVisualStyleBackColor = true;
      this.cmdFind.Click += new System.EventHandler(this.cmdFind_Click);
      // 
      // Label7
      // 
      this.Label7.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label7.HelpContextID = 0;
      resources.ApplyResources(this.Label7, "Label7");
      this.Label7.Name = "Label7";
      // 
      // Label15
      // 
      resources.ApplyResources(this.Label15, "Label15");
      this.Label15.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label15.HelpContextID = 0;
      this.Label15.Name = "Label15";
      // 
      // fraCriteres
      // 
      resources.ApplyResources(this.fraCriteres, "fraCriteres");
      this.fraCriteres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(218)))), ((int)(((byte)(242)))));
      this.fraCriteres.Controls.Add(this.cmdFind);
      this.fraCriteres.Controls.Add(this.Label7);
      this.fraCriteres.Controls.Add(this.Label15);
      this.fraCriteres.HelpContextID = 0;
      this.fraCriteres.Name = "fraCriteres";
      this.fraCriteres.TabStop = false;
      // 
      // apiGrid
      // 
      resources.ApplyResources(this.apiGrid, "apiGrid");
      this.apiGrid.FilterBar = true;
      this.apiGrid.FooterBar = true;
      this.apiGrid.Name = "apiGrid";
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // frmListeDISTT
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdQuitter;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.txtCritSTF);
      this.Controls.Add(this.cmdModifier);
      this.Controls.Add(this.cmdQuitter);
      this.Controls.Add(this.fraCriteres);
      this.Controls.Add(this.apiGrid);
      this.Controls.Add(this.Label1);
      this.KeyPreview = true;
      this.Name = "frmListeDISTT";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmListeDISTT_Load);
      this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmListeDISTT_KeyUp);
      this.fraCriteres.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdModifier;
    private MozartUC.apiCombo txtCritSTF;
    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiButton cmdFind;
    private MozartUC.apiLabel Label7;
    private MozartUC.apiLabel Label15;
    private MozartUC.apiGroupBox fraCriteres;
    private MozartUC.apiTGrid apiGrid;
    private MozartUC.apiLabel Label1;
    private DevExpress.Utils.ToolTipController toolTipController1;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
