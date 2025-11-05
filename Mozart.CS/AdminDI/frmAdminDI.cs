using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmAdminDI : Form
  {
    public frmAdminDI()
    {
      InitializeComponent();
    }

    private void frmAdminDI_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void cmdArchive_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      frmGestionDIAbsence f = new frmGestionDIAbsence();
      f.ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void cmdDIFromweb_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmListeDIFromWeb().ShowDialog();
      Cursor.Current = Cursors.Default;
    }


    private void cmdDeci_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmListeDeciWebArch().ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void cmdDI_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmListeDIsansAction().ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void cmdDIweb_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmListeDIArchivWeb().ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void cmdDeblock_Click(object sender, EventArgs e)
    {
      string MyValue;

      try
      {
        // ne pouvoir débloquer que ces DI (sauf jean , cjp, celine, arnaud info)
        if (ModuleMain.RechercheDroitMenu(532))
        {
          MyValue = Interaction.InputBox(Resources.msg__EnterNumDIToUnlock, Resources.msg_Mozaris_pour + MozartParams.NomSociete);
          if (MyValue != "")
          {
            ModuleData.ExecuteNonQuery("update tact set nlocknum = 0 where ndinnum = " + Convert.ToInt32(MyValue));
          }
        }
        else
        {
          MyValue = Interaction.InputBox(Resources.msg__EnterNumDIToUnlock + "\r\n" + Resources.msg_MayUnlockOnlyDILocked,
            Resources.msg_Mozaris_pour + MozartParams.NomSociete);
          if (MyValue != "")
          {
            ModuleData.ExecuteNonQuery("update tact set nlocknum = 0 where ndinnum = " + Convert.ToInt32(MyValue) + " and nlocknum = " + MozartParams.UID);
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub cmdDeblock_Click()
    // 
    // Dim MyValue As String
    // 
    // On Error Resume Next
    // 
    // ' ne pouvoir débloquer que ces DI (sauf jean , cjp, celine, arnaud info)
    // If RechercheDroitMenu(gintUID, 532) Then
    //    MyValue = InputBox("§Saisissez le numéro de DI à débloquer§", "§Mozaris pour §" & gstrNomSociete)
    //    Select Case MyValue
    //       Case ""
    //         Exit Sub
    //       Case Else
    //         cnx.Execute "update tact set nlocknum = 0 where ndinnum = " & val(MyValue)
    //     End Select
    // Else
    //    MyValue = InputBox("§Saisissez le numéro de DI à débloquer.§" & vbCrLf & "§(Vous ne pouvez débloquer que les DI que vous bloquez)§", "§Mozaris pour §" & gstrNomSociete)
    //    Select Case MyValue
    //       Case ""
    //         Exit Sub
    //       Case Else
    //         cnx.Execute "update tact set nlocknum = 0 where ndinnum = " & val(MyValue) & " and nlocknum = " & gintUID
    //    End Select
    //End If
    //  
    //End Sub

    private void cmdSS_Click(object sender, EventArgs e)
    {
      try
      {
        string InputValue = Interaction.InputBox(Resources.msg_EnterNumSortieStockToUnlock, Resources.msg_Mozaris_pour + MozartParams.NomSociete);
        if (InputValue != "")
          ModuleData.ExecuteNonQuery("update tstockdde set nquibloque = NULL where nddenum = " + Convert.ToInt32(InputValue));
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
  }
}

