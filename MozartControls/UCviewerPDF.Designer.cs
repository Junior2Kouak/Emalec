
namespace MozartControls
{
  partial class UCviewerPDF
  {
    /// <summary> 
    /// Variable nécessaire au concepteur.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Nettoyage des ressources utilisées.
    /// </summary>
    /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Code généré par le Concepteur de composants

    /// <summary> 
    /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
    /// le contenu de cette méthode avec l'éditeur de code.
    /// </summary>
    private void InitializeComponent()
    {
      this.pdfV = new DevExpress.XtraPdfViewer.PdfViewer();
      this.SuspendLayout();
      // 
      // pdfV
      // 
      this.pdfV.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pdfV.Location = new System.Drawing.Point(0, 0);
      this.pdfV.Name = "pdfV";
      this.pdfV.Size = new System.Drawing.Size(920, 702);
      this.pdfV.TabIndex = 0;
      // 
      // UCviewerPDF
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.pdfV);
      this.Name = "UCviewerPDF";
      this.Size = new System.Drawing.Size(920, 702);
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraPdfViewer.PdfViewer pdfV;
  }
}
