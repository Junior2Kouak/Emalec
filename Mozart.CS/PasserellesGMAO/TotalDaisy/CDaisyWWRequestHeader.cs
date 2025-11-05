using System.Collections.Generic;

namespace MozartCS
{
  // Définit un entête commun pour toutes les requêtes vers DaisyWW
  public class CDaisyWWRequestHeader
  {
    public string version { get; } = "2.1";
    public string language { get; } = "En";
    public string action { get; set; }
  }

  // Définit l'entête commun des résultats pour toutes les actions des WS
  public class CDaisyWWBaseResponse
  {
    public string version { get; set; }
    public int error_number { get; set; }
    public string language { get; set; }
    public string message { get; set; }
  }

  #region WebService pour l'action "UPDATE_STATE"

  //Définit les datas à envoyer pour l'action "update_state" : Pour la fermeture de l'incident en fait
  public class CDaisyWWRequestDatas_update_state
  {
    // Work order number
    public string wot_number { get; set; }
    // State
    public string state { get; set; }
    // Closure code
    public string closure_code { get; set; }
    // Root cause code
    public string root_cause_code { get; set; }
    // Type intervention code
    public string type_intervention_code { get; set; }
    // Type action code
    public string type_action_code { get; set; }
    // Real intervention date
    public string real_intervention_date { get; set; }
    // Note
    public string work_notes { get; set; }
  }

  #endregion

  #region WebService pour l'action "UPDATE_STATE_GTI"

  // Définit les datas à envoyer pour l'action "update_state_gti"
  public class CDaisyWWRequestDatas_update_state_gti
  {
    // Work order number
    public string wo_number { get; set; }
    // GTI passage date
    public string gti_date { get; set; }
    // GTI comments
    public string gti_comment { get; set; }
  }

  // Définition de la requête pour l'action "update_state_gti"
  public class CDaisyWWRequest_update_state_gti : CDaisyWWRequestHeader
  {
    public CDaisyWWRequestDatas_update_state_gti data { get; set; }
  }

  // Définition du retour de l'action "update_state_gti"
  public class CDaisyWWResponse_update_state_gti : CDaisyWWBaseResponse
  {
  }

  // On sait pas pourquoi mais le JSON de retour est décoré d'un unique champ 'result' qui sert à rien ....
  public class CDaisyWWResult_update_state_gti
  {
    public CDaisyWWResponse_update_state_gti result;
  }

  #endregion

  #region WebService pour l'action "ATTACHMENT_INCIDENT"

  // Définit les datas à envoyer pour l'action "attachment_incident"
  public class CDaisyWWRequestDatas_attachment_incident
  {
    // Operation
    public string operation { get; set; }
    // Incident nomber (Internal DaisyWW)
    public string wot_number { get; set; }
    // Filename
    public string filename { get; set; }
    // Value of the categorization
    public string categorization_value { get; set; }
    // Content
    public string content { get; set; }
  }

  // Définition de la requête pour l'action "attachment_incident" qui réalise en fait un ajout d'attachement
  public class CDaisyWWRequestDatas_add_attachment : CDaisyWWRequestHeader
  {
    public CDaisyWWRequestDatas_attachment_incident data { get; set; }
  }

  // Définition du retour de l'action "attachment_incident"
  public class CDaisyWWResponse_attachment_incident : CDaisyWWBaseResponse
  {
  }

  // On sait pas pourquoi mais le JSON de retour est décoré d'un unique champ 'result' qui sert à rien ....
  public class CDaisyWWResult_attachment_incident
  {
    public CDaisyWWResponse_attachment_incident result;
  }

  #endregion

  #region WebService pour l'action "close_incident"

  // Définition de la requête pour l'action "update_state" qui réalise en fait un close incident
  public class CDaisyWWRequestDatas_close_incident : CDaisyWWRequestHeader
  {
    public CDaisyWWRequestDatas_update_state data { get; set; }
  }

  // Définition du retour de l'action "update_state"
  public class CDaisyWWResponse_update_state : CDaisyWWBaseResponse
  {
  }

  // On sait pas pourquoi mais le JSON de retour est décoré d'un unique champ 'result' qui sert à rien ....
  public class CDaisyWWResult_update_state
  {
    public CDaisyWWResponse_update_state result;
  }

  #endregion

  #region WebService pour l'action "get_updated_list"

  // Définition de la requête pour l'action "get_updated_list"
  public class CDaisyWWRequest_get_updated_list : CDaisyWWRequestHeader
  {
    public data data { get; set; }
  }

  public class data
  {
  }

  // On sait pas pourquoi mais le JSON de retour est décoré d'un unique champ 'result' qui sert à rien ....
  public class CDaisyWWResult_get_updated_list
  {
    public CDaisyWWResponse_get_updated_list result;
  }

  // Définition du retour de l'action "get_updated_list"
  public class CDaisyWWResponse_get_updated_list : CDaisyWWBaseResponse
  {
    public List<TaskDesc> data { get; set; }
  }

  // Définit les datas retournés par l'action "get_updated_list"
  public class TaskDesc
  {
    // Work order task number (internal DaisyWW) : 40
    public string number { get; set; }
    // Work order
    public string wo_number { get; set; }
  }

  #endregion
}
