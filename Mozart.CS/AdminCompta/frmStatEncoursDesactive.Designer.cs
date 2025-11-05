
namespace MozartCS.AdminCompta
{
  partial class frmStatEncoursDesactive
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
      this.apiTGrid1 = new MozartUC.apiTGrid();
      this.cmdQuitter = new MozartUC.apiButton();
      this.lbl_titre = new MozartUC.apiLabel();
      this.Calendar1 = new System.Windows.Forms.DateTimePicker();
      this.cmdValider = new MozartUC.apiButton();
      this.lblLabels12 = new MozartUC.apiLabel();
      this.SuspendLayout();
      // 
      // apiTGrid1
      // 
      this.apiTGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.apiTGrid1.FilterBar = true;
      this.apiTGrid1.FooterBar = true;
      this.apiTGrid1.Location = new System.Drawing.Point(98, 115);
      this.apiTGrid1.Margin = new System.Windows.Forms.Padding(4);
      this.apiTGrid1.Name = "apiTGrid1";
      this.apiTGrid1.Size = new System.Drawing.Size(1166, 719);
      this.apiTGrid1.TabIndex = 7;
      // 
      // cmdQuitter
      // 
      this.cmdQuitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.cmdQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
      this.cmdQuitter.HelpContextID = 0;
      this.cmdQuitter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.cmdQuitter.Location = new System.Drawing.Point(8, 777);
      this.cmdQuitter.Name = "cmdQuitter";
      this.cmdQuitter.Size = new System.Drawing.Size(83, 57);
      this.cmdQuitter.TabIndex = 5;
      this.cmdQuitter.Tag = "15";
      this.cmdQuitter.Text = "Quitter";
      this.cmdQuitter.UseVisualStyleBackColor = true;
      this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
      // 
      // lbl_titre
      // 
      this.lbl_titre.BackColor = System.Drawing.Color.Transparent;
      this.lbl_titre.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
      this.lbl_titre.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lbl_titre.HelpContextID = 0;
      this.lbl_titre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lbl_titre.Location = new System.Drawing.Point(94, 22);
      this.lbl_titre.Name = "lbl_titre";
      this.lbl_titre.Size = new System.Drawing.Size(1250, 25);
      this.lbl_titre.TabIndex = 8;
      this.lbl_titre.Text = "Titre dynamique";
      // 
      // Calendar1
      // 
      this.Calendar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(132)))));
      this.Calendar1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.Calendar1.Location = new System.Drawing.Point(400, 66);
      this.Calendar1.Name = "Calendar1";
      this.Calendar1.Size = new System.Drawing.Size(175, 20);
      this.Calendar1.TabIndex = 9;
      // 
      // cmdValider
      // 
      this.cmdValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
      this.cmdValider.HelpContextID = 0;
      this.cmdValider.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.cmdValider.Location = new System.Drawing.Point(606, 61);
      this.cmdValider.Name = "cmdValider";
      this.cmdValider.Size = new System.Drawing.Size(76, 34);
      this.cmdValider.TabIndex = 10;
      this.cmdValider.Text = "Valider";
      this.cmdValider.UseVisualStyleBackColor = true;
      this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
      // 
      // lblLabels12
      // 
      this.lblLabels12.AutoSize = true;
      this.lblLabels12.BackColor = System.Drawing.Color.Transparent;
      this.lblLabels12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblLabels12.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels12.HelpContextID = 0;
      this.lblLabels12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblLabels12.Location = new System.Drawing.Point(95, 70);
      this.lblLabels12.Name = "lblLabels12";
      this.lblLabels12.Size = new System.Drawing.Size(299, 16);
      this.lblLabels12.TabIndex = 13;
      this.lblLabels12.Text = "Date de référence (à la date d\'exécution) :";
      // 
      // frmStatEncoursDesactive
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
      this.ClientSize = new System.Drawing.Size(1629, 961);
      this.Controls.Add(this.Calendar1);
      this.Controls.Add(this.cmdValider);
      this.Controls.Add(this.lblLabels12);
      this.Controls.Add(this.lbl_titre);
      this.Controls.Add(this.apiTGrid1);
      this.Controls.Add(this.cmdQuitter);
      this.Name = "frmStatEncoursDesactive";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "frmStatEncoursDesactive";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmStatEncoursDesactive_Load);
      this.Resize += new System.EventHandler(this.frmStatEncoursDesactive_Resize);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiTGrid apiTGrid1;
    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiLabel lbl_titre;
    private System.Windows.Forms.DateTimePicker Calendar1;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiLabel lblLabels12;
  }
}