
namespace MozartCS
{
  partial class frmListeSynergieeArchive
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
      this.cmdQuitter = new MozartUC.apiButton();
      this.Label1 = new MozartUC.apiLabel();
      this.apiTGridNew = new MozartUC.apiTGrid();
      this.cmdRestaurer = new MozartUC.apiButton();
      this.SuspendLayout();
      // 
      // cmdQuitter
      // 
      this.cmdQuitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.cmdQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
      this.cmdQuitter.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdQuitter.HelpContextID = 0;
      this.cmdQuitter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.cmdQuitter.Location = new System.Drawing.Point(11, 632);
      this.cmdQuitter.Name = "cmdQuitter";
      this.cmdQuitter.Size = new System.Drawing.Size(75, 49);
      this.cmdQuitter.TabIndex = 14;
      this.cmdQuitter.Tag = "15";
      this.cmdQuitter.Text = "Quitter";
      this.cmdQuitter.UseVisualStyleBackColor = true;
      this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
      // 
      // Label1
      // 
      this.Label1.AutoSize = true;
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Bold);
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.Label1.Location = new System.Drawing.Point(88, 9);
      this.Label1.Name = "Label1";
      this.Label1.Size = new System.Drawing.Size(289, 22);
      this.Label1.TabIndex = 11;
      this.Label1.Text = "Demandes Synergee Archivées";
      // 
      // apiTGridNew
      // 
      this.apiTGridNew.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.apiTGridNew.FilterBar = true;
      this.apiTGridNew.FooterBar = true;
      this.apiTGridNew.Location = new System.Drawing.Point(92, 34);
      this.apiTGridNew.Name = "apiTGridNew";
      this.apiTGridNew.Size = new System.Drawing.Size(1363, 647);
      this.apiTGridNew.TabIndex = 10;
      // 
      // cmdRestaurer
      // 
      this.cmdRestaurer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
      this.cmdRestaurer.HelpContextID = 0;
      this.cmdRestaurer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.cmdRestaurer.Location = new System.Drawing.Point(11, 78);
      this.cmdRestaurer.Name = "cmdRestaurer";
      this.cmdRestaurer.Size = new System.Drawing.Size(73, 57);
      this.cmdRestaurer.TabIndex = 15;
      this.cmdRestaurer.Tag = "29";
      this.cmdRestaurer.Text = "Restaurer";
      this.cmdRestaurer.UseVisualStyleBackColor = true;
      this.cmdRestaurer.Click += new System.EventHandler(this.cmdRestaurer_Click);
      // 
      // frmListeSynergieeArchive
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Wheat;
      this.ClientSize = new System.Drawing.Size(1467, 693);
      this.Controls.Add(this.cmdRestaurer);
      this.Controls.Add(this.cmdQuitter);
      this.Controls.Add(this.Label1);
      this.Controls.Add(this.apiTGridNew);
      this.Name = "frmListeSynergieeArchive";
      this.Text = "Demandes Synergee Archivées";
      this.Load += new System.EventHandler(this.frmListeSynergieeArchive_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private MozartUC.apiLabel Label1;
    private MozartUC.apiTGrid apiTGridNew;
    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiButton cmdRestaurer;
  }
}