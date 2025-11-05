using MZCtrlResources = MozartControls.Properties.Resources;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using ReportEmalec.Net;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;
using DevExpress.Data.Filtering;
using System.Linq;

namespace MozartCS
{
  public partial class frmListeFactures2 : Form
  {
    private DataTable dt = new DataTable();

    public frmListeFactures2() { InitializeComponent(); }

    private void frmListeFactures2_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        // initialisation des combo
        cbCritClient.Init(MozartDatabase.cnxMozart, ModuleData.GetSqlClause("CLIENT"), "NCLINUM", "VCLINOM", new List<string>() { Resources.col_Num, Resources.col_Nom }, 250, 550, true);
        cbCritChaff.Init(MozartDatabase.cnxMozart, ModuleData.GetSqlClause("CHAFF"), "NPERNUM", "VPERNOM", new List<string>() { Resources.col_Num, Resources.col_Nom }, 150, 550, true);
        cbCritGroupe.Init(MozartDatabase.cnxMozart, ModuleData.GetSqlClause("GROUPE"), "IDGROUPE", "LIBGROUPE", new List<string>() { Resources.col_Num, Resources.col_Nom }, 150, 550, true);

        // Couleurs des boutons
        using (SqlDataReader reader = ModuleData.ExecuteReader("exec api_sp_InfosBoutonsFac"))
        {
          if (reader.Read())
          {
            CmdNoValidCH.BackColor = Utils.ZeroIfNull(reader["CHINOVALID"]) >= 1 ? MozartColors.ColorH80FFFF : MozartColors.ColorH8000000F;
            CmdMessFactST.BackColor = Utils.ZeroIfNull(reader["NEWMESSFAC"]) >= 1 ? MozartColors.ColorH80FFFF : MozartColors.ColorH8000000F;
          }
        }

        apiTGrid.GridControl.DataSource = dt;
        apiTGrid.dgv.OptionsSelection.MultiSelect = true;
        InitTGrid();

        GridView gridView1 = apiTGrid.GridControl.MainView as GridView;
        RepositoryItemComboBox riComboBox = buildRepositoryItemComboBoxInfo();
        gridView1.Columns["VFACINFO"].ColumnEdit = riComboBox;
        apiTGrid.GridControl.RepositoryItems.Add(riComboBox);

        mnuAffichage.Text = Resources.mnu_affichage; 
        mnuAffecterTous.Text = "Passer toutes les lignes à 'OK Réalisé";
        mnuDesaffecter.Text = "Passer toutes les lignes à 'A Réaliser";


      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdFind_Click(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        // Création de la clause SQL à aprtir des critères saisis
        if (cbCritClient.GetItemValue().Length > 0 && cbCritClient.GetItemValue().Length < 3)
        {
          MessageBox.Show("Il faut filtrer avec au moins 3 lettres dans le client", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          cbCritClient.Focus();
          return;
        }
        if (cbCritChaff.GetItemValue().Length > 0 && cbCritChaff.GetItemValue().Length < 3)
        {
          MessageBox.Show("Il faut filtrer avec au moins 3 lettres dans le Chaff", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          cbCritChaff.Focus();
          return;
        }
        if (cbCritGroupe.GetItemValue().Length > 0 && cbCritGroupe.GetItemValue().Length < 6)
        {
          MessageBox.Show("Il faut sélectinner un groupe dans la liste", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          cbCritGroupe.Focus();
          return;
        }

        // on regarde les filtres et si aucun filtre, on affiche un message
        if (txtCritNumFac.Text == "" && txtCritDate0.Text == "" && txtCritDate1.Text == "" && cbCritClient.GetItemValue() == "" &&
            cbCritChaff.GetItemValue() == "" && cbCritGroupe.GetItemValue() == "")
        {
          MessageBox.Show("Il faut saisir au moins 1 critère de filtre", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        StringBuilder sql = new StringBuilder(1000);
        sql.Append("SELECT 'F' + dbo.FormatCle(TFAC.NFACNUM, 7) AS NFACNUM, TFAC.NFACNUM as NUMFAC, VFACINFO, " +
                  " TFAC.DFACDAT, TCLI.VCLINOM, TRSF.VRSFRSF, IsNull(TRSF.VRSFPAYS, '') 'VRSFPAYS', TDIN.NDINCTE, SUM(TELF.NELFTHT) as TOTALHT, " +
                  " TFAC.VFACSTA, TFAC.VFACTYP, TFAC.CFACTRANS, " +
                  " [dbo].[GetTVAIntraClient](TRSF.NRSFNUM, TRSF.VRSFPAYS) as VRSFTVAINTRA, P.VPERNOM 'VDINCHAFF', VRSFCPT8, VRSFLANGUE, " +
                  " Case TELF.NELFTVA WHEN '0' THEN 'EXP' Else 'IMP' END AS IMPEXP , " +
                  " TCLI.VCLITYPEFAC, TCLI.NCLINUM, min(TELF.NELFTVA) as NELFTVA, " +
                  " SUM(TELF.NELFTHT)*(1+TELF.NELFTVA/100) as TOTALTTC, " +
                  " Case CFACTRANSFERTFILIALE WHEN 'N' THEN '' Else 'Transfert automatique vers EMALEC' END AS CFACTRANSFERTFILIALE, " +
                  " (select dfacregt from tfactures f where f.nfacnum = TFAC.NFACNUM and f.nclinum = TCLI.NCLINUM) 'DFACREGT', " +
                  " (select DDATEECH from tfactures f where f.nfacnum = TFAC.NFACNUM and f.nclinum = TCLI.NCLINUM) 'DDATEECH' " +
                  " FROM    TCLI INNER JOIN " +
                  " TRSF ON TCLI.NCLINUM = TRSF.NCLINUM INNER JOIN " +
                  " TFAC ON TRSF.NRSFNUM = TFAC.NRSFNUM INNER JOIN " +
                  " TELF ON TFAC.NELFNUM = TELF.NELFNUM INNER JOIN " +
                  " TDIN ON TELF.NDINNUM = TDIN.NDINNUM LEFT OUTER JOIN " +
                  " TCAN AS C ON C.NCANNUM = TDIN.NDINCTE AND C.NCLINUM = TDIN.NCLINUM LEFT OUTER JOIN " +
                  " TPER AS p ON p.NPERNUM = C.NPERNUM LEFT OUTER JOIN TREF_GROUPE AS G WITH (NOLOCK) ON G.IDGROUPE = p.IDGROUPE ");

        sql.Append($" WHERE TFAC.VSOCIETE = '{MozartParams.NomSociete}' ");

        Int32.TryParse(txtCritNumFac.Text, out int NumFac);
        if (txtCritNumFac.Text != "") sql.Append($" AND NFACNUM ={NumFac}");
        if (txtCritDate0.Text != "") sql.Append($" AND DFACDAT >= '{txtCritDate0.Text}'");
        if (txtCritDate1.Text != "") sql.Append($" AND DFACDAT <= '{txtCritDate1.Text}'");
        if (cbCritClient.GetItemValue() != "") sql.Append($" AND (VCLINOM LIKE '%{cbCritClient.GetItemValue().Replace("'", "''")}%')");
        if (cbCritChaff.GetItemValue() != "")
          sql.Append($" AND (VDINCHAFF IN (select vperadsi from TPER where (VPERNOM LIKE '%{cbCritChaff.GetItemValue().Replace("'", "''")}%') AND VSOCIETE = '{MozartParams.NomSociete}'))");
        if (cbCritGroupe.GetItemValue() != "") sql.Append($" AND (LIBGROUPE LIKE '%{cbCritGroupe.GetItemValue().Replace("'", "''")}%')");

        // Recherche des droits de la personne sur les factures
        sql.Append(RechercheDroitPersonne());


        sql.Append(" GROUP BY TFAC.NFACNUM, TFAC.DFACDAT, TCLI.VCLINOM, TRSF.VRSFRSF, TRSF.VRSFPAYS, TDIN.NDINCTE," +
                    " TFAC.NFACTHTAV, TFAC.VFACSTA, TFAC.VFACTYP, TFAC.CFACTRANS, NELFTVA, VFACINFO," +
                    " TCLI.VCLITYPEFAC , TCLI.NCLINUM, TRSF.NRSFNUM, P.VPERNOM, VRSFCPT8, VRSFLANGUE, CFACTRANSFERTFILIALE" +
                    " ORDER BY NFACNUM DESC");
        Cursor.Current = Cursors.WaitCursor;
        apiTGrid.sSqlDataSource = sql.ToString();
        apiTGrid.Requery(dt, MozartDatabase.cnxMozart);

        // calcul des totaux
        TxtTotFact.Text = CalculTotFac();
      }
      catch (Exception ex) { MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex); }
      finally { Cursor.Current = Cursors.Default; }
    }

    DateTime _curDate = DateTime.MinValue;
    private void cmdDate_Click(object sender, EventArgs e)
    {
      string txtDate = "";
      if ((sender as Button).Name == "cmdDate0")
      {
        txtDate = txtCritDate0.Text;
        Cal.Tag = 0;
      }
      else
      {
        txtDate = txtCritDate1.Text;
        Cal.Tag = 1;
      }
      DateTime d;
      if (DateTime.TryParse(txtDate, out d))
        _curDate = Cal.Value = d;
      else { _curDate = DateTime.MinValue; Cal.Value = DateTime.Now; }
      Cal.Visible = true;
      Cal.ShowCalendar(new MouseEventArgs(MouseButtons.Left, 1, MousePosition.X, MousePosition.Y, 0));
    }
    private void Cal_CloseUp(object sender, EventArgs e)
    {
      Cal.Visible = false;
      if (_curDate == DateTime.MinValue) return;
      if ((int)Cal.Tag == 0) txtCritDate0.Text = Cal.Value.ToShortDateString();
      else if ((int)Cal.Tag == 1) txtCritDate1.Text = Cal.Value.ToShortDateString();
    }
    private void Cal_ValueChanged(object sender, EventArgs e)
    {
      if (Cal.Visible) _curDate = Cal.Value;
    }

    private void frmListeFactures2_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.F2 || e.KeyCode == Keys.Enter)
        cmdFind_Click(null, null);
    }

    private void cmdNouvelle_Click(object sender, EventArgs e)
    {
      new frmNewFacture { strStatutOuverture = "N" }.ShowDialog();
      cmdFind_Click(null, null);
    }

    private void cmdModifier_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow row = apiTGrid.GetFocusedDataRow();
        if (null == row) return;

        // passage des parametres selon si c'est un avoir ou une facture qui est sélectionnée
        if (row["VFACTYP"].ToString() == "F")
        {
          new frmModFacture(Convert.ToInt32(Strings.Mid(row[0].ToString(), 2))).ShowDialog();
        }
        else
        {
          new frmAvoir
          {
            miNumFacture = 0,
            mstrStatutAvoir = "M",
            miNumAvoir = Convert.ToInt32(Strings.Mid(row[0].ToString(), 2)),
            miNumClient = (int)row["NCLINUM"],
            mstrStatutTransfert = row["CFACTRANS"].ToString()
          }.ShowDialog();
        }

        // rafraichissement du recordset
        // peut être pas utile dans tous les cas
        // cela prend du temps
        Cursor.Current = Cursors.WaitCursor;
        cmdFind_Click(null, null);
      }
      catch (Exception ex) { MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex); }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdEditer_Click(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        int[] selItems = apiTGrid.dgv.GetSelectedRows();
        int nb = selItems.Length;
        for (int i = 0; i < nb; i++)
        {
          DataRow row = apiTGrid.dgv.GetDataRow(selItems[i]);
          if (row["VFACTYP"].ToString() == "F")
            ImprimerLesFacturesReports(row);
          else
            ImprimerLesAvoirs(row);
          apiTGrid.dgv.InvertRowSelection(selItems[i]);
        }
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

    private void cmdAvoir_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow row = apiTGrid.GetFocusedDataRow();
        if (null == row) return;
        Cursor.Current = Cursors.WaitCursor;

        // passage des parametres selon si c'est un avoir ou une facture qui est sélectionné
        if (row["VFACTYP"].ToString() == "F")
        {
          // test et message si il y a deja un avoir sur cette facture
          using (SqlDataReader reader = ModuleData.ExecuteReader($"select distinct NFACNUM  from TFAC WHERE VSOCIETE = '{MozartParams.NomSociete}'" +
                                                                  $" AND NFACNUMFACAV = {Convert.ToInt32(Strings.Mid(row[0].ToString(), 3))}"))
          {
            if (reader.Read())
            {
              MessageBox.Show(Resources.msg_Avoir_existe_deja_pour_facture, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            new frmAvoir
            {
              miNumFacture = Convert.ToInt32(Strings.Mid(row[0].ToString(), 3)),
              mstrStatutAvoir = "C",
              miNumAvoir = 0,
              miNumClient = (int)row["NCLINUM"],
              mstrStatutTransfert = ""
            }.ShowDialog();
          }
        }
        else
        {
          new frmAvoir
          {
            miNumFacture = 0,
            mstrStatutAvoir = "M",
            miNumAvoir = Convert.ToInt32(Strings.Mid(row[0].ToString(), 3)),
            miNumClient = (int)row["NCLINUM"],
            mstrStatutTransfert = row["CFACTRANS"].ToString()
          }.ShowDialog();
        }
      }
      catch (Exception ex) { MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex); }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void CmdPDF_Click(object sender, EventArgs e)
    {
      //  '******************************************************************************************************************
      //  'Générer les factures en pdf
      //  '******************************************************************************************************************
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        int[] selItems = apiTGrid.dgv.GetSelectedRows();
        if (selItems.Length == 0)
        {
          MessageBox.Show("Il faut sélectionner une facture", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }
        if (MessageBox.Show("Voulez-vous générer les fichiers pdf des factures sélectionnées ?", Program.AppTitle, MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
        for (int i = 0; i < selItems.Length; i++)
        {
          // Genere les factures
          DataRow row = apiTGrid.dgv.GetDataRow(selItems[i]);
          ImprimerLaFactureEnPDFreport(row);
          apiTGrid.dgv.InvertRowSelection(selItems[i]);
        }
        MessageBox.Show(@"Les fichiers ont été générés dans le répertoire 'Mes documents\Mozart\pdf\'", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      catch (Exception ex) { MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex); }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdMail_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow row = apiTGrid.GetFocusedDataRow();
        if (null == row) return;
        Cursor.Current = Cursors.WaitCursor;

        if (MozartParams.NomGroupe == "EMALEC")
        {
          int[] selItems;
          int NFACNUM_6 = Convert.ToInt32(Strings.Right(row["NFACNUM"].ToString(), 6));
          switch (Convert.ToInt32(row["NCLINUM"]))
          {
            case 18253:
              if (MessageBox.Show("Voulez-vous vraiment envoyer le fichier Excel à JLL XEROX?", Program.AppTitle, MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
              FacturesUtils.GenerateFichierExcelFactureClient(NFACNUM_6, "JLLXEROX", "api_sp_MailFactureXerox");
              FacturesUtils.SendMailFactureClient(NFACNUM_6, "JLLXEROX", $@"{MozartParams.CheminUtilisateurMozart}FactureJLLXEROX{NFACNUM_6}.xls", (DateTime)row["DFACDAT"], MozartParams.UserMail, "");
              break;

            case 17792:
              if (MessageBox.Show("Voulez-vous vraiment envoyer le fichier Excel à MARIONNAUD ?", Program.AppTitle, MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
              FacturesUtils.GenerateFichierExcelFactureClient(NFACNUM_6, "MARIONNAUD", "api_sp_MailFactureMARIONNAUD");
              FacturesUtils.SendMailFactureClient(NFACNUM_6, "MARIONNAUD", $@"{MozartParams.CheminUtilisateurMozart}FactureMARIONNAUD{NFACNUM_6}.xls",
                                                  (DateTime)row["DFACDAT"], MozartParams.UserMail, "FAUDOUARD-LIRON@emalec.com");
              break;

            case 18151:
              if (MessageBox.Show("Voulez-vous vraiment envoyer le fichier Excel à CREDIT COOPERATIF ?", Program.AppTitle, MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
              FacturesUtils.GenerateFichierExcelFactureClient(NFACNUM_6, "CREDIT", "api_sp_MailFactureCREDIT");
              FacturesUtils.SendMailFactureClient(NFACNUM_6, "CREDIT", $@"{MozartParams.CheminUtilisateurMozart}FactureCREDIT{NFACNUM_6}.xls", (DateTime)row["DFACDAT"], MozartParams.UserMail, "");
              break;

            case 12015:
              if (MessageBox.Show("Voulez-vous vraiment envoyer le fichier Excel à MEDIAPOST ?", Program.AppTitle, MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
              FacturesUtils.GenerateFichierExcelFactureClientXLSX(NFACNUM_6, "MEDIAPOST", "api_sp_MailFactureMediapost");
              FacturesUtils.SendMailFactureClient(NFACNUM_6, "MEDIAPOST", $@"{MozartParams.CheminUtilisateurMozart}FactureMEDIAPOST{NFACNUM_6}.xlsx", (DateTime)row["DFACDAT"], MozartParams.UserMail, "");//jpavlikowski@emalec
              break;
            case 11658:
              if (MessageBox.Show("Voulez-vous vraiment envoyer le fichier Excel à REXEL FRANCE ?", Program.AppTitle, MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
              FacturesUtils.GenerateFichierExcelFactureClient(NFACNUM_6, "REXEL", "api_sp_MailFactureRexel");
              FacturesUtils.SendMailFactureClient(NFACNUM_6, "REXEL", $@"{MozartParams.CheminUtilisateurMozart}FactureREXEL{NFACNUM_6}.xls", (DateTime)row["DFACDAT"], "stephanie.hermitte@rexel.fr;laila.bouchachia@rexel.fr", "");
              break;
            case 255:
              if (MessageBox.Show(Resources.msg_envoyer_fichier_excel_KIABI, Program.AppTitle, MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
              FacturesUtils.GenerateFichierExcelFactureClient(NFACNUM_6, "KIABI", "api_sp_MailFactureKIABI");
              FacturesUtils.SendMailFactureClient(NFACNUM_6, "KIABI", $@"{MozartParams.CheminUtilisateurMozart}FactureKIABI{NFACNUM_6}.xls", (DateTime)row["DFACDAT"], "l.carneau@kiabi.com", "fseyer@emalec.com");
              break;
            case 1877:
              if (MessageBox.Show("Voulez-vous vraiment envoyer le fichier Excel à ETAM ?", Program.AppTitle, MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
              FacturesUtils.GenerateFichierExcelFactureClient(NFACNUM_6, "ETAM", "api_sp_MailFactureETAM");
              FacturesUtils.SendMailFactureClient(NFACNUM_6, "ETAM", $@"{MozartParams.CheminUtilisateurMozart}FactureETAM{NFACNUM_6}.xls", (DateTime)row["DFACDAT"], MozartParams.UserMail, "");
              break;
            case 1666:
              if (MessageBox.Show("Voulez-vous vraiment envoyer le fichier Excel à THOMEUROPE ?", Program.AppTitle, MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
              FacturesUtils.GenerateFichierExcelFactureClient(NFACNUM_6, "Thomeurope", "api_sp_MailFactureTHOME");
              FacturesUtils.SendMailFactureClient(NFACNUM_6, "THOMEUROPE", $@"{MozartParams.CheminUtilisateurMozart}FactureThomeurope{NFACNUM_6}.xls", (DateTime)row["DFACDAT"], "mligere@thomeurope.com", "edalbepierre@emalec.com");
              break;
            case 494:
              //          '***********************************************************************************************************************
              //          '
              //          '***********************************************************************************************************************
              if (MessageBox.Show("Voulez-vous vraiment envoyer la(ou les) facture(s) avec leurs attachements à H&M ?", Program.AppTitle, MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;

              selItems = apiTGrid.dgv.GetSelectedRows();
              string sDestMailClient = "dpelletier@emalec.com";
              for (int i = 0; i < selItems.Length; i++)
              {
                DataRow r = apiTGrid.dgv.GetDataRow(selItems[i]);
                if (r["VCLINOM"].ToString() == "H&M")
                {
                  int NumFacTemp = Convert.ToInt32(Strings.Right(r["NFACNUM"].ToString(), 6));
                  string Sujet = $"{Resources.txt_facturation} H & M{Resources.txt_du}{DateTime.Today.ToShortDateString()} - {MozartParams.NomSociete}";
                  string sMsg = $"{Resources.msg_Bonjour}{Environment.NewLine}{Environment.NewLine}" +
                                $"{Resources.msg_Veuillez_trouver_pièce_jointe_facture} {r["NFACNUM"]} {Resources.msg_du_mois} {DateTime.Today.ToShortDateString()},{Environment.NewLine}{Environment.NewLine}" +
                                $"{Resources.msg_fichier_contenant_attachements_facture_PDF}.{Environment.NewLine}{Environment.NewLine}" +
                                $"{Resources.msg_mail_envoyer_adresse_mail_suivante}{sDestMailClient}{Environment.NewLine}{Environment.NewLine}{MozartParams.NomSociete}";

                  string sLstPJFacHM = $@"{MozartParams.CheminUtilisateurMozart}" + ImprimerLaFactureEnPDFreport(r);
                  // On copie la facture pdf dans mes documents pour la gestion de l'envoi par mail
                  File.Copy($@"{MozartParams.CheminUtilisateurMozart}PDF\{NumFacTemp}.pdf",
                            $@"{MozartParams.CheminUtilisateurMozart}{NumFacTemp}.pdf", true);

                  new FrmSendFactureMail(sDestMailClient, Sujet.Replace("|", " "), sMsg.Replace("|", " "), sLstPJFacHM, NumFacTemp, "1",
                                          "", r["VCLINOM"].ToString() + (char)34).ShowDialog();
                  // 19/10/2016 : Nom du fichier (optionnel) et nom du client
                  //  "1" signifie utiliser obligatoirement le stockage sur cloud (pas de mail) ; 0 sinon

                  FacturesUtils.SetFactureEditee(NumFacTemp);
                }
                else
                {
                  MessageBox.Show($"{Resources.msg_La_facture}NumFacTemp {Resources.msg_selection_pas_facture_HM}", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                apiTGrid.dgv.InvertRowSelection(selItems[i]);
              }

              break;

            case 12544:
              // randstad (envoi de la facture et des attachements concaténés dans le même pdf (attention à la taille du fichier !)
              if (MessageBox.Show("Voulez-vous vraiment générer la facture avec ses attachements pour Randstad ?", Program.AppTitle, MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;

              string SujetR = $"{Resources.txt_facturation} RANDSTAD{Resources.txt_du}{DateTime.Today.ToShortDateString()} - {MozartParams.NomSociete}";
              string sMsgR = $"{Resources.msg_Bonjour}{Environment.NewLine}{Environment.NewLine}" +
                            $"Veuillez trouver en pièce jointe la facture {row["NFACNUM"]},{Environment.NewLine}{Environment.NewLine}" +
                            $"Le fichier pdf contient également les attachements de la facture.{ Environment.NewLine}{Environment.NewLine}" +
                            $"{MozartParams.NomSociete}";

              string sLstPJFac = $@"{MozartParams.CheminUtilisateurMozart}" + ImprimerLaFactureEnPDFreport(row);
              // On copie la facture pdf dans mes documents pour la gestion de l'envoi par mail
              File.Copy($@"{MozartParams.CheminUtilisateurMozart}PDF\{NFACNUM_6}.pdf",
                        $@"{MozartParams.CheminUtilisateurMozart}{NFACNUM_6}.pdf", true);

              new FrmSendFactureMail("pbuisson@emalec.com;cfournier@emalec.com", SujetR.Replace(" | ", " "), sMsgR.Replace("|", " "), sLstPJFac, NFACNUM_6, "0",
                                      $"{NFACNUM_6}", row["VCLINOM"].ToString()).ShowDialog();
              //  "1" signifie utiliser obligatoirement le stockage sur cloud (pas de mail) ; 0 si envoi par mail (avec test de la taille)

              FacturesUtils.SetFactureEditee(NFACNUM_6);

              break;

            case 13241:
              //          '***********************************************************************************************************************
              //          ' Weldom 19/10/2016
              //          '***********************************************************************************************************************
              if (MessageBox.Show("Voulez-vous vraiment envoyer la(ou les) facture(s) avec leurs attachements à Weldom ?", Program.AppTitle, MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
              selItems = apiTGrid.dgv.GetSelectedRows();
              string sDestMailClientW = "aziz.el-badaoui@weldom.com;safia.bsaissa@weldom.com"; // dpelletier@emalec.com
              for (int i = 0; i < selItems.Length; i++)
              {
                DataRow r = apiTGrid.dgv.GetDataRow(selItems[i]);
                if (r["VCLINOM"].ToString() == "WELDOM")
                {
                  int NumFacTemp = Convert.ToInt32(Strings.Right(r["NFACNUM"].ToString(), 6));
                  // Recherche du nom du site
                  string vsitnom;
                  using (SqlDataReader reader = ModuleData.ExecuteReader($"select tsit.vsitnom from tfac inner join telf on tfac.nelfnum = telf.nelfnum inner join tact on telf.nelfnum = tact.nelfnum inner join tsit on tsit.nsitnum = tact.nsitnum where nfacnum = {NumFacTemp}"))
                  {
                    if (!reader.Read())
                    {
                      MessageBox.Show("Bug : Pas de site associé à la facture... Voir l'informatique...", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                      return;
                    }
                    vsitnom = Utils.BlankIfNull(reader["VSITNOM"]);
                  }

                  string SujetW = $"Facturation WELDOM {vsitnom}{Resources.txt_du}{DateTime.Today.ToShortDateString()} - {MozartParams.NomSociete}";
                  string sMsgW = $"{Resources.msg_Bonjour}{Environment.NewLine}{Environment.NewLine}" +
                                $"Veuillez trouver en pièce jointe la facture  {r["NFACNUM"]} {Resources.msg_du_mois} {DateTime.Today.ToShortDateString()}, pour le site de {vsitnom}{Environment.NewLine}.{Environment.NewLine}" +
                                $"Le fichier contient également les attachements de la facture sous format PDF.{Environment.NewLine}{Environment.NewLine}{MozartParams.NomSociete}";

                  string sLstPJFacW = $@"{MozartParams.CheminUtilisateurMozart}" + ImprimerLaFactureEnPDFreport(r);
                  // On copie la facture pdf dans mes documents pour la gestion de l'envoi par mail
                  File.Copy($@"{MozartParams.CheminUtilisateurMozart}PDF\{NumFacTemp}.pdf",
                            $@"{MozartParams.CheminUtilisateurMozart}{NumFacTemp}.pdf", true);

                  new FrmSendFactureMail(sDestMailClientW, SujetW.Replace("|", " "), sMsgW.Replace("|", " "), sDestMailClientW, NumFacTemp, "0",
                                          $"{NumFacTemp}-{vsitnom.Replace(" ", "-")}", r["VCLINOM"].ToString() + (char)34).ShowDialog();
                  //  "0" signifie utiliser obligatoirement l'envoi par mail (1 pour le Cloud)

                  FacturesUtils.SetFactureEditee(NumFacTemp);
                }
                else
                {
                  MessageBox.Show($"{Resources.msg_La_facture}NumFacTemp {Resources.msg_selection_pas_facture_client}", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                apiTGrid.dgv.InvertRowSelection(selItems[i]);
              }
              break;

            case 4031:
              //        '******************************************************************************************************************
              //        'Mail ARGEDIS : Envoi mensuel des factures Fournitures et Prestations + Récap. Détails en EXCEL.      '
              string sStrFileOutDetailOnlyUser = $"RecapARGEDIS_Synthese_{DateTime.Today.ToString("MMyyyy")}";
              if (MessageBox.Show(Resources.msg_envoyer_facture_Excel_Client + " ARGEDIS ?", Program.AppTitle, MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
              // copie du fichier modele dans mes doc pour onlyuser
              File.Copy($@"{MozartParams.CheminModeles}FR\RecapARGEDISOnlyUser.xls", $@"{MozartParams.CheminUtilisateurMozart}{sStrFileOutDetailOnlyUser}.xls", true);

              FacturesUtils.iNbLinesFacLOIRETAL = 3;
              FacturesUtils.iNbLinesARGEDISOnlyUser = 0;
              string sLstPJFacARGEDIS = "";
              string sLstNumFact = "";

              ModuleMain.EndAllEXCELProcess();

              // gestion multi sélection : factures fourniture et prestations pour client ARGEDIS
              selItems = apiTGrid.dgv.GetSelectedRows();
              for (int i = 0; i < selItems.Length; i++)
              {
                DataRow r = apiTGrid.dgv.GetDataRow(selItems[i]);
                if (r["VCLINOM"].ToString() == "ARGEDIS")
                {
                  // init des variables lignes pour le fichier EXCEL (=> membres de la classe)
                  FacturesUtils.iNbLinesARGEDIS = 0;
                  FacturesUtils.iNbLinesLOIRETAL = 0;
                  FacturesUtils.iNbLinesFacARGEDIS = 3;

                  string sStrFileOutDetail = $"RecapARGEDIS_{r["NFACNUM"]}_{DateTime.Today.ToString("MMyyyy")}";
                  // copie du fichier modele dans mes doc
                  File.Copy($@"{MozartParams.CheminModeles}FR\RecapARGEDIS.xls", $@"{MozartParams.CheminUtilisateurMozart}{sStrFileOutDetail}.xls", true);
                  Thread.Sleep(1000);

                  int NumFacTemp = Convert.ToInt32(Strings.Right(r["NFACNUM"].ToString(), 6));

                  // génere le fichier pour la compta recap EXCEL
                  FacturesUtils.GenerateFichierExcelFactureClientARGEDIS(sStrFileOutDetail + ".xls", NumFacTemp);

                  // genere le fichier pour sicard
                  FacturesUtils.GenerateFichierExcelFactureClientARGEDISPOnlyUser(sStrFileOutDetailOnlyUser + ".xls", NumFacTemp);

                  sLstPJFacARGEDIS = $@"{sLstPJFacARGEDIS}{(sLstPJFacARGEDIS == "" ? "" : ";")}{MozartParams.CheminUtilisateurMozart}{sStrFileOutDetail}.xls";

                  // Genère la facture en pdf et l'ajoute dans la liste
                  sLstPJFacARGEDIS = sLstPJFacARGEDIS + (sLstPJFacARGEDIS == "" ? "" : ";") + $@"{ MozartParams.CheminUtilisateurMozart}" + ImprimerLaFactureEnPDFreport(r);
                  // On copie la facture pdf dans mes documents pour la gestion de l'envoi par mail
                  File.Copy($@"{MozartParams.CheminUtilisateurMozart}PDF\{NumFacTemp}.pdf", $@"{MozartParams.CheminUtilisateurMozart}{NumFacTemp}.pdf", true);

                  sLstNumFact = $"{sLstNumFact}{(sLstNumFact == "" ? NumFacTemp.ToString() : ",")}{NumFacTemp}";
                  Thread.Sleep(100);
                }
                else
                {
                  MessageBox.Show($"{Resources.msg_La_facture}NumFacTemp {Resources.msg_selection_pas_facture_ARGEDIS}", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                apiTGrid.dgv.InvertRowSelection(selItems[i]);
              }

              // mise à jour de liste des fichiers à joindre
              sLstPJFacARGEDIS = $@"{sLstPJFacARGEDIS}{(sLstPJFacARGEDIS == "" ? "" : ";")}{MozartParams.CheminUtilisateurMozart}{sStrFileOutDetailOnlyUser}.xls";

              // saisie de la date concernant le mois de facturation
              string dDateTemp = Interaction.InputBox(Resources.msg_saisir_mois_annee_facturation);
              if (dDateTemp == "") return;

              // Envoi du mail contenant la liste des fichiers à envoyer
              FacturesUtils.SendMailFactureWithPJ(sLstNumFact, sLstPJFacARGEDIS, dDateTemp, "ARGEDIS");// Format(Month(Date), "00") & "/" & Year(Date)

              // on passe les factures en editee
              if (sLstNumFact != "")
              {
                ModuleData.ExecuteNonQuery($"update TFAC set VFACSTA = 'OUI', DFACEDI = getdate() where VSOCIETE = '{MozartParams.NomSociete}' AND NFACNUM IN({sLstNumFact})");
                ModuleData.ExecuteNonQuery($"update TELF set VELFSTA = 'Edité' where NELFNUM in (select distinct NELFNUM from TFAC where VSOCIETE = '{MozartParams.NomSociete}' AND NFACNUM IN({sLstNumFact}))");
              }
              break;

            case 19750:
              //        '******************************************************************************************************************
              //        'Mail France Mutualiste : Envoi mensuel des factures 
              if (MessageBox.Show(Resources.msg_envoyer_facture_Excel_Client + " LA FRANCE MUTUALISTE ?", Program.AppTitle, MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;

              string sLstPJFacFM = "";
              string sListNumFact = "";

              ModuleMain.EndAllEXCELProcess();

              // gestion multi sélection : factures fourniture et prestations pour client Mutualiste
              selItems = apiTGrid.dgv.GetSelectedRows();
              for (int i = 0; i < selItems.Length; i++)
              {
                DataRow r = apiTGrid.dgv.GetDataRow(selItems[i]);
                if (r["VCLINOM"].ToString() == "LA FRANCE MUTUALISTE")
                {
                  // init des variables lignes pour le fichier EXCEL (=> membres de la classe)
                  FacturesUtils.iNbLinesFacARGEDIS = 3;

                  string sStrFileOutDetail = $"RecapLFMUTUALISTE_{r["NFACNUM"]}_{DateTime.Today.ToString("MMyyyy")}";
                  // copie du fichier modele dans mes doc
                  File.Copy($@"{MozartParams.CheminModeles}FR\RecapLFMUTUALISTE.xls", $@"{MozartParams.CheminUtilisateurMozart}{sStrFileOutDetail}.xls", true);
                  Thread.Sleep(1000);

                  int NumFacTemp = Convert.ToInt32(Strings.Right(r["NFACNUM"].ToString(), 6));

                  // génere le fichier pour la compta recap EXCEL
                  FacturesUtils.GenerateFichierExcelFactureClientLAFRANCEMUTUALISTE(sStrFileOutDetail + ".xls", NumFacTemp);

                  sLstPJFacFM = $@"{sLstPJFacFM}{(sLstPJFacFM == "" ? "" : ";")}{MozartParams.CheminUtilisateurMozart}{sStrFileOutDetail}.xls";

                  // Genère la facture en pdf et l'ajoute dans la liste
                  sLstPJFacFM = sLstPJFacFM + (sLstPJFacFM == "" ? "" : ";") + $@"{ MozartParams.CheminUtilisateurMozart}" + ImprimerLaFactureEnPDFreport(r);
                  // On copie la facture pdf dans mes documents pour la gestion de l'envoi par mail
                  File.Copy($@"{MozartParams.CheminUtilisateurMozart}PDF\{NumFacTemp}.pdf", $@"{MozartParams.CheminUtilisateurMozart}{NumFacTemp}.pdf", true);

                  sLstNumFact = $"{sListNumFact}{(sListNumFact == "" ? NumFacTemp.ToString() : ",")}{NumFacTemp}";
                  Thread.Sleep(100);
                }
                else
                {
                  MessageBox.Show($"{Resources.msg_La_facture} NumFacTemp {Resources.msg_selection_pas_facture_client} LA FRANCE MUTUALISTE", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                apiTGrid.dgv.InvertRowSelection(selItems[i]);
              }

              // saisie de la date concernant le mois de facturation
              string dDateTemp1 = Interaction.InputBox(Resources.msg_saisir_mois_annee_facturation);
              if (dDateTemp1 == "") return;

              // Envoi du mail contenant la liste des fichiers à envoyer
              FacturesUtils.SendMailFactureWithPJ(sListNumFact, sLstPJFacFM, dDateTemp1, "LA FRANCE MUTUALISTE");// Format(Month(Date), "00") & "/" & Year(Date)

              // on passe les factures en editee
              if (sListNumFact != "")
              {
                ModuleData.ExecuteNonQuery($"update TFAC set VFACSTA = 'OUI', DFACEDI = getdate() where VSOCIETE = '{MozartParams.NomSociete}' AND NFACNUM IN({sListNumFact})");
                ModuleData.ExecuteNonQuery($"update TELF set VELFSTA = 'Edité' where NELFNUM in (select distinct NELFNUM from TFAC where VSOCIETE = '{MozartParams.NomSociete}' AND NFACNUM IN({sListNumFact}))");
              }
              break;

            //case 908:
            //  //          '***********************************************************************************************************************
            //  //          'IDGROUP FRANCE
            //  //          '***********************************************************************************************************************
            //  if (MessageBox.Show("Voulez-vous vraiment envoyer la(ou les) facture(s) avec leurs attachements à IDGROUP FRANCE?", Program.AppTitle, MessageBoxButtons.YesNo,
            //                      MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
            //  string sLstPJFacIDG = "";
            //  selItems = apiTGrid.dgv.GetSelectedRows();
            //  for (int i = 0; i < selItems.Length; i++)
            //  {
            //    DataRow r = apiTGrid.dgv.GetDataRow(selItems[i]);
            //    if (r["VCLINOM"].ToString() == "IDGROUP FRANCE")
            //    {
            //      int nFacNum = Convert.ToInt32(Strings.Mid(r["NFACNUM"].ToString(), 2));

            //      new frmMainReport
            //      {
            //        bLaunchByProcessStart = false,
            //        sTypeReport = "TFactureClient",
            //        sIdentifiant = $"{nFacNum}|{r["VCLITYPEFAC"]}",
            //        InfosMail = $"TCLI|NCLINUM|{r["NCLINUM"]}",
            //        sNomSociete = MozartParams.NomSociete,
            //        sLangue = r["VRSFLANGUE"].ToString(),
            //        sOption = "PDF"
            //      }.ShowDialog();

            //      sDestMailClient = "";
            //      string Sujet = "", sMsg = "";

            //      sLstPJFacIDG = $@"{MozartParams.CheminUtilisateurMozart}" + ImprimerLaFactureEnPDFreport(r);
            //      // On copie la facture pdf dans mes documents pour la gestion de l'envoi par mail
            //      File.Copy($@"{MozartParams.CheminUtilisateurMozart}PDF\{NFACNUM_6}.pdf",
            //                $@"{MozartParams.CheminUtilisateurMozart}{NFACNUM_6}.pdf", true);

            //      new FrmSendFactureMail(sDestMailClient, Sujet.Replace("|", " "), sMsg.Replace("|", " "), sLstPJFacIDG, Strings.Right(r["NFACNUM"].ToString(), 6), "1",
            //                              "", r["VCLINOM"].ToString() + (char)34).ShowDialog();
            //      // 19/10/2016 : Nom du fichier (optionnel) et nom du client
            //      // ' "1" signifie utiliser obligatoirement le stockage sur cloud (pas de mail) ; 0 sinon

            //      FacturesUtils.SetFactureEditee(nFacNum);
            //    }
            //    else
            //    {
            //      MessageBox.Show($"{Resources.msg_La_facture}{Strings.Right(r["NFACNUM"].ToString(), 6)} {Resources.msg_selection_pas_facture_IDGROUP}", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //    apiTGrid.dgv.InvertRowSelection(selItems[i]);
            //  }
            //  break;

            default:
              if (MozartParams.NomSociete == "EMALECESPAGNE")
              {
                //          '******************************************************************************************************************
                //          'Générer un fichier en pdf des factures   '
                //          '******************************************************************************************************************
                selItems = apiTGrid.dgv.GetSelectedRows();
                for (int i = 0; i < selItems.Length; i++)
                {
                  DataRow r = apiTGrid.dgv.GetDataRow(selItems[i]);
                  // Genere les factures
                  ImprimerLaFactureEnPDFreport(r);
                  apiTGrid.dgv.InvertRowSelection(selItems[i]);
                }
              }
              else
              {
                MessageBox.Show(Resources.msg_fonction_pas_definie_pour_client, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
              }
              break;
          }
          //  TB SAMSIC CITY TODO -> Else pour Samsic
        }
      }
      catch (Exception ex) { MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex); }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void CmdNoValidCH_Click(object sender, EventArgs e)
    {
      new frmListeValidChif().ShowDialog();
    }

    void ImprimerLesFacturesReports(DataRow row)
    {
      int NumFac = Convert.ToInt32(Strings.Mid(row["NFACNUM"].ToString(), 2));

      FacturesUtils.EditionFacture("PRINT", NumFac, row);

      // mise a jour du flag d'impression
      FacturesUtils.SetFactureEditee(NumFac);

      // attestation si tva 10% et si montant > 300  FG le 04/04/22 (ajout d'une gestion avec un bouton
      //if (Utils.ZeroIfNull(row["TOTALHT"]) > 300 && Utils.ZeroIfNull(row["NELFTVA"]) == 10)
      FacturesUtils.ImprimerAttestation_TVA_5_5(NumFac, (int)row["NCLINUM"]);
    }

    void ImprimerLesAvoirs(DataRow row)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        int NumFac = Convert.ToInt32(Strings.Mid(row["NFACNUM"].ToString(), 2));

        FacturesUtils.EditionFacture("PRINT", NumFac, row);

        // mise a jour du flag d'impression
        FacturesUtils.SetFactureEditee(NumFac);
      }
      catch (Exception ex) { MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex); }
      finally { Cursor.Current = Cursors.Default; }
    }

    void InitTGrid()
    {
      apiTGrid.AddColumn("Num", "NFACNUM", 1000);
      apiTGrid.AddColumn(Resources.col_Date, "DFACDAT", 1200, "dd/mm/yy");
      apiTGrid.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 2800);
      apiTGrid.AddColumn(Resources.col_Raison_sociale, "VRSFRSF", 3000);
      apiTGrid.AddColumn(Resources.col_cte, "NDINCTE", 600);
      apiTGrid.AddColumn("CHAFF", "VDINCHAFF", 1600);
      apiTGrid.AddColumn(Resources.col_Montant_THT, "TOTALHT", 1800, "Currency", 1);
      apiTGrid.AddColumn(Resources.col_TTC, "TOTALTTC", 1800, "Currency", 1);
      apiTGrid.AddColumn("TVA", "NELFTVA", 700, "0.##", 2);
      apiTGrid.AddColumn("TVA intra", "VRSFTVAINTRA", 1500, "", 2);
      apiTGrid.AddColumn(Resources.col_Editee, "VFACSTA", 800, "", 2);
      apiTGrid.AddColumn(Resources.col_FactAvoir, "VFACTYP", 1000, "", 2);
      apiTGrid.AddColumn("Compte", "VRSFCPT8", 1500, " ", 2);
      apiTGrid.AddColumn("Pays", "VRSFPAYS", 1500, "", 2);
      apiTGrid.AddColumn("Echéance", "DDATEECH", 1200, "dd/mm/yy", 2);
      apiTGrid.AddColumn("Règlement", "DFACREGT", 1200, "dd/mm/yy", 2);
      apiTGrid.AddColumn(Resources.col_Transfert, "CFACTRANS", 1200, "", 2);
      apiTGrid.AddColumn("Info", "VFACINFO", 1000);
      apiTGrid.AddColumn(Resources.col_Import_export, "IMPEXP", 0);
      apiTGrid.AddColumn(Resources.col_typefac, "VCLITYPEFAC", 0);
      apiTGrid.AddColumn("CliNum", "NCLINUM", 0);
      // colonne plus utilisée
      //if (MozartParams.NomSociete != "EMALEC")
      //  apiTGrid.AddColumn("trf Emalec", "CFACTRANSFERTFILIALE", 2500, "", 2);

      apiTGrid.InitColumnList();

      apiTGrid.DelockColumn("VFACINFO");
    }

    private void apiTGrid_RowCellStyle(object sender, RowCellStyleEventArgs e)
    {
      if (e.RowHandle <= 0) return;
      if (e.Column.Name == "VFACINFO") return;
      if ((sender as GridView).GetDataRow(e.RowHandle)["VFACTYP"].ToString() == "A")
        e.Appearance.BackColor = MozartColors.colorHC0C0FF;
    }

    private void txtCritNumFac_Enter(object sender, EventArgs e)
    {
      txtCritNumFac.SelectionStart = 0;
      txtCritNumFac.SelectionLength = 100;
    }

    //private void txtCritDate_Enter(object sender, EventArgs e)
    //{
    //  if ((sender as apiTextBox).Name == "txtCritDate0")
    //  {
    //    txtCritDate0.SelectionStart = 0;
    //    txtCritDate0.SelectionLength = 100;
    //  }
    //  else
    //  {
    //    txtCritDate1.SelectionStart = 0;
    //    txtCritDate1.SelectionLength = 100;
    //  }
    //}

    private string ImprimerLaFactureEnPDFreport(DataRow row)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        int NumFac = Convert.ToInt32(Strings.Mid(row["NFACNUM"].ToString(), 2));

        FacturesUtils.EditionFacture("PDF", NumFac, row);

        return NumFac + ".pdf";
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally
      {
        Cursor.Current = Cursors.Default;
      }

      return "";
    }

    private void cmdSTTFact_Click(object sender, EventArgs e)
    {
      new frmListeFactSTTRecu().ShowDialog();
    }

    private void CmdMessFactST_Click(object sender, EventArgs e)
    {
      new frmListeMessagesWebSTT().ShowDialog();
    }

    private void cmdTest_Click(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        // requête qui controle si une facture n'est pas sur deux clients différent
        using (SqlDataReader reader = ModuleData.ExecuteReader($"exec api_sp_ControleDesfactures"))
        {
          StringBuilder msg = new StringBuilder(1000);
          while (reader.Read())
          {
            switch (Utils.ZeroIfNull(reader[2]))
            {
              case 1:
                msg.Append($"La facture suivante est sur deux clients differents : {reader[0]}{Environment.NewLine}");
                break;
              case 2:
                msg.Append($"La facture suivante est en doublon : {reader[0]}({reader[1]}){Environment.NewLine}");
                break;
              case 3:
                msg.Append($"La facture suivante est FRANCE sans TVA : {reader[0]}{ Environment.NewLine}");
                break;
              case 4:
                msg.Append($"La facture suivante est EXPORT avec TVA : {reader[0]}{Environment.NewLine}");
                break;
              case 5:
                msg.Append($"L'action de la facture suivante est encore en statut 'Chiffré'.Prevenez l'informatique. : {reader[0]}({reader[1]}){Environment.NewLine}");
                break;
              case 6:
                msg.Append($"La facture suivante est sur deux comptes analytiques differents: {reader[0]}{Environment.NewLine}");
                break;
            }
          }
          if (msg.ToString() == "") msg.Append("Pas de facture en erreur ! ");

          MessageBox.Show(msg.ToString(), Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

      }
      catch (Exception ex) { MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex); }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void CmdPrintFacETR_Click(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        DataRow row = apiTGrid.GetFocusedDataRow();
        if (null == row) return;
        int NumFac = Convert.ToInt32(Strings.Mid(row["NFACNUM"].ToString(), 2));
        if (row["VFACTYP"].ToString() == "F")
          new frmMainReport
          {
            bLaunchByProcessStart = false,
            sTypeReport = PrepareReport.TFACTURECLIENTETR,
            sIdentifiant = $"{NumFac}|{row["VCLITYPEFAC"]}",
            InfosMail = $"TCLI|NCLINUM|{row["NCLINUM"]}",
            sNomSociete = MozartParams.NomSociete,
            sLangue = row["VRSFLANGUE"].ToString(),
            sOption = "PREVIEW"
          }.ShowDialog();
        else
          //c'est un avoir        
          new frmMainReport
          {
            bLaunchByProcessStart = false,
            sTypeReport = PrepareReport.TAVOIRCLIENTETR,
            sIdentifiant = NumFac.ToString(),
            InfosMail = $"TCLI|NCLINUM|{row["NCLINUM"]}",
            sNomSociete = MozartParams.NomSociete,
            sLangue = row["VRSFLANGUE"].ToString(),
            sOption = "PREVIEW"
          }.ShowDialog();


      }
      catch (Exception ex) { MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex); }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdEdite_Click(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        DataRow row = apiTGrid.GetFocusedDataRow();
        if (null == row) return;

        int NumFac = Convert.ToInt32(row["NUMFAC"].ToString());
        // mise a jour du flag d'impression
        FacturesUtils.SetFactureEditee(NumFac);
      }
      catch (Exception ex) { MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex); }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void apiTGrid_ColumnFilterChanged(object sender, EventArgs e)
    {
      // calcul des totaux
      TxtTotFact.Text = CalculTotFac();
    }

    string CalculTotFac()
    {
      decimal iMnttTot = 0;
      decimal iMnttTotFiltre = 0;
      // on calcul la somme avant filtre
      foreach (DataRow row in dt.Rows)
        iMnttTot += (decimal)row["TOTALHT"];
      // on applique le filtre
      for (int i = 0; i < apiTGrid.dgv.RowCount; i++)
        iMnttTotFiltre += (decimal)apiTGrid.dgv.GetDataRow(i)["TOTALHT"];
      return iMnttTotFiltre.ToString("C") + " / " + iMnttTot.ToString("C");
    }

    private void CmdEditionAttach_Click(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        int[] selItems = apiTGrid.dgv.GetSelectedRows();
        for (int i = 0; i < selItems.Length; i++)
        {
          DataRow r = apiTGrid.dgv.GetDataRow(selItems[i]);
          new FrmEditionAttachementByFacture(Convert.ToInt32(r["NUMFAC"].ToString())).ShowDialog();
          apiTGrid.dgv.InvertRowSelection(selItems[i]);
        }
      }
      catch (Exception ex) { MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex); }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdVisu_Click(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        DataRow row = apiTGrid.GetFocusedDataRow();
        if (null == row) return;

        int NumFac = Convert.ToInt32(row["NUMFAC"].ToString());

        FacturesUtils.EditionFacture("PREVIEW", NumFac, row);
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

    string RechercheDroitPersonne()
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        // test et message si il y a deja un avoir sur cette facture
        using (SqlDataReader reader = ModuleData.ExecuteReader("exec api_sp_GetDroitUtilisateurSurListeFacture"))
        {
          if (reader.Read())
          {
            switch (Utils.BlankIfNull(reader["DROIT"]))
            {
              case "F": return $" AND C.NPERNUMFAC ={MozartParams.UID}";
              case "T": return "";
              case "G": return $" AND G.IDGROUPE ={Utils.BlankIfNull(reader["GROUPE"])}";

            }
          }
        }
      }
      catch (Exception ex) { MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex); }
      finally { Cursor.Current = Cursors.Default; }
      return "";
    }

    private void cmdAct_Click(object sender, EventArgs e)
    {
      new frmListeActionAValider().ShowDialog();
    }

    private void apiButton1_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid.GetFocusedDataRow();
      if (null == row) return;

      int NumFac = Convert.ToInt32(Strings.Mid(row["NFACNUM"].ToString(), 2));

      if (MozartParams.NomSociete == "EMALECFACILITEAM")
      {
        FacturesUtils.ImprimerFichierWord($@"{MozartParams.CheminModeles}{MozartParams.Langue}\TATTESTATION_TVA_6_BELGIQUE.rtf");
      }
      else

        new frmMainReport
        {
          bLaunchByProcessStart = false,
          sTypeReport = "TAttestation_TVA_10",
          sIdentifiant = NumFac.ToString(),
          InfosMail = "TCLI|NCLINUM|000",
          sNomSociete = MozartParams.NomSociete,
          sLangue = "FR",
          sOption = "PREVIEW"
        }.ShowDialog();
    }

    private void cmdNumCde_Click(object sender, EventArgs e)
    {
      // recherche du num de commande sur la facture
      DataRow row = apiTGrid.GetFocusedDataRow();
      if (null == row) return;

      int NumFac = Convert.ToInt32(row["NUMFAC"].ToString());
      string Cde = (string)ModuleData.ExecuteScalarString($"Select VFACNUMCDE from TFAC where NFACNUM = {NumFac}");
      txtNumCde.Text = Cde;
      frameNumCde.Visible = true;
    }

    private void cmdAnnulerNumCde_Click(object sender, EventArgs e)
    {
      txtNumCde.Text = "";
      frameNumCde.Visible = false;
    }

    private void cmdValiderNumCde_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid.GetFocusedDataRow();
      if (null == row) return;

      int NumFac = Convert.ToInt32(row["NUMFAC"].ToString());
      ModuleData.ExecuteNonQuery($"UPDATE TFAC SET VFACNUMCDE = '{txtNumCde.Text}' where NFACNUM = {NumFac}");
      txtNumCde.Text = "";
      frameNumCde.Visible = false;
    }

    private void apiTGrid_RowCellClick(object sender, RowCellClickEventArgs e)
    {
      if (e.Button != MouseButtons.Right) return;

      if (e.Column.Name == "VFACINFO")
      {
        mnuAffichage.Show(Cursor.Position);
      }
    }

    private RepositoryItemComboBox buildRepositoryItemComboBoxInfo()
    {
      RepositoryItemComboBox riComboBox = new RepositoryItemComboBox();
      riComboBox.Items.Add("A Réaliser");
      riComboBox.Items.Add("OK Réalisé");
      riComboBox.TextEditStyle = TextEditStyles.DisableTextEditor;

      return riComboBox;
    }

		private void mnuAffecterTous_Click(object sender, EventArgs e)
		{
      DataRow currentRow = apiTGrid.GetFocusedDataRow();
      if (apiTGrid.GetFocusedDataRow() == null || currentRow == null) return;

      IList<int> lListeIDs = dt.Select(CriteriaToWhereClauseHelper.GetDataSetWhere(apiTGrid.dgv.ActiveFilterCriteria)).ToList().Select(item => Convert.ToInt32(item["NUMFAC"])).ToList();
      if (lListeIDs.Count == 0) return;

      string sSQL = $"UPDATE TFAC SET VFACINFO='OK Réalisé' WHERE NFACNUM IN ({string.Join(",", lListeIDs)}) AND VSOCIETE = '{MozartParams.NomSociete}'";
      ModuleData.CnxExecute(sSQL);

      apiTGrid.Requery(dt, MozartDatabase.cnxMozart);
    }

		private void mnuDesaffecter_Click(object sender, EventArgs e)
		{
      DataRow currentRow = apiTGrid.GetFocusedDataRow();
      if (apiTGrid.GetFocusedDataRow() == null || currentRow == null) return;

      IList<int> lListeIDs = dt.Select(CriteriaToWhereClauseHelper.GetDataSetWhere(apiTGrid.dgv.ActiveFilterCriteria)).ToList().Select(item => Convert.ToInt32(item["NUMFAC"])).ToList();
      if (lListeIDs.Count == 0) return;

      string sSQL = $"UPDATE TFAC SET VFACINFO='A Réaliser' WHERE NFACNUM IN ({string.Join(",", lListeIDs)}) AND VSOCIETE = '{MozartParams.NomSociete}'";
      ModuleData.CnxExecute(sSQL);

      apiTGrid.Requery(dt, MozartDatabase.cnxMozart);
    }

		private void apiTGrid_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
		{

      DataRow pRow = apiTGrid.GetFocusedDataRow();
      if (apiTGrid.GetFocusedDataRow() == null || pRow == null) return;

      string  sSQL = $"UPDATE TFAC SET {e.Column.Name}='{e.Value}' WHERE NFACNUM = {pRow["NUMFAC"]} AND VSOCIETE = '{MozartParams.NomSociete}'";
      ModuleData.CnxExecute(sSQL);

      apiTGrid.Requery(dt, MozartDatabase.cnxMozart);
    }

  }
}
