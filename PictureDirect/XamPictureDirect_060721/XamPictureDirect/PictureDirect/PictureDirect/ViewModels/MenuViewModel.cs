////////////////////////////////////////////////////////////////////////
//  PROJECT :   Emalec Mobile PictureDirect         
//  --------															                              
//																		                                  
//  MODULE  :   PictureDirect.ViewModels   
//  --------															                              
//																		                                  
//  FILE    :	  EActionViewModel.cs                     	
//  --------															                              
//																		                                  
//  DESCRIPTION :                                   					          
//  -----------	                                            			      
//	  Definition du Vue-Modele d'une Action (associée à une Demande d'Intervention)
//																		                                  
//																		                                  
//  AUTHOR       DATE    VERSION     MODIFICATION						            
//  --------------------------------------------------------------------
//  APITECH  !25.09.18! V0.01    ! Creation of the file					        
//           !        !          !                  					          
////////////////////////////////////////////////////////////////////////

using PictureDirect.Models;
using PictureDirect.Views;
using PictureDirect.WCFService;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PictureDirect.ViewModels
{
  //----------------------------------------------------------------------------
  /// <summary>
  /// Vue Modèle d'une Action (associée à une Demande d'Intervention)
  /// </summary>
  public class MenuViewModel : EBaseViewModel
  {
    //----------------------------------------------------------------------------
    public MenuViewModel(INavigation navigation)
    {
      Navigation = navigation;

      NavigateToLoginCommand = new Command(async () => await ExecuteNavigateToLoginCommandAsync());
      NavigateToAboutCommand = new Command(async () => await ExecuteNavigateToAboutCommandAsync());
    }

    public Command NavigateToLoginCommand { get; set; }

    public Command NavigateToAboutCommand { get; set; }

    private async Task ExecuteNavigateToLoginCommandAsync()
    {
      MasterDetailPage masterDetailPage = Application.Current.MainPage as MasterDetailPage;

      if (masterDetailPage != null)
      {
        masterDetailPage.Detail = new NavigationPage(new ELoginView(new ELoginViewModel(Navigation)));

        if (Device.RuntimePlatform == Device.Android)
          await Task.Delay(100);

        masterDetailPage.IsPresented = false;
      }
    }

    private async Task ExecuteNavigateToAboutCommandAsync()
    {
      MasterDetailPage masterDetailPage = Application.Current.MainPage as MasterDetailPage;

      if (masterDetailPage != null)
      {
        masterDetailPage.Detail = new NavigationPage(new AboutPage());

        if (Device.RuntimePlatform == Device.Android)
          await Task.Delay(100);

        masterDetailPage.IsPresented = false;
      }
    }
  }
}

