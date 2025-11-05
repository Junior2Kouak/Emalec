
namespace MozartCS
{
  partial class frmListeGMAOClient
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListeGMAOClient));
      this.cmdNouvelle = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.apiTGrid1 = new MozartUC.apiTGrid();
      this.Label14 = new MozartUC.apiLabel();
      this.cmdModif = new MozartUC.apiButton();
      this.SuspendLayout();
      // 
      // cmdNouvelle
      // 
      resources.ApplyResources(this.cmdNouvelle, "cmdNouvelle");
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
      // Label14
      // 
      resources.ApplyResources(this.Label14, "Label14");
      this.Label14.BackColor = System.Drawing.Color.Wheat;
      this.Label14.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label14.HelpContextID = 0;
      this.Label14.Name = "Label14";
      // 
      // cmdModif
      // 
      resources.ApplyResources(this.cmdModif, "cmdModif");
      this.cmdModif.HelpContextID = 15;
      this.cmdModif.Name = "cmdModif";
      this.cmdModif.Tag = "2";
      this.cmdModif.UseVisualStyleBackColor = true;
      this.cmdModif.Click += new System.EventHandler(this.cmdModif_Click);
      // 
      // frmListeGMAOClient
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      this.Controls.Add(this.cmdModif);
      this.Controls.Add(this.cmdNouvelle);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.apiTGrid1);
      this.Controls.Add(this.Label14);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.Name = "frmListeGMAOClient";
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.Load += new System.EventHandler(this.frmListeGMAOClient_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdNouvelle;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiTGrid apiTGrid1;
    private MozartUC.apiLabel Label14;
    private MozartUC.apiButton cmdModif;
  }
}