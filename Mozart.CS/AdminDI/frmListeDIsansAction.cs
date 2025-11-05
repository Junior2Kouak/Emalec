using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MZCtrlResources = MozartControls.Properties.Resources;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmListeDIsansAction : Form
  {
    DataTable dt = new DataTable();


    public frmListeDIsansAction()
    {
      InitializeComponent();
    }

    private void frmListeDIsansAction_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);
        apigrid.LoadData(dt, MozartDatabase.cnxMozart, "exec api_sp_listedi_sans_action");
        apigrid.GridControl.DataSource = dt;
        InitApigrid();
        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        Cursor.Current = Cursors.Default;
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdModifier_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow currentRow = apigrid.GetFocusedDataRow();

        if (currentRow == null) return;

        //écran de modification de la demande
        MozartParams.NumDi = Convert.ToInt32(currentRow["NDINNUM"]);
        new frmAddAction { mstrStatutDI = "M" }.ShowDialog();

        // on revient donc on réinitialise les variables globales
        MozartParams.NumDi = 0;
        MozartParams.NumAction = 0;

        // rafraichissement du recordset
        apigrid.Requery(dt, MozartDatabase.cnxMozart);
      }
      catch (Exception ex)
      {
        MozartParams.NumDi = 0;
        MozartParams.NumAction = 0;
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }


    /* OK --------------------------------------------------------------------------*/
    private void cmdSupprimer_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow currentRow = apigrid.GetFocusedDataRow();

        if (currentRow == null) return;
        //suppression de l' action selectionnée
        if (MessageBox.Show(Resources.msg_confirm_sup_DI, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
        {
          ModuleData.SupprimerEnreg(Convert.ToInt32(currentRow["NDINNUM"]), "api_sp_SupprimerDI", "@iNumDI");
        }
        else
          return;

        // rafraichissement du recordset
        apigrid.Requery(dt, MozartDatabase.cnxMozart);

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub cmdSupprimer_Click()
    //    
    //On Error GoTo handler:
    //
    //  'suppression de l' action selectionnée
    //  If adoRS.EOF Then Exit Sub
    //  
    //  
    //  Select Case MsgBox("§Voulez-vous vraiment supprimer cette DI ?§", vbYesNo + vbQuestion + vbDefaultButton2)
    //    Case vbYes
    //      SupprimerEnreg Val(adoRS("NDINNUM").Value), "api_sp_SupprimerDI", "@iNumDI"
    //    Case vbNo
    //      Exit Sub
    //  End Select
    //  
    //  ' rafraichissement du recordset
    //  adoRS.Requery
    //
    //  apigrid.MajLabel
    //
    //  ' mise en page du tableau
    //  'InitApigrid
    //
    //Exit Sub
    //handler:
    //  ShowError "cmdSupprimer_Click de " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private void InitApigrid()
    {
      try
      {
        apigrid.AddColumn(Resources.col_DI, "NDINNUM", 650);
        apigrid.AddColumn(Resources.col_date_c, "DDINDAT", 1000, "dd/mm/yyyy");
        apigrid.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1700);
        apigrid.AddColumn(Resources.col_Site, "VSITNOM", 1800);
        apigrid.AddColumn(Resources.col_Num_site, "NSITNUE", 900);
        apigrid.AddColumn(Resources.col_Demandeur, "VDINNOM", 1800);
        apigrid.AddColumn(Resources.col_Ref_client, "VDINREFCLI", 1800);
        apigrid.AddColumn(Resources.col_Compte, "NDINCTE", 900);

        apigrid.InitColumnList();
        apigrid.GridControl.BackColor = ColorTranslator.FromHtml("&HFFC0C0");

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }


    private void apigrid_DoubleClickE(object sender, EventArgs e)
    {
      cmdModifier_Click(null, null);
    }

    private void frmListeDIsansAction_FormClosed(object sender, FormClosedEventArgs e)
    {
      Cursor.Current = Cursors.Default;
    }

    /* OK --------------------------------------------------------------------------*/
    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }


  }
}