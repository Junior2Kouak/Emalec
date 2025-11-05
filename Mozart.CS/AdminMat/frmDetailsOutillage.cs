using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmDetailsOutillage : Form
  {
    public string mstrStatut = "";
    public long miNumOut = 0;

    DataTable dtSec = new DataTable();
    string strStatut = "";
    string strRepImage = "";
    string strImage = "";

    bool bPBHover = false; //quand un toolTip doit s'afficher sur la pictureBox

    //Public mstrStatut As String
    //Public miNumOut As Long

    //Dim iTextBoxDate As Integer
    //Dim rsPri As ADODB.Recordset
    //Dim rsSec As ADODB.Recordset
    //Dim strStatut As String
    //Dim mRepertoireDoc As String

    //Dim strImage As String

    //Dim imgX As Integer
    //Dim ImgY As Integer
    //Dim ImgH As Integer
    //Dim ImgW As Integer

    public frmDetailsOutillage()
    {
      InitializeComponent();
    }

    /* OK ---------------------------------------------------------------------------------------------------*/
    private void frmDetailsOutillage_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);
        strStatut = "";

        //Recherche du répertoire de sauvegarde des images sur le serveur
        strRepImage = Utils.RechercheParam("REP_FOURNITURES");

        string sSql = "select NPERNUM, VPERNOM + ' ' + VPERPRE AS nomPre  from TPER WHERE VSOCIETE = App_Name() AND CPERACTIF='O' order by VPERNOM";
        cboPer.Init(MozartDatabase.cnxMozart, sSql, "NPERNUM", "nomPre", new List<string>() { Resources.col_Num, Resources.col_Nom }, 150, 550, true);

        //Traitement du cas de modification ou de création
        if (mstrStatut == "C")
          OuvertureEnCreation();
        else
        {
          OuvertureEnModification();
          InitApigrid();

          apiTGrid1_SelectionChanged(null, null);
        }

        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    //Private Sub Form_Load()
    //
    //On Error GoTo handler
    //
    //  InitBoutons Me, frmMenu
    //  strStatut = ""
    //  
    //  imgX = Image1.Left
    //  ImgY = Image1.Top
    //  ImgH = Image1.height
    //  ImgW = Image1.width
    //
    //  ' recherche du répertoire de sauvegarde des images sur le serveur
    //  mRepertoireDoc = RechercheParam("REP_FOURNITURES")
    //    
    //  CboPer.Clear
    //
    //#If MULTI Then
    //  RemplirCombo CboPer, "select NPERNUM, VPERNOM + ' ' + VPERPRE  from TPER WHERE VSOCIETE = App_Name() AND CPERACTIF='O' order by VPERNOM"
    //#Else
    //  RemplirCombo CboPer, "select NPERNUM, VPERNOM + ' ' + VPERPRE  from TPER WHERE  CPERACTIF='O' order by VPERNOM"
    //#End If
    //  
    //  ' traitement du cas de modification ou de création
    //  If Me.mstrStatut = "C" Then
    //    OuvertureEnCreation
    //  Else
    //    OuvertureEnModification
    //    InitApigrid
    //    apiTGrid1.Init rsSec
    //    apiTGrid1_RowColChange
    //  End If
    //  
    //  Screen.MousePointer = vbDefault
    //  
    //Exit Sub
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub

    private void loadApiTgrid()
    {
      string sqlSec = "select  NOUTINUM, TOUTILLAGELIGNE.NOUTNUM, TOUTILLAGELIGNE.VOUTQUICRE, DOUTDSOR, VOUTQUI, VOUTOU, DOUTDENT, VOUTQUICREENT, DOUTDENTPREV from TOUTILLAGELIGNE INNER JOIN TOUTILLAGE ON TOUTILLAGELIGNE.NOUTNUM = TOUTILLAGE.NOUTNUM WHERE TOUTILLAGELIGNE.NOUTNUM = " + miNumOut + " ORDER BY NOUTINUM desc ";
      apiTGrid1.LoadData(dtSec, MozartDatabase.cnxMozart, sqlSec);
      apiTGrid1.GridControl.DataSource = dtSec;
    }

    /*OK ---------------------------------------------------------------------------------------------------*/
    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    //Private Sub cmdFermer_Click()
    //  Unload Me
    //End Sub

    /* OK ---------------------------------------------------------------------------------------------------*/
    private void cmdEnregistrer_Click(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        if (txtFou.Text == "")
        {
          MessageBox.Show(Resources.msg_SaisirLibelleMat, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          Cursor.Current = Cursors.Default;
          return;
        }

        Enregistrer();
        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    //Private Sub cmdEnregistrer_Click()
    // 
    //On Error GoTo handler
    //
    //  Screen.MousePointer = vbHourglass
    //        
    //  If txtFou = "" Then
    //    MsgBox "§Saisissez un libellé de matériel§", vbInformation
    //    Screen.MousePointer = vbDefault
    //    Exit Sub
    //  End If
    //  
    //  Enregistrer
    //  Screen.MousePointer = vbDefault
    //Exit Sub
    //handler:
    //  ShowError "cmdEnregistrer_Click dans " & Me.Name
    //End Sub

    // ---------------------------------------------------------------------------------------------------

    /* OK ---------------------------------------------------------------------------------------------------*/
    private void cmdAjouter_Click(object sender, EventArgs e)
    {
      if (miNumOut == 0)
      {
        MessageBox.Show(Resources.msg_EnrgMatAvantSaisieSort, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      strStatut = "C";

      cboPer.Enabled = true;
      cboPer.SetText("");
      txtChantier.Text = "";
      txtDateA1.Text = DateTime.Now.ToShortDateString();
      txtDateA2.Text = "";
      txtDateA3.Text = "";
    }

    //Private Sub cmdAjouter_Click()
    //  If miNumOut = 0 Then
    //    Exit Sub
    //  End If
    //  
    //  strStatut = "C"
    //  CboPer.ListIndex = -1
    //  CboPer.Enabled = True
    //  txtChantier = ""
    //  txtDateA(1) = Date
    //  txtDateA(2) = ""
    //  txtDateA(3) = ""
    //End Sub

    /* OK ---------------------------------------------------------------------------------------------------*/

    private void cmdValider_Click(object sender, EventArgs e)
    {
      string SQL = "";
      try
      {
        if (miNumOut == 0) return;

        if (cboPer.GetText() == "")
        {
          MessageBox.Show(Resources.msg_SelectUser, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        if (txtDateA1.Text == "")
          txtDateA2.Text = DateTime.Now.ToShortDateString();

        if (txtDateA3.Text == "")
        {
          MessageBox.Show(Resources.msg_datRetourObligatoire, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        //Création
        if (strStatut == "C")
        {

          if (txtDateA2.Text == "")
          {
            SQL += $"Insert into TOUTILLAGELIGNE(VOUTQUI, NOUTNUM, DOUTDSOR, VOUTOU, VOUTQUICRE, DOUTDENTPREV, DOUTDENT) Values('" +
            $"{cboPer.GetText().Replace("'", "''")} ' , {miNumOut}" +
            $" , '{txtDateA1.Text}' , '{txtChantier.Text.Replace("'", "''")}' , dbo.GetUserName(),'{txtDateA3.Text}', null )";
          }

          else
          {
            SQL += $"Insert into TOUTILLAGELIGNE(VOUTQUI, NOUTNUM, DOUTDSOR, VOUTOU, DOUTDENT, DOUTDENTPREV, VOUTQUICRE, VOUTQUICREENT) Values('" +
            $"{cboPer.GetText().Replace("'", "''")}' , {miNumOut}" +
            $" , '{txtDateA1.Text}' , '{txtChantier.Text.Replace("'", "''")}' , '{txtDateA2.Text}', '{txtDateA3.Text}', dbo.GetUserName(), dbo.GetUserName())";
          }

          ModuleData.ExecuteNonQuery(SQL);
        }
        else
        { //en modification
          SQL += $"UPDATE TOUTILLAGELIGNE set VOUTOU = '{txtChantier.Text.Replace("'", "''")}'," +
          $" VOUTQUI = '{cboPer.GetText().Replace("'", "''")}'," +
          $" DOUTDSOR = '{txtDateA1.Text}'," +
          $" DOUTDENTPREV = '{txtDateA3.Text}',";

          if (txtDateA2.Text == "")
            SQL += " DOUTDENT = null ";
          else
          {
            SQL += $" DOUTDENT = '{txtDateA2.Text}'," +
            $"VOUTQUICREENT = dbo.GetUserName()  ";
          }

          DataRow currentRow = apiTGrid1.GetFocusedDataRow();
          SQL += $" WHERE NOUTINUM = {currentRow["NOUTINUM"]}";

          try
          {
            ModuleData.ExecuteNonQuery(SQL);
          }
          catch (Exception)
          {
            MessageBox.Show(Resources.msg_ImpFaireModifEnrgExistant, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          }
        }

        loadApiTgrid();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    //Private Sub cmdValider_Click()
    //
    //Dim sSQL As String
    //On Error GoTo handler
    //If miNumOut = 0 Then Exit Sub
    //
    //  If CboPer.Text = "" Then
    //    MsgBox "§Sélectionnez un utilisateur§", vbInformation
    //    Exit Sub
    //  End If
    //
    //  If txtDateA(1).Text = "" Then txtDateA(2).Text = Date
    //  
    //  If txtDateA(3).Text = "" Then
    //    MsgBox "§Date de retour prévue obligatoire§", vbInformation
    //    Exit Sub
    //  End If
    //
    //  ' Creation
    //  If strStatut = "C" Then
    //    If txtDateA(2) = "" Then
    //      sSQL = "Insert into TOUTILLAGELIGNE (VOUTQUI, NOUTNUM, DOUTDSOR,  VOUTOU, VOUTQUICRE, DOUTDENTPREV, DOUTDENT ) Values ( '"
    //      sSQL = sSQL & Replace(CboPer.Text, "'", "''") & "' , " & miNumOut
    //      sSQL = sSQL & " , '" & txtDateA(1) & "' , '" & Replace(txtChantier, "'", "''") & "' , dbo.GetUserName() ,'" & txtDateA(3) & "',   Null  )"
    //    Else
    //      sSQL = "Insert into TOUTILLAGELIGNE (VOUTQUI, NOUTNUM, DOUTDSOR,  VOUTOU, DOUTDENT, DOUTDENTPREV, VOUTQUICRE,VOUTQUICREENT) Values ( '"
    //      sSQL = sSQL & Replace(CboPer.Text, "'", "''") & "' , " & miNumOut
    //      sSQL = sSQL & " , '" & txtDateA(1) & "' , '" & Replace(txtChantier, "'", "''") & "' , '" & txtDateA(2) & "', '" & txtDateA(3) & "' , dbo.GetUserName(), dbo.GetUserName())"
    //    End If
    //    On Error Resume Next
    //    cnx.Execute sSQL
    //  Else  ' en  modification
    //    sSQL = "UPDATE TOUTILLAGELIGNE set VOUTOU = '" & Replace(txtChantier, "'", "''") & "', "
    //    sSQL = sSQL + " VOUTQUI = '" & Replace(CboPer.Text, "'", "''") & "', "
    //    sSQL = sSQL + " DOUTDSOR = '" & txtDateA(1) & "', "
    //    sSQL = sSQL + " DOUTDENTPREV = '" & txtDateA(3) & "', "
    //    If txtDateA(2) = "" Then
    //      sSQL = sSQL + " DOUTDENT = null "
    //    Else
    //      sSQL = sSQL + " DOUTDENT = '" & txtDateA(2) & "', "
    //      sSQL = sSQL + " VOUTQUICREENT =  dbo.GetUserName()  "
    //    End If
    //    sSQL = sSQL + " WHERE NOUTINUM = " & rsSec("NOUTINUM")
    //    On Error Resume Next
    //    cnx.Execute sSQL
    //    If Err Then MsgBox "§Impossible de faire la modification car l'enregistrement existe déjà§"
    //  End If
    //  
    //  rsPri.Requery
    //  
    //  ' Lier le datagrid avec le recordset secondaire
    //  Set rsSec = rsPri("ChildCMD").UnderlyingValue
    //
    //  apiTGrid1.Init rsSec, True
    //Exit Sub
    //Resume
    //handler:
    //  ShowError "cmdValider_Click dans " & Me.Name
    //End Sub

    /* OK ---------------------------------------------------------------------------------------------------*/
    DateTime _curDate = DateTime.MinValue;
    private void cmdDate_Click(object sender, EventArgs e)
    {
      Button btn = sender as Button;
      Calendar1.Tag = btn.Tag;

      string txtDate = "";
      if ((sender as Button).Name == "cmdDate1")
      {
        txtDate = txtDateA0.Text;
        Calendar1.Tag = 0;
      }
      else
      {
        txtDate = txtDateA1.Text;
        Calendar1.Tag = 1;
      }
      switch ((sender as Button).Name)
      {
        case "cmdDate1":
          txtDate = txtDateA0.Text;
          Calendar1.Tag = 0;
          break;
        case "cmdDate2":
          txtDate = txtDateA1.Text;
          Calendar1.Tag = 1;
          break;
        case "cmdDate3":
          txtDate = txtDateA2.Text;
          Calendar1.Tag = 2;
          break;
        case "cmdDate4":
          txtDate = txtDateA3.Text;
          Calendar1.Tag = 3;
          break;
        case "cmdDate5":
          txtDate = txtDateA4.Text;
          Calendar1.Tag = 4;
          break;
        case "cmdDate6":
          txtDate = txtDateA5.Text;
          Calendar1.Tag = 5;
          break;
        default:
          return;
      }
      DateTime d;
      if (DateTime.TryParse(txtDate, out d))
        _curDate = Calendar1.Value = d;
      else { _curDate = DateTime.MinValue; Calendar1.Value = DateTime.Now; }

      Calendar1.Visible = true;
      Calendar1.ShowCalendar(new MouseEventArgs(MouseButtons.Left, 1, MousePosition.X - this.Location.X, MousePosition.Y - this.Location.Y, 0));
    }
    /* OK --------------------------------------------------------------------------------------- */
    private void Calendar1_CloseUp(object sender, EventArgs e)
    {
      Calendar1.Visible = false;
      if (_curDate == DateTime.MinValue) return;
      switch (Calendar1.Tag)
      {
        case 0:
          txtDateA0.Text = Calendar1.Value.ToShortDateString();
          break;
        case 1:
          txtDateA1.Text = Calendar1.Value.ToShortDateString();
          break;
        case 2:
          txtDateA2.Text = Calendar1.Value.ToShortDateString();
          break;
        case 3:
          txtDateA3.Text = Calendar1.Value.ToShortDateString();
          break;
        case 4:
          txtDateA4.Text = Calendar1.Value.ToShortDateString();
          break;
        case 5:
          txtDateA5.Text = Calendar1.Value.ToShortDateString();
          break;
        default:
          break;
      }
    }
    private void Calendar1_ValueChanged(object sender, EventArgs e)
    {
      if (Calendar1.Visible) _curDate = Calendar1.Value;
    }
    //Private Sub Calendar1_Click()
    //  Me.txtDateA(iTextBoxDate) = Calendar1.value
    //  Calendar1.Visible = False
    //End Sub

    //Private Sub cmdDate1_Click()
    //  iTextBoxDate = 0
    //  If Calendar1.Visible Then
    //    Calendar1.Visible = False
    //  Else
    //    Calendar1.Visible = True
    //    Calendar1.value = Now
    //  End If
    //End Sub
    //Private Sub cmdDate2_Click()
    //  iTextBoxDate = 1
    //  If Calendar1.Visible Then
    //    Calendar1.Visible = False
    //  Else
    //    Calendar1.Visible = True
    //    Calendar1.value = Now
    //  End If
    //End Sub
    //Private Sub cmdDate3_Click()
    //  iTextBoxDate = 2
    //  If Calendar1.Visible Then
    //    Calendar1.Visible = False
    //  Else
    //    Calendar1.Visible = True
    //    Calendar1.value = Now
    //  End If
    //End Sub
    //Private Sub cmdDate4_Click()
    //  iTextBoxDate = 3
    //  If Calendar1.Visible Then
    //    Calendar1.Visible = False
    //  Else
    //    Calendar1.Visible = True
    //    Calendar1.value = Now
    //  End If
    //End Sub
    //Private Sub cmdDate5_Click()
    //  iTextBoxDate = 4
    //  If Calendar1.Visible Then
    //    Calendar1.Visible = False
    //  Else
    //    Calendar1.Visible = True
    //    Calendar1.value = Now
    //  End If
    //End Sub
    //Private Sub cmdDate6_Click()
    //  iTextBoxDate = 5
    //  If Calendar1.Visible Then
    //    Calendar1.Visible = False
    //  Else
    //    Calendar1.Visible = True
    //    Calendar1.value = Now
    //  End If
    //End Sub

    /* OK ---------------------------------------------------------------------------------------------------*/
    private void cmdSupp1_Click(object sender, EventArgs e)
    {
      txtDateA0.Text = "";
    }

    //Private Sub cmdSupp1_Click()
    //  txtDateA(0) = ""
    //End Sub

    /* OK ---------------------------------------------------------------------------------------------------*/
    private void cmdSupp3_Click(object sender, EventArgs e)
    {
      txtDateA2.Text = "";
    }

    //Private Sub CmdSupp3_Click()
    //  txtDateA(2) = ""
    //End Sub

    /* OK ---------------------------------------------------------------------------------------------------*/
    private void cmdSupp4_Click(object sender, EventArgs e)
    {
      txtDateA3.Text = "";
    }

    //Private Sub cmdSupp4_Click()
    //  txtDateA(3) = ""
    //End Sub

    /* OK ---------------------------------------------------------------------------------------------------*/
    private void cmdSupp5_Click(object sender, EventArgs e)
    {
      txtDateA4.Text = "";
    }

    //Private Sub cmdSupp5_Click()
    //  txtDateA(4) = ""
    //End Sub

    /* OK ---------------------------------------------------------------------------------------------------*/
    private void cmdSupp6_Click(object sender, EventArgs e)
    {
      txtDateA5.Text = "";
    }

    //Private Sub cmdSupp6_Click()
    //  txtDateA(5) = ""
    //End Sub

    /* OK ---------------------------------------------------------------------------------------------------*/
    private void OuvertureEnCreation()
    {
      try
      {
        lblCreateur.Text = "";
        lblModif.Text = "";
        strImage = "";
        txtDateA0.Text = "";
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    //Private Sub OuvertureEnCreation()
    //
    //On Error GoTo handler
    //      
    //  lblCreateur.Caption = ""
    //  lblModif.Caption = ""
    //  strImage = ""
    //  txtDateA(0) = ""
    //  Exit Sub
    //  
    //handler:
    //  ShowError "OuvertureEnCreation dans " & Me.Name
    //End Sub

    // ---------------------------------------------------------------------------------------------------

    /* OK ---------------------------------------------------------------------------------------------------*/
    private void OuvertureEnModification()
    {

      try
      {
        //recherche des informations de l'action
        string sql = "SELECT (select top 1 VFOUIMG from TFOUIMG with(nolock) where TFOUIMG.NFOUNUM=TFOU.NFOUNUM order by NFOUIMGNUM DESC) as VFOUIMG,* " +
                "FROM TOUTILLAGE, TFOU " +
                "WHERE TOUTILLAGE.NFOUNUM = TFOU.NFOUNUM AND NOUTNUM = " + miNumOut;

        using (SqlDataReader sdr = ModuleData.ExecuteReader(sql))
        {

          if (sdr.Read())
          {
            txtMarque.Text = Utils.BlankIfNull(sdr["VFOUMAR"]);
            txtType.Text = Utils.BlankIfNull(sdr["VFOUTYP"]);
            txtRef.Text = Utils.BlankIfNull(sdr["VFOUREF"]);
            txtDateA0.Text = Utils.DateBlankIfNull(sdr["DOUTDETAL"]);
            txtNum.Text = Utils.BlankIfNull(sdr["VOUTNUMERO"]);
            txtEmplacement.Text = Utils.BlankIfNull(sdr["VOUTEMPL"]);
            txtDateA4.Text = Utils.DateBlankIfNull(sdr["DOUTPROCHETAL"]);
            txtDateA5.Text = Utils.DateBlankIfNull(sdr["DOUTGARANTIE"]);
            txtSerie.Text = Utils.BlankIfNull(sdr["VOUTSERIE"]);

            txtFou.Text = Utils.BlankIfNull(sdr["VFOUMAT"]);
            txtFou.Tag = Utils.ZeroIfNull(sdr["NFOUNUM"]);

            lblCreateur.Text = $"{Utils.BlankIfNull(sdr["VOUTQUICRE"])} le {Utils.BlankIfNull(sdr["DOUTDCRE"])}";
            lblModif.Text = $"{Utils.BlankIfNull(sdr["VOUTQUIMOD"])} le {Utils.BlankIfNull(sdr["DOUTDMOD"])}";

            ChkEtalonnageMag.Checked = Convert.ToBoolean(Utils.ZeroIfNull(sdr["BETALMAG"])) ? true : false;
            ChkOutAEtal.Checked = Convert.ToBoolean(Utils.ZeroIfNull(sdr["BETALAFAIRE"])) ? true : false;

            if (sdr["VFOUMAT"].ToString() != "" && sdr["VFOUIMG"].ToString() != "")
            {
              strImage = strRepImage + sdr["VFOUIMG"].ToString();
              AfficheImg(strImage);
            }
            else
              strImage = "";
          }
          sdr.Close();
        }
        //TB SAMSIC CITY SHAPE

        //Lier le datagrid avec le recordset secondaire
        loadApiTgrid();

        //En modification pas de motif de la fourniture 
        cmdRechercheFou.Enabled = false;
        ColorBtn();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    //Private Sub OuvertureEnModification()
    // 
    //Dim pRS As ADODB.Recordset
    //Dim db As Connection
    //
    //On Error GoTo handler
    //  
    //  ' 'recherche des informations de l'action
    //  Set pRS = New ADODB.Recordset
    //  pRS.Open "SELECT (select top 1 VFOUIMG from TFOUIMG with(nolock) where TFOUIMG.NFOUNUM=TFOU.NFOUNUM order by NFOUIMGNUM DESC) as VFOUIMG,* " & _
    //            "FROM TOUTILLAGE, TFOU " & _
    //            "WHERE TOUTILLAGE.NFOUNUM = TFOU.NFOUNUM AND NOUTNUM = " & miNumOut, cnx
    //
    //  txtMarque = BlankIfNull(pRS("VFOUMAR"))
    //  txtType = BlankIfNull(pRS("VFOUTYP"))
    //  txtRef = BlankIfNull(pRS("VFOUREF"))
    //  txtDateA(0) = BlankIfNull(pRS("DOUTDETAL"))
    //  txtNum = BlankIfNull(pRS("VOUTNUMERO"))
    //  txtEmplacement = BlankIfNull(pRS("VOUTEMPL"))
    //  txtDateA(4) = BlankIfNull(pRS("DOUTPROCHETAL"))
    //  txtDateA(5) = BlankIfNull(pRS("DOUTGARANTIE"))
    //  txtSerie = BlankIfNull(pRS("VOUTSERIE"))
    //  
    //  On Error Resume Next
    //  txtFou = BlankIfNull(pRS("VFOUMAT"))
    //  txtFou.Tag = ZeroIfNull(pRS("NFOUNUM"))
    //    
    //  lblCreateur.Caption = BlankIfNull(pRS("VOUTQUICRE")) & " le " & BlankIfNull(pRS("DOUTDCRE"))
    //  lblModif.Caption = BlankIfNull(pRS("VOUTQUIMOD")) & " le " & BlankIfNull(pRS("DOUTDMOD"))
    //     
    //  If pRS("VFOUIMG") <> "" And Not IsNull(pRS("VFOUIMG")) Then
    //    strImage = mRepertoireDoc & pRS("VFOUIMG")
    //    AfficheImg Me, Image1, strImage, imgX, ImgY, ImgW, ImgH
    //  Else
    //    strImage = ""
    //  End If
    //  
    //  Set db = New Connection
    //  db.CursorLocation = adUseClient
    //  db.Open gstrConnectionSA
    //  
    //  Set rsPri = New ADODB.Recordset
    //  ' TB SAMSIC CITY SHAPE
    //  rsPri.Open "SHAPE {select NOUTNUM from TOUTILLAGE WHERE NOUTNUM=" & miNumOut & "} AS ParentCMD APPEND ({select NOUTINUM, NOUTNUM, VOUTQUICRE, DOUTDSOR, VOUTQUI, VOUTOU, DOUTDENT, VOUTQUICREENT, DOUTDENTPREV from TOUTILLAGELIGNE Order by NOUTINUM desc} AS ChildCMD RELATE NOUTNUM TO NOUTNUM) AS ChildCMD", db, adOpenStatic, adLockOptimistic
    //
    //  ' Lier le datagrid avec le recordset secondaire
    //  Set rsSec = rsPri("ChildCMD").UnderlyingValue
    //  
    //  ' en modification pas de modif de la fourniture
    //  cmdRechercheFou.Enabled = False
    //    ColorBtn
    //    
    //Exit Sub
    //handler:
    //  ShowError "OuvertureEnModification dans " & Me.Name
    //End Sub

    /* OK ---------------------------------------------------------------------------------------------------*/
    private void InitApigrid()
    {
      try
      {
        apiTGrid1.AddColumn("numOut", "NOUTINUM", 0);
        apiTGrid1.AddColumn("numFou", "NOUTNUM", 0);
        apiTGrid1.AddColumn(Resources.col_createurS, "VOUTQUICRE", 1400, "", 0, true);
        apiTGrid1.AddColumn(Resources.col_D_sortie, "DOUTDSOR", 1250, "dd/MM/yy", 2);
        apiTGrid1.AddColumn(Resources.col_utilisateur, "VOUTQUI", 1800, "", 0, true);
        apiTGrid1.AddColumn(Resources.col_chantier, "VOUTOU", 2000, "", 0, true);
        apiTGrid1.AddColumn(Resources.col_dRetour, "DOUTDENT", 1300, "dd/MM/yy", 2);
        apiTGrid1.AddColumn(Resources.col_createurE, "VOUTQUICREENT", 1250, "", 0, true);

        apiTGrid1.FilterBar = false;

        apiTGrid1.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    //Private Sub InitApigrid()
    // 
    //On Error GoTo handler
    //  
    //  apiTGrid1.AddColumn "numOut", "NOUTINUM", 0
    //  apiTGrid1.AddColumn "numFou", "NOUTNUM", 0
    //  apiTGrid1.AddColumn "§Créateur S§", "VOUTQUICRE", 1400
    //  apiTGrid1.AddColumn "§D Sortie§", "DOUTDSOR", 1250, "dd/mm/yy", 2
    //  apiTGrid1.AddColumn "§Utilisateur§", "VOUTQUI", 1800
    //  apiTGrid1.AddColumn "§Chantier§", "VOUTOU", 2000
    //  apiTGrid1.AddColumn "§D Retour§", "DOUTDENT", 1300, "dd/mm/yy", 2
    //  apiTGrid1.AddColumn "§Créateur E§", "VOUTQUICREENT", 1250
    //  
    //  ' Tooltip sur des cellules
    //  apiTGrid1.AddCellTip "VOUTOU", &HFDF0DA            ' Tip = contenu de la cellule entière   ' Vert pale
    //  apiTGrid1.AddCellTip "VOUTQUICRE", &HFDF0DA            ' Tip = contenu de la cellule entière   ' Vert pale
    //  apiTGrid1.AddCellTip "VOUTQUICREENT", &HFDF0DA            ' Tip = contenu de la cellule entière   ' Vert pale
    //  apiTGrid1.AddCellTip "VOUTQUI", &HFDF0DA            ' Tip = contenu de la cellule entière   ' Vert pale
    //  
    //  apiTGrid1.FilterBar = False
    //  
    //Exit Sub
    //handler:
    //  ShowError "InitApigrid dans " & Me.Name
    //End Sub

    /* OK ---------------------------------------------------------------------------------------------------*/
    private void Enregistrer()
    {
      try
      {
        using (SqlCommand cmd = new SqlCommand("api_sp_CreationOutillage", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);    // liste des paramètres

          //  liste des paramètres
          cmd.Parameters["@iNum"].Value = miNumOut;
          cmd.Parameters["@iNumFour"].Value = txtFou.Tag;
          cmd.Parameters["@numero"].Value = txtNum.Text;

          if (txtDateA0.Text == "")
            cmd.Parameters["@DateEtal"].Value = DBNull.Value;
          else
            cmd.Parameters["@DateEtal"].Value = Convert.ToDateTime(txtDateA0.Text).ToShortDateString();

          cmd.Parameters["@Emplacement"].Value = txtEmplacement.Text;

          if (txtDateA4.Text == "")
            cmd.Parameters["@DateProchEtal"].Value = DBNull.Value;
          else
            cmd.Parameters["@DateProchEtal"].Value = Convert.ToDateTime(txtDateA4.Text).ToShortDateString();


          if (txtDateA5.Text == "")
            cmd.Parameters["@DateGarantie"].Value = DBNull.Value;
          else
            cmd.Parameters["@DateGarantie"].Value = Convert.ToDateTime(txtDateA5.Text).ToShortDateString();

          cmd.Parameters["@serie"].Value = txtSerie.Text;
          cmd.Parameters["@BETALMAG"].Value = ChkEtalonnageMag.Checked == true ? 1 : 0;
          cmd.Parameters["@BETALAFAIRE"].Value = ChkOutAEtal.Checked == true ? 1 : 0;

          cmd.ExecuteNonQuery();
          miNumOut = (int)cmd.Parameters[0].Value;
        }
        //Dispose();

        // on passe la feuille en statut modifier
        mstrStatut = "M";

        OuvertureEnModification();

      }
      catch (Exception ex)
      {
        Cursor = Cursors.Default;
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    //Public Sub Enregistrer()
    //
    //Dim ado_cmd As New ADODB.Command
    //Dim ado_rs As New ADODB.Recordset
    //
    //On Error GoTo handler
    //
    //' pour la création ou la modification, c'est la proc stock qui gère
    //
    //  ' création d'une commande
    //  Set ado_cmd.ActiveConnection = cnx
    //  
    //  ' passage du nom de la procédure stockée
    //  ado_cmd.CommandText = "api_sp_CreationOutillage"
    //  ado_cmd.CommandType = adCmdStoredProc
    //  
    //  ' passage des paramètres
    //  ado_cmd.Parameters.Refresh
    //    
    //   ' liste des paramètres
    //  ado_cmd.Parameters("@iNum").value = miNumOut
    //  ado_cmd.Parameters("@iNumFour").value = txtFou.Tag
    //  ado_cmd.Parameters("@numero").value = txtNum
    //  ado_cmd.Parameters("@DateEtal").value = IIf(txtDateA(0) = "", Null, txtDateA(0))
    //  ado_cmd.Parameters("@Emplacement").value = txtEmplacement
    //  ado_cmd.Parameters("@DateProchEtal").value = IIf(txtDateA(4) = "", Null, txtDateA(4))
    //  ado_cmd.Parameters("@DateGarantie").value = IIf(txtDateA(5) = "", Null, txtDateA(5))
    //  ado_cmd.Parameters("@serie").value = txtSerie
    //  
    //  Set ado_rs = ado_cmd.Execute()
    //  miNumOut = ado_cmd.Parameters(0).value
    //  Set ado_cmd = Nothing
    //  
    //  ' on passe la feuille en statut modifier
    //  Me.mstrStatut = "M"
    //   
    //  Call OuvertureEnModification
    //  apiTGrid1.Init rsSec, True
    //
    //Exit Sub
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "Enregistrer dans " & Me.Name
    //End Sub

    /* OK ---------------------------------------------------------------------------------------------------*/
    private void Image1_DoubleClick(object sender, EventArgs e)
    {
      if (Image1.Tag.ToString() == "OK")
      {
        frmxVisuImg f = new frmxVisuImg();
        f.msImage = strImage;
        f.ShowDialog();
      }
    }

    //Private Sub Image1_DblClick()
    //  If Image1.Tag = "OK" Then
    //    frmxVisuImg.mstrImage = strImage
    //    frmxVisuImg.Show vbModal
    //  End If
    //End Sub

    /* OK ---------------------------------------------------------------------------------------------------*/

    private void apiTGrid1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
    {
      if (miNumOut == 0) return;

      if (dtSec.Rows.Count > 0)
      {

        DataRow currentRow = apiTGrid1.GetFocusedDataRow();
        string VOUTQUI = currentRow["VOUTQUI"].ToString().TrimEnd();
        bool bIn = false;
        foreach (DataRow r in (cboPer.DataSource() as DataTable).Rows)
          if (r["nomPre"].ToString().TrimEnd() == VOUTQUI) bIn = true;
        if (!bIn)
        {
          DataRow r = (cboPer.DataSource() as DataTable).NewRow();
          r["nomPre"] = VOUTQUI;
          (cboPer.DataSource() as DataTable).Rows.Add(r);
        }
        cboPer.SetText(currentRow["VOUTQUI"].ToString().TrimEnd());

        txtChantier.Text = Utils.BlankIfNull(currentRow["VOUTOU"]);
        txtDateA2.Text = Utils.DateBlankIfNull(currentRow["DOUTDENT"]);
        txtDateA1.Text = Utils.DateBlankIfNull(currentRow["DOUTDSOR"]);
        txtDateA3.Text = Utils.DateBlankIfNull(currentRow["DOUTDENTPREV"]);
        cboPer.Enabled = false;
        strStatut = "M";
      }
      else
      {
        if (miNumOut == 0)
        {
          MessageBox.Show(Resources.msg_EnrMatSaisirSortie, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }
        strStatut = "C";

        cboPer.Enabled = true;
        txtChantier.Text = "";
        txtDateA1.Text = "";
        txtDateA2.Text = "";
        txtDateA3.Text = "";
      }
    }

    //Private Sub apiTGrid1_RowColChange()
    //
    //If miNumOut = 0 Then Exit Sub
    //  
    //  If rsSec.RecordCount > 0 Then
    //      On Error Resume Next
    //      CboPer.Text = rsSec("VOUTQUI")
    //      If Err Then
    //        CboPer.AddItem rsSec("VOUTQUI")
    //      End If
    //      
    //      txtChantier = BlankIfNull(rsSec("VOUTOU"))
    //      txtDateA(2) = BlankIfNull(rsSec("DOUTDENT"))
    //      txtDateA(1) = BlankIfNull(rsSec("DOUTDSOR"))
    //      txtDateA(3) = BlankIfNull(rsSec("DOUTDENTPREV"))
    //      CboPer.Enabled = False
    //      strStatut = "M"
    //  Else
    //  If miNumOut = 0 Then
    //    MsgBox "§Enregistrer le matériel avant de saisir une sortie§", vbInformation
    //    Exit Sub
    //  End If
    //  
    //    strStatut = "C"
    //    CboPer.ListIndex = -1
    //    CboPer.Enabled = True
    //    txtChantier = ""
    //    txtDateA(1) = ""
    //    txtDateA(2) = ""
    //    txtDateA(3) = ""
    //  End If
    //End Sub

    /* OK ---------------------------------------------------------------------------------------------------*/

    private void cmdRechercheFou_Click(object sender, EventArgs e)
    {
      frmApiRecherche f = new frmApiRecherche(MozartDatabase.cnxMozart);
      f.msSql = "select TFOU.NFOUNUM, VFOUMAT, VFOUMAR, VFOUTYP  from TFOU where  CFOUACTIF='O' order by VFOUMAT";
      f.ShowDialog();

      if (f.msRetour != "")
      {
        txtFou.Text = f.msRetour;
        txtFou.Tag = f.mlItemData;


        string sql = $"SELECT (select top 1 VFOUIMG from TFOUIMG where TFOUIMG.NFOUNUM=TFOU.NFOUNUM order by NFOUIMGNUM DESC) as VFOUIMG,* " +
                  $"FROM TFOU " +
                  $"WHERE NFOUNUM = {txtFou.Tag}";

        using (SqlDataReader sdrFou = ModuleData.ExecuteReader(sql))
        {

          if (sdrFou.Read())
          {
            txtMarque.Text = Utils.BlankIfNull(sdrFou["VFOUMAR"].ToString());
            txtType.Text = Utils.BlankIfNull(sdrFou["VFOUTYP"].ToString());
            txtRef.Text = Utils.BlankIfNull(sdrFou["VFOUREF"].ToString());

            if (sdrFou["VFOUIMG"].ToString() != "" && !(sdrFou["VFOUIMG"] == null))
              strImage = strRepImage + sdrFou["VFOUIMG"].ToString();
            else
              strImage = "";
          }
          sdrFou.Close();
        }

        AfficheImg(strImage);
      }
    }

    //Private Sub cmdRechercheFou_Click()
    //Dim rsFou As ADODB.Recordset
    //
    //    frmApiRecherche.msSql = "select TFOU.NFOUNUM, VFOUMAT, VFOUMAR,VFOUTYP  from TFOU where  CFOUACTIF='O' order by VFOUMAT"
    //    frmApiRecherche.Show vbModal
    //    If frmApiRecherche.msRetour <> "" Then
    //      txtFou = frmApiRecherche.msRetour
    //      txtFou.Tag = frmApiRecherche.mlItemData
    //      
    //      Set rsFou = New ADODB.Recordset
    //
    //      rsFou.Open "SELECT (select top 1 VFOUIMG from TFOUIMG where TFOUIMG.NFOUNUM=TFOU.NFOUNUM order by NFOUIMGNUM DESC) as VFOUIMG,* " & _
    //                  "FROM TFOU " & _
    //                  "WHERE NFOUNUM = " & txtFou.Tag, cnx
    //
    //      txtMarque = BlankIfNull(rsFou("VFOUMAR"))
    //      txtType = BlankIfNull(rsFou("VFOUTYP"))
    //      txtRef = BlankIfNull(rsFou("VFOUREF"))
    //      
    //      If rsFou("VFOUIMG") <> "" And Not IsNull(rsFou("VFOUIMG")) Then
    //          strImage = mRepertoireDoc & rsFou("VFOUIMG")
    //      Else
    //          strImage = ""
    //      End If
    //      AfficheImg Me, Image1, strImage, imgX, ImgY, ImgW, ImgH
    //    End If
    //End Sub

    /* OK ---------------------------------------------------------------------------------------------------*/
    private void ColorBtn()
    {
      int iNbDoc = (int)ModuleData.ExecuteScalarInt($"SELECT COUNT(*) AS NB_DOC FROM TOUT_DOC WHERE TOUT_DOC.VTYPE_OUT = 'OUT_COLL' AND TOUT_DOC.NID_OUT = {miNumOut}");

      if (iNbDoc > 0)
        cmdOutillageDoc.BackColor = Color.FromArgb(251, 255, 83);
    }

    //Private Sub ColorBtn()
    //    
    //    Dim rsBtn As New ADODB.Recordset
    //    rsBtn.Open "SELECT COUNT(*) AS NB_DOC FROM TOUT_DOC WHERE TOUT_DOC.VTYPE_OUT = 'OUT_COLL' AND TOUT_DOC.NID_OUT = " & miNumOut, cnx
    //    
    //    If rsBtn("NB_DOC") > 0 Then
    //        cmdOutillageDoc.BackColor = &H80FFFF
    //    Else
    //        cmdOutillageDoc.BackColor = &H8000000F
    //    End If
    //    rsBtn.Close
    //End Sub

    /* OK ---------------------------------------------------------------------------------------------------*/

    private void cmdOutillageDoc_Click(object sender, EventArgs e)
    {
      if (miNumOut == 0) return;

      using (frmOutillageDocGest f = new frmOutillageDocGest())
      {
        f.miID_OUT = miNumOut;
        f.msVTYPE_OUT = "OUT_COLL";
        f.ShowDialog();
      }
      ColorBtn();
    }

    //Private Sub cmdOutillageDoc_Click()
    //
    //    If miNumOut = 0 Then Exit Sub
    //    
    //    Dim oFrmOutillageDocGest As New frmOutillageDocGest
    //    oFrmOutillageDocGest.iID_OUT = miNumOut
    //    oFrmOutillageDocGest.sVTYPE_OUT = "OUT_COLL"
    //    oFrmOutillageDocGest.Show vbModal
    //    
    //    Set oFrmOutillageDocGest = Nothing
    //    ColorBtn
    //End Sub

    public void AfficheImg(string strFile)
    {

      // réglages des valeurs servant au calcul
      int Lmax = Image1.Width - 70;
      int Hmax = Image1.Height - 70;

      Image i = Image.FromFile(strFile);

      double ratio = (double)Lmax / Hmax;
      // ratio de base à obtenir pour rentrer correctement dans la picturebox

      double ratioImage = (double)i.Width / i.Height;
      // ratio de l'image d'origine
      double Flng = i.Width;
      // largeur de l'image d'origine
      double Fht = i.Height;

      // hauteur de l'image d'origine
      if (Flng > Lmax || Fht > Hmax)

      // si l'image est plus grande d'une quelconque longueur
      {
        if (Flng > Lmax) // si la longueur est plus longue
        {
          if (1 > ratioImage) // et si la largueur est plus longue
          {
            Fht = Hmax; // la hauteur prend la hauteur maximale
            if (Flng > i.Height) Flng = Fht / ratioImage; // calcul de la longueur 
            else Flng = Fht * ratioImage; // calcul de la longueur (bis)
          }
          else // seule la largeur est plus longue
          {
            Flng = Lmax; // la largeur prend la largeur maximale
            if (Fht > i.Width) Fht = Flng / ratioImage; // calcul de la hauteur
            else Fht = Flng / ratioImage;
          }
        }
        else // seule la largeur est plus longue
        {
          Fht = Hmax;
          Flng = Fht * ratioImage;
        }
        bPBHover = true;
        Image1.Tag = "OK";
        Image1.Image = Image.FromFile(strFile).GetThumbnailImage(Convert.ToInt32
        (Flng), Convert.ToInt32(Fht), null, IntPtr.Zero); // j'en tire une miniature
      }
      else
      {
        Image1.Image = Image.FromFile(strFile); // sinon j'affiche l'image de base
        bPBHover = true;
        Image1.Tag = "KO";
      }
    }

    private void Image1_MouseHover(object sender, EventArgs e)
    {
      ToolTip tt = new ToolTip();

      if (bPBHover == true && Image1.Tag.ToString() == "OK")
        tt.SetToolTip(Image1, Resources.txt_doubleCliquezImageTailleReelle);

      if (bPBHover == true && Image1.Tag.ToString() == "KO")
        tt.SetToolTip(Image1, Resources.txt_tailleReelle);
    }

    /* Public Sub AfficheImg(F As Form, img As Image, strFile As String, X As Integer, Y As Integer, w As Integer, h As Integer)
 Dim lW As Long
 Dim lH As Long

   If strFile = "" Then
     F.Image1.Picture = Nothing
     F.Image1.Stretch = True
     F.Image1.Left = X
     F.Image1.Top = Y
     F.Image1.height = h
     F.Image1.width = w
     F.Image1.ToolTipText = ""
     F.Image1.Tag = "KO"
   Else
     F.Image1.Picture = LoadPicture(strFile)
     'traitement taille image
     F.Image1.Stretch = False
     If F.Image1.height > h Or F.Image1.width > w Then
       If F.Image1.height > h Then
         lH = h
         lW = F.Image1.width * h / F.Image1.height
       ElseIf F.Image1.width > w Then
         lW = w
         lH = F.Image1.height * w / F.Image1.width
       End If
       F.Image1.Stretch = True
       F.Image1.height = lH
       F.Image1.width = lW
       F.Image1.Tag = "OK"
       F.Image1.ToolTipText = "§DoubleCliquez pour voir l'image en taille réelle§"
     Else
       F.Image1.Stretch = False
       F.Image1.ToolTipText = "§Taille réelle§"
       F.Image1.Tag = "KO"
     End If
   End If
 End Sub*/
  }
}