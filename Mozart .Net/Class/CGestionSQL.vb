Imports System.Data.SqlClient   

Public Class CGestionSQL
    
    Const sNomBDD As String = "MULTI"
  ' TB SAMSIC CITY SPEC
  ' Spécifique à un serveur
  Const sServeurReplication As String = "SRV-SQL04"

    Public CnxSQLOpen As New SqlConnection 

    Friend function ConnexionSQL(ByVal sServeurSQL As string, Byval sNomSociete As String) As Boolean 

        Try

            'si serveur replication alors on se connecte avec le compte sa (car tous les users ne sont pas duplique
            If sServeurSQL.ToUpper = sServeurReplication.ToUpper Then
                CnxSQLOpen.ConnectionString = String.Format("Data Source={0};Database={1};UID=sa;PWD=bmanpj;app={2}", sServeurSQL, sNomBDD, sNomSociete)
            Else
                CnxSQLOpen.ConnectionString = String.Format("Data Source={0};Database={1};trusted_connection=true;app={2}", sServeurSQL, sNomBDD, sNomSociete)
            End If

            CnxSQLOpen.Open()

            Return True

        Catch ex As Exception

            MessageBox.Show("Classe CGestionSQL dans ConnexionSQL : " + ex.Message, "Erreur")
            Return False

        End Try

    End function

    Friend function ConnexionSQLTimeOut(ByVal sServeurSQL As string, Byval sNomSociete As String, ByVal iTimeOut As int32) As Boolean 

        Try

            CnxSQLOpen.ConnectionString = String.Format("Data Source={0};Database={1};trusted_connection=true;app={2};Connection Timeout={3}", sServeurSQL, sNomBDD, sNomSociete, iTimeOut)
            CnxSQLOpen.Open 

            Return true

        Catch ex As Exception

      MessageBox.Show("Classe CGestionSQL dans ConnexionSQLTimeOut : " + ex.Message, "Erreur")
            Return False 

        End Try              

    End function

    Friend function ConnexionSQLWithOutAPP_NAME(ByVal sServeurSQL As string) As Boolean 

        Try

            CnxSQLOpen.ConnectionString = String.Format("Data Source={0};Database={1};trusted_connection=true", sServeurSQL, sNomBDD)
            CnxSQLOpen.Open 

            Return true

        Catch ex As Exception

      MessageBox.Show("Classe CGestionSQL dans ConnexionSQLWithOutAPP_NAME : " + ex.Message, "Erreur")
            Return False 

        End Try              

    End function

    Friend sub CloseConnexionSQL

        Try

            If CnxSQLOpen.State = ConnectionState.Open then 
                CnxSQLOpen.Close 
                SqlConnection.ClearPool(CnxSQLOpen)
            End If            
           
        Catch ex As Exception

            MessageBox.Show("Classe CGestionSQL dans CloseConnexionSQL : " + ex.Message, "Erreur")

        End Try  

    End sub
    
    Friend Function CreateSQLDataReader(ByVal sRequete As string) As SqlDataReader 

        Try

            If CnxSQLOpen.State = ConnectionState.Open Then
                
                Dim cmdReader As New SqlCommand(sRequete, CnxSQLOpen)         
                Return cmdReader.ExecuteReader 
            Else
                Return Nothing 
            End If            

        Catch ex As Exception

            MessageBox.Show("Classe CGestionSQL dans CreateSQLDataReader : " + ex.Message, "Erreur")  
            Return Nothing 

        End Try

    End Function


End Class
