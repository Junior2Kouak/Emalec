using Microsoft.VisualBasic;
using MozartCS.Properties;
using MozartLib;
using MozartNet;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmChoixDateTransfertCession : Form
  {
    public frmChoixDateTransfertCession()
    {
      InitializeComponent();
    }

    private void frmChoixDateTransfertCession_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);

        txtDateA0.Text = DateTime.Now.AddDays(-30).ToShortDateString();
        txtDateA1.Text = DateTime.Now.AddDays(-15).ToShortDateString();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    DateTime _curDate = DateTime.MinValue;
    private void Calendar1_CloseUp(object sender, EventArgs e)
    {
      Calendar1.Visible = false;
      if (_curDate == DateTime.MinValue) return;
      if ((int)Calendar1.Tag == 0) txtDateA0.Text = Calendar1.Value.ToShortDateString();
      else if ((int)Calendar1.Tag == 1) txtDateA1.Text = Calendar1.Value.ToShortDateString();
    }
    private void Calendar1_ValueChanged(object sender, EventArgs e)
    {
      if (Calendar1.Visible) _curDate = Calendar1.Value;
    }
    private void cmdDate1_2_Click(object sender, EventArgs e)
    {
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
      DateTime d;
      if (DateTime.TryParse(txtDate, out d))
        _curDate = Calendar1.Value = d;
      else { _curDate = DateTime.MinValue; Calendar1.Value = DateTime.Now; }
      Calendar1.Visible = true;
      Calendar1.ShowCalendar(new MouseEventArgs(MouseButtons.Left, 1, MousePosition.X - this.Location.X, MousePosition.Y - this.Location.Y, 0));
    }


    private void cmdValider_Click(object sender, EventArgs e)
    {
      // test des dates
      if (txtDateA0.Text == "")
      {
        MessageBox.Show(Resources.msg_SaisirDateDeb, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      if (txtDateA1.Text == "")
      {
        MessageBox.Show(Resources.msg_SaisirDateFin, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      TransfertCession();
    }




    private void TransfertCession()
    {
      try
      {
        string strDirCompta = $"{Utils.RechercheParam("REP_COMPTA")}{MozartParams.NomSociete}";

        if (!Directory.Exists(strDirCompta))
          Directory.CreateDirectory(strDirCompta);

        strDirCompta += @"\ECRVCession.txt";
        double dCumul = 0;

        using (SqlDataReader reader = ModuleData.ExecuteReader($"exec api_sp_TransfertFactureCessionAna '{txtDateA0.Text}', '{txtDateA1.Text}'"))
        {
          if (!reader.HasRows)
          {
            MessageBox.Show("Pas de cession Analytique pour cette période!",
                            Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
          }
          using (StreamWriter fichier = File.CreateText(strDirCompta))
          {
            int nb = 0;
            while (reader.Read())
            {
              string strDataProd = $"ANA;PCESS {Utils.BlankIfNull(reader["REFPIECE"])};704999999;6;{Utils.BlankIfNull(reader["DATPIECE"])};" +
                                   $"Produit cession : {Utils.BlankIfNull(reader["LIB"])};;{Utils.ZeroIfNull(reader["NACTVAL"])};" +
                                   $"{Utils.BlankIfNull(reader["DATPIECE"])};;{Utils.ZeroIfNull(reader["NDINCTE"]).ToString()};;";

              string strDataCharge = $"ANA;CCESS {Utils.BlankIfNull(reader["REFPIECE"])};604999999;6;{Utils.BlankIfNull(reader["DATPIECE"])};" +
                                     $"Charge Cession :{Utils.BlankIfNull(reader["LIB"])};{Utils.ZeroIfNull(reader["NACTVAL"])};;" +
                                     $"{Utils.BlankIfNull(reader["DATPIECE"])};;{Utils.ZeroIfNull(reader["NCANNUMMULTI"]).ToString()};;";

              fichier.Write(strDataProd);
              fichier.Write("\r\n");
              fichier.Write(strDataCharge);
              fichier.Write("\r\n");
              nb++;
              dCumul += Convert.ToDouble(Utils.ZeroIfNull(reader["NACTVAL"]));
            }

            // Ecriture des lignes de neutralisation 
            // 2 lignes 
            // FG le 01/09/21
            string strNeutrProd = $"ANA;PCESS ;604999999;6;{txtDateA0.Text};NEUTRALISATION TRANSFERTS ANA - CESSIONS;;{Strings.Format(dCumul, ".00")};;;99999;;";

            string strNeutrCharge = $"ANA;CCESS ;704999999;6;{txtDateA0.Text};NEUTRALISATION TRANSFERTS ANA - CESSIONS;{Strings.Format(dCumul, ".00")};;;;99999;;";


            fichier.Write(strNeutrProd);
            fichier.Write("\r\n");
            fichier.Write(strNeutrCharge);
            fichier.Write("\r\n");

            fichier.Close();

            // copie de sauvegarde du fichier
            string strSav = $@"{Utils.RechercheParam("REP_COMPTA")}{MozartParams.NomSociete}\Archives\ECRVCession{DateTime.Now.ToString("ddmmyyyyhhmmss")}.txt";
            File.Copy(strDirCompta, strSav);

            // message de fin
            MessageBox.Show($"Fin de préparation du fichier.\r\n{nb} Cessions transférées.",
                            Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
        }
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

  }
}

