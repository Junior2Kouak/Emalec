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
  public partial class frmChoixCadre : Form
  {
    public frmChoixCadre()
    {
      InitializeComponent();
    }

    //Private Sub Form_Load()
    //Dim adoRS As ADODB.Recordset
    //  On Error GoTo handler
    //  InitBoutons Me, frmMenu
    //  cboChaff.SizeCombo 600  
    //  cboChaff.Clear
    //  RemplirCombo cboChaff, "select NPERNUM, VPERNOM + ' ' + VPERPRE from TPER where CPERACTIF = 'O' AND CPERTYP='CA' AND VSOCIETE = '" & gstrNomSociete & "' ORDER BY  VPERNOM, VPERPRE", False
    //  ' ouverture du recordset
    //  Set adoRS = New ADODB.Recordset
    //  '
    //  adoRS.Open "select npernum from tper where npertapi=1", cnx, adOpenStatic, adLockOptimistic
    //  If Not adoRS.EOF Then
    //    SelectLB cboChaff, adoRS!npernum
    //    adoRS.Close
    //  End If
    //  Set adoRS = Nothing
    //Exit Sub
    //Resume
    //handler:
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub

    private void frmChoixCadre_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);

        apicboChaff.Refresh();

        string sSQL = $"select 0 as NPERNUM, '' as VPERNOM union select NPERNUM, VPERNOM + ' ' + VPERPRE [VPERNOM] from TPER where CPERACTIF = 'O' AND CPERTYP='CA' " +
                      $"AND VSOCIETE = '{MozartParams.NomSociete}' ORDER BY VPERNOM";

        apicboChaff.Init(MozartDatabase.cnxMozart, sSQL, "NPERNUM", "VPERNOM", new List<string>() { Resources.col_Num, "" }, 400, 300);

        apicboChaff.SetItemData(Convert.ToInt32(Utils.ZeroIfBlank(ModuleData.ExecuteScalarString("select npernum from tper where npertapi=1"))));

        DevExpress.XtraEditors.LookUpEdit lookup1 = apicboChaff.Controls["lookup1"] as DevExpress.XtraEditors.LookUpEdit;
        int nb = (lookup1.Properties.DataSource as DataTable).Rows.Count;
        lookup1.Properties.DropDownRows = Math.Min(30, nb);
      }
      catch (System.Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    //Private Sub cmdValider_Click()
    //  On Error GoTo handler
    //  ' affichage curseur
    //  Me.MousePointer = vbHourglass
    //  cnx.Execute "update tper set npertapi=0 where npertapi=1"
    //  cnx.Execute "update tper set npertapi=1 where npernum=" & cboChaff.ItemData(cboChaff.ListIndex)
    //  ' affichage curseur
    //  Me.MousePointer = vbDefault
    //Exit Sub
    //handler:
    //  Me.MousePointer = vbDefault
    //  ShowError "cmdValider_Click dans " & Me.Name
    //End Sub
    private void cmdValider_Click(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleData.ExecuteNonQuery("UPDATE TPER SET NPERTAPI = 0 WHERE NPERTAPI = 1");
        ModuleData.ExecuteNonQuery($"UPDATE TPER SET NPERTAPI = 1 WHERE NPERNUM = {apicboChaff.GetItemData()}");
        Cursor.Current = Cursors.Default;
      }
      catch (System.Exception ex)
      {
        Cursor.Current = Cursors.Default;
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    //Private Sub cmdFermer_Click()
    //  Unload Me
    //End Sub

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
  }
}

