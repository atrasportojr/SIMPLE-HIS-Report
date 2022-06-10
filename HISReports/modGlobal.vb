Imports System.Data.SqlClient
Module modGlobal
    Public msgboxTitle As String = "SIMPLE HIS"
    Public gconnectionstring = ""
    Public Function SQLTestConnection(ByRef servername As String, ByRef databasename As String, ByRef authtype As Integer,
                                    ByRef username As String, ByRef password As String) As Integer
        Dim i As Integer = 0
        Dim str As String = Nothing
        Try
            If authtype = 0 Then
                str = "Data Source=" & servername & ";Initial Catalog=" & databasename & ";Trusted_Connection=True;Connection Timeout=60"
            ElseIf authtype = 1 Then
                str = "Data Source=" & servername & ";Initial Catalog=" & databasename & "; User ID=" & username & ";Password=" & password & ";Connection Timeout=60"
            End If

            gconnectionstring = str
            Dim _conn As New SqlConnection(str)
            If _conn.State = ConnectionState.Closed Then
                _conn.Open()
                i = _conn.State
            End If
        Catch ex As Exception
            gconnectionstring = ""
            MessageBox.Show(ex.Message, "CONNECTION ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return i
    End Function
End Module
