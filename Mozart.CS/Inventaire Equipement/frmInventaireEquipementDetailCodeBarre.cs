using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace MozartCS.Inventaire_Equipement
{
    public partial class frmInventaireEquipementDetailCodeBarre: Form
    {

        public string sCodeBarre;
        public string sFileCodeBarre;
        public bool bCancel = false;
        public bool bSave = false;


        public frmInventaireEquipementDetailCodeBarre()
        {
            InitializeComponent();
        }

        private void frmInventaireEquipementDetailCodeBarre_Load(object sender, EventArgs e)
        {

            TxtCodeBarre.Text = sCodeBarre;
            if (sFileCodeBarre != null && sFileCodeBarre != "" && File.Exists(sFileCodeBarre))
            {
                PictCodeBarre.Image = Image.FromFile(sFileCodeBarre);
            }

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

            if(TxtCodeBarre.Text == "")
            {
                MessageBox.Show("Validation impossible car il faut saisir le libellé du code barre", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            sCodeBarre = TxtCodeBarre.Text;
            bSave = true;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bCancel = true;
            this.Close();
        }

        private void btnAddFileCodeBarre_Click(object sender, EventArgs e)
        {
            if (OFD.ShowDialog() != DialogResult.Cancel)
            {
                if (OFD.FileName != "")
                {
                    string vfilename = Path.GetFileName(OFD.FileName);
                    string vpathandfilename = OFD.FileName;

                    try
                    {
                        Bitmap bitmap = new Bitmap(OFD.FileName);
                        BarcodeReader reader = new BarcodeReader();
                        Result result = reader.Decode(bitmap);

                        if (result != null)
                        {
                            MessageBox.Show("Code-barres détecté : " + result.Text);
                            sCodeBarre = result.Text;
                            sFileCodeBarre = vpathandfilename;
                        }
                        else
                        {
                            MessageBox.Show("Aucun code-barres détecté.\r\nVous pouvez saisir le code manuellement");
                            sCodeBarre = "";
                            sFileCodeBarre = vpathandfilename;
                        }
                        TxtCodeBarre.Text = sCodeBarre;
                        if (PictCodeBarre.Image != null)
                        {
                            PictCodeBarre.Image.Dispose();
                        }
                        PictCodeBarre.Image = Image.FromFile(vpathandfilename);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur : " + ex.Message);
                        return;
                    }
                }
            }
        }
        private void btnDelFileCodeBarre_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez - vous supprimer ce code barre ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            sCodeBarre = "";
            sFileCodeBarre = "";
            if (PictCodeBarre.Image != null)
            {
                PictCodeBarre.Image = null;
                //PictCodeBarre.Image.Dispose();
            }
            TxtCodeBarre.Text = sCodeBarre;

        }
    }

}

        