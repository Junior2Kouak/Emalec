namespace MozartCS
{
  partial class frmListeArticlesClient
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListeArticlesClient));
      this.apiTGrid = new MozartUC.apiTGrid();
      this.cmdCopyStock = new MozartUC.apiButton();
      this.cmdListeInv = new MozartUC.apiButton();
      this.cmdStockTS = new MozartUC.apiButton();
      this.cmdStock = new MozartUC.apiButton();
      this.cmdInv = new MozartUC.apiButton();
      this.Frame2 = new MozartUC.apiGroupBox();
      this.cmdDesactiver = new MozartUC.apiButton();
      this.cmdActiver = new MozartUC.apiButton();
      this.cmdValider = new MozartUC.apiButton();
      this.cmdNouvelle = new MozartUC.apiButton();
      this.apiTGridC = new MozartUC.apiTGrid();
      this.Frame1 = new MozartUC.apiGroupBox();
      this.cmdFermer = new MozartUC.apiButton();
      this.Label14 = new MozartUC.apiLabel();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.Frame2.SuspendLayout();
      this.Frame1.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // apiTGrid
      // 
      resources.ApplyResources(this.apiTGrid, "apiTGrid");
      this.apiTGrid.FilterBar = true;
      this.apiTGrid.FooterBar = true;
      this.apiTGrid.ForeColor = System.Drawing.SystemColors.ControlText;
      this.apiTGrid.Name = "apiTGrid";
      this.apiTGrid.RowStyle += new MozartUC.apiTGrid.RowStyleEventHandler(this.apiTGrid_RowStyle);
      // 
      // cmdCopyStock
      // 
      resources.ApplyResources(this.cmdCopyStock, "cmdCopyStock");
      this.cmdCopyStock.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdCopyStock.HelpContextID = 196;
      this.cmdCopyStock.Name = "cmdCopyStock";
      this.cmdCopyStock.Tag = "46";
      this.cmdCopyStock.UseVisualStyleBackColor = true;
      this.cmdCopyStock.Click += new System.EventHandler(this.cmdCopyStock_Click);
      // 
      // cmdListeInv
      // 
      this.cmdListeInv.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdListeInv.HelpContextID = 159;
      resources.ApplyResources(this.cmdListeInv, "cmdListeInv");
      this.cmdListeInv.Name = "cmdListeInv";
      this.cmdListeInv.Tag = "84";
      this.cmdListeInv.UseVisualStyleBackColor = true;
      this.cmdListeInv.Click += new System.EventHandler(this.cmdListeInv_Click);
      // 
      // cmdStockTS
      // 
      this.cmdStockTS.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdStockTS.HelpContextID = 158;
      resources.ApplyResources(this.cmdStockTS, "cmdStockTS");
      this.cmdStockTS.Name = "cmdStockTS";
      this.cmdStockTS.Tag = "91";
      this.cmdStockTS.UseVisualStyleBackColor = true;
      this.cmdStockTS.Click += new System.EventHandler(this.cmdStockTS_Click);
      // 
      // cmdStock
      // 
      this.cmdStock.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdStock.HelpContextID = 158;
      resources.ApplyResources(this.cmdStock, "cmdStock");
      this.cmdStock.Name = "cmdStock";
      this.cmdStock.Tag = "91";
      this.cmdStock.UseVisualStyleBackColor = true;
      this.cmdStock.Click += new System.EventHandler(this.cmdStock_Click);
      // 
      // cmdInv
      // 
      this.cmdInv.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdInv.HelpContextID = 159;
      resources.ApplyResources(this.cmdInv, "cmdInv");
      this.cmdInv.Name = "cmdInv";
      this.cmdInv.Tag = "84";
      this.cmdInv.UseVisualStyleBackColor = true;
      this.cmdInv.Click += new System.EventHandler(this.cmdInv_Click);
      // 
      // Frame2
      // 
      resources.ApplyResources(this.Frame2, "Frame2");
      this.Frame2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.Frame2.Controls.Add(this.cmdListeInv);
      this.Frame2.Controls.Add(this.apiTGrid);
      this.Frame2.Controls.Add(this.cmdStockTS);
      this.Frame2.Controls.Add(this.cmdStock);
      this.Frame2.Controls.Add(this.cmdInv);
      this.Frame2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Frame2.HelpContextID = 0;
      this.Frame2.Name = "Frame2";
      this.Frame2.TabStop = false;
      // 
      // cmdDesactiver
      // 
      this.cmdDesactiver.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdDesactiver.HelpContextID = 156;
      resources.ApplyResources(this.cmdDesactiver, "cmdDesactiver");
      this.cmdDesactiver.Name = "cmdDesactiver";
      this.cmdDesactiver.Tag = "90";
      this.cmdDesactiver.UseVisualStyleBackColor = true;
      this.cmdDesactiver.Click += new System.EventHandler(this.cmdDesactiver_Click);
      // 
      // cmdActiver
      // 
      this.cmdActiver.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdActiver.HelpContextID = 156;
      resources.ApplyResources(this.cmdActiver, "cmdActiver");
      this.cmdActiver.Name = "cmdActiver";
      this.cmdActiver.Tag = "89";
      this.cmdActiver.UseVisualStyleBackColor = true;
      this.cmdActiver.Click += new System.EventHandler(this.cmdActiver_Click);
      // 
      // cmdValider
      // 
      this.cmdValider.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdValider.HelpContextID = 156;
      resources.ApplyResources(this.cmdValider, "cmdValider");
      this.cmdValider.Name = "cmdValider";
      this.cmdValider.Tag = "19";
      this.cmdValider.UseVisualStyleBackColor = true;
      this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
      // 
      // cmdNouvelle
      // 
      this.cmdNouvelle.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdNouvelle.HelpContextID = 155;
      resources.ApplyResources(this.cmdNouvelle, "cmdNouvelle");
      this.cmdNouvelle.Name = "cmdNouvelle";
      this.cmdNouvelle.Tag = "2";
      this.cmdNouvelle.UseVisualStyleBackColor = true;
      this.cmdNouvelle.Click += new System.EventHandler(this.cmdNouvelle_Click);
      // 
      // apiTGridC
      // 
      resources.ApplyResources(this.apiTGridC, "apiTGridC");
      this.apiTGridC.FilterBar = true;
      this.apiTGridC.FooterBar = true;
      this.apiTGridC.ForeColor = System.Drawing.SystemColors.ControlText;
      this.apiTGridC.Name = "apiTGridC";
      this.apiTGridC.SelectionChanged += new MozartUC.apiTGrid.SelectionChangedEventHandler(this.apiTGridC_SelectionChanged);
      // 
      // Frame1
      // 
      resources.ApplyResources(this.Frame1, "Frame1");
      this.Frame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.Frame1.Controls.Add(this.cmdDesactiver);
      this.Frame1.Controls.Add(this.cmdActiver);
      this.Frame1.Controls.Add(this.cmdValider);
      this.Frame1.Controls.Add(this.cmdNouvelle);
      this.Frame1.Controls.Add(this.apiTGridC);
      this.Frame1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Frame1.HelpContextID = 0;
      this.Frame1.Name = "Frame1";
      this.Frame1.TabStop = false;
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
      // Label14
      // 
      resources.ApplyResources(this.Label14, "Label14");
      this.Label14.BackColor = System.Drawing.Color.Wheat;
      this.Label14.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label14.HelpContextID = 0;
      this.Label14.Name = "Label14";
      // 
      // tableLayoutPanel1
      // 
      resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
      this.tableLayoutPanel1.Controls.Add(this.Frame2, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.Frame1, 0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      // 
      // frmListeArticlesClient
      // 
      this.AcceptButton = this.cmdFermer;
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.tableLayoutPanel1);
      this.Controls.Add(this.cmdCopyStock);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.Label14);
      this.Name = "frmListeArticlesClient";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmListeArticlesClient_Load);
      this.Frame2.ResumeLayout(false);
      this.Frame1.ResumeLayout(false);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiTGrid apiTGrid;
    private MozartUC.apiButton cmdCopyStock;
    private MozartUC.apiButton cmdListeInv;
    private MozartUC.apiButton cmdStockTS;
    private MozartUC.apiButton cmdStock;
    private MozartUC.apiButton cmdInv;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    private MozartUC.apiGroupBox Frame2;
    private MozartUC.apiButton cmdDesactiver;
    private MozartUC.apiButton cmdActiver;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiButton cmdNouvelle;
    private MozartUC.apiTGrid apiTGridC;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    private MozartUC.apiGroupBox Frame1;
    private MozartUC.apiButton cmdFermer;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    private MozartUC.apiLabel Label14;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
  }
}
