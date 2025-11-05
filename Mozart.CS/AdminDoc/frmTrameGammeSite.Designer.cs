namespace MozartCS
{
  partial class frmTrameGammeSite
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrameGammeSite));
      this.cmdModifier = new MozartUC.apiButton();
      this.cmdEdit = new MozartUC.apiButton();
      this.cmdMod = new MozartUC.apiButton();
      this.cmdListeArch = new MozartUC.apiButton();
      this.cmdVisu = new MozartUC.apiButton();
      this.cmdQuitter = new MozartUC.apiButton();
      this.cmdArch = new MozartUC.apiButton();
      this.cmdNouvelle = new MozartUC.apiButton();
      this.Label1 = new MozartUC.apiLabel();
      this.apiTGrid_FicheTech = new MozartUC.apiTGrid();
      this.SuspendLayout();
      // 
      // cmdModifier
      // 
      resources.ApplyResources(this.cmdModifier, "cmdModifier");
      this.cmdModifier.HelpContextID = 169;
      this.cmdModifier.Name = "cmdModifier";
      this.cmdModifier.Tag = "24";
      this.cmdModifier.UseVisualStyleBackColor = true;
      this.cmdModifier.Click += new System.EventHandler(this.cmdModifier_Click);
      // 
      // cmdEdit
      // 
      resources.ApplyResources(this.cmdEdit, "cmdEdit");
      this.cmdEdit.HelpContextID = 173;
      this.cmdEdit.Name = "cmdEdit";
      this.cmdEdit.Tag = "17";
      this.cmdEdit.UseVisualStyleBackColor = true;
      this.cmdEdit.Click += new System.EventHandler(this.cmdEdit_Click);
      // 
      // cmdMod
      // 
      resources.ApplyResources(this.cmdMod, "cmdMod");
      this.cmdMod.HelpContextID = 170;
      this.cmdMod.Name = "cmdMod";
      this.cmdMod.Tag = "19";
      this.cmdMod.UseVisualStyleBackColor = true;
      this.cmdMod.Click += new System.EventHandler(this.cmdMod_Click);
      // 
      // cmdListeArch
      // 
      resources.ApplyResources(this.cmdListeArch, "cmdListeArch");
      this.cmdListeArch.HelpContextID = 172;
      this.cmdListeArch.Name = "cmdListeArch";
      this.cmdListeArch.Tag = "20";
      this.cmdListeArch.UseVisualStyleBackColor = true;
      this.cmdListeArch.Click += new System.EventHandler(this.cmdListeArch_Click);
      // 
      // cmdVisu
      // 
      resources.ApplyResources(this.cmdVisu, "cmdVisu");
      this.cmdVisu.HelpContextID = 168;
      this.cmdVisu.Name = "cmdVisu";
      this.cmdVisu.Tag = "40";
      this.cmdVisu.UseVisualStyleBackColor = true;
      this.cmdVisu.Click += new System.EventHandler(this.cmdVisu_Click);
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
      // cmdArch
      // 
      resources.ApplyResources(this.cmdArch, "cmdArch");
      this.cmdArch.HelpContextID = 171;
      this.cmdArch.Name = "cmdArch";
      this.cmdArch.Tag = "27";
      this.cmdArch.UseVisualStyleBackColor = true;
      this.cmdArch.Click += new System.EventHandler(this.cmdArch_Click);
      // 
      // cmdNouvelle
      // 
      resources.ApplyResources(this.cmdNouvelle, "cmdNouvelle");
      this.cmdNouvelle.HelpContextID = 167;
      this.cmdNouvelle.Name = "cmdNouvelle";
      this.cmdNouvelle.Tag = "2";
      this.cmdNouvelle.UseVisualStyleBackColor = true;
      this.cmdNouvelle.Click += new System.EventHandler(this.cmdNouvelle_Click);
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // apiTGrid_FicheTech
      // 
      resources.ApplyResources(this.apiTGrid_FicheTech, "apiTGrid_FicheTech");
      this.apiTGrid_FicheTech.FilterBar = true;
      this.apiTGrid_FicheTech.FooterBar = true;
      this.apiTGrid_FicheTech.Name = "apiTGrid_FicheTech";
      // 
      // frmTrameGammeSite
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdQuitter;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.apiTGrid_FicheTech);
      this.Controls.Add(this.cmdModifier);
      this.Controls.Add(this.cmdEdit);
      this.Controls.Add(this.cmdMod);
      this.Controls.Add(this.cmdListeArch);
      this.Controls.Add(this.cmdVisu);
      this.Controls.Add(this.cmdQuitter);
      this.Controls.Add(this.cmdArch);
      this.Controls.Add(this.cmdNouvelle);
      this.Controls.Add(this.Label1);
      this.Name = "frmTrameGammeSite";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmTrameGammeSite_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdModifier;
    private MozartUC.apiButton cmdEdit;
    private MozartUC.apiButton cmdMod;
    private MozartUC.apiButton cmdListeArch;
    private MozartUC.apiButton cmdVisu;
    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiButton cmdArch;
    private MozartUC.apiButton cmdNouvelle;
    private MozartUC.apiLabel Label1;
    private MozartUC.apiTGrid apiTGrid_FicheTech;
  }
}
