
namespace MozartCS.Administration
{
  partial class frmListeMailsAuto
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListeMailsAuto));
      this.cmdFermer = new MozartUC.apiButton();
      this.apiTGrid1 = new MozartUC.apiTGrid();
      this.LabelTitre = new System.Windows.Forms.Label();
      this.cmdAdd = new System.Windows.Forms.Button();
      this.cmdModifier = new System.Windows.Forms.Button();
      this.SuspendLayout();
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
      // 
      // apiTGrid1
      // 
      resources.ApplyResources(this.apiTGrid1, "apiTGrid1");
      this.apiTGrid1.FilterBar = true;
      this.apiTGrid1.FooterBar = true;
      this.apiTGrid1.Name = "apiTGrid1";
      // 
      // LabelTitre
      // 
      resources.ApplyResources(this.LabelTitre, "LabelTitre");
      this.LabelTitre.Name = "LabelTitre";
      // 
      // cmdAdd
      // 
      resources.ApplyResources(this.cmdAdd, "cmdAdd");
      this.cmdAdd.Name = "cmdAdd";
      this.cmdAdd.UseVisualStyleBackColor = true;
      this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
      // 
      // cmdModifier
      // 
      resources.ApplyResources(this.cmdModifier, "cmdModifier");
      this.cmdModifier.Name = "cmdModifier";
      this.cmdModifier.UseVisualStyleBackColor = true;
      this.cmdModifier.Click += new System.EventHandler(this.cmdModifier_Click);
      // 
      // frmListeMailsAuto
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      this.Controls.Add(this.cmdModifier);
      this.Controls.Add(this.cmdAdd);
      this.Controls.Add(this.LabelTitre);
      this.Controls.Add(this.apiTGrid1);
      this.Controls.Add(this.cmdFermer);
      this.KeyPreview = true;
      this.Name = "frmListeMailsAuto";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmListeMailsAuto_Load);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmListeMailsAuto_KeyDown);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiTGrid apiTGrid1;
    internal System.Windows.Forms.Label LabelTitre;
    internal System.Windows.Forms.Button cmdAdd;
    internal System.Windows.Forms.Button cmdModifier;
  }
}