using Microsoft.Office.Interop.Word;
using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmChoixDestMail : Form
  {

    public string msInfosMail = "";
    public string mstrType;
    public List<string> mstrListeFilePJ = new List<string>();

    public string msBrowserUrl = "";

    private string snFile = "";
    private string sListeDest = "";
    private string mstrCheminUtilisateurMozart;

    public frmChoixDestMail()
    {
      InitializeComponent();
    }

    private void frmChoixDestMail_Load(object sender, EventArgs e)
    {
      string[] tInfos;
      System.Data.DataTable dt = new System.Data.DataTable();
      DataRow row;
      DataRow rsInfo;
      Microsoft.Office.Interop.Word.Application wdApp;
      string[] tAux = null;

      long NCLINUM = 0;
      string VSITENSEIGNE = "";
      string sPays = "";
      string[] tabMsgBodySubject;

      Cursor.Current = Cursors.WaitCursor;

      // Uniquement pour la lisibilité du code
      mstrCheminUtilisateurMozart = MozartParams.CheminUtilisateurMozart;

      try
      {
        if (msInfosMail != "")
          RemplirListeDestinataires(msInfosMail);

        // INIT
        // France par défaut
        sPays = "FRANCE";
        tabMsgBodySubject = null;

        AffichagegestPJ(false);
        AffichagegestChkbox(false);

        lstPJ.Items.Clear();

        txtSujet.Text = txtSujet.Text + MozartParams.NomSociete;
        txtMessage.Text = Resources.msg_click_here;

        // -------------------------------------------------------------------------------------------------------------------------------------------------

        // traitement du sujet
        if (msInfosMail != "")
        {
          tInfos = msInfosMail.Split('|');

          // on recupere le pays selon le type
          sPays = ModuleData.ExecuteScalarString("exec api_sp_GetPaysDestMailByType '" + tInfos[0] + "', '" + tInfos[1] + "', " + tInfos[2]);

          if (tInfos[0] == "TCCL")
          {
            // recherche du site et du numéro de devis et de l'adresse mail du site
            ModuleData.LoadData(dt, "Select TCSIT.VCSITMAI AS VSITMAI, TSIT.VSITPAYS from TACT WITH (NOLOCK),TSIT WITH (NOLOCK), TCSIT WITH (NOLOCK) WHERE TACT.NSITNUM=TSIT.NSITNUM AND TCSIT.NSITNUM = TSIT.NSITNUM "
                          + " AND TCSIT.NTYPCSITNUM = 1  AND TACT.NACTNUM =" + MozartParams.NumAction);
            if (dt.Rows.Count != 0)
            {
              row = dt.Rows[0];
              if (row["VSITMAI"].ToString() != "")
                lstDest.Items.Add(row["VSITMAI"] + " (Site)");
              sPays = row["VSITPAYS"].ToString();
            }
            dt.Dispose();
          }

          if (tInfos[0] == "TCLI")
          {
            // recherche des contacts client
            ModuleData.LoadData(dt, "Select VCCLMAIL from TCCL WHERE CCCLACTIF = 'O' AND VCCLMAIL IS NOT NULL AND VCCLMAIL <> '' AND NCLINUM = " + tInfos[2]);
            foreach (DataRow rowM in dt.Rows)
            {
              if (rowM["VCCLMAIL"].ToString() != "")
                lstDest.Items.Add(rowM["VCCLMAIL"] + " (Contact client)");
            }

            // recuperation pays
            sPays = ModuleData.ExecuteScalarString("select VCLIPAYS from TCLI WHERE NCLINUM = " + tInfos[2]);
          }

          if (tInfos[0] == "TWDEVIS")
          {
            tAux = mstrType.Split('$');
            // recherche du mail de la personne connecté
            lstDest.Items.Add(tAux[1] + " (Technicien)");
            ModuleData.LoadData(dt, "select NPERNUM, VPERMAILPRO from TPER WITH (NOLOCK) WHERE NPERNUM = " + MozartParams.UID);
            foreach (DataRow rowM in dt.Rows)
            {
              if (rowM["VPERMAILPRO"].ToString() != "")
                lstDest.Items.Add(rowM["VPERMAILPRO"] + " (Chaff)");
            }
            dt.Dispose();
          }

          if (tInfos[0] == "TCSIT")
          {
            ModuleData.LoadData(dt, "exec [api_sp_ChoixDestMail] '" + tInfos[0] + "'," + tInfos[2]);
            foreach (DataRow rowM in dt.Rows)
            {
              if (rowM["MAIL"].ToString() != "")
                lstDest.Items.Add(rowM["MAIL"] + " (" + rowM["LIB"] + ")");
            }
            dt.Dispose();
          }
        }

        // ----------------------------------------------------------------------------------------------------------------------------------------------------

        // INIT
        if (mstrType.Length >= 2)
        {
          string str2 = mstrType.Substring(0, 2);

          if (str2 == "OM")
          {
            ModuleData.LoadData(dt, "SELECT TACT.NDINNUM, VSITNOM, NOMNUM, TSIT.NSITNUM, TSIT.NSITNUE FROM TOM WITH (NOLOCK), TACT WITH (NOLOCK), TSIT WITH (NOLOCK) "
                       + "WHERE TOM.NACTNUM = TACT.NACTNUM And TACT.NSITNUM = TSIT.NSITNUM And TOM.NOMNUM = " + mstrType.Substring(2, mstrType.Length - 2));

            if (dt.Rows.Count > 0)
            {
              rsInfo = dt.Rows[0];
              tabMsgBodySubject = GetMailModeleByTypeAndLang("OM", sPays);

              // CORPS
              tabMsgBodySubject[0] = tabMsgBodySubject[0].Replace("#NDINNUM#", Utils.BlankIfNull(rsInfo["NDINNUM"]));
              tabMsgBodySubject[0] = tabMsgBodySubject[0].Replace("#VSITNOM#", Utils.BlankIfNull(rsInfo["VSITNOM"]));
              tabMsgBodySubject[0] = tabMsgBodySubject[0].Replace("#NOMNUM#", Utils.BlankIfNull(rsInfo["NOMNUM"]));
              tabMsgBodySubject[0] = tabMsgBodySubject[0].Replace("#NSITNUE#", Utils.BlankIfNull(rsInfo["NSITNUE"]));

              // SUJET
              tabMsgBodySubject[1] = tabMsgBodySubject[1].Replace("#VSITNOM#", Utils.BlankIfNull(rsInfo["VSITNOM"]));
              tabMsgBodySubject[1] = tabMsgBodySubject[1].Replace("#VSOCIETE#", MozartParams.NomSociete);
              tabMsgBodySubject[1] = tabMsgBodySubject[1].Replace("#NSITNUE#", Utils.BlankIfNull(rsInfo["NSITNUE"]));
            }
            else
            {  // PAR DEFAUT
              tabMsgBodySubject = GetMailModeleByTypeAndLang("DEFAULT", sPays);
              tabMsgBodySubject[1] = tabMsgBodySubject[1].Replace("#VSOCIETE#", MozartParams.NomSociete);
            }
            dt.Dispose();

            // final
            txtMessage.Text = tabMsgBodySubject[0].Replace("#VSOCIETE#", (MozartParams.NomSociete == "EMALECESPAGNE" ? "EMALEC IBERICA SL" : MozartParams.NomSociete));
            txtSujet.Text = tabMsgBodySubject[1].Replace("#VSOCIETE#", (MozartParams.NomSociete == "EMALECESPAGNE" ? "EMALEC IBERICA SL" : MozartParams.NomSociete));
          }
          else if (str2 == "OG")
          {
            if (mstrType.Length >= 3 && mstrType.Substring(0, 3) == "OGS")
              ModuleData.LoadData(dt, "SELECT TACT.NDINNUM, VSITNOM, NOGNUM, TSIT.NSITNUM, TSIT.NSITNUE FROM TOGS WITH (NOLOCK), TACT WITH (NOLOCK), TSIT WITH (NOLOCK) "
                     + "WHERE TOGS.NACTNUM = TACT.NACTNUM And TACT.NSITNUM = TSIT.NSITNUM And TOGS.NOGNUM = " + mstrType.Substring(3, mstrType.Length - 3));
            else
              ModuleData.LoadData(dt, "SELECT TACT.NDINNUM, VSITNOM, NOGNUM, TSIT.NSITNUM, TSIT.NSITNUE FROM TOG WITH (NOLOCK), TACT WITH (NOLOCK), TSIT WITH (NOLOCK) "
                     + "WHERE TOG.NACTNUM = TACT.NACTNUM And TACT.NSITNUM = TSIT.NSITNUM And TOG.NOGNUM = " + mstrType.Substring(2, mstrType.Length - 2));

            if (dt.Rows.Count > 0)
            {
              rsInfo = dt.Rows[0];
              if (mstrType.Length >= 3 && mstrType.Substring(0, 3) == "OGS")
                tabMsgBodySubject = GetMailModeleByTypeAndLang("OGS", sPays);
              else
                tabMsgBodySubject = GetMailModeleByTypeAndLang("OG", sPays);

              // CORPS
              tabMsgBodySubject[0] = tabMsgBodySubject[0].Replace("#NDINNUM#", Utils.BlankIfNull(rsInfo["NDINNUM"]));
              tabMsgBodySubject[0] = tabMsgBodySubject[0].Replace("#VSITNOM#", Utils.BlankIfNull(rsInfo["VSITNOM"]));
              tabMsgBodySubject[0] = tabMsgBodySubject[0].Replace("#NOGNUM#", Utils.BlankIfNull(rsInfo["NOGNUM"]));
              tabMsgBodySubject[0] = tabMsgBodySubject[0].Replace("#NSITNUE#", Utils.BlankIfNull(rsInfo["NSITNUE"]));

              // SUJET
              tabMsgBodySubject[1] = tabMsgBodySubject[1].Replace("#VSITNOM#", Utils.BlankIfNull(rsInfo["VSITNOM"]));
              tabMsgBodySubject[1] = tabMsgBodySubject[1].Replace("#VSOCIETE#", MozartParams.NomSociete);
              tabMsgBodySubject[1] = tabMsgBodySubject[1].Replace("#NSITNUE#", Utils.BlankIfNull(rsInfo["NSITNUE"]));
            }
            else
            { // PAR DEFAUT
              tabMsgBodySubject = GetMailModeleByTypeAndLang("DEFAULT", sPays);
              tabMsgBodySubject[1] = tabMsgBodySubject[1].Replace("#VSOCIETE#", MozartParams.NomSociete);
            }
            dt.Dispose();

            // final
            txtMessage.Text = tabMsgBodySubject[0].Replace("#VSOCIETE#", (MozartParams.NomSociete == "EMALECESPAGNE" ? "EMALEC IBERICA SL" : MozartParams.NomSociete));
            txtSujet.Text = tabMsgBodySubject[1].Replace("#VSOCIETE#", (MozartParams.NomSociete == "EMALECESPAGNE" ? "EMALEC IBERICA SL" : MozartParams.NomSociete));
          }
          else if (str2 == "DS")
          {
            AffichagegestPJ(true);

            ModuleData.LoadData(dt, "SELECT TACT.NDINNUM, VSITNOM, NDSTNUM FROM TDST WITH (NOLOCK), TACT WITH (NOLOCK), TSIT WITH (NOLOCK) " + " WHERE TDST.NACTNUM = TACT.NACTNUM And TACT.NSITNUM = TSIT.NSITNUM And TDST.NDSTNUM = " + mstrType.Substring(2, mstrType.Length - 2));

            if (dt.Rows.Count > 0)
            {
              rsInfo = dt.Rows[0];
              tabMsgBodySubject = GetMailModeleByTypeAndLang("DS", sPays);

              // CORPS
              tabMsgBodySubject[0] = tabMsgBodySubject[0].Replace("#NDINNUM#", Utils.BlankIfNull(rsInfo["NDINNUM"]));
              tabMsgBodySubject[0] = tabMsgBodySubject[0].Replace("#VSITNOM#", Utils.BlankIfNull(rsInfo["VSITNOM"]));
              tabMsgBodySubject[0] = tabMsgBodySubject[0].Replace("#NDSTNUM#", Utils.BlankIfNull(rsInfo["NDSTNUM"]));

              // SUJET
              tabMsgBodySubject[1] = tabMsgBodySubject[1].Replace("#VSITNOM#", Utils.BlankIfNull(rsInfo["VSITNOM"]));
              tabMsgBodySubject[1] = tabMsgBodySubject[1].Replace("#VSOCIETE#", MozartParams.NomSociete);
            }
            else
            {
              // PAR DEFAUT
              tabMsgBodySubject = GetMailModeleByTypeAndLang("DEFAULT", sPays);

              // SUJET
              tabMsgBodySubject[1] = tabMsgBodySubject[1].Replace("#VSOCIETE#", MozartParams.NomSociete);
            }
            dt.Dispose();

            // final
            txtMessage.Text = tabMsgBodySubject[0].Replace("#VSOCIETE#", (MozartParams.NomSociete == "EMALECESPAGNE" ? "EMALEC IBERICA SL" : MozartParams.NomSociete));
            txtSujet.Text = tabMsgBodySubject[1].Replace("#VSOCIETE#", (MozartParams.NomSociete == "EMALECESPAGNE" ? "EMALEC IBERICA SL" : MozartParams.NomSociete));
          }
          else if (str2 == "CF")
          {

            // affichage des elements pieces jointes
            AffichagegestPJ(true);

            ModuleData.LoadData(dt, "SELECT TACT.NDINNUM, VSITNOM, NCOMNUM FROM TCOM WITH (NOLOCK), TACT WITH (NOLOCK), TSIT WITH (NOLOCK) "
                       + "WHERE TCOM.NACTNUM = TACT.NACTNUM And TACT.NSITNUM = TSIT.NSITNUM And TCOM.NCOMNUM = " + mstrType.Substring(2, mstrType.Length - 2));

            if (dt.Rows.Count > 0)
            {
              rsInfo = dt.Rows[0];

              tabMsgBodySubject = GetMailModeleByTypeAndLang("CF", sPays);

              // CORPS
              tabMsgBodySubject[0] = tabMsgBodySubject[0].Replace("#NDINNUM#", Utils.BlankIfNull(rsInfo["NDINNUM"]));
              tabMsgBodySubject[0] = tabMsgBodySubject[0].Replace("#NCOMNUM#", Utils.BlankIfNull(rsInfo["NCOMNUM"]));

              // SUJET
              tabMsgBodySubject[1] = tabMsgBodySubject[1].Replace("#VSITNOM#", Utils.BlankIfNull(rsInfo["VSITNOM"]));
              tabMsgBodySubject[1] = tabMsgBodySubject[1].Replace("#VSOCIETE#", MozartParams.NomSociete);
            }
            else
            { // PAR DEFAUT
              tabMsgBodySubject = GetMailModeleByTypeAndLang("DEFAULT", sPays);
              tabMsgBodySubject[1] = tabMsgBodySubject[1].Replace("#VSOCIETE#", MozartParams.NomSociete);
            }
            dt.Dispose();

            // final
            txtMessage.Text = tabMsgBodySubject[0].Replace("#VSOCIETE#", (MozartParams.NomSociete == "EMALECESPAGNE" ? "EMALEC IBERICA SL" : MozartParams.NomSociete));
            txtSujet.Text = tabMsgBodySubject[1].Replace("#VSOCIETE#", (MozartParams.NomSociete == "EMALECESPAGNE" ? "EMALEC IBERICA SL" : MozartParams.NomSociete));
          }
          else if (str2 == "DC")
          {
            // affichage des elements pieces jointes
            AffichagegestPJ(true);
            AffichagegestChkbox(true);

            string lRequete = "SELECT TACT.NDINNUM, VSITNOM, NDCLNUM, VSITVIL, NSITNUE, TREF_TYPECONTRAT.VTYPECONTRAT, TSIT.VSITENSEIGNE, TACT.VACTNUMCDE, ";
            lRequete += "TACTCOMP.VACTNUMGMAO, dbo.[GetActionTitle](TACT.NACTNUM) AS VACTDES, TDIN.NCLINUM, TDCL.NDCLHT ";
            lRequete += "FROM TDCL, TACT, TACTCOMP, TDIN, TSIT, TREF_TYPECONTRAT ";
            lRequete += "WHERE TDCL.NACTNUM = TACT.NACTNUM AND TACT.NDINNUM = TDIN.NDINNUM AND TACT.NSITNUM = TSIT.NSITNUM AND TREF_TYPECONTRAT.NTYPECONTRAT = TDIN.NTYPECONTRAT ";
            lRequete += $"AND TACTCOMP.NACTNUM = TACT.NACTNUM And TREF_TYPECONTRAT.LANGUE = '{MozartParams.Langue}' ";
            lRequete += $"AND TDCL.NDCLNUM = {mstrType.Substring(2, mstrType.Length - 2)}";
            ModuleData.LoadData(dt, lRequete);

            if (dt.Rows.Count > 0)
            {
              rsInfo = dt.Rows[0];

              NCLINUM = Convert.ToInt32(rsInfo["NCLINUM"]);
              VSITENSEIGNE = rsInfo["VSITENSEIGNE"].ToString();
              // TB SAMSIC CITY SPEC
              if (Convert.ToInt32(rsInfo["NCLINUM"]) == 13965 & MozartParams.NomGroupe == "EMALEC")
                tabMsgBodySubject = GetMailModeleByTypeAndLang("DC", sPays, Convert.ToInt32(rsInfo["NCLINUM"]));
              else
                tabMsgBodySubject = GetMailModeleByTypeAndLang("DC", sPays);

              // CORPS
              tabMsgBodySubject[0] = tabMsgBodySubject[0].Replace("#NDINNUM#", Utils.BlankIfNull(rsInfo["NDINNUM"]));
              tabMsgBodySubject[0] = tabMsgBodySubject[0].Replace("#NDCLNUM#", Utils.BlankIfNull(rsInfo["NDCLNUM"]));

              tabMsgBodySubject[0] = tabMsgBodySubject[0].Replace("#VSOCIETE#", MozartParams.NomSociete);
              tabMsgBodySubject[0] = tabMsgBodySubject[0].Replace("#VACTDES#", Utils.BlankIfNull(rsInfo["VACTDES"]));
              tabMsgBodySubject[0] = tabMsgBodySubject[0].Replace("#MAIL_RESPONSE#", MozartParams.UserMail);
              tabMsgBodySubject[0] = tabMsgBodySubject[0].Replace("#VSITNOM#", Utils.BlankIfNull(rsInfo["VSITNOM"]));
              tabMsgBodySubject[0] = tabMsgBodySubject[0].Replace("#NSITNUE#", Utils.BlankIfNull(rsInfo["NSITNUE"]));

              tabMsgBodySubject[0] = tabMsgBodySubject[0].Replace("#NDCLHT#", Utils.BlankIfNull(rsInfo["NDCLHT"]));

              if (Strings.InStr(1, tabMsgBodySubject[0], "#VACTNUMGMAO#", Constants.vbTextCompare) != 0)
                tabMsgBodySubject[0] = tabMsgBodySubject[0].Replace("#VACTNUMGMAO#", Utils.BlankIfNull(rsInfo["VACTNUMGMAO"]));

              // SUJET
              tabMsgBodySubject[1] = tabMsgBodySubject[1].Replace("#VSITENSEIGNE#", Utils.BlankIfNull(rsInfo["VSITENSEIGNE"]));
              tabMsgBodySubject[1] = tabMsgBodySubject[1].Replace("#VSITNOM#", Utils.BlankIfNull(rsInfo["VSITNOM"]));
              tabMsgBodySubject[1] = tabMsgBodySubject[1].Replace("#VSITVIL#", Utils.BlankIfNull(rsInfo["VSITVIL"]));
              tabMsgBodySubject[1] = tabMsgBodySubject[1].Replace("#NSITNUE#", Utils.BlankIfNull(rsInfo["NSITNUE"]));
              tabMsgBodySubject[1] = tabMsgBodySubject[1].Replace("#VTYPECONTRAT#", Utils.BlankIfNull(rsInfo["VTYPECONTRAT"]));
              tabMsgBodySubject[1] = tabMsgBodySubject[1].Replace("#VACTNUMCDE#", Utils.BlankIfNull(rsInfo["VACTNUMCDE"]));
              tabMsgBodySubject[1] = tabMsgBodySubject[1].Replace("#VACTNUMGMAO#", Utils.BlankIfNull(rsInfo["VACTNUMGMAO"]));
            }
            else
            { // PAR DEFAUT
              tabMsgBodySubject = GetMailModeleByTypeAndLang("DEFAULT", sPays);
              tabMsgBodySubject[1] = tabMsgBodySubject[1].Replace("#VSOCIETE#", MozartParams.NomSociete);
            }
            dt.Dispose();

            // final
            txtMessage.Text = tabMsgBodySubject[0].Replace("#VSOCIETE#", (MozartParams.NomSociete == "EMALECESPAGNE" ? "EMALEC IBERICA SL" : MozartParams.NomSociete));
            txtSujet.Text = tabMsgBodySubject[1].Replace("#VSOCIETE#", (MozartParams.NomSociete == "EMALECESPAGNE" ? "EMALEC IBERICA SL" : MozartParams.NomSociete));
          }
          else if (str2 == "CO")
          {
            ModuleData.LoadData(dt, "SELECT  VCOURTYPDEST, VSITNOM, VSITENSEIGNE, TACT.NDINNUM FROM TCOUR WITH (NOLOCK), TACT WITH (NOLOCK), TSIT WITH (NOLOCK) "
                 + "WHERE TCOUR.NACTNUM = TACT.NACTNUM AND TACT.NSITNUM = TSIT.NSITNUM "
                 + " AND TCOUR.NCOURNUM= " + Strings.Right(mstrType, mstrType.Length - 2));

            if (dt.Rows.Count > 0)
            {
              rsInfo = dt.Rows[0];
              if (rsInfo["VCOURTYPDEST"].ToString() == "Client" || rsInfo["VCOURTYPDEST"].ToString() == "Site")
              {
                tabMsgBodySubject = GetMailModeleByTypeAndLang("CO_CLI_SIT", sPays);

                // CORPS
                tabMsgBodySubject[0] = tabMsgBodySubject[0].Replace("#NCOURNUM#", Strings.Right(mstrType, mstrType.Length - 2));


                // SUJET
                tabMsgBodySubject[1] = tabMsgBodySubject[1].Replace("#VSITENSEIGNE#", Utils.BlankIfNull(rsInfo["VSITENSEIGNE"]));
                tabMsgBodySubject[1] = tabMsgBodySubject[1].Replace("#VSITNOM#", Utils.BlankIfNull(rsInfo["VSITNOM"]));
                tabMsgBodySubject[1] = tabMsgBodySubject[1].Replace("#NDINNUM#", Utils.BlankIfNull(rsInfo["NDINNUM"]));
              }
              else
              {
                tabMsgBodySubject = GetMailModeleByTypeAndLang("CO", sPays);

                // CORPS
                tabMsgBodySubject[0] = tabMsgBodySubject[0].Replace("#NCOURNUM#", Strings.Right(mstrType, mstrType.Length - 2));

                // SUJET
                tabMsgBodySubject[1] = tabMsgBodySubject[1].Replace("#VSOCIETE#", MozartParams.NomSociete);
                tabMsgBodySubject[1] = tabMsgBodySubject[1].Replace("#VSITNOM#", Utils.BlankIfNull(rsInfo["VSITNOM"]));
              }
            }
            else
            { // PAR DEFAUT
              tabMsgBodySubject = GetMailModeleByTypeAndLang("DEFAULT", sPays);
              tabMsgBodySubject[1] = tabMsgBodySubject[1].Replace("#VSOCIETE#", MozartParams.NomSociete);
            }

            // final
            txtMessage.Text = tabMsgBodySubject[0].Replace("#VSOCIETE#", (MozartParams.NomSociete == "EMALECESPAGNE" ? "EMALEC IBERICA SL" : MozartParams.NomSociete));
            txtSujet.Text = tabMsgBodySubject[1].Replace("#VSOCIETE#", (MozartParams.NomSociete == "EMALECESPAGNE" ? "EMALEC IBERICA SL" : MozartParams.NomSociete));
          }
          else if (str2 == "CX")
          {
            ModuleData.LoadData(dt, "SELECT  VSITNOM, VSITENSEIGNE, TACT.NDINNUM FROM TCOUR WITH (NOLOCK), TACT WITH (NOLOCK), TSIT WITH (NOLOCK) "
                 + "WHERE TCOUR.NACTNUM = TACT.NACTNUM AND TACT.NSITNUM = TSIT.NSITNUM "
                 + "AND VCOURTYPDEST in ('Client','Site') AND TCOUR.NCOURID= " + Strings.Right(mstrType, mstrType.Length - 2));

            if (dt.Rows.Count > 0)
            {
              rsInfo = dt.Rows[0];

              tabMsgBodySubject = GetMailModeleByTypeAndLang("CX_WITH_SUJET", sPays);

              // CORPS
              tabMsgBodySubject[0] = tabMsgBodySubject[0].Replace("#NCOURNUM#", Strings.Right(mstrType, mstrType.Length - 2));

              // SUJET
              tabMsgBodySubject[1] = tabMsgBodySubject[1].Replace("#VSITENSEIGNE#", Utils.BlankIfNull(rsInfo["VSITENSEIGNE"]));
              tabMsgBodySubject[1] = tabMsgBodySubject[1].Replace("#VSITNOM#", Utils.BlankIfNull(rsInfo["VSITNOM"]));
              tabMsgBodySubject[1] = tabMsgBodySubject[1].Replace("#NDINNUM#", Utils.BlankIfNull(rsInfo["NDINNUM"]));
            }
            else
            {
              tabMsgBodySubject = GetMailModeleByTypeAndLang("CX_WITHOUT_SUJET", sPays);
              // CORPS
              tabMsgBodySubject[0] = tabMsgBodySubject[0].Replace("#NCOURNUM#", mstrType.Substring(2, mstrType.Length - 2));
              // SUJET
              tabMsgBodySubject[1] = tabMsgBodySubject[1].Replace("#VSOCIETE#", MozartParams.NomSociete);
            }

            // final
            txtMessage.Text = tabMsgBodySubject[0].Replace("#VSOCIETE#", (MozartParams.NomSociete == "EMALECESPAGNE" ? "EMALEC IBERICA SL" : MozartParams.NomSociete));
            txtSujet.Text = tabMsgBodySubject[1].Replace("#VSOCIETE#", (MozartParams.NomSociete == "EMALECESPAGNE" ? "EMALEC IBERICA SL" : MozartParams.NomSociete));
          }
          else if (mstrType.Length >= 3 && mstrType.Substring(0, 3) == "TEC")
          {
            tabMsgBodySubject = GetMailModeleByTypeAndLang("TEC", sPays);
            // CORPS
            tabMsgBodySubject[0] = tabMsgBodySubject[0].Replace("#VCLINOM#", tAux[2]);
            tabMsgBodySubject[0] = tabMsgBodySubject[0].Replace("#VSITNOM#", tAux[3]);
            // SUJET
            tabMsgBodySubject[1] = tabMsgBodySubject[1].Replace("#VSOCIETE#", MozartParams.NomSociete);

            // final
            txtMessage.Text = tabMsgBodySubject[0].Replace("#VSOCIETE#", (MozartParams.NomSociete == "EMALECESPAGNE" ? "EMALEC IBERICA SL" : MozartParams.NomSociete));
            txtSujet.Text = tabMsgBodySubject[1].Replace("#VSOCIETE#", (MozartParams.NomSociete == "EMALECESPAGNE" ? "EMALEC IBERICA SL" : MozartParams.NomSociete));
          }
          else if (mstrType.Length >= 3 && mstrType.Substring(0, 3) == "ATT")
          {
            ModuleData.LoadData(dt, "SELECT  VSITNOM, NSITNUE, VSITENSEIGNE, VCOURREF, VSITENSEIGNE + ', ' + VSITAD1 + ', ' +  VSITCP + ', ' + VSITVIL as SITE "
                 + "FROM TCOUR WITH (NOLOCK), TACT WITH (NOLOCK), TSIT WITH (NOLOCK) WHERE TCOUR.NACTNUM = TACT.NACTNUM AND TACT.NSITNUM = TSIT.NSITNUM "
                 + "AND TCOUR.NCOURNUM= " + Strings.Right(mstrType, mstrType.Length - 4));

            if (dt.Rows.Count > 0)
            {
              rsInfo = dt.Rows[0];

              tabMsgBodySubject = GetMailModeleByTypeAndLang("ATT_EXIST", sPays);

              // CORPS
              tabMsgBodySubject[0] = tabMsgBodySubject[0].Replace("#VCOURREF#", Utils.BlankIfNull(rsInfo["VCOURREF"]));
              tabMsgBodySubject[0] = tabMsgBodySubject[0].Replace("#SITE#", Utils.BlankIfNull(rsInfo["SITE"]));

              // SUJET
              tabMsgBodySubject[1] = tabMsgBodySubject[1].Replace("#VSITENSEIGNE#", Utils.BlankIfNull(rsInfo["VSITENSEIGNE"]));
              tabMsgBodySubject[1] = tabMsgBodySubject[1].Replace("#VSITNOM#", Utils.BlankIfNull(rsInfo["VSITNOM"]));
              tabMsgBodySubject[1] = tabMsgBodySubject[1].Replace("#NSITNUE#", Utils.BlankIfNull(rsInfo["NSITNUE"]));
            }
            else
            {
              rsInfo = dt.Rows[0];
              tabMsgBodySubject = GetMailModeleByTypeAndLang("ATT_NOT_EXIST", sPays);
              // SUJET
              tabMsgBodySubject[1] = tabMsgBodySubject[1].Replace("#VSITENSEIGNE#", Utils.BlankIfNull(rsInfo["VSITENSEIGNE"]));
              tabMsgBodySubject[1] = tabMsgBodySubject[1].Replace("#VSITNOM#", Utils.BlankIfNull(rsInfo["VSITNOM"]));
              tabMsgBodySubject[1] = tabMsgBodySubject[1].Replace("#NSITNUE#", Utils.BlankIfNull(rsInfo["NSITNUE"]));
            }
            dt.Dispose();

            // final
            txtMessage.Text = tabMsgBodySubject[0].Replace("#VSOCIETE#", (MozartParams.NomSociete == "EMALECESPAGNE" ? "EMALEC IBERICA SL" : MozartParams.NomSociete));
            txtSujet.Text = tabMsgBodySubject[1].Replace("#VSOCIETE#", (MozartParams.NomSociete == "EMALECESPAGNE" ? "EMALEC IBERICA SL" : MozartParams.NomSociete));
          }
        }
        else
        { // PAR DEFAUT
          tabMsgBodySubject = GetMailModeleByTypeAndLang("DEFAULT", sPays);

          // final
          txtMessage.Text = tabMsgBodySubject[0].Replace("#VSOCIETE#", (MozartParams.NomSociete == "EMALECESPAGNE" ? "EMALEC IBERICA SL" : MozartParams.NomSociete));
          txtSujet.Text = tabMsgBodySubject[1].Replace("#VSOCIETE#", (MozartParams.NomSociete == "EMALECESPAGNE" ? "EMALEC IBERICA SL" : MozartParams.NomSociete));
          if (txtSujet.Text == "")
            txtSujet.Text = "Mail d'un document";
        }

        txtMessage.Text += (MozartParams.NomSociete == "EMALECESPAGNE" ? "EMALEC IBERICA SL" : MozartParams.NomSociete);
        snFile = Path.GetFileName(msBrowserUrl.Replace("file://", "").Replace((mstrCheminUtilisateurMozart).Replace("\\", "/"), ""));

        if (Strings.Right(snFile, 3).ToUpper() != "PDF" && Strings.Right(snFile, 3).ToUpper() != "TML")
        {
          if (Strings.Right(snFile, 3).ToUpper() != "RTF")
            snFile = snFile + ".rtf";

          // on copie le fichier pour que pdfcreator le nomme correctement
          // car le word app en cours est un word sous IE
          File.Copy(mstrCheminUtilisateurMozart + snFile, mstrCheminUtilisateurMozart + Strings.Replace(snFile, ".rtf", "Mail.rtf"), true);

          wdApp = new Microsoft.Office.Interop.Word.Application();

          // on teste le N° de version de Word si > 11 alors le word possède l exportation en pdf

          if (int.TryParse(wdApp.Version.Split('.')[0], out int myNum))
          {
            // on utilise le saveasqpdf
            if (Convert.ToInt32(wdApp.Version.Split('.')[0]) > 11 && Strings.Left(mstrType, 2).ToUpper() != "DC")
            {
              Document doc = new Document();
              doc = wdApp.Documents.Open(mstrCheminUtilisateurMozart + snFile.Replace(".rtf", "Mail.rtf"));

              doc.ExportAsFixedFormat(mstrCheminUtilisateurMozart + @"PDF\" + snFile.Replace(".rtf", "Mail.pdf"), WdExportFormat.wdExportFormatPDF,
                                      false, WdExportOptimizeFor.wdExportOptimizeForPrint, WdExportRange.wdExportAllDocument, 1, 1,
                                      WdExportItem.wdExportDocumentContent, true, true, WdExportCreateBookmarks.wdExportCreateNoBookmarks, true, true, false);
              doc.Close();
            }
            else
            {
              Document doc2 = new Document();
              doc2 = wdApp.Documents.Open(mstrCheminUtilisateurMozart + snFile.Replace(".rtf", "Mail.rtf"));

              doc2.ExportAsFixedFormat(mstrCheminUtilisateurMozart + @"PDF\" + snFile.Replace(".rtf", "Mail.pdf"), WdExportFormat.wdExportFormatPDF, false, WdExportOptimizeFor.wdExportOptimizeForPrint, WdExportRange.wdExportAllDocument, 1, 1, WdExportItem.wdExportDocumentContent, true, true, WdExportCreateBookmarks.wdExportCreateNoBookmarks, true, true, false);
              doc2.Close();
            }
          }
          wdApp.Quit();
          wdApp = null  /* Change to default(_) if this is not a reference type */;
        }
        else if (Strings.Right(snFile, 3).ToUpper() != "PDF")
          File.Copy(mstrCheminUtilisateurMozart + snFile, mstrCheminUtilisateurMozart + @"PDF\" + snFile, true);

        // pour XEROX ajout d'un tampon en auto pour les devis : validé par Pierre le 22/01/18 fait par mc
        // TB SAMSIC CITY SPEC
        if (MozartParams.NomGroupe == "EMALEC" && NCLINUM == 13891 && VSITENSEIGNE == "XEROX" && Strings.Left(mstrType, 2) == "DC" && Strings.Right(snFile.Replace(".rtf", "Mail.pdf"), 3).ToUpper() == "PDF")
        {
          frmMail_Devis_Tampon f = new frmMail_Devis_Tampon("frmMail_Devis_Tampon" + " " + "\"" + mstrCheminUtilisateurMozart + @"PDF\" + Strings.Replace(snFile, ".rtf", "Mail.pdf") + "\"");
          f.ShowDialog();

          if (File.Exists(mstrCheminUtilisateurMozart + @"PDF\" + Strings.Replace(Strings.Replace(snFile, ".rtf", "Mail.pdf"), ".pdf", "_Out_Tampon_.pdf")))
            File.Copy(mstrCheminUtilisateurMozart + @"PDF\" + Strings.Replace(Strings.Replace(snFile, ".rtf", "Mail.pdf"), ".pdf", "_Out_Tampon_.pdf"), mstrCheminUtilisateurMozart + @"PDF\" + Strings.Replace(snFile, ".rtf", "Mail.pdf"), true);
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

    private string[] GetMailModeleByTypeAndLang(string p_TypeModele, string p_Pays, long p_NCLINUM = 0)
    {
      SqlDataReader rsLoad = null;
      string[] TabModeleMail = new string[2];
      try
      {
        rsLoad = ModuleData.ExecuteReader(("EXEC api_sp_GetModeleMailByTypeAndLangue \'"
                                         + (p_Pays.Replace("\'", "\'\'") + ("\', \'"
                                         + (p_TypeModele.Replace("\'", "\'\'") + ("\', " + p_NCLINUM))))));

        if (rsLoad.Read())
        {
          TabModeleMail[0] = rsLoad["VEXPRESS_MODELEMAIL"].ToString();
          TabModeleMail[1] = rsLoad["VSUJET_MODELEMAIL"].ToString();
        }
        rsLoad.Close();
      }
      catch (Exception) { }
      finally
      {
        if (rsLoad != null && !rsLoad.IsClosed)
          rsLoad.Close();
      }
      return TabModeleMail;
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      bool bOK = false;
      sListeDest = "";

      foreach (string item in lstDest.CheckedItems)
      {
        bOK = true;
        sListeDest += Strings.Left(item, Strings.InStr(item, "(") - 2) + ";";
      }

      if (txtAdrMail.Text.IndexOf("@") > 0)
      {
        bOK = true;
        sListeDest += txtAdrMail.Text;
      }

      if (!bOK)
        MessageBox.Show(Resources.msg_must_select_one_recipient, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      else
      {
        //  'si devis alors on save les PJ supp dans le tableau des pièces jointes à envoyer
        if (mstrType.StartsWith("DC") || mstrType.StartsWith("CF") || mstrType.StartsWith("CS") || mstrType.StartsWith("DS"))
        {
          foreach (string item in lstPJ.Items)
            mstrListeFilePJ.Add(item);
        }

        SendMailAvecPJ();
        MessageBox.Show(Resources.msg_mail_sent, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        Dispose();
      }
    }

    private void cmdCocher_Click(object sender, EventArgs e)
    {
      //  Cocher toutes les lignes
      for (int i = 0; i <= (lstDest.Items.Count - 1); i++)
      {
        lstDest.SetItemChecked(i, true);
      }

    }

    private void cmdDecocher_Click(object sender, EventArgs e)
    {
      //  Cocher toutes les lignes
      for (int i = 0; i <= (lstDest.Items.Count - 1); i++)
      {
        lstDest.SetItemChecked(i, false);
      }
    }

    private void cmdFermer_Click(object sender, EventArgs e)
    {
      Dispose();
    }

    void RemplirListeDestinataires(string sInfos)
    {
      if ((sInfos == ""))
        return;

      string[] tInfosMail = sInfos.Split('|');
      SqlDataReader mRs = ModuleData.ExecuteReader($"EXEC api_sp_listeDestMailFromTable '{tInfosMail[0]}', '{tInfosMail[1]}', {tInfosMail[2]}");

      while (mRs.Read())
        lstDest.Items.Add(mRs[0]);

      mRs.Close();
    }

    private void SendMailAvecPJ()
    {
      string sPJ = "";
      string sPJ_PP = "";
      string sSql = "";

      string sListePPTitle = "";

      try
      {
        // traitement des pdf dans le repertoire PDF
        if (snFile.ToUpper().EndsWith("PDF") || snFile.ToUpper().EndsWith("TML")
          || MyPrinter.SetDefaultPrinter("PDFCreator") == false)
        {
          sPJ = @"\\" + MozartParams.NomServeur + @"\PJMail\" + snFile;
          File.Copy(mstrCheminUtilisateurMozart + @"PDF\" + snFile, sPJ, true);
        }
        else
        {
          // on envoi le pdf cree a l'ouverture
          Cursor.Current = Cursors.WaitCursor;

          // on attend tant que le fichier n'a pas été créé
          while (File.Exists(mstrCheminUtilisateurMozart + @"PDF\" + snFile.Replace(".rtf", "Mail.pdf")) == false)
          {
            System.Windows.Forms.Application.DoEvents();
            Thread.Sleep(1000);
          }

          // on prepare les fichiers contenu dans la liste des pieces jointes pour l'envoi
          if (mstrListeFilePJ.Count > 0)
          {
            int indexPJ;
            string[] sTabPathExtract;
            string sFileNamePJ = "";

            for (indexPJ = 0; indexPJ < mstrListeFilePJ.Count; indexPJ++)
            {
              sTabPathExtract = Strings.Split(mstrListeFilePJ[indexPJ], @"\");
              if (indexPJ == 0)
                sListePPTitle = " - " + sTabPathExtract[1] + "\n";
              else
                sListePPTitle = sListePPTitle + " - " + sTabPathExtract[1] + "\n";

              sFileNamePJ = sTabPathExtract[0];

              File.Copy(mstrListeFilePJ[indexPJ], @"\\" + MozartParams.NomServeur + @"\PJMail\" + MozartParams.UID + "_" + sFileNamePJ, true);
              sPJ_PP = sPJ_PP + @"\\" + MozartParams.NomServeur + @"\PJMail\" + MozartParams.UID + "_" + sFileNamePJ + ";";
            }
            // affichage message d information selon le type
            switch (Strings.Left(mstrType, 2))
            {
              case "CS":
                MessageBox.Show(Resources.msg_to_be_noted + "\r\n" + sListePPTitle, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                break;
            }
          }

          // copie du fichier pdf dans le repertoire envoi piece jointe
          sPJ = @"\\" + MozartParams.NomServeur + @"\PJMail\" + MozartParams.UID + "_" + Strings.Replace(snFile, ".rtf", "Mail.pdf");
          File.Copy(mstrCheminUtilisateurMozart + @"PDF\" + Strings.Replace(snFile, ".rtf", "Mail.pdf"), sPJ, true);

          // suppression des fichier inutiles
          if (snFile != "t.html")
          {
            try { File.Delete(mstrCheminUtilisateurMozart + Strings.Replace(snFile, ".rtf", "Mail.rtf")); }
            catch (Exception) { }
            try { File.Delete(mstrCheminUtilisateurMozart + @"PDF\" + Strings.Replace(snFile, ".rtf", "Mail.pdf")); }
            catch (Exception) { }
          }

          if (sPJ_PP != "")
            if (sPJ == "")
              sPJ = sPJ_PP + ";";
            else
              sPJ = sPJ + ";" + sPJ_PP;

          // on retire le dernier ;
          if (Strings.Right(sPJ, 1) == ";")
            sPJ = Strings.Left(sPJ, Strings.Len(sPJ) - 1);

          Cursor.Current = Cursors.Default;
        }

        sSql = "EXEC msdb..sp_send_dbmail ";
        sSql += "@profile_name = 'Web" + MozartParams.NomSociete + "', ";
        if ((MozartParams.NomSociete == "EMALEC" || MozartParams.NomSociete == "EMALECIDF") && MozartParams.UserMail.Trim() != "")
          sSql += "@from_address = '" + MozartParams.UserMail.Trim() + "', ";


        sSql += "@recipients   = '" + sListeDest.Trim() + "', ";

        // si devis client, on envoie le mail en copie à l'expéditeur et au chaff du client
        if (Strings.Left(mstrType, 2) == "DC")
          // recherche chaff du client
          sSql += "@copy_recipients   = '" + MozartParams.UserMail.Trim() + ";" + ModuleMain.RechercheChaff(MozartParams.NumDi).Trim() + "', ";
        //  sSql = sSql + "@copy_recipients   = 'fgalotti@emalec.com;fgalotti@emalec.com', ";

        sSql += "@body         = '" + Strings.Replace(txtMessage.Text, "'", "''") + "', ";
        sSql += "@subject      = '" + Strings.Replace(txtSujet.Text, "'", "''") + "', ";
        sSql += "@file_attachments = '" + Strings.Replace(sPJ, "'", "''") + "' ";
        sSql += ", @blind_copy_recipients ='info@emalec.com'";

        ModuleData.CnxExecute(sSql);

        // si devis client, enregistrer l'envoi sur l'observation de l'action
        if (Strings.Left(mstrType, 2) == "DC")
        {
          sSql = "UPDATE TACT set VACTOBS = ' Mail du devis client le " + DateTime.Now.ToString("dd/MM/yy hh:mm") + " par "
                + MozartParams.strUID + " à " + sListeDest.Trim() + ".' + char(13) + char(10) + "
                + "  + coalesce(VACTOBS,'') Where NACTNUM = " + MozartParams.NumAction;
          ModuleData.CnxExecute(sSql);
        }

        if (Strings.Left(mstrType, 2) == "CF")
        {
          sSql = "update TACT set VACTOBS = ' Commande N° " + mstrType + " envoyée par mail à " + sListeDest.Trim() + " le "
               + DateTime.Now.ToString("dd/MM/yy hh:mm") + " par " + MozartParams.strUID + " à  coalesce(VACTOBS,'')  Where NACTNUM = " + MozartParams.NumAction;
          ModuleData.CnxExecute(sSql);
        }

        else if (Strings.Left(mstrType, 2) == "OM")
        {
          sSql = "update TACT set VACTOBS = ' Mail du " + mstrType + " le " + DateTime.Now.ToString("dd/MM/yy hh:mm") + " par " + MozartParams.UID
               + " à " + sListeDest.Trim() + ".' + char(13) + char(10) + coalesce(VACTOBS,'')  Where NACTNUM = " + MozartParams.NumAction;
          ModuleData.CnxExecute(sSql);
        }

        // Si ordre d'intervention en garantie
        else if (Strings.Left(mstrType, 2) == "OG")
        {
          sSql = "update TACT set VACTOBS = ' Mail du " + mstrType + " le " + DateTime.Now.ToString("dd/MM/yy hh:mm") + " par " + MozartParams.UID
               + " à " + sListeDest.Trim() + ".' + char(13) + char(10) + coalesce(VACTOBS,'')  Where NACTNUM = " + MozartParams.NumAction;
          ModuleData.CnxExecute(sSql);
        }

        // demande de devis
        else if (Strings.Left(mstrType, 2) == "DS")
        {
          sSql = "update TACT set VACTOBS = ' Mail du " + mstrType + " le " + DateTime.Now.ToString("dd/MM/yy hh:mm") + " par " + MozartParams.strUID
               + " à " + sListeDest.Trim() + ".' + char(13) + char(10) + coalesce(VACTOBS,'')  Where NACTNUM = " + MozartParams.NumAction;
          ModuleData.CnxExecute(sSql);
        }

        // bordereaux de prix
        else if (Strings.Left(mstrType, 3) == "BPU")
        {
          sSql = "update TACT set VACTOBS = ' Mail du " + mstrType + " le " + DateTime.Now.ToString("dd/MM/yy hh:mm") + " par " + MozartParams.strUID
               + " à " + sListeDest.Trim() + ".' + char(13) + char(10)  + coalesce(VACTOBS,'')  Where NACTNUM = " + MozartParams.NumAction;
          ModuleData.CnxExecute(sSql);
        }

        // courriers
        else if (Strings.Left(mstrType, 2) == "CO" || Strings.Left(mstrType, 2) == "CX")
        {
          sSql = "update TACT set VACTOBS = ' Mail du courrier " + mstrType + " le " + DateTime.Now.ToString("dd/MM/yy hh:mm") + " par " + MozartParams.strUID
               + " à " + sListeDest.Trim() + ".' + char(13) + char(10)  + coalesce(VACTOBS,'')  Where NACTNUM = " + MozartParams.NumAction;
          ModuleData.CnxExecute(sSql);
        }

        // attestation
        else if (Strings.Left(mstrType, 3) == "ATT")
        {
          sSql = "update TACT set VACTOBS = ' Mail Attestation N° " + mstrType + " le " + DateTime.Now.ToString("dd/MM/yy hh:mm") + " par " + MozartParams.strUID
               + " à " + sListeDest.Trim() + ".' + char(13) + char(10)  + coalesce(VACTOBS,'')  Where NACTNUM = " + MozartParams.NumAction;
          ModuleData.CnxExecute(sSql);
        }

        // plan de prevention simplifie
        else if (Strings.Left(mstrType, 3) == "PPS")
        {
          sSql = "update TACT set VACTOBS = ' Mail du " + mstrType + " le " + DateTime.Now.ToString("dd/MM/yy hh:mm") + " par " + MozartParams.strUID
               + " à " + sListeDest.Trim() + ".' + char(13) + char(10) + coalesce(VACTOBS,'')  Where NACTNUM = " + MozartParams.NumAction;
          ModuleData.CnxExecute(sSql);

          // modif statut en cours
          ModuleData.CnxExecute("EXEC [api_sp_UpdateActionNACTPPS] " + MozartParams.NumAction + ", 2");
        }

        // Courrier envoyé depuis RAVEL
        else if (Strings.Left(mstrType, 2) == "DS")
        {
          string[] InfoCourrier = Strings.Split(mstrType, "|");

          sSql = "update TFOUFACCDE set VALERTE = '" + MozartParams.strUID + " le " + DateTime.Now.ToString("dd/MM/yy hh:mm") + " : Envoi du courrier "
            + InfoCourrier[0] + " à " + sListeDest.Trim() + ".' + coalesce(VALERTE,'')  Where NFACCDE = " + InfoCourrier[1];
          ModuleData.CnxExecute(sSql);
        }
      }
      catch (Exception ex)
      {
        Cursor.Current = Cursors.Default;
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void txtboxes_Enter(object sender, EventArgs e)
    {
      TextBox txt = sender as TextBox;
      if (txt.Text.StartsWith("Cliquer"))
        txt.Text = "";
    }

    private void txtAdrMail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
      ModuleMain.FormatMail(txtAdrMail);
    }

    private void cmdAddPJ_Click(object sender, EventArgs e)
    {
      openFileDialog1.FileName = "";
      openFileDialog1.Title = "Ajout pièce jointe";
      openFileDialog1.Filter = "Tous les fichiers (*.*)|*.*";
      openFileDialog1.ShowDialog();

      if (openFileDialog1.FileName == "")
        return;

      //si fichier > 10 Mo
      if (new FileInfo(openFileDialog1.FileName).Length > 10000000)
      {
        MessageBox.Show(Resources.msg_file_too_big, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      // on teste si la taille total des PJ est inférieure à 10 Mo.
      long iSizeAll = 0;

      foreach (string item in lstPJ.Items)
      {
        iSizeAll += new FileInfo(item).Length;
        if (openFileDialog1.FileName == item)
        {
          MessageBox.Show(Resources.msg_file_already_exists, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }
      }
      iSizeAll += new FileInfo(openFileDialog1.FileName).Length;

      if (iSizeAll > 10000000)
      {
        MessageBox.Show(Resources.msg_file_too_big, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      // ajout du fichier
      lstPJ.Items.Add(openFileDialog1.FileName);

      lblPJSizeFilesAll.Text = Resources.msg_total_size + Strings.Format(iSizeAll / 1000000, "0.###") + " Mo";
    }

    private void cmdDelPJ_Click(object sender, EventArgs e)
    {
      if (lstPJ.Items.Count == 0 || lstPJ.SelectedIndex == -1)
        return;

      lstPJ.Items.Remove(lstPJ.SelectedIndex);
    }

    private void AffichagegestPJ(bool bVisible)
    {
      label4.Visible = label6.Visible = lstPJ.Visible = lblPJSizeFilesAll.Visible = cmdAddPJ.Visible = cmdDelPJ.Visible = bVisible;
      this.Height = bVisible ? 725 : 560;
    }

    private void AffichagegestChkbox(bool bVisible)
    {
      chkAttachement.Visible = label5.Visible = chkBonCde.Visible = bVisible;
      this.Height = bVisible ? 725 : 560;
    }

    private void chkAttachement_Click(object sender, EventArgs e)
    {
      try
      {
        string sFileNameAttachement = "";
        // on teste si la taille total des pj est inférieure a 10 Mo.
        string strRepFic = "";
        string sTypeDoc = "";

        if (chkAttachement.Checked == true)
        {
          sFileNameAttachement = ModuleMain.GetFileAttchementByAction(MozartParams.NumAction, ref sTypeDoc);

          strRepFic = (sTypeDoc == "ATTACH" || sTypeDoc == "GAMME" || sTypeDoc == "ATTEST" ? Utils.RechercheParam("REP_ATTGAM") : Utils.RechercheParam("REP_PHOTOS_ACT"));

          // on teste si l'attachement existe
          if (sFileNameAttachement != "")
          {
            long iSizeAll = 0;

            foreach (string item in lstPJ.Items)
            {
              iSizeAll += new FileInfo(item).Length;
              if (openFileDialog1.FileName == item)
              {
                MessageBox.Show(Resources.msg_file_already_exists, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
              }
            }
            iSizeAll += new FileInfo(openFileDialog1.FileName).Length;

            if (iSizeAll > 10000000)
            {
              MessageBox.Show(Resources.msg_files_too_big, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              return;
            }

            // ajout du fichier
            lstPJ.Items.Add(strRepFic + sFileNameAttachement);

            lblPJSizeFilesAll.Text = Resources.msg_total_size + (iSizeAll / 1000000).ToString("0.###") + " Mo";

            if (chkBonCde.Tag.ToString() == "NC")
              cmdValider.Enabled = false;
            else
            {
              cmdValider.Enabled = true;
              chkAttachement.Tag = "";
            }
          }
          else
          {
            MessageBox.Show(Resources.msg_sending_not_possible);
            cmdValider.Enabled = false;
            chkAttachement.Tag = "NC";
            chkAttachement.Checked = false;
            return;
          }
        }
        else
        {
          if (chkBonCde.Tag.ToString() == "NC")
            cmdValider.Enabled = false;
          else
          {
            cmdValider.Enabled = true;
            chkAttachement.Tag = "";
          }

          // on decoche donc on supprime l'attachement rajouter en pj
          sFileNameAttachement = ModuleMain.GetFileAttchementByAction(MozartParams.NumAction, ref sTypeDoc);

          strRepFic = (sTypeDoc == "ATTACH" || sTypeDoc == "GAMME" || sTypeDoc == "ATTEST" ? Utils.RechercheParam("REP_ATTGAM") : Utils.RechercheParam("REP_PHOTOS_ACT"));

          // on teste si l'attachement existe
          if (sFileNameAttachement != "")
          {
            if (lstPJ.Items.Count > 0)
            {
              for (int i = 0; i < lstPJ.Items.Count - 1; i++)
                if (strRepFic + sFileNameAttachement == lstPJ.Items[i].ToString())
                  lstPJ.Items.RemoveAt(i);
            }
          }
        }
      }
      catch (Exception ex)
      {
        Cursor.Current = Cursors.Default;
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void chkBonCmd_Click(object sender, EventArgs e)
    {
      string sFileNamebonCmd = "";
      //on teste si la taille total des pj est inférieru a 10 Mo.

      string strRepFic = Utils.RechercheParam("REP_PHOTOS_ACT");

      if (chkBonCde.Checked)
      {
        sFileNamebonCmd = ModuleMain.GetFileBonCmdByAction(MozartParams.NumAction);

        // on teste si l'attachement existe
        if (sFileNamebonCmd != "")
        {
          long iSizeAll = 0;

          foreach (string item in lstPJ.Items)
          {
            iSizeAll += new FileInfo(item).Length;
            if (openFileDialog1.FileName == item)
              MessageBox.Show(Resources.msg_file_already_exists, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
          }
          iSizeAll += new FileInfo(openFileDialog1.FileName).Length;

          if (iSizeAll > 10000000)
          {
            MessageBox.Show(Resources.msg_files_too_big, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
          }

          //ajout du fichier
          lstPJ.Items.Add(strRepFic + sFileNamebonCmd);

          lblPJSizeFilesAll.Text = Resources.msg_total_size_10mo + (iSizeAll / 1000000).ToString("0.###") + " Mo";

          if (chkAttachement.Tag.ToString() == "NC")
            cmdValider.Enabled = false;
          else
          {
            cmdValider.Enabled = true;
            chkBonCde.Tag = "";
          }
        }
        else
        {
          MessageBox.Show(Resources.msg_sending_not_possible, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          cmdValider.Enabled = false;
          chkBonCde.Checked = false;
          chkBonCde.Tag = "NC";
          return;
        }
      }
      else
      {
        if (chkAttachement.Tag.ToString() == "NC")
          cmdValider.Enabled = false;
        else
        {
          cmdValider.Enabled = true;
          chkBonCde.Tag = ""; // on utilise ce tag pour connaitre l'etat du bouton selon letat de la checkbox attachement

          // on decoche, donc on supprime l'attachement rajouté en PJ
          sFileNamebonCmd = ModuleMain.GetFileBonCmdByAction(MozartParams.NumAction);

          // on teste si l'attachement existe
          if (sFileNamebonCmd != "")
            for (int i = 0; i < lstPJ.Items.Count - 1; i++)
              if (strRepFic + sFileNamebonCmd == lstPJ.Items[i].ToString())
                lstPJ.Items.Remove(i);
        }
      }
    }

    private void cmdAdd_PJ_DocCLi_Click(object sender, EventArgs e)
    {
      frmAddDocPj_To_PJ frm = new frmAddDocPj_To_PJ();
      frm.ShowDialog();

      string sFileToAdd;
      long iSizeAll = 0;

      foreach (Utils.C_PJ pj in frm.lstPJSelect)
      {
        sFileToAdd = pj.PATH_FILE + pj.VFICHIER;

        // si fichier > 10 Mo
        if (new FileInfo(sFileToAdd).Length > 10000000)
        {
          MessageBox.Show(Resources.msg_file_too_big, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        // on teste si la taille total des pj est inférieure a 10 Mo.
        foreach (string item in lstPJ.Items)
        {
          if (sFileToAdd == item)
          {
            MessageBox.Show(Resources.msg_file_already_exists, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
          }

          iSizeAll += new FileInfo(item).Length;

          if (iSizeAll > 10000000)
          {
            MessageBox.Show(Resources.msg_files_too_big, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
          }

          lstPJ.Items.Add(sFileToAdd);
          lblPJSizeFilesAll.Text = Resources.msg_total_size_10mo + (iSizeAll / 1000000).ToString("0.###") + " Mo";
        }
      }
    }
  }
}

