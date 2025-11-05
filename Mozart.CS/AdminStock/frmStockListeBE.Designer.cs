namespace MozartCS
{
  partial class frmStockListeBE
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockListeBE));
      this.ChkOnlyPlanif = new MozartUC.apiCheckBox();
      this.cmdFermer = new MozartUC.apiButton();
      this.cmdVisu = new MozartUC.apiButton();
      this.apiTGridB = new MozartUC.apiTGrid();
      this.apiTGridH = new MozartUC.apiTGrid();
      this.Label10 = new MozartUC.apiLabel();
      this.Label14 = new MozartUC.apiLabel();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.panel1 = new System.Windows.Forms.Panel();
      this.panel2 = new System.Windows.Forms.Panel();
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
      this.ChkOnlyPlanif.CheckedChanged += new System.EventHandler(this.chkOnlyPlanif_CheckedChanged);
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
      // cmdVisu
      // 
      this.cmdVisu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      this.cmdVisu.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdVisu.HelpContextID = 0;
      resources.ApplyResources(this.cmdVisu, "cmdVisu");
      this.cmdVisu.Name = "cmdVisu";
      this.cmdVisu.Tag = "4";
      this.cmdVisu.UseVisualStyleBackColor = false;
      this.cmdVisu.Click += new System.EventHandler(this.cmdVisu_Click);
      // 
      // apiTGridB
      // 
      resources.ApplyResources(this.apiTGridB, "apiTGridB");
      this.apiTGridB.FilterBar = true;
      this.apiTGridB.FooterBar = true;
      this.apiTGridB.Name = "apiTGridB";
      // 
      // apiTGridH
      // 
      resources.ApplyResources(this.apiTGridH, "apiTGridH");
      this.apiTGridH.FilterBar = true;
      this.apiTGridH.FooterBar = true;
      this.apiTGridH.Name = "apiTGridH";
      this.apiTGridH.ClickE += new MozartUC.apiTGrid.ClickEEventHandler(this.apiTGridH_Click);
      this.apiTGridH.RowCellStyle += new MozartUC.apiTGrid.RowCellStyleEventHandler(this.apiTGridH_RowCellStyle);
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
      this.panel1.Controls.Add(this.Label14);
      this.panel1.Controls.Add(this.ChkOnlyPlanif);
      this.panel1.Controls.Add(this.apiTGridH);
      this.panel1.Name = "panel1";
      // 
      // panel2
      // 
      resources.ApplyResources(this.panel2, "panel2");
      this.panel2.Controls.Add(this.apiTGridB);
      this.panel2.Controls.Add(this.Label10);
      this.panel2.Name = "panel2";
      // 
      // frmStockListeBE
      // 
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.tableLayoutPanel1);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.cmdVisu);
      this.Name = "frmStockListeBE";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmStockListeBE_Load);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private MozartUC.apiCheckBox ChkOnlyPlanif;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiButton cmdVisu;
    private MozartUC.apiTGrid apiTGridB;
    private MozartUC.apiTGrid apiTGridH;
    private MozartUC.apiLabel Label10;
    private MozartUC.apiLabel Label14;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel2;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
