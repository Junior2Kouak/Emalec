namespace MozartCS
{
  partial class frmProspModifierEnMasse
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
      this.cmdModifier = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.cboUrgence = new System.Windows.Forms.ComboBox();
      this.Label4 = new System.Windows.Forms.Label();
      this.cboComSuivi = new System.Windows.Forms.ComboBox();
      this.label9 = new System.Windows.Forms.Label();
      this.lblTitre = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // cmdModifier
      // 
      this.cmdModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
      this.cmdModifier.HelpContextID = 0;
      this.cmdModifier.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.cmdModifier.Location = new System.Drawing.Point(12, 69);
      this.cmdModifier.Name = "cmdModifier";
      this.cmdModifier.Size = new System.Drawing.Size(101, 57);
      this.cmdModifier.TabIndex = 57;
      this.cmdModifier.Tag = "66";
      this.cmdModifier.Text = "Appliquer";
      this.cmdModifier.UseVisualStyleBackColor = true;
      this.cmdModifier.Click += new System.EventHandler(this.cmdModifier_Click);
      // 
      // cmdFermer
      // 
      this.cmdFermer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.cmdFermer.Location = new System.Drawing.Point(12, 381);
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Size = new System.Drawing.Size(101, 57);
      this.cmdFermer.TabIndex = 56;
      this.cmdFermer.Tag = "15";
      this.cmdFermer.Text = "Fermer";
      this.cmdFermer.UseVisualStyleBackColor = true;
      // 
      // cboUrgence
      // 
      this.cboUrgence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.cboUrgence.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboUrgence.Location = new System.Drawing.Point(339, 88);
      this.cboUrgence.Name = "cboUrgence";
      this.cboUrgence.Size = new System.Drawing.Size(296, 21);
      this.cboUrgence.TabIndex = 73;
      // 
      // Label4
      // 
      this.Label4.AutoSize = true;
      this.Label4.BackColor = System.Drawing.Color.Wheat;
      this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
      this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.Label4.Location = new System.Drawing.Point(268, 89);
      this.Label4.Name = "Label4";
      this.Label4.Size = new System.Drawing.Size(65, 16);
      this.Label4.TabIndex = 72;
      this.Label4.Text = "Priorité :";
      // 
      // cboComSuivi
      // 
      this.cboComSuivi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.cboComSuivi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboComSuivi.Location = new System.Drawing.Point(339, 127);
      this.cboComSuivi.Name = "cboComSuivi";
      this.cboComSuivi.Size = new System.Drawing.Size(296, 21);
      this.cboComSuivi.TabIndex = 84;
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.BackColor = System.Drawing.Color.Wheat;
      this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
      this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
      this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.label9.Location = new System.Drawing.Point(178, 128);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(155, 16);
      this.label9.TabIndex = 83;
      this.label9.Text = "Commercial de suivi :";
      // 
      // lblTitre
      // 
      this.lblTitre.AutoSize = true;
      this.lblTitre.BackColor = System.Drawing.Color.Wheat;
      this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
      this.lblTitre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblTitre.Location = new System.Drawing.Point(144, 20);
      this.lblTitre.Name = "lblTitre";
      this.lblTitre.Size = new System.Drawing.Size(446, 29);
      this.lblTitre.TabIndex = 243;
      this.lblTitre.Text = "Modification en masse des prospects";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.BackColor = System.Drawing.Color.Wheat;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.ForeColor = System.Drawing.Color.Red;
      this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.label5.Location = new System.Drawing.Point(176, 348);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(533, 60);
      this.label5.TabIndex = 244;
      this.label5.Text = "Aide :\r\n      Positionnez les valeurs que vous souhaitez modifier en masse\r\n     " +
    " Puis cliquez sur le bouton \"Appliquer\"";
      // 
      // frmProspModifierEnMasse
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.lblTitre);
      this.Controls.Add(this.cboComSuivi);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.cboUrgence);
      this.Controls.Add(this.Label4);
      this.Controls.Add(this.cmdModifier);
      this.Controls.Add(this.cmdFermer);
      this.Name = "frmProspModifierEnMasse";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Modifier en masse les prospects";
      this.Load += new System.EventHandler(this.frmProspModifierEnMasse_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdModifier;
    private MozartUC.apiButton cmdFermer;
    private System.Windows.Forms.ComboBox cboUrgence;
    private System.Windows.Forms.Label Label4;
    private System.Windows.Forms.ComboBox cboComSuivi;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label lblTitre;
    private System.Windows.Forms.Label label5;
  }
}