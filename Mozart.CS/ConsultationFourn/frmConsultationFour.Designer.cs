namespace MozartCS
{
  partial class frmConsultationFour
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultationFour));
      this.Calendar1 = new System.Windows.Forms.DateTimePicker();
      this.cmdDate = new MozartUC.apiButton();
      this.cmdsup = new MozartUC.apiButton();
      this.txtDateRetour = new MozartUC.apiTextBox();
      this.cmdValider = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.apiTGrid = new MozartUC.apiTGrid();
      this.cmdAjouter = new MozartUC.apiButton();
      this.Frame3 = new MozartUC.apiGroupBox();
      this.fraCriteres = new MozartUC.apiGroupBox();
      this.txtCritFouRef = new MozartUC.apiTextBox();
      this.Label4 = new MozartUC.apiLabel();
      this.txtCritFouSer = new MozartUC.apiCombo();
      this.txtCritFouMar = new MozartUC.apiTextBox();
      this.txtCritFouMat = new MozartUC.apiTextBox();
      this.cmdFind = new MozartUC.apiButton();
      this.Label3 = new MozartUC.apiLabel();
      this.Label2 = new MozartUC.apiLabel();
      this.Label14 = new MozartUC.apiLabel();
      this.Label7 = new MozartUC.apiLabel();
      this.apiTGridArt = new MozartUC.apiTGrid();
      this.cmdSupp = new MozartUC.apiButton();
      this.Frame2 = new MozartUC.apiGroupBox();
      this.lblLabels15 = new MozartUC.apiLabel();
      this.Label1 = new MozartUC.apiLabel();
      this.Frame3.SuspendLayout();
      this.fraCriteres.SuspendLayout();
      this.Frame2.SuspendLayout();
      this.SuspendLayout();
      // 
      // Calendar1
      // 
      this.Calendar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(132)))));
      this.Calendar1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      resources.ApplyResources(this.Calendar1, "Calendar1");
      this.Calendar1.Name = "Calendar1";
      this.Calendar1.CloseUp += new System.EventHandler(this.Calendar1_CloseUp);
      this.Calendar1.ValueChanged += new System.EventHandler(this.Calendar1_ValueChanged);
      // 
      // cmdDate
      // 
      resources.ApplyResources(this.cmdDate, "cmdDate");
      this.cmdDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.cmdDate.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdDate.HelpContextID = 0;
      this.cmdDate.Image = global::MozartCS.Properties.Resources.calendar;
      this.cmdDate.Name = "cmdDate";
      this.cmdDate.Tag = "5";
      this.cmdDate.UseVisualStyleBackColor = false;
      this.cmdDate.Click += new System.EventHandler(this.cmdDate_Click);
      // 
      // cmdsup
      // 
      resources.ApplyResources(this.cmdsup, "cmdsup");
      this.cmdsup.BackColor = System.Drawing.Color.Transparent;
      this.cmdsup.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdsup.HelpContextID = 0;
      this.cmdsup.Image = global::MozartCS.Properties.Resources.delete_32;
      this.cmdsup.Name = "cmdsup";
      this.cmdsup.Tag = "27";
      this.cmdsup.UseVisualStyleBackColor = false;
      this.cmdsup.Click += new System.EventHandler(this.cmdsup_Click);
      // 
      // txtDateRetour
      // 
      resources.ApplyResources(this.txtDateRetour, "txtDateRetour");
      this.txtDateRetour.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtDateRetour.HelpContextID = 0;
      this.txtDateRetour.Name = "txtDateRetour";
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
      // apiTGrid
      // 
      resources.ApplyResources(this.apiTGrid, "apiTGrid");
      this.apiTGrid.FilterBar = true;
      this.apiTGrid.FooterBar = true;
      this.apiTGrid.ForeColor = System.Drawing.SystemColors.WindowText;
      this.apiTGrid.Name = "apiTGrid";
      this.apiTGrid.DoubleClickE += new MozartUC.apiTGrid.DoubleClickEEventHandler(this.apiTGrid_DoubleClick);
      this.apiTGrid.RowCellStyle += new MozartUC.apiTGrid.RowCellStyleEventHandler(this.apiTGrid_RowCellStyle);
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
      // Frame3
      // 
      resources.ApplyResources(this.Frame3, "Frame3");
      this.Frame3.BackColor = System.Drawing.Color.Wheat;
      this.Frame3.Controls.Add(this.fraCriteres);
      this.Frame3.Controls.Add(this.apiTGrid);
      this.Frame3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Frame3.HelpContextID = 0;
      this.Frame3.Name = "Frame3";
      this.Frame3.TabStop = false;
      // 
      // fraCriteres
      // 
      resources.ApplyResources(this.fraCriteres, "fraCriteres");
      this.fraCriteres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(218)))), ((int)(((byte)(242)))));
      this.fraCriteres.Controls.Add(this.txtCritFouRef);
      this.fraCriteres.Controls.Add(this.Label4);
      this.fraCriteres.Controls.Add(this.txtCritFouSer);
      this.fraCriteres.Controls.Add(this.txtCritFouMar);
      this.fraCriteres.Controls.Add(this.txtCritFouMat);
      this.fraCriteres.Controls.Add(this.cmdFind);
      this.fraCriteres.Controls.Add(this.Label3);
      this.fraCriteres.Controls.Add(this.Label2);
      this.fraCriteres.Controls.Add(this.Label14);
      this.fraCriteres.Controls.Add(this.Label7);
      this.fraCriteres.HelpContextID = 0;
      this.fraCriteres.Name = "fraCriteres";
      this.fraCriteres.TabStop = false;
      // 
      // txtCritFouRef
      // 
      resources.ApplyResources(this.txtCritFouRef, "txtCritFouRef");
      this.txtCritFouRef.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtCritFouRef.HelpContextID = 0;
      this.txtCritFouRef.Name = "txtCritFouRef";
      // 
      // Label4
      // 
      resources.ApplyResources(this.Label4, "Label4");
      this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label4.HelpContextID = 0;
      this.Label4.Name = "Label4";
      // 
      // txtCritFouSer
      // 
      this.txtCritFouSer.BackColor = System.Drawing.SystemColors.Window;
      resources.ApplyResources(this.txtCritFouSer, "txtCritFouSer");
      this.txtCritFouSer.Name = "txtCritFouSer";
      // 
      // txtCritFouMar
      // 
      resources.ApplyResources(this.txtCritFouMar, "txtCritFouMar");
      this.txtCritFouMar.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtCritFouMar.HelpContextID = 0;
      this.txtCritFouMar.Name = "txtCritFouMar";
      // 
      // txtCritFouMat
      // 
      resources.ApplyResources(this.txtCritFouMat, "txtCritFouMat");
      this.txtCritFouMat.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtCritFouMat.HelpContextID = 0;
      this.txtCritFouMat.Name = "txtCritFouMat";
      // 
      // cmdFind
      // 
      this.cmdFind.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdFind.HelpContextID = 0;
      this.cmdFind.Image = global::MozartCS.Properties.Resources.Find;
      resources.ApplyResources(this.cmdFind, "cmdFind");
      this.cmdFind.Name = "cmdFind";
      this.cmdFind.Tag = "8";
      this.cmdFind.UseVisualStyleBackColor = true;
      this.cmdFind.Click += new System.EventHandler(this.cmdFind_Click);
      // 
      // Label3
      // 
      resources.ApplyResources(this.Label3, "Label3");
      this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label3.HelpContextID = 0;
      this.Label3.Name = "Label3";
      // 
      // Label2
      // 
      resources.ApplyResources(this.Label2, "Label2");
      this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label2.HelpContextID = 0;
      this.Label2.Name = "Label2";
      // 
      // Label14
      // 
      resources.ApplyResources(this.Label14, "Label14");
      this.Label14.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label14.HelpContextID = 0;
      this.Label14.Name = "Label14";
      // 
      // Label7
      // 
      this.Label7.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label7.HelpContextID = 0;
      resources.ApplyResources(this.Label7, "Label7");
      this.Label7.Name = "Label7";
      // 
      // apiTGridArt
      // 
      resources.ApplyResources(this.apiTGridArt, "apiTGridArt");
      this.apiTGridArt.FilterBar = true;
      this.apiTGridArt.FooterBar = true;
      this.apiTGridArt.ForeColor = System.Drawing.SystemColors.WindowText;
      this.apiTGridArt.Name = "apiTGridArt";
      this.apiTGridArt.RowCellStyle += new MozartUC.apiTGrid.RowCellStyleEventHandler(this.apiTGridArt_RowCellStyle);
      // 
      // cmdSupp
      // 
      resources.ApplyResources(this.cmdSupp, "cmdSupp");
      this.cmdSupp.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdSupp.HelpContextID = 0;
      this.cmdSupp.Image = global::MozartCS.Properties.Resources.delete_32;
      this.cmdSupp.Name = "cmdSupp";
      this.cmdSupp.Tag = "27";
      this.cmdSupp.UseVisualStyleBackColor = true;
      this.cmdSupp.Click += new System.EventHandler(this.cmdSupp_Click);
      // 
      // Frame2
      // 
      resources.ApplyResources(this.Frame2, "Frame2");
      this.Frame2.BackColor = System.Drawing.Color.Wheat;
      this.Frame2.Controls.Add(this.apiTGridArt);
      this.Frame2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Frame2.HelpContextID = 0;
      this.Frame2.Name = "Frame2";
      this.Frame2.TabStop = false;
      // 
      // lblLabels15
      // 
      resources.ApplyResources(this.lblLabels15, "lblLabels15");
      this.lblLabels15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.lblLabels15.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels15.HelpContextID = 0;
      this.lblLabels15.Name = "lblLabels15";
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // frmConsultationFour
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdSupp);
      this.Controls.Add(this.Calendar1);
      this.Controls.Add(this.cmdDate);
      this.Controls.Add(this.cmdAjouter);
      this.Controls.Add(this.cmdsup);
      this.Controls.Add(this.txtDateRetour);
      this.Controls.Add(this.cmdValider);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.Frame3);
      this.Controls.Add(this.Frame2);
      this.Controls.Add(this.lblLabels15);
      this.Controls.Add(this.Label1);
      this.KeyPreview = true;
      this.Name = "frmConsultationFour";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmConsultationFour_Load);
      this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmConsultationFour_KeyUp);
      this.Frame3.ResumeLayout(false);
      this.fraCriteres.ResumeLayout(false);
      this.fraCriteres.PerformLayout();
      this.Frame2.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DateTimePicker Calendar1;
    private MozartUC.apiButton cmdDate;
    private MozartUC.apiButton cmdsup;
    private MozartUC.apiTextBox txtDateRetour;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiTGrid apiTGrid;
    private MozartUC.apiButton cmdAjouter;
    private MozartUC.apiGroupBox Frame3;
    private MozartUC.apiTGrid apiTGridArt;
    private MozartUC.apiButton cmdSupp;
    private MozartUC.apiGroupBox Frame2;
    private MozartUC.apiLabel lblLabels15;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    private MozartUC.apiLabel Label1;
    private MozartUC.apiGroupBox fraCriteres;
    private MozartUC.apiTextBox txtCritFouMar;
    private MozartUC.apiTextBox txtCritFouMat;
    private MozartUC.apiButton cmdFind;
    private MozartUC.apiLabel Label3;
    private MozartUC.apiLabel Label2;
    private MozartUC.apiLabel Label14;
    private MozartUC.apiLabel Label7;
    private MozartUC.apiCombo txtCritFouSer;
    private MozartUC.apiTextBox txtCritFouRef;
    private MozartUC.apiLabel Label4;
  }
}
