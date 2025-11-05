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
using System.Globalization;
using System.Reflection;
using System.Windows.Forms;
using MZCtrlResources = MozartControls.Properties.Resources;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmPlanSimpleSTT : Form
  {
    public DateTime DebutSemaineSTT;
    public int iNumSTTPlan;
    public string mlblTech = "";

    DataTable dtLun = new DataTable();
    DataTable dtMar = new DataTable();
    DataTable dtMer = new DataTable();
    DataTable dtJeu = new DataTable();
    DataTable dtVen = new DataTable();
    DataTable dtSam = new DataTable();
    DataTable dtDim = new DataTable();
    int iNbrImage = 0;
    int iNumIp = 0;
    int iNumSite;
    int miNumAction;
    string strTypeEdition;

    List<apiLabel> lstJours = new List<apiLabel>();
    List<apiLabel> lstHeures = new List<apiLabel>();
    List<PictureBox> lstPic = new List<PictureBox>();

    
    public frmPlanSimpleSTT() { InitializeComponent(); }

    private void frmPlanSimpleSTT_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        lstJours.Add(lJour0); lstJours.Add(lJour1); lstJours.Add(lJour2); lstJours.Add(lJour3); lstJours.Add(lJour4); lstJours.Add(lJour5); lstJours.Add(lJour6); lstJours.Add(lJour7);

        lstHeures.Add(lHeure0); lstHeures.Add(lHeure1); lstHeures.Add(lHeure2); lstHeures.Add(lHeure3); lstHeures.Add(lHeure4); lstHeures.Add(lHeure5);
        lstHeures.Add(lHeure6); lstHeures.Add(lHeure7); lstHeures.Add(lHeure8); lstHeures.Add(lHeure9); lstHeures.Add(lHeure10); lstHeures.Add(lHeure11);
        lstHeures.Add(lHeure12); lstHeures.Add(lHeure13); lstHeures.Add(lHeure14); lstHeures.Add(lHeure15); lstHeures.Add(lHeure16);

        lblTech.Text = mlblTech;

        InitPlanning();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void InitPlanning()
    {
      foreach (PictureBox item in lstPic)
      {
        this.Controls.Remove(item);
        item.Dispose();
      }

      lstPic.Clear();

      InitDataTables();

      InitialiserPlanning(dtLun);
      InitialiserPlanning(dtMar);
      InitialiserPlanning(dtMer);
      InitialiserPlanning(dtJeu);
      InitialiserPlanning(dtVen);
      InitialiserPlanning(dtSam);
      InitialiserPlanning(dtDim);
    }

    /* OK --------------------------------------------------------------------------------------- */
    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void InitDataTables()
    {
      try
      {
        DateTime dDate = DebutSemaineSTT;

        dtLun.Clear();
        dtLun.Load(ModuleData.ExecuteReader($"api_sp_listeInterventionsST {iNumSTTPlan}, '{dDate}', 0, 20"));
        TexteEtCouleurJour(Label10, dDate);
        dDate = dDate.AddDays(1);

        dtMar.Clear();
        dtMar.Load(ModuleData.ExecuteReader($"api_sp_listeInterventionsST {iNumSTTPlan}, '{dDate}', 0, 20"));
        TexteEtCouleurJour(Label11, dDate);
        dDate = dDate.AddDays(1);

        dtMer.Clear();
        dtMer.Load(ModuleData.ExecuteReader($"api_sp_listeInterventionsST {iNumSTTPlan}, '{dDate}', 0, 20"));
        TexteEtCouleurJour(Label12, dDate);
        dDate = dDate.AddDays(1);

        dtJeu.Clear();
        dtJeu.Load(ModuleData.ExecuteReader($"api_sp_listeInterventionsST {iNumSTTPlan}, '{dDate}', 0, 20"));
        TexteEtCouleurJour(Label13, dDate);
        dDate = dDate.AddDays(1);

        dtVen.Clear();
        dtVen.Load(ModuleData.ExecuteReader($"api_sp_listeInterventionsST {iNumSTTPlan}, '{dDate}', 0, 20"));
        TexteEtCouleurJour(Label14, dDate);
        dDate = dDate.AddDays(1);

        dtSam.Clear();
        dtSam.Load(ModuleData.ExecuteReader($"api_sp_listeInterventionsST {iNumSTTPlan}, '{dDate}', 0, 20"));
        TexteEtCouleurJour(Label15, dDate);
        dDate = dDate.AddDays(1);

        dtDim.Clear();
        dtDim.Load(ModuleData.ExecuteReader($"api_sp_listeInterventionsST {iNumSTTPlan}, '{dDate}', 0, 20"));
        TexteEtCouleurJour(Label16, dDate);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void TexteEtCouleurJour(apiLabel label, DateTime dDate)
    {
      //  Affichage des jours de la semaine (prise en compte des congés)
      //  For i = 0 To 6
      label.Text = dDate.ToString("dddd d MMM", CultureInfo.CurrentUICulture);
      if (ModuleMain.IsFeriee(dDate))
        label.BackColor = Color.Red;
      else
      {
        if (dDate.DayOfWeek == DayOfWeek.Saturday || dDate.DayOfWeek == DayOfWeek.Sunday)
          label.BackColor = Color.White;
        else
          label.BackColor = Color.LightBlue;
      }
    }

    private void InitialiserPlanning(DataTable dt)
    {
      try
      {
        int k = iNbrImage;

        DateTime datePla = new DateTime();

        //  Placement des interventions
        foreach (DataRow row in dt.Rows)
        {
          if (k >= 16 + iNbrImage)
            break;

          picTag myTag = new picTag();
          datePla = Convert.ToDateTime(row["DACTPLA"]);

          if ((int)row["NIPLSTIND"] > 4)
          {
            // Création d'une image
            k += 1;

            PictureBox pic = new PictureBox();

            //      Coordonnées de l'image (pb avec le dimanche car son weekday = 0)
            pic.Left = lstJours[datePla.DayOfWeek == DayOfWeek.Sunday ? 6 : (int)datePla.DayOfWeek - 1].Left;
            pic.Top = lstHeures[(int)row["NIPLSTIND"] - 5].Top;
            pic.Size = pic0.Size;

            // Constitution du tag d'une IP (code, NumIP, NumSite, NumAction(null), text, duree, premierJ , tech)
            myTag.sTag = "D#";
            myTag.sTag += $"{row["NIPLSTNUM"]}#";
            myTag.sTag += $"{row["NSITNUM"]}#";
            myTag.sTag += $"{row["NACTNUM"]}#";
            myTag.sTag += $"{row["VCLINOM"]}\r\n";
            myTag.sTag += $"{row["VSITNOM"]}\r\n#";
            myTag.sTag += $"{row["NACTDUR"]}#";
            myTag.sTag += $"{iNumSTTPlan}#";
            myTag.sTag += datePla.ToShortDateString();

            // Pour les sites emalec spéciaux couleur : jaune
            if (row["VCLINOM"].ToString() == MozartParams.NomSociete)
              pic.BackColor = Color.Yellow;   // &HFFFF &
            else
            {
              // couleur standard = bleu clair
              pic.BackColor = Color.FromArgb(192, 255, 255);  //&HFFFFC0
                                                              // si c'est la nuit :  rouge
              if (row["CACTNUIT"].ToString() == "O") pic.BackColor = Color.Red;
              // si c'est hors présence public :  rouge claire
              if (row["CACTNUIT"].ToString() == "P") pic.BackColor = Color.FromArgb(255, 192, 192);
              // si date d'execution : orange
              // si attachement (et exécution): Vert
              using (SqlDataReader drCode = ModuleData.ExecuteReader($"exec api_sp_ControleDateExec_Attach_STF {row["NACTNUM"]}"))
              {
                if (drCode.Read())
                {
                  if (Convert.ToInt32(drCode[0]) == 0) pic.BackColor = Color.FromArgb(255, 193, 125); // RGB(255, 193, 125)
                  if (Convert.ToInt32(drCode[1]) == 0) pic.BackColor = Color.FromArgb(192, 255, 192); ;  // &HC0FFC0
                }
              }
            }

            // Affichage des informations dans l'image
            myTag.sInter = $"{row["VCLINOM"]}\r\n{row["VSITNOM"]}\r\n {Convert.ToInt32(row["NACTDUR"])}h  {row["sCODE"]}";  // '& " " & ReturnCodePaveBloque(rs("BACTPAVEBLOCK"))

            if (row["VACTHRRDV"].ToString() != "") myTag.sInter += $" RV {row["VACTHRRDV"]}";

            pic.Tag = myTag;

            pic.Paint += new PaintEventHandler(pic_Paint);
            pic.MouseUp += new MouseEventHandler(pic_MouseUp);
            pic.MouseDown += new MouseEventHandler(pic_MouseDown);

            Controls.Add(pic);
            lstPic.Add(pic);
          }
        }
        //  Nombre d'images chargées
        iNbrImage = k;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    private void pic_Paint(object sender, PaintEventArgs e)
    {
      using (Font myFont = new Font("MS Sans Serif", 8))
        e.Graphics.DrawString(((sender as PictureBox).Tag as picTag).sInter, myFont, Brushes.Black, new Point(1, 2));
    }

    private void pic_MouseUp(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Right)
      {
        PictureBox pic = sender as PictureBox;

        string[] MyTabPic = (pic.Tag as picTag).sTag.Split('#');

        iNumIp = Convert.ToInt32(MyTabPic[1]);
        iNumSTTPlan = Convert.ToInt32(MyTabPic[6]);
        miNumAction = Convert.ToInt32(MyTabPic[3]);
        iNumSite = Convert.ToInt32(MyTabPic[2]);
        strTypeEdition = "IP";
        mnuCP.Visible = true;
        mnuCP.Text = UtilsPlan.GetCodePostal(iNumSite);
        mnuAffichage.Show(Cursor.Position);
      }
    }

    private void mnuDetails_Click(object sender, EventArgs e)
    {
      //  si on est pas sur une IP on sort
      if (iNumIp == 0) return;

      try
      {
        int iNumDI, iNumAction;

        //  On garde les variables globales en mémoire
        using (SqlDataReader dr = ModuleData.ExecuteReader("select TACT.NACTNUM, NDINNUM from TACT WITH (NOLOCK), TIPLST WITH (NOLOCK) where TACT.NACTNUM = TIPLST.NACTNUM AND NIPLSTNUM = " + iNumIp))
        {
          // On garde les anciennes valeurs
          iNumDI = MozartParams.NumDi;
          iNumAction = MozartParams.NumAction;

          try
          {
            // écran de modification de la demande
            frmAddAction fAdd = new frmAddAction();
            fAdd.mstrStatutDI = "M";
            MozartParams.NumDi = Convert.ToInt32(dr["NDINNUM"]);
            MozartParams.NumAction = Convert.ToInt32(dr["NACTNUM"]);
            fAdd.ShowDialog();
          }
          catch (Exception)
          {
            MessageBox.Show(Resources.msg_affich_impossible_ecran_charge, MZCtrlResources.Global_erreur,
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          }

          // on revient donc on réinitialise les variables globales avec anciennes valeurs
          MozartParams.NumDi = iNumDI;
          MozartParams.NumAction = iNumAction;
        }

        // initialisation du planning pour prendre en compte les modifications
        InitPlanning();
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
        // si on est pas sur une IP on sort
        if (iNumIp == 0) return;

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
    private void mnuEditionOT_Click(object sender, EventArgs e)
    {
      int iTechCourant = iNumSTTPlan;
      if (strTypeEdition == "TECH")
      {
        if (MessageBox.Show(Resources.msg_dde_impression_OT_semaine, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button2) == DialogResult.Yes)
        {
          foreach (PictureBox pic in lstPic)
          {
            // recherche des info dans le tag de l'image
            string[] myTab = (pic.Tag as picTag).sTag.Split('#');
            if (Convert.ToInt32(myTab[8]) == iTechCourant)
              new frmPlanSTT().ImpressionOTtech(Convert.ToInt32(myTab[1]), Convert.ToInt32(myTab[3]));   // IP et Action
          }
        }
        else
          return;
      }
      else if (strTypeEdition == "IP")
        new frmPlanSTT().ImpressionOTtech(iNumIp, miNumAction);
    }

    private void mnuVisu_Click(object sender, EventArgs e)
    {
      try
      {
        // si on est pas sur une IP on sort
        if (iNumIp == 0) return;

        new frmMainReport
        {
          bLaunchByProcessStart = false,
          sTypeReport = ModuleMain.ChoixModelOTDevExpress(iNumIp),
          sIdentifiant = $"{iNumIp}",
          InfosMail = $"TPER|NPERNUM|{iNumSTTPlan}",
          sNomSociete = MozartParams.NomSociete,
          sLangue = ModuleMain.CodePays(ModuleMain.GetPays("TPER", "VPERPAYS", "NPERNUM", iNumSTTPlan.ToString())).Substring(0, 2),
          sOption = "PREVIEW"
        }.ShowDialog();

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
        // si on est pas sur une IP on sort
        if (iNumIp == 0) return;

        //  Si l'action est exécutée, on ne peut pas la supprimer
        if (UtilsPlan.VerifKiabi(iNumIp) == false) return;

        // Confirmation de la suppression
        if (MessageBox.Show(Resources.msg_dde_suppr_planif, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button2) == DialogResult.Yes)
          ModuleData.ExecuteNonQuery($"api_sp_SupprimerIP_ST {miNumAction}");
        else
          return;

        // initialisation du planning
        InitPlanning();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void pic_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left && e.Clicks == 1)
      {
        PictureBox pic = sender as PictureBox;
        pic.DoDragDrop(pic, DragDropEffects.Move);
      }
    }

    private void form_DragEnter(object sender, DragEventArgs e)
    {
      e.Effect = DragDropEffects.Move;
    }

    private void form_DragOver(object sender, DragEventArgs e)
    {
      e.Effect = DragDropEffects.All;
    }

    private void form_DragDrop(object sender, DragEventArgs e)
    {
      try
      {
        int Top, Left;
        int indice = 0;
        string DatePla = "";
        bool Out = true;

        // Pas de move donc pas de Drop
        if (e.Effect != DragDropEffects.All) return;

        PictureBox picSource = (PictureBox)e.Data.GetData(typeof(PictureBox));

        Point clientPoint = this.PointToClient(new Point(e.X, e.Y));

        //  Conservation de la position initiale
        Left = picSource.Left;
        Top = picSource.Top;

        //  Recherche des info dans le tag de l'image
        string[] myTab = (picSource.Tag as picTag).sTag.Split('#');

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
            //iTech = iNumSTTPlan;
            indice = h + 5;
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
            DatePla = DebutSemaineSTT.AddDays(j).ToShortDateString();
            picSource.Left = lstJours[j].Left;
            break;
          }
        }

        //  Vérifications (déplacement d'une IP avec information au client, aide sur intervention, IP Emalec, action bloque)
        if (!UtilsPlan.VerificationsSTT(Convert.ToInt32(myTab[1]), Convert.ToInt32(myTab[2]), Convert.ToInt32(myTab[3])))
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
            cmd.Parameters["@iTech"].Value = iNumSTTPlan;
            cmd.ExecuteNonQuery();
          }
        }
        catch (Exception ex)
        {
          MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
        }

        if (myTab[0] == "D")
        {
          // si on ne change pas de jour, il ne faut pas réinitialiser
          if (DatePla != myTab[7])
          {
            ModuleData.ExecuteNonQuery($"update TACT set CACTINFOMAG ='N', VACTQUIINFO ='', VACTINFOQUI ='', DACTQUANDINFO = Null where NACTNUM = {myTab[3]}");

            // on met a jour la date de réalisation du devis de sous-traitance
            ModuleData.ExecuteNonQuery($"update TCST set DCSTDEL = '{DatePla}' where nactnum = {myTab[3]}");
          }
        }

        InitPlanning();   // réinitialisation de l'affichage
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
  }

}