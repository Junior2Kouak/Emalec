using Microsoft.VisualBasic;
using MozartLib;
using MozartNet;
using System;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmSaisieAlertRavel : Form
  {
    public long miNumObjet;
    public string mstrType;

    public frmSaisieAlertRavel() { InitializeComponent(); }

    private void frmSaisieAlertRavel_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);
        Initialise();

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

    private void cmdValider_Click(object sender, System.EventArgs e)
    {
      if (mstrType == "FOURNISSEUR")
        ModuleData.ExecuteNonQuery($"update TCOM set CCOMALERT='O', VCOMALERT = '{txtDetail.Text.Replace("'", "''")}' WHERE  NCOMNUM = {miNumObjet}");
      else
        ModuleData.ExecuteNonQuery($"update TCST set CCSTALERT='O', VCSTALERT = '{txtDetail.Text.Replace("'", "''")}', CCSTACOMPTE = '{(chkAcompte.Checked ? "O" : "N")}' WHERE NCSTNUM = {miNumObjet}");

      // Dans le cas ou la facture ravel a déja été saisie, il faut enregistrer l'alerte dans les observations comptables
      // Modification : FGA le 20/10/2025 demande de Sylvie
      // ne pas mettre l'info sur les observations comptables mais sur les alertes  de la cde dans TFOUFACCDE
      // pas utile , nouvelle gestion dans Ravel
   //   string sSQL = $"UPDATE TFOUFACCDE SET TFOUFACCDE.VALERTE = coalesce(VALERTE,'') + char(13) + char(10) + '{txtDetail.Text.Replace("'", "''")}' FROM  TFOUFAC INNER JOIN TFOUFACCDE " +
    //               $"ON TFOUFAC.NFOUFACNUM = TFOUFACCDE.NFOUFACNUM WHERE TFOUFACCDE.NCDENUM = {miNumObjet} AND TFOUFACCDE.VTYPECDE = 'C{Strings.Left(mstrType, 1)}'";
      //ModuleData.ExecuteNonQuery(sSQL);
      Dispose();
    }
    
    private void txtDetail_Enter(object sender, EventArgs e)
    {
      string temp = $"{MozartParams.strUID} le {DateTime.Now} : ";
      string Msg = Interaction.InputBox("Saisissez votre alerte", "Administration Mozart").Replace("'", "''");

      if (Msg == "")
        return;
      else
        txtDetail.Text = $"{temp}{Msg}\r\n{txtDetail.Text}";
    }

    private void Initialise()
    {
      try
      {
        string sSQL;
        txtDetail.Text = "";
        if (mstrType == "FOURNISSEUR")
        {
          sSQL = $"SELECT  VCOMALERT, 'N' From TCOM WHERE NCOMNUM ={miNumObjet}";
          chkAcompte.Visible = false;
        }
        else
        {
          sSQL = $"SELECT  VCSTALERT, CCSTACOMPTE From TCST WHERE NCSTNUM ={miNumObjet}";
          chkAcompte.Visible = true;
        }
        //  recherche des différents type de contrat
        using (SqlDataReader dr = ModuleData.ExecuteReader(sSQL))
        {
          // lier les textbox avec le recordset
          if (dr.Read())
          {
            txtDetail.Text = Utils.BlankIfNull(dr[0]);
            chkAcompte.Checked = dr[1].ToString() == "O";
          }
        }
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
    
	}
}