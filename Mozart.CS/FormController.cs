using System.Windows.Forms;

namespace MozartCS
{
  class FormController
  {

    private readonly Form mobjMDIForm;

    private frmContainer mobjFormContainer;

    public FormController(Form objMDIForm, string strActiveXLib)
    {
      mobjMDIForm = objMDIForm;
    }

    public void OpenForm(string strFormName)
    {

      if (null == mobjFormContainer || true == mobjFormContainer.IsDisposed)
      {
        mobjFormContainer = new frmContainer();

        mobjFormContainer.OpenForm(mobjMDIForm, strFormName);
      }
      else
      {
        mobjFormContainer.Activate();
      }
    }

  }

}
