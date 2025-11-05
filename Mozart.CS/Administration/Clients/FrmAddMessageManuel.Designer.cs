
namespace MozartCS.Administration.Clients
{
  partial class FrmAddMessageManuel
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
      this.LblTitre = new System.Windows.Forms.Label();
      this.BtnValider = new System.Windows.Forms.Button();
      this.BtnCancel = new System.Windows.Forms.Button();
      this.MemoMsg = new DevExpress.XtraEditors.MemoEdit();
      ((System.ComponentModel.ISupportInitialize)(this.MemoMsg.Properties)).BeginInit();
      this.SuspendLayout();
      // 
      // LblTitre
      // 
      this.LblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.LblTitre.Location = new System.Drawing.Point(21, 26);
      this.LblTitre.Name = "LblTitre";
      this.LblTitre.Size = new System.Drawing.Size(767, 23);
      this.LblTitre.TabIndex = 1;
      this.LblTitre.Text = "Titre";
      // 
      // BtnValider
      // 
      this.BtnValider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.BtnValider.Location = new System.Drawing.Point(650, 404);
      this.BtnValider.Name = "BtnValider";
      this.BtnValider.Size = new System.Drawing.Size(138, 32);
      this.BtnValider.TabIndex = 2;
      this.BtnValider.Text = "Valider";
      this.BtnValider.UseVisualStyleBackColor = true;
      this.BtnValider.Click += new System.EventHandler(this.BtnValider_Click);
      // 
      // BtnCancel
      // 
      this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.BtnCancel.Location = new System.Drawing.Point(496, 404);
      this.BtnCancel.Name = "BtnCancel";
      this.BtnCancel.Size = new System.Drawing.Size(138, 32);
      this.BtnCancel.TabIndex = 3;
      this.BtnCancel.Text = "Annuler";
      this.BtnCancel.UseVisualStyleBackColor = true;
      this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
      // 
      // MemoMsg
      // 
      this.MemoMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.MemoMsg.Location = new System.Drawing.Point(24, 52);
      this.MemoMsg.Name = "MemoMsg";
      this.MemoMsg.Size = new System.Drawing.Size(764, 337);
      this.MemoMsg.TabIndex = 6;
      this.MemoMsg.Enter += new System.EventHandler(this.memoEdit1_Enter);
      // 
      // FrmAddMessageManuel
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Wheat;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.MemoMsg);
      this.Controls.Add(this.BtnCancel);
      this.Controls.Add(this.BtnValider);
      this.Controls.Add(this.LblTitre);
      this.Name = "FrmAddMessageManuel";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "FrmAddMessageManuel";
      this.Load += new System.EventHandler(this.FrmAddMessageManuel_Load);
      ((System.ComponentModel.ISupportInitialize)(this.MemoMsg.Properties)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.Label LblTitre;
    private System.Windows.Forms.Button BtnValider;
    private System.Windows.Forms.Button BtnCancel;
    private DevExpress.XtraEditors.MemoEdit MemoMsg;
  }
}