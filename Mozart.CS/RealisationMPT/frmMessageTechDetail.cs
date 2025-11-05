using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MozartCS.RealisationMPT
{
  public partial class frmMessageTechDetail : Form
  {

    string _sNomTech;
    string _sClient;
    string _sChaff;
    string _sLibGroupe;
    string _sVille;
    string _sDIAction;
    string _sDateMsg;
    string _sMessage;

    public string sNomTech
    {
      get => _sNomTech;
      set
      {
        _sNomTech = value;
      }
    }

    public string sClient
    {
      get => _sClient;
      set
      {
        _sClient = value;
      }
    }

    public string sChaff
    {
      get => _sChaff;
      set
      {
        _sChaff = value;
      }
   
    }
    public string sLibGroupe
    {
      get => _sLibGroupe;
      set
      {
        _sLibGroupe = value;
      }
    }

    public string sVille
    {
      get => _sVille;
      set
      {
        _sVille = value;
      }
    }

    public string sDIAction
    {
      get => _sDIAction;
      set
      {
        _sDIAction = value;
      }
    }

    public string sDateMsg
    {
      get => _sDateMsg;
      set
      {
        _sDateMsg = value;
      }
    }

    public string sMessage
    {
      get => _sMessage;
      set
      {
        _sMessage = value;
      }
    }
       

    public frmMessageTechDetail()
    {
      InitializeComponent();
    }

    private void cmdQuitter_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void frmMessageTechDetail_Load(object sender, EventArgs e)
    {

      txtTech.Text = _sNomTech;
      txtClient.Text = _sClient;
      TxtChaff.Text = _sChaff;
      TxtGroupe.Text = _sLibGroupe;
      TxtVille.Text = _sVille;
      TxtDateMsg.Text = _sDateMsg;
      TxtMessage.Text = _sMessage;

    }
  }
}
