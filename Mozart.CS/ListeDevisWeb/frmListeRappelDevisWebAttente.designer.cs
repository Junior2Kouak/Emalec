namespace MozartCS
{
  partial class frmListeRappelDevisWebAttente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListeRappelDevisWebAttente));
            this.cmdQuitter = new MozartUC.apiButton();
            this.cmdDetail = new MozartUC.apiButton();
            this.apiTGrid = new MozartUC.apiTGrid();
            this.apiTGridChaff = new MozartUC.apiTGrid();
            this.Label5 = new MozartUC.apiLabel();
            this.Label1 = new MozartUC.apiLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.apiLabel1 = new MozartUC.apiLabel();
            this.apiTGrid1 = new MozartUC.apiTGrid();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.apiLabel2 = new MozartUC.apiLabel();
            this.apiTGrid2 = new MozartUC.apiTGrid();
            this.BtnDetailDI = new MozartUC.apiButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdQuitter
            // 
            resources.ApplyResources(this.cmdQuitter, "cmdQuitter");
            this.cmdQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdQuitter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdQuitter.HelpContextID = 0;
            this.cmdQuitter.Name = "cmdQuitter";
            this.cmdQuitter.Tag = "15";
            this.cmdQuitter.UseVisualStyleBackColor = true;
            this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
            // 
            // cmdDetail
            // 
            resources.ApplyResources(this.cmdDetail, "cmdDetail");
            this.cmdDetail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdDetail.HelpContextID = 0;
            this.cmdDetail.Name = "cmdDetail";
            this.cmdDetail.Tag = "66";
            this.cmdDetail.UseVisualStyleBackColor = true;
            this.cmdDetail.Click += new System.EventHandler(this.cmdValider_Click);
            // 
            // apiTGrid
            // 
            resources.ApplyResources(this.apiTGrid, "apiTGrid");
            this.apiTGrid.FilterBar = true;
            this.apiTGrid.FooterBar = true;
            this.apiTGrid.Name = "apiTGrid";
            // 
            // apiTGridChaff
            // 
            resources.ApplyResources(this.apiTGridChaff, "apiTGridChaff");
            this.apiTGridChaff.FilterBar = true;
            this.apiTGridChaff.FooterBar = true;
            this.apiTGridChaff.Name = "apiTGridChaff";
            // 
            // Label5
            // 
            resources.ApplyResources(this.Label5, "Label5");
            this.Label5.BackColor = System.Drawing.Color.Wheat;
            this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label5.HelpContextID = 0;
            this.Label5.Name = "Label5";
            // 
            // Label1
            // 
            resources.ApplyResources(this.Label1, "Label1");
            this.Label1.BackColor = System.Drawing.Color.Wheat;
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.HelpContextID = 0;
            this.Label1.Name = "Label1";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Controls.Add(this.apiLabel1);
            this.panel3.Controls.Add(this.apiTGrid1);
            this.panel3.Name = "panel3";
            // 
            // apiLabel1
            // 
            resources.ApplyResources(this.apiLabel1, "apiLabel1");
            this.apiLabel1.BackColor = System.Drawing.Color.Wheat;
            this.apiLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.apiLabel1.HelpContextID = 0;
            this.apiLabel1.Name = "apiLabel1";
            // 
            // apiTGrid1
            // 
            resources.ApplyResources(this.apiTGrid1, "apiTGrid1");
            this.apiTGrid1.FilterBar = true;
            this.apiTGrid1.FooterBar = true;
            this.apiTGrid1.Name = "apiTGrid1";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.Label5);
            this.panel2.Controls.Add(this.apiTGridChaff);
            this.panel2.Name = "panel2";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.apiLabel2);
            this.panel1.Controls.Add(this.apiTGrid2);
            this.panel1.Name = "panel1";
            // 
            // apiLabel2
            // 
            resources.ApplyResources(this.apiLabel2, "apiLabel2");
            this.apiLabel2.BackColor = System.Drawing.Color.Wheat;
            this.apiLabel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.apiLabel2.HelpContextID = 0;
            this.apiLabel2.Name = "apiLabel2";
            // 
            // apiTGrid2
            // 
            resources.ApplyResources(this.apiTGrid2, "apiTGrid2");
            this.apiTGrid2.FilterBar = true;
            this.apiTGrid2.FooterBar = true;
            this.apiTGrid2.Name = "apiTGrid2";
            // 
            // BtnDetailDI
            // 
            resources.ApplyResources(this.BtnDetailDI, "BtnDetailDI");
            this.BtnDetailDI.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnDetailDI.HelpContextID = 0;
            this.BtnDetailDI.Name = "BtnDetailDI";
            this.BtnDetailDI.Tag = "66";
            this.BtnDetailDI.UseVisualStyleBackColor = true;
            this.BtnDetailDI.Click += new System.EventHandler(this.BtnDetailDI_Click);
            // 
            // frmListeRappelDevisWebAttente
            // 
            this.BackColor = System.Drawing.Color.Wheat;
            this.CancelButton = this.cmdQuitter;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.BtnDetailDI);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.cmdQuitter);
            this.Controls.Add(this.cmdDetail);
            this.Controls.Add(this.apiTGrid);
            this.Controls.Add(this.Label1);
            this.Name = "frmListeRappelDevisWebAttente";
            this.ShowInTaskbar = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmListeRappelDevisWebAttente_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiButton cmdDetail;
    private MozartUC.apiTGrid apiTGrid;
    private MozartUC.apiTGrid apiTGridChaff;
    private MozartUC.apiLabel Label5;
    private MozartUC.apiLabel Label1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Panel panel3;
    private MozartUC.apiLabel apiLabel1;
    private MozartUC.apiTGrid apiTGrid1;
    private System.Windows.Forms.Panel panel1;
    private MozartUC.apiLabel apiLabel2;
    private MozartUC.apiTGrid apiTGrid2;
        private MozartUC.apiButton BtnDetailDI;
    }
}
