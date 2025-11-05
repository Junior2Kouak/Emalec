using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmlisteReaproTech : Form
  {
    DataTable dt = new DataTable();
    //Dim rsDdes As ADODB.Recordset

    public frmlisteReaproTech() { InitializeComponent(); }

    /* OK --------------------------------------------------------------------------------------- */
    private void frmlisteReaproTech_Load(object sender, EventArgs e)
    {
      ModuleMain.Initboutons(this);
      //combo des tech

      //TB SAMSIC CITY SPEC
      if (MozartParams.NomGroupe.ToUpper() == "EMALEC")
      {
        string sSql = $"select NPERNUM, VPERNOM + ' ' + VPERPRE as VPERNOM from TPER where (CPERTYP='TE' OR CPERTYP='CA') " +
          $"AND VSOCIETE = App_Name() AND CPERACTIF = 'O' UNION Select Case App_Name() WHEN 'EMALEC' THEN 557 " +
          $"WHEN 'EMALECMPM' THEN 3008 WHEN 'EQUIPAGE' THEN 1887 WHEN 'EMALECBELGIQUE' THEN 2400 " +
          $"WHEN 'EMALECFACILITEAM' THEN 2933 WHEN 'MAGESTIME' THEN 1654 WHEN 'EMALECESPAGNE' THEN 2486  " +
          $"WHEN 'SCS' THEN 2323 WHEN 'EMALECLUXEMBOURG' THEN 2918 ELSE 557 END AS NPERNUM, Case App_Name() " +
          $"WHEN 'EMALEC' THEN 'THET Benjamin' WHEN 'EMALECMPM' THEN 'LAZZAROTTO Ludovic' WHEN 'SCS' THEN 'RONZEL Stéphane' " +
          $"WHEN 'EQUIPAGE' THEN 'LESCOP Stéphane' WHEN 'EMALECBELGIQUE' THEN 'SAUER Julien' " +
          $"WHEN 'EMALECLUXEMBOURG' THEN 'SAUER Julien' WHEN 'MAGESTIME' THEN 'THET Benjamin' WHEN 'EMALECESPAGNE' THEN 'HERRERO David' " +
          $"WHEN 'EMALECFACILITEAM' THEN 'SAUER Julien' ELSE 'THET Benjamin' END As vpernom ORDER BY  VPERNOM";

        apicboTech.Init(MozartDatabase.cnxMozart, sSql, "NPERNUM", "VPERNOM", new List<string>() { Resources.col_Num, Resources.col_Nom }, 150, 550, true);
      }

      LoadDatagridView();
      InitapiGridH();
    }
    //Private Sub Form_Load()

    //Dim sSql As String
    //Dim sSqlc As String
    //  InitBoutons Me, frmMenu
    //    ' combo des tech
    //  cboTech.SizeCombo 600
    //  cboTech.Clear
    //  ' TB SAMSIC CITY SPEC
    //  If gstrNomGroupe = "EMALEC" Then
    //    sSqlc = "select NPERNUM, VPERNOM + ' ' + VPERPRE as VPERNOM from TPER where (CPERTYP='TE' OR CPERTYP='CA') AND VSOCIETE = App_Name() AND CPERACTIF = 'O' UNION "
    //    sSqlc = sSqlc + "Select Case App_Name() WHEN 'EMALEC' THEN 557 WHEN 'EMALECMPM' THEN 3008 WHEN 'EQUIPAGE' THEN 1887 WHEN 'EMALECBELGIQUE' THEN 2400 WHEN 'EMALECFACILITEAM' THEN 2933 "
    //    sSqlc = sSqlc + "WHEN 'MAGESTIME' THEN 1654 WHEN 'EMALECESPAGNE' THEN 2486  WHEN 'SCS' THEN 2323 WHEN 'EMALECLUXEMBOURG' THEN 2918 ELSE 557 END AS NPERNUM, "
    //    sSqlc = sSqlc + "Case App_Name() WHEN 'EMALEC' THEN 'THET Benjamin' WHEN 'EMALECMPM' THEN 'LAZZAROTTO Ludovic' WHEN 'SCS' THEN 'RONZEL Stéphane' "
    //    sSqlc = sSqlc + "WHEN 'EQUIPAGE' THEN 'LESCOP Stéphane' WHEN 'EMALECBELGIQUE' THEN 'SAUER Julien' WHEN 'EMALECLUXEMBOURG' THEN 'SAUER Julien' WHEN 'MAGESTIME' THEN 'THET Benjamin' "
    //    sSqlc = sSqlc + "WHEN 'EMALECESPAGNE' THEN 'HERRERO David' WHEN 'EMALECFACILITEAM' THEN 'SAUER Julien' ELSE 'THET Benjamin' END As vpernom ORDER BY  VPERNOM"
    //  End If ' TB SAMSIC CITY TODO -> else pour samsic
    //  RemplirCombo cboTech, sSqlc
    //  sSql = "SELECT 'Dd' + dbo.FormatCle(TSTOCKDDE.NDDENUM,5) 'DDE', VPERNOM , DDDEDATE, VDDEOBJET, TACT.NPERNUM, NDDENUM, NDINNUM FROM TSTOCKDDE WITH (NOLOCK) INNER JOIN"
    //  sSql = sSql + " TACT WITH (NOLOCK) ON TSTOCKDDE.NACTNUM = TACT.NACTNUM INNER JOIN  TPER WITH (NOLOCK) ON TACT.NPERNUM = TPER.NPERNUM "
    //  sSql = sSql + " WHERE VDDETYPE = 'REAPPRO' AND TACT.NPERNUM in (557) ORDER BY  NDDENUM DESC"
    //  Set rsDdes = New ADODB.Recordset
    //  rsDdes.Open sSql, cnx
    //  InitapiGridH
    //  Screen.MousePointer = vbDefault
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void LoadDatagridView()
    {
      string sSQL = "SELECT 'Dd' + dbo.FormatCle(TSTOCKDDE.NDDENUM,5) 'DDE', VPERNOM , DDDEDATE, VDDEOBJET, TACT.NPERNUM, NDDENUM, NDINNUM " +
                    "FROM TSTOCKDDE WITH (NOLOCK) INNER JOIN TACT WITH (NOLOCK) ON TSTOCKDDE.NACTNUM = TACT.NACTNUM INNER JOIN  TPER WITH (NOLOCK) " +
                    "ON TACT.NPERNUM = TPER.NPERNUM WHERE VDDETYPE = 'REAPPRO' AND TACT.NPERNUM in (557) AND VSOCIETE = '" + MozartParams.NomSociete + "' ORDER BY  NDDENUM DESC";
      apiTGridH.LoadData(dt, MozartDatabase.cnxMozart, sSQL);
      apiTGridH.GridControl.DataSource = dt;
    }

    /* OK --------------------------------------------------------------------------------------- */
    private void InitapiGridH()
    {
      try
      {
        apiTGridH.AddColumn(Resources.col_Dde, "DDE", 900);
        apiTGridH.AddColumn(Resources.col_Tech, "VPERNOM", 1500);
        apiTGridH.AddColumn(Resources.col_DateDde, "DDDEDATE", 1100, "Date");
        apiTGridH.AddColumn(Resources.col_OBS, "VDDEOBJET", 3000);
        apiTGridH.AddColumn("NPERNUM", "NPERNUM", 0);
        apiTGridH.AddColumn("NDDENUM", "NDDENUM", 0);

        //apiTGridH.FilterBar = true;
        apiTGridH.InitColumnList();
        //apiTGridH.AddCellStyle("VDDEOBJET", "&HFDF0DA")  --> apiTGridH_RowCellStyle()
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub InitapiGridH()
    //On Error GoTo handler

    //  apiTGridH.AddColumn "§Dde§", "DDE", 900
    //  apiTGridH.AddColumn "§Tech§", "VPERNOM", 1500
    //  apiTGridH.AddColumn "§Date dde§", "DDDEDATE", 1100
    //  apiTGridH.AddColumn "§OBS§", "VDDEOBJET", 3000
    //  apiTGridH.AddColumn "npernum", "NPERNUM", 0
    //  apiTGridH.AddColumn "§Dde§", "NDDENUM", 0
    //  apiTGridH.FilterBar = True
    //  apiTGridH.Init rsDdes

    //  apiTGridH.AddCellTip "VDDEOBJET", &HFDF0DA            ' Tip = contenu de la cellule entière   ' Vert pale

    //  Exit Sub

    //handler:
    //  ShowError "InitApigridH dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void apiTGridH_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
    {
      if (e.Column.Name == "VDDEOBJET")
        e.Appearance.BackColor = Color.NavajoWhite;
    }

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdAffecter_Click(object sender, EventArgs e)
    {
      if (apicboTech.GetText() == "")
      {
        MessageBox.Show(Resources.msg_ChoixTechAffectADmdReappro);
        return;
      }

      //TODO Valider les Update dans la base
      DataRow row = apiTGridH.GetFocusedDataRow();
      if (row == null) return;

      if (MessageBox.Show(Resources.msg_VousAllezAffecterDemande + row["DDE"] + Resources.msg_AuTech + apicboTech.GetText() + "." + "\r\n" + Resources.msg_EtesVousDaccord,
                          Program.AppTitle, MessageBoxButtons.YesNo) == DialogResult.Yes)
      {
        ModuleData.ExecuteNonQuery($"UPDATE TACT SET NPERNUM = {apicboTech.GetItemData()} WHERE NDINNUM = {row["NDINNUM"]}");
        ModuleData.ExecuteNonQuery($"UPDATE TSTOCK SET NSTOCKLIEU = {apicboTech.GetItemData()} WHERE NDDENUM = {row["NDDENUM"]} AND NSTOCKLIEU <> 0 ");
        ModuleData.ExecuteNonQuery($"UPDATE TSTOCKDDE SET NDDEDEST = {apicboTech.GetItemData()} WHERE NDDENUM = {row["NDDENUM"]}");
        apiTGridH.Requery(dt, MozartDatabase.cnxMozart);
      }
    }
    //Private Sub cmdAffecter_Click()

    //If rsDdes.EOF Then Exit Sub

    //If cboTech.Text = "" Then
    //  MsgBox ("Choisissez le technicien a affecter sur la demande de réappro")
    //  Exit Sub
    //End If

    //If MsgBox("§Vous allez affecter la demande §" & rsDdes!DDE & "§au technicien §" & cboTech.Text & "." & vbCrLf & "Etes vous d'accord ?", vbYesNo + vbQuestion + vbDefaultButton2) = vbYes Then
    //  cnx.Execute "update tact set npernum=" & cboTech.ItemData(cboTech.ListIndex) & " where ndinnum=" & rsDdes!NDINNUM
    //  cnx.Execute "update tstock  set nstocklieu = " & cboTech.ItemData(cboTech.ListIndex) & " where nddenum=" & rsDdes!NDDENUM & " and nstocklieu <> 0 "
    //  cnx.Execute "update tstockdde set nddedest = " & cboTech.ItemData(cboTech.ListIndex) & " where nddenum=" & rsDdes!NDDENUM
    //  rsDdes.Requery
    //End If
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdFermer_Click(object sender, EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdFermer_Click()
    //  Unload Me
    //End Sub
  }
}