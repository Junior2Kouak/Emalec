
namespace MozartCS
{
  partial class frmCliGIDTSaisie
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliGIDTSaisie));
      this.cmdFermer = new MozartUC.apiButton();
      this.GridH = new MozartUC.apiTGrid();
      this.lblSite = new System.Windows.Forms.Label();
      this.lblArbo = new System.Windows.Forms.Label();
      this.GridB = new MozartUC.apiTGrid();
      this.Frame1 = new MozartUC.apiGroupBox();
      this.cmdShape1 = new MozartUC.apiLabel();
      this.cmdAddMedia = new MozartUC.apiButton();
      this.cmdVisuMedia = new MozartUC.apiButton();
      this.cmdModifMedia = new MozartUC.apiButton();
      this.cmdDelMedia = new MozartUC.apiButton();
      this.cmdDel = new MozartUC.apiButton();
      this.lblClient = new System.Windows.Forms.Label();
      this.cboSite = new System.Windows.Forms.ComboBox();
      this.cmdAffectStt = new MozartUC.apiButton();
      this.cmdSupprStt = new MozartUC.apiButton();
      this.frmStt = new MozartUC.apiGroupBox();
      this.txtStt = new System.Windows.Forms.TextBox();
      this.cmdRechercher = new System.Windows.Forms.Button();
      this.cboImpose = new System.Windows.Forms.ComboBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.cboCotraitant = new System.Windows.Forms.ComboBox();
      this.cmdValiderStt = new System.Windows.Forms.Button();
      this.frmAna = new MozartUC.apiGroupBox();
      this.cboAfCompt = new System.Windows.Forms.ComboBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.cboCentreRes = new System.Windows.Forms.ComboBox();
      this.cmdValiderAna = new System.Windows.Forms.Button();
      this.Frame1.SuspendLayout();
      this.frmStt.SuspendLayout();
      this.frmAna.SuspendLayout();
      this.SuspendLayout();
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.UseVisualStyleBackColor = false;
      // 
      // GridH
      // 
      resources.ApplyResources(this.GridH, "GridH");
      this.GridH.FilterBar = true;
      this.GridH.FooterBar = true;
      this.GridH.Name = "GridH";
      this.GridH.RowStyle += new MozartUC.apiTGrid.RowStyleEventHandler(this.GridH_RowStyle);
      this.GridH.FocusedRowChanged += new MozartUC.apiTGrid.FocusedRowChangedEventHandler(this.GridH_FocusedRowChanged);
      // 
      // lblSite
      // 
      resources.ApplyResources(this.lblSite, "lblSite");
      this.lblSite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.lblSite.Name = "lblSite";
      // 
      // lblArbo
      // 
      resources.ApplyResources(this.lblArbo, "lblArbo");
      this.lblArbo.ForeColor = System.Drawing.Color.Yellow;
      this.lblArbo.Name = "lblArbo";
      // 
      // GridB
      // 
      resources.ApplyResources(this.GridB, "GridB");
      this.GridB.FilterBar = false;
      this.GridB.FooterBar = true;
      this.GridB.Name = "GridB";
      this.GridB.InitNewRowE += new MozartUC.apiTGrid.InitNewRowEEventHandler(this.GridB_InitNewRowE);
      this.GridB.RowCellClick += new MozartUC.apiTGrid.RowCellClickEventHandler(this.GridB_RowCellClick);
      this.GridB.ValidateRowE += new MozartUC.apiTGrid.ValidateRowEEventHandler(this.GridB_ValidateRowE);
      this.GridB.FocusedRowChanged += new MozartUC.apiTGrid.FocusedRowChangedEventHandler(this.GridB_FocusedRowChanged);
      // 
      // Frame1
      // 
      resources.ApplyResources(this.Frame1, "Frame1");
      this.Frame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(108)))), ((int)(((byte)(186)))));
      this.Frame1.Controls.Add(this.cmdShape1);
      this.Frame1.Controls.Add(this.cmdAddMedia);
      this.Frame1.Controls.Add(this.cmdVisuMedia);
      this.Frame1.Controls.Add(this.cmdModifMedia);
      this.Frame1.Controls.Add(this.cmdDelMedia);
      this.Frame1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.Frame1.FrameColor = System.Drawing.Color.Empty;
      this.Frame1.HelpContextID = 0;
      this.Frame1.Name = "Frame1";
      this.Frame1.TabStop = false;
      // 
      // cmdShape1
      // 
      this.cmdShape1.BackColor = System.Drawing.Color.Lime;
      this.cmdShape1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      resources.ApplyResources(this.cmdShape1, "cmdShape1");
      this.cmdShape1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdShape1.HelpContextID = 0;
      this.cmdShape1.Name = "cmdShape1";
      // 
      // cmdAddMedia
      // 
      this.cmdAddMedia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.cmdAddMedia, "cmdAddMedia");
      this.cmdAddMedia.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdAddMedia.HelpContextID = 0;
      this.cmdAddMedia.Image = global::MozartCS.Properties.Resources.add_32;
      this.cmdAddMedia.Name = "cmdAddMedia";
      this.cmdAddMedia.Tag = "2";
      this.cmdAddMedia.UseVisualStyleBackColor = false;
      this.cmdAddMedia.Click += new System.EventHandler(this.cmdAddMedia_Click);
      // 
      // cmdVisuMedia
      // 
      this.cmdVisuMedia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.cmdVisuMedia, "cmdVisuMedia");
      this.cmdVisuMedia.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdVisuMedia.HelpContextID = 0;
      this.cmdVisuMedia.Image = global::MozartCS.Properties.Resources.Find;
      this.cmdVisuMedia.Name = "cmdVisuMedia";
      this.cmdVisuMedia.Tag = "8";
      this.cmdVisuMedia.UseVisualStyleBackColor = false;
      this.cmdVisuMedia.Click += new System.EventHandler(this.cmdVisuMedia_Click);
      // 
      // cmdModifMedia
      // 
      this.cmdModifMedia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.cmdModifMedia, "cmdModifMedia");
      this.cmdModifMedia.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdModifMedia.HelpContextID = 0;
      this.cmdModifMedia.Image = global::MozartCS.Properties.Resources.Modify_32;
      this.cmdModifMedia.Name = "cmdModifMedia";
      this.cmdModifMedia.Tag = "19";
      this.cmdModifMedia.UseVisualStyleBackColor = false;
      this.cmdModifMedia.Click += new System.EventHandler(this.cmdModifMedia_Click);
      // 
      // cmdDelMedia
      // 
      this.cmdDelMedia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.cmdDelMedia, "cmdDelMedia");
      this.cmdDelMedia.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdDelMedia.HelpContextID = 0;
      this.cmdDelMedia.Image = global::MozartCS.Properties.Resources.delete_32;
      this.cmdDelMedia.Name = "cmdDelMedia";
      this.cmdDelMedia.Tag = "27";
      this.cmdDelMedia.UseVisualStyleBackColor = false;
      this.cmdDelMedia.Click += new System.EventHandler(this.cmdDelMedia_Click);
      // 
      // cmdDel
      // 
      this.cmdDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.cmdDel, "cmdDel");
      this.cmdDel.HelpContextID = 0;
      this.cmdDel.Image = global::MozartCS.Properties.Resources.delete_32;
      this.cmdDel.Name = "cmdDel";
      this.cmdDel.UseVisualStyleBackColor = false;
      this.cmdDel.Click += new System.EventHandler(this.cmdDel_Click);
      // 
      // lblClient
      // 
      resources.ApplyResources(this.lblClient, "lblClient");
      this.lblClient.ForeColor = System.Drawing.Color.Yellow;
      this.lblClient.Name = "lblClient";
      // 
      // cboSite
      // 
      this.cboSite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboSite.FormattingEnabled = true;
      resources.ApplyResources(this.cboSite, "cboSite");
      this.cboSite.Name = "cboSite";
      this.cboSite.SelectedValueChanged += new System.EventHandler(this.cboSite_SelectedValueChanged);
      // 
      // cmdAffectStt
      // 
      this.cmdAffectStt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.cmdAffectStt, "cmdAffectStt");
      this.cmdAffectStt.HelpContextID = 0;
      this.cmdAffectStt.Name = "cmdAffectStt";
      this.cmdAffectStt.UseVisualStyleBackColor = false;
      this.cmdAffectStt.Click += new System.EventHandler(this.cmdAffectStt_Click);
      // 
      // cmdSupprStt
      // 
      this.cmdSupprStt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.cmdSupprStt, "cmdSupprStt");
      this.cmdSupprStt.HelpContextID = 0;
      this.cmdSupprStt.Name = "cmdSupprStt";
      this.cmdSupprStt.UseVisualStyleBackColor = false;
      this.cmdSupprStt.Click += new System.EventHandler(this.cmdSupprStt_Click);
      // 
      // frmStt
      // 
      this.frmStt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
      this.frmStt.Controls.Add(this.txtStt);
      this.frmStt.Controls.Add(this.cmdRechercher);
      this.frmStt.Controls.Add(this.cboImpose);
      this.frmStt.Controls.Add(this.label2);
      this.frmStt.Controls.Add(this.label1);
      this.frmStt.Controls.Add(this.cboCotraitant);
      this.frmStt.Controls.Add(this.cmdValiderStt);
      resources.ApplyResources(this.frmStt, "frmStt");
      this.frmStt.FrameColor = System.Drawing.Color.Empty;
      this.frmStt.HelpContextID = 0;
      this.frmStt.Name = "frmStt";
      this.frmStt.TabStop = false;
      // 
      // txtStt
      // 
      resources.ApplyResources(this.txtStt, "txtStt");
      this.txtStt.Name = "txtStt";
      // 
      // cmdRechercher
      // 
      resources.ApplyResources(this.cmdRechercher, "cmdRechercher");
      this.cmdRechercher.Name = "cmdRechercher";
      this.cmdRechercher.UseVisualStyleBackColor = true;
      this.cmdRechercher.Click += new System.EventHandler(this.cmdRechercher_Click);
      // 
      // cboImpose
      // 
      this.cboImpose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboImpose.FormattingEnabled = true;
      this.cboImpose.Items.AddRange(new object[] {
            resources.GetString("cboImpose.Items"),
            resources.GetString("cboImpose.Items1")});
      resources.ApplyResources(this.cboImpose, "cboImpose");
      this.cboImpose.Name = "cboImpose";
      // 
      // label2
      // 
      resources.ApplyResources(this.label2, "label2");
      this.label2.Name = "label2";
      // 
      // label1
      // 
      resources.ApplyResources(this.label1, "label1");
      this.label1.Name = "label1";
      // 
      // cboCotraitant
      // 
      this.cboCotraitant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboCotraitant.FormattingEnabled = true;
      this.cboCotraitant.Items.AddRange(new object[] {
            resources.GetString("cboCotraitant.Items"),
            resources.GetString("cboCotraitant.Items1")});
      resources.ApplyResources(this.cboCotraitant, "cboCotraitant");
      this.cboCotraitant.Name = "cboCotraitant";
      // 
      // cmdValiderStt
      // 
      resources.ApplyResources(this.cmdValiderStt, "cmdValiderStt");
      this.cmdValiderStt.Name = "cmdValiderStt";
      this.cmdValiderStt.UseVisualStyleBackColor = true;
      this.cmdValiderStt.Click += new System.EventHandler(this.cmdValiderStt_Click);
      // 
      // frmAna
      // 
      this.frmAna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
      this.frmAna.Controls.Add(this.cboAfCompt);
      this.frmAna.Controls.Add(this.label3);
      this.frmAna.Controls.Add(this.label4);
      this.frmAna.Controls.Add(this.cboCentreRes);
      this.frmAna.Controls.Add(this.cmdValiderAna);
      resources.ApplyResources(this.frmAna, "frmAna");
      this.frmAna.FrameColor = System.Drawing.Color.Empty;
      this.frmAna.HelpContextID = 0;
      this.frmAna.Name = "frmAna";
      this.frmAna.TabStop = false;
      // 
      // cboAfCompt
      // 
      this.cboAfCompt.FormattingEnabled = true;
      resources.ApplyResources(this.cboAfCompt, "cboAfCompt");
      this.cboAfCompt.Name = "cboAfCompt";
      // 
      // label3
      // 
      resources.ApplyResources(this.label3, "label3");
      this.label3.Name = "label3";
      // 
      // label4
      // 
      resources.ApplyResources(this.label4, "label4");
      this.label4.Name = "label4";
      // 
      // cboCentreRes
      // 
      this.cboCentreRes.FormattingEnabled = true;
      resources.ApplyResources(this.cboCentreRes, "cboCentreRes");
      this.cboCentreRes.Name = "cboCentreRes";
      // 
      // cmdValiderAna
      // 
      resources.ApplyResources(this.cmdValiderAna, "cmdValiderAna");
      this.cmdValiderAna.Name = "cmdValiderAna";
      this.cmdValiderAna.UseVisualStyleBackColor = true;
      this.cmdValiderAna.Click += new System.EventHandler(this.cmdValiderAna_Click);
      // 
      // frmCliGIDTSaisie
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(108)))), ((int)(((byte)(186)))));
      this.CancelButton = this.cmdFermer;
      this.Controls.Add(this.frmAna);
      this.Controls.Add(this.frmStt);
      this.Controls.Add(this.cmdSupprStt);
      this.Controls.Add(this.cmdAffectStt);
      this.Controls.Add(this.cboSite);
      this.Controls.Add(this.lblClient);
      this.Controls.Add(this.cmdDel);
      this.Controls.Add(this.Frame1);
      this.Controls.Add(this.GridB);
      this.Controls.Add(this.lblArbo);
      this.Controls.Add(this.lblSite);
      this.Controls.Add(this.GridH);
      this.Controls.Add(this.cmdFermer);
      this.Name = "frmCliGIDTSaisie";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCliGIDTSaisie_FormClosed);
      this.Load += new System.EventHandler(this.frmCliGIDTSaisie_Load);
      this.Frame1.ResumeLayout(false);
      this.frmStt.ResumeLayout(false);
      this.frmStt.PerformLayout();
      this.frmAna.ResumeLayout(false);
      this.frmAna.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiTGrid GridH;
    private System.Windows.Forms.Label lblSite;
    private System.Windows.Forms.Label lblArbo;
    private MozartUC.apiTGrid GridB;
    private MozartUC.apiGroupBox Frame1;
    private MozartUC.apiLabel cmdShape1;
    private MozartUC.apiButton cmdAddMedia;
    private MozartUC.apiButton cmdVisuMedia;
    private MozartUC.apiButton cmdModifMedia;
    private MozartUC.apiButton cmdDelMedia;
    private MozartUC.apiButton cmdDel;
    private System.Windows.Forms.Label lblClient;
    private System.Windows.Forms.ComboBox cboSite;
    private MozartUC.apiButton cmdAffectStt;
    private MozartUC.apiButton cmdSupprStt;
    private MozartUC.apiGroupBox frmStt;
    private System.Windows.Forms.TextBox txtStt;
    private System.Windows.Forms.Button cmdRechercher;
    private System.Windows.Forms.ComboBox cboImpose;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox cboCotraitant;
    private System.Windows.Forms.Button cmdValiderStt;
    private MozartUC.apiGroupBox frmAna;
    private System.Windows.Forms.ComboBox cboAfCompt;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.ComboBox cboCentreRes;
    private System.Windows.Forms.Button cmdValiderAna;
  }
}