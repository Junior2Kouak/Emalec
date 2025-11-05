namespace MozartCS
{
  partial class frmSelectTransporteur
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectTransporteur));
      this.cmdValider = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.Label1 = new MozartUC.apiLabel();
      this.txtCritFour = new System.Windows.Forms.TextBox();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.Frame2 = new MozartUC.apiGroupBox();
      this.txtHT = new MozartUC.apiTextBox();
      this.cmdSupp = new MozartUC.apiButton();
      this.grdDataGrid2 = new MozartUC.apiTGrid();
      this.lblLabels6 = new MozartUC.apiLabel();
      this.Label2 = new MozartUC.apiLabel();
      this.Frame1 = new MozartUC.apiGroupBox();
      this.cmdAjouter = new MozartUC.apiButton();
      this.apiTGrid1 = new MozartUC.apiTGrid();
      this.tableLayoutPanel1.SuspendLayout();
      this.Frame2.SuspendLayout();
      this.Frame1.SuspendLayout();
      this.SuspendLayout();
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
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // txtCritFour
      // 
      this.txtCritFour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.txtCritFour.BorderStyle = System.Windows.Forms.BorderStyle.None;
      resources.ApplyResources(this.txtCritFour, "txtCritFour");
      this.txtCritFour.Name = "txtCritFour";
      this.txtCritFour.ReadOnly = true;
      // 
      // tableLayoutPanel1
      // 
      resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
      this.tableLayoutPanel1.Controls.Add(this.Frame2, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.Frame1, 0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      // 
      // Frame2
      // 
      resources.ApplyResources(this.Frame2, "Frame2");
      this.Frame2.BackColor = System.Drawing.Color.Wheat;
      this.Frame2.Controls.Add(this.txtHT);
      this.Frame2.Controls.Add(this.cmdSupp);
      this.Frame2.Controls.Add(this.grdDataGrid2);
      this.Frame2.Controls.Add(this.lblLabels6);
      this.Frame2.Controls.Add(this.Label2);
      this.Frame2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Frame2.HelpContextID = 0;
      this.Frame2.Name = "Frame2";
      this.Frame2.TabStop = false;
      // 
      // txtHT
      // 
      resources.ApplyResources(this.txtHT, "txtHT");
      this.txtHT.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtHT.HelpContextID = 0;
      this.txtHT.Name = "txtHT";
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
      // grdDataGrid2
      // 
      resources.ApplyResources(this.grdDataGrid2, "grdDataGrid2");
      this.grdDataGrid2.FilterBar = true;
      this.grdDataGrid2.FooterBar = true;
      this.grdDataGrid2.Name = "grdDataGrid2";
      this.grdDataGrid2.RowCellStyle += new MozartUC.apiTGrid.RowCellStyleEventHandler(this.grdDataGrid2_RowCellStyle);
      this.grdDataGrid2.CellValueChanged += new MozartUC.apiTGrid.CellValueChangedEventHandler(this.grdDataGrid2_CellValueChanged);
      // 
      // lblLabels6
      // 
      resources.ApplyResources(this.lblLabels6, "lblLabels6");
      this.lblLabels6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.lblLabels6.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels6.HelpContextID = 0;
      this.lblLabels6.Name = "lblLabels6";
      // 
      // Label2
      // 
      resources.ApplyResources(this.Label2, "Label2");
      this.Label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label2.HelpContextID = 0;
      this.Label2.Name = "Label2";
      // 
      // Frame1
      // 
      resources.ApplyResources(this.Frame1, "Frame1");
      this.Frame1.BackColor = System.Drawing.Color.Wheat;
      this.Frame1.Controls.Add(this.cmdAjouter);
      this.Frame1.Controls.Add(this.apiTGrid1);
      this.Frame1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
      // apiTGrid1
      // 
      resources.ApplyResources(this.apiTGrid1, "apiTGrid1");
      this.apiTGrid1.FilterBar = true;
      this.apiTGrid1.FooterBar = true;
      this.apiTGrid1.Name = "apiTGrid1";
      this.apiTGrid1.DoubleClickE += new MozartUC.apiTGrid.DoubleClickEEventHandler(this.cmdAjouter_Click);
      // 
      // frmSelectTransporteur
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.tableLayoutPanel1);
      this.Controls.Add(this.txtCritFour);
      this.Controls.Add(this.cmdValider);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.Label1);
      this.KeyPreview = true;
      this.Name = "frmSelectTransporteur";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmSelectTransporteur_Load);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.Frame2.ResumeLayout(false);
      this.Frame2.PerformLayout();
      this.Frame1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiLabel Label1;
    private System.Windows.Forms.TextBox txtCritFour;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private MozartUC.apiGroupBox Frame1;
    private MozartUC.apiTGrid apiTGrid1;
    private MozartUC.apiGroupBox Frame2;
    private MozartUC.apiTextBox txtHT;
    private MozartUC.apiButton cmdSupp;
    private MozartUC.apiTGrid grdDataGrid2;
    private MozartUC.apiLabel lblLabels6;
    private MozartUC.apiLabel Label2;
    private MozartUC.apiButton cmdAjouter;
  }
}
