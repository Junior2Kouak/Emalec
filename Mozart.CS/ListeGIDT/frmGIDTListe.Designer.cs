
namespace MozartCS
{
  partial class frmGIDTListe
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGIDTListe));
      this.cmdFermer = new MozartUC.apiButton();
      this.apiGroupBox1 = new MozartUC.apiGroupBox();
      this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
      this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
      this.Grid = new MozartUC.apiTGrid();
      this.apiGroupBox1.SuspendLayout();
      this.SuspendLayout();
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
      // apiGroupBox1
      // 
      resources.ApplyResources(this.apiGroupBox1, "apiGroupBox1");
      this.apiGroupBox1.Controls.Add(this.flowLayoutPanel1);
      this.apiGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.apiGroupBox1.HelpContextID = 0;
      this.apiGroupBox1.Name = "apiGroupBox1";
      this.apiGroupBox1.TabStop = false;
      // 
      // flowLayoutPanel1
      // 
      resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
      this.flowLayoutPanel1.Name = "flowLayoutPanel1";
      // 
      // Grid
      // 
      resources.ApplyResources(this.Grid, "Grid");
      this.Grid.FilterBar = true;
      this.Grid.FooterBar = true;
      this.Grid.Name = "Grid";
      this.Grid.RowCellStyle += new MozartUC.apiTGrid.RowCellStyleEventHandler(this.Grid_RowCellStyle);
      this.Grid.FocusedRowChanged += new MozartUC.apiTGrid.FocusedRowChangedEventHandler(this.Grid_FocusedRowChanged);
      // 
      // frmGIDTListe
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(108)))), ((int)(((byte)(186)))));
      this.Controls.Add(this.Grid);
      this.Controls.Add(this.apiGroupBox1);
      this.Controls.Add(this.cmdFermer);
      this.Name = "frmGIDTListe";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmGIDTListe_Load);
      this.apiGroupBox1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiGroupBox apiGroupBox1;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    private DevExpress.Utils.ToolTipController toolTipController1;
    private MozartUC.apiTGrid Grid;
  }
}