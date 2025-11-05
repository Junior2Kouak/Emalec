Public Class CQCMListeMsg

    Dim iTypeQCM As int32
        
    Public Sub New(ByVal c_iTypeQCM As int32)

        iTypeQCM = c_iTypeQCM

    End Sub

    Public Function ReturnMsg(ByVal p_nIdMsg As Int32) As string

        Select Case iTypeQCM 
            
            Case 1 'FrmQCMListeDetailByQCM
                
                Select Case  p_nIdMsg
                    
                    'frmQCMListe
                    Case 0 : return "Liste des tests de connaissances"
                    Case 1 : Return "Réponse QCM Technicien"
                    Case 2 : return "Afficher les QCM archivés"    
                    Case 3 : return "QCM"
                    Case 4 : return "Entrer le libellé du QCM"  
                    Case 5 : return "Création d'un QCM"  
                    Case 6 : return "Il faut sélectionner un QCM"  
                    Case 7 : return "Libellé du QCM"  
                    Case 8 : return "Date création QCM"
                    Case 9 : Return "Liste des QCM actifs"
                    Case 10 : return "Liste des QCM non actifs"
                    Case 11 : return "Voulez-vous vraiment archiver ce QCM ?"  
                    Case 12 : return "Confirmation archivage QCM"  
                    Case 13 : return "Voulez-vous vraiment restaurer ce QCM ?"
                    Case 14 : return "Confirmation restauration QCM" 
                    Case 15 : return "Attention !! Il faut saisir un nom pour ce QCM !!"  
                    Case 16 : Return "Erreur - Nom QCM"

                    Case 48 : Return "Réponse QCM Candidat"

                        'FrmQCMListeDetailByQCM
                    Case 17 : Return "Liste des techniciens ayant effectués le QCM : "
                    Case 18 : Return "Date réponse QCM" 
                    Case 19 : Return "Nbre de QCM en attente"
                    Case 20 : Return "Nbre de QCM terminés"
                    Case 21 : Return "Voulez-vous vraiment exporter ce QCM en PDF ?"
                    Case 22 : Return "Exporter PDF"
                    Case 23 : Return "Voulez-vous vraiment imprimer ce QCM ?"
                    Case 24 : Return "Impression QCM"
                    Case 25 : Return "Il faut sélectionner un QCM"
                    Case 26 : Return "Liste des techniciens archivés ayant effectués le QCM : "
                    Case 27 : Return "Actifs"
                    Case 28 : Return "Liste des techniciens ayant effectués le QCM : "
                    Case 29 : Return "Archives"
                    Case 48 : Return "QCM_Fiche_Edition_Result"
                    Case 49 : Return "exec api_sp_ImpQCMrep "

                    'FrmQCMListeDetailByPers
                    Case 30 : Return "Liste des qcm effectués par "
                    Case 31 : Return "Libellé du QCM"
                    Case 32 : Return "Nbre de qcm en attente"
                    Case 33 : Return "Nbre de qcm terminés"
                    Case 34 : Return "Libellé du QCM"
                    Case 35 : Return "Date QCM"
                    Case 36 : Return "Résultat (+50%)"
                    Case 37 : Return "(Nb bonnes réponses / Total)"
                    Case 38 : Return "Temps écoulé en (hh:mn:ss)"
                    Case 39 : Return "Voulez-vous vraiment exporter ce questionnaire en PDF ?"
                    Case 40 : Return "Exporter PDF questionnaire"
                    Case 41 : Return "Voulez-vous vraiment imprimer ce questionnaire ?"
                    Case 42 : Return "Impression questionnaire"         
                    Case 43 : Return "Liste des qcm archivés effectués par "
                    Case 44 : Return "Archives"
                    Case 45 : Return "Actifs"
                    Case 50 : Return "QCM_Fiche_Edition_Result"
                    Case 51 : Return "exec api_sp_ImpQCMrep "

                    'frmQCMDetail
                    Case 46 : Return "NOM DU QCM : "
                    Case 47 : Return "Detail QCM : "

                    Case Else
                        Return "Message introuvable dans CQCMListeMsg"
                End Select

            Case 2 'causeries
                    
                Select Case  p_nIdMsg
                    'frmQCMListe
                    Case 0 : return "Liste des causeries sécurité"
                    Case 1 : Return "Réponse CAUSERIES Technicien"
                    Case 2 : return "Afficher les CAUSERIES archivées"    
                    Case 3 : return "causerie"
                    Case 4 : return "Entrer le libellé de la causerie"  
                    Case 5 : return "Création d'une causerie"  
                    Case 6 : return "Il faut sélectionner une causerie"  
                    Case 7 : return "Libellé de la causerie"  
                    Case 8 : return "Date création causerie"  
                    Case 9 : return "Liste des causeries actives"  
                    Case 10 : return "Liste des causeries non actives"
                    Case 11 : return "Voulez-vous vraiment archiver cette causerie ?"  
                    Case 12 : return "Confirmation archivage causerie"  
                    Case 13 : return "Voulez-vous vraiment restaurer cette causerie ?"
                    Case 14 : return "Confirmation restauration causerie" 
                    Case 15 : return "Attention !! Il faut saisir un nom pour cette causerie !!"  
                    Case 16 : return "Erreur - Nom causerie"     

                    Case 48 : Return "Réponse Causerie Candidat"

                        'FrmQCMListeDetailByQCM
                    Case 17 : Return "Liste des techniciens ayant effectués la causerie : "
                    Case 18 : Return "Date réponse causerie" 
                    Case 19 : Return "Nbre de causeries en attente"
                    Case 20 : Return "Nbre de causeries terminées"
                    Case 21 : Return "Voulez-vous vraiment exporter cette causerie en PDF ?"
                    Case 22 : Return "Exporter PDF"
                    Case 23 : Return "Voulez-vous vraiment imprimer cette causerie ?"
                    Case 24 : Return "Impression causerie"
                    Case 25 : Return "Il faut sélectionner une causerie"
                    Case 26 : Return "Liste des techniciens archivés ayant effectués la causerie : "
                    Case 27 : Return "Actifs"
                    Case 28 : Return "Liste des techniciens ayant effectués la causerie : "
                    Case 29 : Return "Archives"
                    Case 48 : Return "Causerie_Fiche_Edition_Result"
                    Case 49 : Return "exec api_sp_ImpCauserieRep "

                    'FrmQCMListeDetailByPers
                    Case 30 : Return "Liste des causeries effectuées par "
                    Case 31 : Return "Libellé de la causerie"
                    Case 32 : Return "Nbre de causeries en attente"
                    Case 33 : Return "Nbre de causeries terminées"
                    Case 34 : Return "Libellé du QCM"
                    Case 35 : Return "Date causerie"
                    Case 36 : Return "Résultat (+50%)"
                    Case 37 : Return "(Nb bonnes réponses / Total)"
                    Case 38 : Return "Temps d'exécution"
                    Case 39 : Return "Voulez-vous vraiment exporter cette causerie en PDF ?"
                    Case 40 : Return "Exporter PDF"
                    Case 41 : Return "Voulez-vous vraiment imprimer cette causerie ?"
                    Case 42 : Return "Impression causerie"                
                    Case 43 : Return "Liste des causeries archivées effectuées par "
                    Case 44 : Return "Archives"
                    Case 45 : Return "Actifs"
                    Case 50 : Return "Causerie_Fiche_Edition_Result"
                    Case 51 : Return "exec api_sp_ImpCauserieRep "

                    'frmQCMDetail
                    Case 46 : Return "NOM DE LA CAUSERIE : "
                    Case 47 : Return "Detail de la causerie : "

                    Case Else
                        Return "Message introuvable dans CQCMListeMsg"
                End Select

            Case Else

                Return "Message introuvable dans CQCMListeMsg"

        End Select             
        
    End Function

End Class
