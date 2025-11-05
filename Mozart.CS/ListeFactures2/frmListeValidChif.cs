using MZCtrlResources = MozartControls.Properties.Resources;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;


namespace MozartCS
{
  public partial class frmListeValidChif : Form
  {
    DataTable dt;
    public frmListeValidChif() { InitializeComponent(); }

    private void frmListeValidChif_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        dt = new DataTable();
        apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, "select * from api_v_listeValidChif where isnull(velfmessweb,'') <> ''");
        apiTGrid1.GridControl.DataSource = dt;
        InitApiTgrid();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        //  Validation du non retour chiffrage
        //  sauvegarde du message dans vactdes
        //  upate par null sur delfdvalid et sur velfmessweb = null
        DataRow row = apiTGrid1.GetFocusedDataRow();
        if (null == row) return;

        // update de vactdes
        ModuleData.ExecuteNonQuery($"UPDATE TACT SET VACTDES=VACTDES + char(13) + char(10) + char(13) + char(10) + " +
                                  $"' Message de {row["VELFQUIVALID"]} le {row["DELFDVALID"]} : ' + char(13) + char(10) + '{row["VELFMESSWEB"].ToString().Replace("'", "''")}'" +
                                  $" WHERE NACTNUM={row["NACTNUM"]}");

        // écran de modification de l' action
        MozartParams.NumAction = (int)row["NACTNUM"];
        MozartParams.NumDi = (int)row["NDINNUM"];

        Cursor.Current = Cursors.WaitCursor;
        new frmAddAction().ShowDialog();

        // update des champs de validation chiffrage
        ModuleData.ExecuteNonQuery($"UPDATE TELF SET DELFDVALID = NULL,VELFQUIVALID = NULL, VELFMESSWEB = NULL WHERE NELFNUM = {row["NELFNUM"]}");

        MozartParams.NumAction = 0;
        MozartParams.NumDi = 0;

        // rafraichissement
        Cursor.Current = Cursors.WaitCursor;
        apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);

        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }
    //Private Sub cmdValider_Click()
    //
    //  Dim sSQL As String
    //
    //  'Validation du non retour chiffrage
    //  'sauvegarde du message dans vactdes
    //  'upate par null sur delfdvalid et sur velfmessweb = null
    //  '
    //  If adoRS.EOF Then Exit Sub
    //  
    //  'update de vactdes
    //  sSQL = "UPDATE TACT SET VACTDES=VACTDES + char(13) + char(10) + char(13) + char(10) + '" & _
    //  " Message de " & adoRS("VELFQUIVALID") & " le " & adoRS("DELFDVALID") & " : ' + char(13) + char(10) + '" & Replace(adoRS("VELFMESSWEB"), "'", "''") & _
    //  "'  WHERE NACTNUM=" & adoRS("NACTNUM").Value
    //  cnx.Execute (sSQL)
    //  
    //  ' écran de modification de l' action
    //  frmAddAction.mstrStatutDI = ""
    //  glNumAction = adoRS("NACTNUM").Value
    //  giNumDi = adoRS("NDINNUM")
    //  frmAddAction.Show vbModal
    //  
    //  'update des champs de validation chiffrage
    //  sSQL = "UPDATE TELF SET DELFDVALID = NULL,VELFQUIVALID = NULL, VELFMESSWEB = NULL WHERE NELFNUM = " & adoRS("NELFNUM").Value
    //  cnx.Execute (sSQL)
    //  
    //  glNumAction = 0
    //  giNumDi = 0
    //
    //  ' rafraichissement
    //  adoRS.Requery
    //  apiTGrid1.MajLabel
    //  
    //End Sub
    //

    /* --------------------------------------------------------------------------------------- */
    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    void InitApiTgrid()
    {
      apiTGrid1.AddColumn(Resources.col_DI, "NDINNUM", 700);
      apiTGrid1.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1300);
      apiTGrid1.AddColumn(Resources.col_Decideur, "VELFQUIVALID", 1300);
      apiTGrid1.AddColumn(Resources.col_Validation, "DELFDVALID", 1100, "dd/MM/yy");
      apiTGrid1.AddColumn(Resources.col_Site, "VSITNOM", 1500);
      apiTGrid1.AddColumn("N°", "NSITNUE", 500);
      apiTGrid1.AddColumn(Resources.col_Action, "VACTDES", 3000);
      apiTGrid1.AddColumn(Resources.col_Message, "VELFMESSWEB", 3000);

      apiTGrid1.InitColumnList();
    }

  }
}

