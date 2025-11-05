using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmListeFicheTechArch : Form
  {
    public string mstrTypeFiche;

    DataTable dtFicheTech = new DataTable();

    //Public mstrTypeFiche As String
    //Dim rsFicheTech As ADODB.Recordset

    public frmListeFicheTechArch()
    {
      InitializeComponent();
    }

    private void frmListeFicheTechArch_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);

        LoadGrid();
        InitGrid();
        Label1.Text = this.Text;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub Form_Load()
    //Dim sSql As String
    //
    //  InitBoutons Me, frmMenu
    //  
    //  Set rsFicheTech = New ADODB.Recordset
    //  
    //  Select Case mstrTypeFiche
    //    Case "N"
    //      Me.Caption = "Fiches Normes archivées"
    //      sSql = "select NID, VLIBNORME, VTITRENORME, DDATENORME, VFICNORME AS VFIC, VTECHNORME, CACTIF From TFICHENORME where CACTIF <> 'O' AND VSOCIETE = '" & gstrNomSociete & "'  order by VLIBNORME"
    //      rsFicheTech.Open sSql, cnx, adOpenStatic, adLockOptimistic
    //    Case "FQ"
    //      Me.Caption = "Fiches sécurité archivées"
    //      sSql = "select ID, TITRE, VFICTECH AS VFIC, DDATEPUB, CACTIF From TFICHETECH where type = 'FP' and CACTIF <> 'O' AND VSOCIETE = '" & gstrNomSociete & "' and ID not in (59,60) ORDER BY TITRE"
    //      rsFicheTech.Open sSql, cnx, adOpenStatic, adLockOptimistic
    //    Case "PR"
    //      Me.Caption = "Fiches procédures et réglements archivées"
    //      sSql = "select ID, TITRE, VFICTECH AS VFIC, DDATEPUB, CACTIF From TFICHETECH where type = 'AD' and CACTIF <> 'O' AND VSOCIETE = '" & gstrNomSociete & "' ORDER BY TITRE"
    //      rsFicheTech.Open sSql, cnx, adOpenStatic, adLockOptimistic
    //    Case "FT"
    //      Me.Caption = "Fiches techniques archivées"
    //      sSql = "select ID, TITRE, VFICTECH AS VFIC, DDATEPUB, VCLASSEMENT, CACTIF From TFICHETECH where type = 'FT' and CACTIF <> 'O' AND VSOCIETE = '" & gstrNomSociete & "' ORDER BY VCLASSEMENT, TITRE"
    //      rsFicheTech.Open sSql, cnx, adOpenStatic, adLockOptimistic
    //  End Select
    //  InitGrid
    //  Label1.Caption = Me.Caption
    //
    //End Sub
    //

    /* OK ---------------------------------------------------------------------*/
    private void LoadGrid()
    {
      string sSQL = "";

      switch (mstrTypeFiche)
      {
        case "N":
          this.Text = Resources.txt_FichesNormesArch;
          sSQL = "select NID, VLIBNORME, VTITRENORME, DDATENORME, VFICNORME AS VFIC, VTECHNORME, CACTIF From TFICHENORME " +
                 "where CACTIF <> 'O' AND VSOCIETE = '" + MozartParams.NomSociete + "'  order by VLIBNORME";
          break;

        case "FQ":
          this.Text = Resources.txt_FichesSecuArch;
          sSQL = "select ID, TITRE, VFICTECH AS VFIC, DDATEPUB, CACTIF From TFICHETECH where type = 'FP' and CACTIF <> 'O' " +
                 "AND VSOCIETE = '" + MozartParams.NomSociete + "' ORDER BY TITRE";
          break;

        case "PR":
          this.Text = Resources.txt_FichesProcEtReglArch;
          sSQL = "select ID, TITRE, VFICTECH AS VFIC, DDATEPUB, CACTIF From TFICHETECH where type = 'AD' and CACTIF<> 'O' " +
                 "AND VSOCIETE = '" + MozartParams.NomSociete + "' and ID not in (59, 60) ORDER BY TITRE";
          break;

        case "FT":
          this.Text = Resources.txt_FichesTecArch;
          sSQL = "select ID, TITRE, VFICTECH AS VFIC, DDATEPUB, VCLASSEMENT, CACTIF From TFICHETECH where type = 'FT' and CACTIF <> 'O' " +
               "AND VSOCIETE = '" + MozartParams.NomSociete + "' ORDER BY VCLASSEMENT, TITRE";
          break;
      }

      if (sSQL != "")
      {
        apiTGrid_FicheTech.LoadData(dtFicheTech, MozartDatabase.cnxMozart, sSQL);
        apiTGrid_FicheTech.GridControl.DataSource = dtFicheTech;
      }

    }

    /* OK ---------------------------------------------------------------------*/
    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdQuitter_Click()
    //  Unload Me
    //End Sub
    //

    /* OK ---------------------------------------------------------------------*/
    private void cmdSupp_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid_FicheTech.GetFocusedDataRow();
      if (row == null) return;

      switch (mstrTypeFiche)
      {
        case "N":
          if (MessageBox.Show(Resources.msg_Confirm_sup_fiche_norme, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                              MessageBoxDefaultButton.Button2) == DialogResult.Yes)
          {
            if ((File.Exists(ModuleData.RechercheParam("REP_FICHE_NORME", MozartParams.NomSociete) + row["VFIC"]) == true))
              File.Delete(ModuleData.RechercheParam("REP_FICHE_NORME", MozartParams.NomSociete) + row["VFIC"]);

            ModuleData.ExecuteNonQuery("DELETE TFICHENORME WHERE NID = " + row["NID"]);
          }
          break;
        case "FQ":
        case "PR":
        case "FT":
          if (MessageBox.Show(Resources.msg_Confirm_sup_fiche, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                              MessageBoxDefaultButton.Button2) == DialogResult.Yes)
          {
            if ((File.Exists(MozartParams.CheminFicheTech + row["VFIC"].ToString()) == true))
              File.Delete(MozartParams.CheminFicheTech + row["VFIC"].ToString());

            ModuleData.ExecuteNonQuery("DELETE TFICHETECH WHERE ID = " + row["ID"].ToString());
          }
          break;
      }
      apiTGrid_FicheTech.Requery(dtFicheTech, MozartDatabase.cnxMozart);
    }
    //Private Sub cmdSupp_Click()
    //    If rsFicheTech.EOF Then Exit Sub
    //    
    //Dim fs As New FileSystemObject
    //    
    //    Select Case mstrTypeFiche
    //        Case "N"
    //            If MsgBox("§Etes-vous sûre de vouloir supprimer cette fiche norme?§", vbYesNo) = vbYes Then
    //                If fs.FileExists(RechercheParam("REP_FICHE_NORME") & rsFicheTech("VFIC")) = True Then fs.DeleteFile RechercheParam("REP_FICHE_NORME") & rsFicheTech("VFIC")
    //                cnx.Execute "DELETE TFICHENORME WHERE NID = " & rsFicheTech("NID")
    //                rsFicheTech.Requery
    //            End If
    //        Case "FQ", "PR", "FT"
    //            If MsgBox("Etes-vous sûre de vouloir supprimer cette fiche ?", vbYesNo) = vbYes Then
    //                If fs.FileExists(gstrCheminFicheTech & rsFicheTech("VFIC")) = True Then fs.DeleteFile gstrCheminFicheTech & rsFicheTech("VFIC")
    //                cnx.Execute "DELETE TFICHETECH WHERE ID = " & rsFicheTech("ID")
    //                rsFicheTech.Requery
    //            End If
    //    End Select
    //    
    //End Sub
    //

    /* OK ---------------------------------------------------------------------*/
    private void cmdRest_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid_FicheTech.GetFocusedDataRow();
      if (row == null) return;

      switch (mstrTypeFiche)
      {
        case "N":
          if (MessageBox.Show(Resources.msg_Confirm_restaurer_fiche_norme, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                              MessageBoxDefaultButton.Button2) == DialogResult.Yes)
          {
            ModuleData.ExecuteNonQuery("UPDATE TFICHENORME SET CACTIF='O' WHERE NID = " + row["NID"].ToString());
          }
          break;
        case "FQ":
        case "PR":
        case "FT":
          if (MessageBox.Show(Resources.msg_Confirm_restaurer_fiche, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                              MessageBoxDefaultButton.Button2) == DialogResult.Yes)
          {
            ModuleData.ExecuteNonQuery("UPDATE TFICHETECH SET CACTIF='O' WHERE ID = " + row["ID"].ToString());
          }
          break;
      }
      LoadGrid();
    }
    //Private Sub cmdRest_Click()
    //    If rsFicheTech.EOF Then Exit Sub
    //
    //    Select Case mstrTypeFiche
    //        Case "N"
    //            If MsgBox("Etes-vous sûre de vouloir restaurer cette fiche norme?", vbYesNo) = vbYes Then
    //                cnx.Execute "UPDATE TFICHENORME SET CACTIF='O' WHERE NID = " & rsFicheTech("NID")
    //                rsFicheTech.Requery
    //            End If
    //        Case "FQ", "PR", "FT"
    //            If MsgBox("Etes-vous sûre de vouloir restaurer cette fiche ?", vbYesNo) = vbYes Then
    //                cnx.Execute "UPDATE TFICHETECH SET CACTIF='O' WHERE ID = " & rsFicheTech("ID")
    //                rsFicheTech.Requery
    //            End If
    //    End Select
    //
    //End Sub
    //

    /* OK ---------------------------------------------------------------------*/
    private void cmdVisu_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid_FicheTech.GetFocusedDataRow();
      if (row == null) return;

      frmBrowser f = new frmBrowser();
      switch (mstrTypeFiche)
      {
        case "N":
          f.msStartingAddress = Utils.RechercheParam("REP_FICHE_NORME") + row["VFIC"].ToString();
          break;
        case "FQ":
        case "PR":
        case "FT":
          f.msStartingAddress = MozartParams.CheminFicheTech + row["VFIC"].ToString();
          break;
      }
      f.ShowDialog();
    }
    //Private Sub CmdVisu_Click()
    //  If rsFicheTech.EOF Then Exit Sub
    //  
    //  Select Case mstrTypeFiche
    //    Case "N"
    //      frmBrowser.StartingAddress = RechercheParam("REP_FICHE_NORME") & rsFicheTech("VFIC")
    //    Case "FQ", "PR", "FT"
    //      frmBrowser.StartingAddress = gstrCheminFicheTech & rsFicheTech("VFIC")
    //  End Select
    //  frmBrowser.Show vbModal
    //End Sub
    //

    /* OK ---------------------------------------------------------------------*/
    private void InitGrid()
    {
      switch (mstrTypeFiche)
      {
        case "N":
          apiTGrid_FicheTech.AddColumn(Resources.col_norme_reglement, "VTITRENORME", 2400, "", 0, true);
          apiTGrid_FicheTech.AddColumn(Resources.col_Technique, "VTECHNORME", 2400, "", 0, true);
          apiTGrid_FicheTech.AddColumn(Resources.col_Lbl, "VLIBNORME", 6000, "", 0, true);
          apiTGrid_FicheTech.AddColumn(Resources.col_publication, "DDATENORME", 1500, "", 2);

          break;

        case "FQ":
        case "PR":
          apiTGrid_FicheTech.AddColumn(Resources.col_fiche_secu, "TITRE", 10800);
          apiTGrid_FicheTech.AddColumn(Resources.col_publication, "DDATEPUB", 1500, "", 2);
          break;

        case "FT":
          apiTGrid_FicheTech.AddColumn(Resources.col_Serie, "VCLASSEMENT", 2800);
          apiTGrid_FicheTech.AddColumn(Resources.col_fiche_tech, "TITRE", 8000);
          apiTGrid_FicheTech.AddColumn(Resources.col_publication, "DDATEPUB", 1500, "", 2);
          break;
      }

      apiTGrid_FicheTech.InitColumnList();
    }
    //Private Sub InitGrid()
    //
    //    Select Case mstrTypeFiche
    //    
    //        Case "N"
    //            apiTGrid_FicheTech.AddColumn "§Normes et réglements§", "VTITRENORME", 2400
    //            apiTGrid_FicheTech.AddColumn "§Techniques§", "VTECHNORME", 2400
    //            apiTGrid_FicheTech.AddColumn "§Libellé§", "VLIBNORME", 6000
    //            apiTGrid_FicheTech.AddColumn "§Publication§", "DDATENORME", 1500, , 2
    //                        
    //            apiTGrid_FicheTech.AddCellTip "VTITRENORME", &HFDF0DA
    //            apiTGrid_FicheTech.AddCellTip "VLIBNORME", &HFDF0DA
    //        Case "FQ", "PR"
    //            apiTGrid_FicheTech.AddColumn "§Fiche sécurité§", "TITRE", 10800
    //            apiTGrid_FicheTech.AddColumn "§Publication§", "DDATEPUB", 1500, , 2
    //        Case "FT"
    //            apiTGrid_FicheTech.AddColumn "Série", "VCLASSEMENT", 2800
    //            apiTGrid_FicheTech.AddColumn "Fiche technique", "TITRE", 8000
    //            apiTGrid_FicheTech.AddColumn "§Publication§", "DDATEPUB", 1500, , 2
    //    End Select
    //
    //apiTGrid_FicheTech.Init rsFicheTech
    //
    //End Sub
    //

    /* inutile---------------------------------------------------------------------*/
    //Private Sub Form_Unload(Cancel As Integer)
    //  If rsFicheTech.State = adStateOpen Then rsFicheTech.Close
    //End Sub
    //
  }
}