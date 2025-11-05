using DevExpress.XtraGrid.Views.Grid;
using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using ReportEmalec.Net;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmSaisieStock : Form
  {
    public long iNumBL;
    public string mstrSite;
    public string mstrTech;
    public bool bModif;

    bool bCombo;
    bool bPremierCommand1 = true;
    bool bPremierInitialiserFeuille = true;
    bool bPremierInitRecord = true;

    DataTable dtArticle = new DataTable();
    DataTable dtLocal = new DataTable();
    DataTable dtAux;

    public frmSaisieStock() { InitializeComponent(); }

    private void frmSaisieStock_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);
        //25/08/2021 : La bouton   ne doit pas s’afficher, il faut supprimer le TAG de ce bouton
        cmdRechercher.Visible = false;

        bCombo = false;

        //modification impossible si le BL a été traité
        //frameSearch.Enabled = bModif;
        cmdListerCdes.Enabled = bModif;
        cmdValider.Enabled = bModif;
        btSupLigne.Enabled = bModif;
        if (bModif)
          grdDataGrid.GridControl.KeyUp += new KeyEventHandler(grdDataGrid_KeyUp);

        InitialiserFeuille();
        apiTgrid.btnExcel.Visible = apiTgrid.btnPrint.Visible = apiTgrid.chkColumnsList.Visible = false;
        apiTGrid1.btnExcel.Visible = apiTGrid1.btnPrint.Visible = apiTGrid1.chkColumnsList.Visible = false;

        cmdCmd.Visible = false;
        txtCmd.Visible = false;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      try
      {
        if (dtArticle.Rows.Count == 0)
        {
          MessageBox.Show(Resources.msg_EntrerArticle, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        if (txtDateLiv.Text == "")
        {
          MessageBox.Show(Resources.msg_DefinirDateLivr, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          //cmdDate_Click(null, null);
          return;
        }

        CreationBL();
        InitialiserFeuille();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdFour_Click(object sender, EventArgs e)
    {
      InitFrameRechercheFournisseur();
      frameFournisseur.Visible = true;
    }

    //' recherche des articles de la commande et insertion dans le recordset local
    private void cmdCmd_Click(object sender, EventArgs e)
    {
      try
      {
        if (txtCmd.Text == "")
        {
          MessageBox.Show(Resources.msg_SaisirNumCommande, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          txtCmd.Focus();
          return;
        }

        if (!Utils.IsNumeric(Strings.Left(txtCmd.Text, 1)))
          txtCmd.Text = Strings.Mid(txtCmd.Text, 3);

        //recherche des détails fournitures
        //ajout de NFOUNUM dans le distinct pour gérer le cas ou des fournitures sont nommées identiquement
        using (SqlDataReader sdr = ModuleData.ExecuteReader($"SELECT DISTINCT TLCO.NFOUNUM, VFOUMAT, NLCOQTE, ISNULL(TFOU.VFOUTYP, '') as VFOUTYP, ISNULL(TFOU.VFOUREF, '') as VFOUREF, ISNULL(TFOU.VFOUMAR, '') as VFOUMAR FROM TLCO,TFOU WHERE TLCO.NFOUNUM=TFOU.NFOUNUM AND NCOMNUM = {txtCmd.Text}"))
        {
          while (sdr.Read())
          {
            DataRow newrow = dtArticle.NewRow();
            newrow["Article"] = Utils.BlankIfNull(sdr["VFOUMAT"]);
            newrow["Quantite"] = Utils.ZeroIfNull(sdr["NLCOQTE"]);
            newrow["NFOUNUM"] = Utils.ZeroIfNull(sdr["NFOUNUM"]);
            newrow["Type"] = Utils.BlankIfNull(sdr["VFOUTYP"]);
            newrow["Ref"] = Utils.BlankIfNull(sdr["VFOUREF"]);
            newrow["Marque"] = Utils.BlankIfNull(sdr["VFOUMAR"]);

            dtArticle.Rows.Add(newrow);
          }
        }
        grdDataGrid.GridControl.DataSource = dtArticle;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdVisu_Click(object sender, EventArgs e)
    {
      launchReport("PREVIEW");
    }

    private void cmdImprimer_Click(object sender, EventArgs e)
    {
      launchReport("PRINT");
    }

    private void launchReport(string pOption)
    {
      if (iNumBL == 0)
      {
        MessageBox.Show(Resources.msg_enregisterBL, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      Cursor.Current = Cursors.WaitCursor;

      string sId;
      if (optDest0.Checked)       // TECH
        sId = $"{iNumBL}|T|E";
      else if (optDest1.Checked)  // SITE
        sId = $"{iNumBL}|S|E";
      else                        //  FOURNISSEUR OU SOUS TRAITANT
        sId = $"{iNumBL}|F|E";

      //impression des BL
      new frmMainReport
      {
        bLaunchByProcessStart = false,
        sTypeReport = "TBordereau",
        sIdentifiant = sId,
        InfosMail = "0|0|0",
        sNomSociete = MozartParams.NomSociete,
        sLangue = MozartParams.Langue,
        sOption = pOption
      }.ShowDialog();

      Cursor.Current = Cursors.Default;
    }

    private void Calendar1_CloseUp(object sender, EventArgs e)
    {
      if (Calendar1.Value.DayOfWeek == DayOfWeek.Saturday || Calendar1.Value.DayOfWeek == DayOfWeek.Sunday
          || ModuleMain.IsFeriee(Calendar1.Value))
      {
        MessageBox.Show("La date ne doit pas être un week-end ou un jour férié !", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      if (DateTime.Now.DayOfWeek == DayOfWeek.Friday || DateTime.Now.DayOfWeek == DayOfWeek.Thursday)
      {
        if (Calendar1.Value < DateTime.Now.AddDays(5))
        {
          MessageBox.Show(Resources.msg_dateSupJPlus3 + "(hors week-end)!", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }
      }
      else
      {
        if (Calendar1.Value < DateTime.Now.AddDays(3))
        {
          MessageBox.Show(Resources.msg_dateSupJPlus3 + "!", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }
      }
      txtDateLiv.Text = Calendar1.Value.ToShortDateString();
      Calendar1.Visible = false;
    }

    private void cmdDate_Click(object sender, EventArgs e)
    {
      try
      {
        Calendar1.Visible = !Calendar1.Visible;
        Calendar1.Value = txtDateLiv.Text != "" ? Convert.ToDateTime(txtDateLiv.Text) : DateTime.Now.AddDays(3);

        Calendar1.ShowCalendar(new MouseEventArgs(MouseButtons.Left, 1, MousePosition.X - this.Location.X, MousePosition.Y - this.Location.Y, 0));
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
        dtArticle.Clear();

        using (SqlDataReader sdr = ModuleData.ExecuteReader($"EXEC [api_sp_ListeFournituresBLLibre] {iNumBL}"))
        {
          while (sdr.Read())
          {
            DataRow newrow = dtArticle.NewRow();
            newrow["Article"] = Utils.BlankIfNull(sdr["VLART"]);
            newrow["Quantite"] = Utils.ZeroIfNull(sdr["NLARTQTE"]);
            newrow["NFOUNUM"] = Utils.ZeroIfNull(sdr["NFOUNUM"]);
            newrow["Type"] = Utils.BlankIfNull(sdr["VFOUTYP"]);
            newrow["Ref"] = Utils.BlankIfNull(sdr["VFOUREF"]);
            newrow["Marque"] = Utils.BlankIfNull(sdr["VFOUMAR"]);
            newrow["NCOMNUM"] = Utils.ZeroIfNull(sdr["NCOMNUM"]);

            dtArticle.Rows.Add(newrow);
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void InitialiserFeuille()
    {
      try
      {
        if (bPremierInitRecord)
        {
          InitRecordsetArticle();
          bPremierInitRecord = false;
        }

        using (SqlDataReader drD = ModuleData.ExecuteReader($"api_sp_RetourInfoBE {MozartParams.NumAction}, {iNumBL}")) //2310171
        {
          if (drD.Read())
          {
            txtcli0.Text = Utils.BlankIfNull(drD["VCLINOM"]);
            txtcli1.Text = Utils.ZeroIfNull(drD["NDINCTE"]).ToString();
            txtcli2.Text = drD["DBEDATE"].ToString();
            txtcli3.Text = Utils.BlankIfNull(drD["NBENUM"]);

            txtObjet.Text = Utils.BlankIfNull(drD["VBEOBJET"]);
            txtDateLiv.Text = drD["DBEDATEEXPE"].ToString();

            // si on est en modification ou en création
            if (Utils.BlankIfNull(drD["NBENUM"]) == "0")
            {
              optDest1.Checked = true; //site par défaut
            }
            else
            {
              switch (Utils.BlankIfNull(drD["VBETYPDEST"]))
              {
                case "Personnel":
                  optDest0.Checked = true;
                  break;
                case "Site":
                  optDest1.Checked = true;
                  break;
                case "Sous-traitant":
                  optDest2.Checked = true;
                  break;
                case "Fournisseur":
                  optDest3.Checked = true;
                  txtLivr.Tag = Utils.BlankIfNull(drD["IDEST"].ToString());
                  txtLivr.Text = Utils.BlankIfNull(drD["VSTFNOM"].ToString());
                  break;
                default:
                  break;
              }
              OuvertureEnModification();
            }
            if (bPremierInitialiserFeuille)
            {
              FormatGrid();
              bPremierInitialiserFeuille = false;
            }
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void CreationBL()
    {
      try
      {
        using (SqlCommand cmd = new SqlCommand("api_sp_creationBE", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);
          cmd.Parameters["@iCourrier"].Value = iNumBL;

          if (optDest0.Checked)
            cmd.Parameters["@TypeDest"].Value = "Personnel";
          else if (optDest1.Checked)
            cmd.Parameters["@TypeDest"].Value = "Site";
          else if (optDest2.Checked)
            cmd.Parameters["@TypeDest"].Value = "Sous-traitant";
          else if (optDest3.Checked)
            cmd.Parameters["@TypeDest"].Value = "Fournisseur";

          cmd.Parameters["@iAction"].Value = MozartParams.NumAction;
          cmd.Parameters["@vObjet"].Value = txtObjet.Text;

          cmd.Parameters["@dateLivr"].Value = txtDateLiv.Text == "" ? DBNull.Value : (object)txtDateLiv.Text;

          cmd.Parameters["@iDest"].Value = optDest3.Checked ? txtLivr.Tag : 0;//id du contact fournisseur

          cmd.ExecuteNonQuery();

          iNumBL = (int)cmd.Parameters[0].Value;

          CreationLigneArt(iNumBL);
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void CreationLigneArt(long numBL)
    {
      bool bErreur = false;

      // delete des lignes de commandes dans la table
      ModuleData.ExecuteNonQuery($"delete from TLBLlibre where NLBLNUM= {numBL}");
      // parcours du recordset et création des lignes dans TLBLlibre
      foreach (DataRow dr in dtArticle.Rows)
      {
        try
        {
          ModuleData.CnxExecute($"insert into TLBLlibre (NLBLNUM, NACTNUM, VLART, NLARTQTE, NFOUNUM, NCOMNUM) values ({numBL}, {MozartParams.NumAction}, '{dr["Article"].ToString().Replace("'", "''")}', " +
                                $"{Utils.ZeroIfNull(dr["Quantite"])}, {Utils.ZeroIfNull(dr["NFOUNUM"])}, {Utils.ZeroIfNull(dr["NCOMNUM"])})");
        }
        catch 
        {
          bErreur = true;
        }
      }

      if (bErreur)
      {
        string sMsg = $"Veuillez vérifier la liste des matériels : Chaque matériel doit avoir un libellé différent.{Environment.NewLine}";
        sMsg += "Les matériels en double ont été enlevés.";
        MessageBox.Show(sMsg, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void optDestALL_CheckedChanged(object sender, EventArgs e)
    {
      RadioButton rb = (RadioButton)sender;
      if (rb.Checked == false) return;

      switch (rb.Name)
      {
        case "optDest0":
          txtLivr.Text = mstrTech;
          cmdFour.Visible = false;
          break;

        case "optDest1":
          txtLivr.Text = mstrSite;
          cmdFour.Visible = false;
          break;

        case "optDest2":
          txtLivr.Text = mstrTech;
          cmdFour.Visible = false;
          break;

        case "optDest3":
          txtLivr.Text = mstrTech;
          cmdFour.Visible = true;
          break;
      }
    }

    public void InitRecordsetArticle()
    {
      try
      {
        dtArticle.Columns.Add("Article", Type.GetType("System.String"));
        dtArticle.Columns.Add("Marque", Type.GetType("System.String"));
        dtArticle.Columns.Add("Type", Type.GetType("System.String"));
        dtArticle.Columns.Add("Ref", Type.GetType("System.String"));
        dtArticle.Columns.Add("Quantite", Type.GetType("System.Int32"));
        dtArticle.Columns.Add("NCOMNUM", Type.GetType("System.Int32"));
        dtArticle.Columns.Add("NFOUNUM", Type.GetType("System.Int32"));
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void FormatGrid()
    {
      try
      {
        grdDataGrid.AddColumn(Resources.col_materiel, "Article", 6000);
        grdDataGrid.AddColumn("Marque", "Marque", 1000);
        grdDataGrid.AddColumn("Type", "Type", 1000);
        grdDataGrid.AddColumn("Référence", "Ref", 1000);
        grdDataGrid.AddColumn("Qté", "Quantite", 1000);
        grdDataGrid.AddColumn("N° commande", "NCOMNUM", 1000);
        grdDataGrid.AddColumn("NFOUNUM", "NFOUNUM", 0);

        grdDataGrid.DelockColumn("Article");
        grdDataGrid.DelockColumn("Marque");
        grdDataGrid.DelockColumn("Type");
        grdDataGrid.DelockColumn("Ref");
        grdDataGrid.DelockColumn("Quantite");
        grdDataGrid.DelockColumn("NCOMNUM");

        grdDataGrid.InitColumnList();

        grdDataGrid.dgv.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;

        if (bModif)
        {
          grdDataGrid.dgv.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
          grdDataGrid.dgv.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
        }
        else
          grdDataGrid.dgv.OptionsBehavior.ReadOnly = true;

        grdDataGrid.GridControl.DataSource = dtArticle;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdListerCdes_Click(object sender, EventArgs e)
    {
      apiTgrid.LoadData(dtLocal, MozartDatabase.cnxMozart, $"SELECT DISTINCT 'CF' + cast(TCOM.NCOMNUM AS varchar) AS NUMERO FROM TCOM WHERE CCOMACTIF = 'O' AND TCOM.NACTNUM = {MozartParams.NumAction}");
      apiTgrid.GridControl.DataSource = dtLocal;

      if (bPremierCommand1)
      {
        apiTgrid.AddColumn("Numéro", "NUMERO", 1000);
        apiTgrid.InitColumnList();
        bPremierCommand1 = false;
      }

      Frame2.Visible = true;
    }

    private void cmdEnregistrer_Click(object sender, EventArgs e)
    {
      try
      {
        DataRow currentRow = apiTgrid.GetFocusedDataRow();
        if (currentRow == null) return;
        //recherche dees détails fournitures 
        using (SqlDataReader drD = ModuleData.ExecuteReader($"SELECT DISTINCT TLCO.NFOUNUM, VFOUMAT, NLCOQTE, ISNULL(TFOU.VFOUTYP, '') as VFOUTYP, ISNULL(TFOU.VFOUREF, '') " +
                                                            $"as VFOUREF, ISNULL(TFOU.VFOUMAR, '') as VFOUMAR FROM TLCO,TFOU WHERE TLCO.NFOUNUM=TFOU.NFOUNUM AND NCOMNUM = " +
                                                            $"{Strings.Right(currentRow["NUMERO"].ToString(), currentRow["NUMERO"].ToString().Length - 2)}"))
        {
          while (drD.Read())
          {
            //ajout de l'enregistrement
            DataRow newrow = dtArticle.NewRow();
            newrow["Article"] = Utils.BlankIfNull(drD["VFOUMAT"]);
            newrow["Quantite"] = Utils.ZeroIfNull(drD["NLCOQTE"]);
            newrow["NFOUNUM"] = Utils.ZeroIfNull(drD["NFOUNUM"]);
            newrow["Type"] = Utils.BlankIfNull(drD["VFOUTYP"]);
            newrow["Ref"] = Utils.BlankIfNull(drD["VFOUREF"]);
            newrow["Marque"] = Utils.BlankIfNull(drD["VFOUMAR"]);
            newrow["NCOMNUM"] = Strings.Right(currentRow["NUMERO"].ToString(), currentRow["NUMERO"].ToString().Length - 2);

            dtArticle.Rows.Add(newrow);
          }
        }

        grdDataGrid.GridControl.DataSource = dtArticle;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Frame2.Visible = false; }
    }

    public void InitFrameRechercheFournisseur()
    {
      dtAux = new DataTable();

      apiTGrid1.LoadData(dtAux, MozartDatabase.cnxMozart, $"select nintnum, vstfnom + ' - ' + VINTNOM as VSTFNOM, vstfvil from tstf inner join tint on TINT.NSTFNUM = dbo.TSTF.NSTFNUM where cstfactif='O' AND (CSTFTYP='FO' or CSTFTYP='FT') order by vstfnom, vstfvil");
      apiTGrid1.GridControl.DataSource = dtAux;

      if (!bCombo)
      {
        InitGrid();
        bCombo = true;
      }
    }

    private void InitGrid()
    {
      apiTGrid1.AddColumn(Resources.col_Nom, "VSTFNOM", 2500);
      apiTGrid1.AddColumn(Resources.col_Ville, "vstfvil", 1500);
      apiTGrid1.AddColumn("Num", "nintnum", 0);

      apiTGrid1.InitColumnList();
    }

    private void cmdFermerChoixFourn_Click(object sender, EventArgs e)
    {
      frameFournisseur.Visible = false;
    }

    private void cmdChoixFour_Click(object sender, EventArgs e)
    {
      DataRow currentRow = apiTGrid1.GetFocusedDataRow();
      if (currentRow == null) return;

      txtLivr.Text = currentRow["VSTFNOM"].ToString();
      txtLivr.Tag = currentRow["NINTNUM"].ToString();
    }

    private void btSupLigne_Click(object sender, EventArgs e)
    {
      DataRow row = grdDataGrid.GetFocusedDataRow();
      if (row == null) return;
      grdDataGrid.dgv.DeleteRow(grdDataGrid.dgv.FocusedRowHandle);
    }
    void grdDataGrid_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Delete)
        btSupLigne.PerformClick();
    }
  }
}