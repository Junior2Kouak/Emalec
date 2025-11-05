namespace MozartCS
{
  partial class frmStockListeReexpedition
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockListeReexpedition));
      this.ChkOnlyPlanif = new MozartUC.apiCheckBox();
      this.cmdBL = new MozartUC.apiButton();
      this.cmdImprimer = new MozartUC.apiButton();
      this.cmdSupp = new MozartUC.apiButton();
      this.apiTGridH = new MozartUC.apiTGrid();
      this.apiTGridB = new MozartUC.apiTGrid();
      this.cmdListeBL = new MozartUC.apiButton();
      this.cmdValider = new MozartUC.apiButton();
      this.cmdDI = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.Label10 = new MozartUC.apiLabel();
      this.Label14 = new MozartUC.apiLabel();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.panel1 = new System.Windows.Forms.Panel();
      this.panel2 = new System.Windows.Forms.Panel();
      this.cmdSchenker = new MozartUC.apiButton();
      this.cmdDPD = new MozartUC.apiButton();
      this.cmdTNT = new MozartUC.apiButton();
      this.tableLayoutPanel1.SuspendLayout();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // ChkOnlyPlanif
      // 
      this.ChkOnlyPlanif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.ChkOnlyPlanif, "ChkOnlyPlanif");
      this.ChkOnlyPlanif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.ChkOnlyPlanif.HelpContextID = 0;
      this.ChkOnlyPlanif.Name = "ChkOnlyPlanif";
      this.ChkOnlyPlanif.UseVisualStyleBackColor = false;
      this.ChkOnlyPlanif.CheckedChanged += new System.EventHandler(this.ChkOnlyPlanif_CheckedChanged);
      // 
      // cmdBL
      // 
      this.cmdBL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      this.cmdBL.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdBL.HelpContextID = 0;
      resources.ApplyResources(this.cmdBL, "cmdBL");
      this.cmdBL.Name = "cmdBL";
      this.cmdBL.Tag = "109";
      this.cmdBL.UseVisualStyleBackColor = false;
      this.cmdBL.Click += new System.EventHandler(this.cmdBL_Click);
      // 
      // cmdImprimer
      // 
      this.cmdImprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      this.cmdImprimer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdImprimer.HelpContextID = 0;
      resources.ApplyResources(this.cmdImprimer, "cmdImprimer");
      this.cmdImprimer.Name = "cmdImprimer";
      this.cmdImprimer.Tag = "17";
      this.cmdImprimer.UseVisualStyleBackColor = false;
      this.cmdImprimer.Click += new System.EventHandler(this.cmdImprimer_Click);
      // 
      // cmdSupp
      // 
      this.cmdSupp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      this.cmdSupp.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdSupp.HelpContextID = 0;
      resources.ApplyResources(this.cmdSupp, "cmdSupp");
      this.cmdSupp.Name = "cmdSupp";
      this.cmdSupp.Tag = "65";
      this.cmdSupp.UseVisualStyleBackColor = false;
      // 
      // apiTGridH
      // 
      resources.ApplyResources(this.apiTGridH, "apiTGridH");
      this.apiTGridH.FilterBar = true;
      this.apiTGridH.FooterBar = true;
      this.apiTGridH.Name = "apiTGridH";
      this.apiTGridH.RowCellStyle += new MozartUC.apiTGrid.RowCellStyleEventHandler(this.apiTGridH_RowCellStyle);
      this.apiTGridH.SelectionChanged += new MozartUC.apiTGrid.SelectionChangedEventHandler(this.apiTGridH_SelectionChanged);
      // 
      // apiTGridB
      // 
      resources.ApplyResources(this.apiTGridB, "apiTGridB");
      this.apiTGridB.FilterBar = true;
      this.apiTGridB.FooterBar = true;
      this.apiTGridB.Name = "apiTGridB";
      // 
      // cmdListeBL
      // 
      this.cmdListeBL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      this.cmdListeBL.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdListeBL.HelpContextID = 0;
      resources.ApplyResources(this.cmdListeBL, "cmdListeBL");
      this.cmdListeBL.Name = "cmdListeBL";
      this.cmdListeBL.Tag = "4";
      this.cmdListeBL.UseVisualStyleBackColor = false;
      this.cmdListeBL.Click += new System.EventHandler(this.cmdListeBL_Click);
      // 
      // cmdValider
      // 
      this.cmdValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      this.cmdValider.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdValider.HelpContextID = 0;
      resources.ApplyResources(this.cmdValider, "cmdValider");
      this.cmdValider.Name = "cmdValider";
      this.cmdValider.Tag = "66";
      this.cmdValider.UseVisualStyleBackColor = false;
      this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
      // 
      // cmdDI
      // 
      this.cmdDI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      this.cmdDI.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdDI.HelpContextID = 0;
      resources.ApplyResources(this.cmdDI, "cmdDI");
      this.cmdDI.Name = "cmdDI";
      this.cmdDI.Tag = "19";
      this.cmdDI.UseVisualStyleBackColor = false;
      this.cmdDI.Click += new System.EventHandler(this.cmdDI_Click);
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      this.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdFermer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Tag = "15";
      this.cmdFermer.UseVisualStyleBackColor = false;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // Label10
      // 
      resources.ApplyResources(this.Label10, "Label10");
      this.Label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
      this.Label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
      this.Label10.HelpContextID = 0;
      this.Label10.Name = "Label10";
      // 
      // Label14
      // 
      resources.ApplyResources(this.Label14, "Label14");
      this.Label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
      this.Label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
      this.Label14.HelpContextID = 0;
      this.Label14.Name = "Label14";
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
      this.panel1.Controls.Add(this.apiTGridH);
      this.panel1.Controls.Add(this.ChkOnlyPlanif);
      this.panel1.Controls.Add(this.Label14);
      this.panel1.Name = "panel1";
      // 
      // panel2
      // 
      resources.ApplyResources(this.panel2, "panel2");
      this.panel2.Controls.Add(this.apiTGridB);
      this.panel2.Controls.Add(this.Label10);
      this.panel2.Name = "panel2";
      // 
      // cmdSchenker
      // 
      this.cmdSchenker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      this.cmdSchenker.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdSchenker.HelpContextID = 0;
      resources.ApplyResources(this.cmdSchenker, "cmdSchenker");
      this.cmdSchenker.Name = "cmdSchenker";
      this.cmdSchenker.Tag = "17";
      this.cmdSchenker.UseVisualStyleBackColor = false;
      this.cmdSchenker.Click += new System.EventHandler(this.cmdSchenker_Click);
      // 
      // cmdDPD
      // 
      this.cmdDPD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      this.cmdDPD.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdDPD.HelpContextID = 0;
      resources.ApplyResources(this.cmdDPD, "cmdDPD");
      this.cmdDPD.Name = "cmdDPD";
      this.cmdDPD.Tag = "17";
      this.cmdDPD.UseVisualStyleBackColor = false;
      this.cmdDPD.Click += new System.EventHandler(this.cmdDPD_Click);
      // 
      // cmdTNT
      // 
      this.cmdTNT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      this.cmdTNT.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdTNT.HelpContextID = 0;
      resources.ApplyResources(this.cmdTNT, "cmdTNT");
      this.cmdTNT.Name = "cmdTNT";
      this.cmdTNT.Tag = "17";
      this.cmdTNT.UseVisualStyleBackColor = false;
      this.cmdTNT.Click += new System.EventHandler(this.cmdTNT_Click);
      // 
      // frmStockListeReexpedition
      // 
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdSchenker);
      this.Controls.Add(this.cmdDPD);
      this.Controls.Add(this.cmdTNT);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Controls.Add(this.cmdBL);
      this.Controls.Add(this.cmdImprimer);
      this.Controls.Add(this.cmdSupp);
      this.Controls.Add(this.cmdListeBL);
      this.Controls.Add(this.cmdValider);
      this.Controls.Add(this.cmdDI);
      this.Controls.Add(this.cmdFermer);
      this.Name = "frmStockListeReexpedition";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmStockListeReexpedition_Load);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private MozartUC.apiCheckBox ChkOnlyPlanif;
    private MozartUC.apiButton cmdBL;
    private MozartUC.apiButton cmdImprimer;
    private MozartUC.apiButton cmdSupp;
    private MozartUC.apiTGrid apiTGridH;
    private MozartUC.apiTGrid apiTGridB;
    private MozartUC.apiButton cmdListeBL;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiButton cmdDI;
    private MozartUC.apiButton cmdFermer;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    private MozartUC.apiLabel Label10;
    private MozartUC.apiLabel Label14;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel2;
    private MozartUC.apiButton cmdSchenker;
    private MozartUC.apiButton cmdDPD;
    private MozartUC.apiButton cmdTNT;
  }
}
