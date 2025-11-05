Imports System.Net
Imports Newtonsoft.Json
Imports RestSharp

Public Class Synergee

  'Const cstApiKey = "B74729E780AAB39E36F24929E38D3EC9" '  "52980777978490482B20170686E7B73C"  ' "7A0C8BE749084C36050934CD78B1EB60"
  Const cstCookie = "_acl=YWRtaW46bm8="
  'Const cstUrl = "https://randstad-rd.synergee.com/API/v2/maintenance/"  '"https://randstad-uat-rd.synergee.com/API/v2/maintenance/"   '"https://randstad-uat-rd.synergee.com"  '"https://randstad-recette.retaildrive.com/API/v2/maintenance/"

  Private Function AcceptAllCertifications(sender As Object, certification As System.Security.Cryptography.X509Certificates.X509Certificate, chain As System.Security.Cryptography.X509Certificates.X509Chain, sslPolicyErrors As Security.SslPolicyErrors) As Boolean
    Return True
  End Function

  Public Function GetFiles(sFrom As String, sTo As String, cstUrl As String, cstApiKey As String) As RestResponse

    ServicePointManager.ServerCertificateValidationCallback = New Security.RemoteCertificateValidationCallback(AddressOf AcceptAllCertifications)
    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12

    Dim client = New RestClient($"{cstUrl}GetWorkOrdersList/?from={sFrom}&to={sTo}") With {
      .Timeout = -1
    }
    Dim request = New RestRequest(Method.GET)
    With request
      .AddHeader("Content-Type", "application/json")
      .AddHeader("X-ApiKey", cstApiKey)
      '.AddHeader("Cookie", cstCookie)
      .AddParameter("application/json", "", ParameterType.RequestBody)
    End With

    Return client.Execute(request)

  End Function

  Public Function SendDateInter(urlid As String, workOrder As String, sDate As String, Comments As String, cstUrl As String, cstApiKey As String) As RestResponse

    ServicePointManager.ServerCertificateValidationCallback = New Security.RemoteCertificateValidationCallback(AddressOf AcceptAllCertifications)
    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12

    Dim client = New RestClient($"{cstUrl}UpdateIntervention/{urlid}") With {.Timeout = -1}
    Dim request = New RestRequest(Method.POST)

    Dim json As String = "{""WorkOrder"": " + workOrder + ", ""Date"": """ + sDate + """, ""Comments"": """ + Comments.Replace("""", "\""") + """}"

    With request
      .AddHeader("X-ApiKey", cstApiKey)
      .AddHeader("Cookie", cstCookie)
      .AddHeader("Content-Type", "application/json")
      .AddParameter("application/json", json, ParameterType.RequestBody)
    End With

    Return client.Execute(request)

  End Function

  Public Function SendReportInter(urlid As String, workOrder As String, sDateDeb As String, sDateFin As String, Comments As String, bProblemResolved As Boolean, sDateNewInter As String, cstUrl As String, cstApiKey As String) As RestResponse

    Dim json As String
    ServicePointManager.ServerCertificateValidationCallback = New Security.RemoteCertificateValidationCallback(AddressOf AcceptAllCertifications)
    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12

    Dim client = New RestClient($"{cstUrl}ReportIntervention/{urlid}") With {.Timeout = -1}
    Dim request = New RestRequest(Method.POST)
    If (bProblemResolved) Then
      json = "{""WorkOrder"": " + workOrder + ", 
             ""Comments"": """ + Comments.Replace("""", "\""") + """, 
             ""InterventionTimes"": [ {""Start"": """ + sDateDeb + """, ""End"": """ + sDateFin + """} ],
             ""Status"": " + """ProblemResolved""}"
    Else
      json = "{""WorkOrder"": " + workOrder + ","
      If sDateNewInter <> "" Then json += """AdditionalIntervention"": """ + sDateNewInter + ""","
      json += " ""Comments"": """ + Comments.Replace("""", "\""") + """, 
              ""InterventionTimes"": [ {""Start"": """ + sDateDeb + """, ""End"": """ + sDateFin + """} ],
              ""Status"": " + """AdditionalIntervention""}"
    End If
    With request
      .AddHeader("X-ApiKey", cstApiKey)
      .AddHeader("Cookie", cstCookie)
      .AddHeader("Content-Type", "application/json")
      .AddParameter("application/json", json, ParameterType.RequestBody)
    End With

    Return client.Execute(request)

  End Function

  Public Function SendDevis(urlid As String, workOrder As String, price As String, comments As String, reference As String, cstUrl As String, cstApiKey As String) As RestResponse

    ServicePointManager.ServerCertificateValidationCallback = New Security.RemoteCertificateValidationCallback(AddressOf AcceptAllCertifications)
    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12

    Dim client = New RestClient($"{cstUrl}UpdateQuote/{urlid}") With {.Timeout = -1}
    Dim json = "{ ""WorkOrder"": " + workOrder + ", ""Price"": " + price + ", ""Comments"": """ + comments + """, ""Reference"": """ + reference + """ }"

    Dim request = New RestRequest(Method.POST)
    With request
      .AddHeader("X-ApiKey", cstApiKey)
      .AddHeader("Cookie", cstCookie)
      .AddHeader("Content-Type", "application/json")
      .AddParameter("application/json", json, ParameterType.RequestBody)
    End With

    Return client.Execute(request)

  End Function

  Public Function SendFile(urlid As String, Filename As String, Shortname As String, Scope As String, cstUrl As String, cstApiKey As String) As RestResponse
    'au choix : "Quote details", "Intervention report", "Invoice"

    ServicePointManager.ServerCertificateValidationCallback = New Security.RemoteCertificateValidationCallback(AddressOf AcceptAllCertifications)
    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12

    Dim client = New RestClient($"{cstUrl}AttachFile/{urlid}") With {.Timeout = -1}
    Dim request = New RestRequest(Method.POST)
    With request
      .AddHeader("X-ApiKey", cstApiKey)
      .AddHeader("Cookie", cstCookie)
      .AddHeader("Name", Shortname)
      .AddHeader("Extension", ".pdf")
      .AddHeader("Scope", Scope)
      .AddFile(Shortname, Filename)
    End With

    Return client.Execute(request)

  End Function

  Public Function SendFacture(urlid As String, price As String, tax As String, comments As String, ref As String, dateFact As String, cstUrl As String, cstApiKey As String) As RestResponse

    ServicePointManager.ServerCertificateValidationCallback = New Security.RemoteCertificateValidationCallback(AddressOf AcceptAllCertifications)
    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12

    Dim client = New RestClient($"{cstUrl}Invoice/{urlid}") With {.Timeout = -1}
    Dim json = "{""Price"": " + price + ", 
                 ""Tax"": " + tax + ", 
                 ""Comments"": """ + comments + """, 
                 ""Reference"": """ + ref.Replace("""", "\""") + """, 
                 ""InvoiceDate"": """ + dateFact + """}"

    Dim request = New RestRequest(Method.POST)
    With request
      .AddHeader("X-ApiKey", cstApiKey)
      .AddHeader("Cookie", cstCookie)
      .AddHeader("Content-Type", "application/json")
      .AddParameter("application/json", json, ParameterType.RequestBody)
    End With

    Return client.Execute(request)
  End Function

End Class

Public Class cPOS
  Property POSNumber As String
  Property Name As String
  Property Street As String
  Property ZipCode As String
  Property City As String
  Property MonOpeningHours As String
  Property TueOpeningHours As String
  Property WedOpeningHours As String
  Property ThuOpeningHours As String
  Property FriOpeningHours As String
  Property SatOpeningHours As String
  Property SunOpeningHours As String
  Property Brand As cBrand
  Property LegalEntity As cLegalEntity
End Class

Public Class cBrand
  Property Name As String
End Class

Public Class cLegalEntity
  Property LegalName As String
  Property Address As String
  Property ZipCode As String
  Property City As String
End Class

Public Class cAssignedTo
  Property FullName As String
  Property Telephone As String
  Property Email As String

End Class

Public Class cLibelle
  Property Fr As String
  Property En As String
  Property Nl As String
  Property It As String
  Property De As String
End Class

Public Class cSynergeeDI
  Property ID As Integer
  Property CompleteStatus As Integer
  Property Description As String
  Property RequestDate As DateTime
  Property Deadline As String
  Property Category As cLibelle
  Property Equipment As cLibelle
  Property Priority As Integer
  Property POS As cPOS
  Property AssignedTo As cAssignedTo
  Property UrlId As Guid
  Property BaseUrl As String
End Class
