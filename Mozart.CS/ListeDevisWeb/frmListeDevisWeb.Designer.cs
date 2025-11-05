namespace MozartCS
{
  partial class frmListeDevisWeb
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListeDevisWeb));
      this.cmdForm = new MozartUC.apiButton();
      this.cmdValide = new MozartUC.apiButton();
      this.cmdAnnule = new MozartUC.apiButton();
      this.cboDI = new System.Windows.Forms.ComboBox();
      this.Label3 = new MozartUC.apiLabel();
      this.Label2 = new MozartUC.apiLabel();
      this.FrameWeb = new MozartUC.apiGroupBox();
      this.CmdListeDevisArchTech = new MozartUC.apiButton();
      this.cmdVisu = new MozartUC.apiButton();
      this.cmdSupprimer = new MozartUC.apiButton();
      this.cmdQuitter = new MozartUC.apiButton();
      this.cmdValider = new MozartUC.apiButton();
      this.apiTGrid = new MozartUC.apiTGrid();
      this.apiTGridClients = new MozartUC.apiTGrid();
      this.apiTGridChaff = new MozartUC.apiTGrid();
      this.Label5 = new MozartUC.apiLabel();
      this.Label4 = new MozartUC.apiLabel();
      this.Label1 = new MozartUC.apiLabel();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.panel1 = new System.Windows.Forms.Panel();
      this.panel2 = new System.Windows.Forms.Panel();
      this.BtnDevisAttente = new MozartUC.apiButton();
      this.FrameWeb.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // cmdForm
      // 
      resources.ApplyResources(this.cmdForm, "cmdForm");
      this.cmdForm.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdForm.HelpContextID = 404;
      this.cmdForm.Name = "cmdForm";
      this.cmdForm.UseVisualStyleBackColor = true;
      this.cmdForm.Click += new System.EventHandler(this.cmdForm_Click);
      // 
      // cmdValide
      // 
      this.cmdValide.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdValide.HelpContextID = 0;
      resources.ApplyResources(this.cmdValide, "cmdValide");
      this.cmdValide.Name = "cmdValide";
      this.cmdValide.UseVisualStyleBackColor = true;
      this.cmdValide.Click += new System.EventHandler(this.cmdValide_Click);
      // 
      // cmdAnnule
      // 
      this.cmdAnnule.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdAnnule.HelpContextID = 0;
      resources.ApplyResources(this.cmdAnnule, "cmdAnnule");
      this.cmdAnnule.Name = "cmdAnnule";
      this.cmdAnnule.UseVisualStyleBackColor = true;
      this.cmdAnnule.Click += new System.EventHandler(this.cmdAnnule_Click);
      // 
      // cboDI
      // 
      this.cboDI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      resources.ApplyResources(this.cboDI, "cboDI");
      this.cboDI.Name = "cboDI";
      // 
      // Label3
      // 
      this.Label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.Label3, "Label3");
      this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label3.HelpContextID = 0;
      this.Label3.Name = "Label3";
      // 
      // Label2
      // 
      this.Label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.Label2, "Label2");
      this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label2.HelpContextID = 0;
      this.Label2.Name = "Label2";
      // 
      // FrameWeb
      // 
      this.FrameWeb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
      this.FrameWeb.Controls.Add(this.cmdValide);
      this.FrameWeb.Controls.Add(this.cmdAnnule);
      this.FrameWeb.Controls.Add(this.Label3);
      this.FrameWeb.Controls.Add(this.Label2);
      this.FrameWeb.Controls.Add(this.cboDI);
      resources.ApplyResources(this.FrameWeb, "FrameWeb");
      this.FrameWeb.FrameColor = System.Drawing.Color.Empty;
      this.FrameWeb.HelpContextID = 0;
      this.FrameWeb.Name = "FrameWeb";
      this.FrameWeb.TabStop = false;
      // 
      // CmdListeDevisArchTech
      // 
      resources.ApplyResources(this.CmdListeDevisArchTech, "CmdListeDevisArchTech");
      this.CmdListeDevisArchTech.ForeColor = System.Drawing.SystemColors.ControlText;
      this.CmdListeDevisArchTech.HelpContextID = 0;
      this.CmdListeDevisArchTech.Name = "CmdListeDevisArchTech";
      this.CmdListeDevisArchTech.UseVisualStyleBackColor = true;
      this.CmdListeDevisArchTech.Click += new System.EventHandler(this.CmdListeDevisArchTech_Click);
      // 
      // cmdVisu
      // 
      resources.ApplyResources(this.cmdVisu, "cmdVisu");
      this.cmdVisu.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdVisu.HelpContextID = 0;
      this.cmdVisu.Name = "cmdVisu";
      this.cmdVisu.Tag = "4";
      this.cmdVisu.UseVisualStyleBackColor = true;
      this.cmdVisu.Click += new System.EventHandler(this.CmdVisu_Click);
      // 
      // cmdSupprimer
      // 
      this.cmdSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.cmdSupprimer, "cmdSupprimer");
      this.cmdSupprimer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdSupprimer.HelpContextID = 0;
      this.cmdSupprimer.Name = "cmdSupprimer";
      this.cmdSupprimer.Tag = "27";
      this.cmdSupprimer.UseVisualStyleBackColor = false;
      this.cmdSupprimer.Click += new System.EventHandler(this.cmdSupprimer_Click);
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
      // apiTGrid
      // 
      resources.ApplyResources(this.apiTGrid, "apiTGrid");
      this.apiTGrid.FilterBar = true;
      this.apiTGrid.FooterBar = true;
      this.apiTGrid.Name = "apiTGrid";
      // 
      // apiTGridClients
      // 
      resources.ApplyResources(this.apiTGridClients, "apiTGridClients");
      this.apiTGridClients.FilterBar = true;
      this.apiTGridClients.FooterBar = true;
      this.apiTGridClients.Name = "apiTGridClients";
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
      // Label4
      // 
      resources.ApplyResources(this.Label4, "Label4");
      this.Label4.BackColor = System.Drawing.Color.Wheat;
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
      this.panel1.Controls.Add(this.Label4);
      this.panel1.Controls.Add(this.apiTGridClients);
      this.panel1.Name = "panel1";
      // 
      // panel2
      // 
      resources.ApplyResources(this.panel2, "panel2");
      this.panel2.Controls.Add(this.Label5);
      this.panel2.Controls.Add(this.apiTGridChaff);
      this.panel2.Name = "panel2";
      // 
      // BtnDevisAttente
      // 
      this.BtnDevisAttente.BackColor = System.Drawing.Color.Yellow;
      resources.ApplyResources(this.BtnDevisAttente, "BtnDevisAttente");
      this.BtnDevisAttente.ForeColor = System.Drawing.SystemColors.ControlText;
      this.BtnDevisAttente.HelpContextID = 427;
      this.BtnDevisAttente.Name = "BtnDevisAttente";
      this.BtnDevisAttente.UseVisualStyleBackColor = false;
      this.BtnDevisAttente.Click += new System.EventHandler(this.BtnDevisAttente_Click);
      // 
      // frmListeDevisWeb
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdQuitter;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.BtnDevisAttente);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Controls.Add(this.FrameWeb);
      this.Controls.Add(this.cmdForm);
      this.Controls.Add(this.CmdListeDevisArchTech);
      this.Controls.Add(this.cmdVisu);
      this.Controls.Add(this.cmdSupprimer);
      this.Controls.Add(this.cmdQuitter);
      this.Controls.Add(this.cmdValider);
      this.Controls.Add(this.apiTGrid);
      this.Controls.Add(this.Label1);
      this.Name = "frmListeDevisWeb";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmListeDevisWeb_Load);
      this.FrameWeb.ResumeLayout(false);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdForm;
    private MozartUC.apiButton cmdValide;
    private MozartUC.apiButton cmdAnnule;
    private System.Windows.Forms.ComboBox cboDI;
    private MozartUC.apiLabel Label3;
    private MozartUC.apiLabel Label2;
    private MozartUC.apiGroupBox FrameWeb;
    private MozartUC.apiButton CmdListeDevisArchTech;
    private MozartUC.apiButton cmdVisu;
    private MozartUC.apiButton cmdSupprimer;
    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiTGrid apiTGrid;
    private MozartUC.apiTGrid apiTGridClients;
    private MozartUC.apiTGrid apiTGridChaff;
    private MozartUC.apiLabel Label5;
    private MozartUC.apiLabel Label4;
    private MozartUC.apiLabel Label1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel2;
    private MozartUC.apiButton BtnDevisAttente;
  }
}
