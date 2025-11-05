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
  public partial class frmSelectionSiteFour : Form
  {
    public int miFournisseur;

    // pour la form appelante
    public int miNumSiteFournisseur = 0;
    public string msNomSiteFournisseur = "";

    public frmSelectionSiteFour()
    {
      InitializeComponent();
    }

    private void frmSelectionSiteFour_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        ModuleMain.Initboutons(this);

        InitApigrid();

        DataTable dt = new DataTable();
        ApiGrid.LoadData(dt, MozartDatabase.cnxMozart, $"SELECT VSTFNOM, CSTFTYP, VSTFVIC, VSTFAD1, VSTFAD2, VSTFCP, VSTFVIL, VSTFTEL, VSTFAC1, NSTFMOE, NSTFDEP, VSTFOBS, NSTFNUM  FROM api_v_ListeSTF WHERE CSTFACTIF = 'O' AND NSTFGRPNUM ={miFournisseur} ORDER BY VSTFNOM");
        ApiGrid.GridControl.DataSource = dt;
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

    //  Option Explicit
    //Public frmAppelante As Form
    //Dim adoRS As ADODB.Recordset
    //Attribute adoRS.VB_VarHelpID = -1
    //
    //Public miFournisseur As Long
    //
    //Private Sub Form_Load()
    //
    //On Error GoTo handler
    //
    //  InitBoutons Me, frmMenu
    //  
    //  Set adoRS = New ADODB.Recordset
    //  adoRS.Open "SELECT VSTFNOM, CSTFTYP, VSTFVIC, VSTFAD1, VSTFAD2, VSTFCP, VSTFVIL, VSTFTEL, VSTFAC1, NSTFMOE, NSTFDEP, VSTFOBS, NSTFNUM  FROM api_v_ListeSTF WHERE CSTFACTIF = 'O' AND NSTFGRPNUM = " & miFournisseur & " ORDER BY VSTFNOM", cnx, adOpenStatic, adLockOptimistic
    //
    //  frmAppelante.miNumSiteFournisseur = 0
    //  frmAppelante.msNomSiteFournisseur = 0
    //
    //  InitApigrid
    //  
    //Exit Sub
    //handler:
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub
    //

    private void cmdSelectionner_Click(object sender, EventArgs e)
    {
      DataRow row = ApiGrid.GetFocusedDataRow();
      if (null == row)
        return;
      //' passage de l'id du soustraitant sélectionné
      miNumSiteFournisseur = (int)Utils.ZeroIfNull(row["NSTFNUM"]);
      msNomSiteFournisseur = Utils.BlankIfNull(row["VSTFNOM"]);

      Close();
    }
    //Private Sub cmdSelectionner_Click()
    //On Error GoTo handler
    //  
    //  If adoRS.EOF Then Exit Sub
    //  
    //  ' passage de l'id du soustraitant sélectionné
    //  frmAppelante.miNumSiteFournisseur = adoRS("NSTFNUM").Value
    //  frmAppelante.msNomSiteFournisseur = adoRS("VSTFNOM").Value
    //  Unload Me
    //  
    //Exit Sub
    //handler:
    //  ShowError "cmdSelectionner_Click dans " & Me.Name
    //End Sub
    //

    private void cmdImplantation_Click_1(object sender, EventArgs e)
    {
      new frmBrowser()
      {
        msStartingAddress = $"https://maps.emalec.com/SitesFournisseur.asp?BASE=MULTI&APP={MozartParams.NomSociete}&NUM={miFournisseur}"
      }.ShowDialog();
    }
    //Private Sub cmdImplantation_Click()
    //  
    //  frmBrowser.StartingAddress = "http://maps.emalec.com/SitesFournisseur.asp?BASE=MULTI&APP=" & gstrNomSociete & "&NUM=" & miFournisseur
    //  frmBrowser.Show vbModal
    //  
    //End Sub
    //

    private void cmdFermer_Click(object sender, EventArgs e)
    {
      miNumSiteFournisseur = 0;
      msNomSiteFournisseur = "";

      Close();
    }
    //Private Sub cmdFermer_Click()
    //  
    //  frmAppelante.miNumSiteFournisseur = 0
    //  frmAppelante.msNomSiteFournisseur = ""
    //  
    //  Unload Me
    //End Sub
    //

    private void InitApigrid()
    {
      //VSTFNOM, CSTFTYP, VSTFVIC, VSTFAD1, VSTFAD2, VSTFCP, VSTFVIL, VSTFTEL, VSTFAC1, NSTFMOE, NSTFDEP, VSTFOBS, NSTFNUM 
      ApiGrid.AddColumn(Resources.col_Nom, "VSTFNOM", 2000);
      ApiGrid.AddColumn(Resources.col_Type, "CSTFTYP", 0);
      ApiGrid.AddColumn(Resources.col_VilleCible, "VSTFVIC", 1800);
      ApiGrid.AddColumn(Resources.col_Adresse1, "VSTFAD1", 2000);
      ApiGrid.AddColumn(Resources.col_Adresse2, "VSTFAD2", 700);
      ApiGrid.AddColumn(Resources.col_CP, "VSTFCP", 700);
      ApiGrid.AddColumn(Resources.col_Ville, "VSTFVIL", 1700);
      ApiGrid.AddColumn(Resources.col_Tel_astreinte, "VSTFTEL", 1000);
      ApiGrid.AddColumn(Resources.col_Activite, "VSTFAC1", 0);
      ApiGrid.AddColumn(Resources.col_euro_heure, "NSTFMOE", 0);
      ApiGrid.AddColumn(Resources.col_euro_depl, "NSTFDEP", 0);
      ApiGrid.AddColumn(Resources.col_Observations, "VSTFOBS", 1000);
      ApiGrid.AddColumn("NumSTF", "NSTFNUM", 0);

      ApiGrid.DesactiveListe();

      ApiGrid.InitColumnList();
    }
    //Public Sub InitApigrid()
    //  
    //On Error GoTo handler
    //  ApiGrid.AddColumn "§Nom§", 2000
    //  ApiGrid.AddColumn "§Type §", 0
    //  ApiGrid.AddColumn "§Ville cible§", 1800
    //  ApiGrid.AddColumn "§Adresse 1§", 2000
    //  ApiGrid.AddColumn "§Adresse 2§", 700
    //  ApiGrid.AddColumn "§CP §", 700
    //  ApiGrid.AddColumn "§Ville§", 1700
    //  ApiGrid.AddColumn "§Tel astreinte§", 1000
    //  ApiGrid.AddColumn "§Activité§", 0
    //  ApiGrid.AddColumn "§€ Heure§", 0
    //  ApiGrid.AddColumn "§€ Depl§", 0
    //  ApiGrid.AddColumn "§Observations§", 1000
    //  ApiGrid.AddColumn "NumSTF", 0
    //  
    //  ApiGrid.Init adoRS
    //  ApiGrid.DesactiveListe
    //
    //Exit Sub
    //handler:
    //  ShowError "InitApigrid dans " & Me.Name
    //End Sub
    //

    private void ApiGrid_DoubleClickE(object sender, EventArgs e)
    {
      cmdSelectionner_Click(null, null);
    }
    //Private Sub apigrid_DblClick()
    //  Call cmdSelectionner_Click
    //End Sub
    //
    //Private Sub Form_Unload(Cancel As Integer)
    //  Screen.MousePointer = vbDefault
    //End Sub
    //
  }
}

