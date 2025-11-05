using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;
using MZCtrlResources = MozartControls.Properties.Resources;

namespace MozartCS
{
  public partial class frmGestMessageWebSTT : Form
  {
    public string sNumDI;
    public string sNumCS;
    public string sNomCLient;
    public string sNomSite;

    DataTable dt = new DataTable();


    public frmGestMessageWebSTT() { InitializeComponent(); }

    private void frmGestMessageWebSTT_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        txtFields0.Text = sNumDI;
        txtFields1.Text = sNumCS;
        txtFields2.Text = sNomSite;
        txtFields3.Text = sNomCLient;

        // liste des messages
        apiTGridMess.LoadData(dt, MozartDatabase.cnxMozart, $"exec api_sp_ListeMessFact {MozartParams.NumAction}");
        apiTGridMess.GridControl.DataSource = dt;

        InitApigrid();

        txtMessage.Text = "";
        if (dt.Rows.Count > 0)
        {
          apiTGridMess_SelectionChanged(null, null);
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    //Private Sub Form_Load()
    //
    //' UPGRADE_INFO (#0501): The 'otext' member isn't used anywhere in current application.
    // 'Dim otext As TextBox
    //
    //On Error GoTo Handler
    //
    //  InitBoutons Me, frmMenu
    //
    //  '***********************************************************************************
    //  txtFields(0).Text = sNumDI
    //  txtFields(1).Text = sNumCS
    //  txtFields(2).Text = sNomSite
    //  txtFields(3).Text = sNomCLient
    //
    //  '************************************************************************************
    //  ' liste des messages
    //  Set adoRS = New ADODB.Recordset
    //  adoRS.Open "exec api_sp_ListeMessFact " & glNumAction, cnx
    //  
    //  InitApigrid
    //    
    //  'txtFields(4).Text = ""
    //  txtMessage = ""
    //
    //    If adoRS.RecordCount > 0 Then
    //        'sélectionne le dernier message reçu
    //        adoRS.MoveFirst
    //        apiTGridMess_Click
    //    End If
    //  
    //  Screen.MousePointer = vbDefault
    //Exit Sub
    //Resume
    //Handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdEnvoyer_Click(object sender, EventArgs e)
    {
      try
      {
        // pour la création ou la modification, c'est la proc stock qui gère
        using (SqlCommand cmd = new SqlCommand("api_sp_CreationMessFact", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

          //  liste des paramètres
          cmd.Parameters["@npernum"].Value = MozartParams.UID;
          cmd.Parameters["@nsttnum"].Value = 0; //Pas nsttnum quand c'est un message provenant d'emalec
          cmd.Parameters["@nactnum"].Value = MozartParams.NumAction;
          cmd.Parameters["@vmessage"].Value = txtMessage.Text;
          cmd.Parameters["@cstatut"].Value = "E";
          cmd.Parameters["@ctype"].Value = "E";

          cmd.ExecuteNonQuery();
        }

        // recharge le recordset
        apiTGridMess.Requery(dt, MozartDatabase.cnxMozart);
        txtMessage.Text = "";
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    //Private Sub cmdEnvoyer_Click()
    //
    //On Error GoTo Handler
    // 
    //Dim cmd As New ADODB.Command
    //' UPGRADE_INFO (#0501): The 'ado_rs' member isn't used anywhere in current application.
    //' Dim ado_rs As New ADODB.Recordset
    //
    //On Error GoTo Handler
    //
    //' pour la création ou la modification, c'est la proc stock qui gère
    //        
    //  ' création d'une commande
    //  Set cmd.ActiveConnection = cnx
    //  
    //  ' passage du nom de la procédure stockée
    //  cmd.CommandText = "api_sp_CreationMessFact"
    //  cmd.CommandType = adCmdStoredProc
    //  
    //   ' liste des paramètres
    //    cmd.Parameters("@npernum").value = gintUID
    //    cmd.Parameters("@nsttnum").value = 0      'Pas nsttnum quand c'est un message provenant d'emalec
    //    cmd.Parameters("@nactnum").value = glNumAction
    //    cmd.Parameters("@vmessage").value = txtMessage.Text
    //    cmd.Parameters("@cstatut").value = "E"
    //    cmd.Parameters("@ctype").value = "E"
    //    
    //  ' exécuter la commande.
    //  cmd.Execute
    //    
    //  ' libération de la commande
    //  Set cmd = Nothing
    //  
    //  'recharge le recordset
    //  adoRS.Requery
    //  txtMessage.Text = ""
    //  
    //Exit Sub
    //Resume
    //Handler:
    //  ShowError "cmdEnvoyer_Click dans " & Me.Name
    //
    //End Sub
    //

    /* OK  --------------------------------------------------------------------------------------- */
    private void cmdClore_Click(object sender, EventArgs e)
    {

      try
      {
        Cursor.Current = Cursors.Default;

        DataRow currentRow = apiTGridMess.GetFocusedDataRow();
        if (currentRow == null) return;

        if (currentRow["CSTATUT"].ToString() == "C")
        {
          MessageBox.Show(Resources.msg_commCloture, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        if (MessageBox.Show(Resources.msg_cloreDiscussion, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
          MessageBoxDefaultButton.Button2) == DialogResult.Yes)
        {
          ModuleData.CnxExecute($"UPDATE TW2MESSFACT SET CSTATUT = 'C' WHERE NACTNUM = {currentRow["NACTNUM"]}");
          apiTGridMess.Requery(dt, MozartDatabase.cnxMozart);
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    //Private Sub cmdClore_Click()
    //     
    //On Error GoTo Handler
    // 
    //  Screen.MousePointer = vbDefault
    //  
    //  If adoRS.state = adStateOpen Then
    //    If adoRS.EOF = True Then Exit Sub
    //  End If
    //  
    //    If adoRS("CSTATUT") = "C" Then
    //        MsgBox "§La communication a été cloturée!!§"
    //        Exit Sub
    //    End If
    //  
    //  If MsgBox("§Clore la discussion?§", vbYesNoCancel, "§Clore la discussion§") = vbYes Then
    //  
    //    cnx.Execute "UPDATE TW2MESSFACT SET CSTATUT = 'C' WHERE NACTNUM = " & adoRS("NACTNUM")
    //    
    //    adoRS.Requery
    //    apiTGridMess.MajLabel
    //       
    //  End If
    //  Exit Sub
    //  Resume
    //Handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "cmdClore_Click dans " & Me.Name
    //End Sub
    //

    /* OK  --------------------------------------------------------------------------------------- */
    private void apiTGridMess_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
    {
      DataRow currentRow = apiTGridMess.GetFocusedDataRow();
      if (currentRow == null) return;

      txtFields4.Text = Utils.BlankIfNull(currentRow["VMESSAGE"]);
    }

    //Private Sub apiTGridMess_Click()
    //    
    //    If adoRS.state = adStateOpen Then
    //        If adoRS.RecordCount > 0 Then
    //            txtFields(4).Text = BlankIfNull(adoRS("VMESSAGE"))
    //        End If
    //    End If
    //
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdSupp_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apiTGridMess.GetFocusedDataRow();
      if (currentRow == null) return;

      if (currentRow["CSTATUT"].ToString() == "C") MessageBox.Show(Resources.msg_comClotureeSuppImpossible, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      else
        if (MessageBox.Show(Resources.msg_suppMessage, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
             MessageBoxDefaultButton.Button2) == DialogResult.Yes)
      {
        ModuleData.CnxExecute($"UPDATE TW2MESSFACT SET CSTATUT = 'S' WHERE ID = {Utils.ZeroIfNull(currentRow["ID"])}");
        apiTGridMess.Requery(dt, MozartDatabase.cnxMozart);
        txtFields4.Text = "";
      }
    }

    //Private Sub cmdSupp_Click()
    //    If adoRS.state = adStateOpen Then
    //        If adoRS.RecordCount > 0 Then
    //            If adoRS("CSTATUT") = "C" Then
    //                MsgBox "§La communication a été cloturée. Suppression impossible!!§"
    //            Else
    //                If MsgBox("§Supprimer ce message ?§", vbYesNo) = vbYes Then
    //                    cnx.Execute "UPDATE TW2MESSFACT SET CSTATUT = 'S' WHERE ID = " & ZeroIfNull(adoRS("ID"))
    //                    adoRS.Requery
    //                    apiTGridMess.MajLabel
    //                End If
    //            End If
    //        End If
    //    End If
    //End Sub
    //
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void InitApigrid()
    {

      try
      {
        apiTGridMess.AddColumn("ID", "ID", 0);
        apiTGridMess.AddColumn(MZCtrlResources.date_creation, "DDATECRE", 2500);
        apiTGridMess.AddColumn(Resources.col_Auteur, "NOMAUT", 2000);
        apiTGridMess.AddColumn(Resources.col_SousTraitant, "NOMSTF", 0);
        apiTGridMess.AddColumn(Resources.col_Message, "VMESSAGE", 4000, "", 0, true);
        apiTGridMess.AddColumn(MZCtrlResources.col_Etat, "CSTATUT", 1200);
        apiTGridMess.AddColumn(MZCtrlResources.col_Type, "CTYPE", 0);

        apiTGridMess.FilterBar = false;
        apiTGridMess.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    //Private Sub InitApigrid()
    // 
    //On Error GoTo Handler
    //  
    //  apiTGridMess.AddColumn "ID", "ID", 0
    //  apiTGridMess.AddColumn "§Date création§", "DDATECRE", 2500
    //  apiTGridMess.AddColumn "§Auteur§", "NOMAUT", 2000
    //  'apiTGridMess.AddColumn "§Sous traitant§", "NOMSTF", 2500
    //  apiTGridMess.AddColumn "§Message§", "VMESSAGE", 4000
    //  apiTGridMess.AddColumn "§Etat§", "CSTATUT", 1200
    //  apiTGridMess.AddColumn "§Type§", "CTYPE", 0
    //     
    //  ' Tooltip sur des cellules
    //  apiTGridMess.AddCellTip "VMESSAGE", &HFDF0DA            ' Tip = contenu de la cellule entière   ' Vert pale
    //  
    //  apiTGridMess.FilterBar = False
    //  
    //  apiTGridMess.Init adoRS
    //  
    //Exit Sub
    //Handler:
    //  ShowError "InitApigrid dans " & Me.Name
    //End Sub
    //

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    //Private Sub cmdFermer_Click()
    //  Unload Me
    //End Sub
    //

    /* inutile --------------------------------------------------------------------------------------- */
    //Private Sub Form_Unload(Cancel As Integer)
    //
    //    If adoRS.state = adStateOpen Then
    //        adoRS.Close
    //    End If
    //    Set adoRS = Nothing
    //
    //End Sub
    //

  }
}

