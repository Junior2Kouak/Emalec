using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmDetailsSTF : Form
  {
    public string mstrStatut;
    public string mstrNomSTF;
    public long miNumSTF;
    public bool mbDroitDocAdmin;

    bool mbModif;
    DataTable dt = new DataTable();

    public frmDetailsSTF()
    {
      InitializeComponent();
    }

    private void frmDetailsSTF_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);
        mbModif = false;
        lblST.Text = mstrNomSTF;

        // chargement de toutes les combos
        ModuleData.RemplirCombo(cboPays, $"select NPAYSNUM, VPAYSNOM from TPAYS where VPAYSNOM <> 'BELGIË' and VPAYSNOM <> 'SWITZERLAND' and VPAYSNOM <> 'SVIZZERA' order by VPAYSNOM");
        cboPays.ValueMember = "NPAYSNUM";
        cboPays.DisplayMember = "VPAYSNOM";

        ModuleData.RemplirCombo(cboStatut, $"select ID, VLIBSTATUT from TREF_STATUT order by VLIBSTATUT");
        cboStatut.ValueMember = "ID";
        cboStatut.DisplayMember = "VLIBSTATUT";

        InitApigridModHisto();

        cboReglement.Init(MozartDatabase.cnxMozart, $"SELECT NUMTYPEREGL,VLIBREGL FROM TREF_TYPEREGL WHERE LANGUE = '{MozartParams.Langue}' ORDER BY VLIBREGL", "NUMTYPEREGL", "VLIBREGL", new List<string>() { Resources.col_Num, Resources.col_Nom }, 150, 550, true);

        // gestion de droit sur la modification du nom pour Jean et Pierre
        if (ModuleMain.RechercheDroitMenu(543))
          txtNom.Enabled = true;

        //gestion de droit sur la fonction de privilège 3 mois
        if (ModuleMain.RechercheDroitMenu(544))
          chk3M.Enabled = true;

        mbDroitDocAdmin = true;

        //gestion de droit sur la fonction de privilège 3 mois
        if (ModuleMain.RechercheDroitMenu(714))
          chkSansDoc.Enabled = true;

        //gestion de droit sur la fonction de privilège 3 mois
        chkContratCadre.Enabled = ModuleMain.RechercheDroitMenu(717);

        // traitement du cas de modification ou de création
        //"Cas traité par un programme externe"
        //if (mstrStatut == "C")
        //  OuvertureEnCreation();
        //else
        OuvertureEnModification();
        cboPays_SelectionChangeCommitted(null, null);

        GestionBoutons();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      try
      {
        // si il y a des modification
        if (mbModif)
        {
          switch (MessageBox.Show(Resources.msgConfirm_enregistrerModif, Program.AppTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
          {
            case DialogResult.Yes:
              cmdEnregistrer_Click(null, null);
              Dispose();
              break;
            case DialogResult.No:
              Dispose();
              break;
            case DialogResult.Cancel:
              return;
          }
        }
        else
          Dispose();

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdEnregistrer_Click(object sender, EventArgs e)
    {
      try
      {
        // test du nom
        if (txtNom.Text == "")
        {
          MessageBox.Show(Resources.msg_Saisir_nom_fournisseur);
          txtNom.Focus();
          return;
        }

        // recherche si le nom du site n'est pas un doublon(uniquement sur la création)
        //"Cas traité par un programme externe"
        //if (mstrStatut == "C")
        //{
        //  if (NomExist(txtNom.Text))
        //  {
        //    MessageBox.Show(Resources.msg_Saisir_autre_nom_fournisseur_car_existe_deja);
        //    txtNom.Focus();
        //    return;
        //  }
        //}

        // test de la sélection d'un pays
        if (cboPays.Text == "")
        {
          MessageBox.Show(Resources.msg_must_select_pays);
          return;
        }

        if (cboPays.Text == "FRANCE")
        {
          // test de la sélection d'une ville
          if (cboVille.Text == "")
          {
            MessageBox.Show(Resources.msg_must_select_ville);
            return;
          }
        }
        else
        {
          if (txtVille.Text == "")
          {
            MessageBox.Show(Resources.msg_must_select_ville);
            return;
          }
          //' NL 17/12/2015 : Si étranger, choix d'un type de STT obligatoire
          if (ChkTypFO.Checked == false)
          {
            if (ChkSTTEtrFran.Checked = false && ChkSTTEtrPart.Checked == false && ChkSTTEtrSimple.Checked == false)
            {
              MessageBox.Show("Sélectionnez un type de STT étranger");
              return;
            }
          }
        }

        if (ChkTypFO.Checked == false && ChkTypMaint.Checked == false && ChkTypInstall.Checked == false && ChkTypGarant.Checked == false)
        {
          MessageBox.Show(Resources.msg_must_select_type);
          return;
        }

        // test de la sélection d'une status social
        if (cboStatut.Text == "" && (ChkTypMaint.Checked == true || ChkTypInstall.Checked == true || ChkTypGarant.Checked == true) && cboPays.Text == "FRANCE")
        {
          MessageBox.Show("Sélectionnez un statut social");
          return;
        }

        Enregistrer();

        // on passe la feuille en statut modification
        mstrStatut = "M";

        OuvertureEnModification();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void CmdDocAdminSTF_Click(object sender, EventArgs e)
    {
      frmGestDocAdminSTF f = new frmGestDocAdminSTF();
      f.miStfGrpNnum = miNumSTF;
      f.mstrNom = txtNom.Text;
      f.ShowDialog();
    }

    private void cmdCR_Click(object sender, EventArgs e)
    {
      framObs.Visible = true;
      TxtObs.Focus();
    }

    private void CmdDocSTFCondCom_Click(object sender, EventArgs e)
    {
      frmGestDocComSTF f = new frmGestDocComSTF();
      f.miStfGrpNnum = miNumSTF;
      f.mstrNom = txtNom.Text;
      f.ShowDialog();

      // rafraichessement de la page (si modification dans les doc)
      OuvertureEnModification();

      // bouton jaune
      GestionBoutons();
    }

    private void cmdRecherche_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmRechCodePostal { ControlCible1 = txtCP, ControlCible2 = cboVille }.ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void OuvertureEnCreation()
    {
      try
      {
        // renseignement de la partie client
        foreach (Control c in Controls)
        {
          if (c is TextBox)
          {
            c.Text = "";
          }
        }

        cboPays.Text = "FRANCE";
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdAnObs_Click(object sender, EventArgs e)
    {
      TxtObs.Text = "";
      framObs.Visible = false;
    }

    private void cmdValObs_Click(object sender, EventArgs e)
    {
      string msg;
      string temp;
      // position en début de text quand focus et avec saut de ligne
      temp = MozartParams.strUID + " le " + DateTime.Now.ToString("dd/MM/yy HH:MM") + " : " + "\r\n";
      msg = TxtObs.Text;
      if (msg == "")
        return;
      else
      {
        if (txtObserv.Text == "")
          txtObserv.Text = temp + msg.Replace("'", "''");
        else
          txtObserv.Text = temp + msg.Replace("'", "''") + "\r\n" + txtObserv.Text;
      }
      mbModif = true;
      framObs.Visible = false;
    }

    private void InitApigridModHisto()
    {
      apiTGridHisto.AddColumn(Resources.col_Societe, "VSOCIETE", 1000);
      apiTGridHisto.AddColumn(Resources.col_Qui_modif, "NQUIMODIF", 2000);
      apiTGridHisto.AddColumn(Resources.col_date_modif, "DDATEMODIF", 1800, "Date");
      apiTGridHisto.AddColumn(Resources.col_Status_soc, "VLIBSTATUT", 2300);
      apiTGridHisto.AddColumn(Resources.col_CA, "NSTFGRPCA", 1100, "currency", 1);

      apiTGridHisto.FilterBar = false;
    }

    private void OuvertureEnModification()
    {
      SqlDataReader dr;
      DataTable dtRs = new DataTable();
      try
      {
        // recherche des informations de l'action
        string sSQL = $"SELECT *,  (SELECT VPERPRE + ' ' + VPERNOM FROM TPER WHERE NPERNUM = NSTFGRPQUIP3M) as  VQUIP3M,  " +
          $"(SELECT VPERPRE + ' ' + VPERNOM FROM TPER WHERE NPERNUM = NSTFGRPQUICA) as VQUICA, " +
          $"(SELECT VPERPRE + ' ' + VPERNOM FROM TPER WHERE NPERNUM = NSTFGRPQUITYPE) as VQUITYPE, " +
          $"(SELECT VPERPRE + ' ' + VPERNOM FROM TPER WHERE NPERNUM = NSTFGRPQUICONTRATCADRE) AS VQUICC " +
          $"FROM TSTFGRP WHERE NSTFGRPNUM = {miNumSTF}";

        dr = ModuleData.ExecuteReader(sSQL);
        dtRs.Load(dr);
        dr.Close();

        DataRow row = dtRs.Rows[0];
        //Gestion du bouton pour document administratif seulement pour les STF
        if (mbDroitDocAdmin)
        {
          if (Convert.ToInt32(Utils.ZeroIfNull(row["NSTFGRPTYPMNT"])) == 1 || Convert.ToInt32(Utils.ZeroIfNull(row["NSTFGRPTYPINST"])) == 1 || Convert.ToInt32(Utils.ZeroIfNull(row["NSTFGRPTYPGAR"])) == 1)
            CmdDocAdminSTF.Visible = true;
          else
            CmdDocAdminSTF.Visible = false;
        }

        txtNom.Text = Utils.BlankIfNull(row["VSTFGRPNOM"]);
        txtAD1.Text = Utils.BlankIfNull(row["VSTFGRPAD1"]);
        txtAD2.Text = Utils.BlankIfNull(row["VSTFGRPAD2"]);
        txtCP.Text = Utils.BlankIfNull(row["VSTFGRPCP"]);
        txtVille.Text = Utils.BlankIfNull(row["VSTFGRPVIL"]);
        txtRegl.Text = Utils.BlankIfNull(row["VSTFGRPREGLMT"]);
        txtObserv.Text = Utils.BlankIfNull(row["VSTFGRPCRREUNION"]);
        txtNote.Text = Utils.BlankIfNull(row["NSTFGRPNOTE"]);
        txtDateCre.Text = Utils.DateBlankIfNull(row["DSTFGRPCREE"]);

        txtCA.Text = Utils.BlankIfNull(row["NSTFGRPCA"]);
        lblDateCA.Text = Utils.BlankIfNull(row["VQUICA"]) + " le " + Utils.DateBlankIfNull(row["DSTFGRPDCA"]);


        ChkTypFO.Checked = Convert.ToInt32(Utils.ZeroIfNull(row["NSTFGRPTYPFO"])) == 1;
        ChkTypMaint.Checked = Convert.ToInt32(Utils.ZeroIfNull(row["NSTFGRPTYPMNT"])) == 1;
        ChkTypInstall.Checked = Convert.ToInt32(Utils.ZeroIfNull(row["NSTFGRPTYPINST"])) == 1;
        ChkTypGarant.Checked = Convert.ToInt32(Utils.ZeroIfNull(row["NSTFGRPTYPGAR"])) == 1;
        chkDec.Checked = (Utils.BlankIfNull(row["CSTFGRPDEC"].ToString()) == "N");
        chkSansDoc.Checked = Utils.BlankIfNull(row["CSTFGRPSANSDOC"].ToString()) == "O";

        if (Utils.BlankIfNull(row["BSTFGRPDOCADM"]) == "")
          ChkDocAdm.Checked = false;
        else
          ChkDocAdm.Checked = Convert.ToBoolean(row["BSTFGRPDOCADM"]);

        chk3M.Checked = row["CSTFGRPP3M"].ToString() == "O";
        if (chk3M.Checked)
          lbl3M.Text = Utils.BlankIfNull(row["VQUIP3M"]) + " le " + Utils.DateBlankIfNull(row["DSTFGRPDP3M"]);
        else
          lbl3M.Text = "";

        switch (Utils.BlankIfNull(row["CSTFGRPTYPE"]).ToUpper())
        {
          case "N":
            ChkSTTEtrSimple.Checked = true;
            break;
          case "C":
            chkChallenger.Checked = true;
            lblChallenger.Text = $"Renseigné par {Utils.BlankIfNull(row["VQUITYPE"])} le {Utils.DateBlankIfNull(row["DSTFGRPTYPE"])}";
            break;
          case "A":
            chkAspirant.Checked = true;
            lblAspirant.Text = $"Renseigné par {Utils.BlankIfNull(row["VQUITYPE"])} le {Utils.DateBlankIfNull(row["DSTFGRPTYPE"])}";
            break;
          case "P":
            chkPartenaire.Checked = true;
            lblPartenaire.Text = $"Renseigné par {Utils.BlankIfNull(row["VQUITYPE"])} le {Utils.DateBlankIfNull(row["DSTFGRPTYPE"])}";
            lblChallenger.Text = lblAspirant.Text = "";
            break;
        }

        TxtFrancoPort.Text = Utils.BlankIfNull(row["NSTFGRPMTTPORT"]);
        txtFranco.Text = Utils.BlankIfNull(row["VSTFGRPFRANCO"]);

        switch (Utils.BlankIfNull(row["VSTFETRTYPE"]).ToUpper())
        {
          case "STTS":
            ChkSTTEtrSimple.Checked = true;
            break;
          case "STTP":
            ChkSTTEtrPart.Checked = true;
            break;
          case "STTPF":
            ChkSTTEtrFran.Checked = true;
            break;
        }
        // Ajout du 28 / 07 / 2016
        chkContratCadre.Checked = Convert.ToInt32(Utils.ZeroIfNull(row["NSTFGRPCONTRATCADRE"])) == 1;
        if (chkContratCadre.Checked)
        {
          lblModifCC.Text = $"{Utils.BlankIfNull(row["VQUICC"])} le {Utils.DateBlankIfNull(row["DSTFGRPDCONTRATCADRE"])}";
        }
        else
        {
          lblModifCC.Text = "";
        }
        chkRefEncours.Checked = Convert.ToInt32(Utils.ZeroIfNull(row["NSTFGRPREFENCOURS"])) == 1;

        chkCSTFGRPPARTVALIDE.Checked = row["CSTFGRPPARTVALIDE"].ToString() == "O";

        // combo de la ville
        cboVille.Text = Utils.BlankIfNull(row["VSTFGRPVIL"]);
        if (cboVille.SelectedIndex == -1)
        {
          cboVille.Items.Add(Utils.BlankIfNull(row["VSTFGRPVIL"]));
          cboVille.Text = Utils.BlankIfNull(row["VSTFGRPVIL"]);
        }

        //  ' combo du pays
        if (cboVille.SelectedIndex == -1)
          cboPays.Text = Utils.BlankIfNull(row["VSTFGRPPAYS"]);
        if (cboPays.SelectedIndex == -1)
        {
          cboPays.Items.Add(Utils.BlankIfNull(row["VSTFGRPPAYS"]));
          cboPays.Text = Utils.BlankIfNull(row["VSTFGRPPAYS"]);
        }

        cboPays.Text = Utils.BlankIfNull(row["VSTFGRPPAYS"]) == "" ? "FRANCE" : row["VSTFGRPPAYS"].ToString();

        if (cboPays.Text != "FRANCE")
          FrameSTTEtranger.Visible = true;

        // combo social
        cboStatut.SetItemData(row["NSTFSOCIAL"].ToString());

        // cbo reglement
        cboReglement.SetItemData(Convert.ToInt32(Utils.ZeroIfNull(row["NUMTYPEREGL"])));

        // traitement des réponses aux question Challenger
        string code = Utils.BlankIfNull(row["CSTFGRPREPONSE"]);
        if (code != "") DecodeReponse(code);

        lstSTFSites.Items.Clear();
        using (SqlDataReader dr2 = ModuleData.ExecuteReader($"SELECT VSTFNOM + ' ' + ISNULL(VSTFAD1, '-') + ' ' + ISNULL(VSTFCP, '-') + ' ' + ISNULL(VSTFVIL, '-') FROM TSTF WHERE CSTFACTIF = 'O' AND NSTFGRPNUM = {row["NSTFGRPNUM"]}  ORDER BY 1"))
        {
          while (dr2.Read())
            lstSTFSites.Items.Add(dr2[0]);
        }
        // on charge l histo des modif ca et statut
        ModuleData.ExecuteNonQuery($"EXEC api_sp_ListeModifSTFGRP {row["NSTFGRPNUM"]}");
        apiTGridHisto.LoadData(dt, MozartDatabase.cnxMozart, $"EXEC api_sp_ListeModifSTFGRP {row["NSTFGRPNUM"]}");
        apiTGridHisto.GridControl.DataSource = dt;

        //InitApigridModHisto();

        apiTGridHisto.Requery(dt, MozartDatabase.cnxMozart);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    private void Enregistrer()
    {
      try
      {
        // Création ou modification, c'est la proc stock qui gère
        // création d'une commande
        // passage du nom de la procédure stockée
        using (SqlCommand cmd = new SqlCommand("api_sp_CreationFournisseur", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

          //  liste des paramètres
          cmd.Parameters["@iFourn"].Value = miNumSTF;   // 0 si création;

          if (ChkTypFO.Checked == true && (ChkTypMaint.Checked == false && ChkTypInstall.Checked == false && ChkTypGarant.Checked == false))
            cmd.Parameters["@vType"].Value = "FO";
          else
          {
            if (ChkTypFO.Checked == true && (ChkTypMaint.Checked == true || ChkTypInstall.Checked == true || ChkTypGarant.Checked == true))
              cmd.Parameters["@vType"].Value = "FT";
            else
            {
              if (ChkTypFO.Checked == false && (ChkTypMaint.Checked == true || ChkTypInstall.Checked == true || ChkTypGarant.Checked == true))
                cmd.Parameters["@vType"].Value = "ST";
            }
          }

          if (chkCSTFGRPPARTVALIDE.Checked == true)
            cmd.Parameters["@cSTFGRPPARTVALIDE"].Value = "O";
          else
            cmd.Parameters["@cSTFGRPPARTVALIDE"].Value = "N";

          cmd.Parameters["@vNom"].Value = txtNom.Text.ToUpper();
          cmd.Parameters["@vAd1"].Value = txtAD1.Text;
          cmd.Parameters["@vAd2"].Value = txtAD2.Text;
          cmd.Parameters["@vCp"].Value = txtCP.Text;
          cmd.Parameters["@vVille"].Value = cboPays.Text == "FRANCE" ? cboVille.Text : txtVille.Text;
          cmd.Parameters["@vPays"].Value = cboPays.Text;
          cmd.Parameters["@vRegl"].Value = txtRegl.Text;
          cmd.Parameters["@iTypFo"].Value = ChkTypFO.Checked ? 1 : 0;
          cmd.Parameters["@iTypMaint"].Value = ChkTypMaint.Checked ? 1 : 0;
          cmd.Parameters["@iTypInstall"].Value = ChkTypInstall.Checked ? 1 : 0;
          cmd.Parameters["@iTypGarant"].Value = ChkTypGarant.Checked ? 1 : 0;
          cmd.Parameters["@CRSTT"].Value = txtObserv.Text;
          cmd.Parameters["@cP3M"].Value = chk3M.Checked ? "O" : "N";
          cmd.Parameters["@vSocial"].Value = cboStatut.GetItemData() == 0 ? null : cboStatut.GetItemData().ToString();
          //cmd.Parameters["@CA"].Value = txtCA.Text == "" ? null : txtCA.Text;
          cmd.Parameters["@CA"].Value = long.TryParse(txtCA.Text, out var v) ? v : (object)DBNull.Value;
          cmd.Parameters["@P_NSTFGRPMTTPORT"].Value = TxtFrancoPort.Text == "" ? null : TxtFrancoPort.Text;
          cmd.Parameters["@vSTFGRPFRANCO"].Value = Utils.BlankIfNull(txtFranco.Text);
          cmd.Parameters["@cDEC"].Value = chkDec.Checked ? "N" : "O";
          cmd.Parameters["@DocAdm"].Value = ChkDocAdm.Checked ? 1 : 0;
          cmd.Parameters["@Type"].Value = CodeType();
          cmd.Parameters["@cSansDoc"].Value = chkSansDoc.Checked ? "O" : "N";

          // NL le 17/12/2015 : Ajout du type de sous-traitant pour les étrangers
          if (ChkSTTEtrSimple.Checked)
            cmd.Parameters["@vEtrType"].Value = "STTS";
          else
          {
            if (ChkSTTEtrPart.Checked)
              cmd.Parameters["@vEtrType"].Value = "STTP";
            else
            {
              if (ChkSTTEtrFran.Checked)
                cmd.Parameters["@vEtrType"].Value = "STTPF";
            }
          }

          // NL le 28/07/2016
          cmd.Parameters["@nSTFGRPCONTRATCADRE"].Value = chkContratCadre.Checked ? 1 : 0; ;
          cmd.Parameters["@nSTFGRPREFENCOURS"].Value = chkRefEncours.Checked ? 1 : 0; ;

          cmd.Parameters["@numTyperegl"].Value = cboReglement.GetItemData();



          cmd.ExecuteNonQuery();
          // récupération du numéro crée
          miNumSTF = (int)cmd.Parameters[0].Value;
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void GestAfficheBtnDocAdminSTF()
    {
      if (ChkTypFO.Checked == true && (ChkTypMaint.Checked == false && ChkTypInstall.Checked == false && ChkTypGarant.Checked == false))
      {
        CmdDocAdminSTF.Visible = false;
        lblLabels0.Visible = true;
        TxtFrancoPort.Visible = true;
      }
      else
      {
        if (ChkTypFO.Checked == true && (ChkTypMaint.Checked == true || ChkTypInstall.Checked == true || ChkTypGarant.Checked == true))
        {
          CmdDocAdminSTF.Visible = true;
          lblLabels0.Visible = true;
          TxtFrancoPort.Visible = true;
        }
        else
        {
          if (ChkTypFO.Checked == false && (ChkTypMaint.Checked == true || ChkTypInstall.Checked == true || ChkTypGarant.Checked == true))
          {
            CmdDocAdminSTF.Visible = true;
            lblLabels0.Visible = false;
            TxtFrancoPort.Visible = false;
          }
        }
      }
    }

    private void ChkTypFO_Click(object sender, EventArgs e)
    {
      GestAfficheBtnDocAdminSTF();
    }

    private void ChkTypGarant_Click(object sender, EventArgs e)
    {
      GestAfficheBtnDocAdminSTF();
    }

    private void ChkTypInstall_Click(object sender, EventArgs e)
    {
      GestAfficheBtnDocAdminSTF();
    }

    private void ChkTypMaint_Click(object sender, EventArgs e)
    {
      GestAfficheBtnDocAdminSTF();
    }

    private void txtCP_TextChanged(object sender, EventArgs e)
    {
      if (txtCP.Text.Length > 1 && cboPays.Text == "FRANCE")
      {
        ModuleMain.RechercheCommune(txtCP.Text, cboVille);
      }
    }

    private void txtVille_Leave(object sender, EventArgs e)
    {
      txtVille.Text = txtVille.Text.ToUpper();
    }

    private void txtCA_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (Convert.ToInt32(e.KeyChar) == 8) return;
      if (Convert.ToInt32(e.KeyChar) < 48 || Convert.ToInt32(e.KeyChar) > 57)
        e.Handled = true;
    }

    private void TxtFrancoPort_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (Convert.ToInt32(e.KeyChar) == 8) return;
      if (Convert.ToInt32(e.KeyChar) < 48 || Convert.ToInt32(e.KeyChar) > 57) e.KeyChar = '0';
    }

    private void txtSiren_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (Convert.ToInt32(e.KeyChar) == 8) return;
      if (Convert.ToInt32(e.KeyChar) < 48 || Convert.ToInt32(e.KeyChar) > 57)
        e.Handled = true;
    }

    private void GestionBoutons()
    {
      using (SqlDataReader dr = ModuleData.ExecuteReader($"exec api_sp_ListeDocSTFConditionsCommerciales {miNumSTF}"))
      {
        if (dr.HasRows)
        {
          CmdDocSTFCondCom.BackColor = Color.FromArgb(251, 255, 83);
        }
        else
        {
          CmdDocSTFCondCom.BackColor = Color.FromArgb(224, 224, 224);     // couleur systeme par défaut;
        }
      }
    }

    private void ChkSTTEtrFran_MouseDown(object sender, MouseEventArgs e)
    {
      if (ChkSTTEtrPart.Checked == true)
        ChkSTTEtrPart.Checked = false;
      if (ChkSTTEtrSimple.Checked == true)
        ChkSTTEtrSimple.Checked = false;
    }

    private void ChkSTTEtrPart_MouseDown(object sender, MouseEventArgs e)
    {
      if (ChkSTTEtrFran.Checked == true)
        ChkSTTEtrFran.Checked = false;
      if (ChkSTTEtrSimple.Checked == true)
        ChkSTTEtrSimple.Checked = false;
    }

    private void ChkSTTEtrSimple_MouseDown(object sender, MouseEventArgs e)
    {
      if (ChkSTTEtrPart.Checked == true)
        ChkSTTEtrPart.Checked = false;
      if (ChkSTTEtrFran.Checked == true)
        ChkSTTEtrFran.Checked = false;
    }

    private void cboPays_SelectionChangeCommitted(object sender, EventArgs e)
    {
      bool bDisplayForFrance = (cboPays.Text == "FRANCE");

      cboVille.Visible = bDisplayForFrance;
      txtVille.Visible = !bDisplayForFrance;
      cmdRecherche.Visible = bDisplayForFrance;
      FrameSTTEtranger.Visible = !bDisplayForFrance;
    }

    // checkbox des questions pour le Challenger
    private void chk_CheckedChanged(object sender, EventArgs e)
    {
      CheckBox chk = (sender as CheckBox);
      string nom = chk.Name;

      if (chk.Checked)
      {
        switch (nom)
        {
          case "chkO1":
            {
              chkN1.Checked = false;
              break;
            }

          case "chkO2":
            {
              chkN2.Checked = false;
              break;
            }

          case "chkO3":
            {
              chkN3.Checked = false;
              break;
            }

          case "chkN1":
            {
              chkO1.Checked = false;
              break;
            }

          case "chkN2":
            {
              chkO2.Checked = false;
              break;
            }

          case "chkN3":
            {
              chkO3.Checked = false;
              break;
            }
        }
      }
    }

    private void btnChallenger_Click(object sender, EventArgs e)
    {
      grpChallenger.Visible = true;
    }

    private void cmdAnnuler_Click(object sender, EventArgs e)
    {
      grpChallenger.Visible = false;
    }

    private void cmdValiderChallenger_Click(object sender, EventArgs e)
    {

      // il faut répondre à toutes les questions
      if ((!chkO1.Checked && !chkN1.Checked) || (!chkO2.Checked && !chkN2.Checked) || (!chkO3.Checked && !chkN3.Checked))
      {
        MessageBox.Show("Il faut répondre à toutes les questions.", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
        return;
      }

      if (chkO1.Checked && chkO2.Checked && chkO3.Checked)
      {
        // coche et enregistrement de qui/quand dans le label prévu
        // Chalenger : C
        // Aspirant : A
        //Partenaire : P

        ModuleData.ExecuteReader($"Update TSTFGRP set CSTFGRPTYPE = '{CodeType()}', DSTFGRPTYPE=Getdate(), NSTFGRPQUITYPE = dbo.[GetUserID]() " +
                                $", CSTFGRPREPONSE = '{CodeReponse()}' where NSTFGRPNUM = {miNumSTF}");

        // fermeture de la fenetre des questions
        grpChallenger.Visible = false;

      }
      else
      {
        // si pas de réponse correcte aux questions, il faut interdir le STT
        switch (MessageBox.Show("Le sous-traitant va être interdit. Voulez-vous continuer ?", Program.AppTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
        {
          case DialogResult.Yes:
            // code interdir le STT
            ModuleData.ExecuteNonQuery($"exec api_sp_InterdirSTT {miNumSTF}");

            // enregistrement des réponses 
            ModuleData.ExecuteReader($"Update TSTFGRP set CSTFGRPTYPE = '{CodeType()}', DSTFGRPTYPE=Getdate(), NSTFGRPQUITYPE = dbo.[GetUserID]() " +
                        $", CSTFGRPREPONSE = '{CodeReponse()}' where NSTFGRPNUM = {miNumSTF}");

            // fermeture de la fenetre des questions
            grpChallenger.Visible = false;

            break;
          case DialogResult.No:
            // enregistrement des réponses 
            ModuleData.ExecuteReader($"Update TSTFGRP set CSTFGRPTYPE = '{CodeType()}', DSTFGRPTYPE=Getdate(), NSTFGRPQUITYPE = dbo.[GetUserID]() " +
                        $", CSTFGRPREPONSE = '{CodeReponse()}' where NSTFGRPNUM = {miNumSTF}");

            // fermeture de la fenetre des questions
            grpChallenger.Visible = false;

            break;
          case DialogResult.Cancel:
            return;
        }

      }
    }

    // Chalenger : C
    // Aspirant : A
    //Partenaire : P
    private string CodeType()
    {
      if (chkChallenger.Checked)
      {
        return "C";
      }
      if (chkAspirant.Checked)
      {
        return "A";
      }
      if (chkPartenaire.Checked)
      {
        return "P";
      }
      return "N";
    }

    private string CodeReponse()
    {
      string R1 = chkO1.Checked ? "1" : "0";
      string R2 = chkO2.Checked ? "1" : "0";
      string R3 = chkO3.Checked ? "1" : "0";

      return $"{R1}{R2}{R3}";
    }

    private void DecodeReponse(string code)
    {
      chkO1.Checked = Convert.ToInt32(Strings.Mid(code, 1, 1)) == 1;
      chkO2.Checked = Convert.ToInt32(Strings.Mid(code, 2, 1)) == 1;
      chkO3.Checked = Convert.ToInt32(Strings.Mid(code, 3, 1)) == 1;
      chkN1.Checked = Convert.ToInt32(Strings.Mid(code, 1, 1)) == 0;
      chkN2.Checked = Convert.ToInt32(Strings.Mid(code, 2, 1)) == 0;
      chkN3.Checked = Convert.ToInt32(Strings.Mid(code, 3, 1)) == 0;
    }

    // checkbox des types (challenger, aspirant, partenaire
    private void chkType_CheckedChanged(object sender, EventArgs e)
    {
      CheckBox chk = (sender as CheckBox);
      string nom = chk.Name;

      if (chk.Checked)
      {
        switch (nom)
        {
          case "chkChallenger":
            chkAspirant.Checked = chkPartenaire.Checked = false;
            lblAspirant.Visible = lblPartenaire.Visible = false;
            btnAspirant.Enabled = btnPartenaire.Enabled = false;
            lblChallenger.Visible = true;
            btnChallenger.Enabled = true;
            break;

          case "chkAspirant":
            chkChallenger.Checked = chkPartenaire.Checked = false;
            lblChallenger.Visible = lblPartenaire.Visible = false;
            btnChallenger.Enabled = btnPartenaire.Enabled = false;
            lblAspirant.Visible = true;
            btnAspirant.Enabled = true;
            break;

          case "chkPartenaire":
            chkAspirant.Checked = chkChallenger.Checked = false;
            lblAspirant.Visible = lblChallenger.Visible = false;
            btnAspirant.Enabled = btnChallenger.Enabled = false;
            lblPartenaire.Visible = true;
            btnPartenaire.Enabled = true;
            break;
        }
      }
      else
      {
        lblAspirant.Visible = lblPartenaire.Visible = lblChallenger.Visible = false;
        btnAspirant.Enabled = btnPartenaire.Enabled = btnChallenger.Enabled = false;
      }
    }

    private void btnAspirant_Click(object sender, EventArgs e)
    {
      // copie du fichier modèle dans le répertoire de l'utilisateur
      string modele = $"{Utils.RechercheParam("MOZART_SYSTEM_FILES")}Modeles\\Groupe\\FR\\ASPIRANT.doc";
      string destination = $"{Environment.GetFolderPath(Environment.SpecialFolder.Personal)}\\ASPIRANT.doc";
      File.Copy(modele, destination, true);

      SFD.FileName = destination;
      SFD.Filter = "Fichiers WORD (*.doc)|*.doc";
      SFD.ShowDialog();
    }

    private void btnPartenaire_Click(object sender, EventArgs e)
    {
      // copie du fichier modèle dans le répertoire de l'utilisateur
      string modele = $"{Utils.RechercheParam("MOZART_SYSTEM_FILES")}Modeles\\Groupe\\FR\\PARTENAIRE.doc";
      string destination = $"{Environment.GetFolderPath(Environment.SpecialFolder.Personal)}\\PARTENAIRE.doc";
      File.Copy(modele, destination, true);

      SFD.FileName = destination;
      SFD.Filter = "Fichiers WORD (*.doc)|*.doc";
      SFD.ShowDialog();

    }
  }
}

