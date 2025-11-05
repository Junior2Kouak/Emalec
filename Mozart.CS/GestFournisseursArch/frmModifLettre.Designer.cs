namespace MozartCS
{
  partial class frmModifLettre
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModifLettre));
			this.cmdVisu = new MozartUC.apiButton();
			this.cmdValider = new MozartUC.apiButton();
			this.cmdImprimer = new MozartUC.apiButton();
			this.cmdFermer = new MozartUC.apiButton();
			this.cmdSpell = new MozartUC.apiButton();
			this.cmdTraduction = new MozartUC.apiButton();
			this.txtNumAR = new MozartUC.apiTextBox();
			this.txtPied = new MozartUC.apiTextBox();
			this.txtRef = new MozartUC.apiTextBox();
			this.txtObjet = new MozartUC.apiTextBox();
			this.txtCompte = new MozartUC.apiTextBox();
			this.txtLettre = new MozartUC.apiTextBox();
			this.lblNumAR = new MozartUC.apiLabel();
			this.lblLabels3 = new MozartUC.apiLabel();
			this.lblLabels15 = new MozartUC.apiLabel();
			this.lblLabels17 = new MozartUC.apiLabel();
			this.lblLabels0 = new MozartUC.apiLabel();
			this.lblLabels1 = new MozartUC.apiLabel();
			this.Frame7 = new MozartUC.apiGroupBox();
			this.cboLangue = new System.Windows.Forms.ComboBox();
			this.txtNom = new MozartUC.apiTextBox();
			this.txtCont = new MozartUC.apiTextBox();
			this.txtTypCour = new MozartUC.apiTextBox();
			this.txtTypDest = new MozartUC.apiTextBox();
			this.txtNum = new MozartUC.apiTextBox();
			this.Label52 = new MozartUC.apiLabel();
			this.lblLabels5 = new MozartUC.apiLabel();
			this.lblLabels4 = new MozartUC.apiLabel();
			this.lblLabels16 = new MozartUC.apiLabel();
			this.lblLabels8 = new MozartUC.apiLabel();
			this.lblLabels2 = new MozartUC.apiLabel();
			this.Frame8 = new MozartUC.apiGroupBox();
			this.Label1 = new MozartUC.apiLabel();
			this.Frame7.SuspendLayout();
			this.Frame8.SuspendLayout();
			this.SuspendLayout();
			// 
			// cmdVisu
			// 
			resources.ApplyResources(this.cmdVisu, "cmdVisu");
			this.cmdVisu.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdVisu.HelpContextID = 0;
			this.cmdVisu.Name = "cmdVisu";
			this.cmdVisu.Tag = "4";
			this.cmdVisu.UseVisualStyleBackColor = true;
			this.cmdVisu.Click += new System.EventHandler(this.cmdVisu_Click);
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
			// cmdImprimer
			// 
			resources.ApplyResources(this.cmdImprimer, "cmdImprimer");
			this.cmdImprimer.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdImprimer.HelpContextID = 0;
			this.cmdImprimer.Name = "cmdImprimer";
			this.cmdImprimer.Tag = "17";
			this.cmdImprimer.UseVisualStyleBackColor = true;
			this.cmdImprimer.Click += new System.EventHandler(this.cmdImprimer_Click);
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
			// cmdSpell
			// 
			this.cmdSpell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
			this.cmdSpell.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdSpell.HelpContextID = 644;
			resources.ApplyResources(this.cmdSpell, "cmdSpell");
			this.cmdSpell.Name = "cmdSpell";
			this.cmdSpell.UseVisualStyleBackColor = false;
			this.cmdSpell.Click += new System.EventHandler(this.cmdSpell_Click);
			// 
			// cmdTraduction
			// 
			this.cmdTraduction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.cmdTraduction.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdTraduction.HelpContextID = 643;
			resources.ApplyResources(this.cmdTraduction, "cmdTraduction");
			this.cmdTraduction.Name = "cmdTraduction";
			this.cmdTraduction.UseVisualStyleBackColor = false;
			this.cmdTraduction.Click += new System.EventHandler(this.cmdTraduction_Click);
			// 
			// txtNumAR
			// 
			resources.ApplyResources(this.txtNumAR, "txtNumAR");
			this.txtNumAR.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtNumAR.HelpContextID = 0;
			this.txtNumAR.Name = "txtNumAR";
			// 
			// txtPied
			// 
			resources.ApplyResources(this.txtPied, "txtPied");
			this.txtPied.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtPied.HelpContextID = 0;
			this.txtPied.Name = "txtPied";
			// 
			// txtRef
			// 
			resources.ApplyResources(this.txtRef, "txtRef");
			this.txtRef.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtRef.HelpContextID = 0;
			this.txtRef.Name = "txtRef";
			// 
			// txtObjet
			// 
			resources.ApplyResources(this.txtObjet, "txtObjet");
			this.txtObjet.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtObjet.HelpContextID = 0;
			this.txtObjet.Name = "txtObjet";
			// 
			// txtCompte
			// 
			resources.ApplyResources(this.txtCompte, "txtCompte");
			this.txtCompte.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtCompte.HelpContextID = 0;
			this.txtCompte.Name = "txtCompte";
			this.txtCompte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCompte_KeyPress);
			// 
			// txtLettre
			// 
			resources.ApplyResources(this.txtLettre, "txtLettre");
			this.txtLettre.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtLettre.HelpContextID = 0;
			this.txtLettre.Name = "txtLettre";
			// 
			// lblNumAR
			// 
			resources.ApplyResources(this.lblNumAR, "lblNumAR");
			this.lblNumAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.lblNumAR.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblNumAR.HelpContextID = 0;
			this.lblNumAR.Name = "lblNumAR";
			// 
			// lblLabels3
			// 
			resources.ApplyResources(this.lblLabels3, "lblLabels3");
			this.lblLabels3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.lblLabels3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLabels3.HelpContextID = 0;
			this.lblLabels3.Name = "lblLabels3";
			// 
			// lblLabels15
			// 
			resources.ApplyResources(this.lblLabels15, "lblLabels15");
			this.lblLabels15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.lblLabels15.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLabels15.HelpContextID = 0;
			this.lblLabels15.Name = "lblLabels15";
			// 
			// lblLabels17
			// 
			resources.ApplyResources(this.lblLabels17, "lblLabels17");
			this.lblLabels17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.lblLabels17.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLabels17.HelpContextID = 0;
			this.lblLabels17.Name = "lblLabels17";
			// 
			// lblLabels0
			// 
			resources.ApplyResources(this.lblLabels0, "lblLabels0");
			this.lblLabels0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.lblLabels0.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLabels0.HelpContextID = 0;
			this.lblLabels0.Name = "lblLabels0";
			// 
			// lblLabels1
			// 
			resources.ApplyResources(this.lblLabels1, "lblLabels1");
			this.lblLabels1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.lblLabels1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLabels1.HelpContextID = 0;
			this.lblLabels1.Name = "lblLabels1";
			// 
			// Frame7
			// 
			resources.ApplyResources(this.Frame7, "Frame7");
			this.Frame7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.Frame7.Controls.Add(this.cmdSpell);
			this.Frame7.Controls.Add(this.cmdTraduction);
			this.Frame7.Controls.Add(this.txtNumAR);
			this.Frame7.Controls.Add(this.txtPied);
			this.Frame7.Controls.Add(this.txtRef);
			this.Frame7.Controls.Add(this.txtObjet);
			this.Frame7.Controls.Add(this.txtCompte);
			this.Frame7.Controls.Add(this.txtLettre);
			this.Frame7.Controls.Add(this.lblNumAR);
			this.Frame7.Controls.Add(this.lblLabels3);
			this.Frame7.Controls.Add(this.lblLabels15);
			this.Frame7.Controls.Add(this.lblLabels17);
			this.Frame7.Controls.Add(this.lblLabels0);
			this.Frame7.Controls.Add(this.lblLabels1);
			this.Frame7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.Frame7.FrameColor = System.Drawing.Color.Empty;
			this.Frame7.HelpContextID = 0;
			this.Frame7.Name = "Frame7";
			this.Frame7.TabStop = false;
			// 
			// cboLangue
			// 
			this.cboLangue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			resources.ApplyResources(this.cboLangue, "cboLangue");
			this.cboLangue.Name = "cboLangue";
			// 
			// txtNom
			// 
			resources.ApplyResources(this.txtNom, "txtNom");
			this.txtNom.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtNom.HelpContextID = 0;
			this.txtNom.Name = "txtNom";
			// 
			// txtCont
			// 
			resources.ApplyResources(this.txtCont, "txtCont");
			this.txtCont.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtCont.HelpContextID = 0;
			this.txtCont.Name = "txtCont";
			// 
			// txtTypCour
			// 
			resources.ApplyResources(this.txtTypCour, "txtTypCour");
			this.txtTypCour.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtTypCour.HelpContextID = 0;
			this.txtTypCour.Name = "txtTypCour";
			// 
			// txtTypDest
			// 
			resources.ApplyResources(this.txtTypDest, "txtTypDest");
			this.txtTypDest.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtTypDest.HelpContextID = 0;
			this.txtTypDest.Name = "txtTypDest";
			// 
			// txtNum
			// 
			resources.ApplyResources(this.txtNum, "txtNum");
			this.txtNum.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtNum.HelpContextID = 0;
			this.txtNum.Name = "txtNum";
			// 
			// Label52
			// 
			resources.ApplyResources(this.Label52, "Label52");
			this.Label52.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.Label52.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.Label52.HelpContextID = 0;
			this.Label52.Name = "Label52";
			// 
			// lblLabels5
			// 
			resources.ApplyResources(this.lblLabels5, "lblLabels5");
			this.lblLabels5.BackColor = System.Drawing.Color.Transparent;
			this.lblLabels5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLabels5.HelpContextID = 0;
			this.lblLabels5.Name = "lblLabels5";
			// 
			// lblLabels4
			// 
			resources.ApplyResources(this.lblLabels4, "lblLabels4");
			this.lblLabels4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.lblLabels4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLabels4.HelpContextID = 0;
			this.lblLabels4.Name = "lblLabels4";
			// 
			// lblLabels16
			// 
			resources.ApplyResources(this.lblLabels16, "lblLabels16");
			this.lblLabels16.BackColor = System.Drawing.Color.Transparent;
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
			// lblLabels2
			// 
			resources.ApplyResources(this.lblLabels2, "lblLabels2");
			this.lblLabels2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.lblLabels2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLabels2.HelpContextID = 0;
			this.lblLabels2.Name = "lblLabels2";
			// 
			// Frame8
			// 
			this.Frame8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.Frame8.Controls.Add(this.cboLangue);
			this.Frame8.Controls.Add(this.txtNom);
			this.Frame8.Controls.Add(this.txtCont);
			this.Frame8.Controls.Add(this.txtTypCour);
			this.Frame8.Controls.Add(this.txtTypDest);
			this.Frame8.Controls.Add(this.txtNum);
			this.Frame8.Controls.Add(this.Label52);
			this.Frame8.Controls.Add(this.lblLabels5);
			this.Frame8.Controls.Add(this.lblLabels4);
			this.Frame8.Controls.Add(this.lblLabels16);
			this.Frame8.Controls.Add(this.lblLabels8);
			this.Frame8.Controls.Add(this.lblLabels2);
			resources.ApplyResources(this.Frame8, "Frame8");
			this.Frame8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.Frame8.FrameColor = System.Drawing.Color.Empty;
			this.Frame8.HelpContextID = 0;
			this.Frame8.Name = "Frame8";
			this.Frame8.TabStop = false;
			// 
			// Label1
			// 
			resources.ApplyResources(this.Label1, "Label1");
			this.Label1.BackColor = System.Drawing.Color.Wheat;
			this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label1.HelpContextID = 0;
			this.Label1.Name = "Label1";
			// 
			// frmModifLettre
			// 
			this.BackColor = System.Drawing.Color.Wheat;
			this.CancelButton = this.cmdFermer;
			resources.ApplyResources(this, "$this");
			this.Controls.Add(this.cmdVisu);
			this.Controls.Add(this.cmdValider);
			this.Controls.Add(this.cmdImprimer);
			this.Controls.Add(this.cmdFermer);
			this.Controls.Add(this.Frame7);
			this.Controls.Add(this.Frame8);
			this.Controls.Add(this.Label1);
			this.KeyPreview = true;
			this.Name = "frmModifLettre";
			this.ShowInTaskbar = false;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmModifLettre_Load);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmModifLettre_KeyPress);
			this.Frame7.ResumeLayout(false);
			this.Frame7.PerformLayout();
			this.Frame8.ResumeLayout(false);
			this.Frame8.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion
    private MozartUC.apiButton cmdVisu;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiButton cmdImprimer;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiButton cmdSpell;
    private MozartUC.apiButton cmdTraduction;
    private MozartUC.apiTextBox txtNumAR;
    private MozartUC.apiTextBox txtPied;
    private MozartUC.apiTextBox txtRef;
    private MozartUC.apiTextBox txtObjet;
    private MozartUC.apiTextBox txtCompte;
    private MozartUC.apiTextBox txtLettre;
    private MozartUC.apiLabel lblNumAR;
    private MozartUC.apiLabel lblLabels3;
    private MozartUC.apiLabel lblLabels15;
    private MozartUC.apiLabel lblLabels17;
    private MozartUC.apiLabel lblLabels0;
    private MozartUC.apiLabel lblLabels1;
    private MozartUC.apiGroupBox Frame7;
    private System.Windows.Forms.ComboBox cboLangue;
    private MozartUC.apiTextBox txtNom;
    private MozartUC.apiTextBox txtCont;
    private MozartUC.apiTextBox txtTypCour;
    private MozartUC.apiTextBox txtTypDest;
    private MozartUC.apiTextBox txtNum;
    private MozartUC.apiLabel Label52;
    private MozartUC.apiLabel lblLabels5;
    private MozartUC.apiLabel lblLabels4;
    private MozartUC.apiLabel lblLabels16;
    private MozartUC.apiLabel lblLabels8;
    private MozartUC.apiLabel lblLabels2;
    private MozartUC.apiGroupBox Frame8;
    private MozartUC.apiLabel Label1;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
