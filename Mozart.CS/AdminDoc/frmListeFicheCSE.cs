using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmListeFicheCSE : Form
  {
    DataTable dtqual = new DataTable();
    private string CheminFicCSE;

    public frmListeFicheCSE()
    {
      InitializeComponent();
    }

    private void frmListeQualif_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);

        //  init
        CheminFicCSE = ModuleData.RechercheParam("REP_FICHE_CE", MozartParams.NomSociete);

        LoadGrid();
        InitApiTgrid();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void LoadGrid()
    {
      Cursor.Current = Cursors.WaitCursor;
      apiTGrid1.LoadData(dtqual, MozartDatabase.cnxMozart, "EXEC api_sp_listeFichesCSE");
      apiTGrid1.GridControl.DataSource = dtqual;
      Cursor.Current = Cursors.Default;
    }

    private void cmdAjouter_Click(object sender, EventArgs e)
    {
      ODF.Filter = "Fichiers PDF (*.PDF)|*.PDF";
      ODF.ShowDialog();

      if (ODF.SafeFileName != "")
      {
        // gestion des droits.
        // le user Impersonate n'a pas les droits sur l'ensemble du réseau mais uniquement sur les répertoires de stockage des fichiers listé dans Mozart.
        // donc si l'utilisateur va chercher un fichier sur un répertoire du réseau, la copie en Impersonate plante.
        // Il faut copier en local avec les droits de l'utilisateur, puis dans le répertoire de stockage en Impersonate
        string sTempFile = $@"{Path.GetTempFileName()}";
        File.Copy(ODF.FileName, sTempFile, true);
        string sNewTempFile = $"{sTempFile}.Mozart{Path.GetExtension(ODF.FileName)}";
        File.Move(sTempFile, sNewTempFile);
        string sNomFichier = $"{DateTime.Now.ToString("yyyyddMMHHmmss")}.pdf";

        CImpersonation.CopyFileImpersonated(sNewTempFile, CheminFicCSE + sNomFichier);
        File.Delete(sNewTempFile);

        // enregistrement dans la base
        string sSQL = $"INSERT INTO TFICHECSE (TITRE, VFICHIER, NQUICREE) values ('Nouveau document', '{sNomFichier}', {MozartParams.UID})";
        ModuleData.ExecuteNonQuery(sSQL);

        //  mise a jour 
        apiTGrid1.Requery(dtqual, MozartDatabase.cnxMozart);
      }
    }

    private void cmdModifier_Click(object sender, EventArgs e)
    {
      if (apiTGrid1.GetFocusedDataRow() == null) return;

      try
      {
        Cursor.Current = Cursors.WaitCursor;
        
        DataRow row = apiTGrid1.GetFocusedDataRow();
        if (row["CACTIF"].ToString() == "O")
        {
          if (MessageBox.Show("Voulez-vous archiver ce document ?", Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
          {
            ModuleData.ExecuteNonQuery("UPDATE TFICHECSE SET CACTIF='N' WHERE ID = " + row["ID"].ToString());
            apiTGrid1.Requery(dtqual, MozartDatabase.cnxMozart);
          }
        }
        else
        {
          if (MessageBox.Show("Voulez-vous activer ce document ?", Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
          {
            ModuleData.ExecuteNonQuery("UPDATE TFICHECSE SET CACTIF='O' WHERE ID = " + row["ID"].ToString());
            apiTGrid1.Requery(dtqual, MozartDatabase.cnxMozart);
          }
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

    private void cmdSupp_Click(object sender, EventArgs e)
    {
      if (apiTGrid1.GetFocusedDataRow() == null) return;

      try
      {
        Cursor.Current = Cursors.WaitCursor;
        
        if (MessageBox.Show("Supprimer ce document ?", Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
        {
          DataRow row = apiTGrid1.GetFocusedDataRow();
          if (CImpersonation.FileExistImpersonated(CheminFicCSE + apiTGrid1.GetFocusedDataRow()["VFICHIER"].ToString()))
          {
            CImpersonation.DeleteFileImpersonated(CheminFicCSE + apiTGrid1.GetFocusedDataRow()["VFICHIER"].ToString());
          }
          ModuleData.ExecuteNonQuery("DELETE FROM TFICHECSE WHERE ID = " + row["ID"].ToString());
          apiTGrid1.Requery(dtqual, MozartDatabase.cnxMozart);
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

    private void InitApiTgrid()
    {
      apiTGrid1.AddColumn("ID", "ID", 0);
      apiTGrid1.AddColumn("Titre", "TITRE", 3500);
      apiTGrid1.AddColumn("Date création", "DDATECRE", 2000);
      apiTGrid1.AddColumn("Créateur", "VPERNOM", 2200);
      apiTGrid1.AddColumn("Actif (O/N)", "CACTIF", 1800);
      apiTGrid1.AddColumn("Fichier", "VFICHIER", 00);

      apiTGrid1.DelockColumn("TITRE");

      apiTGrid1.InitColumnList();
    }

    private void cmdVisu_Click(object sender, EventArgs e)
    {
      try
      {
        if (apiTGrid1.GetFocusedDataRow() == null) return;

        if (CImpersonation.FileExistImpersonated(CheminFicCSE + apiTGrid1.GetFocusedDataRow()["VFICHIER"].ToString()))
        {
          new frmBrowser
          {
            msStartingAddress = CImpersonation.OpenFileImpersonated(CheminFicCSE + apiTGrid1.GetFocusedDataRow()["VFICHIER"].ToString())
          }.ShowDialog();
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void apiTGrid1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
    {
      //On met à jour la base de données
      DataRow currentRow = apiTGrid1.GetFocusedDataRow();
      ModuleData.ExecuteNonQuery($"UPDATE TFICHECSE SET TITRE = '{e.Value}' WHERE ID = {currentRow["ID"]}");
    }
  }
}