////////////////////////////////////////////////////////////////////////
//  PROJECT :   Emalec Mobile PictureDirect         
//  --------															                              
//																		                                  
//  MODULE  :   PictureDirect.View   
//  --------															                              
//																		                                  
//  FILE    :	  EActionDetailPage.xaml.cs                     	
//  --------															                              
//																		                                  
//  DESCRIPTION :                                   					          
//  -----------	                                            			      
//	  Definition de la Vue du détail d'une Action : prise de photo
//																		                                  
//																		                                  
//  AUTHOR       DATE    VERSION     MODIFICATION						            
//  --------------------------------------------------------------------
//  APITECH  !25.09.18! V0.01    ! Creation of the file					        
//           !        !          !                  					          
////////////////////////////////////////////////////////////////////////

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using PictureDirect.Models;
using PictureDirect.ViewModels;
using System;
using Plugin.Media;
using PictureDirect.WCFService;
using Plugin.Permissions.Abstractions;

namespace PictureDirect.Views
{
  //----------------------------------------------------------------------------
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class EActionDetailPage : ContentPage
  {
    //----------------------------------------------------------------------------
    //public EActionDetailPage()
    //{
    //  InitializeComponent();

    //  var item = new ActionContract
    //  {
    //    Id = 0,
    //    Name = "Action!"
    //  };

    //  BindingContext = new EActionDetailViewModel(Navigation, item);
    //}

    //----------------------------------------------------------------------------
    public EActionDetailPage(EActionDetailViewModel viewModel)
    {
      InitializeComponent();

      BindingContext = viewModel;
      viewModel.Navigation = Navigation;
    }
  }
}