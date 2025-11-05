using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmWizardProspeClient : Form
  {
    /*
  Dim oUsrCtrlInit As New UCInit
  Dim oUsrCtrlFinish As New UCFinish
        */

    // Si <> 0, On vient de Prospe -> Client
    private int mINumProsp;
    private int miIndexUserCtrl;

    private UCInfoClient oUsrCtrlInfoClient;
    private UCContactClient oUsrCtrlContactClient;
    private UCRSFFactuClient oUsrCtrlRSFFactuClient;
    private UCCompteAnaClient oUsrCtrlCompteAnaClient;
    private UCContratClient oUsrCtrlContratClient;
    private UCTauxContratClient oUsrCtrlTauxContratClient;
    private UCCommercialClient oUsrCtrlCommercialClient;

    private TCLI mTCLIEnreg;

    private COMMUNEntities mCOMMUNEntities;
    private MULTIEntities mMULTIEntities;

    public frmWizardProspeClient(int pINumProsp = 0)
    {
      try
      {
        InitializeComponent();

        mCOMMUNEntities = new COMMUNEntities();
        mMULTIEntities = new MULTIEntities();

        mTCLIEnreg = new TCLI();

        oUsrCtrlInfoClient = new UCInfoClient(mTCLIEnreg, mMULTIEntities, mCOMMUNEntities);
        oUsrCtrlContactClient = new UCContactClient(mTCLIEnreg, mMULTIEntities, mCOMMUNEntities);
        oUsrCtrlRSFFactuClient = new UCRSFFactuClient(mTCLIEnreg, mMULTIEntities, mCOMMUNEntities);
        oUsrCtrlCompteAnaClient = new UCCompteAnaClient(mTCLIEnreg, mMULTIEntities, mCOMMUNEntities);
        oUsrCtrlContratClient = new UCContratClient(mTCLIEnreg, mMULTIEntities, mCOMMUNEntities);
        oUsrCtrlTauxContratClient = new UCTauxContratClient(mTCLIEnreg, mMULTIEntities, mCOMMUNEntities);
        oUsrCtrlCommercialClient = new UCCommercialClient(mTCLIEnreg, mMULTIEntities, mCOMMUNEntities);

        miIndexUserCtrl = 0;

        mINumProsp = pINumProsp;

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void frmWizardProspeClient_Load(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        ModuleMain.Initboutons(this);

        // on charge la liste des fournitures série extincteurs : Où çà ?????????

        PictSociete.Image = MozartParams.GetLogoFromSociete(MozartParams.NomSociete).Image;

        PanelMaster.Visible = false;

        PanelMaster.Controls.AddRange(new Control[] { oUsrCtrlInfoClient, oUsrCtrlContactClient, oUsrCtrlRSFFactuClient,
                                                      oUsrCtrlContratClient, oUsrCtrlTauxContratClient, oUsrCtrlCompteAnaClient, oUsrCtrlCommercialClient });

        // chargement des donness du prospect
        if (mINumProsp > 0)
        {
          LoadDefaultProsp();
        }

        VisibleUserCtrl();

        PanelMaster.Visible = true;
      }
      catch (Exception ex)
      {
        //System.IO.File.AppendAllText(@"c:\temp\erreurs.log", DateTime.Now + " - " + ex.ToString() + Environment.NewLine);
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      {
        Cursor.Current = Cursors.Default;
      }
    }

    private void VisibleUserCtrl()
    {
      foreach (Control lCurrentCtrl in PanelMaster.Controls)
      {
        lCurrentCtrl.Visible = false;
      }

      if ((miIndexUserCtrl != 0) && (miIndexUserCtrl != PanelMaster.Controls.Count))
      {
        UCWizardBase lCurrentCtrl = (UCWizardBase)PanelMaster.Controls[miIndexUserCtrl];

        lCurrentCtrl.Visible = true;
        lCurrentCtrl.SetInitialFcous();
      }
    }

    private void BtnPrevious_Click(object sender, EventArgs e)
    {
      miIndexUserCtrl--;

      BtnPrevious.Visible = (miIndexUserCtrl != 0);

      BtnNext.Visible = true;
      BtnFinish.Visible = false;

      VisibleUserCtrl();
    }

    private void BtnNext_Click(object sender, EventArgs e)
    {
      if (miIndexUserCtrl != 0)
      {
        // Impossible de passer au controle suivant si vérif incorrecte
        UCWizardBase lCurrentControl = (UCWizardBase)PanelMaster.Controls[miIndexUserCtrl];
        if (!lCurrentControl.VerifSaisieChamp())
        {
          return;
        }
      }

      miIndexUserCtrl++;

      BtnPrevious.Visible = true;

      if (miIndexUserCtrl == (PanelMaster.Controls.Count - 1))
      {
        BtnNext.Visible = false;
        BtnFinish.Visible = true;
      }
      else
      {
        BtnNext.Visible = true;
        BtnFinish.Visible = false;
      }

      SetDefaultData();

      VisibleUserCtrl();
    }

    private void BtnFinish_Click(object sender, EventArgs e)
    {
      // Check de la saisie sur le dernier écran du Wizard
      if (miIndexUserCtrl != 0)
      {
        // Impossible de passer au controle suivant si vérif incorrecte
        UCWizardBase lCurrentControl = (UCWizardBase)PanelMaster.Controls[miIndexUserCtrl];
        if (!lCurrentControl.VerifSaisieChamp())
        {
          return;
        }
      }

      TPROSP lProsp = mMULTIEntities.TPROSP.Find(mINumProsp);

      // Ajout des entités à EF
      // TCLI
      mMULTIEntities.TCLI.Add(mTCLIEnreg);
      // TPROSP_CLI
      TPROSP_CLI lProspCli = new TPROSP_CLI
      {
        TCLI = mTCLIEnreg,
        TPROSP = lProsp
      };
      mMULTIEntities.TPROSP_CLI.Add(lProspCli);
      // Contact client
      TCCL lTCCL = oUsrCtrlContactClient.ContactClient;
      mMULTIEntities.TCCL.Add(lTCCL);
      // RSF
      mMULTIEntities.TRSF.Add(oUsrCtrlRSFFactuClient.RSF);
      // TCANs : Comptes analytiques
      mMULTIEntities.TCAN.AddRange(oUsrCtrlCompteAnaClient.TCANs);
      // TCONTRATCLIs : Contrats
      mMULTIEntities.TCONTRATCLI.AddRange(oUsrCtrlContratClient.TCONTRATCLIs);
      // TCLIPRIXTYPCONTs : Prix par contrat par pays
      mMULTIEntities.TCLIPRIXTYPCONT.AddRange(oUsrCtrlTauxContratClient.TCLIPRIXTYPCONTs);
      // TCLIPER : Commercial
      mMULTIEntities.TCLIPER.Add(oUsrCtrlCommercialClient.TCLIPER);
      // TSIT : Si un site doit être créé (1er écran, demande ajout site même adresse)
      TSIT lSite = null;

      if (oUsrCtrlInfoClient.bCreationSite)
      {
        lSite = new TSIT
        {
          VSITNOM = mTCLIEnreg.VCLINOM,
          VSITENSEIGNE = mTCLIEnreg.VCLINOM,
          NSITNUE = "",
          VSITAD1 = mTCLIEnreg.VCLIAD1,
          VSITAD2 = mTCLIEnreg.VCLIAD2,
          VSITCP = mTCLIEnreg.VCLICP,
          VSITVIL = mTCLIEnreg.VCLIVIL,
          VSITPAYS = mTCLIEnreg.VCLIPAYS,
          VSITRES = lTCCL.VCCLNOM,
          VSITTEL = lTCCL.VCCLTEL,
          VSITMAI = lTCCL.VCCLMAIL,
          TCLI = mTCLIEnreg,
          // C'est la 1ière du client sachant que c'est un nouveau client et qu'1 seule RSF peut être crééé
          TRSF = oUsrCtrlRSFFactuClient.RSF
        };
        if (lSite.VSITPAYS == TPAYS.STR_PAYS_FRANCE)
        {
          lSite.NREGCOD = Convert.ToInt32(mTCLIEnreg.VCLICP.Substring(0, 2));
        }
        else
        {
          lSite.NREGCOD = 0;
        }
        mMULTIEntities.TSIT.Add(lSite);

        TCSIT lTCSit = new TCSIT
        {
          VCSITNOM = lTCCL.VCCLNOM,
          VCSITPRE = "",
          VCSITCIV = "",
          NTYPCSITNUM = 1,
          VCSITTEL = lTCCL.VCCLTEL,
          VCSITPOR = "",
          VCSITMAI = lTCCL.VCCLMAIL,
          TSIT = lSite
        };
        mMULTIEntities.TCSIT.Add(lTCSit);
      }

      //var entries = mMULTIEntities.ChangeTracker.Entries()
      //  .Where(x => x.State == EntityState.Added || x.State == EntityState.Modified || x.State == EntityState.Deleted)
      //  .ToList();

      //foreach (var entry in entries)
      //{
      //  Console.WriteLine($"Entity: {entry.Entity.GetType().Name}, State: {entry.State}  {entry.Entity}");
      //}

      try
      {
        mMULTIEntities.SaveChanges();

        // Le trigger dans TSIT insère des lignes dans TCONT, il faut updater les valeurs maintenant...
        if (oUsrCtrlInfoClient.bCreationSite)
        {
          // 1 seul site à la création...
          foreach (TCONT lTmpCont in mMULTIEntities.TCONT.Where(x => x.TSIT.NSITNUM == lSite.NSITNUM))
          {
            lTmpCont.VCONTETAT = "OUI";
          }

          //var entries2 = mMULTIEntities.ChangeTracker.Entries()
          //    .Where(x => x.State == EntityState.Added || x.State == EntityState.Modified || x.State == EntityState.Deleted)
          //    .ToList();

          //foreach (var entry in entries2)
          //{
          //  Console.WriteLine($"Entity: {entry.Entity.GetType().Name}, State: {entry.State}  {entry.Entity}");
          //}
       
          mMULTIEntities.SaveChanges();
        }
      }
      catch (Exception ex)
      {
        //Console.WriteLine("Erreur lors du SaveChanges:");
        //Console.WriteLine(ex.Message);

        //foreach (var entry in mMULTIEntities.ChangeTracker.Entries().Where(x => x.State == EntityState.Added))
        //{
        //  Console.WriteLine($"Type: {entry.Entity.GetType().Name}");

        //    var props = entry.CurrentValues.PropertyNames;
        //    foreach (var prop in props)
        //    {
        //      Console.WriteLine($"    {prop} = {entry.CurrentValues[prop]}");
        //    }
        //}
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }

      try
      {
        // envoi du message d'information création client
        mMULTIEntities.api_sp_SendMailNewClient(mTCLIEnreg.NCLINUM);

        MessageBox.Show($"Le client '{mTCLIEnreg.VCLINOM}' a été créé dans MOZART.", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);

        Close();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void LoadDefaultProsp()
    {
      TPROSP lProsp = mMULTIEntities.TPROSP.Find(mINumProsp);
      if (lProsp != null)
      {
        oUsrCtrlInfoClient.TxtCliNom.Text = lProsp.VPROSNOM;
        oUsrCtrlInfoClient.TxtVCLIAD1.Text = lProsp.VPROSAD1;
        oUsrCtrlInfoClient.TxtVCLIAD2.Text = lProsp.VPROSAD2;
        oUsrCtrlInfoClient.GridCliPays.SelectedText = lProsp.VPROSPAYS;
        oUsrCtrlInfoClient.TxtVCLICP.Text = lProsp.VPROSCP;
        oUsrCtrlInfoClient.TxtVCLICPCEDEX.Text = lProsp.VPROSCEDEX;
        if (lProsp.VPROSPAYS == TPAYS.STR_PAYS_FRANCE)
        {
          oUsrCtrlInfoClient.GridCliVille.Text = lProsp.VPROSVIL;
        }
        else
        {
          oUsrCtrlInfoClient.txtVille.Text = lProsp.VPROSVIL;
        }
      }

      TPROSPCCL lProspCCL = mMULTIEntities.TPROSPCCL.Where(x => (x.NPROSNUM == mINumProsp) && (x.CPROSPCCLACTIF == "O")).FirstOrDefault();
      if (lProspCCL != null)
      {
        oUsrCtrlContactClient.CboCCLCiv.Text = lProspCCL.VPROSPCCLCIV;
        oUsrCtrlContactClient.TxtCCLNom.Text = lProspCCL.VPROSPCCLNOM;
        oUsrCtrlContactClient.TxtCCLPrenom.Text = lProspCCL.VPROSPCCLPRE;
        oUsrCtrlContactClient.TxtCCLTel.Text = lProspCCL.VPROSPCCLTEL;
        oUsrCtrlContactClient.TxtCCLPort.Text = lProspCCL.VPROSPCCLPORT;
        oUsrCtrlContactClient.TxtCCLMail.Text = lProspCCL.VPROSPCCLMAIL;
        oUsrCtrlContactClient.TxtCCLFonction.Text = lProspCCL.VPROSPCCLQUAL;
      }
    }

    private void SetDefaultData()
    {
      switch (miIndexUserCtrl)
      {
        case 3:
          break;

        case 5:
          oUsrCtrlTauxContratClient.TCONTRATCLIs = oUsrCtrlContratClient.TCONTRATCLIs;
          oUsrCtrlTauxContratClient.ListePaysContrat = oUsrCtrlInfoClient.ListePaysContrat;
          break;

        default:
          break;
      }

      /*
      Dim bOK As Boolean = True

      'NEXT
      If p_LASTNEXT = 1 Then

        Select Case iIndexUserCtrl

          Case 3

            If oUsrCtrlRSFFactuClient.GridRSFPays.Text = "" Then oUsrCtrlRSFFactuClient.GridRSFPays.EditValue = oUsrCtrlInfoClient.GridCliPays.EditValue
            If oUsrCtrlRSFFactuClient.TxtRSFNom.Text = "" Then oUsrCtrlRSFFactuClient.TxtRSFNom.Text = oUsrCtrlInfoClient.TxtCliNom.Text
            If oUsrCtrlRSFFactuClient.TxtRSFAD1.Text = "" Then oUsrCtrlRSFFactuClient.TxtRSFAD1.Text = oUsrCtrlInfoClient.TxtVCLIAD1.Text
            If oUsrCtrlRSFFactuClient.TxtRSFAD2.Text = "" Then oUsrCtrlRSFFactuClient.TxtRSFAD2.Text = oUsrCtrlInfoClient.TxtVCLIAD2.Text
            If oUsrCtrlRSFFactuClient.TxtRSFCP.Text = "" Then oUsrCtrlRSFFactuClient.TxtRSFCP.Text = oUsrCtrlInfoClient.TxtVCLICP.Text
            If oUsrCtrlRSFFactuClient._TxtVILLE.Text = "" And oUsrCtrlRSFFactuClient.GridRSFPays.Text <> "FRANCE" Then oUsrCtrlRSFFactuClient._TxtVILLE.Text = oUsrCtrlInfoClient._TxtVILLE.Text

            If oUsrCtrlInfoClient.bChangeTypologie = True Then
              'particulier
              If oUsrCtrlInfoClient.ChkBoxParticulier.Checked = True Then
                oUsrCtrlRSFFactuClient.CboRSFTyp.Enabled = False
                oUsrCtrlRSFFactuClient.cboRSFNBJ.Enabled = False
                oUsrCtrlRSFFactuClient.CboRSFTyp.EditValue = "VIREMENT"
                oUsrCtrlRSFFactuClient.cboRSFNBJ.EditValue = "0"
                oUsrCtrlRSFFactuClient.cboRSFFin.EditValue = "NON"
                'siret grisé
                oUsrCtrlRSFFactuClient.TxtSIRET.Enabled = False
                oUsrCtrlRSFFactuClient.TxtRSFTVAIntra.Enabled = False

              ElseIf oUsrCtrlInfoClient.ChkBoxProfessionel.Checked = True Then  'profesionnel
                oUsrCtrlRSFFactuClient.CboRSFTyp.Enabled = True
                oUsrCtrlRSFFactuClient.cboRSFNBJ.Enabled = True
                oUsrCtrlRSFFactuClient.CboRSFTyp.EditValue = "VIREMENT"
                oUsrCtrlRSFFactuClient.cboRSFNBJ.EditValue = "30"
                oUsrCtrlRSFFactuClient.cboRSFFin.EditValue = "NON"
                'siret actif
                oUsrCtrlRSFFactuClient.TxtSIRET.Enabled = True
                oUsrCtrlRSFFactuClient.TxtRSFTVAIntra.Enabled = True

              End If

              oUsrCtrlInfoClient.bChangeTypologie = False

            End If

          Case 4
          Case 5

            If Not oUsrCtrlContratClient._DtListContrat Is Nothing Then

              Dim dtTauxContrat As DataTable = Nothing

              'on ércupère la table des taux et prix
              If Not oUsrCtrlTauxContratClient Is Nothing AndAlso Not oUsrCtrlTauxContratClient._DtListTauxContrat Is Nothing Then

                dtTauxContrat = oUsrCtrlTauxContratClient._DtListTauxContrat

              End If

              'on charge la table des contrats
              oUsrCtrlTauxContratClient._DtListContratSelected = oUsrCtrlContratClient._DtListContrat.Select("[BCONTRATAFFECTE] = 1").CopyToDataTable
              oUsrCtrlTauxContratClient.DtListPaysContratSelected = oUsrCtrlInfoClient.DTPaysContrat.Select("[BPAYSSELECT] = 1").CopyToDataTable
              'on charge la table des prix par contrat et par pays
              oUsrCtrlTauxContratClient.LoadDataByContratSelect()

              'si  table des prix contrat avant maj existe alors, on mets à jour ses prix
              'De meme pour les mays
              'pour ne pas resaisir le montant ou la taux déjà défini
              If Not dtTauxContrat Is Nothing Then

                Dim LstPays As List(Of String) = (From r In oUsrCtrlInfoClient.DTPaysContrat.AsEnumerable() Select r.Field(Of String)("VPAYSNOM")).ToList()  'oUsrCtrlInfoClient.DTPaysContrat.Select().ToList()

                Dim drSearch As DataRow() = Nothing

                For Each drUpdate As DataRow In oUsrCtrlTauxContratClient._DtListTauxContrat.Rows

                  'on supprime le pays si non sélectionner
                  If (LstPays.Contains(drUpdate.Item("VPAYS")) = False) Then

                    oUsrCtrlTauxContratClient._DtListTauxContrat.Rows.Remove(drUpdate)

                  Else

                    drSearch = dtTauxContrat.Select(String.Format("[NTYPECONTRAT] = {0} AND [VPAYS] = '{1}'", drUpdate.Item("NTYPECONTRAT"), drUpdate.Item("VPAYS")))
                    If drSearch.Count > 0 Then

                      If drUpdate.Item("NCLICONTHOR") <> drSearch(0).Item("NCLICONTHOR") Then drUpdate.Item("NCLICONTHOR") = drSearch(0).Item("NCLICONTHOR")
                      If drUpdate.Item("NCLICONTDEP") <> drSearch(0).Item("NCLICONTDEP") Then drUpdate.Item("NCLICONTDEP") = drSearch(0).Item("NCLICONTDEP")
                      If drUpdate.Item("NCLICONTHORSAM") <> drSearch(0).Item("NCLICONTHORSAM") Then drUpdate.Item("NCLICONTHORSAM") = drSearch(0).Item("NCLICONTHORSAM")
                      If drUpdate.Item("NCLICONTHORNUIDIM") <> drSearch(0).Item("NCLICONTHORNUIDIM") Then drUpdate.Item("NCLICONTHORNUIDIM") = drSearch(0).Item("NCLICONTHORNUIDIM")

                    End If

                  End If

                Next

                oUsrCtrlTauxContratClient.Refreshdata()

              End If

            End If

          Case 6

        End Select

      End If
          */
    }
  }
}
