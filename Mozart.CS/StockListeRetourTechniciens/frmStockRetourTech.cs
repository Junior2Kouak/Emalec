using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using MZCtrlResources = MozartControls.Properties.Resources;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmStockRetourTech : Form
  {
    public int iNumRetour;
    DataTable dtArticle = new DataTable();

    private bool firstTime = true;

    public frmStockRetourTech() { InitializeComponent(); }

    private void frmStockRetourTech_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        string sSql = $"select NPERNUM, VPERNOM + ' ' + VPERPRE As nompre from TPER where (CPERTYP='TE' OR CPERTYP='CA' OR CPERTYP='BE' OR CPERTYP='CT') " +
                      $"AND {(iNumRetour > 0 ? "VSOCIETE = '" + MozartParams.NomSociete : "CPERACTIF = 'O' AND VSOCIETE = '" + MozartParams.NomSociete)}' ORDER BY  VPERNOM, VPERPRE";

        ModuleData.RemplirCombo(cboTech, sSql);
        cboTech.ValueMember = "NPERNUM";
        cboTech.DisplayMember = "nompre";
        cboTech.SelectedIndex = 0;

        InitRecordsetArticle();

        InitApiGrid();

        // On est en visu sur un retour
        if (iNumRetour > 0)
          InitFormVisu();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void cmdRechercher_Click(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        // affichage de la feuille de recherche des fournitures avec numero de fournisseur si connu
        frmRechercheArticlesCom f = new frmRechercheArticlesCom
        {
          miNumFournisseur = 0,
          m_brechercheSite = false,
          m_bSaisieQte = true,
          mstrClient = "",
          mstrStatut = "",
          m_bAfficheInfoFou = false,
          mdtArticles = dtArticle
        };
        f.ShowDialog();

        dtArticle = f.mdtArticles;

        if (firstTime)
        {
          firstTime = false;
        }
        grdDataGrid.GridControl.DataSource = dtArticle;
        grdDataGrid.Requery(dtArticle, MozartDatabase.cnxMozart);
        // remplir les montants totaux
        RemplirTxtTotaux();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }

      finally { Cursor.Current = Cursors.Default; }
    }

    private void InitApiGrid()
    {
      try
      {
        grdDataGrid.GridControl.DataSource = dtArticle;
        FormatGridArticle();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdVisu_Click(object sender, EventArgs e)
    {
      string[,] TdbGlobal = { { "Now", "" } };
      if (dtArticle.Rows.Count == 0) return;

      frmBrowser f = new frmBrowser();
      f.Preview_Print(MozartParams.CheminModeles + MozartParams.Langue + @"\TRetourTech.rtf",
                      @"TRetourTechOut.rtf",
                      TdbGlobal,
                      $"exec api_sp_ImpRetourTechListFou {iNumRetour}",
                      " (Prévisualisation retour technicien)",
                      "PREVIEW");
    }

    private void cmdImprimer_Click(object sender, EventArgs e)
    {
      string[,] TdbGlobal = { { "Now", "" } };

      frmBrowser f = new frmBrowser();
      f.ImprimerFichier(MozartParams.CheminModeles + MozartParams.Langue + @"\TRetourTech.rtf",
                      @"TRetourTechOut.rtf",
                      TdbGlobal,
                      "exec api_sp_ImpRetourTechListFou " + iNumRetour);
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      try
      {
        if (cboTech.Text == "")
        {
          MessageBox.Show(Resources.msg_sel_tech, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          cboTech.Focus();
          return;
        }
        if (txtDateRetour.Text == "")
        {
          MessageBox.Show(Resources.msg_saisie_date_retour, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          txtDateRetour.Focus();
          return;
        }
        if (dtArticle.Rows.Count == 0)
        {
          MessageBox.Show(Resources.msg_EntrerArticle, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        CreationLignesRetour();

        MessageBox.Show(Resources.msg_entreeStockOK, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        this.Dispose();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void CreationLignesRetour()
    {
      try
      {
        // Recherche d'un nouveau numero de retour
        int numRet = Convert.ToInt32(ModuleData.ExecuteScalarInt("SELECT MAX(NRETNUM) + 1 FROM TSTOCKRETOUR"));

        // Parcours du recordset et création des lignes dans TSTOCK et dans TSTOCKRETOUR
        using (SqlCommand c = new SqlCommand("api_sp_CreationRetourStock", MozartDatabase.cnxMozart))
        {
          foreach (DataRow row in dtArticle.Rows)
          {
            c.CommandType = CommandType.StoredProcedure;
            SqlCommandBuilder.DeriveParameters(c);

            c.Parameters["@nRetNum"].Value = numRet;
            c.Parameters["@nFouNum"].Value = Utils.ZeroIfNull(row["NumArticle"]);
            c.Parameters["@iQte"].Value = Utils.ZeroIfNull(row["Quantite"]);
            c.Parameters["@nPerNum"].Value = cboTech.GetItemData();
            c.Parameters["@dRetour"].Value = txtDateRetour.Text;
            c.Parameters["@vObjet"].Value = txtObjet.Text;

            c.ExecuteNonQuery();
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    DateTime _curDate = DateTime.MinValue;
    private void Cal_CloseUp(object sender, EventArgs e)
    {
      Cal.Visible = false;
      if (_curDate == DateTime.MinValue) return;
      txtDateRetour.Text = Cal.Value.ToShortDateString();
    }
    private void Cal_ValueChanged(object sender, EventArgs e)
    {
      if (Cal.Visible) _curDate = Cal.Value;
    }
    private void cmdDate_Click(object sender, EventArgs e)
    {
      DateTime d;
      if (DateTime.TryParse(txtDateRetour.Text, out d))
        _curDate = Cal.Value = d;
      else { _curDate = DateTime.MinValue; Cal.Value = DateTime.Now; }
      Cal.Visible = true;
      Cal.ShowCalendar(new MouseEventArgs(MouseButtons.Left, 1, MousePosition.X - this.Location.X, MousePosition.Y - this.Location.Y, 0));
    }

    public void InitRecordsetArticle()
    {
      try
      {
        dtArticle.Columns.Add("Serie", typeof(string));
        dtArticle.Columns.Add("Article", typeof(string));
        dtArticle.Columns.Add("Marque", typeof(string));
        dtArticle.Columns.Add("Type", typeof(string));
        dtArticle.Columns.Add("Reference", typeof(string));
        dtArticle.Columns.Add("PCB", typeof(int));
        dtArticle.Columns.Add("Prix U", typeof(double));
        dtArticle.Columns.Add("VFOUEMPLACEMENT", typeof(string));
        dtArticle.Columns.Add("Quantite", typeof(int));
        dtArticle.Columns.Add("Prix T", typeof(double));
        dtArticle.Columns.Add("Fournisseur", typeof(string));
        dtArticle.Columns.Add("NumArticle", typeof(int));
        dtArticle.Columns.Add("NumFour", typeof(int));
        dtArticle.Columns.Add("NumSiteFour", typeof(int));
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void FormatGridArticle()
    {
      try
      {
        grdDataGrid.AddColumn(MZCtrlResources.col_Serie, "Serie", 800);
        grdDataGrid.AddColumn(Resources.col_materiel, "Article", 4900);
        grdDataGrid.AddColumn(Resources.col_marque, "Marque", 830);
        grdDataGrid.AddColumn(Resources.col_Type, "Type", 1200);
        grdDataGrid.AddColumn(Resources.col_Ref, "Reference", 800, "", 0);
        grdDataGrid.AddColumn(Resources.col_pcb, "PCB", 1000, "", 2);
        grdDataGrid.AddColumn(Resources.col_prix_U, "Prix U", 900, "## ##0.00", 1);
        grdDataGrid.AddColumn(Resources.col_Emplacement, "VFOUEMPLACEMENT", 1000);
        grdDataGrid.AddColumn(Resources.col_qte3, "Quantite", 1000, "", 2);
        grdDataGrid.AddColumn(Resources.col_prixT, "Prix T", 0);
        grdDataGrid.AddColumn(Resources.col_four, "Fournisseur", 0);
        grdDataGrid.AddColumn(Resources.col_num_four, "NumArticle", 0);
        grdDataGrid.AddColumn(Resources.col_NumArticle, "NumFour", 0);
        grdDataGrid.AddColumn(Resources.col_NumSiteFour, "NumSiteFour", 0);

        grdDataGrid.DelockColumn("Quantite");

        grdDataGrid.InitColumnList();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void RemplirTxtTotaux()
    {
      try
      {
        txtHT.Tag = 0;

        //TODO VL: pourquoi passer par la propriété Tag ? -> Ca me semble être le plus logique pour stocker une valeur
        foreach (DataRow row in dtArticle.Rows)
          txtHT.Tag = Convert.ToDouble(txtHT.Tag) + Utils.ZeroIfNull(Convert.ToDouble(row["Prix U"])) * Utils.ZeroIfNull(Convert.ToDouble(row["Quantite"]));

        txtHT.Text = Convert.ToDouble(txtHT.Tag).ToString("C");
        txtTVA.Text = (Convert.ToDouble(txtHT.Tag) * MozartParams.TVA1 / 100).ToString("C");
        txtTTC.Text = (Convert.ToDouble(txtHT.Tag) + Convert.ToDouble(txtHT.Tag) * MozartParams.TVA1 / 100).ToString("C");
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void InitFormVisu()
    {

      string sSql = $"SELECT VFOUSER, VFOUMAT, VFOUMAR, VFOUTYP, VFOUREF, NFOUNBLOT, FSTOCKPUHT, NSTOCKQTE, NPERNUM , DRETOUR, VCOMMENT, VFOUEMPLACEMENT";
      sSql += " FROM TSTOCK";
      sSql += " INNER JOIN TFOU ON TFOU.NFOUNUM = TSTOCK.NFOUNUM";
      sSql += $" INNER JOIN TSTOCKRETOUR ON TSTOCKRETOUR.NSTOCKNUM = TSTOCK.NSTOCKNUM";
      sSql += $" INNER JOIN TFOUSTE ON TFOUSTE.NFOUNUM = TFOU.NFOUNUM AND TFOUSTE.VSOCIETE = '{MozartParams.NomSociete}'";
      sSql += $" WHERE TSTOCKRETOUR.NRETNUM = {iNumRetour}";

      using (SqlDataReader drArtVisu = ModuleData.ExecuteReader(sSql))
      {
        if (drArtVisu.Read())
        {
          cboTech.SetItemData((drArtVisu["npernum"]).ToString());
          txtDateRetour.Text = drArtVisu["DRETOUR"].ToString();
          txtObjet.Text = drArtVisu["VCOMMENT"].ToString();

          do
          {
            DataRow newrow = dtArticle.NewRow();

            newrow["Serie"] = drArtVisu["VFOUSER"];
            newrow["Article"] = drArtVisu["VFOUMAT"];
            newrow["Marque"] = drArtVisu["VFOUMAR"];
            newrow["Type"] = drArtVisu["VFOUTYP"];
            newrow["Reference"] = drArtVisu["VFOUREF"];
            newrow["PCB"] = drArtVisu["NFOUNBLOT"];
            newrow["Prix U"] = drArtVisu["FSTOCKPUHT"];
            newrow["VFOUEMPLACEMENT"] = drArtVisu["VFOUEMPLACEMENT"];
            newrow["Quantite"] = drArtVisu["NSTOCKQTE"];

            dtArticle.Rows.Add(newrow);
          } while (drArtVisu.Read());
        }
      }

      cmdValider.Enabled = cmdDate.Enabled = cmdRechercher.Enabled = cboTech.Enabled = false;

      RemplirTxtTotaux();
    }

    private void cmdRetourTech_Click(object sender, EventArgs e)
    {
      if (cboTech.Text == "")
      {
        MessageBox.Show("Choisissez d'abord un technicien dans la liste...", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      try
      {
        // Recherche d'un nouveau numero de retour
        using (SqlDataReader drR = ModuleData.ExecuteReader($"api_sp_RetourTech2 {cboTech.GetItemData()}"))
        {
          dtArticle.Clear();

          while (drR.Read())
          {
            DataRow newrow = dtArticle.NewRow();

            newrow["Serie"] = drR["VFOUSER"];
            newrow["Article"] = drR["art"];
            newrow["Marque"] = Utils.BlankIfNull(drR["VFOUMAR"]);
            newrow["Type"] = Utils.BlankIfNull(drR["VFOUTYP"]);
            newrow["Reference"] = Utils.BlankIfNull(drR["VFOUREF"]);
            newrow["PCB"] = Utils.ZeroIfNull(drR["NFOUNBLOT"]);
            newrow["Prix U"] = Utils.ZeroIfNull(drR["Prix U"]);
            newrow["VFOUEMPLACEMENT"] = Utils.BlankIfNull(drR["VFOUEMPLACEMENT"]);
            newrow["Quantite"] = drR["Quantite"];
            newrow["Prix T"] = Utils.ZeroIfNull(drR["PrixT"]);
            newrow["Fournisseur"] = Utils.BlankIfNull(drR["Fournisseur"]);
            newrow["NumArticle"] = drR["NumArticle"];
            newrow["NumFour"] = drR["NumFour"];
            newrow["NumSiteFour"] = drR["NumSiteFour"];

            dtArticle.Rows.Add(newrow);
          }
        }

        RemplirTxtTotaux();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
  }
}