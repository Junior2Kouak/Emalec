
namespace MozartCS
{
  partial class frmPlan_Info_Utiles
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
      this.cmdValider = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.Txt_VPER_RESTRICTIONS = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.Txt_Info_Utiles = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // cmdValider
      // 
      this.cmdValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
      this.cmdValider.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdValider.HelpContextID = 0;
      this.cmdValider.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.cmdValider.Location = new System.Drawing.Point(12, 31);
      this.cmdValider.Name = "cmdValider";
      this.cmdValider.Size = new System.Drawing.Size(81, 57);
      this.cmdValider.TabIndex = 17;
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
      this.cmdFermer.Location = new System.Drawing.Point(12, 478);
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Size = new System.Drawing.Size(81, 57);
      this.cmdFermer.TabIndex = 16;
      this.cmdFermer.Tag = "15";
      this.cmdFermer.Text = "Fermer";
      this.cmdFermer.UseVisualStyleBackColor = true;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // Txt_VPER_RESTRICTIONS
      // 
      this.Txt_VPER_RESTRICTIONS.Location = new System.Drawing.Point(116, 31);
      this.Txt_VPER_RESTRICTIONS.Multiline = true;
      this.Txt_VPER_RESTRICTIONS.Name = "Txt_VPER_RESTRICTIONS";
      this.Txt_VPER_RESTRICTIONS.ReadOnly = true;
      this.Txt_VPER_RESTRICTIONS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.Txt_VPER_RESTRICTIONS.Size = new System.Drawing.Size(928, 203);
      this.Txt_VPER_RESTRICTIONS.TabIndex = 14;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(113, 7);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(124, 13);
      this.label1.TabIndex = 13;
      this.label1.Text = "Liste des restrictions";
      // 
      // Txt_Info_Utiles
      // 
      this.Txt_Info_Utiles.Location = new System.Drawing.Point(116, 281);
      this.Txt_Info_Utiles.Multiline = true;
      this.Txt_Info_Utiles.Name = "Txt_Info_Utiles";
      this.Txt_Info_Utiles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.Txt_Info_Utiles.Size = new System.Drawing.Size(928, 254);
      this.Txt_Info_Utiles.TabIndex = 18;
      this.Txt_Info_Utiles.Click += new System.EventHandler(this.Txt_Info_Utiles_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(113, 265);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(122, 13);
      this.label2.TabIndex = 19;
      this.label2.Text = "Informations utiles : ";
      // 
      // frmPlan_Info_Utiles
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Wheat;
      this.ClientSize = new System.Drawing.Size(1077, 554);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.Txt_Info_Utiles);
      this.Controls.Add(this.cmdValider);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.Txt_VPER_RESTRICTIONS);
      this.Controls.Add(this.label1);
      this.Name = "frmPlan_Info_Utiles";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Informations Utiles";
      this.Load += new System.EventHandler(this.frmPlan_Info_Utiles_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdValider;
    private MozartUC.apiButton cmdFermer;
    private System.Windows.Forms.TextBox Txt_VPER_RESTRICTIONS;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox Txt_Info_Utiles;
    private System.Windows.Forms.Label label2;
  }
}