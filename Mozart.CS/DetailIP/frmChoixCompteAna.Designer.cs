namespace MozartCS
{
    partial class frmChoixCompteAna
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChoixCompteAna));
      this.cmdValider = new System.Windows.Forms.Button();
      this.cmdFermer = new System.Windows.Forms.Button();
      this.cboCan = new System.Windows.Forms.ComboBox();
      this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
      this.SuspendLayout();
      // 
      // cmdValider
      // 
      resources.ApplyResources(this.cmdValider, "cmdValider");
      this.cmdValider.Name = "cmdValider";
      this.cmdValider.UseVisualStyleBackColor = true;
      this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.UseVisualStyleBackColor = true;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // cboCan
      // 
      this.cboCan.DisplayMember = "VCANLIB";
      this.cboCan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      resources.ApplyResources(this.cboCan, "cboCan");
      this.cboCan.FormattingEnabled = true;
      this.cboCan.Name = "cboCan";
      this.cboCan.ValueMember = "NCANNUM";
      // 
      // frmChoixCompteAna
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Wheat;
      this.Controls.Add(this.cboCan);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.cmdValider);
      this.Name = "frmChoixCompteAna";
      this.ShowInTaskbar = false;
      this.Load += new System.EventHandler(this.frmChoixCompteAna_Load);
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdValider;
        private System.Windows.Forms.Button cmdFermer;
        private System.Windows.Forms.ComboBox cboCan;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}