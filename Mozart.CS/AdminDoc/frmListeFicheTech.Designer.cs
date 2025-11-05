namespace MozartCS
{
  partial class frmListeFicheTech
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListeFicheTech));
      this.cboSociete = new System.Windows.Forms.ComboBox();
      this.CmdStatCliCom = new MozartUC.apiButton();
      this.cmdValider = new MozartUC.apiButton();
      this.Label50 = new MozartUC.apiLabel();
      this.Label52 = new MozartUC.apiLabel();
      this.Frame1 = new MozartUC.apiGroupBox();
      this.cmdCopier = new MozartUC.apiButton();
      this.cmdArchive = new MozartUC.apiButton();
      this.cmdArch = new MozartUC.apiButton();
      this.cmdModifier = new MozartUC.apiButton();
      this.cmdAjouter = new MozartUC.apiButton();
      this.cmdVisu = new MozartUC.apiButton();
      this.cmdQuitter = new MozartUC.apiButton();
      this.apiTGrid_FicheTech = new MozartUC.apiTGrid();
      this.Label1 = new MozartUC.apiLabel();
      this.Frame1.SuspendLayout();
      this.SuspendLayout();
      // 
      // cboSociete
      // 
      this.cboSociete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.cboSociete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      resources.ApplyResources(this.cboSociete, "cboSociete");
      this.cboSociete.Name = "cboSociete";
      // 
      // CmdStatCliCom
      // 
      this.CmdStatCliCom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.CmdStatCliCom, "CmdStatCliCom");
      this.CmdStatCliCom.ForeColor = System.Drawing.SystemColors.ControlText;
      this.CmdStatCliCom.HelpContextID = 0;
      this.CmdStatCliCom.Name = "CmdStatCliCom";
      this.CmdStatCliCom.Tag = "67";
      this.CmdStatCliCom.UseVisualStyleBackColor = false;
      this.CmdStatCliCom.Click += new System.EventHandler(this.CmdStatCliCom_Click);
      // 
      // cmdValider
      // 
      this.cmdValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.cmdValider, "cmdValider");
      this.cmdValider.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdValider.HelpContextID = 0;
      this.cmdValider.Name = "cmdValider";
      this.cmdValider.Tag = "35";
      this.cmdValider.UseVisualStyleBackColor = false;
      this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
      // 
      // Label50
      // 
      resources.ApplyResources(this.Label50, "Label50");
      this.Label50.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.Label50.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label50.HelpContextID = 0;
      this.Label50.Name = "Label50";
      // 
      // Label52
      // 
      resources.ApplyResources(this.Label52, "Label52");
      this.Label52.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.Label52.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label52.HelpContextID = 0;
      this.Label52.Name = "Label52";
      // 
      // Frame1
      // 
      this.Frame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.Frame1.Controls.Add(this.cboSociete);
      this.Frame1.Controls.Add(this.CmdStatCliCom);
      this.Frame1.Controls.Add(this.cmdValider);
      this.Frame1.Controls.Add(this.Label50);
      this.Frame1.Controls.Add(this.Label52);
      resources.ApplyResources(this.Frame1, "Frame1");
      this.Frame1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Frame1.FrameColor = System.Drawing.Color.Empty;
      this.Frame1.HelpContextID = 0;
      this.Frame1.Name = "Frame1";
      this.Frame1.TabStop = false;
      // 
      // cmdCopier
      // 
      resources.ApplyResources(this.cmdCopier, "cmdCopier");
      this.cmdCopier.HelpContextID = 676;
      this.cmdCopier.Name = "cmdCopier";
      this.cmdCopier.UseVisualStyleBackColor = true;
      this.cmdCopier.Click += new System.EventHandler(this.cmdCopier_Click);
      // 
      // cmdArchive
      // 
      resources.ApplyResources(this.cmdArchive, "cmdArchive");
      this.cmdArchive.HelpContextID = 0;
      this.cmdArchive.Name = "cmdArchive";
      this.cmdArchive.Tag = "61";
      this.cmdArchive.UseVisualStyleBackColor = true;
      this.cmdArchive.Click += new System.EventHandler(this.cmdArchive_Click);
      // 
      // cmdArch
      // 
      resources.ApplyResources(this.cmdArch, "cmdArch");
      this.cmdArch.HelpContextID = 317;
      this.cmdArch.Name = "cmdArch";
      this.cmdArch.Tag = "27";
      this.cmdArch.UseVisualStyleBackColor = true;
      this.cmdArch.Click += new System.EventHandler(this.cmdArch_Click);
      // 
      // cmdModifier
      // 
      resources.ApplyResources(this.cmdModifier, "cmdModifier");
      this.cmdModifier.HelpContextID = 317;
      this.cmdModifier.Name = "cmdModifier";
      this.cmdModifier.Tag = "19";
      this.cmdModifier.UseVisualStyleBackColor = true;
      this.cmdModifier.Click += new System.EventHandler(this.cmdModifier_Click);
      // 
      // cmdAjouter
      // 
      resources.ApplyResources(this.cmdAjouter, "cmdAjouter");
      this.cmdAjouter.HelpContextID = 317;
      this.cmdAjouter.Name = "cmdAjouter";
      this.cmdAjouter.Tag = "2";
      this.cmdAjouter.UseVisualStyleBackColor = true;
      this.cmdAjouter.Click += new System.EventHandler(this.cmdAjouter_Click);
      // 
      // cmdVisu
      // 
      resources.ApplyResources(this.cmdVisu, "cmdVisu");
      this.cmdVisu.HelpContextID = 0;
      this.cmdVisu.Name = "cmdVisu";
      this.cmdVisu.Tag = "4";
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
      // 
      // apiTGrid_FicheTech
      // 
      resources.ApplyResources(this.apiTGrid_FicheTech, "apiTGrid_FicheTech");
      this.apiTGrid_FicheTech.FilterBar = true;
      this.apiTGrid_FicheTech.FooterBar = true;
      this.apiTGrid_FicheTech.Name = "apiTGrid_FicheTech";
      // 
      // Label1
      // 
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // frmListeFicheTech
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdQuitter;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.Frame1);
      this.Controls.Add(this.cmdCopier);
      this.Controls.Add(this.cmdArchive);
      this.Controls.Add(this.cmdArch);
      this.Controls.Add(this.cmdModifier);
      this.Controls.Add(this.cmdAjouter);
      this.Controls.Add(this.cmdVisu);
      this.Controls.Add(this.cmdQuitter);
      this.Controls.Add(this.apiTGrid_FicheTech);
      this.Controls.Add(this.Label1);
      this.Name = "frmListeFicheTech";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmListeFicheTech_Load);
      this.Frame1.ResumeLayout(false);
      this.Frame1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ComboBox cboSociete;
    private MozartUC.apiButton CmdStatCliCom;
    private MozartUC.apiLabel Label50;
    private MozartUC.apiLabel Label52;
    private MozartUC.apiGroupBox Frame1;
    private MozartUC.apiButton cmdArchive;
    private MozartUC.apiButton cmdArch;
    private MozartUC.apiButton cmdModifier;
    private MozartUC.apiButton cmdAjouter;
    private MozartUC.apiButton cmdVisu;
    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiTGrid apiTGrid_FicheTech;
    private MozartUC.apiLabel Label1;
    private MozartUC.apiButton cmdCopier;
    private MozartUC.apiButton cmdValider;
  }
}
