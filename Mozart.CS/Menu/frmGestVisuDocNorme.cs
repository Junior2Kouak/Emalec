using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;


namespace MozartCS
{
  public partial class frmGestVisuDocNorme : Form
  {
    private string mstrTypeFiche;

    private DataTable dtFicheTech = new DataTable();

    public frmGestVisuDocNorme()
    {
      InitializeComponent();
    }

    private void frmGestVisuDocNorme_Load(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        mstrTypeFiche = "N";
        string sSQL = "";

        // pour le moment, on ne gère que les fiches Norme en gestion de lecture
        // mais on garde quand même le code pour les autres fiches si besoin
        switch (mstrTypeFiche)
        {
          case "N":
            sSQL = $"select N.NID, VLIBNORME, VTITRENORME, DDATENORME, VFICNORME AS VFIC, VTECHNORME From TFICHENORME N INNER JOIN TFICHEADMVISU A " +
              $" ON N.NID=A.NID where CACTIF = 'O' And CETAT='A' And A.NPERNUM={MozartParams.UID} AND N.VSOCIETE='{MozartParams.NomSociete}' order by VLIBNORME";
            break;
          case "FQ":
            sSQL = "select ID AS NID, TITRE, VFICTECH AS VFIC, DDATEPUB, CACTIF From TFICHETECH where type = 'FP' and CACTIF = 'O' and ID not in (59,60) ORDER BY TITRE";
            break;
          case "PR":
            sSQL = $"select ID AS NID, TITRE, VFICTECH AS VFIC, DDATEPUB, CACTIF From TFICHETECH where type = 'AD' and CACTIF = 'O' ORDER BY TITRE";
            break;
          case "FT":
            sSQL = "select ID AS NID, TITRE, VFICTECH AS VFIC, DDATEPUB, VCLASSEMENT, CACTIF From TFICHETECH where type = 'FT' and CACTIF = 'O' ORDER BY VCLASSEMENT, TITRE";
            break;
          default:
            break;
        }

        if (sSQL != "") apiTGrid_FicheTech.LoadData(dtFicheTech, MozartDatabase.cnxMozart, sSQL);
        apiTGrid_FicheTech.GridControl.DataSource = dtFicheTech;

        InitGrid();
        Label1.Text = Text;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdVisu_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow currentRow = apiTGrid_FicheTech.GetFocusedDataRow();
        if (currentRow == null) return;

        string sBaseRep;

        switch (mstrTypeFiche)
        {
          case "N":
            sBaseRep = Utils.RechercheParam("REP_FICHE_NORME");
            break;

          case "FQ":
          case "PR":
          case "FT":
            sBaseRep = MozartParams.CheminFicheTech;
            break;

          default:
            sBaseRep = "";
            break;
        }

        new frmBrowser
        {
          msStartingAddress = CImpersonation.OpenFileImpersonated(sBaseRep + Utils.BlankIfNull(currentRow["VFIC"]))
        }.ShowDialog();

        // mise a jour des lignes dans la table de gestion des visualisations par les tech et chaff
        ModuleData.CnxExecute($"UPDATE TFICHEADMVISU SET CETAT = 'V' WHERE NID ={currentRow["NID"]} AND NPERNUM={MozartParams.UID}");
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void InitGrid()
    {
      switch (mstrTypeFiche)
      {
        case "N":
          apiTGrid_FicheTech.AddColumn("Normes et réglements", "VTITRENORME", 2500, "", 0, true);
          apiTGrid_FicheTech.AddColumn("Techniques", "VTECHNORME", 2200);
          apiTGrid_FicheTech.AddColumn("Libellé", "VLIBNORME", 5000, "", 0, true);
          apiTGrid_FicheTech.AddColumn("Publication", "DDATENORME", 1400, "", 2);
          break;

        case "FQ":
        case "PR":
          apiTGrid_FicheTech.AddColumn("Fiche sécurité", "TITRE", 10800);
          apiTGrid_FicheTech.AddColumn("Publication", "DDATEPUB", 1500, "", 2);
          break;

        case "FT":
          apiTGrid_FicheTech.AddColumn("Série", "VCLASSEMENT", 2800);
          apiTGrid_FicheTech.AddColumn("Fiche technique", "TITRE", 8000);
          apiTGrid_FicheTech.AddColumn("Publication", "DDATEPUB", 1500, "", 2);
          break;

        default:
          break;
      }

      apiTGrid_FicheTech.InitColumnList();
    }
  }
}

