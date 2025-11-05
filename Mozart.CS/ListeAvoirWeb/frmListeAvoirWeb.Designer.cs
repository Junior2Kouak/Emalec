namespace MozartCS
{
  partial class frmListeAvoirWeb
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListeAvoirWeb));
      this.cmdDet = new MozartUC.apiButton();
      this.apiTGridH = new MozartUC.apiTGrid();
      this.Frame2 = new MozartUC.apiGroupBox();
      this.apiTGridB = new MozartUC.apiTGrid();
      this.Frame1 = new MozartUC.apiGroupBox();
      this.cmdFermer = new MozartUC.apiButton();
      this.cmdEnregistrer = new MozartUC.apiButton();
      this.Label1 = new MozartUC.apiLabel();
      this.Frame2.SuspendLayout();
      this.Frame1.SuspendLayout();
      this.SuspendLayout();
      // 
      // cmdDet
      // 
      resources.ApplyResources(this.cmdDet, "cmdDet");
      this.cmdDet.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdDet.HelpContextID = 0;
      this.cmdDet.Name = "cmdDet";
      this.cmdDet.Tag = "66";
      this.cmdDet.UseVisualStyleBackColor = true;
      this.cmdDet.Click += new System.EventHandler(this.cmdDet_Click);
      // 
      // apiTGridH
      // 
      resources.ApplyResources(this.apiTGridH, "apiTGridH");
      this.apiTGridH.FilterBar = true;
      this.apiTGridH.FooterBar = true;
      this.apiTGridH.Name = "apiTGridH";
      // 
      // Frame2
      // 
      resources.ApplyResources(this.Frame2, "Frame2");
      this.Frame2.BackColor = System.Drawing.Color.Wheat;
      this.Frame2.Controls.Add(this.apiTGridH);
      this.Frame2.FrameColor = System.Drawing.Color.Empty;
      this.Frame2.HelpContextID = 0;
      this.Frame2.Name = "Frame2";
      this.Frame2.TabStop = false;
      // 
      // apiTGridB
      // 
      resources.ApplyResources(this.apiTGridB, "apiTGridB");
      this.apiTGridB.FilterBar = true;
      this.apiTGridB.FooterBar = true;
      this.apiTGridB.Name = "apiTGridB";
      // 
      // Frame1
      // 
      resources.ApplyResources(this.Frame1, "Frame1");
      this.Frame1.BackColor = System.Drawing.Color.Wheat;
      this.Frame1.Controls.Add(this.apiTGridB);
      this.Frame1.FrameColor = System.Drawing.Color.Empty;
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
      // 
      // cmdEnregistrer
      // 
      resources.ApplyResources(this.cmdEnregistrer, "cmdEnregistrer");
      this.cmdEnregistrer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdEnregistrer.HelpContextID = 0;
      this.cmdEnregistrer.Name = "cmdEnregistrer";
      this.cmdEnregistrer.Tag = "66";
      this.cmdEnregistrer.UseVisualStyleBackColor = true;
      this.cmdEnregistrer.Click += new System.EventHandler(this.cmdEnregistrer_Click);
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // frmListeAvoirWeb
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdDet);
      this.Controls.Add(this.Frame2);
      this.Controls.Add(this.Frame1);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.cmdEnregistrer);
      this.Controls.Add(this.Label1);
      this.Name = "frmListeAvoirWeb";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmListeAvoirWeb_Load);
      this.Frame2.ResumeLayout(false);
      this.Frame1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdDet;
    private MozartUC.apiTGrid apiTGridH;
    private MozartUC.apiGroupBox Frame2;
    private MozartUC.apiTGrid apiTGridB;
    private MozartUC.apiGroupBox Frame1;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiButton cmdEnregistrer;
    private MozartUC.apiLabel Label1;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
