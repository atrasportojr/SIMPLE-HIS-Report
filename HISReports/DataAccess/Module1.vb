Module Module1


    Public value As String
    Public globalDB As String
    Public globalCompanyid As String
    Public globalTerminalid As String
    Public globalmessage As String
    Public isSuccess As Integer

    Dim list As New ArrayList

    Public constringmap As String = ""

    Function checkDB(ByVal key As String) As String
        Dim result As Boolean = False
        Dim text As String
        For Each text In list
            If key.Equals(text) Then
                result = True
            End If
        Next
        Return result
    End Function

End Module

