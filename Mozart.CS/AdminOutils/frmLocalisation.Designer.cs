namespace MozartCS
{
  partial class frmLocalisation
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLocalisation));
      this.txtPays = new MozartUC.apiTextBox();
      this.txtVille = new MozartUC.apiTextBox();
      this.txtCP = new MozartUC.apiTextBox();
      this.cmdFermer = new MozartUC.apiButton();
      this.cmdEnregistrer = new MozartUC.apiButton();
      this.lblContact = new System.Windows.Forms.Label();
      this.lblLabels5 = new System.Windows.Forms.Label();
      this.Label2 = new System.Windows.Forms.Label();
      this.Label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // txtPays
      // 
      this.txtPays.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.txtPays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.txtPays.HelpContextID = 0;
      resources.ApplyResources(this.txtPays, "txtPays");
      this.txtPays.Name = "txtPays";
      // 
      // txtVille
      // 
      this.txtVille.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.txtVille.HelpContextID = 0;
      resources.ApplyResources(this.txtVille, "txtVille");
      this.txtVille.Name = "txtVille";
      // 
      // txtCP
      // 
      this.txtCP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.txtCP.HelpContextID = 0;
      resources.ApplyResources(this.txtCP, "txtCP");
      this.txtCP.Name = "txtCP";
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
      // cmdEnregistrer
      // 
      this.cmdEnregistrer.DialogResult = System.Windows.Forms.DialogResult.OK;
      resources.ApplyResources(this.cmdEnregistrer, "cmdEnregistrer");
      this.cmdEnregistrer.HelpContextID = 0;
      this.cmdEnregistrer.Name = "cmdEnregistrer";
      this.cmdEnregistrer.Tag = "66";
      this.cmdEnregistrer.UseVisualStyleBackColor = true;
      this.cmdEnregistrer.Click += new System.EventHandler(this.cmdEnregistrer_Click);
      // 
      // lblContact
      // 
      resources.ApplyResources(this.lblContact, "lblContact");
      this.lblContact.BackColor = System.Drawing.Color.Wheat;
      this.lblContact.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblContact.Name = "lblContact";
      // 
      // lblLabels5
      // 
      resources.ApplyResources(this.lblLabels5, "lblLabels5");
      this.lblLabels5.BackColor = System.Drawing.Color.Wheat;
      this.lblLabels5.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels5.Name = "lblLabels5";
      // 
      // Label2
      // 
      resources.ApplyResources(this.Label2, "Label2");
      this.Label2.BackColor = System.Drawing.Color.Wheat;
      this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label2.Name = "Label2";
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.Name = "Label1";
      // 
      // frmLocalisation
      // 
      this.AcceptButton = this.cmdEnregistrer;
      this.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.txtPays);
      this.Controls.Add(this.txtVille);
      this.Controls.Add(this.txtCP);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.cmdEnregistrer);
      this.Controls.Add(this.lblContact);
      this.Controls.Add(this.lblLabels5);
      this.Controls.Add(this.Label2);
      this.Controls.Add(this.Label1);
      this.Name = "frmLocalisation";
      this.ShowInTaskbar = false;
      this.Load += new System.EventHandler(this.frmLocalisation_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiTextBox txtPays;
    private MozartUC.apiTextBox txtVille;
    private MozartUC.apiTextBox txtCP;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiButton cmdEnregistrer;
    private System.Windows.Forms.Label lblContact;
    private System.Windows.Forms.Label lblLabels5;
    private System.Windows.Forms.Label Label2;
    private System.Windows.Forms.Label Label1;
  }
}
