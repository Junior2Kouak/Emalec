Public Class clsKimoce


  '  FGA le 21/11/2022
  ' cette class ne semble pas très utile


  Const cstUrl = "10.53.20.28"
  Const cstPort = 6520
  Const cstUser = "Emalec"
  'Const cstPassword = "Emalecp"  ' en production
  Const cstPassword = "Emalecr"  ' en recette
  Const cstCommand = "col_multi"


  Public Structure stMIS
    Public Shared RqtExCde As Int16 = 0
    Public Shared OrigCpyExCde As Int16 = 1
    Public Shared OrigCpyAddrExCde As Int16 = 2
    Public Shared OrigCtcExCde As Int16 = 3
    Public Shared OrigCtcDsc As Int16 = 4
    Public Shared OrigCtcPhnNum As Int16 = 5
    Public Shared OrigDpmtExCde As Int16 = 6
    Public Shared RqtNatExCde As Int16 = 7
    Public Shared ObjExCde As Int16 = 8
    Public Shared ObjDsc As Int16 = 9
    Public Shared ObjIdentVal As Int16 = 10
    Public Shared AdcExCde As Int16 = 11
    Public Shared PbmExCde As Int16 = 12
    Public Shared RqtItvLimDte As Int16 = 13
    Public Shared RqtSolLimDte As Int16 = 14
    Public Shared RqtLimDteModCde As Int16 = 15
    Public Shared CldExCde As Int16 = 16
    Public Shared RqtDte As Int16 = 17
    Public Shared OrdCpyExCde As Int16 = 18
    Public Shared OrdCpyAddrExCde As Int16 = 19
    Public Shared OrdCtcExCde As Int16 = 20
    Public Shared DstCpyExCde As Int16 = 21
    Public Shared DstCpyAddrExCde As Int16 = 22
    Public Shared DstCtcExCde As Int16 = 23
    Public Shared DstCtcDsc As Int16 = 24
    Public Shared DstDpmtExCde As Int16 = 25
    Public Shared DstWrkGrpExCde As Int16 = 26
    Public Shared PriExCde As Int16 = 27
    Public Shared CntExCde As Int16 = 28
    Public Shared CntCstUnitNbr As Int16 = 29
    Public Shared LocCpyDsc As Int16 = 30
    Public Shared LocCpyAddrStreet1Dsc As Int16 = 31
    Public Shared LocCpyAddrStreet2Dsc As Int16 = 32
    Public Shared LocCpyAddrZipDsc As Int16 = 33
    Public Shared LocCpyAddrTwnDsc As Int16 = 34
    Public Shared LocPhnNum As Int16 = 35
    Public Shared LocFaxNum As Int16 = 36
    Public Shared LocCpyLocDsc As Int16 = 37
    Public Shared LocDpmtDsc As Int16 = 38
    Public Shared RqtFolderNum As Int16 = 39
    Public Shared Memo As Int16 = 40
  End Structure

  Public Function GetMIS() As Int32

    Return 0

  End Function
End Class
