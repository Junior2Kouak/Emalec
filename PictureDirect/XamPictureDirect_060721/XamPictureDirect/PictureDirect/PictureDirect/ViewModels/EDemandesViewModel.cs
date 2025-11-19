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

namespace PictureDirect.ViewModels
{
  //----------------------------------------------------------------------------
  public class EDemandesViewModel : EBaseViewModel
  {
    /// <summary>
    /// Liste des Demandes d'Intervention
    /// </summary>
    public ObservableCollection<EDemandeViewModel> Demandes
    {
      get => _demandes;
      set => SetProperty(ref _demandes, value);
    }
    private ObservableCollection<EDemandeViewModel> _demandes;

    public EActionDetailViewModel SelectedAction
    {
      get => _selectedAction;
      set => SetProperty(ref _selectedAction, value, "SelectedAction", SelectedActionChangedAsync);
    }
    private EActionDetailViewModel _selectedAction;

    public EDemandeViewModel SelectedDemande
    {
      get => _selectedDemande;
      set => SetProperty(ref _selectedDemande, value);
    }
    private EDemandeViewModel _selectedDemande;

    private async void SelectedActionChangedAsync()
    {
      EActionDetailViewModel action = SelectedAction;
      if (action == null)
        return;

      if (SelectedDemande == null)
        return;

      await action.LoadPhotosAsync();

      await Navigation.PushAsync(new EActionDetailPage(action));

      //SelectedDemande = null;
      SelectedAction = null;
    }

    public Command LoadDemandesCommand { get; set; }

    // EDemandesView.xaml : <TapGestureRecognizer ... Path=BindingContext.ItemTapCommand
    public Command<EDemandeViewModel> ItemTapCommand { get; set; }

    //----------------------------------------------------------------------------
    public EDemandesViewModel(INavigation navigation)
    {
      Title = "Demandes";
      Navigation = navigation;
      _demandes = new ObservableCollection<EDemandeViewModel>();

      LoadDemandesCommand = new Command(async () => await ExecuteLoadDemandesCommandAsync());
      ItemTapCommand = new Command<EDemandeViewModel>((item) => ExecuteItemTapCommand(item));

      Task.Run(async () => await ExecuteLoadDemandesCommandAsync());
    }

    //----------------------------------------------------------------------------
    /// <summary>
    /// Raffraichir un élément dans la liste des Demandes d'Intervention
    /// </summary>
    /// <param name="demande">Elément de la liste à mettre à jour</param>
    private void ExecuteItemTapCommand(EDemandeViewModel demande)
    {
      foreach (EDemandeViewModel item in Demandes.Except(new[] { demande }))
        item.Expanded = false;

      demande.Expanded = !demande.Expanded;

      if (demande.Expanded)
        SelectedDemande = demande;
      else
        SelectedDemande = null;
    }
    //----------------------------------------------------------------------------
    /// <summary>
    /// Initialiser la liste des Demandes d'Intervention
    /// </summary>
    /// <returns></returns>
    private async Task ExecuteLoadDemandesCommandAsync()
    {
      if (IsBusy)
        return;

      using (EBusyManager.GetInstance(this))
      {
        try
        {
          Demandes.Clear();

          List<DemandeContract> demandes = await WCFServiceHelper.GetCommandesAsync();

          if (demandes.Count > 0)
          {
            Demandes = new ObservableCollection<EDemandeViewModel>(demandes.Select(x => new EDemandeViewModel(x)));
          }
          else
          {
            IsEmpty = true;
          }

          Task.Run(async () => await SyncHelper.Instance.CleanOldPictures(demandes.Select(x => x.Id).ToList()));

        }
        catch (Exception ex)
        {
          SetContextInfo(ex.Message, InfoType.Error);
        }
      }
    }
  }
}
