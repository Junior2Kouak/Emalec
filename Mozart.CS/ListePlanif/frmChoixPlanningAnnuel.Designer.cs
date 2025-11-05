namespace MozartCS
{
  partial class frmChoixPlanningAnnuel
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChoixPlanningAnnuel));
      this.cboPrestation = new System.Windows.Forms.ComboBox();
      this.cboAnnee = new System.Windows.Forms.ComboBox();
      this.cboTypeContrat = new System.Windows.Forms.ComboBox();
      this.cboCHAFF = new System.Windows.Forms.ComboBox();
      this.optInter5 = new System.Windows.Forms.RadioButton();
      this.optInter4 = new System.Windows.Forms.RadioButton();
      this.optInter3 = new System.Windows.Forms.RadioButton();
      this.optInter2 = new System.Windows.Forms.RadioButton();
      this.optInter0 = new System.Windows.Forms.RadioButton();
      this.optInter1 = new System.Windows.Forms.RadioButton();
      this.lblLabels2 = new MozartUC.apiLabel();
      this.lblLabels0 = new MozartUC.apiLabel();
      this.lblLabels5 = new MozartUC.apiLabel();
      this.lblLabels1 = new MozartUC.apiLabel();
      this.lblLabels19 = new MozartUC.apiLabel();
      this.lblLabels25 = new MozartUC.apiLabel();
      this.Frame7 = new MozartUC.apiGroupBox();
      this.cmdValider = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.lblPrest = new MozartUC.apiLabel();
      this.lblannee = new MozartUC.apiLabel();
      this.lblCont = new MozartUC.apiLabel();
      this.lblChaff = new MozartUC.apiLabel();
      this.Label1 = new MozartUC.apiLabel();
      this.ApiGrid = new MozartUC.apiTGrid();
      this.Frame7.SuspendLayout();
      this.SuspendLayout();
      // 
      // cboPrestation
      // 
      this.cboPrestation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      resources.ApplyResources(this.cboPrestation, "cboPrestation");
      this.cboPrestation.Items.AddRange(new object[] {
            resources.GetString("cboPrestation.Items"),
            resources.GetString("cboPrestation.Items1")});
      this.cboPrestation.Name = "cboPrestation";
      // 
      // cboAnnee
      // 
      this.cboAnnee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      resources.ApplyResources(this.cboAnnee, "cboAnnee");
      this.cboAnnee.Name = "cboAnnee";
      // 
      // cboTypeContrat
      // 
      this.cboTypeContrat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      resources.ApplyResources(this.cboTypeContrat, "cboTypeContrat");
      this.cboTypeContrat.Name = "cboTypeContrat";
      // 
      // cboCHAFF
      // 
      this.cboCHAFF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      resources.ApplyResources(this.cboCHAFF, "cboCHAFF");
      this.cboCHAFF.Name = "cboCHAFF";
      // 
      // optInter5
      // 
      this.optInter5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.optInter5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
      resources.ApplyResources(this.optInter5, "optInter5");
      this.optInter5.Name = "optInter5";
      this.optInter5.UseVisualStyleBackColor = false;
      this.optInter5.Click += new System.EventHandler(this.optInter_Click);
      // 
      // optInter4
      // 
      this.optInter4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.optInter4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
      resources.ApplyResources(this.optInter4, "optInter4");
      this.optInter4.Name = "optInter4";
      this.optInter4.UseVisualStyleBackColor = false;
      this.optInter4.Click += new System.EventHandler(this.optInter_Click);
      // 
      // optInter3
      // 
      this.optInter3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.optInter3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
      resources.ApplyResources(this.optInter3, "optInter3");
      this.optInter3.Name = "optInter3";
      this.optInter3.UseVisualStyleBackColor = false;
      this.optInter3.Click += new System.EventHandler(this.optInter_Click);
      // 
      // optInter2
      // 
      this.optInter2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.optInter2.ForeColor = System.Drawing.SystemColors.ControlText;
      resources.ApplyResources(this.optInter2, "optInter2");
      this.optInter2.Name = "optInter2";
      this.optInter2.UseVisualStyleBackColor = false;
      this.optInter2.Click += new System.EventHandler(this.optInter_Click);
      // 
      // optInter0
      // 
      this.optInter0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.optInter0.Checked = true;
      this.optInter0.ForeColor = System.Drawing.SystemColors.ControlText;
      resources.ApplyResources(this.optInter0, "optInter0");
      this.optInter0.Name = "optInter0";
      this.optInter0.TabStop = true;
      this.optInter0.UseVisualStyleBackColor = false;
      this.optInter0.Click += new System.EventHandler(this.optInter_Click);
      // 
      // optInter1
      // 
      this.optInter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.optInter1.ForeColor = System.Drawing.SystemColors.ControlText;
      resources.ApplyResources(this.optInter1, "optInter1");
      this.optInter1.Name = "optInter1";
      this.optInter1.UseVisualStyleBackColor = false;
      this.optInter1.Click += new System.EventHandler(this.optInter_Click);
      // 
      // lblLabels2
      // 
      this.lblLabels2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.lblLabels2, "lblLabels2");
      this.lblLabels2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.lblLabels2.HelpContextID = 0;
      this.lblLabels2.Name = "lblLabels2";
      // 
      // lblLabels0
      // 
      this.lblLabels0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.lblLabels0, "lblLabels0");
      this.lblLabels0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.lblLabels0.HelpContextID = 0;
      this.lblLabels0.Name = "lblLabels0";
      // 
      // lblLabels5
      // 
      this.lblLabels5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.lblLabels5, "lblLabels5");
      this.lblLabels5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.lblLabels5.HelpContextID = 0;
      this.lblLabels5.Name = "lblLabels5";
      // 
      // lblLabels1
      // 
      this.lblLabels1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.lblLabels1, "lblLabels1");
      this.lblLabels1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels1.HelpContextID = 0;
      this.lblLabels1.Name = "lblLabels1";
      // 
      // lblLabels19
      // 
      this.lblLabels19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.lblLabels19, "lblLabels19");
      this.lblLabels19.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels19.HelpContextID = 0;
      this.lblLabels19.Name = "lblLabels19";
      // 
      // lblLabels25
      // 
      this.lblLabels25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.lblLabels25, "lblLabels25");
      this.lblLabels25.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels25.HelpContextID = 0;
      this.lblLabels25.Name = "lblLabels25";
      // 
      // Frame7
      // 
      this.Frame7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.Frame7.Controls.Add(this.optInter5);
      this.Frame7.Controls.Add(this.optInter4);
      this.Frame7.Controls.Add(this.optInter3);
      this.Frame7.Controls.Add(this.optInter2);
      this.Frame7.Controls.Add(this.optInter0);
      this.Frame7.Controls.Add(this.optInter1);
      this.Frame7.Controls.Add(this.lblLabels2);
      this.Frame7.Controls.Add(this.lblLabels0);
      this.Frame7.Controls.Add(this.lblLabels5);
      this.Frame7.Controls.Add(this.lblLabels1);
      this.Frame7.Controls.Add(this.lblLabels19);
      this.Frame7.Controls.Add(this.lblLabels25);
      resources.ApplyResources(this.Frame7, "Frame7");
      this.Frame7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Frame7.HelpContextID = 0;
      this.Frame7.Name = "Frame7";
      this.Frame7.TabStop = false;
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
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // lblPrest
      // 
      this.lblPrest.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.lblPrest, "lblPrest");
      this.lblPrest.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblPrest.HelpContextID = 0;
      this.lblPrest.Name = "lblPrest";
      // 
      // lblannee
      // 
      this.lblannee.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.lblannee, "lblannee");
      this.lblannee.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblannee.HelpContextID = 0;
      this.lblannee.Name = "lblannee";
      // 
      // lblCont
      // 
      this.lblCont.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.lblCont, "lblCont");
      this.lblCont.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblCont.HelpContextID = 0;
      this.lblCont.Name = "lblCont";
      // 
      // lblChaff
      // 
      this.lblChaff.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.lblChaff, "lblChaff");
      this.lblChaff.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblChaff.HelpContextID = 0;
      this.lblChaff.Name = "lblChaff";
      // 
      // Label1
      // 
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // ApiGrid
      // 
      resources.ApplyResources(this.ApiGrid, "ApiGrid");
      this.ApiGrid.FilterBar = true;
      this.ApiGrid.FooterBar = true;
      this.ApiGrid.Name = "ApiGrid";
      this.ApiGrid.SelectionChanged += new MozartUC.apiTGrid.SelectionChangedEventHandler(this.ApiGrid_SelectionChanged);
      // 
      // frmChoixPlanningAnnuel
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cboPrestation);
      this.Controls.Add(this.cboAnnee);
      this.Controls.Add(this.ApiGrid);
      this.Controls.Add(this.cboTypeContrat);
      this.Controls.Add(this.cboCHAFF);
      this.Controls.Add(this.Frame7);
      this.Controls.Add(this.cmdValider);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.lblPrest);
      this.Controls.Add(this.lblannee);
      this.Controls.Add(this.lblCont);
      this.Controls.Add(this.lblChaff);
      this.Controls.Add(this.Label1);
      this.Name = "frmChoixPlanningAnnuel";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmChoixPlanningAnnuel_Load);
      this.Frame7.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ComboBox cboPrestation;
    private System.Windows.Forms.ComboBox cboAnnee;
    private System.Windows.Forms.ComboBox cboTypeContrat;
    private System.Windows.Forms.ComboBox cboCHAFF;
    private System.Windows.Forms.RadioButton optInter5;
    private System.Windows.Forms.RadioButton optInter4;
    private System.Windows.Forms.RadioButton optInter3;
    private System.Windows.Forms.RadioButton optInter2;
    private System.Windows.Forms.RadioButton optInter0;
    private System.Windows.Forms.RadioButton optInter1;
    private MozartUC.apiLabel lblLabels2;
    private MozartUC.apiLabel lblLabels0;
    private MozartUC.apiLabel lblLabels5;
    private MozartUC.apiLabel lblLabels1;
    private MozartUC.apiLabel lblLabels19;
    private MozartUC.apiLabel lblLabels25;
    private MozartUC.apiGroupBox Frame7;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiLabel lblPrest;
    private MozartUC.apiLabel lblannee;
    private MozartUC.apiLabel lblCont;
    private MozartUC.apiLabel lblChaff;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    private MozartUC.apiLabel Label1;
    private MozartUC.apiTGrid ApiGrid;
  }
}
