namespace MozartCS
{
  partial class frmGestNotes
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestNotes));
			this.cmdFermer = new MozartUC.apiButton();
			this.Fram5 = new MozartUC.apiGroupBox();
			this.txtMessage = new MozartUC.apiTextBox();
			this.cmdEnvoyer = new MozartUC.apiButton();
			this.cmdSupp = new MozartUC.apiButton();
			this.Frame1 = new MozartUC.apiGroupBox();
			this.txtFields4 = new MozartUC.apiTextBox();
			this.apiTGridMess = new MozartUC.apiTGrid();
			this.Label1 = new MozartUC.apiLabel();
			this.Fram5.SuspendLayout();
			this.Frame1.SuspendLayout();
			this.SuspendLayout();
			// 
			// cmdFermer
			// 
			resources.ApplyResources(this.cmdFermer, "cmdFermer");
			this.cmdFermer.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdFermer.HelpContextID = 0;
			this.cmdFermer.Name = "cmdFermer";
			this.cmdFermer.Tag = "15";
			this.cmdFermer.UseVisualStyleBackColor = true;
			this.cmdFermer.Click += new System.EventHandler(this.cmdFermer_Click);
			// 
			// Fram5
			// 
			this.Fram5.BackColor = System.Drawing.Color.Wheat;
			this.Fram5.Controls.Add(this.txtMessage);
			this.Fram5.Controls.Add(this.cmdEnvoyer);
			resources.ApplyResources(this.Fram5, "Fram5");
			this.Fram5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.Fram5.FrameColor = System.Drawing.Color.Empty;
			this.Fram5.HelpContextID = 0;
			this.Fram5.Name = "Fram5";
			this.Fram5.TabStop = false;
			// 
			// txtMessage
			// 
			this.txtMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			resources.ApplyResources(this.txtMessage, "txtMessage");
			this.txtMessage.ForeColor = System.Drawing.SystemColors.ControlText;
			this.txtMessage.HelpContextID = 0;
			this.txtMessage.Name = "txtMessage";
			// 
			// cmdEnvoyer
			// 
			this.cmdEnvoyer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			resources.ApplyResources(this.cmdEnvoyer, "cmdEnvoyer");
			this.cmdEnvoyer.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdEnvoyer.HelpContextID = 0;
			this.cmdEnvoyer.Name = "cmdEnvoyer";
			this.cmdEnvoyer.UseVisualStyleBackColor = false;
			this.cmdEnvoyer.Click += new System.EventHandler(this.cmdEnvoyer_Click);
			// 
			// cmdSupp
			// 
			resources.ApplyResources(this.cmdSupp, "cmdSupp");
			this.cmdSupp.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdSupp.HelpContextID = 0;
			this.cmdSupp.Name = "cmdSupp";
			this.cmdSupp.Tag = "27";
			this.cmdSupp.UseVisualStyleBackColor = true;
			this.cmdSupp.Click += new System.EventHandler(this.cmdSupp_Click);
			// 
			// Frame1
			// 
			this.Frame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.Frame1.Controls.Add(this.txtFields4);
			this.Frame1.Controls.Add(this.apiTGridMess);
			resources.ApplyResources(this.Frame1, "Frame1");
			this.Frame1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.Frame1.FrameColor = System.Drawing.Color.Empty;
			this.Frame1.HelpContextID = 0;
			this.Frame1.Name = "Frame1";
			this.Frame1.TabStop = false;
			// 
			// txtFields4
			// 
			this.txtFields4.BackColor = System.Drawing.Color.White;
			resources.ApplyResources(this.txtFields4, "txtFields4");
			this.txtFields4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.txtFields4.HelpContextID = 0;
			this.txtFields4.Name = "txtFields4";
			this.txtFields4.ReadOnly = true;
			// 
			// apiTGridMess
			// 
			this.apiTGridMess.FilterBar = true;
			this.apiTGridMess.FooterBar = true;
			resources.ApplyResources(this.apiTGridMess, "apiTGridMess");
			this.apiTGridMess.Name = "apiTGridMess";
			this.apiTGridMess.SelectionChanged += new MozartUC.apiTGrid.SelectionChangedEventHandler(this.apiTGridMess_SelectionChanged);
			// 
			// Label1
			// 
			this.Label1.BackColor = System.Drawing.Color.Wheat;
			resources.ApplyResources(this.Label1, "Label1");
			this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label1.HelpContextID = 0;
			this.Label1.Name = "Label1";
			// 
			// frmGestNotes
			// 
			this.BackColor = System.Drawing.Color.Wheat;
			resources.ApplyResources(this, "$this");
			this.Controls.Add(this.cmdFermer);
			this.Controls.Add(this.Fram5);
			this.Controls.Add(this.cmdSupp);
			this.Controls.Add(this.Frame1);
			this.Controls.Add(this.Label1);
			this.Name = "frmGestNotes";
			this.ShowInTaskbar = false;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmGestMessageWebSTT_Load);
			this.Fram5.ResumeLayout(false);
			this.Fram5.PerformLayout();
			this.Frame1.ResumeLayout(false);
			this.Frame1.PerformLayout();
			this.ResumeLayout(false);

    }

    #endregion

    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiTextBox txtMessage;
    private MozartUC.apiButton cmdEnvoyer;
    private MozartUC.apiGroupBox Fram5;
    private MozartUC.apiButton cmdSupp;
    private MozartUC.apiTextBox txtFields4;
    private MozartUC.apiTGrid apiTGridMess;
    private MozartUC.apiGroupBox Frame1;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line
    private MozartUC.apiLabel Label1;

  }
}
