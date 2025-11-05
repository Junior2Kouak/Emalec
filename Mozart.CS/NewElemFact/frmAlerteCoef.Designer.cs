namespace MozartCS
{
    partial class frmAlerteCoef
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlerteCoef));
      this.frameCoef = new System.Windows.Forms.GroupBox();
      this.lblCoef = new System.Windows.Forms.Label();
      this.frameCoef.SuspendLayout();
      this.SuspendLayout();
      // 
      // frameCoef
      // 
      this.frameCoef.BackColor = System.Drawing.Color.White;
      this.frameCoef.Controls.Add(this.lblCoef);
      resources.ApplyResources(this.frameCoef, "frameCoef");
      this.frameCoef.Name = "frameCoef";
      this.frameCoef.TabStop = false;
      // 
      // lblCoef
      // 
      resources.ApplyResources(this.lblCoef, "lblCoef");
      this.lblCoef.Name = "lblCoef";
      // 
      // frmAlerteCoef
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.frameCoef);
      this.Name = "frmAlerteCoef";
      this.ShowInTaskbar = false;
      this.Load += new System.EventHandler(this.frmAlerteCoef_Load);
      this.frameCoef.ResumeLayout(false);
      this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox frameCoef;
        public System.Windows.Forms.Label lblCoef;
    }
}