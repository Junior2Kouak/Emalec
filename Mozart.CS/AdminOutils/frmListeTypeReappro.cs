using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmListeTypeReappro : Form
  {
    //Public sType As String
    //Dim sChamp As String
    //Dim adoRSB As ADODB.Recordset
    public String msType = "";
    private string sChamp = "";

    DataTable dt = new DataTable();

    public frmListeTypeReappro()
    {
      InitializeComponent();
    }

    private void frmListeTypeReappro_Load(object sender, System.EventArgs e)
    {
      string sSQL = "";
      try
      {
        ModuleMain.Initboutons(this);
        //  titre de la liste
        switch (msType)
        {
          case "CLIM":
            Label1.Text = Resources.lbl_ListArtReapStockVehChaufClim;
            //      utilisation du bon champ dans la table TFOU selon le type de liste
            sChamp = "NFOUREAPCLIMQTE";
            break;
          case "MULTI":
            Label1.Text = Resources.lbl_ListArtReapStockVehMultitech;
            //      utilisation du bon champ dans la table TFOU selon le type de liste
            sChamp = "NFOUREAPQTE";
            break;
          case "FAIBLE":
            Label1.Text = Resources.lbl_ListArtReapStockVehCourantFaible;
            //utilisation du bon champ dans la table TFOU selon le type de liste
            sChamp = "NFOUREAPFAIBLEQTE";
            break;
          case "PLOMBIER":
            Label1.Text = Resources.lbl_ListArtReapStockVehPlombier;
            // utilisation du bon champ dans la table TFOU selon le type de liste
            sChamp = "NFOUREAPPLOMBQTE";
            break;
          case "DIRICKX":
            Label1.Text = Resources.lbl_ConstiListArtReapStockVehExtincIncend;
            // utilisation du bon champ dans la table TFOU selon le type de liste
            sChamp = "NFOUREAPDIRICKXQTE";
            break;
          case "ED":
            Label1.Text = Resources.lbl_ListArtReapStockVehED;
            //      'utilisation du bon champ dans la table TFOU selon le type de liste
            sChamp = "NFOUREAPEDQTE";
            break;
          case "FORT":
            Label1.Text = Resources.lbl_ListArtReapStockVehCourantFort;
            //      utilisation du bon champ dans la table TFOU selon le type de liste
            sChamp = "NFOUREAPFORTQTE";
            break;
          case "COUV":
            Label1.Text = Resources.lbl_ListArtReapStockVehCouverture;
            //       utilisation du bon champ dans la table TFOU selon le type de liste
            sChamp = "NFOUREAPCOUVQTE";
            break;
          case "ARGEDIS":
            Label1.Text = Resources.lbl_ListArtReapStockVehARGEDIS;
            //       utilisation du bon champ dans la table TFOU selon le type de liste
            sChamp = "NFOUREAPARGEDISQTE";
            break;
          case "GUNNEBO":
            Label1.Text = Resources.lbl_ListArtReapStockVehGUNNEBO;
            //      'utilisation du bon champ dans la table TFOU selon le type de liste
            sChamp = "NFOUREAPGUNNEBOQTE";
            break;
          case "MULTIEI":
            Label1.Text = Resources.lbl_ListArtReapStockVehMultitechExtincIncend;
            //      utilisation du bon champ dans la table TFOU selon le type de liste
            sChamp = "NFOUREAPMULTIEIQTE";
            break;
          case "VIS":
            Label1.Text = Resources.lbl_ListArtReapStockVehVisserieFixa;
            //      utilisation du bon champ dans la table TFOU selon le type de liste
            sChamp = "NFOUREAPVISQTE";
            break;
          case "PHOTOVOLT":
            Label1.Text = Resources.lbl_ListArtReapStockVehPhotovoltaique;
            //       utilisation du bon champ dans la table TFOU selon le type de liste
            sChamp = "NFOUREAPPHOTOVOLTQTE";
            break;
          case "CROWN":
            Label1.Text = Resources.lbl_ListArtReapStockVehCROWNHEIGHTS;
            //      utilisation du bon champ dans la table TFOU selon le type de liste
            sChamp = "NFOUREAPCROWNQTE";
            break;
          case "MULTISERV_FOU":
            Label1.Text = Resources.lbl_ListArtReapStockVehMultiservices;
            //      utilisation du bon champ dans la table TFOU selon le type de liste
            sChamp = "NFOUREAPMULTISERVQTE";
            break;
        }
        this.Text = Label1.Text;

        sSQL = "select distinct VFOUSER, VFOUMAT, VFOUMAR, VFOUTYP, VFOUREF, NFOUNBLOT,  NFOUNUM, min(FPUHT) as FPUHT, ";
        sSQL += sChamp + "   from api_v_ListeFournituresReappro WHERE " + sChamp + " >= 0 ";
        sSQL += " GROUP BY VFOUSER, VFOUMAT, VFOUMAR, VFOUTYP, VFOUREF, NFOUNBLOT,  NFOUNUM, " + sChamp + " ORDER BY VFOUMAT";

        apiGridb.LoadData(dt, MozartDatabase.cnxMozart, sSQL);
        apiGridb.GridControl.DataSource = dt;
        InitApiTgrid();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub Form_Load()
    //    
    //Dim sSQL As String
    //
    //On Error GoTo handler:
    //
    //  InitBoutons Me, frmMenu
    //  
    //    ' titre de la liste
    //  Select Case sType
    //    Case "CLIM"
    //      Label1.Caption = "Liste des articles de réappro stock véhicule chauffage climatisation"
    //      ' utilisation du bon champ dans la table TFOU selon le type de liste
    //      sChamp = "NFOUREAPCLIMQTE"
    //    Case "MULTI"
    //      Label1.Caption = "Liste des articles de réappro stock véhicule multitechnique"
    //      ' utilisation du bon champ dans la table TFOU selon le type de liste
    //      sChamp = "NFOUREAPQTE"
    //    Case "FAIBLE"
    //      Label1.Caption = "Liste des articles de réappro stock véhicule courant faible"
    //      ' utilisation du bon champ dans la table TFOU selon le type de liste
    //      sChamp = "NFOUREAPFAIBLEQTE"
    //    Case "PLOMBIER"
    //      Label1.Caption = "Liste des articles de réappro stock véhicule plombier"
    //      ' utilisation du bon champ dans la table TFOU selon le type de liste
    //      sChamp = "NFOUREAPPLOMBQTE"
    //    Case "DIRICKX"
    //      Label1.Caption = "Constitution de la liste des articles de réappro stock véhicule extinction incendie"
    //      ' utilisation du bon champ dans la table TFOU selon le type de liste
    //      sChamp = "NFOUREAPDIRICKXQTE"
    //    Case "ED"
    //      Label1.Caption = "Liste des articles de réappro stock véhicule ED"
    //      ' utilisation du bon champ dans la table TFOU selon le type de liste
    //      sChamp = "NFOUREAPEDQTE"
    //    Case "FORT"
    //      Label1.Caption = "Liste des articles de réappro stock véhicule courant fort"
    //      ' utilisation du bon champ dans la table TFOU selon le type de liste
    //      sChamp = "NFOUREAPFORTQTE"
    //    Case "COUV"
    //      Label1.Caption = "Liste des articles de réappro stock véhicule Couverture"
    //      ' utilisation du bon champ dans la table TFOU selon le type de liste
    //      sChamp = "NFOUREAPCOUVQTE"
    //    Case "ARGEDIS"
    //      Label1.Caption = "Liste des articles de réappro stock véhicule ARGEDIS"
    //      ' utilisation du bon champ dans la table TFOU selon le type de liste
    //      sChamp = "NFOUREAPARGEDISQTE"
    //    Case "GUNNEBO"
    //      Label1.Caption = "Liste des articles de réappro stock véhicule GUNNEBO"
    //      ' utilisation du bon champ dans la table TFOU selon le type de liste
    //      sChamp = "NFOUREAPGUNNEBOQTE"
    //    Case "MULTIEI"
    //      Label1.Caption = "Liste des articles de réappro stock véhicule Multitech/Extinction Incendie"
    //      ' utilisation du bon champ dans la table TFOU selon le type de liste
    //      sChamp = "NFOUREAPMULTIEIQTE"
    //    Case "VIS"
    //      Label1.Caption = "Liste des articles de réappro stock véhicule Visserie/Fixation"
    //      ' utilisation du bon champ dans la table TFOU selon le type de liste
    //      sChamp = "NFOUREAPVISQTE"
    //    Case "PHOTOVOLT"
    //      Label1.Caption = "Liste des articles de réappro stock véhicule Photovoltaique"
    //      ' utilisation du bon champ dans la table TFOU selon le type de liste
    //      sChamp = "NFOUREAPPHOTOVOLTQTE"
    //    Case "CROWN"
    //      Label1.Caption = "Liste des articles de réappro stock véhicule CROWN HEIGHTS"
    //      ' utilisation du bon champ dans la table TFOU selon le type de liste
    //      sChamp = "NFOUREAPCROWNQTE"
    //    Case "MULTISERV_FOU"
    //      Label1.Caption = "Liste des articles de réappro stock véhicule Multiservices"
    //      ' utilisation du bon champ dans la table TFOU selon le type de liste
    //      sChamp = "NFOUREAPMULTISERVQTE"
    //    
    //  End Select
    //  Me.Caption = Label1.Caption
    //
    //  
    //  Set adoRSB = New ADODB.Recordset
    //  sSQL = "select distinct VFOUSER, VFOUMAT, VFOUMAR, VFOUTYP, VFOUREF, NFOUNBLOT,  NFOUNUM, min(FPUHT) as FPUHT, "
    //  sSQL = sSQL & sChamp & "   from api_v_ListeFournituresReappro WHERE " & sChamp & " >= 0 "
    //  sSQL = sSQL & " GROUP BY VFOUSER, VFOUMAT, VFOUMAR, VFOUTYP, VFOUREF, NFOUNBLOT,  NFOUNUM, " & sChamp & " ORDER BY VFOUMAT"
    //  adoRSB.Open sSQL, cnx, adOpenDynamic, adLockOptimistic
    //  InitapiGridB
    //
    //    
    //  Screen.MousePointer = vbDefault
    //  Exit Sub
    //  Resume
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "Form_Load de " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdQuitter_Click()
    //  Unload Me

    //End Sub
    //

    /* OK --------------------------------------------------------------------------*/
    private void InitApiTgrid()
    {
      try
      {
        //  apiGridb.AddColumn "§Série§", "VFOUSER", 1200
        apiGridb.AddColumn(Resources.col_materiel, "VFOUMAT", 6500, "", 0, true);   // <= AddCellTip
        apiGridb.AddColumn(Resources.col_marque, "VFOUMAR", 2500, "", 0, true);   // <= AddCellTip
        apiGridb.AddColumn(Resources.col_Type, "VFOUTYP", 2500, "", 0, true);   // <= AddCellTip
        apiGridb.AddColumn(Resources.col_Ref, "VFOUREF", 2500, "", 0, true);   // <= AddCellTip
        apiGridb.AddColumn(Resources.col_Qte, sChamp, 600, " ", 2);
        apiGridb.AddColumn("founum", "NFOUNUM", 0);

        //  apiGridb.AddCellStyle sChamp, "0", &HCCCCCC, vbWhite

        apiGridb.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub InitapiGridB()
    //  
    //On Error GoTo handler
    //
    //  'apiGridb.AddColumn "§Série§", "VFOUSER", 1200
    //  apiGridb.AddColumn "Matériel", "VFOUMAT", 6500
    //  apiGridb.AddColumn "Marque", "VFOUMAR", 2500
    //  apiGridb.AddColumn "Type", "VFOUTYP", 2500
    //  apiGridb.AddColumn "Référence", "VFOUREF", 2500
    //  apiGridb.AddColumn "QTE", sChamp, 600, , 2
    //  apiGridb.AddColumn "founum", "NFOUNUM", 0

    //  apiGridb.AddCellTip "VFOUMAT", &HFDF0DA
    //  apiGridb.AddCellTip "VFOUMAR", &HFDF0DA
    //  apiGridb.AddCellTip "VFOUTYP", &HFDF0DA
    //  apiGridb.AddCellTip "VFOUREF", &HFDF0DA
    //
    //  apiGridb.AddCellStyle sChamp, "0", &HCCCCCC, vbWhite
    //
    //  apiGridb.Init adoRSB
    //  
    //Exit Sub
    //handler:
    //  ShowError "InitApigridb dans " & Me.Name
    //End Sub

    /* Inutile ------------------------------------------------------------------*/
    //Private Sub Form_Unload(Cancel As Integer)
    //  Screen.MousePointer = vbDefault
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private void apiGridb_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
    {
      if (e.Column.Name == sChamp)
      {
        e.Appearance.ForeColor = System.Drawing.Color.Black;
        e.Appearance.BackColor = System.Drawing.Color.White;
        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
      }
    }
    //Private Sub apiGridb_FetchCellStyle(Cols As TrueOleDBGrid80.Columns, BookMark As Variant, col As Integer, DataField As String, CellText As String, CellStyle As TrueOleDBGrid80.StyleDisp)
    //  If DataField = sChamp Then
    //    CellStyle.ForeColor = vbBlack
    //    CellStyle.BackColor = vbWhite
    //    CellStyle.Font.Bold = True
    //  End If
    //End Sub
  }
}