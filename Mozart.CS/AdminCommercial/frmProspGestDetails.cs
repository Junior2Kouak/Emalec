using DevExpress.Data.ODataLinq.Helpers;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using MozartCS.Properties;
using MozartLib;
using MozartLib.Entites.COMMUN;
using MozartNet;
using MozartUC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using MZCtrlResources = MozartControls.Properties.Resources;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmProspGestDetails : Form
  {
    private int miNumProspect;

    private string Obs = "";

    private bool mBExistClientRattache;

    private MULTIEntities mMULTIEntities;

    private List<TPAYS> mListePays;
    private List<TREF_SECTEUR> mListeSecteurs;
    private BindingList<TREF_PROSPGROUPE> mListeGroupeProspect;
    private List<int> mListePaysProspect;

    private BindingList<CPaysSel> mListePaysInter;

    private List<TPER> mListeCommercial;

    private string mTxtLabelfrmIndentification;

    public class CPaysSel : INotifyPropertyChanged
    {
      private bool _bSelected;
      public int idPays { get; set; }
      public string sPAYSNOM { get; set; }
      public bool bSelected
      {
        get => _bSelected;
        set
        {
          if (_bSelected != value)
          {
            _bSelected = value;
            OnPropertyChanged(nameof(bSelected));
          }
        }
      }

      public event PropertyChangedEventHandler PropertyChanged;
      protected void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public frmProspGestDetails(int piNumProspect)
    {
      InitializeComponent();

      Obs = $"INFORMATIONS ENTREPRISE{Environment.NewLine}{Environment.NewLine}Raison sociale :{Environment.NewLine}Activité:{Environment.NewLine}Groupe d'appartenance :{Environment.NewLine}" +
        $"Chiffres d'affaires (date) :{Environment.NewLine}Evolution chiffre d'affaires (dates) :{Environment.NewLine}" +
        $"Effectifs(dates) :{Environment.NewLine}Pays d'activité :{Environment.NewLine}Typologies de sites(tertiaire, point de vente, logistique, usine…) :{Environment.NewLine}{Environment.NewLine}" +
        $"INFORMATIONS SPECIFIQUES{Environment.NewLine}{Environment.NewLine}Actualités récentes :{Environment.NewLine}Evolution ou projets à venir:{Environment.NewLine}{Environment.NewLine}" +
        $"ORGANISATION MAINTENANCE{Environment.NewLine}{Environment.NewLine}Maintenance externalisée(O/ N) :{Environment.NewLine}Nombre de personnes en charge de la maintenance(chez le client) :{Environment.NewLine}Process de gestion de la maintenance :{Environment.NewLine}" +
        $"GMAO client(O/ N) :{Environment.NewLine}Prestataire(s) actuel(s)(indiquer dates) :{Environment.NewLine}Date de fin de contrat:\r\nAO à venir(O / N) + date :{Environment.NewLine}Durée d'engagement contractuelle :{Environment.NewLine}Activité présente ou passée avec le groupe Samsic :";

      miNumProspect = piNumProspect;

      mBExistClientRattache = false;

      mMULTIEntities = new MULTIEntities();
    }

    private void frmProspGestDetails_Load(object sender, EventArgs e)
    {
      try
      {
        string lTmpStr;

        Cursor.Current = Cursors.WaitCursor;

        COMMUNEntities lCOMMUNEntities = new COMMUNEntities();

        ModuleMain.Initboutons(this);

        mTxtLabelfrmIndentification = frmIndentification.Text;

        txtObs.Text = $"{Obs}";

        // Pays
        mListePays = lCOMMUNEntities.TPAYS.OrderBy(x => x.VPAYSNOM).ToList();
        cboPays.DataSource = mListePays;
        cboPays.ValueMember = "NPAYSNUM";
        cboPays.DisplayMember = "VPAYSNOM";
        // Par défaut
        cboPays.Text = TPAYS.STR_PAYS_FRANCE;

        // Pays d'intervention
        InitApigridPaysInter();

        // Liste des pays d'intervention
        mListePaysProspect = lCOMMUNEntities.TPAYS_PROSPECT.Select(x => x.NPAYSNUM).ToList();
        mListePaysInter = new BindingList<CPaysSel>(mListePays.Where(x => mListePaysProspect.Contains(x.NPAYSNUM)).Select(x => new CPaysSel()
        {
          idPays = x.NPAYSNUM,
          sPAYSNOM = x.VPAYSNOM,
          bSelected = false
        }).ToList());
        apiTGridPaysInter.GridControl.DataSource = mListePaysInter;

        mListeCommercial = mMULTIEntities.TPER.Where(x => (x.CPERTYP != TREF_TYPEPER.STR_TE) && (x.CPERACTIF == CEntiteConstants.STR_CHAMP_O) && (x.VSOCIETE == MozartParams.NomSociete))
                                              .OrderBy(x => x.VPERNOM).ToList();
        mListeCommercial.Insert(0, new TPER()
        {
          NPERNUM = 0,
          VPERNOM = ""
        });
        cboComSuivi.DataSource = mListeCommercial;
        cboComSuivi.ValueMember = "NPERNUM";
        cboComSuivi.DisplayMember = "VPERNOM";

        // Secteurs d'activité
        mListeSecteurs = lCOMMUNEntities.TREF_SECTEUR.OrderBy(x => x.VSOUSACTIVITE).ToList();
        cboSousAct.DataSource = mListeSecteurs;
        cboSousAct.ValueMember = "NSECTEUR";
        cboSousAct.DisplayMember = "VSOUSACTIVITE";

        // Prosp groupe
        mListeGroupeProspect = new BindingList<TREF_PROSPGROUPE>(mMULTIEntities.TREF_PROSPGROUPE.OrderBy(x => x.VREF_PROSPGROUPENOM).ToList());
        mListeGroupeProspect.Insert(0, new TREF_PROSPGROUPE()
        {
          NREF_PROSPGROUPEID = 0,
          VREF_PROSPGROUPENOM = ""
        });
        cboGroupeProsp.DataSource = mListeGroupeProspect;
        cboGroupeProsp.ValueMember = "NREF_PROSPGROUPEID";
        cboGroupeProsp.DisplayMember = "VREF_PROSPGROUPENOM";

        if (cboSousAct.Items.Count > 0)
          cboSousAct.SelectedIndex = 0;

        lTmpStr = $"select NPROSPNUM, VPROSPNOM from TREF_PROSP_URGE INNER JOIN TPAYS ON TPAYS.NPAYSNUM=TREF_PROSP_URGE.NPAYSNUM where VLANGUEABR = '{MozartParams.Langue}' order by NPROSPNUM";
        ModuleData.RemplirCombo(cboUrgence, lTmpStr, true);
        cboUrgence.ValueMember = "NPROSPNUM";
        cboUrgence.DisplayMember = "VPROSPNOM";
        // Par défaut
        cboUrgence.SelectedIndex = 0;

        InitApigridClient();

        InitApigridSuiviCom();

        OuvertureEnModification();

        // Gère l'affichage des clients si rattachés : On cache ou pas la grille de la liste des clients + bouton transformation en client
        frmClientsAttached.Visible = mBExistClientRattache;

        InitApigrid();
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

    private void InitApigridPaysInter()
    {
      apiTGridPaysInter.AddColumn(MZCtrlResources.col_Pays, "sPAYSNOM", 600);

      apiTGridPaysInter.AddColumn(MZCtrlResources.selected, "bSelected", 600);
      apiTGridPaysInter.dgv.Columns["bSelected"].ColumnEdit = new RepositoryItemCheckEdit();
      apiTGridPaysInter.DelockColumn("bSelected");

      apiTGridPaysInter.AddHiddenColumn("idPays");

      apiTGridPaysInter.InitColumnList();
    }

    private void cboSousAct_SelectedIndexChanged(object sender, EventArgs e)
    {
      TREF_SECTEUR lRefSecteur = (TREF_SECTEUR)cboSousAct.SelectedItem;
      if (lRefSecteur != null)
      {
        LabelCodeAPE.Text = lRefSecteur.VCODEAPE;
      }
    }

    private void cmdEnregistrer_Click(object sender, EventArgs e)
    {
      try
      {
        //  test du nom
        if (txtEnseigne.Text == "")
        {
          MessageBox.Show(Resources.msg_must_type_prospect_name, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          txtEnseigne.Focus();
          return;
        }

        //  recherche si le nom du client n'est pas un doublon ( si on modifie )
        if (NomExist(txtEnseigne.Text))
        {
          MessageBox.Show(Resources.msg_must_type_another_name_for_this_prospect, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          txtEnseigne.Focus();
          return;
        }

        if (cboSousAct.Text == "")
        {
          MessageBox.Show(Resources.msg_must_fill_sector_and_sousactivite, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          cboSousAct.Focus();
          return;
        }

        if (cboComSuivi.Text == "")
        {
          MessageBox.Show(MZCtrlResources.must_fill_com_suivi, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          cboComSuivi.Focus();
          return;
        }

        Enregistrer();
        OuvertureEnModification();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdSuiv_Click(object sender, EventArgs e)
    {
      if (miNumProspect == 0) return;

      new frmProspSuiv(miNumProspect).ShowDialog();
    }

    private void cmdRecherche_Click(object sender, EventArgs e)
    {
      new frmRechCodePostal
      {
        ControlCible1 = txtCP,
        ControlCible2 = cboVille
      }.ShowDialog();
    }

    private void OuvertureEnModification()
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        TPROSP lProsp = mMULTIEntities.TPROSP.FirstOrDefault(x => x.NPROSNUM == miNumProspect);
        if (lProsp != null)
        {
          frmIndentification.Text = mTxtLabelfrmIndentification + $" (créé le {lProsp.DPROSDATECRE})";
          txtEnseigne.Text = lProsp.VPROSNOM;

          txtAD1.Text = lProsp.VPROSAD1;
          txtAD2.Text = lProsp.VPROSAD2;

          txtTel.Text = lProsp.VPROSTEL;
          txtMail.Text = lProsp.VPROSMAIL;

          txtObs.Text = lProsp.VPROSRENS;
          if (txtObs.Text == "") txtObs.Text = $"{Obs}";
          if (lProsp.NPROSNBSUC != null)
          {
            txtSuc.Text = lProsp.NPROSNBSUC.ToString();
          }
          cboUrgence.SelectedIndex = lProsp.NPROSURGENCE - 1;

          if (lProsp.NPROSGROUPE != null)
          {
            cboGroupeProsp.SelectedValue = lProsp.NPROSGROUPE;
          }

          //  combo de la ville
          cboVille.Text = lProsp.VPROSVIL;
          if (cboVille.SelectedIndex == -1)
          {
            cboVille.Items.Add(lProsp.VPROSVIL);
            cboVille.Text = lProsp.VPROSVIL;
          }

          //  combo du pays
          string lStrPays = lProsp.VPROSPAYS.ToUpper();
          TPAYS lNewPays = mListePays.FirstOrDefault(x => x.VPAYSNOM.Equals(lStrPays, StringComparison.OrdinalIgnoreCase));
          if (lNewPays == null)
          {
            lNewPays = new TPAYS
            {
              NPAYSNUM = 0,
              VPAYSNOM = lStrPays
            };
            mListePays.Add(lNewPays);
          }
          cboPays.SelectedItem = lNewPays;

          txtCP.Text = lProsp.VPROSCP;
          txtVille.Text = lProsp.VPROSVIL;
          txtCedex.Text = lProsp.VPROSCEDEX;

          string sCodeAPE = "";
          string sSousAct = "";

          if (lProsp.TREF_SECTEUR != null)
          {
            sCodeAPE = lProsp.TREF_SECTEUR.VCODEAPE;
            sSousAct = lProsp.TREF_SECTEUR.VSOUSACTIVITE;
          }
          LabelCodeAPE.Text = sCodeAPE;
          cboSousAct.Text = sSousAct;

          // Commercial de suivi
          if (lProsp.TPER_COMSUIVI != null)
          {
            cboComSuivi.Text = lProsp.TPER_COMSUIVI.VPERNOM;
          }

          // Remplissage de la liste des clients rattachés
          var lListClients = new List<CProspectListeCli_DTO>(mMULTIEntities.Database.SqlQuery<CProspectListeCli_DTO>($"EXEC api_sp_ProspectListeCli {miNumProspect}").ToList());

          apiTGridClients.GridControl.DataSource = lListClients;
          mBExistClientRattache = (lListClients.Count != 0);

          LoadContactProspect();
          changeContactFilterStatus(true);

          //  gestion couleur bouton
          if (DocInterneExist())
          {
            CmdDocInt.BackColor = Color.Yellow;
          }

          var lListeSelectedPaysInter = mMULTIEntities.TPROSP_PAYS.Where(x => x.NPROSNUM == miNumProspect).ToList();
          mListePaysInter = new BindingList<CPaysSel>(mListePays.Where(x => mListePaysProspect.Contains(x.NPAYSNUM)).Select(x => new CPaysSel()
          {
            idPays = x.NPAYSNUM,
            sPAYSNOM = x.VPAYSNOM,
            bSelected = lListeSelectedPaysInter.Exists(y => y.NPAYSNUM == x.NPAYSNUM)
          }).ToList());
          apiTGridPaysInter.GridControl.DataSource = mListePaysInter;

          apiTGridSuiviCom.GridControl.DataSource = mMULTIEntities.TPROSPSUIV.Where(x => x.NPROSNUM == lProsp.NPROSNUM).OrderByDescending(x => x.DSUIVDATE).Take(3).ToList();

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

    private void Enregistrer()
    {
      try
      {
        TPROSP lProsp = mMULTIEntities.TPROSP.Find(miNumProspect);
        if (lProsp == null)
        {
          lProsp = new TPROSP
          {
            DPROSDATECRE = DateTime.Now,
            VPROSQUICRE = MozartParams.strUID,
            CPROSACTIF = CEntiteConstants.STR_CHAMP_O
          };

          // Il faut créer un suivi si c'est un nouveau prospect
          TPROSPSUIV lProspSuiv = new TPROSPSUIV
          {
            TPROSP = lProsp,
            DSUIVDATE = DateTime.Now,
            VSUIVACTION = "Création du prospect",
            NDOMCOMID = 1,
            CSUIVPREM = (mMULTIEntities.TPROSPSUIV.Any(x => x.NPROSNUM == lProsp.NPROSNUM)) ? CEntiteConstants.STR_CHAMP_O : CEntiteConstants.STR_CHAMP_N,
            VSUIVQUI = MozartParams.strUID,
            NSUIVQUI = MozartParams.UID
          };

          mMULTIEntities.TPROSP.Add(lProsp);
          mMULTIEntities.TPROSPSUIV.Add(lProspSuiv);
        }
        else
        {
          lProsp.DPROSDATMOD = DateTime.Now;
          lProsp.VPROSQUIMOD = MozartParams.strUID;
        }

        lProsp.VPROSNOM = txtEnseigne.Text;
        lProsp.VPROSAD1 = txtAD1.Text;
        lProsp.VPROSAD2 = txtAD2.Text;
        lProsp.VPROSCP = txtCP.Text;
        lProsp.VPROSVIL = (cboPays.Text == TPAYS.STR_PAYS_FRANCE) ? cboVille.Text : txtVille.Text;
        lProsp.VPROSPAYS = cboPays.Text;
        lProsp.VPROSTEL = txtTel.Text;
        //cmd.Parameters["@vFax"].Value = "";
        //cmd.Parameters["@vPort"].Value = "";
        lProsp.VPROSMAIL = txtMail.Text;
        lProsp.VPROSCEDEX = txtCedex.Text;
        lProsp.VPROSRENS = txtObs.Text;
        lProsp.NPROSNBSUC = ("" == txtSuc.Text) ? 0 : int.Parse(txtSuc.Text);
        lProsp.NSECTEUR = ((TREF_SECTEUR)cboSousAct.SelectedItem).NSECTEUR;
        lProsp.NIDPROSORICONT = 0;  // (-1 == apicboOriContact.GetItemData()) ? 0 : apicboOriContact.GetItemData();
        lProsp.NPROSCHAFF = MozartParams.UID;
        lProsp.VSOCIETE = MozartParams.NomSociete;
        lProsp.NPROSURGENCE = cboUrgence.SelectedIndex + 1;  // Décalage de 1 car pas de possiblité de ne rien choisir
        lProsp.NPROSGROUPE = ((TREF_PROSPGROUPE)cboGroupeProsp.SelectedItem).NREF_PROSPGROUPEID;
        lProsp.NPROSCOMSUIVINUM = ((TPER)cboComSuivi.SelectedItem).NPERNUM;

        // MàJ pays d'intervention
        updatePaysIntervention();

        // Sauvegarde
        mMULTIEntities.SaveChanges();

        miNumProspect = lProsp.NPROSNUM;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void updatePaysIntervention()
    {
      var paysSelectionnes = mListePaysInter.Where(x => x.bSelected).Select(x => x.idPays).ToList();
      var existants = mMULTIEntities.TPROSP_PAYS.Where(x => x.NPROSNUM == miNumProspect).ToList();
      var existantsIds = existants.Select(x => x.NPAYSNUM).ToList();

      // À ajouter : cochés mais pas encore en DB
      var toAdd = paysSelectionnes.Except(existantsIds).ToList();

      // À supprimer : en DB mais décochés
      var toRemove = existantsIds.Except(paysSelectionnes).ToList();

      // Ajout
      foreach (var id in toAdd)
      {
        mMULTIEntities.TPROSP_PAYS.Add(new TPROSP_PAYS
        {
          NPROSNUM = miNumProspect,
          NPAYSNUM = id
        });
      }

      // Suppression
      var removeEntities = existants.Where(x => toRemove.Contains(x.NPAYSNUM));
      mMULTIEntities.TPROSP_PAYS.RemoveRange(removeEntities);
    }

    private void cboPays_SelectedIndexChanged(object sender, EventArgs e)
    {
      cboVille.Visible = cmdRecherche.Visible = cboPays.Text == TPAYS.STR_PAYS_FRANCE;
      txtVille.Visible = !cboVille.Visible;
    }

    private void cmdMail_Click(object sender, EventArgs e)
    {
      try
      {
        var process = Process.Start(Uri.EscapeUriString($"mailto: {txtMail.Text}"));
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void txtCP_TextChanged(object sender, EventArgs e)
    {
      if (txtCP.Text.Length > 1 && cboPays.Text == TPAYS.STR_PAYS_FRANCE)
        ModuleMain.RechercheCommune(txtCP.Text, cboVille);
    }

    private void txtVille_Leave(object sender, EventArgs e)
    {
      txtVille.Text = txtVille.Text.ToUpper();
    }

    private bool NomExist(string nom)
    {
      //  recherche des informations de l'action
      int Nb = MozartDatabase.ExecuteScalarInt($"select count(*) from TPROSP WHERE VSOCIETE = App_Name() AND NPROSNUM <> {miNumProspect} " +
                                                $"AND upper(VPROSNOM) = '{nom.ToUpper().Replace("'", "''")}'");
      return Nb > 0;
    }

    private void txtSuc_KeyPress(object sender, KeyPressEventArgs e)
    {
      int KeyAscii = e.KeyChar;

      if (KeyAscii == 46) { e.KeyChar = ','; return; }
      if (KeyAscii < 48 || KeyAscii > 57) e.Handled = true;
    }

    private async void ApiTelAuto1_Click(object sender, EventArgs e)
    {
      //ApiTelAuto1.TelDial(txtTel.Text);
      if (txtTel.Text != "")
      {
        string reponse = await CNumerotationAuto.MakeCallByAvaya(MozartParams.UserTelInt, txtTel.Text, Environment.MachineName);
        if (reponse != "OK")
        {
          MessageBox.Show(reponse, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }

    private void InitApigridClient()
    {
      apiTGridClients.AddColumn(MZCtrlResources.col_Client, "VCLINOM", 1000);
      apiTGridClients.AddColumn(MZCtrlResources.societe, "VSOCIETE", 600, "", MozartUCConstants.GRID_COL_ALIGN_RIGHT);
      apiTGridClients.AddColumn(Resources.col_CA, "NCA", 600, "N2", MozartUCConstants.GRID_COL_ALIGN_RIGHT);
      apiTGridClients.AddColumn(MZCtrlResources.date_1iere_DI, "DDINDAT", 600, "dd/mm/yy", MozartUCConstants.GRID_COL_ALIGN_RIGHT);
      apiTGridClients.AddColumn(Resources.col_Chaff, "VNOMCHAFF", 1000);

      apiTGridClients.InitColumnList();
    }

    private void InitApigridSuiviCom()
    {
      apiTGridSuiviCom.AddColumn(MZCtrlResources.d_action, "DSUIVDATE", 900, "dd/mm/yy");
      apiTGridSuiviCom.AddColumn(Resources.col_Auteur, "VSUIVQUI", 1100);
      apiTGridSuiviCom.AddColumn(MZCtrlResources.col_Action, "VSUIVACTION", 10000);

      apiTGridSuiviCom.InitColumnList();
    }

    private void InitApigrid()
    {
      apiTGridContProsp.AddColumn(Resources.col_Civ, "VPROSPCCLCIV", 600);
      apiTGridContProsp.AddColumn(MZCtrlResources.nom, "VPROSPCCLNOM", 1100);
      apiTGridContProsp.AddColumn(Resources.col_Prenom, "VPROSPCCLPRE", 1100);
      apiTGridContProsp.AddColumn(Resources.col_Fonction, "VPROSPCCLQUAL", 1100);
      apiTGridContProsp.AddColumn(Resources.col_Tel, "VPROSPCCLTEL", 1800);
      apiTGridContProsp.AddColumn(Resources.col_Port, "VPROSPCCLPORT", 1800);
      apiTGridContProsp.AddColumn(MZCtrlResources.createur, "VQUICREE", 2000);
      apiTGridContProsp.AddColumn(MZCtrlResources.date_creation, "DDATCRE", 2000);
      apiTGridContProsp.AddColumn(MZCtrlResources.modificateur, "VQUIMODIF", 2000);
      apiTGridContProsp.AddColumn(MZCtrlResources.date_modif, "DDATMODIF", 2000);
      apiTGridContProsp.AddColumn(Resources.col_Adresse_mail, "VPROSPCCLMAIL", 2000);

      apiTGridContProsp.AddHiddenColumn("NIDPROSPCCLNUM");
      apiTGridContProsp.AddHiddenColumn(TPROSPCCL.TPROSPCCL_STR_CPROSPCCLACTIF);

      apiTGridContProsp.InitColumnList();
    }

    private void LoadContactProspect()
    {
      MULTIEntities lMULTIEntities = new MULTIEntities();

      List<TPROSPCCL> tPROSPCCLs = lMULTIEntities.TPROSPCCL.Where(x => x.NPROSNUM == miNumProspect).ToList();

      List<CProspContactListe_DTO> ltmp = tPROSPCCLs.Select(x => new CProspContactListe_DTO(x)).ToList();

      apiTGridContProsp.GridControl.DataSource = ltmp;
    }

    private void CmdDetailContact_Click(object sender, EventArgs e)
    {
      if (miNumProspect == 0) return;

      if (!(apiTGridContProsp.dgv.GetFocusedRow() is CProspContactListe_DTO currentRow)) return;

      new frmProspContactDetail(currentRow.NIDPROSPCCLNUM, miNumProspect).ShowDialog();

      LoadContactProspect();
    }

    private void CmdAddContact_Click(object sender, EventArgs e)
    {
      if (miNumProspect == 0) return;

      new frmProspContactDetail(0, miNumProspect).ShowDialog();

      LoadContactProspect();
    }

    private void CmdDelContact_Click(object sender, EventArgs e)
    {
      if (miNumProspect == 0) return;
      if (!(apiTGridContProsp.dgv.GetFocusedRow() is CProspContactListe_DTO currentRow)) return;

      if (MessageBox.Show(MZCtrlResources.quest_archiver_contact, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
      {
        MULTIEntities lMULTIEntities = new MULTIEntities();
        TPROSPCCL lPROSPCCL = lMULTIEntities.TPROSPCCL.FirstOrDefault(x => x.NIDPROSPCCLNUM == currentRow.NIDPROSPCCLNUM);
        if (lPROSPCCL != null)
        {
          lPROSPCCL.CPROSPCCLACTIF = CEntiteConstants.STR_CHAMP_N;

          lMULTIEntities.TPROSPCCL.AddOrUpdate(lPROSPCCL);
          lMULTIEntities.SaveChanges();
        }

        LoadContactProspect();
      }
    }

    private void CmdDocInt_Click(object sender, EventArgs e)
    {
      if (miNumProspect == 0) return;

      new frmProspectGestionDocInterne(miNumProspect).ShowDialog();
    }

    private bool DocInterneExist()
    {
      int nb = MozartDatabase.ExecuteScalarInt($"select count(NPROSDOCID) from TPROSPDOC WHERE NPROSNUM = {miNumProspect}");
      return nb > 0;
    }

    private void cmdNewClient_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmWizardProspeClient(miNumProspect).ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void changeContactFilterStatus(bool pContactActif)
    {
      if (pContactActif)
      {
        chkContactsInactifs.Text = MZCtrlResources.afficher_contacts_archives; // "Afficher les contacts archivés";
        apiTGridContProsp.dgv.ActiveFilterString = $"[{TPROSPCCL.TPROSPCCL_STR_CPROSPCCLACTIF}] = '{CEntiteConstants.STR_CHAMP_O}'";
      }
      else
      {
        chkContactsInactifs.Text = MZCtrlResources.afficher_contacts; // "Afficher les contacts";
        apiTGridContProsp.dgv.ActiveFilterString = $"[{TPROSPCCL.TPROSPCCL_STR_CPROSPCCLACTIF}] = '{CEntiteConstants.STR_CHAMP_N}'";
      }

      CmdDelContact.Enabled = pContactActif;
    }

    private void chkContactsInactifs_CheckedChanged(object sender, EventArgs e)
    {
      changeContactFilterStatus(!chkContactsInactifs.Checked);
    }

    private void apiTGridContProsp_RowStyle(object sender, RowStyleEventArgs e)
    {
      var view = sender as GridView;
      if (e.RowHandle < 0)
      {
        return;
      }

      string valeur = view.GetRowCellValue(e.RowHandle, TPROSPCCL.TPROSPCCL_STR_CPROSPCCLACTIF) as string;
      if (valeur == CEntiteConstants.STR_CHAMP_N)
      {
        e.HighPriority = true;
        e.Appearance.BackColor = Color.LightGray; // couleur de fond
        e.Appearance.ForeColor = Color.Red;     // couleur du texte
      }
    }
  }
}
