Public Class clsProcedures
    Private operation As Integer

    Public phicprocedurecatno As Integer
    Public phicprocedurecatdesc As String

    Public phicprocedurecodeold As String
    Public phicprocedurecode As String
    Public phicproceduredesc As String
    Public RVU As Integer
    Public isdefault As Boolean
    Public isactive As Boolean
    Public memo As String
    Public createdbyid As Long
    Public updatedbyid As Long

    Public Shared Function getProcedures(ByVal sop As Integer, ByVal search As String, Optional ByRef phicprocedurecodeold As Integer = 1) As DataTable
        Dim strPar() As String = {"operation", "soperation", "search", "phicprocedurecodeold"}
        Dim strVal() As Object = {0, sop, search, phicprocedurecodeold}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.SetParam(strPar, strVal, "spPHICProcedures", 0)
    End Function
    Public Shared Function getCategories(ByVal sop As Integer, ByVal search As String) As DataTable
        Dim strPar() As String = {"operation", "soperation", "search"}
        Dim strVal() As Object = {0, sop, search}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.SetParam(strPar, strVal, "spPHICProceduresCategories", 0)
    End Function

    Public Sub SaveCategory(ByRef isnew As Boolean, ByRef sop As Integer)
        operation = 2
        If isnew Then
            operation = 1
        End If
        Dim strPar() As String = {"operation", "soperation", "phicprocedurecatnoold", "phicprocedurecatno", "phicprocedurecatdesc", "NewPK"}
        Dim strVal() As Object = {operation, sop, phicprocedurecatno, phicprocedurecatno, phicprocedurecatdesc, operation}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring)
        s.SetParam(strPar, strVal, "spPHICProceduresCategories", 2)
    End Sub
    Public Sub SaveProcedure(ByRef isnew As Boolean, ByRef sop As Integer)
        operation = 2
        If isnew Then
            operation = 1
        End If
        Dim strPar() As String = {"operation", "soperation", "phicprocedurecodeold", "phicprocedurecode", "phicproceduredesc",
                                  "RVU", "phicprocedurecatno", "phic_isdefault", "phic_isactive", "phic_memo",
                                  "phic_createdbyid", "phic_updatedbyid", "NewPK"}
        Dim strVal() As Object = {operation, sop, phicprocedurecodeold, phicprocedurecode, phicproceduredesc,
                                  RVU, phicprocedurecatno, isdefault, isactive, memo,
                                  createdbyid, updatedbyid, operation}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring)
        s.SetParam(strPar, strVal, "spPHICProcedures", 2)
    End Sub
End Class
