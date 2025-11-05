namespace MozartCS.Inventaire_Equipement
{
    partial class frmInventaireEquipementDetailCodeBarre
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
            this.PictCodeBarre = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCodeBarre = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddFileCodeBarre = new System.Windows.Forms.Button();
            this.btnDelFileCodeBarre = new System.Windows.Forms.Button();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.PictCodeBarre)).BeginInit();
            this.SuspendLayout();
            // 
            // PictCodeBarre
            // 
            this.PictCodeBarre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictCodeBarre.Location = new System.Drawing.Point(103, 60);
            this.PictCodeBarre.Name = "PictCodeBarre";
            this.PictCodeBarre.Size = new System.Drawing.Size(397, 256);
            this.PictCodeBarre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictCodeBarre.TabIndex = 0;
            this.PictCodeBarre.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Libellé Code Barre :";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(488, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Photo du code barre";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtCodeBarre
            // 
            this.TxtCodeBarre.Location = new System.Drawing.Point(173, 341);
            this.TxtCodeBarre.Name = "TxtCodeBarre";
            this.TxtCodeBarre.Size = new System.Drawing.Size(359, 20);
            this.TxtCodeBarre.TabIndex = 3;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(342, 386);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(86, 32);
            this.BtnSave.TabIndex = 4;
            this.BtnSave.Text = "Valider";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(112, 386);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 32);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddFileCodeBarre
            // 
            this.btnAddFileCodeBarre.Location = new System.Drawing.Point(506, 60);
            this.btnAddFileCodeBarre.Name = "btnAddFileCodeBarre";
            this.btnAddFileCodeBarre.Size = new System.Drawing.Size(86, 32);
            this.btnAddFileCodeBarre.TabIndex = 6;
            this.btnAddFileCodeBarre.Text = "Ajouter";
            this.btnAddFileCodeBarre.UseVisualStyleBackColor = true;
            this.btnAddFileCodeBarre.Click += new System.EventHandler(this.btnAddFileCodeBarre_Click);
            // 
            // btnDelFileCodeBarre
            // 
            this.btnDelFileCodeBarre.Location = new System.Drawing.Point(506, 98);
            this.btnDelFileCodeBarre.Name = "btnDelFileCodeBarre";
            this.btnDelFileCodeBarre.Size = new System.Drawing.Size(86, 32);
            this.btnDelFileCodeBarre.TabIndex = 7;
            this.btnDelFileCodeBarre.Text = "Supprimer";
            this.btnDelFileCodeBarre.UseVisualStyleBackColor = true;
            this.btnDelFileCodeBarre.Click += new System.EventHandler(this.btnDelFileCodeBarre_Click);
            // 
            // OFD
            // 
            this.OFD.Filter = "Images (*.png,*.jpg,*.jpeg,*.bmp)|*.png;*.jpg;*.jpeg;*.bmp";
            // 
            // frmInventaireEquipementDetailCodeBarre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 430);
            this.Controls.Add(this.btnDelFileCodeBarre);
            this.Controls.Add(this.btnAddFileCodeBarre);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TxtCodeBarre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PictCodeBarre);
            this.Name = "frmInventaireEquipementDetailCodeBarre";
            this.Text = "Détail du code barre";
            this.Load += new System.EventHandler(this.frmInventaireEquipementDetailCodeBarre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictCodeBarre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictCodeBarre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCodeBarre;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddFileCodeBarre;
        private System.Windows.Forms.Button btnDelFileCodeBarre;
        private System.Windows.Forms.OpenFileDialog OFD;
    }
}