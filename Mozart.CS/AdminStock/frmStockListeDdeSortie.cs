using MZCtrlResources = MozartControls.Properties.Resources;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Localization;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using ReportEmalec.Net;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using System.IO;
using MZUtils = MozartControls.Utils;


namespace MozartCS
{
  public partial class frmStockListeDdeSortie : Form
  {
    public int miNumAction;
    public bool mbFacture;

    DataSet ds;
    SqlDataAdapter daDdes;
    SqlDataAdapter daDetail;
    SqlDataAdapter daCdeFou;
    SqlCommand cmd_comfou;

    public string mstrTech;
    public string mstrSite;

    int miLastDdeBloquee = -1;


    public frmStockListeDdeSortie()
    {
      InitializeComponent();
      GridLocalizer.Active = new CustomGridLocalizer();
    }

    class CustomGridLocalizer : GridLocalizer
    {
      public override string GetLocalizedString(GridStringId id)
      {
        if (id == GridStringId.CheckboxSelectorColumnCaption)
        {
          return Resources.col_solde;
        }
        return base.GetLocalizedString(id);
      }
    }

    private void frmStockListeDdeSortie_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        if (miNumAction > 0)
        {
          cmdDI.Visible = cmdListeBL.Visible = cmdPrintDde.Visible = cmdPrint.Visible = cmdValider.Visible = cmdCDE.Visible = Frame1.Visible = false;
          cmdAjouter.Visible = cmdVueDde.Visible = true;
        }
        else cmdValider.Enabled = true;

        ds = new DataSet("StockListeDdeSortie");
        daDetail = new SqlDataAdapter();

        cmd_comfou = new SqlCommand("SELECT * FROM api_v_listeCom WHERE VCOMTYP = 'E' AND CCOMACTIF = 'NON' AND NACTNUM = @nactnum ORDER BY NCOMNUM", MozartDatabase.cnxMozart);
        cmd_comfou.CommandType = CommandType.Text;
        cmd_comfou.Parameters.Add("@nactnum", SqlDbType.Int);
        daCdeFou = new SqlDataAdapter(cmd_comfou);

        daDdes = new SqlDataAdapter($"EXEC api_sp_ListeDdeSortieStock {miNumAction}", MozartDatabase.cnxMozart);
        daDdes.Fill(ds, "DdeS");
        apiTGridH.GridControl.DataSource = ds.Tables["DdeS"];
        InitapiGridH();

        if (null != ds.Tables["CdeFou"]) ds.Tables["CdeFou"].Clear();

        if (ds.Tables["DdeS"].Rows.Count > 0)
        {
          // requete recherche detail dde sortie where nddenum
          string NDDENUM = ExtractNDDENUM(ds.Tables["DdeS"].Rows[0]);
          daDetail.SelectCommand = new SqlCommand($"SELECT * FROM dbo.api_v_ListeDdeSortieStockDetail WHERE NDDENUM={NDDENUM} ORDER BY VFOUSER, VFOUMAT", MozartDatabase.cnxMozart);
          daDetail.Fill(ds, "Detail");
          //requete recherche com par rapport au NACTNUM
          //On utilise une commande avec passage de paramatre dans la fonction Execute
          //Pour rafraichir l APITGRID il faut utiliser un Init a chaque requery
          cmd_comfou.Parameters["@nactnum"].Value = (int)Utils.ZeroIfNull(ds.Tables["DdeS"].Rows[0]["NACTNUM"]);
          daCdeFou.Fill(ds, "CdeFou");
        }
        else
        {
          //pas de demande de sortie stock trouvé
          daDetail.SelectCommand = new SqlCommand("SELECT * FROM dbo.api_v_ListeDdeSortieStockDetail WHERE NDDENUM=-1 order by vfouser, vfoumat", MozartDatabase.cnxMozart);
          daDetail.Fill(ds, "Detail");
          cmd_comfou.Parameters["@nactnum"].Value = -1;
          daCdeFou.Fill(ds, "CdeFou");
        }
        SqlCommand cmdUpdate = new SqlCommand("UPDATE TLART SET NLARTQTEBL=@NLARTQTEBL, SOLDE=@SOLDE WHERE NDDENUM=@NDDENUM AND NFOUNUM=@NFOUNUM", MozartDatabase.cnxMozart);
        cmdUpdate.Parameters.Add("@NLARTQTEBL", SqlDbType.Int, 4, "NLARTQTEBL");
        cmdUpdate.Parameters.Add("@SOLDE", SqlDbType.SmallInt, 2, "SOLDE");
        cmdUpdate.Parameters.Add("@NDDENUM", SqlDbType.Int, 4, "NDDENUM");
        cmdUpdate.Parameters.Add("@NFOUNUM", SqlDbType.Int, 4, "NFOUNUM");
        daDetail.UpdateCommand = cmdUpdate;

        InitapiGridB();
        InitApiGridCdeFou();
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
        DataRow rowDdes = apiTGridH.GetFocusedDataRow();
        if (null == rowDdes) return;
        //  Maj TLART
        string sOperateur = "";

 
        if (Verifications())
        {
          sOperateur = Interaction.InputBox(Resources.msg_saisir_nom, Resources.lbl_MozarisPour + MozartParams.NomSociete);
          if (sOperateur == "")
          {
            MessageBox.Show(Resources.msg_devez_saisir_nom, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
          }
          Cursor.Current = Cursors.WaitCursor;
          daDetail.Update(ds, "Detail");

          // Maj TBL et TBLL + solder les lignes dont les qtés demandées et sorties sont égales
          string NDDENUM = ExtractNDDENUM(rowDdes);
          int numBL = (int)ModuleData.ExecuteScalarInt($"EXEC api_sp_MajDdeStock {NDDENUM}, {rowDdes["NACTNUM"]}, '{rowDdes["VDDETYPE"]}', '{sOperateur}'");
          cmdValider.Enabled = false;

          //FGA le 03 / 06 / 24
          // si client paramétré sur envoie mail, on envoi un mail
          string Mail = (string)ModuleData.ExecuteScalarString($"Select CEMALECHABITAT from TCLI where NCLINUM = {rowDdes["NCLINUM"]}");
          if (Mail == "O")
          {
            string Message = $"/!\\ CLIENT AVEC MAIL AUTOMATIQUE PREVENTION COLIS\r\n\r\n";
            Message = Message + $"Cette action est-elle la dernière générée pour ce départ de matériel? (Pas d’autre BL ou sortie de stock associée?)\r\n" +
              $"Si vous répondez Oui, le mail automatique récapitulant le matériel à recevoir sera généré et transmis au client";

            if (MessageBox.Show(Message, Program.AppTitle, MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;

            Utils.MailDuBLauClient(Convert.ToInt32(rowDdes["NACTNUM"]));
          }

          // on envoi un mail au client lorsque la sortie est destinée au site
          //ModuleData.ExecuteNonQuery($"EXEC api_sp_SendMailExpeditionStock {numBL}");

          // on ajout dans le champ observations de l'action de la filiale dans laquelle la commande une filiale a été passée
          ModuleData.ExecuteNonQuery($"EXEC api_sp_AjoutObsEnvoiCmdToSiteClientFiliale {numBL}");

          // gestion des reappro tech filiale
          // on teste si bl existe dans tcmd_filiale_bl
          if (0 != numBL)
          {
            using (SqlDataReader reader = ModuleData.ExecuteReader($"SELECT NIDCMD_FILIALE_BL FROM TCMD_FILIALE_BL WITH (NOLOCK) WHERE NBLNUM_EMALEC = {numBL}"))
            {
              if (reader.Read())
                Traitement_ReapproTechFilialeOnFiliale(numBL);
            }
          }

          Cursor.Current = Cursors.Default;
          PrintBL(numBL);
        }

        Cursor.Current = Cursors.WaitCursor;
        ds.Tables["DdeS"].Clear();
        daDdes.Fill(ds, "DdeS");
        apiTGridH_SelectionChanged(null, null);

        ModuleData.ExecuteNonQuery($"UPDATE TSTOCKDDE SET NQUIBLOQUE = Null WHERE NDDENUM = {miLastDdeBloquee}");
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    //private void MailDuBLauClient(int nActnum)
    //{

    //  // recherche des infos
    //  SqlDataReader rsLoad = ModuleData.ExecuteReader($"EXEC api_sp_RechercheInfoMailBLClient {nActnum}");

    //  // si pas d'info, c'est qu'il manque le mail du site
    //  if (rsLoad.Read())
    //  {

    //    // génération du BL
    //    new frmMainReport
    //    {
    //      bLaunchByProcessStart = false,
    //      sTypeReport = "TBordereau",
    //      sIdentifiant = $"{nActnum}|S|M",
    //      InfosMail = "0|0|0;",
    //      sNomSociete = MozartParams.NomSociete,
    //      sLangue = MozartParams.Langue,
    //      sOption = "PDF",
    //      strType = "PDF"
    //    }.ShowDialog();

    //    if (rsLoad["VCSITMAI"].ToString() != "")
    //    {
    //        // chemin du serveur de mail
    //        string sPJ = $"\\\\{MozartParams.NomServeur}\\PJMail\\{nActnum}.pdf";
    //        File.Copy($"{MozartParams.CheminUtilisateurMozart}\\PDF\\{nActnum}.pdf", sPJ, true);

    //        string Sujet = $"Livraison Colis EMALEC – DI Emalec [{rsLoad["NDINNUM"]}] – Ref client : [{rsLoad["VACTNUMCDE"]}] – GMAO [{rsLoad["VACTNUMGMAO"]}]";
    //        string Message = $"Bonjour,\r\n\r\n";
    //        Message = Message + "Vous allez recevoir dans les jours à venir un colis de la part d’Emalec dont le contenu est décrit en pièce jointe pour l’intervention suivante :\r\n\r\n";
    //        Message = Message + rsLoad["VACTDES"] + Environment.NewLine + Environment.NewLine;
    //        Message = Message + "Nos équipes prendront contact ultérieurement avec vous pour valider la date de rendez-vous.\r\n\r\n";
    //        Message = Message + "A bientôt,";

    //        Message = Message.Replace("'", "''");
    //        Sujet = Sujet.Replace("'", "''");

    //        string sSql = "EXEC msdb..sp_send_dbmail ";
    //        sSql += "@profile_name = 'Web" + MozartParams.NomSociete + "', ";
    //        sSql += "@recipients   = '" + rsLoad["VCSITMAI"] + "', ";
    //        sSql += "@body         = '" + Message + "', ";
    //        sSql += "@subject      = '" + Sujet + "', ";
    //        sSql += "@file_attachments = '" + Strings.Replace(sPJ, "'", "''") + "' ";
    //        sSql += ", @blind_copy_recipients ='info@emalec.com'";

    //        ModuleData.ExecuteNonQuery(sSql);
    //    }       

    //  }
    //  rsLoad.Close();

    //}

    private void cmdSupp_Click(object sender, EventArgs e)
    {
      DataRow rowDdes = apiTGridH.GetFocusedDataRow();
      if (null == rowDdes) return;

      if ((int)rowDdes["EN_COURS"] == 1)
      {
        MessageBox.Show(Resources.msg_impossible_supprimer_demande, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      if (MessageBox.Show(Resources.msg_supprimer_demande_sortie, Program.AppTitle, MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;

      try
      {
        Cursor.Current = Cursors.WaitCursor;

        string NDDENUM = ExtractNDDENUM(rowDdes);

        ModuleData.ExecuteNonQuery($"delete from tlart where NDDENUM = {NDDENUM}");
        ModuleData.ExecuteNonQuery($"delete from tstockdde where NDDENUM = {NDDENUM}");
        // on archive la demande de ss si elle est supprimé + la commande créer sur la filiale
        ModuleData.ExecuteNonQuery($"EXEC [api_sp_CommandeReapproTech_ArchiverByMagasinEMALEC] {NDDENUM}");

        ds.Tables["DdeS"].Clear();
        daDdes.Fill(ds, "DdeS");
        apiTGridH_SelectionChanged(null, null);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

 
    private void cmdCDE_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGridB.GetFocusedDataRow();
      if (null == row) return;

      if (row["NFOUQTECDE"].ToString() == "") return;

      new frmListeCommandesFour
      {
        miFouNum = (int)Utils.ZeroIfNull(row["NFOUNUM"]),
        miCompte = 995,
        mstrStatutCom = "S"
      }.ShowDialog();
    }

    private void Check2_CheckedChanged(object sender, EventArgs e)
    {
      if (Check2.Checked) apiTGridH.dgv.ActiveFilterString = "EN_COURS = 1";
      else apiTGridH.dgv.ActiveFilterString = "";
    }

    private void Check1_CheckedChanged(object sender, EventArgs e)
    {
      if (Check1.Checked) apiTGridH.dgv.ActiveFilterString = "EN_COURS != 1";
      else apiTGridH.dgv.ActiveFilterString = "";
    }

    private void apiTGridH_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
    {
      DataRow row = apiTGridH.GetFocusedDataRow();
      if (null != ds.Tables["CdeFou"]) ds.Tables["CdeFou"].Clear();
      if (null != row)
      {
        MozartParams.NumAction = (int)Utils.ZeroIfNull(row["NACTNUM"]);
        RefreshRecDetail(Convert.ToInt32(ExtractNDDENUM(row)));
        cmdValider.Enabled = true;
        txtHT.Text = CalculerTHT().ToString("N2");
        // on change de dde, donc on débloque la dde précédente
        ModuleData.ExecuteNonQuery($"UPDATE TSTOCKDDE SET NQUIBLOQUE = Null WHERE NDDENUM ={miLastDdeBloquee}");

        if (MozartParams.NumAction > 0) cmdModif.Enabled = ((int)row["EN_COURS"] == 0 && (int)Utils.ZeroIfNull(row["NQUIBLOQUE"]) == 0);
        cmdValider.Enabled = (int)Utils.ZeroIfNull(row["NQUIBLOQUE"]) == 0;
        if (cmdValider.Enabled)
          Label10.Text = Resources.msg_detail_demande;
        else
        {
          using (SqlDataReader reader = ModuleData.ExecuteReader($"select VPERNOM + ' ' + VPERPRE FROM TPER WHERE NPERNUM = {(int)Utils.ZeroIfNull(row["NQUIBLOQUE"])}"))
          {
            if (reader.Read()) Label10.Text = $"{Resources.detail_demande_en_cours} {Utils.BlankIfNull(reader[0])})";
          }
        }
        if ((int)Utils.ZeroIfNull(row["NQUIBLOQUE"]) == 0)
        {
          miLastDdeBloquee = Convert.ToInt32(ExtractNDDENUM(row));
          ModuleData.ExecuteNonQuery($"UPDATE TSTOCKDDE SET NQUIBLOQUE = {MozartParams.UID} WHERE NDDENUM = {miLastDdeBloquee}");
        }
        // passage des paramètres
        daCdeFou.SelectCommand.Parameters["@nactnum"].Value = (int)Utils.ZeroIfNull(row["NACTNUM"]);
        daCdeFou.Fill(ds, "CdeFou");
        Frame1.Visible = ds.Tables["CdeFou"].Rows.Count > 0;
      }
      else
      {
        // aucune demande dans la liste-- > aucun détail
        RefreshRecDetail(-1);
        daCdeFou.SelectCommand.Parameters["@nactnum"].Value = -1;
        daCdeFou.Fill(ds, "CdeFou");
        Frame1.Visible = false;  // pas de commande lié
        txtHT.Text = "0";
      }
    }
    //Private Sub apiTGridH_RowColChange()
    //
    //  If Not rsDdes.EOF Then
    //    glNumAction = rsDdes("NACTNUM")
    //  
    //    'rsDetail.Filter = "NDDENUM = " & Mid(rsDdes!NDDENUM, 3)
    //    RefreshRecDetail Mid(rsDdes!NDDENUM, 3)
    //    cmdValider.Enabled = True
    //    txtHT = CalculerTHT
    //    
    //    ' on change de dde, donc on débloque la dde précédente
    //    cnx.Execute "UPDATE TSTOCKDDE SET NQUIBLOQUE = Null WHERE NDDENUM = " & miLastDdeBloquee
    //    
    //    If glNumAction > 0 Then cmdModif.Enabled = (rsDdes!EN_COURS = 0 And ZeroIfNull(rsDdes!NQUIBLOQUE) = 0)
    //    cmdValider.Enabled = (ZeroIfNull(rsDdes!NQUIBLOQUE) = 0)
    //    If cmdValider.Enabled = False Then
    //      Dim rsP As New ADODB.Recordset
    //      rsP.Open "select VPERNOM + ' ' + VPERPRE FROM TPER WHERE NPERNUM = " & ZeroIfNull(rsDdes!NQUIBLOQUE), cnx, adOpenForwardOnly, adLockReadOnly
    //      If Not rsP.EOF Then
    //        Label1(0).Caption = "§Détail de la demande (modification en cours par §" & rsP(0) & ")"
    //        rsP.Close: Set rsP = Nothing
    //      End If
    //    Else
    //      Label1(0).Caption = "§Détail de la demande§"
    //    End If
    //    
    //    If ZeroIfNull(rsDdes!NQUIBLOQUE) = 0 Then
    //      miLastDdeBloquee = Mid(rsDdes!NDDENUM, 3)
    //      cnx.Execute "UPDATE TSTOCKDDE SET NQUIBLOQUE = " & gintUID & " WHERE NDDENUM = " & miLastDdeBloquee
    //    End If
    //    
    //    ' passage des paramètres
    //    Set rsCdeFou = cmd_comfou.Execute(, rsDdes!NACTNUM)
    //    apiTGridCdeFour.Init rsCdeFou
    //
    //    If rsCdeFou.RecordCount > 0 Then
    //      Frame1.Visible = True
    //    Else
    //      Frame1.Visible = False
    //    End If
    //    
    //  Else
    //    ' aucune demande dans la liste --> aucun détail
    //    RefreshRecDetail -1
    //    'rsCdeFou.Filter = "NACTNUM = -1"
    //    Set rsCdeFou = cmd_comfou.Execute(, -1)
    //    apiTGridCdeFour.Init rsCdeFou
    //    
    //    Frame1.Visible = False  ' pas de commande lié
    //    txtHT = 0
    //  End If
    //  apiTGridB.MajLabel
    //    
    //
    //
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void PrintBL(int numBL)
    {
      new frmMainReport
      {
        bLaunchByProcessStart = false,
        sTypeReport = "TBordereau",
        sIdentifiant = $"{numBL}|T|L",
        InfosMail = "0|0|0;",
        sNomSociete = MozartParams.NomSociete,
        sLangue = MozartParams.Langue,
        sOption = "PRINT",
        strType = "PREVIEW"
      }.ShowDialog();
    }

    private void cmdDI_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGridH.GetFocusedDataRow();
      if (null == row) return;

      MozartParams.NumDi = (int)row["ndinnum"];
      MozartParams.NumAction = (int)row["NACTNUM"];

      Cursor.Current = Cursors.WaitCursor;
      new frmDetailstravaux()
      {
        mstrStatutAction = "M",
      }.ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void cmdVueDde_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGridH.GetFocusedDataRow();
      if (null == row) return;

      new frmMainReport
      {
        bLaunchByProcessStart = false,
        sTypeReport = "TDdeSortie",
        sIdentifiant = $"{ExtractNDDENUM(row)}|B",
        InfosMail = "0|0|0;",
        sNomSociete = MozartParams.NomSociete,
        sLangue = MozartParams.Langue,
        sOption = "PREVIEW"
      }.ShowDialog();
    }

    private void cmdPrintDde_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGridH.GetFocusedDataRow();
      if (null == row) return;

      if (Utils.BlankIfNull(row["ENPREPA"]) == "OUI")
      {
        MessageBox.Show("Sortie de stock en preparation", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      new frmMainReport
      {
        bLaunchByProcessStart = false,
        sTypeReport = "TDdeSortie",
        sIdentifiant = $"{ExtractNDDENUM(row)}|A",
        InfosMail = "0|0|0;",
        sNomSociete = MozartParams.NomSociete,
        sLangue = MozartParams.Langue,
        sOption = "PREVIEW"
      }.ShowDialog();

    }

    private void cmdPrint_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGridH.GetFocusedDataRow();
      if (null == row) return;
      if (Utils.BlankIfNull(row["ENPREPA"]) == "OUI")
      {
        MessageBox.Show("Sortie de stock en preparation", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      //string[,] TdbGlobal = { { "Copie", "Original" } };

      //new frmBrowser().ImprimerFichier(MozartParams.CheminModeles + MozartParams.Langue + @"\TDdeSortie.rtf",
      //                                @"TDdeSortie1.rtf",
      //                                TdbGlobal,
      //                                $"exec api_sp_impDdeSortieStock {ExtractNDDENUM(rowDdes)}");

      new frmMainReport
      {
        bLaunchByProcessStart = false,
        sTypeReport = "TDdeSortie",
        sIdentifiant = $"{ExtractNDDENUM(row)}|A",
        InfosMail = "0|0|0;",
        sNomSociete = MozartParams.NomSociete,
        sLangue = MozartParams.Langue,
        sOption = "PRINT"
      }.ShowDialog();

    }

    private void cmdModif_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGridH.GetFocusedDataRow();
      if (null == row) return;

      int h = apiTGridH.dgv.FocusedRowHandle;
      int NDDENUM = Convert.ToInt32(ExtractNDDENUM(row));

      frmStockDdeSortie frm = new frmStockDdeSortie();

      if (row["VDEST"].ToString() == "Tech Filiale")
        frm.mstrTech = $"{Utils.BlankIfNull(row["vTech"])} ({Utils.BlankIfNull(row["vClinom"])})";
      else
        frm.mstrTech = Utils.BlankIfNull(row["vTech"]);

      if (row["VDEST"].ToString() == "Site client filiale")
        frm.mstrSite = $"{Utils.BlankIfNull(row["VSITNOM_DEST"])} (Site du client filiale)";
      else
        frm.mstrSite = Utils.BlankIfNull(row["VSITNOM"]);

      frm.mbFacture = mbFacture;
      frm.miNumDdeSortie = NDDENUM;
      frm.ShowDialog();

      Cursor.Current = Cursors.WaitCursor;
      ds.Tables["DdeS"].Clear();
      daDdes.Fill(ds, "DdeS");

      apiTGridH.dgv.FocusedRowHandle = h;

      RefreshRecDetail(NDDENUM);
    }

    private void cmdAjouter_Click(object sender, EventArgs e)
    {
      if (mbFacture)
      {
        MessageBox.Show(Resources.msg_engagerDepenseActPlanifier, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      new frmStockDdeSortie
      {
        mstrTech = mstrTech,    //frmDetailstravaux.txtInter.Text
        mstrSite = mstrSite,    //frmDetailstravaux.txtSite
        miNumDdeSortie = 0      // mode ajout
      }.ShowDialog();

      Cursor.Current = Cursors.WaitCursor;
      ds.Tables["DdeS"].Clear();
      daDdes.Fill(ds, "DdeS");
      apiTGridH_SelectionChanged(null, null);
      Cursor.Current = Cursors.Default;
    }

    private void cmdListeBL_Click(object sender, EventArgs e)
    {
      new frmStockListeBL().ShowDialog();
    }

    private void apiTGridB_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
    {
      DataRow r = apiTGridB.GetFocusedDataRow();
      if (null == r) return;
      // en cs pas de valeur -1 (!= vb6)
      if (r["SOLDE"].ToString() == "-1")
      {
        try
        {
          Cursor.Current = Cursors.WaitCursor;
          r["SOLDE"] = 1;
          daDetail.Update(ds, "Detail");
        }
        catch (Exception ex)
        {
          MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
        }
        finally { Cursor.Current = Cursors.Default; }
      }
    }
    //Private Sub apiTGridB_AfterColUpdate(ColIndex As Integer)
    //' UPGRADE_INFO (#0501): The 'iPos' member isn't used anywhere in current application.
    //' Dim iPos As Integer
    //
    //'  iPos = rsDetail.AbsolutePosition
    //'  rsDetail.Requery
    //'  rsDetail.AbsolutePosition = iPos
    //'  cnx.Execute "UPDATE TLART SET SOLDE = " & IIf(rsDetail!SOLDE = -1, 1, 0) & " WHERE NDDENUM = " & Mid(rsDdes!NDDENUM, 3) & " and NFOUNUM = " & rsDetail!nfounum
    //'  rsDetail.Requery
    //'  rsDetail.AbsolutePosition = iPos
    //  
    //  If rsDetail!SOLDE = -1 Then
    //    rsDetail!SOLDE = 1
    //    rsDetail.Update
    //  End If
    //  
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void btnENPREPA_ButtonClick(object sender, ButtonPressedEventArgs e)
    {
      if (ModuleMain.RechercheDroitMenu(549))
      {
        try
        {
          Cursor.Current = Cursors.WaitCursor;

          DataRow row = apiTGridH.GetFocusedDataRow();
          if (null == row) return;
          int h = apiTGridH.dgv.FocusedRowHandle;
          ModuleData.ExecuteNonQuery($"UPDATE TSTOCKDDE SET ENPREPA = {(Utils.BlankIfNull(row["ENPREPA"]) == "OUI" ? "''" : "'OUI'")} WHERE NDDENUM={ExtractNDDENUM(row)}");

          ds.Tables["DdeS"].Clear();
          daDdes.Fill(ds, "DdeS");
          apiTGridH.dgv.FocusedRowHandle = h;
          apiTGridH_SelectionChanged(null, null);
        }
        catch (Exception ex)
        {
          MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
        }
        finally { Cursor.Current = Cursors.Default; }
      }
    }

    private void InitapiGridH()
    {
      //if (ModuleMain.RechercheDroitMenu(MozartParams.UID,549));
      apiTGridH.AddColumn("En prépa", "ENPREPA", 700, "", 0, false, true);
      apiTGridH.AddColumn(Resources.col_Dde, "NDDENUM", 1000);
      apiTGridH.AddColumn(Resources.col_Ddde, "DDDEDATE", 1100, "Date");
      apiTGridH.AddColumn(Resources.col_Dlivr, "DDDELIVR", 800, "dd/MM/yy");
      apiTGridH.AddColumn(Resources.col_DPlanif, "DACTPLA", 800);
      apiTGridH.AddColumn(Resources.col_Destination, "VLIEULIVR", 850);
      apiTGridH.AddColumn(Resources.col_Des, "des", 1100);
      apiTGridH.AddColumn(Resources.col_DI, "NDINNUM", 700, "", 1);
      apiTGridH.AddColumn(Resources.col_Chaff, "VPERNOM", 1100);
      apiTGridH.AddColumn(Resources.col_Auteur, "VDDEQUICRE", 1100);
      apiTGridH.AddColumn(Resources.col_Lbl, "VACTDES", 2300, "", 0, true);//AddCellTip
      apiTGridH.AddColumn(Resources.col_Dest, "VDEST", 900, "", 0, true);//AddCellTip
      apiTGridH.AddColumn(Resources.col_Tech, "VTECH", 1100, "", 0, true);//AddCellTip
      apiTGridH.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1000);
      apiTGridH.AddColumn(Resources.col_Site, "VSITNOM", 1300, "", 0, true);//AddCellTip
      apiTGridH.AddColumn(Resources.col_CP, "VSITCP", 700, "", 2);
      apiTGridH.AddColumn(Resources.col_Ville, "VSITVIL", 1500, "", 0, true);//AddCellTip
      apiTGridH.AddColumn(Resources.col_ficheFour, "VLIB", 1200);
      apiTGridH.AddColumn(Resources.col_Encours, "EN_COURS", 0);
      apiTGridH.AddColumn(Resources.col_Code, "CODESTOCK", 0);
      apiTGridH.AddColumn("VSITNOM_DEST", "VSITNOM_DEST", 0);
      apiTGridH.AddColumn("NumSite", "NSITNUM", 0);
      apiTGridH.AddColumn("ActNum", "NACTNUM", 0);

      apiTGridH.InitColumnList();

      // bouton pour la 1ere colonne
      RepositoryItemButtonEdit btnENPREPA = new RepositoryItemButtonEdit();
      btnENPREPA.Buttons.Clear();
      btnENPREPA.Buttons.Add(new EditorButton(ButtonPredefines.Combo));
      btnENPREPA.TextEditStyle = TextEditStyles.DisableTextEditor;
      btnENPREPA.ButtonClick += new ButtonPressedEventHandler(btnENPREPA_ButtonClick);
      apiTGridH.dgv.Columns["ENPREPA"].ColumnEdit = btnENPREPA;
      apiTGridH.dgv.Columns["ENPREPA"].ShowButtonMode = ShowButtonModeEnum.ShowForFocusedCell;
      apiTGridH.dgv.Columns["ENPREPA"].OptionsColumn.AllowEdit = true;

      apiTGridH.dgv.OptionsView.ColumnAutoWidth = false;
    }

    private void apiTGridH_RowStyle(object sender, RowStyleEventArgs e)
    {
      if (e.RowHandle >= 0)
      {
        GridView View = sender as GridView;
        if (View.GetDataRow(e.RowHandle)["VDDETYPE"].ToString() == "REAPPRO") // réappro web en rouge
        {
          e.Appearance.ForeColor = Color.Black;
          e.Appearance.BackColor = MozartColors.colorHC0C0FF;
          e.HighPriority = true;
        }
        if (View.GetDataRow(e.RowHandle)["EN_COURS"].ToString() == "1")   //  Dde partiellement traitée en vert
        {
          e.Appearance.ForeColor = Color.Black;
          e.Appearance.BackColor = MozartColors.ColorHC0FFC0;
          e.HighPriority = true;
        }
        if (View.GetDataRow(e.RowHandle)["CODESTOCK"].ToString() == "O")  // gras si stock existe
        {
          e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
          e.HighPriority = true;
        }
      }
    }

    private void InitapiGridB()
    {
      if (miNumAction == 0)
      {
        //apiTGridB.AddColumn("§Soldé§", "SOLDE", 700);
        apiTGridB.dgv.OptionsSelection.MultiSelect = true;
        apiTGridB.dgv.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect;
        apiTGridB.dgv.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.False;
        apiTGridB.dgv.OptionsSelection.CheckBoxSelectorField = "SOLDE";
      }
      apiTGridB.AddColumn("DdeNum", "NDDENUM", 0);
      apiTGridB.AddColumn("ActNum", "NACTNUM", 0);
      apiTGridB.AddColumn("FouNum", "NFOUNUM", 0);
      apiTGridB.AddColumn(Resources.col_série, "VFOUSER", 1200);
      apiTGridB.AddColumn(Resources.col_Article, "VFOUMAT", 3500);
      apiTGridB.AddColumn(Resources.col_Emplmt, "VFOUEMPLACEMENT", 1100);
      apiTGridB.AddColumn(Resources.col_marque, "VFOUMAR", 1100, "", 0, true);//AddCellTip
      apiTGridB.AddColumn(Resources.col_Type, "VFOUTYP", 1100);
      apiTGridB.AddColumn(Resources.col_reference, "VFOUREF", 1200);
      apiTGridB.AddColumn(Resources.col_demande, "NLARTQTE", 1100, "", 2);
      apiTGridB.AddColumn(Resources.col_Déjaexp, "NLARTQTEOUT", 1000, "", 2);
      if (miNumAction == 0)
      {
        apiTGridB.AddColumn(Resources.col_Cmdee, "NFOUQTECDE", 1000, "", 2);
        apiTGridB.AddColumn(Resources.col_Actuel, "NLARTQTEBL", 1200, "", 2);
        apiTGridB.DelockColumn("NLARTQTEBL");
        apiTGridB.AddColumn(Resources.col_stock, "NFOUQTESTOCK", 1200, "", 2);
        apiTGridB.AddColumn("Qté Dde", "QTEDDE", 1400, "", 2);
      }
      else apiTGridB.AddColumn(Resources.col_Cmdee, "NFOUQTECDE", 0, "", 2);

      apiTGridB.FilterBar = false;
      apiTGridB.InitColumnList();
      apiTGridB.GridControl.DataSource = ds.Tables["Detail"];
    }

    private void apiTGridB_RowCellStyle(object sender, RowCellStyleEventArgs e)
    {
      if (null == e.CellValue) return;

      if (e.Column.Name == "SOLDE")
      {
        if (e.CellValue.ToString() == "0")
        {
          e.Appearance.ForeColor = MozartColors.colorHCCCCCC;
          e.Appearance.BackColor = Color.White;
        }
        else if (e.CellValue.ToString() == "1")
        {
          e.Appearance.ForeColor = Color.Red;
          e.Appearance.BackColor = MozartColors.ColorHC000;
          e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
        }
      }
      else if (e.Column.Name == "NLARTQTEOUT")
      {
        if (e.RowHandle >= 0)
        {
          GridView View = sender as GridView;
          if (View.GetDataRow(e.RowHandle)["NLARTQTE"].ToString() != e.CellValue.ToString()) e.Appearance.ForeColor = Color.Red;
          e.Appearance.BackColor = MozartColors.colorHCCCCCC;
          e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
        }
      }
      else if (e.Column.Name == "NFOUQTESTOCK")
      {
        // stock - (demandé-deja exp)
        if (e.RowHandle >= 0)
        {
          if (e.CellValue.ToString() == "0")
          {
            e.Appearance.ForeColor = MozartColors.colorHCCCCCC;
            e.Appearance.BackColor = Color.White;
          }
          GridView View = sender as GridView;
          if (View.GetDataRow(e.RowHandle)["NLARTQTEOUT"].ToString() == View.GetDataRow(e.RowHandle)["NLARTQTEBL"].ToString()) return;
          if ((int)e.CellValue - (int)View.GetDataRow(e.RowHandle)["NLARTQTEOUT"] - (int)View.GetDataRow(e.RowHandle)["NLARTQTEBL"] < 0)
          {
            e.Appearance.ForeColor = Color.Red;
            e.Appearance.BackColor = MozartColors.ColorHC0FFC0;
            e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
          }
        }
      }
    }

    private void apiTGridH_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
    {
      if (e.Column.Name == "ENPREPA")
      {
        if (null != e.CellValue && e.CellValue.ToString() == "OUI")
        {
          e.Appearance.ForeColor = Color.White;
          e.Appearance.BackColor = Color.Red;
          e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
        }
        else
        {
          e.Appearance.ForeColor = MozartColors.colorHCCCCCC;
          e.Appearance.BackColor = Color.White;
        }
      }
    }

    private bool Verifications()
    {
      if (0 == ds.Tables["Detail"].Rows.Count) return false;
      bool res = false;
      int SumQte = 0;
      foreach (DataRow row in ds.Tables["Detail"].Rows)
      {
        if (row["NLARTQTEOUT"].ToString() != row["NLARTQTE"].ToString())
        {
          if (Utils.ZeroIfNull(row["NLARTQTEBL"]) > Utils.ZeroIfNull(row["NLARTQTE"]))
          {
            MessageBox.Show(Resources.msg_qte_BL_sup_qte_demande, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            row["NLARTQTEBL"] = 0;
            return res;
          }
          // FG 27/07 ajout test sur la quantité en stock
          if (Utils.ZeroIfNull(row["NLARTQTEBL"]) > Utils.ZeroIfNull(row["NFOUQTESTOCK"]))
          {
            MessageBox.Show("Quantité du BL supérieure à la quantité en stock", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            row["NLARTQTEBL"] = 0;
            return res;
          }
          SumQte += (int)Utils.ZeroIfNull(row["NLARTQTEBL"]);
        }
        else
        {
          if (Utils.ZeroIfNull(row["NLARTQTEBL"]) > 0) SumQte = 1;
        }
      }
      if (0 == SumQte) return res;
      return true;
    }

    private double CalculerTHT()
    {
      DataRow row = apiTGridH.GetFocusedDataRow();
      if (null == row) return 0;
      double mt = (double)ModuleData.ExecuteScalarDouble($"EXEC api_sp_MontantDde {ExtractNDDENUM(row)}");
      Math.Round(mt, 2);
      return mt;
    }

    private void frmStockListeDdeSortie_FormClosing(object sender, FormClosingEventArgs e)
    {
      ModuleData.ExecuteNonQuery($"UPDATE TSTOCKDDE SET NQUIBLOQUE = Null WHERE NDDENUM = {miLastDdeBloquee}");
      mbFacture = false;
    }

    private void InitApiGridCdeFou()
    {
      apiTGridCdeFour.AddColumn(Resources.col_Num_CDE, "NCOMNUM", 800);
      apiTGridCdeFour.AddColumn(Resources.col_Fournisseur, "VSTFNOM", 2200);
      apiTGridCdeFour.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 2000);
      apiTGridCdeFour.AddColumn(Resources.col_DateLivraison, "DCOMDLI", 1300, "", 2);
      apiTGridCdeFour.AddColumn(Resources.col_Reception, "NCOMETAT", 500, "", 2);

      apiTGridCdeFour.InitColumnList();
      apiTGridCdeFour.GridControl.DataSource = ds.Tables["CdeFou"];
    }

    private void RefreshRecDetail(int DdeNum)
    {
      if (null == daDetail.SelectCommand) return;
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        daDetail.Update(ds, "Detail");
        daDetail.SelectCommand.CommandText = $"SELECT * FROM dbo.api_v_ListeDdeSortieStockDetail WHERE NDDENUM={DdeNum} order by vfouser, vfoumat";
        ds.Tables["Detail"].Clear();
        daDetail.Fill(ds, "Detail");
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally
      {
        Cursor.Current = Cursors.Default;
      }
    }

    private void apiTGridB_CellValueChanging(object sender, CellValueChangedEventArgs e)
    {
      if (e.Value.ToString() == "")
      {
        MessageBox.Show(Resources.col_Valeurvide, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        (sender as GridView).CancelUpdateCurrentRow();
      }
    }

    private void apiTGridCdeFour_RowCellStyle(object sender, RowCellStyleEventArgs e)
    {
      // Gestion  de la couleur selon létat de la commande MC le 05/01/12
      if (null != e.CellValue && e.Column.Name == "NCOMETAT")
      {
        if (e.CellValue.ToString() == "PARTIEL") e.Appearance.BackColor = MozartColors.ColorH80FF00;
        else if (e.CellValue.ToString() == "OUI") e.Appearance.BackColor = MozartColors.ColorH80FF80;
      }
    }

    private void apiTGridH_DoubleClickE(object sender, EventArgs e)
    {
      DataRow row = apiTGridH.GetFocusedDataRow();
      if (null == row) return;

      if (row["VLIB"].ToString() != "")
      {
        ModuleData.RemplirCombo(cboFicChantierFO, $"SELECT NIDFICHE, VLIB FROM TCHANTIERFICHE WITH (NOLOCK) INNER JOIN TCHANTIERCAN WITH (NOLOCK) ON TCHANTIERFICHE.NIDCHANTIER = TCHANTIERCAN.NIDCHANTIER INNER JOIN" +
                                                  $" TDIN WITH (NOLOCK) ON TDIN.NDINCTE = TCHANTIERCAN.NCANNUM AND TDIN.NDINNUM = {Utils.ZeroIfNull(row["NDINNUM"])}" +
                                                  $" WHERE VTYPE = 'F' AND VSOCIETE = '{MozartParams.NomSociete}' ORDER BY TCHANTIERFICHE.NCLASS");
        cboFicChantierFO.ValueMember = "NIDFICHE";
        cboFicChantierFO.DisplayMember = "VLIB";
        cboFicChantierFO.Text = row["VLIB"].ToString();

        FrmFicheChantier.Visible = true;
      }
    }

    private void CmdCloseFrame_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGridH.GetFocusedDataRow();
      if (null == row) return;
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        // mise à jour de la fiche
        ModuleData.ExecuteNonQuery($"UPDATE TSTOCKDDE SET NIDFICHE = {cboFicChantierFO.SelectedValue} WHERE NDDENUM = {ExtractNDDENUM(row)}");
        FrmFicheChantier.Visible = false;

        ds.Tables["DdeS"].Clear();
        daDdes.Fill(ds, "DdeS");
        apiTGridH_SelectionChanged(null, null);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void CmdAllSS_Click(object sender, EventArgs e)
    {
      new frmListeSortiesStockToutesAvecDetFou().ShowDialog();
    }
    
    private void ChkOnlyPlanif_CheckedChanged(object sender, EventArgs e)
    {
      if (ChkOnlyPlanif.Checked) apiTGridH.dgv.ActiveFilterString = "DACTPLA != NULL";
      else apiTGridH.dgv.ActiveFilterString = "";
    }
    

    private string ExtractNDDENUM(DataRow row)
    {
      return Utils.BlankIfNull(row["NDDENUM"]).Substring(2);
    }

    // équivalent VB6 CGESTREAPPROFILIALE
    int numBL_EMALEC;
    int numBL_Filiale;
    int numSTF_Fournisseur;
    int numCom_Filiale;
    int numSS_EMALEC;
    int numaction_cmd_filiale;
    int numSS_Filiale;
    private void Traitement_ReapproTechFilialeOnFiliale(int numBL)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        // on charge les données selon le n° de livraison emalec
        numBL_EMALEC = numBL;
        int res = LoadDataINfoByNBLNUM_EMALEC();
        if (0 != res) return;

        res = CreateReceptionCmdOnSS_EMALEC();
        if (0 != res) return;

        // on créé les lgines du bl
        res = CreateLigneReceptionCmdFilialeWithBL_EMALEC();
        if (0 != res) return;

        // on créer à présent la SS pour le techicien
        res = CreateSS_Filiale_By_NBLNUM_EMALEC();
        if (0 != res) return;

        // on créer le bon expedition
        res = CreateBL_Filiale_By_NDDENUM_Filiale();
        if (0 != res) return;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private int LoadDataINfoByNBLNUM_EMALEC()
    {
      try
      {
        using (SqlCommand cmd = new SqlCommand("api_sp_GetInfoReapproTechByNBLNUM_EMALEC", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);

          cmd.Parameters["@p_nblnum_emalec"].Value = numBL_EMALEC;

          using (SqlDataReader reader = cmd.ExecuteReader())
          {
            if (reader.Read())
            {
              numSTF_Fournisseur = (int)Utils.ZeroIfNull(reader["NSTFNUM"]);
              numCom_Filiale = (int)Utils.ZeroIfNull(reader["NCOMNUM_FILIALE"]);
              numSS_EMALEC = (int)Utils.ZeroIfNull(reader["NDDENUM_EMALEC"]);
              numaction_cmd_filiale = (int)Utils.ZeroIfNull(reader["NACTNUM_FILIALE"]);
              return 0;
            }
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }

      return -1;
    }

    private int CreateReceptionCmdOnSS_EMALEC()
    {
      try
      {
        using (SqlCommand cmd = new SqlCommand("api_sp_CreationReception", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);

          cmd.Parameters["@NumLivr"].Value = 0;
          cmd.Parameters["@FournNum"].Value = numSTF_Fournisseur;
          cmd.Parameters["@CdeNum"].Value = numCom_Filiale;
          cmd.Parameters["@LivrDate"].Value = DateTime.Today;
          cmd.Parameters["@BL"].Value = $"SS{numSS_EMALEC}";
          cmd.Parameters["@Transporteur"].Value = Program.AppTitle;
          cmd.Parameters["@Observ"].Value = "Livraison automatique de reappro tech";
          cmd.Parameters["@LivrNum"].Value = 0;

          cmd.ExecuteNonQuery();

          numBL_Filiale = Convert.ToInt32(cmd.Parameters[0].Value);
          return 0;
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }

      return -1;
    }

    private int CreateLigneReceptionCmdFilialeWithBL_EMALEC()
    {
      try
      {
        using (SqlCommand cmd = new SqlCommand("api_sp_GetListeFournitureBy_NBLNUM", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);

          cmd.Parameters["@p_nblnum"].Value = numBL_EMALEC;

          using (SqlDataReader reader = cmd.ExecuteReader())
          {
            if (reader.Read())
              return CreateLigneReceptionCmdFiliale((int)Utils.ZeroIfNull(reader["NFOUNUM"]), (int)Utils.ZeroIfNull(reader["NBLLQTE"]));
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      return -1;
    }

    private int CreateLigneReceptionCmdFiliale(int nfounum, int nqte)
    {
      try
      {
        using (SqlCommand cmd = new SqlCommand("api_sp_CreationReceptionLigne", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);

          cmd.Parameters["@LivrNum"].Value = numBL_Filiale;
          cmd.Parameters["@FouNum"].Value = nfounum;
          cmd.Parameters["@Commande"].Value = numCom_Filiale;
          cmd.Parameters["@Date"].Value = DateTime.Today;
          cmd.Parameters["@Qte"].Value = nqte;

          cmd.ExecuteNonQuery();

          return 0;
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      return -1;
    }

    private int CreateSS_Filiale_By_NBLNUM_EMALEC()
    {
      try
      {
        if (numBL_EMALEC == 0 || numaction_cmd_filiale == 0) return 0;
        // Enregistrement de la réception
        // Enregistrement des lignes de la réception

        using (SqlCommand cmd = new SqlCommand("Api_sp_CreationSSAndBlCmd_Filiale", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);

          cmd.Parameters["@P_NBLNUM_EMALEC"].Value = numBL_EMALEC;
          cmd.Parameters["@P_NACTNUM_FILIALE"].Value = numaction_cmd_filiale;
          cmd.Parameters["@O_NDDENUM"].Value = 0;

          cmd.ExecuteNonQuery();

          numSS_Filiale = Convert.ToInt32(cmd.Parameters[0].Value);
          return 0;
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }

      return -1;
    }

    private int CreateBL_Filiale_By_NDDENUM_Filiale()
    {
      try
      {
        if (numBL_EMALEC == 0 || numaction_cmd_filiale == 0) return 0;

        using (SqlCommand cmd = new SqlCommand("api_sp_GetListeFournitureBy_NBLNUM", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);

          cmd.Parameters["@DdeNum"].Value = numSS_Filiale;
          cmd.Parameters["@ActNum"].Value = numaction_cmd_filiale;
          cmd.Parameters["@TypeDde"].Value = "REAPRRO";
          cmd.Parameters["@Createur"].Value = "Administrateur";

          cmd.ExecuteNonQuery();

          return 0;
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }

      return -1;
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
      DataRow rowDdes = apiTGridH.GetFocusedDataRow();
      if (null == rowDdes) return;

      string sTypeLivr;
      switch (rowDdes["VDEST"])
      {
        case "Site":
          sTypeLivr = "S";
          break;
        case "Tech":
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
        mstrClient = Utils.BlankIfNull(rowDdes["VCLINOM"]),
        mNumAction = (int)rowDdes["NACTNUM"],
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

