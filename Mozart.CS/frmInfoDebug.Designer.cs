namespace MozartCS
{
    partial class frmInfoDebug
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInfoDebug));
      this.cmdFermer = new System.Windows.Forms.Button();
      this.cmdCopier = new System.Windows.Forms.Button();
      this.txtBug = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.UseVisualStyleBackColor = true;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // cmdCopier
      // 
      resources.ApplyResources(this.cmdCopier, "cmdCopier");
      this.cmdCopier.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdCopier.Name = "cmdCopier";
      this.cmdCopier.UseVisualStyleBackColor = true;
      this.cmdCopier.Click += new System.EventHandler(this.cmdCopier_Click);
      // 
      // txtBug
      // 
      resources.ApplyResources(this.txtBug, "txtBug");
      this.txtBug.BackColor = System.Drawing.Color.MistyRose;
      this.txtBug.Name = "txtBug";
      this.txtBug.ReadOnly = true;
      // 
      // frmInfoDebug
      // 
      this.AcceptButton = this.cmdFermer;
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.CancelButton = this.cmdFermer;
      this.Controls.Add(this.cmdCopier);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.txtBug);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmInfoDebug";
      this.Load += new System.EventHandler(this.frmInfoDebug_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion
    private System.Windows.Forms.Button cmdFermer;
    private System.Windows.Forms.Button cmdCopier;
    private System.Windows.Forms.TextBox txtBug;
  }
}