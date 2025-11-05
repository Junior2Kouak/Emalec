
namespace MozartCS
{
  partial class frmSuiviTempsTravailTech_Histo
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
      this.TxtHisto = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // TxtHisto
      // 
      this.TxtHisto.BackColor = System.Drawing.Color.White;
      this.TxtHisto.Dock = System.Windows.Forms.DockStyle.Fill;
      this.TxtHisto.Location = new System.Drawing.Point(0, 0);
      this.TxtHisto.Multiline = true;
      this.TxtHisto.Name = "TxtHisto";
      this.TxtHisto.ReadOnly = true;
      this.TxtHisto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.TxtHisto.Size = new System.Drawing.Size(956, 386);
      this.TxtHisto.TabIndex = 19;
      // 
      // frmSuiviTempsTravailTech_Histo
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Wheat;
      this.ClientSize = new System.Drawing.Size(956, 386);
      this.Controls.Add(this.TxtHisto);
      this.Name = "frmSuiviTempsTravailTech_Histo";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "frmSuiviTempsTravailTech";
      this.Load += new System.EventHandler(this.frmSuiviTempsTravailTech_Histo_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.TextBox TxtHisto;
  }
}