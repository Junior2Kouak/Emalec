
using DevExpress.XtraEditors;

namespace MozartCS
{
  partial class frmClients_GestionKPI
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClients_GestionKPI));
      this.cmdFermer = new MozartUC.apiButton();
      this.cmdEnregistrer = new MozartUC.apiButton();
      this.LblTitre = new System.Windows.Forms.Label();
      this.ChkKPI = new System.Windows.Forms.CheckBox();
      this.BtnHelpKPI_DateContractuel = new System.Windows.Forms.Button();
      this.chkDelaiParContrat = new System.Windows.Forms.CheckBox();
      this.cmdViewDefaultValues = new MozartUC.apiButton();
      this.cmdTous = new MozartUC.apiButton();
      this.ucGestionKPI1 = new MozartCS.UCGestionKPI();
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
      // cmdEnregistrer
      // 
      resources.ApplyResources(this.cmdEnregistrer, "cmdEnregistrer");
      this.cmdEnregistrer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdEnregistrer.HelpContextID = 0;
      this.cmdEnregistrer.Name = "cmdEnregistrer";
      this.cmdEnregistrer.Tag = "4";
      this.cmdEnregistrer.UseVisualStyleBackColor = true;
      this.cmdEnregistrer.Click += new System.EventHandler(this.cmdEnregistrer_Click);
      // 
      // LblTitre
      // 
      resources.ApplyResources(this.LblTitre, "LblTitre");
      this.LblTitre.Name = "LblTitre";
      // 
      // ChkKPI
      // 
      resources.ApplyResources(this.ChkKPI, "ChkKPI");
      this.ChkKPI.Name = "ChkKPI";
      this.ChkKPI.UseVisualStyleBackColor = true;
      // 
      // BtnHelpKPI_DateContractuel
      // 
      this.BtnHelpKPI_DateContractuel.BackgroundImage = global::MozartCS.Properties.Resources._49277;
      resources.ApplyResources(this.BtnHelpKPI_DateContractuel, "BtnHelpKPI_DateContractuel");
      this.BtnHelpKPI_DateContractuel.Name = "BtnHelpKPI_DateContractuel";
      this.BtnHelpKPI_DateContractuel.UseVisualStyleBackColor = true;
      this.BtnHelpKPI_DateContractuel.Click += new System.EventHandler(this.BtnHelpKPI_DateContractuel_Click);
      // 
      // chkDelaiParContrat
      // 
      resources.ApplyResources(this.chkDelaiParContrat, "chkDelaiParContrat");
      this.chkDelaiParContrat.Name = "chkDelaiParContrat";
      this.chkDelaiParContrat.UseVisualStyleBackColor = true;
      this.chkDelaiParContrat.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
      // 
      // cmdViewDefaultValues
      // 
      resources.ApplyResources(this.cmdViewDefaultValues, "cmdViewDefaultValues");
      this.cmdViewDefaultValues.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdViewDefaultValues.HelpContextID = 743;
      this.cmdViewDefaultValues.Name = "cmdViewDefaultValues";
      this.cmdViewDefaultValues.Tag = "4";
      this.cmdViewDefaultValues.UseVisualStyleBackColor = true;
      this.cmdViewDefaultValues.Click += new System.EventHandler(this.cmdViewDefaultValues_Click);
      // 
      // cmdTous
      // 
      resources.ApplyResources(this.cmdTous, "cmdTous");
      this.cmdTous.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdTous.HelpContextID = 0;
      this.cmdTous.Name = "cmdTous";
      this.cmdTous.Tag = "4";
      this.cmdTous.UseVisualStyleBackColor = true;
      this.cmdTous.Click += new System.EventHandler(this.cmdTous_Click);
      // 
      // ucGestionKPI1
      // 
      resources.ApplyResources(this.ucGestionKPI1, "ucGestionKPI1");
      this.ucGestionKPI1.BackColor = System.Drawing.Color.Wheat;
      this.ucGestionKPI1.Name = "ucGestionKPI1";
      // 
      // frmClients_GestionKPI
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      this.Controls.Add(this.cmdTous);
      this.Controls.Add(this.cmdViewDefaultValues);
      this.Controls.Add(this.ucGestionKPI1);
      this.Controls.Add(this.chkDelaiParContrat);
      this.Controls.Add(this.BtnHelpKPI_DateContractuel);
      this.Controls.Add(this.ChkKPI);
      this.Controls.Add(this.LblTitre);
      this.Controls.Add(this.cmdEnregistrer);
      this.Controls.Add(this.cmdFermer);
      this.Name = "frmClients_GestionKPI";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmClients_GestionKPI_Load);
      this.ResumeLayout(false);

    }

    #endregion
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiButton cmdEnregistrer;
    internal System.Windows.Forms.Label LblTitre;
    internal System.Windows.Forms.CheckBox ChkKPI;
    internal System.Windows.Forms.Button BtnHelpKPI_DateContractuel;
    internal System.Windows.Forms.CheckBox chkDelaiParContrat;
    private UCGestionKPI ucGestionKPI1;
    private MozartUC.apiButton cmdViewDefaultValues;
    private MozartUC.apiButton cmdTous;
  }
}