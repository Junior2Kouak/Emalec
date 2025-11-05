namespace MozartCS
{
  partial class frmNewFacture
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewFacture));
      this.cmdModifier = new MozartUC.apiButton();
      this.cmdAjouter = new MozartUC.apiButton();
      this.lblNbrEnregistrement = new MozartUC.apiLabel();
      this.Frame3 = new MozartUC.apiGroupBox();
      this.apiTGridFacturable = new MozartUC.apiTGrid();
      this.cmdSupprimer = new MozartUC.apiButton();
      this.Frame1 = new MozartUC.apiGroupBox();
      this.apiTGridAFacturer = new MozartUC.apiTGrid();
      this.cmdValider = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.Label1 = new MozartUC.apiLabel();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.Frame3.SuspendLayout();
      this.Frame1.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // cmdModifier
      // 
      resources.ApplyResources(this.cmdModifier, "cmdModifier");
      this.cmdModifier.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdModifier.HelpContextID = 0;
      this.cmdModifier.Name = "cmdModifier";
      this.cmdModifier.Tag = "19";
      this.cmdModifier.UseVisualStyleBackColor = true;
      this.cmdModifier.Click += new System.EventHandler(this.cmdModifier_Click);
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
      // lblNbrEnregistrement
      // 
      resources.ApplyResources(this.lblNbrEnregistrement, "lblNbrEnregistrement");
      this.lblNbrEnregistrement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.lblNbrEnregistrement.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblNbrEnregistrement.HelpContextID = 0;
      this.lblNbrEnregistrement.Name = "lblNbrEnregistrement";
      this.lblNbrEnregistrement.Tag = "Nb de lignes :";
      // 
      // Frame3
      // 
      resources.ApplyResources(this.Frame3, "Frame3");
      this.Frame3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.Frame3.Controls.Add(this.apiTGridFacturable);
      this.Frame3.Controls.Add(this.cmdAjouter);
      this.Frame3.Controls.Add(this.lblNbrEnregistrement);
      this.Frame3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Frame3.FrameColor = System.Drawing.Color.Empty;
      this.Frame3.HelpContextID = 0;
      this.Frame3.Name = "Frame3";
      this.Frame3.TabStop = false;
      // 
      // apiTGridFacturable
      // 
      resources.ApplyResources(this.apiTGridFacturable, "apiTGridFacturable");
      this.apiTGridFacturable.FilterBar = true;
      this.apiTGridFacturable.FooterBar = true;
      this.apiTGridFacturable.Name = "apiTGridFacturable";
      this.apiTGridFacturable.ColumnFilterChanged += new MozartUC.apiTGrid.ColumnFilterChangedEventHandler(this.apiTGridFacturable_ColumnFilterChanged);
      // 
      // cmdSupprimer
      // 
      resources.ApplyResources(this.cmdSupprimer, "cmdSupprimer");
      this.cmdSupprimer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdSupprimer.HelpContextID = 0;
      this.cmdSupprimer.Image = global::MozartCS.Properties.Resources.delete_32;
      this.cmdSupprimer.Name = "cmdSupprimer";
      this.cmdSupprimer.Tag = "27";
      this.cmdSupprimer.UseVisualStyleBackColor = true;
      this.cmdSupprimer.Click += new System.EventHandler(this.cmdSupprimer_Click);
      // 
      // Frame1
      // 
      resources.ApplyResources(this.Frame1, "Frame1");
      this.Frame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.Frame1.Controls.Add(this.apiTGridAFacturer);
      this.Frame1.Controls.Add(this.cmdSupprimer);
      this.Frame1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Frame1.FrameColor = System.Drawing.Color.Empty;
      this.Frame1.HelpContextID = 0;
      this.Frame1.Name = "Frame1";
      this.Frame1.TabStop = false;
      // 
      // apiTGridAFacturer
      // 
      resources.ApplyResources(this.apiTGridAFacturer, "apiTGridAFacturer");
      this.apiTGridAFacturer.FilterBar = true;
      this.apiTGridAFacturer.FooterBar = true;
      this.apiTGridAFacturer.Name = "apiTGridAFacturer";
      // 
      // cmdValider
      // 
      resources.ApplyResources(this.cmdValider, "cmdValider");
      this.cmdValider.ForeColor = System.Drawing.SystemColors.ControlText;
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
      this.cmdFermer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Tag = "15";
      this.cmdFermer.UseVisualStyleBackColor = true;
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // tableLayoutPanel1
      // 
      resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
      this.tableLayoutPanel1.Controls.Add(this.Frame3, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.Frame1, 0, 1);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      // 
      // frmNewFacture
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.tableLayoutPanel1);
      this.Controls.Add(this.cmdModifier);
      this.Controls.Add(this.cmdValider);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.Label1);
      this.Name = "frmNewFacture";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmNewFacture_Load);
      this.Frame3.ResumeLayout(false);
      this.Frame3.PerformLayout();
      this.Frame1.ResumeLayout(false);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private MozartUC.apiButton cmdModifier;
    private MozartUC.apiButton cmdAjouter;
    private MozartUC.apiLabel lblNbrEnregistrement;
    private MozartUC.apiGroupBox Frame3;
    private MozartUC.apiButton cmdSupprimer;
    private MozartUC.apiGroupBox Frame1;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiLabel Label1;
    private MozartUC.apiTGrid apiTGridFacturable;
    private MozartUC.apiTGrid apiTGridAFacturer;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
