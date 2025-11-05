namespace MozartCS
{
  partial class frmDiGeronimmo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDiGeronimmo));
			this.cmdQuitter = new MozartUC.apiButton();
			this.cmdCreerDi = new MozartUC.apiButton();
			this.cmdDetailDi = new MozartUC.apiButton();
			this.apiTGridHaut = new MozartUC.apiTGrid();
			this.apiTGridBas = new MozartUC.apiTGrid();
			this.Label10 = new MozartUC.apiLabel();
			this.Label2 = new MozartUC.apiLabel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.cmdNotes = new MozartUC.apiButton();
			this.cmdDocuments = new MozartUC.apiButton();
			this.btnArchiverNew = new MozartUC.apiButton();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnArchiverEnCours = new MozartUC.apiButton();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// cmdQuitter
			// 
			resources.ApplyResources(this.cmdQuitter, "cmdQuitter");
			this.cmdQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cmdQuitter.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdQuitter.HelpContextID = 0;
			this.cmdQuitter.Name = "cmdQuitter";
			this.cmdQuitter.Tag = "15";
			this.cmdQuitter.UseVisualStyleBackColor = true;
			this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
			// 
			// cmdCreerDi
			// 
			resources.ApplyResources(this.cmdCreerDi, "cmdCreerDi");
			this.cmdCreerDi.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdCreerDi.HelpContextID = 0;
			this.cmdCreerDi.Name = "cmdCreerDi";
			this.cmdCreerDi.Tag = "66";
			this.cmdCreerDi.UseVisualStyleBackColor = true;
			this.cmdCreerDi.Click += new System.EventHandler(this.cmdCreerDi_Click);
			// 
			// cmdDetailDi
			// 
			resources.ApplyResources(this.cmdDetailDi, "cmdDetailDi");
			this.cmdDetailDi.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdDetailDi.HelpContextID = 0;
			this.cmdDetailDi.Name = "cmdDetailDi";
			this.cmdDetailDi.Tag = "66";
			this.cmdDetailDi.UseVisualStyleBackColor = true;
			this.cmdDetailDi.Click += new System.EventHandler(this.cmdDetailDi_Click);
			// 
			// apiTGridHaut
			// 
			resources.ApplyResources(this.apiTGridHaut, "apiTGridHaut");
			this.apiTGridHaut.FilterBar = true;
			this.apiTGridHaut.FooterBar = true;
			this.apiTGridHaut.Name = "apiTGridHaut";
			// 
			// apiTGridBas
			// 
			resources.ApplyResources(this.apiTGridBas, "apiTGridBas");
			this.apiTGridBas.FilterBar = true;
			this.apiTGridBas.FooterBar = true;
			this.apiTGridBas.Name = "apiTGridBas";
			// 
			// Label10
			// 
			resources.ApplyResources(this.Label10, "Label10");
			this.Label10.BackColor = System.Drawing.Color.Wheat;
			this.Label10.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label10.HelpContextID = 0;
			this.Label10.Name = "Label10";
			// 
			// Label2
			// 
			resources.ApplyResources(this.Label2, "Label2");
			this.Label2.BackColor = System.Drawing.Color.Wheat;
			this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label2.HelpContextID = 0;
			this.Label2.Name = "Label2";
			// 
			// tableLayoutPanel1
			// 
			resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
			this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			// 
			// panel1
			// 
			resources.ApplyResources(this.panel1, "panel1");
			this.panel1.Controls.Add(this.cmdNotes);
			this.panel1.Controls.Add(this.cmdDocuments);
			this.panel1.Controls.Add(this.btnArchiverNew);
			this.panel1.Controls.Add(this.Label10);
			this.panel1.Controls.Add(this.apiTGridHaut);
			this.panel1.Controls.Add(this.cmdCreerDi);
			this.panel1.Name = "panel1";
			// 
			// cmdNotes
			// 
			resources.ApplyResources(this.cmdNotes, "cmdNotes");
			this.cmdNotes.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdNotes.HelpContextID = 0;
			this.cmdNotes.Name = "cmdNotes";
			this.cmdNotes.Tag = "66";
			this.cmdNotes.UseVisualStyleBackColor = true;
			this.cmdNotes.Click += new System.EventHandler(this.cmdNotes_Click);
			// 
			// cmdDocuments
			// 
			resources.ApplyResources(this.cmdDocuments, "cmdDocuments");
			this.cmdDocuments.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdDocuments.HelpContextID = 0;
			this.cmdDocuments.Name = "cmdDocuments";
			this.cmdDocuments.Tag = "66";
			this.cmdDocuments.UseVisualStyleBackColor = true;
			this.cmdDocuments.Click += new System.EventHandler(this.cmdDocuments_Click);
			// 
			// btnArchiverNew
			// 
			resources.ApplyResources(this.btnArchiverNew, "btnArchiverNew");
			this.btnArchiverNew.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnArchiverNew.HelpContextID = 0;
			this.btnArchiverNew.Name = "btnArchiverNew";
			this.btnArchiverNew.Tag = "66";
			this.btnArchiverNew.UseVisualStyleBackColor = true;
			this.btnArchiverNew.Click += new System.EventHandler(this.btnArchiverNew_Click);
			// 
			// panel2
			// 
			resources.ApplyResources(this.panel2, "panel2");
			this.panel2.Controls.Add(this.btnArchiverEnCours);
			this.panel2.Controls.Add(this.Label2);
			this.panel2.Controls.Add(this.cmdQuitter);
			this.panel2.Controls.Add(this.apiTGridBas);
			this.panel2.Controls.Add(this.cmdDetailDi);
			this.panel2.Name = "panel2";
			// 
			// btnArchiverEnCours
			// 
			resources.ApplyResources(this.btnArchiverEnCours, "btnArchiverEnCours");
			this.btnArchiverEnCours.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnArchiverEnCours.HelpContextID = 0;
			this.btnArchiverEnCours.Name = "btnArchiverEnCours";
			this.btnArchiverEnCours.Tag = "66";
			this.btnArchiverEnCours.UseVisualStyleBackColor = true;
			this.btnArchiverEnCours.Click += new System.EventHandler(this.btnArchiverEnCours_Click);
			// 
			// frmDiGeronimmo
			// 
			this.BackColor = System.Drawing.Color.Wheat;
			this.CancelButton = this.cmdQuitter;
			resources.ApplyResources(this, "$this");
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "frmDiGeronimmo";
			this.ShowInTaskbar = false;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmDiKimoce_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

    }

    #endregion

    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiButton cmdCreerDi;
    private MozartUC.apiButton cmdDetailDi;
    private MozartUC.apiTGrid apiTGridHaut;
    private MozartUC.apiTGrid apiTGridBas;
    private MozartUC.apiLabel Label10;
    private MozartUC.apiLabel Label2;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel2;
		private MozartUC.apiButton btnArchiverNew;
		private MozartUC.apiButton btnArchiverEnCours;
		private MozartUC.apiButton cmdDocuments;
		private MozartUC.apiButton cmdNotes;
	}
}
