
namespace MozartCS
{
  partial class frmSuiviTempsTravailTech_VISA
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
      this.Lbl_Temps_Recup_Rest = new System.Windows.Forms.Label();
      this.BtnAddVisa = new System.Windows.Forms.Button();
      this.label4 = new System.Windows.Forms.Label();
      this.BtnDelVisa = new System.Windows.Forms.Button();
      this.Lbl_Temps_Recup_Add = new System.Windows.Forms.Label();
      this.Lbl_Info_VISA = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(12, 23);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(270, 37);
      this.label1.TabIndex = 0;
      this.label1.Text = "Temps de récupération restant au technicien (en HH:mm)";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // Lbl_Temps_Recup_Rest
      // 
      this.Lbl_Temps_Recup_Rest.BackColor = System.Drawing.Color.White;
      this.Lbl_Temps_Recup_Rest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Lbl_Temps_Recup_Rest.Location = new System.Drawing.Point(307, 23);
      this.Lbl_Temps_Recup_Rest.Name = "Lbl_Temps_Recup_Rest";
      this.Lbl_Temps_Recup_Rest.Size = new System.Drawing.Size(170, 30);
      this.Lbl_Temps_Recup_Rest.TabIndex = 1;
      this.Lbl_Temps_Recup_Rest.Text = "00:00";
      this.Lbl_Temps_Recup_Rest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // BtnAddVisa
      // 
      this.BtnAddVisa.Location = new System.Drawing.Point(353, 186);
      this.BtnAddVisa.Name = "BtnAddVisa";
      this.BtnAddVisa.Size = new System.Drawing.Size(124, 36);
      this.BtnAddVisa.TabIndex = 2;
      this.BtnAddVisa.Text = "Valider VISA";
      this.BtnAddVisa.UseVisualStyleBackColor = true;
      this.BtnAddVisa.Click += new System.EventHandler(this.BtnAddVisa_Click);
      // 
      // label4
      // 
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(12, 73);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(289, 30);
      this.label4.TabIndex = 3;
      this.label4.Text = "Temps de récupération à ajouter (en HH:mm)";
      this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // BtnDelVisa
      // 
      this.BtnDelVisa.Location = new System.Drawing.Point(206, 186);
      this.BtnDelVisa.Name = "BtnDelVisa";
      this.BtnDelVisa.Size = new System.Drawing.Size(130, 36);
      this.BtnDelVisa.TabIndex = 5;
      this.BtnDelVisa.Text = "Supprimer VISA";
      this.BtnDelVisa.UseVisualStyleBackColor = true;
      this.BtnDelVisa.Visible = false;
      this.BtnDelVisa.Click += new System.EventHandler(this.BtnDelVisa_Click);
      // 
      // Lbl_Temps_Recup_Add
      // 
      this.Lbl_Temps_Recup_Add.BackColor = System.Drawing.Color.Yellow;
      this.Lbl_Temps_Recup_Add.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Lbl_Temps_Recup_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Lbl_Temps_Recup_Add.Location = new System.Drawing.Point(307, 73);
      this.Lbl_Temps_Recup_Add.Name = "Lbl_Temps_Recup_Add";
      this.Lbl_Temps_Recup_Add.Size = new System.Drawing.Size(170, 30);
      this.Lbl_Temps_Recup_Add.TabIndex = 6;
      this.Lbl_Temps_Recup_Add.Text = "00:00";
      this.Lbl_Temps_Recup_Add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // Lbl_Info_VISA
      // 
      this.Lbl_Info_VISA.BackColor = System.Drawing.Color.White;
      this.Lbl_Info_VISA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Lbl_Info_VISA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Lbl_Info_VISA.Location = new System.Drawing.Point(15, 142);
      this.Lbl_Info_VISA.Name = "Lbl_Info_VISA";
      this.Lbl_Info_VISA.Size = new System.Drawing.Size(455, 24);
      this.Lbl_Info_VISA.TabIndex = 7;
      this.Lbl_Info_VISA.Text = "Info";
      this.Lbl_Info_VISA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label2
      // 
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(12, 116);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(289, 26);
      this.label2.TabIndex = 8;
      this.label2.Text = "Informations VISA :";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // frmSuiviTempsTravailTech_VISA
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Wheat;
      this.ClientSize = new System.Drawing.Size(502, 234);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.Lbl_Info_VISA);
      this.Controls.Add(this.Lbl_Temps_Recup_Add);
      this.Controls.Add(this.BtnDelVisa);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.BtnAddVisa);
      this.Controls.Add(this.Lbl_Temps_Recup_Rest);
      this.Controls.Add(this.label1);
      this.Name = "frmSuiviTempsTravailTech_VISA";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "frmSuiviTempsTravailTech_VISA";
      this.Load += new System.EventHandler(this.frmSuiviTempsTravailTech_VISA_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label Lbl_Temps_Recup_Rest;
    private System.Windows.Forms.Button BtnAddVisa;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button BtnDelVisa;
    private System.Windows.Forms.Label Lbl_Temps_Recup_Add;
    private System.Windows.Forms.Label Lbl_Info_VISA;
    private System.Windows.Forms.Label label2;
  }
}