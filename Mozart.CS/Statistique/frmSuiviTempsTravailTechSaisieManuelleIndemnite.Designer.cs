
namespace MozartCS
{
  partial class frmSuiviTempsTravailTechSaisieManuelleIndemnite
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
            this.label2 = new System.Windows.Forms.Label();
            this.Lbl_Montant_Indemnite_MOZARIS = new System.Windows.Forms.Label();
            this.BtnValider = new System.Windows.Forms.Button();
            this.TxtObs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NUP_Montant_Indemn = new System.Windows.Forms.NumericUpDown();
            this.TxtHisto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NUP_Montant_Indemn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Indemnité de compensation MOZARIS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Indemnité manuelle de compensation MOZARIS (en €)";
            // 
            // Lbl_Montant_Indemnite_MOZARIS
            // 
            this.Lbl_Montant_Indemnite_MOZARIS.BackColor = System.Drawing.Color.White;
            this.Lbl_Montant_Indemnite_MOZARIS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lbl_Montant_Indemnite_MOZARIS.Location = new System.Drawing.Point(362, 34);
            this.Lbl_Montant_Indemnite_MOZARIS.Name = "Lbl_Montant_Indemnite_MOZARIS";
            this.Lbl_Montant_Indemnite_MOZARIS.Size = new System.Drawing.Size(116, 27);
            this.Lbl_Montant_Indemnite_MOZARIS.TabIndex = 3;
            this.Lbl_Montant_Indemnite_MOZARIS.Text = "00";
            this.Lbl_Montant_Indemnite_MOZARIS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnValider
            // 
            this.BtnValider.Location = new System.Drawing.Point(535, 41);
            this.BtnValider.Name = "BtnValider";
            this.BtnValider.Size = new System.Drawing.Size(75, 65);
            this.BtnValider.TabIndex = 11;
            this.BtnValider.Text = "Valider";
            this.BtnValider.UseVisualStyleBackColor = true;
            this.BtnValider.Click += new System.EventHandler(this.BtnValider_Click);
            // 
            // TxtObs
            // 
            this.TxtObs.Location = new System.Drawing.Point(31, 149);
            this.TxtObs.Multiline = true;
            this.TxtObs.Name = "TxtObs";
            this.TxtObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtObs.Size = new System.Drawing.Size(747, 106);
            this.TxtObs.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Historique";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Observations";
            // 
            // NUP_Montant_Indemn
            // 
            this.NUP_Montant_Indemn.DecimalPlaces = 2;
            this.NUP_Montant_Indemn.Location = new System.Drawing.Point(362, 100);
            this.NUP_Montant_Indemn.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.NUP_Montant_Indemn.Name = "NUP_Montant_Indemn";
            this.NUP_Montant_Indemn.Size = new System.Drawing.Size(116, 20);
            this.NUP_Montant_Indemn.TabIndex = 16;
            this.NUP_Montant_Indemn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUP_Montant_Indemn.ThousandsSeparator = true;
            // 
            // TxtHisto
            // 
            this.TxtHisto.BackColor = System.Drawing.Color.White;
            this.TxtHisto.Location = new System.Drawing.Point(31, 296);
            this.TxtHisto.Multiline = true;
            this.TxtHisto.Name = "TxtHisto";
            this.TxtHisto.ReadOnly = true;
            this.TxtHisto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtHisto.Size = new System.Drawing.Size(747, 142);
            this.TxtHisto.TabIndex = 13;
            // 
            // frmSuiviTempsTravailTechSaisieManuelleIndemnite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(794, 450);
            this.Controls.Add(this.NUP_Montant_Indemn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtHisto);
            this.Controls.Add(this.BtnValider);
            this.Controls.Add(this.TxtObs);
            this.Controls.Add(this.Lbl_Montant_Indemnite_MOZARIS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSuiviTempsTravailTechSaisieManuelleIndemnite";
            this.Text = "Saisie manuelle de l\'indemnité de compensation";
            this.Load += new System.EventHandler(this.frmSuiviTempsTravailTechSaisieManuelleIndemnite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUP_Montant_Indemn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label Lbl_Montant_Indemnite_MOZARIS;
    private System.Windows.Forms.Button BtnValider;
    private System.Windows.Forms.TextBox TxtObs;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.NumericUpDown NUP_Montant_Indemn;
    private System.Windows.Forms.TextBox TxtHisto;
  }
}