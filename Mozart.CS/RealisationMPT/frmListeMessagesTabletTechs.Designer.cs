
namespace MozartCS.RealisationMPT
{
  partial class frmListeMessagesTabletTechs
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
      this.cmdQuitter = new MozartUC.apiButton();
      this.apiTGrid = new MozartUC.apiTGrid();
      this.Label1 = new System.Windows.Forms.Label();
      this.Frame1 = new MozartUC.apiGroupBox();
      this.Calendar1 = new System.Windows.Forms.DateTimePicker();
      this.CmdValid = new MozartUC.apiButton();
      this.cmdDate1 = new MozartUC.apiButton();
      this.txtDateA0 = new MozartUC.apiTextBox();
      this.cmdDate2 = new MozartUC.apiButton();
      this.txtDateA1 = new MozartUC.apiTextBox();
      this.lblLabels12 = new MozartUC.apiLabel();
      this.lblLabels0 = new MozartUC.apiLabel();
      this.BtnDetail = new MozartUC.apiButton();
      this.Frame1.SuspendLayout();
      this.SuspendLayout();
      // 
      // cmdQuitter
      // 
      this.cmdQuitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.cmdQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
      this.cmdQuitter.HelpContextID = 0;
      this.cmdQuitter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.cmdQuitter.Location = new System.Drawing.Point(12, 834);
      this.cmdQuitter.Name = "cmdQuitter";
      this.cmdQuitter.Size = new System.Drawing.Size(73, 57);
      this.cmdQuitter.TabIndex = 4;
      this.cmdQuitter.Tag = "15";
      this.cmdQuitter.Text = "Quitter";
      this.cmdQuitter.UseVisualStyleBackColor = true;
      this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
      // 
      // apiTGrid
      // 
      this.apiTGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.apiTGrid.FilterBar = true;
      this.apiTGrid.FooterBar = true;
      this.apiTGrid.Location = new System.Drawing.Point(100, 110);
      this.apiTGrid.Name = "apiTGrid";
      this.apiTGrid.Size = new System.Drawing.Size(1153, 784);
      this.apiTGrid.TabIndex = 5;
      // 
      // Label1
      // 
      this.Label1.AutoSize = true;
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
      this.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.Label1.Location = new System.Drawing.Point(100, 7);
      this.Label1.Name = "Label1";
      this.Label1.Size = new System.Drawing.Size(478, 29);
      this.Label1.TabIndex = 6;
      this.Label1.Text = "Liste des messages tablettes technicien";
      // 
      // Frame1
      // 
      this.Frame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.Frame1.Controls.Add(this.Calendar1);
      this.Frame1.Controls.Add(this.CmdValid);
      this.Frame1.Controls.Add(this.cmdDate1);
      this.Frame1.Controls.Add(this.txtDateA0);
      this.Frame1.Controls.Add(this.cmdDate2);
      this.Frame1.Controls.Add(this.txtDateA1);
      this.Frame1.Controls.Add(this.lblLabels12);
      this.Frame1.Controls.Add(this.lblLabels0);
      this.Frame1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
      this.Frame1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Frame1.FrameColor = System.Drawing.Color.Empty;
      this.Frame1.HelpContextID = 0;
      this.Frame1.Location = new System.Drawing.Point(100, 39);
      this.Frame1.Name = "Frame1";
      this.Frame1.Size = new System.Drawing.Size(881, 65);
      this.Frame1.TabIndex = 7;
      this.Frame1.TabStop = false;
      this.Frame1.Text = "Choix de la période";
      // 
      // Calendar1
      // 
      this.Calendar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(132)))));
      this.Calendar1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.Calendar1.Location = new System.Drawing.Point(297, 44);
      this.Calendar1.Name = "Calendar1";
      this.Calendar1.Size = new System.Drawing.Size(120, 21);
      this.Calendar1.TabIndex = 14;
      this.Calendar1.Visible = false;
      this.Calendar1.CloseUp += new System.EventHandler(this.Calendar1_CloseUp);
      this.Calendar1.ValueChanged += new System.EventHandler(this.Calendar1_ValueChanged);
      // 
      // CmdValid
      // 
      this.CmdValid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.CmdValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
      this.CmdValid.ForeColor = System.Drawing.SystemColors.ControlText;
      this.CmdValid.HelpContextID = 0;
      this.CmdValid.Image = global::MozartCS.Properties.Resources.ok_32;
      this.CmdValid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.CmdValid.Location = new System.Drawing.Point(623, 12);
      this.CmdValid.Name = "CmdValid";
      this.CmdValid.Size = new System.Drawing.Size(56, 41);
      this.CmdValid.TabIndex = 11;
      this.CmdValid.Tag = "29";
      this.CmdValid.UseVisualStyleBackColor = false;
      this.CmdValid.Click += new System.EventHandler(this.CmdValid_Click);
      // 
      // cmdDate1
      // 
      this.cmdDate1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.cmdDate1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
      this.cmdDate1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdDate1.HelpContextID = 0;
      this.cmdDate1.Image = global::MozartCS.Properties.Resources.calendar;
      this.cmdDate1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.cmdDate1.Location = new System.Drawing.Point(251, 12);
      this.cmdDate1.Name = "cmdDate1";
      this.cmdDate1.Size = new System.Drawing.Size(40, 35);
      this.cmdDate1.TabIndex = 5;
      this.cmdDate1.Tag = "5";
      this.cmdDate1.UseVisualStyleBackColor = false;
      this.cmdDate1.Click += new System.EventHandler(this.cmdDate1_Click);
      // 
      // txtDateA0
      // 
      this.txtDateA0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.txtDateA0.Enabled = false;
      this.txtDateA0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
      this.txtDateA0.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtDateA0.HelpContextID = 0;
      this.txtDateA0.Location = new System.Drawing.Point(111, 20);
      this.txtDateA0.Name = "txtDateA0";
      this.txtDateA0.Size = new System.Drawing.Size(137, 20);
      this.txtDateA0.TabIndex = 4;
      // 
      // cmdDate2
      // 
      this.cmdDate2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.cmdDate2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
      this.cmdDate2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdDate2.HelpContextID = 0;
      this.cmdDate2.Image = global::MozartCS.Properties.Resources.calendar;
      this.cmdDate2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.cmdDate2.Location = new System.Drawing.Point(542, 12);
      this.cmdDate2.Name = "cmdDate2";
      this.cmdDate2.Size = new System.Drawing.Size(40, 35);
      this.cmdDate2.TabIndex = 3;
      this.cmdDate2.Tag = "5";
      this.cmdDate2.UseVisualStyleBackColor = false;
      this.cmdDate2.Click += new System.EventHandler(this.cmdDate1_Click);
      // 
      // txtDateA1
      // 
      this.txtDateA1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.txtDateA1.Enabled = false;
      this.txtDateA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
      this.txtDateA1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtDateA1.HelpContextID = 0;
      this.txtDateA1.Location = new System.Drawing.Point(399, 20);
      this.txtDateA1.Name = "txtDateA1";
      this.txtDateA1.Size = new System.Drawing.Size(137, 20);
      this.txtDateA1.TabIndex = 2;
      // 
      // lblLabels12
      // 
      this.lblLabels12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.lblLabels12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
      this.lblLabels12.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels12.HelpContextID = 0;
      this.lblLabels12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblLabels12.Location = new System.Drawing.Point(15, 24);
      this.lblLabels12.Name = "lblLabels12";
      this.lblLabels12.Size = new System.Drawing.Size(97, 17);
      this.lblLabels12.TabIndex = 8;
      this.lblLabels12.Text = "Date de début :";
      // 
      // lblLabels0
      // 
      this.lblLabels0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.lblLabels0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
      this.lblLabels0.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels0.HelpContextID = 0;
      this.lblLabels0.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblLabels0.Location = new System.Drawing.Point(320, 24);
      this.lblLabels0.Name = "lblLabels0";
      this.lblLabels0.Size = new System.Drawing.Size(97, 17);
      this.lblLabels0.TabIndex = 7;
      this.lblLabels0.Text = "Date de fin :";
      // 
      // BtnDetail
      // 
      this.BtnDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
      this.BtnDetail.HelpContextID = 0;
      this.BtnDetail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.BtnDetail.Location = new System.Drawing.Point(12, 156);
      this.BtnDetail.Name = "BtnDetail";
      this.BtnDetail.Size = new System.Drawing.Size(73, 57);
      this.BtnDetail.TabIndex = 8;
      this.BtnDetail.Tag = "15";
      this.BtnDetail.Text = "Détails";
      this.BtnDetail.UseVisualStyleBackColor = true;
      this.BtnDetail.Click += new System.EventHandler(this.BtnDetail_Click);
      // 
      // frmListeMessagesTabletTechs
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Wheat;
      this.ClientSize = new System.Drawing.Size(1531, 931);
      this.Controls.Add(this.BtnDetail);
      this.Controls.Add(this.Frame1);
      this.Controls.Add(this.cmdQuitter);
      this.Controls.Add(this.apiTGrid);
      this.Controls.Add(this.Label1);
      this.Name = "frmListeMessagesTabletTechs";
      this.Text = "Liste des messages tablettes technicien";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmListeMessagesTabletTechs_Load);
      this.Frame1.ResumeLayout(false);
      this.Frame1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdQuitter;
    private MozartUC.apiTGrid apiTGrid;
    private System.Windows.Forms.Label Label1;
    private MozartUC.apiGroupBox Frame1;
    private MozartUC.apiButton CmdValid;
    private MozartUC.apiButton cmdDate1;
    private MozartUC.apiTextBox txtDateA0;
    private MozartUC.apiButton cmdDate2;
    private MozartUC.apiTextBox txtDateA1;
    private MozartUC.apiLabel lblLabels12;
    private MozartUC.apiLabel lblLabels0;
    private System.Windows.Forms.DateTimePicker Calendar1;
    private MozartUC.apiButton BtnDetail;
  }
}