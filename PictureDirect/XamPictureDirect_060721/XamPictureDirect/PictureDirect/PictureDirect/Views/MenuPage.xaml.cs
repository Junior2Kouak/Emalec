using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using PictureDirect.Models;
using PictureDirect.ViewModels;

namespace PictureDirect.Views
{
  //----------------------------------------------------------------------------
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class MenuPage : ContentPage
  {
    //----------------------------------------------------------------------------
    public MenuPage()
    {
      InitializeComponent();
      BindingContext = new MenuViewModel(Navigation);
      
    }
  }
}