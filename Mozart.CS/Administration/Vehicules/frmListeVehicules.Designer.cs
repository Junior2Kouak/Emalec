
namespace MozartCS
{
  partial class frmListeVehicules
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListeVehicules));
			this.ButtonRestaurer = new System.Windows.Forms.Button();
			this.ButtonLstArchives = new System.Windows.Forms.Button();
			this.ButtonArchiver = new System.Windows.Forms.Button();
			this.ButtonDetails = new System.Windows.Forms.Button();
			this.BtnFermer = new System.Windows.Forms.Button();
			this.BtnAjouter = new System.Windows.Forms.Button();
			this.apiSocieteAuto1 = new MozartUC.apiSocieteAuto();
			this.LabelTitre = new System.Windows.Forms.Label();
			this.apiTGrid1 = new MozartUC.apiTGrid();
			this.Frame1 = new MozartUC.apiGroupBox();
			this.apiLabel2 = new MozartUC.apiLabel();
			this.Command1 = new MozartUC.apiButton();
			this.Label25 = new MozartUC.apiLabel();
			this.Label24 = new MozartUC.apiLabel();
			this.Label12 = new MozartUC.apiLabel();
			this.cmdLegende = new MozartUC.apiButton();
			this.button1 = new System.Windows.Forms.Button();
			this.Frame1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ButtonRestaurer
			// 
			resources.ApplyResources(this.ButtonRestaurer, "ButtonRestaurer");
			this.ButtonRestaurer.Name = "ButtonRestaurer";
			this.ButtonRestaurer.UseVisualStyleBackColor = true;
			this.ButtonRestaurer.Click += new System.EventHandler(this.ButtonRestaurer_Click);
			// 
			// ButtonLstArchives
			// 
			resources.ApplyResources(this.ButtonLstArchives, "ButtonLstArchives");
			this.ButtonLstArchives.Name = "ButtonLstArchives";
			this.ButtonLstArchives.UseVisualStyleBackColor = true;
			this.ButtonLstArchives.Click += new System.EventHandler(this.ButtonLstArchives_Click);
			// 
			// ButtonArchiver
			// 
			resources.ApplyResources(this.ButtonArchiver, "ButtonArchiver");
			this.ButtonArchiver.Name = "ButtonArchiver";
			this.ButtonArchiver.UseVisualStyleBackColor = true;
			this.ButtonArchiver.Click += new System.EventHandler(this.ButtonArchiver_Click);
			// 
			// ButtonDetails
			// 
			resources.ApplyResources(this.ButtonDetails, "ButtonDetails");
			this.ButtonDetails.Name = "ButtonDetails";
			this.ButtonDetails.UseVisualStyleBackColor = true;
			this.ButtonDetails.Click += new System.EventHandler(this.ButtonDetails_Click);
			// 
			// BtnFermer
			// 
			resources.ApplyResources(this.BtnFermer, "BtnFermer");
			this.BtnFermer.Name = "BtnFermer";
			this.BtnFermer.UseVisualStyleBackColor = true;
			this.BtnFermer.Click += new System.EventHandler(this.BtnFermer_Click);
			// 
			// BtnAjouter
			// 
			resources.ApplyResources(this.BtnAjouter, "BtnAjouter");
			this.BtnAjouter.Name = "BtnAjouter";
			this.BtnAjouter.UseVisualStyleBackColor = true;
			this.BtnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
			// 
			// apiSocieteAuto1
			// 
			this.apiSocieteAuto1.CacheOneSoc = true;
			resources.ApplyResources(this.apiSocieteAuto1, "apiSocieteAuto1");
			this.apiSocieteAuto1.IdMenuParent = ((short)(44));
			this.apiSocieteAuto1.ListIndex = ((short)(-1));
			this.apiSocieteAuto1.Name = "apiSocieteAuto1";
			this.apiSocieteAuto1.Change += new MozartUC.apiSocieteAuto.ChangeEventHandler(this.apiSocieteAuto1_Change);
			// 
			// LabelTitre
			// 
			resources.ApplyResources(this.LabelTitre, "LabelTitre");
			this.LabelTitre.Name = "LabelTitre";
			// 
			// apiTGrid1
			// 
			resources.ApplyResources(this.apiTGrid1, "apiTGrid1");
			this.apiTGrid1.CounterColumn = null;
			this.apiTGrid1.FilterBar = true;
			this.apiTGrid1.FooterBar = true;
			this.apiTGrid1.Name = "apiTGrid1";
			this.apiTGrid1.DoubleClickE += new MozartUC.apiTGrid.DoubleClickEEventHandler(this.apiTGrid1_DoubleClickE);
			this.apiTGrid1.RowCellStyle += new MozartUC.apiTGrid.RowCellStyleEventHandler(this.apiTGrid1_RowCellStyle);
			this.apiTGrid1.RowStyle += new MozartUC.apiTGrid.RowStyleEventHandler(this.apiTGrid1_RowStyle);
			// 
			// Frame1
			// 
			this.Frame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.Frame1.Controls.Add(this.apiLabel2);
			this.Frame1.Controls.Add(this.Command1);
			this.Frame1.Controls.Add(this.Label25);
			this.Frame1.Controls.Add(this.Label24);
			this.Frame1.Controls.Add(this.Label12);
			resources.ApplyResources(this.Frame1, "Frame1");
			this.Frame1.FrameColor = System.Drawing.Color.Empty;
			this.Frame1.HelpContextID = 0;
			this.Frame1.Name = "Frame1";
			this.Frame1.TabStop = false;
			// 
			// apiLabel2
			// 
			this.apiLabel2.BackColor = System.Drawing.Color.Orange;
			this.apiLabel2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.apiLabel2.HelpContextID = 0;
			resources.ApplyResources(this.apiLabel2, "apiLabel2");
			this.apiLabel2.Name = "apiLabel2";
			// 
			// Command1
			// 
			this.Command1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Command1.HelpContextID = 0;
			resources.ApplyResources(this.Command1, "Command1");
			this.Command1.Name = "Command1";
			this.Command1.UseVisualStyleBackColor = true;
			this.Command1.Click += new System.EventHandler(this.Command1_Click);
			// 
			// Label25
			// 
			resources.ApplyResources(this.Label25, "Label25");
			this.Label25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.Label25.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label25.HelpContextID = 0;
			this.Label25.Name = "Label25";
			// 
			// Label24
			// 
			resources.ApplyResources(this.Label24, "Label24");
			this.Label24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.Label24.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label24.HelpContextID = 0;
			this.Label24.Name = "Label24";
			// 
			// Label12
			// 
			this.Label12.BackColor = System.Drawing.Color.SpringGreen;
			this.Label12.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label12.HelpContextID = 0;
			resources.ApplyResources(this.Label12, "Label12");
			this.Label12.Name = "Label12";
			// 
			// cmdLegende
			// 
			resources.ApplyResources(this.cmdLegende, "cmdLegende");
			this.cmdLegende.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdLegende.HelpContextID = 0;
			this.cmdLegende.Name = "cmdLegende";
			this.cmdLegende.UseVisualStyleBackColor = true;
			this.cmdLegende.Click += new System.EventHandler(this.cmdLegende_Click);
			// 
			// button1
			// 
			resources.ApplyResources(this.button1, "button1");
			this.button1.Name = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// frmListeVehicules
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Wheat;
			this.Controls.Add(this.button1);
			this.Controls.Add(this.cmdLegende);
			this.Controls.Add(this.Frame1);
			this.Controls.Add(this.apiTGrid1);
			this.Controls.Add(this.apiSocieteAuto1);
			this.Controls.Add(this.LabelTitre);
			this.Controls.Add(this.ButtonRestaurer);
			this.Controls.Add(this.ButtonLstArchives);
			this.Controls.Add(this.ButtonArchiver);
			this.Controls.Add(this.ButtonDetails);
			this.Controls.Add(this.BtnFermer);
			this.Controls.Add(this.BtnAjouter);
			this.Name = "frmListeVehicules";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmListeVehicules_Load);
			this.Frame1.ResumeLayout(false);
			this.Frame1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion
    internal System.Windows.Forms.Button ButtonRestaurer;
    internal System.Windows.Forms.Button ButtonLstArchives;
    internal System.Windows.Forms.Button ButtonArchiver;
    internal System.Windows.Forms.Button ButtonDetails;
    internal System.Windows.Forms.Button BtnFermer;
    internal System.Windows.Forms.Button BtnAjouter;
    internal MozartUC.apiSocieteAuto apiSocieteAuto1;
    internal System.Windows.Forms.Label LabelTitre;
    private MozartUC.apiTGrid apiTGrid1;
        private MozartUC.apiGroupBox Frame1;
        private MozartUC.apiLabel apiLabel2;
        private MozartUC.apiButton Command1;
        private MozartUC.apiLabel Label25;
        private MozartUC.apiLabel Label24;
        private MozartUC.apiLabel Label12;
        private MozartUC.apiButton cmdLegende;
		internal System.Windows.Forms.Button button1;
	}
}