namespace MozartCS
{
  partial class frmPlanSTBase
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlanSTBase));
      this.Label17 = new MozartUC.apiLabel();
      this.tablePlanning = new System.Windows.Forms.TableLayoutPanel();
      this.Label15 = new System.Windows.Forms.Label();
      this.Label14 = new System.Windows.Forms.Label();
      this.Label13 = new System.Windows.Forms.Label();
      this.Label12 = new System.Windows.Forms.Label();
      this.Label11 = new System.Windows.Forms.Label();
      this.Label10 = new System.Windows.Forms.Label();
      this.lblSemaine = new MozartUC.apiLabel();
      this.menuAffichage = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.mnuDetails = new System.Windows.Forms.ToolStripMenuItem();
      this.tablePlanning.SuspendLayout();
      this.menuAffichage.SuspendLayout();
      this.SuspendLayout();
      // 
      // Label17
      // 
      resources.ApplyResources(this.Label17, "Label17");
      this.Label17.BackColor = System.Drawing.Color.Wheat;
      this.Label17.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label17.HelpContextID = 0;
      this.Label17.Name = "Label17";
      // 
      // tablePlanning
      // 
      this.tablePlanning.AllowDrop = true;
      this.tablePlanning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.tablePlanning, "tablePlanning");
      this.tablePlanning.Controls.Add(this.Label15, 5, 0);
      this.tablePlanning.Controls.Add(this.Label14, 4, 0);
      this.tablePlanning.Controls.Add(this.Label13, 3, 0);
      this.tablePlanning.Controls.Add(this.Label12, 2, 0);
      this.tablePlanning.Controls.Add(this.Label11, 1, 0);
      this.tablePlanning.Controls.Add(this.Label10, 0, 0);
      this.tablePlanning.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
      this.tablePlanning.Name = "tablePlanning";
      this.tablePlanning.DragDrop += new System.Windows.Forms.DragEventHandler(this.tablePlanning_DragDrop);
      this.tablePlanning.DragEnter += new System.Windows.Forms.DragEventHandler(this.tablePlanning_DragEnter);
      this.tablePlanning.DragOver += new System.Windows.Forms.DragEventHandler(this.tablePlanning_DragOver);
      this.tablePlanning.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tablePlanning_MouseDown);
      this.tablePlanning.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tablePlanning_MouseUp);
      // 
      // Label15
      // 
      resources.ApplyResources(this.Label15, "Label15");
      this.Label15.BackColor = System.Drawing.Color.White;
      this.Label15.ForeColor = System.Drawing.Color.Blue;
      this.Label15.Name = "Label15";
      // 
      // Label14
      // 
      resources.ApplyResources(this.Label14, "Label14");
      this.Label14.BackColor = System.Drawing.Color.White;
      this.Label14.ForeColor = System.Drawing.Color.Blue;
      this.Label14.Name = "Label14";
      // 
      // Label13
      // 
      resources.ApplyResources(this.Label13, "Label13");
      this.Label13.BackColor = System.Drawing.Color.White;
      this.Label13.ForeColor = System.Drawing.Color.Blue;
      this.Label13.Name = "Label13";
      // 
      // Label12
      // 
      resources.ApplyResources(this.Label12, "Label12");
      this.Label12.BackColor = System.Drawing.Color.White;
      this.Label12.ForeColor = System.Drawing.Color.Blue;
      this.Label12.Name = "Label12";
      // 
      // Label11
      // 
      resources.ApplyResources(this.Label11, "Label11");
      this.Label11.BackColor = System.Drawing.Color.White;
      this.Label11.ForeColor = System.Drawing.Color.Blue;
      this.Label11.Name = "Label11";
      // 
      // Label10
      // 
      resources.ApplyResources(this.Label10, "Label10");
      this.Label10.BackColor = System.Drawing.Color.White;
      this.Label10.ForeColor = System.Drawing.Color.Blue;
      this.Label10.Name = "Label10";
      // 
      // lblSemaine
      // 
      this.lblSemaine.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.lblSemaine, "lblSemaine");
      this.lblSemaine.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblSemaine.HelpContextID = 0;
      this.lblSemaine.Name = "lblSemaine";
      // 
      // menuAffichage
      // 
      this.menuAffichage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDetails});
      this.menuAffichage.Name = "contextMenuStrip1";
      resources.ApplyResources(this.menuAffichage, "menuAffichage");
      // 
      // mnuDetails
      // 
      this.mnuDetails.Name = "mnuDetails";
      resources.ApplyResources(this.mnuDetails, "mnuDetails");
      this.mnuDetails.Click += new System.EventHandler(this.mnuDetails_Click);
      // 
      // frmPlanSTBase
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.lblSemaine);
      this.Controls.Add(this.Label17);
      this.Controls.Add(this.tablePlanning);
      this.Name = "frmPlanSTBase";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmPlanSTBase_Load);
      this.tablePlanning.ResumeLayout(false);
      this.tablePlanning.PerformLayout();
      this.menuAffichage.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private MozartUC.apiLabel Label17;
    private System.Windows.Forms.TableLayoutPanel tablePlanning;
    private MozartUC.apiLabel lblSemaine;
    private System.Windows.Forms.Label Label10;
    private System.Windows.Forms.Label Label14;
    private System.Windows.Forms.Label Label13;
    private System.Windows.Forms.Label Label12;
    private System.Windows.Forms.Label Label11;
    private System.Windows.Forms.Label Label15;
    private System.Windows.Forms.ContextMenuStrip menuAffichage;
    private System.Windows.Forms.ToolStripMenuItem mnuDetails;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    // TODO GetCodeDeclareControl cas non traité pour type VB.Menu
    // TODO GetCodeDeclareControl cas non traité pour type VB.Menu

  }
}
