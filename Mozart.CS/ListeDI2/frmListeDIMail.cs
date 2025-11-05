using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;


namespace MozartCS
{
  public partial class frmListeDIMail : Form
  {
    DataTable dt = new DataTable();

    public frmListeDIMail() { InitializeComponent(); }

    private void frmListeDIMails_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, $"select * from TDIMAIL where DDIMTRAITE is null AND VSOCIETE = '{MozartParams.NomSociete}' order by NDIMNUM desc");
        apiTGrid1.GridControl.DataSource = dt;

        InitApigrid();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    /* --------------------------------------------------------------------------------------- */
    private void cmdValider_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (row == null) return;

      //écran de creation de la DI
      MozartParams.NumDi = 0;

      //test si la di est déjà prise
      if (DiBloquee())
      {
        MessageBox.Show(Resources.msg_Di_Cours_Traitement, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }
      if (DiTraitee())
      {
        MessageBox.Show("Cette DI est traitée!", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }
      ModuleData.ExecuteNonQuery($"update TDIMAIL set BDIMLOCK = 1 where NDIMNUM = {row["NDIMNUM"]}"); //on la bloque

      Cursor.Current = Cursors.WaitCursor;


      new frmAddAction()
      {
        BrowseText = (string)row["VDIMTEXT"],
        miNumDIMail = (int)row["NDIMNUM"],
        mstrStatutDI = "DIMail",
      }.ShowDialog();


      MozartParams.Action = "";

      // test si la di est crée
      if (!DiTraitee())
        ModuleData.ExecuteNonQuery($"update TDIMAIL set BDIMLOCK = 0 where NDIMNUM = {row["NDIMNUM"]}");

      //rafraichissement
      apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
      Cursor.Current = Cursors.WaitCursor;
    }

    /* --------------------------------------------------------------------------------------- */
    private void cmdSupprimer_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (row == null) return;

      if (MessageBox.Show(Resources.msg_confirm_archive_demande, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
      //On la marque comme traitée
      ModuleData.ExecuteNonQuery($"update TDIMAIL set DDIMTRAITE = Getdate(), NQUITRAITE = {MozartParams.UID}  where NDIMNUM = {row["NDIMNUM"]}");

      apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
    }

    /* --------------------------------------------------------------------------------------- */
    private void cmdVisu_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (row == null) return;

      new frmVisuDiMail()
      {
        miNumDIMail = (int)row["NDIMNUM"],
      }.ShowDialog();
    }


    /* --------------------------------------------------------------------------------------- */
    private void cmdArchive_Click(object sender, EventArgs e)
    {
      new frmListeDiMailsArch().ShowDialog(); //écran des DiMails archivées

      Cursor.Current = Cursors.WaitCursor;
      apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
      Cursor.Current = Cursors.Default;
    }


    /* --------------------------------------------------------------------------------------- */
    private void InitApigrid()
    {
      apiTGrid1.AddColumn("Num", "NDIMNUM", 0);
      apiTGrid1.AddColumn(Resources.col_DateArrivee, "DDIMCRE", 1700, "Date");
      apiTGrid1.AddColumn(Resources.col_Emetteur, "VDIMFROM", 2400);
      apiTGrid1.AddColumn(Resources.col_destinataire, "VDIMTO", 2400);
      apiTGrid1.AddColumn(Resources.col_Sujet, "VDIMSUJET", 2700);
      apiTGrid1.AddColumn(Resources.col_Texte, "VDIMTEXT", 3000);
      apiTGrid1.AddColumn(Resources.col_Lock, "BDIMLOCK", 0);
      apiTGrid1.AddColumn(Resources.col_PJ, "VDIMPJ", 0);

      apiTGrid1.InitColumnList();
    }

    /* --------------------------------------------------------------------------------------- */
    private bool DiBloquee()
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (null == row) return true;
      return ModuleData.ExecuteScalarInt($"select BDIMLOCK from TDIMAIL where NDIMNUM = {row["NDIMNUM"]}") == 1;
    }

    /* --------------------------------------------------------------------------------------- */
    private bool DiTraitee()
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (null == row) return false;
      return !(ModuleData.ExecuteScalarString($"SELECT DDIMTRAITE from TDIMAIL where NDIMNUM = {Utils.BlankIfNull(row["NDIMNUM"])}") == "");
    }

    /* --------------------------------------------------------------------------------------- */
    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

		private void cmdDebloquer_Click(object sender, EventArgs e)
		{
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (row == null) return;

      if (MessageBox.Show("Voulez-vous débloquer cette demande ?", Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;

      ModuleData.ExecuteNonQuery($"update TDIMAIL set BDIMLOCK = 0 where NDIMNUM = {row["NDIMNUM"]}");

      apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);

    }
  }
}

