using MZCtrlResources = MozartControls.Properties.Resources;
using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmTechDansVille : Form
  {
    //Option Explicit
    //
    //Dim adoRS As ADODB.Recordset
    //Dim adoRSNumDi As ADODB.Recordset
    //Public mstrville As String

    public string mstrVille = "";

    DataTable dt = new DataTable();

    public frmTechDansVille()
    {
      InitializeComponent();
    }

    /* OK --------------------------------------------------------------------------*/
    private void frmTechDansVille_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);

        InitApigrid();

        //   combo des clients
        apicboCP.Init(MozartDatabase.cnxMozart, "select distinct VSITCP from TSIT INNER JOIN TCLI ON TSIT.NCLINUM = TCLI.NCLINUM where VSITCP is not null order by VSITCP",
                  "VSITCP", "VSITCP", new List<string>() { Resources.col_Code }, 50, 400, false);
        apicboVille.Init(MozartDatabase.cnxMozart, "select distinct VSITVIL from TSIT INNER JOIN TCLI ON TSIT.NCLINUM = TCLI.NCLINUM where VSITVIL is not null order by VSITVIL",
                  "VSITVIL", "VSITVIL", new List<string>() { Resources.col_Nom }, 200, 400, false);

        if (mstrVille != "")
          apicboVille.SetText(mstrVille);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub Form_Load()
    //
    //On Error GoTo handler
    //
    //InitBoutons Me, frmMenu
    //
    //  
    //  cboCP.SizeCombo 400
    //  cboVille.SizeCombo 400
    //  
    // 
    //  ' combo des clients
    //  RemplirCombo cboCP, "select distinct 1, VSITCP from TSIT INNER JOIN TCLI ON TSIT.NCLINUM = TCLI.NCLINUM where VSITCP is not null order by VSITCP"
    //  RemplirCombo cboVille, "select distinct 1, VSITVIL from TSIT INNER JOIN TCLI ON TSIT.NCLINUM = TCLI.NCLINUM where VSITVIL is not null order by VSITVIL"
    //
    //
    //  If mstrville <> "" Then
    //    cboVille.Text = mstrville
    //    cmdEnregistrer_Click
    //  End If
    //
    //
    //Exit Sub
    //handler:
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdFermer_Click()
    //  Unload Me
    //End Sub

    /* En attente --------------------------------------------------------------------------*/
    private void cmdDI_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apiTGrid1.GetFocusedDataRow();
      if (currentRow == null) return;

      if (currentRow != null)
      {
        // recherche de l'IP ou de la di dans le tag de l'image
        string[] tabAct = Strings.Split(currentRow[6].ToString(), ",");

        // UBound() renvoie 0 si il y a 1 enregistrement, puis nb enreg -1
        if (tabAct.Length == 1)
        {
          using (SqlDataReader dr = ModuleData.ExecuteReader("SELECT NDINNUM, NACTNUM FROM TACT WITH(NOLOCK) WHERE NACTNUM = " + tabAct[0]))
          {
            if (dr.Read())
            {
              // écran de modification de la demande
              MozartParams.NumDi = (int)dr["NDINNUM"];
              MozartParams.NumAction = (int)dr["NACTNUM"];
              new frmAddAction
              {
                mstrStatutDI = "M"
              }.ShowDialog();
            }
          }
        }
        else
        {
          new frmDetailIP
          {
            miNumIP = 0,
            sNumAct = currentRow[6].ToString()
          }.ShowDialog();
        }
      }
    }
    //Private Sub cmdDi_Click()
    //Dim tabAct
    //
    //
    //    If ApiGrid.Valeur <> "" Then
    //        ' recherche de l'IP ou de la di dans le tag de l'image
    //        tabAct = Split(ApiGrid.ValeurCol(6), ",")
    //        
    //        ' UBound() renvoie 0 si il y a 1 enregistrement, puis nb enreg -1
    //        If UBound(tabAct) = 0 Then
    //            
    //            Set adoRSNumDi = New ADODB.Recordset
    //            adoRSNumDi.Open "SELECT NDINNUM,NACTNUM FROM TACT WITH (NOLOCK) WHERE NACTNUM = " & tabAct(0), cnx
    //            
    //            adoRSNumDi.MoveFirst
    //            
    //            ' écran de modification de la demande
    //            frmAddAction.mstrStatutDI = "M"
    //            giNumDi = adoRSNumDi("NDINNUM").Value
    //            glNumAction = adoRSNumDi("NACTNUM").Value
    //          
    //            frmAddAction.Show vbModal
    //        Else
    //            frmDetailIP.miNumIP = 0
    //            frmDetailIP.sNumAct = ApiGrid.ValeurCol(6)
    //            frmDetailIP.Show vbModal
    //        End If
    //    End If
    //
    //End Sub
    //

    /* OK --------------------------------------------------------------------------*/
    private void cmdEnregistrer_Click(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        string sSql = $"exec api_sp_RechercheTechVille '{apicboCP.GetText().Replace("'", "''")}', '{apicboVille.GetText().Replace("'", "''")}'";
        apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, sSql);
        apiTGrid1.GridControl.DataSource = dt;
        //InitApigrid();
        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub cmdEnregistrer_Click()
    // 
    //    
    //On Error GoTo handler
    //
    //  Screen.MousePointer = vbHourglass
    //      
    //  Set adoRS = New ADODB.Recordset
    //  adoRS.Open "exec api_sp_RechercheTechVille '" & Replace(cboCP.Text, "'", "''") & "','" & Replace(cboVille.Text, "'", "''") & "'", cnx
    //
    //  InitApigrid
    //  
    //  Screen.MousePointer = vbDefault
    //
    //Exit Sub
    //handler:
    //  ShowError "cmdEnregistrer_Click dans " & Me.Name
    //End Sub
    //

    /* OK --------------------------------------------------------------------------*/
    private void cboCP_TxtChanged(object sender, EventArgs e)
    {
      apicboVille.SetText("");
    }
    //Private Sub cboCP_Click()
    //  cboVille.ListIndex = -1
    //End Sub
    //

    /* OK --------------------------------------------------------------------------*/
    private void cboVille_TxtChanged(object sender, EventArgs e)
    {
      apicboCP.SetText("");
    }
    //Private Sub cboVille_Click()
    //  cboCP.ListIndex = -1
    //End Sub
    //

    /* OK --------------------------------------------------------------------------*/
    private void InitApigrid()
    {
      try
      {
        apiTGrid1.AddColumn(Resources.col_Technicien, "VPERNOM", 1900);
        apiTGrid1.AddColumn(Resources.col_Date, "DIPLDATJ", 900, "dd/mm/yy");
        apiTGrid1.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1800);
        apiTGrid1.AddColumn(Resources.col_Site, "VSITNOM", 1900);
        apiTGrid1.AddColumn(Resources.col_CP, "VSITCP", 800);
        apiTGrid1.AddColumn(Resources.col_Ville, "VSITVIL", 1900);
        apiTGrid1.AddColumn("", "NUMACT", 0);
        apiTGrid1.AddColumn("", "NSITNUM", 0);
        apiTGrid1.AddColumn("", "", 0);
        apiTGrid1.AddColumn(Resources.col_dist_km, "KM", 1000);

        apiTGrid1.InitColumnList();

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub InitApigrid()
    //  
    //On Error GoTo handler
    //
    //  ApiGrid.AddColumn "§Technicien§", 1900
    //  ApiGrid.AddColumn "§Date P§", 900, "dd/mm/yy"
    //  ApiGrid.AddColumn "§Client§", 1800
    //  ApiGrid.AddColumn "§Site§", 1900
    //  ApiGrid.AddColumn "§CP§", 800
    //  ApiGrid.AddColumn "§Ville§", 1900
    //  ApiGrid.AddColumn "NumAct", 0
    //  ApiGrid.AddColumn "NumSite", 0
    //  ApiGrid.AddColumn "§diff§", 0
    //  ApiGrid.AddColumn "§Distance KM§", 1000
    //  
    //  ApiGrid.Init adoRS
    //  
    //Exit Sub
    //
    //handler:
    //  ShowError "InitApigrid dans " & Me.Name
    //End Sub
  }
}

