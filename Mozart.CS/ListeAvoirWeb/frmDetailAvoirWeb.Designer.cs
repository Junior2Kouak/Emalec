namespace MozartCS
{
  partial class frmDetailAvoirWeb
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetailAvoirWeb));
      this.lblLabels4 = new MozartUC.apiLabel();
      this.txtMessage = new MozartUC.apiTextBox();
      this.cmdValider = new MozartUC.apiButton();
      this.cmdAvoir = new MozartUC.apiButton();
      this.Frame1 = new MozartUC.apiGroupBox();
      this.txtDesc = new MozartUC.apiTextBox();
      this.grdDataGrid = new MozartUC.apiTGrid();
      this.Frame2 = new MozartUC.apiGroupBox();
      this.txtNomClient = new MozartUC.apiTextBox();
      this.txtTotalHT = new MozartUC.apiTextBox();
      this.txtNumFac = new MozartUC.apiTextBox();
      this.txtDateFac = new MozartUC.apiTextBox();
      this.lblLabels18 = new MozartUC.apiLabel();
      this.lblLabels17 = new MozartUC.apiLabel();
      this.lblLabels2 = new MozartUC.apiLabel();
      this.lblLabels1 = new MozartUC.apiLabel();
      this.cmdVisu = new MozartUC.apiButton();
      this.Fram5 = new MozartUC.apiGroupBox();
      this.cmdFermer = new MozartUC.apiButton();
      this.apiTGrid1 = new MozartUC.apiTGrid();
      this.Label1 = new MozartUC.apiLabel();
      this.Frame1.SuspendLayout();
      this.Frame2.SuspendLayout();
      this.SuspendLayout();
      // 
      // lblLabels4
      // 
      this.lblLabels4.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.lblLabels4, "lblLabels4");
      this.lblLabels4.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels4.HelpContextID = 0;
      this.lblLabels4.Name = "lblLabels4";
      // 
      // txtMessage
      // 
      resources.ApplyResources(this.txtMessage, "txtMessage");
      this.txtMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.txtMessage.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtMessage.HelpContextID = 0;
      this.txtMessage.Name = "txtMessage";
      // 
      // cmdValider
      // 
      resources.ApplyResources(this.cmdValider, "cmdValider");
      this.cmdValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.cmdValider.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdValider.HelpContextID = 20;
      this.cmdValider.Name = "cmdValider";
      this.cmdValider.UseVisualStyleBackColor = false;
      this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
      // 
      // cmdAvoir
      // 
      resources.ApplyResources(this.cmdAvoir, "cmdAvoir");
      this.cmdAvoir.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdAvoir.HelpContextID = 28;
      this.cmdAvoir.Name = "cmdAvoir";
      this.cmdAvoir.Tag = "2";
      this.cmdAvoir.UseVisualStyleBackColor = true;
      this.cmdAvoir.Click += new System.EventHandler(this.cmdAvoir_Click);
      // 
      // Frame1
      // 
      resources.ApplyResources(this.Frame1, "Frame1");
      this.Frame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.Frame1.Controls.Add(this.txtDesc);
      this.Frame1.Controls.Add(this.grdDataGrid);
      this.Frame1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Frame1.FrameColor = System.Drawing.Color.Empty;
      this.Frame1.HelpContextID = 0;
      this.Frame1.Name = "Frame1";
      this.Frame1.TabStop = false;
      // 
      // txtDesc
      // 
      resources.ApplyResources(this.txtDesc, "txtDesc");
      this.txtDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.txtDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.txtDesc.HelpContextID = 0;
      this.txtDesc.Name = "txtDesc";
      this.txtDesc.ReadOnly = true;
      // 
      // grdDataGrid
      // 
      resources.ApplyResources(this.grdDataGrid, "grdDataGrid");
      this.grdDataGrid.FilterBar = true;
      this.grdDataGrid.FooterBar = true;
      this.grdDataGrid.Name = "grdDataGrid";
      // 
      // Frame2
      // 
      resources.ApplyResources(this.Frame2, "Frame2");
      this.Frame2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
      this.Frame2.Controls.Add(this.txtNomClient);
      this.Frame2.Controls.Add(this.txtTotalHT);
      this.Frame2.Controls.Add(this.txtNumFac);
      this.Frame2.Controls.Add(this.txtDateFac);
      this.Frame2.Controls.Add(this.lblLabels18);
      this.Frame2.Controls.Add(this.lblLabels17);
      this.Frame2.Controls.Add(this.lblLabels2);
      this.Frame2.Controls.Add(this.lblLabels1);
      this.Frame2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Frame2.FrameColor = System.Drawing.Color.Empty;
      this.Frame2.HelpContextID = 0;
      this.Frame2.Name = "Frame2";
      this.Frame2.TabStop = false;
      // 
      // txtNomClient
      // 
      this.txtNomClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.txtNomClient, "txtNomClient");
      this.txtNomClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
      this.txtNomClient.HelpContextID = 0;
      this.txtNomClient.Name = "txtNomClient";
      // 
      // txtTotalHT
      // 
      this.txtTotalHT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.txtTotalHT, "txtTotalHT");
      this.txtTotalHT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
      this.txtTotalHT.HelpContextID = 0;
      this.txtTotalHT.Name = "txtTotalHT";
      // 
      // txtNumFac
      // 
      this.txtNumFac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.txtNumFac, "txtNumFac");
      this.txtNumFac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
      this.txtNumFac.HelpContextID = 0;
      this.txtNumFac.Name = "txtNumFac";
      // 
      // txtDateFac
      // 
      this.txtDateFac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      resources.ApplyResources(this.txtDateFac, "txtDateFac");
      this.txtDateFac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
      this.txtDateFac.HelpContextID = 0;
      this.txtDateFac.Name = "txtDateFac";
      // 
      // lblLabels18
      // 
      this.lblLabels18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
      resources.ApplyResources(this.lblLabels18, "lblLabels18");
      this.lblLabels18.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels18.HelpContextID = 0;
      this.lblLabels18.Name = "lblLabels18";
      // 
      // lblLabels17
      // 
      this.lblLabels17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
      resources.ApplyResources(this.lblLabels17, "lblLabels17");
      this.lblLabels17.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels17.HelpContextID = 0;
      this.lblLabels17.Name = "lblLabels17";
      // 
      // lblLabels2
      // 
      this.lblLabels2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
      resources.ApplyResources(this.lblLabels2, "lblLabels2");
      this.lblLabels2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels2.HelpContextID = 0;
      this.lblLabels2.Name = "lblLabels2";
      // 
      // lblLabels1
      // 
      this.lblLabels1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
      resources.ApplyResources(this.lblLabels1, "lblLabels1");
      this.lblLabels1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels1.HelpContextID = 0;
      this.lblLabels1.Name = "lblLabels1";
      // 
      // cmdVisu
      // 
      resources.ApplyResources(this.cmdVisu, "cmdVisu");
      this.cmdVisu.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdVisu.HelpContextID = 0;
      this.cmdVisu.Name = "cmdVisu";
      this.cmdVisu.Tag = "4";
      this.cmdVisu.UseVisualStyleBackColor = true;
      this.cmdVisu.Click += new System.EventHandler(this.cmdVisu_Click);
      // 
      // Fram5
      // 
      resources.ApplyResources(this.Fram5, "Fram5");
      this.Fram5.BackColor = System.Drawing.Color.Wheat;
      this.Fram5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Fram5.FrameColor = System.Drawing.Color.Empty;
      this.Fram5.HelpContextID = 0;
      this.Fram5.Name = "Fram5";
      this.Fram5.TabStop = false;
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
      // apiTGrid1
      // 
      resources.ApplyResources(this.apiTGrid1, "apiTGrid1");
      this.apiTGrid1.FilterBar = true;
      this.apiTGrid1.FooterBar = true;
      this.apiTGrid1.Name = "apiTGrid1";
      // 
      // Label1
      // 
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // frmDetailAvoirWeb
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.lblLabels4);
      this.Controls.Add(this.txtMessage);
      this.Controls.Add(this.cmdValider);
      this.Controls.Add(this.cmdAvoir);
      this.Controls.Add(this.Frame1);
      this.Controls.Add(this.Frame2);
      this.Controls.Add(this.cmdVisu);
      this.Controls.Add(this.Fram5);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.apiTGrid1);
      this.Controls.Add(this.Label1);
      this.Name = "frmDetailAvoirWeb";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmDetailAvoirWeb_Load);
      this.Frame1.ResumeLayout(false);
      this.Frame1.PerformLayout();
      this.Frame2.ResumeLayout(false);
      this.Frame2.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdAvoir;
    private MozartUC.apiTextBox txtDesc;
    private MozartUC.apiTGrid grdDataGrid;
    private MozartUC.apiGroupBox Frame1;
    private MozartUC.apiTextBox txtNomClient;
    private MozartUC.apiTextBox txtTotalHT;
    private MozartUC.apiTextBox txtNumFac;
    private MozartUC.apiTextBox txtDateFac;
    private MozartUC.apiLabel lblLabels18;
    private MozartUC.apiLabel lblLabels17;
    private MozartUC.apiLabel lblLabels2;
    private MozartUC.apiLabel lblLabels1;
    private MozartUC.apiGroupBox Frame2;
    private MozartUC.apiButton cmdVisu;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiTextBox txtMessage;
    private MozartUC.apiLabel lblLabels4;
    private MozartUC.apiGroupBox Fram5;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiTGrid apiTGrid1;
    private MozartUC.apiLabel Label1;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
