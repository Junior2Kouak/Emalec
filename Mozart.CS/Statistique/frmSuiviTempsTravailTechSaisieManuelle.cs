using MozartNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MozartCS
{
  public partial class frmSuiviTempsTravailTechSaisieManuelle : Form
  {    
    string _fieldname;
    int _duree_seconde_MOZART;
    int _NID_SUIVI_TPS_TRAJET;
    string _sColText;
    bool _bChangeValid;

    int _num_semaine_iso;
    int _num_annee;
    int _NPERNUM;

    CSUIVI_TPS_TRAJET_MAN oCSUIVI_TPS_TRAJET_MAN;

    public string fieldname
    {
      get => _fieldname;
      set
      {
      _fieldname = value;       
      }
    }

    public int duree_seconde_MOZART
    {
      get => _duree_seconde_MOZART;
      set
      {
        _duree_seconde_MOZART = value;
      }
    }

    public int NID_SUIVI_TPS_TRAJET
    {
      get => _NID_SUIVI_TPS_TRAJET;
      set
      {
        _NID_SUIVI_TPS_TRAJET = value;
      }
    }

    public int N_TOT_SEC_MAN
    {
      get => (oCSUIVI_TPS_TRAJET_MAN == null) ? 0 : oCSUIVI_TPS_TRAJET_MAN.N_TOT_SEC_MAN;     
    }

    public string sColText
    {
      get => _sColText;
      set
      {
        _sColText = value;
      }
    }
    public bool bChangeValid
    {
      get => _bChangeValid;     
    }


    public int num_semaine_iso
    {
      get => _num_semaine_iso;
      set
      {
        _num_semaine_iso = value;
      }
    }

    public int num_annee
    {
      get => _num_annee;
      set
      {
        _num_annee = value;
      }
    }

    public int NPERNUM
    {
      get => _NPERNUM;
      set
      {
        _NPERNUM = value;
      }
    }

    public frmSuiviTempsTravailTechSaisieManuelle()
    {
      InitializeComponent();
    }

    private void frmSuiviTempsTravailTechSaisieManuelle_Load(object sender, EventArgs e)
    {

      //init
      ModuleMain.Initboutons(this);

      Lbl_H_MOZARIS.Text = "";
      Lbl_M_MOZARIS.Text = "";
      _bChangeValid = false;

      LoadData();

    }
    private void LoadData()
    {
        oCSUIVI_TPS_TRAJET_MAN = new CSUIVI_TPS_TRAJET_MAN(_NID_SUIVI_TPS_TRAJET, _fieldname, _duree_seconde_MOZART, _sColText, _num_semaine_iso, _num_annee, _NPERNUM);

        if (oCSUIVI_TPS_TRAJET_MAN != null)
        {

        if(oCSUIVI_TPS_TRAJET_MAN.NID_SUIVI_TPS_TRAJET_MAN == 0)
                {
                    NUP_Heure_Man.Value = oCSUIVI_TPS_TRAJET_MAN.NHEURE_MOZARIS;
                    NUP_Minute_Man.Value = oCSUIVI_TPS_TRAJET_MAN.NMINUTE_MOZARIS;
                }
        else
                {
                    NUP_Heure_Man.Value = oCSUIVI_TPS_TRAJET_MAN.NHEURE_MAN;
                    NUP_Minute_Man.Value = oCSUIVI_TPS_TRAJET_MAN.NMINUTE_MAN;
                }                 
        
        TxtHisto.Text = oCSUIVI_TPS_TRAJET_MAN.VHISTO;

        Lbl_H_MOZARIS.Text = oCSUIVI_TPS_TRAJET_MAN.NHEURE_MOZARIS.ToString("00");
        Lbl_M_MOZARIS.Text = oCSUIVI_TPS_TRAJET_MAN.NMINUTE_MOZARIS.ToString("00");  

        }        

    }

    private void BtnValider_Click(object sender, EventArgs e)
    {

      //on teste si commentairte saisie
      if(TxtObs.Text == "")
      {
        MessageBox.Show("Il faut saisir une observation !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      ////on teste si heure saisie
      //if (NUP_Heure_Man.Value == 0 && NUP_Minute_Man.Value == 0)
      //{
      //  MessageBox.Show("Il faut saisir une durée !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      //  return;
      //}           

      oCSUIVI_TPS_TRAJET_MAN.VOBS_MAN = TxtObs.Text;     
      oCSUIVI_TPS_TRAJET_MAN.N_TOT_SEC_MAN = (int)NUP_Heure_Man.Value * 3600 + (int)NUP_Minute_Man.Value * 60;

      oCSUIVI_TPS_TRAJET_MAN.Save();

      //LoadData();

      _bChangeValid = true;

      Close();

    }
  }
}
