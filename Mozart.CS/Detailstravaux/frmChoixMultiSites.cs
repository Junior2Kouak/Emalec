using DevExpress.XtraGrid.Views.Grid;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using MozartUC;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmChoixMultiSites : Form
  {
    public long miNumClient;
    public int miNumContrat;
    public DataTable dtRS = new DataTable();

    DataTable dtSite = new DataTable();

    int nbCoche;
    bool isCreate = false; // va vérifier si on a déjà créé la datatable dt (cas où on refuse de créer une DI par site => validerClick)

    //pour frmDetailsTravaux
    public char mcItemCboPrest;
    public bool mbOptInter0IsChecked;
    public int miCboGamme = -1; // si -1, pas de selection
    public bool mbMultiDi;
    public bool mbAnnulerChoix;

 
    public frmChoixMultiSites() { InitializeComponent(); }

    private void frmChoixMultiSites_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        InitApigrid();
        apiTGrid.SetBounds(apiTGrid.Location.X, apiTGrid.Location.Y, apiTGrid.Width - 1, apiTGrid.Height);

        Utils.InitComboBox(cboGamme, $"api_sp_ComboGamme {miNumClient}, 0", "", "", true);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }


    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      mbAnnulerChoix = true;
      Dispose();
    }

      private void cmdValider_Click(object sender, EventArgs e)
    {
      try
      {
        string sMsg = "";

        if (dtSite.Rows.Count == 0) return;

        // on recherche le montant et la duree de la prev au niveau du contrat

        if (mcItemCboPrest == 'P')
        {
          foreach (DataRow row in dtSite.Rows)
          {
            if (Utils.ZeroIfNull(row["CHECK"]) != 0)
            {
              string sSQL = "";

              if (mbOptInter0IsChecked)
                sSQL = $"SELECT NMONTANTINTER,NDUREEINTER FROM TCONT WHERE NSITNUM = {row["NSITNUM"]} AND NTYPECONTRAT = {miNumContrat}";
              else
                sSQL = $"SELECT NMONTANTSTTP2,NDUREEINTER FROM TCONT WHERE NSITNUM = {row["NSITNUM"]} AND NTYPECONTRAT = {miNumContrat}";

              using (SqlDataReader sdrMontantDuree = ModuleData.ExecuteReader(sSQL))
              {
                if (sdrMontantDuree.Read())
                {
                  if (Utils.BlankIfNull(sdrMontantDuree[0]) == "" || Utils.BlankIfNull(sdrMontantDuree["NDUREEINTER"]) == "")
                    sMsg += $"   - {Utils.BlankIfNull(row["VSITNOM"])}\r\n";
                }
                else
                  sMsg += $"   - {Utils.BlankIfNull(row["VSITNOM"])}\r\n";
              }
            }
          }
        }

        // si on a une donnée incorrecte, on affiche un message et on quitte la fonction
        if (sMsg != "")
        {
          MessageBox.Show($"Problème sur le contrat de la DI :\r\n{Resources.txt_montantDureePreventiveNonRenseignes}\r\n{sMsg}", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }

        // initialisation du recordset
        if (!isCreate)
        {
          InitRecordset();
          isCreate = true;
        }

        foreach (DataRow row1 in dtSite.Rows)
        {
          if (Convert.ToBoolean(row1["CHECK"]))
          {
            // ajout de l'enregistrement

            DataRow newrow = dtRS.NewRow();

            newrow["Nom"] = Utils.BlankIfNull(row1["VSITNOM"]);
            newrow["Num"] = Utils.ZeroIfNull(row1["NSITNUM"]);
            newrow["Client"] = miNumClient;
            dtRS.Rows.Add(newrow);
          }
        }

        // choix de la gamme

        if (cboGamme.Text != "")
          miCboGamme = (int)cboGamme.SelectedValue;

        mbMultiDi = false;

        // gestion Multi-DI
        if (chkDI.Checked)
        {
          if (MessageBox.Show("Etes-vous sûr de vouloir créer une DI par site ?", Program.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                              MessageBoxDefaultButton.Button2) == DialogResult.Yes)
          {
            mbMultiDi = true;
          }
          else
          {
            chkDI.Checked = false;
            return;
          }
        }

        mbAnnulerChoix = false;

        Dispose();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdCocherT_Click(object sender, EventArgs e)
    {
      try
      {
        int nb = apiTGrid.dgv.DataRowCount;
        for (int i = 0; i < nb; i++)
        {
          int h = apiTGrid.dgv.GetVisibleRowHandle(i);
          DataRow r = apiTGrid.dgv.GetDataRow(h);
          r["CHECK"] = true;
        }

        lblNbSites.Text = $"{lblNbSites.Tag}{nb}";
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    
    private void cmdDecocher_Click(object sender, EventArgs e)
    {
      try
      {
        foreach (DataRow row in dtSite.Rows)
        {
          row["CHECK"] = false;
        }

        nbCoche = 0;
        lblNbSites.Text = $"{lblNbSites.Tag}{nbCoche}";
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

   
     public void InitRecordset()
    {
      // initialisation du recordset des sites
      dtRS.Columns.Add("Nom", Type.GetType("System.String"));
      dtRS.Columns.Add("Num", Type.GetType("System.Int32"));
      dtRS.Columns.Add("Client", Type.GetType("System.Int32"));
    }

     private void apiTGrid_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
    {
      DataRow row = apiTGrid.GetFocusedDataRow();
      if (row == null) return;

      if (!Convert.ToBoolean(row["CHECK"]))
        nbCoche--;
      else
        nbCoche++;

      lblNbSites.Text = $"{lblNbSites.Tag}{nbCoche}";
    }

     private void InitApigrid()
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;

        // recherche de la liste des sites
        apiTGrid.LoadData(dtSite, MozartDatabase.cnxMozart, $"api_sp_TousSites {MozartParams.NumDi},{miNumClient}");
        apiTGrid.GridControl.DataSource = dtSite;

        //décocher tous
        foreach (DataRow row in dtSite.Rows)
          row["CHECK"] = false;

        //apiTGrid.AddColumn(" ", "CHECK", 300, "", 0, false, false, true);
        apiTGrid.AddColumn("NumSite", "NSITNUM", 0);
        apiTGrid.AddColumn(Resources.col_Site, "VSITNOM", 4500, "", 0, true);
        apiTGrid.AddColumn(Resources.col_Region, "VSITREG", 1200);
        apiTGrid.AddColumn(Resources.col_resp_reg, "VCCLNOM", 1200);
        apiTGrid.AddColumn(Resources.col_depart, "NREGCOD", 500);
        apiTGrid.AddColumn(Resources.col_Pays, "VSITPAYS", 1000);

        apiTGrid.InitColumnList();

        apiTGrid.dgv.OptionsSelection.MultiSelect = true;
        apiTGrid.dgv.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect;
        apiTGrid.dgv.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.False;
        apiTGrid.dgv.OptionsSelection.CheckBoxSelectorField = "CHECK";
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

  }
}

