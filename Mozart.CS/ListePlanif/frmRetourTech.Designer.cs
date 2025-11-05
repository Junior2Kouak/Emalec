namespace MozartCS
{
    partial class frmRetourTech
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRetourTech));
      this.cmdQuitter = new System.Windows.Forms.Button();
      this.apiTGridTech = new MozartUC.apiTGrid();
      this.SuspendLayout();
      // 
      // cmdQuitter
      // 
      resources.ApplyResources(this.cmdQuitter, "cmdQuitter");
      this.cmdQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdQuitter.Name = "cmdQuitter";
      this.cmdQuitter.UseVisualStyleBackColor = true;
      this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
      // 
      // apiTGridTech
      // 
      resources.ApplyResources(this.apiTGridTech, "apiTGridTech");
      this.apiTGridTech.FilterBar = true;
      this.apiTGridTech.FooterBar = true;
      this.apiTGridTech.Name = "apiTGridTech";
      // 
      // frmRetourTech
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdQuitter;
      this.Controls.Add(this.apiTGridTech);
      this.Controls.Add(this.cmdQuitter);
      this.Name = "frmRetourTech";
      this.ShowInTaskbar = false;
      this.Load += new System.EventHandler(this.frmRetourTech_Load);
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdQuitter;
    private MozartUC.apiTGrid apiTGridTech;
  }
}