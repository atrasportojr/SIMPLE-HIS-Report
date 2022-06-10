Imports System.IO

Public Class clsModel

    Public Class ICD_Procedures
        Public Property admissiondiagnosisid As Long
        Public Property icd10code As String
        Public Property description As String
        Public Property isprimary As Boolean
        Public Property laterality As String
        Public Property proceduredate As String
    End Class
    Public Class PhilHealthPackage
        Public Property caseno As Long
        Public Property casename As String
        Public Property icd10code As String
        Public Property casetype As String
        Public Property caserate As Double
        Public Property facilityfee As Double
        Public Property doctorsfee As Double
        Public Property philhealthcaseno As String
    End Class

    Public Class charge
        Public Property chargeid As Long
        Public Property supplierno As Long
        Public Property pCompanyName As String
        Public Property pCompanyTIN As String
        Public Property pBIRPermitNumber As String
        Public Property pReceiptNumber As String
        Public Property pReceiptDate As Date
        Public Property pVATExemptSale As Double
        Public Property pVAT As Double
        Public Property pTotal As Double
        Public Property remarks As String
        Public Property discounttypeid As Long
        Public Property discount As Double
        Public Property officecode As String
        Public Property officedescription As String
        Public Property transtype As String = "CH"
        Public Property istakehome As Boolean

        Public Property items As New List(Of Item)

    End Class
    Public Class Item
        Public Property chargedetailid As Integer
        Public Property chargeid As Integer
        Public Property itemcode As String
        Public Property itemcattype As String
        Public Property itemcatcode As String
        Public Property quantity As Integer
        Public Property unitprice As Double
        Public Property description As String
        Public Property genericname As String
        Public Property dosage As String
        Public Property pricelevel As Integer
        Public Property linediscount As Double
        Public Property excess As Double

        Public Property phicdrugcode As String
        Public Property phicgenericcode As String
        Public Property phicgenericname As String
        Public Property phicstrengthcode As String
        Public Property phicformcode As String
        Public Property phicunitcode As String
        Public Property phicpackagecode As String
        Public Property phicsaltcode As String


        Public Property frequencyid As Integer
        Public Property frequencyname As String
        Public Property routeid As Integer
        Public Property routename As String
        Public Property specialinstructions As String
        Public Property defaultroute As Integer

        Public Property chargedate As Date
        Public Property isexist As Boolean
    End Class


    Public Class CourseWard
        Public Property courseid As Long
        Public Property coursedate As Date
        Public Property courseaction As String
        Public Property isupdated As Boolean
    End Class

    Public Class NewbornHearingTestResult
        Public Shared Property Passed As String = "P"
        Public Shared Property Referred As String = "R"
        Public Shared Property NA As String = "X"
    End Class
    Public Class DocumentType
        Public Shared Property ITX As String = "ITX"
    End Class
    Public Class PhilhealthClaimType
        Public Shared Property ALLCASERATE As String = "ALL-CASE-RATE"
        Public Shared Property ZBENEFIT As String = "Z-BENEFIT"
    End Class
    Public Class ReltoPHICMember
        Public Shared Property Member As String = "M"
        Public Shared Property Spouse As String = "S"
        Public Shared Property Child As String = "C"
        Public Shared Property Parent As String = "P"
    End Class
End Class
