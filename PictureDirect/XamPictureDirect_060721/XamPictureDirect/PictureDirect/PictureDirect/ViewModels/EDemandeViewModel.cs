////////////////////////////////////////////////////////////////////////
//  PROJECT :   Emalec Mobile PictureDirect         
//  --------															                              
//																		                                  
//  MODULE  :   PictureDirect.ViewModels   
//  --------															                              
//																		                                  
//  FILE    :	  EDemandeViewModel.cs                     	
//  --------															                              
//																		                                  
//  DESCRIPTION :                                   					          
//  -----------	                                            			      
//	  Definition du Vue-Modele d'une Demande d'Intervention
//																		                                  
//																		                                  
//  AUTHOR       DATE    VERSION     MODIFICATION						            
//  --------------------------------------------------------------------
//  APITECH  !25.09.18! V0.01    ! Creation of the file					        
//           !        !          !                  					          
////////////////////////////////////////////////////////////////////////

using System.ComponentModel;
using MvvmHelpers;

using PictureDirect.Models;
using PictureDirect.WCFService;

namespace PictureDirect.ViewModels
{
  //----------------------------------------------------------------------------
  /// <summary>
  /// Vue Modèle d'une Demande d'Intervention : contient une liste EActionViewModel pour les Actions associées.
  /// </summary>
  public class EDemandeViewModel : ObservableRangeCollection<EActionDetailViewModel>, INotifyPropertyChanged
  {

    /// <summary>
    /// Nom de la Demande d'Intervention
    /// </summary>
    public string Name { get { return Demande.Name; } }

    /// <summary>
    /// Demande d'Intervention associée
    /// </summary>
    public DemandeContract Demande { get; set; }

    /// <summary>
    /// Liste des Actions associées à cette Demande d'Intervention
    /// </summary>
    private ObservableRangeCollection<EActionDetailViewModel> _demandeActions = new ObservableRangeCollection<EActionDetailViewModel>();

    //----------------------------------------------------------------------------
    public EDemandeViewModel()
    {
    }

    //----------------------------------------------------------------------------
    public EDemandeViewModel(DemandeContract demande, bool expanded = false)
    {
      this.Demande = demande;
      this._expanded = expanded;

      foreach (ActionContract action in demande.Actions)
      {
        // conserver les Vue Modeles des Actions associées à cette Demande d'Intervention
        _demandeActions.Add(new EActionDetailViewModel(this, action));
      }

      if (expanded)
        this.AddRange(_demandeActions);

    }

    //----------------------------------------------------------------------------
    /// <summary>
    /// Gestion du déplier de la Demande d'Intervention => lister les Actions associées
    /// </summary>
    public bool Expanded
    {
      get { return _expanded; }
      set
      {
        if (_expanded != value)
        {
          _expanded = value;
          OnPropertyChanged(new PropertyChangedEventArgs("Expanded"));
          OnPropertyChanged(new PropertyChangedEventArgs("StateIcon"));
          if (_expanded)
          {
            this.AddRange(_demandeActions);
          }
          else
          {
            this.Clear();
          }
        }
      }
    }
    private bool _expanded;

    // EDemandeView.xaml : <Image x:Name="ImgA" Source="{Binding StateIcon}" 
    public string StateIcon
    {
      get
      {
        if (Expanded)
        {
          return "arrow_a.png";
        }
        else
        {
          return "arrow_b.png";
        }
      }
    }

  }
}
