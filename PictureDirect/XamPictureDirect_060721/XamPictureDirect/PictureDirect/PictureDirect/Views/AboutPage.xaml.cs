
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PictureDirect.Views
{
  //----------------------------------------------------------------------------
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class AboutPage : ContentPage
  {
    //----------------------------------------------------------------------------
    public AboutPage()
    {
      InitializeComponent();
    }

    private double _width;
    private double _height;
    public bool IsLandscape => _width > _height;

    protected override void OnSizeAllocated(double width, double height)
    {
      base.OnSizeAllocated(width, height);

      _width = width;
      _height = height;

      if (IsLandscape)
      {
        portraitHeader.IsVisible = false;
        landscapeHeader.IsVisible = true;
      }
      else
      {
        portraitHeader.IsVisible = true;
        landscapeHeader.IsVisible = false;
      }
    }
  }
}