using MozartCS.Properties;
using MozartNet;
using MozartLib;
using System.Data;
using System.Windows.Forms;

namespace MozartCS
{
  public partial class frmPlanSelectTech : Form
  {
    public string sListeSelectTech = "";

    DataTable dt = new DataTable();
    //Dim rs As ADODB.Recordset

    public frmPlanSelectTech()
    {
      InitializeComponent();
    }

    private void frmPlanSelectTech_Load(object sender, System.EventArgs e)
    {
      ModuleMain.Initboutons(this);

      string sSql = $"SELECT NPERNUM, VPERNOM + ' ' + VPERPRE AS TECH FROM TPER WITH (NOLOCK) WHERE VSOCIETE = '{MozartParams.NomSociete}' AND CPERTYP in ('TE','CA', 'BE') " +
                    "and BUTILISATEUR = 0 AND CPERACTIF = 'O' AND BVISUPLANNING = 1 ORDER BY VPERNOM";
      ModuleData.LoadData(dt, sSql);
      listTech.DataSource = dt;
      listTech.DisplayMember = "TECH";
      listTech.ValueMember = "NPERNUM";
    }
    //Private Sub Form_Load()
    //Dim i As Integer
    //    InitBoutons Me, frmMenu
    //    Set rs = New ADODB.Recordset
    //    rs.Open "select npernum,vpernom + ' ' + vperpre as tech from tper WITH (NOLOCK) where VSOCIETE = '" & gstrNomSociete & "' AND cpertyp in ('TE','CA', 'BE') and BUTILISATEUR=0 AND CPERACTIF = 'O' AND BVISUPLANNING = 1 order by vpernom", cnx
    //    If rs.RecordCount = 0 Then Exit Sub
    //    rs.MoveFirst
    //    For i = 0 To rs.RecordCount - 1
    //        listTech.AddItem rs("tech"), i
    //        listTech.ItemData(i) = rs("npernum")
    //        rs.MoveNext
    //    Next
    //End Sub

    private void cmdFermer_Click(object sender, System.EventArgs e)
    {
      Dispose();
    }
    //Private Sub cmdFermer_Click()
    //    rs.Close
    //    Unload Me
    //End Sub

    private void cmdValider_Click(object sender, System.EventArgs e)
    {
      foreach (DataRowView item in listTech.CheckedItems)
        sListeSelectTech += $",{item.Row.ItemArray[0]}";

      // On supprime la premiere virgule
      if (sListeSelectTech.Length > 0)
        sListeSelectTech = sListeSelectTech.Substring(1);
      Close();
    }
    //Private Sub cmdValider_Click()
    //Dim i As Integer
    //    If listTech.SelCount > 0 Then
    //        For i = 0 To listTech.ListCount - 1
    //            If listTech.Selected(i) Then
    //                ' construction de la chaine de npernum
    //                frmPlan.sListeSelectTech = frmPlan.sListeSelectTech + "," + CStr(listTech.ItemData(i))
    //            End If
    //        Next i
    //        ' on supprime la premiere virgule
    //        frmPlan.sListeSelectTech = Right(frmPlan.sListeSelectTech, Len(frmPlan.sListeSelectTech) - 1)
    //        rs.Close
    //        Unload Me
    //    End If
    //End Sub

    private void listTech_ItemCheck(object sender, ItemCheckEventArgs e)
    {
      if (_lockCheck)
      {
        _lockCheck = false;
        e.NewValue = e.CurrentValue;
        return;
      }
      if (listTech.CheckedItems.Count >= 4)
      {
        if (e.CurrentValue != CheckState.Checked)
        {
          e.NewValue = CheckState.Unchecked;
          MessageBox.Show(Resources.msg_Max4tech);
        }
      }
    }
    private bool _lockCheck = false;
    private void listTech_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
    {
      if (e.KeyCode != Keys.Space) _lockCheck = true;
    }
    //Private Sub listTech_ItemCheck(Item As Integer)
    //    If listTech.SelCount > 4 Then
    //        listTech.Selected(Item) = False
    //        MsgBox ("Vous devez sélectionner au maximum 4 techniciens")
    //    End If
    //End Sub
  }
}