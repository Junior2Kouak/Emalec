
namespace MozartCS
{
  partial class frmModifRespSite
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModifRespSite));
      this.cmdFermer = new MozartUC.apiButton();
      this.cboRespMaint = new System.Windows.Forms.ComboBox();
      this.Label51 = new MozartUC.apiLabel();
      this.cmdAppliquer = new MozartUC.apiButton();
      this.txtCRErreur = new System.Windows.Forms.TextBox();
      this.apiLabel1 = new MozartUC.apiLabel();
      this.SuspendLayout();
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
      // cboRespMaint
      // 
      this.cboRespMaint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      resources.ApplyResources(this.cboRespMaint, "cboRespMaint");
      this.cboRespMaint.Name = "cboRespMaint";
      this.cboRespMaint.Sorted = true;
      // 
      // Label51
      // 
      resources.ApplyResources(this.Label51, "Label51");
      this.Label51.BackColor = System.Drawing.Color.Wheat;
      this.Label51.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Label51.HelpContextID = 0;
      this.Label51.Name = "Label51";
      // 
      // cmdAppliquer
      // 
      resources.ApplyResources(this.cmdAppliquer, "cmdAppliquer");
      this.cmdAppliquer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdAppliquer.HelpContextID = 0;
      this.cmdAppliquer.Name = "cmdAppliquer";
      this.cmdAppliquer.Tag = "15";
      this.cmdAppliquer.UseVisualStyleBackColor = true;
      this.cmdAppliquer.Click += new System.EventHandler(this.cmdAppliquer_Click);
      // 
      // txtCRErreur
      // 
      resources.ApplyResources(this.txtCRErreur, "txtCRErreur");
      this.txtCRErreur.Name = "txtCRErreur";
      // 
      // apiLabel1
      // 
      resources.ApplyResources(this.apiLabel1, "apiLabel1");
      this.apiLabel1.BackColor = System.Drawing.Color.Wheat;
      this.apiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.apiLabel1.HelpContextID = 0;
      this.apiLabel1.Name = "apiLabel1";
      // 
      // frmModifRespSite
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Wheat;
      this.Controls.Add(this.apiLabel1);
      this.Controls.Add(this.txtCRErreur);
      this.Controls.Add(this.cmdAppliquer);
      this.Controls.Add(this.cboRespMaint);
      this.Controls.Add(this.Label51);
      this.Controls.Add(this.cmdFermer);
      this.Name = "frmModifRespSite";
      this.Load += new System.EventHandler(this.frmModifRespSite_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdFermer;
    private System.Windows.Forms.ComboBox cboRespMaint;
    private MozartUC.apiLabel Label51;
    private MozartUC.apiButton cmdAppliquer;
    private System.Windows.Forms.TextBox txtCRErreur;
    private MozartUC.apiLabel apiLabel1;
  }
}