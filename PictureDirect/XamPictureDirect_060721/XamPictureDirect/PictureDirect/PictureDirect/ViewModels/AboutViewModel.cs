using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace PictureDirect.ViewModels
{
  //----------------------------------------------------------------------------
  public class AboutViewModel : EBaseViewModel
  {
    //----------------------------------------------------------------------------
    public AboutViewModel()
    {
      Title = "A propos";

      OpenWebCommand = new Command(() => Device.OpenUri(new Uri("http://www.emalec.com")));
    }

    public ICommand OpenWebCommand { get; }
  }
}