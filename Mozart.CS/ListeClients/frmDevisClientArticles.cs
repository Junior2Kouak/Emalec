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
  public partial class frmDevisClientArticles : Form
  {
    public int miNumDI;           // <-- MozartParams.NumDI
    public int miNumAction;       // <-- MozartParams.NumAction
    public int miNumDevis;
    public int miNumClient;
    public double iCoefNuiDimArt; // variable contenant coef pour les nuit et dimanches

    public DataTable mdtArticles;  // à passer en paramètre
    public List<TextBox> lstFields;

    bool bModif = false;

    public frmDevisClientArticles() { InitializeComponent(); }

    private void frmDevisClientArticles_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        InitPage();
        InitApiTgrid2();

        chkNuit.Text = chkNuit.Text.Replace("2.5", iCoefNuiDimArt.ToString());

        txtTauxHeures.TextChanged += new EventHandler(this.txtNbr_TextChanged);
        txtNbrHeures.TextChanged += new EventHandler(this.txtNbr_TextChanged);
        txtNbrDep.TextChanged += new EventHandler(this.txtNbr_TextChanged);
        txtTauxDep.TextChanged += new EventHandler(this.txtNbr_TextChanged);

        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void InitFields()
    {
      txtFields0.Text = lstFields[0].Text;
      txtFields1.Text = lstFields[1].Text;
      txtFields2.Text = lstFields[2].Text;
      txtFields3.Text = lstFields[3].Text;
      txtFields4.Text = lstFields[4].Text;
      txtFields5.Text = lstFields[5].Text;
      txtFields6.Text = lstFields[6].Text;
      txtFields7.Text = lstFields[7].Text;
      txtFields8.Text = lstFields[8].Text;
      txtFields9.Text = lstFields[9].Text;
      txtFields10.Text = lstFields[10].Text;
      txtFields11.Text = lstFields[11].Text;
    }

    private void InitPage()
    {
      InitFields();
      ChargesArticles();
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      // on teste avant si des prix mini de FO ont été dépassé dans ce quantitatif
      foreach (DataRow row in mdtArticles.Rows)
      {
        if (Utils.BlankIfNull(row["Prix Client"]) == "")
          if (Utils.ZeroIfNull(row["Quantite"]) > 0)
          {
            if (Utils.Is_OK_PrixMiniFourniture(Convert.ToInt32(row["NumArticle"]), Convert.ToDouble(row["Prix T"]) / Convert.ToDouble(row["Quantite"]), row["Article"].ToString()) == false)
              return;
          }
      }

      ValiditeDateLastPrixFourniture();
      CreationLignesArticlesDevis();

      // Maj du devis dans la table TDCL
      string sAstreinte = "";
      if (chkJour.Checked)
        sAstreinte = "N";
      else if (chkNonPublic.Checked)
        sAstreinte = "P";
      else if (chkNuit.Checked)
        sAstreinte = "O";
      else
        sAstreinte = "N";

      string sSql = $"UPDATE TDCL SET NHRTAUX = {Utils.ZeroIfNull(txtTauxHeures.Text).ToString().Replace(",", ".")}, NDEPTAUX={Utils.ZeroIfNull(txtTauxDep.Text).ToString().Replace(",", ".")}";
      sSql += ", NHEURESNB = " + Utils.ZeroIfNull(txtNbrHeures.Text) + ", NDEPNB = " + Utils.ZeroIfNull(txtNbrDep.Text);
      sSql += ", CASTREINTE = '" + sAstreinte + "'";
      sSql += ", BDETAILFOU = " + Convert.ToInt32(chkDetailFou.Checked);
      sSql += ", NDCLQUATHT = " + txtHTtot.Tag.ToString().Replace(",", ".") + " WHERE NDCLNUM = " + miNumDevis;
      ModuleData.ExecuteNonQuery(sSql);

      bModif = false;
    }

    private void ValiditeDateLastPrixFourniture()
    {
      try
      {
        foreach (DataRow row in mdtArticles.Rows)
          if (Utils.BlankIfNull(row["Date prix"]) != "")
            if (Convert.ToDateTime(row["Date prix"]) < DateTime.Now.AddYears(-2))
            {
              MessageBox.Show("Attention, vous avez au moins un prix d'achat de fourniture qui date de plus de 2 ans.\r\nVous devez reconsulter ce prix et remettre la base MOZART à jour",
                              Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              break;
            }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdImprimer_Click(object sender, EventArgs e)
    {
      if (mdtArticles.Rows.Count == 0)
      {
        MessageBox.Show(Resources.msg_selection_article, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      string[,] TdbGlobal = { { "NHEURES", txtNbrHeures.Text + "  heure(s)  à  " + txtTauxHeures.Text },
                              { "NDEP" , txtNbrDep.Text + "  déplacement(s)  à  " + txtTauxDep.Text } ,
                              { "ASTR" , chkNuit.Checked ? "OUI" : "NON" },
                              { "TOT" , (Convert.ToDouble(txtHTDep.Tag) + Convert.ToDouble(txtHTHeure.Tag)).ToString("C2") },
                              { "TOTAL" , Convert.ToDouble(txtHTtot.Tag).ToString("C2") } };

      new frmBrowser().ImprimerFichier(MozartParams.CheminModeles + MozartParams.Langue + @"\TDevisClientArticles.rtf",
                                       @"TDevisClientArticles.Out.rtf",
                                       TdbGlobal,
                                       $"exec api_sp_ImpDevisClientArticles {miNumDevis}");
    }

    private void cmdVisu_Click(object sender, EventArgs e)
    {
      try
      {
        if (mdtArticles.Rows.Count == 0)
        {
          MessageBox.Show(Resources.msg_selection_article, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        string[,] TdbGlobal = { { "NHEURES", txtNbrHeures.Text + "  heure(s)  à  " + txtTauxHeures.Text },
                              { "NDEP" , txtNbrDep.Text + "  déplacement(s)  à  " + txtTauxDep.Text } ,
                              { "ASTR" , chkNuit.Checked ? "OUI" : "NON" },
                              { "TOT" , (Convert.ToDouble(txtHTDep.Tag) + Convert.ToDouble(txtHTHeure.Tag)).ToString("C2") },
                              { "TOTAL" , Convert.ToDouble(txtHTtot.Tag).ToString("C2") } };

        frmBrowser f = new frmBrowser();
        f.mstrType = $"DC{miNumDevis}";
        f.Preview_Print(MozartParams.CheminModeles + MozartParams.Langue + @"\TDevisClientArticles.rtf",
                        @"TDevisClientArticles.Out.rtf",
                        TdbGlobal,
                        $"exec api_sp_ImpDevisClientArticles {miNumDevis}",
                        " (Visualisation devis client)",
                        "PREVIEW");
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void ChargesArticles()
    {
      try
      {
        mdtArticles = new DataTable();
        apiTGrid2.LoadData(mdtArticles, MozartDatabase.cnxMozart, $"api_sp_RetourArticlesDevis {miNumDevis}");

        mdtArticles.Columns["Quantite"].ReadOnly = false;
        mdtArticles.Columns["NFOUCOEFF"].ReadOnly = false;
        mdtArticles.Columns["Prix Client"].ReadOnly = false;
        mdtArticles.Columns["Prix T"].ReadOnly = false;

        DataColumn col = new DataColumn("PRIXVENTE2MOIS");
        mdtArticles.Columns.Add(col);

        foreach (DataRow row in mdtArticles.Rows)
        {
          row["PRIXVENTE2MOIS"] = RecherchePrixV2Mois(Convert.ToInt32(row["NumArticle"]));
          row["Quantite"] = row["QuantiteDevis"];
        }

        string sSql = "SELECT C.NCLICONTHOR AS NCLIHOR, C.NCLICONTDEP AS NCLIDEP FROM TCLIPRIXTYPCONT C WITH (NOLOCK), TACT A WITH (NOLOCK), TSIT S WITH (NOLOCK), TDIN D WITH (NOLOCK)"
                    + $" WHERE S.NCLINUM = C.NCLINUM AND S.NSITNUM = A.NSITNUM AND S.VSITPAYS = C.VPAYS AND A.NACTNUM = {miNumAction} AND D.NDINNUM = A.NDINNUM AND C.NTYPECONTRAT = D.NTYPECONTRAT";
        using (SqlDataReader drB = ModuleData.ExecuteReader(sSql))
        {
          if (drB.Read())
            using (SqlDataReader drA = ModuleData.ExecuteReader($"SELECT NHRTAUX, NDEPTAUX, NHEURESNB, NDEPNB, CASTREINTE, BDETAILFOU FROM TDCL WHERE NDCLNUM = {miNumDevis}"))
            {
              if (drA.Read())
              {
                if (drA["CASTREINTE"].ToString() == "O")
                {
                  chkJour.Checked = false;
                  chkNonPublic.Checked = false;
                  chkNuit.Checked = true;
                }
                else if (drA["CASTREINTE"].ToString() == "P")
                {
                  chkJour.Checked = false;
                  chkNuit.Checked = false;
                  chkNonPublic.Checked = true;
                }
                else
                {
                  chkJour.Checked = true;
                  chkNonPublic.Checked = chkNuit.Checked = false;
                }

                txtTauxDep.Text = Utils.ZeroIfNull(drA["NDEPTAUX"]).ToString();

                if (txtTauxDep.Text == "")
                  txtTauxDep.Text = Utils.BlankIfNull(drB["NCLIDEP"]).ToString();

                if (txtTauxDep.Text == "")
                  txtTauxDep.Text = "68";

                txtTauxHeures.Text = Utils.ZeroIfNull(drA["NHRTAUX"]).ToString();

                if (txtTauxHeures.Text == "")
                  txtTauxHeures.Text = Utils.ZeroIfNull(drB["NCLIHOR"]).ToString();
                if (txtTauxHeures.Text == "")
                  txtTauxHeures.Text = "48";

                txtNbrDep.Text = Utils.ZeroIfNull(drA["NDEPNB"]).ToString();
                txtNbrHeures.Text = Utils.ZeroIfNull(drA["NHEURESNB"]).ToString();

                chkDetailFou.Checked = Utils.ZeroIfNull(drA["BDETAILFOU"]) == 1 ? true : false;

                // remplir les montants totaux
                RemplirTxtTotaux();
                CalculTotal();
              }
            }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdRechercher_Click(object sender, EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        new frmRechercheArticles
        {
          miNumDi = miNumDI,
          miNumAction = miNumAction,
          miNumClient = miNumClient,
          mdtArticles = mdtArticles,
          msNomClient = txtFields0.Text
        }.ShowDialog();

        RemplirTxtTotaux();
        CalculTotal();
        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void CreationLignesArticlesDevis()
    {
      try
      {
        //  delete des lignes d'articles pour ce devis
        ModuleData.ExecuteNonQuery($"DELETE from TLDCL where NDCLNUM = {miNumDevis}");

        //parcours du recordset et création des lignes dans TDCL
        foreach (DataRow row in mdtArticles.Rows)
        {
          using (SqlCommand cmd = new SqlCommand("api_sp_CreationLigneDevis", MozartDatabase.cnxMozart))
          {
            cmd.CommandType = CommandType.StoredProcedure;
            SqlCommandBuilder.DeriveParameters(cmd);

            cmd.Parameters["@iDclNum"].Value = miNumDevis;
            cmd.Parameters["@iFouNum"].Value = Utils.ZeroIfNull(row["NumArticle"]);
            cmd.Parameters["@iFourSite"].Value = Utils.ZeroIfNull(row["NumSiteFour"]);
            cmd.Parameters["@nQte"].Value = Utils.ZeroIfNull(row["Quantite"]);
            cmd.Parameters["@nPU"].Value = Utils.ZeroIfNull(row["Prix U"]);
            cmd.Parameters["@nPC"].Value = Utils.ZeroIfNull(row["Prix Client"]);

            // si prix client, alors on ne peut pas modifier le coeff de fourniture donc on le passe à zero
            if (Utils.ZeroIfNull(row["Prix Client"]) > 0)
            {
              cmd.Parameters["@nPT"].Value = Utils.ZeroIfNull(row["Prix Client"]) * Utils.ZeroIfNull(row["Quantite"]);
              cmd.Parameters["@nCoeff"].Value = 0;
            }
            else
            {
              cmd.Parameters["@nPT"].Value = Utils.ZeroIfNull(row["Prix U"]) * Utils.ZeroIfNull(row["Quantite"]);
              cmd.Parameters["@nCoeff"].Value = Utils.ZeroIfNull(row["NFOUCOEFF"]);
            }
            // TB SAMSIC CITY SPEC
            if (miNumClient == 494 && MozartParams.NomGroupe == "EMALEC")
              cmd.Parameters["@vCode"].Value = Utils.BlankIfNull(row["VCODECPT"]);

            cmd.ExecuteNonQuery();
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private double RecherchePrixV2Mois(int NumArticle)
    {
      return (double)ModuleData.ExecuteScalarDouble($"api_sp_TrouvePrixVenteFouCli {miNumClient}, {NumArticle}");
    }

    private void InitApiTgrid2()
    {
      try
      {
        apiTGrid2.FilterBar = false;

        apiTGrid2.AddColumn(Resources.col_Serie, "Serie", 1400);
        apiTGrid2.AddColumn(Resources.col_materiel, "Article", 3600);
        apiTGrid2.AddColumn(Resources.col_marque, "Marque", 850);
        apiTGrid2.AddColumn(Resources.col_Type, "VFOUTYP", 1400);     // equivaut a 3cm"
        apiTGrid2.AddColumn("Réf", "VFOUREF", 1400);
        apiTGrid2.AddColumn("PCB", "NFOUNBLOT", 700, "", 2);
        apiTGrid2.AddColumn("Prix " + MozartParams.NomSociete, "Prix U", 1200, "0.000", 1);
        apiTGrid2.AddColumn("Date prix", "Date prix", 1300, "", 2);
        apiTGrid2.AddColumn("PV 2mois", "PRIXVENTE2MOIS", 1100, "", 2);
        apiTGrid2.AddColumn("Coeff", "NFOUCOEFF", 700, "0.00", 2);
        apiTGrid2.AddColumn("Prix Client", "Prix Client", 1000, "0.000", 1);
        apiTGrid2.AddColumn("Qté", "Quantite", 600, "", 2);
        apiTGrid2.AddColumn("Total", "Prix T", 800, "0.000", 1);
        apiTGrid2.AddColumn(Resources.col_Fournisseur, "Fournisseur", 0);
        apiTGrid2.AddColumn(Resources.col_NumFourn, "NumFour", 0);
        apiTGrid2.AddColumn(Resources.col_numArt, "NumArticle", 0);
        apiTGrid2.AddColumn(Resources.col_NumSiteFour, "NumSiteFour", 0);

        //  ' TB SAMSIC CITY SPEC
        if (miNumClient == 494 && MozartParams.NomGroupe == "EMALEC")
          apiTGrid2.AddColumn("Code HM", "VCODECPT", 1000);

        apiTGrid2.DelockColumn("Quantite");
        apiTGrid2.DelockColumn("NFOUCOEFF");

        apiTGrid2.InitColumnList();
        apiTGrid2.GridControl.DataSource = mdtArticles;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void apiTGrid2_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
    {
      //  mise a jour du total
      //  pas de changement du coeff pour les articles avec prix client
      DataRow row = apiTGrid2.GetFocusedDataRow();
      if (e.Column.FieldName == "NFOUCOEFF")
      {
        if (Convert.ToDouble(row["Prix Client"]) > 0)
        {
          MessageBox.Show("Vous ne pouvez pas saisir de coeff car il y a un prix client", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          row["NFOUCOEFF"] = 0;
        }
        else
        {
          if (Convert.ToDouble(row["NFOUCOEFF"]) < 1)
          {
            MessageBox.Show("Vous devez saisir un coefficient > 1", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            row["NFOUCOEFF"] = 4;
          }
          row["Prix T"] = Convert.ToDouble(row["Prix U"]) * Convert.ToDouble(row["NFOUCOEFF"]) * Convert.ToDouble(row["Quantite"]);
        }
      }

      if (e.Column.FieldName == "Quantite")
      {
        if (Convert.ToDouble(row["Prix Client"]) > 0)
          row["Prix T"] = Convert.ToDouble(row["Prix Client"]) * Convert.ToDouble(row["Quantite"]);
        else
          row["Prix T"] = Convert.ToDouble(row["Prix U"]) * Convert.ToDouble(row["NFOUCOEFF"]) * Convert.ToDouble(row["Quantite"]);
      }
      RemplirTxtTotaux();
      CalculTotal();
    }

    private void apiTGrid2_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
    {
      if (e.RowHandle >= 0)
      {
        if (e.Column.Name == "Quantite")
          e.Appearance.BackColor = Color.Orange;

        if (e.Column.Name == "NFOUCOEFF" && Convert.ToDouble(e.CellValue) > 0)
        {
          e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
          e.Appearance.BackColor = Color.FromArgb(255, 160, 0);
        }

        if (e.Column.Name == "Date prix" && e.CellValue.ToString() != "" && Convert.ToDateTime(e.CellValue) < DateTime.Now.AddYears(-2))
        {
          e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
          e.Appearance.ForeColor = Color.Red;
        }
      }
    }

    private void RemplirTxtTotaux()
    {
      try
      {
        double totHT = 0;
        double totPrixEmalec = 0;
        foreach (DataRow row in mdtArticles.Rows)
        {
          if (Utils.ZeroIfNull(row["Prix Client"]) > 0)
            // prix client , pas de coeff
            totHT += Utils.ZeroIfNull(row["Prix Client"]) * Utils.ZeroIfNull(row["Quantite"]);
          else
            // prix de la base avec application du coeff
            totHT += Utils.ZeroIfNull(row["Prix U"]) * Utils.ZeroIfNull(row["Quantite"]) * Utils.ZeroIfNull(row["NFOUCOEFF"]);

          // total prix emalec
          totPrixEmalec += Utils.ZeroIfNull(row["Prix U"]) * Utils.ZeroIfNull(row["Quantite"]);
        }

        txtHT.Text = totHT.ToString("C");
        txtHT.Tag = totHT;
        txtPrixEmalec.Text = totPrixEmalec.ToString("C");
        txtPrixEmalec.Tag = totPrixEmalec;

        if (totPrixEmalec != 0)
        {
          txtCoeff.Text = (totHT / totPrixEmalec).ToString("#.00");
          txtCoeff.Tag = totHT / totPrixEmalec;
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void txtNbr_TextChanged(object sender, EventArgs e)
    {
      CalculTotal();
      bModif = true;
    }

    private void txtNbr_Enter(object sender, EventArgs e)
    {
      apiTextBox txt = (sender as apiTextBox);
      txt.Focus();
      txt.SelectionStart = 0;
      txt.SelectionLength = txt.Text.Length;
    }

    private void chkJour_CheckedChanged(object sender, EventArgs e)
    {
      if (chkJour.Checked)
        chkNonPublic.Checked = chkNuit.Checked = false;
    }

    private void chkNonPublic_CheckedChanged(object sender, EventArgs e)
    {
      if (chkNonPublic.Checked)
        chkJour.Checked = chkNuit.Checked = false;
    }

    private void chkNuit_CheckedChanged(object sender, EventArgs e)
    {
      // si astreinte, on modifie le taux horaire
      if (chkNuit.Checked)
      {
        chkJour.Checked = chkNonPublic.Checked = false;
        txtTauxHeures.Text = (Utils.ZeroIfNull(txtTauxHeures.Text) * iCoefNuiDimArt).ToString();
      }
      else
        txtTauxHeures.Text = (Utils.ZeroIfNull(txtTauxHeures.Text) / iCoefNuiDimArt).ToString();
    }

    private void txtNbr_KeyPress(object sender, KeyPressEventArgs e)
    {
      KeyValidator.KeyPress_SaisieNombre(e);
    }

    private void CalculTotal()
    {
      txtHTHeure.Text = (Utils.ZeroIfNull(txtTauxHeures.Text) * Utils.ZeroIfNull(txtNbrHeures.Text)).ToString("C2");
      txtHTHeure.Tag = Utils.ZeroIfNull(txtTauxHeures.Text) * Utils.ZeroIfNull(txtNbrHeures.Text);
      txtHTDep.Text = (Utils.ZeroIfNull(txtNbrDep.Text) * Utils.ZeroIfNull(txtTauxDep.Text)).ToString("C2");
      txtHTDep.Tag = Utils.ZeroIfNull(txtNbrDep.Text) * Utils.ZeroIfNull(txtTauxDep.Text);
      txtHTtot.Text = (Utils.ZeroIfNull(txtHT.Tag) + Convert.ToDouble(txtHTHeure.Tag) + Convert.ToDouble(txtHTDep.Tag)).ToString("C2");
      txtHTtot.Tag = Utils.ZeroIfNull(txtHT.Tag) + Convert.ToDouble(txtHTHeure.Tag) + Convert.ToDouble(txtHTDep.Tag);
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      //  ' si il y a des modifications
      //  ' couleur du bouton quantitatif si quelquechose
      //  frmDevisClient.cmdArticlesDevis.BackColor = IIf(ZeroIfNull(txtHTtot) > 0, &H80FFFF, &H8000000F)

      if (bModif)
      {
        DialogResult resp = MessageBox.Show(Resources.msgConfirm_enregistrerModif, Program.AppTitle,
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        switch (resp)
        {
          case DialogResult.Yes:
            cmdValider_Click(null, null);
            Dispose();
            break;
          case DialogResult.No:
            Dispose();
            break;
        }
      }
      else
        Dispose();
    }
  }
}