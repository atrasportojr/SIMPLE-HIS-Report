Public Class clsOccupationReligionNationality
#Region "Variables"
    Dim operation As Integer
    Private mOldid As Integer
    Private mDescription, mmemo As String
    Public misactive As Boolean
    Public misdefault As Boolean

    Public createdby As Long
    Public updatedby As Long
#End Region
    Public Property Oldid() As Integer
        Get
            Return mOldid
        End Get
        Set(ByVal value As Integer)
            mOldid = value
        End Set
    End Property
    Public Property Description() As String
        Get
            Return mDescription
        End Get
        Set(ByVal value As String)
            mDescription = value
        End Set
    End Property
    Public Property isactive() As Boolean
        Get
            Return misactive
        End Get
        Set(ByVal value As Boolean)
            misactive = value
        End Set
    End Property
    Public Property isdefault() As Boolean
        Get
            Return misdefault
        End Get
        Set(ByVal value As Boolean)
            misdefault = value
        End Set
    End Property
    Public Property memo() As String
        Get
            Return mmemo
        End Get
        Set(ByVal value As String)
            mmemo = value
        End Set
    End Property
    Public Shared Function getInfo(ByVal soperation As Integer, ByVal search As String, Optional ByVal id As Integer = 0, Optional ByVal isactive As Integer = 0) As DataTable
        If isactive = 0 Then
            isactive = 1
        Else
            isactive = 0
        End If
        Dim strPar() As String = {"@operation", "@soperation", "@search", "@Oldoccupationid", "@isactive"}
        Dim strVal() As String = {0, soperation, search, id, isactive}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.setparam(strPar, strVal, "spOccupation_Religion_Nationality", 0)
    End Function
    Public Function save(ByVal storedProc As String, ByVal isNew As Boolean, ByVal soperation As Integer) As String
        If isNew Then
            operation = 1
        Else
            operation = 2
        End If
        Dim strPar() As String = {"@operation", "@soperation", "@Oldoccupationid", "@description", "@isactive", "@isdefault", "@memo", "@createdbyid", "@updatebyid", "NewPK"}
        Dim strVal() As String = {Me.operation, soperation, Me.Oldid, Me.Description, Me.isactive, Me.isdefault, Me.memo, Me.createdby, Me.updatedby, operation}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.SetParam(strPar, strVal, storedProc, 2)
    End Function
End Class
