using MozartCS.Properties;
using MozartNet;
using System.Windows.Forms;

namespace MozartCS
{
  public partial class frmSaisieLettreModeles : Form
  {
    //Dim iIndice As Integer
    public string msTxtLettre;
    int miIndice;

    public frmSaisieLettreModeles()
    {
      InitializeComponent();
    }

    /* OK ---------------------------------------------------------------------*/
    private void frmSaisieLettreModeles_Load(object sender, System.EventArgs e)
    {
      ModuleMain.Initboutons(this);
    }
    //Private Sub Form_Load()
    //InitBoutons Me, frmMenu
    //End Sub

    /* OK ---------------------------------------------------------------------*/
    private void cmdValider_Click(object sender, System.EventArgs e)
    {
      // Retour à frmSaisieLettre
      msTxtLettre = ChoixTexte();
      Close();
    }
    //Private Sub cmdValider_Click()
    //   frmSaisieLettre.txtLettre = ChoixTexte(iIndice)
    //   Unload Me
    //End Sub

    /* OK ---------------------------------------------------------------------*/
    private string ChoixTexte()
    {
      string sTexte = "";

      if (miIndice == 0)
        sTexte = $"{Resources.txt_SaisieLettreMdl_0_1}\r\n\r\n\r\n\r\n{Resources.txt_SaisieLettreMdl_0_2}\r\n{Resources.txt_SaisieLettreMdl_0_3}";
      else if (miIndice == 1)
        sTexte = $"{Resources.txt_SaisieLettreMdl_1_1}\r\n\r\n\r\n\r\n{Resources.txt_SaisieLettreMdl_1_2}";
      else if (miIndice == 2)
        sTexte = $"{Resources.txt_SaisieLettreMdl_2_1}\r\n\r\n\r\n\r\n{Resources.txt_SaisieLettreMdl_2_2}\r\n{Resources.txt_SaisieLettreMdl_2_3}";
      else if (miIndice == 3)
        sTexte = $"{Resources.txt_SaisieLettreMdl_3_1}\r\n\r\n\r\n\r\n{Resources.txt_SaisieLettreMdl_3_2}";

      return sTexte;
    }
    //Private Function ChoixTexte(indice As Integer) As String
    //Dim stexte As String
    //  'relance 1
    //  If indice = 0 Then
    //    stexte = "Après vérification de votre compte, nous avons constaté que le règlement de la facture ci-dessous n'a pas été effectué en totalité à ce jour."
    //    stexte = stexte + vbCrLf + vbCrLf + vbCrLf + vbCrLf
    //    stexte = stexte + "Ci-joint duplicata." + vbCrLf
    //    stexte = stexte + "Nous pensons qu'il s'agit d'un simple oubli et vous remercions de bien vouloir nous adresser le règlement total de ...... euros."
    //  ElseIf indice = 1 Then
    //    stexte = "Nous sommes surpris de constater que vous n'avez toujours pas réglé les factures ci-dessous malgré notre précédent courrier."
    //    stexte = stexte + vbCrLf + vbCrLf + vbCrLf + vbCrLf
    //    stexte = stexte + "Nous vous demandons de bien vouloir faire le nécessaire en réglant la somme de ...... euros sans plus tarder."
    //  ElseIf indice = 2 Then
    //    stexte = "Malgré nos deux précédents courriers de relance, nous n'avons toujours pas reçu le règlement des factures impayées ci-dessous :"
    //    stexte = stexte + vbCrLf + vbCrLf + vbCrLf + vbCrLf
    //    stexte = stexte + "Ci-joint duplicata certifié conforme." + vbCrLf
    //    stexte = stexte + "Très surpris de les voir sans réponse comme sans effet, nous vous demandons de nous adresser le règlement de ...... euros par retour de courrier, faute de quoi nous nous verrions dans l'obligation de recouvrer notre créance par voie judiciaire."
    //  ElseIf indice = 3 Then
    //    stexte = "Malgré nos précédents courriers de relance, nous n'avons toujours pas reçu le réglement des factures impayées ci-dessous :"
    //    stexte = stexte + vbCrLf + vbCrLf + vbCrLf + vbCrLf
    //    stexte = stexte + "Nous sommes contraints de vous adreser une mise en demeure de payer avant envoi de votre dossier à notre service contentieux." + vbCrLf
    //  End If
    //  ChoixTexte = stexte
    //End Function

    /* OK ---------------------------------------------------------------------*/
    private void optModeles_Click(object sender, System.EventArgs e)
    {
      RadioButton rbtn = (RadioButton)sender;
      miIndice = rbtn.TabIndex - 1;
    }
    //Private Sub optModeles_Click(Index As Integer)
    //  iIndice = Index
    //End Sub
  }
}