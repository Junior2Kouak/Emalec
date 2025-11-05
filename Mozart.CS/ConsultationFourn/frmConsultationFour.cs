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
  public partial class frmConsultationFour : Form
  {
    public int miNumConsult;
    public int miNumPrest;
    public int miNumDevisPrest;
    public int miNumAction = 0;
    public string mstrStatut;
    public string mstrDateRetour;

    private DataTable dtArt = new DataTable();
    private DataTable dtConsFour = new DataTable();

    public frmConsultationFour() { InitializeComponent(); }


    private void frmConsultationFour_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        apiLabel[] labels = { Label2, Label3, Label14, Label4 };
        foreach (apiLabel lbl in labels)
        {
          lbl.Text += " :";
        }

        string sql = $"EXEC api_sp_ListeSerieFOMOZART {MozartParams.Langue}";
        txtCritFouSer.Init(MozartDatabase.cnxMozart, sql, "NCFOCOD", "CCFOCOD",
                          new List<string>() { Resources.col_Num, Resources.col_série }, 250, 550, true);

        InitApiTgrid();
        InitRsArticle();
        InitApiTgridArt();

        // Si on vient des prestations, alors on charge directement les articles de la prestation
        if (miNumPrest != 0 || miNumDevisPrest != 0)
          RetourArticlePrestation();

        if (miNumConsult != 0 && mstrStatut == "M")
          OuvertureEnModification();

        Cursor.Current = Cursors.Default;
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

    void InitApiTgrid()
    {
      try
      {
        apiTGrid.AddColumn("Num", "NFOUNUM", 0);
        apiTGrid.AddColumn(Resources.col_Serie, "VFOUSER", 1300, "", 0, true);
        apiTGrid.AddColumn(Resources.col_materiel, "VFOUMAT", 3350, "", 0, true);
        apiTGrid.AddColumn(Resources.col_marque, "VFOUMAR", 1200, "", 0, true);
        apiTGrid.AddColumn(Resources.col_Type, "VFOUTYP", 1500);
        apiTGrid.AddColumn(Resources.col_reference, "VFOUREF", 1400, "", 0, true);
        apiTGrid.AddColumn(Resources.col_Condit, "VFOUCON", 600);
        apiTGrid.AddColumn(Resources.col_pcb, "NFOUNBLOT", 600);
        apiTGrid.AddColumn("12M", "Qte12M", 600);
        apiTGrid.AddColumn(Resources.col_dateprix, "DFOUDPR", 1000, "dd/mm/yy", 1);
        apiTGrid.AddColumn(Resources.col_prixU, "FPUHT", 950, "Currency", 1);
        apiTGrid.InitColumnList();
        apiTGrid.GridControl.DataSource = dtConsFour;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void apiTGrid_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
    {
      GridView View = sender as GridView;
      if (e.RowHandle >= 0)
        if (View.GetDataRow(e.RowHandle)["CCODEG"].ToString().ToUpper() == "O")
          e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);

    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      try
      {
        if (dtArt.Rows.Count == 0)
        {
          MessageBox.Show(Resources.msg_selection_un_article, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        if (txtDateRetour.Text == "")
          MessageBox.Show(Resources.msg_date_reception_obligatoire, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        else
        {
          EnregistrerArticle();
          frmChoixFournisseurs f = new frmChoixFournisseurs()
          {
            mstrStatut = mstrStatut,
            miNumConsult = miNumConsult,
            mstrDateRetour = mstrDateRetour
          };
          f.ShowDialog();
          mstrStatut = f.mstrStatut;
          miNumConsult = Convert.ToInt32(f.miNumConsult);
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }

    }

    private void cmdAjouter_Click(object sender, EventArgs e)
    {

      DataRow currentRow = apiTGrid.GetFocusedDataRow();
      DataRow[] SearchRows = dtArt.Select("Num = " + currentRow["NFOUNUM"]);

      if (SearchRows.Length == 0)
        AjouterEnreg(currentRow);
      else
        MessageBox.Show(Resources.msg_article_already_in_list, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }

    private void EnregistrerArticle()
    {
      try
      {
        if (dtArt.Rows.Count == 0) return;
        // on a la liste des articles dans rsart
        // on enregistre ces articles dans une table temporaire
        ModuleData.ExecuteNonQuery($"delete from TART WHERE VQUICRE = '{MozartParams.strUID}'");
        foreach (DataRow row in dtArt.Rows)
          ModuleData.ExecuteNonQuery($"insert into TART (NFOUNUM, VFOUSER, NFOUQTE, DARTDRECP, VQUICRE) values ({row["num"]}, '{row["serie"]}', {row["Quantité"]}, " +
                                     $"'{txtDateRetour.Text:dd/MM/yyyy}', '{MozartParams.strUID}')");
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void AjouterEnreg(DataRow row)
    {
      try
      {
        // Ajout de l'enregistrement
        DataRow newrow = dtArt.NewRow();

        newrow["Num"] = row["NFOUNUM"];
        newrow["Serie"] = row["VFOUSER"];
        newrow["Materiel"] = row["VFOUMAT"];

        if (row["VFOUMAR"] != DBNull.Value) newrow["Marque"] = row["VFOUMAR"];
        if (row["VFOUTYP"] != DBNull.Value) newrow["Type"] = row["VFOUTYP"];
        if (row["VFOUREF"] != DBNull.Value) newrow["Reference"] = row["VFOUREF"];
        if (row["VFOUCON"] != DBNull.Value) newrow["Condit"] = row["VFOUCON"];
        if (row["NFOUNBLOT"] != DBNull.Value) newrow["PCB"] = row["NFOUNBLOT"];
        if (row["DFOUDPR"] != DBNull.Value) newrow["Date prix"] = row["DFOUDPR"];

        newrow["Quantité"] = 1;
        newrow["Prix"] = ".";

        dtArt.Rows.Add(newrow);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdFermer_Click(object sender, EventArgs e)
    {
      Dispose();
    }

    private void cmdSupp_Click(object sender, EventArgs e)
    {
      try
      {
        // suppression de la ligne courante
        DataRow row = apiTGridArt.GetFocusedDataRow();
        if (row == null) return;

        row.Delete();
        dtArt.AcceptChanges();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    void InitApiTgridArt()
    {
      try
      {
        apiTGridArt.AddColumn("Num", "Num", 0);
        apiTGridArt.AddColumn(Resources.col_Serie, "Serie", 1300);
        apiTGridArt.AddColumn(Resources.col_materiel, "Materiel", 3500);
        apiTGridArt.AddColumn(Resources.col_marque, "Marque", 1400);
        apiTGridArt.AddColumn(Resources.col_Type, "Type", 1600);
        apiTGridArt.AddColumn(Resources.col_reference, "Reference", 1500);
        apiTGridArt.AddColumn(Resources.col_Condit, "Condit", 1000);
        apiTGridArt.AddColumn(Resources.col_pcb, "PCB", 0);
        apiTGridArt.AddColumn(Resources.col_dateprix, "Date prix", 0, "dd/mm/yy", 2);
        apiTGridArt.AddColumn(Resources.col_Qte, "Quantité", 1000, "", 2);
        apiTGridArt.AddColumn(Resources.col_prixU, "Prix", 0);

        apiTGridArt.DelockColumn("Quantité");
        apiTGridArt.InitColumnList();
        apiTGridArt.FilterBar = false;
        apiTGridArt.GridControl.DataSource = dtArt;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    public void InitRsArticle()
    {
      try
      {
        // Ajout des champs au recordset
        dtArt.Columns.Add("Num", typeof(int));
        dtArt.Columns.Add("Serie", typeof(string));
        dtArt.Columns.Add("Materiel", typeof(string));
        dtArt.Columns.Add("Marque", typeof(string));
        dtArt.Columns.Add("Type", typeof(string));
        dtArt.Columns.Add("Reference", typeof(string));
        dtArt.Columns.Add("Condit", typeof(string));
        dtArt.Columns.Add("PCB", typeof(string));
        dtArt.Columns.Add("Date prix", typeof(DateTime));
        dtArt.Columns.Add("Quantité", typeof(int));
        dtArt.Columns.Add("Prix", typeof(string));
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    DateTime _curDate = DateTime.MinValue;
    private void Calendar1_CloseUp(object sender, EventArgs e)
    {
      Calendar1.Visible = false;
      if (_curDate == DateTime.MinValue) return;
      txtDateRetour.Text = Calendar1.Value.ToShortDateString();
    }
    private void Calendar1_ValueChanged(object sender, EventArgs e)
    {
      if (Calendar1.Visible) _curDate = Calendar1.Value;
    }

    private void cmdDate_Click(object sender, EventArgs e)
    {
      DateTime d;
      if (DateTime.TryParse(txtDateRetour.Text, out d))
        _curDate = Calendar1.Value = d;
      else { _curDate = DateTime.MinValue; Calendar1.Value = DateTime.Now; }
      Calendar1.Visible = true;
      Calendar1.ShowCalendar(new MouseEventArgs(MouseButtons.Left, 1, MousePosition.X - this.Location.X, MousePosition.Y - this.Location.Y, 0));
    }

    private void cmdsup_Click(object sender, EventArgs e)
    {
      mstrDateRetour = txtDateRetour.Text = "";
    }

    private void Form_Unload(int Cancel)
    {
      miNumPrest = 0;
      Cursor.Current = Cursors.Default;
    }

    private void apiTGrid_DoubleClick(object sender, EventArgs e)
    {
      cmdAjouter_Click(sender, e);
    }

    private void apiTGridArt_RowCellStyle(object sender, RowCellStyleEventArgs e)
    {
      if (e.Column.Name == "Quantité")
      {
        e.Appearance.BackColor = Color.Orange;
        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
        //  CellStyle.Font.Size = 10
      }
    }

    private void RetourArticlePrestation()
    {
      try
      {
        if (miNumPrest != 0)
        {
          string sSql = "SELECT TLPRESTFOU.NFOUNUM, VFOUSER, VFOUMAT, VFOUMAR, VFOUTYP, " +
                        "VFOUREF , VFOUCON, NFOUNBLOT, DFOUDPR, NFOUQTE " +
                        "FROM TLPRESTFOU, TFOU " +
                        "WHERE TLPRESTFOU.NFOUNUM = TFOU.NFOUNUM " +
                        $"AND TLPRESTFOU.NPRESTID = {miNumPrest}" +
                        " ORDER BY VFOUMAT";

          using (SqlDataReader drFouPrest = ModuleData.ExecuteReader(sSql))
          {
            while (drFouPrest.Read())
            {
              DataRow newrow = dtArt.NewRow();

              newrow["Num"] = drFouPrest["NFOUNUM"];
              newrow["Serie"] = drFouPrest["VFOUSER"];
              newrow["Materiel"] = drFouPrest["VFOUSER"];
              if (drFouPrest[3] != DBNull.Value) newrow["Marque"] = Utils.BlankIfNull(drFouPrest["VFOUMAR"]);
              if (drFouPrest[4] != DBNull.Value) newrow["Type"] = Utils.BlankIfNull(drFouPrest["VFOUTYP"]);
              if (drFouPrest[5] != DBNull.Value) newrow["Reference"] = Utils.BlankIfNull(drFouPrest["VFOUREF"]);
              if (drFouPrest[6] != DBNull.Value) newrow["Condit"] = Utils.BlankIfNull(drFouPrest["VFOUCON"]);
              if (drFouPrest[7] != DBNull.Value) newrow["PCB"] = Utils.BlankIfNull(drFouPrest["NFOUNBLOT"]);
              if (drFouPrest[8] != DBNull.Value) newrow["Date prix"] = Utils.BlankIfNull(drFouPrest["DFOUDPR"]);
              newrow["Quantité"] = drFouPrest["NFOUQTE"];
              newrow["Prix"] = ".";

              dtArt.Rows.Add(newrow);
            }
          }
        }

        else
        {
          if (miNumDevisPrest != 0)
          {
            using (SqlDataReader drFouPrest = ModuleData.ExecuteReader($"api_sp_RetourArticlesDevisPrestationConsultation {miNumDevisPrest}"))
            {
              while (drFouPrest.Read())
              {
                DataRow newrow = dtArt.NewRow();

                newrow["Num"] = drFouPrest["NFOUNUM"];
                newrow["Serie"] = drFouPrest["CCFOCOD"];
                newrow["Materiel"] = drFouPrest["VFOUMAT"];
                if (drFouPrest[3] != DBNull.Value) newrow["Marque"] = Utils.BlankIfNull(drFouPrest["VFOUMAR"]);
                if (drFouPrest[4] != DBNull.Value) newrow["Type"] = Utils.BlankIfNull(drFouPrest["VFOUTYP"]);
                if (drFouPrest[5] != DBNull.Value) newrow["Reference"] = Utils.BlankIfNull(drFouPrest["VFOUREF"]);
                if (drFouPrest[6] != DBNull.Value) newrow["Condit"] = Utils.BlankIfNull(drFouPrest["VFOUCON"]);
                if (drFouPrest[7] != DBNull.Value) newrow["PCB"] = Utils.BlankIfNull(drFouPrest["NFOUNBLOT"]);
                if (drFouPrest[8] != DBNull.Value) newrow["Date prix"] = Utils.BlankIfNull(drFouPrest["DFOUDPR"]);
                newrow["Quantité"] = Utils.ZeroIfNull(drFouPrest["QTE"]);
                newrow["Prix"] = ".";

                dtArt.Rows.Add(newrow);
              }
            }
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void OuvertureEnModification()
    {
      using (SqlDataReader drFouCons = ModuleData.ExecuteReader("EXEC api_sp_DetailConsultation " + miNumConsult))
      {
        if (drFouCons.Read()) mstrDateRetour = txtDateRetour.Text = Utils.BlankIfNull(drFouCons["DCONSULTDAT"].ToString());

        do
        {
          DataRow newrow = dtArt.NewRow();

          newrow["Num"] = drFouCons["NFOUNUM"];
          newrow["Serie"] = drFouCons["VFOUSER"];
          newrow["Materiel"] = drFouCons["VFOUMAT"];
          if (drFouCons[3] != DBNull.Value) newrow["Marque"] = Utils.BlankIfNull(drFouCons["VFOUMAR"]);
          if (drFouCons[4] != DBNull.Value) newrow["Type"] = Utils.BlankIfNull(drFouCons["VFOUTYP"]);
          if (drFouCons[5] != DBNull.Value) newrow["Reference"] = Utils.BlankIfNull(drFouCons["VFOUREF"]);
          if (drFouCons[6] != DBNull.Value) newrow["Condit"] = Utils.BlankIfNull(drFouCons["VFOUCON"]);
          if (drFouCons[7] != DBNull.Value) newrow["PCB"] = Utils.BlankIfNull(drFouCons["NFOUNBLOT"]);
          if (drFouCons[8] != DBNull.Value) newrow["Date prix"] = Utils.BlankIfNull(drFouCons["DFOUDPR"]);
          newrow["Quantité"] = Utils.ZeroIfNull(drFouCons["NFOUQTE"]);
          newrow["Prix"] = ".";

          dtArt.Rows.Add(newrow);

        } while (drFouCons.Read());
      }
    }

    private void cmdFind_Click(object sender, EventArgs e)
    {
      string sFouSer;
      string sFouMat;
      string sFouMar;
      string sFouRef;

      sFouSer = (txtCritFouSer.GetText() == "") ? "T$" : txtCritFouSer.GetText();
      sFouMat = (txtCritFouMat.Text == "") ? "T$" : txtCritFouMat.Text;
      sFouMar = (txtCritFouMar.Text == "") ? "T$" : txtCritFouMar.Text;
      sFouRef = (txtCritFouRef.Text == "") ? "T$" : txtCritFouRef.Text;
      ModuleData.LoadData(dtConsFour, $"EXEC api_sp_ListeDesFournituresConsult '{sFouSer}', '{sFouMat}', '{sFouMar}', '{sFouRef}'");
    }

    private void frmConsultationFour_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.F2 || e.KeyCode == Keys.Enter)
        cmdFind_Click(null, null);
    }
  }
}