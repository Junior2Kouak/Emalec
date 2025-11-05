using DevExpress.XtraGrid.Views.Grid;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmListeProduitsDangereux : Form
  {
    DataTable dt = new DataTable();

    public frmListeProduitsDangereux() { InitializeComponent(); }

    private void frmListeProduitsDangereux_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);
        apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, $"exec api_sp_ListeDesFournituresDanger");
        apiTGrid1.GridControl.DataSource = dt;

        InitApiTgrid();
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


    private void cmdValider_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (null == row) return;

      new frmDetailsFourniture
      {
        mstrStatut = "M",
        mbStatutValidation = true, //true si pas de validation necessaire
        miNumFour = (int)Utils.ZeroIfNull(row["NFOUNUM"])
      }.ShowDialog();

      apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
    }

    //'**************************************************************************************************************
    //'Permet de visualier les mouvements de stock de cette fourniture
    //'**************************************************************************************************************
    /* --------------------------------------------------------------------------------------- */
    private void CmdVisuMvtStock_Click(object sender, EventArgs e)
    {
      DataRow row = apiTGrid1.GetFocusedDataRow();
      if (null == row) return;

      int NFOUNUM = (int)Utils.ZeroIfNull(row["NFOUNUM"]);
      int lQTEActuel = 0;
      int lQTECde = 0;

      GetQteStockForMvt(NFOUNUM, ref lQTEActuel, ref lQTECde);

      new frmStockMouvements()
      {
        miFouNum = NFOUNUM,
        miNumStock = 0,
        mstrType = "FOURNITURE",
        miVFOUMAT = Utils.BlankIfNull(row["VFOUMAT"]),
        miNQTEACTUEL = lQTEActuel,
        miNQTECDE = lQTECde
      }.ShowDialog();
    }


    private void cmdSupprimer_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow row = apiTGrid1.GetFocusedDataRow();
        if (null == row) return;

        int numfour = (int)Utils.ZeroIfNull(row["NFOUNUM"]);
        int iSup = Utils.bSuppOK(numfour);

        if (iSup == 1)
        {
          if (MessageBox.Show(Resources.msg_desactiver_articles, Program.AppTitle, MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
          {
            string sSup = Utils.TestFouEnStockExistInStock(numfour);
            if (sSup == "OK")
            {
              Cursor.Current = Cursors.WaitCursor;
              ModuleData.ExecuteNonQuery($"exec api_sp_DeactiverArt {numfour}");
              // ' traitement des cas ou la fourniture est dans la liste de stock client (sans etre cochée comme gérée)
              //' on supprime de TSTOCKARTCLI et de TSTOCKARTCLISIT pour tous les clients
              ModuleData.ExecuteNonQuery($"delete from TSTOCKARTCLISIT where  NFOUNUM={numfour}");
              ModuleData.ExecuteNonQuery($"delete from TSTOCKARTCLI where  NFOUNUM={numfour}");
              apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
            }
            else
            {
              MessageBox.Show($"{Resources.msg_pas_archiver_fourniture} {Utils.BlankIfNull(row["VFOUMAT"])} {Resources.msg_nombre_diff_zero}({sSup})!!", "",
                                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
          }
        }
        else if (iSup == 2)
        {
          apiTGrid1.Requery(dt, MozartDatabase.cnxMozart);
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    /* --------------------------------------------------------------------------------------- */
    private void InitApiTgrid()
    {
      apiTGrid1.AddColumn(Resources.col_série, "VFOUSER", 1300);
      apiTGrid1.AddColumn(Resources.col_materiel, "VFOUMAT", 7000);
      apiTGrid1.AddColumn(Resources.col_marque, "VFOUMAR", 1100);
      apiTGrid1.AddColumn(Resources.col_Type, "VFOUTYP", 1100); //equivaut a 3cm
      apiTGrid1.AddColumn(Resources.col_Ref, "VFOUREF", 1100);
      apiTGrid1.AddColumn("Cond", "VFOUCON", 700);
      apiTGrid1.AddColumn("UA", "NFOUNBLOT", 600, "", 2);
      apiTGrid1.AddColumn("UV", "NFOUUV", 600, "", 2);
      apiTGrid1.AddColumn("12M", "NFOUNBUTIL", 600, "", 2);
      apiTGrid1.AddColumn("Gest Stock", "CCODEG", 600);
      apiTGrid1.AddColumn(Resources.col_stock, "NFOUQTESTOCK", 700, "", 2);
      apiTGrid1.AddColumn("FDS", "VFOUFICFILE", 1000);
      apiTGrid1.AddColumn("Date FDS", "DATEFDS", 1000, "dd/mm/yyyy");
      apiTGrid1.AddColumn("Recyclage", "NFOUTAR", 600, "0.##", 2);
      apiTGrid1.AddColumn("Crea", "VFOUQUICRE", 1000);
      apiTGrid1.AddColumn("Dernière Modif", "VFOUQUIMOD", 1000);
      apiTGrid1.AddColumn("Dernière Util", "DFOULASTUSE", 1000, "dd/mm/yyyy");
      apiTGrid1.AddColumn("ID", "NFOUNUM", 700);

      apiTGrid1.InitColumnList();
    }

    //Style sur la ligne entière
    private void apiTGrid1_RowStyle(object sender, RowStyleEventArgs e)
    {
      GridView View = sender as GridView;
      if (e.RowHandle >= 0)
      {
        if (View.GetDataRow(e.RowHandle)["CCODEG"].ToString().ToUpper() == "O")
        {
          e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
        }
      }
    }

    //'********************************************************************************************************
    //'Permet de récupérer les qte en stock de la fournitures
    //'********************************************************************************************************
    /* --------------------------------------------------------------------------------------- */
    private void GetQteStockForMvt(int nfounum, ref int lQTEActuel, ref int lQTECde)
    {
      lQTEActuel = 0;
      lQTECde = 0;

      try
      {
        Cursor.Current = Cursors.WaitCursor;
        using (SqlDataReader reader = ModuleData.ExecuteReader($"SELECT ISNULL(NFOUQTESTOCK, 0) AS NFOUQTESTOCK, ISNULL(QTEATTENDUE, 0) AS QTEATTENDUE FROM api_v_ListeFournituresStockMagasin WHERE NSTOCKLIEU = 0 AND NFOUNUM =  {nfounum}"))
        {
          if (reader.Read())
          {
            lQTEActuel = (int)Utils.ZeroIfNull(reader["NFOUQTESTOCK"]); //qte actuelle
            lQTECde = (int)Utils.ZeroIfNull(reader["QTEATTENDUE"]); //qte cde
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


    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

  }

}

