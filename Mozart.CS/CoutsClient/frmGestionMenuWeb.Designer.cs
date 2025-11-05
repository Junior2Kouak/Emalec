namespace MozartCS
{
  partial class frmGestionMenuWeb
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionMenuWeb));
      this.Text1 = new MozartUC.apiTextBox();
      this.cmdPetP = new MozartUC.apiButton();
      this.imlIcones = new System.Windows.Forms.ImageList(this.components);
      this.cmdFermer = new MozartUC.apiButton();
      this.lvwDB = new System.Windows.Forms.ListView();
      this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.Label3 = new MozartUC.apiLabel();
      this.Label2 = new MozartUC.apiLabel();
      this.Label1 = new MozartUC.apiLabel();
      this.tvwDB = new System.Windows.Forms.TreeView();
      this.SuspendLayout();
      // 
      // Text1
      // 
      resources.ApplyResources(this.Text1, "Text1");
      this.Text1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Text1.HelpContextID = 0;
      this.Text1.Name = "Text1";
      // 
      // cmdPetP
      // 
      resources.ApplyResources(this.cmdPetP, "cmdPetP");
      this.cmdPetP.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdPetP.HelpContextID = 0;
      this.cmdPetP.Name = "cmdPetP";
      this.cmdPetP.Tag = "46";
      this.cmdPetP.UseVisualStyleBackColor = true;
      this.cmdPetP.Click += new System.EventHandler(this.cmdPetP_Click);
      // 
      // imlIcones
      // 
      this.imlIcones.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlIcones.ImageStream")));
      this.imlIcones.TransparentColor = System.Drawing.Color.Transparent;
      this.imlIcones.Images.SetKeyName(0, "TOP");
      this.imlIcones.Images.SetKeyName(1, "O");
      this.imlIcones.Images.SetKeyName(2, "N");
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
      // lvwDB
      // 
      resources.ApplyResources(this.lvwDB, "lvwDB");
      this.lvwDB.BackColor = System.Drawing.Color.White;
      this.lvwDB.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
      this.lvwDB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.lvwDB.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
      this.lvwDB.HideSelection = false;
      this.lvwDB.MultiSelect = false;
      this.lvwDB.Name = "lvwDB";
      this.lvwDB.Sorting = System.Windows.Forms.SortOrder.Ascending;
      this.lvwDB.UseCompatibleStateImageBehavior = false;
      this.lvwDB.View = System.Windows.Forms.View.Details;
      this.lvwDB.SelectedIndexChanged += new System.EventHandler(this.lvwDB_SelectedIndexChanged);
      // 
      // columnHeader1
      // 
      resources.ApplyResources(this.columnHeader1, "columnHeader1");
      // 
      // Label3
      // 
      resources.ApplyResources(this.Label3, "Label3");
      this.Label3.BackColor = System.Drawing.Color.Wheat;
      this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label3.HelpContextID = 0;
      this.Label3.Name = "Label3";
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
      // tvwDB
      // 
      resources.ApplyResources(this.tvwDB, "tvwDB");
      this.tvwDB.ImageList = this.imlIcones;
      this.tvwDB.Name = "tvwDB";
      this.tvwDB.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvwDB_NodeMouseClick);
      // 
      // frmGestionMenuWeb
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.tvwDB);
      this.Controls.Add(this.Text1);
      this.Controls.Add(this.cmdPetP);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.lvwDB);
      this.Controls.Add(this.Label3);
      this.Controls.Add(this.Label2);
      this.Controls.Add(this.Label1);
      this.Name = "frmGestionMenuWeb";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmGestionMenuWeb_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiTextBox Text1;
    private MozartUC.apiButton cmdPetP;
    private System.Windows.Forms.ImageList imlIcones;
    private MozartUC.apiButton cmdFermer;
    private System.Windows.Forms.ListView lvwDB;
    // TODO GetCodeDeclareControl cas non traité pour type MSComctlLib.TreeView
    private MozartUC.apiLabel Label3;
    private MozartUC.apiLabel Label2;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    private MozartUC.apiLabel Label1;
    private System.Windows.Forms.TreeView tvwDB;
    private System.Windows.Forms.ColumnHeader columnHeader1;
  }
}
