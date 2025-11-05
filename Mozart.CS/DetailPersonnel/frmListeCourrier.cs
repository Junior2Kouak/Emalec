using DevExpress.XtraGrid.Views.Grid;
using MozartCS.Properties;
using MozartNet;
using MozartLib;
using ReportEmalec.Net;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace MozartCS
{
  public partial class frmListeCourrier : Form
  {
    public string msNomPersonne = "";

    bool bNiemeFois;
    DataTable dt = new DataTable();

    public frmListeCourrier()
    {
      InitializeComponent();
    }

    private void frmListeCourrier_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);
        // Inutile car contrôle invisible
        //chkAll.BackColor = ModuleMain.Couleur(MozartParams.NomSociete);

        bNiemeFois = false;

        // si on vient de la liste du personnel, on cherche les courriers fait à une personne
        if (msNomPersonne != "")
        {
          cboCritDest.SelectedIndex = 5;
          cmdFind_Click(null, null);

          apiGrid.dgv.ActiveFilterString = $"Nom LIKE '%{msNomPersonne}%'";
        }
      }
      catch (Exception ex) { Utils.ShowException(ex, MethodBase.GetCurrentMethod().Name, ex.StackTrace); }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void cmdFind_Click(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        string p_TOP = "";

        // on test la validité des filtres (au moins 3 ou 4 lettres)
        // on test la validité des filtres (au moins 3 lettres)
        if (txtCritAuteur.Text.Length > 0 && txtCritAuteur.Text.Length < 3)
        {
          MessageBox.Show("Il faut filtrer avec au moins 3 lettres dans l'auteur", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          txtCritAuteur.Focus();
          Cursor.Current = Cursors.Default;
          return;
        }

        if (txtCritRef.Text.Length > 0 && txtCritRef.Text.Length < 4)
        {
          MessageBox.Show("Il faut filtrer avec au moins 4 lettres dans la référence", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          txtCritRef.Focus();
          Cursor.Current = Cursors.Default;
          return;
        }

        if (txtCritObj.Text.Length > 0 && txtCritObj.Text.Length < 4)
        {
          MessageBox.Show("Il faut filtrer avec au moins 4 lettres dans l'objet", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          txtCritObj.Focus();
          Cursor.Current = Cursors.Default;
          return;
        }

        // on regarde les filtres et si aucun filtre, on affiche le cas des 1000 courriers
        string sCritAuteur = txtCritAuteur.Text == "" ? "T" : txtCritAuteur.Text;
        string sCritDest = cboCritDest.Text == "" ? "T" : cboCritDest.Text;
        string sCritRef = txtCritRef.Text == "" ? "T" : txtCritRef.Text.Replace("'", "''");
        string sCritObj = txtCritObj.Text == "" ? "T" : txtCritObj.Text.Replace("'", "''");

        if (sCritAuteur == "T" && sCritDest == "T" && sCritRef == "T" && sCritObj == "T") p_TOP = "TOP";

        apiGrid.LoadData(dt, MozartDatabase.cnxMozart, $"api_sp_listeCourrier '{p_TOP}', '{sCritAuteur}', '{sCritDest}', '{sCritRef}', '{sCritObj}'");
        apiGrid.GridControl.DataSource = dt;

        if (!bNiemeFois)
        {
          InitApigrid();
        }
      }
      catch (Exception ex) { Utils.ShowException(ex, MethodBase.GetCurrentMethod().Name, ex.StackTrace); }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void InitApigrid()
    {
      apiGrid.AddColumn("Num", "NCOURNUM", 1200);
      apiGrid.AddColumn(Resources.col_Date, "DCOURDAT", 900, "dd/mm/yy");
      apiGrid.AddColumn(Resources.col_Auteur, "VPERNOM", 2000);
      apiGrid.AddColumn(Resources.col_nature, "VTYPCOUR", 1300);
      apiGrid.AddColumn(Resources.col_destinataire, "VCOURTYPDEST", 1200);
      apiGrid.AddColumn(Resources.col_Nom, "Nom", 2000, "", 0, true);
      apiGrid.AddColumn(Resources.col_Contact, "Contact", 2000, "", 0, true);
      apiGrid.AddColumn(Resources.col_Ref, "VCOURREF", 2000, "", 0, true);
      apiGrid.AddColumn(Resources.col_Objet, "VCOUROBJET", 2000, "", 0, true);
      apiGrid.AddColumn(Resources.col_Objet, "CCOURTYPCOUR", 0);
      apiGrid.AddColumn(Resources.col_Objet, "VCOURTYPAR", 0);
      apiGrid.AddColumn(Resources.col_Objet, "NCOURID", 0);
      apiGrid.AddColumn("NumCOUR", "NUMCOUR", 0);
      apiGrid.AddColumn("IDDEST", "NCOURIDDEST", 0);
      apiGrid.AddColumn(Resources.col_Action, "NACTNUM", 0);
      apiGrid.AddColumn("NumAR", "VCOURNUMAR", 900);

      bNiemeFois = true;

      apiGrid.InitColumnList();
    }

    private void cmdNouvelle_Click(object sender, EventArgs e)
    {
      //écran de création de la demande
      new frmSelectCourrier
      {
        mstrTypeDest = ""
      }.ShowDialog();

      Cursor.Current = Cursors.WaitCursor;
      cmdFind_Click(null, null);
      Cursor.Current = Cursors.Default;
    }
    
    private void cmdModifier_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apiGrid.GetFocusedDataRow();
      if (currentRow == null) return;

      Cursor.Current = Cursors.WaitCursor;

      // selon le type de courrier, on envi sur des écrans différents
      switch (currentRow["CCOURTYPCOUR"])
      {
        case "A":
          //passage des infos
          new frmSaisieAttestation
          {
            mstrTypeDest = currentRow["VCOURTYPDEST"].ToString(),
            mstrTypeCour = "A",
            mstrTypeAR = currentRow["VCOURTYPAR"].ToString(),
            miNumCourrier = Convert.ToInt64(currentRow["NCOURID"]),
            miAction = Convert.ToInt64(currentRow["NACTNUM"]),
            mstrStatutCourrier = "M"
          }.ShowDialog();
          break;

        case "L":
        case "F":
        case "N":
        case "M":
          new frmModifLettre
          {
            mstrTypeDest = currentRow["VCOURTYPDEST"].ToString(),
            mstrTypeCour = currentRow["CCOURTYPCOUR"].ToString(),
            mstrTypeAR = currentRow["VCOURTYPAR"].ToString(),
            iNumCourrier = Convert.ToInt64(currentRow["NUMCOUR"]),
            iNumDest = Convert.ToInt64(currentRow["NCOURIDDEST"])
          }.ShowDialog();
          break;
        case "C":
          //passage des infos
          MessageBox.Show($"Ce courrier n'est plus géré, contactez le service informatique.",
            Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          break;

        default:
          break;
      }

      int position = apiGrid.dgv.FocusedRowHandle;
      var filtre = apiGrid.dgv.ActiveFilterString;

      cmdFind_Click(null, null);
      apiGrid.dgv.ActiveFilterString = filtre;

      apiGrid.dgv.FocusedRowHandle = position;
      Cursor.Current = Cursors.Default;
    }
    
    private void cmdImprimer_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow currentRow = apiGrid.GetFocusedDataRow();
        if (currentRow == null) return;

        int bookmark = (apiGrid.GridControl.DefaultView as GridView).FindRow(currentRow);

        string sTypeCourrier = currentRow["CCOURTYPCOUR"].ToString();
        string sModele = ModuleMain.RechercheModele(sTypeCourrier);

        if (sTypeCourrier == "A")
        {

          new frmMainReport
          {
            bLaunchByProcessStart = false,
            sTypeReport = "TATTESTATION",
            sIdentifiant = $"CLIENT|{currentRow["NCOURID"]}|2/2  Client",
            InfosMail = $"0|0|0",
            sNomSociete = MozartParams.NomSociete,
            sLangue = MozartParams.Langue,
            sOption = "PRINT",
          }.ShowDialog();
        }
        else if (sTypeCourrier != "C")
        {
          new frmMainReport
          {
            bLaunchByProcessStart = false,
            sTypeReport = PrepareReport.TLETTREV3,
            sIdentifiant = $"{currentRow["NUMCOUR"]}|0|{currentRow["NCOURIDDEST"]}",
            InfosMail = "",
            sNomSociete = MozartParams.NomSociete,
            sLangue = Strings.Left(ModuleMain.CodePays(currentRow["PAYS"].ToString()), 2),
            sOption = "PRINT",
            strType = "CO",
            numAction = MozartParams.NumAction
          }.ShowDialog();


        }
        else
        {
          MessageBox.Show($"Ce courrier n'est plus géré, contactez le service informatique.",
                      Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        (apiGrid.GridControl.DefaultView as GridView).SelectRow(bookmark);
      }
      catch (Exception ex) { Utils.ShowException(ex, MethodBase.GetCurrentMethod().Name, ex.StackTrace); }
    }

    private void cmdSupprimer_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow currentRow = apiGrid.GetFocusedDataRow();
        if (currentRow == null) return;

        Cursor.Current = Cursors.WaitCursor;

        if (MessageBox.Show(Resources.msg_Confirm_courrier_deletion, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
          ModuleData.SupprimerEnreg(Convert.ToInt64(currentRow["NUMCOUR"]), "api_sp_SupprimerCourrier", "@iNumCourrier");

        cmdFind_Click(null, null);
      }
      catch (Exception ex) { Utils.ShowException(ex, MethodBase.GetCurrentMethod().Name, ex.StackTrace); }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void Command1_Click(object sender, EventArgs e)
    {
      if (frmAide.Visible == true)
        frmAide.Visible = false;
      else
        frmAide.Visible = true;
    }

    private void Command2_Click(object sender, EventArgs e)
    {
      frmAide.Visible = false;
    }

    private void apiGrid_DoubleClickE(object sender, EventArgs e)
    {
      cmdModifier_Click(null, null);
    }

    private void Form_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.F2)
        cmdFind_Click(null, null);
    }
  }
}
