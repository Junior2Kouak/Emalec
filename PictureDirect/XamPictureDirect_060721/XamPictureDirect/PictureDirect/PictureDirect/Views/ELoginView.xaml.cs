////////////////////////////////////////////////////////////////////////
//  PROJECT :   Emalec Mobile PictureDirect         
//  --------															                              
//																		                                  
//  MODULE  :   PictureDirect.View   
//  --------															                              
//																		                                  
//  FILE    :	  EDemandesView.xaml.cs                     	
//  --------															                              
//																		                                  
//  DESCRIPTION :                                   					          
//  -----------	                                            			      
//	  Definition de la Vue de la liste des Demandes d'Intervention
//																		                                  
//																		                                  
//  AUTHOR       DATE    VERSION     MODIFICATION						            
//  --------------------------------------------------------------------
//  APITECH  !25.09.18! V0.01    ! Creation of the file					        
//           !        !          !                  					          
////////////////////////////////////////////////////////////////////////

using System;
using System.Diagnostics;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using PictureDirect.ViewModels;

namespace PictureDirect.Views
{
  //----------------------------------------------------------------------------
  /// <summary>
  /// Page : 'Liste des Demandes d'Intervention'
  /// </summary>
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class ELoginView : ContentPage
  {
    //----------------------------------------------------------------------------
    public ELoginView()
    {
      InitializeComponent();
      BindingContext = new ELoginViewModel(Navigation);
    }

    //----------------------------------------------------------------------------
    public ELoginView(ELoginViewModel viewModel)
    {
      InitializeComponent();
      viewModel.Navigation = Navigation;
      BindingContext = viewModel;
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
        portraitGrid.IsVisible = false;
        landscapeGrid.IsVisible = true;
      }
      else
      {
        portraitGrid.IsVisible = true;
        landscapeGrid.IsVisible = false;
      }
    }
  }
  
}