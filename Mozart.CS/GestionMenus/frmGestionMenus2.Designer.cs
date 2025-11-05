namespace MozartCS
{
  partial class frmGestionMenus2
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionMenus2));
      this.cmdFermer = new MozartUC.apiButton();
      this.flbIco = new System.Windows.Forms.OpenFileDialog();
      this.cmdPetP = new MozartUC.apiButton();
      this.imlIcones = new System.Windows.Forms.ImageList(this.components);
      this.lvwDB = new System.Windows.Forms.ListView();
      this.lvwSociete = new System.Windows.Forms.ListView();
      this.Label1 = new MozartUC.apiLabel();
      this.lblPath = new MozartUC.apiLabel();
      this.tvwDB = new System.Windows.Forms.TreeView();
      this.SuspendLayout();
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
      // cmdPetP
      // 
      resources.ApplyResources(this.cmdPetP, "cmdPetP");
      this.cmdPetP.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdPetP.HelpContextID = 85;
      this.cmdPetP.Name = "cmdPetP";
      this.cmdPetP.Tag = "46";
      this.cmdPetP.UseVisualStyleBackColor = true;
      this.cmdPetP.Click += new System.EventHandler(this.cmdPetP_Click);
      // 
      // imlIcones
      // 
      this.imlIcones.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlIcones.ImageStream")));
      this.imlIcones.TransparentColor = System.Drawing.Color.Transparent;
      this.imlIcones.Images.SetKeyName(0, "folder.png");
      this.imlIcones.Images.SetKeyName(1, "ok.gif");
      this.imlIcones.Images.SetKeyName(2, "delete.png");
      // 
      // lvwDB
      // 
      resources.ApplyResources(this.lvwDB, "lvwDB");
      this.lvwDB.BackColor = System.Drawing.Color.White;
      this.lvwDB.ForeColor = System.Drawing.Color.Black;
      this.lvwDB.HideSelection = false;
      this.lvwDB.Name = "lvwDB";
      this.lvwDB.UseCompatibleStateImageBehavior = false;
      this.lvwDB.View = System.Windows.Forms.View.Details;
      this.lvwDB.SelectedIndexChanged += new System.EventHandler(this.lvwDB_SelectedIndexChanged);
      // 
      // lvwSociete
      // 
      resources.ApplyResources(this.lvwSociete, "lvwSociete");
      this.lvwSociete.BackColor = System.Drawing.Color.White;
      this.lvwSociete.CheckBoxes = true;
      this.lvwSociete.ForeColor = System.Drawing.SystemColors.WindowText;
      this.lvwSociete.HideSelection = false;
      this.lvwSociete.Name = "lvwSociete";
      this.lvwSociete.UseCompatibleStateImageBehavior = false;
      this.lvwSociete.View = System.Windows.Forms.View.Details;
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // lblPath
      // 
      resources.ApplyResources(this.lblPath, "lblPath");
      this.lblPath.BackColor = System.Drawing.Color.White;
      this.lblPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblPath.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblPath.HelpContextID = 0;
      this.lblPath.Name = "lblPath";
      // 
      // tvwDB
      // 
      resources.ApplyResources(this.tvwDB, "tvwDB");
      this.tvwDB.ImageList = this.imlIcones;
      this.tvwDB.Name = "tvwDB";
      this.tvwDB.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvwDB_NodeMouseClick);
      // 
      // frmGestionMenus2
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.tvwDB);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.cmdPetP);
      this.Controls.Add(this.lvwDB);
      this.Controls.Add(this.lvwSociete);
      this.Controls.Add(this.Label1);
      this.Controls.Add(this.lblPath);
      this.Name = "frmGestionMenus2";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmGestionMenus2_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdFermer;
    private System.Windows.Forms.OpenFileDialog flbIco;
    private MozartUC.apiButton cmdPetP;
    private System.Windows.Forms.ImageList imlIcones;
    private System.Windows.Forms.ListView lvwDB;
    // TODO GetCodeDeclareControl cas non traité pour type MSComctlLib.TreeView
    private System.Windows.Forms.ListView lvwSociete;
    private MozartUC.apiLabel Label1;
    private MozartUC.apiLabel lblPath;
    private System.Windows.Forms.TreeView tvwDB;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
