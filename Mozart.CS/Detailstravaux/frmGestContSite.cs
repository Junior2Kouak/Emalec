using MozartNet;
using System.Reflection;
using System.Windows.Forms;
using MZUtils = MozartControls.Utils;

namespace MozartCS
{
  public partial class frmGestContSite : Form
  {
    //Public msDuree As String
    //Public miNumSite As Long
    //Dim adoRS_Pri As ADODB.Recordset
    public string msDuree;
    public long miNumSite;


    public frmGestContSite()
    {
      InitializeComponent();
    }

    //Private Sub Form_Load()
    //On Error GoTo handler
    //  ' initialisation des boutons
    //  InitBoutons Me, frmMenu
    //  Set adoRS_Pri = New ADODB.Recordset
    //  adoRS_Pri.Open "SELECT NDUREEINTER FROM TCONT WITH (NOLOCK)  WHERE TCONT.NSITNUM = " & miNumSite & " AND TCONT.NTYPECONTRAT = 247", cnx, adOpenStatic, adLockOptimistic
    //  If adoRS_Pri.EOF Then Exit Sub
    //  txtduree = adoRS_Pri("NDUREEINTER")
    //Exit Sub
    //handler:
    //  Screen.MousePointer = vbDefault
    //  ShowError "Form_Load dans " & Me.Name
    //End Sub
    private void frmGestContSite_Load(object sender, System.EventArgs e)
    {
      try
      {
        ModuleMain.Initboutons(this);

        txtduree.Text = ModuleData.ExecuteScalarString("SELECT NDUREEINTER FROM TCONT WITH (NOLOCK) " +
                                                        $"WHERE TCONT.NSITNUM = {miNumSite} AND TCONT.NTYPECONTRAT = 247");
      }
      catch (System.Exception ex)
      {
        Cursor.Current = Cursors.Default;
        MZUtils.displayError(MethodBase.GetCurrentMethod().Name, ex);
      }
    }


    //Private Sub cmdValider_Click()
    //  cnx.Execute "Update TCONT set NDUREEINTER= " & Replace(txtduree, ",", ".") & " WHERE TCONT.NSITNUM = " & miNumSite & " AND TCONT.NTYPECONTRAT = 247"
    //End Sub
    private void cmdValider_Click(object sender, System.EventArgs e)
    {
      ModuleData.ExecuteNonQuery($"Update TCONT set NDUREEINTER= {txtduree.Text.Replace(",", ".")} WHERE TCONT.NSITNUM = {miNumSite} AND TCONT.NTYPECONTRAT = 247");
    }

    //Private Sub txtduree_KeyPress(KeyAscii As Integer)
    //' Contrôle de numéricité
    //  If KeyAscii = 8 Then Exit Sub
    //  If KeyAscii = 46 Then Exit Sub
    //  If KeyAscii < 48 Or KeyAscii > 57 Then KeyAscii = 0
    //End Sub
    private void txtduree_KeyPress(object sender, KeyPressEventArgs e)
    {
      KeyValidator.KeyPress_SaisieMontant(e);// pour virgule
    }

    //Private Sub cmdFermer_Click()
    //    Unload Me
    //End Sub
    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
  }
}

