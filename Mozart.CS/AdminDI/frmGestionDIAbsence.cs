using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmGestionDIAbsence : Form
  {
    DataTable dt = new DataTable();

    public frmGestionDIAbsence()
    {
      InitializeComponent();
    }

    private void frmListeDIsansAction_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);
        apigrid.LoadData(dt, MozartDatabase.cnxMozart, "exec api_sp_listedi_Absence");
        apigrid.GridControl.DataSource = dt;
        InitApigrid();
        Cursor.Current = Cursors.Default;
      }
      catch (Exception ex)
      {
        Cursor.Current = Cursors.Default;
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void InitApigrid()
    {
      try
      {
        apigrid.AddColumn(Resources.col_Site, "VSITNOM", 2000);
        apigrid.AddColumn("DI rattachée", "NDINNUM", 1000, "", 2);
        apigrid.AddColumn(" ", "BOUTON", 500, "", 2);
        apigrid.AddColumn(Resources.col_Num_site, "NSITNUM", 0);

        apigrid.DelockColumn("BOUTON");
        apigrid.InitColumnList();
        apigrid.FilterBar = false;
        apigrid.GridControl.BackColor = ColorTranslator.FromHtml("&HFFC0C0");

        // ajout d'un bouton dans la colonne bouton
        RepositoryItemButtonEdit BtnDI = new RepositoryItemButtonEdit()
        {
          TextEditStyle = TextEditStyles.HideTextEditor,
          ReadOnly = true,

        };
        BtnDI.ButtonClick += new ButtonPressedEventHandler(btnDI_ButtonClick);

        EditorButton Button = new EditorButton(ButtonPredefines.OK)
        {
          ToolTip = "Cliquez ici pour modifier la DI",
          Caption = "DI",
        };

        BtnDI.Buttons.Clear();
        BtnDI.Buttons.Add(Button);

        apigrid.GridControl.RepositoryItems.Add(BtnDI);
        apigrid.dgv.Columns["BOUTON"].ColumnEdit = BtnDI;

      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void btnDI_ButtonClick(object sender, ButtonPressedEventArgs e)
    {
      DevExpress.XtraEditors.ButtonEdit editor = (DevExpress.XtraEditors.ButtonEdit)sender;
      EditorButton Button = e.Button;

      DataRow row = apigrid.GetFocusedDataRow();
      if (null == row) return;

      string NumDI = row["NDINNUM"].ToString();

      // demande du numéro de DI
      NumDI = Interaction.InputBox("Saisir le N° de DI", "N° DI", NumDI);
      if (NumDI == "") return;

      if (!Utils.IsNumeric(NumDI))
      {
        MessageBox.Show($"Il faut saisir un numéro de DI, sans lettre", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      // test si le numéro de DI est bien sur le site sélectionné
      if (!TestDI(Convert.ToInt32(NumDI), Convert.ToInt32(row["NSITNUM"])))
      {
        MessageBox.Show($"Cette DI n'est pas valide sur ce site", Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }
      else
      {
        // mise à jour dans la base
        ModuleData.ExecuteNonQuery($"update tliensitdi set ndinnum = {NumDI} where nsitnum = {row["NSITNUM"].ToString()}");
      }

      // refresh de la liste
      apigrid.Requery(dt, MozartDatabase.cnxMozart);

    }

    /* --------------------------------------------------------------------------------------- */
    private bool TestDI(long p_NDINNUM, long p_NSITNUM)
    {
      try
      {
        return (Convert.ToInt16(ModuleData.ExecuteScalarInt("EXEC api_sp_testDI " + p_NDINNUM + "," + p_NSITNUM)) > 0);
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      return false;
    }

    private void cmdQuitter_Click(object sender, System.EventArgs e)
    {
      Cursor.Current = Cursors.Default;
      Dispose();
    }



  }
}