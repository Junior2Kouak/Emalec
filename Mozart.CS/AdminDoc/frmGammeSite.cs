using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmGammeSite : Form
  {
    public string mstrStatut = "";
    public long miNumTrame;
    private string scboClient = "";
    private string scboSite;
    private string scboType;

    //Option Explicit
    //
    //Public mstrStatut As String
    //Public miNumTrame As Long
    //
    //Dim NbCoche
    //Dim adoRS As ADODB.Recordset

    public frmGammeSite()
    {
      InitializeComponent();
    }

    private void frmGammeSite_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);
        //  combo des clients
        //#if MULTI
        apicboClient.Init(MozartDatabase.cnxMozart, "select distinct TCLI.NCLINUM, VCLINOM from TGAMCLIENT, TCLI WHERE VSOCIETE = '" + MozartParams.NomSociete +
                      "' AND TCLI.NCLINUM = TGAMCLIENT.NCLINUM order by VCLINOM", "NCLINUM", "VCLINOM", new List<string>() { Resources.col_Num, Resources.col_Nom }, 500, 500);

        //#else
        //        apicboClient.Init(MozartDatabase.cnxMozart, "select distinct TCLI.NCLINUM, VCLINOM from TGAMCLIENT, TCLI WHERE TCLI.NCLINUM = TGAMCLIENT.NCLINUM " +
        //                      "order by VCLINOM", "NCLINUM", "VCLINOM", new List<string>() { Resources.col_Num, Resources.col_Nom }, 500, 500);
        //#endif

        if (mstrStatut == "V")    // Visualiser
        {
          cmdValider.Enabled = false;
          cmdAjout.Enabled = false;
          Label14.Text = Resources.txt_visuTramesGammeSite;

          DataTable dtV = new DataTable();
          using (SqlDataReader dr = ModuleData.ExecuteReader("api_sp_InfoTramesGammeSite " + miNumTrame))
          {
            dtV.Load(dr);
            dr.Close();
          }
          if (dtV.Rows.Count > 0)
          {
            DataRow row = dtV.Rows[0];
            txtNum.Text = row[0].ToString();
            txtDate.Text = row[1].ToString().Substring(0, 10);
            apicboClient.SetText(row[2].ToString());
            cboSite.SelectedText = row[3].ToString();
            scboType = Utils.BlankIfNull(row["num"]);
          }
          apicboClient.Enabled = false;
          cboType.Enabled = false;
        }
        else if (mstrStatut == "Mod")   // Modifier
        {
          cboSite.Enabled = false;
          cboNumSite.Enabled = false;
          Label14.Text = Resources.txt_modifTrameGammeClient;
          cmdValider.Enabled = true;

          using (SqlDataReader dr = ModuleData.ExecuteReader("api_sp_InfoTramesGammeSite " + miNumTrame))
          {
            if (dr.Read())
            {
              txtNum.Text = dr[0].ToString();
              txtDate.Text = dr[1].ToString().Substring(0, 10);
              // On passe par des variables intermédiaires pour éviter l'erreur 'DataReader déjà ouvert'
              scboClient = dr[2].ToString();
              scboSite = dr[3].ToString();
              scboType = Utils.BlankIfNull(dr["num"]);
            }
            dr.Close();
          }
          // Utilisation des variables intermédiaires
          apicboClient.SetText(scboClient);
          cboSite.Text = scboSite;
          apicboClient.Enabled = false;
          cboType.Enabled = false;
        }
        else if (mstrStatut == "M")   // Copier
        {
          Label14.Text = Resources.txt_modifTrameGammeSite;
          cmdValider.Enabled = true;

          using (SqlDataReader dr = ModuleData.ExecuteReader("api_sp_InfoTramesGammeSite " + miNumTrame))
          {
            if (dr.Read())
            {
              txtNum.Text = dr[0].ToString();
              txtDate.Text = dr[1].ToString().Substring(0, 10);
              // On passe par des variables intermédiaires pour éviter l'erreur 'DataReader déjà ouvert'
              scboClient = dr[2].ToString();
              scboSite = dr[3].ToString();
              scboType = Utils.BlankIfNull(dr["num"]);
            }
            dr.Close();
          }
          // Utilisation des variables intermédiaires
          apicboClient.SetText(scboClient);
          cboSite.Text = scboSite;
          apicboClient.Enabled = false;
          cboType.Enabled = false;
        }
        else
        { //création
          Label14.Text = Resources.txt_creaGammeSite;
          cmdValider.Enabled = true;
          cmdAjout.Enabled = false;
        }

        cboclient_Leave(null, null);
        if (scboType != null && scboType != "") cboType.SelectedValue = scboType;
        CboType_SelectedIndexChanged(null, null);
        this.cboType.SelectedIndexChanged += new System.EventHandler(this.CboType_SelectedIndexChanged);
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
    //Private Sub Form_Load()
    //  
    //  ' initialisation des images
    //  InitBoutons Me, frmMenu
    //  
    //  ' combo des clients
    //  cboClient.SizeCombo 500
    //  
    //  SizeCombo cboSite, 500
    //  SizeCombo cboNumSite, 500
    //#If MULTI Then
    //  RemplirCombo cboclient, "select distinct TCLI.NCLINUM, VCLINOM from TGAMCLIENT, TCLI WHERE VSOCIETE = App_Name() AND TCLI.NCLINUM = TGAMCLIENT.NCLINUM order by VCLINOM"
    //#Else
    //  RemplirCombo cboclient, "select distinct TCLI.NCLINUM, VCLINOM from TGAMCLIENT, TCLI WHERE TCLI.NCLINUM = TGAMCLIENT.NCLINUM order by VCLINOM"
    //#End If
    //    
    //  
    //  If mstrStatut = "V" Then
    //    cmdValider.Enabled = False
    //    cmdAjout.Enabled = False
    //    Label1(4).Caption = "§Visualisation des trames de gamme d'un site§"
    //  
    //    ' ouverture du recordset
    //    Set adoRS = New ADODB.Recordset
    //    adoRS.Open "api_sp_InfoTramesGammeSite " & miNumTrame, cnx, adOpenStatic, adLockOptimistic
    //  
    //    txtNum = adoRS(0)
    //    txtDate = adoRS(1)
    //    cboClient.Text = adoRS(2)
    //    cboSite.Text = adoRS(3)
    //    SelectLB CboType, adoRS("Num")
    //    
    //    cboClient.Enabled = False
    //    CboType.Enabled = False
    //      
    //      
    //  ElseIf mstrStatut = "Mod" Then
    //  
    //      
    //    Label1(4).Caption = "§Modification des trames de gamme d'un client§"
    //    cmdValider.Enabled = True
    //  
    //    ' ouverture du recordset
    //    Set adoRS = New ADODB.Recordset
    //    adoRS.Open "api_sp_InfoTramesGammeSite " & miNumTrame, cnx, adOpenStatic, adLockOptimistic
    //  
    //    txtNum = adoRS(0)
    //    txtDate = adoRS(1)
    //    cboClient.Text = adoRS(2)
    //    cboSite.Text = adoRS(3)
    //   ' cboType.Text = adoRS(4)
    //
    //    SelectLB CboType, adoRS("Num")
    //        
    //    cboClient.Enabled = False
    //    CboType.Enabled = False
    //  
    //  
    //  ElseIf mstrStatut = "M" Then
    //  
    //  
    //    Label1(4).Caption = "§Modification des trames de gamme d'un site§"
    //    cmdValider.Enabled = True
    //  
    //    ' ouverture du recordset
    //    Set adoRS = New ADODB.Recordset
    //    adoRS.Open "api_sp_InfoTramesGammeSite " & miNumTrame, cnx, adOpenStatic, adLockOptimistic
    //  
    //    txtNum = adoRS(0)
    //    txtDate = adoRS(1)
    //    cboClient.Text = adoRS(2)
    //    cboSite.Text = adoRS(3)
    //    SelectLB CboType, adoRS("Num")
    //    
    //    cboClient.Enabled = False
    //    CboType.Enabled = False
    //    
    //  Else  ' création
    //  
    //    Label1(4).Caption = "§Création des trames de gamme d'un site§"
    //    cmdValider.Enabled = True
    //    cmdAjout.Enabled = False
    //    
    //  End If
    //  
    //  Screen.MousePointer = vbDefault
    //
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdFermer_Click()
    //  Unload Me
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private void cmdValider_Click(object sender, EventArgs e)
    {
      try
      {
        string sSQL;

        if (apicboClient.GetText() == "")
        {
          MessageBox.Show(Resources.msg_select_client, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        if (cboSite.Text == "")
        {
          MessageBox.Show(Resources.msg_select_site, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        if (cboType.Text == "")
        {
          MessageBox.Show(Resources.msg_select_gamme_type, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }


        if (mstrStatut == "M") // copie ?
        {
          // confirmation
          if (MessageBox.Show(Resources.msg_confirm_creation_trame_site, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                              MessageBoxDefaultButton.Button2) == DialogResult.No)
            return;
          CopierGamme();
          return;
        }
        else if (mstrStatut == "Mod")
        {
          ModifierGamme();
          return;
        }
        else if (mstrStatut == "C")
        {
          if (cboSite.Text == "TOUS SITES")
          {
            if (MessageBox.Show(Resources.msg_confirm_creation_gamme_tous_sites, Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button2) == DialogResult.No)
              return;
            else
              CopieTousSites();
          }
          CopierGamme();
          return;
        }

        // creation de la gamme
        int NumSite = (int)ModuleData.ExecuteScalarInt("select max(NTRASITNUM) from TGAMSITE");
        NumSite++;

        //  parcours du listebox et insertion d'une ligne dans la table TGAMCLIENT pour chaque catégorie cochée
        //  et pour chaque site
        for (int j = 0; j < lstCat.Items.Count - 1; j++)
        {
          if (lstCat.GetItemChecked(j) == true)
          {
            //execution de la requête d'insert
            sSQL = "insert into TGAMSITE (NTRASITNUM, NSITNUM,  NGAMTRAMENUM, VGAMTYPE, NTYPECONTRAT, DTRASITDAT, NTRAEMANUM, CTRASITACTIF) "
            + "Values ( " + NumSite + ", "
            + ((DataRowView)cboSite.SelectedItem).Row.ItemArray[0] + ",  " + ((DataRowView)lstCat.SelectedItem).Row.ItemArray[j] + ",'" + cboType.Text + "', "
            + txtContrat.Tag + ", '"
            + DateTime.Now.ToShortDateString() + "', " + ((DataRowView)cboType.SelectedItem).Row.ItemArray[0] + ", 'O')";
          }
        }

        cmdValider.Enabled = false;
        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        Cursor.Current = Cursors.Default;
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub cmdValider_Click()
    //
    //Dim sSQL As String
    //Dim i, j As Integer
    //Dim rsSite As ADODB.Recordset
    //
    //On Error GoTo handler
    //
    //  If cboClient.Text = "" Then
    //    MsgBox "§Sélectionnez un client§"
    //    Exit Sub
    //  End If
    //  
    //  If cboSite.Text = "" Then
    //    MsgBox "§Sélectionnez un site§"
    //    Exit Sub
    //  End If
    //  
    //  If CboType.Text = "" Then
    //    MsgBox "§Sélectionnez un type de gamme§"
    //    Exit Sub
    //  End If
    //  
    //  If mstrStatut = "M" Then  ' copie ?
    //    ' confirmation
    //    If MsgBox("§Vous allez créer une nouvelle trame pour ce site. Etes vous d'accord ?§", vbYesNo + vbQuestion + vbDefaultButton2) = vbNo Then
    //        Exit Sub
    //    End If
    //    CopierGamme
    //    Exit Sub
    //  ElseIf mstrStatut = "Mod" Then
    //    ModifierGamme
    //    Exit Sub
    //  ElseIf mstrStatut = "C" Then
    //    If cboSite.Text = "TOUS SITES" Then
    //      If MsgBox("§Vous allez créer une nouvelle gamme pour tous les sites. Etes vous d'accord ?§", vbYesNo + vbQuestion + vbDefaultButton2) = vbNo Then
    //        Exit Sub
    //      End If
    //      CopieTousSites
    //      Exit Sub
    //    End If
    //  
    //  End If
    //
    //  ' creation de la gamme
    //  Set rsSite = New ADODB.Recordset
    //  sSQL = "select max(NTRASITNUM) from TGAMSITE "
    //  rsSite.Open sSQL, cnx
    //       
    //  ' dernier numéro créé
    //  i = rsSite(0)
    //    
    //  ' parcours du listebox et insertion d'une ligne dans la table TGAMCLIENT pour chaque catégorie cochée
    //  ' et pour chaque site
    //  For j = 0 To lstCat.ListCount - 1
    //    If lstCat.Selected(j) = True Then
    //      ' execution de la requête d'insert
    //        sSQL = "insert into TGAMSITE (NTRASITNUM, NSITNUM,  NGAMTRAMENUM, VGAMTYPE, NTYPECONTRAT, DTRASITDAT, NTRAEMANUM, CTRASITACTIF) "
    //        sSQL = sSQL & "Values ( " & (i + 1) & ", "
    //        sSQL = sSQL & cboSite.ItemData(cboSite.ListIndex) & ",  " & lstCat.ItemData(j) & ",'" & CboType.Text & "', "
    //        sSQL = sSQL & txtContrat.Tag & ", '"
    //        sSQL = sSQL & Date & "', " & CboType.ItemData(CboType.ListIndex) & ", 'O')"
    //        cnx.Execute sSQL
    //    End If
    //  Next
    //        
    //  cmdValider.Enabled = False
    //  Screen.MousePointer = vbDefault
    //
    //Exit Sub
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "cmdValider dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private void cmdAjout_Click(object sender, EventArgs e)
    {
      if (miNumTrame == 0) return;

      frmSaisieDetailGam f = new frmSaisieDetailGam();
      f.miNumTrame = Convert.ToInt64(lstCat.SelectedValue);
      f.miSite = cboSite.GetItemData();
      f.miClient = 0;
      f.miNumGamCli = miNumTrame;
      f.ShowDialog();

      // rafraichissement écran
      RemplirListes();

      CocherLesCat();
    }
    //Private Sub cmdAjout_Click()
    // 
    // If miNumTrame = 0 Then Exit Sub
    // 
    // frmSaisieDetailGam.miNumTrame = lstCat.ItemData(lstCat.ListIndex)
    // frmSaisieDetailGam.miSite = cboSite.ItemData(cboSite.ListIndex)
    // frmSaisieDetailGam.miClient = 0
    // frmSaisieDetailGam.miNumGamCli = miNumTrame
    // frmSaisieDetailGam.Show vbModal
    // 
    // ' rafraichissement écran
    // RemplirListes
    //
    // CocherLesCat
    //
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private void CopieTousSites()
    {
      string sSql;

      //  parcours de la listebox et insertion d'une ligne dans la table TGAMSITE 
      // pour chaque catégorie cochée et chaque site
      for (int k = 1; k < cboSite.Items.Count - 2; k++)
      {
        int NumSite = (int)ModuleData.ExecuteScalarInt("select max(NTRASITNUM) from TGAMSITE");
        foreach (DataRowView item in lstCat.CheckedItems)
        {
          sSql = "insert into TGAMSITE (NTRASITNUM, NSITNUM,  NGAMTRAMENUM, VGAMTYPE, NTYPECONTRAT, DTRASITDAT, NTRAEMANUM, CTRASITACTIF) "
               + "Values ( " + (NumSite + 1) + ", "
               + ((DataRowView)cboSite.SelectedItem).Row.ItemArray[0] + ",  " + item["NGAMTRAMENUM"] + ",'" + cboType.Text + "', "
               + Convert.ToInt32(txtContrat.Tag.ToString()) + ", '"
               + DateTime.Now.ToShortDateString() + "', " + ((DataRowView)cboType.SelectedItem).Row.ItemArray[1] + ", 'O')";

          ModuleData.ExecuteNonQuery(sSql);

        }

      }
      cmdValider.Enabled = false;
      Cursor.Current = Cursors.Default;
    }
    //Private Sub CopieTousSites()
    //
    //Dim sSQL As String
    //Dim k, i, j As Integer
    //Dim rsSite As ADODB.Recordset
    //
    //' boucle sur les sites
    //
    //For k = 1 To cboSite.ListCount - 2
    //
    //  'creation de la gamme
    //  Set rsSite = New ADODB.Recordset
    //  sSQL = "select max(NTRASITNUM) from TGAMSITE "
    //  rsSite.Open sSQL, cnx
    //       
    //  ' dernier numéro créé
    //  i = rsSite(0)
    //    
    //  ' parcours du listebox et insertion d'une ligne dans la table TGAMSITE pour chaque catégorie cochée
    //  ' et pour chaque site
    //  For j = 0 To lstCat.ListCount - 1
    //    If lstCat.Selected(j) = True Then
    //      ' execution de la requête d'insert
    //        sSQL = "insert into TGAMSITE (NTRASITNUM, NSITNUM,  NGAMTRAMENUM, VGAMTYPE, NTYPECONTRAT, DTRASITDAT, NTRAEMANUM, CTRASITACTIF) "
    //        sSQL = sSQL & "Values ( " & (i + 1) & ", "
    //        sSQL = sSQL & cboSite.ItemData(k) & ",  " & lstCat.ItemData(j) & ",'" & CboType.Text & "', "
    //        sSQL = sSQL & txtContrat.Tag & ", '"
    //        sSQL = sSQL & Date & "', " & CboType.ItemData(CboType.ListIndex) & ", 'O')"
    //        cnx.Execute sSQL
    //    End If
    //  Next
    //Next ' site suivant
    //
    //  cmdValider.Enabled = False
    //  Screen.MousePointer = vbDefault
    //
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private void CopierGamme()
    {
      string sSql;
      int NumSite = (int)ModuleData.ExecuteScalarInt("select max(NTRASITNUM) from TGAMSITE");

      //  parcours de la listebox et insertion d'une ligne dans la table TGAMCLIENT pour chaque catégorie cochée 
      foreach (DataRowView item in lstCat.CheckedItems)
      {
        sSql = "insert into TGAMSITE (NTRASITNUM, NSITNUM,  NGAMTRAMENUM, VGAMTYPE, NTYPECONTRAT, DTRASITDAT, NTRAEMANUM, CTRASITACTIF) "
                 + "Values ( " + (NumSite + 1) + ", "
                 + ((DataRowView)cboSite.SelectedItem).Row.ItemArray[0] + ",  " + item["NGAMTRAMENUM"] + ",'" + cboType.Text + "', "
                 + Convert.ToInt32(txtContrat.Tag.ToString()) + ", '"
                 + DateTime.Now.ToShortDateString() + "', " + ((DataRowView)cboType.SelectedItem).Row.ItemArray[1] + ", 'O')";

        ModuleData.ExecuteNonQuery(sSql);
      }

      cmdValider.Enabled = false;
      Cursor.Current = Cursors.Default;
    }
    //Private Sub CopierGamme()
    //
    //Dim sSQL As String
    //Dim i, j As Integer
    //Dim rsSite As ADODB.Recordset
    //
    //
    //'***************** copie de la gamme en cours
    //  Set rsSite = New ADODB.Recordset
    //  sSQL = "select max(NTRASITNUM) from TGAMSITE "
    //  rsSite.Open sSQL, cnx
    //       
    //  ' dernier numéro créé
    //  i = rsSite(0)
    //    
    //  ' parcours du listebox et insertion d'une ligne dans la table TGAMCLIENT pour chaque catégorie cochée
    //  ' et pour chaque site
    //  For j = 0 To lstCat.ListCount - 1
    //    If lstCat.Selected(j) = True Then
    //      ' execution de la requête d'insert
    //        sSQL = "insert into TGAMSITE (NTRASITNUM, NSITNUM,  NGAMTRAMENUM, VGAMTYPE, NTYPECONTRAT, DTRASITDAT, NTRAEMANUM, CTRASITACTIF) "
    //        sSQL = sSQL & "Values ( " & (i + 1) & ", "
    //        sSQL = sSQL & cboSite.ItemData(cboSite.ListIndex) & ",  " & lstCat.ItemData(j) & ",'" & CboType.Text & "', "
    //        sSQL = sSQL & txtContrat.Tag & ", '"
    //        sSQL = sSQL & Date & "', " & CboType.ItemData(CboType.ListIndex) & ", 'O')"
    //        cnx.Execute sSQL
    //    End If
    //  Next
    //        
    //  cmdValider.Enabled = False
    //  Screen.MousePointer = vbDefault
    //
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private void ModifierGamme()
    {
      string sSQL = "";


      try
      {
        DataTable dtDet = new DataTable();
        sSQL = "select NGAMTRAMENUM, VTRASITDET from  TGAMSITE WHERE VTRASITDET is not null AND NTRASITNUM= " + miNumTrame + " AND NSITNUM = " + cboSite.GetItemData();
        dtDet.Load(new SqlCommand(sSQL, MozartDatabase.cnxMozart).ExecuteReader());

        sSQL = "delete from  TGAMSITE WHERE NTRASITNUM= " + miNumTrame + " AND NSITNUM = " + cboSite.GetItemData();
        ModuleData.ExecuteNonQuery(sSQL);

        //  parcours du listebox et insertion d'une ligne dans la table TGAMSITE pour chaque catégorie cochée
        //  et pour chaque site
        foreach (DataRowView item in lstCat.CheckedItems)
        {
          // execution de la requête d'insert
          sSQL = "insert into TGAMSITE (NTRASITNUM, NSITNUM,  NGAMTRAMENUM, VGAMTYPE, NTYPECONTRAT, DTRASITDAT, NTRAEMANUM, CTRASITACTIF) "
               + "Values ( " + miNumTrame + ", "
               + cboSite.GetItemData() + ",  " + item["NGAMTRAMENUM"].ToString() + ",'" + cboType.Text.Replace("'", "''") + "', "
               + txtContrat.Tag.ToString().Replace("'", "''") + ", '"
               + DateTime.Now.ToShortDateString() + "', " + cboType.SelectedValue + ", 'O')";

          ModuleData.ExecuteNonQuery(sSQL);

          //  on remet les détails existants
          for (int i = 0; i < dtDet.Rows.Count; i++)
          {
            sSQL = "update TGAMSITE set VTRASITDET = '" + ((DataRow)dtDet.Rows[i])["VTRASITDET"].ToString().Replace("'", "''") + "' "
                 + " WHERE NTRASITNUM= " + miNumTrame + " AND NSITNUM = " + cboSite.GetItemData()
                 + " AND NGAMTRAMENUM =  " + ((DataRow)dtDet.Rows[i])["NGAMTRAMENUM"].ToString();
            ModuleData.ExecuteNonQuery(sSQL);
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }

    }
    //Private Sub ModifierGamme()
    //
    //Dim sSQL As String
    //Dim rsDet As ADODB.Recordset
    //
    //  On Error Resume Next
    //  
    //  Set rsDet = New ADODB.Recordset
    //  sSQL = "select NGAMTRAMENUM, VTRASITDET from  TGAMSITE WHERE VTRASITDET is not null AND NTRASITNUM= " & miNumTrame & " AND NSITNUM = " & cboSite.ItemData(cboSite.ListIndex)
    //  rsDet.Open sSQL, cnx
    //       
    //  sSQL = "delete from  TGAMSITE WHERE NTRASITNUM= " & miNumTrame & " AND NSITNUM = " & cboSite.ItemData(cboSite.ListIndex)
    //  cnx.Execute sSQL
    //       
    //  ' parcours du listebox et insertion d'une ligne dans la table TGAMSITE pour chaque catégorie cochée
    //  ' et pour chaque site
    //  For j = 0 To lstCat.ListCount - 1
    //    If lstCat.Selected(j) = True Then
    //      ' execution de la requête d'insert
    //        sSQL = "insert into TGAMSITE (NTRASITNUM, NSITNUM,  NGAMTRAMENUM, VGAMTYPE, NTYPECONTRAT, DTRASITDAT, NTRAEMANUM, CTRASITACTIF) "
    //        sSQL = sSQL & "Values ( " & miNumTrame & ", "
    //        sSQL = sSQL & cboSite.ItemData(cboSite.ListIndex) & ",  " & lstCat.ItemData(j) & ",'" & CboType.Text & "', "
    //        sSQL = sSQL & txtContrat.Tag & ", '"
    //        sSQL = sSQL & Date & "', " & CboType.ItemData(CboType.ListIndex) & ", 'O')"
    //        cnx.Execute sSQL
    //    End If
    //  Next
    //
    //  ' on remet les détails existants
    //  While Not rsDet.EOF
    //    sSQL = "update TGAMSITE set VTRASITDET = '" & Replace(rsDet("VTRASITDET"), "'", "''") & "' "
    //    sSQL = sSQL & " WHERE NTRASITNUM= " & miNumTrame & " AND NSITNUM = " & cboSite.ItemData(cboSite.ListIndex)
    //    sSQL = sSQL & " AND NGAMTRAMENUM =  " & rsDet("NGAMTRAMENUM")
    //    cnx.Execute sSQL
    //    rsDet.MoveNext
    //  Wend
    //
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private void cboclient_Leave(object sender, EventArgs e)
    {
      try
      {
        if (apicboClient.GetItemData().ToString() != "System.Data.DataRowView")
        {
          cboSite.DataBindings.Clear();
          cboNumSite.DataBindings.Clear();

          //    on rempli les combo site et num site
          RemplirComboSite(cboSite, cboNumSite, apicboClient.GetItemData());

          //      ajouter tous sites
          if (mstrStatut == "C")
          {
            DataRow newRow = ((DataTable)cboSite.DataSource).NewRow();
            newRow.ItemArray[0] = 0;
            newRow.ItemArray[1] = Resources.txt_tousSites;
            ((DataTable)cboSite.DataSource).Rows.InsertAt(newRow, 0);

            newRow = ((DataTable)cboNumSite.DataSource).NewRow();
            newRow.ItemArray[0] = 0;
            newRow.ItemArray[1] = Resources.txt_tousSites;
            ((DataTable)cboNumSite.DataSource).Rows.InsertAt(newRow, 0);

            //cboSite.Items.Add(Resources.txt_tousSites);
            //cboNumSite.Items.Add(Resources.txt_tousSites);
          }
          //combo des types
          RemplirComboType("NON");
        }
        else
        {
          cboSite.DataBindings.Clear();
          cboNumSite.DataBindings.Clear();
          cboType.DataBindings.Clear();
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    //Private Sub cboClient_Click()
    //On Error GoTo handler
    //
    //  If cboClient.ListIndex <> 0 Then
    //        
    //    cboSite.Clear
    //    cboNumSite.Clear
    //    ' on rempli les combo site et num site
    //    RemplirComboSite cboSite, cboNumSite, cboClient.ItemData(cboClient.ListIndex)
    //
    //    If mstrStatut = "C" Then
    //      ' ajouter tous sites
    //      cboSite.AddItem "§TOUS SITES§"
    //      cboNumSite.AddItem "§TOUS SITES§"
    //    End If
    //  
    //    ' combo des types
    //    RemplirComboType "NON"
    //
    //  Else
    //    cboSite.Clear
    //    cboNumSite.Clear
    //    CboType.Clear
    //  End If
    //
    //Exit Sub
    //handler:
    //  ShowError "cboClient_click dans " & Me.Name
    //End Sub

    //création d'une fonction se rapprochant de modMain.RemplirComboSite en VB6

    private void RemplirComboSite(ComboBox combo1, ComboBox combo2, int iclient, string typeC = "", string enseigne = "")
    {
      string sSQL1, sSQL2 = "";

      try
      {
        if (enseigne != "")
        {
          if (typeC == "C" || typeC == "DIMail")
          {
            sSQL1 = "SELECT  NSITNUM, VSITNOM FROM TSIT WHERE CSITACTIF='O' AND TSIT.NCLINUM = " + iclient + " AND VSITENSEIGNE='" + enseigne.Replace("'", "''") + "' order by VSITNOM";
            sSQL2 = "SELECT  NSITNUM, NSITNUE FROM TSIT WHERE CSITACTIF='O' AND TSIT.NCLINUM = " + iclient + " AND VSITENSEIGNE='" + enseigne.Replace("'", "''") + "' order by VSITNOM";
          }
          else
          {
            sSQL1 = "SELECT   NSITNUM, VSITNOM FROM TSIT WHERE TSIT.NCLINUM = " + iclient + " AND VSITENSEIGNE='" + enseigne.Replace("'", "''") + "' order by VSITNOM";
            sSQL2 = "SELECT  NSITNUM, NSITNUE FROM TSIT WHERE TSIT.NCLINUM = " + iclient + " AND VSITENSEIGNE='" + enseigne.Replace("'", "''") + "' order by VSITNOM";
          }
        }
        else
        {
          if (typeC == "C" || typeC == "DIMail")
          {
            sSQL1 = "SELECT   NSITNUM, VSITNOM FROM TSIT WHERE CSITACTIF='O' AND TSIT.NCLINUM = " + iclient + " order by VSITNOM";
            sSQL2 = "SELECT  NSITNUM, NSITNUE FROM TSIT WHERE CSITACTIF='O' AND TSIT.NCLINUM = " + iclient + " order by VSITNOM";
          }
          else
          {
            sSQL1 = "SELECT 0 [NSITNUM], 'Tous sites' [VSITNOM] UNION Select  NSITNUM, VSITNOM FROM TSIT WHERE TSIT.NCLINUM = " + iclient + " order by VSITNOM";
            sSQL2 = "SELECT 0 [NSITNUM], 'Tous sites' [VSITNOM] UNION Select  NSITNUM, NSITNUE FROM TSIT WHERE TSIT.NCLINUM = " + iclient + " order by VSITNOM";
          }
        }

        //vider la combo
        combo1.DataBindings.Clear();
        combo2.DataBindings.Clear();

        //combo1.Items.Add("");
        //combo1.SelectedItem = 0;
        //combo2.Items.Add("");
        //combo2.SelectedItem = 0;

        ModuleData.RemplirCombo(combo1, sSQL1);
        combo1.ValueMember = "NSITNUM";
        combo1.DisplayMember = "VSITNOM";

        ModuleData.RemplirCombo(combo2, sSQL2);
        combo2.ValueMember = "NSITNUM";
        combo2.DisplayMember = "NSITNUE";

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    /* OK--------------------------------------------------------------------------*/
    private void CboType_SelectedIndexChanged(object sender, EventArgs e)
    {
      try
      {
        if (apicboClient.GetItemData() >= 0)
        {
          //    liste des catégories
          RemplirListes();

          //    cocher les catégories
          CocherLesCat();
          lblNbSitesC.Text = (lblNbSitesC.Tag.ToString() + CompterCoche()).ToString();
          txtAE.Text = "GC" + string.Format(((DataRowView)cboType.SelectedItem).Row.ItemArray[1].ToString(), "000");

          //    recherche du type de contrat
          txtContrat.Text = RechercheContrat();
        }
        else
        {
          //    on vide la liste des catégories
          lstCat.Items.Clear();
          txtAE.Text = "";
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    //Private Sub cboType_Click()
    //    
    //On Error GoTo handler
    //
    //  If CboType.ListIndex <> 0 Then
    //    ' liste des catégories
    //    RemplirListes
    //    ' cocher les catégories
    //    CocherLesCat
    //    txtAE = "GC" & Format(CboType.ItemData(CboType.ListIndex), "000")
    //    ' recherche du type de contrat
    //    txtContrat = RechercheContrat
    //    
    //  Else
    //    ' on vide la liste des catégories
    //    lstCat.Clear
    //    txtAE = ""
    //  End If
    //
    //Exit Sub
    //handler:
    //  ShowError "CboType_click dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private void cboNumSite_SelectedIndexChanged(object sender, EventArgs e)
    {
      try
      {
        cboSite.SelectedIndex = cboNumSite.SelectedIndex;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub cboNumSite_Click()
    //    
    //On Error GoTo handler
    //    
    //  ' on accorde les deux combo
    //  'cboSite.ListIndex = cboNumSite.ListIndex
    //  SelectLB cboSite, cboNumSite.ItemData(cboNumSite.ListIndex)
    //  
    //Exit Sub
    //handler:
    //  ShowError "cboNumSite_Click dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private void cboSite_SelectedIndexChanged(object sender, EventArgs e)
    {
      try
      {
        if (cboSite.SelectedIndex > 0 && 0 < cboNumSite.Items.Count)
          cboNumSite.SelectedIndex = cboSite.SelectedIndex;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub cboSite_Click()
    //
    //On Error GoTo handler
    //  
    //  ' on accorde les deux combo
    //  'cboNumSite.ListIndex = cboSite.ItemData(cboSite.ListIndex)
    //    
    //  SelectLB cboNumSite, cboSite.ItemData(cboSite.ListIndex)
    //  
    //Exit Sub
    //handler:
    //  ShowError "cboSite_click dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private void RemplirComboType(string actif)
    {
      string sSql;
      if (actif == "OUI")
        sSql = "select distinct TGAMCLIENT.VGAMTYPE + ' - ' + VPAYSNOM, NTRACLINUM From TGAMCLIENT, TPAYS, TGAMTRAMESEMALEC "
             + " Where nClinum = " + apicboClient.GetItemData() + " AND CTRACLIACTIF = 'O' "
             + " AND TPAYS.NPAYSNUM = TGAMTRAMESEMALEC.NPAYSNUM  AND TGAMTRAMESEMALEC.NTRAEMANUM = TGAMCLIENT.NTRAEMANUM "
             + " order by TGAMCLIENT.VGAMTYPE + ' - ' + VPAYSNOM, NTRACLINUM ";
      else
        sSql = "select distinct TGAMCLIENT.VGAMTYPE + ' - ' + VPAYSNOM, NTRACLINUM From TGAMCLIENT, TPAYS, TGAMTRAMESEMALEC "
             + " Where nClinum = " + apicboClient.GetItemData() + " AND TPAYS.NPAYSNUM = TGAMTRAMESEMALEC.NPAYSNUM "
             + " AND TGAMTRAMESEMALEC.NTRAEMANUM = TGAMCLIENT.NTRAEMANUM order by TGAMCLIENT.VGAMTYPE + ' - ' + VPAYSNOM, NTRACLINUM ";

      ModuleData.RemplirCombo(cboType, sSql);
      cboType.ValueMember = "NTRACLINUM";
      cboType.DisplayMember = "Column1";
    }
    //Public Sub RemplirComboType(actif As String)
    //  
    //Dim i As Integer
    //  
    //  On Error GoTo handler
    //  
    //  Set rs = New ADODB.Recordset
    //  If actif = "OUI" Then
    //    rs.Open "select distinct TGAMCLIENT.VGAMTYPE + ' - ' + VPAYSNOM  , NTRACLINUM " _
    //          & " From TGAMCLIENT, TPAYS, TGAMTRAMESEMALEC " _
    //          & " Where nClinum = " & cboClient.ItemData(cboClient.ListIndex) & " AND CTRACLIACTIF = 'O' " _
    //          & " AND TPAYS.NPAYSNUM = TGAMTRAMESEMALEC.NPAYSNUM " _
    //          & " AND TGAMTRAMESEMALEC.NTRAEMANUM = TGAMCLIENT.NTRAEMANUM " _
    //          & " order by TGAMCLIENT.VGAMTYPE + ' - ' + VPAYSNOM, NTRACLINUM ", cnx
    //  Else
    //    rs.Open "select distinct TGAMCLIENT.VGAMTYPE + ' - ' + VPAYSNOM  , NTRACLINUM " _
    //          & " From TGAMCLIENT, TPAYS, TGAMTRAMESEMALEC " _
    //          & " Where nClinum = " & cboClient.ItemData(cboClient.ListIndex) _
    //          & " AND TPAYS.NPAYSNUM = TGAMTRAMESEMALEC.NPAYSNUM " _
    //          & " AND TGAMTRAMESEMALEC.NTRAEMANUM = TGAMCLIENT.NTRAEMANUM " _
    //          & " order by TGAMCLIENT.VGAMTYPE + ' - ' + VPAYSNOM, NTRACLINUM ", cnx
    //  End If
    //  
    //  CboType.Clear
    //  
    //  CboType.AddItem ""
    //  CboType.ItemData(0) = 0
    //    
    //  i = 1
    //  While Not rs.EOF
    //    CboType.AddItem rs(0)
    //    CboType.ItemData(i) = rs(1)
    //    rs.MoveNext
    //    i = i + 1
    //  Wend
    //  rs.Close
    //  CboType.ListIndex = 0
    //  
    //Exit Sub
    //handler:
    //  ShowError "RemplirComboType dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private void RemplirListeCategories()
    {
      if (cboType.SelectedItem == null)
        return;

      DataTable dtCat = new DataTable();
      //  Liste de toutes les categories EMALEC
      string sSQL = "SELECT  distinct VGAMPARA + ':' + COALESCE(VGAMLIB, '') [VGAMLIB], TGAMTRAMESEMALEC.NGAMTRAMENUM, NGAMNUMPARA, NGAMNUMLIB "
                   + "FROM TGAMCLIENT RIGHT OUTER JOIN TGAMTRAMESEMALEC ON TGAMCLIENT.NTRAEMANUM = TGAMTRAMESEMALEC.NTRAEMANUM "
                   + "Where NTRACLINUM = " + ((DataRowView)cboType.SelectedItem).Row.ItemArray[1] + " order by NGAMNUMPARA, NGAMNUMLIB";

      using (SqlDataReader dataReader = ModuleData.ExecuteReader(sSQL))
      {
        dtCat.Load(dataReader);
        dataReader.Close();
      }
      lstCat.DataSource = dtCat;
      lstCat.DisplayMember = "VGAMLIB";
      lstCat.ValueMember = "NGAMTRAMENUM";
    }
    //Private Sub RemplirListeCategories()
    //
    //Dim RsFou As ADODB.Recordset
    //Dim sSQL As String
    //Dim i As Integer
    //
    //On Error GoTo handler
    //  Set RsFou = New ADODB.Recordset
    //  
    //  ' liste des case cochées sur le client
    //'  sSQL = "SELECT  VGAMPARA + ':' + COALESCE(VGAMLIB, '') + ' ' + COALESCE(VTRACLIDET, '') , TGAMCLIENT.NGAMTRAMENUM "
    //'  sSQL = sSQL & "FROM TGAMCLIENT INNER JOIN TGAMTRAMESEMALEC ON TGAMCLIENT.NGAMTRAMENUM = "
    //'  sSQL = sSQL & "TGAMTRAMESEMALEC.NGAMTRAMENUM Where NTRACLINUM = " & cboType.ItemData(cboType.ListIndex)
    //'  sSQL = sSQL & " order by NGAMNUMPARA, NGAMNUMLIB"
    //  
    //  ' liste de toutes les categories emalec
    //  sSQL = "SELECT  distinct VGAMPARA + ':' + COALESCE(VGAMLIB, ''), TGAMTRAMESEMALEC.NGAMTRAMENUM, NGAMNUMPARA, NGAMNUMLIB "
    //  sSQL = sSQL & "FROM TGAMCLIENT RIGHT OUTER JOIN TGAMTRAMESEMALEC ON TGAMCLIENT.NTRAEMANUM=TGAMTRAMESEMALEC.NTRAEMANUM "
    //  sSQL = sSQL & "Where NTRACLINUM = " & CboType.ItemData(CboType.ListIndex) & " order by NGAMNUMPARA, NGAMNUMLIB"
    //  
    //  
    //  ' vider la listeBox
    //  RsFou.Open sSQL, cnx, adOpenStatic, adLockOptimistic
    //
    //  
    //  ' vider la listeBox
    //  lstCat.Clear
    //  
    //  i = 0
    //  While Not RsFou.EOF
    //    lstCat.AddItem RsFou(0)
    //    lstCat.ItemData(i) = RsFou(1)
    //    RsFou.MoveNext
    //    i = i + 1
    //  Wend
    //  RsFou.Close
    // 
    //Exit Sub
    //Resume
    //handler:
    //  ShowError " RemplirListeCategories dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private void RemplirListeDetails()
    {
      if (cboType.SelectedItem == null)
        return;

      DataTable dtFou = new DataTable();

      using (SqlDataReader dataReader = ModuleData.ExecuteReader($"EXEC api_sp_ListeDetailGammeSit " + ((DataRowView)cboType.SelectedItem).Row.ItemArray[1]
                                  + ", " + miNumTrame))
      {
        dtFou.Load(dataReader);
        dataReader.Close();
      }
      lstDet.DataSource = dtFou;
      lstDet.DisplayMember = "VTRASITDET";
      lstDet.ValueMember = "NGAMTRAMENUM";
    }
    //Private Sub RemplirListeDetails()
    //
    //Dim RsFou As ADODB.Recordset
    //Dim i As Integer
    //
    //On Error GoTo handler
    //  
    //'  sSQL = "SELECT DISTINCT coalesce(TGAMSITE.VTRASITDET,''), TGAMTRAMESEMALEC.NGAMTRAMENUM, TGAMTRAMESEMALEC.NGAMNUMPARA , TGAMTRAMESEMALEC.NGAMNUMLIB  "
    //'  sSQL = sSQL & "From TGAMTRAMESEMALEC, TGAMSITE, TGAMCLIENT "
    //'  sSQL = sSQL & "Where dbo.TGAMCLIENT.NTRACLINUM = " & cboType.ItemData(cboType.ListIndex)
    //'  sSQL = sSQL & " AND TGAMTRAMESEMALEC.NGAMTRAMENUM = TGAMCLIENT.NGAMTRAMENUM "
    //'  sSQL = sSQL & " AND TGAMCLIENT.NGAMTRAMENUM *= TGAMSITE.NGAMTRAMENUM "
    //'  sSQL = sSQL & " AND TGAMSITE.NTRASITNUM= " & miNumTrame
    //'  sSQL = sSQL & " ORDER BY TGAMTRAMESEMALEC.NGAMNUMPARA, TGAMTRAMESEMALEC.NGAMNUMLIB "
    //  
    //  'recherche du numero de gamme emalec de la gamme client
    //'  Set RsAux = New ADODB.Recordset
    //'  sSQL = "SELECT DISTINCT NTRAEMANUM From TGAMCLIENT WHERE NTRACLINUM =  " & CboType.ItemData(CboType.ListIndex)
    //'  RsAux.Open sSQL, cnx
    //  
    //  Set RsFou = New ADODB.Recordset
    //'  sSQL = "SELECT DISTINCT coalesce(TGAMSITE.VTRASITDET,''), TGAMTRAMESEMALEC.NGAMTRAMENUM, TGAMTRAMESEMALEC.NGAMNUMPARA , TGAMTRAMESEMALEC.NGAMNUMLIB  "
    //'  sSQL = sSQL & " From TGAMTRAMESEMALEC, TGAMSITE "
    //'  sSQL = sSQL & " Where dbo.TGAMTRAMESEMALEC.NTRAEMANUM = (SELECT DISTINCT NTRAEMANUM From TGAMCLIENT WHERE NTRACLINUM =  " & CboType.ItemData(CboType.ListIndex) & ") "
    //'  sSQL = sSQL & " AND TGAMTRAMESEMALEC.NGAMTRAMENUM *= TGAMSITE.NGAMTRAMENUM "
    //'  sSQL = sSQL & " AND TGAMSITE.NTRASITNUM= " & miNumTrame
    //'  sSQL = sSQL & " ORDER BY TGAMTRAMESEMALEC.NGAMNUMPARA, TGAMTRAMESEMALEC.NGAMNUMLIB "
    //
    //' RsFou.Open sSQL, cnx
    //
    //  RsFou.Open "exec  api_sp_ListeDetailGammeSit " & CboType.ItemData(CboType.ListIndex) & ", " & miNumTrame, cnx
    //  
    //'  rsFou.Open "select VGAMPARA + ': ' + VGAMLIB, NGAMTRAMENUM from TGAMTRAMESEMALEC WHERE NTRAEMANUM = " & CboType.ItemData(CboType.ListIndex) & " order by NGAMNUMPARA, NGAMNUMLIB", cnx
    //  
    //  ' vider la listeBox
    //  lstDet.Clear
    //  
    //  i = 0
    //  While Not RsFou.EOF
    //    lstDet.AddItem RsFou(0)
    //    lstDet.ItemData(i) = RsFou(1)
    //    RsFou.MoveNext
    //    i = i + 1
    //  Wend
    //  RsFou.Close
    // 
    //Exit Sub
    //Resume
    //handler:
    //  ShowError " RemplirListeDetails dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private void lstCat_SelectedIndexChanged(object sender, EventArgs e)
    {
      lblNbSitesC.Text = (lblNbSitesC.Tag.ToString() + CompterCoche()).ToString();
      lstDet.TopIndex = lstCat.TopIndex;
    }

    //Private Sub lstcat_Click()
    //  lblNbSitesC = lblNbSitesC.Tag & CompterCoche
    //  lstDet.ListIndex = lstCat.ListIndex
    //  lstDet.TopIndex = lstCat.TopIndex
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private void cmdCocherTC_Click(object sender, EventArgs e)
    {
      //  cocher toutes les lignes
      for (int i = 0; i <= (lstCat.Items.Count - 1); i++)
        lstCat.SetItemChecked(i, true);

      lblNbSitesC.Text = lblNbSitesC.Tag + CompterCoche().ToString();
    }
    //Private Sub cmdCocherTC_Click()
    //
    //Dim i As Integer
    //
    //On Error GoTo handler
    //   
    //  i = 0
    //  For i = 0 To lstCat.ListCount - 1
    //      lstCat.Selected(i) = True
    //  Next
    //  lblNbSitesC = lblNbSitesC.Tag & CompterCoche
    //
    //Exit Sub
    //handler:
    //  ShowError " cmdCocherTC_Click dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private void cmdDecocherTC_Click(object sender, EventArgs e)
    {
      //  Décocher toutes les lignes
      for (int i = 0; i <= (lstCat.Items.Count - 1); i++)
        lstCat.SetItemChecked(i, false);

      lblNbSitesC.Text = lblNbSitesC.Tag + CompterCoche().ToString();
    }
    //Private Sub cmdDecocherTC_Click()
    //Dim i As Integer
    //On Error GoTo handler
    //  i = 0
    //  For i = 0 To lstCat.ListCount - 1
    //      lstCat.Selected(i) = False
    //  Next
    //  lblNbSitesC = lblNbSitesC.Tag & CompterCoche
    //Exit Sub
    //handler:
    //  ShowError " cmdDecocherTC_Click dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private int CompterCoche()
    {
      return lstCat.CheckedItems.Count;
    }
    //Private Function CompterCoche() As Integer
    //
    //Dim i As Integer
    //
    //On Error GoTo handler
    //   
    //  i = 0
    //  NbCoche = 0
    //  For i = 0 To lstCat.ListCount - 1
    //   If lstCat.Selected(i) = True Then
    //    NbCoche = NbCoche + 1
    //   End If
    //  Next
    //  CompterCoche = NbCoche
    //
    //Exit Function
    //handler:
    //  ShowError " CompterCoche dans " & Me.Name
    //End Function

    /* OK --------------------------------------------------------------------------*/
    private void CocherLesCat()
    {
      try
      {
        string sSql;
        // Recherche de la liste des catégories à cocher
        // Si on est en création, on reprend les coches de la gamme client
        // Sinon, on reprend les coches de la gamme site
        if (mstrStatut == "C")
          sSql = "select NGAMTRAMENUM FROM TGAMCLIENT Where NTRACLINUM = " + ((DataRowView)cboType.SelectedItem).Row.ItemArray[1];
        else
          sSql = "select NGAMTRAMENUM from TGAMSITE where NTRASITNUM = " + miNumTrame;

        DataTable dtSite = new DataTable();
        dtSite.Load(ModuleData.ExecuteReader(sSql));
        // Boucle sur tous les n° de gamme
        for (int i = 0; i < dtSite.Rows.Count; i++)
        {
          // Boucle sur les catégories pour rechercher le matching
          for (int j = 0; j < lstCat.Items.Count; j++)
          {
            if (((DataRowView)lstCat.Items[j]).Row.ItemArray[1].ToString() == ((DataRow)dtSite.Rows[i])["NGAMTRAMENUM"].ToString())
              lstCat.SetItemChecked(j, true);
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub CocherLesCat()
    //
    //Dim rsSite As ADODB.Recordset
    //Dim sSQL As String
    //Dim i As Integer
    //
    //On Error GoTo handler
    //
    //   If cboClient.ListIndex = -1 Then
    //    lstCat.Clear
    //    Exit Sub
    //   End If
    //   
    //  ' recherche de la liste des catégories à cocher
    //  ' si on est en création, on reprend les coches de la gamme client
    //  ' sinon, on reprend les coches de la gamme site
    //  Set rsSite = New ADODB.Recordset
    //  If mstrStatut = "C" Then
    //  ' liste des case cochées sur le client
    //    sSQL = "select NGAMTRAMENUM FROM TGAMCLIENT Where NTRACLINUM=" & CboType.ItemData(CboType.ListIndex)
    //  Else
    //    sSQL = "select NGAMTRAMENUM from TGAMSITE where NTRASITNUM = " & miNumTrame
    //  End If
    //  rsSite.Open sSQL, cnx
    //  
    //  ' parcours du recordset et de la listebox
    //  While Not rsSite.EOF
    //    i = 0
    //    For i = 0 To lstCat.ListCount - 1
    //      If lstCat.ItemData(i) = rsSite("NGAMTRAMENUM") Then
    //        lstCat.Selected(i) = True
    //       End If
    //    Next
    //    rsSite.MoveNext
    //  Wend
    //  rsSite.Close
    // 
    //Exit Sub
    //handler:
    //  ShowError " CocherLesSites dans " & Me.Name
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    /* private void lstCat_MouseMove(object sender, MouseEventArgs e)
     {
       lstDet.TopIndex = lstCat.TopIndex;
     }*/
    //Private Sub lstCat_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
    //lstDet.TopIndex = lstCat.TopIndex
    //End Sub

    /* --------------------------------------------------------------------------*/
    //TODO AT : Comment obtenir cette fonction dans le [Design] ?
    //Private Sub lstCat_Scroll()
    //lstDet.TopIndex = lstCat.TopIndex
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private void RemplirListes()
    {
      RemplirListeCategories();
      RemplirListeDetails();
    }
    //Private Sub RemplirListes()
    //  RemplirListeCategories
    //  RemplirListeDetails
    //End Sub

    /* OK --------------------------------------------------------------------------*/
    private string RechercheContrat()
    {
      string ret = "";
      string sSQL = "SELECT TREF_TYPECONTRAT.VTYPECONTRAT, TGAMCLIENT.NTYPECONTRAT  FROM TGAMCLIENT INNER JOIN TREF_TYPECONTRAT "
                  + " ON TREF_TYPECONTRAT.NTYPECONTRAT = TGAMCLIENT.NTYPECONTRAT WHERE NTRACLINUM = " + ((DataRowView)cboType.SelectedItem).Row.ItemArray[1]
                  + " AND LANGUE = '" + MozartParams.Langue + "'";
      using (SqlDataReader dr = new SqlCommand(sSQL, MozartDatabase.cnxMozart).ExecuteReader())
      {
        if (dr.Read())
        {
          ret = dr[0].ToString();
          txtContrat.Tag = dr[1];
        }
        dr.Close();
      }
      return ret;
    }

    //Private Function RechercheContrat() As String
    //
    //Dim RsFou As ADODB.Recordset
    //Dim sSQL As String
    //On Error GoTo handler
    //  
    //  Set RsFou = New ADODB.Recordset
    //  sSQL = "SELECT TREF_TYPECONTRAT.VTYPECONTRAT, TGAMCLIENT.NTYPECONTRAT  FROM TGAMCLIENT INNER JOIN TREF_TYPECONTRAT "
    //  sSQL = sSQL & " ON TREF_TYPECONTRAT.NTYPECONTRAT = TGAMCLIENT.NTYPECONTRAT WHERE NTRACLINUM = " & CboType.ItemData(CboType.ListIndex)
    //  sSQL = sSQL & " AND LANGUE = '" & gstrLangue & "'"
    //  
    //  RsFou.Open sSQL, cnx
    //  
    //  If Not RsFou.EOF Then RechercheContrat = RsFou(0)
    //  txtContrat.Tag = RsFou(1)
    //  
    //  RsFou.Close
    // 
    //Exit Function
    //handler:
    //  ShowError " RechercheContrat dans " & Me.Name
    //End Function
  }
}