namespace MozartCS
{
  partial class frmListeClients
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListeClients));
      this.cmdContact = new MozartUC.apiButton();
      this.ApiGridSite = new MozartUC.apiTGrid();
      this.Frame2 = new MozartUC.apiGroupBox();
      this.ApiGrid = new MozartUC.apiTGrid();
      this.Frame1 = new MozartUC.apiGroupBox();
      this.cmdListeDevis = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.cboclient = new MozartUC.apiCombo();
      this.lblLabels11 = new MozartUC.apiLabel();
      this.Label1 = new MozartUC.apiLabel();
      this.Frame2.SuspendLayout();
      this.Frame1.SuspendLayout();
      this.SuspendLayout();
      // 
      // cmdContact
      // 
      resources.ApplyResources(this.cmdContact, "cmdContact");
      this.cmdContact.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdContact.HelpContextID = 47;
      this.cmdContact.Name = "cmdContact";
      this.cmdContact.UseVisualStyleBackColor = true;
      this.cmdContact.Click += new System.EventHandler(this.cmdContact_Click);
      // 
      // ApiGridSite
      // 
      resources.ApplyResources(this.ApiGridSite, "ApiGridSite");
      this.ApiGridSite.FilterBar = true;
      this.ApiGridSite.FooterBar = true;
      this.ApiGridSite.Name = "ApiGridSite";
      // 
      // Frame2
      // 
      resources.ApplyResources(this.Frame2, "Frame2");
      this.Frame2.BackColor = System.Drawing.Color.Wheat;
      this.Frame2.Controls.Add(this.ApiGridSite);
      this.Frame2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.Frame2.HelpContextID = 0;
      this.Frame2.Name = "Frame2";
      this.Frame2.TabStop = false;
      // 
      // ApiGrid
      // 
      resources.ApplyResources(this.ApiGrid, "ApiGrid");
      this.ApiGrid.FilterBar = true;
      this.ApiGrid.FooterBar = true;
      this.ApiGrid.Name = "ApiGrid";
      // 
      // Frame1
      // 
      resources.ApplyResources(this.Frame1, "Frame1");
      this.Frame1.BackColor = System.Drawing.Color.Wheat;
      this.Frame1.Controls.Add(this.ApiGrid);
      this.Frame1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.Frame1.HelpContextID = 0;
      this.Frame1.Name = "Frame1";
      this.Frame1.TabStop = false;
      // 
      // cmdListeDevis
      // 
      resources.ApplyResources(this.cmdListeDevis, "cmdListeDevis");
      this.cmdListeDevis.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdListeDevis.HelpContextID = 59;
      this.cmdListeDevis.Name = "cmdListeDevis";
      this.cmdListeDevis.UseVisualStyleBackColor = true;
      this.cmdListeDevis.Click += new System.EventHandler(this.cmdListeDevis_Click);
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
      // cboclient
      // 
      resources.ApplyResources(this.cboclient, "cboclient");
      this.cboclient.Name = "cboclient";
      this.cboclient.TxtChanged += new MozartUC.apiCombo.TxtChangedEventHandler(this.cboclient_TxtChanged);
      // 
      // lblLabels11
      // 
      resources.ApplyResources(this.lblLabels11, "lblLabels11");
      this.lblLabels11.BackColor = System.Drawing.Color.Wheat;
      this.lblLabels11.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels11.HelpContextID = 0;
      this.lblLabels11.Name = "lblLabels11";
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // frmListeClients
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdContact);
      this.Controls.Add(this.Frame2);
      this.Controls.Add(this.Frame1);
      this.Controls.Add(this.cmdListeDevis);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.cboclient);
      this.Controls.Add(this.lblLabels11);
      this.Controls.Add(this.Label1);
      this.Name = "frmListeClients";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmListeClients_Load);
      this.Frame2.ResumeLayout(false);
      this.Frame1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdContact;
    private MozartUC.apiTGrid ApiGridSite;
    private MozartUC.apiGroupBox Frame2;
    private MozartUC.apiTGrid ApiGrid;
    private MozartUC.apiGroupBox Frame1;
    private MozartUC.apiButton cmdListeDevis;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiCombo cboclient;
    private MozartUC.apiLabel lblLabels11;
    private MozartUC.apiLabel Label1;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
