namespace MozartCS
{
  partial class frmGestClientPrixPrestation
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestClientPrixPrestation));
			this.cmdCoef = new MozartUC.apiButton();
			this.cmdAjout = new MozartUC.apiButton();
			this.cmdSup = new MozartUC.apiButton();
			this.apiTGridPrest = new MozartUC.apiTGrid();
			this.cmdFermer = new MozartUC.apiButton();
			this.apiTGridPrix = new MozartUC.apiTGrid();
			this.Label2 = new MozartUC.apiLabel();
			this.Label1 = new MozartUC.apiLabel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.GrpBoxSearch = new System.Windows.Forms.GroupBox();
			this.cmdFind = new MozartUC.apiButton();
			this.txtCritFouSer = new MozartUC.apiCombo();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.TxtCritCode = new System.Windows.Forms.TextBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.TxtCritCreateur = new System.Windows.Forms.TextBox();
			this.TxtCritPresta = new System.Windows.Forms.TextBox();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.GrpBoxSearch.SuspendLayout();
			this.SuspendLayout();
			// 
			// cmdCoef
			// 
			resources.ApplyResources(this.cmdCoef, "cmdCoef");
			this.cmdCoef.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdCoef.HelpContextID = 0;
			this.cmdCoef.Name = "cmdCoef";
			this.cmdCoef.UseVisualStyleBackColor = true;
			this.cmdCoef.Click += new System.EventHandler(this.cmdCoef_Click);
			// 
			// cmdAjout
			// 
			resources.ApplyResources(this.cmdAjout, "cmdAjout");
			this.cmdAjout.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdAjout.HelpContextID = 0;
			this.cmdAjout.Name = "cmdAjout";
			this.cmdAjout.Tag = "2";
			this.toolTip1.SetToolTip(this.cmdAjout, resources.GetString("cmdAjout.ToolTip"));
			this.cmdAjout.UseVisualStyleBackColor = true;
			this.cmdAjout.Click += new System.EventHandler(this.cmdAjout_Click);
			// 
			// cmdSup
			// 
			resources.ApplyResources(this.cmdSup, "cmdSup");
			this.cmdSup.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdSup.HelpContextID = 0;
			this.cmdSup.Name = "cmdSup";
			this.cmdSup.Tag = "27";
			this.toolTip1.SetToolTip(this.cmdSup, resources.GetString("cmdSup.ToolTip"));
			this.cmdSup.UseVisualStyleBackColor = true;
			this.cmdSup.Click += new System.EventHandler(this.cmdSup_Click);
			// 
			// apiTGridPrest
			// 
			resources.ApplyResources(this.apiTGridPrest, "apiTGridPrest");
			this.apiTGridPrest.FilterBar = true;
			this.apiTGridPrest.FooterBar = true;
			this.apiTGridPrest.Name = "apiTGridPrest";
			// 
			// cmdFermer
			// 
			resources.ApplyResources(this.cmdFermer, "cmdFermer");
			this.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cmdFermer.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdFermer.HelpContextID = 0;
			this.cmdFermer.Name = "cmdFermer";
			this.cmdFermer.Tag = "15";
			this.toolTip1.SetToolTip(this.cmdFermer, resources.GetString("cmdFermer.ToolTip"));
			this.cmdFermer.UseVisualStyleBackColor = true;
			this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
			// 
			// apiTGridPrix
			// 
			resources.ApplyResources(this.apiTGridPrix, "apiTGridPrix");
			this.apiTGridPrix.FilterBar = true;
			this.apiTGridPrix.FooterBar = true;
			this.apiTGridPrix.Name = "apiTGridPrix";
			this.apiTGridPrix.CellValueChanged += new MozartUC.apiTGrid.CellValueChangedEventHandler(this.apiTGridPrix_CellValueChanged);
			// 
			// Label2
			// 
			resources.ApplyResources(this.Label2, "Label2");
			this.Label2.BackColor = System.Drawing.Color.Wheat;
			this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label2.HelpContextID = 0;
			this.Label2.Name = "Label2";
			// 
			// Label1
			// 
			resources.ApplyResources(this.Label1, "Label1");
			this.Label1.BackColor = System.Drawing.Color.Wheat;
			this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label1.HelpContextID = 0;
			this.Label1.Name = "Label1";
			// 
			// panel2
			// 
			resources.ApplyResources(this.panel2, "panel2");
			this.panel2.Controls.Add(this.Label2);
			this.panel2.Controls.Add(this.apiTGridPrix);
			this.panel2.Name = "panel2";
			// 
			// panel1
			// 
			resources.ApplyResources(this.panel1, "panel1");
			this.panel1.Controls.Add(this.GrpBoxSearch);
			this.panel1.Controls.Add(this.apiTGridPrest);
			this.panel1.Controls.Add(this.Label1);
			this.panel1.Name = "panel1";
			// 
			// GrpBoxSearch
			// 
			this.GrpBoxSearch.Controls.Add(this.cmdFind);
			this.GrpBoxSearch.Controls.Add(this.txtCritFouSer);
			this.GrpBoxSearch.Controls.Add(this.Label5);
			this.GrpBoxSearch.Controls.Add(this.Label4);
			this.GrpBoxSearch.Controls.Add(this.TxtCritCode);
			this.GrpBoxSearch.Controls.Add(this.Label3);
			this.GrpBoxSearch.Controls.Add(this.label6);
			this.GrpBoxSearch.Controls.Add(this.TxtCritCreateur);
			this.GrpBoxSearch.Controls.Add(this.TxtCritPresta);
			resources.ApplyResources(this.GrpBoxSearch, "GrpBoxSearch");
			this.GrpBoxSearch.Name = "GrpBoxSearch";
			this.GrpBoxSearch.TabStop = false;
			// 
			// cmdFind
			// 
			this.cmdFind.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdFind.HelpContextID = 0;
			this.cmdFind.Image = global::MozartCS.Properties.Resources.Find;
			resources.ApplyResources(this.cmdFind, "cmdFind");
			this.cmdFind.Name = "cmdFind";
			this.cmdFind.Tag = "8";
			this.cmdFind.UseVisualStyleBackColor = true;
			this.cmdFind.Click += new System.EventHandler(this.cmdFind_Click);
			// 
			// txtCritFouSer
			// 
			this.txtCritFouSer.BackColor = System.Drawing.SystemColors.Window;
			resources.ApplyResources(this.txtCritFouSer, "txtCritFouSer");
			this.txtCritFouSer.Name = "txtCritFouSer";
			this.txtCritFouSer.NewValues = false;
			// 
			// Label5
			// 
			resources.ApplyResources(this.Label5, "Label5");
			this.Label5.Name = "Label5";
			// 
			// Label4
			// 
			resources.ApplyResources(this.Label4, "Label4");
			this.Label4.Name = "Label4";
			// 
			// TxtCritCode
			// 
			resources.ApplyResources(this.TxtCritCode, "TxtCritCode");
			this.TxtCritCode.Name = "TxtCritCode";
			// 
			// Label3
			// 
			resources.ApplyResources(this.Label3, "Label3");
			this.Label3.Name = "Label3";
			// 
			// label6
			// 
			resources.ApplyResources(this.label6, "label6");
			this.label6.Name = "label6";
			// 
			// TxtCritCreateur
			// 
			resources.ApplyResources(this.TxtCritCreateur, "TxtCritCreateur");
			this.TxtCritCreateur.Name = "TxtCritCreateur";
			// 
			// TxtCritPresta
			// 
			resources.ApplyResources(this.TxtCritPresta, "TxtCritPresta");
			this.TxtCritPresta.Name = "TxtCritPresta";
			// 
			// frmGestClientPrixPrestation
			// 
			this.AcceptButton = this.cmdFermer;
			this.BackColor = System.Drawing.Color.Wheat;
			this.CancelButton = this.cmdFermer;
			resources.ApplyResources(this, "$this");
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.cmdCoef);
			this.Controls.Add(this.cmdAjout);
			this.Controls.Add(this.cmdSup);
			this.Controls.Add(this.cmdFermer);
			this.Name = "frmGestClientPrixPrestation";
			this.ShowInTaskbar = false;
			this.Load += new System.EventHandler(this.frmGestClientPrixPrestation_Load);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.GrpBoxSearch.ResumeLayout(false);
			this.GrpBoxSearch.PerformLayout();
			this.ResumeLayout(false);

    }

    #endregion

    private MozartUC.apiButton cmdCoef;
    private MozartUC.apiButton cmdAjout;
    private MozartUC.apiButton cmdSup;
    private MozartUC.apiTGrid apiTGridPrest;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiTGrid apiTGridPrix;
    private MozartUC.apiLabel Label2;
    private MozartUC.apiLabel Label1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.ToolTip toolTip1;
    internal System.Windows.Forms.GroupBox GrpBoxSearch;
    internal System.Windows.Forms.Label Label5;
    internal System.Windows.Forms.Label Label4;
    internal System.Windows.Forms.TextBox TxtCritCode;
    internal System.Windows.Forms.Label Label3;
    internal System.Windows.Forms.Label label6;
    internal System.Windows.Forms.TextBox TxtCritCreateur;
    internal System.Windows.Forms.TextBox TxtCritPresta;
    private MozartUC.apiCombo txtCritFouSer;
    private MozartUC.apiButton cmdFind;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
