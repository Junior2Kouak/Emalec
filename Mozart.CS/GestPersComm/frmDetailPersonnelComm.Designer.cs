namespace MozartCS
{
  partial class frmDetailPersonnelComm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetailPersonnelComm));
      this.Calendar1 = new System.Windows.Forms.DateTimePicker();
      this.txtDateNaissance = new MozartUC.apiTextBox();
      this.cmdDate22 = new MozartUC.apiButton();
      this.cmdSupp22 = new MozartUC.apiButton();
      this.cmdSupp21 = new MozartUC.apiButton();
      this.cmdDate21 = new MozartUC.apiButton();
      this.cmdSupp20 = new MozartUC.apiButton();
      this.cmdDate20 = new MozartUC.apiButton();
      this.txtAnciennete = new MozartUC.apiTextBox();
      this.txtAge = new MozartUC.apiTextBox();
      this.txtDateSortie = new MozartUC.apiTextBox();
      this.txtDateEntree = new MozartUC.apiTextBox();
      this.Label54 = new MozartUC.apiLabel();
      this.Label55 = new MozartUC.apiLabel();
      this.Label58 = new MozartUC.apiLabel();
      this.Label57 = new MozartUC.apiLabel();
      this.Label56 = new MozartUC.apiLabel();
      this.Frame4 = new MozartUC.apiGroupBox();
      this.Frame3 = new MozartUC.apiGroupBox();
      this.cboCiv = new System.Windows.Forms.ComboBox();
      this.txtprenom = new MozartUC.apiTextBox();
      this.txtNom = new MozartUC.apiTextBox();
      this.Label53 = new MozartUC.apiLabel();
      this.Label2 = new MozartUC.apiLabel();
      this.lblLabels20 = new MozartUC.apiLabel();
      this.Frame7 = new MozartUC.apiGroupBox();
      this.cboVille = new System.Windows.Forms.ComboBox();
      this.cboPays = new System.Windows.Forms.ComboBox();
      this.txtVille = new MozartUC.apiTextBox();
      this.cmdRecherche = new MozartUC.apiButton();
      this.txtCP = new MozartUC.apiTextBox();
      this.txtAD2 = new MozartUC.apiTextBox();
      this.txtAD1 = new MozartUC.apiTextBox();
      this.cmdFact = new MozartUC.apiButton();
      this.txtEtatAdmin = new MozartUC.apiTextBox();
      this.cboEtat = new System.Windows.Forms.ComboBox();
      this.lblLabels7 = new MozartUC.apiLabel();
      this.lblLabels6 = new MozartUC.apiLabel();
      this.framEtat = new MozartUC.apiGroupBox();
      this.Label521 = new MozartUC.apiLabel();
      this.Label513 = new MozartUC.apiLabel();
      this.Label512 = new MozartUC.apiLabel();
      this.Label50 = new MozartUC.apiLabel();
      this.Frame5 = new MozartUC.apiGroupBox();
      this.cboType = new System.Windows.Forms.ComboBox();
      this.cboRegion = new System.Windows.Forms.ComboBox();
      this.cboService = new System.Windows.Forms.ComboBox();
      this.Label519 = new MozartUC.apiLabel();
      this.Label52 = new MozartUC.apiLabel();
      this.Label51 = new MozartUC.apiLabel();
      this.Frame2 = new MozartUC.apiGroupBox();
      this.Frame1 = new MozartUC.apiGroupBox();
      this.cmdFermer = new MozartUC.apiButton();
      this.cmdEnregistrer = new MozartUC.apiButton();
      this.cmdCarte = new MozartUC.apiButton();
      this.Label1 = new MozartUC.apiLabel();
      this.Frame4.SuspendLayout();
      this.Frame3.SuspendLayout();
      this.Frame7.SuspendLayout();
      this.framEtat.SuspendLayout();
      this.Frame5.SuspendLayout();
      this.Frame2.SuspendLayout();
      this.Frame1.SuspendLayout();
      this.SuspendLayout();
      // 
      // Calendar1
      // 
      this.Calendar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(132)))));
      this.Calendar1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      resources.ApplyResources(this.Calendar1, "Calendar1");
      this.Calendar1.Name = "Calendar1";
      this.Calendar1.CloseUp += new System.EventHandler(this.Calendar1_CloseUp);
      this.Calendar1.ValueChanged += new System.EventHandler(this.Calendar1_ValueChanged);
      // 
      // txtDateNaissance
      // 
      this.txtDateNaissance.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtDateNaissance.HelpContextID = 0;
      resources.ApplyResources(this.txtDateNaissance, "txtDateNaissance");
      this.txtDateNaissance.Name = "txtDateNaissance";
      // 
      // cmdDate22
      // 
      resources.ApplyResources(this.cmdDate22, "cmdDate22");
      this.cmdDate22.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdDate22.HelpContextID = 0;
      this.cmdDate22.Image = global::MozartCS.Properties.Resources.calendar;
      this.cmdDate22.Name = "cmdDate22";
      this.cmdDate22.Tag = "5";
      this.cmdDate22.UseVisualStyleBackColor = true;
      this.cmdDate22.Click += new System.EventHandler(this.cmdDate_Click);
      // 
      // cmdSupp22
      // 
      this.cmdSupp22.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdSupp22.HelpContextID = 0;
      this.cmdSupp22.Image = global::MozartCS.Properties.Resources.delete_32;
      resources.ApplyResources(this.cmdSupp22, "cmdSupp22");
      this.cmdSupp22.Name = "cmdSupp22";
      this.cmdSupp22.Tag = "65";
      this.cmdSupp22.UseVisualStyleBackColor = true;
      this.cmdSupp22.Click += new System.EventHandler(this.cmdDateSupp_Click);
      // 
      // cmdSupp21
      // 
      this.cmdSupp21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.cmdSupp21.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdSupp21.HelpContextID = 0;
      this.cmdSupp21.Image = global::MozartCS.Properties.Resources.delete_32;
      resources.ApplyResources(this.cmdSupp21, "cmdSupp21");
      this.cmdSupp21.Name = "cmdSupp21";
      this.cmdSupp21.Tag = "65";
      this.cmdSupp21.UseVisualStyleBackColor = false;
      this.cmdSupp21.Click += new System.EventHandler(this.cmdDateSupp_Click);
      // 
      // cmdDate21
      // 
      this.cmdDate21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      resources.ApplyResources(this.cmdDate21, "cmdDate21");
      this.cmdDate21.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdDate21.HelpContextID = 0;
      this.cmdDate21.Image = global::MozartCS.Properties.Resources.calendar;
      this.cmdDate21.Name = "cmdDate21";
      this.cmdDate21.Tag = "5";
      this.cmdDate21.UseVisualStyleBackColor = false;
      this.cmdDate21.Click += new System.EventHandler(this.cmdDate_Click);
      // 
      // cmdSupp20
      // 
      this.cmdSupp20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.cmdSupp20.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdSupp20.HelpContextID = 0;
      this.cmdSupp20.Image = global::MozartCS.Properties.Resources.delete_32;
      resources.ApplyResources(this.cmdSupp20, "cmdSupp20");
      this.cmdSupp20.Name = "cmdSupp20";
      this.cmdSupp20.Tag = "65";
      this.cmdSupp20.UseVisualStyleBackColor = false;
      this.cmdSupp20.Click += new System.EventHandler(this.cmdDateSupp_Click);
      // 
      // cmdDate20
      // 
      this.cmdDate20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      resources.ApplyResources(this.cmdDate20, "cmdDate20");
      this.cmdDate20.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdDate20.HelpContextID = 0;
      this.cmdDate20.Image = global::MozartCS.Properties.Resources.calendar;
      this.cmdDate20.Name = "cmdDate20";
      this.cmdDate20.Tag = "5";
      this.cmdDate20.UseVisualStyleBackColor = false;
      this.cmdDate20.Click += new System.EventHandler(this.cmdDate_Click);
      // 
      // txtAnciennete
      // 
      resources.ApplyResources(this.txtAnciennete, "txtAnciennete");
      this.txtAnciennete.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtAnciennete.HelpContextID = 0;
      this.txtAnciennete.Name = "txtAnciennete";
      // 
      // txtAge
      // 
      resources.ApplyResources(this.txtAge, "txtAge");
      this.txtAge.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtAge.HelpContextID = 0;
      this.txtAge.Name = "txtAge";
      // 
      // txtDateSortie
      // 
      this.txtDateSortie.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtDateSortie.HelpContextID = 0;
      resources.ApplyResources(this.txtDateSortie, "txtDateSortie");
      this.txtDateSortie.Name = "txtDateSortie";
      // 
      // txtDateEntree
      // 
      this.txtDateEntree.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtDateEntree.HelpContextID = 0;
      resources.ApplyResources(this.txtDateEntree, "txtDateEntree");
      this.txtDateEntree.Name = "txtDateEntree";
      // 
      // Label54
      // 
      resources.ApplyResources(this.Label54, "Label54");
      this.Label54.BackColor = System.Drawing.Color.Wheat;
      this.Label54.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Label54.HelpContextID = 0;
      this.Label54.Name = "Label54";
      // 
      // Label55
      // 
      resources.ApplyResources(this.Label55, "Label55");
      this.Label55.BackColor = System.Drawing.Color.Wheat;
      this.Label55.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Label55.HelpContextID = 0;
      this.Label55.Name = "Label55";
      // 
      // Label58
      // 
      resources.ApplyResources(this.Label58, "Label58");
      this.Label58.BackColor = System.Drawing.Color.Wheat;
      this.Label58.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Label58.HelpContextID = 0;
      this.Label58.Name = "Label58";
      // 
      // Label57
      // 
      resources.ApplyResources(this.Label57, "Label57");
      this.Label57.BackColor = System.Drawing.Color.Wheat;
      this.Label57.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Label57.HelpContextID = 0;
      this.Label57.Name = "Label57";
      // 
      // Label56
      // 
      resources.ApplyResources(this.Label56, "Label56");
      this.Label56.BackColor = System.Drawing.Color.Wheat;
      this.Label56.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Label56.HelpContextID = 0;
      this.Label56.Name = "Label56";
      // 
      // Frame4
      // 
      this.Frame4.BackColor = System.Drawing.Color.Wheat;
      this.Frame4.Controls.Add(this.txtDateNaissance);
      this.Frame4.Controls.Add(this.cmdDate22);
      this.Frame4.Controls.Add(this.cmdSupp22);
      this.Frame4.Controls.Add(this.cmdSupp21);
      this.Frame4.Controls.Add(this.cmdDate21);
      this.Frame4.Controls.Add(this.cmdSupp20);
      this.Frame4.Controls.Add(this.cmdDate20);
      this.Frame4.Controls.Add(this.txtAnciennete);
      this.Frame4.Controls.Add(this.txtAge);
      this.Frame4.Controls.Add(this.txtDateSortie);
      this.Frame4.Controls.Add(this.txtDateEntree);
      this.Frame4.Controls.Add(this.Label54);
      this.Frame4.Controls.Add(this.Label55);
      this.Frame4.Controls.Add(this.Label58);
      this.Frame4.Controls.Add(this.Label57);
      this.Frame4.Controls.Add(this.Label56);
      resources.ApplyResources(this.Frame4, "Frame4");
      this.Frame4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.Frame4.HelpContextID = 0;
      this.Frame4.Name = "Frame4";
      this.Frame4.TabStop = false;
      // 
      // Frame3
      // 
      this.Frame3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.Frame3.Controls.Add(this.Frame4);
      resources.ApplyResources(this.Frame3, "Frame3");
      this.Frame3.HelpContextID = 0;
      this.Frame3.Name = "Frame3";
      this.Frame3.TabStop = false;
      // 
      // cboCiv
      // 
      this.cboCiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.cboCiv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboCiv.Items.AddRange(new object[] {
            resources.GetString("cboCiv.Items"),
            resources.GetString("cboCiv.Items1"),
            resources.GetString("cboCiv.Items2")});
      resources.ApplyResources(this.cboCiv, "cboCiv");
      this.cboCiv.Name = "cboCiv";
      // 
      // txtprenom
      // 
      this.txtprenom.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtprenom.HelpContextID = 0;
      resources.ApplyResources(this.txtprenom, "txtprenom");
      this.txtprenom.Name = "txtprenom";
      // 
      // txtNom
      // 
      this.txtNom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.txtNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.txtNom.HelpContextID = 0;
      resources.ApplyResources(this.txtNom, "txtNom");
      this.txtNom.Name = "txtNom";
      this.txtNom.Leave += new System.EventHandler(this.txtNom_Leave);
      // 
      // Label53
      // 
      resources.ApplyResources(this.Label53, "Label53");
      this.Label53.BackColor = System.Drawing.Color.Wheat;
      this.Label53.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Label53.HelpContextID = 0;
      this.Label53.Name = "Label53";
      // 
      // Label2
      // 
      this.Label2.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.Label2, "Label2");
      this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label2.HelpContextID = 0;
      this.Label2.Name = "Label2";
      // 
      // lblLabels20
      // 
      this.lblLabels20.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this.lblLabels20, "lblLabels20");
      this.lblLabels20.ForeColor = System.Drawing.SystemColors.ControlText;
      this.lblLabels20.HelpContextID = 0;
      this.lblLabels20.Name = "lblLabels20";
      // 
      // Frame7
      // 
      this.Frame7.BackColor = System.Drawing.Color.Wheat;
      this.Frame7.Controls.Add(this.cboCiv);
      this.Frame7.Controls.Add(this.txtprenom);
      this.Frame7.Controls.Add(this.txtNom);
      this.Frame7.Controls.Add(this.Label53);
      this.Frame7.Controls.Add(this.Label2);
      this.Frame7.Controls.Add(this.lblLabels20);
      resources.ApplyResources(this.Frame7, "Frame7");
      this.Frame7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.Frame7.HelpContextID = 0;
      this.Frame7.Name = "Frame7";
      this.Frame7.TabStop = false;
      // 
      // cboVille
      // 
      this.cboVille.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      resources.ApplyResources(this.cboVille, "cboVille");
      this.cboVille.Name = "cboVille";
      this.cboVille.Sorted = true;
      this.cboVille.Leave += new System.EventHandler(this.cboVille_Leave);
      // 
      // cboPays
      // 
      this.cboPays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      resources.ApplyResources(this.cboPays, "cboPays");
      this.cboPays.Name = "cboPays";
      this.cboPays.Sorted = true;
      this.cboPays.SelectedIndexChanged += new System.EventHandler(this.cboPays_SelectedIndexChanged);
      // 
      // txtVille
      // 
      this.txtVille.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtVille.HelpContextID = 0;
      resources.ApplyResources(this.txtVille, "txtVille");
      this.txtVille.Name = "txtVille";
      this.txtVille.Leave += new System.EventHandler(this.txtVille_Leave);
      // 
      // cmdRecherche
      // 
      resources.ApplyResources(this.cmdRecherche, "cmdRecherche");
      this.cmdRecherche.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdRecherche.HelpContextID = 0;
      this.cmdRecherche.Name = "cmdRecherche";
      this.cmdRecherche.UseVisualStyleBackColor = true;
      this.cmdRecherche.Click += new System.EventHandler(this.cmdRecherche_Click);
      // 
      // txtCP
      // 
      this.txtCP.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtCP.HelpContextID = 0;
      resources.ApplyResources(this.txtCP, "txtCP");
      this.txtCP.Name = "txtCP";
      this.txtCP.TextChanged += new System.EventHandler(this.txtCP_TextChanged);
      // 
      // txtAD2
      // 
      this.txtAD2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtAD2.HelpContextID = 0;
      resources.ApplyResources(this.txtAD2, "txtAD2");
      this.txtAD2.Name = "txtAD2";
      // 
      // txtAD1
      // 
      this.txtAD1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtAD1.HelpContextID = 0;
      resources.ApplyResources(this.txtAD1, "txtAD1");
      this.txtAD1.Name = "txtAD1";
      // 
      // cmdFact
      // 
      this.cmdFact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      resources.ApplyResources(this.cmdFact, "cmdFact");
      this.cmdFact.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdFact.HelpContextID = 0;
      this.cmdFact.Name = "cmdFact";
      this.cmdFact.UseVisualStyleBackColor = false;
      // 
      // txtEtatAdmin
      // 
      this.txtEtatAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.txtEtatAdmin, "txtEtatAdmin");
      this.txtEtatAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.txtEtatAdmin.HelpContextID = 0;
      this.txtEtatAdmin.Name = "txtEtatAdmin";
      // 
      // cboEtat
      // 
      this.cboEtat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.cboEtat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      resources.ApplyResources(this.cboEtat, "cboEtat");
      this.cboEtat.Name = "cboEtat";
      // 
      // lblLabels7
      // 
      this.lblLabels7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.lblLabels7, "lblLabels7");
      this.lblLabels7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
      this.lblLabels7.HelpContextID = 0;
      this.lblLabels7.Name = "lblLabels7";
      // 
      // lblLabels6
      // 
      this.lblLabels6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      resources.ApplyResources(this.lblLabels6, "lblLabels6");
      this.lblLabels6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
      this.lblLabels6.HelpContextID = 0;
      this.lblLabels6.Name = "lblLabels6";
      // 
      // framEtat
      // 
      this.framEtat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.framEtat.Controls.Add(this.cmdFact);
      this.framEtat.Controls.Add(this.txtEtatAdmin);
      this.framEtat.Controls.Add(this.cboEtat);
      this.framEtat.Controls.Add(this.lblLabels7);
      this.framEtat.Controls.Add(this.lblLabels6);
      resources.ApplyResources(this.framEtat, "framEtat");
      this.framEtat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.framEtat.HelpContextID = 0;
      this.framEtat.Name = "framEtat";
      this.framEtat.TabStop = false;
      // 
      // Label521
      // 
      resources.ApplyResources(this.Label521, "Label521");
      this.Label521.BackColor = System.Drawing.Color.Wheat;
      this.Label521.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Label521.HelpContextID = 0;
      this.Label521.Name = "Label521";
      // 
      // Label513
      // 
      resources.ApplyResources(this.Label513, "Label513");
      this.Label513.BackColor = System.Drawing.Color.Wheat;
      this.Label513.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Label513.HelpContextID = 0;
      this.Label513.Name = "Label513";
      // 
      // Label512
      // 
      resources.ApplyResources(this.Label512, "Label512");
      this.Label512.BackColor = System.Drawing.Color.Wheat;
      this.Label512.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Label512.HelpContextID = 0;
      this.Label512.Name = "Label512";
      // 
      // Label50
      // 
      resources.ApplyResources(this.Label50, "Label50");
      this.Label50.BackColor = System.Drawing.Color.Wheat;
      this.Label50.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Label50.HelpContextID = 0;
      this.Label50.Name = "Label50";
      // 
      // Frame5
      // 
      this.Frame5.BackColor = System.Drawing.Color.Wheat;
      this.Frame5.Controls.Add(this.cboVille);
      this.Frame5.Controls.Add(this.cboPays);
      this.Frame5.Controls.Add(this.txtVille);
      this.Frame5.Controls.Add(this.cmdRecherche);
      this.Frame5.Controls.Add(this.txtCP);
      this.Frame5.Controls.Add(this.txtAD2);
      this.Frame5.Controls.Add(this.txtAD1);
      this.Frame5.Controls.Add(this.framEtat);
      this.Frame5.Controls.Add(this.Label521);
      this.Frame5.Controls.Add(this.Label513);
      this.Frame5.Controls.Add(this.Label512);
      this.Frame5.Controls.Add(this.Label50);
      resources.ApplyResources(this.Frame5, "Frame5");
      this.Frame5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Frame5.HelpContextID = 0;
      this.Frame5.Name = "Frame5";
      this.Frame5.TabStop = false;
      // 
      // cboType
      // 
      resources.ApplyResources(this.cboType, "cboType");
      this.cboType.Name = "cboType";
      // 
      // cboRegion
      // 
      this.cboRegion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.cboRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      resources.ApplyResources(this.cboRegion, "cboRegion");
      this.cboRegion.Name = "cboRegion";
      // 
      // cboService
      // 
      this.cboService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.cboService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      resources.ApplyResources(this.cboService, "cboService");
      this.cboService.Name = "cboService";
      // 
      // Label519
      // 
      resources.ApplyResources(this.Label519, "Label519");
      this.Label519.BackColor = System.Drawing.Color.Wheat;
      this.Label519.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Label519.HelpContextID = 0;
      this.Label519.Name = "Label519";
      // 
      // Label52
      // 
      resources.ApplyResources(this.Label52, "Label52");
      this.Label52.BackColor = System.Drawing.Color.Wheat;
      this.Label52.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Label52.HelpContextID = 0;
      this.Label52.Name = "Label52";
      // 
      // Label51
      // 
      resources.ApplyResources(this.Label51, "Label51");
      this.Label51.BackColor = System.Drawing.Color.Wheat;
      this.Label51.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Label51.HelpContextID = 0;
      this.Label51.Name = "Label51";
      // 
      // Frame2
      // 
      this.Frame2.BackColor = System.Drawing.Color.Wheat;
      this.Frame2.Controls.Add(this.cboType);
      this.Frame2.Controls.Add(this.cboRegion);
      this.Frame2.Controls.Add(this.cboService);
      this.Frame2.Controls.Add(this.Label519);
      this.Frame2.Controls.Add(this.Label52);
      this.Frame2.Controls.Add(this.Label51);
      resources.ApplyResources(this.Frame2, "Frame2");
      this.Frame2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Frame2.HelpContextID = 0;
      this.Frame2.Name = "Frame2";
      this.Frame2.TabStop = false;
      // 
      // Frame1
      // 
      this.Frame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.Frame1.Controls.Add(this.Frame7);
      this.Frame1.Controls.Add(this.Frame5);
      this.Frame1.Controls.Add(this.Frame2);
      resources.ApplyResources(this.Frame1, "Frame1");
      this.Frame1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.Frame1.HelpContextID = 0;
      this.Frame1.Name = "Frame1";
      this.Frame1.TabStop = false;
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
      // cmdEnregistrer
      // 
      resources.ApplyResources(this.cmdEnregistrer, "cmdEnregistrer");
      this.cmdEnregistrer.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdEnregistrer.HelpContextID = 0;
      this.cmdEnregistrer.Name = "cmdEnregistrer";
      this.cmdEnregistrer.Tag = "66";
      this.cmdEnregistrer.UseVisualStyleBackColor = true;
      this.cmdEnregistrer.Click += new System.EventHandler(this.cmdEnregistrer_Click);
      // 
      // cmdCarte
      // 
      resources.ApplyResources(this.cmdCarte, "cmdCarte");
      this.cmdCarte.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cmdCarte.HelpContextID = 0;
      this.cmdCarte.Name = "cmdCarte";
      this.cmdCarte.Tag = "76";
      this.cmdCarte.UseVisualStyleBackColor = true;
      this.cmdCarte.Click += new System.EventHandler(this.cmdCarte_Click);
      // 
      // Label1
      // 
      resources.ApplyResources(this.Label1, "Label1");
      this.Label1.BackColor = System.Drawing.Color.Wheat;
      this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Label1.HelpContextID = 0;
      this.Label1.Name = "Label1";
      // 
      // frmDetailPersonnelComm
      // 
      this.BackColor = System.Drawing.Color.Wheat;
      resources.ApplyResources(this, "$this");
      this.Controls.Add(this.Calendar1);
      this.Controls.Add(this.Frame3);
      this.Controls.Add(this.Frame1);
      this.Controls.Add(this.cmdFermer);
      this.Controls.Add(this.cmdEnregistrer);
      this.Controls.Add(this.cmdCarte);
      this.Controls.Add(this.Label1);
      this.Name = "frmDetailPersonnelComm";
      this.ShowInTaskbar = false;
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.frmDetailPersonnelComm_Load);
      this.Frame4.ResumeLayout(false);
      this.Frame4.PerformLayout();
      this.Frame3.ResumeLayout(false);
      this.Frame7.ResumeLayout(false);
      this.Frame7.PerformLayout();
      this.framEtat.ResumeLayout(false);
      this.framEtat.PerformLayout();
      this.Frame5.ResumeLayout(false);
      this.Frame5.PerformLayout();
      this.Frame2.ResumeLayout(false);
      this.Frame2.PerformLayout();
      this.Frame1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DateTimePicker Calendar1;
    private MozartUC.apiTextBox txtDateNaissance;
    private MozartUC.apiButton cmdDate22;
    private MozartUC.apiButton cmdSupp22;
    private MozartUC.apiButton cmdSupp21;
    private MozartUC.apiButton cmdDate21;
    private MozartUC.apiButton cmdSupp20;
    private MozartUC.apiButton cmdDate20;
    private MozartUC.apiTextBox txtAnciennete;
    private MozartUC.apiTextBox txtAge;
    private MozartUC.apiTextBox txtDateSortie;
    private MozartUC.apiTextBox txtDateEntree;
    private MozartUC.apiLabel Label54;
    private MozartUC.apiLabel Label55;
    private MozartUC.apiLabel Label58;
    private MozartUC.apiLabel Label57;
    private MozartUC.apiLabel Label56;
    private MozartUC.apiGroupBox Frame4;
    private MozartUC.apiGroupBox Frame3;
    private System.Windows.Forms.ComboBox cboCiv;
    private MozartUC.apiTextBox txtprenom;
    private MozartUC.apiTextBox txtNom;
    private MozartUC.apiLabel Label53;
    private MozartUC.apiLabel Label2;
    private MozartUC.apiLabel lblLabels20;
    private MozartUC.apiGroupBox Frame7;
    private System.Windows.Forms.ComboBox cboVille;
    private System.Windows.Forms.ComboBox cboPays;
    private MozartUC.apiTextBox txtVille;
    private MozartUC.apiButton cmdRecherche;
    private MozartUC.apiTextBox txtCP;
    private MozartUC.apiTextBox txtAD2;
    private MozartUC.apiTextBox txtAD1;
    private MozartUC.apiButton cmdFact;
    private MozartUC.apiTextBox txtEtatAdmin;
    private System.Windows.Forms.ComboBox cboEtat;
    private MozartUC.apiLabel lblLabels7;
    private MozartUC.apiLabel lblLabels6;
    private MozartUC.apiGroupBox framEtat;
    private MozartUC.apiLabel Label521;
    private MozartUC.apiLabel Label513;
    private MozartUC.apiLabel Label512;
    private MozartUC.apiLabel Label50;
    private MozartUC.apiGroupBox Frame5;
    private System.Windows.Forms.ComboBox cboType;
    private System.Windows.Forms.ComboBox cboRegion;
    private System.Windows.Forms.ComboBox cboService;
    private MozartUC.apiLabel Label519;
    private MozartUC.apiLabel Label52;
    private MozartUC.apiLabel Label51;
    private MozartUC.apiGroupBox Frame2;
    private MozartUC.apiGroupBox Frame1;
    private MozartUC.apiButton cmdFermer;
    private MozartUC.apiButton cmdEnregistrer;
    private MozartUC.apiButton cmdCarte;
    private MozartUC.apiLabel Label1;
    // TODO GetCodeDeclareControl cas non traité pour type VB.Line

  }
}
