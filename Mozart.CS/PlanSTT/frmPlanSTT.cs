using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using ReportEmalec.Net;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmPlanSTT : Form
  {
    public int miNumAction;
    public string mStrStatutIP;
    public int miNumSite;
    public string mStrTagIP;
    public string miDuree;
    public int miNumTech;// identifiant de l’intervenant (le technicien du sous-traitant)
    public int miNumIp;
    public int miNumST;// identifiant du  sous-traitant

    private int iNbrImage;

    public DateTime mdSemaine;
    DataTable dtTech = new DataTable();

    List<apiLabel> lstJours = new List<apiLabel>();
    List<apiLabel> lstHeures = new List<apiLabel>();
    List<PictureBox> lstPic = new List<PictureBox>();
    List<Button> lstCmdOptim = new List<Button>();
    List<Button> lstCmdPlus = new List<Button>();
    List<Label> lstLblTech = new List<Label>();
    List<Label> lstLblInfo = new List<Label>();

    int iPosPremierTech = 0;
    string strTypeEdition = "";

    public frmPlanSTT() { InitializeComponent(); }


    private void frmPlanSTT_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);
        Text = Resources.txt_Planning_prev_STT;

        // Fonction qui donne le premier jour de la semaine (lundi)
        mdSemaine = mdSemaine.AddDays(-(mdSemaine.DayOfWeek == (int)DayOfWeek.Sunday ? 7 : (int)mdSemaine.DayOfWeek - 1));

        iNbrImage = 0;
        miNumAction = MozartParams.NumAction;   // pour ne pas modifier la variable globale

        lstJours.Add(lJour0); lstJours.Add(lJour1); lstJours.Add(lJour2); lstJours.Add(lJour3); lstJours.Add(lJour4); lstJours.Add(lJour5); lstJours.Add(lJour6); lstJours.Add(lJour7);

        lstHeures.Add(lHeure0); lstHeures.Add(lHeure1); lstHeures.Add(lHeure2); lstHeures.Add(lHeure3); lstHeures.Add(lHeure4); lstHeures.Add(lHeure5);
        lstHeures.Add(lHeure6); lstHeures.Add(lHeure7); lstHeures.Add(lHeure8); lstHeures.Add(lHeure9); lstHeures.Add(lHeure10); lstHeures.Add(lHeure11);
        lstHeures.Add(lHeure12); lstHeures.Add(lHeure13); lstHeures.Add(lHeure14); lstHeures.Add(lHeure15); lstHeures.Add(lHeure16);

        lstLblTech.Add(lblTech0); lstLblTech.Add(lblTech1); lstLblTech.Add(lblTech2); lstLblTech.Add(lblTech3);
        lstLblInfo.Add(lblInfo0); lstLblInfo.Add(lblInfo1); lstLblInfo.Add(lblInfo2); lstLblInfo.Add(lblInfo3);
        //lstCmdOptim.Add(cmdOptim0); lstCmdOptim.Add(cmdOptim1); lstCmdOptim.Add(cmdOptim2); lstCmdOptim.Add(cmdOptim3);

        for (int i = 0; i < 28; i++)
          lstCmdPlus.Add((Button)Controls.Find($"cmdPlus{i}", false)[0]);

        foreach (Button item in lstCmdPlus)
          item.Visible = false;

        //  recherche des tech de sous traitants
        string sSql = "SELECT NSTTNUM, left(VSTFNOM,10) + '-  ' + VSTTNOM + ' ' + VSTTPRENOM [VSTTNOM] FROM TSTF INNER JOIN TSTTECH " +
                      "ON TSTF.NSTFNUM = TSTTECH.NSTFNUM WHERE CSTFPREV = 'O' ORDER BY left(VSTFNOM,10) + '-  ' + VSTTNOM + ' ' + VSTTPRENOM ";
        cboInter.Init(MozartDatabase.cnxMozart, sSql, "NSTTNUM", "VSTTNOM", new List<string>() { Resources.col_Num, Resources.col_Nom }, 150, 550);

        if (mStrStatutIP == "C")
        {
          // constitution du tag d'une nouvelle IP (Code, NumIP(null), NumSite, NumAction, Texte, DuréeAction, Tech, Jour)
          picTag myTag = new picTag
          {
            sTag = $"N#0#{miNumSite}#{miNumAction}#{mStrTagIP}#{miDuree}#0##N",
            sInter = $"{mStrTagIP}{miDuree}heures"
          };

          pic0.Tag = myTag;
          pic0.Visible = true;

          // recherche des techniciens
          GetTechniciens(true, "N", true);

          // affichage du planning en création
          InitialiserPlanning();
        }
        else
        {
          // recherche des techniciens
          GetTechniciens(true, "N", true);
          pic0.Visible = false;

          // afifchage du planning en modification
          InitialiserPlanning();
        }

        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdFermer_Click(object sender, EventArgs e)
    {
      if (pic0.Visible)
      {
        MessageBox.Show(Resources.msg_Planifier_avant_sortie, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }
      Dispose();
    }

    private void cmdPlus_Click(object sender, EventArgs e)
    {
      int Index = Convert.ToInt32((sender as Button).Tag);

      frmPlanSimpleSTT f = new frmPlanSimpleSTT();
      if (Index <= 6)
      {
        f.iNumSTTPlan = Convert.ToInt32(lblTech0.Tag);
        f.mlblTech = lblTech0.Text;
      }
      else if (Index > 6 && Index <= 13)
      {
        f.iNumSTTPlan = Convert.ToInt32(lblTech1.Tag);
        f.mlblTech = lblTech1.Text;
      }
      else if (Index > 13 && Index <= 20)
      {
        f.iNumSTTPlan = Convert.ToInt32(lblTech2.Tag);
        f.mlblTech = lblTech2.Text;
      }
      else if (Index > 20 && Index <= 27)
      {
        f.iNumSTTPlan = Convert.ToInt32(lblTech3.Tag);
        f.mlblTech = lblTech3.Text;
      }
      f.DebutSemaineSTT = mdSemaine;
      f.ShowDialog();

      InitialiserPlanning();
    }

    private void cmdOptim_Click(object sender, EventArgs e)
    {
      int iNumTech = Convert.ToInt32((sender as Button).Tag);
      //if ((sender as Button).Text == "? km") { }
      ////CalculKmSemaine(Index);
      //else
      //{
      //  // TB SAMSIC CITY SPEC
      //  if (MozartParams.NomGroupe == "EMALEC")
      //  {
      //    frmBrowser f = new frmBrowser();
      //    f.msStartingAddress = $"https://maps.emalec.com/TrajetTechnicienSemaine.asp?BASE=MULTI&APP={MozartParams.NomSociete}&NumTech={iNumTech}&Semaine={mdSemaine.ToShortDateString()}";
      //    f.ShowDialog();
      //  }
      //  // TB SAMSIC CITY TODO -> else pour samsic
      //}
    }

    private void cmdLegende_Click(object sender, EventArgs e)
    {
      new frmLegende().ShowDialog();
    }

    private void cmdGoTech_Click(object sender, EventArgs e)
    {
      miNumTech = cboInter.GetItemData();
      GetTechniciens(true, "P", false);
      InitialiserPlanning();
    }

    private void GetTechniciens(bool bPremierFois, string sDirection, bool bFindTech = false)
    {
      try
      {
        string sSql = "";
        // liste des techniciens
        // si on est en creation de l'IP, on affiche que les tech du ST sélectionné
        if (mStrStatutIP == "C")
        {
          sSql = "SELECT NSTTNUM, VSTTNOM + ' ' + VSTTPRENOM as VSTTNOM, VSTTPORT, VSTFNOM FROM TSTF INNER JOIN TSTTECH ON TSTF.NSTFNUM = TSTTECH.NSTFNUM " +
                 "WHERE TSTF.NSTFNUM = " + miNumST + " ORDER BY VSTTNOM";
          dtTech.Load(ModuleData.ExecuteReader(sSql));
        }
        else
        {
          if (bPremierFois && bFindTech)
          {
            sSql = "SELECT NSTTNUM, VSTTNOM + ' ' + VSTTPRENOM as VSTTNOM, VSTTPORT, VSTFNOM FROM TSTF INNER JOIN TSTTECH ON TSTF.NSTFNUM = TSTTECH.NSTFNUM " +
                   "WHERE CSTFPREV = 'O' ORDER BY VSTFNOM, VSTTNOM";
            dtTech.Load(ModuleData.ExecuteReader(sSql));
          }
        }

        DataColumn[] keys = new DataColumn[1];
        keys[0] = dtTech.Columns["NSTTNUM"];
        dtTech.PrimaryKey = keys;


        // on se place sur le bon technicien si c'est la premiere fois
        if (bPremierFois)
        {
          if (miNumTech != 0)
          {
            //  rsT.Requery
            DataRow[] rowT = dtTech.Select($"NSTTNUM = {miNumTech}");
            iPosPremierTech = dtTech.Rows.IndexOf(rowT[0]);

            // on le place au milieu
            iPosPremierTech -= Math.Min(iPosPremierTech, 2);
          }
        }
        else
        {
          // traitement des cas suivant et précédent
          if (sDirection == "TECHSUIV")
          {
            // rien car on est déja bien placé à moins que l'on soit EOF, alors on sort
            if (iPosPremierTech + 3 >= dtTech.Rows.Count)
              return;
            else
              iPosPremierTech += 4;
          }
          else
            // on remonte de 8 cases
            iPosPremierTech -= Math.Min(iPosPremierTech, 4);
        }

        // initialisation des 4 techniciens et placement des techniciens
        for (int i = 0; i <= 3; i++)
        {
          if (iPosPremierTech + i < dtTech.Rows.Count)
          {
            DataRow rowT = dtTech.Rows[iPosPremierTech + i];
            lstLblTech[i].Text = rowT["VSTTNOM"].ToString();
            lstLblTech[i].Tag = rowT["NSTTNUM"];
            //lstCmdOptim[i].Tag = rowT["NSTTNUM"];
            lstLblInfo[i].Tag = rowT["NSTTNUM"];
            lstLblInfo[i].Text = $"{rowT["VSTFNOM"]}\r\n{rowT["VSTTPORT"]}";
          }
          else
          {
            lstLblTech[i].Text = "";
            lstLblTech[i].Tag = "";
            lstLblInfo[i].Tag = "";
            //lstCmdOptim[i].Tag = "";
            lstLblInfo[i].Text = "";
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void InitialiserPlanning(int iCacherIP = 0)
    {
      try
      {
        int k = iNbrImage;

        // recherche du numéro de semaine
        lblSemaine.Text = Resources.txt_semaine + UtilsPlan.WeekOfDate(mdSemaine);
        lblAnnee.Text = Resources.col_annee + " " + mdSemaine.Year.ToString();

        UtilsPlan.TexteEtCouleurJour(Label10, mdSemaine);
        UtilsPlan.TexteEtCouleurJour(Label11, mdSemaine.AddDays(1));
        UtilsPlan.TexteEtCouleurJour(Label12, mdSemaine.AddDays(2));
        UtilsPlan.TexteEtCouleurJour(Label13, mdSemaine.AddDays(3));
        UtilsPlan.TexteEtCouleurJour(Label14, mdSemaine.AddDays(4));
        UtilsPlan.TexteEtCouleurJour(Label15, mdSemaine.AddDays(5));
        UtilsPlan.TexteEtCouleurJour(Label16, mdSemaine.AddDays(6));

        foreach (PictureBox item in lstPic)
        {
          Controls.Remove(item);
          item.Dispose();
        }

        lstPic.Clear();

        DataTable dt = new DataTable();

        for (int j = 0; j < 4; j++)     // 0,1,2,3 => 4 techniciens sur le planning
        {
          //lstCmdOptim[j].Text = "§ ? km§";

          // liste des interventions par techniciens pour la semaine en cours
          if (lstLblTech[j].Tag.ToString() != "")
          {
            dt.Clear();
            dt.Load(ModuleData.ExecuteReader($"api_sp_listeInterventionsST {lstLblTech[j].Tag}, '{mdSemaine}" + "'"));
            foreach (DataRow row in dt.Rows)
            {
              // Création d'une image
              k += 1;
              DateTime datePla = Convert.ToDateTime(row["DACTPLA"]);

              PictureBox pic = new PictureBox();
              picTag myTag = new picTag();

              // Coordonnées de l'image (pb avec le dimanche car son weekday = 0)
              pic.Left = lstJours[datePla.DayOfWeek == DayOfWeek.Sunday ? 6 : (int)datePla.DayOfWeek - 1].Left;
              pic.Top = lstHeures[(j * 4) + (int)row["NIPLSTIND"] - 1].Top;
              pic.Size = pic0.Size;

              miNumAction = Convert.ToInt32(row["NACTNUM"]);

              // Constitution du tag d'une IP (code, NumIP, NumSite, NumAction(null), text, duree, premierJ, tech)
              myTag.sTag = "D#";
              myTag.sTag += $"{row["NIPLSTNUM"]}#";
              myTag.sTag += $"{row["NSITNUM"]}#";
              myTag.sTag += $"{row["NACTNUM"]}#";
              myTag.sTag += $"{row["VCLINOM"]}\r\n";
              myTag.sTag += $"{row["VSITNOM"]}\r\n#";
              myTag.sTag += $"{row["NACTDUR"]}#";
              myTag.sTag += $"{lstLblTech[j].Tag}#";
              myTag.sTag += datePla.ToShortDateString();

              // Pour les sites emalec spéciaux couleur : jaune
              if (row["VCLINOM"].ToString() == MozartParams.NomSociete)
                pic.BackColor = Color.Yellow;   // &HFFFF &
              else
              {
                // couleur standard = bleu clair
                pic.BackColor = Color.FromArgb(192, 255, 255);  //&HFFFFC0

                if ((int)ModuleData.ExecuteScalarInt($"select count(NCSTNUM) FROM TCST WHERE NACTNUM = {miNumAction}") == 0)
                  pic.BackColor = Color.FromArgb(255, 192, 255);  // &HFF80FF

                // si autre personne sur site au meme moment = bleu clair
                if (!UtilsPlan.VerifAide(Convert.ToInt32(row["NIPLSTNUM"]), miNumAction, false, bSTT: true))
                  pic.BackColor = Color.FromArgb(192, 192, 255);   // &HFFC0C0

                // si c'est la nuit :  rouge                                                
                if (row["CACTNUIT"].ToString() == "O") pic.BackColor = Color.Red;

                // si c'est hors présence public :  rouge claire
                if (row["CACTNUIT"].ToString() == "P") pic.BackColor = Color.FromArgb(255, 192, 192);

                // si date d'execution : orange
                // si attachement (et exécution): Vert
                if (Utils.DateBlankIfNull(row["DACTDEX"]) != "")
                  if (Utils.BlankIfNull(row["VACTATT"]) == "")
                    pic.BackColor = Color.FromArgb(255, 193, 125); // RGB(255, 193, 125)
                  else
                    pic.BackColor = Color.FromArgb(192, 255, 192); ; // &HC0FFC0

                // si facture, et exec, et attach : blanc
                if (row["nbfact"].ToString() != "0" && pic.BackColor == Color.FromArgb(192, 255, 192))
                  pic.BackColor = Color.White;
              }

              // Affichage des informations dans l'image
              myTag.sInter = $"{row["VCLINOM"]}\r\n{row["VSITNOM"]}\r\n {Convert.ToInt32(row["NACTDUR"])}h  {row["sCODE"]}";

              if (row["nbfact"].ToString() == "F") myTag.sInter += $"  €";
              if (Utils.BlankIfNull(row["PrevMag"]) == "O") myTag.sInter += $"  #";

              pic.Tag = myTag;

              pic.Paint += new PaintEventHandler(pic_Paint);
              pic.MouseUp += new MouseEventHandler(pic_MouseUp);
              pic.MouseDown += new MouseEventHandler(pic_MouseDown);

              if (iCacherIP != 0)
              {
                if (Convert.ToInt32(row["NIPLSTNUM"]) == iCacherIP)
                  pic.Visible = false;
                else
                  pic.Visible = true;
              }
              else
                pic.Visible = true;

              Controls.Add(pic);
              lstPic.Add(pic);
            }
          }
          TraitementBoutonSupp();
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(string.Format("{0}{1}\r\n\r\n{2}{3}", Resources.msg_error_planning + "\r\n",
          ex.Message, Resources.Global_dans, MethodBase.GetCurrentMethod().Name), Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
    }

    private void pic_Paint(object sender, PaintEventArgs e)
    {
      using (Font myFont = new Font("MS Sans Serif", 8))
        e.Graphics.DrawString(((sender as PictureBox).Tag as picTag).sInter, myFont, Brushes.Black, new Point(1, 2));
    }

    private void TraitementBoutonSupp()
    {
      for (int j = 0; j < 4; j++)
      {
        for (int i = j * 7; i < (j * 7) + 6; i++)
          lstCmdPlus[i].Visible = false;

        // Nombre d'interventions par technicien, par jour pour la semaine en cours
        if (lstLblTech[j].Tag.ToString() != "")
        {
          using (SqlDataReader rsAct = ModuleData.ExecuteReader("exec [api_sp_NombreInterventionsSTT] " + lstLblTech[j].Tag + ", '" + mdSemaine + "'"))
          {
            while (rsAct.Read())
            {
              int DayOfWeek = (int)Convert.ToDateTime(rsAct["DACTPLA"]).DayOfWeek;
              int NbInter = Convert.ToInt32(rsAct[1]);
              if (Convert.ToInt32(rsAct[1]) > 3)
              {
                if (DayOfWeek == (int)System.DayOfWeek.Sunday)  // dimanche
                {
                  lstCmdPlus[(7 * j) + 6].Visible = true;

                  if (NbInter == 4)
                    lstCmdPlus[(7 * j) + 6].BackColor = Color.White;
                  else
                    lstCmdPlus[(7 * j) + 6].BackColor = Color.Orange;
                }
                else
                {
                  lstCmdPlus[(7 * j) + DayOfWeek - 1].Visible = true;
                  if (NbInter == 4)
                    lstCmdPlus[(7 * j) + DayOfWeek - 1].BackColor = Color.White;
                  else
                    lstCmdPlus[(7 * j) + DayOfWeek - 1].BackColor = Color.Orange;   // &H80FF &
                }
              }
            }
          }
        }
      }
    }

    private void frmPlanSTT_DragEnter(object sender, DragEventArgs e)
    {
      e.Effect = DragDropEffects.Move;
    }

    private void frmPlanSTT_DragOver(object sender, DragEventArgs e)
    {
      e.Effect = DragDropEffects.All;
    }

    private void frmPlanSTT_DragDrop(object sender, DragEventArgs e)
    {
      // Si c'est une nouvelle action que l'on pose alors c'est une création d'IP
      //  - dans la table TPLA, création de l'enregistrement
      //    insert into TPLA set DPLADAT = datepla, NPLAIND = indice, TACTNUM = source.tag
      //  - dans la table TACT, modification du technicien affecté et renseignement du numero IP
      //    update TACT set TPERNUM = lblTech(itech).Tag where NACTNUM = source.tag
      // Sinon c'est une IP que l'on déplace
      //  - dans la table TPLA, modification du champs indice et dateplanifié
      //    update TPLA set DPLADAT = datepla, NPLAIND = indice where NPLANUM = source.tag
      //  - dans la table TACT, modification du technicien affecté
      //    update TACT set TPERNUM = lblTech(itech).Tag where NACTNUM = source.tag
      // fin si

      try
      {
        int Top, Left;
        int indice = 0;
        int iTech = 0;
        string DatePla = "";
        bool Out = true;

        // Pas de move donc pas de Drop
        if (e.Effect != DragDropEffects.All) return;

        PictureBox picSource = (PictureBox)e.Data.GetData(typeof(PictureBox));

        Point clientPoint = PointToClient(new Point(e.X, e.Y));

        //  Conservation de la position initiale
        Left = picSource.Left;
        Top = picSource.Top;

        //  Recherche des info dans le tag de l'image
        string[] myTab = (picSource.Tag as picTag).sTag.Split('#');
        miNumAction = Convert.ToInt32(myTab[3]);

        //  Test pour empecher de sortir du planning
        if (clientPoint.X > lstJours[7].Left) return;
        if (clientPoint.X < lstJours[0].Left) return;
        if (clientPoint.Y > lstHeures[16].Top) return;
        if (clientPoint.Y < lstHeures[0].Top) return;

        //  Définition du technicien et de l'indice ou l'on pose
        for (int h = 15; h >= 0; h--)
        {
          if (clientPoint.Y > lstHeures[h].Top)
          {
            // determiner le tech et l'indice
            iTech = h / 4;
            indice = ((h + 1) % 4 == 0) ? 4 : (h + 1) % 4;
            picSource.Top = lstHeures[h].Top;
            Out = false;
            break;
          }
        }

        //  On sort si il ny a pas de technicien sur le drop
        if (Out)
          return;

        //  Définition du jour ou on pose
        for (int j = 7; j >= 0; j--)
        {
          if (clientPoint.X > lstJours[j].Left)
          {
            DatePla = mdSemaine.AddDays(j).ToShortDateString();
            picSource.Left = lstJours[j].Left;
            break;
          }
        }

        //  Vérifications 'si on change d'entreprise, erreur
        //  ancien tech et nouveau tech ou on pose
        if (!UtilsPlan.VerifTech(Convert.ToInt32(myTab[6]), Convert.ToInt32(lstLblTech[iTech].Tag)))
        {
          picSource.Left = Left;
          picSource.Top = Top;
          return;
        }

        //   Vérifications (déplacement d'une IP avec information au client, aide sur intervention, IP Emalec, action bloquée)
        if (!UtilsPlan.VerificationsSTT(nIpl: Convert.ToInt32(myTab[1]), NSITNUM: Convert.ToInt32(myTab[2]), NumAction: Convert.ToInt32(myTab[3])))
        {
          picSource.Left = Left;
          picSource.Top = Top;
          return;
        }

        try
        {
          using (SqlCommand cmd = new SqlCommand("api_sp_CreationIP_ST", MozartDatabase.cnxMozart))
          {
            cmd.CommandType = CommandType.StoredProcedure;
            SqlCommandBuilder.DeriveParameters(cmd);

            cmd.Parameters["@iIP"].Value = myTab[1];
            cmd.Parameters["@iAction"].Value = myTab[3];
            cmd.Parameters["@pDate"].Value = DatePla;
            cmd.Parameters["@indice"].Value = indice;
            cmd.Parameters["@iTech"].Value = Convert.ToInt32(lstLblTech[iTech].Tag);
            cmd.ExecuteNonQuery();
          }
        }
        catch (Exception ex)
        {
          MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
        }

        if (myTab[0] == "D")
        {
          // Si on ne change pas de jour, il ne faut pas réinitialiser
          if (DatePla != myTab[7])
          {
            ModuleData.ExecuteNonQuery($"UPDATE TACT set CACTINFOMAG = 'N', VACTQUIINFO = '', VACTINFOQUI = '', DACTQUANDINFO = Null where NACTNUM = {myTab[3]}");

            // On met a jour la date de réalisation du devis de sous-traitance
            ModuleData.ExecuteNonQuery($"UPDATE TCST set DCSTDEL = '{DatePla}' where nactnum = {myTab[3]}");
          }
        }
        if (picSource.Name == "pic0")
          picSource.Visible = false;

        // Réinitialisation de l'affichage
        InitialiserPlanning();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void mnuGamme_Click(object sender, EventArgs e)
    {
      try
      {
        // Si on est pas sur une IP on sort
        if (miNumIp == 0) return;

        using (SqlDataReader dr = ModuleData.ExecuteReader($"SELECT NGAMNUM, NINTNUM from TACT WITH (NOLOCK) where NGAMNUM <> 0 AND NACTNUM = {miNumAction}"))
        {
          dr.Read();

          new frmMainReport
          {
            bLaunchByProcessStart = false,
            sTypeReport = "TGAMMECLIENTST",
            sIdentifiant = $"{dr["NGAMNUM"]}|{miNumAction}",
            InfosMail = "TINT|NINTNUM|" + dr["NINTNUM"].ToString(),
            sNomSociete = MozartParams.NomSociete,
            sLangue = MozartParams.Langue,
            sOption = "PREVIEW"
          }.ShowDialog();

        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdAllPrecSuiv_DragEnter(object sender, DragEventArgs e)
    {
      e.Effect = DragDropEffects.Move;
    }

    private void cmdAllPrecSuiv_DragOver(object sender, DragEventArgs e)
    {
      e.Effect = DragDropEffects.All;
    }

    private void cmdAllPrecSuiv_DragDrop(object sender, DragEventArgs e)
    {
      // Passage au technicien précédent
      // si création : - faire passer le numéro de l'action a planifier
      //                - afficher l'image a l'ouverture
      // si déplacement d'une IP : - faire passer le numéro de l'IP
      //                           - afficher l'image a l'ouverture

      int Top, Left;
      PictureBox picSource = (PictureBox)e.Data.GetData(typeof(PictureBox));

      //  Conservation de la position initiale
      Left = picSource.Left;
      Top = picSource.Top;

      // Recherche des info dans le tag de l'image
      string[] myTab = (picSource.Tag as picTag).sTag.Split('#');
      miNumAction = Convert.ToInt32(myTab[3]);

      // Vérifications (déplacement d'une IP avec information au client, aide sur intervention, IP Emalec, action bloque)
      if (!UtilsPlan.Verifications(Convert.ToInt32(myTab[1]), Convert.ToInt32(myTab[2])))
      {
        picSource.Left = Left;
        picSource.Top = Top;
        return;
      }

      // Si on est en création d'une IP, on passe simplement à la semaine suivante 
      if (myTab[0] != "N")
      {
        // On pose l'IP à modifier dans la pic(0)
        //pic0.Left = 240;
        //pic0.Top = 2640;
        pic0.Tag = picSource.Tag;

        (pic0.Tag as picTag).sInter = myTab[4] + myTab[5] + "heures";
        pic0.Visible = true;
      }

      string sens = (sender as Button).Tag.ToString();
      if (sens.StartsWith("TECH"))
        GetTechniciens(false, sens);
      else
        mdSemaine = mdSemaine.AddDays(sens.Contains("PREC") ? -7 : 7);

      InitialiserPlanning(Convert.ToInt32(myTab[1]));
    }

    private void cmdTechPrecSuiv_Click(object sender, EventArgs e)
    {
      // Passage aux techniciens précédents
      GetTechniciens(false, (sender as Button).Tag.ToString());

      Timer1.Enabled = false;
      InitialiserPlanning();
    }

    private void cmdSemainePrecSuiv_Click(object sender, EventArgs e)
    {
      // Passage à la semaine précédente ou suivante
      Timer1.Enabled = false;
      mdSemaine = mdSemaine.AddDays((sender as Button).Tag.ToString() == "SEMPREC" ? -7 : 7);
      InitialiserPlanning();
    }

    private void frmPlanSTT_MouseUp(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Right)
      {
        miNumTech = 0;
        miNumIp = 0;
        strTypeEdition = Resources.col_Tech;
        mnuCP.Visible = false;
        mnuAffichage.Show(Cursor.Position);
      }
    }

    private void frmPlanSTT_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyValue == 116)
        InitialiserPlanning();
    }

    private void pic_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left && e.Clicks == 1)
      {
        PictureBox pic = sender as PictureBox;
        pic.DoDragDrop(pic, DragDropEffects.Move);
      }
    }

    private void pic_MouseUp(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Right)
      {
        PictureBox pic = sender as PictureBox;

        string[] MyTabPic = (pic.Tag as picTag).sTag.Split('#');

        //dDateJour = Convert.ToDateTime(MyTabPic[7]);
        miNumIp = Convert.ToInt32(MyTabPic[1]);
        miNumTech = Convert.ToInt32(MyTabPic[6]);
        miNumAction = Convert.ToInt32(MyTabPic[3]);
        miNumSite = Convert.ToInt32(MyTabPic[2]);
        strTypeEdition = "IP";
        mnuCP.Visible = true;
        mnuCP.Text = UtilsPlan.GetCodePostal(Convert.ToInt32(miNumSite));
        mnuAffichage.Show(Cursor.Position);
      }
    }

    private void lblInfo_MouseUp(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Right)
      {
        miNumTech = Convert.ToInt32((sender as Label).Tag);
        miNumIp = 0;
        strTypeEdition = Resources.col_Tech;
        mnuCP.Visible = false;
        mnuAffichage.Show(Cursor.Position);
      }
    }

    private void mnuEditionOT_Click(object sender, EventArgs e)
    {
      int iTechCourant = miNumTech;
      if (strTypeEdition == "TECH")
      {
        if (MessageBox.Show(Resources.msg_dde_impression_OT_semaine, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button2) == DialogResult.Yes)
        {
          foreach (PictureBox pic in lstPic)
          {
            // Recherche des info dans le tag de l'image
            string[] myTab = (pic.Tag as picTag).sTag.Split('#');
            if (Convert.ToInt32(myTab[8]) == iTechCourant)
              ImpressionOTtech(Convert.ToInt32(myTab[1]), Convert.ToInt32(myTab[3]));   // IP et Action
          }
        }
        else
          return;
      }
      else if (strTypeEdition == "IP")
        ImpressionOTtech(miNumIp, miNumAction);
    }

    public void ImpressionOTtech(int NumIP, int iAction)
    {
      try
      {
        // Si on est pas sur une IP on sort
        if (NumIP == 0) return;

        // Recherche des infos
        int? nCstNum = ModuleData.ExecuteScalarInt($"select NCSTNUM, NINTNUM, NACTNUM from TCST WHERE NACTNUM = {iAction}");
        if (nCstNum == null) return;

        if (ModuleMain.TestIfSTWithAccessWEB("CST", (int)nCstNum))

          if (MessageBox.Show(Resources.msg_Warning_impr_doc_non_obligatoire_ST_a_acces_web, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
          MessageBoxDefaultButton.Button2) == DialogResult.No)
            return;

        new frmMainReport
        {
          bLaunchByProcessStart = false,
          sTypeReport = "TContratSousTraitance",
          sIdentifiant = $"{iAction}|{nCstNum}",
          InfosMail = $"TINT|NINTNUM|0",
          sNomSociete = MozartParams.NomSociete,
          sLangue = MozartParams.Langue,
          sOption = "PRINT",
          strType = "CS",
          numAction = iAction
        }.ShowDialog();

        // Si il existe une gammeimpression de la gamme et de l'inventaire stock si lié
        using (SqlDataReader dr = ModuleData.ExecuteReader($"SELECT NGAMNUM, NSITNUM from TACT WITH (NOLOCK) where NGAMNUM <> 0 AND NACTNUM = {iAction}"))
        {
          if (dr.Read())
          {
            Utils.ImpressionGammeST(Convert.ToInt32(dr["NGAMNUM"]), MozartParams.Langue);

            //  FGA le 13/06/2024
            //  if ((bool)ModuleData.ExecuteScalarObject($"SELECT TOP 1 BSTOCKLIE FROM TGAMCLIENT WHERE NTRACLINUM = {dr["NGAMNUM"]}"))
            //    Utils.ImpressionStockST(miNumTech, Convert.ToInt32(dr["NSITNUM"]), NumIP, DateTime.Now.ToShortDateString());
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void mnuVisu_Click(object sender, EventArgs e)
    {
      try
      {
        // Si on est pas sur une IP on sort
        if (miNumIp == 0) return;

        using (SqlDataReader rsA = ModuleData.ExecuteReader("select NCSTNUM, NINTNUM, NACTNUM from TCST WHERE NACTNUM = " + miNumAction))
        {
          if (rsA.Read())
          {
            new frmMainReport
            {
              bLaunchByProcessStart = false,
              sTypeReport = "TContratSousTraitance",
              sIdentifiant = $"{miNumAction}|{rsA["NCSTNUM"]}",
              InfosMail = $"TINT|NINTNUM|{rsA["NINTNUM"]}",
              sNomSociete = MozartParams.NomSociete,
              sLangue = MozartParams.Langue,
              sOption = "PREVIEW",
              strType = "CS",
              numAction = MozartParams.NumAction
            }.ShowDialog();
          }
          else
          {
            MessageBox.Show(Resources.msg_aucun_contrat_sur_action, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void mnuSupprimerIP_Click(object sender, EventArgs e)
    {
      try
      {
        // Si on est pas sur une IP on sort
        if (miNumIp == 0) return;

        // Confirmation de la suppression
        if (MessageBox.Show(Resources.msg_dde_suppr_planif, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button2) == DialogResult.Yes)
          ModuleData.ExecuteNonQuery($"api_sp_SupprimerIP_ST {miNumAction}");
        else
          return;

        // Initialisation du planning
        InitialiserPlanning();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void mnuDetails_Click(object sender, EventArgs e)
    {
      //  si on est pas sur une IP on sort
      if (miNumIp == 0) return;

      try
      {
        int iNumDI, iNumAction;

        //  On garde les variables globales en mémoire
        using (SqlDataReader dr = ModuleData.ExecuteReader("select TACT.NACTNUM, NDINNUM from TACT WITH (NOLOCK), TIPLST WITH (NOLOCK) where TACT.NACTNUM = TIPLST.NACTNUM AND NIPLSTNUM = " + miNumIp))
        {
          if (dr.Read())
          {
            // On garde les anciennes valeurs
            iNumDI = MozartParams.NumDi;
            iNumAction = MozartParams.NumAction;

            try
            {
              MozartParams.NumDi = Convert.ToInt32(dr["NDINNUM"]);
              MozartParams.NumAction = Convert.ToInt32(dr["NACTNUM"]);

              // écran de modification de la demande
              new frmAddAction() { mstrStatutDI = "M" }.ShowDialog();
            }
            catch (Exception)
            {
              MessageBox.Show(Resources.msg_affich_impossible_ecran_charge, Resources.Global_Erreur, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            // on revient donc on réinitialise les variables globales avec anciennes valeurs
            MozartParams.NumDi = iNumDI;
            MozartParams.NumAction = iNumAction;
          }
        }

        // initialisation du planning pour prendre en compte les modifications
        InitialiserPlanning();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }



    private void cmdImprimer_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      this.ImprimerDansWord();
      Cursor.Current = Cursors.Default;
    }

    private void cmdRefresh_Click(object sender, EventArgs e)
    {
      InitialiserPlanning();
    }

    private void Timer2_Tick(object sender, EventArgs e)
    {
      // Le timer.Interval est passé à 180000
      lblRefresh.Visible = true;
      Timer2.Enabled = false;
    }

    private void cmdPlus_Paint(object sender, PaintEventArgs e)
    {
      Button b = sender as Button;
      using (Pen p = new Pen(Color.Black))
        e.Graphics.DrawString("+", b.Font, p.Brush, new PointF(b.Width / 2, -3));
    }


    private void cmdAllPlus_DragDrop(object sender, DragEventArgs e)
    {
      // On passe l'IP sur le planning du tech virtuel

      int Index = Convert.ToInt32((sender as Button).Tag);
      int Top, Left;
      PictureBox picSource = (PictureBox)e.Data.GetData(typeof(PictureBox));

      //  Conservation de la position initiale
      Left = picSource.Left;
      Top = picSource.Top;

      //  Recherche des info dans le tag de l'image
      string[] myTab = (picSource.Tag as picTag).sTag.Split('#');
      miNumAction = Convert.ToInt32(myTab[3]);

      //   Vérifications (déplacement d'une IP avec information au client, aide sur intervention, IP Emalec, action bloque)
      if (!UtilsPlan.Verifications(Convert.ToInt32(myTab[1]), Convert.ToInt32(myTab[2])))
      {
        picSource.Left = Left;
        picSource.Top = Top;
        return;
      }

      frmPlanSimpleSTT f = new frmPlanSimpleSTT();
      if (Index <= 6)
      {
        f.iNumSTTPlan = Convert.ToInt32(lblTech0.Tag);
        f.mlblTech = lblTech0.Text;
      }
      else if (Index > 6 && Index <= 13)
      {
        f.iNumSTTPlan = Convert.ToInt32(lblTech1.Tag);
        f.mlblTech = lblTech1.Text;
      }
      else if (Index > 13 && Index <= 20)
      {
        f.iNumSTTPlan = Convert.ToInt32(lblTech2.Tag);
        f.mlblTech = lblTech2.Text;
      }
      else if (Index > 20 && Index <= 27)
      {
        f.iNumSTTPlan = Convert.ToInt32(lblTech3.Tag);
        f.mlblTech = lblTech3.Text;
      }

      //  On pose l'IP a modifier dans la pic0
      f.pic0.Tag = picSource.Tag;
      (f.pic0.Tag as picTag).sInter = myTab[4] + myTab[5] + "heures";

      f.pic0.Visible = true;

      picSource.Visible = false;

      f.DebutSemaineSTT = mdSemaine;
      f.ShowDialog();
    }
  }
}