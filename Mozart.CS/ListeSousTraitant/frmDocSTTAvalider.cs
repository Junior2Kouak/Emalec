using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmDocSTT : Form
  {
    public int iDocAdminSTFNum;
    public int iSTFGRPNUM;
    public string strNom;
    public string CheminDocAdminSTFATraiter;

    bool bArchive;
    private string sNomFichier;

    public frmDocSTT() { InitializeComponent(); }

    private void frmDocSTT_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        Label2.Text = strNom;

        //Init
        bArchive = false;
        ModuleData.RemplirCombo(cboTypeDoc, $"SELECT NTYPEDOCSTFNUM, VTYPEDOCSTFLIB FROM TREF_TYPEDOCSTF WHERE VLANGUE = '{MozartParams.Langue}' AND CTYPEDOCSTFACTIF = 'O'");
        cboTypeDoc.ValueMember = "NTYPEDOCSTFNUM";
        cboTypeDoc.DisplayMember = "VTYPEDOCSTFLIB";

        OuvertureEnModification();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void OuvertureEnModification()
    {
      try
      {
        //recherche des infos du documents dans la table des docs à valider
        if (iDocAdminSTFNum > 0)
        {
          using (SqlDataReader drDocSTF = ModuleData.ExecuteReader($"select * from TW2DOCSTF WHERE NDOCSTFNUM= {iDocAdminSTFNum}"))
          {
            if (drDocSTF.Read())
            {
              TxtFic.Text = Utils.BlankIfNull(drDocSTF["VDOCSTFNOM"]);
              txtRem.Text = Utils.BlankIfNull(drDocSTF["VDOCSTFCOM"]);

              //visualisation du fichier (user impersonate)
              WebBrowser1.Navigate("about:blank");
              WebBrowser1.Navigate(CImpersonation.OpenFileImpersonated(CheminDocAdminSTFATraiter + Utils.BlankIfNull(drDocSTF["VDOCSTFNOM"])));
            }
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdEnregistrer_Click(object sender, EventArgs e)
    {
      try
      {
        //Test de la date
        if (txtDateDoc.Text == "")
        {
          MessageBox.Show(Resources.msg_Format_date_incorrect, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        // test du type de fichier
        if (cboTypeDoc.Text == "")
        {
          MessageBox.Show(Resources.msg_Select_type_doc, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        //génération d'un numéro unique pour le nom physique
        sNomFichier = DateTime.Now.ToString("yyyyddMMHHmmss") + "_" + iSTFGRPNUM + ".pdf";

        //enregistrement du document dans la base 
        Enregistrer();

        //marque le doc comme validé avec la date et qui 
        ModuleData.CnxExecute($"UPDATE TW2DOCSTF SET BDOCVALIDER=1, DDOCSTFTRAITE=GetDate(), NQUITRAITE={MozartParams.UID} WHERE NDOCSTFNUM={iDocAdminSTFNum}");

        //Copie du fichier dans le répertoire de prod
        // a changer ensuite et mettre un move
        CImpersonation.CopyFileImpersonated(CheminDocAdminSTFATraiter + TxtFic.Text, Utils.RechercheParam("REP_DOC_STF") + sNomFichier);

        // fermer la fenêtre
        Dispose();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void Enregistrer()
    {
      try
      {
        //création du doc et déplacement du fichier
        using (SqlCommand cmd = new SqlCommand("api_sp_CreationDocAdminSTF", MozartDatabase.cnxMozart))
        {
          //passage du nom de la procédure stockée
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);

          //liste des paramètres
          cmd.Parameters["@p_ndocstfnum"].Value = 0;
          cmd.Parameters["@p_nstfgrpnum"].Value = iSTFGRPNUM;
          cmd.Parameters["@p_ntypedocnum"].Value = cboTypeDoc.GetItemData();
          cmd.Parameters["@p_vdocfile"].Value = sNomFichier;
          cmd.Parameters["@p_vcomment"].Value = txtRem.Text;
          cmd.Parameters["@p_ddocstfedi"].Value = txtDateDoc.Text;
          cmd.Parameters["@p_bArchive"].Value = !bArchive;

          cmd.ExecuteNonQuery();
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdDocSTT_Click(object sender, EventArgs e)
    {
      new frmGestDocAdminSTF()
      {
        miStfGrpNnum = iSTFGRPNUM,
        mstrNom = strNom
      }.ShowDialog();
    }
  }
}

