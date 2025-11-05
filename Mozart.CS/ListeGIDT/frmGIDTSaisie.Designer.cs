
namespace MozartCS
{
  partial class frmGIDTSaisie
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGIDTSaisie));
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
      this.cmdCopier = new System.Windows.Forms.Button();
      this.Frame1.SuspendLayout();
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
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // GridH
      // 
      resources.ApplyResources(this.GridH, "GridH");
      this.GridH.FilterBar = true;
      this.GridH.FooterBar = true;
      this.GridH.Name = "GridH";
      this.GridH.RowCellStyle += new MozartUC.apiTGrid.RowCellStyleEventHandler(this.GridH_RowCellStyle);
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
      // cmdCopier
      // 
      this.cmdCopier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.cmdCopier, "cmdCopier");
      this.cmdCopier.Name = "cmdCopier";
      this.cmdCopier.UseVisualStyleBackColor = false;
      this.cmdCopier.Click += new System.EventHandler(this.cmdCopier_Click);
      // 
      // frmGIDTSaisie
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(108)))), ((int)(((byte)(186)))));
      this.Controls.Add(this.cmdCopier);
      this.Controls.Add(this.cboSite);
      this.Controls.Add(this.lblClient);
      this.Controls.Add(this.cmdDel);
      this.Controls.Add(this.Frame1);
      this.Controls.Add(this.GridB);
      this.Controls.Add(this.lblArbo);
      this.Controls.Add(this.lblSite);
      this.Controls.Add(this.GridH);
      this.Controls.Add(this.cmdFermer);
      this.Name = "frmGIDTSaisie";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmGIDTSaisie_FormClosed);
      this.Load += new System.EventHandler(this.frmGIDTSaisie_Load);
      this.Frame1.ResumeLayout(false);
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
    private System.Windows.Forms.Button cmdCopier;
  }
}