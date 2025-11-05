namespace MozartCS
{
  partial class frmGestFourniture
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestFourniture));
      this.CommonDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.cmdIntegrationIndustrie = new MozartUC.apiButton();
      this.CmdGestCFO = new MozartUC.apiButton();
      this.cmdExportBricomaint = new MozartUC.apiButton();
      this.CmdF = new MozartUC.apiButton();
      this.apiTGridW = new MozartUC.apiTGrid();
      this.framUtil = new MozartUC.apiGroupBox();
      this.CmdWeb = new MozartUC.apiButton();
      this.CmdConsultFOMag = new MozartUC.apiButton();
      this.CmdCopieFou = new MozartUC.apiButton();
      this.CmdVisuMvtStock = new MozartUC.apiButton();
      this.apiChoixFourn = new MozartUC.apiCombo();
      this.txtCritId = new MozartUC.apiTextBox();
      this.cmdFind = new MozartUC.apiButton();
      this.cboCritSerie = new System.Windows.Forms.ComboBox();
      this.txtCritRefFou = new MozartUC.apiTextBox();
      this.txtCritMat = new MozartUC.apiTextBox();
      this.txtCritMarque = new MozartUC.apiTextBox();
      this.txtCritType = new MozartUC.apiTextBox();
      this.txtCritRef = new MozartUC.apiTextBox();
      this.lblId = new MozartUC.apiLabel();
      this.lblserie = new MozartUC.apiLabel();
      this.lblreffou = new MozartUC.apiLabel();
      this.lblF2 = new MozartUC.apiLabel();
      this.lblmat = new MozartUC.apiLabel();
      this.lblmarque = new MozartUC.apiLabel();
      this.lbltype = new MozartUC.apiLabel();
      this.lblref = new MozartUC.apiLabel();
      this.lblfournisseur = new MozartUC.apiLabel();
      this.fraCriteres = new MozartUC.apiGroupBox();
      this.CmdPrixCli = new MozartUC.apiButton();
      this.cmdSupprimer = new MozartUC.apiButton();
      this.cmdArchive = new MozartUC.apiButton();
      this.cmdValidation = new MozartUC.apiButton();
      this.cmdNouvelle = new MozartUC.apiButton();
      this.cmdValider = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.apiTGrid1 = new MozartUC.apiTGrid();
      this.Label1 = new MozartUC.apiLabel();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.framUtil.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // cmdIntegrationIndustrie
      // 
      resources.ApplyResources(this.cmdIntegrationIndustrie, "cmdIntegrationIndustrie");
      this.cmdIntegrationIndustrie.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdIntegrationIndustrie.HelpContextID = 0;
      this.cmdIntegrationIndustrie.Name = "cmdIntegrationIndustrie";
      this.cmdIntegrationIndustrie.UseVisualStyleBackColor = true;
      this.cmdIntegrationIndustrie.Click += new System.EventHandler(this.cmdIntegrationIndustrie_Click);
      // 
      // CmdGestCFO
      // 
      resources.ApplyResources(this.CmdGestCFO, "CmdGestCFO");
      this.CmdGestCFO.ForeColor = System.Drawing.SystemColors.ControlText;
      this.CmdGestCFO.HelpContextID = 611;
      this.CmdGestCFO.Name = "CmdGestCFO";
      this.CmdGestCFO.UseVisualStyleBackColor = true;
      this.CmdGestCFO.Click += new System.EventHandler(this.CmdGestCFO_Click);
      // 
      // cmdExportBricomaint
      // 
      resources.ApplyResources(this.cmdExportBricomaint, "cmdExportBricomaint");
      this.cmdExportBricomaint.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdExportBricomaint.HelpContextID = 0;
      this.cmdExportBricomaint.Name = "cmdExportBricomaint";
      this.cmdExportBricomaint.UseVisualStyleBackColor = true;
      this.cmdExportBricomaint.Click += new System.EventHandler(this.cmdExportBricomaint_Click);
      // 
      // CmdF
      // 
      this.CmdF.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      resources.ApplyResources(this.CmdF, "CmdF");
      this.CmdF.ForeColor = System.Drawing.SystemColors.ControlText;
      this.CmdF.HelpContextID = 0;
      this.CmdF.Name = "CmdF";
      this.CmdF.UseVisualStyleBackColor = true;
      this.CmdF.Click += new System.EventHandler(this.CmdF_Click);
      // 
      // apiTGridW
      // 
      resources.ApplyResources(this.apiTGridW, "apiTGridW");
      this.apiTGridW.FilterBar = true;
      this.apiTGridW.FooterBar = true;
      this.apiTGridW.Name = "apiTGridW";
      // 
      // framUtil
      // 
      this.framUtil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.framUtil.Controls.Add(this.CmdF);
      this.framUtil.Controls.Add(this.apiTGridW);
      resources.ApplyResources(this.framUtil, "framUtil");
      this.framUtil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.framUtil.FrameColor = System.Drawing.Color.Empty;
      this.framUtil.HelpContextID = 0;
      this.framUtil.Name = "framUtil";
      this.framUtil.TabStop = false;
      // 
      // CmdWeb
      // 
      resources.ApplyResources(this.CmdWeb, "CmdWeb");
      this.CmdWeb.ForeColor = System.Drawing.SystemColors.ControlText;
      this.CmdWeb.HelpContextID = 634;
      this.CmdWeb.Name = "CmdWeb";
      this.CmdWeb.UseVisualStyleBackColor = true;
      this.CmdWeb.Click += new System.EventHandler(this.CmdWeb_Click);
      // 
      // CmdConsultFOMag
      // 
      resources.ApplyResources(this.CmdConsultFOMag, "CmdConsultFOMag");
      this.CmdConsultFOMag.ForeColor = System.Drawing.SystemColors.ControlText;
      this.CmdConsultFOMag.HelpContextID = 0;
      this.CmdConsultFOMag.Name = "CmdConsultFOMag";
      this.CmdConsultFOMag.Tag = "80";
      this.CmdConsultFOMag.UseVisualStyleBackColor = true;
      this.CmdConsultFOMag.Click += new System.EventHandler(this.CmdConsultFOMag_Click);
      // 
      // CmdCopieFou
      // 
      resources.ApplyResources(this.CmdCopieFou, "CmdCopieFou");
      this.CmdCopieFou.ForeColor = System.Drawing.SystemColors.ControlText;
      this.CmdCopieFou.HelpContextID = 295;
      this.CmdCopieFou.Name = "CmdCopieFou";
      this.CmdCopieFou.Tag = "47";
      this.CmdCopieFou.UseVisualStyleBackColor = true;
      this.CmdCopieFou.Click += new System.EventHandler(this.CmdCopieFou_Click);
      // 
      // CmdVisuMvtStock
      // 
      resources.ApplyResources(this.CmdVisuMvtStock, "CmdVisuMvtStock");
      this.CmdVisuMvtStock.ForeColor = System.Drawing.SystemColors.ControlText;
      this.CmdVisuMvtStock.HelpContextID = 289;
      this.CmdVisuMvtStock.Name = "CmdVisuMvtStock";
      this.CmdVisuMvtStock.Tag = "110";
      this.CmdVisuMvtStock.UseVisualStyleBackColor = true;
      this.CmdVisuMvtStock.Click += new System.EventHandler(this.CmdVisuMvtStock_Click);
      // 
      // apiChoixFourn
      // 
      resources.ApplyResources(this.apiChoixFourn, "apiChoixFourn");
      this.apiChoixFourn.Name = "apiChoixFourn";
      this.apiChoixFourn.NewValues = false;
      // 
      // txtCritId
      // 
      resources.ApplyResources(this.txtCritId, "txtCritId");
      this.txtCritId.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtCritId.HelpContextID = 0;
      this.txtCritId.Name = "txtCritId";
      this.txtCritId.Tag = "TFOU.NFOUNUM";
      this.txtCritId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCritId_KeyPress);
      // 
      // cmdFind
      // 
      resources.ApplyResources(this.cmdFind, "cmdFind");
      this.cmdFind.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdFind.HelpContextID = 0;
      this.cmdFind.Image = global::MozartCS.Properties.Resources.Find;
      this.cmdFind.Name = "cmdFind";
      this.cmdFind.Tag = "8";
      this.cmdFind.UseVisualStyleBackColor = true;
      this.cmdFind.Click += new System.EventHandler(this.cmdFind_Click);
      // 
      // cboCritSerie
      // 
      resources.ApplyResources(this.cboCritSerie, "cboCritSerie");
      this.cboCritSerie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboCritSerie.Name = "cboCritSerie";
      // 
      // txtCritRefFou
      // 
      resources.ApplyResources(this.txtCritRefFou, "txtCritRefFou");
      this.txtCritRefFou.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtCritRefFou.HelpContextID = 0;
      this.txtCritRefFou.Name = "txtCritRefFou";
      this.txtCritRefFou.Tag = "TSTF.VSTFFOUREFCLI";
      // 
      // txtCritMat
      // 
      resources.ApplyResources(this.txtCritMat, "txtCritMat");
      this.txtCritMat.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtCritMat.HelpContextID = 0;
      this.txtCritMat.Name = "txtCritMat";
      this.txtCritMat.Tag = "TFOU.VFOUMAT";
      // 
      // txtCritMarque
      // 
      resources.ApplyResources(this.txtCritMarque, "txtCritMarque");
      this.txtCritMarque.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtCritMarque.HelpContextID = 0;
      this.txtCritMarque.Name = "txtCritMarque";
      this.txtCritMarque.Tag = "TFOU.VFOUMAR";
      // 
      // txtCritType
      // 
      resources.ApplyResources(this.txtCritType, "txtCritType");
      this.txtCritType.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtCritType.HelpContextID = 0;
      this.txtCritType.Name = "txtCritType";
      this.txtCritType.Tag = "TFOU.VFOUTYP";
      // 
      // txtCritRef
      // 
      resources.ApplyResources(this.txtCritRef, "txtCritRef");
      this.txtCritRef.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtCritRef.HelpContextID = 0;
      this.txtCritRef.Name = "txtCritRef";
      this.txtCritRef.Tag = "TFOU.VFOUREF";
      // 
      // lblId
      // 
      resources.ApplyResources(this.lblId, "lblId");
      this.lblId.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblId.HelpContextID = 0;
      this.lblId.Name = "lblId";
      // 
      // lblserie
      // 
      resources.ApplyResources(this.lblserie, "lblserie");
      this.lblserie.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblserie.HelpContextID = 0;
      this.lblserie.Name = "lblserie";
      // 
      // lblreffou
      // 
      resources.ApplyResources(this.lblreffou, "lblreffou");
      this.lblreffou.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblreffou.HelpContextID = 0;
      this.lblreffou.Name = "lblreffou";
      // 
      // lblF2
      // 
      resources.ApplyResources(this.lblF2, "lblF2");
      this.lblF2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblF2.HelpContextID = 0;
      this.lblF2.Name = "lblF2";
      // 
      // lblmat
      // 
      resources.ApplyResources(this.lblmat, "lblmat");
      this.lblmat.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblmat.HelpContextID = 0;
      this.lblmat.Name = "lblmat";
      // 
      // lblmarque
      // 
      resources.ApplyResources(this.lblmarque, "lblmarque");
      this.lblmarque.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblmarque.HelpContextID = 0;
      this.lblmarque.Name = "lblmarque";
      // 
      // lbltype
      // 
      resources.ApplyResources(this.lbltype, "lbltype");
      this.lbltype.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lbltype.HelpContextID = 0;
      this.lbltype.Name = "lbltype";
      // 
      // lblref
      // 
      resources.ApplyResources(this.lblref, "lblref");
      this.lblref.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblref.HelpContextID = 0;
      this.lblref.Name = "lblref";
      // 
      // lblfournisseur
      // 
      resources.ApplyResources(this.lblfournisseur, "lblfournisseur");
      this.lblfournisseur.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblfournisseur.HelpContextID = 0;
      this.lblfournisseur.Name = "lblfournisseur";
      // 
      // fraCriteres
      // 
      resources.ApplyResources(this.fraCriteres, "fraCriteres");
      this.fraCriteres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(218)))), ((int)(((byte)(242)))));
      this.fraCriteres.FrameColor = System.Drawing.Color.Empty;
      this.fraCriteres.HelpContextID = 0;
      this.fraCriteres.Name = "fraCriteres";
      this.fraCriteres.TabStop = false;
      // 
      // CmdPrixCli
      // 
      resources.ApplyResources(this.CmdPrixCli, "CmdPrixCli");
      this.CmdPrixCli.ForeColor = System.Drawing.SystemColors.ControlText;
      this.CmdPrixCli.HelpContextID = 260;
      this.CmdPrixCli.Name = "CmdPrixCli";
      this.CmdPrixCli.Tag = "90";
      this.CmdPrixCli.UseVisualStyleBackColor = true;
      this.CmdPrixCli.Click += new System.EventHandler(this.CmdPrixCli_Click);
      // 
      // cmdSupprimer
      // 
      this.cmdSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.cmdSupprimer, "cmdSupprimer");
      this.cmdSupprimer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdSupprimer.HelpContextID = 161;
      this.cmdSupprimer.Name = "cmdSupprimer";
      this.cmdSupprimer.Tag = "27";
      this.cmdSupprimer.UseVisualStyleBackColor = false;
      this.cmdSupprimer.Click += new System.EventHandler(this.cmdSupprimer_Click);
      // 
      // cmdArchive
      // 
      this.cmdArchive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.cmdArchive, "cmdArchive");
      this.cmdArchive.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdArchive.HelpContextID = 0;
      this.cmdArchive.Name = "cmdArchive";
      this.cmdArchive.Tag = "20";
      this.cmdArchive.UseVisualStyleBackColor = false;
      this.cmdArchive.Click += new System.EventHandler(this.cmdArchive_Click);
      // 
      // cmdValidation
      // 
      resources.ApplyResources(this.cmdValidation, "cmdValidation");
      this.cmdValidation.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdValidation.HelpContextID = 0;
      this.cmdValidation.Name = "cmdValidation";
      this.cmdValidation.Tag = "";
      this.cmdValidation.UseVisualStyleBackColor = true;
      this.cmdValidation.Click += new System.EventHandler(this.cmdValidation_Click);
      // 
      // cmdNouvelle
      // 
      resources.ApplyResources(this.cmdNouvelle, "cmdNouvelle");
      this.cmdNouvelle.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdNouvelle.HelpContextID = 281;
      this.cmdNouvelle.Name = "cmdNouvelle";
      this.cmdNouvelle.Tag = "2";
      this.cmdNouvelle.UseVisualStyleBackColor = true;
      this.cmdNouvelle.Click += new System.EventHandler(this.cmdNouvelle_Click);
      // 
      // cmdValider
      // 
      resources.ApplyResources(this.cmdValider, "cmdValider");
      this.cmdValider.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdValider.HelpContextID = 0;
      this.cmdValider.Name = "cmdValider";
      this.cmdValider.Tag = "19";
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
      // apiTGrid1
      // 
      resources.ApplyResources(this.apiTGrid1, "apiTGrid1");
      this.apiTGrid1.FilterBar = true;
      this.apiTGrid1.FooterBar = true;
      this.apiTGrid1.Name = "apiTGrid1";
      this.apiTGrid1.RowStyle += new MozartUC.apiTGrid.RowStyleEventHandler(this.apiTGrid1_RowStyle);
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
      this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(218)))), ((int)(((byte)(242)))));
      this.tableLayoutPanel1.Controls.Add(this.lblF2, 17, 0);
      this.tableLayoutPanel1.Controls.Add(this.cmdFind, 16, 0);
      this.tableLayoutPanel1.Controls.Add(this.txtCritId, 13, 0);
      this.tableLayoutPanel1.Controls.Add(this.lblserie, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.lblfournisseur, 14, 0);
      this.tableLayoutPanel1.Controls.Add(this.cboCritSerie, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.lblId, 12, 0);
      this.tableLayoutPanel1.Controls.Add(this.txtCritRefFou, 11, 0);
      this.tableLayoutPanel1.Controls.Add(this.lblmat, 2, 0);
      this.tableLayoutPanel1.Controls.Add(this.txtCritRef, 9, 0);
      this.tableLayoutPanel1.Controls.Add(this.lblreffou, 10, 0);
      this.tableLayoutPanel1.Controls.Add(this.apiChoixFourn, 15, 0);
      this.tableLayoutPanel1.Controls.Add(this.txtCritType, 7, 0);
      this.tableLayoutPanel1.Controls.Add(this.txtCritMarque, 5, 0);
      this.tableLayoutPanel1.Controls.Add(this.txtCritMat, 3, 0);
      this.tableLayoutPanel1.Controls.Add(this.lblmarque, 4, 0);
      this.tableLayoutPanel1.Controls.Add(this.lblref, 8, 0);
      this.tableLayoutPanel1.Controls.Add(this.lbltype, 6, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      // 
      // frmGestFourniture
      // 
      this.AcceptButton = this.cmdFind;
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.tableLayoutPanel1);
      this.Controls.Add(this.cmdIntegrationIndustrie);
      this.Controls.Add(this.CmdGestCFO);
      this.Controls.Add(this.cmdExportBricomaint);
      this.Controls.Add(this.framUtil);
      this.Controls.Add(this.CmdWeb);
      this.Controls.Add(this.CmdConsultFOMag);
      this.Controls.Add(this.CmdCopieFou);
      this.Controls.Add(this.CmdVisuMvtStock);
      this.Controls.Add(this.fraCriteres);
      this.Controls.Add(this.CmdPrixCli);
      this.Controls.Add(this.cmdSupprimer);
      this.Controls.Add(this.cmdArchive);
      this.Controls.Add(this.cmdValidation);
      this.Controls.Add(this.cmdNouvelle);
      this.Controls.Add(this.cmdValider);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.apiTGrid1);
      this.Controls.Add(this.Label1);
      this.KeyPreview = true;
      this.Name = "frmGestFourniture";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmGestFourniture_Load);
      this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmGestFourniture_KeyUp);
      this.framUtil.ResumeLayout(false);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.OpenFileDialog CommonDialog1;
    private MozartUC.apiButton cmdIntegrationIndustrie;
    private MozartUC.apiButton CmdGestCFO;
    private MozartUC.apiButton cmdExportBricomaint;
    private MozartUC.apiButton CmdF;
    private MozartUC.apiTGrid apiTGridW;
    private MozartUC.apiGroupBox framUtil;
    private MozartUC.apiButton CmdWeb;
    private MozartUC.apiButton CmdConsultFOMag;
    private MozartUC.apiButton CmdCopieFou;
    private MozartUC.apiButton CmdVisuMvtStock;
    private MozartUC.apiCombo apiChoixFourn;
    private MozartUC.apiTextBox txtCritId;
    private MozartUC.apiButton cmdFind;
    private System.Windows.Forms.ComboBox cboCritSerie;
    private MozartUC.apiTextBox txtCritRefFou;
    private MozartUC.apiTextBox txtCritMat;
    private MozartUC.apiTextBox txtCritMarque;
    private MozartUC.apiTextBox txtCritType;
    private MozartUC.apiTextBox txtCritRef;
    private MozartUC.apiLabel lblId;
    private MozartUC.apiLabel lblserie;
    private MozartUC.apiLabel lblreffou;
    private MozartUC.apiLabel lblF2;
    private MozartUC.apiLabel lblmat;
    private MozartUC.apiLabel lblmarque;
    private MozartUC.apiLabel lbltype;
    private MozartUC.apiLabel lblref;
    private MozartUC.apiLabel lblfournisseur;
    private MozartUC.apiGroupBox fraCriteres;
    private MozartUC.apiButton CmdPrixCli;
    private MozartUC.apiButton cmdSupprimer;
    private MozartUC.apiButton cmdArchive;
    private MozartUC.apiButton cmdValidation;
    private MozartUC.apiButton cmdNouvelle;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiTGrid apiTGrid1;
    private MozartUC.apiLabel Label1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
  }
}
