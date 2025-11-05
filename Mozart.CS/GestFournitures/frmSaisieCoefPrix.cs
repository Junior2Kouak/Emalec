using MozartCS.Properties;
using MozartNet;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MozartCS
{
  public partial class frmSaisieCoefPrix : Form
  {
    //Public miNumClient As Long
    //Public BListeFournitureEI As Boolean
    public long miNumClient;
    public bool mbListeFournitureEI;

    public List<int> listFournitureToRevise;
    public int iNbFoTotalPrixCli;

        public frmSaisieCoefPrix()
    {
      InitializeComponent();
    }

        private void frmSaisieCoefPrix_Load(object sender, EventArgs e)
        {
            label4.Text = $"Nombre de fournitures filtrées / Total : {listFournitureToRevise.Count}  / {iNbFoTotalPrixCli}";
        }

        //Private Sub txtCoef_KeyPress(KeyAscii As Integer)
        //  If KeyAscii = 8 Then Exit Sub
        //  If KeyAscii = 46 Then KeyAscii = 44
        //  If KeyAscii = 44 Then Exit Sub  'pour la virgule
        //  If KeyAscii< 48 Or KeyAscii > 57 Then KeyAscii = 0
        //End Sub
        private void txtCoef_KeyPress(object sender, KeyPressEventArgs e)
    {
      KeyValidator.KeyPress_SaisieMontant(e);
    }

    //Private Sub cmdValider_Click()
    //Dim sSQL As String
    //' distinction entre les listes de fournitures EI et les listes classiques
    //If BListeFournitureEI Then
    //  If MsgBox("§Etes-vous certains d'appliquer ce coefficient ?§", vbYesNo) = vbYes Then
    //      sSQL = "UPDATE TSTOCKARTCLI SET NPUHTCLI = NPUHTCLI * CONVERT (DECIMAL(9,4),REPLACE('" & txtCoef & "' ,',','.')) FROM TSTOCKARTCLI INNER JOIN" _
    //                                                     & " TFOU ON TFOU.NFOUNUM = TSTOCKARTCLI.NFOUNUM AND TFOU.NCFOCOD = 31 WHERE TSTOCKARTCLI.NCLINUM = " & miNumClient
    //      cnx.Execute sSQL
    //  End If
    //Else
    //  If MsgBox("§Etes-vous certains d'appliquer ce coefficient ?§", vbYesNo) = vbYes Then
    //      sSQL = "UPDATE TSTOCKARTCLI SET NPUHTCLI = NPUHTCLI * CONVERT (DECIMAL(9,4),REPLACE('" & txtCoef & "' ,',','.')) FROM TSTOCKARTCLI INNER JOIN" _
    //                                                     & " TFOU ON TFOU.NFOUNUM = TSTOCKARTCLI.NFOUNUM AND TFOU.NCFOCOD <> 31 WHERE TSTOCKARTCLI.NCLINUM = " & miNumClient
    //      cnx.Execute sSQL
    //  End If
    //End If
    //Unload Me
    //End Sub
    private void cmdValider_Click(object sender, EventArgs e)
    {
      string sSQL;
            var ListFourn = String.Join(", ", listFournitureToRevise.ToArray());

            if (mbListeFournitureEI)
      {
        if (MessageBox.Show(this, Resources.msg_ConfirmApplyCoef, Program.AppTitle, MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
          sSQL = $"UPDATE TSTOCKARTCLI SET NPUHTCLI = NPUHTCLI * CONVERT (DECIMAL(9,4),REPLACE('{txtCoef.Text}' ,',','.')) FROM TSTOCKARTCLI INNER JOIN"
                 + $" TFOU ON TFOU.NFOUNUM = TSTOCKARTCLI.NFOUNUM AND TFOU.NCFOCOD = 31 WHERE TSTOCKARTCLI.NCLINUM = {miNumClient} AND TSTOCKARTCLI.NFOUNUM IN ({ListFourn})";
          ModuleData.ExecuteScalarString(sSQL);
        }
      }
      else
      {
        if (MessageBox.Show(this, Resources.msg_ConfirmApplyCoef, Program.AppTitle, MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
          sSQL = $"UPDATE TSTOCKARTCLI SET NPUHTCLI = NPUHTCLI * CONVERT (DECIMAL(9,4),REPLACE('{txtCoef.Text}' ,',','.')) FROM TSTOCKARTCLI INNER JOIN"
                  + $" TFOU ON TFOU.NFOUNUM = TSTOCKARTCLI.NFOUNUM AND TFOU.NCFOCOD <> 31 WHERE TSTOCKARTCLI.NCLINUM = {miNumClient} AND TSTOCKARTCLI.NFOUNUM IN ({ListFourn})";
          ModuleData.ExecuteScalarString(sSQL);
        }
      }
      this.Dispose();
    }

    private void cmdFermer_Click(object sender, EventArgs e)
    {
      this.Dispose();
    }

       
    }
}
