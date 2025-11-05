namespace MozartCS
{
  partial class frmDiSynergee
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDiSynergee));
      this.cmdSynergee = new MozartUC.apiButton();
      this.cmdDetailDi = new MozartUC.apiButton();
      this.cmdCreerDi = new MozartUC.apiButton();
      this.cmdQuitter = new MozartUC.apiButton();
      this.apiTGridNew = new MozartUC.apiTGrid();
      this.apiTGridEnCours = new MozartUC.apiTGrid();
      this.Label2 = new MozartUC.apiLabel();
      this.Label1 = new MozartUC.apiLabel();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.panel1 = new System.Windows.Forms.Panel();
      this.btnListeArchives = new MozartUC.apiButton();
      this.btnArchiverNew = new MozartUC.apiButton();
      this.panel2 = new System.Windows.Forms.Panel();
      this.bntArchiver = new MozartUC.apiButton();
      this.tableLayoutPanel1.SuspendLayout();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // cmdSynergee
      // 
      resources.ApplyResources(this.cmdSynergee, "cmdSynergee");
      this.cmdSynergee.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdSynergee.HelpContextID = 0;
      this.cmdSynergee.Name = "cmdSynergee";
      this.cmdSynergee.Tag = "";
      this.cmdSynergee.UseVisualStyleBackColor = true;
      this.cmdSynergee.Click += new System.EventHandler(this.cmdSynergee_Click);
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
      // apiTGridNew
      // 
      resources.ApplyResources(this.apiTGridNew, "apiTGridNew");
      this.apiTGridNew.FilterBar = true;
      this.apiTGridNew.FooterBar = true;
      this.apiTGridNew.Name = "apiTGridNew";
      // 
      // apiTGridEnCours
      // 
      resources.ApplyResources(this.apiTGridEnCours, "apiTGridEnCours");
      this.apiTGridEnCours.FilterBar = true;
      this.apiTGridEnCours.FooterBar = true;
      this.apiTGridEnCours.Name = "apiTGridEnCours";
      // 
      // Label2
      // 
      resources.ApplyResources(this.Label2, "Label2");
      this.Label2.BackColor = System.Drawing.Color.Wheat;
      this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label2.HelpContextID = 0;
      this.Label2.Name = "Label2";
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
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
      this.panel1.Controls.Add(this.btnListeArchives);
      this.panel1.Controls.Add(this.btnArchiverNew);
      this.panel1.Controls.Add(this.Label1);
      this.panel1.Controls.Add(this.cmdSynergee);
      this.panel1.Controls.Add(this.apiTGridNew);
      this.panel1.Controls.Add(this.cmdCreerDi);
      this.panel1.Name = "panel1";
      // 
      // btnListeArchives
      // 
      resources.ApplyResources(this.btnListeArchives, "btnListeArchives");
      this.btnListeArchives.ForeColor = System.Drawing.SystemColors.ControlText;
      this.btnListeArchives.HelpContextID = 0;
      this.btnListeArchives.Name = "btnListeArchives";
      this.btnListeArchives.Tag = "66";
      this.btnListeArchives.UseVisualStyleBackColor = true;
      this.btnListeArchives.Click += new System.EventHandler(this.btnListeArchives_Click);
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
      this.panel2.Controls.Add(this.bntArchiver);
      this.panel2.Controls.Add(this.cmdQuitter);
      this.panel2.Controls.Add(this.Label2);
      this.panel2.Controls.Add(this.apiTGridEnCours);
      this.panel2.Controls.Add(this.cmdDetailDi);
      this.panel2.Name = "panel2";
      // 
      // bntArchiver
      // 
      resources.ApplyResources(this.bntArchiver, "bntArchiver");
      this.bntArchiver.ForeColor = System.Drawing.SystemColors.ControlText;
      this.bntArchiver.HelpContextID = 0;
      this.bntArchiver.Name = "bntArchiver";
      this.bntArchiver.Tag = "66";
      this.bntArchiver.UseVisualStyleBackColor = true;
      this.bntArchiver.Click += new System.EventHandler(this.bntArchiver_Click);
      // 
      // frmDiSynergee
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdQuitter;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.tableLayoutPanel1);
      this.Name = "frmDiSynergee";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmDiSynergee_Load);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private MozartUC.apiButton cmdSynergee;
    private MozartUC.apiButton cmdDetailDi;
    private MozartUC.apiButton cmdCreerDi;
    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiTGrid apiTGridNew;
    private MozartUC.apiTGrid apiTGridEnCours;
    private MozartUC.apiLabel Label2;
    private MozartUC.apiLabel Label1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel2;
    private MozartUC.apiButton bntArchiver;
    private MozartUC.apiButton btnArchiverNew;
    private MozartUC.apiButton btnListeArchives;
  }
}
