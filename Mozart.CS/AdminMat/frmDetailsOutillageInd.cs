using DevExpress.XtraGrid.Views.Grid;
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
  public partial class frmDetailsOutillageInd : Form
  {
    public string mstrStatut = "";
    public long miNumOut = 0;

    DataTable dtSec = new DataTable();
    DataTable dtHisto = new DataTable();
    string strStatut = "";
    string strRepImage = "";
    string strImage = "";

    bool bPBHover = false; //quand un toolTip doit s'afficher sur la pictureBox


    public frmDetailsOutillageInd()
    {
      InitializeComponent();
    }

    private void frmDetailsOutillageInd_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);
        strStatut = "";

        //Recherche du répertoire de sauvegarde des images sur le serveur
        strRepImage = Utils.RechercheParam("REP_FOURNITURES");

        string sSql = "select NPERNUM, VPERNOM + ' ' + VPERPRE AS nomPre  from TPER WHERE VSOCIETE = App_Name() AND CPERACTIF='O' order by VPERNOM";
        CboPer.Init(MozartDatabase.cnxMozart, sSql, "NPERNUM", "nomPre", new List<string>() { Resources.col_Num, Resources.col_Nom }, 150, 550, true);


                InitApigridHistoTolBal();
                //Traitement du cas de modification ou de création
                if (mstrStatut == "C")
          OuvertureEnCreation();
        else
        {
          OuvertureEnModification();
          InitApigrid();
                    

                    apiTGrid1_SelectionChanged(null, null);
        }

        ColorBtn();
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
    //  
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
    //  RemplirCombo CboPer, "select NPERNUM, VPERNOM + ' ' + VPERPRE  from TPER WHERE VSOCIETE = App_Name() AND CPERACTIF='O' order by VPERNOM"
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
    //  ColorBtn
    //  
    //  Screen.MousePointer = vbDefault
    //  
    //Exit Sub
    //Resume
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub
    //
    //

    private void loadApiTGrid()
    {

      string sqlSec = "select TOUTILLAGELIGNEIND.NOUTINDNUM, NOUTINDUTINUM, TOUTILLAGELIGNEIND.VOUTINDQUICRE, DOUTINDDSOR, VOUTINDQUI, VOUTINDOU, DOUTINDDENT, VOUTINDQUICREENT FROM TOUTILLAGELIGNEIND INNER JOIN TOUTILLAGEIND  WITH (nolock) ON TOUTILLAGELIGNEIND.NOUTINDNUM = TOUTILLAGEIND.NOUTINDNUM where TOUTILLAGEIND.NOUTINDNUM = " + miNumOut + " ORDER BY NOUTINDUTINUM desc ";
      apiTGrid1.LoadData(dtSec, MozartDatabase.cnxMozart, sqlSec);
      apiTGrid1.GridControl.DataSource = dtSec;
    }

    private void loadApiTGrid_Histo_Bal()
    {

        string sqlSec = $"EXEC [api_sp_Outillage_Individuel_Histo_Tol_Bal_Load] {miNumOut}";
        apiTGrid_Bal_Tolerance.LoadData(dtHisto, MozartDatabase.cnxMozart, sqlSec);
        apiTGrid_Bal_Tolerance.GridControl.DataSource = dtHisto;
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void cmdAjouter_Click(object sender, EventArgs e)
    {
      if (miNumOut == 0)
      {
        MessageBox.Show(Resources.msg_EnrgMatAvantSaisieSort, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      strStatut = "C";

      CboPer.Enabled = true;
      CboPer.SetText("");
      txtChantier.Text = "";
      txtDateA1.Text = DateTime.Now.ToShortDateString();
      txtDateA2.Text = "";
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      string SQL = "";
      try
      {
        if (miNumOut == 0) return;

        if (CboPer.GetText() == "")
        {
          MessageBox.Show(Resources.msg_SelectUser, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        if (txtDateA1.Text == "")
          txtDateA2.Text = DateTime.Now.ToShortDateString();

        //Création
        if (strStatut == "C")
        {

          if (txtDateA2.Text == "")
          {
            SQL += $"Insert into TOUTILLAGELIGNEIND (VOUTINDQUI, NOUTINDNUM, DOUTINDDSOR,  VOUTINDOU, VOUTINDQUICRE, DOUTINDDENT ) Values ( '" +
            $"{CboPer.GetText().Replace("'", "''")} ' , {miNumOut}" +
            $" , '{txtDateA1.Text}' , '{txtChantier.Text.Replace("'", "''")}' , dbo.GetUserName(), null )";
          }

          else
          {
            SQL += $"Insert into TOUTILLAGELIGNEIND (VOUTINDQUI, NOUTINDNUM, DOUTINDDSOR,  VOUTINDOU, DOUTINDDENT, VOUTINDQUICRE,VOUTINDQUICREENT) Values ( '" +
            $"{CboPer.GetText().Replace("'", "''")}' , {miNumOut}" +
            $" , '{txtDateA1.Text}' , '{txtChantier.Text.Replace("'", "''")}' , '{txtDateA2.Text}',  dbo.GetUserName(), dbo.GetUserName())";
          }

          ModuleData.ExecuteNonQuery(SQL);
        }

        else
        { //en modification
          SQL += $"UPDATE TOUTILLAGELIGNEIND set VOUTINDOU = '{txtChantier.Text.Replace("'", "''")}'," +
          $" VOUTINDQUI = '{CboPer.GetText().Replace("'", "''")}'," +
          $" DOUTINDDSOR = '{txtDateA1.Text}',";

          if (txtDateA2.Text == "")
            SQL += " DOUTINDDENT = null ";
          else
          {
            SQL += $" DOUTINDDENT = '{txtDateA2.Text}'," +
            $"VOUTINDQUICREENT = dbo.GetUserName()  ";
          }

          DataRow currentRow = apiTGrid1.GetFocusedDataRow();
          SQL += $" WHERE NOUTINDUTINUM = {currentRow["NOUTINDUTINUM"]}";

          try
          {
            ModuleData.ExecuteNonQuery(SQL);

            // gestion de la case stock
            int chk = chkStock.Checked == true ? 1 : 0;
            SQL = $"UPDATE TOUTILLAGEIND set BSTOCK = {chk} WHERE NOUTINDNUM = {miNumOut}";
            ModuleData.ExecuteNonQuery(SQL);

          }
          catch (Exception)
          {
            MessageBox.Show(Resources.msg_ImpFaireModifEnrgExistant, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          }
        }

        loadApiTGrid();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

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

    private void cmdSupp1_Click(object sender, EventArgs e)
    {
      txtDateA0.Text = "";
    }

    private void cmdSupp3_Click(object sender, EventArgs e)
    {
      txtDateA2.Text = "";
    }
    private void cmdSupp6_Click(object sender, EventArgs e)
    {
      txtDateA5.Text = "";
    }

    private void cmdSupp5_Click(object sender, EventArgs e)
    {
      txtDateA4.Text = "";
    }

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

    private void OuvertureEnModification()
    {
      try
      {
        //recherche des informations de l'action
        string sql = "EXEC [api_sp_Outillage_Individuel_Load] " + miNumOut.ToString();

        using (SqlDataReader sdr = ModuleData.ExecuteReader(sql))
        {

          if (sdr.Read())
          {
            txtMarque.Text = Utils.BlankIfNull(sdr["VFOUMAR"]);
            txtType.Text = Utils.BlankIfNull(sdr["VFOUTYP"]);
            txtRef.Text = Utils.BlankIfNull(sdr["VFOUREF"]);
            txtNum.Text = Utils.BlankIfNull(sdr["VOUTINDNUMERO"]);
            txtEmplacement.Text = Utils.BlankIfNull(sdr["VOUTINDEMPL"]);
            txtDateA0.Text = Utils.DateBlankIfNull(sdr["DOUTINDDETAL"]);
            txtDateA4.Text = Utils.DateBlankIfNull(sdr["DOUTINDPROCHETAL"]);
            txtDateA5.Text = Utils.DateBlankIfNull(sdr["DOUTGARANTIE"]);
            txtSerie.Text = Utils.BlankIfNull(sdr["VOUTSERIE"]);

            txtFou.Text = Utils.BlankIfNull(sdr["VFOUMAT"]);
            txtFou.Tag = Utils.ZeroIfNull(sdr["NFOUNUM"]);

            lblCreateur.Text = $"{Utils.BlankIfNull(sdr["VOUTINDQUICRE"])} le {Utils.BlankIfNull(sdr["DOUTINDDCRE"])}";
            lblModif.Text = $"{Utils.BlankIfNull(sdr["VOUTINDQUIMOD"])} le {Utils.BlankIfNull(sdr["DOUTINDDMOD"])}";

            ChkEtalonnageMag.Checked = Convert.ToBoolean(Utils.ZeroIfNull(sdr["BETALMAG"])) ? true : false;
            chkStock.Checked = Convert.ToBoolean(Utils.ZeroIfNull(sdr["BSTOCK"])) ? true : false;
            ChkOutAEtal.Checked = Convert.ToBoolean(Utils.ZeroIfNull(sdr["BETALAFAIRE"])) ? true : false;

            GrpTolerance_Balance.Visible = Convert.ToInt32(Utils.ZeroIfNull(sdr["NID_FOU_ETAL_TECH"])) > 0 ? true : false;
            GrpTolerance_Balance.Text = $"{GrpTolerance_Balance.Text} entre {sdr["NMINVALUE"]} g et {sdr["NMAXVALUE"]} g";


            if (sdr["VFOUIMG"].ToString() != "" && sdr["VFOUIMG"].ToString() != "")
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
        loadApiTGrid();

        loadApiTGrid_Histo_Bal();

        //En modification pas de motif de la fourniture sauf si on a les droits
        if (ModuleMain.bAccesBouton("108") == 0)
				{
          cmdRechercheFou.Enabled = false;
        }
        ColorBtn();

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void InitApigrid()
    {
      try
      {
        apiTGrid1.AddColumn("numOut", "NOUTINDUTINUM", 0);
        apiTGrid1.AddColumn("numFou", "NOUTINDNUM", 0);
        apiTGrid1.AddColumn(Resources.col_createurS, "VOUTINDQUICRE", 1250, "", 0, true);
        apiTGrid1.AddColumn(Resources.col_D_sortie, "DOUTINDDSOR", 950, "dd/MM/yy", 2);
        apiTGrid1.AddColumn(Resources.col_utilisateur, "VOUTINDQUI", 1750, "", 0, true);
        apiTGrid1.AddColumn(Resources.col_chantier, "VOUTINDOU", 1600, "", 0, true);
        apiTGrid1.AddColumn(Resources.col_dRetour, "DOUTINDDENT", 1000, "dd/MM/yy", 2);
        apiTGrid1.AddColumn(Resources.col_createurE, "VOUTINDQUICREENT", 1250, "", 0, true);

        apiTGrid1.FilterBar = false;

        apiTGrid1.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

        private void InitApigridHistoTolBal()
        {
            try
            {
                apiTGrid_Bal_Tolerance.AddColumn("Utilisateur", "VPERNOM", 1750, "", 0, true);
                apiTGrid_Bal_Tolerance.AddColumn("Date réception", "DDATESEND", 950, "dd/MM/yy", 2);                
                apiTGrid_Bal_Tolerance.AddColumn("Valeur minimale", "NMINVALUE", 950, "", 2, true);
                apiTGrid_Bal_Tolerance.AddColumn("Saisie", "NVALUE_CREE", 950, "", 2, true);
                apiTGrid_Bal_Tolerance.AddColumn("Valeur maximale", "NMAXVALUE", 950, "", 2, true);
                
                apiTGrid_Bal_Tolerance.FilterBar = false;
        
                apiTGrid_Bal_Tolerance.InitColumnList();
            }
            catch (Exception ex)
            {
                MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
            }
        }

        public void Enregistrer()
    {
      try
      {
        using (SqlCommand cmd = new SqlCommand("api_sp_CreationOutillageIndiv", MozartDatabase.cnxMozart))
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
          cmd.Parameters["@BSTOCK"].Value = chkStock.Checked == true ? 1 : 0;


          cmd.ExecuteNonQuery();
          miNumOut = (int)cmd.Parameters[0].Value;
        }

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

    private void Image1_DoubleClick(object sender, EventArgs e)
    {
      if (Image1.Tag.ToString() == "OK")
      {
        frmxVisuImg f = new frmxVisuImg();
        f.msImage = strImage;
        f.ShowDialog();
      }
    }

      private void apiTGrid1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
    {
      if (miNumOut == 0) return;

      if (dtSec.Rows.Count > 0)
      {

        DataRow currentRow = apiTGrid1.GetFocusedDataRow();

        string VOUTINDQUI = currentRow["VOUTINDQUI"].ToString().TrimEnd();
        bool bIn = false;
        foreach (DataRow r in (CboPer.DataSource() as DataTable).Rows)
          if (r["nomPre"].ToString().TrimEnd() == VOUTINDQUI) bIn = true;
        if (!bIn)
        {
          DataRow r = (CboPer.DataSource() as DataTable).NewRow();
          r["nomPre"] = VOUTINDQUI;
          (CboPer.DataSource() as DataTable).Rows.Add(r);
        }
        CboPer.SetText(VOUTINDQUI);

        txtChantier.Text = Utils.BlankIfNull(currentRow["VOUTINDOU"]);
        txtDateA1.Text = Utils.DateBlankIfNull(currentRow["DOUTINDDSOR"]);
        txtDateA2.Text = Utils.DateBlankIfNull(currentRow["DOUTINDDENT"]);
        CboPer.Enabled = false;
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

        CboPer.Enabled = true;
        txtChantier.Text = "";
        txtDateA1.Text = "";
        txtDateA2.Text = "";
      }
    }

 
    private void cmdRechercheFou_Click(object sender, EventArgs e)
    {
      frmApiRecherche f = new frmApiRecherche(MozartDatabase.cnxMozart);
      f.msSql = "select TFOU.NFOUNUM, VFOUMAT, VFOUMAR,VFOUTYP  from TFOU where  CFOUACTIF='O' order by VFOUMAT";
      f.ShowDialog();

      if (f.msRetour != "")
      {
        txtFou.Text = f.msRetour;
        txtFou.Tag = f.mlItemData;


        string sql = $"SELECT (select top 1 VFOUIMG from TFOUIMG with (nolock) where TFOUIMG.NFOUNUM=TFOU.NFOUNUM order by NFOUIMGNUM DESC) as VFOUIMG,* " +
                  $"FROM TFOU with (nolock) " +
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

        if (strImage != "") { AfficheImg(strImage); };
      }
    }

    //Private Sub cmdRechercheFou_Click()
    //Dim rsFou As adodb.Recordset
    //
    //    frmApiRecherche.msSql = "select TFOU.NFOUNUM, VFOUMAT, VFOUMAR,VFOUTYP  from TFOU where  CFOUACTIF='O' order by VFOUMAT"
    //    frmApiRecherche.Show vbModal
    //    If frmApiRecherche.msRetour <> "" Then
    //      txtFou = frmApiRecherche.msRetour
    //      txtFou.Tag = frmApiRecherche.mlItemData
    //      
    //      Set rsFou = New adodb.Recordset
    //
    //      rsFou.Open "SELECT (select top 1 VFOUIMG from TFOUIMG with (nolock) where TFOUIMG.NFOUNUM=TFOU.NFOUNUM order by NFOUIMGNUM DESC) as VFOUIMG,* " & _
    //                  "FROM TFOU with (nolock) " & _
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
    //    
    //End Sub
    //

    /* OK ---------------------------------------------------------------------*/
    private void cmdOutillageDoc_Click(object sender, EventArgs e)
    {
      if (miNumOut == 0) return;

      using (frmOutillageDocGest f = new frmOutillageDocGest())
      {
        f.miID_OUT = miNumOut;
        f.msVTYPE_OUT = "OUT_IND";
        f.ShowDialog();
      }
      ColorBtn();
    }

    private void ColorBtn()
    {
      int iNbDoc = (int)ModuleData.ExecuteScalarInt($"SELECT COUNT(*) AS NB_DOC FROM TOUT_DOC WHERE TOUT_DOC.VTYPE_OUT = 'OUT_IND' AND TOUT_DOC.NID_OUT = {miNumOut}");

      if (iNbDoc > 0)
        cmdOutillageDoc.BackColor = Color.FromArgb(251, 255, 83);
    }

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

        private void apiTGrid_Bal_Tolerance_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.Column.Name == "NVALUE_CREE")
            {
                e.Appearance.BackColor = Color.Yellow;
                e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
            }
        }

		private void apiButton1_Click(object sender, EventArgs e)
		{
      DataRow row = apiTGrid_Bal_Tolerance.GetFocusedDataRow();
      if (null == row) return;
      txtValeur.Text = row["NVALUE_CREE"].ToString();
      txtNval.Tag = row["NID_OUT_IND_ETAL_HISTO_SERVER"].ToString();
      frameFiliale.Visible = true;
    }

		private void cmdCopieFiliale6_Click(object sender, EventArgs e)
		{
      txtNval.Text = "";
      txtValeur.Text = "";
      frameFiliale.Visible = false;

    }

		private void cmdCopieFiliale0_Click(object sender, EventArgs e)
		{
      // update de la table avec la valeur de la cellule
      ModuleData.ExecuteNonQuery($"update TOUT_IND_ETAL_HISTO SET NVALUE_CREE = {txtNval.EditValue} where NID_OUT_IND_ETAL_HISTO_SERVER = {txtNval.Tag}");
      loadApiTGrid_Histo_Bal();
      txtNval.Text = "";
      txtValeur.Text = "";
      frameFiliale.Visible = false;
    }
  }
}

