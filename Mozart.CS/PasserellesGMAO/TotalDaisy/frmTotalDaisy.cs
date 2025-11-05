using MozartLib;
using MozartNet;
using System;
using System.Windows.Forms;

namespace MozartCS
{
  public partial class frmTotalDaisy : Form
  {
    private int mNumAction;
    // mNumGMAO contient le WO pour Total...
    private string mNumGMAO;

    public string strObservation;

    public frmTotalDaisy(int pNumAction, string pNumGMAO)
    {
      InitializeComponent();

      mNumAction = pNumAction;
      mNumGMAO = pNumGMAO;
    }

    private void frmTotalDaisy_Load(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;

      ModuleMain.Initboutons(this);

      strObservation = "";

      if (MozartParams.strUID != "GIRAUD-BY")
      {
        tabPanGetList.Pages.Remove(tabGetList);
      }

      // Combos et valeurs par défaut
      cboCodeCloture.Items.Add("Résolu");
      cboCodeCloture.SelectedIndex = 0;

      cboCauseRacine.Items.Add("Autre");
      cboCauseRacine.SelectedIndex = 0;

      cboTypeInter.Items.Add("Intervention terrain");
      cboTypeInter.SelectedIndex = 0;

      cboTypeAction.Items.Add("Remplacement d'accessoires");
      cboTypeAction.SelectedIndex = 0;

      // Init par défaut des champs
      txtNotes.Text = "Voir attachement";
      txtNoteCloture.Text = txtNotes.Text;
      datePassageGTI.EditValue = DateTime.Now;

      // Liste des CRVP et attachement
      string strRepImage = Utils.RechercheParam("REP_PHOTOS_ACT");
      string strRepAtt = Utils.RechercheParam("REP_ATTGAM");
      string lSql = $"SELECT VFICHIER, CASE WHEN VTYPE = 'ATTACH' OR VTYPE = 'GAMME' OR VTYPE = 'ATTEST' THEN '{strRepAtt}' ELSE '{strRepImage}' END + '\\' + VFICHIER AS VFULLNAME ";
      lSql += $"FROM TIMAC WHERE NACTNUM = {mNumAction} AND NTYPEDOC IN (1, 37) AND VTYPEDEST = 'C'";
      ModuleData.RemplirCombo(cboListeFichier, lSql);
      cboListeFichier.ValueMember = "VFULLNAME";
      cboListeFichier.DisplayMember = "VFICHIER";

      Cursor.Current = Cursors.Default;
    }

    private void cmdDeclarerPassageGTI_Click(object sender, EventArgs e)
    {
      string lNote;

      if (datePassageGTI.EditValue == null)
      {
        MessageBox.Show("Il faut renseigner une date de passage.", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      lNote = txtNotes.Text.Trim();
      if (lNote == "")
      {
        MessageBox.Show("Il faut renseigner une note.", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      try
      {
        Cursor.Current = Cursors.WaitCursor;

        CDaisyWWResponse_update_state_gti lResult = CTotalDaisyWS.declarePassageGTI(mNumGMAO, datePassageGTI.DateTime, lNote);
        string lMsgRetour;
        switch (lResult.error_number)
        {
          case CDaisyWWConstants.msg_success:
            lMsgRetour = "L'opération s'est terminée sans erreur";
            break;

          case CDaisyWWConstants.msg_GTI_date_already_set:
            lMsgRetour = "Le passage GTI a déjà été déclaré";
            break;

          default:
            lMsgRetour = lResult.message;
            break;
        }
        addToTxtResponse($"Déclarer passage GTI : Retour de l'appel : {lMsgRetour} (Code : {lResult.error_number}){Environment.NewLine}");
      }
      catch (Exception pEx)
      {
        addToTxtResponse($"Erreur d'import : {pEx.Message})");
      }
      finally
      {
        Cursor.Current = Cursors.Default;

      }
    }

    private void cmdGetList_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;

      // Récupération et stockage des nouveaux tickets dans la base
      CTotalDaisyWS.getList();
      txtResult.Text += "Récupération des tickets effectuée";

      Cursor.Current = Cursors.Default;
    }

    private void cmdResoudre_Click(object sender, EventArgs e)
    {
      if (cboCodeCloture.SelectedIndex == -1)
      {
        MessageBox.Show("Il faut renseigner un code de clôture.", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      if (cboCauseRacine.SelectedIndex == -1)
      {
        MessageBox.Show("Il faut renseigner une cause racine.", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      if (cboTypeInter.SelectedIndex == -1)
      {
        MessageBox.Show("Il faut renseigner un type d'intervention.", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      if (cboTypeAction.SelectedIndex == -1)
      {
        MessageBox.Show("Il faut renseigner un type d'action.", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      if (dateInterReelle.EditValue == null)
      {
        MessageBox.Show("Il faut renseigner une date d'intervention réelle.", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      if (txtNoteCloture.Text == "")
      {
        MessageBox.Show("Il faut renseigner une note de clôture.", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      try
      {
        Cursor.Current = Cursors.WaitCursor;

        CDaisyWWResponse_update_state lResult = CTotalDaisyWS.close_incident(mNumGMAO, dateInterReelle.DateTime, txtNoteCloture.Text);
        string lMsgRetour;
        switch (lResult.error_number)
        {
          case CDaisyWWConstants.msg_success:
            lMsgRetour = "L'opération s'est terminée sans erreur";
            break;

          default:
            lMsgRetour = lResult.message;
            break;
        }
        addToTxtResponse($"Clôture : Retour de l'appel : {lMsgRetour} (Code : {lResult.error_number}){Environment.NewLine}");

      }
      catch (Exception pEx)
      {
        addToTxtResponse($"Erreur d'import : {pEx.Message.Replace('\'', ' ')})");
      }
      finally
      {
        Cursor.Current = Cursors.Default;
      }
    }

    private void addToTxtResponse(string pTexteToAdd)
    {
      if (txtResponse.Text != "")
      {
        txtResponse.Text += Environment.NewLine;
      }
      txtResponse.Text += $"{DateTime.Now:g} : {pTexteToAdd}";
    }

    private void cmdImporter_Click(object sender, EventArgs e)
    {
      if (cboListeFichier.SelectedIndex == -1)
      {
        MessageBox.Show("Il faut sélectionner un fichier à importer.", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      try
      {
        Cursor.Current = Cursors.WaitCursor;

        CDaisyWWResponse_attachment_incident lResult = CTotalDaisyWS.add_attachement(mNumGMAO, cboListeFichier.SelectedValue.ToString());
        //CDaisyWWResponse_attachment_incident lResult = CTotalDaisyWS.add_attachement("WO08498939", "C:\\temp\\test_total.txt");
        string lMsgRetour;
        switch (lResult.error_number)
        {
          case CDaisyWWConstants.msg_success:
            lMsgRetour = "L'opération s'est terminée sans erreur";
            break;

          default:
            lMsgRetour = lResult.message;
            break;
        }
        addToTxtResponse($"Import de fichiers : Retour de l'appel : {lMsgRetour} (Code : {lResult.error_number})");

      }
      catch (Exception pEx)
      {
        addToTxtResponse($"Erreur d'import : {pEx.Message})");
      }
      finally
      {
        Cursor.Current = Cursors.Default;
      }
    }
  }
}
