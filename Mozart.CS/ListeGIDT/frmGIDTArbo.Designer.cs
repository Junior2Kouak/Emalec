
namespace MozartCS
{
  partial class frmGIDTArbo
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGIDTArbo));
      this.lblClient = new System.Windows.Forms.Label();
      this.cmdFermer = new MozartUC.apiButton();
      this.Grid = new MozartUC.apiTGrid();
      this.cmdDel = new MozartUC.apiButton();
      this.frmArbo = new MozartUC.apiGroupBox();
      this.cboContrat = new MozartUC.apiCombo();
      this.txtNiv2 = new System.Windows.Forms.TextBox();
      this.txtNiv3 = new System.Windows.Forms.TextBox();
      this.txtNiv1 = new System.Windows.Forms.TextBox();
      this.cmdValider = new System.Windows.Forms.Button();
      this.lblNiv3 = new System.Windows.Forms.Label();
      this.lblNiv2 = new System.Windows.Forms.Label();
      this.lblNiv1 = new System.Windows.Forms.Label();
      this.lblContrat = new System.Windows.Forms.Label();
      this.cmdAdd = new MozartUC.apiButton();
      this.frmArbo.SuspendLayout();
      this.SuspendLayout();
      // 
      // lblClient
      // 
      resources.ApplyResources(this.lblClient, "lblClient");
      this.lblClient.ForeColor = System.Drawing.Color.Yellow;
      this.lblClient.Name = "lblClient";
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.UseVisualStyleBackColor = false;
      // 
      // Grid
      // 
      resources.ApplyResources(this.Grid, "Grid");
      this.Grid.FilterBar = true;
      this.Grid.FooterBar = true;
      this.Grid.Name = "Grid";
      this.Grid.ClickE += new MozartUC.apiTGrid.ClickEEventHandler(this.Grid_ClickE);
      this.Grid.RowCellStyle += new MozartUC.apiTGrid.RowCellStyleEventHandler(this.Grid_RowCellStyle);
      // 
      // cmdDel
      // 
      this.cmdDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.cmdDel, "cmdDel");
      this.cmdDel.HelpContextID = 0;
      this.cmdDel.Image = global::MozartCS.Properties.Resources.delete_32;
      this.cmdDel.Name = "cmdDel";
      this.cmdDel.UseVisualStyleBackColor = false;
      this.cmdDel.Click += new System.EventHandler(this.cmdDel_Click);
      // 
      // frmArbo
      // 
      resources.ApplyResources(this.frmArbo, "frmArbo");
      this.frmArbo.Controls.Add(this.cboContrat);
      this.frmArbo.Controls.Add(this.txtNiv2);
      this.frmArbo.Controls.Add(this.txtNiv3);
      this.frmArbo.Controls.Add(this.txtNiv1);
      this.frmArbo.Controls.Add(this.cmdValider);
      this.frmArbo.Controls.Add(this.lblNiv3);
      this.frmArbo.Controls.Add(this.lblNiv2);
      this.frmArbo.Controls.Add(this.lblNiv1);
      this.frmArbo.Controls.Add(this.lblContrat);
      this.frmArbo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.frmArbo.FrameColor = System.Drawing.Color.Empty;
      this.frmArbo.HelpContextID = 0;
      this.frmArbo.Name = "frmArbo";
      this.frmArbo.TabStop = false;
      // 
      // cboContrat
      // 
      resources.ApplyResources(this.cboContrat, "cboContrat");
      this.cboContrat.Name = "cboContrat";
      this.cboContrat.NewValues = false;
      // 
      // txtNiv2
      // 
      resources.ApplyResources(this.txtNiv2, "txtNiv2");
      this.txtNiv2.Name = "txtNiv2";
      // 
      // txtNiv3
      // 
      resources.ApplyResources(this.txtNiv3, "txtNiv3");
      this.txtNiv3.Name = "txtNiv3";
      // 
      // txtNiv1
      // 
      resources.ApplyResources(this.txtNiv1, "txtNiv1");
      this.txtNiv1.Name = "txtNiv1";
      // 
      // cmdValider
      // 
      this.cmdValider.ForeColor = System.Drawing.Color.Black;
      resources.ApplyResources(this.cmdValider, "cmdValider");
      this.cmdValider.Name = "cmdValider";
      this.cmdValider.UseVisualStyleBackColor = true;
      this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
      // 
      // lblNiv3
      // 
      resources.ApplyResources(this.lblNiv3, "lblNiv3");
      this.lblNiv3.Name = "lblNiv3";
      // 
      // lblNiv2
      // 
      resources.ApplyResources(this.lblNiv2, "lblNiv2");
      this.lblNiv2.Name = "lblNiv2";
      // 
      // lblNiv1
      // 
      resources.ApplyResources(this.lblNiv1, "lblNiv1");
      this.lblNiv1.Name = "lblNiv1";
      // 
      // lblContrat
      // 
      resources.ApplyResources(this.lblContrat, "lblContrat");
      this.lblContrat.Name = "lblContrat";
      // 
      // cmdAdd
      // 
      this.cmdAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.cmdAdd, "cmdAdd");
      this.cmdAdd.HelpContextID = 0;
      this.cmdAdd.Image = global::MozartCS.Properties.Resources.add_32;
      this.cmdAdd.Name = "cmdAdd";
      this.cmdAdd.UseVisualStyleBackColor = false;
      this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
      // 
      // frmGIDTArbo
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(108)))), ((int)(((byte)(186)))));
      this.Controls.Add(this.cmdAdd);
      this.Controls.Add(this.frmArbo);
      this.Controls.Add(this.cmdDel);
      this.Controls.Add(this.Grid);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.lblClient);
      this.Name = "frmGIDTArbo";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmGIDTArbo_Load);
      this.frmArbo.ResumeLayout(false);
      this.frmArbo.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblClient;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiTGrid Grid;
    private MozartUC.apiButton cmdDel;
    private MozartUC.apiGroupBox frmArbo;
    private System.Windows.Forms.Button cmdValider;
    private System.Windows.Forms.Label lblNiv3;
    private System.Windows.Forms.Label lblNiv2;
    private System.Windows.Forms.Label lblNiv1;
    private System.Windows.Forms.Label lblContrat;
    private MozartUC.apiButton cmdAdd;
    private System.Windows.Forms.TextBox txtNiv2;
    private System.Windows.Forms.TextBox txtNiv3;
    private System.Windows.Forms.TextBox txtNiv1;
    private MozartUC.apiCombo cboContrat;
  }
}