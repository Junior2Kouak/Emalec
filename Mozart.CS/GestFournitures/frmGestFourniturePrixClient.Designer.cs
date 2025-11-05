namespace MozartCS
{
    partial class frmGestFourniturePrixClient
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestFourniturePrixClient));
      this.cmdFermer = new System.Windows.Forms.Button();
      this.apiTGridPrix = new MozartUC.apiTGrid();
      this.SuspendLayout();
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.UseVisualStyleBackColor = true;
      // 
      // apiTGridPrix
      // 
      resources.ApplyResources(this.apiTGridPrix, "apiTGridPrix");
      this.apiTGridPrix.FilterBar = true;
      this.apiTGridPrix.FooterBar = true;
      this.apiTGridPrix.Name = "apiTGridPrix";
      // 
      // frmGestFourniturePrixClient
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdFermer;
      this.Controls.Add(this.apiTGridPrix);
      this.Controls.Add(this.cmdFermer);
      this.Name = "frmGestFourniturePrixClient";
      this.ShowInTaskbar = false;
      this.Load += new System.EventHandler(this.frmGestFourniturePrixClient_Load);
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdFermer;
    private MozartUC.apiTGrid apiTGridPrix;
  }
}