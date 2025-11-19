////////////////////////////////////////////////////////////////////////
//  PROJECT :   Emalec Mobile PictureDirect         
//  --------															                              
//																		                                  
//  MODULE  :   PictureDirect.ViewModels   
//  --------															                              
//																		                                  
//  FILE    :	  EDemandesGroupViewModel.cs                     	
//  --------															                              
//																		                                  
//  DESCRIPTION :                                   					          
//  -----------	                                            			      
//	  Definition du Vue-Modele de la liste des Demandes d'Intervention
//																		                                  
//																		                                  
//  AUTHOR       DATE    VERSION     MODIFICATION						            
//  --------------------------------------------------------------------
//  APITECH  !25.09.18! V0.01    ! Creation of the file					        
//           !        !          !                  					          
////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;

using Xamarin.Forms;
using PictureDirect.Models;
using PictureDirect.WCFService;
using System.Linq;
using System.Threading.Tasks;
using PictureDirect.Views;
using PictureDirect.Helpers;
using PictureDirect.Services;

namespace PictureDirect.ViewModels
{
  //----------------------------------------------------------------------------
  public class ELoginViewModel : EBaseViewModel
  {

    public int NumUser
    {
      get => _numUser;
      set => SetProperty(ref _numUser, value);
    }
    private int _numUser;

    public string Login
    {
      get => _login;
      set => SetProperty(ref _login, value);
    }
    private string _login;

    public string Password
    {
      get => _password;
      set => SetProperty(ref _password, value);
    }
    private string _password;

    public Command LoginCommand { get; set; }

    //----------------------------------------------------------------------------
    public ELoginViewModel(INavigation navigation)
    {
      Title = "Login";
      Navigation = navigation;

      LoginCommand = new Command(async () => await ExecuteLoginCommandAsync());

      NumUser = App.Config.DefaultNumUser;
      Login = App.Config.DefaultLogin;
      Password = App.Config.DefaultPassword;
    }
    
    //----------------------------------------------------------------------------
    /// <summary>
    /// Initialiser la liste des Demandes d'Intervention
    /// </summary>
    /// <returns></returns>
    private async Task ExecuteLoginCommandAsync()
    {
      ContextHelper.Instance.Reset();

      using (EBusyManager.GetInstance(this))
      {
        try
        {
          LoginResponseContract res = await WCFServiceHelper.LoginAsync(NumUser, Login, Password);

          if (res != null && res.ResultCode == 0)
          {
            ContextHelper.Instance.NumUser = NumUser;
            ContextHelper.Instance.Login = Login;

            App.Config.DefaultNumUser = NumUser;
            App.Config.DefaultLogin = Login;
            App.Config.MaxNumberOfPictures = res.MaxNumberOfPictures;

            await SQLiteHelper.Instance.SaveConfigAsync(App.Config);

            if (res.WcfVersion != App.Version)
            {
              if (!string.IsNullOrEmpty(res.WrongVersionMessage))
                await Application.Current.MainPage.DisplayAlert("Version invalide", res.WrongVersionMessage, "Ok");

              if (res.BlockWrongVersion)
                return;
            }

            await Navigation.PushAsync(new EDemandesView(new EDemandesViewModel(Navigation)));
          }
          else
          {
            SetContextInfo("Erreur d'authentification", InfoType.Error);
          }
        }
        catch (Exception ex)
        {
          SetContextInfo("Erreur d'authentification : " + ex.Message, InfoType.Error);
        }
      }
    }
  }
}
