using MozartCS.Properties;
using MozartNet;
using System;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmCommissionSec : Form
  {
    public int iNumsite;
    int iID;


    public frmCommissionSec() { InitializeComponent(); }

    private void frmCommissionSec_Load(object sender, System.EventArgs e)
    {
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        ModuleMain.Initboutons(this);

        ModuleData.RemplirCombo(cboClassement, "SELECT NIDCLASSEMENT,VLIB FROM TREF_CLASSCOMSECU ORDER BY VLIB");
        cboClassement.ValueMember = "NIDCLASSEMENT";
        cboClassement.DisplayMember = "VLIB";

        iID = 0;
        InitForm();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
      finally { Cursor.Current = Cursors.Default; }
    }

    private void InitForm()
    {
      using (SqlDataReader dr = ModuleData.ExecuteReader($"exec api_sp_DetailComSecu {iNumsite}"))
      {
        if (dr.Read())
        {
          iID = Convert.ToInt32(Utils.ZeroIfNull(dr["NIDCOMSECU"]));
          txtDateDer.Text = Utils.DateBlankIfNull(dr["DDATEDER"]);
          cboClassement.SetItemData(Convert.ToString(Utils.ZeroIfNull(dr["NIDCLASSEMENT"])));
          lblAnc.Text = $"{dr["DIF"]} {Resources.txt_Jours}";
          lblRet.Text = Convert.ToInt32(Utils.ZeroIfNull(dr["RETARD"])) == 0 ? Resources.txt_Sans_Objet_Conforme : $"{Convert.ToString(Utils.ZeroIfNull(dr["RETARD"]))} {Resources.txt_Jours}";
          cboAvis.Text = Utils.BlankIfNull(dr["VAVIS"]);
          txtnbRes.Text = Utils.ZeroIfNull(dr["NNBRES"]).ToString();
          txtDatelr.Text = Utils.DateBlankIfNull(dr["DDATEALR"], "dd/MM/yyyy");
          lblPeriodicite.Text = $"{Resources.txt_Periodicite} {Utils.ZeroIfNull(dr["NBAN"])} {Resources.txt_ans} ({Utils.ZeroIfNull(dr["NPERIODICITE"])} {Resources.txt_Jours})";
          lblAnnee.Text = Utils.BlankIfNull(dr["PROCAN"]);
          if ((int)dr["NBFIC"] > 0)
            cmdFichier.BackColor = MozartColors.ColorH80FFFF;
          else
            cmdFichier.BackColor = MozartColors.ColorH8000000F;
          txtDateConv.Text = Utils.DateBlankIfNull(dr["DDATECONV"], "dd/MM/yyyy");
        }
      }
    }

    DateTime _curDate = DateTime.MinValue;
    private void cmdDate_Click(object sender, EventArgs e)
    {
      Button btn = sender as Button;
      Calendar1.Tag = btn.Tag;

      string txtDate = "";
      switch ((sender as Button).Name)
      {
        case "cmdDateConve":
          txtDate = txtDateConv.Text;
          Calendar1.Tag = 0;
          break;
        case "cmdDateDer":
          txtDate = txtDateDer.Text;
          Calendar1.Tag = 1;
          break;
        case "cmdDateLr":
          txtDate = txtDatelr.Text;
          Calendar1.Tag = 2;
          break;
        default: return;
      }

      DateTime d;
      if (DateTime.TryParse(txtDate, out d))
        _curDate = Calendar1.Value = d;
      else { _curDate = DateTime.MinValue; Calendar1.Value = DateTime.Now; }

      Calendar1.Visible = true;
      Calendar1.ShowCalendar(new MouseEventArgs(MouseButtons.Left, 1, MousePosition.X - this.Location.X, MousePosition.Y - this.Location.Y, 0));
    }
    /* OK --------------------------------------------------------------------------------------- */
    private void Calendar1_CloseUp(object sender, EventArgs e)
    {
      Calendar1.Visible = false;
      if (_curDate == DateTime.MinValue) return;
      if ((int)Calendar1.Tag == 0) txtDateConv.Text = Calendar1.Value.ToShortDateString();
      else if ((int)Calendar1.Tag == 1) txtDateDer.Text = Calendar1.Value.ToShortDateString();
      else if ((int)Calendar1.Tag == 2) txtDatelr.Text = Calendar1.Value.ToShortDateString();
    }
    private void Calendar1_ValueChanged(object sender, EventArgs e)
    {
      if (Calendar1.Visible) _curDate = Calendar1.Value;
    }

    private void Enregistrer()
    {
      //verifications
      if (Utils.BlankIfNull(txtDateDer.Text) == "")
      {
        MessageBox.Show(Resources.msg_Date_Derniere_Comission_Obligatoire, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      else if (Utils.BlankIfNull(cboClassement.Text) == "")
      {
        MessageBox.Show(Resources.msg_Classement_Obligatoire, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      else if (Utils.BlankIfNull(cboAvis.Text) == "")
      {
        MessageBox.Show(Resources.msg_Avis_Obligatoire, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      else if (!Utils.IsNumeric(txtnbRes.Text))
      {
        MessageBox.Show(Resources.msg_Nbr_Reserve_Pas_Nombre, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      string DateConv = Utils.BlankIfNull(txtDateConv.Text) == "" ? "Null" : $"'{txtDateConv.Text}'";

      string sSql = $"exec api_sp_CreationComSecu {iID}, {iNumsite}, '{txtDateDer.Text}', '{txtDatelr.Text}', '{cboAvis.Text}', {cboClassement.GetItemData()}, {Utils.ZeroIfNull(txtnbRes.Text)}, {DateConv}";

      ModuleData.ExecuteNonQuery(sSql);
    }

    private void cmdValider_Click(object sender, EventArgs e)
    {
      Enregistrer();
      InitForm();
    }

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }

    private void cmdSupp1_Click(object sender, EventArgs e)
    {
      txtDateDer.Text = "";
    }

    private void cmdSupp2_Click(object sender, EventArgs e)
    {
      txtDatelr.Text = "";
    }

    /* --------------------------------------------------------------------------------------- */
    //Pas à implémenter 
    //Private Sub cmdProg_Click()
    //Dim fso As Object
    //Dim path As String
    //Dim Folder
    //Dim Y
    //Dim ts, ts2
    //Dim sNomFic, sFichier, sdate, ssite, sjour, smois, sannee, sSql As String
    //Dim rs As ADODB.Recordset
    //Dim fs As New FileSystemObject
    //Dim Rep
    //
    //  Set fso = CreateObject("Scripting.FileSystemObject")
    //
    //  path = "C:\COMMISSIONS"
    //  Set Folder = fso.GetFolder(path)
    //  Rep = RechercheParam("REP_COMSECU")
    //  
    //  For Each Y In Folder.Files
    //      Set rs = New ADODB.Recordset
    //      
    //      sFichier = Y.path
    //      ts = Split(sFichier, "\")
    //      sNomFic = ts(UBound(ts))
    //      
    //      ts2 = Split(sNomFic, "-")
    //      
    //      ssite = ts2(UBound(ts2) - 1)
    //      
    //      sdate = ts2(UBound(ts2))
    //      sjour = Left(sdate, 2)
    //      smois = Mid(sdate, 3, 2)
    //      sannee = Mid(sdate, 5, 4)
    //      
    //      ' TB SAMSIC CITY SPEC
    //      If gstrNomGroupe = "EMALEC" Then
    //        sSql = "SELECT NIDCOMSECU FROM TCOMSECU WHERE NSITNUM IN (SELECT NSITNUM FROM TSIT WHERE NSITNUE = '" & ssite & "' AND NCLINUM = 1597)"
    //      End If ' TB SAMSIC CITY TODO -> else pour samsic
    //      rs.Open sSql, cnx
    //      
    //      If rs.RecordCount > 0 Then
    //        fs.CopyFile sFichier, Rep & Replace(sNomFic, "'", "")
    //        sSql = "INSERT INTO TCOMSECUFIC VALUES (" & rs(0) & ",'" & Rep & Replace(sNomFic, "'", "") & "','" & sjour & "/" & smois & "/" & sannee & "')"
    //        cnx.Execute sSql
    //        fs.DeleteFile sFichier
    //      Else
    //        rs.Close
    //        ' TB SAMSIC CITY SPEC
    //        If gstrNomGroupe = "EMALEC" Then
    //          sSql = "SELECT NSITNUM FROM TSIT WHERE NSITNUE = '" & ssite & "' AND NCLINUM = 1597"
    //        End If ' TB SAMSIC CITY TODO -> else pour samsic
    //        rs.Open sSql, cnx
    //        
    //        If rs.RecordCount > 0 Then
    //        sSql = "INSERT INTO TCOMSECU (NSITNUM, DDATEDER) VALUES( " & rs(0) & ",'" & sjour & "/" & smois & "/" & sannee & "')"
    //        cnx.Execute sSql
    //        
    //        rs.Close
    //        ' TB SAMSIC CITY SPEC
    //        If gstrNomGroupe = "EMALEC" Then
    //          sSql = "SELECT NIDCOMSECU FROM TCOMSECU WHERE NSITNUM IN (SELECT NSITNUM FROM TSIT WHERE NSITNUE = '" & ssite & "' AND NCLINUM = 1597)"
    //        End If ' TB SAMSIC CITY TODO -> else pour samsic
    //        rs.Open sSql, cnx
    //        If rs.RecordCount > 0 Then
    //          fs.CopyFile sFichier, Rep & Replace(sNomFic, "'", "")
    //          sSql = "INSERT INTO TCOMSECUFIC VALUES (" & rs(0) & ",'" & Rep & Replace(sNomFic, "'", "") & "','" & sjour & "/" & smois & "/" & sannee & "')"
    //          cnx.Execute sSql
    //          fs.DeleteFile sFichier
    //        Else
    //          MsgBox "Erreur"
    //        End If
    //        End If
    //        rs.Close
    //        
    //      End If
    //    
    //      
    //  Next
    //
    //End Sub
    //
    /* --------------------------------------------------------------------------------------- */
    private void cmdFichier_Click(object sender, EventArgs e)
    {
      if (iID != 0)
      {
        new frmComSecuFichier()
        {
          dDate = txtDateDer.Text,
          iID = iID
        }.ShowDialog();
      }
      else
      {
        MessageBox.Show(Resources.msg_Validation_Commission_Securite, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }
    }

    private void cmdSuppDateConv_Click(object sender, EventArgs e)
    {
      txtDateConv.Text = "";
    }

  }
}

