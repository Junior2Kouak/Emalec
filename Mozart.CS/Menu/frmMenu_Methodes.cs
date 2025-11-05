using MozartNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MozartCS
{
    public partial class frmMenu_Methodes : Form
    {
        public frmMenu_Methodes()
        {
            InitializeComponent();
        }

        private void frmMenu_Methodes_Load(object sender, EventArgs e)
        {
            ModuleMain.Initboutons(this);
        }

        private void btnMethodes_Click(object sender, EventArgs e)
        {
            new frmMethodes_Admin_Equipement().ShowDialog();
        }

        private void BtnPrepaInventaire_Click(object sender, EventArgs e)
        {
            new frmMethodes_Prepa_Inventaire().ShowDialog();
        }

        private void BtnGestCliChamp_Click(object sender, EventArgs e)
        {
            new frmMethodes_Admin_Equipement_GestionChampByClient().ShowDialog();
        }

        private void CmdGTP_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            new frmGTPGestion().ShowDialog();
            Cursor.Current = Cursors.Default;
        }
    }
}
