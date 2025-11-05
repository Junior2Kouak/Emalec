namespace MozartCS
{
  partial class frmRelanceST
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelanceST));
      this.cmdOM = new MozartUC.apiButton();
      this.cmdTrav = new MozartUC.apiButton();
      this.cmdDevis = new MozartUC.apiButton();
      this.GridOrdres = new MozartUC.apiTGrid();
      this.Frame3 = new MozartUC.apiGroupBox();
      this.Command1 = new MozartUC.apiButton();
      this.GridTravaux = new MozartUC.apiTGrid();
      this.Frame2 = new MozartUC.apiGroupBox();
      this.GridDevis = new MozartUC.apiTGrid();
      this.Frame1 = new MozartUC.apiGroupBox();
      this.cmdQuitter = new MozartUC.apiButton();
      this.cmdImprimer = new MozartUC.apiButton();
      this.Label1 = new MozartUC.apiLabel();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.panel1 = new System.Windows.Forms.Panel();
      this.panel2 = new System.Windows.Forms.Panel();
      this.panel3 = new System.Windows.Forms.Panel();
      this.Frame3.SuspendLayout();
      this.Frame2.SuspendLayout();
      this.Frame1.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.panel3.SuspendLayout();
      this.SuspendLayout();
      // 
      // cmdOM
      // 
      resources.ApplyResources(this.cmdOM, "cmdOM");
      this.cmdOM.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdOM.HelpContextID = 0;
      this.cmdOM.Name = "cmdOM";
      this.cmdOM.UseVisualStyleBackColor = true;
      this.cmdOM.Click += new System.EventHandler(this.cmdOM_Click);
      // 
      // cmdTrav
      // 
      resources.ApplyResources(this.cmdTrav, "cmdTrav");
      this.cmdTrav.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdTrav.HelpContextID = 0;
      this.cmdTrav.Name = "cmdTrav";
      this.cmdTrav.UseVisualStyleBackColor = true;
      this.cmdTrav.Click += new System.EventHandler(this.cmdTrav_Click);
      // 
      // cmdDevis
      // 
      resources.ApplyResources(this.cmdDevis, "cmdDevis");
      this.cmdDevis.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdDevis.HelpContextID = 0;
      this.cmdDevis.Name = "cmdDevis";
      this.cmdDevis.UseVisualStyleBackColor = true;
      this.cmdDevis.Click += new System.EventHandler(this.cmdDevis_Click);
      // 
      // GridOrdres
      // 
      resources.ApplyResources(this.GridOrdres, "GridOrdres");
      this.GridOrdres.FilterBar = true;
      this.GridOrdres.FooterBar = true;
      this.GridOrdres.Name = "GridOrdres";
      this.GridOrdres.DoubleClickE += new MozartUC.apiTGrid.DoubleClickEEventHandler(this.apiTGrid2_DblClickE);
      // 
      // Frame3
      // 
      resources.ApplyResources(this.Frame3, "Frame3");
      this.Frame3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.Frame3.Controls.Add(this.GridOrdres);
      this.Frame3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Frame3.FrameColor = System.Drawing.Color.Empty;
      this.Frame3.HelpContextID = 0;
      this.Frame3.Name = "Frame3";
      this.Frame3.TabStop = false;
      // 
      // Command1
      // 
      resources.ApplyResources(this.Command1, "Command1");
      this.Command1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Command1.HelpContextID = 0;
      this.Command1.Name = "Command1";
      this.Command1.Tag = "17";
      this.Command1.UseVisualStyleBackColor = true;
      this.Command1.Click += new System.EventHandler(this.Command1_Click);
      // 
      // GridTravaux
      // 
      resources.ApplyResources(this.GridTravaux, "GridTravaux");
      this.GridTravaux.FilterBar = true;
      this.GridTravaux.FooterBar = true;
      this.GridTravaux.Name = "GridTravaux";
      this.GridTravaux.DoubleClickE += new MozartUC.apiTGrid.DoubleClickEEventHandler(this.apiTGrid1_DblClickE);
      // 
      // Frame2
      // 
      resources.ApplyResources(this.Frame2, "Frame2");
      this.Frame2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.Frame2.Controls.Add(this.GridTravaux);
      this.Frame2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Frame2.FrameColor = System.Drawing.Color.Empty;
      this.Frame2.HelpContextID = 0;
      this.Frame2.Name = "Frame2";
      this.Frame2.TabStop = false;
      // 
      // GridDevis
      // 
      resources.ApplyResources(this.GridDevis, "GridDevis");
      this.GridDevis.FilterBar = true;
      this.GridDevis.FooterBar = true;
      this.GridDevis.Name = "GridDevis";
      this.GridDevis.DoubleClickE += new MozartUC.apiTGrid.DoubleClickEEventHandler(this.apiTGrid_DblClickE);
      // 
      // Frame1
      // 
      resources.ApplyResources(this.Frame1, "Frame1");
      this.Frame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.Frame1.Controls.Add(this.GridDevis);
      this.Frame1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Frame1.FrameColor = System.Drawing.Color.Empty;
      this.Frame1.HelpContextID = 0;
      this.Frame1.Name = "Frame1";
      this.Frame1.TabStop = false;
      // 
      // cmdQuitter
      // 
      this.cmdQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      resources.ApplyResources(this.cmdQuitter, "cmdQuitter");
      this.cmdQuitter.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdQuitter.HelpContextID = 0;
      this.cmdQuitter.Name = "cmdQuitter";
      this.cmdQuitter.Tag = "15";
      this.cmdQuitter.UseVisualStyleBackColor = true;
      // 
      // cmdImprimer
      // 
      resources.ApplyResources(this.cmdImprimer, "cmdImprimer");
      this.cmdImprimer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdImprimer.HelpContextID = 0;
      this.cmdImprimer.Name = "cmdImprimer";
      this.cmdImprimer.Tag = "17";
      this.cmdImprimer.UseVisualStyleBackColor = true;
      this.cmdImprimer.Click += new System.EventHandler(this.cmdImprimer_Click);
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
      this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 2);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      // 
      // panel1
      // 
      resources.ApplyResources(this.panel1, "panel1");
      this.panel1.Controls.Add(this.Frame1);
      this.panel1.Controls.Add(this.cmdDevis);
      this.panel1.Name = "panel1";
      // 
      // panel2
      // 
      resources.ApplyResources(this.panel2, "panel2");
      this.panel2.Controls.Add(this.Frame2);
      this.panel2.Controls.Add(this.cmdTrav);
      this.panel2.Name = "panel2";
      // 
      // panel3
      // 
      resources.ApplyResources(this.panel3, "panel3");
      this.panel3.Controls.Add(this.Frame3);
      this.panel3.Controls.Add(this.cmdOM);
      this.panel3.Name = "panel3";
      // 
      // frmRelanceST
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdQuitter;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.tableLayoutPanel1);
      this.Controls.Add(this.Command1);
      this.Controls.Add(this.cmdQuitter);
      this.Controls.Add(this.cmdImprimer);
      this.Controls.Add(this.Label1);
      this.Name = "frmRelanceST";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmRelanceST_Load);
      this.Frame3.ResumeLayout(false);
      this.Frame2.ResumeLayout(false);
      this.Frame1.ResumeLayout(false);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.panel3.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdOM;
    private MozartUC.apiButton cmdTrav;
    private MozartUC.apiButton cmdDevis;
    private MozartUC.apiTGrid GridOrdres;
    private MozartUC.apiGroupBox Frame3;
    private MozartUC.apiButton Command1;
    private MozartUC.apiTGrid GridTravaux;
    private MozartUC.apiGroupBox Frame2;
    private MozartUC.apiTGrid GridDevis;
    private MozartUC.apiGroupBox Frame1;
    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiButton cmdImprimer;
    private MozartUC.apiLabel Label1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Panel panel3;
  }
}
