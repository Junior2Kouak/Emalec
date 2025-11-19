
using PictureDirect.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PictureDirect.Views
{
  //----------------------------------------------------------------------------
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class EPhotoDetailPage : ContentPage
  {
    //----------------------------------------------------------------------------
    public EPhotoDetailPage(EPhotoViewModel vm)
    {
      InitializeComponent();
      BindingContext = vm;
      vm.Navigation = Navigation;
    }

    private double _width;
    private double _height;
    public bool IsLandscape => _width > _height;

    private double _initialImgHeight;
    protected override void OnSizeAllocated(double width, double height)
    {
      base.OnSizeAllocated(width, height);

      _width = width;
      _height = height;

      if (_initialImgHeight == 0)
        _initialImgHeight = img.Height;

      if (IsLandscape)
      {
        img.HeightRequest = height - 200;
      }
      else
      {
        img.HeightRequest = _initialImgHeight;
      }
    }
  }
}