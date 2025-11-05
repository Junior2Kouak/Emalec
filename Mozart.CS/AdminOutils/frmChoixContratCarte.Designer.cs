namespace MozartCS
{
  partial class frmChoixContratCarte
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChoixContratCarte));
      this.cboTypeContrat = new System.Windows.Forms.ComboBox();
      this.cboAnnee = new System.Windows.Forms.ComboBox();
      this.cboPrestation = new System.Windows.Forms.ComboBox();
      this.cmdValider = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.lblCont = new System.Windows.Forms.Label();
      this.lblannee = new MozartUC.apiLabel();
      this.lblPrest = new MozartUC.apiLabel();
      this.Label1 = new System.Windows.Forms.Label();
      this.apiTGrid1 = new MozartUC.apiTGrid();
      this.SuspendLayout();
      // 
      // cboTypeContrat
      // 
      this.cboTypeContrat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      resources.ApplyResources(this.cboTypeContrat, "cboTypeContrat");
      this.cboTypeContrat.Name = "cboTypeContrat";
      // 
      // cboAnnee
      // 
      this.cboAnnee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      resources.ApplyResources(this.cboAnnee, "cboAnnee");
      this.cboAnnee.Name = "cboAnnee";
      // 
      // cboPrestation
      // 
      this.cboPrestation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      resources.ApplyResources(this.cboPrestation, "cboPrestation");
      this.cboPrestation.Name = "cboPrestation";
      // 
      // cmdValider
      // 
      resources.ApplyResources(this.cmdValider, "cmdValider");
      this.cmdValider.HelpContextID = 0;
      this.cmdValider.Name = "cmdValider";
      this.cmdValider.Tag = "29";
      this.cmdValider.UseVisualStyleBackColor = true;
      this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Tag = "15";
      this.cmdFermer.UseVisualStyleBackColor = true;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // lblCont
      // 
      this.lblCont.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.lblCont, "lblCont");
      this.lblCont.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblCont.Name = "lblCont";
      // 
      // lblannee
      // 
      this.lblannee.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.lblannee, "lblannee");
      this.lblannee.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblannee.HelpContextID = 0;
      this.lblannee.Name = "lblannee";
      // 
      // lblPrest
      // 
      this.lblPrest.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.lblPrest, "lblPrest");
      this.lblPrest.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblPrest.HelpContextID = 0;
      this.lblPrest.Name = "lblPrest";
      this.lblPrest.Tag = "";
      // 
      // Label1
      // 
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.Name = "Label1";
      // 
      // apiTGrid1
      // 
      this.apiTGrid1.FilterBar = true;
      this.apiTGrid1.FooterBar = true;
      resources.ApplyResources(this.apiTGrid1, "apiTGrid1");
      this.apiTGrid1.Name = "apiTGrid1";
      this.apiTGrid1.ClickE += new MozartUC.apiTGrid.ClickEEventHandler(this.apiTGrid1_ClickE);
      // 
      // frmChoixContratCarte
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.apiTGrid1);
      this.Controls.Add(this.cboTypeContrat);
      this.Controls.Add(this.cboAnnee);
      this.Controls.Add(this.cboPrestation);
      this.Controls.Add(this.cmdValider);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.lblCont);
      this.Controls.Add(this.lblannee);
      this.Controls.Add(this.lblPrest);
      this.Controls.Add(this.Label1);
      this.Name = "frmChoixContratCarte";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmChoixContratCarte_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ComboBox cboTypeContrat;
    private System.Windows.Forms.ComboBox cboAnnee;
    private System.Windows.Forms.ComboBox cboPrestation;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiButton cmdFermer;
    private System.Windows.Forms.Label lblCont;
    private MozartUC.apiLabel lblannee;
    private MozartUC.apiLabel lblPrest;
    private System.Windows.Forms.Label Label1;
    private MozartUC.apiTGrid apiTGrid1;
  }
}
