
namespace MozartCS
{
    partial class frmMenu_Methodes
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
            this.btnMethodes = new MozartUC.apiButton();
            this.BtnPrepaInventaire = new MozartUC.apiButton();
            this.cmdFermer = new MozartUC.apiButton();
            this.BtnGestCliChamp = new MozartUC.apiButton();
            this.CmdGTP = new MozartUC.apiButton();
            this.SuspendLayout();
            // 
            // btnMethodes
            // 
            this.btnMethodes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnMethodes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnMethodes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMethodes.HelpContextID = 737;
            this.btnMethodes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnMethodes.Location = new System.Drawing.Point(164, 89);
            this.btnMethodes.Name = "btnMethodes";
            this.btnMethodes.Size = new System.Drawing.Size(97, 73);
            this.btnMethodes.TabIndex = 35;
            this.btnMethodes.Tag = "79";
            this.btnMethodes.Text = "Administration des équipements";
            this.btnMethodes.UseVisualStyleBackColor = false;
            this.btnMethodes.Visible = false;
            this.btnMethodes.Click += new System.EventHandler(this.btnMethodes_Click);
            // 
            // BtnPrepaInventaire
            // 
            this.BtnPrepaInventaire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnPrepaInventaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.BtnPrepaInventaire.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnPrepaInventaire.HelpContextID = 737;
            this.BtnPrepaInventaire.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnPrepaInventaire.Location = new System.Drawing.Point(351, 89);
            this.BtnPrepaInventaire.Name = "BtnPrepaInventaire";
            this.BtnPrepaInventaire.Size = new System.Drawing.Size(97, 73);
            this.BtnPrepaInventaire.TabIndex = 36;
            this.BtnPrepaInventaire.Tag = "79";
            this.BtnPrepaInventaire.Text = "Préparation d\'un inventaire client";
            this.BtnPrepaInventaire.UseVisualStyleBackColor = false;
            this.BtnPrepaInventaire.Visible = false;
            this.BtnPrepaInventaire.Click += new System.EventHandler(this.BtnPrepaInventaire_Click);
            // 
            // cmdFermer
            // 
            this.cmdFermer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.cmdFermer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdFermer.HelpContextID = 0;
            this.cmdFermer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmdFermer.Location = new System.Drawing.Point(12, 498);
            this.cmdFermer.Name = "cmdFermer";
            this.cmdFermer.Size = new System.Drawing.Size(73, 57);
            this.cmdFermer.TabIndex = 37;
            this.cmdFermer.Tag = "15";
            this.cmdFermer.Text = "Fermer";
            this.cmdFermer.UseVisualStyleBackColor = true;
            // 
            // BtnGestCliChamp
            // 
            this.BtnGestCliChamp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnGestCliChamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.BtnGestCliChamp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnGestCliChamp.HelpContextID = 737;
            this.BtnGestCliChamp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnGestCliChamp.Location = new System.Drawing.Point(164, 216);
            this.BtnGestCliChamp.Name = "BtnGestCliChamp";
            this.BtnGestCliChamp.Size = new System.Drawing.Size(97, 73);
            this.BtnGestCliChamp.TabIndex = 38;
            this.BtnGestCliChamp.Tag = "79";
            this.BtnGestCliChamp.Text = "Gestion des champs Code Barre par client";
            this.BtnGestCliChamp.UseVisualStyleBackColor = false;
            this.BtnGestCliChamp.Visible = false;
            this.BtnGestCliChamp.Click += new System.EventHandler(this.BtnGestCliChamp_Click);
            // 
            // CmdGTP
            // 
            this.CmdGTP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CmdGTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.CmdGTP.HelpContextID = 368;
            this.CmdGTP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CmdGTP.Location = new System.Drawing.Point(351, 216);
            this.CmdGTP.Name = "CmdGTP";
            this.CmdGTP.Size = new System.Drawing.Size(97, 73);
            this.CmdGTP.TabIndex = 39;
            this.CmdGTP.Tag = "";
            this.CmdGTP.Text = "Gestion Patrimoine";
            this.CmdGTP.UseVisualStyleBackColor = false;
            this.CmdGTP.Visible = false;
            this.CmdGTP.Click += new System.EventHandler(this.CmdGTP_Click);
            // 
            // frmMenu_Methodes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1200, 772);
            this.Controls.Add(this.CmdGTP);
            this.Controls.Add(this.BtnGestCliChamp);
            this.Controls.Add(this.cmdFermer);
            this.Controls.Add(this.BtnPrepaInventaire);
            this.Controls.Add(this.btnMethodes);
            this.Name = "frmMenu_Methodes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Menu Méthodes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenu_Methodes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MozartUC.apiButton btnMethodes;
        private MozartUC.apiButton BtnPrepaInventaire;
        private MozartUC.apiButton cmdFermer;
        private MozartUC.apiButton BtnGestCliChamp;
        private MozartUC.apiButton CmdGTP;
    }
}