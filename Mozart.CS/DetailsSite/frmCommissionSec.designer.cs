namespace MozartCS
{
  partial class frmCommissionSec
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCommissionSec));
      this.cmdDateConve = new MozartUC.apiButton();
      this.txtDateConv = new MozartUC.apiTextBox();
      this.cmdSuppDateConv = new MozartUC.apiButton();
      this.cmdProg = new MozartUC.apiButton();
      this.cmdFichier = new MozartUC.apiButton();
      this.cmdSupp1 = new MozartUC.apiButton();
      this.cmdSupp2 = new MozartUC.apiButton();
      this.txtDatelr = new MozartUC.apiTextBox();
      this.cmdDateLr = new MozartUC.apiButton();
      this.txtnbRes = new MozartUC.apiTextBox();
      this.cboAvis = new System.Windows.Forms.ComboBox();
      this.txtDateDer = new MozartUC.apiTextBox();
      this.cmdDateDer = new MozartUC.apiButton();
      this.cboClassement = new System.Windows.Forms.ComboBox();
      this.cmdValider = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.Calendar1 = new System.Windows.Forms.DateTimePicker();
      this.Label7 = new MozartUC.apiLabel();
      this.Label10 = new MozartUC.apiLabel();
      this.lblAnnee = new MozartUC.apiLabel();
      this.lblRet = new MozartUC.apiLabel();
      this.lblAnc = new MozartUC.apiLabel();
      this.Label9 = new MozartUC.apiLabel();
      this.label8 = new MozartUC.apiLabel();
      this.lblPeriodicite = new MozartUC.apiLabel();
      this.Label6 = new MozartUC.apiLabel();
      this.Label5 = new MozartUC.apiLabel();
      this.Label4 = new MozartUC.apiLabel();
      this.Label3 = new MozartUC.apiLabel();
      this.Label2 = new MozartUC.apiLabel();
      this.Label1 = new MozartUC.apiLabel();
      this.SuspendLayout();
      // 
      // cmdDateConve
      // 
      this.cmdDateConve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      resources.ApplyResources(this.cmdDateConve, "cmdDateConve");
      this.cmdDateConve.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdDateConve.HelpContextID = 0;
      this.cmdDateConve.Image = global::MozartCS.Properties.Resources.calendar;
      this.cmdDateConve.Name = "cmdDateConve";
      this.cmdDateConve.Tag = "5";
      this.cmdDateConve.UseVisualStyleBackColor = false;
      this.cmdDateConve.Click += new System.EventHandler(this.cmdDate_Click);
      // 
      // txtDateConv
      // 
      resources.ApplyResources(this.txtDateConv, "txtDateConv");
      this.txtDateConv.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtDateConv.HelpContextID = 0;
      this.txtDateConv.Name = "txtDateConv";
      // 
      // cmdSuppDateConv
      // 
      this.cmdSuppDateConv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.cmdSuppDateConv.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdSuppDateConv.HelpContextID = 0;
      this.cmdSuppDateConv.Image = global::MozartCS.Properties.Resources.delete_32;
      resources.ApplyResources(this.cmdSuppDateConv, "cmdSuppDateConv");
      this.cmdSuppDateConv.Name = "cmdSuppDateConv";
      this.cmdSuppDateConv.Tag = "65";
      this.cmdSuppDateConv.UseVisualStyleBackColor = false;
      this.cmdSuppDateConv.Click += new System.EventHandler(this.cmdSuppDateConv_Click);
      // 
      // cmdProg
      // 
      resources.ApplyResources(this.cmdProg, "cmdProg");
      this.cmdProg.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdProg.HelpContextID = 0;
      this.cmdProg.Name = "cmdProg";
      this.cmdProg.UseVisualStyleBackColor = true;
      // 
      // cmdFichier
      // 
      resources.ApplyResources(this.cmdFichier, "cmdFichier");
      this.cmdFichier.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdFichier.HelpContextID = 0;
      this.cmdFichier.Name = "cmdFichier";
      this.cmdFichier.UseVisualStyleBackColor = true;
      this.cmdFichier.Click += new System.EventHandler(this.cmdFichier_Click);
      // 
      // cmdSupp1
      // 
      this.cmdSupp1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.cmdSupp1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdSupp1.HelpContextID = 0;
      this.cmdSupp1.Image = global::MozartCS.Properties.Resources.delete_32;
      resources.ApplyResources(this.cmdSupp1, "cmdSupp1");
      this.cmdSupp1.Name = "cmdSupp1";
      this.cmdSupp1.Tag = "65";
      this.cmdSupp1.UseVisualStyleBackColor = false;
      this.cmdSupp1.Click += new System.EventHandler(this.cmdSupp1_Click);
      // 
      // cmdSupp2
      // 
      this.cmdSupp2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.cmdSupp2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdSupp2.HelpContextID = 0;
      this.cmdSupp2.Image = global::MozartCS.Properties.Resources.delete_32;
      resources.ApplyResources(this.cmdSupp2, "cmdSupp2");
      this.cmdSupp2.Name = "cmdSupp2";
      this.cmdSupp2.Tag = "65";
      this.cmdSupp2.UseVisualStyleBackColor = false;
      this.cmdSupp2.Click += new System.EventHandler(this.cmdSupp2_Click);
      // 
      // txtDatelr
      // 
      resources.ApplyResources(this.txtDatelr, "txtDatelr");
      this.txtDatelr.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtDatelr.HelpContextID = 0;
      this.txtDatelr.Name = "txtDatelr";
      // 
      // cmdDateLr
      // 
      this.cmdDateLr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      resources.ApplyResources(this.cmdDateLr, "cmdDateLr");
      this.cmdDateLr.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdDateLr.HelpContextID = 0;
      this.cmdDateLr.Image = global::MozartCS.Properties.Resources.calendar;
      this.cmdDateLr.Name = "cmdDateLr";
      this.cmdDateLr.Tag = "5";
      this.cmdDateLr.UseVisualStyleBackColor = false;
      this.cmdDateLr.Click += new System.EventHandler(this.cmdDate_Click);
      // 
      // txtnbRes
      // 
      this.txtnbRes.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtnbRes.HelpContextID = 0;
      resources.ApplyResources(this.txtnbRes, "txtnbRes");
      this.txtnbRes.Name = "txtnbRes";
      // 
      // cboAvis
      // 
      this.cboAvis.Items.AddRange(new object[] {
            resources.GetString("cboAvis.Items"),
            resources.GetString("cboAvis.Items1"),
            resources.GetString("cboAvis.Items2"),
            resources.GetString("cboAvis.Items3")});
      resources.ApplyResources(this.cboAvis, "cboAvis");
      this.cboAvis.Name = "cboAvis";
      // 
      // txtDateDer
      // 
      resources.ApplyResources(this.txtDateDer, "txtDateDer");
      this.txtDateDer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtDateDer.HelpContextID = 0;
      this.txtDateDer.Name = "txtDateDer";
      // 
      // cmdDateDer
      // 
      this.cmdDateDer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      resources.ApplyResources(this.cmdDateDer, "cmdDateDer");
      this.cmdDateDer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdDateDer.HelpContextID = 0;
      this.cmdDateDer.Image = global::MozartCS.Properties.Resources.calendar;
      this.cmdDateDer.Name = "cmdDateDer";
      this.cmdDateDer.Tag = "5";
      this.cmdDateDer.UseVisualStyleBackColor = false;
      this.cmdDateDer.Click += new System.EventHandler(this.cmdDate_Click);
      // 
      // cboClassement
      // 
      resources.ApplyResources(this.cboClassement, "cboClassement");
      this.cboClassement.Name = "cboClassement";
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
      // Calendar1
      // 
      this.Calendar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(132)))));
      this.Calendar1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      resources.ApplyResources(this.Calendar1, "Calendar1");
      this.Calendar1.Name = "Calendar1";
      this.Calendar1.CloseUp += new System.EventHandler(this.Calendar1_CloseUp);
      this.Calendar1.ValueChanged += new System.EventHandler(this.Calendar1_ValueChanged);
      // 
      // Label7
      // 
      this.Label7.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.Label7, "Label7");
      this.Label7.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label7.HelpContextID = 0;
      this.Label7.Name = "Label7";
      // 
      // Label10
      // 
      this.Label10.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.Label10, "Label10");
      this.Label10.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label10.HelpContextID = 0;
      this.Label10.Name = "Label10";
      // 
      // lblAnnee
      // 
      this.lblAnnee.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.lblAnnee, "lblAnnee");
      this.lblAnnee.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblAnnee.HelpContextID = 0;
      this.lblAnnee.Name = "lblAnnee";
      // 
      // lblRet
      // 
      this.lblRet.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.lblRet, "lblRet");
      this.lblRet.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblRet.HelpContextID = 0;
      this.lblRet.Name = "lblRet";
      // 
      // lblAnc
      // 
      this.lblAnc.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.lblAnc, "lblAnc");
      this.lblAnc.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblAnc.HelpContextID = 0;
      this.lblAnc.Name = "lblAnc";
      // 
      // Label9
      // 
      this.Label9.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.Label9, "Label9");
      this.Label9.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label9.HelpContextID = 0;
      this.Label9.Name = "Label9";
      // 
      // label8
      // 
      this.label8.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.label8, "label8");
      this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
      this.label8.HelpContextID = 0;
      this.label8.Name = "label8";
      // 
      // lblPeriodicite
      // 
      this.lblPeriodicite.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.lblPeriodicite, "lblPeriodicite");
      this.lblPeriodicite.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblPeriodicite.HelpContextID = 0;
      this.lblPeriodicite.Name = "lblPeriodicite";
      // 
      // Label6
      // 
      this.Label6.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.Label6, "Label6");
      this.Label6.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label6.HelpContextID = 0;
      this.Label6.Name = "Label6";
      // 
      // Label5
      // 
      this.Label5.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.Label5, "Label5");
      this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label5.HelpContextID = 0;
      this.Label5.Name = "Label5";
      // 
      // Label4
      // 
      this.Label4.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.Label4, "Label4");
      this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label4.HelpContextID = 0;
      this.Label4.Name = "Label4";
      // 
      // Label3
      // 
      this.Label3.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.Label3, "Label3");
      this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label3.HelpContextID = 0;
      this.Label3.Name = "Label3";
      // 
      // Label2
      // 
      this.Label2.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.Label2, "Label2");
      this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label2.HelpContextID = 0;
      this.Label2.Name = "Label2";
      // 
      // Label1
      // 
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // frmCommissionSec
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdDateConve);
      this.Controls.Add(this.txtDateConv);
      this.Controls.Add(this.cmdSuppDateConv);
      this.Controls.Add(this.cmdProg);
      this.Controls.Add(this.cmdFichier);
      this.Controls.Add(this.cmdSupp1);
      this.Controls.Add(this.cmdSupp2);
      this.Controls.Add(this.txtDatelr);
      this.Controls.Add(this.cmdDateLr);
      this.Controls.Add(this.txtnbRes);
      this.Controls.Add(this.cboAvis);
      this.Controls.Add(this.txtDateDer);
      this.Controls.Add(this.cmdDateDer);
      this.Controls.Add(this.cboClassement);
      this.Controls.Add(this.cmdValider);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.Calendar1);
      this.Controls.Add(this.Label7);
      this.Controls.Add(this.Label10);
      this.Controls.Add(this.lblAnnee);
      this.Controls.Add(this.lblRet);
      this.Controls.Add(this.lblAnc);
      this.Controls.Add(this.Label9);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.lblPeriodicite);
      this.Controls.Add(this.Label6);
      this.Controls.Add(this.Label5);
      this.Controls.Add(this.Label4);
      this.Controls.Add(this.Label3);
      this.Controls.Add(this.Label2);
      this.Controls.Add(this.Label1);
      this.Name = "frmCommissionSec";
      this.ShowInTaskbar = false;
      this.Load += new System.EventHandler(this.frmCommissionSec_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdDateConve;
    private MozartUC.apiTextBox txtDateConv;
    private MozartUC.apiButton cmdSuppDateConv;
    private MozartUC.apiButton cmdProg;
    private MozartUC.apiButton cmdFichier;
    private MozartUC.apiButton cmdSupp1;
    private MozartUC.apiButton cmdSupp2;
    private MozartUC.apiTextBox txtDatelr;
    private MozartUC.apiButton cmdDateLr;
    private MozartUC.apiTextBox txtnbRes;
    private System.Windows.Forms.ComboBox cboAvis;
    private MozartUC.apiButton cmdDateDer;
    private System.Windows.Forms.ComboBox cboClassement;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiButton cmdFermer;
    private System.Windows.Forms.DateTimePicker Calendar1;
    private MozartUC.apiLabel Label7;
    private MozartUC.apiLabel Label10;
    private MozartUC.apiLabel lblAnnee;
    private MozartUC.apiLabel lblRet;
    private MozartUC.apiLabel lblAnc;
    private MozartUC.apiLabel Label9;
    private MozartUC.apiLabel label8;
    private MozartUC.apiLabel lblPeriodicite;
    private MozartUC.apiLabel Label6;
    private MozartUC.apiLabel Label5;
    private MozartUC.apiLabel Label4;
    private MozartUC.apiLabel Label3;
    private MozartUC.apiLabel Label2;
    private MozartUC.apiLabel Label1;
    internal MozartUC.apiTextBox txtDateDer;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
