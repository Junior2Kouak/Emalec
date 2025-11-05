using Aspose.Email.Mapi;
using DevExpress.XtraGrid.Views.Grid;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using ReportEmalec.Net;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;
using MZCtrlResources = MozartControls.Properties.Resources;

namespace MozartCS
{
  public partial class frmProspListe : Form
  {
    private Color COLOR_OFFRE_COM_ACTIVE = Color.Cyan;
    private Color COLOR_FIN_DE_CONTRAT = Color.Red;
    private Color COLOR_RDV_PRIS_N8N_ECHU = Color.GreenYellow;

    private BindingList<CProspListe_Dto> mProspects;

    private bool mBModeArchives;
    private Hashtable mBoutonsDeLaForm;
    private string mFiltres;

    public frmProspListe()
    {
      InitializeComponent();

      lblOffreComActive.BackColor = COLOR_OFFRE_COM_ACTIVE;
      lblFinDeContrat.BackColor = COLOR_FIN_DE_CONTRAT;
      lblRDVNonEchu.BackColor = COLOR_RDV_PRIS_N8N_ECHU;
    }

    private void frmProspListeSuivi_Load(object sender, EventArgs e)
    {
      if (DesignMode)
      {
        return;
      }

      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        // Stockage de l'état des boutons pour switch entre actifs et archivés
        mBoutonsDeLaForm = new Hashtable
        {
          { cmdRestaurer, cmdRestaurer.Visible },
          { cmdAjouter, cmdAjouter.Visible },
          { cmdArchive, cmdArchive.Visible },
          { cmdSupprimer, cmdSupprimer.Visible },
          { cmdModifMasse, cmdModifMasse.Visible }
        };

        chkOffreEnCours.BackColor = chkDateRelDepassee.BackColor = ModuleMain.Couleur(MozartParams.NomSociete);

        updateIHM(false);

        gridListeProspects.GridView.OptionsView.AllowCellMerge = true;

        //refreshGrid();
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

    // MàJ de la fenêtre selon qu'on est en mode archive ou actif
    private void updateIHM(bool pIsModeArchives)
    {
      mBModeArchives = pIsModeArchives;

      string lTitle = MZCtrlResources.gest_com_prospect;

      if (mBModeArchives)
      {
        // Archives
        lblTitre.Text = Text = $"{lTitle} {MZCtrlResources.archives}";

        // Stockage des filtres et on vide le filtre
        mFiltres = gridListeProspects.GridView.ActiveFilterString;
        gridListeProspects.GridView.ActiveFilterString = "";

        // Pour les couleurs des lignes
        gridListeProspects.GridView.RowStyle -= new RowStyleEventHandler(rowStyle);
        gridListeProspects.GridView.RowCellStyle -= new RowCellStyleEventHandler(rowCellStyle);

        // Les boutons visibles
        cmdRestaurer.Visible = (bool) mBoutonsDeLaForm[cmdRestaurer];
        // Les boutons des prospects actifs
        cmdAjouter.Visible = false;
        cmdArchive.Visible = false;
        cmdSupprimer.Visible = false;
        cmdModifMasse.Visible = false;
        frmLegend.Visible = false;
      }
      else
      {
        // Actifs
        lblTitre.Text = Text = lTitle;

        gridListeProspects.GridView.ActiveFilterString = mFiltres;

        // Pour les couleurs des lignes
        gridListeProspects.GridView.RowStyle += new RowStyleEventHandler(rowStyle);
        gridListeProspects.GridView.RowCellStyle += new RowCellStyleEventHandler(rowCellStyle);

        // Les boutons visibles
        cmdAjouter.Visible = (bool)mBoutonsDeLaForm[cmdAjouter];
        cmdArchive.Visible = (bool)mBoutonsDeLaForm[cmdArchive];
        cmdSupprimer.Visible = (bool)mBoutonsDeLaForm[cmdSupprimer];
        cmdModifMasse.Visible = (bool)mBoutonsDeLaForm[cmdModifMasse];
        // Les boutons des prospects archivés
        cmdRestaurer.Visible = false;
      }

      // Pas soumis aux droits mais si on est ou pas dans les archives
      flpFilters.Visible = !mBModeArchives;
      cmdLegend.Visible = !mBModeArchives;

      refreshGrid();
    }

    private void refreshGrid()
    {
      Cursor.Current = Cursors.WaitCursor;

      MULTIEntities mULTIEntities = new MULTIEntities();

      string lProcStock = $"EXEC api_sp_ListeProspectWithCli '{MozartParams.NomSociete}', '{(mBModeArchives ? CEntiteConstants.STR_CHAMP_N : CEntiteConstants.STR_CHAMP_O)}'";
      List<CProspListe_Dto> lTmpProspects = mULTIEntities.Database.SqlQuery<CProspListe_Dto>(lProcStock).ToList();

      // Gestion des droits : Prospects que le user connecté doit voir
      List<int> lNumProspect = MozartParams.UserConnecte.getProspectsFiltres(lTmpProspects.Select(x => x.NPROSNUM).Distinct().ToList());

      mProspects = new BindingList<CProspListe_Dto>(lTmpProspects.Where(x => lNumProspect.Contains(x.NPROSNUM)).ToList());

      gridListeProspects.GridControl.DataSource = mProspects;

      Cursor.Current = Cursors.Default;
    }

    private void cmdAjouter_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmProspGestDetails(0).ShowDialog();

      refreshGrid();

      Cursor.Current = Cursors.Default;
    }

    private void cmdDetail_Click(object sender, EventArgs e)
    {
      if (!(gridListeProspects.GridView.GetFocusedRow() is CProspListe_Dto currentRow)) return;

      Cursor.Current = Cursors.WaitCursor;
      new frmProspGestDetails(currentRow.NPROSNUM).ShowDialog();

      refreshGrid();

      Cursor.Current = Cursors.Default;
    }

    private void cmdModifier_Click(object sender, EventArgs e)
    {
      if (!(gridListeProspects.GridView.GetFocusedRow() is CProspListe_Dto currentRow)) return;

      Cursor.Current = Cursors.WaitCursor;
      new frmProspSuiv(currentRow.NPROSNUM).ShowDialog();

      refreshGrid();
      Cursor.Current = Cursors.Default;
    }

    private void cmdEditer_Click(object sender, EventArgs e)
    {
      if (!(gridListeProspects.GridView.GetFocusedRow() is CProspListe_Dto currentRow)) return;

      Cursor.Current = Cursors.WaitCursor;
      new frmMainReport
      {
        bLaunchByProcessStart = false,
        sTypeReport = "FICHEPROSPECT",
        sIdentifiant = currentRow.NPROSNUM.ToString(),
        InfosMail = "0|0|0",
        sNomSociete = MozartParams.NomSociete,
        sLangue = "FR",
        sOption = "PREVIEW",
        strType = "FICHEPROSPECT", // A Voir, c'est pour les infos mails
        numAction = 0
      }.ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void cmdSupprimer_Click(object sender, EventArgs e)
    {
      try
      {
        if (!(gridListeProspects.GridView.GetFocusedRow() is CProspListe_Dto currentRow)) return;

        if (MessageBox.Show(MZCtrlResources.quest_archi_prospect, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
        {
          return;
        }

        MULTIEntities mMULTIEntities = new MULTIEntities();
        TPROSP lProsp = mMULTIEntities.TPROSP.FirstOrDefault(x => x.NPROSNUM == currentRow.NPROSNUM);
        if (lProsp != null)
        {
          lProsp.CPROSACTIF = CEntiteConstants.STR_CHAMP_N;
          lProsp.VPROSQUIMOD = MozartParams.strUID;
          lProsp.DPROSDATMOD = DateTime.Now;

          mMULTIEntities.TPROSP.AddOrUpdate(lProsp);
          mMULTIEntities.SaveChanges();
        }

        refreshGrid();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdArchive_Click(object sender, EventArgs e)
    {
      updateIHM(true);
    }

    private void cmdcarte_Click(object sender, EventArgs e)
    {
      try
      {
        if (!(gridListeProspects.GridView.GetFocusedRow() is CProspListe_Dto currentRow)) return;

        Cursor.Current = Cursors.WaitCursor;
        new frmBrowser
        {
          msStartingAddress = $"https://maps.emalec.com/SiteParAdresse.asp?NOM={currentRow.VPROSNOM}&AD1={currentRow.VPROSAD1}&VILLE={currentRow.VPROSCP} {currentRow.VPROSVIL}&PAYS={currentRow.VPROSPAYS}"
        }.ShowDialog();
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

    private void Check1_Click(object sender, EventArgs e)
    {
      List<string> filterValues = new List<string>();

      if (chkOffreEnCours.Checked)
      {
        filterValues.Add($"BLEU = '{CEntiteConstants.STR_CHAMP_O}'");
      }

      if (chkDateRelDepassee.Checked)
      {
        filterValues.Add($"DATERELDEP = '{CEntiteConstants.STR_CHAMP_O}'");
      }

      if (chkRdvNonEchus.Checked)
      {
        filterValues.Add($"VERT = '{CEntiteConstants.STR_CHAMP_O}'");
      }

      gridListeProspects.GridView.ActiveFilterString = string.Join("AND ", filterValues);
    }

    private void cmdModifMasse_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      new frmProspectModifMasse(mProspects).ShowDialog();

      refreshGrid();

      Cursor.Current = Cursors.Default;
    }

    private void rowStyle(object sender, RowStyleEventArgs e)
    {
      GridView view = sender as GridView;
      CProspListe_Dto currentRow = (CProspListe_Dto)view.GetRow(e.RowHandle);
      if (currentRow == null) return;

      if (currentRow.BLEU == CEntiteConstants.STR_CHAMP_O)
      {
        e.Appearance.BackColor = COLOR_OFFRE_COM_ACTIVE;
        e.HighPriority = true;
      }

      if (currentRow.VERT == CEntiteConstants.STR_CHAMP_O)
      {
        e.Appearance.BackColor = COLOR_RDV_PRIS_N8N_ECHU;
        e.HighPriority = true;
      }
    }

    private void rowCellStyle(object sender, RowCellStyleEventArgs e)
    {
      string[] colonnesExclues = { TCLI.TCLI_NOMCOL_VCLINOM, TSOCIETE.TSOCIETE_NOMCOL_VSOCIETE };

      if (!colonnesExclues.Contains(e.Column.FieldName)) return;

      GridView view = sender as GridView;
      CProspListe_Dto currentRow = (CProspListe_Dto)view.GetRow(e.RowHandle);
      if (currentRow == null) return;

      if (currentRow.ROUGE == CEntiteConstants.STR_CHAMP_O)
      {
        e.Appearance.BackColor = COLOR_FIN_DE_CONTRAT;
      }
    }

    private void cmdLegend_Click(object sender, EventArgs e)
    {
      frmLegend.Visible = !frmLegend.Visible;
    }

    private void cmdRestaurer_Click(object sender, EventArgs e)
    {
      try
      {
        if (!(gridListeProspects.GridView.GetFocusedRow() is CProspListe_Dto currentRow)) return;

        if (MessageBox.Show(Resources.msg_ConfirmDelProspect, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
        {
          return;
        }

        MULTIEntities mMULTIEntities = new MULTIEntities();
        TPROSP lProsp = mMULTIEntities.TPROSP.FirstOrDefault(x => x.NPROSNUM == currentRow.NPROSNUM);
        if (lProsp != null)
        {
          lProsp.CPROSACTIF = CEntiteConstants.STR_CHAMP_O;

          mMULTIEntities.TPROSP.AddOrUpdate(lProsp);
          mMULTIEntities.SaveChanges();
        }

        refreshGrid();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdFermer_Click(object sender, EventArgs e)
    {
      if (mBModeArchives)
      {
        updateIHM(!mBModeArchives);
      } else
      {
        Close();
      }
    }
  }
}
