namespace MozartCS
{
  partial class frmPrepaCommandePrest
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrepaCommandePrest));
      this.apiToolTip1 = new MozartUC.apiTooltip();
      this.Frame1 = new MozartUC.apiGroupBox();
      this.Command2 = new MozartUC.apiButton();
      this.dbGrid = new MozartUC.apiTGrid();
      this.cmdRechercher = new MozartUC.apiButton();
      this.cmdValider = new MozartUC.apiButton();
      this.Frame8 = new MozartUC.apiGroupBox();
      this.txtFields_Di = new MozartUC.apiTextBox();
      this.txtFields_Num = new MozartUC.apiTextBox();
      this.txtFields_Name = new MozartUC.apiTextBox();
      this.txtFields_Date = new MozartUC.apiTextBox();
      this.txtFields_Demandeur = new MozartUC.apiTextBox();
      this.txtFields_Compte = new MozartUC.apiTextBox();
      this.lblLabels23 = new MozartUC.apiLabel();
      this.lblLabels1 = new MozartUC.apiLabel();
      this.lblLabels16 = new MozartUC.apiLabel();
      this.lblLabels8 = new MozartUC.apiLabel();
      this.lblLabels9 = new MozartUC.apiLabel();
      this.lblLabels5 = new MozartUC.apiLabel();
      this.Frame6 = new MozartUC.apiGroupBox();
      this.txtFields_Site = new MozartUC.apiTextBox();
      this.txtFields_Adr1 = new MozartUC.apiTextBox();
      this.txtFields_Ville = new MozartUC.apiTextBox();
      this.txtFields_CodePostal = new MozartUC.apiTextBox();
      this.txtFields_Adr2 = new MozartUC.apiTextBox();
      this.txtFields_Resp = new MozartUC.apiTextBox();
      this.lblLabels19 = new MozartUC.apiLabel();
      this.lblLabels3 = new MozartUC.apiLabel();
      this.lblLabels4 = new MozartUC.apiLabel();
      this.lblLabels22 = new MozartUC.apiLabel();
      this.lblLabels0 = new MozartUC.apiLabel();
      this.lblLabels17 = new MozartUC.apiLabel();
      this.apiTGrid = new MozartUC.apiTGrid();
      this.cmdFermer = new MozartUC.apiButton();
      this.Frame1.SuspendLayout();
      this.Frame8.SuspendLayout();
      this.Frame6.SuspendLayout();
      this.SuspendLayout();
      // 
      // apiToolTip1
      // 
      this.apiToolTip1.BackColor = System.Drawing.Color.SteelBlue;
      this.apiToolTip1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      resources.ApplyResources(this.apiToolTip1, "apiToolTip1");
      this.apiToolTip1.hwnd = ((long)(0));
      this.apiToolTip1.Name = "apiToolTip1";
      this.apiToolTip1.NbLignes = 0;
      this.apiToolTip1.Texte = null;
      this.apiToolTip1.TexteBox = null;
      this.apiToolTip1.Titre = null;
      // 
      // Frame1
      // 
      this.Frame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      this.Frame1.Controls.Add(this.Command2);
      this.Frame1.Controls.Add(this.dbGrid);
      resources.ApplyResources(this.Frame1, "Frame1");
      this.Frame1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
      this.Frame1.HelpContextID = 0;
      this.Frame1.Name = "Frame1";
      this.Frame1.TabStop = false;
      // 
      // Command2
      // 
      resources.ApplyResources(this.Command2, "Command2");
      this.Command2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Command2.HelpContextID = 0;
      this.Command2.Image = global::MozartCS.Properties.Resources.ok_32;
      this.Command2.Name = "Command2";
      this.Command2.Tag = "2";
      this.Command2.UseVisualStyleBackColor = true;
      this.Command2.Click += new System.EventHandler(this.Command2_Click);
      // 
      // dbGrid
      // 
      this.dbGrid.FilterBar = true;
      resources.ApplyResources(this.dbGrid, "dbGrid");
      this.dbGrid.FooterBar = true;
      this.dbGrid.Name = "dbGrid";
      // 
      // cmdRechercher
      // 
      this.cmdRechercher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      resources.ApplyResources(this.cmdRechercher, "cmdRechercher");
      this.cmdRechercher.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdRechercher.HelpContextID = 0;
      this.cmdRechercher.Name = "cmdRechercher";
      this.cmdRechercher.Tag = "26";
      this.cmdRechercher.UseVisualStyleBackColor = false;
      this.cmdRechercher.Click += new System.EventHandler(this.cmdRechercher_Click);
      // 
      // cmdValider
      // 
      this.cmdValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      resources.ApplyResources(this.cmdValider, "cmdValider");
      this.cmdValider.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdValider.HelpContextID = 20;
      this.cmdValider.Name = "cmdValider";
      this.cmdValider.Tag = "66";
      this.cmdValider.UseVisualStyleBackColor = false;
      this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
      // 
      // Frame8
      // 
      resources.ApplyResources(this.Frame8, "Frame8");
      this.Frame8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.Frame8.Controls.Add(this.txtFields_Di);
      this.Frame8.Controls.Add(this.txtFields_Num);
      this.Frame8.Controls.Add(this.txtFields_Name);
      this.Frame8.Controls.Add(this.txtFields_Date);
      this.Frame8.Controls.Add(this.txtFields_Demandeur);
      this.Frame8.Controls.Add(this.txtFields_Compte);
      this.Frame8.Controls.Add(this.lblLabels23);
      this.Frame8.Controls.Add(this.lblLabels1);
      this.Frame8.Controls.Add(this.lblLabels16);
      this.Frame8.Controls.Add(this.lblLabels8);
      this.Frame8.Controls.Add(this.lblLabels9);
      this.Frame8.Controls.Add(this.lblLabels5);
      this.Frame8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
      this.Frame8.HelpContextID = 0;
      this.Frame8.Name = "Frame8";
      this.Frame8.TabStop = false;
      // 
      // txtFields_Di
      // 
      resources.ApplyResources(this.txtFields_Di, "txtFields_Di");
      this.txtFields_Di.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtFields_Di.HelpContextID = 0;
      this.txtFields_Di.Name = "txtFields_Di";
      // 
      // txtFields_Num
      // 
      resources.ApplyResources(this.txtFields_Num, "txtFields_Num");
      this.txtFields_Num.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtFields_Num.HelpContextID = 0;
      this.txtFields_Num.Name = "txtFields_Num";
      // 
      // txtFields_Name
      // 
      resources.ApplyResources(this.txtFields_Name, "txtFields_Name");
      this.txtFields_Name.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtFields_Name.HelpContextID = 0;
      this.txtFields_Name.Name = "txtFields_Name";
      // 
      // txtFields_Date
      // 
      resources.ApplyResources(this.txtFields_Date, "txtFields_Date");
      this.txtFields_Date.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtFields_Date.HelpContextID = 0;
      this.txtFields_Date.Name = "txtFields_Date";
      // 
      // txtFields_Demandeur
      // 
      resources.ApplyResources(this.txtFields_Demandeur, "txtFields_Demandeur");
      this.txtFields_Demandeur.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtFields_Demandeur.HelpContextID = 0;
      this.txtFields_Demandeur.Name = "txtFields_Demandeur";
      // 
      // txtFields_Compte
      // 
      resources.ApplyResources(this.txtFields_Compte, "txtFields_Compte");
      this.txtFields_Compte.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtFields_Compte.HelpContextID = 0;
      this.txtFields_Compte.Name = "txtFields_Compte";
      // 
      // lblLabels23
      // 
      resources.ApplyResources(this.lblLabels23, "lblLabels23");
      this.lblLabels23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.lblLabels23.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels23.HelpContextID = 0;
      this.lblLabels23.Name = "lblLabels23";
      // 
      // lblLabels1
      // 
      resources.ApplyResources(this.lblLabels1, "lblLabels1");
      this.lblLabels1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.lblLabels1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels1.HelpContextID = 0;
      this.lblLabels1.Name = "lblLabels1";
      // 
      // lblLabels16
      // 
      resources.ApplyResources(this.lblLabels16, "lblLabels16");
      this.lblLabels16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.lblLabels16.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels16.HelpContextID = 0;
      this.lblLabels16.Name = "lblLabels16";
      // 
      // lblLabels8
      // 
      resources.ApplyResources(this.lblLabels8, "lblLabels8");
      this.lblLabels8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.lblLabels8.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels8.HelpContextID = 0;
      this.lblLabels8.Name = "lblLabels8";
      // 
      // lblLabels9
      // 
      resources.ApplyResources(this.lblLabels9, "lblLabels9");
      this.lblLabels9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.lblLabels9.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels9.HelpContextID = 0;
      this.lblLabels9.Name = "lblLabels9";
      // 
      // lblLabels5
      // 
      resources.ApplyResources(this.lblLabels5, "lblLabels5");
      this.lblLabels5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.lblLabels5.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels5.HelpContextID = 0;
      this.lblLabels5.Name = "lblLabels5";
      // 
      // Frame6
      // 
      resources.ApplyResources(this.Frame6, "Frame6");
      this.Frame6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.Frame6.Controls.Add(this.txtFields_Site);
      this.Frame6.Controls.Add(this.txtFields_Adr1);
      this.Frame6.Controls.Add(this.txtFields_Ville);
      this.Frame6.Controls.Add(this.txtFields_CodePostal);
      this.Frame6.Controls.Add(this.txtFields_Adr2);
      this.Frame6.Controls.Add(this.txtFields_Resp);
      this.Frame6.Controls.Add(this.lblLabels19);
      this.Frame6.Controls.Add(this.lblLabels3);
      this.Frame6.Controls.Add(this.lblLabels4);
      this.Frame6.Controls.Add(this.lblLabels22);
      this.Frame6.Controls.Add(this.lblLabels0);
      this.Frame6.Controls.Add(this.lblLabels17);
      this.Frame6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
      this.Frame6.HelpContextID = 0;
      this.Frame6.Name = "Frame6";
      this.Frame6.TabStop = false;
      // 
      // txtFields_Site
      // 
      resources.ApplyResources(this.txtFields_Site, "txtFields_Site");
      this.txtFields_Site.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtFields_Site.HelpContextID = 0;
      this.txtFields_Site.Name = "txtFields_Site";
      // 
      // txtFields_Adr1
      // 
      resources.ApplyResources(this.txtFields_Adr1, "txtFields_Adr1");
      this.txtFields_Adr1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtFields_Adr1.HelpContextID = 0;
      this.txtFields_Adr1.Name = "txtFields_Adr1";
      // 
      // txtFields_Ville
      // 
      resources.ApplyResources(this.txtFields_Ville, "txtFields_Ville");
      this.txtFields_Ville.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtFields_Ville.HelpContextID = 0;
      this.txtFields_Ville.Name = "txtFields_Ville";
      // 
      // txtFields_CodePostal
      // 
      resources.ApplyResources(this.txtFields_CodePostal, "txtFields_CodePostal");
      this.txtFields_CodePostal.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtFields_CodePostal.HelpContextID = 0;
      this.txtFields_CodePostal.Name = "txtFields_CodePostal";
      // 
      // txtFields_Adr2
      // 
      resources.ApplyResources(this.txtFields_Adr2, "txtFields_Adr2");
      this.txtFields_Adr2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtFields_Adr2.HelpContextID = 0;
      this.txtFields_Adr2.Name = "txtFields_Adr2";
      // 
      // txtFields_Resp
      // 
      resources.ApplyResources(this.txtFields_Resp, "txtFields_Resp");
      this.txtFields_Resp.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtFields_Resp.HelpContextID = 0;
      this.txtFields_Resp.Name = "txtFields_Resp";
      // 
      // lblLabels19
      // 
      resources.ApplyResources(this.lblLabels19, "lblLabels19");
      this.lblLabels19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.lblLabels19.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels19.HelpContextID = 0;
      this.lblLabels19.Name = "lblLabels19";
      // 
      // lblLabels3
      // 
      resources.ApplyResources(this.lblLabels3, "lblLabels3");
      this.lblLabels3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.lblLabels3.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels3.HelpContextID = 0;
      this.lblLabels3.Name = "lblLabels3";
      // 
      // lblLabels4
      // 
      resources.ApplyResources(this.lblLabels4, "lblLabels4");
      this.lblLabels4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.lblLabels4.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels4.HelpContextID = 0;
      this.lblLabels4.Name = "lblLabels4";
      // 
      // lblLabels22
      // 
      resources.ApplyResources(this.lblLabels22, "lblLabels22");
      this.lblLabels22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.lblLabels22.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels22.HelpContextID = 0;
      this.lblLabels22.Name = "lblLabels22";
      // 
      // lblLabels0
      // 
      resources.ApplyResources(this.lblLabels0, "lblLabels0");
      this.lblLabels0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.lblLabels0.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels0.HelpContextID = 0;
      this.lblLabels0.Name = "lblLabels0";
      // 
      // lblLabels17
      // 
      resources.ApplyResources(this.lblLabels17, "lblLabels17");
      this.lblLabels17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.lblLabels17.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels17.HelpContextID = 0;
      this.lblLabels17.Name = "lblLabels17";
      // 
      // apiTGrid
      // 
      resources.ApplyResources(this.apiTGrid, "apiTGrid");
      this.apiTGrid.FilterBar = true;
      this.apiTGrid.FooterBar = true;
      this.apiTGrid.Name = "apiTGrid";
      this.apiTGrid.RowCellStyle += new MozartUC.apiTGrid.RowCellStyleEventHandler(this.apiTGrid_RowCellStyle);
      this.apiTGrid.RowCellClick += new MozartUC.apiTGrid.RowCellClickEventHandler(this.CaseCochee);
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      this.cmdFermer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Tag = "15";
      this.cmdFermer.UseVisualStyleBackColor = false;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // frmPrepaCommandePrest
      // 
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.apiToolTip1);
      this.Controls.Add(this.Frame1);
      this.Controls.Add(this.cmdRechercher);
      this.Controls.Add(this.cmdValider);
      this.Controls.Add(this.Frame8);
      this.Controls.Add(this.Frame6);
      this.Controls.Add(this.apiTGrid);
      this.Controls.Add(this.cmdFermer);
      this.Name = "frmPrepaCommandePrest";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmPrepaCommandePrest_Load);
      this.Frame1.ResumeLayout(false);
      this.Frame8.ResumeLayout(false);
      this.Frame8.PerformLayout();
      this.Frame6.ResumeLayout(false);
      this.Frame6.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private MozartUC.apiTooltip apiToolTip1;
    private MozartUC.apiTGrid dbGrid;
    private MozartUC.apiGroupBox Frame1;
    private MozartUC.apiButton cmdRechercher;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiTextBox txtFields_Di;
    private MozartUC.apiTextBox txtFields_Num;
    private MozartUC.apiTextBox txtFields_Name;
    private MozartUC.apiTextBox txtFields_Date;
    private MozartUC.apiTextBox txtFields_Demandeur;
    private MozartUC.apiTextBox txtFields_Compte;
    private MozartUC.apiLabel lblLabels23;
    private MozartUC.apiLabel lblLabels1;
    private MozartUC.apiLabel lblLabels16;
    private MozartUC.apiLabel lblLabels8;
    private MozartUC.apiLabel lblLabels9;
    private MozartUC.apiLabel lblLabels5;
    private MozartUC.apiGroupBox Frame8;
    private MozartUC.apiTextBox txtFields_Site;
    private MozartUC.apiTextBox txtFields_Adr1;
    private MozartUC.apiTextBox txtFields_Ville;
    private MozartUC.apiTextBox txtFields_CodePostal;
    private MozartUC.apiTextBox txtFields_Adr2;
    private MozartUC.apiTextBox txtFields_Resp;
    private MozartUC.apiLabel lblLabels19;
    private MozartUC.apiLabel lblLabels3;
    private MozartUC.apiLabel lblLabels4;
    private MozartUC.apiLabel lblLabels22;
    private MozartUC.apiLabel lblLabels0;
    private MozartUC.apiLabel lblLabels17;
    private MozartUC.apiGroupBox Frame6;
    private MozartUC.apiTGrid apiTGrid;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiButton Command2;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
