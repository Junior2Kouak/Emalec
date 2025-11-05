
namespace MozartCS
{
  partial class frmListeDelegationDevis
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListeDelegationDevis));
      this.cmdDI = new MozartUC.apiButton();
      this.cmdModifier = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.apigrid = new MozartUC.apiTGrid();
      this.Label1 = new MozartUC.apiLabel();
      this.cmdLegende = new MozartUC.apiButton();
      this.Frame1 = new MozartUC.apiGroupBox();
      this.Command1 = new MozartUC.apiButton();
      this.Label7 = new MozartUC.apiLabel();
      this.Label6 = new MozartUC.apiLabel();
      this.Label5 = new MozartUC.apiLabel();
      this.Label4 = new MozartUC.apiLabel();
      this.Label3 = new MozartUC.apiLabel();
      this.Label2 = new MozartUC.apiLabel();
      this.Frame1.SuspendLayout();
      this.SuspendLayout();
      // 
      // cmdDI
      // 
      resources.ApplyResources(this.cmdDI, "cmdDI");
      this.cmdDI.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdDI.HelpContextID = 0;
      this.cmdDI.Name = "cmdDI";
      this.cmdDI.Tag = "49";
      this.cmdDI.UseVisualStyleBackColor = true;
      this.cmdDI.Click += new System.EventHandler(this.cmdDI_Click);
      // 
      // cmdModifier
      // 
      resources.ApplyResources(this.cmdModifier, "cmdModifier");
      this.cmdModifier.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdModifier.HelpContextID = 0;
      this.cmdModifier.Name = "cmdModifier";
      this.cmdModifier.Tag = "19";
      this.cmdModifier.UseVisualStyleBackColor = true;
      this.cmdModifier.Click += new System.EventHandler(this.cmdModifier_Click);
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
      // apigrid
      // 
      resources.ApplyResources(this.apigrid, "apigrid");
      this.apigrid.FilterBar = true;
      this.apigrid.FooterBar = true;
      this.apigrid.Name = "apigrid";
      this.apigrid.DoubleClickE += new MozartUC.apiTGrid.DoubleClickEEventHandler(this.apigrid_DoubleClickE);
      this.apigrid.RowCellStyle += new MozartUC.apiTGrid.RowCellStyleEventHandler(this.apigrid_RowCellStyle);
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // cmdLegende
      // 
      resources.ApplyResources(this.cmdLegende, "cmdLegende");
      this.cmdLegende.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdLegende.HelpContextID = 0;
      this.cmdLegende.Name = "cmdLegende";
      this.cmdLegende.UseVisualStyleBackColor = true;
      this.cmdLegende.Click += new System.EventHandler(this.cmdLegende_Click);
      // 
      // Frame1
      // 
      this.Frame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.Frame1.Controls.Add(this.Command1);
      this.Frame1.Controls.Add(this.Label7);
      this.Frame1.Controls.Add(this.Label6);
      this.Frame1.Controls.Add(this.Label5);
      this.Frame1.Controls.Add(this.Label4);
      this.Frame1.Controls.Add(this.Label3);
      this.Frame1.Controls.Add(this.Label2);
      resources.ApplyResources(this.Frame1, "Frame1");
      this.Frame1.FrameColor = System.Drawing.Color.Empty;
      this.Frame1.HelpContextID = 0;
      this.Frame1.Name = "Frame1";
      this.Frame1.TabStop = false;
      // 
      // Command1
      // 
      this.Command1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Command1.HelpContextID = 0;
      resources.ApplyResources(this.Command1, "Command1");
      this.Command1.Name = "Command1";
      this.Command1.UseVisualStyleBackColor = true;
      this.Command1.Click += new System.EventHandler(this.cmdLegende_Click);
      // 
      // Label7
      // 
      this.Label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.Label7, "Label7");
      this.Label7.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label7.HelpContextID = 0;
      this.Label7.Name = "Label7";
      // 
      // Label6
      // 
      this.Label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
      this.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Label6.HelpContextID = 0;
      resources.ApplyResources(this.Label6, "Label6");
      this.Label6.Name = "Label6";
      // 
      // Label5
      // 
      this.Label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.Label5, "Label5");
      this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label5.HelpContextID = 0;
      this.Label5.Name = "Label5";
      // 
      // Label4
      // 
      this.Label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Label4.HelpContextID = 0;
      resources.ApplyResources(this.Label4, "Label4");
      this.Label4.Name = "Label4";
      // 
      // Label3
      // 
      this.Label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.Label3, "Label3");
      this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label3.HelpContextID = 0;
      this.Label3.Name = "Label3";
      // 
      // Label2
      // 
      this.Label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
      this.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Label2.HelpContextID = 0;
      resources.ApplyResources(this.Label2, "Label2");
      this.Label2.Name = "Label2";
      // 
      // frmListeDelegationDevis
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.cmdFermer;
      this.Controls.Add(this.Frame1);
      this.Controls.Add(this.cmdLegende);
      this.Controls.Add(this.cmdDI);
      this.Controls.Add(this.cmdModifier);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.apigrid);
      this.Controls.Add(this.Label1);
      this.Name = "frmListeDelegationDevis";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmListeDelegationDevis_FormClosed);
      this.Load += new System.EventHandler(this.frmListeDelegationDevis_Load);
      this.Frame1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion
    private MozartUC.apiButton cmdDI;
    private MozartUC.apiButton cmdModifier;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiTGrid apigrid;
    private MozartUC.apiLabel Label1;
    private MozartUC.apiButton cmdLegende;
    private MozartUC.apiGroupBox Frame1;
    private MozartUC.apiButton Command1;
    private MozartUC.apiLabel Label7;
    private MozartUC.apiLabel Label6;
    private MozartUC.apiLabel Label5;
    private MozartUC.apiLabel Label4;
    private MozartUC.apiLabel Label3;
    private MozartUC.apiLabel Label2;
  }
}