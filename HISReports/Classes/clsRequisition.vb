Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class clsRequisition

#Region "Variables"
    Dim operation As Integer
    Public soperation As Integer

    Public patientrequestno As Long
    Public registrydetailno As Long
    Public sourceoffice As String
    Public destinationofficemaster As String
    Public documentno As String
    Public reqtransno As Long
    Public purpose As String
    Public requestedbyid As Long
    Public daterequested As Date
    Public approvedbyid As Long
    Public dateapproved As Date
    Public daterender As Date
    Public stat As Integer
    Public frequencyid As Integer

    Public patientrequestdetailno As Long
    Public itemcode As String
    Public quantityrequested As Integer
    Public quantityrendered As Integer
    Public remarks As String
    Public destinationoffice As String
#End Region


#Region "Methods"
    Public Shared Function getPatient(ByVal patno As Long) As DataTable
        Dim strPar() As String = {"operation", "soperation", "search"}
        Dim strVal() As String = {0, 2, patno}

        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.SetParam(strPar, strVal, "spPatientRequisition", 0)
    End Function
    Public Shared Function getTransno(ByVal office As String) As DataTable
        Dim strPar() As String = {"operation", "soperation", "office"}
        Dim strVal() As String = {0, 3, office}

        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.SetParam(strPar, strVal, "spPatientRequisition", 0)
    End Function
    Public Shared Function getRequisiton(ByVal office As String, ByVal soperation As Integer, ByVal patreqno As Long) As DataTable
        Dim strPar() As String = {"operation", "soperation", "office", "patientrequestno"}
        Dim strVal() As String = {0, soperation, office, patreqno}

        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.SetParam(strPar, strVal, "spPatientRequisition", 0)
    End Function
    Public Shared Function getAllRequisiton(ByVal office As String, ByVal indicator As Integer, ByVal regdetno As Integer) As DataTable
        Dim strPar() As String = {"operation", "soperation", "office", "registrydetailno", "indicator"}
        Dim strVal() As String = {0, 0, office, regdetno, indicator}

        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.SetParam(strPar, strVal, "spPatientRequisition", 0)
    End Function
    'transfered in spPatientRequisition 6/26
    Public Shared Function getRequisitonDetails(ByVal patreqno As Long) As DataTable
        Dim strPar() As String = {"operation", "soperation", "patientrequestno"}
        Dim strVal() As String = {0, 6, patreqno}

        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.SetParam(strPar, strVal, "spPatientRequisition", 0)
    End Function
    'transfered in spPatientRequisition 6/26
    Public Shared Function getRequisitonDetailsbyOffice(ByVal patreqno As Long, ByVal office As String) As DataTable
        Dim strPar() As String = {"operation", "soperation", "patientrequestno", "destinationoffice"}
        Dim strVal() As String = {0, 7, patreqno, office}

        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.SetParam(strPar, strVal, "spPatientRequisition", 0)
    End Function
    Public Shared Function deleteRequisitonDetails(ByVal patreqdetno As Long) As DataTable
        Dim strPar() As String = {"operation", "soperation", "patientrequestdetailno"}
        Dim strVal() As String = {3, 0, patreqdetno}

        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.SetParam(strPar, strVal, "spPatientRequisition", 0)
        'Call SaveLog("Patient Request", "Delete Requisition details  " & patreqdetno, patreqdetno)
    End Function
    Public Shared Function getOffices(Optional ByVal sop As Integer = 4) As DataTable
        Dim strPar() As String = {"operation", "soperation"}
        Dim strVal() As String = {0, sop}

        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.SetParam(strPar, strVal, "spPatientRequisition", 0)
    End Function
    Public Shared Function getPatientRequisition(ByVal vpatientreq As Long) As DataTable
        Dim strPar() As String = {"operation", "soperation", "patientrequestno"}
        Dim strVal() As String = {0, 8, vpatientreq}

        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.SetParam(strPar, strVal, "spPatientRequisition", 0)
    End Function
    Public Function Save(ByVal isNew As Boolean) As Long
        If isNew Then
            operation = 1
            soperation = 0
        Else
            operation = 2
        End If

        Dim strPar() As String = {"operation", _
                                   "soperation", _
                                   "patientrequestno", _
                                   "registrydetailno", _
                                   "sourceoffice", _
                                   "destinationoffice", _
                                   "documentno", _
                                   "reqtransno", _
                                   "purpose", _
                                   "requestedbyid", _
                                   "daterequested", _
                                   "approvedbyid", _
                                   "dateapproved", _
                                   "daterender", _
                                   "NewPK"}
        Dim strVal() As String = {operation, _
                                  soperation, _
                                  patientrequestno, _
                                  registrydetailno, _
                                  sourceoffice, _
                                  destinationofficemaster, _
                                  documentno, _
                                  reqtransno, _
                                  purpose, _
                                  requestedbyid, _
                                  daterequested, _
                                  approvedbyid, _
                                  dateapproved, _
                                  daterender, _
                                  operation}
        'Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.SetParam(strPar, strVal, "spPatientRequisition", 2)
        If isNew Then
            Dim s As New simpleadapter.SimpleAdapter(gconnectionstring)
            Me.patientrequestno = s.SetParam(strPar, strVal, "spPatientRequisition", 2)
            'Call SaveLog("Patient Request", "New Patient Request No  " & Me.patientrequestno, patientrequestno)
        Else
            Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.SetParam(strPar, strVal, "spPatientRequisition", 2)
            'Call SaveLog("Patient Request", "Update Patient Request " & Me.patientrequestno, patientrequestno)
        End If
        Return Me.patientrequestno
    End Function

    Public Function saveDetails(ByVal isNew As Boolean) As DataTable
        If isNew Then
            operation = 1
            soperation = 1
        Else
            operation = 2
            soperation = 7
        End If
        Dim strPar() As String = {"operation", _
                                   "soperation", _
                                  "itemcode", _
                                  "patientrequestdetailno", _
                                  "patientrequestno", _
                                  "quantityrequested", _
                                  "quantityrendered", _
                                  "remarks", _
                                  "destinationoffice", _
                                  "status",
                                  "frequencyid"}

        Dim strVal() As Object = {operation, _
                                  soperation, _
                                 itemcode, _
                                 patientrequestdetailno, _
                                 patientrequestno, _
                                 quantityrequested, _
                                 quantityrendered, _
                                 remarks, _
                                 destinationoffice, _
                                 stat,
                                 frequencyid}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.SetParam(strPar, strVal, "spPatientRequisition", 1)
    End Function

#End Region

End Class
