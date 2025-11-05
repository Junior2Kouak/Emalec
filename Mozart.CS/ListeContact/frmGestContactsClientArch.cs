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
  public partial class frmGestContactsClientArch : Form
  {
    DataTable dt = new DataTable();
    public long miNumClient;
    public string mstrClient;
    //Dim rsPri As Recordset
    //
    //Public miNumClient As Long
    //Public mstrClient As String
    public frmGestContactsClientArch()
    {
      InitializeComponent();
    }

    private void frmGestContactsClientArch_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);
        Label1.Text = mstrClient;

        apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, $"select * from TCCL where CCCLACTIF = 'N' AND NCLINUM = {miNumClient} Order by VCCLNOM");
        apiTGrid1.GridControl.DataSource = dt;
        InitApigrid();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub Form_Load()
    //  
    //  InitBoutons Me, frmMenu
    //  
    //  Label1.Caption = mstrClient
    //  
    //  Set rsPri = New Recordset
    //  rsPri.Open "select * from TCCL where CCCLACTIF = 'N' AND NCLINUM = " & miNumClient & " Order by VCCLNOM", cnx, adOpenStatic, adLockOptimistic
    //  
    //  InitApigrid
    //  
    //End Sub

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdFermer_Click()
    //  Unload Me
    //End Sub

    private void cmdSupprimer_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow row = apiTGrid1.GetFocusedDataRow();
        if (null == row) return;

        if (MessageBox.Show(Resources.msg_Confirm_restaurer_contact, Program.AppTitle, MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
        {
          ModuleData.ExecuteNonQuery($"update TCCL set CCCLACTIF = 'O' where NCCLNUM = {row["NCCLNUM"]}");
        }
        else
          return;

        //rafraichissement du recordset
        apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub cmdSupprimer_Click()
    //On Error GoTo handler
    //
    //  If rsPri.EOF Then Exit Sub
    //  
    //  Select Case MsgBox("§Voulez-vous vraiment restaurer ce contact ?§", vbYesNo + vbQuestion + vbDefaultButton2)
    //    Case vbYes
    //      cnx.Execute "update TCCL set CCCLACTIF = 'O' where NCCLNUM = " & rsPri("NCCLNUM").value
    //    Case vbNo
    //      Exit Sub
    //  End Select
    //    
    //  ' rafraichissement du recordset
    //  rsPri.Requery
    //
    //Exit Sub
    //handler:
    //  ShowError "cmdSupprimer_click dans " & Me.Name
    //End Sub


    private void InitApigrid()
    {
      apiTGrid1.AddColumn(Resources.col_Nom, "VCCLNOM", 1300, "", 0, true);
      apiTGrid1.AddColumn(Resources.col_Prenom, "VCCLPRE", 1000);
      apiTGrid1.AddColumn(Resources.col_Civ, "CCCLCIV", 600);
      apiTGrid1.AddColumn(Resources.col_Fonction, "VCCLFONC", 1500, "", 0, true);
      apiTGrid1.AddColumn(Resources.col_Adresse1, "VCCLAD1", 1200, "", 0, true);
      apiTGrid1.AddColumn(Resources.col_Ad2, "VCCLAD2", 500, "", 0, true);
      apiTGrid1.AddColumn(Resources.col_CP, "VCCLCP", 600);
      apiTGrid1.AddColumn(Resources.col_Ville, "VCCLVIL", 1400, "", 0, true);
      apiTGrid1.AddColumn(Resources.col_Tel, "VCCLTEL", 1200);
      apiTGrid1.AddColumn(Resources.col_Fax, "VCCLFAX", 1200);
      apiTGrid1.AddColumn(Resources.col_GSM, "VINTPOR", 1200);
      apiTGrid1.AddColumn(Resources.col_Email, "VCCLMAIL", 800, "", 0, true);
      apiTGrid1.AddColumn(Resources.col_D_Devis, "VCCLDEVIS", 800);
      apiTGrid1.AddColumn(Resources.col_D_Attest, "VCCLATT", 800);
      apiTGrid1.AddColumn(Resources.col_D_Stat, "VCCLSTAT", 800);
      apiTGrid1.AddColumn(Resources.col_NumContact, "NCCLNUM", 0);
      apiTGrid1.AddColumn(Resources.col_NumClient, "NCLINUM", 0);

      apiTGrid1.InitColumnList();
    }
    //Sub InitApigrid()
    //  
    //  apiTGrid1.AddColumn "§Nom§", "VCCLNOM", 1300
    //  apiTGrid1.AddColumn "§Prénom§", "VCCLPRE", 1000
    //  apiTGrid1.AddColumn "§Civ§", "CCCLCIV", 600
    //  apiTGrid1.AddColumn "§Fonction§", "VCCLFONC", 1500
    //  apiTGrid1.AddColumn "§Adresse1§", "VCCLAD1", 1200
    //  apiTGrid1.AddColumn "§Ad2§", "VCCLAD2", 500
    //  apiTGrid1.AddColumn "§CP§", "VCCLCP", 600
    //  apiTGrid1.AddColumn "§Ville§", "VCCLVIL", 1400
    //  apiTGrid1.AddColumn "§Tél§", "VCCLTEL", 1200
    //  apiTGrid1.AddColumn "§Fax§", "VCCLFAX", 1200
    //  apiTGrid1.AddColumn "§GSM§", "VINTPOR", 1200
    //  apiTGrid1.AddColumn "§E-Mail§", "VCCLMAIL", 800
    //  apiTGrid1.AddColumn "§D Devis§", "VCCLDEVIS", 800
    //  apiTGrid1.AddColumn "§D Attest§", "VCCLATT", 800
    //  apiTGrid1.AddColumn "§D Stat§", "VCCLSTAT", 800
    //  apiTGrid1.AddColumn "NumContact", "NCCLNUM", 0
    //  apiTGrid1.AddColumn "§NumClient§", "NCLINUM", 0
    //  
    //  apiTGrid1.AddCellTip "VCCLFONC", &HFDF0DA
    //  apiTGrid1.AddCellTip "VCCLAD1", &HFDF0DA
    //  apiTGrid1.AddCellTip "VCCLMAIL", &HFDF0DA
    //  apiTGrid1.AddCellTip "VCCLAD2", &HFDF0DA
    //  apiTGrid1.AddCellTip "VCCLVIL", &HFDF0DA
    //  apiTGrid1.AddCellTip "VCCLNOM", &HFDF0DA
    //
    //  apiTGrid1.Init rsPri
    //      
    //End Sub
    //
    //
    //
    private void frmGestContactsClientArch_FormClosed(object sender, FormClosedEventArgs e)
    {
      Cursor.Current = Cursors.Default;
    }
    //Private Sub Form_Unload(Cancel As Integer)
    //  Screen.MousePointer = vbDefault
    //End Sub
    //


  }
}

