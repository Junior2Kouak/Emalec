using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;


namespace MozartCS
{
  public partial class frmGestFournitures : Form
  {
    public int mIdFournisseur;

    private DataTable dt = new DataTable();

    public frmGestFournitures()
    {
      InitializeComponent();
    }

    private void frmGestFournitures_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        ModuleMain.Initboutons(this);

        SqlDataReader reader = ModuleData.ExecuteReader($"select  VSTFGRPNOM, VSTFGRPAD1, VSTFGRPAD2, VSTFGRPCP, VSTFGRPVIL " +
                                                        $" FROM  TSTFGRP WHERE NSTFGRPNUM = {mIdFournisseur}");
        reader.Read();

        Label10.Text = Utils.BlankIfNull(reader["VSTFGRPNOM"]);
        Label11.Text = Utils.BlankIfNull(reader["VSTFGRPAD1"]);
        Label12.Text = Utils.BlankIfNull(reader["VSTFGRPAD2"]);
        Label13.Text = Utils.BlankIfNull(reader["VSTFGRPCP"]);
        Label14.Text = Utils.BlankIfNull(reader["VSTFGRPVIL"]);

        InitApigrid();

        ApiGrid.LoadData(dt, MozartDatabase.cnxMozart, $"select * from api_v_ListeFournitures WHERE NSTFGRPNUM = {mIdFournisseur} AND CFOUACTIF = 'O' Order by VFOUSER, VFOUMAT, FPUHT");
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

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    //  Option Explicit
    //
    //Dim adoRS As Recordset
    //Public mIdFournisseur As Integer
    //
    //
    //Private Sub Form_Load()
    //  
    //Dim sSQL As String
    //
    //  On Error GoTo handler
    //  
    //  ' initialisation des boutons
    //  InitBoutons Me, frmMenu
    //
    //  
    //  Set adoRS = New Recordset
    //  sSQL = "select  VSTFGRPNOM, VSTFGRPAD1, VSTFGRPAD2, VSTFGRPCP, VSTFGRPVIL "
    //  sSQL = sSQL & " FROM  TSTFGRP WHERE NSTFGRPNUM = " & mIdFournisseur
    //  
    //  adoRS.Open sSQL, cnx, adOpenStatic, adLockOptimistic
    //  
    //  Label1(0).Caption = BlankIfNull(adoRS("VSTFGRPNOM"))
    //  Label1(1).Caption = BlankIfNull(adoRS("VSTFGRPAD1"))
    //  Label1(2).Caption = BlankIfNull(adoRS("VSTFGRPAD2"))
    //  Label1(3).Caption = BlankIfNull(adoRS("VSTFGRPCP"))
    //  Label1(4).Caption = BlankIfNull(adoRS("VSTFGRPVIL"))
    //  
    //  adoRS.Close
    //  
    //  ' liste des article du fournisseur
    //  Set adoRS = New Recordset
    //  adoRS.Open "select * from api_v_ListeFournitures WHERE NSTFGRPNUM = " & mIdFournisseur & " AND CFOUACTIF = 'O' Order by VFOUSER, VFOUMAT, FPUHT ", cnx, adOpenStatic, adLockOptimistic
    //  
    //  InitApigrid
    //  
    //  Screen.MousePointer = vbDefault
    //  
    //Exit Sub
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub
    //

    private void cmdNouvelle_Click(object sender, EventArgs e)
    {
      new frmDetailsFourniture()
      {
        mstrStatut = "C",
        miNumFour = 0
      }.ShowDialog();

      ApiGrid.Requery(dt, MozartDatabase.cnxMozart);
    }
    //Private Sub cmdNouvelle_Click()
    //
    //  Screen.MousePointer = vbHourglass
    //  frmDetailsFourniture.mstrStatut = "C"
    //  frmDetailsFourniture.miNumFour = 0
    //  frmDetailsFourniture.Show vbModal
    //  
    //  adoRS.Requery
    //  ApiGrid.MajLabel
    //  'InitApigrid
    //
    //End Sub
    //

    private void Command1_Click(object sender, EventArgs e)
    {
      DataRow row = ApiGrid.GetFocusedDataRow();
      if (null == row)
        return;

      new frmDetailsFourniture()
      {
        mstrStatut = "M",
        miNumFour = (int)Utils.ZeroIfNull(row["NFOUNUM"])
      }.ShowDialog();

      ApiGrid.Requery(dt, MozartDatabase.cnxMozart);
    }
    //Private Sub Command1_Click()
    //  
    // If adoRS.EOF Then Exit Sub
    //  Screen.MousePointer = vbHourglass
    //  frmDetailsFourniture.mstrStatut = "M"
    //  frmDetailsFourniture.miNumFour = ZeroIfNull(adoRS("NFOUNUM"))
    //  frmDetailsFourniture.Show vbModal
    //  
    //   ' rafraichissement du recordset
    //  adoRS.Requery
    //
    //  ' mise en page du tableau
    //  ApiGrid.MajLabel
    //  'InitApigrid
    //
    //
    //End Sub
    //

    private void InitApigrid()
    {
      ApiGrid.AddColumn("ID", "NFOUNUM", 1000);
      ApiGrid.AddColumn(Resources.col_Serie, "VFOUSER", 1500);
      ApiGrid.AddColumn(Resources.col_materiel, "VFOUMAT", 2800);
      ApiGrid.AddColumn(Resources.col_marque, "VFOUMAR", 1500);
      ApiGrid.AddColumn(Resources.col_Type, "VFOUTYP", 1500);
      ApiGrid.AddColumn(Resources.col_reference, "VFOUREF", 1500);
      ApiGrid.AddColumn(Resources.col_Condit, "VFOUCON", 700);
      ApiGrid.AddColumn(Resources.col_pcb, "NFOUNBLOT", 600);
      ApiGrid.AddColumn(Resources.col_prixU, "FPUHT", 1200, "", 1);
      ApiGrid.AddColumn(Resources.col_Fournisseur, "VSTFGRPNOM", 0);
      ApiGrid.AddColumn(Resources.col_dateprix, "DFOUDPR", 1000, "dd/MM/yy", 2);
      ApiGrid.AddColumn(Resources.col_clients, "VFOUCLI", 0);
      ApiGrid.AddColumn(Resources.col_Num_Art, "VSTFFOUREFCLI", 0);
      //'ApiGrid.AddColumn(Resources.col_NumFourn, "NFOUNUM", 0);
      ApiGrid.AddColumn(Resources.col_uniteprix, "FPUNITE", 0);
      ApiGrid.AddColumn(Resources.col_Actif, "CFOUACTIF", 0);
      ApiGrid.AddColumn(Resources.col_img, "VFOUIMAGE", 400);

      ApiGrid.InitColumnList();
    }
    //Sub InitApigrid()
    //  
    //On Error GoTo handler
    //
    //  ApiGrid.AddColumn "§Série§", "VFOUSER", 1500          '0
    //  ApiGrid.AddColumn "§Matériel§", "VFOUMAT", 2800
    //  ApiGrid.AddColumn "§Marque§", "VFOUMAR", 1500
    //  ApiGrid.AddColumn "§Type§", "VFOUTYP", 1500
    //  ApiGrid.AddColumn "§Référence§", "VFOUREF", 1500
    //  ApiGrid.AddColumn "§Cond§", "VFOUCON", 700
    //  ApiGrid.AddColumn "§PCB§", "NFOUNBLOT", 600
    //  ApiGrid.AddColumn "§Prix/U§", "FPUHT", 1200, , 1
    //  ApiGrid.AddColumn "§Fournisseur§", "VSTFGRPNOM", 0
    //  ApiGrid.AddColumn "§Date Prix§", "DFOUDPR", 1000, "dd/mm/yy", 2
    //  ApiGrid.AddColumn "§Clients§", "VFOUCLI", 0
    //  ApiGrid.AddColumn "NumArt", "VSTFFOUREFCLI", 0
    //  ApiGrid.AddColumn "§NumFourn§", "NFOUNUM", 0
    //  ApiGrid.AddColumn "§uniteprix§", "FPUNITE", 0
    //  ApiGrid.AddColumn "§actif§", "CFOUACTIF", 0
    //  ApiGrid.AddColumn "§Img§", "VFOUIMAGE", 400
    //  
    //  ApiGrid.Init adoRS
    //  'ApiGrid.DesactiveListe
    //
    //Exit Sub
    //handler:
    //  ShowError "InitApigrid dans " & Me.Name
    //End Sub
    //
    //Private Sub Form_Unload(Cancel As Integer)
    //  Screen.MousePointer = vbDefault
    //End Sub
    //
    //
    //Private Sub cmdFermer_Click()
    //  Unload Me
    //End Sub
    //
  }
}

