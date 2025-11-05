namespace MozartCS
{
  partial class frmDevisClientAvenant
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDevisClientAvenant));
      this.txtPrestation = new MozartUC.apiTextBox();
      this.cmdVisu = new MozartUC.apiButton();
      this.cmdValider = new MozartUC.apiButton();
      this.CmdPrest = new MozartUC.apiButton();
      this.cmdSupp = new MozartUC.apiButton();
      this.cmdAjouter = new MozartUC.apiButton();
      this.txtHT = new MozartUC.apiTextBox();
      this.lblLabels11 = new MozartUC.apiLabel();
      this.Frame2 = new MozartUC.apiGroupBox();
      this.CmdEnregistrer = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.apiGridAvenant = new MozartUC.apiTGrid();
      this.apiGridPrestation = new MozartUC.apiTGrid();
      this.apiGridCat = new MozartUC.apiTGrid();
      this.lblLabels13 = new MozartUC.apiLabel();
      this.Label2 = new MozartUC.apiLabel();
      this.Label1 = new MozartUC.apiLabel();
      this.Label3 = new MozartUC.apiLabel();
      this.Frame2.SuspendLayout();
      this.SuspendLayout();
      // 
      // txtPrestation
      // 
      this.txtPrestation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.txtPrestation.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtPrestation.HelpContextID = 0;
      resources.ApplyResources(this.txtPrestation, "txtPrestation");
      this.txtPrestation.Name = "txtPrestation";
      // 
      // cmdVisu
      // 
      resources.ApplyResources(this.cmdVisu, "cmdVisu");
      this.cmdVisu.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdVisu.HelpContextID = 0;
      this.cmdVisu.Name = "cmdVisu";
      this.cmdVisu.Tag = "4";
      this.cmdVisu.UseVisualStyleBackColor = true;
      this.cmdVisu.Click += new System.EventHandler(this.cmdVisu_Click);
      // 
      // cmdValider
      // 
      resources.ApplyResources(this.cmdValider, "cmdValider");
      this.cmdValider.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdValider.HelpContextID = 0;
      this.cmdValider.Name = "cmdValider";
      this.cmdValider.Tag = "66";
      this.cmdValider.UseVisualStyleBackColor = true;
      this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
      // 
      // CmdPrest
      // 
      resources.ApplyResources(this.CmdPrest, "CmdPrest");
      this.CmdPrest.ForeColor = System.Drawing.SystemColors.ControlText;
      this.CmdPrest.HelpContextID = 0;
      this.CmdPrest.Name = "CmdPrest";
      this.CmdPrest.Tag = "24";
      this.CmdPrest.UseVisualStyleBackColor = true;
      this.CmdPrest.Click += new System.EventHandler(this.CmdPrest_Click);
      // 
      // cmdSupp
      // 
      this.cmdSupp.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdSupp.HelpContextID = 0;
      this.cmdSupp.Image = global::MozartCS.Properties.Resources.delete_32;
      resources.ApplyResources(this.cmdSupp, "cmdSupp");
      this.cmdSupp.Name = "cmdSupp";
      this.cmdSupp.Tag = "27";
      this.cmdSupp.UseVisualStyleBackColor = true;
      this.cmdSupp.Click += new System.EventHandler(this.cmdSupp_Click);
      // 
      // cmdAjouter
      // 
      resources.ApplyResources(this.cmdAjouter, "cmdAjouter");
      this.cmdAjouter.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdAjouter.HelpContextID = 0;
      this.cmdAjouter.Image = global::MozartCS.Properties.Resources.add_32;
      this.cmdAjouter.Name = "cmdAjouter";
      this.cmdAjouter.Tag = "2";
      this.cmdAjouter.UseVisualStyleBackColor = true;
      this.cmdAjouter.Click += new System.EventHandler(this.cmdAjouter_Click);
      // 
      // txtHT
      // 
      resources.ApplyResources(this.txtHT, "txtHT");
      this.txtHT.HelpContextID = 0;
      this.txtHT.Name = "txtHT";
      // 
      // lblLabels11
      // 
      this.lblLabels11.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.lblLabels11, "lblLabels11");
      this.lblLabels11.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels11.HelpContextID = 0;
      this.lblLabels11.Name = "lblLabels11";
      // 
      // Frame2
      // 
      this.Frame2.BackColor = System.Drawing.Color.Wheat;
      this.Frame2.Controls.Add(this.txtHT);
      this.Frame2.Controls.Add(this.lblLabels11);
      resources.ApplyResources(this.Frame2, "Frame2");
      this.Frame2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.Frame2.HelpContextID = 0;
      this.Frame2.Name = "Frame2";
      this.Frame2.TabStop = false;
      // 
      // CmdEnregistrer
      // 
      resources.ApplyResources(this.CmdEnregistrer, "CmdEnregistrer");
      this.CmdEnregistrer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.CmdEnregistrer.HelpContextID = 0;
      this.CmdEnregistrer.Name = "CmdEnregistrer";
      this.CmdEnregistrer.Tag = "66";
      this.CmdEnregistrer.UseVisualStyleBackColor = true;
      this.CmdEnregistrer.Click += new System.EventHandler(this.CmdEnregistrer_Click);
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Tag = "15";
      this.cmdFermer.UseVisualStyleBackColor = true;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // apiGridAvenant
      // 
      this.apiGridAvenant.FilterBar = true;
      this.apiGridAvenant.FooterBar = true;
      resources.ApplyResources(this.apiGridAvenant, "apiGridAvenant");
      this.apiGridAvenant.Name = "apiGridAvenant";
      this.apiGridAvenant.ClickE += new MozartUC.apiTGrid.ClickEEventHandler(this.apiGridAvenant_Click);
      this.apiGridAvenant.CellValueChanging += new MozartUC.apiTGrid.CellValueChangingEventHandler(this.apiGridAvenant_CellValueChanging);
      // 
      // apiGridPrestation
      // 
      this.apiGridPrestation.FilterBar = true;
      this.apiGridPrestation.FooterBar = true;
      resources.ApplyResources(this.apiGridPrestation, "apiGridPrestation");
      this.apiGridPrestation.Name = "apiGridPrestation";
      this.apiGridPrestation.RowStyle += new MozartUC.apiTGrid.RowStyleEventHandler(this.apiGridPrestation_RowStyle);
      // 
      // apiGridCat
      // 
      this.apiGridCat.FilterBar = true;
      this.apiGridCat.FooterBar = true;
      resources.ApplyResources(this.apiGridCat, "apiGridCat");
      this.apiGridCat.Name = "apiGridCat";
      this.apiGridCat.InitNewRowE += new MozartUC.apiTGrid.InitNewRowEEventHandler(this.apiGridCat_InitNewRowE);
      this.apiGridCat.ValidateRowE += new MozartUC.apiTGrid.ValidateRowEEventHandler(this.apiGridCat_ValidateRowE);
      // 
      // lblLabels13
      // 
      this.lblLabels13.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.lblLabels13, "lblLabels13");
      this.lblLabels13.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels13.HelpContextID = 0;
      this.lblLabels13.Name = "lblLabels13";
      // 
      // Label2
      // 
      resources.ApplyResources(this.Label2, "Label2");
      this.Label2.BackColor = System.Drawing.Color.Wheat;
      this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label2.HelpContextID = 0;
      this.Label2.Name = "Label2";
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // Label3
      // 
      resources.ApplyResources(this.Label3, "Label3");
      this.Label3.BackColor = System.Drawing.Color.Wheat;
      this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label3.HelpContextID = 0;
      this.Label3.Name = "Label3";
      // 
      // frmDevisClientAvenant
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.txtPrestation);
      this.Controls.Add(this.cmdVisu);
      this.Controls.Add(this.cmdValider);
      this.Controls.Add(this.CmdPrest);
      this.Controls.Add(this.cmdSupp);
      this.Controls.Add(this.cmdAjouter);
      this.Controls.Add(this.Frame2);
      this.Controls.Add(this.CmdEnregistrer);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.apiGridAvenant);
      this.Controls.Add(this.apiGridPrestation);
      this.Controls.Add(this.apiGridCat);
      this.Controls.Add(this.lblLabels13);
      this.Controls.Add(this.Label2);
      this.Controls.Add(this.Label1);
      this.Controls.Add(this.Label3);
      this.Name = "frmDevisClientAvenant";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmDevisClientAvenant_Load);
      this.Frame2.ResumeLayout(false);
      this.Frame2.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiTextBox txtPrestation;
    private MozartUC.apiButton cmdVisu;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiButton CmdPrest;
    private MozartUC.apiButton cmdSupp;
    private MozartUC.apiButton cmdAjouter;
    private MozartUC.apiTextBox txtHT;
    private MozartUC.apiLabel lblLabels11;
    private MozartUC.apiGroupBox Frame2;
    private MozartUC.apiButton CmdEnregistrer;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiTGrid apiGridAvenant;
    private MozartUC.apiTGrid apiGridPrestation;
    private MozartUC.apiTGrid apiGridCat;
    private MozartUC.apiLabel lblLabels13;
    private MozartUC.apiLabel Label2;
    private MozartUC.apiLabel Label1;
    private MozartUC.apiLabel Label3;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
