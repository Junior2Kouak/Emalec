namespace MozartCS
{
  partial class frmGestDroitWeb
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestDroitWeb));
			this.lstPresta = new System.Windows.Forms.CheckedListBox();
			this.Frame5 = new MozartUC.apiGroupBox();
			this.cmdAnnuler = new MozartUC.apiButton();
			this.cmdValiderChaff = new MozartUC.apiButton();
			this.apiTGridArch = new MozartUC.apiTGrid();
			this.framArch = new MozartUC.apiGroupBox();
			this.cmdArch = new MozartUC.apiButton();
			this.lstEns = new System.Windows.Forms.CheckedListBox();
			this.Frame1 = new MozartUC.apiGroupBox();
			this.lstCat = new System.Windows.Forms.CheckedListBox();
			this.Frame2 = new MozartUC.apiGroupBox();
			this.chkPrix = new MozartUC.apiCheckBox();
			this.chkPresta = new MozartUC.apiCheckBox();
			this.txtMini = new MozartUC.apiTextBox();
			this.chkEns = new MozartUC.apiCheckBox();
			this.chkType = new MozartUC.apiCheckBox();
			this.chkContrat = new MozartUC.apiCheckBox();
			this.chkLogin = new MozartUC.apiCheckBox();
			this.txtValid = new MozartUC.apiTextBox();
			this.cboDroit = new System.Windows.Forms.ComboBox();
			this.txtUtilisateur = new MozartUC.apiTextBox();
			this.TxtPwd = new MozartUC.apiTextBox();
			this.Label6 = new MozartUC.apiLabel();
			this.Label5 = new MozartUC.apiLabel();
			this.Label2 = new MozartUC.apiLabel();
			this.Label3 = new MozartUC.apiLabel();
			this.Label4 = new MozartUC.apiLabel();
			this.Frame4 = new MozartUC.apiGroupBox();
			this.cmdValider = new MozartUC.apiButton();
			this.cmdFermer = new MozartUC.apiButton();
			this.cmdCocherT = new MozartUC.apiButton();
			this.cmdDecocher = new MozartUC.apiButton();
			this.apiTGridH = new MozartUC.apiTGrid();
			this.lblNbSites = new MozartUC.apiLabel();
			this.Frame3 = new MozartUC.apiGroupBox();
			this.Label14 = new MozartUC.apiLabel();
			this.Frame5.SuspendLayout();
			this.framArch.SuspendLayout();
			this.Frame1.SuspendLayout();
			this.Frame2.SuspendLayout();
			this.Frame4.SuspendLayout();
			this.Frame3.SuspendLayout();
			this.SuspendLayout();
			// 
			// lstPresta
			// 
			resources.ApplyResources(this.lstPresta, "lstPresta");
			this.lstPresta.CheckOnClick = true;
			this.lstPresta.Name = "lstPresta";
			// 
			// Frame5
			// 
			resources.ApplyResources(this.Frame5, "Frame5");
			this.Frame5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.Frame5.Controls.Add(this.lstPresta);
			this.Frame5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.Frame5.FrameColor = System.Drawing.Color.Empty;
			this.Frame5.HelpContextID = 0;
			this.Frame5.Name = "Frame5";
			this.Frame5.TabStop = false;
			// 
			// cmdAnnuler
			// 
			resources.ApplyResources(this.cmdAnnuler, "cmdAnnuler");
			this.cmdAnnuler.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdAnnuler.HelpContextID = 0;
			this.cmdAnnuler.Name = "cmdAnnuler";
			this.cmdAnnuler.UseVisualStyleBackColor = true;
			this.cmdAnnuler.Click += new System.EventHandler(this.cmdAnnuler_Click);
			// 
			// cmdValiderChaff
			// 
			resources.ApplyResources(this.cmdValiderChaff, "cmdValiderChaff");
			this.cmdValiderChaff.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdValiderChaff.HelpContextID = 0;
			this.cmdValiderChaff.Name = "cmdValiderChaff";
			this.cmdValiderChaff.UseVisualStyleBackColor = true;
			this.cmdValiderChaff.Click += new System.EventHandler(this.cmdValiderChaff_Click);
			// 
			// apiTGridArch
			// 
			resources.ApplyResources(this.apiTGridArch, "apiTGridArch");
			this.apiTGridArch.FilterBar = true;
			this.apiTGridArch.FooterBar = true;
			this.apiTGridArch.Name = "apiTGridArch";
			// 
			// framArch
			// 
			resources.ApplyResources(this.framArch, "framArch");
			this.framArch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.framArch.Controls.Add(this.cmdAnnuler);
			this.framArch.Controls.Add(this.cmdValiderChaff);
			this.framArch.Controls.Add(this.apiTGridArch);
			this.framArch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.framArch.FrameColor = System.Drawing.Color.Empty;
			this.framArch.HelpContextID = 0;
			this.framArch.Name = "framArch";
			this.framArch.TabStop = false;
			// 
			// cmdArch
			// 
			resources.ApplyResources(this.cmdArch, "cmdArch");
			this.cmdArch.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdArch.HelpContextID = 0;
			this.cmdArch.Name = "cmdArch";
			this.cmdArch.Tag = "29";
			this.cmdArch.UseVisualStyleBackColor = true;
			this.cmdArch.Click += new System.EventHandler(this.cmdArch_Click);
			// 
			// lstEns
			// 
			this.lstEns.CheckOnClick = true;
			resources.ApplyResources(this.lstEns, "lstEns");
			this.lstEns.Name = "lstEns";
			// 
			// Frame1
			// 
			resources.ApplyResources(this.Frame1, "Frame1");
			this.Frame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.Frame1.Controls.Add(this.lstEns);
			this.Frame1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.Frame1.FrameColor = System.Drawing.Color.Empty;
			this.Frame1.HelpContextID = 0;
			this.Frame1.Name = "Frame1";
			this.Frame1.TabStop = false;
			// 
			// lstCat
			// 
			this.lstCat.CheckOnClick = true;
			resources.ApplyResources(this.lstCat, "lstCat");
			this.lstCat.Name = "lstCat";
			// 
			// Frame2
			// 
			resources.ApplyResources(this.Frame2, "Frame2");
			this.Frame2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.Frame2.Controls.Add(this.lstCat);
			this.Frame2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.Frame2.FrameColor = System.Drawing.Color.Empty;
			this.Frame2.HelpContextID = 0;
			this.Frame2.Name = "Frame2";
			this.Frame2.TabStop = false;
			// 
			// chkPrix
			// 
			this.chkPrix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			resources.ApplyResources(this.chkPrix, "chkPrix");
			this.chkPrix.ForeColor = System.Drawing.SystemColors.ControlText;
			this.chkPrix.HelpContextID = 0;
			this.chkPrix.Name = "chkPrix";
			this.chkPrix.UseVisualStyleBackColor = false;
			// 
			// chkPresta
			// 
			this.chkPresta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			resources.ApplyResources(this.chkPresta, "chkPresta");
			this.chkPresta.ForeColor = System.Drawing.SystemColors.ControlText;
			this.chkPresta.HelpContextID = 0;
			this.chkPresta.Name = "chkPresta";
			this.chkPresta.UseVisualStyleBackColor = false;
			this.chkPresta.Click += new System.EventHandler(this.chkPresta_Click);
			// 
			// txtMini
			// 
			this.txtMini.BackColor = System.Drawing.SystemColors.Control;
			this.txtMini.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtMini.HelpContextID = 0;
			resources.ApplyResources(this.txtMini, "txtMini");
			this.txtMini.Name = "txtMini";
			// 
			// chkEns
			// 
			this.chkEns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			resources.ApplyResources(this.chkEns, "chkEns");
			this.chkEns.ForeColor = System.Drawing.SystemColors.ControlText;
			this.chkEns.HelpContextID = 0;
			this.chkEns.Name = "chkEns";
			this.chkEns.UseVisualStyleBackColor = false;
			this.chkEns.Click += new System.EventHandler(this.chkEns_Click);
			// 
			// chkType
			// 
			this.chkType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			resources.ApplyResources(this.chkType, "chkType");
			this.chkType.ForeColor = System.Drawing.SystemColors.ControlText;
			this.chkType.HelpContextID = 0;
			this.chkType.Name = "chkType";
			this.chkType.UseVisualStyleBackColor = false;
			// 
			// chkContrat
			// 
			this.chkContrat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			resources.ApplyResources(this.chkContrat, "chkContrat");
			this.chkContrat.ForeColor = System.Drawing.SystemColors.ControlText;
			this.chkContrat.HelpContextID = 0;
			this.chkContrat.Name = "chkContrat";
			this.chkContrat.UseVisualStyleBackColor = false;
			this.chkContrat.Click += new System.EventHandler(this.chkContrat_Click);
			// 
			// chkLogin
			// 
			this.chkLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			resources.ApplyResources(this.chkLogin, "chkLogin");
			this.chkLogin.ForeColor = System.Drawing.SystemColors.ControlText;
			this.chkLogin.HelpContextID = 0;
			this.chkLogin.Name = "chkLogin";
			this.chkLogin.UseVisualStyleBackColor = false;
			// 
			// txtValid
			// 
			this.txtValid.BackColor = System.Drawing.SystemColors.Control;
			this.txtValid.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtValid.HelpContextID = 0;
			resources.ApplyResources(this.txtValid, "txtValid");
			this.txtValid.Name = "txtValid";
			this.txtValid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValid_KeyPress);
			// 
			// cboDroit
			// 
			this.cboDroit.BackColor = System.Drawing.SystemColors.Control;
			resources.ApplyResources(this.cboDroit, "cboDroit");
			this.cboDroit.Name = "cboDroit";
			// 
			// txtUtilisateur
			// 
			this.txtUtilisateur.BackColor = System.Drawing.SystemColors.Control;
			this.txtUtilisateur.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtUtilisateur.HelpContextID = 0;
			resources.ApplyResources(this.txtUtilisateur, "txtUtilisateur");
			this.txtUtilisateur.Name = "txtUtilisateur";
			this.txtUtilisateur.TextChanged += new System.EventHandler(this.Text_Changed);
			// 
			// TxtPwd
			// 
			this.TxtPwd.BackColor = System.Drawing.SystemColors.Control;
			this.TxtPwd.ForeColor = System.Drawing.SystemColors.ControlText;
			this.TxtPwd.HelpContextID = 0;
			resources.ApplyResources(this.TxtPwd, "TxtPwd");
			this.TxtPwd.Name = "TxtPwd";
			this.TxtPwd.TextChanged += new System.EventHandler(this.Text_Changed);
			// 
			// Label6
			// 
			resources.ApplyResources(this.Label6, "Label6");
			this.Label6.BackColor = System.Drawing.Color.Transparent;
			this.Label6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label6.HelpContextID = 0;
			this.Label6.Name = "Label6";
			// 
			// Label5
			// 
			resources.ApplyResources(this.Label5, "Label5");
			this.Label5.BackColor = System.Drawing.Color.Transparent;
			this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label5.HelpContextID = 0;
			this.Label5.Name = "Label5";
			// 
			// Label2
			// 
			resources.ApplyResources(this.Label2, "Label2");
			this.Label2.BackColor = System.Drawing.Color.Transparent;
			this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label2.HelpContextID = 0;
			this.Label2.Name = "Label2";
			// 
			// Label3
			// 
			resources.ApplyResources(this.Label3, "Label3");
			this.Label3.BackColor = System.Drawing.Color.Transparent;
			this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label3.HelpContextID = 0;
			this.Label3.Name = "Label3";
			// 
			// Label4
			// 
			resources.ApplyResources(this.Label4, "Label4");
			this.Label4.BackColor = System.Drawing.Color.Transparent;
			this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label4.HelpContextID = 0;
			this.Label4.Name = "Label4";
			// 
			// Frame4
			// 
			this.Frame4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.Frame4.Controls.Add(this.chkPrix);
			this.Frame4.Controls.Add(this.chkPresta);
			this.Frame4.Controls.Add(this.txtMini);
			this.Frame4.Controls.Add(this.chkEns);
			this.Frame4.Controls.Add(this.chkType);
			this.Frame4.Controls.Add(this.chkContrat);
			this.Frame4.Controls.Add(this.chkLogin);
			this.Frame4.Controls.Add(this.txtValid);
			this.Frame4.Controls.Add(this.cboDroit);
			this.Frame4.Controls.Add(this.txtUtilisateur);
			this.Frame4.Controls.Add(this.TxtPwd);
			this.Frame4.Controls.Add(this.Label6);
			this.Frame4.Controls.Add(this.Label5);
			this.Frame4.Controls.Add(this.Label2);
			this.Frame4.Controls.Add(this.Label3);
			this.Frame4.Controls.Add(this.Label4);
			resources.ApplyResources(this.Frame4, "Frame4");
			this.Frame4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.Frame4.FrameColor = System.Drawing.Color.Empty;
			this.Frame4.HelpContextID = 0;
			this.Frame4.Name = "Frame4";
			this.Frame4.TabStop = false;
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
			// cmdCocherT
			// 
			resources.ApplyResources(this.cmdCocherT, "cmdCocherT");
			this.cmdCocherT.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdCocherT.HelpContextID = 0;
			this.cmdCocherT.Name = "cmdCocherT";
			this.cmdCocherT.UseVisualStyleBackColor = true;
			this.cmdCocherT.Click += new System.EventHandler(this.cmdCocherT_Click);
			// 
			// cmdDecocher
			// 
			resources.ApplyResources(this.cmdDecocher, "cmdDecocher");
			this.cmdDecocher.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdDecocher.HelpContextID = 0;
			this.cmdDecocher.Name = "cmdDecocher";
			this.cmdDecocher.UseVisualStyleBackColor = true;
			this.cmdDecocher.Click += new System.EventHandler(this.cmdDecocher_Click);
			// 
			// apiTGridH
			// 
			resources.ApplyResources(this.apiTGridH, "apiTGridH");
			this.apiTGridH.BackColor = System.Drawing.SystemColors.Control;
			this.apiTGridH.FilterBar = true;
			this.apiTGridH.FooterBar = true;
			this.apiTGridH.Name = "apiTGridH";
			this.apiTGridH.CellValueChanged += new MozartUC.apiTGrid.CellValueChangedEventHandler(this.apiTGridH_CellValueChanged);
			// 
			// lblNbSites
			// 
			resources.ApplyResources(this.lblNbSites, "lblNbSites");
			this.lblNbSites.BackColor = System.Drawing.Color.Transparent;
			this.lblNbSites.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblNbSites.HelpContextID = 0;
			this.lblNbSites.Name = "lblNbSites";
			this.lblNbSites.Tag = "Nb sites cochés :";
			// 
			// Frame3
			// 
			resources.ApplyResources(this.Frame3, "Frame3");
			this.Frame3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.Frame3.Controls.Add(this.cmdCocherT);
			this.Frame3.Controls.Add(this.cmdDecocher);
			this.Frame3.Controls.Add(this.lblNbSites);
			this.Frame3.Controls.Add(this.apiTGridH);
			this.Frame3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.Frame3.FrameColor = System.Drawing.Color.Empty;
			this.Frame3.HelpContextID = 0;
			this.Frame3.Name = "Frame3";
			this.Frame3.TabStop = false;
			// 
			// Label14
			// 
			this.Label14.BackColor = System.Drawing.Color.Wheat;
			resources.ApplyResources(this.Label14, "Label14");
			this.Label14.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label14.HelpContextID = 0;
			this.Label14.Name = "Label14";
			// 
			// frmGestDroitWeb
			// 
			this.AcceptButton = this.cmdFermer;
			this.BackColor = System.Drawing.Color.Wheat;
			this.CancelButton = this.cmdFermer;
			resources.ApplyResources(this, "$this");
			this.Controls.Add(this.Frame5);
			this.Controls.Add(this.framArch);
			this.Controls.Add(this.cmdArch);
			this.Controls.Add(this.Frame1);
			this.Controls.Add(this.Frame2);
			this.Controls.Add(this.Frame4);
			this.Controls.Add(this.cmdValider);
			this.Controls.Add(this.cmdFermer);
			this.Controls.Add(this.Frame3);
			this.Controls.Add(this.Label14);
			this.Name = "frmGestDroitWeb";
			this.ShowInTaskbar = false;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmGestDroitWeb_Load);
			this.Frame5.ResumeLayout(false);
			this.framArch.ResumeLayout(false);
			this.Frame1.ResumeLayout(false);
			this.Frame2.ResumeLayout(false);
			this.Frame4.ResumeLayout(false);
			this.Frame4.PerformLayout();
			this.Frame3.ResumeLayout(false);
			this.ResumeLayout(false);

    }

    private void ChkPresta_Click(object sender, System.EventArgs e)
    {
      throw new System.NotImplementedException();
    }

    #endregion

    private System.Windows.Forms.CheckedListBox lstPresta;
    private MozartUC.apiGroupBox Frame5;
    private MozartUC.apiButton cmdAnnuler;
    private MozartUC.apiButton cmdValiderChaff;
    private MozartUC.apiTGrid apiTGridArch;
    private MozartUC.apiGroupBox framArch;
    private MozartUC.apiButton cmdArch;
    private System.Windows.Forms.CheckedListBox lstEns;
    private MozartUC.apiGroupBox Frame1;
    private System.Windows.Forms.CheckedListBox lstCat;
    private MozartUC.apiGroupBox Frame2;
    private MozartUC.apiCheckBox chkPrix;
    private MozartUC.apiCheckBox chkPresta;
    private MozartUC.apiTextBox txtMini;
    private MozartUC.apiCheckBox chkEns;
    private MozartUC.apiCheckBox chkType;
    private MozartUC.apiCheckBox chkContrat;
    private MozartUC.apiCheckBox chkLogin;
    private MozartUC.apiTextBox txtValid;
    private System.Windows.Forms.ComboBox cboDroit;
    private MozartUC.apiTextBox txtUtilisateur;
    private MozartUC.apiTextBox TxtPwd;
    private MozartUC.apiLabel Label6;
    private MozartUC.apiLabel Label5;
    private MozartUC.apiLabel Label2;
    private MozartUC.apiLabel Label3;
    private MozartUC.apiLabel Label4;
    private MozartUC.apiGroupBox Frame4;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiButton cmdCocherT;
    private MozartUC.apiButton cmdDecocher;
    private MozartUC.apiTGrid apiTGridH;
    private MozartUC.apiLabel lblNbSites;
    private MozartUC.apiGroupBox Frame3;
    private MozartUC.apiLabel Label14;
    // TODO GetCodeDeclareControl cas non traitÃ© pour type VB.Line

  }
}
