namespace MozartCS
{
  partial class frmListeArtNewTech
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListeArtNewTech));
			this.Command1 = new MozartUC.apiButton();
			this.cmdVisu = new MozartUC.apiButton();
			this.txtHT = new MozartUC.apiTextBox();
			this.cmdSupp = new MozartUC.apiButton();
			this.apiGridb = new MozartUC.apiTGrid();
			this.lblLabels6 = new MozartUC.apiLabel();
			this.Frame2 = new MozartUC.apiGroupBox();
			this.apiChoixFourn = new MozartUC.apiCombo();
			this.cmdFind = new MozartUC.apiButton();
			this.txtCritMat = new MozartUC.apiTextBox();
			this.txtCritMarque = new MozartUC.apiTextBox();
			this.txtCritType = new MozartUC.apiTextBox();
			this.txtCritRef = new MozartUC.apiTextBox();
			this.lblF2 = new MozartUC.apiLabel();
			this.lblmat = new MozartUC.apiLabel();
			this.lblmarque = new MozartUC.apiLabel();
			this.lbltype = new MozartUC.apiLabel();
			this.lblref = new MozartUC.apiLabel();
			this.lblfournisseur = new MozartUC.apiLabel();
			this.fraCriteres = new MozartUC.apiGroupBox();
			this.cmdAjouter = new MozartUC.apiButton();
			this.apiGridH = new MozartUC.apiTGrid();
			this.Frame1 = new MozartUC.apiGroupBox();
			this.cmdQuitter = new MozartUC.apiButton();
			this.Label1 = new MozartUC.apiLabel();
			this.Frame2.SuspendLayout();
			this.fraCriteres.SuspendLayout();
			this.Frame1.SuspendLayout();
			this.SuspendLayout();
			// 
			// Command1
			// 
			resources.ApplyResources(this.Command1, "Command1");
			this.Command1.HelpContextID = 0;
			this.Command1.Name = "Command1";
			this.Command1.Tag = "49";
			this.Command1.UseVisualStyleBackColor = true;
			this.Command1.Click += new System.EventHandler(this.Command1_Click);
			// 
			// cmdVisu
			// 
			resources.ApplyResources(this.cmdVisu, "cmdVisu");
			this.cmdVisu.HelpContextID = 0;
			this.cmdVisu.Name = "cmdVisu";
			this.cmdVisu.Tag = "4";
			this.cmdVisu.UseVisualStyleBackColor = true;
			this.cmdVisu.Click += new System.EventHandler(this.cmdVisu_Click);
			// 
			// txtHT
			// 
			resources.ApplyResources(this.txtHT, "txtHT");
			this.txtHT.HelpContextID = 0;
			this.txtHT.Name = "txtHT";
			// 
			// cmdSupp
			// 
			resources.ApplyResources(this.cmdSupp, "cmdSupp");
			this.cmdSupp.HelpContextID = 290;
			this.cmdSupp.Image = global::MozartCS.Properties.Resources.delete_32;
			this.cmdSupp.Name = "cmdSupp";
			this.cmdSupp.Tag = "27";
			this.cmdSupp.UseVisualStyleBackColor = true;
			this.cmdSupp.Click += new System.EventHandler(this.cmdSupp_Click);
			// 
			// apiGridb
			// 
			resources.ApplyResources(this.apiGridb, "apiGridb");
			this.apiGridb.FilterBar = true;
			this.apiGridb.FooterBar = true;
			this.apiGridb.Name = "apiGridb";
			this.apiGridb.CellValueChanged += new MozartUC.apiTGrid.CellValueChangedEventHandler(this.apiGridb_CellValueChanged);
			// 
			// lblLabels6
			// 
			resources.ApplyResources(this.lblLabels6, "lblLabels6");
			this.lblLabels6.BackColor = System.Drawing.Color.Transparent;
			this.lblLabels6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLabels6.HelpContextID = 0;
			this.lblLabels6.Name = "lblLabels6";
			// 
			// Frame2
			// 
			resources.ApplyResources(this.Frame2, "Frame2");
			this.Frame2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
			this.Frame2.Controls.Add(this.txtHT);
			this.Frame2.Controls.Add(this.cmdSupp);
			this.Frame2.Controls.Add(this.apiGridb);
			this.Frame2.Controls.Add(this.lblLabels6);
			this.Frame2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.Frame2.FrameColor = System.Drawing.Color.Empty;
			this.Frame2.HelpContextID = 0;
			this.Frame2.Name = "Frame2";
			this.Frame2.TabStop = false;
			// 
			// apiChoixFourn
			// 
			resources.ApplyResources(this.apiChoixFourn, "apiChoixFourn");
			this.apiChoixFourn.Name = "apiChoixFourn";
			this.apiChoixFourn.NewValues = false;
			// 
			// cmdFind
			// 
			this.cmdFind.HelpContextID = 0;
			this.cmdFind.Image = global::MozartCS.Properties.Resources.Find;
			resources.ApplyResources(this.cmdFind, "cmdFind");
			this.cmdFind.Name = "cmdFind";
			this.cmdFind.Tag = "8";
			this.cmdFind.UseVisualStyleBackColor = true;
			this.cmdFind.Click += new System.EventHandler(this.cmdFind_Click);
			// 
			// txtCritMat
			// 
			resources.ApplyResources(this.txtCritMat, "txtCritMat");
			this.txtCritMat.HelpContextID = 0;
			this.txtCritMat.Name = "txtCritMat";
			this.txtCritMat.Tag = "TFOU.VFOUMAT";
			// 
			// txtCritMarque
			// 
			resources.ApplyResources(this.txtCritMarque, "txtCritMarque");
			this.txtCritMarque.HelpContextID = 0;
			this.txtCritMarque.Name = "txtCritMarque";
			this.txtCritMarque.Tag = "TFOU.VFOUMAR";
			// 
			// txtCritType
			// 
			resources.ApplyResources(this.txtCritType, "txtCritType");
			this.txtCritType.HelpContextID = 0;
			this.txtCritType.Name = "txtCritType";
			this.txtCritType.Tag = "TFOU.VFOUTYP";
			// 
			// txtCritRef
			// 
			resources.ApplyResources(this.txtCritRef, "txtCritRef");
			this.txtCritRef.HelpContextID = 0;
			this.txtCritRef.Name = "txtCritRef";
			this.txtCritRef.Tag = "TFOU.VFOUREF";
			// 
			// lblF2
			// 
			this.lblF2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblF2.HelpContextID = 0;
			resources.ApplyResources(this.lblF2, "lblF2");
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
			this.fraCriteres.Controls.Add(this.cmdFind);
			this.fraCriteres.Controls.Add(this.txtCritMat);
			this.fraCriteres.Controls.Add(this.txtCritMarque);
			this.fraCriteres.Controls.Add(this.txtCritType);
			this.fraCriteres.Controls.Add(this.txtCritRef);
			this.fraCriteres.Controls.Add(this.lblF2);
			this.fraCriteres.Controls.Add(this.lblmat);
			this.fraCriteres.Controls.Add(this.lblmarque);
			this.fraCriteres.Controls.Add(this.lbltype);
			this.fraCriteres.Controls.Add(this.lblref);
			this.fraCriteres.Controls.Add(this.lblfournisseur);
			this.fraCriteres.FrameColor = System.Drawing.Color.Empty;
			this.fraCriteres.HelpContextID = 0;
			this.fraCriteres.Name = "fraCriteres";
			this.fraCriteres.TabStop = false;
			// 
			// cmdAjouter
			// 
			resources.ApplyResources(this.cmdAjouter, "cmdAjouter");
			this.cmdAjouter.HelpContextID = 290;
			this.cmdAjouter.Image = global::MozartCS.Properties.Resources.add_32;
			this.cmdAjouter.Name = "cmdAjouter";
			this.cmdAjouter.Tag = "2";
			this.cmdAjouter.UseVisualStyleBackColor = true;
			this.cmdAjouter.Click += new System.EventHandler(this.cmdAjouter_Click);
			// 
			// apiGridH
			// 
			resources.ApplyResources(this.apiGridH, "apiGridH");
			this.apiGridH.FilterBar = true;
			this.apiGridH.FooterBar = true;
			this.apiGridH.Name = "apiGridH";
			// 
			// Frame1
			// 
			resources.ApplyResources(this.Frame1, "Frame1");
			this.Frame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
			this.Frame1.Controls.Add(this.fraCriteres);
			this.Frame1.Controls.Add(this.cmdAjouter);
			this.Frame1.Controls.Add(this.apiGridH);
			this.Frame1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.Frame1.FrameColor = System.Drawing.Color.Empty;
			this.Frame1.HelpContextID = 0;
			this.Frame1.Name = "Frame1";
			this.Frame1.TabStop = false;
			// 
			// cmdQuitter
			// 
			resources.ApplyResources(this.cmdQuitter, "cmdQuitter");
			this.cmdQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cmdQuitter.HelpContextID = 0;
			this.cmdQuitter.Name = "cmdQuitter";
			this.cmdQuitter.Tag = "15";
			this.cmdQuitter.UseVisualStyleBackColor = true;
			this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
			// 
			// Label1
			// 
			resources.ApplyResources(this.Label1, "Label1");
			this.Label1.BackColor = System.Drawing.Color.Transparent;
			this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label1.HelpContextID = 0;
			this.Label1.Name = "Label1";
			// 
			// frmListeArtNewTech
			// 
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
			this.CancelButton = this.cmdQuitter;
			resources.ApplyResources(this, "$this");
			this.Controls.Add(this.apiChoixFourn);
			this.Controls.Add(this.Command1);
			this.Controls.Add(this.cmdVisu);
			this.Controls.Add(this.Frame2);
			this.Controls.Add(this.Frame1);
			this.Controls.Add(this.cmdQuitter);
			this.Controls.Add(this.Label1);
			this.KeyPreview = true;
			this.Name = "frmListeArtNewTech";
			this.ShowInTaskbar = false;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmListeArtNewTech_Load);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmListeArtNewTech_KeyUp);
			this.Frame2.ResumeLayout(false);
			this.Frame2.PerformLayout();
			this.fraCriteres.ResumeLayout(false);
			this.fraCriteres.PerformLayout();
			this.Frame1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton Command1;
    private MozartUC.apiButton cmdVisu;
    private MozartUC.apiTextBox txtHT;
    private MozartUC.apiButton cmdSupp;
    private MozartUC.apiTGrid apiGridb;
    private MozartUC.apiLabel lblLabels6;
    private MozartUC.apiGroupBox Frame2;
    private MozartUC.apiCombo apiChoixFourn;
    private MozartUC.apiButton cmdFind;
    private MozartUC.apiTextBox txtCritMat;
    private MozartUC.apiTextBox txtCritMarque;
    private MozartUC.apiTextBox txtCritType;
    private MozartUC.apiTextBox txtCritRef;
    private MozartUC.apiLabel lblF2;
    private MozartUC.apiLabel lblmat;
    private MozartUC.apiLabel lblmarque;
    private MozartUC.apiLabel lbltype;
    private MozartUC.apiLabel lblref;
    private MozartUC.apiLabel lblfournisseur;
    private MozartUC.apiGroupBox fraCriteres;
    private MozartUC.apiButton cmdAjouter;
    private MozartUC.apiTGrid apiGridH;
    private MozartUC.apiGroupBox Frame1;
    private MozartUC.apiButton cmdQuitter;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    private MozartUC.apiLabel Label1;

  }
}
