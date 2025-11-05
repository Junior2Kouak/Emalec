using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartNet;
using MozartUC;
using MozartLib;
using ReportEmalec.Net;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace MozartCS
{
  public static class UtilsPlan
  {

    /* OK --------------------------------------------------------------------------------------- */
    public static void TexteEtCouleurJour(apiLabel label, DateTime dDate)
    {
      //  Affichage des jours de la semaine (prise en compte des congés)
      //  For i = 0 To 6
      label.Text = dDate.ToString("dddd d MMM", CultureInfo.CurrentUICulture);
      if (ModuleMain.IsFeriee(dDate))
        label.BackColor = Color.Red;
      else
      {
        if (dDate.DayOfWeek == DayOfWeek.Saturday || dDate.DayOfWeek == DayOfWeek.Sunday)
        {
          label.BackColor = Color.Black;
          label.ForeColor = Color.White;
        }
        else
          label.BackColor = Color.LightBlue;
      }
    }

    /* OK --------------------------------------------------------------------------------------- */
    public static bool VerificationsSTT(int nIpl, int NSITNUM, int NumAction)
    {
      if (VerifKiabi(nIpl))
        if (VerifInfosClientSTT(nIpl, NumAction))
          if (VerifAide(nIpl, NumAction, bSTT: true))
            if (VerifRDV(nIpl, NumAction, bSTT: true))
              if (VerifMailFranceLoisir(nIpl, NumAction))
                return true;
      return false;
    }
    //Public Function Verifications(ByVal nIpl As Long, ByVal NSITNUM As Long) As Boolean
    //  
    //  Verifications = True
    //  
    //    If VerifKiabi(nIpl) Then
    //        If VerifInfosClient(nIpl) Then
    //          If VerifAide(nIpl) Then
    //            If VerifRDV(nIpl) Then
    //              If VerifMailFranceLoisir(nIpl) Then
    //                Exit Function
    //              End If
    //            End If
    //          End If
    //        End If
    //    End If
    //  Verifications = False
    //      
    //End Function

    /* OK --------------------------------------------------------------------------------------- */
    public static bool Verifications(int nIpl, int NSITNUM, int nTech = 0, int NACTNUM = 0, bool bDateMmJr = true, string sDatePla = "")
    {
      if (VerifDroits(nIpl))
        if (VerifAuto(nIpl))
          if (VerifESTEE(nIpl))
            if (VerifLockAction(nIpl))
              if (VerifInfosClient(nIpl, NACTNUM, bDateMmJr))
                if (VerifDateSouhaiteLimite(nIpl, sDatePla, NACTNUM))
                  if (VerifAide(nIpl, NACTNUM))
                    if (VerifRDV(nIpl, NACTNUM))
                      if (VerifBlocage(nIpl))
                        if (VerifNacelleTech(nIpl, nTech, NACTNUM))
                          if (VerifCompTech(nIpl, nTech, NACTNUM))
                            if (VerifTechInterdit(nIpl, nTech, NSITNUM, NACTNUM))
                              if (VerifSiteOuvert(NSITNUM, sDatePla))
                                if (VerifTechDevis(NACTNUM, nTech, nIpl))
                                  return true;

      return false;
    }
    //    Public Function Verifications(ByVal nIpl As Long, ByVal NSITNUM As Long, Optional ByVal nTech As Integer, Optional ByVal NACTNUM As Long, Optional ByVal bDateMmJr As Boolean, Optional ByVal sDatePla As String) As Boolean
    //
    //    Verifications = True
    //
    //    If VerifDroits(nIpl) Then
    //      If VerifAuto(nIpl) Then
    //          If VerifESTEE(nIpl) Then
    //            If VerifLockAction(nIpl) Then
    //              If VerifInfosClient(nIpl, bDateMmJr) Then
    //                If VerifdateSouhaiteLimite(nIpl, sDatePla, NACTNUM) Then
    //                  If VerifAide(nIpl) Then
    //                    If VerifRDV(nIpl) Then
    //                      If VerifBlocage(nIpl) Then
    //                        If VerifNacelleTech(nIpl, nTech, NACTNUM) Then
    //                          If VerifCompTech(nIpl, nTech, NACTNUM) Then
    //                            If VerifTechInterdit(nIpl, nTech, NSITNUM, NACTNUM) Then
    //                              If VerifSiteOuvert(NSITNUM, sDatePla) Then
    //                                If VerifTechDevis(NACTNUM, nTech, nIpl) Then
    //                                  Exit Function
    //                                End If
    //                              End If
    //                            End If
    //                          End If
    //                        End If
    //                      End If
    //                    End If
    //                  End If
    //                End If
    //              End If
    //          End If
    //        End If
    //      End If
    //    End If
    //
    //    Verifications = False
    //
    //End Function

    /* OK --------------------------------------------------------------------------------------- */
    internal static void BlocagePave(int iNumIp, string sTag)
    {
      //  mise a jour de toutes les actions du pavé
      //  blocage si pas de blocage et  déblocage si blocage
      ModuleData.ExecuteNonQuery($"update TACTCOMP set BACTPAVEBLOCK = {(sTag == "D" ? "1" : "0")} " +
                                 $"from TACT inner join TACTCOMP C on c.nactnum=tact.nactnum where NIPLNUM = {iNumIp}");
    }

    /* OK --------------------------------------------------------------------------------------- */
    private static int RechercheClient(int nIpl, int nACTNUM)
    {
      string sSql = $"SELECT NCLINUM FROM TACT WITH (NOLOCK) INNER JOIN TSIT WITH (NOLOCK) ON TSIT.NSITNUM=TACT.NSITNUM {(nIpl == 0 ? $"WHERE NACTNUM = {nACTNUM}" : $"WHERE NIPLNUM = {nIpl}")}";
      return (int)ModuleData.ExecuteScalarInt(sSql);
    }

    /* OK --------------------------------------------------------------------------------------- */
    private static bool GetClientIsPrevKPIDateDepasse(int nACTNUM, string sDatePla, int nIpl)
    {
      bool bRet = false;
      using (SqlDataReader dr = ModuleData.ExecuteReader($"EXEC [api_sp_GetClientIsKPIPrev] {nACTNUM}, {nIpl}"))
      {
        while (dr.Read())
        {
          if (dr["CPRECOD"].ToString() == "P" && Convert.ToBoolean(dr["NCLI_KPI_PLA_PREV"]) && Convert.ToDateTime(dr["DACTDAT"]) < Convert.ToDateTime(sDatePla))
          {
            bRet = true;
            break;
          }
        }
      }
      return bRet;
    }
    //    Private Function GetClientIsPrevKPIDateDepasse(ByVal p_NACTNUM As Long, ByVal sDatePla As String, ByVal p_nIpl As Long) As Boolean
    //    Dim bResult As Boolean
    //    bResult = False
    //    Dim lRs As New ADODB.Recordset
    //    lRs.Open "EXEC [api_sp_GetClientIsKPIPrev] " & p_NACTNUM & ", " & p_nIpl, cnx, adOpenStatic, adLockReadOnly
    //    If lRs.RecordCount > 0 Then
    //        Do While lRs.EOF = False
    //            If lRs("CPRECOD") = "P" And lRs("NCLI_KPI_PLA_PREV") = True And CDate(lRs("DACTDAT")) < CDate(sDatePla) Then
    //                bResult = True
    //                Exit Do
    //            End If
    //            lRs.MoveNext
    //        Loop
    //    End If
    //    lRs.Close
    //    Set lRs = Nothing
    //    GetClientIsPrevKPIDateDepasse = bResult
    //End Function

    /* OK --------------------------------------------------------------------------------------- */
    public static bool VerifAide(int nIpl, int NumAction, bool bMsg = true, bool bSTT = false)
    {
      bool bRet = true;
      if (nIpl == 0) return bRet;

      string sSql = $"SELECT COUNT(*) FROM TACT T1 WITH (NOLOCK), TACT T2 WITH (NOLOCK)";
      if (!bSTT)
      {
        sSql += $" WHERE T1.NIPLNUM = {nIpl} ";
        sSql += $"AND T1.NSITNUM = T2.NSITNUM AND T1.DACTPLA = T2.DACTPLA AND T1.NPERNUM <> coalesce(T2.NPERNUM,'') AND T1.CACTTYT = 'T' AND T2.CACTTYT = 'T'";
      }
      else
      {
        sSql += $" WHERE T1.NACTNUM = {NumAction} ";
        sSql += $"AND T1.NDINNUM = T2.NDINNUM AND T1.NSITNUM = T2.NSITNUM AND T1.DACTPLA = T2.DACTPLA AND T1.NINTNUM <> coalesce(T2.NINTNUM,'')";
      }

      if ((int)ModuleData.ExecuteScalarInt(sSql) > 0)
      {
        if (bMsg)
        {
          if (bSTT)
            bRet = MessageBox.Show(Resources.msg_deplacement_planif_action_groupee
                                + "\r\n" + Resources.msg_verif_consequence + "\r\n\r\n" + Resources.msg_dde_continuer, Program.AppTitle,
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes;
          else
          {
            frmMessageBoxPerso f = new frmMessageBoxPerso();
            f.msTypeMessage = "AIDE_TECH";
            f.ShowDialog();
            bRet = f.mbOK;
          }
        }
        else
          bRet = false;
      }
      return bRet;
    }
    //Private Function VerifAide(ByVal nIpl As Long, Optional bMsg As Boolean = True) As Boolean
    //Dim lRs As ADODB.Recordset
    //Dim strSQL As String
    //
    //  VerifAide = True
    //  If nIpl = 0 Then Exit Function
    //  
    //  strSQL = "SELECT COUNT(*) FROM TACT T1 WITH (NOLOCK), TACT T2 WITH (NOLOCK) WHERE T1.NACTNUM = " & miNumAction & " AND T1.NDINNUM = T2.NDINNUM "
    //  strSQL = strSQL & " AND T1.NSITNUM = T2.NSITNUM AND T1.DACTPLA = T2.DACTPLA AND T1.NINTNUM <> coalesce(T2.NINTNUM,'')  "
    //
    //  Set lRs = cnx.Execute(strSQL)
    //  If lRs(0) > 0 Then
    //    If bMsg Then
    //      If MsgBox("§Attention, vous allez déplacer la planification d'une action groupée. Il y a plusieurs techniciens ou sous traitants planifiés au même moment pour réaliser cette prestation.§" & vbCrLf & "§Vérifiez les conséquences§" & vbCrLf & vbCrLf & "§Voulez-vous continuer ?§", vbExclamation + vbYesNo + vbDefaultButton2) = vbYes Then
    //        VerifAide = True
    //      Else
    //        VerifAide = False
    //      End If
    //    Else
    //        VerifAide = False
    //    End If
    //  End If
    //  lRs.Close
    //
    //End Function

    /* OK --------------------------------------------------------------------------------------- */
    public static bool VerifAuto(int nIpl)
    {
      if (nIpl == 0) return true;
      if (MozartParams.NomSociete.ToUpper() != "EMALEC") return true;

      //  Droit sur le planning : interdit de modifier mais pouvoir planifier la première fois
      if (!ModuleMain.RechercheDroitMenu(535))
      {
        MessageBox.Show(Resources.msg_pas_droits_deplac_suppr_inter + "\r\n" + Resources.msg_action_sera_annulee, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return false;
      }
      return true;
    }

    public static bool VerifBlocage(int nIpl)
    {
      bool bRet = true;

      if (nIpl == 0) return bRet;

      if ((int)ModuleData.ExecuteScalarInt($"SELECT COUNT(*) FROM TACT WITH (NOLOCK) INNER JOIN TACTCOMP WITH (NOLOCK) ON TACTCOMP.NACTNUM = TACT.NACTNUM WHERE BACTPAVEBLOCK = 1  AND NIPLNUM = {nIpl}") > 0)
      {
        MessageBox.Show(Resources.msg_action_bloquee_service_planif + "\r\n" + Resources.msg_action_sera_annulee, Program.AppTitle,
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        bRet = false;
      }
      return bRet;
    }

    private static bool VerifCompTech(int nIpl, int nTech, int nACTNUM)
    {
      bool bRet = true;

      if (nTech == 0) return bRet;

      string sSql = $"SELECT NTYPECONTRAT FROM TACT A WITH (NOLOCK), TDIN D WITH (NOLOCK) WHERE D.NDINNUM = A.NDINNUM AND NCLINUM <> {MozartParams.SOCIETE}";
      using (SqlDataReader dr = ModuleData.ExecuteReader(sSql + (nIpl == 0 ? $" AND NACTNUM = {nACTNUM}" : $" AND NIPLNUM = {nIpl}")))
      {
        while (dr.Read())
        {
          // on regarde si le technicien a la bonne compétence (sauf pour hors contrat)
          if (Convert.ToInt32(dr["NTYPECONTRAT"]) != 48)
            if ((int)ModuleData.ExecuteScalarInt("SELECT count(*) FROM TPERTYPECONTRAT WHERE NPERNUM = " + nTech + " AND NTYPECONTRAT ='" + dr["NTYPECONTRAT"] + "'") == 0)
              bRet = false;
        }
      }
      if (bRet == false)
        bRet = MessageBox.Show(Resources.msg_tech_sans_competence_inter + "\r\n\r\n" + Resources.msg_dde_continuer, Program.AppTitle,
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes;

      return bRet;
    }

    private static bool VerifDateSouhaiteLimite(int nIpl, string sDatePla, int nACTNUM)
    {
      // la date souhaitée est utilisée comme limite de planification
      // pour tous les clients : modif demandé par sylvie et validé par jean. le 18/07/2016 par MC

      // nouvelle demande de Sylvie le 16/09/2020
      // traitement spécial pour le client PRIMARK  17571 (on bloque tous les pavés)

      if (sDatePla == "") return true;

      string sSql;

      int iClient = RechercheClient(nIpl, nACTNUM);

      if (nIpl == 0)
      {
        // Hors prev
        if (iClient == 17571)
          sSql = $"SELECT ISNULL(DACTDAT, 0)  FROM TACT WITH (NOLOCK) INNER JOIN TDIN WITH (NOLOCK) ON TDIN.NDINNUM = TACT.NDINNUM WHERE NACTNUM = {nACTNUM}";
        else
        {
          // test si kip prev, test si prev
          if (GetClientIsPrevKPIDateDepasse(nACTNUM, sDatePla, nIpl))
            MessageBox.Show(Resources.msg_planif_depasse_date_contractuelle, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          sSql = $"SELECT ISNULL(DACTDAT, 0)  FROM TACT WITH (NOLOCK) INNER JOIN TDIN WITH (NOLOCK) ON TDIN.NDINNUM = TACT.NDINNUM WHERE CPRECOD NOT IN ('P', 'R', 'F') AND NACTNUM = {nACTNUM}";
        }
      }
      else
      {
        // Hors prev
        if (iClient == 17571)
        {
          sSql = $"SELECT MIN(DACTDAT) FROM TACT WITH (NOLOCK) INNER JOIN TDIN WITH (NOLOCK) ON TDIN.NDINNUM = TACT.NDINNUM WHERE NIPLNUM = {nIpl}";
        }
        else
        {
          // test si kip prev, test si prev
          if (GetClientIsPrevKPIDateDepasse(nACTNUM, sDatePla, nIpl))
            MessageBox.Show(Resources.msg_planif_depasse_date_contractuelle, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

          sSql = $"SELECT MIN(DACTDAT) FROM TACT WITH (NOLOCK) INNER JOIN TDIN WITH (NOLOCK) ON TDIN.NDINNUM = TACT.NDINNUM WHERE CPRECOD NOT IN ('P', 'R', 'F') AND NIPLNUM = {nIpl}";

        }
       
      }

      object sDateSql = ModuleData.ExecuteScalarObject(sSql);
      if (sDateSql != null && sDateSql != DBNull.Value)
      {
        if (Convert.ToDateTime(sDatePla) > Convert.ToDateTime(sDateSql))
        {
          MessageBox.Show(Resources.txt_impossible_depasse_date_souhaitee, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return false;
        }
      }
      return true;
    }

    public static bool VerifDroits(int nIpl)
    {
      bool bRet = true;
      if (nIpl == 0) return bRet;
      int count = (int)ModuleData.ExecuteScalarInt($"SELECT count(*) FROM TDIN WITH (NOLOCK) INNER JOIN TAUT WITH (NOLOCK) ON  TDIN.NDINCTE = TAUT.NCANNUM" +
                      $" INNER JOIN TPER WITH (NOLOCK) ON TAUT.NPERNUM = TPER.NPERNUM INNER JOIN TACT WITH (NOLOCK) ON TDIN.NDINNUM = TACT.NDINNUM " +
                      $" WHERE TPER.NPERNUM = {MozartParams.UID} And TACT.NIPLNUM={nIpl}");
      if (count == 0)
      {
        MessageBox.Show(Resources.msg_pas_doits_deplac_suppr_1inter, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        bRet = false;
      }
      return bRet;
    }


    private static bool VerifESTEE(int nIpl)
    {
      if (nIpl == 0) return true;
      if (MozartParams.NomSociete.ToUpper() != "EMALEC") return true;

      //  test si droit modif planif pour ESTEE LAUDER
      //  droit sur le planning : interdit de modifier sauf pour jullien, chevalier, le diot
      int Nb = (int)ModuleData.ExecuteScalarInt($"SELECT COUNT(*) FROM TACT WITH (NOLOCK) INNER JOIN TMAILBLOCKPLA WITH (NOLOCK) " +
                                                $"ON TACT.NACTNUM = TMAILBLOCKPLA.NACTNUM WHERE NIPLNUM = {nIpl}");
      if (Nb > 0 && ModuleMain.RechercheDroitMenu(538))
      {
        MessageBox.Show(Resources.msg_modif_interdite_client_informe + "\r\n" + Resources.msg_voir_Michel_ou_Jean + "\r\n" + Resources.msg_action_sera_annulee, Program.AppTitle,
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return false;
      }
      return true;
    }

    private static bool VerifInfosClient(int nIpl, int numAction, bool bDateMmJr)
    {
      bool bRet = true;

      if (nIpl == 0) return bRet;

      if ((int)ModuleData.ExecuteScalarInt($"SELECT count(CACTINFOMAG) FROM TACT WITH (NOLOCK) WHERE CACTINFOMAG = 'O' AND NIPLNUM = {nIpl}") > 0)
      {
        if (bDateMmJr == false)
        {
          MessageBox.Show(Resources.msg_modif_impossible_site_informe + "\r\n"
                        + Resources.txt_deplacer_par_replanif_meme_jour_ou_suppr, Program.AppTitle,
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          bRet = false;
        }
        else
          MessageBox.Show(Resources.txt_Site_informe_passage_tech, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      return bRet;
    }
    //Private Function VerifInfosClient(ByVal nIpl As Long, ByVal bDateMmJr As Boolean) As Boolean
    //Dim lRs As ADODB.Recordset
    //Dim strSQL As String
    //Dim sMes As String

    //  VerifInfosClient = True
    //  If nIpl = 0 Then Exit Function

    //  strSQL = "SELECT count(CACTINFOMAG) FROM TACT WITH (NOLOCK) WHERE CACTINFOMAG = 'O' AND NIPLNUM = " & nIpl
    //  Set lRs = cnx.Execute(strSQL)
    //  If lRs(0) > 0 Then
    //        If bDateMmJr = False Then
    //              MsgBox "§Modification impossible car le site est informé du passage de notre technicien.§" & vbCrLf & "§Pour déplacer cette intervention, il faut obligatoirement la replanifier dans la même journée ou supprimer l'information du site§", vbInformation
    //            VerifInfosClient = False
    //        Else
    //            MsgBox "§Avertissement : le site a été informé du passage de notre technicien.§", vbInformation
    //        End If
    //  End If
    //  lRs.Close
    //End Function

    /* OK --------------------------------------------------------------------------------------- */
    public static bool VerifInfosClientSTT(int nIpl, int NumAction)
    {
      bool bRet = true;
      if (nIpl == 0) return bRet;

      if ((int)ModuleData.ExecuteScalarInt($"SELECT count(CACTINFOMAG) FROM TACT WITH (NOLOCK) WHERE CACTINFOMAG = 'O' AND NACTNUM = {NumAction}") > 0)
        if (MessageBox.Show(Resources.msg_chgt_planif_site_informe + "\r\n"
                          + Resources.msg_verif_consequences + "\r\n\r\n"
                          + Resources.msg_dde_continuer, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
          bRet = true;
        else
          bRet = false;

      return bRet;
    }

    public static bool VerifKiabi(int nIpl)
    {
      bool bRet = true;
      if (nIpl == 0) return bRet;

      //  droit sur les préventives KIABI
      //  on reprend les droits inscrits sur un bouton fictif (tag 216) pour l'affichage du champ
      int Nb = (int)ModuleData.ExecuteScalarInt($"SELECT count(*) FROM TACT WITH (NOLOCK), TDIN WITH (NOLOCK) WHERE NIPLNUM = {nIpl} AND NCLINUM = 255 AND CPRECOD = 'P' AND TDIN.NDINNUM = TACT.NDINNUM");
      if (Nb > 0)
      {
        if (ModuleMain.bAccesBouton("216") > 0)
          MessageBox.Show(Resources.msg_deplacement_prev_Kiabi_Sephora, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        else
        {
          MessageBox.Show(Resources.msg_deplacement_prev_Kiabi_Sephora_interdit + "\r\n" + Resources.msg_voir_direction + "\r\n" + Resources.msg_action_sera_annulee, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          bRet = false;
        }
      }

      return bRet;
    }

    public static bool VerifLockAction(int nIpl)
    {
      if (nIpl == 0) return true;

      // recherche si une action de l'IP n'est pas en cours de modification par quelqu'un
      // ne pas bloquer si on vient du détail de l'action
      SqlDataReader dr = ModuleData.ExecuteReader($"api_sp_ListeLockAction {nIpl}, {MozartParams.NumAction}");
      if (dr.Read())
      {
        MessageBox.Show(Resources.msg_action_en_cours_modif_par + dr[1] + Resources.txt_DI + dr[0] + ")" + "\r\n" + "Vous ne pouvez pas déplacer cette intervention actuellement !", Program.AppTitle,
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return false;
      }
      return true;
    }

    public static bool VerifMailFranceLoisir(int nIpl, int NumAction)
    {
      bool bRet = true;
      if (nIpl == 0) return bRet;

      // on regarde si les mails FRANCE LOISIRS des préventives sont partis ou pas
      string sSql = $"SELECT datediff(day,getdate(), DACTPLA) as Jour FROM TACT WITH (NOLOCK), TDIN WITH (NOLOCK) WHERE NACTNUM = {NumAction} AND NCLINUM = 879 " +
                    $"AND CPRECOD = 'P' AND TDIN.NDINNUM = TACT.NDINNUM";
      int? Nb = (int)ModuleData.ExecuteScalarInt(sSql);
      if (Nb == 0) return bRet;

      if (Nb > 20) { /*  rien, car le mail n'a pas ete envoyé */  }
      else
      {
        bRet = MessageBox.Show(Resources.msg_deplacement_prev_FranceLoisirs_mail_envoye_site + "\r\n\r\n" + Resources.msg_dde_continuer, Program.AppTitle,
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes;
      }

      return bRet;
    }

    private static bool VerifNacelleTech(int nIpl, int nTech, int nACTNUM)
    {
      bool bRet = true;

      if (nTech == 0) return bRet;

      string sSql;

      if (nIpl == 0)
        sSql = $"SELECT count(CACTNACEL) FROM TACT WITH (NOLOCK) WHERE CACTNACEL='O' AND NACTNUM = {nACTNUM}";
      else
        sSql = $"SELECT count(CACTNACEL) FROM TACT WITH (NOLOCK) WHERE CACTNACEL='O' AND NIPLNUM = {nIpl}";

      if ((int)ModuleData.ExecuteScalarInt(sSql) > 0)
      {
        if (ModuleData.ExecuteScalarString($"SELECT VPERPERMI FROM TPER WITH (NOLOCK) WHERE NPERNUM = {nTech}").Contains("C"))
          bRet = true;
        else
        {
          frmMessageBoxPerso f = new frmMessageBoxPerso();
          f.msTypeMessage = "NACELLE";
          f.ShowDialog();
          bRet = f.mbOK;
        }
      }
      return bRet;
    }

    public static bool VerifRDV(int nIpl, int NumAction, bool bSTT = false)
    {
      bool bRet = true;
      if (nIpl == 0) return bRet;

      string sSql = $"SELECT COUNT(*) FROM TACT WITH (NOLOCK) INNER JOIN TACTCOMP WITH (NOLOCK) ON TACTCOMP.NACTNUM = TACT.NACTNUM WHERE (ISNULL(TACT.VACTRDV, '') <> '' " +
                    $"OR ISNULL(TACTCOMP.VACTHRRDV, '') <> '')";
      if (!bSTT)
        sSql += $"AND TACT.NIPLNUM = {nIpl}";
      else
        sSql += $"AND TACT.NACTNUM = {NumAction}";

      if ((int)ModuleData.ExecuteScalarInt(sSql) > 0)
      {
        bRet = MessageBox.Show(Resources.msg_deplacement_planif_avec_rdv + "\r\n" + Resources.msg_verif_consequences + "\r\n\r\n"
                            + Resources.msg_dde_continuer, Program.AppTitle,
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes;
      }
      return bRet;
    }
    //Private Function VerifRDV(ByVal nIpl As Long) As Boolean
    //Dim lRs As ADODB.Recordset
    //Dim strSQL As String
    //
    //  VerifRDV = True
    //  If nIpl = 0 Then Exit Function
    //
    //  strSQL = "SELECT COUNT(*) FROM TACT WITH (NOLOCK) INNER JOIN TACTCOMP WITH (NOLOCK) ON TACTCOMP.NACTNUM = TACT.NACTNUM WHERE (ISNULL(TACT.VACTRDV, '') <> '' OR ISNULL(TACTCOMP.VACTHRRDV, '') <> '') AND TACT.NACTNUM = " & miNumAction
    //  Set lRs = cnx.Execute(strSQL)
    //  If lRs(0) > 0 Then
    //    If MsgBox("§Attention, vous allez déplacer la planification de cette action alors qu'il existe un rendez vous.§" & vbCrLf & "§Vérifiez les conséquences (information magasin, siège, technicien, chargé d'affaires, assistantes, ...)§" & vbCrLf & vbCrLf & "§Voulez-vous continuer ?§", vbExclamation + vbYesNo + vbDefaultButton2) = vbYes Then
    //      VerifRDV = True
    //    Else
    //      VerifRDV = False
    //    End If
    //  End If
    //  lRs.Close
    //End Function

    /* OK --------------------------------------------------------------------------------------- */
    private static bool VerifSiteOuvert(int nSITNUM, string sDatePla)
    {
      bool bRet = true;

      if ((int)ModuleData.ExecuteScalarInt($"SELECT COUNT(*) CPT FROM TFERMETURESITE WHERE NSITNUM = {nSITNUM} AND DDATEFERM = '{sDatePla}'") != 0)
      {
        MessageBox.Show($"Site indisponible le : {sDatePla} (fermeture exceptionnelle du site)", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        bRet = false;
      }
      return bRet;
    }
    //Private Function VerifSiteOuvert(ByVal NSITNUM As Long, ByVal sDate As String) As Boolean
    //  Dim rsfermeture As ADODB.Recordset

    //  ' on recherche les fermetures du sites
    //  VerifSiteOuvert = True
    //  Set rsfermeture = New ADODB.Recordset
    //  rsfermeture.Open "SELECT COUNT(*) CPT FROM TFERMETURESITE WHERE NSITNUM = " & NSITNUM & " AND DDATEFERM = '" & sDate & "'", cnx
    //  If rsfermeture("cpt") <> 0 Then
    //      MsgBox "Site indisponible le : " & sDate & " (fermeture exceptionnelle du site)"
    //      VerifSiteOuvert = False
    //      rsfermeture.Close
    //      Exit Function
    //  End If
    //  rsfermeture.Close
    //End Function

    /* OK --------------------------------------------------------------------------------------- */
    public static bool VerifTech(int ancTech, int newTech)
    {
      bool bRet = true;
      if (ancTech == 0 || newTech == 0) return bRet;

      // si c'est le meme tech on sort sans tester plus loin
      if (ancTech == newTech) return bRet;

      if ((int)ModuleData.ExecuteScalarInt($"SELECT NSTFNUM from TSTTECH WHERE NSTTNUM = {ancTech}")
       != (int)ModuleData.ExecuteScalarInt($"SELECT NSTFNUM from TSTTECH WHERE NSTTNUM = {newTech}"))
      {
        MessageBox.Show(Resources.msg_impossible_change_STT, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        bRet = false;
      }

      return bRet;
    }
    //Public Function VerifTech(ByVal ancTech As Long, ByVal newTech As Long) As Boolean
    //Dim aRs As ADODB.Recordset
    //Dim nRs As ADODB.Recordset
    // 
    //  VerifTech = True
    //  
    //  If (ancTech = 0 Or newTech = 0) Then Exit Function
    //  
    //  ' si c'est le meme tech on sort sans tester plus loin
    //  If ancTech = newTech Then Exit Function
    //  
    //  Set aRs = cnx.Execute("SELECT NSTFNUM from TSTTECH WHERE NSTTNUM = " & ancTech)
    //  Set nRs = cnx.Execute("SELECT NSTFNUM from TSTTECH WHERE NSTTNUM = " & newTech)
    //  
    //  If aRs(0) <> nRs(0) Then
    //    MsgBox "§Attention, vous ne devez pas changer de sous-traitant§", vbInformation
    //    VerifTech = False
    //  End If
    //  
    //  aRs.Close
    //  nRs.Close
    //  Set aRs = Nothing
    //  Set nRs = Nothing
    //  
    //End Function

    /* OK --------------------------------------------------------------------------------------- */
    private static bool VerifTechDevis(int nACTNUM, int nTech, int nIpl)
    {
      bool bRet = true;

      if (nTech == 0) return bRet;

      string sSql = "SELECT count(NWDEVNUM) AS CPT FROM TWDEVIS WITH (NOLOCK) INNER JOIN TACT WITH (NOLOCK) ON TWDEVIS.NACTNUM = TACT.NACTNUM " +
                $"WHERE TACT.NDINNUM in (SELECT NDINNUM FROM TACT WITH (NOLOCK) WHERE (NACTNUM = {nACTNUM} OR NIPLNUM = {nIpl}) AND VACTDES NOT LIKE '%AIDE AU TECHNICIEN%')";
      int c1 = (int)ModuleData.ExecuteScalarInt(sSql);
      if (c1 > 0)
      {
        sSql = "SELECT count(NWDEVNUM) AS CPT FROM TWDEVIS WITH (NOLOCK) INNER JOIN TACT WITH (NOLOCK) ON TWDEVIS.NACTNUM = TACT.NACTNUM " +
                 $"WHERE TACT.NDINNUM in (SELECT NDINNUM FROM TACT WITH (NOLOCK) WHERE (NACTNUM = {nACTNUM} OR NIPLNUM = {nIpl})) AND TWDEVIS.NPERNUM = {nTech}";
        int c2 = (int)ModuleData.ExecuteScalarInt(sSql);
        if (c2 == 0)
        {
          if (MessageBox.Show("Ce technicien n'est pas celui qui a fait le devis. Voulez-vous toutefois planifier ce technicien ?", Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
          {
            bRet = true;

            string sObs = MozartParams.strUID + " le " + DateTime.Now.ToString("dd/MM/yy HH:mm") + " : Planification volontaire d''un technicien autre que celui qui a fait le devis.";
            sSql = $"UPDATE TACT SET VACTOBS = '{sObs}' + CHAR(10) + CHAR(13) + VACTOBS WHERE (NIPLNUM = {nIpl} OR NACTNUM = {nACTNUM})" +
            " AND NDINNUM IN (SELECT NDINNUM FROM TACT WITH (NOLOCK) INNER JOIN TWDEVIS ON TWDEVIS.NACTNUM = TACT.NACTNUM " +
            $" WHERE (TACT.NACTNUM = {nACTNUM} OR TACT.NIPLNUM = {nIpl}))";
            ModuleData.ExecuteNonQuery(sSql);
          }
          else
            bRet = false;
        }
      }
      return bRet;
    }
    //Private Function VerifTechDevis(ByVal NACTNUM As Long, ByVal nTech As Long, ByVal nIpl As Long) As Boolean
    //Dim lRs1 As ADODB.Recordset
    //Dim lRs2 As ADODB.Recordset
    //Dim strSQL As String
    //Dim sObs As String
    //
    //  VerifTechDevis = True
    //  If nTech = 0 Then Exit Function
    //
    //  strSQL = "SELECT count(NWDEVNUM) AS CPT FROM TWDEVIS WITH (NOLOCK) INNER JOIN TACT WITH (NOLOCK) ON TWDEVIS.NACTNUM = TACT.NACTNUM " _
    //          & "WHERE TACT.NDINNUM in (SELECT NDINNUM FROM TACT WITH (NOLOCK) WHERE (NACTNUM = " & NACTNUM & " OR NIPLNUM = " & nIpl & ") AND VACTDES NOT LIKE '%AIDE AU TECHNICIEN%')"
    //  Set lRs1 = cnx.Execute(strSQL)
    //  If lRs1(0) > 0 Then
    //      strSQL = "SELECT count(NWDEVNUM) AS CPT FROM TWDEVIS WITH (NOLOCK) INNER JOIN TACT WITH (NOLOCK) ON TWDEVIS.NACTNUM = TACT.NACTNUM " _
    //          & "WHERE TACT.NDINNUM in (SELECT NDINNUM FROM TACT WITH (NOLOCK) WHERE (NACTNUM = " & NACTNUM & " OR NIPLNUM = " & nIpl & ")) AND TWDEVIS.NPERNUM = " & nTech
    //      Set lRs2 = cnx.Execute(strSQL)
    //      If lRs2(0) = 0 Then
    //        If MsgBox("Ce technicien n'est pas celui qui a fait le devis. Voulez-vous toutefois planifier ce technicien ?", vbYesNo) = vbYes Then
    //          VerifTechDevis = True
    //          sObs = gstrUID & " le " & Format(Now, "dd/MM/YY HH:MM") & " : Planification volontaire d''un technicien autre que celui qui a fait le devis."
    //          strSQL = "UPDATE TACT SET VACTOBS = '" & sObs & "' + CHAR(10) + CHAR(13) + VACTOBS WHERE (NIPLNUM = " & nIpl & " OR NACTNUM = " & NACTNUM & ")" _
    //                & " AND NDINNUM IN (SELECT NDINNUM FROM TACT WITH (NOLOCK) INNER JOIN TWDEVIS ON TWDEVIS.NACTNUM = TACT.NACTNUM " _
    //                & " WHERE (TACT.NACTNUM = " & NACTNUM & " OR TACT.NIPLNUM = " & nIpl & "))"
    //          cnx.Execute(strSQL)
    //        Else
    //          VerifTechDevis = False
    //        End If
    //      End If
    //      lRs2.Close
    //  End If
    //
    //  lRs1.Close
    //
    //End Function

    /* OK --------------------------------------------------------------------------------------- */
    private static bool VerifTechInterdit(int nIpl, int nTech, int nSITNUM, int nACTNUM)
    {
      bool bRet = true;

      if (nTech == 0 || nSITNUM == 0) return bRet;

      // TECH EN COURS INTERDIT
      int NbInterdits = (int)ModuleData.ExecuteScalarInt($"SELECT COUNT(*) FROM TTECHSITE WITH (NOLOCK) WHERE NSITNUM = {nSITNUM} AND NPERNUM = {nTech} AND CTYPE = 'I'");

      // AUTRES TECH OBLIGATOIRE?
      int NbAutresObligatoires = (int)ModuleData.ExecuteScalarInt($"SELECT COUNT(*) FROM TTECHSITE WITH (NOLOCK) WHERE NSITNUM = {nSITNUM} AND NPERNUM <> {nTech} AND CTYPE = 'O' AND NPERNUM NOT IN (SELECT NPERNUM FROM TPER WHERE CPERACTIF = 'N')");

      // TECH EN COURS OBLIGATOIRE
      int NbObligatoires = (int)ModuleData.ExecuteScalarInt($"SELECT COUNT(*) FROM TTECHSITE WITH (NOLOCK) WHERE NSITNUM = {nSITNUM} AND NPERNUM ={nTech} AND CTYPE = 'O'");

      if (NbInterdits > 0)
      {
        MessageBox.Show(Resources.msg_tech_interdit_site, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        bRet = false;
      }
      else if (NbObligatoires == 0)
      {
        if (NbAutresObligatoires > 0)
        {
          MessageBox.Show(Resources.msg_tech_obligatoire_site, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          bRet = false;
        }
      }
      return bRet;
    }
    //    Private Function VerifTechInterdit(ByVal nIp As Long, ByVal nTech As Integer, ByVal NSITNUM As Long, ByVal NACTNUM As Long) As Boolean
    //Dim sSQL As String
    //Dim rsVerifInt As ADODB.Recordset
    //Dim rsVerifObl As ADODB.Recordset
    //Dim rsVerifOblTech As ADODB.Recordset
    //
    //    VerifTechInterdit = True
    //
    //    If nTech = 0 Or NSITNUM = 0 Then Exit Function
    //    ' vérification interdiction et obligation tech sur site
    //  
    //    ' TECH EN COURS INTERDIT
    //    sSQL = "SELECT COUNT(*) FROM TTECHSITE WITH (NOLOCK) WHERE NSITNUM = " & NSITNUM & " AND NPERNUM = " & nTech & " AND CTYPE = 'I'"
    //    Set rsVerifInt = New ADODB.Recordset
    //    rsVerifInt.Open sSQL, cnx
    //  
    //    ' AUTRES TECH OBLIGATOIRE?
    //    sSQL = "SELECT COUNT(*) FROM TTECHSITE WITH (NOLOCK) WHERE NSITNUM = " & NSITNUM & " AND NPERNUM <> " & nTech & " AND CTYPE = 'O' AND NPERNUM NOT IN (SELECT NPERNUM FROM TPER WHERE CPERACTIF = 'N')"
    //    Set rsVerifObl = New ADODB.Recordset
    //    rsVerifObl.Open sSQL, cnx
    //  
    //    ' TECH EN COURS OBLIGATOIRE
    //    sSQL = "SELECT COUNT(*) FROM TTECHSITE WITH (NOLOCK) WHERE NSITNUM = " & NSITNUM & " AND NPERNUM = " & nTech & " AND CTYPE = 'O'"
    //    Set rsVerifOblTech = New ADODB.Recordset
    //    rsVerifOblTech.Open sSQL, cnx
    //
    //    If rsVerifInt(0) > 0 Then
    //        MsgBox "§Ce technicien est interdit sur ce site!§", vbCritical
    //        VerifTechInterdit = False
    //    ' on ne teste les tech obligatoire que sur les PREV
    //    ElseIf rsVerifOblTech(0) = 0 Then
    //          If rsVerifObl(0) > 0 Then
    //              MsgBox "§Il y a des techniciens obligatoires sur ce site!§", vbCritical
    //              VerifTechInterdit = False
    //          End If
    //    End If
    //
    //End Function

    /* OK --------------------------------------------------------------------------------------- */
    public static bool CompteOK(int numIpD, int numIpS, int numAct)
    {
      int nCteDest = (int)ModuleData.ExecuteScalarInt($"SELECT NDINCTE FROM TDIN WITH (NOLOCK),TACT WITH (NOLOCK) WHERE TDIN.NDINNUM=TACT.NDINNUM AND NIPLNUM = {numIpD}");
      if (numIpS == 0)
      {
        int nCteSource = (int)ModuleData.ExecuteScalarInt($"SELECT NDINCTE FROM TDIN WITH (NOLOCK),TACT WITH (NOLOCK) WHERE TDIN.NDINNUM=TACT.NDINNUM AND NACTNUM = {numAct}");
        return nCteDest == nCteSource;
      }
      else
      {
        int nCteSource = (int)ModuleData.ExecuteScalarInt($"SELECT NDINCTE FROM TDIN WITH (NOLOCK),TACT WITH (NOLOCK) WHERE TDIN.NDINNUM=TACT.NDINNUM AND NIPLNUM = {numIpS}");
        return nCteDest == nCteSource;
      }
    }

    public static int WeekOfDate(DateTime d)
    {
      return new GregorianCalendar(GregorianCalendarTypes.Localized).GetWeekOfYear(d, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
    }

    public static void EtatBlocage(int iNumIp, ref ToolStripMenuItem mnuBlocage)
    {
      bool lRes;

      SqlDataReader dr = ModuleData.ExecuteReader($"SELECT BACTPAVEBLOCK, isnull(VBLOCAGEPAVE,'') LIB from TACT inner join TACTCOMP C ON C.NACTNUM=TACT.NACTNUM WHERE NIPLNUM = {iNumIp}");
      if (dr.Read() && (Boolean.TryParse(dr["BACTPAVEBLOCK"].ToString(), out lRes)))
      {
        if (lRes)
        {
          mnuBlocage.Text = $"{Resources.txt_deblocage_pave} : {dr["LIB"]}";
          mnuBlocage.Tag = "B";
        }
        else
        {
          mnuBlocage.Text = $"{Resources.txt_blocage_pave} : {dr["LIB"]}";
          mnuBlocage.Tag = "D";
        }
      }
      else
      {
        mnuBlocage.Text = Resources.txt_blocage_pave;
        mnuBlocage.Tag = "D";
      }
    }

    public static void mnuDetails_Click(int iNumIp)
    {
      int iNumDI, iNumAction;
      // si on est pas sur une IP on sort
      if (iNumIp == 0) return;

      // affichage d'une fenetre avec detail de l'IP
      int NbAction = (int)ModuleData.ExecuteScalarInt($"select count(*) from TACT WITH (NOLOCK) where NIPLNUM = {iNumIp}");
      if (NbAction > 1)
      {
          new frmDetailIP
          {
            miNumIP = iNumIp
          }.ShowDialog();
      }
      else
      {
        // on garde les variables globales en mémoire
        iNumDI = MozartParams.NumDi;
        iNumAction = MozartParams.NumAction;

        int nActNum = 0, nDiNum = 0;

        using (SqlDataReader drA = ModuleData.ExecuteReader($"select NACTNUM, NDINNUM from TACT WITH (NOLOCK) where NIPLNUM = {iNumIp}"))
        {
          if (drA.Read())
          {
            nActNum = Convert.ToInt32(drA["NACTNUM"]);
            nDiNum = Convert.ToInt32(drA["NDINNUM"]);
          }
        }

        // recherche des droits sur cette DI
        string sSql = $"SELECT count(*) FROM TDIN WITH (NOLOCK) INNER JOIN TAUT WITH (NOLOCK) ON  TDIN.NDINCTE = TAUT.NCANNUM INNER JOIN TPER WITH (NOLOCK) " +
                      $"ON TAUT.NPERNUM = TPER.NPERNUM WHERE TPER.NPERNUM = {MozartParams.UID} AND  TDIN.NDINNUM = {nDiNum}";
        if (0 == (int)ModuleData.ExecuteScalarInt(sSql))
        {
          MessageBox.Show(Resources.msg_pasDroitsAccesDI + "\r\n" + "Voir avec votre responsable", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }
        else
        {
          //écran de modification de la demande
          MozartParams.NumAction = nActNum;
          MozartParams.NumDi = nDiNum;

            new frmAddAction
            {
              mstrStatutDI = "M",
            }.ShowDialog();

          // on revient donc on réinitialise les variables globales avec anciennes valeurs
          MozartParams.NumDi = iNumDI;
          MozartParams.NumAction = iNumAction;
        }
      }
    }
    //Private Sub mnuDetails_Click()
    //Dim rsD As New ADODB.Recordset
    //Dim rsa As New ADODB.Recordset
    //Dim rsDroit As New ADODB.Recordset
    //Dim liNumDI, llNumAction
    //
    //  ' si on est pas sur une IP on sort
    //  If iNumIp = 0 Then Exit Sub
    //    
    //  ' affichage d'une fenetre avec detail de l'IP
    //  rsD.Open "select count(*) from TACT WITH (NOLOCK) where NIPLNUM = " & iNumIp, cnx
    //      
    //  If rsD(0) > 1 Then
    //    frmDetailIP.miNumIP = iNumIp
    //    frmDetailIP.Show vbModal
    //  Else
    //    ' on garde les variables globales en mémoire
    //    rsa.Open "select NACTNUM, NDINNUM from TACT WITH (NOLOCK) where NIPLNUM = " & iNumIp, cnx
    //
    //    liNumDI = giNumDi
    //    llNumAction = glNumAction
    //  
    //    ' recherche des droits sur cette DI
    //    rsDroit.Open "SELECT count(*) FROM TDIN WITH (NOLOCK) INNER JOIN TAUT WITH (NOLOCK) ON  TDIN.NDINCTE = TAUT.NCANNUM " & _
    //             " INNER JOIN TPER WITH (NOLOCK) ON TAUT.NPERNUM = TPER.NPERNUM WHERE TPER.NPERNUM = " & gintUID & _
    //             " AND   TDIN.NDINNUM = " & rsa("NDINNUM"), cnx
    //             
    //    If rsDroit(0) = 0 Then
    //        MsgBox "§Vous n'avez pas les droits d'accès sur cette DI§"
    //        rsDroit.Close
    //        Exit Sub
    //    Else
    //      ' écran de modification de la demande
    //      frmAddAction.mstrStatutDI = "M"
    //      giNumDi = rsa("NDINNUM").value
    //      glNumAction = rsa("NACTNUM").value
    //        
    //      On Error Resume Next
    //      
    //      frmAddAction.Show vbModal
    //      
    //        
    //      If Err Then MsgBox "§Impossible d'afficher l'écran de détail de l'action car cet écran et déjà chargé en arrière plan§"
    //      
    //      ' on revient donc on réinitialise les variables globales avec anciennes valeurs
    //      giNumDi = liNumDI
    //      glNumAction = llNumAction
    //      rsDroit.Close
    //      rsa.Close
    //    End If
    //  End If
    //  rsD.Close
    //
    //  ' initialisation du planning pour prendre en compte les modifications
    //  Call Form_Load
    //  
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    public static void mnuEditionOTJour_Click(int iTechCourant, string ddatejour, int ipCourant)
    {
      if (MessageBox.Show(Resources.msg_dde_impression_OT_jour, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                      MessageBoxDefaultButton.Button2) == DialogResult.Yes)
      {
        string sSql = "select distinct tipl.niplnum, nsitnum, nactnum, niplind From tact WITH (NOLOCK), tipl WITH (NOLOCK) Where tact.nIplNUm = tipl.nIplNUm " +
                      $"and tact.npernum = {iTechCourant} and tipl.dipldatj = '{ddatejour}' ORDER BY NIPLIND";
        using (SqlDataReader drIpJour = ModuleData.ExecuteReader(sSql))
        {
          while (drIpJour.Read())
          {
            int nIplNum = (int)Utils.ZeroIfNull(drIpJour["NIPLNUM"]);
            if (Utils.ZeroIfNull(ipCourant) != nIplNum)
            {
              ipCourant = (int)Utils.ZeroIfNull(drIpJour["NIPLNUM"]);
              ImpressionOTtech(nIplNum, iTechCourant);

              // Impression des gammes si elles existent et du stock
              ImpressionDocuments(iTechCourant, Convert.ToInt32(drIpJour["NSITNUM"]), nIplNum, ddatejour);

              // fonction qui imprime la liste des equipements du site s'il y a une prev sur l'ip
              ImpressionEquiptSite(nIplNum, iTechCourant);

              // attestation de detection incendie si besoin => si prestation = travaux et contrat = detection incendie
              ImpressionDetectionIncendie(nIplNum);

              //attestion de manipulation de fuilde frigorigene => si prestation = dépannage et type contrat = clim niv 1 ,2,3
              ImpressionAttestationClim(nIplNum);
            }
          }
        }
      }
    }

    public static void mnuEditionOT_Click(int iTechCourant, string DebutSemaine, int ipCourant, int iSite, string strTypeEdition,
                                        ProgressBar ProgressBar1, string[] myTab, List<PictureBox> lstPic, bool bFax)
    {

      if (strTypeEdition == Resources.col_Tech)
      {
        //impression de toutes les IP de la semaine pour ce tech
        if (MessageBox.Show(Resources.msg_dde_impression_OT_semaine, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2) == DialogResult.Yes)
        {
          string sSql = $"select distinct tipl.niplnum, nsitnum, nactnum, niplind From tact WITH (NOLOCK), tipl WITH (NOLOCK) Where tact.nIplNUm = tipl.nIplNUm " +
                        $"and tact.npernum = {iTechCourant} and tipl.dipldatj BETWEEN DATEADD(dd, 0, '{DebutSemaine}') AND DATEADD(dd, 6, '{DebutSemaine}') ORDER BY dipldatj, NIPLIND";
          using (SqlDataReader drIpSemaine = ModuleData.ExecuteReader(sSql))
          {
            while (drIpSemaine.Read())
            {
              int nIplNum = (int)Utils.ZeroIfNull(drIpSemaine["NIPLNUM"]);
              if (Utils.ZeroIfNull(ipCourant) != nIplNum)
              {
                ipCourant = (int)Utils.ZeroIfNull(drIpSemaine["NIPLNUM"]);
                ImpressionOTtech(nIplNum, iTechCourant);

                // Impression des gammes si elles existent et du stock
                ImpressionDocuments(iTechCourant, Convert.ToInt32(drIpSemaine["NSITNUM"]), nIplNum, drIpSemaine["DIPLDATJ"].ToString());

                // fonction qui imprime la liste des equipements du site s'il y a une prev sur l'ip
                ImpressionEquiptSite(nIplNum, iTechCourant);

                // attestation de detection incendie si besoin => si prestation = travaux et contrat = detection incendie
                ImpressionDetectionIncendie(nIplNum);

                //attestion de manipulation de fuilde frigorigene => si prestation = dépannage et type contrat = clim niv 1 ,2,3
                ImpressionAttestationClim(nIplNum);
              }
            }
          }
        }
      }
      else // strTypeEdition == "IP"
      {
        if (MessageBox.Show(Resources.mdg_dde_impression_OT_tech, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2) == DialogResult.Yes)
        {
          // si on a une gamme fichier PDF alors on utilise la fonction FAX car impossible d'imprimer le PDF en direct
          if ((int)ModuleData.ExecuteScalarInt("SELECT NGAMTRAMENUM FROM TGAMCLIENT WHERE NGAMTRAMENUM = 0 AND NTRACLINUM in (SELECT NGAMNUM from TACT WITH (NOLOCK) where NGAMNUM <> 0 AND NIPLNUM = " + ipCourant + ")"
                                  + " UNION"
                                  + " SELECT VFICHIER FROM TACT WITH (NOLOCK) INNER JOIN TIMAC WITH (NOLOCK) ON TIMAC.NACTNUM = TACT.NACTNUM WHERE TIMAC.VTYPE = 'DOCTECH' AND TACT.NIPLNUM = " + ipCourant) == 0)
          {
            mnuFaxerOT_Click(ProgressBar1, iTechCourant, myTab, strTypeEdition, lstPic, bFax);
            return;
          }

          ImpressionOTtech(ipCourant, iTechCourant);

          // Impression des gammes si elles existent et du stock
          ImpressionDocuments(iTechCourant, iSite, ipCourant, DebutSemaine);

          // fonction qui imprime la liste des equipements du site s'il y a une prev sur l'ip
          ImpressionEquiptSite(ipCourant, iTechCourant);

          // attestation de detection incendie si besoin => si prestation = travaux et contrat = detection incendie
          ImpressionDetectionIncendie(ipCourant);

          //attestion de manipulation de fuilde frigorigene => si prestation = dépannage et type contrat = clim niv 1 ,2,3
          ImpressionAttestationClim(ipCourant);

        }
      }
    }

    public static void mnuFaxerOT_Click(ProgressBar ProgressBar1, int iNumTech, string[] myTab, string strTypeEdition, List<PictureBox> lstPic, bool bFax)
    {
      string DefaultPrinter = MyPrinter.DefaultPrinterName();

      if (MyPrinter.SetDefaultPrinter("PDFCreator") == false)
      {
        MessageBox.Show(Resources.msg_imp_PDF_indispo, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      int i = 1;
      ProgressBar1.Value = 0;
      ProgressBar1.Value = 7;
      ProgressBar1.Visible = true;

      //  Bug : si pendant la génération des documents on clique sur une pic alors ca change le inumTech et on imprime les OT de qq1 d'autre
      int iTechCourant = iNumTech;   // on passe par une variable locale

      // 2 cas :
      //  - impression de l'IP courante (OT + Gamme + Stock)
      //  - impression de toutes les IP de la semaine pour le tech (OT + Gamme + Stock)
      UtilsPlan.SuppressionFichiersPDF(MozartParams.strUID);

      string strFileOut = "";

      // si on est pas sur une IP on sort
      if (strTypeEdition == "IP")
      {
        ProgressBar1.Value = 1;
        strFileOut = $"{MozartParams.UID}{i++:000}_OTTechOut";
        UtilsPlan.ImpressionOTtech(Convert.ToInt32(myTab[1]), iTechCourant, strFileOut);
        ProgressBar1.Value = 2;
        UtilsPlan.AttenteFinImpressionPDF(strFileOut);

        // recherche des actions préventives de cette IP et impression de la gamme si existe
        UtilsPlan.ImpressionComplementsOT(ref i, myTab, bFax, ProgressBar1);
        ProgressBar1.Value = 3;
        UtilsPlan.AttenteFinImpressionPDF(strFileOut);

        // fonction qui imprime la liste des equipements du site s'il y a une prev sur l'ip
        strFileOut = $"{MozartParams.UID}{i++:000}_OTTechOut";
        UtilsPlan.ImpressionEquiptSite(Convert.ToInt32(myTab[1]), iTechCourant, strFileOut);
        ProgressBar1.Value = 4;
        UtilsPlan.AttenteFinImpressionPDF(strFileOut);

        // impression attestation detection incendie si besoin
        strFileOut = $"{MozartParams.UID}{i++:000}_DetectionOut";
        UtilsPlan.ImpressionDetectionIncendie(Convert.ToInt32(myTab[1]), strFileOut);
        ProgressBar1.Value = 5;
        UtilsPlan.AttenteFinImpressionPDF(strFileOut);

        // impression attestation clim si besoin
        strFileOut = $"{MozartParams.UID}{i++:000}_AttManipFluideFrigoOut";
        UtilsPlan.ImpressionAttestationClim(Convert.ToInt32(myTab[1]));
        ProgressBar1.Value = 6;
        UtilsPlan.AttenteFinImpressionPDF(strFileOut);

        // copie des PDF doc techniciens
        string strPathOut = $"{MozartParams.CheminUtilisateurMozart}PDF\\";
        UtilsPlan.ImpressionDocTechnicien(Convert.ToInt32(myTab[1]), strPathOut, 5);
        ProgressBar1.Value = 7;
      }

      else if (strTypeEdition == Resources.col_Tech)
      {
        if (MessageBox.Show(Resources.txt_dde_impresssion_tous_OT_semaine, Program.AppTitle,
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
          return;

        foreach (PictureBox pic in lstPic)
        {
          myTab = (pic.Tag as picTag).sTag.Split('#');
          if (Convert.ToInt32(myTab[7]) == iTechCourant)
            i += 2;
        }

        ProgressBar1.Maximum = i;
        i = 0;

        foreach (PictureBox pic in lstPic)
        {
          myTab = (pic.Tag as picTag).sTag.Split('#');
          if (Convert.ToInt32(myTab[7]) == iTechCourant)
          {
            i += 1;
            ProgressBar1.Value = i;

            strFileOut = $"{MozartParams.UID}{i++:000}_OTTechOut";
            UtilsPlan.ImpressionOTtech(Convert.ToInt32(myTab[1]), iTechCourant, strFileOut);
            UtilsPlan.AttenteFinImpressionPDF(strFileOut);

            // recherche des actions préventives de cette IP et impression de la gamme si existe
            UtilsPlan.ImpressionComplementsOT(ref i, myTab, bFax, ProgressBar1);
            UtilsPlan.AttenteFinImpressionPDF(strFileOut);

            // fonction qui imprime la liste des equipements du site s'il y a une prev sur l'ip
            strFileOut = $"{MozartParams.UID}{i++:000}_OTTechOut";
            UtilsPlan.ImpressionEquiptSite(Convert.ToInt32(myTab[1]), iTechCourant, strFileOut);
            UtilsPlan.AttenteFinImpressionPDF(strFileOut);

            // impression attestation detection incendie si besoin
            strFileOut = $"{MozartParams.UID}{i++:000}_DetectionOut";
            UtilsPlan.ImpressionDetectionIncendie(Convert.ToInt32(myTab[1]), strFileOut);
            UtilsPlan.AttenteFinImpressionPDF(strFileOut);

            // impression attestation clim si besoin
            strFileOut = $"{MozartParams.UID}{i++:000}_AttManipFluideFrigoOut";
            UtilsPlan.ImpressionAttestationClim(Convert.ToInt32(myTab[1]));
            UtilsPlan.AttenteFinImpressionPDF(strFileOut);

            // copie des PDF doc techniciens
            string strPathOut = $"{MozartParams.CheminUtilisateurMozart}PDF\\";
            UtilsPlan.ImpressionDocTechnicien(Convert.ToInt32(myTab[1]), strPathOut, 5);

            // on incrémente même si on a pas imprimé (pas génant pour l'ordre d'assemblage)
            ProgressBar1.Value = ++i;
          }
        }
        //  Remettre l'imprimante de départ
        ProgressBar1.Value = ProgressBar1.Maximum - 1;
        Thread.Sleep(300);
        UtilsPlan.AssemblagePDF(MozartParams.UID, MozartParams.UID);
        ProgressBar1.Value = ProgressBar1.Maximum - 1;

        Cursor.Current = Cursors.Default;
        //ReinitImprimanteWord();
        MyPrinter.SetDefaultPrinter(DefaultPrinter);

        frmBrowser f = new frmBrowser();
        f.msBrowseText = "";
        f.msInfosMail = $"TPER|NPERNUM|{iNumTech}";
        f.msStartingAddress = $@"{MozartParams.CheminUtilisateurMozart}PDF\" + MozartParams.UID + ".pdf";
        f.ShowDialog();      // Mail possible
        ProgressBar1.Visible = false;
        bFax = false;
      }
    }

    public static string ImpressionOTtech(long NumIP, long NumSite, string strFileOut = "")
    {
      //si on est pas sur une IP on sort
      if (NumIP == 0) return "";

      if (strFileOut == "")
        strFileOut = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\Mozart\\PDF\\{NumIP}.pdf";

      new frmMainReport
      {
        bLaunchByProcessStart = false,
        sTypeReport = ModuleMain.ChoixModelOTDevExpress(NumIP),
        sIdentifiant = $"{NumIP}",
        InfosMail = $"TPER|NPERNUM|0",
        sNomSociete = MozartParams.NomSociete,
        sLangue = ModuleMain.CodePays(ModuleMain.GetPays("TSIT", "VSITPAYS", "NSITNUM", NumSite.ToString())).Substring(0, 2),
        sOption = "PDF"
      }.ShowDialog();

      //string[,] TdbGlobal = { { "", "" } };

      //frmBrowser f = new frmBrowser();
      //f.ImprimerFichier($"{MozartParams.CheminModeles}{ModuleMain.CodePays(ModuleMain.GetPays("TSIT", "VSITPAYS", "NSITNUM", NumSite.ToString()))}" +
      //                  $"{ModuleMain.ChoixModelOT(NumIP)}",
      //                  strFileOut,
      //                  TdbGlobal,
      //                  $"exec api_sp_OrdreDeTravail {NumIP}");
      return strFileOut;
    }

    public static string ImpressionAttestationClim(int nIplNum, string strFileOut = "")
    {
      string[,] TdbGlobal = { { "Date", DateTime.Now.ToShortDateString() } };

      string sSQL = $"SELECT NACTNUM FROM TACT WITH (NOLOCK), TDIN WITH (NOLOCK) WHERE TACT.NDINNUM = TDIN.NDINNUM AND NIPLNUM = {nIplNum} " +
                    $"AND TDIN.NTYPECONTRAT in (19, 20, 121) AND CPRECOD in ('D', 'T', 'P') and CTECCOD = 'C' and CACTTYT = 'T'";

      using (SqlDataReader dr = ModuleData.ExecuteReader(sSQL))
      {
        while (dr.Read())
        {
          if (strFileOut == "")
            strFileOut = @"TAttManipFluFrigoOut.rtf";

          new frmBrowser().ImprimerFichier($"{MozartParams.CheminModeles}{MozartParams.Langue}\\TAttManipFluFrigo.rtf",
                             strFileOut,
                             TdbGlobal,
                             $"api_sp_ImpAttFluFrigo {dr["NACTNUM"]}");

          Thread.Sleep(500);           // pb word
        }
      }
      return strFileOut;
    }
    //Public Function ImpressionAttestationClim(ByVal nIpActNum As Long, Optional strFileOut As String = "")
    //
    //Dim TdbGlobal(0 To 1, 0 To 1) As Variant
    //Dim rsAdo As ADODB.Recordset
    //Dim sSQL As String
    //
    //  On Error Resume Next
    //  Set rsAdo = New ADODB.Recordset
    //
    //  sSQL = "SELECT NACTNUM FROM TACT WITH (NOLOCK), TDIN WITH (NOLOCK) WHERE TACT.NDINNUM = TDIN.NDINNUM" _
    //      & " AND NIPLNUM = " & nIpActNum & " AND TDIN.NTYPECONTRAT in (19,20,121)" _
    //      & " AND CPRECOD in ('D','T','P') and CTECCOD = 'C' and CACTTYT = 'T'"
    //
    //  rsAdo.Open sSQL, cnx
    //
    //  While Not rsAdo.EOF
    //
    //        If strFileOut = "" Then strFileOut = "\TAttManipFluFrigoOut.rtf"
    //        ' impression du procès verbal de la detection incendie
    //            ImprimerFichier gstrCheminModeles & gstrLangue & "\" & "TAttManipFluFrigo.rtf", _
    //                        strFileOut, _
    //                        TdbGlobal(), _
    //                        "exec api_sp_ImpAttFluFrigo " & rsAdo("NACTNUM")
    //            MsgWaitObj 500           ' pb word
    //
    //      rsAdo.MoveNext
    //  Wend
    //  rsAdo.Close
    //  Set rsAdo = Nothing
    //
    //End Function

    /* OK --------------------------------------------------------------------------------------- */
    public static string ImpressionDetectionIncendie(int nIplNum, string strFileOut = "")
    {
      string[,] TdbGlobal = { { "Date", DateTime.Now.ToShortDateString() } };
      string sSQL = $"SELECT NACTNUM FROM TACT WITH (NOLOCK), TDIN WITH (NOLOCK) WHERE TACT.NDINNUM = TDIN.NDINNUM AND NIPLNUM = {nIplNum} AND TDIN.NTYPECONTRAT = 28 AND CPRECOD = 'T'";


      using (SqlDataReader dr = ModuleData.ExecuteReader(sSQL))
      {
        while (dr.Read())
        {
          if (strFileOut == "")
            strFileOut = $@"TDetectionIncendie{dr["NACTNUM"]}.rtf";

          // impression du procès verbal de la detection incendie
          new frmBrowser().ImprimerFichier($"{MozartParams.CheminModeles}{MozartParams.Langue}\\TDetectionIncendie.rtf",
                               strFileOut,
                               TdbGlobal,
                               $"api_sp_impPVDetectionIncendie {dr["NACTNUM"]}");
          Thread.Sleep(500);           // pb word
        }
      }
      return strFileOut;
    }
    //    Public Function ImpressionDetectionIncendie(ByVal nIpNum As Long, Optional strFileOut As String = "")
    //
    //Dim TdbGlobal(0 To 1, 0 To 1) As Variant
    //Dim rsAdo As ADODB.Recordset
    //Dim sSQL As String
    //
    //  On Error Resume Next
    //
    //  sSQL = "SELECT NACTNUM FROM TACT WITH (NOLOCK), TDIN WITH (NOLOCK) WHERE TACT.NDINNUM = TDIN.NDINNUM" _
    //      & " AND NIPLNUM = " & nIpNum & " AND TDIN.NTYPECONTRAT = 28" _
    //      & " AND CPRECOD = 'T'"
    //
    //  Set rsAdo = New ADODB.Recordset
    //  rsAdo.Open sSQL, cnx
    //  While Not rsAdo.EOF
    //
    //    If strFileOut = "" Then strFileOut = "\TDetectionIncendie" & rsAdo("NACTNUM") & ".rtf"
    //    
    //    ' impression du procès verbal de la detection incendie
    //    ImprimerFichier gstrCheminModeles & gstrLangue & "\" & "TDetectionIncendie.rtf", _
    //                strFileOut, _
    //                TdbGlobal(), _
    //                "exec api_sp_impPVDetectionIncendie " & rsAdo("NACTNUM")
    //
    //    MsgWaitObj 500           ' pb word
    //  
    //    rsAdo.MoveNext
    //  Wend
    //
    //  rsAdo.Close
    //
    //End Function

    /* OK --------------------------------------------------------------------------------------- */
    public static string ImpressionEquiptSite(int nIplNum, int iTechCourant, string strFileOut = "")
    {
      string[,] TdbGlobal = { { "Date", DateTime.Now.ToShortDateString() } };

      //on verifie qu'il existe une prev sur cette IP. Si ce n'est pas le cas, on sort de la fonction
      string sSQL = $"SELECT NSITNUM FROM TACT WITH (NOLOCK) WHERE NIPLNUM = {nIplNum} AND CPRECOD = 'P'";

      int iNumSite = (int)ModuleData.ExecuteScalarInt(sSQL);
      if (iNumSite > 0)
      {
        if (strFileOut == "") strFileOut = @"TStockSite_Gidt_Out" + nIplNum + ".rtf";

        sSQL = $"SELECT api_v_GIDT_ListeObjet.*, VCLINOM FROM api_v_GIDT_ListeObjet, TCLI WHERE NSITNUM = {iNumSite} and api_v_GIDT_ListeObjet.NCLINUM = TCLI.NCLINUM " +
               $"AND tcli.NCLINUM <> 664 ORDER BY VSITNOM, VNIV1, VNIV2, VNIV3, VOBJLIB ";
        if (ModuleData.ExecuteScalarInt(sSQL) != null)
          new frmBrowser().ImprimerFichier(MozartParams.CheminModeles + ModuleMain.CodePays(ModuleMain.GetPays("TPER", "VPERPAYS", "NPERNUM", iTechCourant.ToString())) + "TStockSite_Gidt.rtf",
                               strFileOut,
                               TdbGlobal,
                               sSQL);
      }

      return strFileOut;
    }
    //Private Sub ImpressionEquiptSite(ByVal NumIP As Long, ByVal NumTech As Integer, Optional strFileOut As String = "")
    //Dim rsAct As ADODB.Recordset
    //Dim rsGidt As ADODB.Recordset
    //Dim sSQL As String
    //Dim TdbGlobal(0 To 1, 0 To 1) As Variant
    //
    //  ' on verifie qu'il existe une prev sur cette ip
    //  ' si ce n'est pas le cas, on sort de la fonction
    //
    //  sSQL = "SELECT NSITNUM FROM TACT WITH (NOLOCK) WHERE NIPLNUM = " & NumIP & " AND CPRECOD = 'P'"
    //  Set rsAct = New ADODB.Recordset
    //  rsAct.Open sSQL, cnx
    //
    //  If rsAct.RecordCount > 0 Then
    //
    //    If strFileOut = "" Then strFileOut = "\TStockSite_Gidt_Out" & NumIP & ".rtf"
    //
    //    ' TB SAMSIC CITY SPEC
    //    If gstrNomGroupe = "EMALEC" Then
    //      sSQL = "SELECT api_v_GIDT_ListeObjet.*, VCLINOM FROM api_v_GIDT_ListeObjet, tcli" _
    //          & " WHERE NSITNUM = '" & rsAct("NSITNUM") & "'" _
    //          & " and api_v_GIDT_ListeObjet.nclinum = tcli.nclinum AND tcli.NCLINUM <> 664 ORDER BY VSITNOM, VNIV1, VNIV2, VNIV3, VOBJLIB "
    //      'GREG le 24/07/2008 : plus de liste des equipement pour SEPHORA
    //    End If ' TB SAMSIC CITY TODO -> adapter la requête
    //
    //    Set rsGidt = New ADODB.Recordset
    //    rsGidt.Open sSQL, cnx
    //
    //    If rsGidt.RecordCount > 0 Then
    //      ImprimerFichier gstrCheminModeles & CodePays(GetPays("TPER", "VPERPAYS", "NPERNUM", NumTech)) & "TStockSite_Gidt.rtf", _
    //            strFileOut, TdbGlobal(), sSQL
    //    End If
    //
    //    rsGidt.Close
    //  End If
    //
    //  rsAct.Close
    //
    //End Sub

    //Private Sub mnuEditionOTJour_Click()
    //Dim TdbGlobal(0 To 1, 0 To 1) As Variant
    //Dim iTechCourant As Integer
    //Dim rsIpJour As ADODB.Recordset
    //Dim ipCourant As Long
    //
    //  On Error Resume Next
    //  TdbGlobal(0, 0) = "NOW"
    //  TdbGlobal(0, 1) = Date
    //
    //  iTechCourant = iNumTech
    //  
    //  If MsgBox("§Voulez-vous imprimer tous les OT de ce technicien pour ce jour ?§", vbYesNoCancel + vbQuestion + vbDefaultButton2) = vbYes Then
    //      Set rsIpJour = New ADODB.Recordset
    //      rsIpJour.Open "select distinct tipl.niplnum, nsitnum, nactnum, niplind From tact WITH (NOLOCK), tipl WITH (NOLOCK) Where tact.nIplNUm = tipl.nIplNUm and tact.npernum = " & iTechCourant & " and tipl.dipldatj = '" & ddatejour & "' ORDER BY NIPLIND", cnx
    //
    //      While Not rsIpJour.EOF
    //
    //        If ZeroIfNull(ipCourant) <> rsIpJour("NIPLNUM") Then
    //          ipCourant = rsIpJour("NIPLNUM")
    //    
    //          ImpressionOTtech rsIpJour("NIPLNUM"), iTechCourant
    //          MsgWaitObj 1000
    //          ImpressionDocuments iTechCourant, rsIpJour("NSITNUM"), rsIpJour("NIPLNUM"), ddatejour
    //          
    //          ' fonction qui imprime la liste des equipements du site s'il y a une prev sur l'ip
    //          ImpressionEquiptSite rsIpJour("NIPLNUM"), iTechCourant
    //          
    //          'attestation de detection incendie si besoin
    //          ' si prestation = travaux et contrat = detection incendie
    //          ImpressionDetectionIncendie rsIpJour("NIPLNUM")
    //          
    //          'attestion de manipulation de fuilde frigorigene
    //          'si prestation = dépannage et type contrat = clim niv 1 ,2,3
    //          ImpressionAttestationClim rsIpJour("NIPLNUM")
    //          
    //        End If
    //        rsIpJour.MoveNext
    //      Wend
    //      
    //      rsIpJour.Close
    //  Else
    //    Exit Sub
    //  End If
    //  
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private static bool ImpressionGamme(int iTech, int iNumsite, int iNumIP, int Jour, int NGAMNUM, string strFileOut = "", bool bFax = false, int iActNum = 0)
    {
      bool bRet = false;
      //string[,] TdbGlobal = { { "NOW", DateTime.Now.ToShortDateString() } };

      string sType = TestTypeGamme(iNumsite, iNumIP);  // c'est une gamme site
      int iNumGamme = TestTypeGamme(iNumsite, iNumIP) == "S" ? NGAMNUM - 1000 : NGAMNUM;

      if (sType == "C")
      {
        // si la gamme est un fichier externe
        using (SqlDataReader drGam = ModuleData.ExecuteReader($"SELECT TOP 1 NGAMTRAMENUM, VFICHIER FROM TGAMCLIENT WHERE NTRACLINUM = {NGAMNUM}"))
        {
          if (drGam.Read() && Convert.ToInt32(drGam["NGAMTRAMENUM"]) == 0)
          {
            if (bFax)
            {
              if (strFileOut == "") strFileOut = $@"TGammeOut{NGAMNUM}.rtf";

              // Recopier le fichier sélectionné sur le serveur
              File.Copy(drGam["VFICHIER"].ToString(), $"{MozartParams.CheminUtilisateurMozart}PDF{strFileOut}.pdf");
            }
            else
              new frmBrowser { msStartingAddress = drGam["VFICHIER"].ToString() }.ShowDialog();
          }
          else
          {
            string lPays;

            //  recherche du modèle selon gamme standard ou equipement
            if ((bool)ModuleData.ExecuteScalarObject($"SELECT BCLIGESTNUM FROM TCLI INNER JOIN TSIT ON TCLI.NCLINUM=TSIT.NCLINUM WHERE NSITNUM = {iNumsite}"))
            {
              lPays = "FR\\";
            }
            else
            {
              lPays = ModuleMain.CodePays(ModuleMain.GetPays("TPER", "VPERPAYS", "NPERNUM", iTech.ToString()));
            }

            new frmMainReport
            {
              bLaunchByProcessStart = false,
              sTypeReport = "TGAMME",
              sIdentifiant = $"{iNumGamme}|{iActNum}",
              InfosMail = "0|0|0",
              sNomSociete = MozartParams.NomSociete,
              sLangue = Strings.Left(lPays, 2),
              sOption = "PRINT"
            }.ShowDialog();

            //// impression de la gamme client
            //new frmBrowser().ImprimerFichier(MozartParams.CheminModeles + lPays + "TGamme.rtf",
            //                                 strFileOut, TdbGlobal,
            //                                  "exec api_sp_impGammeClient " + iNumGamme + ", " + iActNum);

            bRet = true;
          }
        }
      }
      else
      {
        // impression de la gamme site
        new frmMainReport
        {
          bLaunchByProcessStart = false,
          sTypeReport = "TGAMMESITE",
          sIdentifiant = $"{iNumsite}|{Jour}",
          InfosMail = "0|0|0",
          sNomSociete = MozartParams.NomSociete,
          sLangue = Strings.Left(ModuleMain.CodePays(ModuleMain.GetPays("TPER", "VPERPAYS", "NPERNUM", iTech.ToString())), 2),
          sOption = "PRINT"
        }.ShowDialog();
        //new frmBrowser().ImprimerFichier(MozartParams.CheminModeles + ModuleMain.CodePays(ModuleMain.GetPays("TPER", "VPERPAYS", "NPERNUM", iTech.ToString())) + "TGamme.rtf",
        //                                 strFileOut,
        //                                 TdbGlobal,
        //                                 $"exec api_sp_impTrameGammeSite {iNumsite}, {iTech}, {iNumsite}, '{Jour}'");
        bRet = true;
      }

      return bRet;
    }
    //Public Function ImpressionGamme(ByVal iTech As Long, ByVal iNumsite As Long, ByVal IP As Long, ByVal Jour As String, _
    //                                                  ByVal NGAMNUM As Long, Optional strFileOut As String = "", Optional bFax As Boolean = False, Optional ByVal iNumAct As Long) As Boolean
    //Dim TdbGlobal(0 To 1, 0 To 1) As Variant
    //Dim iNumGamme As Long
    //Dim sType As String
    //Dim rsGam As ADODB.Recordset
    //Dim rsMod As ADODB.Recordset
    //
    //  On Error Resume Next
    //  TdbGlobal(0, 0) = "NOW"
    //  TdbGlobal(0, 1) = Date
    //
    //  ImpressionGamme = False

    //  'mise en comm par MC le 18/08/2010 suite au dépassement de 1000 gammes client
    //    sType = TestTypeGamme(iNumsite, IP) ' c'est une gamme site
    //    If sType = "S" Then
    //        iNumGamme = NGAMNUM - 1000
    //    Else
    //        iNumGamme = NGAMNUM
    //    End If
    //
    //  If strFileOut = "" Then strFileOut = "\TGammeOut" & NGAMNUM & ".rtf"
    //
    //  If sType = "C" Then
    //    ' si la gamme est un fichier externe
    //    Set rsGam = New ADODB.Recordset
    //    rsGam.Open "SELECT TOP 1 NGAMTRAMENUM, VFICHIER FROM TGAMCLIENT WHERE NTRACLINUM = " & NGAMNUM, cnx
    //    If rsGam("NGAMTRAMENUM") = 0 Then
    //      If bFax Then
    //        Dim fs As New Scripting.FileSystemObject
    //        ' Recopier le fichier sélectionné sur le serveur
    //        fs.CopyFile rsGam("VFICHIER"), gstrCheminUtilisateur & "\Mozart\PDF" & strFileOut & ".pdf"
    //      Else
    //        frmBrowser.StartingAddress = rsGam("VFICHIER")
    //        frmBrowser.bPlanningAn = 0
    //        'frmBrowser.bPrintAuto = True
    //        frmBrowser.Show vbModal
    //      End If
    //    Else
    //      ' recherche du modèle selon gamme standard ou equipement
    //      Set rsMod = New ADODB.Recordset
    //      rsMod.Open "SELECT BCLIGESTNUM FROM TCLI INNER JOIN TSIT ON TCLI.NCLINUM=TSIT.NCLINUM WHERE NSITNUM = " & iNumsite, cnx
    //      If rsMod("BCLIGESTNUM") Then
    //        ' impression de la gamme client
    //        ImprimerFichier gstrCheminModeles & "FR\TGamme.rtf", _
    //                        strFileOut, _
    //                        TdbGlobal(), _
    //                        "exec api_sp_impGammeClient " & iNumGamme & ", " & iNumAct
    //        ImpressionGamme = True
    //      Else
    //        ' impression de la gamme client
    //        ImprimerFichier gstrCheminModeles & CodePays(GetPays("TPER", "VPERPAYS", "NPERNUM", iTech)) & "TGamme.rtf", _
    //                        strFileOut, _
    //                        TdbGlobal(), _
    //                        "exec api_sp_impGammeClient " & iNumGamme & ", " & iNumAct
    //        ImpressionGamme = True
    //      End If
    //      rsMod.Close
    //    End If
    //    rsGam.Close
    //  Else
    //      ' impression de la gamme site
    //      ImprimerFichier gstrCheminModeles & CodePays(GetPays("TPER", "VPERPAYS", "NPERNUM", iTech)) & "TGamme.rtf", _
    //                      strFileOut, _
    //                      TdbGlobal(), _
    //                      "exec api_sp_impTrameGammeSite " & iNumGamme & ", " & iTech & ", " & iNumsite & ", '" & Jour & "'"
    //      ImpressionGamme = True
    //  End If
    //
    //End Function

    /* OK --------------------------------------------------------------------------------------- */
    public static int ImpressionDocTechnicien(int nIplNum, string strPathOut = "", int i = 0)
    {
      string sFileNameDest = "";
      string sSql = $"SELECT NIMAGE, VFICHIER FROM TACT WITH (NOLOCK) INNER JOIN TIMAC WITH (NOLOCK) " +
                    $"ON TIMAC.NACTNUM = TACT.NACTNUM  WHERE TIMAC.VTYPE = 'DOCTECH' AND TACT.NIPLNUM = {nIplNum}";

      using (SqlDataReader dr = ModuleData.ExecuteReader(sSql))
      {
        while (dr.Read())
        {
          if (strPathOut != "")
            sFileNameDest = $"{MozartParams.UID}{i.ToString("000")}{dr["VFICHIER"]}";

          File.Copy($"{MozartParams.CheminDocTechnicien}{dr["VFICHIER"]}", strPathOut + sFileNameDest);
          i += 1;
        }
      }
      return i;
    }
    //Public Function ImpressionDocTechnicien(ByVal nIplNum As Long, Optional strPathOut As String = "", Optional i As Integer) As Integer
    //
    //Dim rsAdo As ADODB.Recordset
    //Dim sSQL As String
    //Dim sFileNameDest As String
    //
    //  On Error Resume Next
    //  Set rsAdo = New ADODB.Recordset
    //
    //  sSQL = "SELECT NIMAGE, VFICHIER FROM TACT WITH (NOLOCK) INNER JOIN" _
    //      & " TIMAC WITH (NOLOCK) ON TIMAC.NACTNUM = TACT.NACTNUM" _
    //      & " WHERE TIMAC.VTYPE = 'DOCTECH' AND TACT.NIPLNUM = " & nIplNum
    //
    //  rsAdo.Open sSQL, cnx
    //
    //  While Not rsAdo.EOF
    //      If strPathOut<> "" Then
    //        sFileNameDest = gintUID & "_" & Format(i, "000") & "_" & rsAdo("VFICHIER")
    //
    //        FileCopy gstrCheminDocTechnicien & rsAdo("VFICHIER"), strPathOut & sFileNameDest
    //        i = i + 1
    //      End If
    //      rsAdo.MoveNext
    //  Wend
    //  rsAdo.Close
    //  Set rsAdo = Nothing
    //
    // ImpressionDocTechnicien = i
    //
    //End Function

    /* OK --------------------------------------------------------------------------------------- */
    public static bool ImpressionDocuments(int iTech, int iNumsite, int iNumIP, string Jour, string strFileOut = "")
    {
      bool bRet = false;
      bool bImpStock = false;

      // recherche des actions préventives de cette IP et impression de la gamme si existe
      // recherche des actions de cette IP et impression de la gamme si existe
      using (SqlDataReader dr = ModuleData.ExecuteReader($"SELECT NGAMNUM, NACTNUM from TACT WITH (NOLOCK) where NGAMNUM <> 0 AND NIPLNUM = {iNumIP}"))
      {
        while (dr.Read())
        {
          if ((int)Utils.ZeroIfNull(dr["NGAMNUM"]) > 0)
          {
            bRet = ImpressionGamme(iTech, iNumsite, iNumIP, Convert.ToInt32(Jour), Convert.ToInt32(dr["NGAMNUM"]), "", false, Convert.ToInt32(dr["NACTNUM"]));
            if (bRet && TestTypeGamme(iNumsite, iNumIP) == "C")
              bImpStock = (bool)ModuleData.ExecuteScalarObject($"SELECT TOP 1 BSTOCKLIE FROM TGAMCLIENT WHERE NTRACLINUM = {dr["NGAMNUM"]}");
          }
        }
      }

      if (bImpStock)
        UtilsPlan.ImpressionStock(iTech, iNumsite, iNumIP, Jour);

      return bRet;
    }
    // Public Function ImpressionDocuments(ByVal iTech As Long, ByVal iNumsite As Long, ByVal IP As Long, ByVal Jour As String, Optional strFileOut As String = "") As Boolean
    //
    //Dim rsAdo As ADODB.Recordset
    //Dim bImpStock As Boolean
    //
    //  On Error GoTo handler
    //
    //  ImpressionDocuments = False
    //  bImpStock = False
    //
    //' recherche des actions préventives de cette IP et impression de la gamme si existe
    //' recherche des actions de cette IP et impression de la gamme si existe
    //  Set rsAdo = New ADODB.Recordset
    //
    //  rsAdo.Open "SELECT NGAMNUM, NACTNUM from TACT WITH (NOLOCK) where NGAMNUM <> 0 AND NIPLNUM = " & IP, cnx, adOpenStatic, adLockOptimistic
    //
    //  If rsAdo.EOF Then Exit Function
    //
    //  While Not rsAdo.EOF
    //    If ZeroIfNull(rsAdo("NGAMNUM")) = 0 Then
    //      bImpStock = False
    //    Else
    //      ImpressionDocuments = ImpressionGamme(iTech, iNumsite, IP, Jour, rsAdo("NGAMNUM"), , , rsAdo("NACTNUM"))
    //      MsgWaitObj 500           ' pb word
    //      If ImpressionDocuments Then
    //        If TestTypeGamme(iNumsite, IP) = "C" Then
    //            Dim rsStock As ADODB.Recordset
    //            Set rsStock = cnx.Execute("SELECT TOP 1 BSTOCKLIE FROM TGAMCLIENT WHERE NTRACLINUM = " & rsAdo!NGAMNUM)
    //            If rsStock(0) Then bImpStock = True
    //            rsStock.Close
    //        End If
    //      End If
    //    End If
    //    rsAdo.MoveNext    ' DI suivante dans l'OT
    //  Wend
    //
    //  Set rsAdo = Nothing
    //
    //  If Not ImpressionDocuments Then Exit Function
    //
    //  If bImpStock Then ImpressionStock iTech, iNumsite, IP, Jour
    //
    //  Exit Function
    //
    //handler:
    //  ShowError "ImpressionDocuments dans ModMain"
    //End Function

    /* OK --------------------------------------------------------------------------------------- */
    public static bool ImpressionStock(int iTech, int iNumsite, int IP, string Jour, string strFileOut = "")
    {
      bool bRet = false;

      string[,] TdbGlobal = { { "Copie", "Original" } };

      //  Recherche si ce client a une gestion des stocks et si ce site a des articles paramétrés et impression de la liste
      string sActif = ModuleData.ExecuteScalarString($"SELECT CACTIF from TSTOCKARTCLI TA, TSTOCKARTCLISIT TS WHERE TA.NCLINUM = TS.NCLINUM AND NSITNUM = {iNumsite}");
      if (sActif == "O")
      {
        //    ' impression de la gamme stock
        if (strFileOut == "")
          strFileOut = @"TStockSiteOut.rtf";

        new frmBrowser().ImprimerFichier(MozartParams.CheminModeles + ModuleMain.CodePays(ModuleMain.GetPays("TPER", "VPERPAYS", "NPERNUM", iTech.ToString())) + "TStockSite.rtf",
                                         strFileOut,
                                         TdbGlobal,
                                         $"exec api_sp_impStockSite {iNumsite}, {iTech}, '{Jour}'");
        bRet = true;
      }
      return bRet;
    }
    //Public Function ImpressionStock(ByVal iTech As Long, ByVal iNumsite As Long, ByVal IP As Long, ByVal Jour As String, Optional strFileOut As String = "") As Boolean
    //
    //Dim rsAdo As ADODB.Recordset
    //Dim TdbGlobal(0 To 1, 0 To 1) As Variant
    //
    //  On Error GoTo handler
    //  ImpressionStock = False
    //  ' recherche si ce client a une gestion des stocks
    //  ' si oui , recherche si ce site a des articles paramétrés et impression de la liste des article ou de la liste total sinon
    //  ' si non rien
    //  Set rsAdo = New ADODB.Recordset
    //  rsAdo.Open "select cactif from TSTOCKARTCLI, TSTOCKARTCLISIT where TSTOCKARTCLI.nclinum=TSTOCKARTCLISIT.nclinum AND NSITNUM=" & iNumsite, cnx, adOpenStatic, adLockOptimistic
    //  If rsAdo.EOF Then Exit Function
    //  If rsAdo(0) = "O" Then  ' si gestion de stock
    //    ' impression de la gamme stock
    //    TdbGlobal(0, 0) = "copie"
    //    TdbGlobal(0, 1) = "Original"

    //    If strFileOut = "" Then strFileOut = "\TStockSiteOut.rtf"


    //    ImprimerFichier gstrCheminModeles & CodePays(GetPays("TPER", "VPERPAYS", "NPERNUM", iTech)) & "TStockSite.rtf", _
    //                    strFileOut, _
    //                    TdbGlobal(), _
    //                    "exec api_sp_impStockSite " & iNumsite & "," & iTech & ",'" & Jour & "'"


    //    ImpressionStock = True
    //  End If
    //  rsAdo.Close
    //  Exit Function


    //handler:
    //  ShowError "ImpressionStock dans ModMain"
    //End Function  

    /* OK --------------------------------------------------------------------------------------- */
    public static void ImpressionComplementsOT(ref int i, string[] MyTab, bool bFax, ProgressBar ProgressBar1)
    {
      string sSql, strFileOut;
      bool bImpGamme = false;
      bool bImpStock = false;

      using (SqlDataReader dr = ModuleData.ExecuteReader($"SELECT NGAMNUM from TACT WITH (NOLOCK) where NGAMNUM <> 0 AND NIPLNUM = {MyTab[1]}"))
      {
        while (dr.Read())
        {
          // recherche si ce site ou ce client à une gamme et impression
          i += 1;
          strFileOut = $"{MozartParams.UID}_{i:000}_GammeOut";

          if (Utils.ZeroIfNull(dr["NGAMNUM"]) == 0)
            bImpGamme = false;
          else
          {
            bImpGamme = ImpressionGamme(Convert.ToInt32(MyTab[7]), Convert.ToInt32(MyTab[2]), Convert.ToInt32(MyTab[1]), Convert.ToInt32(MyTab[8]),
                                        Convert.ToInt32(dr["NGAMNUM"]), strFileOut, bFax, Convert.ToInt32(MyTab[3]));
            if (bImpGamme)
            {
              if (TestTypeGamme(Convert.ToInt32(MyTab[2]), Convert.ToInt32(MyTab[1])) == "C") // on ne traite uniquement que le cas des trames client
              {
                if (Convert.ToInt32(dr["NGAMNUM"]) < 0)
                  sSql = $"SELECT TOP 1 BSTOCKLIE FROM TGAMSITE WHERE NTRASITNUM = {dr["NGAMNUM"]}";
                else
                  sSql = $"SELECT TOP 1 BSTOCKLIE FROM TGAMCLIENT WHERE NTRACLINUM = {dr["NGAMNUM"]}";

                bImpStock = (bool)ModuleData.ExecuteScalarObject(sSql);
              }
              ProgressBar1.Value = i;
              AttenteFinImpressionPDF(strFileOut);
            }
          }
        }
      }

      if (bImpStock)
      {
        {
          i += 1;   // on incrémente même si on a pas imprimé (pas génant pour l'ordre d'assemblage)
          strFileOut = $"{MozartParams.UID}_{i:000}_StockOut";
          if (ImpressionStock(Convert.ToInt32(MyTab[7]), Convert.ToInt32(MyTab[2]), Convert.ToInt32(MyTab[1]), MyTab[8], strFileOut))
          {
            ProgressBar1.Value = i;
            AttenteFinImpressionPDF(strFileOut);
          }
        }
      }
    }
    //Private Sub ImpressionComplementsOT(i As Integer, MyTab)
    //Dim rsAdo As New ADODB.Recordset
    //Dim strFileOut As String
    //Dim bImpGamme As Boolean
    //Dim bImpStock As Boolean
    //
    //  bImpGamme = False
    //  bImpStock = False
    //
    //  rsAdo.Open "SELECT NGAMNUM from TACT WITH (NOLOCK) where NGAMNUM <> 0 AND NIPLNUM = " & MyTab(1), cnx, adOpenStatic, adLockOptimistic
    //
    //  While Not rsAdo.EOF
    //    ' recherche si ce site ou ce client à une gamme et impression
    //    i = i + 1
    //    strFileOut = gintUID & "_" & Format(i, "000") & "_GammeOut"
    //
    //    If ZeroIfNull(rsAdo("NGAMNUM")) = 0 Then
    //      bImpGamme = False
    //    Else
    //      bImpGamme = ImpressionGamme(MyTab(7), MyTab(2), MyTab(1), MyTab(8), rsAdo("NGAMNUM"), "\" & strFileOut, bFax, MyTab(3))
    //      If bImpGamme Then
    //        If TestTypeGamme(MyTab(2), MyTab(1)) = "C" Then ' on ne traite uniquement que le cas des trames client
    //          Dim rsStock As ADODB.Recordset
    //            If rsAdo!NGAMNUM < 0 Then
    //                Set rsStock = cnx.Execute("SELECT TOP 1 BSTOCKLIE FROM TGAMSITE WHERE NTRASITNUM = " & rsAdo!NGAMNUM)
    //            Else
    //                Set rsStock = cnx.Execute("SELECT TOP 1 BSTOCKLIE FROM TGAMCLIENT WHERE NTRACLINUM = " & rsAdo!NGAMNUM)
    //            End If
    //          If rsStock(0) Then bImpStock = True
    //          rsStock.Close
    //        End If
    //        ProgressBar1.value = i
    //        AttenteFinImpressionPDF strFileOut
    //      End If
    //    End If
    //    rsAdo.MoveNext    ' DI suivante dans l'OT
    //  Wend
    //  rsAdo.Close
    //
    //  If bImpStock Then
    //    i = i + 1   ' on incrémente même si on a pas imprimé (pas génant pour l'ordre d'assemblage)
    //    strFileOut = gintUID & "_" & Format(i, "000") & "_StockOut"
    //    If ImpressionStock(MyTab(7), MyTab(2), MyTab(1), MyTab(8), "\" & strFileOut) = True Then
    //      ProgressBar1.value = i
    //      AttenteFinImpressionPDF strFileOut
    //    End If
    //  End If
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    private static string TestTypeGamme(int iNumsite, int iNumIP)
    {
      string sSql = $"SELECT COUNT(*) FROM TGAMSITE WITH (NOLOCK) INNER JOIN TDIN WITH (NOLOCK) ON TDIN.NTYPECONTRAT = TGAMSITE.NTYPECONTRAT " +
                    $"INNER JOIN TACT WITH (NOLOCK) ON TDIN.NDINNUM = TACT.NDINNUM WHERE TGAMSITE.NSITNUM = {iNumsite} AND NIPLNUM = {iNumIP} " +
                    $"AND TACT.NGAMNUM = TGAMSITE.NTRASITNUM + 1000";  //on met le + 1000 pour la gamme site (voir ai_sp_combogamme)

      return (int)ModuleData.ExecuteScalarInt(sSql) > 0 ? "S" : "C";
    }
    //    Public Function TestTypeGamme(ByVal iSiteNum As Long, ByVal IP As Long) As String
    //
    //    Dim ado_TestGamme As New ADODB.Recordset
    //    Dim sReq As String
    //
    //    sReq = "SELECT COUNT(*) FROM TGAMSITE WITH (NOLOCK) INNER JOIN " & _
    //            "TDIN WITH (NOLOCK) ON TDIN.NTYPECONTRAT = TGAMSITE.NTYPECONTRAT INNER JOIN " & _
    //            "TACT WITH (NOLOCK) ON TDIN.NDINNUM = TACT.NDINNUM " & _
    //            "WHERE TGAMSITE.NSITNUM = " & CStr(iSiteNum) & " AND NIPLNUM = " & CStr(IP) & " " & _
    //            "AND TACT.NGAMNUM = TGAMSITE.NTRASITNUM + 1000" 'on mets le + 1000 pour la gamme site (voir ai_sp_combogamme)
    //
    //    ado_TestGamme.Open sReq, cnx, adOpenStatic, adLockReadOnly
    //    If ado_TestGamme.RecordCount > 0 Then
    //
    //        If CInt(ado_TestGamme(0).value) > 0 Then
    //            TestTypeGamme = "S"
    //        Else
    //            TestTypeGamme = "C"
    //        End If
    //
    //    End If
    //
    //
    //    ado_TestGamme.Close
    //    Set ado_TestGamme = Nothing
    //
    //End Function

    /* OK --------------------------------------------------------------------------------------- */
    public static string ReturnCodePaveBloque(bool p_BACTPAVEBLOCK)
    {
      return p_BACTPAVEBLOCK ? "(B)" : "";
    }
    //    Public Function ReturnCodePaveBloque(ByVal p_BACTPAVEBLOCK As Boolean) As String
    //    Select Case p_BACTPAVEBLOCK
    //        Case True
    //            ReturnCodePaveBloque = "(B)"
    //        Case Else
    //            ReturnCodePaveBloque = ""
    //    End Select
    //End Function

    /* OK --------------------------------------------------------------------------------------- */
    public static int GetMozart_Soc_By_Site(int p_NSITNUM)
    {
      return (int)ModuleData.ExecuteScalarInt($"api_sp_GetMozart_Soc_by_Site {p_NSITNUM}");
    }
    //    Public Function GetMozart_Soc_By_Site(ByVal p_NSITNUM As Long) As Long
    //  On Error GoTo handler

    //  GetMozart_Soc_By_Site = 0
    //
    //  Set rs = New ADODB.Recordset
    //  rs.Open "EXEC [api_sp_GetMozart_Soc_by_Site] " & p_NSITNUM, cnx, adOpenStatic, adLockReadOnly
    //
    //  If rs.EOF = False Then
    //    GetMozart_Soc_By_Site = rs(0).value
    //  End If
    //  rs.Close
    //Exit Function

    /* OK --------------------------------------------------------------------------------------- */
    public static string GetCodePostal(int iSite)
    {
      return $"{Resources.txt_Code_Postal} {ModuleData.ExecuteScalarString("SELECT VSITCP FROM TSIT WHERE NSITNUM = " + iSite)}";
    }

    /* OK --------------------------------------------------------------------------------------- */
    public static bool DemiJournee(int NumSite, int indice, string datepla)
    {
      string sSql = "SELECT COALESCE(NMATAPINT,0) as NMATAPINT FROM THORAIRES WHERE NSITNUM = " + NumSite + " and vjour = datename(weekday,'" + datepla + "')";
      int res = (int)ModuleData.ExecuteScalarInt(sSql);

      switch (res)
      {
        case 0:
          return true;
        case 1:
          return !(indice == 1 || indice == 2);
        case 2:
          return !(indice == 3 || indice == 4);
        case 3:
          return false;
        default:
          break;
      }
      return true;
    }

    /* OK --------------------------------------------------------------------------------------- */
    public static bool TestTechOK(int iTech, DateTime dateRef)
    {
      bool bRet = false;

      // recherche de la date de sortie
      object DateSortie = ModuleData.ExecuteScalarObject($"SELECT DPERSOR FROM TPER WHERE NPERNUM = {iTech}");
      if (DateSortie == null || DateSortie.ToString() == "")
        bRet = true;
      else
      {
        if (dateRef <= (DateTime)DateSortie)
          bRet = true;
      }
      return bRet;
    }

    /* OK --------------------------------------------------------------------------------------- */
    public static void AssemblagePDF(int sPrefix, int sOutFile)
    {
      string sExe, sArgs;
      string rep = $@"{MozartParams.CheminUtilisateurMozart}PDF\";

      if (!File.Exists($"{rep}pdfAsm.exe"))
      {
        MessageBox.Show(Resources.msg_utilitaireAssemblageNonDispo, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      if (File.Exists("pdftk.exe") && File.Exists("libiconv2.dll"))
      {
        sExe = "pdftk.exe";
        sArgs = $"{sPrefix}*.pdf cat output {sOutFile}.Pdf";
      }
      else
      {
        sExe = "PdfAsm .exe";
        sArgs = $"-M{sPrefix}*.pdf -d{sOutFile}.Pdf -a ";
      }

      Process p = new Process();
      p.StartInfo.FileName = sExe;
      p.StartInfo.WorkingDirectory = rep;
      p.StartInfo.Arguments = sArgs;
      p.Start();
      p.WaitForExit();

      AttenteFinImpressionPDF($"{rep}{sOutFile}.pdf");
    }
    //Public Sub AssemblagePDF(sPrefix As Variant, sOutFile As Variant)
    //Dim sCmd As String
    //
    //  On Error Resume Next
    //
    //  ChDrive(Left(cstPathPDFOut, 1))
    //  ChDir cstPathPDFOut
    //
    //  If Dir("pdfAsm.exe ") = "" Then
    //    MsgBox "§L'utilitaire d'assemblage n'est pas disponible sur ce poste§", , "§Erreur d'assemblage§"
    //    Exit Sub
    //  End If
    //
    //  If Dir("pdftk.exe") <> "" And Dir("libiconv2.dll") Then
    //    sCmd = "pdftk.exe " & sPrefix & "*.pdf cat output " & sOutFile & ".Pdf"
    //  Else
    //    sCmd = "PdfAsm -M" & sPrefix & "*.pdf -d" & sOutFile & ".Pdf -a "
    //  End If
    //
    //  ExecuteAndWait sCmd   'Shell sCmd
    //
    //  AttenteFinAssemblagePDF cstPathPDFOut & sOutFile & ".pdf"
    //
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    public static void AttenteFinImpressionPDF(string sFile)
    {
      int i = 0;

      Cursor.Current = Cursors.WaitCursor;
      do
      {
        FileInfo fi = new FileInfo(sFile);
        if (fi.Exists && fi.Length > 0)
          return;
        Thread.Sleep(50);
      } while (i++ < 100);

      Cursor.Current = Cursors.Default;
    }
    //Public Sub AttenteFinImpressionPDF(sFile As String)
    //Dim fs As New FileSystemObject
    //Dim F As File
    //Dim i As Integer
    //
    //  On Error Resume Next
    //  Screen.MousePointer = vbHourglass
    //  Do
    //    Set F = fs.GetFile(cstPathPDFOut & sFile & ".Pdf")
    //    ' Si le fichier a été trouvé ET si sa taille n'est pas à 0
    //    If Err = 0 Then
    //      If F.Size > 0 Then
    //        If Err = 0 Then Exit Do
    //      End If
    //    End If
    //    MsgWaitObj 50
    //    i = i + 1
    //  Loop While i< 100
    //
    //  Screen.MousePointer = vbDefault
    //End Sub

    /* OK --------------------------------------------------------------------------------------- */
    public static void SuppressionFichiersPDF(string sUID)
    {
      foreach (string F in Directory.GetFiles(MozartParams.CheminUtilisateurMozart + "PDF"))
      {
        if (Strings.Left(F, Strings.Len(sUID)) == sUID && Strings.LCase(Strings.Right(F, 3)) == "pdf" || Strings.LCase(Strings.Right(F, 3)) == "rtf")
          File.Delete(F);
      }
    }

    /* OK --------------------------------------------------------------------------------------- */
    public static void AddLogIPL(int nIplNum, string sType, string sCommentaire = "")
    {

      if (nIplNum == 0) return;
      string sLog = "";
      DataTable dtLog = new DataTable();

      if (sType == "S")
        sLog = Resources.txt_Suppr_planif + sCommentaire;
      else if (sType == "M")
        sLog = Resources.txt_modif_planif + sCommentaire;
      else if (sType == "C")
        sLog = Resources.txt_creation_planif + sCommentaire;
      else
        return;

      ModuleData.LoadData(dtLog, $"SELECT NACTNUM, NDINNUM FROM TACT WITH (NOLOCK) WHERE NIPLNUM = {nIplNum}");
      foreach (DataRow row in dtLog.Rows)
        ModuleData.ExecuteNonQuery($"INSERT INTO TLOG VALUES({row["NDINNUM"]},{row["NACTNUM"]},{nIplNum},'{sLog}','{MozartParams.strUID}', getdate())");
    }
    //    Public Sub AddLogIPL(ByVal nIplNum As Long, sType As String, Optional sCommentaire As String)
    //Dim rsAction As ADODB.Recordset
    //Dim sSQL As String
    //Dim sLog As String


    //  If nIplNum = 0 Then Exit Sub

    //  sSQL = "SELECT NACTNUM, NDINNUM FROM TACT WITH (NOLOCK) WHERE NIPLNUM = " & nIplNum


    //  Set rsAction = New ADODB.Recordset
    //  rsAction.Open sSQL, cnx

    //  If sType = "S" Then
    //    sLog = "§Suppression planification§" + sCommentaire
    //  ElseIf sType = "M" Then
    //    sLog = "§Modification planification§" + sCommentaire
    //  ElseIf sType = "C" Then
    //    sLog = "§Création planification§" + sCommentaire
    //  Else
    //    Exit Sub
    //  End If

    //  While Not rsAction.EOF
    //    sSQL = "INSERT INTO TLOG VALUES(" & rsAction("NDINNUM") & "," & rsAction("NACTNUM") & "," & nIplNum & ",'" & sLog & "','" & gstrUID & "', getdate())"
    //    cnx.Execute sSQL
    //    rsAction.MoveNext
    //  Wend
    //End Sub
  }

  public class picTag
  {
    public string sTag { get; set; }
    public string sInter { get; set; }
  }

  public class cmdPlusTag
  {
    public int iBtn { get; set; }
    public int iTech { get; set; }
    public string sDateJour { get; set; }
  }

}
