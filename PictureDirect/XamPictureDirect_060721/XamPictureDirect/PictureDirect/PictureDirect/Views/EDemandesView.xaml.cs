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
  public partial class EDemandesView : ContentPage
  {
    //----------------------------------------------------------------------------
    public EDemandesView()
    {
      InitializeComponent();
      BindingContext = new EDemandesViewModel(Navigation);
    }

    //----------------------------------------------------------------------------
    public EDemandesView(EDemandesViewModel viewModel)
    {
      InitializeComponent();
      viewModel.Navigation = Navigation;
      BindingContext = viewModel;
    }
       
  }
  
}