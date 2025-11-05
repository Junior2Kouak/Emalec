namespace MozartCS
{
  partial class frmRechercheFournituresCNF
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRechercheFournituresCNF));
			this.cmdSupp = new MozartUC.apiButton();
			this.txtHT = new MozartUC.apiTextBox();
			this.apiTGridB = new MozartUC.apiTGrid();
			this.Label2 = new MozartUC.apiLabel();
			this.lblLabels6 = new MozartUC.apiLabel();
			this.Frame2 = new MozartUC.apiGroupBox();
			this.cmdAjouter = new MozartUC.apiButton();
			this.apiTGridH = new MozartUC.apiTGrid();
			this.Frame1 = new MozartUC.apiGroupBox();
			this.cmdValider = new MozartUC.apiButton();
			this.cmdFermer = new MozartUC.apiButton();
			this.Label1 = new MozartUC.apiLabel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.lblserie = new MozartUC.apiLabel();
			this.lblmat = new MozartUC.apiLabel();
			this.txtCritRef = new MozartUC.apiTextBox();
			this.txtCritType = new MozartUC.apiTextBox();
			this.txtCritMarque = new MozartUC.apiTextBox();
			this.txtCritMat = new MozartUC.apiTextBox();
			this.lblmarque = new MozartUC.apiLabel();
			this.lblref = new MozartUC.apiLabel();
			this.lbltype = new MozartUC.apiLabel();
			this.cboCritSerie = new MozartUC.apiCombo();
			this.cmdFind = new MozartUC.apiButton();
			this.lblF2 = new MozartUC.apiLabel();
			this.Frame2.SuspendLayout();
			this.Frame1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// cmdSupp
			// 
			this.cmdSupp.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdSupp.HelpContextID = 0;
			this.cmdSupp.Image = global::MozartCS.Properties.Resources.delete_32;
			resources.ApplyResources(this.cmdSupp, "cmdSupp");
			this.cmdSupp.Name = "cmdSupp";
			this.cmdSupp.Tag = "27";
			this.cmdSupp.UseVisualStyleBackColor = true;
			this.cmdSupp.Click += new System.EventHandler(this.cmdSupp_Click);
			// 
			// txtHT
			// 
			resources.ApplyResources(this.txtHT, "txtHT");
			this.txtHT.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtHT.HelpContextID = 0;
			this.txtHT.Name = "txtHT";
			// 
			// apiTGridB
			// 
			resources.ApplyResources(this.apiTGridB, "apiTGridB");
			this.apiTGridB.FilterBar = true;
			this.apiTGridB.FooterBar = true;
			this.apiTGridB.ForeColor = System.Drawing.SystemColors.WindowText;
			this.apiTGridB.Name = "apiTGridB";
			this.apiTGridB.CellValueChanging += new MozartUC.apiTGrid.CellValueChangingEventHandler(this.apiTGridB_CellValueChanging);
			this.apiTGridB.CellValueChanged += new MozartUC.apiTGrid.CellValueChangedEventHandler(this.apiTGridB_CellValueChanged);
			// 
			// Label2
			// 
			resources.ApplyResources(this.Label2, "Label2");
			this.Label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label2.HelpContextID = 0;
			this.Label2.Name = "Label2";
			// 
			// lblLabels6
			// 
			resources.ApplyResources(this.lblLabels6, "lblLabels6");
			this.lblLabels6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.lblLabels6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLabels6.HelpContextID = 0;
			this.lblLabels6.Name = "lblLabels6";
			// 
			// Frame2
			// 
			resources.ApplyResources(this.Frame2, "Frame2");
			this.Frame2.BackColor = System.Drawing.Color.Wheat;
			this.Frame2.Controls.Add(this.cmdSupp);
			this.Frame2.Controls.Add(this.txtHT);
			this.Frame2.Controls.Add(this.apiTGridB);
			this.Frame2.Controls.Add(this.Label2);
			this.Frame2.Controls.Add(this.lblLabels6);
			this.Frame2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.Frame2.FrameColor = System.Drawing.Color.Empty;
			this.Frame2.HelpContextID = 0;
			this.Frame2.Name = "Frame2";
			this.Frame2.TabStop = false;
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
			// apiTGridH
			// 
			resources.ApplyResources(this.apiTGridH, "apiTGridH");
			this.apiTGridH.FilterBar = true;
			this.apiTGridH.FooterBar = true;
			this.apiTGridH.ForeColor = System.Drawing.SystemColors.WindowText;
			this.apiTGridH.Name = "apiTGridH";
			this.apiTGridH.DoubleClickE += new MozartUC.apiTGrid.DoubleClickEEventHandler(this.cmdAjouter_Click);
			// 
			// Frame1
			// 
			resources.ApplyResources(this.Frame1, "Frame1");
			this.Frame1.BackColor = System.Drawing.Color.Wheat;
			this.Frame1.Controls.Add(this.cmdAjouter);
			this.Frame1.Controls.Add(this.apiTGridH);
			this.Frame1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.Frame1.FrameColor = System.Drawing.Color.Empty;
			this.Frame1.HelpContextID = 0;
			this.Frame1.Name = "Frame1";
			this.Frame1.TabStop = false;
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
			this.tableLayoutPanel1.BackColor = System.Drawing.Color.Moccasin;
			this.tableLayoutPanel1.Controls.Add(this.lblserie, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.lblmat, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.txtCritRef, 9, 0);
			this.tableLayoutPanel1.Controls.Add(this.txtCritType, 7, 0);
			this.tableLayoutPanel1.Controls.Add(this.txtCritMarque, 5, 0);
			this.tableLayoutPanel1.Controls.Add(this.txtCritMat, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.lblmarque, 4, 0);
			this.tableLayoutPanel1.Controls.Add(this.lblref, 8, 0);
			this.tableLayoutPanel1.Controls.Add(this.lbltype, 6, 0);
			this.tableLayoutPanel1.Controls.Add(this.cmdFind, 11, 0);
			this.tableLayoutPanel1.Controls.Add(this.lblF2, 13, 0);
			this.tableLayoutPanel1.Controls.Add(this.cboCritSerie, 1, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			// 
			// lblserie
			// 
			resources.ApplyResources(this.lblserie, "lblserie");
			this.lblserie.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblserie.HelpContextID = 0;
			this.lblserie.Name = "lblserie";
			// 
			// lblmat
			// 
			resources.ApplyResources(this.lblmat, "lblmat");
			this.lblmat.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblmat.HelpContextID = 0;
			this.lblmat.Name = "lblmat";
			// 
			// txtCritRef
			// 
			resources.ApplyResources(this.txtCritRef, "txtCritRef");
			this.txtCritRef.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtCritRef.HelpContextID = 0;
			this.txtCritRef.Name = "txtCritRef";
			this.txtCritRef.Tag = "TFOU.VFOUREF";
			// 
			// txtCritType
			// 
			resources.ApplyResources(this.txtCritType, "txtCritType");
			this.txtCritType.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtCritType.HelpContextID = 0;
			this.txtCritType.Name = "txtCritType";
			this.txtCritType.Tag = "TFOU.VFOUTYP";
			// 
			// txtCritMarque
			// 
			resources.ApplyResources(this.txtCritMarque, "txtCritMarque");
			this.txtCritMarque.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtCritMarque.HelpContextID = 0;
			this.txtCritMarque.Name = "txtCritMarque";
			this.txtCritMarque.Tag = "TFOU.VFOUMAR";
			// 
			// txtCritMat
			// 
			resources.ApplyResources(this.txtCritMat, "txtCritMat");
			this.txtCritMat.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtCritMat.HelpContextID = 0;
			this.txtCritMat.Name = "txtCritMat";
			this.txtCritMat.Tag = "TFOU.VFOUMAT";
			// 
			// lblmarque
			// 
			resources.ApplyResources(this.lblmarque, "lblmarque");
			this.lblmarque.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblmarque.HelpContextID = 0;
			this.lblmarque.Name = "lblmarque";
			// 
			// lblref
			// 
			resources.ApplyResources(this.lblref, "lblref");
			this.lblref.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblref.HelpContextID = 0;
			this.lblref.Name = "lblref";
			// 
			// lbltype
			// 
			resources.ApplyResources(this.lbltype, "lbltype");
			this.lbltype.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lbltype.HelpContextID = 0;
			this.lbltype.Name = "lbltype";
			// 
			// cboCritSerie
			// 
			resources.ApplyResources(this.cboCritSerie, "cboCritSerie");
			this.cboCritSerie.Name = "cboCritSerie";
			this.cboCritSerie.NewValues = false;
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
			this.cmdFind.Click += new System.EventHandler(this.cmdFind_Click_1);
			// 
			// lblF2
			// 
			resources.ApplyResources(this.lblF2, "lblF2");
			this.lblF2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblF2.HelpContextID = 0;
			this.lblF2.Name = "lblF2";
			// 
			// frmRechercheFournituresCNF
			// 
			this.BackColor = System.Drawing.Color.Wheat;
			this.CancelButton = this.cmdFermer;
			resources.ApplyResources(this, "$this");
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.Frame2);
			this.Controls.Add(this.Frame1);
			this.Controls.Add(this.cmdValider);
			this.Controls.Add(this.cmdFermer);
			this.Controls.Add(this.Label1);
			this.Name = "frmRechercheFournituresCNF";
			this.ShowInTaskbar = false;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmRechercheFournituresNF_Load);
			this.Frame2.ResumeLayout(false);
			this.Frame2.PerformLayout();
			this.Frame1.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdSupp;
    private MozartUC.apiTextBox txtHT;
    private MozartUC.apiTGrid apiTGridB;
    private MozartUC.apiLabel Label2;
    private MozartUC.apiLabel lblLabels6;
    private MozartUC.apiGroupBox Frame2;
    private MozartUC.apiButton cmdAjouter;
    private MozartUC.apiTGrid apiTGridH;
    private MozartUC.apiGroupBox Frame1;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiButton cmdFermer;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    private MozartUC.apiLabel Label1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private MozartUC.apiLabel lblserie;
		private MozartUC.apiLabel lblmat;
		private MozartUC.apiTextBox txtCritRef;
		private MozartUC.apiTextBox txtCritType;
		private MozartUC.apiTextBox txtCritMarque;
		private MozartUC.apiTextBox txtCritMat;
		private MozartUC.apiLabel lblmarque;
		private MozartUC.apiLabel lblref;
		private MozartUC.apiLabel lbltype;
		private MozartUC.apiButton cmdFind;
		private MozartUC.apiLabel lblF2;
		private MozartUC.apiCombo cboCritSerie;
	}
}
