using MZCtrlResources = MozartControls.Properties.Resources;
using Microsoft.VisualBasic;
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
  public partial class frmListeOutilsAcmd : Form
  {

    DataTable dt = new DataTable();
    //Dim adoRS As ADODB.Recordset

    public frmListeOutilsAcmd() { InitializeComponent(); }

    private void frmListeOutilsAcmd_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        //ouverture du recordset
        apigrid.LoadData(dt, MozartDatabase.cnxMozart, $"exec api_sp_listeOutilAcmd");
        apigrid.GridControl.DataSource = dt;

        InitApigrid();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }
    /* --------------------------------------------------------------------------------------- */
    //Private Sub Form_Load()
    //    
    //On Error GoTo handler:
    //
    //  InitBoutons Me, frmMenu
    //  
    //  ' ouverture du recordset
    //  Set adoRS = New ADODB.Recordset
    //  adoRS.Open "exec api_sp_listeOutilAcmd", cnx
    //
    //  InitApigrid
    //    
    //  Screen.MousePointer = vbDefault
    //  Exit Sub
    //  
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "Form_Load de " & Me.Name
    //    
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void InitApigrid()
    {
      apigrid.AddColumn(Resources.col_DI, "NDINNUM", 690);
      apigrid.AddColumn(Resources.col_date_c, "DDINDAT", 730, "dd/MM/yy");
      apigrid.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 970);
      apigrid.AddColumn(Resources.col_Site, "VSITNOM", 1100);
      apigrid.AddColumn(Resources.col_Num, "NSITNUE", 0);
      apigrid.AddColumn(Resources.col_Action, "VACTDES", 3500);
      apigrid.AddColumn(Resources.col_Date, "DACTDATE", 770, "dd/MM/yy");
      apigrid.AddColumn(Resources.col_Technicien, "VACTINT", 0);
      apigrid.AddColumn(Resources.col_etat, "CETACOD", 150);
      apigrid.AddColumn(Resources.col_Chaff, "VPERNOM", 1000);
      apigrid.AddColumn(Resources.col_fournitures, "VACTFOU", 3700);
      apigrid.AddColumn(Resources.col_type_intervenant, "CACTTYT", 0);

      apigrid.InitColumnList();
    }

    /* --------------------------------------------------------------------------------------- */
    private void cmdModifier_Click(object sender, EventArgs e)
    {
      DataRow row = apigrid.GetFocusedDataRow();
      if (row == null) return;

      //écran de modification de la demande
      MozartParams.NumDi = Convert.ToInt32(Strings.Mid(Utils.BlankIfNull(row["NDINNUM"]), 3));
      MozartParams.NumAction = Convert.ToInt32(Utils.ZeroIfNull(row["NACTNUM"]));

      try
      {
        new frmDetailstravaux { mstrStatutAction = "M" }.ShowDialog();
      }
      catch
      {
        MessageBox.Show(Resources.msg_affich_impossible_ecran_charge, Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }

      //On revient donc on réinitialise les variables globales
      MozartParams.NumDi = 0;
      MozartParams.NumAction = 0;

      //rafraichissement du recordset
      apigrid.Requery(dt, MozartDatabase.cnxMozart);

      Cursor.Current = Cursors.Default;
    }
    //Private Sub cmdModifier_Click()
    //    
    //  If adoRS.EOF Then Exit Sub
    //  
    // ' Screen.MousePointer = vbHourglass
    //
    //  ' écran de modification de la demande
    //    ' écran de modification de la demande
    //  frmDetailsTravaux.mstrStatutAction = "M"
    //  giNumDi = Mid(adoRS("NDINNUM").Value, 3)
    //  glNumAction = adoRS("NACTNUM").Value
    //    
    //  On Error Resume Next
    //  
    //  frmDetailsTravaux.Show vbModal
    //      
    //  If Err Then MsgBox "§Impossible d'afficher l'écran de détail de l'action car cet écran et déjà chargé en arrière plan§"
    //  
    //  Screen.MousePointer = vbHourglass
    //    
    //  ' on revient donc on réinitialise les variables globales
    //  giNumDi = 0
    //  glNumAction = 0
    //  
    //  ' rafraichissement du recordset
    //  adoRS.Requery
    //  InitApigrid
    //  Screen.MousePointer = vbDefault
    //
    //End Sub
    //

    /* --------------------------------------------------------------------------------------- */
    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      //fermeture de la fenetre
      Dispose();
    }

    /* --------------------------------------------------------------------------------------- */
    private void apigrid_DoubleClickE(object sender, EventArgs e)
    {
      cmdModifier_Click(null, null);
    }

  }
}

