namespace MozartCS
{
  partial class frmPlanSelectTech
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlanSelectTech));
      this.listTech = new System.Windows.Forms.CheckedListBox();
      this.Label2 = new System.Windows.Forms.Label();
      this.Label14 = new System.Windows.Forms.Label();
      this.cmdValider = new MozartUC.apiButton();
      this.cmdFermer = new MozartUC.apiButton();
      this.SuspendLayout();
      // 
      // listTech
      // 
      resources.ApplyResources(this.listTech, "listTech");
      this.listTech.CheckOnClick = true;
      this.listTech.MultiColumn = true;
      this.listTech.Name = "listTech";
      this.listTech.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listTech_ItemCheck);
      this.listTech.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.listTech_PreviewKeyDown);
      // 
      // Label2
      // 
      resources.ApplyResources(this.Label2, "Label2");
      this.Label2.BackColor = System.Drawing.Color.Wheat;
      this.Label2.Name = "Label2";
      // 
      // Label14
      // 
      resources.ApplyResources(this.Label14, "Label14");
      this.Label14.BackColor = System.Drawing.Color.Wheat;
      this.Label14.Name = "Label14";
      // 
      // cmdValider
      // 
      resources.ApplyResources(this.cmdValider, "cmdValider");
      this.cmdValider.HelpContextID = 0;
      this.cmdValider.Name = "cmdValider";
      this.cmdValider.Tag = "66";
      this.cmdValider.UseVisualStyleBackColor = true;
      this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
      // 
      // cmdFermer
      // 
      resources.ApplyResources(this.cmdFermer, "cmdFermer");
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Tag = "15";
      this.cmdFermer.UseVisualStyleBackColor = true;
      this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
      // 
      // frmPlanSelectTech
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.cmdValider);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.listTech);
      this.Controls.Add(this.Label2);
      this.Controls.Add(this.Label14);
      this.Name = "frmPlanSelectTech";
      this.ShowInTaskbar = false;
      this.Load += new System.EventHandler(this.frmPlanSelectTech_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdValider;
    private MozartUC.apiButton cmdFermer;
    private System.Windows.Forms.CheckedListBox listTech;
    private System.Windows.Forms.Label Label2;
    private System.Windows.Forms.Label Label14;
  }
}
