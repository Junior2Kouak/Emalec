namespace MozartCS
{
  partial class frmAvoir
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAvoir));
			this.optFact0 = new System.Windows.Forms.RadioButton();
			this.optFact1 = new System.Windows.Forms.RadioButton();
			this.grdDataGrid = new MozartUC.apiTGrid();
			this.lblLabels4 = new MozartUC.apiLabel();
			this.Frame3 = new MozartUC.apiGroupBox();
			this.cmdValider = new MozartUC.apiButton();
			this.cmdFermer = new MozartUC.apiButton();
			this.txtHT = new System.Windows.Forms.TextBox();
			this.txtTVA = new System.Windows.Forms.TextBox();
			this.txtTTC = new System.Windows.Forms.TextBox();
			this.Label2 = new MozartUC.apiLabel();
			this.Label1 = new MozartUC.apiLabel();
			this.lbleOeuvre = new MozartUC.apiLabel();
			this.lblOeuvre = new MozartUC.apiLabel();
			this.lblLabels21 = new MozartUC.apiLabel();
			this.lblLabels20 = new MozartUC.apiLabel();
			this.Frame2 = new MozartUC.apiGroupBox();
			this.txtObjet = new MozartUC.apiTextBox();
			this.txtPrest = new MozartUC.apiTextBox();
			this.lblLabels15 = new MozartUC.apiLabel();
			this.lblLabels6 = new MozartUC.apiLabel();
			this.Frame7 = new MozartUC.apiGroupBox();
			this.txtFields7 = new MozartUC.apiTextBox();
			this.txtFields6 = new MozartUC.apiTextBox();
			this.txtFields5 = new MozartUC.apiTextBox();
			this.txtFields4 = new MozartUC.apiTextBox();
			this.txtFields1 = new MozartUC.apiTextBox();
			this.txtFields3 = new MozartUC.apiTextBox();
			this.txtFields0 = new MozartUC.apiTextBox();
			this.txtFields2 = new MozartUC.apiTextBox();
			this.lblLabels3 = new MozartUC.apiLabel();
			this.lblLabels2 = new MozartUC.apiLabel();
			this.lblLabels0 = new MozartUC.apiLabel();
			this.lblLabels5 = new MozartUC.apiLabel();
			this.lblLabels9 = new MozartUC.apiLabel();
			this.lblLabels8 = new MozartUC.apiLabel();
			this.lblLabels16 = new MozartUC.apiLabel();
			this.lblLabels1 = new MozartUC.apiLabel();
			this.Frame8 = new MozartUC.apiGroupBox();
			this.cmdVisualiser = new MozartUC.apiButton();
			this.Label3 = new MozartUC.apiLabel();
			this.Frame3.SuspendLayout();
			this.Frame2.SuspendLayout();
			this.Frame7.SuspendLayout();
			this.Frame8.SuspendLayout();
			this.SuspendLayout();
			// 
			// optFact0
			// 
			this.optFact0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.optFact0.Checked = true;
			resources.ApplyResources(this.optFact0, "optFact0");
			this.optFact0.ForeColor = System.Drawing.SystemColors.ControlText;
			this.optFact0.Name = "optFact0";
			this.optFact0.TabStop = true;
			this.optFact0.UseVisualStyleBackColor = false;
			this.optFact0.Click += new System.EventHandler(this.optFact0_Click);
			// 
			// optFact1
			// 
			this.optFact1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			resources.ApplyResources(this.optFact1, "optFact1");
			this.optFact1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.optFact1.Name = "optFact1";
			this.optFact1.UseVisualStyleBackColor = false;
			this.optFact1.Click += new System.EventHandler(this.optFact1_Click);
			// 
			// grdDataGrid
			// 
			resources.ApplyResources(this.grdDataGrid, "grdDataGrid");
			this.grdDataGrid.FilterBar = true;
			this.grdDataGrid.FooterBar = true;
			this.grdDataGrid.Name = "grdDataGrid";
			this.grdDataGrid.CellValueChanged += new MozartUC.apiTGrid.CellValueChangedEventHandler(this.grdDataGrid_CellValueChanged);
			this.grdDataGrid.EditorKeyPressE += new MozartUC.apiTGrid.EditorKeyPressEEventHandler(this.grdDataGrid_EditorKeyPressE);
			// 
			// lblLabels4
			// 
			this.lblLabels4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			resources.ApplyResources(this.lblLabels4, "lblLabels4");
			this.lblLabels4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLabels4.HelpContextID = 0;
			this.lblLabels4.Name = "lblLabels4";
			// 
			// Frame3
			// 
			resources.ApplyResources(this.Frame3, "Frame3");
			this.Frame3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.Frame3.Controls.Add(this.optFact0);
			this.Frame3.Controls.Add(this.optFact1);
			this.Frame3.Controls.Add(this.grdDataGrid);
			this.Frame3.Controls.Add(this.lblLabels4);
			this.Frame3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.Frame3.FrameColor = System.Drawing.Color.Empty;
			this.Frame3.HelpContextID = 0;
			this.Frame3.Name = "Frame3";
			this.Frame3.TabStop = false;
			// 
			// cmdValider
			// 
			this.cmdValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			resources.ApplyResources(this.cmdValider, "cmdValider");
			this.cmdValider.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdValider.HelpContextID = 0;
			this.cmdValider.Name = "cmdValider";
			this.cmdValider.Tag = "29";
			this.cmdValider.UseVisualStyleBackColor = false;
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
			// txtHT
			// 
			resources.ApplyResources(this.txtHT, "txtHT");
			this.txtHT.Name = "txtHT";
			// 
			// txtTVA
			// 
			resources.ApplyResources(this.txtTVA, "txtTVA");
			this.txtTVA.Name = "txtTVA";
			// 
			// txtTTC
			// 
			resources.ApplyResources(this.txtTTC, "txtTTC");
			this.txtTTC.Name = "txtTTC";
			// 
			// Label2
			// 
			resources.ApplyResources(this.Label2, "Label2");
			this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label2.HelpContextID = 0;
			this.Label2.Name = "Label2";
			// 
			// Label1
			// 
			resources.ApplyResources(this.Label1, "Label1");
			this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label1.HelpContextID = 0;
			this.Label1.Name = "Label1";
			// 
			// lbleOeuvre
			// 
			resources.ApplyResources(this.lbleOeuvre, "lbleOeuvre");
			this.lbleOeuvre.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lbleOeuvre.HelpContextID = 0;
			this.lbleOeuvre.Name = "lbleOeuvre";
			// 
			// lblOeuvre
			// 
			resources.ApplyResources(this.lblOeuvre, "lblOeuvre");
			this.lblOeuvre.BackColor = System.Drawing.Color.Wheat;
			this.lblOeuvre.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblOeuvre.HelpContextID = 0;
			this.lblOeuvre.Name = "lblOeuvre";
			// 
			// lblLabels21
			// 
			resources.ApplyResources(this.lblLabels21, "lblLabels21");
			this.lblLabels21.BackColor = System.Drawing.Color.Wheat;
			this.lblLabels21.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLabels21.HelpContextID = 0;
			this.lblLabels21.Name = "lblLabels21";
			// 
			// lblLabels20
			// 
			resources.ApplyResources(this.lblLabels20, "lblLabels20");
			this.lblLabels20.BackColor = System.Drawing.Color.Wheat;
			this.lblLabels20.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLabels20.HelpContextID = 0;
			this.lblLabels20.Name = "lblLabels20";
			// 
			// Frame2
			// 
			resources.ApplyResources(this.Frame2, "Frame2");
			this.Frame2.BackColor = System.Drawing.Color.Wheat;
			this.Frame2.Controls.Add(this.txtHT);
			this.Frame2.Controls.Add(this.txtTVA);
			this.Frame2.Controls.Add(this.txtTTC);
			this.Frame2.Controls.Add(this.Label2);
			this.Frame2.Controls.Add(this.Label1);
			this.Frame2.Controls.Add(this.lbleOeuvre);
			this.Frame2.Controls.Add(this.lblOeuvre);
			this.Frame2.Controls.Add(this.lblLabels21);
			this.Frame2.Controls.Add(this.lblLabels20);
			this.Frame2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.Frame2.FrameColor = System.Drawing.Color.Empty;
			this.Frame2.HelpContextID = 0;
			this.Frame2.Name = "Frame2";
			this.Frame2.TabStop = false;
			// 
			// txtObjet
			// 
			resources.ApplyResources(this.txtObjet, "txtObjet");
			this.txtObjet.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtObjet.HelpContextID = 0;
			this.txtObjet.Name = "txtObjet";
			// 
			// txtPrest
			// 
			resources.ApplyResources(this.txtPrest, "txtPrest");
			this.txtPrest.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtPrest.HelpContextID = 0;
			this.txtPrest.Name = "txtPrest";
			// 
			// lblLabels15
			// 
			this.lblLabels15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			resources.ApplyResources(this.lblLabels15, "lblLabels15");
			this.lblLabels15.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLabels15.HelpContextID = 0;
			this.lblLabels15.Name = "lblLabels15";
			// 
			// lblLabels6
			// 
			this.lblLabels6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			resources.ApplyResources(this.lblLabels6, "lblLabels6");
			this.lblLabels6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLabels6.HelpContextID = 0;
			this.lblLabels6.Name = "lblLabels6";
			// 
			// Frame7
			// 
			resources.ApplyResources(this.Frame7, "Frame7");
			this.Frame7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.Frame7.Controls.Add(this.Frame2);
			this.Frame7.Controls.Add(this.txtObjet);
			this.Frame7.Controls.Add(this.txtPrest);
			this.Frame7.Controls.Add(this.lblLabels15);
			this.Frame7.Controls.Add(this.lblLabels6);
			this.Frame7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.Frame7.FrameColor = System.Drawing.Color.Empty;
			this.Frame7.HelpContextID = 0;
			this.Frame7.Name = "Frame7";
			this.Frame7.TabStop = false;
			// 
			// txtFields7
			// 
			resources.ApplyResources(this.txtFields7, "txtFields7");
			this.txtFields7.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtFields7.HelpContextID = 0;
			this.txtFields7.Name = "txtFields7";
			// 
			// txtFields6
			// 
			resources.ApplyResources(this.txtFields6, "txtFields6");
			this.txtFields6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtFields6.HelpContextID = 0;
			this.txtFields6.Name = "txtFields6";
			// 
			// txtFields5
			// 
			resources.ApplyResources(this.txtFields5, "txtFields5");
			this.txtFields5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtFields5.HelpContextID = 0;
			this.txtFields5.Name = "txtFields5";
			// 
			// txtFields4
			// 
			resources.ApplyResources(this.txtFields4, "txtFields4");
			this.txtFields4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtFields4.HelpContextID = 0;
			this.txtFields4.Name = "txtFields4";
			// 
			// txtFields1
			// 
			resources.ApplyResources(this.txtFields1, "txtFields1");
			this.txtFields1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtFields1.HelpContextID = 0;
			this.txtFields1.Name = "txtFields1";
			// 
			// txtFields3
			// 
			resources.ApplyResources(this.txtFields3, "txtFields3");
			this.txtFields3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtFields3.HelpContextID = 0;
			this.txtFields3.Name = "txtFields3";
			// 
			// txtFields0
			// 
			resources.ApplyResources(this.txtFields0, "txtFields0");
			this.txtFields0.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtFields0.HelpContextID = 0;
			this.txtFields0.Name = "txtFields0";
			// 
			// txtFields2
			// 
			resources.ApplyResources(this.txtFields2, "txtFields2");
			this.txtFields2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtFields2.HelpContextID = 0;
			this.txtFields2.Name = "txtFields2";
			// 
			// lblLabels3
			// 
			resources.ApplyResources(this.lblLabels3, "lblLabels3");
			this.lblLabels3.BackColor = System.Drawing.Color.Transparent;
			this.lblLabels3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLabels3.HelpContextID = 0;
			this.lblLabels3.Name = "lblLabels3";
			// 
			// lblLabels2
			// 
			resources.ApplyResources(this.lblLabels2, "lblLabels2");
			this.lblLabels2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.lblLabels2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLabels2.HelpContextID = 0;
			this.lblLabels2.Name = "lblLabels2";
			// 
			// lblLabels0
			// 
			resources.ApplyResources(this.lblLabels0, "lblLabels0");
			this.lblLabels0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.lblLabels0.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLabels0.HelpContextID = 0;
			this.lblLabels0.Name = "lblLabels0";
			// 
			// lblLabels5
			// 
			resources.ApplyResources(this.lblLabels5, "lblLabels5");
			this.lblLabels5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.lblLabels5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLabels5.HelpContextID = 0;
			this.lblLabels5.Name = "lblLabels5";
			// 
			// lblLabels9
			// 
			resources.ApplyResources(this.lblLabels9, "lblLabels9");
			this.lblLabels9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.lblLabels9.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLabels9.HelpContextID = 0;
			this.lblLabels9.Name = "lblLabels9";
			// 
			// lblLabels8
			// 
			resources.ApplyResources(this.lblLabels8, "lblLabels8");
			this.lblLabels8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.lblLabels8.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLabels8.HelpContextID = 0;
			this.lblLabels8.Name = "lblLabels8";
			// 
			// lblLabels16
			// 
			resources.ApplyResources(this.lblLabels16, "lblLabels16");
			this.lblLabels16.BackColor = System.Drawing.Color.Transparent;
			this.lblLabels16.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLabels16.HelpContextID = 0;
			this.lblLabels16.Name = "lblLabels16";
			// 
			// lblLabels1
			// 
			resources.ApplyResources(this.lblLabels1, "lblLabels1");
			this.lblLabels1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.lblLabels1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLabels1.HelpContextID = 0;
			this.lblLabels1.Name = "lblLabels1";
			// 
			// Frame8
			// 
			resources.ApplyResources(this.Frame8, "Frame8");
			this.Frame8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.Frame8.Controls.Add(this.txtFields7);
			this.Frame8.Controls.Add(this.txtFields6);
			this.Frame8.Controls.Add(this.txtFields5);
			this.Frame8.Controls.Add(this.txtFields4);
			this.Frame8.Controls.Add(this.txtFields1);
			this.Frame8.Controls.Add(this.txtFields3);
			this.Frame8.Controls.Add(this.txtFields0);
			this.Frame8.Controls.Add(this.txtFields2);
			this.Frame8.Controls.Add(this.lblLabels3);
			this.Frame8.Controls.Add(this.lblLabels2);
			this.Frame8.Controls.Add(this.lblLabels0);
			this.Frame8.Controls.Add(this.lblLabels5);
			this.Frame8.Controls.Add(this.lblLabels9);
			this.Frame8.Controls.Add(this.lblLabels8);
			this.Frame8.Controls.Add(this.lblLabels16);
			this.Frame8.Controls.Add(this.lblLabels1);
			this.Frame8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.Frame8.FrameColor = System.Drawing.Color.Empty;
			this.Frame8.HelpContextID = 0;
			this.Frame8.Name = "Frame8";
			this.Frame8.TabStop = false;
			// 
			// cmdVisualiser
			// 
			resources.ApplyResources(this.cmdVisualiser, "cmdVisualiser");
			this.cmdVisualiser.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdVisualiser.HelpContextID = 0;
			this.cmdVisualiser.Name = "cmdVisualiser";
			this.cmdVisualiser.Tag = "4";
			this.cmdVisualiser.UseVisualStyleBackColor = true;
			this.cmdVisualiser.Click += new System.EventHandler(this.cmdVisualiser_Click);
			// 
			// Label3
			// 
			resources.ApplyResources(this.Label3, "Label3");
			this.Label3.BackColor = System.Drawing.Color.Wheat;
			this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label3.HelpContextID = 0;
			this.Label3.Name = "Label3";
			// 
			// frmAvoir
			// 
			this.BackColor = System.Drawing.Color.Wheat;
			this.CancelButton = this.cmdFermer;
			resources.ApplyResources(this, "$this");
			this.Controls.Add(this.Frame3);
			this.Controls.Add(this.cmdValider);
			this.Controls.Add(this.cmdFermer);
			this.Controls.Add(this.Frame7);
			this.Controls.Add(this.Frame8);
			this.Controls.Add(this.cmdVisualiser);
			this.Controls.Add(this.Label3);
			this.Name = "frmAvoir";
			this.ShowInTaskbar = false;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAvoir_FormClosed);
			this.Load += new System.EventHandler(this.frmAvoir_Load);
			this.Frame3.ResumeLayout(false);
			this.Frame2.ResumeLayout(false);
			this.Frame2.PerformLayout();
			this.Frame7.ResumeLayout(false);
			this.Frame7.PerformLayout();
			this.Frame8.ResumeLayout(false);
			this.Frame8.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.RadioButton optFact0;
    private System.Windows.Forms.RadioButton optFact1;
    private MozartUC.apiTGrid grdDataGrid;
    private MozartUC.apiLabel lblLabels4;
    private MozartUC.apiGroupBox Frame3;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiButton cmdFermer;
    private System.Windows.Forms.TextBox txtHT;
    private System.Windows.Forms.TextBox txtTVA;
    private System.Windows.Forms.TextBox txtTTC;
    private MozartUC.apiLabel Label2;
    private MozartUC.apiLabel Label1;
    private MozartUC.apiLabel lbleOeuvre;
    private MozartUC.apiLabel lblOeuvre;
    private MozartUC.apiLabel lblLabels21;
    private MozartUC.apiLabel lblLabels20;
    private MozartUC.apiGroupBox Frame2;
    private MozartUC.apiTextBox txtObjet;
    private MozartUC.apiTextBox txtPrest;
    private MozartUC.apiLabel lblLabels15;
    private MozartUC.apiLabel lblLabels6;
    private MozartUC.apiGroupBox Frame7;
    private MozartUC.apiTextBox txtFields7;
    private MozartUC.apiTextBox txtFields6;
    private MozartUC.apiTextBox txtFields5;
    private MozartUC.apiTextBox txtFields4;
    private MozartUC.apiTextBox txtFields1;
    private MozartUC.apiTextBox txtFields3;
    private MozartUC.apiTextBox txtFields0;
    private MozartUC.apiTextBox txtFields2;
    private MozartUC.apiLabel lblLabels3;
    private MozartUC.apiLabel lblLabels2;
    private MozartUC.apiLabel lblLabels0;
    private MozartUC.apiLabel lblLabels5;
    private MozartUC.apiLabel lblLabels9;
    private MozartUC.apiLabel lblLabels8;
    private MozartUC.apiLabel lblLabels16;
    private MozartUC.apiLabel lblLabels1;
    private MozartUC.apiGroupBox Frame8;
    private MozartUC.apiButton cmdVisualiser;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    private MozartUC.apiLabel Label3;

  }
}
