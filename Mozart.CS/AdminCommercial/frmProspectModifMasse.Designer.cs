namespace MozartCS
{
  partial class frmProspectModifMasse
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProspectModifMasse));
      this.lblTitre = new System.Windows.Forms.Label();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.lblProspectsSelected = new DevExpress.XtraEditors.LabelControl();
      this.lblProspects = new DevExpress.XtraEditors.LabelControl();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.cmdDown = new DevExpress.XtraEditors.SimpleButton();
      this.cmdUp = new DevExpress.XtraEditors.SimpleButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.cmdModifier = new MozartUC.apiButton();
      this.apiTGridSelected = new MozartCS.UCListeProspects();
      this.apiTGridAll = new MozartCS.UCListeProspects();
      this.tableLayoutPanel1.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // lblTitre
      // 
      resources.ApplyResources(this.lblTitre, "lblTitre");
      this.lblTitre.BackColor = System.Drawing.Color.Wheat;
      this.lblTitre.Name = "lblTitre";
      // 
      // tableLayoutPanel1
      // 
      resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
      this.tableLayoutPanel1.Controls.Add(this.apiTGridSelected, 0, 4);
      this.tableLayoutPanel1.Controls.Add(this.lblProspectsSelected, 0, 3);
      this.tableLayoutPanel1.Controls.Add(this.apiTGridAll, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.lblProspects, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      // 
      // lblProspectsSelected
      // 
      this.lblProspectsSelected.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("lblProspectsSelected.Appearance.Font")));
      this.lblProspectsSelected.Appearance.Options.UseFont = true;
      resources.ApplyResources(this.lblProspectsSelected, "lblProspectsSelected");
      this.lblProspectsSelected.Name = "lblProspectsSelected";
      // 
      // lblProspects
      // 
      resources.ApplyResources(this.lblProspects, "lblProspects");
      this.lblProspects.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("lblProspects.Appearance.Font")));
      this.lblProspects.Appearance.Options.UseFont = true;
      this.lblProspects.Name = "lblProspects";
      // 
      // tableLayoutPanel2
      // 
      resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
      this.tableLayoutPanel2.Controls.Add(this.cmdDown, 0, 0);
      this.tableLayoutPanel2.Controls.Add(this.cmdUp, 1, 0);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      // 
      // cmdDown
      // 
      resources.ApplyResources(this.cmdDown, "cmdDown");
      this.cmdDown.ImageOptions.Image = global::MozartCS.Properties.Resources.flecheB;
      this.cmdDown.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
      this.cmdDown.Name = "cmdDown";
      this.cmdDown.Click += new System.EventHandler(this.cmdDown_Click);
      // 
      // cmdUp
      // 
      resources.ApplyResources(this.cmdUp, "cmdUp");
      this.cmdUp.ImageOptions.Image = global::MozartCS.Properties.Resources.flecheH;
      this.cmdUp.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
      this.cmdUp.Name = "cmdUp";
      this.cmdUp.Click += new System.EventHandler(this.cmdUp_Click);
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
      // cmdModifier
      // 
      resources.ApplyResources(this.cmdModifier, "cmdModifier");
      this.cmdModifier.HelpContextID = 0;
      this.cmdModifier.Name = "cmdModifier";
      this.cmdModifier.Tag = "66";
      this.cmdModifier.UseVisualStyleBackColor = true;
      this.cmdModifier.Click += new System.EventHandler(this.cmdModifier_Click);
      // 
      // apiTGridSelected
      // 
      this.apiTGridSelected.AllowDrop = true;
      resources.ApplyResources(this.apiTGridSelected, "apiTGridSelected");
      this.apiTGridSelected.Name = "apiTGridSelected";
      // 
      // apiTGridAll
      // 
      resources.ApplyResources(this.apiTGridAll, "apiTGridAll");
      this.apiTGridAll.Name = "apiTGridAll";
      // 
      // frmProspectModifMasse
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Wheat;
      this.Controls.Add(this.cmdModifier);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Controls.Add(this.lblTitre);
      this.Name = "frmProspectModifMasse";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmModifMasse_Load);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.tableLayoutPanel2.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblTitre;
    private UCListeProspects apiTGridAll;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private DevExpress.XtraEditors.LabelControl lblProspects;
    private DevExpress.XtraEditors.LabelControl lblProspectsSelected;
    private UCListeProspects apiTGridSelected;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiButton cmdModifier;
    private DevExpress.XtraEditors.SimpleButton cmdDown;
    private DevExpress.XtraEditors.SimpleButton cmdUp;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
  }
}