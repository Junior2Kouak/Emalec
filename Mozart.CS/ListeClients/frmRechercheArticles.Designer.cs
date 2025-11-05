namespace MozartCS
{
  partial class frmRechercheArticles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRechercheArticles));
            this.apiToolTip1 = new MozartUC.apiTooltip();
            this.ChkStockOut = new MozartUC.apiCheckBox();
            this.cmdSupp = new MozartUC.apiButton();
            this.cmdAjouter = new MozartUC.apiButton();
            this.chkStock = new MozartUC.apiCheckBox();
            this.cmdFermer = new MozartUC.apiButton();
            this.cmdValider = new MozartUC.apiButton();
            this.apiTGrid1 = new MozartUC.apiTGrid();
            this.lblQteStock = new MozartUC.apiLabel();
            this.Frame1 = new MozartUC.apiGroupBox();
            this.ucSelectArticle = new MozartNet.UCSelectArticle();
            this.apiTGrid2 = new MozartUC.apiTGrid();
            this.txtHT = new MozartUC.apiTextBox();
            this.lblLabels6 = new MozartUC.apiLabel();
            this.Frame2 = new MozartUC.apiGroupBox();
            this.CmdImgHautNext = new MozartUC.apiButton();
            this.CmdImgHautLast = new MozartUC.apiButton();
            this.ImageFournitureH = new System.Windows.Forms.PictureBox();
            this.FrameImgFouHaut = new MozartUC.apiGroupBox();
            this.CmdImgBasLast = new MozartUC.apiButton();
            this.CmdImgBasNext = new MozartUC.apiButton();
            this.ImageFournitureB = new System.Windows.Forms.PictureBox();
            this.FrameImgFouBas = new MozartUC.apiGroupBox();
            this.Label1 = new MozartUC.apiLabel();
            this.cmdDetails = new MozartUC.apiButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkPrixClient = new MozartUC.apiCheckBox();
            this.Frame1.SuspendLayout();
            this.Frame2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageFournitureH)).BeginInit();
            this.FrameImgFouHaut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageFournitureB)).BeginInit();
            this.FrameImgFouBas.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // apiToolTip1
            // 
            this.apiToolTip1.BackColor = System.Drawing.Color.SteelBlue;
            this.apiToolTip1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.apiToolTip1.hwnd = ((long)(0));
            resources.ApplyResources(this.apiToolTip1, "apiToolTip1");
            this.apiToolTip1.Name = "apiToolTip1";
            this.apiToolTip1.NbLignes = 0;
            this.apiToolTip1.Texte = null;
            this.apiToolTip1.TexteBox = null;
            this.apiToolTip1.Titre = null;
            // 
            // ChkStockOut
            // 
            this.ChkStockOut.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.ChkStockOut, "ChkStockOut");
            this.ChkStockOut.ForeColor = System.Drawing.Color.Black;
            this.ChkStockOut.HelpContextID = 0;
            this.ChkStockOut.Name = "ChkStockOut";
            this.ChkStockOut.UseVisualStyleBackColor = false;
            this.ChkStockOut.CheckedChanged += new System.EventHandler(this.ChkStockOut_CheckedChanged);
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
            // chkStock
            // 
            this.chkStock.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.chkStock, "chkStock");
            this.chkStock.ForeColor = System.Drawing.Color.Black;
            this.chkStock.HelpContextID = 0;
            this.chkStock.Name = "chkStock";
            this.chkStock.UseVisualStyleBackColor = false;
            this.chkStock.CheckedChanged += new System.EventHandler(this.chkStock_CheckedChanged);
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
            // apiTGrid1
            // 
            resources.ApplyResources(this.apiTGrid1, "apiTGrid1");
            this.apiTGrid1.FilterBar = true;
            this.apiTGrid1.FooterBar = true;
            this.apiTGrid1.ForeColor = System.Drawing.Color.Black;
            this.apiTGrid1.Name = "apiTGrid1";
            this.apiTGrid1.DoubleClickE += new MozartUC.apiTGrid.DoubleClickEEventHandler(this.apiTGrid1_DoubleClickE);
            this.apiTGrid1.RowStyle += new MozartUC.apiTGrid.RowStyleEventHandler(this.apiTGrid1_RowStyle);
            this.apiTGrid1.SelectionChanged += new MozartUC.apiTGrid.SelectionChangedEventHandler(this.apiTGrid1_SelectionChanged);
            // 
            // lblQteStock
            // 
            resources.ApplyResources(this.lblQteStock, "lblQteStock");
            this.lblQteStock.BackColor = System.Drawing.Color.Transparent;
            this.lblQteStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.lblQteStock.HelpContextID = 0;
            this.lblQteStock.Name = "lblQteStock";
            // 
            // Frame1
            // 
            resources.ApplyResources(this.Frame1, "Frame1");
            this.Frame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
            this.Frame1.Controls.Add(this.apiTGrid1);
            this.Frame1.Controls.Add(this.lblQteStock);
            this.Frame1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Frame1.FrameColor = System.Drawing.Color.Empty;
            this.Frame1.HelpContextID = 0;
            this.Frame1.Name = "Frame1";
            this.Frame1.TabStop = false;
            // 
            // ucSelectArticle
            // 
            resources.ApplyResources(this.ucSelectArticle, "ucSelectArticle");
            this.ucSelectArticle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(218)))), ((int)(((byte)(242)))));
            this.ucSelectArticle.Name = "ucSelectArticle";
            this.ucSelectArticle.SearchResult += new MozartNet.UCSelectArticle.SearchResultEventHandler(this.ucSelectArticle_SearchResult);
            // 
            // apiTGrid2
            // 
            resources.ApplyResources(this.apiTGrid2, "apiTGrid2");
            this.apiTGrid2.FilterBar = true;
            this.apiTGrid2.FooterBar = true;
            this.apiTGrid2.ForeColor = System.Drawing.Color.Black;
            this.apiTGrid2.Name = "apiTGrid2";
            this.apiTGrid2.SelectionChanged += new MozartUC.apiTGrid.SelectionChangedEventHandler(this.apiTGrid2_SelectionChanged);
            this.apiTGrid2.CellValueChanged += new MozartUC.apiTGrid.CellValueChangedEventHandler(this.apiTGrid2_CellValueChanged);
            // 
            // txtHT
            // 
            resources.ApplyResources(this.txtHT, "txtHT");
            this.txtHT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtHT.HelpContextID = 0;
            this.txtHT.Name = "txtHT";
            // 
            // lblLabels6
            // 
            resources.ApplyResources(this.lblLabels6, "lblLabels6");
            this.lblLabels6.BackColor = System.Drawing.Color.Transparent;
            this.lblLabels6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLabels6.HelpContextID = 0;
            this.lblLabels6.Name = "lblLabels6";
            // 
            // Frame2
            // 
            resources.ApplyResources(this.Frame2, "Frame2");
            this.Frame2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
            this.Frame2.Controls.Add(this.apiTGrid2);
            this.Frame2.Controls.Add(this.txtHT);
            this.Frame2.Controls.Add(this.lblLabels6);
            this.Frame2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Frame2.FrameColor = System.Drawing.Color.Empty;
            this.Frame2.HelpContextID = 0;
            this.Frame2.Name = "Frame2";
            this.Frame2.TabStop = false;
            // 
            // CmdImgHautNext
            // 
            this.CmdImgHautNext.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CmdImgHautNext.HelpContextID = 0;
            resources.ApplyResources(this.CmdImgHautNext, "CmdImgHautNext");
            this.CmdImgHautNext.Name = "CmdImgHautNext";
            this.CmdImgHautNext.UseVisualStyleBackColor = true;
            this.CmdImgHautNext.Click += new System.EventHandler(this.CmdImgHautNext_Click);
            // 
            // CmdImgHautLast
            // 
            this.CmdImgHautLast.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CmdImgHautLast.HelpContextID = 0;
            resources.ApplyResources(this.CmdImgHautLast, "CmdImgHautLast");
            this.CmdImgHautLast.Name = "CmdImgHautLast";
            this.CmdImgHautLast.UseVisualStyleBackColor = true;
            this.CmdImgHautLast.Click += new System.EventHandler(this.CmdImgHautLast_Click);
            // 
            // ImageFournitureH
            // 
            resources.ApplyResources(this.ImageFournitureH, "ImageFournitureH");
            this.ImageFournitureH.Name = "ImageFournitureH";
            this.ImageFournitureH.TabStop = false;
            // 
            // FrameImgFouHaut
            // 
            resources.ApplyResources(this.FrameImgFouHaut, "FrameImgFouHaut");
            this.FrameImgFouHaut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.FrameImgFouHaut.Controls.Add(this.CmdImgHautNext);
            this.FrameImgFouHaut.Controls.Add(this.CmdImgHautLast);
            this.FrameImgFouHaut.Controls.Add(this.ImageFournitureH);
            this.FrameImgFouHaut.FrameColor = System.Drawing.Color.Empty;
            this.FrameImgFouHaut.HelpContextID = 0;
            this.FrameImgFouHaut.Name = "FrameImgFouHaut";
            this.FrameImgFouHaut.TabStop = false;
            // 
            // CmdImgBasLast
            // 
            this.CmdImgBasLast.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CmdImgBasLast.HelpContextID = 0;
            resources.ApplyResources(this.CmdImgBasLast, "CmdImgBasLast");
            this.CmdImgBasLast.Name = "CmdImgBasLast";
            this.CmdImgBasLast.UseVisualStyleBackColor = true;
            this.CmdImgBasLast.Click += new System.EventHandler(this.CmdImgBasLast_Click);
            // 
            // CmdImgBasNext
            // 
            this.CmdImgBasNext.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CmdImgBasNext.HelpContextID = 0;
            resources.ApplyResources(this.CmdImgBasNext, "CmdImgBasNext");
            this.CmdImgBasNext.Name = "CmdImgBasNext";
            this.CmdImgBasNext.UseVisualStyleBackColor = true;
            this.CmdImgBasNext.Click += new System.EventHandler(this.CmdImgBasNext_Click);
            // 
            // ImageFournitureB
            // 
            resources.ApplyResources(this.ImageFournitureB, "ImageFournitureB");
            this.ImageFournitureB.Name = "ImageFournitureB";
            this.ImageFournitureB.TabStop = false;
            // 
            // FrameImgFouBas
            // 
            resources.ApplyResources(this.FrameImgFouBas, "FrameImgFouBas");
            this.FrameImgFouBas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.FrameImgFouBas.Controls.Add(this.CmdImgBasLast);
            this.FrameImgFouBas.Controls.Add(this.CmdImgBasNext);
            this.FrameImgFouBas.Controls.Add(this.ImageFournitureB);
            this.FrameImgFouBas.FrameColor = System.Drawing.Color.Empty;
            this.FrameImgFouBas.HelpContextID = 0;
            this.FrameImgFouBas.Name = "FrameImgFouBas";
            this.FrameImgFouBas.TabStop = false;
            // 
            // Label1
            // 
            resources.ApplyResources(this.Label1, "Label1");
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Label1.HelpContextID = 0;
            this.Label1.Name = "Label1";
            // 
            // cmdDetails
            // 
            resources.ApplyResources(this.cmdDetails, "cmdDetails");
            this.cmdDetails.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdDetails.HelpContextID = 0;
            this.cmdDetails.Name = "cmdDetails";
            this.cmdDetails.Tag = "66";
            this.cmdDetails.UseVisualStyleBackColor = true;
            this.cmdDetails.Click += new System.EventHandler(this.cmdDetails_Click);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(218)))), ((int)(((byte)(242)))));
            this.panel1.Controls.Add(this.chkPrixClient);
            this.panel1.Controls.Add(this.chkStock);
            this.panel1.Controls.Add(this.ChkStockOut);
            this.panel1.Name = "panel1";
            // 
            // chkPrixClient
            // 
            this.chkPrixClient.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.chkPrixClient, "chkPrixClient");
            this.chkPrixClient.ForeColor = System.Drawing.Color.Black;
            this.chkPrixClient.HelpContextID = 0;
            this.chkPrixClient.Name = "chkPrixClient";
            this.chkPrixClient.UseVisualStyleBackColor = false;
            this.chkPrixClient.CheckedChanged += new System.EventHandler(this.chkPrixClient_CheckedChanged);
            // 
            // frmRechercheArticles
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.CancelButton = this.cmdFermer;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucSelectArticle);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.cmdDetails);
            this.Controls.Add(this.apiToolTip1);
            this.Controls.Add(this.cmdSupp);
            this.Controls.Add(this.cmdAjouter);
            this.Controls.Add(this.cmdFermer);
            this.Controls.Add(this.cmdValider);
            this.Controls.Add(this.Frame1);
            this.Controls.Add(this.Frame2);
            this.Controls.Add(this.FrameImgFouHaut);
            this.Controls.Add(this.FrameImgFouBas);
            this.KeyPreview = true;
            this.Name = "frmRechercheArticles";
            this.ShowInTaskbar = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRechercheArticles_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmRechercheArticles_KeyUp);
            this.Frame1.ResumeLayout(false);
            this.Frame1.PerformLayout();
            this.Frame2.ResumeLayout(false);
            this.Frame2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageFournitureH)).EndInit();
            this.FrameImgFouHaut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImageFournitureB)).EndInit();
            this.FrameImgFouBas.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private MozartUC.apiTooltip apiToolTip1;
    private MozartUC.apiCheckBox ChkStockOut;
    private MozartUC.apiButton cmdSupp;
    private MozartUC.apiButton cmdAjouter;
    private MozartUC.apiCheckBox chkStock;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiTGrid apiTGrid1;
    private MozartUC.apiLabel lblQteStock;
    private MozartUC.apiGroupBox Frame1;
    private MozartUC.apiTGrid apiTGrid2;
    private MozartUC.apiTextBox txtHT;
    private MozartUC.apiLabel lblLabels6;
    private MozartUC.apiGroupBox Frame2;
    private MozartUC.apiButton CmdImgHautNext;
    private MozartUC.apiButton CmdImgHautLast;
    private System.Windows.Forms.PictureBox ImageFournitureH;
    private MozartUC.apiGroupBox FrameImgFouHaut;
    private MozartUC.apiButton CmdImgBasLast;
    private MozartUC.apiButton CmdImgBasNext;
    private System.Windows.Forms.PictureBox ImageFournitureB;
    private MozartUC.apiGroupBox FrameImgFouBas;
    private MozartUC.apiLabel Label1;
    private MozartUC.apiButton cmdDetails;
    private MozartNet.UCSelectArticle ucSelectArticle;
    private System.Windows.Forms.Panel panel1;
    private MozartUC.apiCheckBox chkPrixClient;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
