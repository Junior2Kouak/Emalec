using MZCtrlResources = MozartControls.Properties.Resources;
using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmListeDocuments : Form
  {

    string strRepImage = "";
    string strRepAtt = "";
    DataTable dt = new DataTable();

    public frmListeDocuments()
    {
      InitializeComponent();
    }

    /* OK ---------------------------------------------------------------------*/
    private void frmListeDocuments_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);

        string sSql = "SELECT NCLINUM, VCLINOM FROM TCLI WHERE VSOCIETE = '" + MozartParams.NomSociete + "' AND CCLIACTIF='O'";
        apicboCritClient.Init(MozartDatabase.cnxMozart, sSql, "NCLINUM", "VCLINOM", new List<string>() { Resources.col_Num, Resources.col_Nom }, 150, 550);

        strRepImage = Utils.RechercheParam("REP_PHOTOS_ACT");
        strRepAtt = Utils.RechercheParam("REP_ATTGAM");

        InitGrid();
        Grid.FilterBar = false;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    /* OK ---------------------------------------------------------------------*/
    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    /* ---------------------------------------------------------------------*/
    private void InitGrid()
    {
      Grid.AddColumn(Resources.col_Type_document, "TYPE", 1700);
      Grid.AddColumn(Resources.col_Nature_document, "VTYPEDOCLIB", 2300);
      Grid.AddColumn(Resources.col_Nom_doc, "VIMAGE", 2100);
      Grid.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 2500, "", 0, true);   // <= AddCellTip
      Grid.AddColumn(Resources.col_Site, "VSITNOM", 3000, "", 0, true);   // <= AddCellTip
      Grid.AddColumn(Resources.col_Date, "DDATECRE", 1500, "dd/mm/yy");
      Grid.AddColumn(Resources.col_DI, "NDINNUM", 1100);
    }


    /* ---------------------------------------------------------------------*/
    private void cmdFind_Click(object sender, EventArgs e)
    {
      //  Création de la clause SQL à partir des critères saisis
      Cursor.Current = Cursors.WaitCursor;
      Grid.FilterBar = true;

      List<string> tCrit = new List<string>();
      //  Récupération des critères si non vide
      if (Strings.Trim(txtCritType.Text) != "")
        tCrit.Add(" AND VCLINOM LIKE '%" + Strings.Replace(txtCritType.Text, "'", "''") + "%'");

      if (Strings.Trim(txtCritNature.Text) != "")
        tCrit.Add(" AND VCLINOM LIKE '%" + Strings.Replace(txtCritNature.Text, "'", "''") + "%'");

      if (Strings.Trim(txtCritNumDI.Text) != "")
        tCrit.Add(" AND TACT.NDINNUM = " + txtCritNumDI.Text);

      if (Strings.Trim(apicboCritClient.GetText()) != "")
        tCrit.Add(" AND VCLINOM LIKE '%" + apicboCritClient.GetText().Replace("'", "''") + "%'");

      if (tCrit.Count == 0)
      {
        MessageBox.Show(Resources.msg_must_type_filter, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      string sSql = "  SELECT TACT.NDINNUM, TCLI.VCLINOM, TSIT.VSITNOM, TACT.NACTNUM, TIMAC.VIMAGE, TIMAC.VFICHIER, TIMAC.DDATECRE, VTYPEDOCLIB, VTYPE, "
      + " CASE TIMAC.VTYPEDEST WHEN 'C' THEN 'Client' WHEN 'I' THEN 'Interne' WHEN 'T' THEN 'Technicien' END AS 'TYPE'"
      + " FROM TACT WITH (NOLOCK) INNER JOIN TIMAC WITH (NOLOCK) ON TACT.NACTNUM = TIMAC.NACTNUM INNER JOIN"
      + " TREF_TYPEDOC WITH (NOLOCK) ON TREF_TYPEDOC.NTYPEDOC = TIMAC.NTYPEDOC INNER JOIN"
      + " TSIT WITH (NOLOCK) INNER JOIN"
      + " TCLI WITH (NOLOCK) ON TSIT.NCLINUM = TCLI.NCLINUM ON TACT.NSITNUM = TSIT.NSITNUM INNER JOIN"
      + " TDIN WITH (NOLOCK) ON TACT.NDINNUM = TDIN.NDINNUM INNER JOIN"
      + " TAUT WITH (NOLOCK) ON TDIN.NDINCTE = TAUT.NCANNUM INNER JOIN"
      + " TPER WITH (NOLOCK) ON TAUT.NPERNUM = TPER.NPERNUM"
      + " Where TPER.npernum = " + MozartParams.UID
      + " AND TCLI.VSOCIETE = '" + MozartParams.NomSociete + "'"
      + " AND LANGUE='" + MozartParams.Langue + "' ";

      foreach (var item in tCrit)
        sSql += item;
      sSql += " ORDER BY DDATECRE desc";

      Grid.LoadData(dt, MozartDatabase.cnxMozart, sSql);
      Grid.GridControl.DataSource = dt;

      Cursor.Current = Cursors.Default;
    }
    //Private Sub cmdFind_Click()
    //
    //  ' Création de la clause SQL à partir des critères saisis
    //  On Error Resume Next
    //  Screen.MousePointer = vbHourglass
    //  rsDcl.Close
    //  On Error GoTo Err
    //  
    //  Grid.FilterBar = True
    //  txtCritClient.LostFocus
    //  
    //  Dim tCrit(4) As String
    //  Dim sSQL As String, sWhere As String
    //  Dim i As Integer
    //  
    //  ' Récupération des critères si non vide
    //  If Trim(txtCritType) <> "" Then tCrit(0) = "VCLINOM LIKE '%" & CStr(Replace(txtCritType, "'", "''")) & "%'"
    //  If Trim(txtCritNature) <> "" Then tCrit(1) = "VCLINOM LIKE '%" & CStr(Replace(txtCritNature, "'", "''")) & "%'"
    //  If Trim(txtCritNumDI) <> "" Then tCrit(2) = "TACT.NDINNUM = " & CLng(txtCritNumDI)
    //  If Trim(txtCritClient.Texte) <> "" Then tCrit(3) = "VCLINOM LIKE '%" & CStr(Replace(txtCritClient.Texte, "'", "''")) & "%'"
    //  
    //  For i = 0 To 3
    //    If tCrit(i) <> "" Then sWhere = " AND " & tCrit(i) & sWhere
    //  Next
    //  
    //  If sWhere = "" Then
    //    MsgBox "Il faut renseigner au moins un filtre"
    //    Screen.MousePointer = vbDefault
    //    Exit Sub
    //  End If
    //
    //  sSQL = "  SELECT TACT.NDINNUM, TCLI.VCLINOM, TSIT.VSITNOM, TACT.NACTNUM, TIMAC.VIMAGE, TIMAC.VFICHIER, TIMAC.DDATECRE, VTYPEDOCLIB, VTYPE, "
    //  sSQL = sSQL & " CASE TIMAC.VTYPEDEST WHEN 'C' THEN 'Client' WHEN 'I' THEN 'Interne' WHEN 'T' THEN 'Technicien' END AS 'TYPE'"
    //  sSQL = sSQL & " FROM TACT WITH (NOLOCK) INNER JOIN TIMAC WITH (NOLOCK) ON TACT.NACTNUM = TIMAC.NACTNUM INNER JOIN"
    //  sSQL = sSQL & " TREF_TYPEDOC WITH (NOLOCK) ON TREF_TYPEDOC.NTYPEDOC = TIMAC.NTYPEDOC INNER JOIN"
    //  sSQL = sSQL & " TSIT WITH (NOLOCK) INNER JOIN"
    //  sSQL = sSQL & " TCLI WITH (NOLOCK) ON TSIT.NCLINUM = TCLI.NCLINUM ON TACT.NSITNUM = TSIT.NSITNUM INNER JOIN"
    //  sSQL = sSQL & " TDIN WITH (NOLOCK) ON TACT.NDINNUM = TDIN.NDINNUM INNER JOIN"
    //  sSQL = sSQL & " TAUT WITH (NOLOCK) ON TDIN.NDINCTE = TAUT.NCANNUM INNER JOIN"
    //  sSQL = sSQL & " TPER WITH (NOLOCK) ON TAUT.NPERNUM = TPER.NPERNUM"
    //  sSQL = sSQL & " Where TPER.npernum = " & gintUID
    //  sSQL = sSQL & " AND TCLI.VSOCIETE = '" & gstrNomSociete & "'"
    //  sSQL = sSQL & " AND LANGUE='" & gstrLangue & "'"
    //  sSQL = sSQL & sWhere
    //  
    //  rsDcl.Open sSQL, cnx, adOpenDynamic, adLockOptimistic
    //  rsDcl.Sort = "DDATECRE desc"
    //  Grid.Init rsDcl, bNiemeFois
    //  bNiemeFois = True
    //  Screen.MousePointer = vbDefault
    //  Exit Sub
    //  Resume
    //Err:
    //  ShowError "cmdFind_Click dans " & Me.Name
    //End Sub

    /* ---------------------------------------------------------------------*/
    private void cmdModifier_Click(object sender, EventArgs e)
    {
      DataRow row = Grid.GetFocusedDataRow();
      if (row == null) return;

      frmxVisuImg f = new frmxVisuImg();
      if (row["VTYPE"].ToString() == "ATTACH" || row["VTYPE"].ToString() == "GAMME")
        f.msImage = strRepAtt + row["VFICHIER"].ToString();
      else if (row["VTYPE"].ToString() == "DOCTECH")
        f.msImage = MozartParams.CheminDocTechnicien + row["VFICHIER"].ToString();
      else
        f.msImage = strRepImage + row["VFICHIER"].ToString();

      f.ShowDialog();
    }
    //Private Sub cmdModifier_Click()
    //  
    //   On Error Resume Next
    //
    //  If rsDcl.EOF Then Exit Sub
    //  
    //  If (rsDcl("VTYPE") = "ATTACH" Or rsDcl("VTYPE") = "GAMME") Then
    //      frmxVisuImg.mstrImage = strRepAtt & rsDcl("VFICHIER")
    //  ElseIf rsDcl("VTYPE") = "DOCTECH" Then
    //    frmxVisuImg.mstrImage = gstrCheminDocTechnicien & rsDcl("VFICHIER")
    //  Else
    //    frmxVisuImg.mstrImage = mRepertoireDoc & rsDcl("VFICHIER")
    //  End If
    //  
    //  frmxVisuImg.Show vbModal
    //
    //End Sub

    /* ---------------------------------------------------------------------*/
    private void cmdDI_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow currentRow = Grid.GetFocusedDataRow();

        if (currentRow == null) return;

        MozartParams.NumDi = Convert.ToInt32(currentRow["NDINNUM"]);
        MozartParams.NumAction = Convert.ToInt32(currentRow["NACTNUM"]);

        //écran de modification de la demande
        frmAddAction f = new frmAddAction();
        f.mstrStatutDI = "M";

        f.ShowDialog();

        MozartParams.NumDi = 0;
        MozartParams.NumAction = 0;

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }


    /* ---------------------------------------------------------------------*/
    private void cmdSupprimer_Click(object sender, EventArgs e)
    {
      DataRow row = Grid.GetFocusedDataRow();
      if (row == null) return;

      if (MessageBox.Show(Resources.msg_confirm_archive_devis, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                          MessageBoxDefaultButton.Button2) == DialogResult.Yes)
      {
        ModuleData.ExecuteNonQuery($"exec api_sp_ArchActSuiteArchDevis {row["NACTNUM"]}, {row["NDCLNUM"]}");
      }
    }
    //Private Sub cmdSupprimer_Click()
    //  
    //  On Error Resume Next
    //
    //  ' Archivage du devis sélectionné
    //  If rsDcl.EOF Then Exit Sub
    //
    //  If MsgBox("§Voulez-vous vraiment archiver ce devis ? (l'action du devis sera passée en archive)§", vbYesNo + vbQuestion + vbDefaultButton2) = vbYes Then
    //    'cnx.Execute "UPDATE TDCL SET CDCLACTIF = 'N' WHERE NDCLNUM = " & rsDcl!NDCLNUM, 3
    //    'Archive auto de l action lié au devis le 07/10/2010 par MC
    //    cnx.Execute "exec api_sp_ArchActSuiteArchDevis " & rsDcl!NACTNUM & "," & rsDcl!NDCLNUM
    //    rsDcl.Requery
    //    Grid.Init rsDcl, True
    //  End If
    //
    //End Sub

    /* ---------------------------------------------------------------------*/
    private void txtCritNature_Enter(object sender, EventArgs e)
    {
      txtCritNature.SelectionStart = 0;
      txtCritNature.SelectionLength = 100;
    }

    /* ---------------------------------------------------------------------*/
    private void txtCritNumDI_Enter(object sender, EventArgs e)
    {
      txtCritNumDI.SelectionStart = 0;
      txtCritNumDI.SelectionLength = 100;
    }

    /* ---------------------------------------------------------------------*/
    private void txtCritClient_Enter(object sender, EventArgs e)
    {
    }

    /* OK ---------------------------------------------------------------------*/
    private void frmListeDocuments_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.F2)
        cmdFind_Click(null, null);
    }
  }
}