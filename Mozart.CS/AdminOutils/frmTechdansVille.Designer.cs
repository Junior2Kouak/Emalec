namespace MozartCS
{
  partial class frmTechDansVille
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTechDansVille));
      this.cmdDI = new MozartUC.apiButton();
      this.apicboCP = new MozartUC.apiCombo();
      this.apicboVille = new MozartUC.apiCombo();
      this.Label2 = new System.Windows.Forms.Label();
      this.lblContact = new System.Windows.Forms.Label();
      this.Frame1 = new MozartUC.apiGroupBox();
      this.cmdFermer = new MozartUC.apiButton();
      this.cmdValider = new MozartUC.apiButton();
      this.Label1 = new System.Windows.Forms.Label();
      this.apiTGrid1 = new MozartUC.apiTGrid();
      this.Frame1.SuspendLayout();
      this.SuspendLayout();
      // 
      // cmdDI
      // 
      resources.ApplyResources(this.cmdDI, "cmdDI");
      this.cmdDI.HelpContextID = 0;
      this.cmdDI.Name = "cmdDI";
      this.cmdDI.Tag = "19";
      this.cmdDI.UseVisualStyleBackColor = true;
      this.cmdDI.Click += new System.EventHandler(this.cmdDI_Click);
      // 
      // apicboCP
      // 
      resources.ApplyResources(this.apicboCP, "apicboCP");
      this.apicboCP.Name = "apicboCP";
      this.apicboCP.TxtChanged += new MozartUC.apiCombo.TxtChangedEventHandler(this.cboCP_TxtChanged);
      // 
      // apicboVille
      // 
      resources.ApplyResources(this.apicboVille, "apicboVille");
      this.apicboVille.Name = "apicboVille";
      this.apicboVille.TxtChanged += new MozartUC.apiCombo.TxtChangedEventHandler(this.cboVille_TxtChanged);
      // 
      // Label2
      // 
      resources.ApplyResources(this.Label2, "Label2");
      this.Label2.BackColor = System.Drawing.Color.Wheat;
      this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label2.Name = "Label2";
      // 
      // lblContact
      // 
      resources.ApplyResources(this.lblContact, "lblContact");
      this.lblContact.BackColor = System.Drawing.Color.Wheat;
      this.lblContact.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblContact.Name = "lblContact";
      // 
      // Frame1
      // 
      this.Frame1.BackColor = System.Drawing.Color.Wheat;
      this.Frame1.Controls.Add(this.apicboCP);
      this.Frame1.Controls.Add(this.apicboVille);
      this.Frame1.Controls.Add(this.Label2);
      this.Frame1.Controls.Add(this.lblContact);
      this.Frame1.HelpContextID = 0;
      resources.ApplyResources(this.Frame1, "Frame1");
      this.Frame1.Name = "Frame1";
      this.Frame1.TabStop = false;
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Tag = "15";
      this.cmdFermer.UseVisualStyleBackColor = true;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // cmdValider
      // 
      resources.ApplyResources(this.cmdValider, "cmdValider");
      this.cmdValider.HelpContextID = 0;
      this.cmdValider.Name = "cmdValider";
      this.cmdValider.Tag = "66";
      this.cmdValider.UseVisualStyleBackColor = true;
      this.cmdValider.Click += new System.EventHandler(this.cmdEnregistrer_Click);
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.Name = "Label1";
      // 
      // apiTGrid1
      // 
      this.apiTGrid1.FilterBar = true;
      this.apiTGrid1.FooterBar = true;
      resources.ApplyResources(this.apiTGrid1, "apiTGrid1");
      this.apiTGrid1.Name = "apiTGrid1";
      // 
      // frmTechDansVille
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.apiTGrid1);
      this.Controls.Add(this.cmdDI);
      this.Controls.Add(this.Frame1);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.cmdValider);
      this.Controls.Add(this.Label1);
      this.Name = "frmTechDansVille";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmTechDansVille_Load);
      this.Frame1.ResumeLayout(false);
      this.Frame1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdDI;
    private MozartUC.apiCombo apicboCP;
    private MozartUC.apiCombo apicboVille;
    private System.Windows.Forms.Label Label2;
    private System.Windows.Forms.Label lblContact;
    private MozartUC.apiGroupBox Frame1;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiButton cmdValider;
    private System.Windows.Forms.Label Label1;
    private MozartUC.apiTGrid apiTGrid1;
  }
}
