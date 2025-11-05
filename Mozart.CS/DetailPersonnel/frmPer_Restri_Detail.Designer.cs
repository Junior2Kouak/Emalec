
namespace MozartCS.DetailPersonnel
{
  partial class frmPer_Restri_Detail
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
      this.label1 = new System.Windows.Forms.Label();
      this.Txt_VPER_RESTRICTIONS = new System.Windows.Forms.TextBox();
      this.Btn_Tooltip = new System.Windows.Forms.Button();
      this.cmdValider = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(113, 32);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(124, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Liste des restrictions";
      // 
      // Txt_VPER_RESTRICTIONS
      // 
      this.Txt_VPER_RESTRICTIONS.Location = new System.Drawing.Point(116, 56);
      this.Txt_VPER_RESTRICTIONS.Multiline = true;
      this.Txt_VPER_RESTRICTIONS.Name = "Txt_VPER_RESTRICTIONS";
      this.Txt_VPER_RESTRICTIONS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.Txt_VPER_RESTRICTIONS.Size = new System.Drawing.Size(928, 504);
      this.Txt_VPER_RESTRICTIONS.TabIndex = 1;
      this.Txt_VPER_RESTRICTIONS.Click += new System.EventHandler(this.Txt_VPER_RESTRICTIONS_Click);
      // 
      // Btn_Tooltip
      // 
      this.Btn_Tooltip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Btn_Tooltip.Location = new System.Drawing.Point(243, 27);
      this.Btn_Tooltip.Name = "Btn_Tooltip";
      this.Btn_Tooltip.Size = new System.Drawing.Size(34, 23);
      this.Btn_Tooltip.TabIndex = 2;
      this.Btn_Tooltip.Text = "?";
      this.Btn_Tooltip.UseVisualStyleBackColor = true;
      this.Btn_Tooltip.Click += new System.EventHandler(this.Btn_Tooltip_Click);
      // 
      // cmdValider
      // 
      this.cmdValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
      this.cmdValider.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdValider.HelpContextID = 0;
      this.cmdValider.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.cmdValider.Location = new System.Drawing.Point(12, 56);
      this.cmdValider.Name = "cmdValider";
      this.cmdValider.Size = new System.Drawing.Size(81, 57);
      this.cmdValider.TabIndex = 12;
      this.cmdValider.Tag = "66";
      this.cmdValider.Text = "Enregistrer";
      this.cmdValider.UseVisualStyleBackColor = true;
      this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
      // 
      // cmdFermer
      // 
      this.cmdFermer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
      this.cmdFermer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.cmdFermer.Location = new System.Drawing.Point(12, 500);
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Size = new System.Drawing.Size(81, 57);
      this.cmdFermer.TabIndex = 11;
      this.cmdFermer.Tag = "15";
      this.cmdFermer.Text = "Fermer";
      this.cmdFermer.UseVisualStyleBackColor = true;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // frmPer_Restri_Detail
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Wheat;
      this.ClientSize = new System.Drawing.Size(1061, 569);
      this.Controls.Add(this.cmdValider);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.Btn_Tooltip);
      this.Controls.Add(this.Txt_VPER_RESTRICTIONS);
      this.Controls.Add(this.label1);
      this.Name = "frmPer_Restri_Detail";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Liste des restrictions";
      this.Load += new System.EventHandler(this.frmPer_Restri_Detail_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox Txt_VPER_RESTRICTIONS;
    private System.Windows.Forms.Button Btn_Tooltip;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiButton cmdFermer;
  }
}