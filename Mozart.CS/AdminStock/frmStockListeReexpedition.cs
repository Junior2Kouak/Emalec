using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Base;
using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using ReportEmalec.Net;
using System;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MZCtrlResources = MozartControls.Properties.Resources;
using MZUtils = MozartControls.Utils;


namespace MozartCS
{
  public partial class frmStockListeReexpedition : Form
  {
    DataTable dtDdes;
    DataTable dtDetail;

    public frmStockListeReexpedition() { InitializeComponent(); }
    /*--------------------------------------------------------------*/
    private void frmStockListeReexpedition_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        ModuleMain.Initboutons(this);

        dtDdes = new DataTable();
        dtDetail = new DataTable();

        //  1 Prepa : on met à jour le champ VCONFORMITE_CDE de la table TBE, NL le 06/02/2017
        ModuleData.ExecuteNonQuery("EXEC api_sp_PrepaListeBE 'N'");

        //  2 Lecture du résultat
        apiTGridH.LoadData(dtDdes, MozartDatabase.cnxMozart, "EXEC api_sp_ListeBE 'N'");
        InitapiGridH();

        DataRow row = apiTGridH.GetFocusedDataRow();
        if (null != row) apiTGridB.LoadData(dtDetail, MozartDatabase.cnxMozart, $"api_sp_ListeBEDetails {row["NBENUM"]}");
        InitapiGridB();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGridH.GetFocusedDataRow();
      if (null == row) return;

      if (MessageBox.Show(Resources.msg_fermer_demande, Program.AppTitle, MessageBoxButtons.YesNo,
                  MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;

      string sOperateur = Interaction.InputBox(Resources.msg_saisir_nom, $"{Resources.lbl_MozarisPour}{MozartParams.NomSociete}");
      if (sOperateur == "")
      {
        MessageBox.Show(Resources.msg_devez_saisir_nom, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      ModuleData.ExecuteNonQuery($"UPDATE TBE SET CBESOLDEE = 'O', DBEDPREPA=Getdate(), VBECREATEUR='{sOperateur}' WHERE NBENUM = {row["NBENUM"]}");

      // FGA le 03/06/24
      // si client paramétré pour l'envoi d'un mail, on envoi un mail au client avec le BL en PJ
      string Mail = (string)ModuleData.ExecuteScalarString($"Select CEMALECHABITAT from TCLI where NCLINUM = {row["NCLINUM"]}");
      if (Mail == "O")
      {
        string Message = $"/!\\ CLIENT AVEC MAIL AUTOMATIQUE PREVENTION COLIS\r\n\r\n";
        Message = Message + $"Cette action est-elle la dernière générée pour ce départ de matériel? (Pas d’autre BL ou sortie de stock associée?)\r\n" +
          $"Si vous répondez Oui, le mail automatique récapitulant le matériel à recevoir sera généré et transmis au client";

        if (MessageBox.Show(Message, Program.AppTitle, MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;

        Utils.MailDuBLauClient(Convert.ToInt32(row["NACTNUM"]));

      }

      // ancienne gestion du mail client
      // envoie d'un mail au site si un BL LIBRE à destination du site
      //ModuleData.ExecuteNonQuery($"api_sp_SendMailExpeditionStockBL {row["NBENUM"]}");

      cmdImprimer_Click(null, null);

      apiTGridH.Requery(dtDdes, MozartDatabase.cnxMozart);
    }

    private void cmdBL_Click(object sender, EventArgs e)
    {
      new frmStockListeBE().ShowDialog();
    }

    private void apiTGridH_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
    {
      DataRow row = apiTGridH.GetFocusedDataRow();
      if (null == row)
      {
        apiTGridB.dgv.ActiveFilterString = "NLBLNUM = -1";
        return;
      }

      apiTGridB.LoadData(dtDetail, MozartDatabase.cnxMozart, $"api_sp_ListeBEDetails {row["NBENUM"]}");
      apiTGridB.dgv.ActiveFilterString = $"NLBLNUM = {row["NBENUM"]}";
      cmdValider.Enabled = true;
    }

    private void cmdDI_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGridH.GetFocusedDataRow();
      if (null == row) return;

      MozartParams.NumDi = (int)Utils.ZeroIfNull(row["ndinnum"]);
      MozartParams.NumAction = (int)Utils.ZeroIfNull(row["NACTNUM"]);

      Cursor.Current = Cursors.WaitCursor;
      new frmDetailstravaux
      {
        mstrStatutAction = "M"
      }.ShowDialog();

      MozartParams.NumDi = 0;
      MozartParams.NumAction = 0;

      Cursor.Current = Cursors.Default;
    }

 
    private void cmdListeBL_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGridH.GetFocusedDataRow();
      if (null == row) return;

      string VBETYPDEST = Utils.BlankIfNull(row["VBETYPDEST"]);
      string ident = "";

      if (VBETYPDEST == "Personnel") // Tech
        ident = $"{row["NBENUM"]}|T|E";
      else if (VBETYPDEST == "Site")
        ident = $"{row["NBENUM"]}|S|E";
      else if (VBETYPDEST == "Sous-traitant")
        ident = $"{row["NBENUM"]}|F|E";
      else
      {
        return;
      }

      new frmMainReport
      {
        bLaunchByProcessStart = false,
        sTypeReport = "TBordereau",
        sIdentifiant = ident,
        InfosMail = "0|0|0;",
        sNomSociete = MozartParams.NomSociete,
        sLangue = MozartParams.Langue,
        sOption = "PREVIEW",
        strType = "PREVIEW"
      }.ShowDialog();
    }

    private void InitapiGridH()
    {
      //'  If RechercheDroitMenu(gintUID, 549) Then
      apiTGridH.AddColumn("En prépa", "ENPREPA", 1200, "", 0, false, true);
      //'  End If
      apiTGridH.AddColumn(Resources.col_num_bl, "NBENUM", 700);
      apiTGridH.AddColumn(Resources.col_Date, "DBEDATE", 1400, "Date");
      apiTGridH.AddColumn(Resources.col_dateLivr, "DBEDATEEXPE", 1100, "dd/MM/yy");
      apiTGridH.AddColumn(Resources.col_planifie, "DACTPLA", 1100, "dd/MM/yy");
      apiTGridH.AddColumn(Resources.col_OBS, "VBEOBJET", 3700);
      apiTGridH.AddColumn(Resources.col_DI, "NDINNUM", 820, "", 1);
      apiTGridH.AddColumn(Resources.col_Chaff, "VDINCHAFF", 920);
      apiTGridH.AddColumn(Resources.col_destinataire, "VDEST", 700, "", 0);
      apiTGridH.AddColumn(Resources.col_Tech, "VPERNOM", 1000, "", 0);
      apiTGridH.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1200);
      apiTGridH.AddColumn(Resources.col_Site, "VSITNOM", 1200);
      apiTGridH.AddColumn(Resources.col_CP, "VSITCP", 630, "", 2);
      apiTGridH.AddColumn(Resources.col_Ville, "VSITVIL", 2200);
      apiTGridH.AddColumn("Conformité", "VCONFORMITE_CDE", 800);
      apiTGridH.AddColumn(Resources.col_Code, "VBETYPDEST", 0);
      apiTGridH.FilterBar = true;
      apiTGridH.InitColumnList();
      apiTGridH.GridControl.DataSource = dtDdes;

      // bouton pour la 1ere colonne
      RepositoryItemButtonEdit btnENPREPA = new RepositoryItemButtonEdit();
      btnENPREPA.Buttons.Clear();
      btnENPREPA.Buttons.Add(new EditorButton(ButtonPredefines.Combo));
      btnENPREPA.TextEditStyle = TextEditStyles.DisableTextEditor;
      btnENPREPA.ButtonClick += new ButtonPressedEventHandler(btnENPREPA_ButtonClick);
      apiTGridH.dgv.Columns["ENPREPA"].ColumnEdit = btnENPREPA;
      apiTGridH.dgv.Columns["ENPREPA"].ShowButtonMode = ShowButtonModeEnum.ShowForFocusedCell;
      apiTGridH.dgv.Columns["ENPREPA"].OptionsColumn.AllowEdit = true;
    }

    private void apiTGridH_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
    {
      if (null != e.CellValue && e.Column.Name == "ENPREPA" && e.CellValue.ToString() == "OUI")
      {
        e.Appearance.ForeColor = Color.White;
        e.Appearance.BackColor = Color.Red;
        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
      }
    }

    private void btnENPREPA_ButtonClick(object sender, ButtonPressedEventArgs e)
    {
      if (ModuleMain.RechercheDroitMenu(549))
      {
        DataRow row = apiTGridH.GetFocusedDataRow();
        ModuleData.ExecuteNonQuery($"UPDATE TBE SET ENPREPA = {(Utils.BlankIfNull(row["ENPREPA"]) == "OUI" ? "''" : "'OUI'")} WHERE NBENUM={row["NBENUM"]}");
        apiTGridH.Requery(dtDdes, MozartDatabase.cnxMozart);
      }
    }

    private void InitapiGridB()
    {
      apiTGridB.AddColumn("Num", "NLBLNUM", 0);
      apiTGridB.AddColumn(Resources.col_NumAction, "NACTNUM", 0);
      apiTGridB.AddColumn(Resources.col_NumCF, "NCOMNUM", 1000);
      apiTGridB.AddColumn("Qté", "NLARTQTE", 1000, "", 2);
      apiTGridB.AddColumn(Resources.col_Article, "VLART", 6000);
      apiTGridB.AddColumn(Resources.col_marque, "VFOUMAR", 1000);
      apiTGridB.AddColumn(Resources.col_reference, "VFOUREF", 1000);
      apiTGridB.AddColumn("Réception/Traitement", "RECEPTION", 1500);
      apiTGridB.FilterBar = false;
      apiTGridB.InitColumnList();
      apiTGridB.GridControl.DataSource = dtDetail;
    }

    private void cmdImprimer_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGridH.GetFocusedDataRow();
      if (null == row) return;

      string VBETYPDEST = Utils.BlankIfNull(row["VBETYPDEST"]);
      string ident = "";
      if (VBETYPDEST == "Personnel") // Tech
        ident = $"{row["NBENUM"]}|T|E";
      else if (VBETYPDEST == "Site")
        ident = $"{row["NBENUM"]}|S|E";
      else if (VBETYPDEST == "Sous-traitant")
        ident = $"{row["NBENUM"]}|F|E";
      else
      {
        return;
      }

      new frmMainReport
      {
        bLaunchByProcessStart = false,
        sTypeReport = "TBordereau",
        sIdentifiant = ident,
        InfosMail = "0|0|0;",
        sNomSociete = MozartParams.NomSociete,
        sLangue = MozartParams.Langue,
        sOption = "PRINT",
        strType = "PRINT"
      }.ShowDialog();
    }


    //Private Sub cmdImprimer_Click()
    //
    //    ' impression des BL
    //    If rsDdes!VBETYPDEST = "Personnel" Then  ' si Tech
    //      Shell gstrRepertoireReports & "ReportEmalec.Net.exe " & """TBordereau;" & rsDdes!NBENUM & "|T|E;0|0|0;" & gstrNomSociete & ";" & gstrLangue & ";PRINT", vbNormalFocus
    //    ElseIf rsDdes!VBETYPDEST = "Site" Then    ' si Site
    //      Shell gstrRepertoireReports & "ReportEmalec.Net.exe " & """TBordereau;" & rsDdes!NBENUM & "|S|E;0|0|0;" & gstrNomSociete & ";" & gstrLangue & ";PRINT", vbNormalFocus
    //    ElseIf rsDdes!VBETYPDEST = "Sous-traitant" Then  ' si sous traitant
    //      'LancerImpression "TBordereau", "F", 2, "Nous vous demandons de bien vouloir nous retourner l'accusé de réception ci-joint."
    //      Shell gstrRepertoireReports & "ReportEmalec.Net.exe " & """TBordereau;" & rsDdes!NBENUM & "|F|E;0|0|0;" & gstrNomSociete & ";" & gstrLangue & ";PRINT", vbNormalFocus
    //    End If
    //
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    //Private Sub LoadRsDetail()
    //  Set rsDetail = New ADODB.Recordset
    //
    //  rsDetail.Open "api_sp_ListeBEDetails " & rsDdes!NBENUM, cnx, adOpenKeyset, adLockBatchOptimistic  ' pas d'update automatique
    //  
    //  apiTGridB.Init rsDetail
    //  
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void ChkOnlyPlanif_CheckedChanged(object sender, EventArgs e)
    {
      if (ChkOnlyPlanif.Checked) apiTGridH.dgv.ActiveFilterString = "DACTPLA <> NULL";
      else apiTGridH.dgv.ActiveFilterString = "";
    }

    private void cmdTNT_Click(object sender, EventArgs e)
    {
      creerCommande(5352);  // TNT
    }

    private void cmdDPD_Click(object sender, EventArgs e)
    {
      creerCommande(6602);  // DPD
    }

    private void cmdSchenker_Click(object sender, EventArgs e)
    {
      creerCommande(29033);  // SCHENKER
    }

    private void creerCommande(int pNumFournisseur)
    {
      DataRow row = apiTGridH.GetFocusedDataRow();
      if (null == row) return;

      string sTypeLivr;
      switch (row["VDEST"])
      {
        case "Site":
          sTypeLivr = "S";
          break;
        case "Personnel":
          sTypeLivr = "T";
          break;
        case "Tech filiale":
          sTypeLivr = "E";
          break;
        default:
          sTypeLivr = "E";
          break;
      }

      new frmSelectTransporteur
      {
        miNumFournisseur = pNumFournisseur,
        mstrClient = Utils.BlankIfNull(row["VCLINOM"]),
        mNumAction = (int)row["NACTNUM"],
        mTypeLivr = sTypeLivr
      }.ShowDialog();

      apiTGridH_SelectionChanged(null, null);
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

  }
}

