namespace MozartCS
{
  partial class frmGestionMenus
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionMenus));
      this.CmdAccesGrp = new MozartUC.apiButton();
      this.cmdDecoche = new MozartUC.apiButton();
      this.cmdCoche = new MozartUC.apiButton();
      this.txtFiltre2 = new MozartUC.apiTextBox();
      this.lvwSociete = new System.Windows.Forms.ListView();
      this.flbIco = new System.Windows.Forms.OpenFileDialog();
      this.cmdAcces = new MozartUC.apiButton();
      this.cmdPetP = new MozartUC.apiButton();
      this.txtFiltre = new MozartUC.apiTextBox();
      this.cmdFiltrer = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.lvwDB = new System.Windows.Forms.ListView();
      this.imlIcones = new System.Windows.Forms.ImageList(this.components);
      this.lblPath = new MozartUC.apiLabel();
      this.Label1 = new MozartUC.apiLabel();
      this.tvwDB = new System.Windows.Forms.TreeView();
      this.cmdClearFilter = new MozartUC.apiButton();
      this.SuspendLayout();
      // 
      // CmdAccesGrp
      // 
      resources.ApplyResources(this.CmdAccesGrp, "CmdAccesGrp");
      this.CmdAccesGrp.ForeColor = System.Drawing.SystemColors.ControlText;
      this.CmdAccesGrp.HelpContextID = 0;
      this.CmdAccesGrp.Name = "CmdAccesGrp";
      this.CmdAccesGrp.Tag = "52";
      this.CmdAccesGrp.UseVisualStyleBackColor = true;
      this.CmdAccesGrp.Click += new System.EventHandler(this.CmdAccesGrp_Click);
      // 
      // cmdDecoche
      // 
      resources.ApplyResources(this.cmdDecoche, "cmdDecoche");
      this.cmdDecoche.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdDecoche.HelpContextID = 0;
      this.cmdDecoche.Name = "cmdDecoche";
      this.cmdDecoche.Tag = "15";
      this.cmdDecoche.UseVisualStyleBackColor = true;
      this.cmdDecoche.Click += new System.EventHandler(this.cmdDecoche_Click);
      // 
      // cmdCoche
      // 
      resources.ApplyResources(this.cmdCoche, "cmdCoche");
      this.cmdCoche.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdCoche.HelpContextID = 0;
      this.cmdCoche.Name = "cmdCoche";
      this.cmdCoche.Tag = "15";
      this.cmdCoche.UseVisualStyleBackColor = true;
      this.cmdCoche.Click += new System.EventHandler(this.cmdCoche_Click);
      // 
      // txtFiltre2
      // 
      resources.ApplyResources(this.txtFiltre2, "txtFiltre2");
      this.txtFiltre2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtFiltre2.HelpContextID = 0;
      this.txtFiltre2.Name = "txtFiltre2";
      // 
      // lvwSociete
      // 
      resources.ApplyResources(this.lvwSociete, "lvwSociete");
      this.lvwSociete.BackColor = System.Drawing.Color.White;
      this.lvwSociete.CheckBoxes = true;
      this.lvwSociete.ForeColor = System.Drawing.Color.Black;
      this.lvwSociete.HideSelection = false;
      this.lvwSociete.Name = "lvwSociete";
      this.lvwSociete.UseCompatibleStateImageBehavior = false;
      this.lvwSociete.View = System.Windows.Forms.View.Details;
      // 
      // cmdAcces
      // 
      resources.ApplyResources(this.cmdAcces, "cmdAcces");
      this.cmdAcces.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdAcces.HelpContextID = 0;
      this.cmdAcces.Name = "cmdAcces";
      this.cmdAcces.Tag = "52";
      this.cmdAcces.UseVisualStyleBackColor = true;
      this.cmdAcces.Click += new System.EventHandler(this.cmdAcces_Click);
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
      // txtFiltre
      // 
      resources.ApplyResources(this.txtFiltre, "txtFiltre");
      this.txtFiltre.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtFiltre.HelpContextID = 0;
      this.txtFiltre.Name = "txtFiltre";
      this.txtFiltre.TextChanged += new System.EventHandler(this.txtFiltre_TextChanged);
      // 
      // cmdFiltrer
      // 
      this.cmdFiltrer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdFiltrer.HelpContextID = 0;
      this.cmdFiltrer.Image = global::MozartCS.Properties.Resources.Find;
      resources.ApplyResources(this.cmdFiltrer, "cmdFiltrer");
      this.cmdFiltrer.Name = "cmdFiltrer";
      this.cmdFiltrer.UseVisualStyleBackColor = true;
      this.cmdFiltrer.Click += new System.EventHandler(this.cmdFiltrer_Click);
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
      this.lvwDB.CheckBoxes = true;
      this.lvwDB.ForeColor = System.Drawing.Color.Black;
      this.lvwDB.HideSelection = false;
      this.lvwDB.MultiSelect = false;
      this.lvwDB.Name = "lvwDB";
      this.lvwDB.UseCompatibleStateImageBehavior = false;
      this.lvwDB.View = System.Windows.Forms.View.Details;
      this.lvwDB.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvwDB_ItemChecked);
      this.lvwDB.SelectedIndexChanged += new System.EventHandler(this.lvwDB_SelectedIndexChanged);
      // 
      // imlIcones
      // 
      this.imlIcones.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlIcones.ImageStream")));
      this.imlIcones.TransparentColor = System.Drawing.Color.Transparent;
      this.imlIcones.Images.SetKeyName(0, "folder.png");
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
      this.tvwDB.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.tvwDB_AfterCollapse);
      this.tvwDB.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.tvwDB_AfterExpand);
      this.tvwDB.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvwDB_NodeMouseClick);
      // 
      // cmdClearFilter
      // 
      this.cmdClearFilter.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdClearFilter.HelpContextID = 0;
      this.cmdClearFilter.Image = global::MozartCS.Properties.Resources.delete_32;
      resources.ApplyResources(this.cmdClearFilter, "cmdClearFilter");
      this.cmdClearFilter.Name = "cmdClearFilter";
      this.cmdClearFilter.UseVisualStyleBackColor = true;
      this.cmdClearFilter.Click += new System.EventHandler(this.cmdClearFilter_Click);
      // 
      // frmGestionMenus
      // 
      this.AcceptButton = this.cmdFiltrer;
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdClearFilter);
      this.Controls.Add(this.tvwDB);
      this.Controls.Add(this.CmdAccesGrp);
      this.Controls.Add(this.cmdDecoche);
      this.Controls.Add(this.cmdCoche);
      this.Controls.Add(this.txtFiltre2);
      this.Controls.Add(this.lvwSociete);
      this.Controls.Add(this.cmdAcces);
      this.Controls.Add(this.cmdPetP);
      this.Controls.Add(this.txtFiltre);
      this.Controls.Add(this.cmdFiltrer);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.lvwDB);
      this.Controls.Add(this.lblPath);
      this.Controls.Add(this.Label1);
      this.Name = "frmGestionMenus";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmGestionMenus_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton CmdAccesGrp;
    private MozartUC.apiButton cmdDecoche;
    private MozartUC.apiButton cmdCoche;
    private MozartUC.apiTextBox txtFiltre2;
    private System.Windows.Forms.ListView lvwSociete;
    private System.Windows.Forms.OpenFileDialog flbIco;
    private MozartUC.apiButton cmdAcces;
    private MozartUC.apiButton cmdPetP;
    private MozartUC.apiTextBox txtFiltre;
    private MozartUC.apiButton cmdFiltrer;
    private MozartUC.apiButton cmdFermer;
    private System.Windows.Forms.ListView lvwDB;
    // TODO GetCodeDeclareControl cas non traité pour type MSComctlLib.TreeView
    private System.Windows.Forms.ImageList imlIcones;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    private MozartUC.apiLabel lblPath;
    private MozartUC.apiLabel Label1;
    private System.Windows.Forms.TreeView tvwDB;
    private MozartUC.apiButton cmdClearFilter;
  }
}
