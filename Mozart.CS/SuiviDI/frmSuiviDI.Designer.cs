namespace MozartCS
{
  partial class frmSuiviDI
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSuiviDI));
      this.ApiGrid = new MozartUC.apiTGrid();
      this.Frame1 = new MozartUC.apiGroupBox();
      this.ApiGrid1 = new MozartUC.apiTGrid();
      this.Frame2 = new MozartUC.apiGroupBox();
      this.Label2 = new MozartUC.apiLabel();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.panel1 = new System.Windows.Forms.Panel();
      this.panel2 = new System.Windows.Forms.Panel();
      this.cmdQuitter = new MozartUC.apiButton();
      this.cmdDetailsNonExec = new MozartUC.apiButton();
      this.cmdDetailNonPlanif = new MozartUC.apiButton();
      this.Frame1.SuspendLayout();
      this.Frame2.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // ApiGrid
      // 
      resources.ApplyResources(this.ApiGrid, "ApiGrid");
      this.ApiGrid.FilterBar = true;
      this.ApiGrid.FooterBar = true;
      this.ApiGrid.Name = "ApiGrid";
      this.ApiGrid.DoubleClickE += new MozartUC.apiTGrid.DoubleClickEEventHandler(this.ApiGrid_DoubleClickE);
      // 
      // Frame1
      // 
      resources.ApplyResources(this.Frame1, "Frame1");
      this.Frame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.Frame1.Controls.Add(this.ApiGrid);
      this.Frame1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
      this.Frame1.HelpContextID = 0;
      this.Frame1.Name = "Frame1";
      this.Frame1.TabStop = false;
      // 
      // ApiGrid1
      // 
      resources.ApplyResources(this.ApiGrid1, "ApiGrid1");
      this.ApiGrid1.FilterBar = true;
      this.ApiGrid1.FooterBar = true;
      this.ApiGrid1.Name = "ApiGrid1";
      this.ApiGrid1.DoubleClickE += new MozartUC.apiTGrid.DoubleClickEEventHandler(this.ApiGrid1_DoubleClickE);
      // 
      // Frame2
      // 
      resources.ApplyResources(this.Frame2, "Frame2");
      this.Frame2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.Frame2.Controls.Add(this.ApiGrid1);
      this.Frame2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
      this.Frame2.HelpContextID = 0;
      this.Frame2.Name = "Frame2";
      this.Frame2.TabStop = false;
      // 
      // Label2
      // 
      resources.ApplyResources(this.Label2, "Label2");
      this.Label2.BackColor = System.Drawing.Color.Wheat;
      this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label2.HelpContextID = 0;
      this.Label2.Name = "Label2";
      // 
      // tableLayoutPanel1
      // 
      resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
      this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      // 
      // panel1
      // 
      resources.ApplyResources(this.panel1, "panel1");
      this.panel1.Controls.Add(this.Frame1);
      this.panel1.Name = "panel1";
      // 
      // panel2
      // 
      resources.ApplyResources(this.panel2, "panel2");
      this.panel2.Controls.Add(this.Frame2);
      this.panel2.Name = "panel2";
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
      // cmdDetailsNonExec
      // 
      resources.ApplyResources(this.cmdDetailsNonExec, "cmdDetailsNonExec");
      this.cmdDetailsNonExec.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdDetailsNonExec.HelpContextID = 0;
      this.cmdDetailsNonExec.Name = "cmdDetailsNonExec";
      this.cmdDetailsNonExec.Tag = "";
      this.cmdDetailsNonExec.UseVisualStyleBackColor = true;
      this.cmdDetailsNonExec.Click += new System.EventHandler(this.cmdDetailsNonExec_Click);
      // 
      // cmdDetailNonPlanif
      // 
      resources.ApplyResources(this.cmdDetailNonPlanif, "cmdDetailNonPlanif");
      this.cmdDetailNonPlanif.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdDetailNonPlanif.HelpContextID = 0;
      this.cmdDetailNonPlanif.Name = "cmdDetailNonPlanif";
      this.cmdDetailNonPlanif.Tag = "";
      this.cmdDetailNonPlanif.UseVisualStyleBackColor = true;
      this.cmdDetailNonPlanif.Click += new System.EventHandler(this.cmdDetailNonPlanif_Click);
      // 
      // frmSuiviDI
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdQuitter);
      this.Controls.Add(this.cmdDetailsNonExec);
      this.Controls.Add(this.cmdDetailNonPlanif);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Controls.Add(this.Label2);
      this.Name = "frmSuiviDI";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmSuiviDI_Load);
      this.Frame1.ResumeLayout(false);
      this.Frame2.ResumeLayout(false);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private MozartUC.apiTGrid ApiGrid;
    private MozartUC.apiGroupBox Frame1;
    private MozartUC.apiTGrid ApiGrid1;
    private MozartUC.apiGroupBox Frame2;
    private MozartUC.apiLabel Label2;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel2;
    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiButton cmdDetailsNonExec;
    private MozartUC.apiButton cmdDetailNonPlanif;
  }
}
