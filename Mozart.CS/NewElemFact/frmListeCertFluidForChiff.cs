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
  public partial class frmListeCertFluidForChiff : Form
  {
    public string msMode = "";
    public long mlNumActionSelect = 0;
    public DataTable mdtArticle = new DataTable();

    DataTable dtCertFluid = new DataTable();

    //Dim rsDI As ADODB.Recordset
    //Dim rsCertFluid As ADODB.Recordset
    //Dim sMode As String
    //Dim lNumActionSelect As Long

    public frmListeCertFluidForChiff()
    {
      InitializeComponent();
    }

    /* ----------------------------------------------------------------------------------------- */
    private void frmListeCertFluidForChiff_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);
        apiTgrid.btnExcel.Visible = apiTgrid.btnPrint.Visible = apiTgrid.chkColumnsList.Visible = false;
        DataTable dtDI = new DataTable();

        // TODO Test avec 2292774
        ModuleData.LoadData(dtDI, $"EXEC [api_sp_ListeCertiticat_A_Chiffrer] {mlNumActionSelect}");
        //InitDataTableArticle();
        InitGrid();
        dtCertFluid.Columns.Add("NCOCHE", typeof(bool));
        dtCertFluid.Columns.Add("NIDCERTFLUIDSERVER", typeof(Int64));
        dtCertFluid.Columns.Add("NFLUIDEVIERGE", typeof(double));
        dtCertFluid.Columns.Add("NCERTNUMFICHE", typeof(string));
        dtCertFluid.Columns.Add("VNATUREFLUID", typeof(string));
        dtCertFluid.Columns.Add("NIDTYPEFLUIDE", typeof(int));
        dtCertFluid.Columns.Add("NSSCFONUM", typeof(int));
        dtCertFluid.Columns.Add("PRIXCOEFF_UNIT", typeof(double));
        dtCertFluid.Columns.Add("PRIXCOEFF_TOTAL", typeof(double));

        foreach (DataRow item in dtDI.Rows)
        {
          DataRow newrow = dtCertFluid.NewRow();
          newrow["NCOCHE"] = item["NCOCHE"];
          newrow["NIDCERTFLUIDSERVER"] = item["NIDCERTFLUIDSERVER"];
          newrow["NFLUIDEVIERGE"] = Math.Round(Convert.ToDouble(item["NFLUIDEVIERGE"]));
          newrow["NCERTNUMFICHE"] = item["NCERTNUMFICHE"];
          newrow["VNATUREFLUID"] = item["VNATUREFLUID"];
          newrow["NIDTYPEFLUIDE"] = item["NIDTYPEFLUIDE"];
          newrow["NSSCFONUM"] = item["NSSCFONUM"];
          newrow["PRIXCOEFF_UNIT"] = item["PRIXCOEFF_UNIT"];
          newrow["PRIXCOEFF_TOTAL"] = item["PRIXCOEFF_TOTAL"];
          dtCertFluid.Rows.Add(newrow);
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub Form_Load()
    //
    //On Error GoTo Handler:
    //
    //  InitBoutons Me, frmMenu
    //     
    //  ' recherche de la liste des sites
    //  Set rsDI = New ADODB.Recordset
    //  rsDI.Open "EXEC [api_sp_ListeCertiticat_A_Chiffrer] " & lNumActionSelect, cnx, adOpenStatic, adLockOptimistic
    //  
    //  ' initialisation du tableau de recherche des articles
    //  Set rsCertFluid = New ADODB.Recordset
    //  
    //  ' ajout des champs au recordset
    //  rsCertFluid.Fields.Append "NCOCHE", adInteger
    //  rsCertFluid.Fields.Append "NIDCERTFLUIDSERVER", adBigInt
    //  rsCertFluid.Fields.Append "NFLUIDEVIERGE", adDecimal
    //  rsCertFluid.Fields.Append "NCERTNUMFICHE", adVarChar, 300
    //  rsCertFluid.Fields.Append "VNATUREFLUID", adVarChar, 300
    //  rsCertFluid.Fields.Append "NIDTYPEFLUIDE", adInteger
    //  rsCertFluid.Fields.Append "NSSCFONUM", adInteger
    //  rsCertFluid.Fields.Append "PRIXCOEFF_UNIT", adDecimal
    //  rsCertFluid.Fields.Append "PRIXCOEFF_TOTAL", adDecimal
    //  
    //  rsCertFluid.Open , , adOpenDynamic, adLockOptimistic
    //    
    //  While Not rsDI.EOF
    //    rsCertFluid.AddNew
    //    rsCertFluid("NCOCHE").value = rsDI("NCOCHE")
    //    rsCertFluid("NIDCERTFLUIDSERVER").value = rsDI("NIDCERTFLUIDSERVER")
    //    rsCertFluid("NFLUIDEVIERGE").value = roundUp(rsDI("NFLUIDEVIERGE"))
    //    rsCertFluid("NCERTNUMFICHE").value = rsDI("NCERTNUMFICHE")
    //    rsCertFluid("VNATUREFLUID").value = rsDI("VNATUREFLUID")
    //    rsCertFluid("NIDTYPEFLUIDE").value = rsDI("NIDTYPEFLUIDE")
    //    rsCertFluid("NSSCFONUM").value = rsDI("NSSCFONUM")
    //    rsCertFluid("PRIXCOEFF_UNIT").value = rsDI("PRIXCOEFF_UNIT")
    //    rsCertFluid("PRIXCOEFF_TOTAL").value = rsDI("PRIXCOEFF_TOTAL")
    //    
    //    rsCertFluid.Update
    //    rsDI.MoveNext
    //  Wend
    //  
    //  rsDI.Close
    //  Set rsDI = Nothing
    //  
    //  InitTGrid
    //  
    //Exit Sub
    //Resume
    //Handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub


    //Public Property Get Mode() As String
    //  Mode = sMode
    //End Property

    //Public Property Let Mode(ByVal New_Mode As String)
    //  sMode = New_Mode
    //End Property

    //Public Property Get NumActionSelected() As Long
    //  NumActionSelected = lNumActionSelect
    //End Property

    //Public Property Let NumActionSelected(ByVal New_NumActionSelected As Long)
    //  lNumActionSelect = New_NumActionSelected
    //End Property


    /* ----------------------------------------------------------------------------------------- */
    private void cmdEnregistrer_Click(object sender, EventArgs e)
    {
      bool bOK = false;

      foreach (DataRow rowCertFluide in dtCertFluid.Rows)
      {
        // TODO Afficher la colonne NCOCHE avec une case à cocher
        if (Convert.ToBoolean(rowCertFluide["NCOCHE"]))
        {
          //  test si l'enregistrement n'est pas déja selectionné, on a le numArticle on regarde si il existe

          DataTable dtA = new DataTable();
          // Execution d'une requete qui donne la liste des articles avec les prix emalec ou client
          ModuleData.LoadData(dtA, $"exec [api_sp_ListePrixArticleCertificatFluide] {MozartParams.NumDi}, {rowCertFluide["NIDCERTFLUIDSERVER"]}");

          // Rendre la colonne Prix modifiable

          foreach (DataRow rowA in dtA.Rows)
          {
            bOK = false;
            DataTable dtArticlesClone = mdtArticle.Copy();
            foreach (DataRow rowArt in dtArticlesClone.Rows)
            {
              mdtArticle.Columns["Prix"].ReadOnly = false;
              if (msMode == "NF")
              {
                if ((int)rowArt["NFOUNUM"] == (int)rowA["NFOUNUM"])
                {
                  // update seulement de la quantité
                  rowArt["Quantite"] = (int)rowArt["Quantite"] + roundUp((double)rowA["QTE"]);
                  bOK = true;
                }
              }
              else
              {
                if ((int)rowArt["NumArticle"] == (int)rowA["NFOUNUM"])
                {
                  // update seulement de la quantité
                  rowArt["Quantite"] = (int)rowArt["Quantite"] + roundUp(Convert.ToDouble(rowA["QTE"]));
                  rowArt["Prix"] = (double)rowA["NFOUTAR"] * ((int)rowArt["Quantite"] + roundUp(Convert.ToDouble(rowA["QTE"])));
                  bOK = true;
                }
              }
            }

            if (!bOK)
            {
              if (msMode == "NF")
                AjouterEnregFNF(rowA);
              else
                AjouterEnreg(rowA);
            }
          }
        }
      }
      Dispose();
    }
    //Private Sub cmdEnregistrer_Click()
    //Dim rsA As ADODB.Recordset
    //Dim bOK As Boolean
    //
    //  If rsCertFluid.EOF Then Exit Sub
    //    
    //  'on récupère les case à cocher = OK
    //  rsCertFluid.MoveFirst
    //  
    //  While rsCertFluid.EOF = False
    //    
    //    If rsCertFluid("NCOCHE") = -1 Then
    //    
    //        ' test si l'enregistrement n'est pas déja selectionné
    //          ' on a le numArticle on regarde si il existe
    //        
    //          Set rsA = New ADODB.Recordset
    //          ' execution d'une requete qui donne la liste des articles avec les prix emalec ou client
    //          rsA.Open "exec [api_sp_ListePrixArticleCertificatFluide] " & giNumDi & "," & rsCertFluid!NIDCERTFLUIDSERVER, cnx, adOpenDynamic, adLockReadOnly
    //            
    //          While Not rsA.EOF
    //            
    //            bOK = False
    //            On Error Resume Next
    //              rsarticle.MoveFirst
    //        
    //            On Error GoTo Handler
    //        
    //              While Not rsarticle.EOF
    //                If sMode = "NF" Then
    //                    If rsarticle("NFOUNUM") = rsA("NFOUNUM").value Then
    //                        'update seulement de la quantité
    //                        rsarticle("Quantite").value = rsarticle("Quantite").value + roundUp(rsA("QTE"))
    //                        rsarticle.Update
    //                        bOK = True
    //                    End If
    //                Else
    //                    If rsarticle("NumArticle") = rsA("NFOUNUM").value Then
    //                        'update seulement de la quantité
    //                        rsarticle("Quantite").value = rsarticle("Quantite").value + roundUp(rsA("QTE"))
    //                        rsarticle("PrixTotal").value = rsA("NFOUTAR") * (rsarticle("Quantite").value + roundUp(rsA("QTE")))
    //                        rsarticle.Update
    //                        bOK = True
    //                    End If
    //                End If
    //                rsarticle.MoveNext
    //              Wend
    //        
    //              If Not bOK Then
    //                If sMode = "NF" Then
    //                    Call AjouterEnregFNF(rsA)
    //                Else
    //                    Call AjouterEnreg(rsA)
    //                End If
    //              End If
    //            rsA.MoveNext
    //          Wend
    //          rsA.Close
    //         Set rsA = Nothing
    //    End If
    //    rsCertFluid.MoveNext
    //  
    //  Wend
    //  Unload Me
    //
    //Exit Sub
    //Resume
    //Handler:
    //  ShowError "AjouterEnreg dans " & Me.Name
    //End Sub

    private void InitDataTableArticle()
    {
      mdtArticle = new DataTable();

      mdtArticle.Columns.Add(new DataColumn("Serie", Type.GetType("System.String")));
      mdtArticle.Columns.Add(new DataColumn("Article", Type.GetType("System.String")));
      mdtArticle.Columns.Add(new DataColumn("Marque", Type.GetType("System.String")));
      mdtArticle.Columns.Add(new DataColumn("Type", Type.GetType("System.String")));
      mdtArticle.Columns.Add(new DataColumn("Fournisseurs", Type.GetType("System.String")));
      mdtArticle.Columns.Add(new DataColumn("NumFour", Type.GetType("System.Int32")));
      mdtArticle.Columns.Add(new DataColumn("NumArticle", Type.GetType("System.Int32")));
      mdtArticle.Columns.Add(new DataColumn("Quantite", Type.GetType("System.Int32")));
      mdtArticle.Columns.Add(new DataColumn("CoeffClient", Type.GetType("System.Double")));
      mdtArticle.Columns.Add(new DataColumn("PrixTotal", Type.GetType("System.Double")));
      mdtArticle.Columns.Add(new DataColumn("Recyclage", Type.GetType("System.Int32")));
      mdtArticle.Columns.Add(new DataColumn("NACTNUM", Type.GetType("System.Int32")));
      mdtArticle.Columns.Add(new DataColumn("NFOUNUM", Type.GetType("System.Int32")));
      mdtArticle.Columns.Add(new DataColumn("DFNFMODIF", Type.GetType("System.String")));
      mdtArticle.Columns.Add(new DataColumn("BSTOCK", Type.GetType("System.Int32")));
    }

    private void AjouterEnreg(DataRow rowArt)
    {
      DataRow newrow = mdtArticle.NewRow();
      newrow["Serie"] = Utils.BlankIfNull(rowArt["VFOUSER"]);
      newrow["Article"] = Utils.BlankIfNull(rowArt["VFOUMAT"]);
      newrow["Marque"] = Utils.BlankIfNull(rowArt["VFOUMAR"]);
      newrow["Prix"] = Utils.ZeroIfNull(rowArt["NFOUTAR"]);
      newrow["Fournisseurs"] = "";
      newrow["NumFour"] = 0;
      newrow["NumArticle"] = rowArt["NFOUNUM"];
      newrow["Quantite"] = roundUp(Convert.ToDouble(rowArt["Qte"]));
      newrow["CoefClient"] = rowArt["COEFF"];
      //newrow["PrixTotal"] = (int)rowArt["NFOUTAR"] * roundUp((double)rowArt["Qte"]);
      newrow["Recyclage"] = Utils.ZeroIfNull(rowArt["RecyclageVente"]) == 0 ? Utils.ZeroIfNull(rowArt["Recyclage"]) : Utils.ZeroIfNull(rowArt["RecyclageVente"]);
      //newrow["colImmo"] = false;
      //newrow["colStock"] = false;

      mdtArticle.Rows.Add(newrow);
    }
    //Private Sub AjouterEnreg(rsArt As ADODB.Recordset)
    //On Error GoTo Handler
    //
    //  rsarticle.AddNew
    //
    //  rsarticle("Serie").value = rsArt("VFOUSER")
    //  rsarticle("Article").value = rsArt("VFOUMAT")
    //  rsarticle("Marque").value = BlankIfNull(rsArt("VFOUMAR"))
    //  rsarticle("Prix").value = rsArt("NFOUTAR")
    //  rsarticle("Fournisseur").value = ""  'adoRS!VSTFNOM
    //  rsarticle("NumFour").value = 0 'adoRS!NSTFNUM
    //  rsarticle("NumArticle").value = rsArt("NFOUNUM")
    //  rsarticle("Quantite").value = roundUp(rsArt("QTE"))
    //  rsarticle("CoefClient").value = rsArt("COEFF")
    //  rsarticle("PrixTotal").value = rsArt("NFOUTAR") * roundUp(rsArt("QTE"))
    //  rsarticle("Recyclage").value = IIf(ZeroIfNull(rsArt("RecyclageVente")) = 0, ZeroIfNull(rsArt("Recyclage")), ZeroIfNull(rsArt("RecyclageVente"))) 'ZeroIfNull(rsArt("Recyclage"))
    //
    //  rsarticle.Update
    //
    //Exit Sub
    //Resume
    //Handler:
    //  ShowError "AjouterEnreg dans " & Me.Name
    //End Sub

    private void AjouterEnregFNF(DataRow rowArt)
    {
      DataRow newrow = mdtArticle.NewRow();
      newrow["CCFOCOD"] = Utils.BlankIfNull(rowArt["VFOUSER"]);
      newrow["VFOUMAT"] = Utils.BlankIfNull(rowArt["VFOUMAT"]);
      newrow["VFOUMAR"] = Utils.BlankIfNull(rowArt["VFOUMAR"]);
      newrow["NFPRIXACHAT"] = Utils.ZeroIfNull(rowArt["FPUHT"]);
      newrow["NFNFQTE"] = roundUp((double)rowArt["Qte"]);
      //newrow["Fournisseurs"] = "";
      newrow["NACTNUM"] = 0;
      newrow["NFOUNUM"] = rowArt["NFOUNUM"];
      newrow["DFNFMODIF"] = DateTime.Now.ToShortDateString();
      newrow["BSTOCK"] = 0;
      //      newrow["PrixTotal"] = (int)rowArt["NFOUTAR"] * (int)rowArt["Qte"];

      //newrow["colImmo"] = false;
      //newrow["colStock"] = false;
      mdtArticle.Rows.Add(newrow);
    }
    //Private Sub AjouterEnregFNF(rsArt As ADODB.Recordset)
    //On Error GoTo Handler
    //
    //  rsarticle.AddNew
    //
    //  rsarticle("Serie").value = rsArt("VFOUSER")
    //  rsarticle("Article").value = rsArt("VFOUMAT")
    //  rsarticle("Marque").value = BlankIfNull(rsArt("VFOUMAR"))
    //  rsarticle("PrixAchat").value = IIf(ZeroIfNull(rsArt("COEFF")) = 0, 0, rsArt("NFOUTAR") / rsArt("COEFF"))
    //  rsarticle("Quantite").value = roundUp(rsArt("QTE"))
    //  'rsarticle("Fournisseur").value = ""  'adoRS!VSTFNOM
    //  rsarticle("NACTNUM").value = 0 'adoRS!NSTFNUM
    //  rsarticle("NFOUNUM").value = rsArt("NFOUNUM")
    //
    //  rsarticle("DFNFMODIF").value = Date
    //  rsarticle("BSTOCK").value = 0
    //
    //  'rsarticle("PrixTotal").value = rsArt("NFOUTAR") * rsArt("QTE")
    //  rsarticle.Update
    //
    //Exit Sub
    //Resume
    //Handler:
    //  ShowError "AjouterEnreg dans " & Me.Name
    //End Sub


    //Private Sub Form_Unload(Cancel As Integer)
    //  On Error Resume Next
    //  rsCertFluid.Close
    //  Set rsCertFluid = Nothing
    //End Sub

    /* ----------------------------------------------------------------------------------------- */
    private void InitGrid()
    {
      apiTgrid.AddColumn(" ", "NCOCHE", 400);
      apiTgrid.AddColumn(Resources.col_num_cert, "NCERTNUMFICHE", 2500);
      apiTgrid.AddColumn(Resources.col_nature_fluide, "VNATUREFLUID", 2500);
      apiTgrid.AddColumn(Resources.col_qte_utilisee, "NFLUIDEVIERGE", 1200, "", 1);
      apiTgrid.AddColumn(Resources.col_prix_total, "PRIXCOEFF_TOTAL", 3000, "Currency", 1);
      apiTgrid.AddColumn("NIDCERTFLUIDSERVER", "NIDCERTFLUIDSERVER", 0);
      apiTgrid.DelockColumn("NCOCHE");
      apiTgrid.GridControl.DataSource = dtCertFluid;
      apiTgrid.FilterBar = false;
    }
    //Sub InitTGrid()
    //  apiTgrid.AddColumn " ", "NCOCHE", 400, , , , , True
    //  apiTgrid.AddColumn "§N° Cert§", "NCERTNUMFICHE", 2500
    //  apiTgrid.AddColumn "§Nature Fluide§", "VNATUREFLUID", 2500
    //  apiTgrid.AddColumn "§Quantité utilisée§", "NFLUIDEVIERGE", 1200, , 1
    //  apiTgrid.AddColumn "§Prix Total§", "PRIXCOEFF_TOTAL", 3000, "Currency", 1
    //  apiTgrid.AddColumn "NIDCERTFLUIDSERVER", "NIDCERTFLUIDSERVER", 0
    //  
    //  apiTgrid.DelockColumn "NCOCHE"
    //  
    //  apiTgrid.Init rsCertFluid
    //  apiTgrid.FilterBar = False
    //End Sub

    /* ----------------------------------------------------------------------------------------- */
    private double roundUp(double dblValue)
    {
      return (int)dblValue == dblValue ? dblValue : (int)dblValue + 1;
    }
    //Private Function roundUp(dblValue As Double) As Double
    //    On Error GoTo PROC_ERR
    //    Dim myDec As Long
    //    myDec = InStr(1, CStr(dblValue), ",", vbTextCompare)
    //    
    //    If myDec > 0 Then
    //        roundUp = CDbl(Left(CStr(dblValue), myDec)) + 1
    //    Else
    //        roundUp = dblValue
    //    End If
    //    
    //PROC_EXIT:
    //        Exit Function
    //PROC_ERR:
    //        MsgBox Err.Description, vbInformation, "Round Up"
    //End Function
  }
}