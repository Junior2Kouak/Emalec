namespace MozartCS
{
  partial class frmSaisieWebContrat
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSaisieWebContrat));
      this.cmdEnregistrer = new System.Windows.Forms.Button();
      this.cmdFermer = new System.Windows.Forms.Button();
      this.txtContrat = new System.Windows.Forms.TextBox();
      this.ttEnregister = new System.Windows.Forms.ToolTip(this.components);
      this.SuspendLayout();
      // 
      // cmdEnregistrer
      // 
      resources.ApplyResources(this.cmdEnregistrer, "cmdEnregistrer");
      this.cmdEnregistrer.Name = "cmdEnregistrer";
      this.ttEnregister.SetToolTip(this.cmdEnregistrer, resources.GetString("cmdEnregistrer.ToolTip"));
      this.cmdEnregistrer.UseVisualStyleBackColor = true;
      this.cmdEnregistrer.Click += new System.EventHandler(this.cmdEnregistrer_Click);
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.UseVisualStyleBackColor = true;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // txtContrat
      // 
      resources.ApplyResources(this.txtContrat, "txtContrat");
      this.txtContrat.Name = "txtContrat";
      // 
      // frmSaisieWebContrat
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Wheat;
      this.Controls.Add(this.txtContrat);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.cmdEnregistrer);
      this.Name = "frmSaisieWebContrat";
      this.ShowInTaskbar = false;
      this.Load += new System.EventHandler(this.frmSaisieWebContrat_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button cmdEnregistrer;
    private System.Windows.Forms.Button cmdFermer;
    private System.Windows.Forms.TextBox txtContrat;
    private System.Windows.Forms.ToolTip ttEnregister;
  }
}