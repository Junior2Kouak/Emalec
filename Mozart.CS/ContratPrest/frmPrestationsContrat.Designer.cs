namespace MozartCS
{
  partial class frmPrestationsContrat
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrestationsContrat));
      this.apiTGridPrestHisto = new MozartUC.apiTGrid();
      this.FrameHistoPACHAT = new MozartUC.apiGroupBox();
      this.cmdDecocher = new MozartUC.apiButton();
      this.cmdCocher = new MozartUC.apiButton();
      this.apiTGridHaut = new MozartUC.apiTGrid();
      this.Frame1 = new MozartUC.apiGroupBox();
      this.cmdAjouter = new MozartUC.apiButton();
      this.cmdSupp = new MozartUC.apiButton();
      this.apiTGridPrestSaisie = new MozartUC.apiTGrid();
      this.txtTDHT = new MozartUC.apiLabel();
      this.Label3 = new MozartUC.apiLabel();
      this.txtTHT = new MozartUC.apiLabel();
      this.Label2 = new MozartUC.apiLabel();
      this.Frame7 = new MozartUC.apiGroupBox();
      this.cmdValider = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.apiTGrid2 = new MozartUC.apiTGrid();
      this.Label4 = new MozartUC.apiLabel();
      this.Label1 = new MozartUC.apiLabel();
      this.FrameHistoPACHAT.SuspendLayout();
      this.Frame1.SuspendLayout();
      this.Frame7.SuspendLayout();
      this.SuspendLayout();
      // 
      // apiTGridPrestHisto
      // 
      resources.ApplyResources(this.apiTGridPrestHisto, "apiTGridPrestHisto");
      this.apiTGridPrestHisto.FilterBar = true;
      this.apiTGridPrestHisto.FooterBar = true;
      this.apiTGridPrestHisto.ForeColor = System.Drawing.SystemColors.ControlText;
      this.apiTGridPrestHisto.Name = "apiTGridPrestHisto";
      this.apiTGridPrestHisto.RowCellStyle += new MozartUC.apiTGrid.RowCellStyleEventHandler(this.apiTGridPrestHisto_RowCellStyle);
      // 
      // FrameHistoPACHAT
      // 
      resources.ApplyResources(this.FrameHistoPACHAT, "FrameHistoPACHAT");
      this.FrameHistoPACHAT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.FrameHistoPACHAT.Controls.Add(this.apiTGridPrestHisto);
      this.FrameHistoPACHAT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.FrameHistoPACHAT.HelpContextID = 0;
      this.FrameHistoPACHAT.Name = "FrameHistoPACHAT";
      this.FrameHistoPACHAT.TabStop = false;
      // 
      // cmdDecocher
      // 
      this.cmdDecocher.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdDecocher.HelpContextID = 0;
      resources.ApplyResources(this.cmdDecocher, "cmdDecocher");
      this.cmdDecocher.Name = "cmdDecocher";
      this.cmdDecocher.Tag = "15";
      this.cmdDecocher.UseVisualStyleBackColor = true;
      this.cmdDecocher.Click += new System.EventHandler(this.cmdDecocher_Click);
      // 
      // cmdCocher
      // 
      this.cmdCocher.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdCocher.HelpContextID = 0;
      resources.ApplyResources(this.cmdCocher, "cmdCocher");
      this.cmdCocher.Name = "cmdCocher";
      this.cmdCocher.Tag = "15";
      this.cmdCocher.UseVisualStyleBackColor = true;
      this.cmdCocher.Click += new System.EventHandler(this.cmdCocher_Click);
      // 
      // apiTGridHaut
      // 
      resources.ApplyResources(this.apiTGridHaut, "apiTGridHaut");
      this.apiTGridHaut.FilterBar = true;
      this.apiTGridHaut.FooterBar = true;
      this.apiTGridHaut.ForeColor = System.Drawing.SystemColors.ControlText;
      this.apiTGridHaut.Name = "apiTGridHaut";
      this.apiTGridHaut.RowStyle += new MozartUC.apiTGrid.RowStyleEventHandler(this.apiTGridHaut_RowStyle);
      // 
      // Frame1
      // 
      resources.ApplyResources(this.Frame1, "Frame1");
      this.Frame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.Frame1.Controls.Add(this.apiTGridHaut);
      this.Frame1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.Frame1.HelpContextID = 0;
      this.Frame1.Name = "Frame1";
      this.Frame1.TabStop = false;
      // 
      // cmdAjouter
      // 
      resources.ApplyResources(this.cmdAjouter, "cmdAjouter");
      this.cmdAjouter.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdAjouter.HelpContextID = 0;
      this.cmdAjouter.Image = global::MozartCS.Properties.Resources.add_32;
      this.cmdAjouter.Name = "cmdAjouter";
      this.cmdAjouter.Tag = "2";
      this.cmdAjouter.UseVisualStyleBackColor = true;
      this.cmdAjouter.Click += new System.EventHandler(this.cmdAjouter_Click);
      // 
      // cmdSupp
      // 
      resources.ApplyResources(this.cmdSupp, "cmdSupp");
      this.cmdSupp.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdSupp.HelpContextID = 0;
      this.cmdSupp.Image = global::MozartCS.Properties.Resources.delete_32;
      this.cmdSupp.Name = "cmdSupp";
      this.cmdSupp.Tag = "27";
      this.cmdSupp.UseVisualStyleBackColor = true;
      this.cmdSupp.Click += new System.EventHandler(this.cmdSupp_Click);
      // 
      // apiTGridPrestSaisie
      // 
      this.apiTGridPrestSaisie.FilterBar = true;
      this.apiTGridPrestSaisie.FooterBar = true;
      this.apiTGridPrestSaisie.ForeColor = System.Drawing.SystemColors.ControlText;
      resources.ApplyResources(this.apiTGridPrestSaisie, "apiTGridPrestSaisie");
      this.apiTGridPrestSaisie.Name = "apiTGridPrestSaisie";
      this.apiTGridPrestSaisie.ClickE += new MozartUC.apiTGrid.ClickEEventHandler(this.apiTGridPrestSaisie_ClickE);
      this.apiTGridPrestSaisie.RowCellStyle += new MozartUC.apiTGrid.RowCellStyleEventHandler(this.apiTGridPrestSaisie_RowCellStyle);
      this.apiTGridPrestSaisie.CellValueChanging += new MozartUC.apiTGrid.CellValueChangingEventHandler(this.apiTGridPrestSaisie_CellValueChanging);
      this.apiTGridPrestSaisie.CellValueChanged += new MozartUC.apiTGrid.CellValueChangedEventHandler(this.apiTGridPrestSaisie_CellValueChanged);
      // 
      // txtTDHT
      // 
      this.txtTDHT.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.txtTDHT, "txtTDHT");
      this.txtTDHT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.txtTDHT.HelpContextID = 0;
      this.txtTDHT.Name = "txtTDHT";
      // 
      // Label3
      // 
      resources.ApplyResources(this.Label3, "Label3");
      this.Label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label3.HelpContextID = 0;
      this.Label3.Name = "Label3";
      // 
      // txtTHT
      // 
      this.txtTHT.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.txtTHT, "txtTHT");
      this.txtTHT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.txtTHT.HelpContextID = 0;
      this.txtTHT.Name = "txtTHT";
      // 
      // Label2
      // 
      resources.ApplyResources(this.Label2, "Label2");
      this.Label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label2.HelpContextID = 0;
      this.Label2.Name = "Label2";
      // 
      // Frame7
      // 
      resources.ApplyResources(this.Frame7, "Frame7");
      this.Frame7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.Frame7.Controls.Add(this.apiTGridPrestSaisie);
      this.Frame7.Controls.Add(this.txtTDHT);
      this.Frame7.Controls.Add(this.Label3);
      this.Frame7.Controls.Add(this.txtTHT);
      this.Frame7.Controls.Add(this.Label2);
      this.Frame7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.Frame7.HelpContextID = 0;
      this.Frame7.Name = "Frame7";
      this.Frame7.TabStop = false;
      // 
      // cmdValider
      // 
      resources.ApplyResources(this.cmdValider, "cmdValider");
      this.cmdValider.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdValider.HelpContextID = 0;
      this.cmdValider.Name = "cmdValider";
      this.cmdValider.Tag = "66";
      this.cmdValider.UseVisualStyleBackColor = true;
      this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
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
      // apiTGrid2
      // 
      resources.ApplyResources(this.apiTGrid2, "apiTGrid2");
      this.apiTGrid2.FilterBar = true;
      this.apiTGrid2.FooterBar = true;
      this.apiTGrid2.Name = "apiTGrid2";
      this.apiTGrid2.RowCellStyle += new MozartUC.apiTGrid.RowCellStyleEventHandler(this.apiTGrid2_RowCellStyle);
      // 
      // Label4
      // 
      this.Label4.BackColor = System.Drawing.Color.Transparent;
      resources.ApplyResources(this.Label4, "Label4");
      this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label4.HelpContextID = 0;
      this.Label4.Name = "Label4";
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // frmPrestationsContrat
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.FrameHistoPACHAT);
      this.Controls.Add(this.cmdDecocher);
      this.Controls.Add(this.cmdCocher);
      this.Controls.Add(this.Frame1);
      this.Controls.Add(this.cmdAjouter);
      this.Controls.Add(this.apiTGrid2);
      this.Controls.Add(this.cmdSupp);
      this.Controls.Add(this.Frame7);
      this.Controls.Add(this.cmdValider);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.Label4);
      this.Controls.Add(this.Label1);
      this.Name = "frmPrestationsContrat";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmPrestationsContrat_Load);
      this.FrameHistoPACHAT.ResumeLayout(false);
      this.Frame1.ResumeLayout(false);
      this.Frame7.ResumeLayout(false);
      this.Frame7.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiTGrid apiTGridPrestHisto;
    private MozartUC.apiGroupBox FrameHistoPACHAT;
    private MozartUC.apiButton cmdDecocher;
    private MozartUC.apiButton cmdCocher;
    private MozartUC.apiTGrid apiTGridHaut;
    private MozartUC.apiGroupBox Frame1;
    private MozartUC.apiButton cmdAjouter;
    private MozartUC.apiButton cmdSupp;
    private MozartUC.apiTGrid apiTGridPrestSaisie;
    private MozartUC.apiLabel txtTDHT;
    private MozartUC.apiLabel Label3;
    private MozartUC.apiLabel txtTHT;
    private MozartUC.apiLabel Label2;
    private MozartUC.apiGroupBox Frame7;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiTGrid apiTGrid2;
    private MozartUC.apiLabel Label4;
    private MozartUC.apiLabel Label1;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
