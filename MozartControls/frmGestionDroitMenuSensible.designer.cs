namespace MozartControls
{
  partial class frmGestionDroitMenuSensible
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionDroitMenuSensible));
			this.imlIcones = new System.Windows.Forms.ImageList(this.components);
			this.cmdFermer = new MozartUC.apiButton();
			this.Label1 = new MozartUC.apiLabel();
			this.tvwDB = new System.Windows.Forms.TreeView();
			this.apiLabel1 = new MozartUC.apiLabel();
			this.SuspendLayout();
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
			// apiLabel1
			// 
			resources.ApplyResources(this.apiLabel1, "apiLabel1");
			this.apiLabel1.BackColor = System.Drawing.Color.Wheat;
			this.apiLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.apiLabel1.HelpContextID = 0;
			this.apiLabel1.Name = "apiLabel1";
			// 
			// frmGestionDroitMenuSensible
			// 
			this.BackColor = System.Drawing.Color.Wheat;
			this.CancelButton = this.cmdFermer;
			resources.ApplyResources(this, "$this");
			this.Controls.Add(this.apiLabel1);
			this.Controls.Add(this.tvwDB);
			this.Controls.Add(this.cmdFermer);
			this.Controls.Add(this.Label1);
			this.Name = "frmGestionDroitMenuSensible";
			this.ShowInTaskbar = false;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmGestionMenuWeb_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.ImageList imlIcones;
    private MozartUC.apiButton cmdFermer;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    private MozartUC.apiLabel Label1;
		private System.Windows.Forms.TreeView tvwDB;
		private MozartUC.apiLabel apiLabel1;
	}
}
