using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using MozartCS.Properties;
using MozartLib;
using MozartUC;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class UCGestionKPI : UserControl
  {
    private const string COLUMNNAME_NTYPECONTRAT = "NTYPECONTRAT";
    private const string COLUMNNAME_VTYPECONTRAT = "VTYPECONTRAT";
    private const string COLUMNNAME_CGESTION = "CGESTION";

    private int _NCLINUM;

    // Gestion des valeurs par défaut si true : Est à true si _NCLINUM = 0
    private bool mBManageDefaultValue;

    private DataTable dt = new DataTable();

    private Color mForeColor;

    public UCGestionKPI()
    {
      InitializeComponent();
    }

    // Nécessaire : A FAIRE dans le FORM_LOAD
    public void initComponent(int pNCliNum)
    {
      try
      {
        _NCLINUM = pNCliNum;

        mBManageDefaultValue = (_NCLINUM == 0);

        Cursor.Current = Cursors.WaitCursor;

        LoadData();

        InitApiTGrid();

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

    // Nécessaire : Permet d'enregistrer les modifications
    public void commitChanges()
    {
      bool bPlageToutAZero = true;

      bool bAtLeatOneContrat = dt.AsEnumerable().Any(row => row.Field<string>(COLUMNNAME_CGESTION) == "OUI");
      if (!bAtLeatOneContrat)
      {
        throw new Exception("Au moins un contrat doit être géré");
      }

      bPlageToutAZero &= EnregistrerUnJour(1, txtLunDebMat, txtLunDebMatMin, txtLunFinMat, txtLunFinMatMin, chkCoupLun, txtLunDebSoir, txtLunDebSoirMin, txtLunFinSoir, txtLunFinSoirMin);
      bPlageToutAZero &= EnregistrerUnJour(2, txtMarDebMat, txtMarDebMatMin, txtMarFinMat, txtMarFinMatMin, chkCoupMar, txtMarDebSoir, txtMarDebSoirMin, txtMarFinSoir, txtMarFinSoirMin);
      bPlageToutAZero &= EnregistrerUnJour(3, txtMerDebMat, txtMerDebMatMin, txtMerFinMat, txtMerFinMatMin, chkCoupMer, txtMerDebSoir, txtMerDebSoirMin, txtMerFinSoir, txtMerFinSoirMin);
      bPlageToutAZero &= EnregistrerUnJour(4, txtJeuDebMat, txtJeuDebMatMin, txtJeuFinMat, txtJeuFinMatMin, chkCoupJeu, txtJeuDebSoir, txtJeuDebSoirMin, txtJeuFinSoir, txtJeuFinSoirMin);
      bPlageToutAZero &= EnregistrerUnJour(5, txtVenDebMat, txtVenDebMatMin, txtVenFinMat, txtVenFinMatMin, chkCoupVen, txtVenDebSoir, txtVenDebSoirMin, txtVenFinSoir, txtVenFinSoirMin);
      bPlageToutAZero &= EnregistrerUnJour(6, txtSamDebMat, txtSamDebMatMin, txtSamFinMat, txtSamFinMatMin, chkCoupSam, txtSamDebSoir, txtSamDebSoirMin, txtSamFinSoir, txtSamFinSoirMin);
      bPlageToutAZero &= EnregistrerUnJour(7, txtDimDebMat, txtDimDebMatMin, txtDimFinMat, txtDimFinMatMin, chkCoupDim, txtDimDebSoir, txtDimDebSoirMin, txtDimFinSoir, txtDimFinSoirMin);

      if (bPlageToutAZero)
      {
        throw new Exception("Aucune plage horaire n'est définie");
      }

      EnregistrerGrid();

      // Les KPIs ...
      string lKPIQuery = $"UPDATE TCLI SET VKPI_OBS = '{txtObsKPI.Text.Replace("'", "''")}'";
      lKPIQuery += $", CKPI_DEPAST = '{getKPIOptButton(rdoDepAst_C)}'";
      lKPIQuery += $", CKPI_DEPRAP = '{getKPIOptButton(rdoDepRap_C)}'";
      lKPIQuery += $", CKPI_DEPMOY = '{getKPIOptButton(rdoDepMoy_C)}'";
      lKPIQuery += $", CKPI_DEPLEN = '{getKPIOptButton(rdoDepLent_C)}'";
      lKPIQuery += $", CKPI_DEVIS = '{getKPIOptButton(rdoDevis_C)}'";
      lKPIQuery += $", CKPI_TRVX = '{getKPIOptButton(rdoTrvx_C)}'";
      lKPIQuery += $", CKPI_RESO = '{getKPIOptButton(rdoReso_C)}'";
      lKPIQuery += $", CKPI_PDP = '{getKPIOptButton(rdoPDP_C)}'";
      lKPIQuery += $", CKPI_QUAL = '{getKPIOptButton(rdoQual_C)}'";

      lKPIQuery += $" WHERE NCLINUM = {_NCLINUM}";
      MozartDatabase.ExecuteNonQuery(lKPIQuery);
    }

    private void InitApiTGrid()
    {
      //apiTGrid1.dgv.OptionsView.AllowHtmlDrawHeaders = true;
      apiTGrid1.dgv.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
      apiTGrid1.dgv.ColumnPanelRowHeight = 60;

      apiTGrid1.AddColumn(Resources.col_Contrat, COLUMNNAME_VTYPECONTRAT, 2800);
      if (!mBManageDefaultValue)
      {
        apiTGrid1.AddColumn(Resources.col_Gestion, COLUMNNAME_CGESTION, 700);
      }
      apiTGrid1.AddColumn("Délai Dépannage Astreinte (h)", "NDEPAST", 1000, "N2");
      apiTGrid1.AddColumn("Taux de respect du délai (%)", "TXDEPAST", 1000);
      apiTGrid1.AddColumn("Délai Dépannage Rapide (h)", "NDEPRAP", 1000, "N2");
      apiTGrid1.AddColumn("Taux de respect du délai (%)", "TXDEPRAP", 1000);
      apiTGrid1.AddColumn("Délai Dépannage Moyen (h)", "NDEPMOY", 1000, "N2");
      apiTGrid1.AddColumn("Taux de respect du délai (%)", "TXDEPMOY", 1000);
      apiTGrid1.AddColumn("Délai Dépannage Lent (h)", "NDEPLEN", 1000, "N2");
      apiTGrid1.AddColumn("Taux de respect du délai (%)", "TXDEPLEN", 1000);
      apiTGrid1.AddColumn("Délai de transmission d'un devis (J)", "NTRANSDEVIS", 1000);
      apiTGrid1.AddColumn("Taux de respect des travaux après commande (%)", "TXREALTRVX", 1000);
      apiTGrid1.AddColumn("Délai de réalisation des travaux après commande (J)", "NREALTRVX", 1000);
      apiTGrid1.AddColumn("Délai de résolution (Hors commande client) (J)", "NRESOCMDE", 1000);
      apiTGrid1.AddColumn("Taux de respect du plan de maintenance (%)", "NRESPPLANMAINT", 1000);
      apiTGrid1.AddColumn("Taux de respect des enquêtes qualité (%)", "TXENQQUAL", 1000);
      apiTGrid1.AddColumn(COLUMNNAME_NTYPECONTRAT, COLUMNNAME_NTYPECONTRAT, 0);

      if (!mBManageDefaultValue)
      {
        RepositoryItemComboBox riComboBox = new RepositoryItemComboBox();
        riComboBox.Items.Add("OUI");
        riComboBox.Items.Add("NON");
        riComboBox.TextEditStyle = TextEditStyles.DisableTextEditor;
        riComboBox.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;
        riComboBox.EditValueChanged += new EventHandler(this.comboBoxEdit1_SelectedIndexChanged);
        GridView gridView1 = apiTGrid1.GridControl.MainView as GridView;
        gridView1.Columns[COLUMNNAME_CGESTION].ColumnEdit = riComboBox;
        apiTGrid1.GridControl.RepositoryItems.Add(riComboBox);
        apiTGrid1.DelockColumn(COLUMNNAME_CGESTION);
      }

      apiTGrid1.InitColumnList();
      apiTGrid1.GridControl.DataSource = dt;

      apiTGrid1.DelockColumn("NDEPAST");
      apiTGrid1.DelockColumn("NDEPRAP");
      apiTGrid1.DelockColumn("NDEPMOY");
      apiTGrid1.DelockColumn("NDEPLEN");
      apiTGrid1.DelockColumn("NTRANSDEVIS");
      apiTGrid1.DelockColumn("TXREALTRVX");
      apiTGrid1.DelockColumn("NREALTRVX");
      apiTGrid1.DelockColumn("NRESOCMDE");
      apiTGrid1.DelockColumn("TXDEPAST");
      apiTGrid1.DelockColumn("TXDEPRAP");
      apiTGrid1.DelockColumn("TXDEPMOY");
      apiTGrid1.DelockColumn("TXDEPLEN");
      apiTGrid1.DelockColumn("NRESPPLANMAINT");
      apiTGrid1.DelockColumn("TXENQQUAL");

      apiTGrid1.dgv.OptionsView.ColumnAutoWidth = true;
      apiTGrid1.LoadData(dt, MozartDatabase.cnxMozart, $"exec api_sp_ListeDelaisContrat {_NCLINUM}, {MozartParams.Langue}");
    }

    private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
    {
      ComboBoxEdit edit = apiTGrid1.dgv.ActiveEditor as ComboBoxEdit;
      if (edit != null)
      {
        string value = edit.SelectedItem.ToString();
        if (value == "OUI")
        {
          // Mets les valeurs par défaut : TODO ou pas ? Faut-il remettre les vraies valeurs par défaut ou celles dans la table de valeurs par défaut ??
        }

        // Permet de rafraichir la ligne courante...
        if (apiTGrid1.dgv.PostEditor())
        {
          apiTGrid1.dgv.UpdateCurrentRow();
        }
      }
    }

    private void apiTGrid1_ShowingEditor(object sender, System.ComponentModel.CancelEventArgs e)
    {
      // Passage en lecture seule des cellules si GESTION à NON
      string value = apiTGrid1.dgv.GetRowCellValue(apiTGrid1.dgv.FocusedRowHandle, apiTGrid1.dgv.Columns[COLUMNNAME_CGESTION]).ToString();
      if ((value == "NON") && (apiTGrid1.dgv.FocusedColumn.Name != COLUMNNAME_VTYPECONTRAT) && (apiTGrid1.dgv.FocusedColumn.Name != COLUMNNAME_CGESTION))
      {
        e.Cancel = true;
      }
      else
      {
        e.Cancel = false;
      }
    }

    private void apiTGrid1_RowCellStyle(object sender, RowCellStyleEventArgs e)
    {
      if (e.RowHandle < 0) return;
      
      string value = apiTGrid1.dgv.GetRowCellValue(e.RowHandle, apiTGrid1.dgv.Columns[COLUMNNAME_CGESTION]).ToString();
      if (value == "NON")
      {
        if ((e.Column.Name != COLUMNNAME_VTYPECONTRAT) && (e.Column.Name != COLUMNNAME_CGESTION))
        {
          if (mForeColor != e.Appearance.ForeColor)
          {
            mForeColor = e.Appearance.ForeColor;
          }

          e.Appearance.ForeColor = e.Appearance.BackColor;
        }
        else
        {
          e.Appearance.ForeColor = mForeColor;
        }
      }
    }

    private void LoadData()
    {
      using (SqlCommand cmd = new SqlCommand($"select * from THORAIRESKPI where nclinum = {_NCLINUM}", MozartDatabase.cnxMozart))
      {
        TimeSpan lDateDeb1;
        TimeSpan lDateDeb2;
        TimeSpan lDateFin1;
        TimeSpan lDateFin2;

        cmd.CommandType = CommandType.Text;
        SqlDataReader sdr = cmd.ExecuteReader();
        if (sdr.HasRows)
        {
          while (sdr.Read())
          {
            lDateDeb1 = (TimeSpan)sdr["DHORKPIDEB1"];
            lDateFin1 = (TimeSpan)sdr["DHORKPIFIN1"];
            lDateDeb2 = (sdr["DHORKPIDEB2"] == DBNull.Value) ? TimeSpan.Zero : (TimeSpan)sdr["DHORKPIDEB2"];
            lDateFin2 = (sdr["DHORKPIFIN2"] == DBNull.Value) ? TimeSpan.Zero : (TimeSpan)sdr["DHORKPIFIN2"];

            switch (Convert.ToInt32(Utils.BlankIfNull(sdr["NHORKPIJOUR"])))
            {
              case 1:
                // Lundi
                InitFormUnJour(txtLunDebMat, txtLunDebMatMin, txtLunFinMat, txtLunFinMatMin, chkCoupLun, txtLunDebSoir, txtLunDebSoirMin, txtLunFinSoir, txtLunFinSoirMin,
                              lDateDeb1, lDateFin1, lDateDeb2, lDateFin2);
                break;
              case 2:
                // Mardi
                InitFormUnJour(txtMarDebMat, txtMarDebMatMin, txtMarFinMat, txtMarFinMatMin, chkCoupMar, txtMarDebSoir, txtMarDebSoirMin, txtMarFinSoir, txtMarFinSoirMin,
                              lDateDeb1, lDateFin1, lDateDeb2, lDateFin2);
                break;
              case 3:
                // Mercredi
                InitFormUnJour(txtMerDebMat, txtMerDebMatMin, txtMerFinMat, txtMerFinMatMin, chkCoupMer, txtMerDebSoir, txtMerDebSoirMin, txtMerFinSoir, txtMerFinSoirMin,
                              lDateDeb1, lDateFin1, lDateDeb2, lDateFin2);
                break;
              case 4:
                // Jeudi
                InitFormUnJour(txtJeuDebMat, txtJeuDebMatMin, txtJeuFinMat, txtJeuFinMatMin, chkCoupJeu, txtJeuDebSoir, txtJeuDebSoirMin, txtJeuFinSoir, txtJeuFinSoirMin,
                              lDateDeb1, lDateFin1, lDateDeb2, lDateFin2);
                break;
              case 5:
                // Vendredi
                InitFormUnJour(txtVenDebMat, txtVenDebMatMin, txtVenFinMat, txtVenFinMatMin, chkCoupVen, txtVenDebSoir, txtVenDebSoirMin, txtVenFinSoir, txtVenFinSoirMin,
                              lDateDeb1, lDateFin1, lDateDeb2, lDateFin2);
                break;
              case 6:
                // Samedi
                InitFormUnJour(txtSamDebMat, txtSamDebMatMin, txtSamFinMat, txtSamFinMatMin, chkCoupSam, txtSamDebSoir, txtSamDebSoirMin, txtSamFinSoir, txtSamFinSoirMin,
                              lDateDeb1, lDateFin1, lDateDeb2, lDateFin2);
                break;
              case 7:
                // Dimanche
                InitFormUnJour(txtDimDebMat, txtDimDebMatMin, txtDimFinMat, txtDimFinMatMin, chkCoupDim, txtDimDebSoir, txtDimDebSoirMin, txtDimFinSoir, txtDimFinSoirMin,
                              lDateDeb1, lDateFin1, lDateDeb2, lDateFin2);
                break;
            }
          }
        }

        sdr.Close();
      }

      using (SqlDataReader dr = MozartDatabase.ExecuteReader($"SELECT * FROM TCLI WHERE NCLINUM={_NCLINUM}"))
      {
        if (dr.HasRows)
        {
          dr.Read();

          txtObsKPI.Text = dr["VKPI_OBS"].ToString();

          setKPIOptButton(dr["CKPI_DEPAST"].ToString(), rdoDepAst_C, rdoDepAst_I);
          setKPIOptButton(dr["CKPI_DEPRAP"].ToString(), rdoDepRap_C, rdoDepRap_I);
          setKPIOptButton(dr["CKPI_DEPMOY"].ToString(), rdoDepMoy_C, rdoDepMoy_I);
          setKPIOptButton(dr["CKPI_DEPLEN"].ToString(), rdoDepLent_C, rdoDepLent_I);
          setKPIOptButton(dr["CKPI_DEVIS"].ToString(), rdoDevis_C, rdoDevis_I);
          setKPIOptButton(dr["CKPI_TRVX"].ToString(), rdoTrvx_C, rdoTrvx_I);
          setKPIOptButton(dr["CKPI_RESO"].ToString(), rdoReso_C, rdoReso_I);
          setKPIOptButton(dr["CKPI_PDP"].ToString(), rdoPDP_C, rdoPDP_I);
          setKPIOptButton(dr["CKPI_QUAL"].ToString(), rdoQual_C, rdoQual_I);
        }
      }
    }

    private void setKPIOptButton(string pVal, apiRadioButton pContratctuel, apiRadioButton pInterne)
    {
      if (pVal == "I")
      {
        pInterne.Checked = true;
      }
      else
      {
        pContratctuel.Checked = true;
      }
    }

    private string getKPIOptButton(apiRadioButton pContractuel)
    {
      return (pContractuel.Checked ? "C" : "I");
    }

    private void InitFormUnJour(apiTextBox txtDayDebMat, apiTextBox txtDayDebMatMin, apiTextBox txtDayFinMat, apiTextBox txtDayFinMatMin,
                                apiCheckBox chkCoupDay, apiTextBox txtDayDebSoir, apiTextBox txtDayDebSoirMin, apiTextBox txtDayFinSoir, apiTextBox txtDayFinSoirMin,
                                TimeSpan pDateDeb1, TimeSpan pDateFin1, TimeSpan pDateDeb2, TimeSpan pDateFin2)
    {
      chkCoupDay.Checked = (pDateDeb2 != TimeSpan.Zero);

      txtDayDebMat.Text = pDateDeb1.ToString("hh");
      txtDayDebMatMin.Text = pDateDeb1.ToString("mm");

      txtDayFinMat.Text = pDateFin1.ToString("hh");
      txtDayFinMatMin.Text = pDateFin1.ToString("mm");

      txtDayDebSoir.Text = pDateDeb2.ToString("hh");
      txtDayDebSoirMin.Text = pDateDeb2.ToString("mm");

      txtDayFinSoir.Text = pDateFin2.ToString("hh");
      txtDayFinSoirMin.Text = pDateFin2.ToString("mm");
    }

    private TimeSpan convertToTime(string pTxtHeures, string pTxtMinutes)
    {
      try
      {
        return new TimeSpan(Convert.ToInt32(pTxtHeures), Convert.ToInt32(pTxtMinutes), 0);
      }
      catch
      {
        throw new Exception("Erreur de conversion");
      }
    }

    // Lance une exception si la plage est incorrecte
    // Retourne true si la plage n'est pas définie (tout à 0)
    private bool validPeriod(string pDayDebMat, string pDayDebMatMin, string pDayFinMat, string pDayFinMatMin,
                             bool existeCoupure, string pDayDebSoir, string pDayDebSoirMin, string pDayFinSoir, string pDayFinSoirMin,
                             out TimeSpan pHeureDeb1, out TimeSpan pHeureFin1,
                             out TimeSpan pHeureDeb2, out TimeSpan pHeureFin2)
    {
      // Init de toutes les valeurs de retour à 0h00
      pHeureDeb1 = TimeSpan.Zero;
      pHeureFin1 = TimeSpan.Zero;
      pHeureDeb2 = TimeSpan.Zero;
      pHeureFin2 = TimeSpan.Zero;

      pHeureDeb1 = convertToTime(pDayDebMat, pDayDebMatMin);
      pHeureFin1 = convertToTime(pDayFinMat, pDayFinMatMin);

      // Heure de début doit être inférieure à Heure de fin
      if (pHeureDeb1 > pHeureFin1)
      {
        throw new Exception("Plage 1 : Heure de début postérieure à heure de fin");
      }

      if (!existeCoupure)
      {
        // 1 seule plage
        return ((pHeureDeb1 == pHeureFin1) && (pHeureDeb1 == TimeSpan.Zero));
      }

      // Existence d'une 2ième plage
      pHeureDeb2 = convertToTime(pDayDebSoir, pDayDebSoirMin);
      pHeureFin2 = convertToTime(pDayFinSoir, pDayFinSoirMin);

      // Heure de début doit être inférieur à Heure de fin
      if (pHeureDeb2 > pHeureFin2)
      {
        throw new Exception("Plage 2 : Heure de début postérieure à heure de fin");
      }

      if (pHeureDeb2 <= pHeureDeb1)
      {
        throw new Exception("La plage 2 doit être postérieure à la plage 1");
      }

      return ((pHeureDeb1 == TimeSpan.Zero) && (pHeureFin1 == TimeSpan.Zero) && (pHeureDeb2 == TimeSpan.Zero) && (pHeureFin2 == TimeSpan.Zero));
    }

    private bool EnregistrerUnJour(int pNumJour, apiTextBox txtDayDebMat, apiTextBox txtDayDebMatMin, apiTextBox txtDayFinMat, apiTextBox txtDayFinMatMin,
                                apiCheckBox chkCoupDay, apiTextBox txtDayDebSoir, apiTextBox txtDayDebSoirMin, apiTextBox txtDayFinSoir, apiTextBox txtDayFinSoirMin)
    {
      TimeSpan lHeureDeb1;
      TimeSpan lHeureFin1;
      TimeSpan lHeureDeb2;
      TimeSpan lHeureFin2;
      bool bPlageEstToutAZero;

      try
      {
        bPlageEstToutAZero = validPeriod(txtDayDebMat.Text, txtDayDebMatMin.Text, txtDayFinMat.Text, txtDayFinMatMin.Text,
                                         chkCoupDay.Checked, txtDayDebSoir.Text, txtDayDebSoirMin.Text, txtDayFinSoir.Text, txtDayFinSoirMin.Text,
                                         out lHeureDeb1, out lHeureFin1, out lHeureDeb2, out lHeureFin2);
      }
      catch
      {
        throw new Exception("Une ou plusieurs plages sont incorrectes");
      }

      using (SqlCommand cmd = new SqlCommand("api_sp_InsertOrUpdateHoraireKPI", MozartDatabase.cnxMozart))
      {
        cmd.CommandType = CommandType.StoredProcedure;
        SqlCommandBuilder.DeriveParameters(cmd);

        cmd.Parameters["@p_nclinum"].Value = _NCLINUM;
        cmd.Parameters["@p_nhorpkijour"].Value = pNumJour;
        cmd.Parameters["@p_dhorkpideb1"].Value = lHeureDeb1;
        cmd.Parameters["@p_dhorkpifin1"].Value = lHeureFin1;
        cmd.Parameters["@p_dhorkpideb2"].Value = lHeureDeb2;
        cmd.Parameters["@p_dhorkpifin2"].Value = lHeureFin2;
        cmd.ExecuteNonQuery();
      }

      return bPlageEstToutAZero;
    }

    private void EnregistrerGrid()
    {
      foreach (DataRow lRow in dt.Rows)
      {
        using (SqlCommand cmd = new SqlCommand("api_sp_SaveDelaiContrat2", MozartDatabase.cnxMozart))
        {
          cmd.CommandType = CommandType.StoredProcedure;
          SqlCommandBuilder.DeriveParameters(cmd);

          cmd.Parameters["@P_NCLINUM"].Value = _NCLINUM;
          cmd.Parameters["@P_NTYPECONTRAT"].Value = lRow[COLUMNNAME_NTYPECONTRAT];
          cmd.Parameters["@P_CGESTION"].Value = lRow[COLUMNNAME_CGESTION].ToString();
          cmd.Parameters["@P_NDEPAST"].Value = Utils.ZeroIfBlank(lRow["NDEPAST"]);
          cmd.Parameters["@P_TXDEPAST"].Value = Utils.ZeroIfBlank(lRow["TXDEPAST"]);
          cmd.Parameters["@P_NDEPRAP"].Value = Utils.ZeroIfBlank(lRow["NDEPRAP"]);
          cmd.Parameters["@P_TXDEPRAP"].Value = Utils.ZeroIfBlank(lRow["TXDEPRAP"]);
          cmd.Parameters["@P_NDEPMOY"].Value = Utils.ZeroIfBlank(lRow["NDEPMOY"]);
          cmd.Parameters["@P_TXDEPMOY"].Value = Utils.ZeroIfBlank(lRow["TXDEPMOY"]);
          cmd.Parameters["@P_NDEPLEN"].Value = Utils.ZeroIfBlank(lRow["NDEPLEN"]);
          cmd.Parameters["@P_TXDEPLEN"].Value = Utils.ZeroIfBlank(lRow["TXDEPLEN"]);
          cmd.Parameters["@P_NTRANSDEVIS"].Value = Utils.ZeroIfBlank(lRow["NTRANSDEVIS"]);
          cmd.Parameters["@P_TXREALTRVX"].Value = Utils.ZeroIfBlank(lRow["TXREALTRVX"]);
          cmd.Parameters["@P_NREALTRVX"].Value = Utils.ZeroIfBlank(lRow["NREALTRVX"]);
          cmd.Parameters["@P_NRESOCMDE"].Value = Utils.ZeroIfBlank(lRow["NRESOCMDE"]);
          cmd.Parameters["@P_NRESPPLANMAINT"].Value = Utils.ZeroIfBlank(lRow["NRESPPLANMAINT"]);
          cmd.Parameters["@P_TXENQQUAL"].Value = Utils.ZeroIfBlank(lRow["TXENQQUAL"]);

          cmd.ExecuteNonQuery();
        }
      }
    }

    private void chkCoupDay_CheckedChanged(object sender, EventArgs e)
    {
      CheckBox chk = sender as CheckBox;
      switch (chk.Name)
      {
        case "chkCoupLun":
          SetCoupUnJour(chkCoupLun, new apiLabel[] { lblCoupLun0, lblCoupLun1, lblCoupLun2, lblCoupLun3 }, txtLunDebSoir, txtLunFinSoir, txtLunDebSoirMin, txtLunFinSoirMin);
          break;
        case "chkCoupMar":
          SetCoupUnJour(chkCoupMar, new apiLabel[] { lblCoupMar0, lblCoupMar1, lblCoupMar2, lblCoupMar3 }, txtMarDebSoir, txtMarFinSoir, txtMarDebSoirMin, txtMarFinSoirMin);
          break;
        case "chkCoupMer":
          SetCoupUnJour(chkCoupMer, new apiLabel[] { lblCoupMer0, lblCoupMer1, lblCoupMer2, lblCoupMer3 }, txtMerDebSoir, txtMerFinSoir, txtMerDebSoirMin, txtMerFinSoirMin);
          break;
        case "chkCoupJeu":
          SetCoupUnJour(chkCoupJeu, new apiLabel[] { lblCoupJeu0, lblCoupJeu1, lblCoupJeu2, lblCoupJeu3 }, txtJeuDebSoir, txtJeuFinSoir, txtJeuDebSoirMin, txtJeuFinSoirMin);
          break;
        case "chkCoupVen":
          SetCoupUnJour(chkCoupVen, new apiLabel[] { lblCoupVen0, lblCoupVen1, lblCoupVen2, lblCoupVen3 }, txtVenDebSoir, txtVenFinSoir, txtVenDebSoirMin, txtVenFinSoirMin);
          break;
        case "chkCoupSam":
          SetCoupUnJour(chkCoupSam, new apiLabel[] { lblCoupSam0, lblCoupSam1, lblCoupSam2, lblCoupSam3 }, txtSamDebSoir, txtSamFinSoir, txtSamDebSoirMin, txtSamFinSoirMin);
          break;
        case "chkCoupDim":
          SetCoupUnJour(chkCoupDim, new apiLabel[] { lblCoupDim0, lblCoupDim1, lblCoupDim2, lblCoupDim3 }, txtDimDebSoir, txtDimFinSoir, txtDimDebSoirMin, txtDimFinSoirMin);
          break;
      }
    }

    private void SetCoupUnJour(apiCheckBox chkCoupDay, apiLabel[] lblCoupDay,
                                apiTextBox txtDayDebSoir, apiTextBox txtDayFinSoir,
                                apiTextBox txtDayDebSoirMin, apiTextBox txtDayFinSoirMin)
    {
      bool bVisible = chkCoupDay.Checked;
      foreach (apiLabel label in lblCoupDay)
        label.Visible = bVisible;

      txtDayDebSoir.Visible = txtDayFinSoir.Visible = txtDayDebSoirMin.Visible = txtDayFinSoirMin.Visible = bVisible;

      if (!bVisible)
        txtDayDebSoir.Text = txtDayFinSoir.Text = txtDayDebSoirMin.Text = txtDayFinSoirMin.Text = "00";
    }

    private void SetDefaultValue(apiCheckBox chkCoupDay, apiLabel[] lblCoupDay,
                                apiTextBox txtDayDebMat, apiTextBox txtDayFinMat, apiTextBox txtDayDebMatMin, apiTextBox txtDayFinMatMin,
                                apiTextBox txtDayDebSoir, apiTextBox txtDayFinSoir, apiTextBox txtDayDebSoirMin, apiTextBox txtDayFinSoirMin)
    {
      if (chkCoupDay == chkCoupDim)
      {
        chkCoupDay.Checked = false;

        txtDayDebMat.Text = "00"; txtDayDebMatMin.Text = "00";
        txtDayFinMat.Text = "00"; txtDayFinMatMin.Text = "00";
      }
      else
      {
        chkCoupDay.Checked = true;

        txtDayDebMat.Text = "09"; txtDayDebMatMin.Text = "00";
        txtDayFinMat.Text = "12"; txtDayFinMatMin.Text = "00";

        txtDayDebSoir.Text = "14"; txtDayDebSoirMin.Text = "00";
        txtDayFinSoir.Text = "19"; txtDayFinSoirMin.Text = "00";
      }

      SetCoupUnJour(chkCoupDay, lblCoupDay, txtDayDebSoir, txtDayFinSoir, txtDayDebSoirMin, txtDayFinSoirMin);
    }

    private void cmdLoadDefaultHor_Click(object sender, EventArgs e)
    {
      SetDefaultValue(chkCoupLun, new apiLabel[] { lblCoupLun0, lblCoupLun1, lblCoupLun2, lblCoupLun3 }, txtLunDebMat, txtLunFinMat, txtLunDebMatMin, txtLunFinMatMin, txtLunDebSoir, txtLunFinSoir, txtLunDebSoirMin, txtLunFinSoirMin);
      SetDefaultValue(chkCoupMar, new apiLabel[] { lblCoupMar0, lblCoupMar1, lblCoupMar2, lblCoupMar3 }, txtMarDebMat, txtMarFinMat, txtMarDebMatMin, txtMarFinMatMin, txtMarDebSoir, txtMarFinSoir, txtMarDebSoirMin, txtMarFinSoirMin);
      SetDefaultValue(chkCoupMer, new apiLabel[] { lblCoupMer0, lblCoupMer1, lblCoupMer2, lblCoupMer3 }, txtMerDebMat, txtMerFinMat, txtMerDebMatMin, txtMerFinMatMin, txtMerDebSoir, txtMerFinSoir, txtMerDebSoirMin, txtMerFinSoirMin);
      SetDefaultValue(chkCoupJeu, new apiLabel[] { lblCoupJeu0, lblCoupJeu1, lblCoupJeu2, lblCoupJeu3 }, txtJeuDebMat, txtJeuFinMat, txtJeuDebMatMin, txtJeuFinMatMin, txtJeuDebSoir, txtJeuFinSoir, txtJeuDebSoirMin, txtJeuFinSoirMin);
      SetDefaultValue(chkCoupVen, new apiLabel[] { lblCoupVen0, lblCoupVen1, lblCoupVen2, lblCoupVen3 }, txtVenDebMat, txtVenFinMat, txtVenDebMatMin, txtVenFinMatMin, txtVenDebSoir, txtVenFinSoir, txtVenDebSoirMin, txtVenFinSoirMin);
      SetDefaultValue(chkCoupSam, new apiLabel[] { lblCoupSam0, lblCoupSam1, lblCoupSam2, lblCoupSam3 }, txtSamDebMat, txtSamFinMat, txtSamDebMatMin, txtSamFinMatMin, txtSamDebSoir, txtSamFinSoir, txtSamDebSoirMin, txtSamFinSoirMin);
      SetDefaultValue(chkCoupDim, new apiLabel[] { lblCoupDim0, lblCoupDim1, lblCoupDim2, lblCoupDim3 }, txtDimDebMat, txtDimFinMat, txtDimDebMatMin, txtDimFinMatMin, txtDimDebSoir, txtDimFinSoir, txtDimDebSoirMin, txtDimFinSoirMin);
    }

    public void copySelectedOnOthers()
    {
      DataRow lFocusedRow = apiTGrid1.GetFocusedDataRow();
      if (lFocusedRow == null) return;

      foreach (DataRow lCurrentRow in dt.Rows)
      {
        if (!DataRowComparer.Equals(lFocusedRow, lCurrentRow))
        {
          if (!mBManageDefaultValue)
          {
            lCurrentRow[COLUMNNAME_CGESTION] = lFocusedRow[COLUMNNAME_CGESTION];
          }
          lCurrentRow["NDEPAST"] = lFocusedRow["NDEPAST"];
          lCurrentRow["TXDEPAST"] = lFocusedRow["TXDEPAST"];
          lCurrentRow["NDEPRAP"] = lFocusedRow["NDEPRAP"];
          lCurrentRow["TXDEPRAP"] = lFocusedRow["TXDEPRAP"];
          lCurrentRow["NDEPMOY"] = lFocusedRow["NDEPMOY"];
          lCurrentRow["TXDEPMOY"] = lFocusedRow["TXDEPMOY"];
          lCurrentRow["NDEPLEN"] = lFocusedRow["NDEPLEN"];
          lCurrentRow["TXDEPLEN"] = lFocusedRow["TXDEPLEN"];
          lCurrentRow["NTRANSDEVIS"] = lFocusedRow["NTRANSDEVIS"];
          lCurrentRow["TXREALTRVX"] = lFocusedRow["TXREALTRVX"];
          lCurrentRow["NREALTRVX"] = lFocusedRow["NREALTRVX"];
          lCurrentRow["NRESOCMDE"] = lFocusedRow["NRESOCMDE"];
          lCurrentRow["NRESPPLANMAINT"] = lFocusedRow["NRESPPLANMAINT"];
          lCurrentRow["TXENQQUAL"] = lFocusedRow["TXENQQUAL"];
        }
      }
    }
  }
}
