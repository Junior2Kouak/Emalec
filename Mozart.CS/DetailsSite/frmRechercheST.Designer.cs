namespace MozartCS
{
  partial class frmRechercheST
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRechercheST));
      this.cmdGerer = new MozartUC.apiButton();
      this.cboPays = new System.Windows.Forms.ComboBox();
      this.cboPrestations = new System.Windows.Forms.ComboBox();
      this.cboCategories = new System.Windows.Forms.ComboBox();
      this.cboVillesCibles = new System.Windows.Forms.ComboBox();
      this.txtCritSTFACTIV = new MozartUC.apiTextBox();
      this.txtCritSTFDEP = new MozartUC.apiTextBox();
      this.txtCritINTNOM = new MozartUC.apiTextBox();
      this.txtCritSTFNOM = new MozartUC.apiTextBox();
      this.cmdFind = new MozartUC.apiButton();
      this.Label11 = new MozartUC.apiLabel();
      this.Label10 = new MozartUC.apiLabel();
      this.Label5 = new MozartUC.apiLabel();
      this.Label4 = new MozartUC.apiLabel();
      this.Label3 = new MozartUC.apiLabel();
      this.Label2 = new MozartUC.apiLabel();
      this.label14 = new MozartUC.apiLabel();
      this.Label7 = new MozartUC.apiLabel();
      this.fraCriteres = new MozartUC.apiGroupBox();
      this.Grid = new MozartUC.apiTGrid();
      this.cmdFermer = new MozartUC.apiButton();
      this.cmdSelectionner = new MozartUC.apiButton();
      this.Label9 = new MozartUC.apiLabel();
      this.Label8 = new MozartUC.apiLabel();
      this.Label1 = new MozartUC.apiLabel();
      this.fraCriteres.SuspendLayout();
      this.SuspendLayout();
      // 
      // cmdGerer
      // 
      resources.ApplyResources(this.cmdGerer, "cmdGerer");
      this.cmdGerer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdGerer.HelpContextID = 0;
      this.cmdGerer.Name = "cmdGerer";
      this.cmdGerer.Tag = "15";
      this.cmdGerer.UseVisualStyleBackColor = true;
      this.cmdGerer.Click += new System.EventHandler(this.cmdGerer_Click);
      // 
      // cboPays
      // 
      this.cboPays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      resources.ApplyResources(this.cboPays, "cboPays");
      this.cboPays.Name = "cboPays";
      this.cboPays.SelectedValueChanged += new System.EventHandler(this.cboPays_SelectedValueChanged);
      // 
      // cboPrestations
      // 
      this.cboPrestations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      resources.ApplyResources(this.cboPrestations, "cboPrestations");
      this.cboPrestations.Name = "cboPrestations";
      // 
      // cboCategories
      // 
      this.cboCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboCategories.Items.AddRange(new object[] {
            resources.GetString("cboCategories.Items"),
            resources.GetString("cboCategories.Items1")});
      resources.ApplyResources(this.cboCategories, "cboCategories");
      this.cboCategories.Name = "cboCategories";
      this.cboCategories.SelectedIndexChanged += new System.EventHandler(this.cboCategories_SelectedIndexChanged);
      // 
      // cboVillesCibles
      // 
      this.cboVillesCibles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      resources.ApplyResources(this.cboVillesCibles, "cboVillesCibles");
      this.cboVillesCibles.Name = "cboVillesCibles";
      // 
      // txtCritSTFACTIV
      // 
      resources.ApplyResources(this.txtCritSTFACTIV, "txtCritSTFACTIV");
      this.txtCritSTFACTIV.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtCritSTFACTIV.HelpContextID = 0;
      this.txtCritSTFACTIV.Name = "txtCritSTFACTIV";
      // 
      // txtCritSTFDEP
      // 
      resources.ApplyResources(this.txtCritSTFDEP, "txtCritSTFDEP");
      this.txtCritSTFDEP.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtCritSTFDEP.HelpContextID = 0;
      this.txtCritSTFDEP.Name = "txtCritSTFDEP";
      // 
      // txtCritINTNOM
      // 
      resources.ApplyResources(this.txtCritINTNOM, "txtCritINTNOM");
      this.txtCritINTNOM.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtCritINTNOM.HelpContextID = 0;
      this.txtCritINTNOM.Name = "txtCritINTNOM";
      // 
      // txtCritSTFNOM
      // 
      resources.ApplyResources(this.txtCritSTFNOM, "txtCritSTFNOM");
      this.txtCritSTFNOM.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtCritSTFNOM.HelpContextID = 0;
      this.txtCritSTFNOM.Name = "txtCritSTFNOM";
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
      // Label11
      // 
      resources.ApplyResources(this.Label11, "Label11");
      this.Label11.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label11.HelpContextID = 0;
      this.Label11.Name = "Label11";
      // 
      // Label10
      // 
      resources.ApplyResources(this.Label10, "Label10");
      this.Label10.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label10.HelpContextID = 0;
      this.Label10.Name = "Label10";
      // 
      // Label5
      // 
      resources.ApplyResources(this.Label5, "Label5");
      this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label5.HelpContextID = 0;
      this.Label5.Name = "Label5";
      // 
      // Label4
      // 
      resources.ApplyResources(this.Label4, "Label4");
      this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label4.HelpContextID = 0;
      this.Label4.Name = "Label4";
      // 
      // Label3
      // 
      resources.ApplyResources(this.Label3, "Label3");
      this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label3.HelpContextID = 0;
      this.Label3.Name = "Label3";
      // 
      // Label2
      // 
      resources.ApplyResources(this.Label2, "Label2");
      this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label2.HelpContextID = 0;
      this.Label2.Name = "Label2";
      // 
      // label14
      // 
      resources.ApplyResources(this.label14, "label14");
      this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
      this.label14.HelpContextID = 0;
      this.label14.Name = "label14";
      // 
      // Label7
      // 
      this.Label7.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label7.HelpContextID = 0;
      resources.ApplyResources(this.Label7, "Label7");
      this.Label7.Name = "Label7";
      // 
      // fraCriteres
      // 
      resources.ApplyResources(this.fraCriteres, "fraCriteres");
      this.fraCriteres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(218)))), ((int)(((byte)(242)))));
      this.fraCriteres.Controls.Add(this.cboPays);
      this.fraCriteres.Controls.Add(this.cboPrestations);
      this.fraCriteres.Controls.Add(this.cboCategories);
      this.fraCriteres.Controls.Add(this.cboVillesCibles);
      this.fraCriteres.Controls.Add(this.txtCritSTFACTIV);
      this.fraCriteres.Controls.Add(this.txtCritSTFDEP);
      this.fraCriteres.Controls.Add(this.txtCritINTNOM);
      this.fraCriteres.Controls.Add(this.txtCritSTFNOM);
      this.fraCriteres.Controls.Add(this.cmdFind);
      this.fraCriteres.Controls.Add(this.Label11);
      this.fraCriteres.Controls.Add(this.Label10);
      this.fraCriteres.Controls.Add(this.Label5);
      this.fraCriteres.Controls.Add(this.Label4);
      this.fraCriteres.Controls.Add(this.Label3);
      this.fraCriteres.Controls.Add(this.Label2);
      this.fraCriteres.Controls.Add(this.label14);
      this.fraCriteres.Controls.Add(this.Label7);
      this.fraCriteres.HelpContextID = 0;
      this.fraCriteres.Name = "fraCriteres";
      this.fraCriteres.TabStop = false;
      // 
      // Grid
      // 
      resources.ApplyResources(this.Grid, "Grid");
      this.Grid.FilterBar = true;
      this.Grid.FooterBar = true;
      this.Grid.Name = "Grid";
      this.Grid.DoubleClickE += new MozartUC.apiTGrid.DoubleClickEEventHandler(this.Grid_DblClick);
      this.Grid.RowStyle += new MozartUC.apiTGrid.RowStyleEventHandler(this.Grid_RowStyle);
      // 
      // cmdFermer
      // 
      this.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Tag = "15";
      this.cmdFermer.UseVisualStyleBackColor = true;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // cmdSelectionner
      // 
      resources.ApplyResources(this.cmdSelectionner, "cmdSelectionner");
      this.cmdSelectionner.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdSelectionner.HelpContextID = 0;
      this.cmdSelectionner.Name = "cmdSelectionner";
      this.cmdSelectionner.Tag = "20";
      this.cmdSelectionner.UseVisualStyleBackColor = true;
      this.cmdSelectionner.Click += new System.EventHandler(this.cmdSelectionner_Click);
      // 
      // Label9
      // 
      this.Label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
      this.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Label9.HelpContextID = 0;
      resources.ApplyResources(this.Label9, "Label9");
      this.Label9.Name = "Label9";
      // 
      // Label8
      // 
      resources.ApplyResources(this.Label8, "Label8");
      this.Label8.BackColor = System.Drawing.Color.Wheat;
      this.Label8.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label8.HelpContextID = 0;
      this.Label8.Name = "Label8";
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // frmRechercheST
      // 
      this.AcceptButton = this.cmdFind;
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdGerer);
      this.Controls.Add(this.fraCriteres);
      this.Controls.Add(this.Grid);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.cmdSelectionner);
      this.Controls.Add(this.Label9);
      this.Controls.Add(this.Label8);
      this.Controls.Add(this.Label1);
      this.KeyPreview = true;
      this.Name = "frmRechercheST";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmRechercheST_Load);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmdFind_KeyUp);
      this.fraCriteres.ResumeLayout(false);
      this.fraCriteres.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdGerer;
    private System.Windows.Forms.ComboBox cboPays;
    private System.Windows.Forms.ComboBox cboPrestations;
    private System.Windows.Forms.ComboBox cboCategories;
    private System.Windows.Forms.ComboBox cboVillesCibles;
    private MozartUC.apiTextBox txtCritSTFACTIV;
    private MozartUC.apiTextBox txtCritSTFDEP;
    private MozartUC.apiTextBox txtCritINTNOM;
    private MozartUC.apiTextBox txtCritSTFNOM;
    private MozartUC.apiButton cmdFind;
    private MozartUC.apiLabel Label11;
    private MozartUC.apiLabel Label10;
    private MozartUC.apiLabel Label5;
    private MozartUC.apiLabel Label4;
    private MozartUC.apiLabel Label3;
    private MozartUC.apiLabel Label2;
    private MozartUC.apiLabel label14;
    private MozartUC.apiLabel Label7;
    private MozartUC.apiGroupBox fraCriteres;
    private MozartUC.apiTGrid Grid;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiButton cmdSelectionner;
    private MozartUC.apiLabel Label9;
    private MozartUC.apiLabel Label8;
    private MozartUC.apiLabel Label1;

  }
}
