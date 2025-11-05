using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS.ListeClients
{
  public partial class UCtrlValidation : UserControl
  {
    public event EventHandler DevisStatusUpdated;
    public event EventHandler DevisRemarqueEnter;
    public event EventHandler DevisEnablePrintAndVisu;

    private String mStatutValidation;
    private int mNumDevis;
    private double mMontantDevis;

    public UCtrlValidation()
    {
      InitializeComponent();

      txtRmEng.Visible = ModuleMain.RechercheDroitMenu(txtRmEng.HelpContextID);
    }

    public Color FrameColor
    {
      get { return grpBox.FrameColor; }
      set { grpBox.FrameColor = value; }
    }

    public String StatutValidation
    {
      get { return mStatutValidation; }
      set { mStatutValidation = value; }
    }

    public int NumDevis
    {
      get { return mNumDevis; }
      set { mNumDevis = value; }
    }

    public double MontantDevis
    {
      get { return mMontantDevis; }
      set { mMontantDevis = value; }
    }

    public void addRemarque(int pNumDevis, string pTexte)
    {
      if (txtRmEng.Text == "") txtRmEng.Text = pTexte;
      else txtRmEng.Text = pTexte + "\r\n" + txtRmEng.Text;

      // enregistrement dans la base
      MozartDatabase.ExecuteNonQuery($"update TDCLVALID set VRMQ='{txtRmEng.Text.Replace("'", "''")}' WHERE NDCLNUM = {pNumDevis}");

      // envoi du mail au créateur d'une saisie de remarque
      //MozartDatabase.ExecuteNonQuery($"EXEC [api_sp_EnvoiMsgDelegationAddObs] {pNumDevis}, 'DEVIS'");
    }

    public string Remarque
    {
      get { return txtRmEng.Text; }
      set { txtRmEng.Text = value; }
    }

    // Affiche délégation
    public void fill(int pNumDevis, string pStrValidationDevis, double pMontantHT)
    {
      StatutValidation = pStrValidationDevis;
      NumDevis = pNumDevis;
      MontantDevis = pMontantHT;

      try
      {
        DateTime dn;
        // recherche si il y a des données de délégation
        using (SqlDataReader sdr = MozartDatabase.ExecuteReader($"exec api_sp_AfficheDelegationDevis {NumDevis}"))
        {
          if (sdr.Read())
          {
            apiLabel[] lblNiv = { null, lblniv0, lblniv1, lblniv2, lblniv3, lblniv4, lblniv5 };
            apiLabel[] lblPer = { null, lblPer0, lblPer1, lblPer2, lblPer3, lblPer4, lblPer5 };
            apiLabel[] lblSign = { null, lblSign0, lblSign1, lblSign2, lblSign3, lblSign4, lblSign5 };

            // Remplissage des composants
            for (int i = 1; i <= 6; i++)
            {
              lblNiv[i].Visible = true;
              lblPer[i].Visible = true;
              lblSign[i].Visible = true;

              // affichage de la personne
              if (i == 6)
              {
                // Cas du niveau direction
                if (Utils.BlankIfNull(sdr["QUI" + i]) == "")
                  lblPer[i].Text = $"Direction {Environment.NewLine} (illimité)";
                else
                  lblPer[i].Text = $"{Utils.BlankIfNull(sdr["QUI" + i])} {Environment.NewLine} (illimité)";
              }
              else
              {
                // Autres cas
                lblPer[i].Text = Utils.BlankIfNull(sdr["QUI" + i]) + $"{Environment.NewLine} (< " + Utils.ZeroIfNull(sdr["MT" + i].ToString()) + " €)";
                if (lblPer[i].Text == $"{Environment.NewLine} (< 0 €)") lblPer[i].Text = "";
              }

              // on garde l'info du montant de validation
              lblPer[i].Tag = Utils.ZeroIfNull(sdr["MT" + i]);
              // affichage de l'info de signature quand       
              lblSign[i].Text = "";
              if (DateTime.TryParse(Utils.BlankIfNull(sdr["DN" + i]), out dn))
                lblSign[i].Text = $"{dn.ToShortDateString()}{Environment.NewLine}{dn.TimeOfDay}";
              // on garde l'info de qui a validé
              lblSign[i].Tag = (int)Utils.ZeroIfNull(sdr["QN" + i]);
            }

            // Mise à jour des couleurs
            for (int i = 1; i <= 6; i++)
            {
              // case grise si validation nécessaire
              if (lblPer[i].Text != "")
              {
                switch (i)
                {
                  case 1:
                    lblSign[i].BackColor = MozartColors.ColorH8000000F;
                    break;
                  case 2:
                    //si deleg 1 >= deleg 2
                    if ((double)lblPer0.Tag > Convert.ToDouble(lblPer[i].Tag)) lblSign[i].BackColor = Color.White;
                    else lblSign[i].BackColor = MozartColors.ColorH8000000F;
                    break;
                  case 3:
                  case 4:
                  case 5:
                    //si deleg n >= deleg n+1
                    if ((double)lblPer0.Tag >= Convert.ToDouble(lblPer[i].Tag)) lblSign[i].BackColor = Color.White;
                    else
                    {
                      // si cde > deleg n+1
                      if (MontantDevis > (double)Controls.Find($"lblPer{i - 1}", true)[0].Tag) lblSign[i].BackColor = MozartColors.ColorH8000000F;
                    }
                    break;
                  case 6:
                    // si montant sup à validation du responsable de service
                    if (MontantDevis > Convert.ToDouble(lblPer4.Tag)) lblSign[i].BackColor = MozartColors.ColorH8000000F;
                    else lblSign[i].BackColor = Color.White;
                    break;
                  default:
                    break;
                }
              }
            }

            // remarque sur délégation
            txtRmEng.Text = Utils.BlankIfNull(sdr["VRMQ"]);

            // gestion de l'édition
            lblPer6.Text = Utils.BlankIfNull(sdr["QUIEDIT"]);
            lblSign6.Text = "";
            if (DateTime.TryParse(Utils.BlankIfNull(sdr["DEDIT"]), out dn))
              lblSign6.Text = $"{dn.ToShortDateString()}{Environment.NewLine}{dn.TimeOfDay}";
            lblSign6.Tag = (int)Utils.ZeroIfNull(sdr["QEDIT"]);

            //  titre du tableau
            setTexteValidation(StatutValidation, false);
          }
          else
          {
            // Pas de données de validation
            DevisEnablePrintAndVisu?.Invoke(this, null);
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void setTexteValidation(String pStatutValidation, bool pUpdateDB = true)
    {
      string sSQL;

      StatutValidation = pStatutValidation;

      switch (StatutValidation)
      {
        case "E":
          lblTxt.Text = Resources.txt_devis_att_valid;
          lblTxt.ForeColor = Color.Red;
          break;

        case "V":
          lblTxt.Text = Resources.txt_devis_val_a_edit;
          lblTxt.ForeColor = Color.Orange;

          if (pUpdateDB)
          {
            sSQL = $"UPDATE TACT SET VACTOBS = '{MozartParams.strUID} : {Resources.txt_Valid_devis_client} N° DC{NumDevis} {Resources.lib_le} ' + CONVERT(varchar(10), getdate(), 103) + ' à ' + CONVERT(VARCHAR(10), getdate(), 108) + '.' + CHAR(13) + CHAR(10) + COALESCE(VACTOBS,'''')";
            //sSQL += " ,CACTVUEWEB = 'O'";
            sSQL += $" WHERE NACTNUM = {MozartParams.NumAction}";
            MozartDatabase.ExecuteNonQuery(sSQL);
          }
          break;

        case "I":
          lblTxt.Text = Resources.txt_devis_edite_envoye;
          lblTxt.ForeColor = Color.Green;

          if (pUpdateDB)
          {
            lblPer6.Text = MozartParams.strUID;
            lblSign6.Text = DateTime.Now.ToShortDateString() + "\r\n" + DateTime.Now.ToString("T");

            sSQL = $"UPDATE TACT SET VACTOBS = '{MozartParams.strUID} : {Resources.txt_Edit_devis_client} N° DC{NumDevis} {Resources.lib_le} ' + CONVERT(varchar(10), getdate(), 103) + ' à ' + CONVERT(VARCHAR(10), getdate(), 108) + '.' + CHAR(13) + CHAR(10) + COALESCE(VACTOBS,'''')";
            sSQL += " ,CACTVUEWEB = 'O'";
            sSQL += $" WHERE NACTNUM = {MozartParams.NumAction}";
            MozartDatabase.ExecuteNonQuery(sSQL);
          }
          break;

        case "P":
          lblTxt.Text = Resources.txt_devis_en_construct;
          lblTxt.ForeColor = Color.Black;
          break;

        default:
          // On ne doit pas passer ici normalement
          break;
      }

      DevisStatusEventArgs lEvent = new DevisStatusEventArgs
      {
        StatutValidation = StatutValidation
      };
      DevisStatusUpdated?.Invoke(this, lEvent);
    }

    public void traitementDelegation(int pNumDevis, string pStrValidationDevis, double pMontantHT)
    {
      string lSql;
      
      StatutValidation = pStrValidationDevis;
      NumDevis = pNumDevis;
      MontantDevis = pMontantHT;

      try
      {
        int createur = 0;
        string datecre = "";
        string lReq;
        int N2 = 0;
        int N3 = 0;
        int N4 = 0;
        int N5 = 0;

        //  pas de délégation pour certaines sociétés
        string[] filiales = { "EMALECFACILITEAM", "EMALECSUISSE", "EMAFI", "EMALECDEV" };
        if (Array.Exists(filiales, p => p == MozartParams.NomSociete)) return;

        // recherche du créateur et de la date de creation
        using (SqlDataReader sdr = MozartDatabase.ExecuteReader($"SELECT NDCLQUICRE, DDCLDCRE FROM TDCL WHERE NDCLNUM = {NumDevis}"))
        {
          if (sdr.Read())
          {
            createur = (int)Utils.ZeroIfNull(sdr["NDCLQUICRE"]);
            if (Utils.BlankIfNull(sdr["DDCLDCRE"]) == "") datecre = "";
            else datecre = Utils.DateLongBlankIfNull(sdr["DDCLDCRE"]);
          }
        }

        // recherche du montant de validation du créateur
        double MontantValidation = Utils.ZeroIfNull(ModuleMain.GetMontantSeuilDevisByNPERNUM(createur));

        //  en modification, on supprime toutes les données de validation (sauf le créateur et les remarques) et on repart de zéro
        if (StatutValidation != "P")
        {
          MozartDatabase.ExecuteNonQuery($"delete TDCLVALID where NDCLNUM = {NumDevis}");
          // mise à jour du statut
          MozartDatabase.ExecuteNonQuery($"update TDCL set CDCLVALID='P' where NDCLNUM = {NumDevis}");
          StatutValidation = "P";
        }

        //  si montant validation supérieur, on valide automatiquement le devis
        if (MontantDevis < MontantValidation)
        {
          lSql = $"insert into TDCLVALID (NDCLNUM, QN1, DN1, VRMQ)";
          lSql += $" select {NumDevis},{createur}, '{datecre}', 'Montant du devis inférieur au montant de validation du créateur'";

          MozartDatabase.ExecuteNonQuery(lSql);

          MozartDatabase.ExecuteNonQuery($"update TDCL set CDCLVALID='V' where NDCLNUM = {NumDevis}");
          StatutValidation = "V";

          return;
        }

        //  suite si besoin
        // CASE 1
        //  on insert une ligne dans la table de validation avec le createur en case 1
        MozartDatabase.ExecuteNonQuery($"insert into TDCLVALID (NDCLNUM, QN1, DN1, VRMQ) select {NumDevis},{createur}, '{datecre}','{txtRmEng.Text.Replace("'", "''")}'");

        //  CASE 2, 3
        //  recherche de l'assistant CHAFF et du responsable du compte
        lReq = $"SELECT TCAN.NPERNUM AS NPERNUM_RESP, TCAN.NPERNUMASSCHAFF AS NPERNUM_ASSCHAFF FROM TCAN, TACT, TDIN, TDCL";
        lReq += $" WHERE TCAN.NCLINUM=TDIN.NCLINUM AND TACT.NDINNUM=TDIN.NDINNUM AND TCAN.NCANNUM=TDIN.NDINCTE AND TACT.NACTNUM = TDCL.NACTNUM AND NDCLNUM = {NumDevis}";
        using (SqlDataReader sdr = MozartDatabase.ExecuteReader(lReq))
        {
          if (sdr.Read())
          {
            N2 = (int)Utils.ZeroIfNull(sdr["NPERNUM_ASSCHAFF"]);
            N3 = Convert.ToInt32(sdr["NPERNUM_RESP"]);

            MozartDatabase.ExecuteNonQuery($"update TDCLVALID set QN2= {N2}, QN3= {N3} where NDCLNUM = {NumDevis}");
          }
        }

        // CASE 4 et 5
        // recherche du groupe et du service
        lReq = $"SELECT G.NPERNUM AS NPERNUM_GRP, S.NPERNUM AS NPERNUM_SVC FROM TREF_GROUPE G, TREF_SERVICE S, TPER P ";
        lReq += $"WHERE P.IDGROUPE=G.IDGROUPE AND G.IDSERVICE=S.IDSERVICE AND P.NPERNUM = {N3}";
        using (SqlDataReader sdr = MozartDatabase.ExecuteReader(lReq))
        {
          if (sdr.Read())
          {
            N4 = (int)Utils.ZeroIfNull(sdr["NPERNUM_GRP"]);
            N5 = (int)Utils.ZeroIfNull(sdr["NPERNUM_SVC"]);

            MozartDatabase.ExecuteNonQuery($"update TDCLVALID set QN4={N4}, QN5={N5} where NDCLNUM = {NumDevis}");
          }
        }

        // CASE 6  direction par defaut, on enregistre personne pour le moment (uniquement à la signature)

        //  mise a jour du statut
        MozartDatabase.ExecuteNonQuery($"update TDCL set CDCLVALID='E' where NDCLNUM = {NumDevis}");
        StatutValidation = "E";
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void lblSignALL_Click(object sender, EventArgs e)
    {
      int index = (int)Char.GetNumericValue((sender as apiLabel).Name[7]);
      //pas de validation possible car si créateur, deja validé
      if (index == 0) return;

      apiLabel[] lblSign = { lblSign0, lblSign1, lblSign2, lblSign3, lblSign4, lblSign5, lblSign6 };
      apiLabel[] lblNiv = { lblniv0, lblniv1, lblniv2, lblniv3, lblniv4, lblniv5, lblniv6 };
      apiLabel[] lblPer = { lblPer0, lblPer1, lblPer2, lblPer3, lblPer4, lblPer5, lblPer6 };

      //si déjà validé, pas utile de revalider
      if (lblSign[index].Text != "") return;
      //si pas de hierarchique sortir (sauf si edition)
      if (lblPer[index].Text == "" && index != 6) return;

      switch (index)
      {
        case 6:
          //  cas de l'edition du devis
          if (StatutValidation != "V")
          {
            if (!(StatutValidation == "P"))
              MessageBox.Show(Resources.txt_devis_must_validated, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
          else
          {
            // on enregistre l'edition du devis
            if (MessageBox.Show(Resources.txt_confirm_valid, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;

            MozartDatabase.ExecuteNonQuery($"update TDCLVALID set QEDIT={MozartParams.UID}, DEDIT=GetDate() where NDCLNUM = {NumDevis}");
            MozartDatabase.ExecuteNonQuery($"update TDCL set CDCLVALID='I' where NDCLNUM = {NumDevis}");

            setTexteValidation("I");
          }
          break;

        case 1:
        case 2:
        case 3:
        case 4:
          int[] lListeNPERNUM = null;

          //  cas des chefs de Groupe
          //  BARBOSA, DALBEPIERRE, roussillion, VIGIEUR,  bouyssi, Dumont doivent se voir l'un l'autre.
          if (index == 3)
          {
            lListeNPERNUM = new int[] { 226, 300, 1837, 1843, 3497, 3766, 4021, 4493, 3936, 622, 2066 };
          }
          else
          {
            //  cas des chefs de Service
            //  viguier et Dumont
            if (index == 4)
            {
              lListeNPERNUM = new int[] { 1837, 4021, 30 };
            }
          }

          if (lListeNPERNUM != null)
          {
            if (Array.Exists(lListeNPERNUM, element => element == MozartParams.UID))
            {
              if (Array.Exists(lListeNPERNUM, element => element == (int)lblSign[index].Tag))
              {
                if (txtRmEng.Text != "")
                {
                  if (MessageBox.Show(Resources.txt_confirm_valid_malgre_avert, Program.AppTitle, MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
                }
                else
                {
                  if (MessageBox.Show(Resources.txt_confirm_valid, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
                }
                // mise à jour de la validation
                lblPer[index].Tag = ModuleMain.GetMontantSeuilDevisByNPERNUM(MozartParams.UID);

                string dateValid = $"{DateTime.Now.ToShortDateString()} {DateTime.Now:T}";
                string sMsg = $"{MozartParams.strUID} {Resources.lib_le} {dateValid} : {Resources.txt_valid_as} {lblNiv[index].Text}";
                MozartDatabase.ExecuteNonQuery($"update TDCLVALID set DN{index + 1}=GetDate(), QN{index + 1}={MozartParams.UID}, VRMQ = '{sMsg}' + char(13) + char(10) + isnull(VRMQ, '') where NDCLNUM = {NumDevis}");
                lblSign[index].Text = dateValid;
                txtRmEng.Text = sMsg + Environment.NewLine + txtRmEng.Text;

                if (Convert.ToDouble(lblPer[index].Tag) >= MontantDevis)
                {
                  MozartDatabase.ExecuteNonQuery($"update TDCL set CDCLVALID='V' where CDCLVALID<>'I' and NDCLNUM = {NumDevis}");

                  setTexteValidation("V");
                }
                return;
              }
            }
          }

          if ((int)lblSign[index].Tag == MozartParams.UID)
          {
            if (txtRmEng.Text != "")
            {
              if (MessageBox.Show(Resources.txt_confirm_valid_malgre_avert, Program.AppTitle, MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
            }
            else
            {
              if (MessageBox.Show(Resources.txt_confirm_valid, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                  MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
            }

            // mise a jour de la validation
            string dateValid = $"{DateTime.Now.ToShortDateString()} {DateTime.Now:T}";
            string sMsg = $"{MozartParams.strUID} {Resources.lib_le} {dateValid} : {Resources.txt_valid_as} {lblNiv[index].Text}";
            MozartDatabase.ExecuteNonQuery($"update TDCLVALID set DN{index + 1}=GetDate(), VRMQ = '{sMsg}' + char(13) + char(10) + isnull(VRMQ, '') where NDCLNUM = {NumDevis}");
            txtRmEng.Text = sMsg + Environment.NewLine + txtRmEng.Text;

            lblSign[index].Text = DateTime.Now.ToShortDateString() + "\r\n" + DateTime.Now.ToString("T");
            if (Convert.ToDouble(lblPer[index].Tag) >= MontantDevis)
            {
              MozartDatabase.ExecuteNonQuery($"update TDCL set CDCLVALID='V' where CDCLVALID<>'I' and NDCLNUM = {NumDevis}");

              setTexteValidation("V");
            }
          }
          break;

        case 5:
          //si index=5 (direction), c'est un cas particulier
          //  FGA le 260923 gestion par societe de l'utilisateur
          int dirOk = (int)MozartDatabase.ExecuteScalarInt($"SELECT COUNT(P.NPERNUM) FROM TDIRECTION D INNER JOIN TPER P ON D.NPERNUM = P.NPERNUM " +
                                                      $"WHERE P.NPERNUM = {MozartParams.UID}");
          if (dirOk == 1)
          {
            // on enregistre la validation et on valide
            if (txtRmEng.Text != "")
            {
              if (MessageBox.Show(Resources.txt_confirm_valid_malgre_avert, Program.AppTitle, MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
            }
            else
            {
              if (MessageBox.Show(Resources.txt_confirm_valid, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                  MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
            }

            // mise a jour de la validation
            string dateValid = $"{DateTime.Now.ToShortDateString()} {DateTime.Now:T}";
            string sMsg = $"{MozartParams.strUID} {Resources.lib_le} {dateValid} : {Resources.txt_valid_as} {lblNiv[index].Text}";
            MozartDatabase.ExecuteNonQuery($"update TDCLVALID set QN{index + 1}={MozartParams.UID}, DN{index + 1}=GetDate(), VRMQ = '{sMsg}' + char(13) + char(10) + isnull(VRMQ, '') where NDCLNUM = {NumDevis}");
            MozartDatabase.ExecuteNonQuery($"update TDCL set CDCLVALID='V' where CDCLVALID<>'I' and NDCLNUM = {NumDevis}");
            txtRmEng.Text = sMsg + Environment.NewLine + txtRmEng.Text;

            setTexteValidation("V");

            lblPer5.Text = MozartParams.strUID;
            lblSign5.Text = DateTime.Now.ToShortDateString() + "\r\n" + DateTime.Now.ToString("T");
          }
          break;

        default:
          break;
      }
    }

    private void txtRmEng_Enter(object sender, EventArgs e)
    {
      DevisRemarqueEnter?.Invoke(this, null);
    }
  }
}
