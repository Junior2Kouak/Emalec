
using DevExpress.XtraBars.Navigation;

namespace MozartCS
{
  partial class frmTotalDaisy
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTotalDaisy));
      this.cmdQuitter = new MozartUC.apiButton();
      this.tabPanGetList = new DevExpress.XtraBars.Navigation.TabPane();
      this.tabDeclarerPassageGTI = new DevExpress.XtraBars.Navigation.TabNavigationPage();
      this.cmdDeclarerPassageGTI = new MozartUC.apiButton();
      this.datePassageGTI = new DevExpress.XtraEditors.DateEdit();
      this.txtNotes = new MozartUC.apiTextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.lblDate = new System.Windows.Forms.Label();
      this.tabCloture = new DevExpress.XtraBars.Navigation.TabNavigationPage();
      this.cmdResoudre = new MozartUC.apiButton();
      this.dateInterReelle = new DevExpress.XtraEditors.DateEdit();
      this.txtNoteCloture = new MozartUC.apiTextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.cboTypeAction = new System.Windows.Forms.ComboBox();
      this.label5 = new System.Windows.Forms.Label();
      this.cboTypeInter = new System.Windows.Forms.ComboBox();
      this.label4 = new System.Windows.Forms.Label();
      this.cboCauseRacine = new System.Windows.Forms.ComboBox();
      this.label3 = new System.Windows.Forms.Label();
      this.cboCodeCloture = new System.Windows.Forms.ComboBox();
      this.label2 = new System.Windows.Forms.Label();
      this.tabInsererPJ = new DevExpress.XtraBars.Navigation.TabNavigationPage();
      this.cboListeFichier = new System.Windows.Forms.ComboBox();
      this.label8 = new System.Windows.Forms.Label();
      this.cmdImporter = new MozartUC.apiButton();
      this.tabGetList = new DevExpress.XtraBars.Navigation.TabNavigationPage();
      this.txtResult = new MozartUC.apiTextBox();
      this.cmdGetList = new MozartUC.apiButton();
      this.txtResponse = new MozartUC.apiTextBox();
      this.lblResponse = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.tabPanGetList)).BeginInit();
      this.tabPanGetList.SuspendLayout();
      this.tabDeclarerPassageGTI.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.datePassageGTI.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.datePassageGTI.Properties.CalendarTimeProperties)).BeginInit();
      this.tabCloture.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dateInterReelle.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dateInterReelle.Properties.CalendarTimeProperties)).BeginInit();
      this.tabInsererPJ.SuspendLayout();
      this.tabGetList.SuspendLayout();
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
      // 
      // tabPanGetList
      // 
      resources.ApplyResources(this.tabPanGetList, "tabPanGetList");
      this.tabPanGetList.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
      this.tabPanGetList.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("tabPanGetList.Appearance.Font")));
      this.tabPanGetList.Appearance.Options.UseBackColor = true;
      this.tabPanGetList.Appearance.Options.UseFont = true;
      this.tabPanGetList.AppearanceButton.Hovered.Font = ((System.Drawing.Font)(resources.GetObject("tabPanGetList.AppearanceButton.Hovered.Font")));
      this.tabPanGetList.AppearanceButton.Hovered.Options.UseFont = true;
      this.tabPanGetList.AppearanceButton.Pressed.BackColor = System.Drawing.Color.DarkOrange;
      this.tabPanGetList.AppearanceButton.Pressed.BorderColor = System.Drawing.Color.DarkOrange;
      this.tabPanGetList.AppearanceButton.Pressed.Font = ((System.Drawing.Font)(resources.GetObject("tabPanGetList.AppearanceButton.Pressed.Font")));
      this.tabPanGetList.AppearanceButton.Pressed.Options.UseBackColor = true;
      this.tabPanGetList.AppearanceButton.Pressed.Options.UseBorderColor = true;
      this.tabPanGetList.AppearanceButton.Pressed.Options.UseFont = true;
      this.tabPanGetList.AppearanceButton.Pressed.Options.UseForeColor = true;
      this.tabPanGetList.Controls.Add(this.tabDeclarerPassageGTI);
      this.tabPanGetList.Controls.Add(this.tabCloture);
      this.tabPanGetList.Controls.Add(this.tabInsererPJ);
      this.tabPanGetList.Controls.Add(this.tabGetList);
      this.tabPanGetList.Name = "tabPanGetList";
      this.tabPanGetList.PageProperties.AppearanceCaption.BackColor = System.Drawing.Color.DarkOrange;
      this.tabPanGetList.PageProperties.AppearanceCaption.BorderColor = System.Drawing.Color.DarkOrange;
      this.tabPanGetList.PageProperties.AppearanceCaption.Options.UseBackColor = true;
      this.tabPanGetList.PageProperties.AppearanceCaption.Options.UseBorderColor = true;
      this.tabPanGetList.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabDeclarerPassageGTI,
            this.tabInsererPJ,
            this.tabCloture,
            this.tabGetList});
      this.tabPanGetList.RegularSize = new System.Drawing.Size(909, 437);
      this.tabPanGetList.SelectedPage = this.tabDeclarerPassageGTI;
      // 
      // tabDeclarerPassageGTI
      // 
      this.tabDeclarerPassageGTI.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("tabDeclarerPassageGTI.Appearance.Font")));
      this.tabDeclarerPassageGTI.Appearance.Options.UseFont = true;
      resources.ApplyResources(this.tabDeclarerPassageGTI, "tabDeclarerPassageGTI");
      this.tabDeclarerPassageGTI.Controls.Add(this.cmdDeclarerPassageGTI);
      this.tabDeclarerPassageGTI.Controls.Add(this.datePassageGTI);
      this.tabDeclarerPassageGTI.Controls.Add(this.txtNotes);
      this.tabDeclarerPassageGTI.Controls.Add(this.label1);
      this.tabDeclarerPassageGTI.Controls.Add(this.lblDate);
      this.tabDeclarerPassageGTI.Name = "tabDeclarerPassageGTI";
      this.tabDeclarerPassageGTI.Properties.AppearanceCaption.BackColor = System.Drawing.Color.DarkOrange;
      this.tabDeclarerPassageGTI.Properties.AppearanceCaption.BorderColor = System.Drawing.Color.DarkOrange;
      this.tabDeclarerPassageGTI.Properties.AppearanceCaption.Font = ((System.Drawing.Font)(resources.GetObject("tabDeclarerPassageGTI.Properties.AppearanceCaption.Font")));
      this.tabDeclarerPassageGTI.Properties.AppearanceCaption.Options.UseBackColor = true;
      this.tabDeclarerPassageGTI.Properties.AppearanceCaption.Options.UseBorderColor = true;
      this.tabDeclarerPassageGTI.Properties.AppearanceCaption.Options.UseFont = true;
      this.tabDeclarerPassageGTI.Properties.AppearanceCaption.Options.UseForeColor = true;
      // 
      // cmdDeclarerPassageGTI
      // 
      resources.ApplyResources(this.cmdDeclarerPassageGTI, "cmdDeclarerPassageGTI");
      this.cmdDeclarerPassageGTI.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdDeclarerPassageGTI.HelpContextID = 182;
      this.cmdDeclarerPassageGTI.Name = "cmdDeclarerPassageGTI";
      this.cmdDeclarerPassageGTI.UseVisualStyleBackColor = true;
      this.cmdDeclarerPassageGTI.Click += new System.EventHandler(this.cmdDeclarerPassageGTI_Click);
      // 
      // datePassageGTI
      // 
      resources.ApplyResources(this.datePassageGTI, "datePassageGTI");
      this.datePassageGTI.Name = "datePassageGTI";
      this.datePassageGTI.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("datePassageGTI.Properties.Buttons"))))});
      this.datePassageGTI.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
      this.datePassageGTI.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("datePassageGTI.Properties.CalendarTimeProperties.Buttons"))))});
      this.datePassageGTI.Properties.DisplayFormat.FormatString = "G";
      this.datePassageGTI.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
      this.datePassageGTI.Properties.EditFormat.FormatString = "G";
      this.datePassageGTI.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
      this.datePassageGTI.Properties.MaskSettings.Set("mask", "G");
      // 
      // txtNotes
      // 
      this.txtNotes.HelpContextID = 0;
      resources.ApplyResources(this.txtNotes, "txtNotes");
      this.txtNotes.Name = "txtNotes";
      // 
      // label1
      // 
      resources.ApplyResources(this.label1, "label1");
      this.label1.Name = "label1";
      // 
      // lblDate
      // 
      resources.ApplyResources(this.lblDate, "lblDate");
      this.lblDate.Name = "lblDate";
      // 
      // tabCloture
      // 
      this.tabCloture.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
      this.tabCloture.Appearance.Options.UseBackColor = true;
      resources.ApplyResources(this.tabCloture, "tabCloture");
      this.tabCloture.Controls.Add(this.cmdResoudre);
      this.tabCloture.Controls.Add(this.dateInterReelle);
      this.tabCloture.Controls.Add(this.txtNoteCloture);
      this.tabCloture.Controls.Add(this.label6);
      this.tabCloture.Controls.Add(this.label7);
      this.tabCloture.Controls.Add(this.cboTypeAction);
      this.tabCloture.Controls.Add(this.label5);
      this.tabCloture.Controls.Add(this.cboTypeInter);
      this.tabCloture.Controls.Add(this.label4);
      this.tabCloture.Controls.Add(this.cboCauseRacine);
      this.tabCloture.Controls.Add(this.label3);
      this.tabCloture.Controls.Add(this.cboCodeCloture);
      this.tabCloture.Controls.Add(this.label2);
      this.tabCloture.Name = "tabCloture";
      // 
      // cmdResoudre
      // 
      resources.ApplyResources(this.cmdResoudre, "cmdResoudre");
      this.cmdResoudre.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdResoudre.HelpContextID = 182;
      this.cmdResoudre.Name = "cmdResoudre";
      this.cmdResoudre.UseVisualStyleBackColor = true;
      this.cmdResoudre.Click += new System.EventHandler(this.cmdResoudre_Click);
      // 
      // dateInterReelle
      // 
      resources.ApplyResources(this.dateInterReelle, "dateInterReelle");
      this.dateInterReelle.Name = "dateInterReelle";
      this.dateInterReelle.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("dateInterReelle.Properties.Buttons"))))});
      this.dateInterReelle.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
      this.dateInterReelle.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("dateInterReelle.Properties.CalendarTimeProperties.Buttons"))))});
      this.dateInterReelle.Properties.DisplayFormat.FormatString = "G";
      this.dateInterReelle.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
      this.dateInterReelle.Properties.EditFormat.FormatString = "G";
      this.dateInterReelle.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
      this.dateInterReelle.Properties.MaskSettings.Set("mask", "G");
      // 
      // txtNoteCloture
      // 
      this.txtNoteCloture.HelpContextID = 0;
      resources.ApplyResources(this.txtNoteCloture, "txtNoteCloture");
      this.txtNoteCloture.Name = "txtNoteCloture";
      // 
      // label6
      // 
      resources.ApplyResources(this.label6, "label6");
      this.label6.Name = "label6";
      // 
      // label7
      // 
      resources.ApplyResources(this.label7, "label7");
      this.label7.Name = "label7";
      // 
      // cboTypeAction
      // 
      this.cboTypeAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboTypeAction.FormattingEnabled = true;
      resources.ApplyResources(this.cboTypeAction, "cboTypeAction");
      this.cboTypeAction.Name = "cboTypeAction";
      // 
      // label5
      // 
      resources.ApplyResources(this.label5, "label5");
      this.label5.Name = "label5";
      // 
      // cboTypeInter
      // 
      this.cboTypeInter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboTypeInter.FormattingEnabled = true;
      resources.ApplyResources(this.cboTypeInter, "cboTypeInter");
      this.cboTypeInter.Name = "cboTypeInter";
      // 
      // label4
      // 
      resources.ApplyResources(this.label4, "label4");
      this.label4.Name = "label4";
      // 
      // cboCauseRacine
      // 
      this.cboCauseRacine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboCauseRacine.FormattingEnabled = true;
      resources.ApplyResources(this.cboCauseRacine, "cboCauseRacine");
      this.cboCauseRacine.Name = "cboCauseRacine";
      // 
      // label3
      // 
      resources.ApplyResources(this.label3, "label3");
      this.label3.Name = "label3";
      // 
      // cboCodeCloture
      // 
      this.cboCodeCloture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboCodeCloture.FormattingEnabled = true;
      resources.ApplyResources(this.cboCodeCloture, "cboCodeCloture");
      this.cboCodeCloture.Name = "cboCodeCloture";
      // 
      // label2
      // 
      resources.ApplyResources(this.label2, "label2");
      this.label2.Name = "label2";
      // 
      // tabInsererPJ
      // 
      resources.ApplyResources(this.tabInsererPJ, "tabInsererPJ");
      this.tabInsererPJ.Controls.Add(this.cboListeFichier);
      this.tabInsererPJ.Controls.Add(this.label8);
      this.tabInsererPJ.Controls.Add(this.cmdImporter);
      this.tabInsererPJ.Name = "tabInsererPJ";
      // 
      // cboListeFichier
      // 
      this.cboListeFichier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboListeFichier.FormattingEnabled = true;
      resources.ApplyResources(this.cboListeFichier, "cboListeFichier");
      this.cboListeFichier.Name = "cboListeFichier";
      // 
      // label8
      // 
      resources.ApplyResources(this.label8, "label8");
      this.label8.Name = "label8";
      // 
      // cmdImporter
      // 
      resources.ApplyResources(this.cmdImporter, "cmdImporter");
      this.cmdImporter.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdImporter.HelpContextID = 182;
      this.cmdImporter.Name = "cmdImporter";
      this.cmdImporter.UseVisualStyleBackColor = true;
      this.cmdImporter.Click += new System.EventHandler(this.cmdImporter_Click);
      // 
      // tabGetList
      // 
      resources.ApplyResources(this.tabGetList, "tabGetList");
      this.tabGetList.Controls.Add(this.txtResult);
      this.tabGetList.Controls.Add(this.cmdGetList);
      this.tabGetList.Name = "tabGetList";
      // 
      // txtResult
      // 
      this.txtResult.HelpContextID = 0;
      resources.ApplyResources(this.txtResult, "txtResult");
      this.txtResult.Name = "txtResult";
      // 
      // cmdGetList
      // 
      resources.ApplyResources(this.cmdGetList, "cmdGetList");
      this.cmdGetList.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdGetList.HelpContextID = 182;
      this.cmdGetList.Name = "cmdGetList";
      this.cmdGetList.UseVisualStyleBackColor = true;
      this.cmdGetList.Click += new System.EventHandler(this.cmdGetList_Click);
      // 
      // txtResponse
      // 
      this.txtResponse.HelpContextID = 0;
      resources.ApplyResources(this.txtResponse, "txtResponse");
      this.txtResponse.Name = "txtResponse";
      // 
      // lblResponse
      // 
      resources.ApplyResources(this.lblResponse, "lblResponse");
      this.lblResponse.Name = "lblResponse";
      // 
      // frmTotalDaisy
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Wheat;
      this.CancelButton = this.cmdQuitter;
      this.Controls.Add(this.lblResponse);
      this.Controls.Add(this.txtResponse);
      this.Controls.Add(this.tabPanGetList);
      this.Controls.Add(this.cmdQuitter);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmTotalDaisy";
      this.Load += new System.EventHandler(this.frmTotalDaisy_Load);
      ((System.ComponentModel.ISupportInitialize)(this.tabPanGetList)).EndInit();
      this.tabPanGetList.ResumeLayout(false);
      this.tabDeclarerPassageGTI.ResumeLayout(false);
      this.tabDeclarerPassageGTI.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.datePassageGTI.Properties.CalendarTimeProperties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.datePassageGTI.Properties)).EndInit();
      this.tabCloture.ResumeLayout(false);
      this.tabCloture.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dateInterReelle.Properties.CalendarTimeProperties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dateInterReelle.Properties)).EndInit();
      this.tabInsererPJ.ResumeLayout(false);
      this.tabInsererPJ.PerformLayout();
      this.tabGetList.ResumeLayout(false);
      this.tabGetList.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MozartUC.apiButton cmdQuitter;
    private TabPane tabPanGetList;
    private TabNavigationPage tabDeclarerPassageGTI;
    private TabNavigationPage tabInsererPJ;
    private TabNavigationPage tabCloture;
    private System.Windows.Forms.Label lblDate;
    private MozartUC.apiTextBox txtNotes;
    private System.Windows.Forms.Label label1;
    private DevExpress.XtraEditors.DateEdit datePassageGTI;
    private MozartUC.apiButton cmdDeclarerPassageGTI;
    private MozartUC.apiTextBox txtResponse;
    private System.Windows.Forms.Label lblResponse;
    private TabNavigationPage tabGetList;
    private MozartUC.apiTextBox txtResult;
    private MozartUC.apiButton cmdGetList;
    private System.Windows.Forms.ComboBox cboCodeCloture;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox cboCauseRacine;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ComboBox cboTypeInter;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.ComboBox cboTypeAction;
    private System.Windows.Forms.Label label5;
    private MozartUC.apiButton cmdResoudre;
    private DevExpress.XtraEditors.DateEdit dateInterReelle;
    private MozartUC.apiTextBox txtNoteCloture;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private MozartUC.apiButton cmdImporter;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.ComboBox cboListeFichier;
  }
}