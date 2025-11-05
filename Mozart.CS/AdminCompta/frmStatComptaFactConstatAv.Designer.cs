
namespace MozartCS.AdminCompta
{
  partial class frmStatComptaFactConstatAv
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
      this.Frame3 = new MozartUC.apiGroupBox();
      this.Calendar1 = new System.Windows.Forms.DateTimePicker();
      this.cmdValider = new MozartUC.apiButton();
      this.txtDateA0 = new MozartUC.apiTextBox();
      this.cmdDate1 = new MozartUC.apiButton();
      this.Label3 = new MozartUC.apiLabel();
      this.lblLabels12 = new MozartUC.apiLabel();
      this.Frame1 = new MozartUC.apiGroupBox();
      this.apiTGridH = new MozartUC.apiTGrid();
      this.lblLabels6 = new MozartUC.apiLabel();
      this.lblTHTh = new MozartUC.apiLabel();
      this.cmdFermer = new MozartUC.apiButton();
      this.cmdDI = new MozartUC.apiButton();
      this.Frame3.SuspendLayout();
      this.Frame1.SuspendLayout();
      this.SuspendLayout();
      // 
      // Frame3
      // 
      this.Frame3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.Frame3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      this.Frame3.Controls.Add(this.Calendar1);
      this.Frame3.Controls.Add(this.cmdValider);
      this.Frame3.Controls.Add(this.txtDateA0);
      this.Frame3.Controls.Add(this.cmdDate1);
      this.Frame3.Controls.Add(this.Label3);
      this.Frame3.Controls.Add(this.lblLabels12);
      this.Frame3.FrameColor = System.Drawing.Color.Empty;
      this.Frame3.HelpContextID = 0;
      this.Frame3.Location = new System.Drawing.Point(106, 12);
      this.Frame3.Name = "Frame3";
      this.Frame3.Size = new System.Drawing.Size(971, 87);
      this.Frame3.TabIndex = 6;
      this.Frame3.TabStop = false;
      // 
      // Calendar1
      // 
      this.Calendar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(132)))));
      this.Calendar1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.Calendar1.Location = new System.Drawing.Point(440, 33);
      this.Calendar1.Name = "Calendar1";
      this.Calendar1.Size = new System.Drawing.Size(91, 20);
      this.Calendar1.TabIndex = 10;
      this.Calendar1.Visible = false;
      this.Calendar1.ValueChanged += new System.EventHandler(this.Calendar1_ValueChanged);
      // 
      // cmdValider
      // 
      this.cmdValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
      this.cmdValider.HelpContextID = 0;
      this.cmdValider.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.cmdValider.Location = new System.Drawing.Point(344, 38);
      this.cmdValider.Name = "cmdValider";
      this.cmdValider.Size = new System.Drawing.Size(55, 35);
      this.cmdValider.TabIndex = 7;
      this.cmdValider.Text = "Valider";
      this.cmdValider.UseVisualStyleBackColor = true;
      this.cmdValider.Click += new System.EventHandler(this.cmdValider_Click);
      // 
      // txtDateA0
      // 
      this.txtDateA0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.txtDateA0.Enabled = false;
      this.txtDateA0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
      this.txtDateA0.HelpContextID = 0;
      this.txtDateA0.Location = new System.Drawing.Point(136, 45);
      this.txtDateA0.Name = "txtDateA0";
      this.txtDateA0.Size = new System.Drawing.Size(129, 20);
      this.txtDateA0.TabIndex = 6;
      // 
      // cmdDate1
      // 
      this.cmdDate1.BackColor = System.Drawing.Color.Transparent;
      this.cmdDate1.BackgroundImage = global::MozartCS.Properties.Resources.calendar;
      this.cmdDate1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
      this.cmdDate1.HelpContextID = 0;
      this.cmdDate1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.cmdDate1.Location = new System.Drawing.Point(281, 38);
      this.cmdDate1.Name = "cmdDate1";
      this.cmdDate1.Size = new System.Drawing.Size(32, 35);
      this.cmdDate1.TabIndex = 5;
      this.cmdDate1.Tag = "5";
      this.cmdDate1.UseVisualStyleBackColor = false;
      this.cmdDate1.Click += new System.EventHandler(this.cmdDate1_Click);
      // 
      // Label3
      // 
      this.Label3.AutoSize = true;
      this.Label3.BackColor = System.Drawing.Color.Transparent;
      this.Label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
      this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label3.HelpContextID = 0;
      this.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.Label3.Location = new System.Drawing.Point(16, 13);
      this.Label3.Name = "Label3";
      this.Label3.Size = new System.Drawing.Size(627, 22);
      this.Label3.TabIndex = 9;
      this.Label3.Text = "Etats des contrats STT exécutés,  dont il manque la facture du STT";
      // 
      // lblLabels12
      // 
      this.lblLabels12.BackColor = System.Drawing.Color.Transparent;
      this.lblLabels12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
      this.lblLabels12.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels12.HelpContextID = 0;
      this.lblLabels12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblLabels12.Location = new System.Drawing.Point(16, 47);
      this.lblLabels12.Name = "lblLabels12";
      this.lblLabels12.Size = new System.Drawing.Size(112, 17);
      this.lblLabels12.TabIndex = 8;
      this.lblLabels12.Text = "Date de référence :";
      // 
      // Frame1
      // 
      this.Frame1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.Frame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      this.Frame1.Controls.Add(this.apiTGridH);
      this.Frame1.Controls.Add(this.lblLabels6);
      this.Frame1.Controls.Add(this.lblTHTh);
      this.Frame1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
      this.Frame1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Frame1.FrameColor = System.Drawing.Color.Empty;
      this.Frame1.HelpContextID = 0;
      this.Frame1.Location = new System.Drawing.Point(106, 105);
      this.Frame1.Name = "Frame1";
      this.Frame1.Size = new System.Drawing.Size(1264, 505);
      this.Frame1.TabIndex = 8;
      this.Frame1.TabStop = false;
      this.Frame1.Text = "Liste des actions exécutées chiffrées, non facturées, réalisées par $ste";
      // 
      // apiTGridH
      // 
      this.apiTGridH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.apiTGridH.FilterBar = true;
      this.apiTGridH.FooterBar = true;
      this.apiTGridH.Location = new System.Drawing.Point(19, 16);
      this.apiTGridH.Name = "apiTGridH";
      this.apiTGridH.Size = new System.Drawing.Size(1239, 456);
      this.apiTGridH.TabIndex = 3;
      this.apiTGridH.ColumnFilterChanged += new MozartUC.apiTGrid.ColumnFilterChangedEventHandler(this.apiTGridH_ColumnFilterChanged);
      // 
      // lblLabels6
      // 
      this.lblLabels6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.lblLabels6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      this.lblLabels6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
      this.lblLabels6.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels6.HelpContextID = 0;
      this.lblLabels6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblLabels6.Location = new System.Drawing.Point(875, 478);
      this.lblLabels6.Name = "lblLabels6";
      this.lblLabels6.Size = new System.Drawing.Size(63, 18);
      this.lblLabels6.TabIndex = 12;
      this.lblLabels6.Text = "Total  :";
      // 
      // lblTHTh
      // 
      this.lblTHTh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.lblTHTh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      this.lblTHTh.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
      this.lblTHTh.ForeColor = System.Drawing.Color.Red;
      this.lblTHTh.HelpContextID = 0;
      this.lblTHTh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblTHTh.Location = new System.Drawing.Point(944, 478);
      this.lblTHTh.Name = "lblTHTh";
      this.lblTHTh.Size = new System.Drawing.Size(314, 19);
      this.lblTHTh.TabIndex = 11;
      this.lblTHTh.Text = "Total HT";
      this.lblTHTh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // cmdFermer
      // 
      this.cmdFermer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.cmdFermer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      this.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cmdFermer.HelpContextID = 0;
      this.cmdFermer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.cmdFermer.Location = new System.Drawing.Point(12, 553);
      this.cmdFermer.Name = "cmdFermer";
      this.cmdFermer.Size = new System.Drawing.Size(73, 57);
      this.cmdFermer.TabIndex = 9;
      this.cmdFermer.Tag = "15";
      this.cmdFermer.Text = "Fermer";
      this.cmdFermer.UseVisualStyleBackColor = false;
      // 
      // cmdDI
      // 
      this.cmdDI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(198)))), ((int)(((byte)(229)))));
      this.cmdDI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
      this.cmdDI.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdDI.HelpContextID = 0;
      this.cmdDI.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.cmdDI.Location = new System.Drawing.Point(12, 121);
      this.cmdDI.Name = "cmdDI";
      this.cmdDI.Size = new System.Drawing.Size(73, 57);
      this.cmdDI.TabIndex = 37;
      this.cmdDI.Tag = "19";
      this.cmdDI.Text = "Détails DI";
      this.cmdDI.UseVisualStyleBackColor = false;
      this.cmdDI.Click += new System.EventHandler(this.cmdDI_Click);
      // 
      // frmStatComptaFactConstatAv
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
      this.CancelButton = this.cmdFermer;
      this.ClientSize = new System.Drawing.Size(1382, 622);
      this.Controls.Add(this.cmdDI);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.Frame1);
      this.Controls.Add(this.Frame3);
      this.Name = "frmStatComptaFactConstatAv";
      this.Text = "frmStatComptaFactConstatAv";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmStatComptaFactConstatAv_Load);
      this.Frame3.ResumeLayout(false);
      this.Frame3.PerformLayout();
      this.Frame1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private MozartUC.apiGroupBox Frame3;
    private MozartUC.apiButton cmdValider;
    private MozartUC.apiTextBox txtDateA0;
    private MozartUC.apiButton cmdDate1;
    private MozartUC.apiLabel Label3;
    private MozartUC.apiLabel lblLabels12;
    private MozartUC.apiGroupBox Frame1;
    private MozartUC.apiTGrid apiTGridH;
    private MozartUC.apiLabel lblLabels6;
    private MozartUC.apiLabel lblTHTh;
    private MozartUC.apiButton cmdFermer;
    private System.Windows.Forms.DateTimePicker Calendar1;
    private MozartUC.apiButton cmdDI;
  }
}