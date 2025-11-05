using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartNet;
using MozartLib;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmAdminCompt : Form
  {
    public frmAdminCompt()
    {
      InitializeComponent();
    }

    private void frmAdminCompt_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void cmdStatTech_Click(object sender, EventArgs e)
    {
      new frmStatHeureTechInspTrav().ShowDialog();
    }

    private void cmdXferSalaires_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmTransfertSalaires().ShowDialog();
      Cursor = Cursors.Default;
    }

    private void cmdEtat_Click(object sender, EventArgs e)
    {
      new frmAdminEtatCompta().ShowDialog();
    }


    private void cmdCteAna_Click(object sender, EventArgs e)
    {
      new frmGestCompteAna().ShowDialog();
    }

    private void cmdTransfererFactures_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmChoixDateTransfert().ShowDialog();
      Cursor = Cursors.Default;
    }

    private void cmdHeureTech_Click(object sender, EventArgs e)
    {
      new frmTableAnalytiqueH().ShowDialog();
    }


    private void cmdHeuresCaff_Click(object sender, EventArgs e)
    {
      new frmTableAnalytiqueChaff("SUPERVISEUR").ShowDialog();
    }


    private void cmdCompte_Click(object sender, EventArgs e)
    {
      new frmListeCompteAnaByCliAndChaff().ShowDialog();
    }


    private void cmdTransfertCession_Click(object sender, EventArgs e)
    {
      Cursor = Cursors.WaitCursor;
      new frmChoixDateTransfertCession().ShowDialog();
      Cursor = Cursors.Default;
    }


    /* OK ---------------------------------------------------------------------*/
    //encodage vb6 ansi encodage c# utf8
    private void cmdTransfererHeures_Click(object sender, EventArgs e)
    {
      double dCumul = 0;
      double dCumul641 = 0;
      double dCumul642 = 0;
      string strD = "";

      string strMois = DateTime.Now.AddMonths(-1).Month.ToString();       //mois précédent;
      string strAnnee = DateTime.Now.AddMonths(-1).Year.ToString();       //Année précédente

      strMois = Interaction.InputBox("Saisir N° Mois", "Saisir N° Mois", strMois);
      if (strMois == "") return;
      strAnnee = Interaction.InputBox("Saisir Année", "Saisir Année", strAnnee);
      if (strAnnee == "") return;

      if (MessageBox.Show($"Vous allez transférer les heures du mois précédent ({strMois}/{strAnnee}){Environment.NewLine}" +
                          $"Voulez-vous vraiment transférer les heures en comptabilité ?", Program.AppTitle,
                          MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
        return;

      MessageBox.Show($"Vous allez lancer le calcul des heures du personnel pour le mois {strMois}/{strAnnee}{Environment.NewLine}" +
                      $"Celui-ci peut prendre plus d'une minute.", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      Cursor = Cursors.WaitCursor;

      strMois = Convert.ToInt16(strMois).ToString("00");

      ModuleData.ExecuteNonQuery($"delete thca from thca inner join tper on tper.npernum = thca.npernum where vsociete =" +
                     $" '{MozartParams.NomSociete}' and month(dhcadat) = {strMois} and year(dhcadat) = {strAnnee}");
      ModuleData.ExecuteNonQuery($"exec api_sp_MajHeurePersonnel '{MozartParams.NomSociete}', {strMois}, {strAnnee}");

      MessageBox.Show("Les heures sont désormais calculées, le transfert va démarrer.", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      Cursor = Cursors.Default;

      try
      {
        Cursor = Cursors.WaitCursor;

        //  ouverture du fichier
        string strFileCompta = Utils.RechercheParam("REP_COMPTA") + MozartParams.NomSociete + @"\ECRHeures.txt";

        int iNombre = 0;
        StringBuilder sData = new StringBuilder();

        using (SqlDataReader sdr = ModuleData.ExecuteReader($"api_sp_CalculHeureTechbis {strMois} , {strAnnee}"))
        {
          if (!sdr.HasRows)
          {
            MessageBox.Show(Resources.msg_pasDeLigesSelect, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
          }

          strD = $"01/{strMois}/{strAnnee}";
          strD = Convert.ToDateTime(strD).AddMonths(1).AddDays(-1).ToString("dd/MM/yy") + ";";

          while (sdr.Read())
          {
            //Une écriture par ligne
            //  
            // N° de pièce : mois/compte/personne(4)  0433BEN
            // Compte : 641999999
            // Date écriture : dernier jour du mois
            // Libellé : nom tech nb heures Ex: BEN ALI  3 Heures
            // Débit:    Montant heures * taux
            // Crédit:    rien
            // Echéance: rien
            // Répartition analytique: Compte client(32, 33)
            // Montant analytique: total ligne

            if (!(sdr["HEURES"].ToString() == "0" || sdr["COUT"].ToString() == "0" || sdr["COUT"] == DBNull.Value || sdr["HEURES"] == DBNull.Value))
            {
              //      compteur de lignes
              ++iNombre;
              sData.Append("ANA;"); //Code journal
              sData.Append(strMois + Strings.Right(sdr["COMPTE"].ToString(), 2) + Strings.Left(sdr["NOM"].ToString(), 4) + ";"); //Pièce
              sData.Append(sdr["CPERTYP"].ToString() == "TE" ? "642999999;" : "641999999;"); //Compte comptable - 9
              sData.Append(";"); //Code TVA
              sData.Append(strD); //Date écriture - 8 (dernier jour du mois)
              sData.Append(sdr["NOM"].ToString() + " " + sdr["HEURES"] + " heures" + ";"); //libellé
              //sData.Append(sdr["COUT"].ToString() + ",00;"); //Débit
              sData.Append("0,01;"); //Débit  on affiche 0.01 pour cacher les vrais chiffres confidentiels

              // cumul  général (on ajoute 1 centime par ligne car on affiche 1 centime par ligne)
              dCumul += Convert.ToDouble(sdr["COUT"]) + 0.01;

              // cumul par compte
              if (sdr["CPERTYP"].ToString() == "TE")
              {
                dCumul642 += Convert.ToDouble(sdr["COUT"]) + 0.01;
              }
              else
              {
                dCumul641 += Convert.ToDouble(sdr["COUT"]) + 0.01;
              }


              sData.Append(";"); //Crédit
              sData.Append(";"); //Echéance
              sData.Append(";"); //Type règlement
              sData.AppendLine(sdr["COMPTE"].ToString() + ";");
            }
          }
          sdr.Close();
        }

        // ajout des sous-totaux par compte ana
        // [api_sp_CalculHeureTechbisSousTotaux]
        using (SqlDataReader sdr = ModuleData.ExecuteReader($"api_sp_CalculHeureTechbisSousTotaux {strMois} , {strAnnee}"))
        {
          if (!sdr.HasRows)
          {
            return;
          }

          while (sdr.Read())
          {

            if (!(sdr["HEURES"].ToString() == "0" || sdr["COUT"].ToString() == "0" || sdr["COUT"] == DBNull.Value || sdr["HEURES"] == DBNull.Value))
            {
              sData.Append("ANA;"); //Code journal
              sData.Append(strMois + Convert.ToInt32(sdr["COMPTE"]).ToString("000") + "XXX;"); //Pièce
              sData.Append(sdr["J"].ToString() + ";"); //Compte comptable - 9
              sData.Append(";"); //Code TVA
              sData.Append(strD); //Date écriture - 8 (dernier jour du mois)
              sData.Append("TOTAL HEURES " + strMois + "/" + strAnnee + "-" + sdr["HEURES"] + " heures" + ";"); //libellé
              sData.Append(Strings.Format(sdr["COUT"], ".00") + ";"); //Débit
              sData.Append(";"); //Crédit
              sData.Append(";"); //Echéance
              sData.Append(";"); //Type règlement
              sData.AppendLine(sdr["COMPTE"].ToString() + ";");
            }
          }
          sdr.Close();
        }



        // Ecriture de la ligne de contrepartie globale
        // Contrepartie  compte 706996000 pour le total des 641999999 et 642999999
        // Crédit : total des lignes du dessus
        // Répartition analytique : 996
        // Montant analytique: total ligne

        sData.Append("ANA;"); //Code journal
        sData.Append(strMois + "XXXXXX;"); //Pièce
        sData.Append("706996000;"); //Compte comptable -9 
        sData.Append(";"); //Code TVA
        sData.Append(strD); //Data écriture - 8 (dernier jour du mois)
        sData.Append("TOTAL Heures analytiques - " + strMois + "/" + strAnnee + ";"); //Libellé
        sData.Append(";"); //Débit
        sData.Append(Strings.Format(dCumul, ".00") + ";"); //Crédit
        sData.Append(";;"); //Echéance et Type règlement
        sData.AppendLine("996;"); //analytique

        // Ecriture des lignes de neutralisation 
        // 3 lignes 
        // FG le 01/09/21

        sData.Append("ANA;"); //Code journal
        sData.Append(strMois + "XXXXXX;"); //Pièce
        sData.Append("641999999;"); //Compte comptable -9 
        sData.Append(";"); //Code TVA
        sData.Append(strD); //Data écriture - 8 (dernier jour du mois)
        sData.Append("NEUTRALISATION TRANSFERTS ANA - HEURES " + strMois + "/" + strAnnee + ";"); //Libellé
        sData.Append(";"); //Débit
        sData.Append(Strings.Format(dCumul641, ".00") + ";"); //Crédit
        sData.Append(";;"); //Echéance et Type règlement
        sData.AppendLine("99999;"); //analytique

        sData.Append("ANA;"); //Code journal
        sData.Append(strMois + "XXXXXX;"); //Pièce
        sData.Append("642999999;"); //Compte comptable -9 
        sData.Append(";"); //Code TVA
        sData.Append(strD); //Data écriture - 8 (dernier jour du mois)
        sData.Append("NEUTRALISATION TRANSFERTS ANA - HEURES " + strMois + "/" + strAnnee + ";"); //Libellé
        sData.Append(";"); //Débit
        sData.Append(Strings.Format(dCumul642, ".00") + ";"); //Crédit
        sData.Append(";;"); //Echéance et Type règlement
        sData.AppendLine("99999;"); //analytique

        sData.Append("ANA;"); //Code journal
        sData.Append(strMois + "XXXXXX;"); //Pièce
        sData.Append("706996000;"); //Compte comptable -9 
        sData.Append(";"); //Code TVA
        sData.Append(strD); //Data écriture - 8 (dernier jour du mois)
        sData.Append("NEUTRALISATION TRANSFERTS ANA - HEURES " + strMois + "/" + strAnnee + ";"); //Libellé
        sData.Append(Strings.Format(dCumul, ".00") + ";"); //Débit
        sData.Append(";"); //Crédit
        sData.Append(";;"); //Echéance et Type règlement
        sData.AppendLine("99999;"); //analytique

        // Ecriture de toutes les lignes en une seule fois
        File.WriteAllText(strFileCompta, sData.ToString());

        //  Copie de sauvegarde du fichier
        File.Copy(strFileCompta, Utils.RechercheParam("REP_COMPTA") + MozartParams.NomSociete + @"\archives\ECR-Heures-" + DateTime.Now.ToString("ddmmyyyyhhmmss") + ".txt");

        MessageBox.Show($"{Resources.msg_finPrepaFichier}{Environment.NewLine}{iNombre.ToString()}{Resources.txt_lignesTranf}", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally
      {
        Cursor = Cursors.Default;
      }
    }

    //Private Sub cmdTransfererHeures_Click()
    //
    //Dim rs As ADODB.Recordset
    //Dim fs As New Scripting.FileSystemObject
    //Dim ts As TextStream
    //Dim sData As String
    //Dim strDirCompta As String
    //Dim strMois As String
    //Dim strAnnee As String
    //Dim iNombre As Integer
    //Dim dCumul As Double
    //Dim bFirstLine As Boolean
    //Dim strD As String
    //
    //  strMois = Month(DateAdd("m", -1, Date))   ' mois précédent
    //  strAnnee = Year(DateAdd("m", -1, Date))   ' Année précédente
    //  
    //  strMois = InputBox("Saisir N° Mois", "Saisir N° Mois", strMois)
    //  If strMois = "" Then Exit Sub
    //  strAnnee = InputBox("Saisir Année", "Saisir Année", strAnnee)
    //  If strAnnee = "" Then Exit Sub
    //  
    //  If MsgBox("Vous allez transférer les heures du mois précédent (" & strMois & "/" & strAnnee & ")" & vbCrLf _
    //          & "Voulez-vous vraiment transférer les heures en comptabilité ?", vbYesNo + vbQuestion + vbDefaultButton2) = vbNo Then
    //    Exit Sub
    //  End If
    //  
    //  cnx.CommandTimeout = 300
    //  
    //  MsgBox "Vous allez lancer le calcul des heures du personnel pour le mois " & strMois & "/" & strAnnee & vbCrLf & "Celui-ci peut prendre plus d'une minute.", vbExclamation
    //  MousePointer = vbHourglass
    //
    //    cnx.Execute "delete thca from thca inner join tper on tper.npernum = thca.npernum where vsociete = '" & gstrNomSociete & " '" _
    //                & " and month(dhcadat) = " & strMois & " and year(dhcadat) = " & strAnnee
    //    cnx.Execute "exec api_sp_MajHeurePersonnel '" & gstrNomSociete & "', " & strMois & ", " & strAnnee
    //
    //  MsgBox "Les heures sont désormais calculées, le transfert va démarrer.", vbInformation
    //  MousePointer = vbDefault
    // 
    //  cnx.CommandTimeout = 30
    //  
    //  On Error GoTo handler
    //  MousePointer = vbHourglass
    //  
    //  ' ouverture du fichier
    //  strDirCompta = RechercheParam("REP_COMPTA") & gstrNomSociete & "\ECRHeures.txt"
    //
    // Set ts = fs.OpenTextFile(strDirCompta, ForWriting, True)
    //   
    //  ' ouverture du recordset des données
    //  Set rs = New ADODB.Recordset
    //  rs.Open "api_sp_CalculHeureTechbis " & strMois & ", " & strAnnee, cnx
    // 
    //  If rs.EOF Then
    //    MsgBox "§Pas de lignes sélectionnées§"
    //    Exit Sub
    //  End If
    //  
    //' Une écriture par ligne
    //  
    //'  N° de pièce : mois/compte/personne(4)  0433BEN
    //'  Compte : 641999999
    //'  Date écriture : dernier jour du mois
    //'  Libellé : nom tech nb heures Ex: BEN ALI  3 Heures
    //'  Débit:    Montant heures * taux
    //'  Crédit:    rien
    //'  Echéance: rien
    //'  Répartition analytique: Compte client(32, 33)
    //'  Montant analytique: total ligne
    //
    //  bFirstLine = True
    //  strD = "01/" & strMois & "/" & strAnnee
    //  strD = Format(DateAdd("d", -1, DateAdd("m", 1, strD)), "dd/mm/yy") & ";"
    //  
    //  While Not rs.EOF
    //    
    //    ccOffset = 0
    //    sData = ""
    //    
    //    ' on ne prend que les lignes non vides (heure ou cout)
    //    If rs("HEURES") = "0" Or rs("COUT") = "0" Or IsNull(rs("COUT")) Or IsNull(rs("HEURES")) Then GoTo ligneSuiv
    //    
    //      ' compteur de lignes
    //      iNombre = iNombre + 1
    //      Concat sData, "ANA;"              'Code journal
    //      Concat sData, Format(strMois, "00") & Right$(rs("COMPTE"), 2) & Left$(rs("NOM"), 4) & ";" ' Pièce
    //      Concat sData, IIf(rs("CPERTYP") = "TE", "642999999;", "641999999;")        'Compte comptable - 9
    //      Concat sData, ";"                 'Code TVA
    //      Concat sData, strD                'Date ecriture - 8 (dernier jour du mois)
    //      Concat sData, rs("NOM") & " " & rs("HEURES") & " heures" & ";"  'Libellé
    //      Concat sData, Format(rs("COUT"), ".00") & ";"                ' Débit
    //      dCumul = dCumul + CDbl(rs("COUT"))
    //      Concat sData, ";"                 'Crédit
    //      Concat sData, ";"                 'Echéance
    //      Concat sData, ";"                 'Type règlement
    //      Concat sData, rs("COMPTE") & ";"  ' analytique
    //      
    //      ts.WriteLine Left$(sData, ccOffset) ' écriture de la ligne
    //      
    //ligneSuiv:
    //    rs.MoveNext
    //  Wend
    //  
    //'  Ecriture de la ligne de contrepartie globale
    //'  Contrepartie  compte 706996000 pour le total des 641999999
    //'  Crédit : total des lignes du dessus
    //'  Répartition analytique : 996
    //'  Montant analytique: total ligne
    //  
    //  ccOffset = 0
    //  sData = ""
    //  
    //  Concat sData, "ANA;"              'Code journal
    //  Concat sData, Format(strMois, "00") & "XXXXXX;" ' Pièce
    //  Concat sData, "706996000;"   'Compte comptable - 9
    //  Concat sData, ";"                 'Code TVA
    //  Concat sData, strD  'Date ecriture - 8 (dernier jour du mois)
    //  Concat sData, Format(strMois, "00") & " - TOTAL Heures analytiques" & ";"           'Libellé
    //  Concat sData, ";" ' Débit
    //  Concat sData, Format(dCumul, ".00") & ";"  ' Crédit
    //  Concat sData, ";"                 'Echéance
    //  Concat sData, ";"                 'Type règlement
    //  Concat sData, "996;"   ' analytique
    //  
    //  ts.WriteLine Left$(sData, ccOffset) ' écriture de la ligne
    //  ts.Close
    //  
    //  ' copie de sauvegarde du fichier
    //  fs.CopyFile strDirCompta, RechercheParam("REP_COMPTA") & gstrNomSociete & "\archives\ECR-Heures-" & Format(Now, "ddmmyyyyhhmmss") & ".txt"
    //   
    //  ' fermeture du recordset
    //  rs.Close
    //  
    //  MousePointer = vbDefault
    //  MsgBox "§Fin de préparation du fichier.§" & vbCrLf & iNombre & "§ lignes transférées.§"
    //    
    //Exit Sub
    //Resume
    //handler:
    //  MousePointer = vbDefault
    //  ShowError "cmdTransfererHeures dans " & Me.Name
    //End Sub
    //
    //

    /* OK ---------------------------------------------------------------------*/
    //encodage vb6 ansi encodage c# utf8
    private void cmdRepas_Click(object sender, EventArgs e)
    {
      double dCumul = 0;



      string strMois = DateTime.Now.AddMonths(-1).Month.ToString();       //mois précédent;
      string strAnnee = DateTime.Now.AddMonths(-1).Year.ToString();       //Année précédente

      strMois = Interaction.InputBox("Saisir N° Mois", "Saisir N° Mois", strMois);
      if (strMois == "") return;
      strAnnee = Interaction.InputBox("Saisir Année", "Saisir Année", strAnnee);
      if (strAnnee == "") return;

      //MessageBox.Show(GetTauxKm(Convert.ToInt32(strAnnee)).ToString());

      if (MessageBox.Show($"Vous allez transférer les frais du mois précédent ({strMois}/{strAnnee})\r\n" +
                          $"Voulez-vous vraiment transférer faire le transfert en comptabilité ?", Program.AppTitle,
                          MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
        return;

      try
      {
        Cursor = Cursors.WaitCursor;

        strMois = Convert.ToInt16(strMois).ToString("00");

        //  ouverture du fichier
        string strFileCompta = Utils.RechercheParam("REP_COMPTA") + MozartParams.NomSociete + @"\ECRFrais.txt";
        int iNombre = 0;
        string strD = "";
        StringBuilder sData = new StringBuilder();

        //Une écriture par ligne

        strD = $"01/{strMois}/{strAnnee}";
        DateTime dtemp = Convert.ToDateTime(strD);
        dtemp = dtemp.AddMonths(1).AddDays(-1);
        strD = dtemp.ToString("dd/MM/yy") + ";";

        using (SqlDataReader sdr = ModuleData.ExecuteReader($"api_sp_CalculFraisTechTransfert {strMois} , {strAnnee}"))
        {
          if (!sdr.HasRows)
          {
            MessageBox.Show(Resources.msg_pasDeLigesSelect, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
          }

          //  gestion des repas

          dCumul = 0;

          while (sdr.Read())
          {
            if ((int)sdr["REPAS"] != 0)
            {
              //      compteur de lignes
              ++iNombre;

              sData.Append("ANA;");
              sData.Append(strMois + Strings.Right(sdr["NVEHCTE"].ToString(), 2) + Strings.Left(sdr["TECH"].ToString(), 4) + ";"); //Pièce
              sData.Append("625199998" + ";"); //Compte comptable - 9
              sData.Append(";"); //Code TVA
              sData.Append(strD); //Date écriture - 8 (dernier jour du mois)
              sData.Append(sdr["TECH"].ToString() + " " + (int)sdr["REPAS"] / 10 + " repas" + ";"); //libellé
              sData.Append(Strings.Format(sdr["REPAS"], ".00") + ";"); //Débit
              sData.Append(";"); //Crédit
              sData.Append(";"); //Echéance
              sData.Append(";"); //Type règlement
              sData.AppendLine(sdr["NVEHCTE"].ToString() + ";"); //analytique

              dCumul += Convert.ToDouble(sdr["REPAS"]);
            }
          }

          sdr.Close();
        }
        //  Ecriture de la ligne de contrepartie globale
        //  Contrepartie  compte 706998000 pour le total des 641999999
        //  Crédit : total des lignes du dessus
        //  Répartition analytique : 998
        //  Montant analytique: total ligne

        sData.Append("ANA;");
        sData.Append(strMois + "XXXXXX;"); //Pièce
        sData.Append("706998000;"); //Compte comptable -9 
        sData.Append(";"); //Code TVA
        sData.Append(strD); //Data écriture - 8 (dernier jour du mois)
        sData.Append(strMois + " - TOTAL repas" + ";"); //Libellé
        sData.Append(";"); //Débit
        sData.Append(Strings.Format(dCumul, ".00") + ";"); //Crédit
        sData.Append(";;"); //Echéance et Type règlement
        sData.AppendLine("998;"); //analytique

        // Ecriture des lignes de neutralisation 
        // 2 lignes 
        // FG le 01/09/21

        sData.Append("ANA;"); //Code journal
        sData.Append(strMois + "XXXXXX;"); //Pièce
        sData.Append("625199998;"); //Compte comptable -9 
        sData.Append(";"); //Code TVA
        sData.Append(strD); //Data écriture - 8 (dernier jour du mois)
        sData.Append("NEUTRALISATION TRANSFERTS ANA - REPAS " + strMois + "/" + strAnnee + ";"); //Libellé
        sData.Append(";"); //Débit
        sData.Append(Strings.Format(dCumul, ".00") + ";"); //Crédit
        sData.Append(";;"); //Echéance et Type règlement
        sData.AppendLine("99999;"); //analytique

        sData.Append("ANA;"); //Code journal
        sData.Append(strMois + "XXXXXX;"); //Pièce
        sData.Append("706998000;"); //Compte comptable -9 
        sData.Append(";"); //Code TVA
        sData.Append(strD); //Data écriture - 8 (dernier jour du mois)
        sData.Append("NEUTRALISATION TRANSFERTS ANA - REPAS " + strMois + "/" + strAnnee + ";"); //Libellé
        sData.Append(Strings.Format(dCumul, ".00") + ";"); //Débit
        sData.Append(";"); //Crédit
        sData.Append(";;"); //Echéance et Type règlement
        sData.AppendLine("99999;"); //analytique

        //********************************************************************************************

        //  gestion des GD
        using (SqlDataReader sdr = ModuleData.ExecuteReader($"api_sp_CalculFraisTechTransfert {strMois} , {strAnnee}"))
        {
          dCumul = 0;

          while (sdr.Read())
          {
            if ((int)sdr["GD"] != 0)
            {
              //      compteur de lignes
              ++iNombre;

              sData.Append("ANA;");
              sData.Append(strMois + Strings.Right(sdr["NVEHCTE"].ToString(), 2) + Strings.Left(sdr["TECH"].ToString(), 4) + ";"); //Pièce
              sData.Append("625199998;"); //Compte comptable - 9
              sData.Append(";"); //Code TVA
              sData.Append(strD); //Date écriture - 8 (dernier jour du mois)
              sData.Append(sdr["TECH"].ToString() + " " + (int)sdr["NB_GD"] + " GD" + ";"); //libellé
              sData.Append(Strings.Format(sdr["GD"], ".00") + ";"); //Débit
              sData.Append(";;;"); //Crédit Echéance Type règlement
              sData.AppendLine(sdr["NVEHCTE"].ToString() + ";"); //analytique

              dCumul += Convert.ToDouble(sdr["GD"]);
            }

          }
          sdr.Close();
        }

        // Ecriture de la ligne de contrepartie globale
        // Contrepartie  compte 706998000 pour le total
        // Crédit : total des lignes du dessus
        // Répartition analytique : 998
        // Montant analytique: total ligne

        sData.Append("ANA;");
        sData.Append(strMois + "XXXXXX;"); //Pièce
        sData.Append("706998000;"); //Compte comptable -9 
        sData.Append(";"); //Code TVA
        sData.Append(strD); //Data écriture - 8 (dernier jour du mois)
        sData.Append(strMois + " - TOTAL GD" + ";"); //Libellé
        sData.Append(";"); //Débit
        sData.Append(Strings.Format(dCumul, ".00") + ";"); //Crédit
        sData.Append(";;"); //Echéance et Type règlement
        sData.AppendLine("998;"); //analytique

        // Ecriture des lignes de neutralisation 
        // 2 lignes 
        // FG le 01/09/21

        sData.Append("ANA;"); //Code journal
        sData.Append(strMois + "XXXXXX;"); //Pièce
        sData.Append("625199998;"); //Compte comptable -9 
        sData.Append(";"); //Code TVA
        sData.Append(strD); //Data écriture - 8 (dernier jour du mois)
        sData.Append("NEUTRALISATION TRANSFERTS ANA - GD " + strMois + "/" + strAnnee + ";"); //Libellé
        sData.Append(";"); //Débit
        sData.Append(Strings.Format(dCumul, ".00") + ";"); //Crédit
        sData.Append(";;"); //Echéance et Type règlement
        sData.AppendLine("99999;"); //analytique

        sData.Append("ANA;"); //Code journal
        sData.Append(strMois + "XXXXXX;"); //Pièce
        sData.Append("706998000;"); //Compte comptable -9 
        sData.Append(";"); //Code TVA
        sData.Append(strD); //Data écriture - 8 (dernier jour du mois)
        sData.Append("NEUTRALISATION TRANSFERTS ANA - GD " + strMois + "/" + strAnnee + ";"); //Libellé
        sData.Append(Strings.Format(dCumul, ".00") + ";"); //Débit
        sData.Append(";"); //Crédit
        sData.Append(";;"); //Echéance et Type règlement
        sData.AppendLine("99999;"); //analytique
        //********************************************************************************************

        //  gestion des KM

        using (SqlDataReader sdr = ModuleData.ExecuteReader($"api_sp_CalculFraisTechTransfert {strMois} , {strAnnee}"))
        {
          dCumul = 0;

          while (sdr.Read())
          {
            if ((int)sdr["KM"] != 0)
            {
              //      compteur de lignes
              ++iNombre;

              sData.Append("ANA;");
              sData.Append(strMois + Strings.Right(sdr["NVEHCTE"].ToString(), 2) + Strings.Left(sdr["TECH"].ToString(), 4) + ";"); //Pièce
              sData.Append("625199999;"); //Compte comptable - 9
              sData.Append(";"); //Code TVA
              sData.Append(strD); //Date écriture - 8 (dernier jour du mois)
              sData.Append(sdr["TECH"].ToString() + " " + sdr["KM"].ToString() + " KMs" + ";"); //libellé

              if (sdr["CKM"].ToString() == "")
              {
                //sData.Append(Strings.Format(Convert.ToDouble(sdr["KM"].ToString()) * 0.4, ".00") + ";");//Débit
                //dCumul += Convert.ToDouble(Convert.ToDouble(sdr["KM"].ToString()) * 0.4);
                //MODIF DU 10/02/2022, taux km géré dans TTAUX_ANA A PRESENT
                sData.Append(Strings.Format(Convert.ToDouble(sdr["KM"].ToString()) * GetTauxKm(Convert.ToInt32(strAnnee)), ".00") + ";");//Débit
                dCumul += Convert.ToDouble(Convert.ToDouble(sdr["KM"].ToString()) * GetTauxKm(Convert.ToInt32(strAnnee)));
              }
              else
              {
                sData.Append(Strings.Format(sdr["KM"], ".00") + ";");//Débit
                dCumul += Convert.ToDouble(sdr["CKM"].ToString());
              }
              sData.Append(";;;"); //Crédit Echéance Type règlement
              sData.AppendLine(sdr["NVEHCTE"].ToString() + ";"); //analytique
            }
          }
          sdr.Close();
        }

        // Ecriture de la ligne de contrepartie globale
        // Contrepartie  compte 706997000 pour le total
        // Crédit : total des lignes du dessus
        // Répartition analytique : 997
        // Montant analytique: total ligne

        sData.Append("ANA;");
        sData.Append(strMois + "XXXXXX;"); //Pièce
        sData.Append("706997000;"); //Compte comptable -9 
        sData.Append(";"); //Code TVA
        sData.Append(strD); //Data écriture - 8 (dernier jour du mois)
        sData.Append(Convert.ToInt32(strMois).ToString("00") + " - TOTAL KMs" + ";"); //Libellé
        sData.Append(";"); //Débit
        sData.Append(Strings.Format(dCumul, ".00") + ";"); //Crédit
        sData.Append(";;"); //Echéance et Type règlement
        sData.AppendLine("997;"); //analytique

        // Ecriture des lignes de neutralisation 
        // 2 lignes 
        // FG le 01/09/21

        sData.Append("ANA;"); //Code journal
        sData.Append(strMois + "XXXXXX;"); //Pièce
        sData.Append("625199999;"); //Compte comptable -9 
        sData.Append(";"); //Code TVA
        sData.Append(strD); //Data écriture - 8 (dernier jour du mois)
        sData.Append("NEUTRALISATION TRANSFERTS ANA - KMs " + strMois + "/" + strAnnee + ";"); //Libellé
        sData.Append(";"); //Débit
        sData.Append(Strings.Format(dCumul, ".00") + ";"); //Crédit
        sData.Append(";;"); //Echéance et Type règlement
        sData.AppendLine("99999;"); //analytique

        sData.Append("ANA;"); //Code journal
        sData.Append(strMois + "XXXXXX;"); //Pièce
        sData.Append("706997000;"); //Compte comptable -9 
        sData.Append(";"); //Code TVA
        sData.Append(strD); //Data écriture - 8 (dernier jour du mois)
        sData.Append("NEUTRALISATION TRANSFERTS ANA - KMs " + strMois + "/" + strAnnee + ";"); //Libellé
        sData.Append(Strings.Format(dCumul, ".00") + ";"); //Débit
        sData.Append(";"); //Crédit
        sData.Append(";;"); //Echéance et Type règlement
        sData.AppendLine("99999;"); //analytique

        // Ecriture de toutes les lignes en une seule fois
        File.WriteAllText(strFileCompta, sData.ToString());

        //  Copie de sauvegarde du fichier
        File.Copy(strFileCompta, Utils.RechercheParam("REP_COMPTA") + MozartParams.NomSociete + @"\archives\ECR-Frais-" + DateTime.Now.ToString("ddmmyyyyhhmmss") + ".txt");

        MessageBox.Show(Resources.msg_finPrepaFichier + " :" + iNombre.ToString() + Resources.txt_lignesTranf, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally
      {
        Cursor = Cursors.Default;
      }
    }

    //Private Sub cmdRepas_Click()
    //
    //Dim rs As ADODB.Recordset
    //Dim fs As New Scripting.FileSystemObject
    //Dim ts As TextStream
    //Dim sData As String
    //Dim strDirCompta As String
    //Dim strMois As String
    //Dim strAnnee As String
    //Dim iNombre As Integer
    //Dim dCumul As Double
    //Dim bFirstLine As Boolean
    //Dim strD As String
    //
    //  strMois = Month(DateAdd("m", -1, Date))   ' mois précédent
    //  strAnnee = Year(DateAdd("m", -1, Date))   ' Année précédente
    //  
    //  strMois = InputBox("Saisir N° Mois", "Saisir N° Mois", strMois)
    //  strAnnee = InputBox("Saisir Année", "Saisir Année", strAnnee)
    //  
    //  If MsgBox("Vous allez transférer les frais du mois précédent (" & strMois & "/" & strAnnee & ")" & vbCrLf _
    //          & "Voulez-vous vraiment faire le transfert en comptabilité ?", vbYesNo + vbQuestion + vbDefaultButton2) = vbNo Then
    //    Exit Sub
    //  End If
    //  
    //  On Error GoTo handler
    //  MousePointer = vbHourglass
    //  
    //  ' ouverture du fichier
    //  strDirCompta = RechercheParam("REP_COMPTA") & gstrNomSociete & "\ECRFrais.txt"
    //
    //  Set ts = fs.OpenTextFile(strDirCompta, ForWriting, True)
    //   
    //  ' ouverture du recordset des données
    //  Set rs = New ADODB.Recordset
    //  rs.Open "api_sp_CalculFraisTechTransfert " & strMois & ", " & strAnnee, cnx
    // 
    //  If rs.EOF Then
    //    MsgBox "§Pas de ligne sélectionnée§"
    //    Exit Sub
    //  End If
    //  
    //' Une écriture par ligne
    //
    //  bFirstLine = True
    //  strD = "01/" & strMois & "/" & strAnnee
    //  strD = Format(DateAdd("d", -1, DateAdd("m", 1, strD)), "dd/mm/yy") & ";"
    //  
    //  
    //  ' gestion des repas
    //  rs.Filter = "REPAS <> 0"
    //  dCumul = 0
    //  
    //  While Not rs.EOF
    //    
    //    ccOffset = 0
    //    sData = ""
    //       
    //    ' compteur de lignes
    //    iNombre = iNombre + 1
    //  
    //    Concat sData, "ANA;"
    //    Concat sData, Format(strMois, "00") & Format(Right$(rs("NVEHCTE"), 2), "!@@") & Left$(rs("TECH"), 4) & ";" ' Pièce
    //    Concat sData, "625199998" & ";"   'Compte comptable - 9
    //    Concat sData, ";"                 ' Code TVA
    //    Concat sData, strD  'Date ecriture - 8 (dernier jour du mois)
    //    Concat sData, rs("TECH") & " " & rs("REPAS") / 10 & " repas" & ";"              'Libellé
    //    Concat sData, Format(rs("REPAS"), ".00") & ";"               ' débit
    //    Concat sData, ";"   ' Crédit
    //    Concat sData, ";"   ' échéance
    //    Concat sData, ";"   ' type réglement
    //    Concat sData, rs("NVEHCTE") & ";"  'analytique
    //    
    //    dCumul = dCumul + CDbl(rs("REPAS"))
    //    
    //    ts.WriteLine Left$(sData, ccOffset) ' écriture de la ligne
    //      
    //    rs.MoveNext
    //  Wend
    //  
    //'  Ecriture de la ligne de contrepartie globale
    //'  Contrepartie  compte 706998000 pour le total des 641999999
    //'  Crédit : total des lignes du dessus
    //'  Répartition analytique : 998
    //'  Montant analytique: total ligne
    //  
    //  ccOffset = 0
    //  sData = ""
    //  
    //  Concat sData, "ANA;"
    //  Concat sData, Format(strMois, "00") & "XXXXXX;" ' Pièce
    //  Concat sData, "706998000;"   'Compte comptable - 9
    //  Concat sData, ";"                 ' Code TVA
    //  Concat sData, strD  'Date ecriture - 8 (dernier jour du mois)
    //  Concat sData, Format(strMois, "00") & " - TOTAL repas" & ";"     'Libellé
    //  Concat sData, ";" ' Débit
    //  Concat sData, Format(dCumul, ".00") & ";"  ' Crédit
    //  Concat sData, ";"   ' Echéance
    //  Concat sData, ";"   ' type réglement
    //  Concat sData, "998;"   ' analytique
    //  
    //  ts.WriteLine Left$(sData, ccOffset) ' écriture de la ligne
    //  
    //'********************************************************************************************
    //  ' gestion des GD
    //  rs.Filter = "GD <> 0"
    //  dCumul = 0
    //  If rs.RecordCount > 0 Then rs.MoveFirst
    //  
    //  While Not rs.EOF
    //    
    //    ccOffset = 0
    //    sData = ""
    //       
    //    ' compteur de lignes
    //    iNombre = iNombre + 1
    //  
    //    Concat sData, "ANA;"
    //    Concat sData, Format(strMois, "00") & Right$(rs("NVEHCTE"), 2) & Left$(rs("TECH"), 4) & ";" ' Pièce
    //    Concat sData, "625199998;"        'Compte comptable - 9
    //    Concat sData, ";"                 ' Code TVA
    //    Concat sData, strD                'Date ecriture - 8 (dernier jour du mois)
    //    Concat sData, rs("TECH") & " " & Int(rs("GD") / 55) & " GD" & ";"   'Libellé
    //    Concat sData, Format(rs("GD"), ".00") & ";"              ' Débit
    //    Concat sData, ";"                 ' Crédit
    //    Concat sData, ";"                 ' Echéance
    //    Concat sData, ";"                 ' type réglement
    //    Concat sData, rs("NVEHCTE") & ";" ' analytique
    //    
    //    dCumul = dCumul + CDbl(rs("GD"))
    //    
    //    ts.WriteLine Left$(sData, ccOffset) ' écriture de la ligne
    //      
    //    rs.MoveNext
    //  Wend
    //  
    //'  Ecriture de la ligne de contrepartie globale
    //'  Contrepartie  compte 706998000 pour le total
    //'  Crédit : total des lignes du dessus
    //'  Répartition analytique : 998
    //'  Montant analytique: total ligne
    //  
    //  ccOffset = 0
    //  sData = ""
    //  
    //  Concat sData, "ANA;"
    //  Concat sData, Format(strMois, "00") & "XXXXXX" & ";"   ' Pièce
    //  Concat sData, "706998000;"   'Compte comptable - 9
    //  Concat sData, ";"                 ' Code TVA
    //  Concat sData, strD  'Date ecriture - 8 (dernier jour du mois)
    //  Concat sData, Format(strMois, "00") & " - TOTAL GD" & ";"             'Libellé
    //  Concat sData, ";" ' Débit
    //  Concat sData, Format(dCumul, ".00") & ";"  ' Crédit
    //  Concat sData, ";"  ' Echéance
    //  Concat sData, ";"                 ' type réglement
    //  Concat sData, "998;"   ' analytique
    //  
    //  ts.WriteLine Left$(sData, ccOffset) ' écriture de la ligne
    //
    //
    //'********************************************************************************************
    //  ' gestion des KM
    //  rs.Filter = "KM <> 0"
    //  dCumul = 0
    //  If rs.RecordCount > 0 Then rs.MoveFirst
    //  
    //  While Not rs.EOF
    //    
    //    ccOffset = 0
    //    sData = ""
    //       
    //    ' compteur de factures
    //    iNombre = iNombre + 1
    //  
    //    Concat sData, "ANA;"
    //    Concat sData, Format(strMois, "00") & Right$(rs("NVEHCTE"), 2) & Left$(rs("TECH"), 4) & ";" ' Pièce
    //    Concat sData, "625199999" & ";"   'Compte comptable - 9
    //    Concat sData, ";"                 ' Code TVA
    //    Concat sData, strD                'Date ecriture - 8 (dernier jour du mois)
    //    Concat sData, rs("TECH") & " " & rs("KM") & " KMs" & ";"   'Libellé
    //    
    //    If IsNull(rs("CKM")) Then
    //      Concat sData, Format(rs("KM") * 0.4, ".00") & ";"   ' Débit
    //      dCumul = dCumul + CDbl(rs("KM") * 0.4)
    //    Else
    //      Concat sData, Format(rs("CKM"), ".00") & ";"   ' Débit
    //      dCumul = dCumul + CDbl(rs("CKM"))
    //    End If
    //    
    //    Concat sData, ";"                 ' Crédit
    //    Concat sData, ";"                 ' Echéance
    //    Concat sData, ";"                 ' type réglement
    //    Concat sData, rs("NVEHCTE") & ";" ' analytique
    //    
    //    ts.WriteLine Left$(sData, ccOffset) ' écriture de la ligne
    //      
    //    rs.MoveNext
    //  Wend
    //  
    //'  Ecriture de la ligne de contrepartie globale
    //'  Contrepartie  compte 706997000 pour le total
    //'  Crédit : total des lignes du dessus
    //'  Répartition analytique : 997
    //'  Montant analytique: total ligne
    //  
    //  ccOffset = 0
    //  sData = ""
    //  
    //  Concat sData, "ANA;"
    //  Concat sData, Format(strMois, "00") & "XXXXXX" & ";"    ' Pièce
    //  Concat sData, "706997000" & ";"             'Compte comptable - 9
    //  Concat sData, ";"                           ' Code TVA
    //  Concat sData, strD                          'Date ecriture - 8 (dernier jour du mois)
    //  Concat sData, Format(strMois, "00") & " - TOTAL KMs" & ";"  'Libellé
    //  Concat sData, ";"                           ' Débit
    //  Concat sData, Format(dCumul, ".00") & ";"   ' Crédit
    //  Concat sData, ";"                           ' Echéance
    //  Concat sData, ";"                           ' type réglement
    //  Concat sData, "997" & ";"                   ' analytique
    //  
    //  ts.WriteLine Left$(sData, ccOffset) ' écriture de la ligne
    //
    //  ' fermeture du fichier
    //  ts.Close
    //  
    //  ' copie de sauvegarde du fichier
    //  fs.CopyFile strDirCompta, RechercheParam("REP_COMPTA") & gstrNomSociete & "\archives\ECR-Frais-" & Format(Now, "ddmmyyyyhhmmss") & ".txt"
    //   
    //  ' fermeture du recordset
    //  rs.Close
    //  
    //  MousePointer = vbDefault
    //  MsgBox "§Fin de préparation du fichier.§" & vbCrLf & iNombre & "§ lignes transférées.§"
    //    
    //Exit Sub
    //handler:
    //  MousePointer = vbDefault
    //  ShowError "cmdRepas dans " & Me.Name
    //End Sub
    //
    //

    /* OK ---------------------------------------------------------------------*/
    private void cmdTransfertStock_Click(object sender, EventArgs e)
    {
      double dCumul = 0;

      string strMois = DateTime.Now.AddMonths(-1).Month.ToString();       //mois précédent;
      string strAnnee = DateTime.Now.AddMonths(-1).Year.ToString();       //Année précédente

      strMois = Interaction.InputBox("Saisir N° Mois", "Saisir N° Mois", strMois);
      if (strMois == "") return;
      strAnnee = Interaction.InputBox("Saisir Année", "Saisir Année", strAnnee);
      if (strAnnee == "") return;

      if (MessageBox.Show($"Vous allez transférer les stocks du mois précédent ({strMois}/{strAnnee}){Environment.NewLine}" +
                            $"Voulez-vous vraiment faire le transfert en comptabilité ?", Program.AppTitle,
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
        return;

      try
      {
        Cursor = Cursors.WaitCursor;
        //  ouverture du fichier
        string strFileCompta = Utils.RechercheParam("REP_COMPTA") + MozartParams.NomSociete + @"\ECRStock.txt";
        int iNombre = 0;
        string strLib = "";
        StringBuilder sData = new StringBuilder();

        strMois = Convert.ToInt16(strMois).ToString("00");

        using (SqlDataReader sdr = ModuleData.ExecuteReader($"api_sp_TransfertStock {strMois} , {strAnnee}"))
        {
          if (!sdr.HasRows)
          {
            MessageBox.Show(Resources.msg_pasDeLigesSelect, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
          }

          // Une écriture par ligne

          // N° de pièce : mois/compte/personne(4)  0433BOZZ
          // Compte : 605999999
          // Date écriture : sortie de stock
          // Libellé : cpt ana, vfoumat
          // Débit:    qte * puht
          // Crédit:    rien
          // Echéance: rien
          // Répartition analytique: même montant
          // Montant analytique: total ligne

          dCumul = 0;

          while (sdr.Read())
          {
            //      compteur de factures
            ++iNombre;

            //      limitation lib à 20 caractères (wavesoft)
            strLib = Strings.Mid(sdr["DSTOCKENTREE"].ToString(), 4, 2) + "-" + sdr["COMPTE"] + "-" + sdr["vpernom"]; //pièce

            sData.Append("ANA;");
            sData.Append(Strings.Left(strLib, 20) + ";");
            sData.Append("705999999" + ";"); //Compte comptable - 9
            sData.Append(";"); //Code TVA
            sData.Append(sdr["DSTOCKENTREE"].ToString() + ";"); // Date stock
            sData.Append(sdr["QTE"].ToString() + " " + MozartParams.SupprimerCaracteresSpeciaux(sdr["VFOUMAT"].ToString()) + "-" + sdr["NDINNUM"].ToString() + ";"); //libellé
            sData.Append(Strings.Format(sdr["MONTANT"], ".00") + ";"); //Débit
            sData.Append(";;;"); //Crédit Echéance type réglement
            sData.AppendLine(sdr["COMPTE"].ToString() + ";"); //analytique

            dCumul += Utils.ZeroIfNull(sdr["MONTANT"]);

            //      update dans la table indiquant que la ligne est passée en compta
            ModuleData.ExecuteNonQuery("UPDATE TSTOCK SET BSTOCKXFER = 1 WHERE NSTOCKNUM = " + sdr["NSTOCKNUM"].ToString());
          }
          sdr.Close();
        }

        // Ecriture de la ligne de contrepartie globale
        // Contrepartie  compte 705999999 pour le total des 605999999
        // Crédit : total des lignes du dessus
        // Répartition analytique : 995
        // Montant analytique: total ligne

        sData.Append("ANA;");
        sData.Append("XXXXXXXX;"); //Pièce
        sData.Append("605999999" + ";"); //Compte comptable - 9
        sData.Append(";"); //TVA
        sData.Append(DateTime.Now.AddDays(-(int)DateTime.Now.Day).ToString("dd") + "/" + strMois + "/" + strAnnee + ";"); // Date du jour
        sData.Append("TOTAL des répartitions analytiques;"); //Libellé
        sData.Append(";"); //Débit
        sData.Append(Strings.Format(dCumul, ".00") + ";"); //Crédit
        sData.Append(";;"); //Echéance et Type règlement
        sData.AppendLine("995;"); //analytique

        // Ecriture des lignes de neutralisation 
        // 2 lignes 
        // FG le 01/09/21

        sData.Append("ANA;"); //Code journal
        sData.Append(strMois + "XXXXXX;"); //Pièce
        sData.Append("705999999;"); //Compte comptable -9 
        sData.Append(";"); //Code TVA
        sData.Append(DateTime.Now.AddDays(-(int)DateTime.Now.Day).ToString("dd") + "/" + strMois + "/" + strAnnee + ";"); //Data écriture - 8 (dernier jour du mois)
        sData.Append("NEUTRALISATION TRANSFERTS ANA - STOCKS " + strMois + "/" + strAnnee + ";"); //Libellé
        sData.Append(";"); //Débit
        sData.Append(Strings.Format(dCumul, ".00") + ";"); //Crédit
        sData.Append(";;"); //Echéance et Type règlement
        sData.AppendLine("99999;"); //analytique

        sData.Append("ANA;"); //Code journal
        sData.Append(strMois + "XXXXXX;"); //Pièce
        sData.Append("605999999;"); //Compte comptable -9 
        sData.Append(";"); //Code TVA
        sData.Append(DateTime.Now.AddDays(-(int)DateTime.Now.Day).ToString("dd") + "/" + strMois + "/" + strAnnee + ";"); //Data écriture - 8 (dernier jour du mois)
        sData.Append("NEUTRALISATION TRANSFERTS ANA - STOCKS " + strMois + "/" + strAnnee + ";"); //Libellé
        sData.Append(Strings.Format(dCumul, ".00") + ";"); //Débit
        sData.Append(";"); //Crédit
        sData.Append(";;"); //Echéance et Type règlement
        sData.AppendLine("99999;"); //analytique

        // Ecriture de toutes les lignes en une seule fois
        File.WriteAllText(strFileCompta, sData.ToString());

        //  Copie de sauvegarde du fichier
        File.Copy(strFileCompta, Utils.RechercheParam("REP_COMPTA") + MozartParams.NomSociete + @"\archives\ECR-Stock-" + DateTime.Now.ToString("ddmmyyyyhhmmss") + ".txt");

        MessageBox.Show($"{Resources.msg_finPrepaFichier}{Environment.NewLine}{iNombre.ToString()}{Resources.txt_lignesTranf}", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally
      {
        Cursor = Cursors.Default;
      }
    }

    private void BtnAdminDAF_Click(object sender, EventArgs e)
    {
      // Pour tests
      if ((MozartParams.strUID == "GIRAUD-BY") || (MozartParams.strUID == "LEFORT"))
      {
        new frmAdminDAF().ShowDialog();
      }
      else
      {
        new frmAdminDAF_TauxAna().ShowDialog();
      }
    }

    private Double GetTauxKm(int p_annee)
    {

      double TauxKmOut = 0;
      try
      {
        //création d'une commande
        using (SqlCommand cmd = new SqlCommand("api_sp_GetTauxKM", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);
          cmd.Parameters["@p_annee"].Value = p_annee;

          using (SqlDataReader reader = cmd.ExecuteReader())
          {
            if (reader.Read())
            {
              TauxKmOut = (double)Utils.ZeroIfNull(reader["VAL_PANIER"]);
            }
          }

          return TauxKmOut;
        }
      }
      catch (Exception ex)
      {
        Utils.ShowException(ex, MethodBase.GetCurrentMethod().Name, ex.StackTrace);
        return 0;
      }
    }


    private void btnHeuresDeplacement_Click(object sender, EventArgs e)
    {
      double dCumul = 0;
      double dCumul641 = 0;
      double dCumul642 = 0;
      string strD = "";

      string strMois = DateTime.Now.AddMonths(-1).Month.ToString();       //mois précédent;
      string strAnnee = DateTime.Now.AddMonths(-1).Year.ToString();       //Année précédente

      strMois = Interaction.InputBox("Saisir N° Mois", "Saisir N° Mois", strMois);
      if (strMois == "") return;

      strAnnee = Interaction.InputBox("Saisir Année", "Saisir Année", strAnnee);
      if (strAnnee == "") return;

      if (MessageBox.Show($"Vous allez transférer les heures du mois précédent ({strMois}/{strAnnee}){Environment.NewLine}" +
                          $"Voulez-vous vraiment transférer les heures en comptabilité ?", Program.AppTitle,
                          MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
        return;

      strMois = Convert.ToInt16(strMois).ToString("00");

      try
      {
        Cursor = Cursors.WaitCursor;

        //  ouverture du fichier
        string strFileCompta = Utils.RechercheParam("REP_COMPTA") + MozartParams.NomSociete + @"\ECRHeuresDepl.txt";

        int iNombre = 0;
        StringBuilder sData = new StringBuilder();

        using (SqlDataReader sdr = ModuleData.ExecuteReader($"api_sp_CalculHeureDepl {strMois} , {strAnnee}"))
        {
          if (!sdr.HasRows)
          {
            MessageBox.Show(Resources.msg_pasDeLigesSelect, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
          }

          strD = $"01/{strMois}/{strAnnee}";
          strD = Convert.ToDateTime(strD).AddMonths(1).AddDays(-1).ToString("dd/MM/yy") + ";";

          while (sdr.Read())
          {
            //Une écriture par ligne
            //  
            // N° de pièce : mois/compte/personne(4)  0433BEN
            // Compte : 641999999
            // Date écriture : dernier jour du mois
            // Libellé : nom tech nb heures Ex: BEN ALI  3 Heures
            // Débit:    Montant heures * taux
            // Crédit:    rien
            // Echéance: rien
            // Répartition analytique: Compte client(32, 33)
            // Montant analytique: total ligne

            if (!(sdr["HEURES"].ToString() == "0" || sdr["COUT"].ToString() == "0" || sdr["COUT"] == DBNull.Value || sdr["HEURES"] == DBNull.Value))
            {
              //      compteur de lignes
              ++iNombre;
              sData.Append("ANA;"); //Code journal
              sData.Append(strMois + Strings.Right(sdr["COMPTE"].ToString(), 2) + Strings.Left(sdr["NOM"].ToString(), 4) + ";"); //Pièce
              //sData.Append(sdr["CPERTYP"].ToString() == "TE" ? "642999999;" : "641999999;"); //Compte comptable - 9
              sData.Append("642999999;"); //Compte comptable - 9
              sData.Append(";"); //Code TVA
              sData.Append(strD); //Date écriture - 8 (dernier jour du mois)
              sData.Append(sdr["NOM"].ToString() + " " + sdr["HEURES"] + " heures de déplacement" + ";"); //libellé
              //sData.Append(sdr["COUT"].ToString() + ",00;"); //Débit
              sData.Append("0,01;"); //Débit  on affiche 0.01 pour cacher les vrais chiffres confidentiels

              // cumul  général (on ajoute 1 centime par ligne car on affiche 1 centime par ligne)
              dCumul += Convert.ToDouble(sdr["COUT"]) + 0.01;

              // cumul par compte
              if (sdr["CPERTYP"].ToString() == "TE")
              {
                dCumul642 += Convert.ToDouble(sdr["COUT"]) + 0.01;
              }
              else
              {
                dCumul641 += Convert.ToDouble(sdr["COUT"]) + 0.01;
              }


              sData.Append(";"); //Crédit
              sData.Append(";"); //Echéance
              sData.Append(";"); //Type règlement
              sData.AppendLine(sdr["COMPTE"].ToString() + ";");
            }
          }
          sdr.Close();
        }

        // ajout des sous-totaux par compte ana
        // [api_sp_CalculHeureTechbisSousTotaux]
        using (SqlDataReader sdr = ModuleData.ExecuteReader($"api_sp_CalculHeureDeplSousTotaux {strMois} , {strAnnee}"))
        {
          if (!sdr.HasRows)
          {
            return;
          }

          while (sdr.Read())
          {

            if (!(sdr["HEURES"].ToString() == "0" || sdr["COUT"].ToString() == "0" || sdr["COUT"] == DBNull.Value || sdr["HEURES"] == DBNull.Value))
            {
              sData.Append("ANA;"); //Code journal
              sData.Append(strMois + Convert.ToInt32(sdr["COMPTE"]).ToString("000") + "XXX;"); //Pièce
              sData.Append(sdr["J"].ToString() + ";"); //Compte comptable - 9
              sData.Append(";"); //Code TVA
              sData.Append(strD); //Date écriture - 8 (dernier jour du mois)
              sData.Append("TOTAL HEURES " + strMois + "/" + strAnnee + "-" + sdr["HEURES"] + " heures de déplacement" + ";"); //libellé
              sData.Append(Strings.Format(sdr["COUT"], ".00") + ";"); //Débit
              sData.Append(";"); //Crédit
              sData.Append(";"); //Echéance
              sData.Append(";"); //Type règlement
              sData.AppendLine(sdr["COMPTE"].ToString() + ";");
            }
          }
          sdr.Close();
        }



        // Ecriture de la ligne de contrepartie globale
        // Contrepartie  compte 706996000 pour le total des 641999999 et 642999999
        // Crédit : total des lignes du dessus
        // Répartition analytique : 996
        // Montant analytique: total ligne

        sData.Append("ANA;"); //Code journal
        sData.Append(strMois + "XXXXXX;"); //Pièce
        sData.Append("706996000;"); //Compte comptable -9 
        sData.Append(";"); //Code TVA
        sData.Append(strD); //Data écriture - 8 (dernier jour du mois)
        sData.Append("TOTAL Heures analytiques - " + strMois + "/" + strAnnee + ";"); //Libellé
        sData.Append(";"); //Débit
        sData.Append(Strings.Format(dCumul, ".00") + ";"); //Crédit
        sData.Append(";;"); //Echéance et Type règlement
        sData.AppendLine("996;"); //analytique

        // Ecriture des lignes de neutralisation 
        // 3 lignes 
        // FG le 01/09/21

        //sData.Append("ANA;"); //Code journal
        //sData.Append(strMois + "XXXXXX;"); //Pièce
        //sData.Append("641999999;"); //Compte comptable -9 
        //sData.Append(";"); //Code TVA
        //sData.Append(strD); //Data écriture - 8 (dernier jour du mois)
        //sData.Append("NEUTRALISATION TRANSFERTS ANA - HEURES " + strMois + "/" + strAnnee + ";"); //Libellé
        //sData.Append(";"); //Débit
        //sData.Append(Strings.Format(dCumul641, ".00") + ";"); //Crédit
        //sData.Append(";;"); //Echéance et Type règlement
        //sData.AppendLine("99999;"); //analytique

        sData.Append("ANA;"); //Code journal
        sData.Append(strMois + "XXXXXX;"); //Pièce
        sData.Append("642999999;"); //Compte comptable -9 
        sData.Append(";"); //Code TVA
        sData.Append(strD); //Data écriture - 8 (dernier jour du mois)
        sData.Append("NEUTRALISATION TRANSFERTS ANA - HEURES " + strMois + "/" + strAnnee + ";"); //Libellé
        sData.Append(";"); //Débit
        sData.Append(Strings.Format(dCumul642, ".00") + ";"); //Crédit
        sData.Append(";;"); //Echéance et Type règlement
        sData.AppendLine("99999;"); //analytique

        sData.Append("ANA;"); //Code journal
        sData.Append(strMois + "XXXXXX;"); //Pièce
        sData.Append("706996000;"); //Compte comptable -9 
        sData.Append(";"); //Code TVA
        sData.Append(strD); //Data écriture - 8 (dernier jour du mois)
        sData.Append("NEUTRALISATION TRANSFERTS ANA - HEURES " + strMois + "/" + strAnnee + ";"); //Libellé
        sData.Append(Strings.Format(dCumul, ".00") + ";"); //Débit
        sData.Append(";"); //Crédit
        sData.Append(";;"); //Echéance et Type règlement
        sData.AppendLine("99999;"); //analytique

        // Ecriture de toutes les lignes en une seule fois
        File.WriteAllText(strFileCompta, sData.ToString());

        //  Copie de sauvegarde du fichier
        File.Copy(strFileCompta, Utils.RechercheParam("REP_COMPTA") + MozartParams.NomSociete + @"\archives\ECR-HeuresDepl-" + DateTime.Now.ToString("ddmmyyyyhhmmss") + ".txt");

        MessageBox.Show($"{Resources.msg_finPrepaFichier}{Environment.NewLine}{iNombre.ToString()}{Resources.txt_lignesTranf}", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally
      {
        Cursor = Cursors.Default;
      }
    }

    private void BtnRepartAna_Hr_Pers_Click(object sender, EventArgs e)
    {
      new frmAdminRepartitionAnaHr().ShowDialog();
    }

    //Private Sub cmdTransfertStock_Click()
    //
    //Dim rs As ADODB.Recordset
    //Dim fs As New Scripting.FileSystemObject
    //Dim ts As TextStream
    //Dim sData As String
    //Dim strDirCompta As String
    //Dim iNombre As Integer
    //Dim dCumul As Double
    //Dim bFirstLine As Boolean
    //Dim strMois As String
    //Dim strAnnee As String
    //Dim strLib  As String
    //
    //  strMois = Month(DateAdd("m", -1, Date))   ' mois précédent
    //  strAnnee = Year(DateAdd("m", -1, Date))   ' Année précédente
    //
    //  strMois = InputBox("Saisir N° Mois", "Saisir N° Mois", strMois)
    //  strAnnee = InputBox("Saisir Année", "Saisir Année", strAnnee)
    //
    //  
    //  If MsgBox("Vous allez transférer les stocks du mois précédent (" & strMois & "/" & strAnnee & ")" & vbCrLf _
    //          & "Voulez-vous vraiment faire le transfert en comptabilité ?", vbYesNo + vbQuestion + vbDefaultButton2) = vbNo Then
    //    Exit Sub
    //  End If
    //    
    //  On Error GoTo handler
    //  MousePointer = vbHourglass
    //  
    //  ' ouverture du fichier
    //  strDirCompta = RechercheParam("REP_COMPTA") & gstrNomSociete & "\ECRStock.txt"
    //
    //  Set ts = fs.OpenTextFile(strDirCompta, ForWriting, True)
    //   
    //  ' ouverture du recordset des données
    //  Set rs = New ADODB.Recordset
    //  rs.Open "api_sp_TransfertStock  " & strMois & ", " & strAnnee, cnx
    // 
    //  If rs.EOF Then
    //    MousePointer = vbDefault
    //    MsgBox "§Pas de ligne sélectionnée§"
    //    Exit Sub
    //  End If
    //  
    //' Une écriture par ligne
    //  
    //'  N° de pièce : mois/compte/personne(4)  0433BOZZ
    //'  Compte : 605999999
    //'  Date écriture : sortie de stock
    //'  Libellé : cpt ana, vfoumat
    //'  Débit:    qte * puht
    //'  Crédit:    rien
    //'  Echéance: rien
    //'  Répartition analytique: même montant
    //'  Montant analytique: total ligne
    //
    //  bFirstLine = True
    //  
    //  While Not rs.EOF
    //    
    //    ccOffset = 0
    //    sData = ""
    //    
    //      ' compteur de factures
    //      iNombre = iNombre + 1
    //      
    //      ' limitation lib à 20 caractères (wavesoft)
    //      strLib = Mid(rs!DSTOCKENTREE, 4, 2) & "-" & rs!COMPTE & "-" & rs!vpernom   ' Pièce
    //      
    //      Concat sData, "ANA;"
    //      Concat sData, Left(strLib, 20) & ";"
    //      Concat sData, "705999999" & ";"       'Compte comptable - 9
    //      Concat sData, ";"                     ' Code TVA
    //      Concat sData, rs!DSTOCKENTREE & ";"   'Date stock
    //      Concat sData, rs!QTE & " " & Replace(rs!VFOUMAT, ";", "") & ";"             'Libellé
    //      Concat sData, Format(rs!MONTANT, ".00") & ";"   ' Débit
    //      Concat sData, ";"                               ' Crédit
    //      Concat sData, ";"                     ' Echéance
    //      Concat sData, ";"                     ' type réglement
    //      Concat sData, rs!COMPTE & ";"         ' analytique
    //      
    //      dCumul = dCumul + CDbl(ZeroIfNull(rs!MONTANT))
    //      
    //      ts.WriteLine Left$(sData, ccOffset) ' écriture de la ligne
    //      
    //      ' update dans la table indiquant que la ligne est passée en compta
    //      cnx.Execute "UPDATE TSTOCK SET BSTOCKXFER = 1 WHERE NSTOCKNUM = " & val(rs("NSTOCKNUM"))
    //    
    //    rs.MoveNext
    //  Wend
    //  
    //'  Ecriture de la ligne de contrepartie globale
    //'  Contrepartie  compte 705999999 pour le total des 605999999
    //'  Crédit : total des lignes du dessus
    //'  Répartition analytique : 995
    //'  Montant analytique: total ligne
    //  
    //  ccOffset = 0
    //  sData = ""
    //  
    //  Concat sData, "ANA;"
    //  Concat sData, "XXXXXXXX;"                   ' Pièce
    //  Concat sData, "605999999" & ";"             ' Compte comptable - 9
    //  Concat sData, ";"                           ' Code TVA
    //  Concat sData, Format(DatePart("d", DateAdd("d", -Day(Now), Now)), "00") & "/" & strMois & "/" & strAnnee & ";" 'Date du jour
    //  Concat sData, "TOTAL des répartitions analytiques" & ";"           'Libellé
    //  Concat sData, ";"                           ' Débit
    //  Concat sData, Format(dCumul, ".00") & ";"   ' Crédit
    //  Concat sData, ";"                           ' Echéance
    //  Concat sData, ";"                           ' type réglement
    //  Concat sData, "995;"                        ' analytique
    //  
    //  ts.WriteLine Left$(sData, ccOffset) ' écriture de la ligne
    //  
    //  ' fermeture du fichier
    //  ts.Close
    //  
    //  ' copie de sauvegarde du fichier
    //  fs.CopyFile strDirCompta, RechercheParam("REP_COMPTA") & gstrNomSociete & "\archives\ECR-Stock-" & Format(Now, "ddmmyyyyhhmmss") & ".txt"
    //   
    //  ' fermeture du recordset
    //  rs.Close
    //  
    //  MousePointer = vbDefault
    //  MsgBox "§Fin de préparation du fichier.§" & vbCrLf & iNombre & "§ lignes de transfert.§"
    //  Exit Sub
    //  Resume
    //  
    //handler:
    //  MousePointer = vbDefault
    //  ShowError "cmdTransfererStock dans " & Me.Name
    //End Sub
    //
    //
    //
    //
    //
    //

  }
}

