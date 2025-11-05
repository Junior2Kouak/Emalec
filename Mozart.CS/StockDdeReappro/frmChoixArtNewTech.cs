using MozartCS.Properties;
using MozartNet;
using MozartUC;
using System;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmChoixArtNewTech : Form
  {
    public string mstrType = "";
    public string mstrTitre = "";
    public DataTable mdtArticles;

    private DataTable dtArtLocal = new DataTable();
    string sChampQte = "";


    public frmChoixArtNewTech() { InitializeComponent(); }

    private void frmChoixArtNewTech_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        Text = Label1.Text += $" {mstrTitre.Replace("\r\n", " ")}";

        OuvertureEnModification();
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

    private void cmdChoix_Click(object sender, EventArgs e)
    {
      if (dtArtLocal.Rows.Count > 0)
        ValiderSaisie();
      Dispose();
    }

    private void OuvertureEnModification()
    {
      // recherche des infos de cette COMMANDE
      string sSql = "";

      if (mstrType == "MULTI")
      {
        sSql = "select * from api_v_ListeArtReappro WHERE  NFOUREAPNEWQTE > 0 ORDER BY VFOUSER, VFOUMAT";
        sChampQte = "NFOUREAPNEWQTE";
      }
      else if (mstrType == "DIRICKX")
      {
        sSql = "select * from api_v_ListeArtReappro WHERE NFOUREAPNEWDIRICKXQTE > 0 ORDER BY VFOUSER, VFOUMAT";
        sChampQte = "NFOUREAPNEWDIRICKXQTE";
      }
      else if (mstrType == "FAIBLE")
      {
        sSql = "select * from api_v_ListeArtReappro WHERE NFOUREAPNEWFAIBLEQTE > 0 ORDER BY VFOUSER, VFOUMAT";
        sChampQte = "NFOUREAPNEWFAIBLEQTE";
      }
      else if (mstrType == "PLOMB")
      {
        sSql = "select * from api_v_ListeArtReappro WHERE NFOUREAPNEWPLOMBQTE > 0 ORDER BY VFOUSER, VFOUMAT";
        sChampQte = "NFOUREAPNEWPLOMBQTE";
      }
      else if (mstrType == "FORT")
      {
        sSql = "select * from api_v_ListeArtReappro WHERE NFOUREAPNEWFORTQTE > 0 ORDER BY VFOUSER, VFOUMAT";
        sChampQte = "NFOUREAPNEWFORTQTE";
      }
      else if (mstrType == "MULTIEI")
      {
        sSql = "select * from api_v_ListeArtReappro WHERE NFOUREAPNEWMULTIEIQTE > 0 ORDER BY VFOUSER, VFOUMAT";
        sChampQte = "NFOUREAPNEWMULTIEIQTE";
      }
      else if (mstrType == "EPI")
      {
        sSql = "select * from api_v_ListeArtReappro WHERE NFOUREAPNEWEPIQTE > 0 ORDER BY VFOUSER, VFOUMAT";
        sChampQte = "NFOUREAPNEWEPIQTE";
      }
      else if (mstrType == "CHAUFF")
      {
        sSql = "select * from api_v_ListeArtReappro WHERE NFOUREAPNEWCHAUFF > 0 ORDER BY VFOUSER, VFOUMAT";
        sChampQte = "NFOUREAPNEWCHAUFF";
      }
      else if (mstrType == "MULTISERV_FOU")
      {
        sSql = "select * from api_v_ListeArtReappro WHERE NFOUREAPMULTISERVQTE > 0 ORDER BY VFOUSER, VFOUMAT";
        sChampQte = "NFOUREAPMULTISERVQTE";
      }
      else if (mstrType == "POSTE")
      {
        sSql = "select * from api_v_ListeArtReappro WHERE NFOUREAPNEWCOUVQTE > 0 ORDER BY VFOUSER, VFOUMAT";
        sChampQte = "NFOUREAPNEWCOUVQTE";
      }
      else
      {
        sSql = "select * from api_v_ListeArtReappro WHERE NFOUREAPNEWCLIMQTE > 0 ORDER BY VFOUSER, VFOUMAT";
        sChampQte = "NFOUREAPNEWCLIMQTE";
      }

      ModuleData.LoadData(dtArtLocal, sSql);
      apiTGrid.GridControl.DataSource = dtArtLocal;

      //InitRecordsetArticle

      InitApigrid();

      dtArtLocal.Columns[sChampQte].ColumnName = "NQTE";
      dtArtLocal.Columns["NQTE"].ReadOnly = false;
    }

    public void InitApigrid()
    {
      try
      {
        apiTGrid.AddColumn(Resources.col_Serie, "VFOUSER", 0);
        apiTGrid.AddColumn(Resources.col_materiel, "VFOUMAT", 2300);
        apiTGrid.AddColumn(Resources.col_marque, "VFOUMAR", 1500);
        apiTGrid.AddColumn(Resources.col_Type, "VFOUTYP", 1500);
        apiTGrid.AddColumn(Resources.col_reference, "VFOUREF", 1200);
        apiTGrid.AddColumn(Resources.col_qte2, "NQTE", 800, "", 2);
        apiTGrid.AddColumn("NFOUNUM", "NFOUNUM", 0);

        apiTGrid.InitColumnList();

        apiTGrid.DelockColumn("NQTE");
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void ValiderSaisie()
    {
      foreach (DataRow rowLocal in dtArtLocal.Rows)
      {
        if (rowLocal["NQTE"] != DBNull.Value && Convert.ToInt32(rowLocal["NQTE"]) > 0)
        {
          // ajout de l'enregistrement si pas deja existant
          if (RechercheDoublon(Convert.ToInt32(rowLocal["NFOUNUM"])))
            //  on supprime l'article et on recrée la ligne
            mdtArticles.Rows.Remove(mdtArticles.Select("NumArticle = " + rowLocal["NFOUNUM"])[0]);

          // Ajout de l'enregistrement
          DataRow newArt = mdtArticles.NewRow();

          newArt["Serie"] = rowLocal["VFOUSER"];
          newArt["Article"] = rowLocal["VFOUMAT"];
          newArt["Marque"] = Utils.BlankIfNull(rowLocal["VFOUMAR"]);
          newArt["Type"] = Utils.BlankIfNull(rowLocal["VFOUTYP"]);
          newArt["Reference"] = Utils.BlankIfNull(rowLocal["VFOUREF"]);
          newArt["Quantite"] = rowLocal["NQTE"];
          newArt["Prix U"] = rowLocal["FPUHT"];
          newArt["Prix T"] = 0;
          newArt["NumArticle"] = rowLocal["NFOUNUM"];

          mdtArticles.Rows.Add(newArt);
        }
      }
    }

    private bool RechercheDoublon(int numFou)
    {
      // recherche si l'article est present dans la liste
      return mdtArticles.Select($"NumArticle = {numFou}").Length != 0;
    }

    private void apiTGrid_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
    {
      if (e.RowHandle >= 0 && e.Column.Name == "NQTE")
      {
        e.Appearance.BackColor = Color.LightGray;
        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
      }
    }

    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
  }
}