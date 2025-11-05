
namespace MozartControls
{
  partial class frmDetailsPlanDeCharge
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetailsPlanDeCharge));
      this.cmdFermer = new MozartUC.apiButton();
      this.apiTGrid1 = new MozartUC.apiTGrid();
      this.btnUp = new System.Windows.Forms.Button();
      this.btnDown = new System.Windows.Forms.Button();
      this.Label1 = new MozartUC.apiLabel();
      this.lblTotEng = new System.Windows.Forms.Label();
      this.lblTotResteAEngage = new System.Windows.Forms.Label();
      this.txtTotResteAEngager = new System.Windows.Forms.TextBox();
      this.txtTotEngage = new System.Windows.Forms.TextBox();
      this.txtTot = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Tag = "15";
      this.cmdFermer.UseVisualStyleBackColor = true;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // apiTGrid1
      // 
      resources.ApplyResources(this.apiTGrid1, "apiTGrid1");
      this.apiTGrid1.FilterBar = false;
      this.apiTGrid1.FooterBar = false;
      this.apiTGrid1.Name = "apiTGrid1";
      this.apiTGrid1.RowCellStyle += new MozartUC.apiTGrid.RowCellStyleEventHandler(this.apiTGrid1_RowCellStyle);
      this.apiTGrid1.RowCellClick += new MozartUC.apiTGrid.RowCellClickEventHandler(this.apiTGrid1_RowCellClick);
      this.apiTGrid1.CellValueChanged += new MozartUC.apiTGrid.CellValueChangedEventHandler(this.apiTGrid1_CellValueChanged);
      // 
      // btnUp
      // 
      resources.ApplyResources(this.btnUp, "btnUp");
      this.btnUp.Image = global::MozartControls.Properties.Resources.arrow_up;
      this.btnUp.Name = "btnUp";
      this.btnUp.UseVisualStyleBackColor = true;
      this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
      // 
      // btnDown
      // 
      resources.ApplyResources(this.btnDown, "btnDown");
      this.btnDown.Image = global::MozartControls.Properties.Resources.arrow_down;
      this.btnDown.Name = "btnDown";
      this.btnDown.UseVisualStyleBackColor = true;
      this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // lblTotEng
      // 
      resources.ApplyResources(this.lblTotEng, "lblTotEng");
      this.lblTotEng.Name = "lblTotEng";
      // 
      // lblTotResteAEngage
      // 
      resources.ApplyResources(this.lblTotResteAEngage, "lblTotResteAEngage");
      this.lblTotResteAEngage.Name = "lblTotResteAEngage";
      // 
      // txtTotResteAEngager
      // 
      resources.ApplyResources(this.txtTotResteAEngager, "txtTotResteAEngager");
      this.txtTotResteAEngager.Name = "txtTotResteAEngager";
      this.txtTotResteAEngager.ReadOnly = true;
      // 
      // txtTotEngage
      // 
      resources.ApplyResources(this.txtTotEngage, "txtTotEngage");
      this.txtTotEngage.Name = "txtTotEngage";
      this.txtTotEngage.ReadOnly = true;
      // 
      // txtTot
      // 
      resources.ApplyResources(this.txtTot, "txtTot");
      this.txtTot.Name = "txtTot";
      this.txtTot.ReadOnly = true;
      // 
      // label2
      // 
      resources.ApplyResources(this.label2, "label2");
      this.label2.Name = "label2";
      // 
      // frmDetailsPlanDeCharge
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Wheat;
      this.Controls.Add(this.txtTot);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtTotEngage);
      this.Controls.Add(this.txtTotResteAEngager);
      this.Controls.Add(this.lblTotResteAEngage);
      this.Controls.Add(this.lblTotEng);
      this.Controls.Add(this.Label1);
      this.Controls.Add(this.btnDown);
      this.Controls.Add(this.btnUp);
      this.Controls.Add(this.apiTGrid1);
      this.Controls.Add(this.cmdFermer);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmDetailsPlanDeCharge";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDetailsPlanDeCharge_FormClosing);
      this.Load += new System.EventHandler(this.frmDetailsPlanDeCharge_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiTGrid apiTGrid1;
    private System.Windows.Forms.Button btnUp;
    private System.Windows.Forms.Button btnDown;
    private MozartUC.apiLabel Label1;
    private System.Windows.Forms.Label lblTotEng;
    private System.Windows.Forms.Label lblTotResteAEngage;
    private System.Windows.Forms.TextBox txtTotResteAEngager;
    private System.Windows.Forms.TextBox txtTotEngage;
    private System.Windows.Forms.TextBox txtTot;
    private System.Windows.Forms.Label label2;
  }
}