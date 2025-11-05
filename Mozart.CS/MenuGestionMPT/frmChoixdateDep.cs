using MozartCS.Properties;
using MozartNet;
using System;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmChoixdateDep : Form
  {
    public frmChoixdateDep()
    {
      InitializeComponent();
    }

    /* OK -------------------------------------------------------------------------------------*/
    private void frmChoixdateDep_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);
        DateTime dateTmp = DateTime.Now;
        txtDateA0.Text = (dateTmp.AddYears(-1)).AddDays(-dateTmp.Day + 1).ToShortDateString();
        txtDateA1.Text = dateTmp.AddDays(-dateTmp.Day).ToShortDateString();
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }
    //Private Sub Form_Load()
    // 
    //On Error GoTo handler
    // 
    //  InitBoutons Me, frmMenu
    //  
    //  txtDateA(0) = DateAdd("yyyy", -1, DateAdd("d", -(Day(Date) - 1), Date))
    //  txtDateA(1) = DateAdd("d", -(Day(Date)), Date)
    //  
    //Exit Sub
    //handler:
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub
    //

    /* OK -------------------------------------------------------------------------------------*/
    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdFermer_Click()
    //    Unload Me
    //End Sub
    //

    /* OK -------------------------------------------------------------------------------------*/
    DateTime _curDate = DateTime.MinValue;
    private void CmdDate_Click(object sender, EventArgs e)
    {
      Button btn = sender as Button;
      Calendar1.Tag = btn.Tag;

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
    //Private Sub cmdDate1_Click()
    //    
    //On Error GoTo handler
    //
    //  iTextBoxDate = 0
    //  If Calendar1.Visible Then
    //      
    //      Calendar1.Visible = False
    //  Else
    //      Calendar1.Visible = True
    //      Calendar1.Value = Now
    //  End If
    //  
    //Exit Sub
    //handler:
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub
    //
    //Private Sub cmdDate2_Click()
    // 
    //  iTextBoxDate = 1
    //  If Calendar1.Visible Then
    //      Calendar1.Visible = False
    //  Else
    //      Calendar1.Visible = True
    //  End If
    //  
    //Exit Sub
    //handler:
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub
    //
    //Private Sub Calendar1_Click()
    //
    //  Me.txtDateA(iTextBoxDate) = Calendar1.Value
    //  Calendar1.Visible = False
    //  
    //Exit Sub
    //handler:
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub
    //

    /* OK -------------------------------------------------------------------------------------*/
    private void cmdValider_Click(object sender, EventArgs e)
    {
      try
      {
        //test des dates 
        if (txtDateA0.Text == "")
        {
          MessageBox.Show(Resources.msg_SaisirDateDeb, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        if (txtDateA1.Text == "")
        {
          MessageBox.Show(Resources.msg_SaisirDateFin, Program.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        Cursor = Cursors.WaitCursor;
        frmStatDepannage f = new frmStatDepannage();
        f.mstrDateTxt0 = txtDateA0.Text;
        f.mstrDateTxt1 = txtDateA1.Text;
        f.ShowDialog();
        Cursor = Cursors.Default;
      }
      catch (Exception ex)
      {
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }

    //Private Sub cmdValider_Click()
    // 
    //' test des dates
    //If txtDateA(0) = "" Then
    //    MsgBox "§il faut saisir une date de début§"
    //    Exit Sub
    //End If
    //
    //If txtDateA(1) = "" Then
    //    MsgBox "§il faut saisir une date de fin§"
    //    Exit Sub
    //End If
    //
    //Screen.MousePointer = vbHourglass
    //frmStatDepannage.Show vbModal
    //Screen.MousePointer = vbDefault
    //
    //Exit Sub
    //handler:
    //  ShowError "cmdValider_Click dans " & Me.Name
    //End Sub
    //
  }
}