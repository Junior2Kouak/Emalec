
using System.Collections.Generic;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using PictureDirect.Models;

namespace PictureDirect.Views
{
  //----------------------------------------------------------------------------
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class MainPage : MasterDetailPage
  {
    //----------------------------------------------------------------------------
    public MainPage()
    {
      InitializeComponent();
    }
  }
}