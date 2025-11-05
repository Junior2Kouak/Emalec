namespace MozartCS
{
  partial class frmFactAvancement
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFactAvancement));
      this.apiGridAvenantPrest = new MozartUC.apiTGrid();
      this.frame1 = new MozartUC.apiGroupBox();
      this.cmdEnregistrer = new MozartUC.apiButton();
      this.apiGridPrest = new MozartUC.apiTGrid();
      this.cmdFermer = new MozartUC.apiButton();
      this.txtHT = new System.Windows.Forms.TextBox();
      this.lblAvPost = new MozartUC.apiLabel();
      this.lblLabels14 = new MozartUC.apiLabel();
      this.frame1.SuspendLayout();
      this.SuspendLayout();
      // 
      // apiGridAvenantPrest
      // 
      resources.ApplyResources(this.apiGridAvenantPrest, "apiGridAvenantPrest");
      this.apiGridAvenantPrest.FilterBar = true;
      this.apiGridAvenantPrest.FooterBar = true;
      this.apiGridAvenantPrest.ForeColor = System.Drawing.SystemColors.ControlText;
      this.apiGridAvenantPrest.Name = "apiGridAvenantPrest";
      this.apiGridAvenantPrest.CellValueChanged += new MozartUC.apiTGrid.CellValueChangedEventHandler(this.apiGridAvenantPrest_CellValueChanged);
      // 
      // frame1
      // 
      resources.ApplyResources(this.frame1, "frame1");
      this.frame1.BackColor = System.Drawing.Color.Wheat;
      this.frame1.Controls.Add(this.apiGridAvenantPrest);
      this.frame1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.frame1.HelpContextID = 0;
      this.frame1.Name = "frame1";
      this.frame1.TabStop = false;
      // 
      // cmdEnregistrer
      // 
      resources.ApplyResources(this.cmdEnregistrer, "cmdEnregistrer");
      this.cmdEnregistrer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdEnregistrer.HelpContextID = 0;
      this.cmdEnregistrer.Name = "cmdEnregistrer";
      this.cmdEnregistrer.Tag = "29";
      this.cmdEnregistrer.UseVisualStyleBackColor = true;
      this.cmdEnregistrer.Click += new System.EventHandler(this.cmdEnregistrer_Click);
      // 
      // apiGridPrest
      // 
      resources.ApplyResources(this.apiGridPrest, "apiGridPrest");
      this.apiGridPrest.FilterBar = true;
      this.apiGridPrest.FooterBar = true;
      this.apiGridPrest.Name = "apiGridPrest";
      this.apiGridPrest.CellValueChanged += new MozartUC.apiTGrid.CellValueChangedEventHandler(this.apiGridPrest_CellValueChanged);
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
      // txtHT
      // 
      resources.ApplyResources(this.txtHT, "txtHT");
      this.txtHT.Name = "txtHT";
      // 
      // lblAvPost
      // 
      resources.ApplyResources(this.lblAvPost, "lblAvPost");
      this.lblAvPost.BackColor = System.Drawing.Color.Wheat;
      this.lblAvPost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
      this.lblAvPost.HelpContextID = 0;
      this.lblAvPost.Name = "lblAvPost";
      // 
      // lblLabels14
      // 
      resources.ApplyResources(this.lblLabels14, "lblLabels14");
      this.lblLabels14.BackColor = System.Drawing.Color.Wheat;
      this.lblLabels14.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels14.HelpContextID = 0;
      this.lblLabels14.Name = "lblLabels14";
      // 
      // frmFactAvancement
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.frame1);
      this.Controls.Add(this.cmdEnregistrer);
      this.Controls.Add(this.apiGridPrest);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.txtHT);
      this.Controls.Add(this.lblAvPost);
      this.Controls.Add(this.lblLabels14);
      this.Name = "frmFactAvancement";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmFactAvancement_Load);
      this.frame1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiTGrid apiGridAvenantPrest;
    private MozartUC.apiGroupBox frame1;
    private MozartUC.apiButton cmdEnregistrer;
    private MozartUC.apiTGrid apiGridPrest;
    private MozartUC.apiButton cmdFermer;
    private System.Windows.Forms.TextBox txtHT;
    private MozartUC.apiLabel lblAvPost;
    private MozartUC.apiLabel lblLabels14;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
