using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PictureDirect.Renderers
{
  public class ExtendedViewCell : ViewCell
  {
    public static readonly BindableProperty SelectedBackgroundColorProperty =
        BindableProperty.Create("SelectedBackgroundColor",
                                typeof(Color),
                                typeof(ExtendedViewCell),
                                Color.Default);

    public Color SelectedBackgroundColor
    {
      get { return (Color)GetValue(SelectedBackgroundColorProperty); }
      set { SetValue(SelectedBackgroundColorProperty, value); }
    }

    public static readonly BindableProperty BackgroundColorProperty =
        BindableProperty.Create("BackgroundColor",
                                typeof(Color),
                                typeof(ExtendedViewCell),
                                Color.White);

    public Color BackgroundColor
    {
      get { return (Color)GetValue(BackgroundColorProperty); }
      set { SetValue(BackgroundColorProperty, value); }
    }
  }
}
