Imports System
Imports System.IO
Imports System.Text
Imports System.Xml
Imports System.Net

Imports System.Security.Cryptography
Imports System.Configuration
Imports PdfSharp.Pdf

Imports System.Type
Imports System.Xml.Serialization
Imports System.Data
Imports System.Data.SqlClient
Public Class Utility
    Public Enum ReferrenceKey
        transmitalno = 1
        eclaimsclaimno = 2
        eclaimsdocumentno = 3
        employeeno = 4
    End Enum

    Public Shared Function formatHospNo(ByVal mHospitalNo As String) As String
        Dim i As Integer
        Dim lhospno As Integer
        lhospno = mHospitalNo.Length()
        Dim value As String = mHospitalNo
        Dim a As Integer = 2
        For i = 0 To lhospno - 2 Step a
            value = value.Insert(i + a, "-")
            If (a = 3) = True Then
                Exit For
            Else
                a = a + 1
            End If
        Next

        Return value
    End Function

    Public Shared Function ConvertXMLStringToDataSet(ByVal xmldata As String) As DataSet
        Dim ds As New DataSet
        Dim sr As New System.IO.StringReader(xmldata)
        Dim doc As New Xml.XmlDocument
        doc.Load(sr)
        Dim reader As New Xml.XmlNodeReader(doc)
        While reader.Read()
            Select Case reader.NodeType
                Case Xml.XmlNodeType.Element
                    Dim dt As New DataTable
                    dt.TableName = reader.Name
                    Dim tableexist As Boolean = False
                    tableexist = ds.Tables.Contains(reader.Name)
                    Dim str As String = reader.Name
                    While (reader.MoveToNextAttribute())
                        dt.Columns.Add(reader.Name)
                        If dt.Rows.Count = 0 Then
                            dt.Rows.Add("")
                        End If
                        dt.Rows(0).Item(reader.Name) = reader.Value
                    End While
                    If str = "DOCUMENT" Then
                        reader.Read()
                        dt.Columns.Add("INNERVALUE")
                        If dt.Rows.Count = 0 Then
                            dt.Rows.Add("")
                        End If
                        dt.Rows(0).Item("INNERVALUE") = RTrim(reader.Value)
                    End If
                    'Dim str As String = reader.ReadInnerXml
                    'If str.Length > 0 Then
                    '    dt.Columns.Add("INNERVALUE")
                    '    If dt.Rows.Count = 0 Then
                    '        dt.Rows.Add("")
                    '    End If
                    '    dt.Rows(0).Item("INNERVALUE") = str
                    'End If
                    If tableexist Then
                        ds.Tables(dt.TableName).Merge(dt)
                    Else
                        ds.Tables.Add(dt)
                    End If
                    Exit Select
            End Select
        End While
        Return ds
    End Function

    Public Shared Function getReference(ByRef key As ReferrenceKey) As Long
        Try
            Dim strPar() As String = {"operation", "soperation", "search"}
            Dim strVal() As String = {0, 14, key.ToString}
            Dim s As New simpleadapter.SimpleAdapter(gconnectionstring)
            Dim dt As DataTable = s.SetParam(strPar, strVal, "spEclaims", 0)
            Dim obj As Long = dt.Rows(0).Item("referencevalue")
            Return obj
        Catch ex As Exception
            Return 0
        End Try


    End Function

    Public Shared Function GetServerDate() As Date
        Try
            Dim strPar() As String = {"Operation"}
            Dim strVal() As String = {0}
            'Dim dt As DataTable = GenericDA.ManageQuery(strPar, strVal, "spGetSystemDate", 0)
            Dim s As New simpleadapter.SimpleAdapter(gconnectionstring)
            Dim dt As DataTable = s.SetParam(strPar, strVal, "spGetSystemDate", 0)
            Dim vServerDate As Date = CDate(dt.Rows(0).Item("serverdatetime").ToString)
            dt = Nothing
            Return vServerDate
        Catch ex As Exception
            Return FormatDateTime("1/1/1900", DateFormat.ShortDate)
        End Try


    End Function

    Public Shared Function NullToEmptyString(ByVal myInput As Object, Optional ByVal def As Object = "") As String
        'If the input value is NULL then return an empty string
        'Otherwise return the original value as a string
        If def <> "" Then
            NullToEmptyString(def)
        End If
        If IsDBNull(myInput) Then
            Return def
        ElseIf IsNothing(myInput) Then
            Return def
        Else
            Return myInput
        End If
    End Function
    Public Shared Function NullToBoolean(ByVal myInput As Object) As Boolean
        If IsDBNull(myInput) Then
            Return False
        ElseIf IsNothing(myInput) Then
            Return False
        Else
            Return myInput
        End If
    End Function

    Public Shared Function NullToCurrentDate(ByVal myInput As Object) As Date
        'If the input value is NULL then return the default date format 1/1/1900
        'Otherwise return the original value as a string
        If IsDBNull(myInput) Then
            Return Date.Now
        Else
            Return myInput
        End If
    End Function
    Public Shared Function NullToDefaultDateFormat(ByVal myInput As Object, Optional ByVal def As Object = "1/1/1900") As Date
        'If the input value is NULL then return the default date format 1/1/1900
        'Otherwise return the original value as a string
        If def <> "1/1/1900" And IsDBNull(myInput) Then
            Return NullToDefaultDateFormat(def)
        End If
        If IsDBNull(myInput) Then
            Return FormatDateTime("1/1/1900", DateFormat.ShortDate)
        Else
            If myInput < CDate("1/1/1900") Then
                Return FormatDateTime("1/1/1900", DateFormat.ShortDate)
            End If
            Return myInput
        End If
    End Function
    Public Shared Function NullToZero(ByVal myInput As Object) As Decimal
        'If the input value is NULL then return an empty string
        'Otherwise return the original value as a string
        If IsDBNull(myInput) Then
            Return 0

        Else
            Return myInput
        End If
    End Function

    Public Shared Function EmptyToZero(ByVal myInput As Object) As Decimal
        'If the input value is NULL then return an empty string
        'Otherwise return the original value as a string
        Try
            If IsDBNull(myInput) Then
                Return 0
            Else
                Return myInput
            End If
        Catch ex As Exception
            Return 0
        End Try

    End Function


    'Public Shared Function readSetting(ByVal setting As Integer) As String
    '    Try
    '        Dim key As 
    '        key = setting
    '        Dim appSettings = ConfigurationManager.AppSettings
    '        Dim result As String = appSettings(key.ToString)
    '        If IsNothing(result) Then
    '            result = "Not found"
    '        End If
    '        Return result
    '    Catch e As ConfigurationErrorsException
    '        Return ""
    '    End Try
    'End Function


    Public Shared Function GetRandomString() As String
        Dim validchars As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890"
        Dim sb As New System.Text.StringBuilder
        Dim rand As New Random()
        For i As Integer = 1 To 10
            Dim idx As Integer = rand.Next(0, validchars.Length)
            Dim randomChar As Char = validchars(idx)
            sb.Append(randomChar)
        Next i
        Return sb.ToString()
    End Function

    Public Shared Function convertImage(ByVal imgdata As Byte()) 'IDRIZ
        Dim ImageData(-1) As Byte
        ImageData = CType(imgdata, Byte())
        Dim MemoryStream As New System.IO.MemoryStream(ImageData)
        Dim image As System.Drawing.Image = System.Drawing.Image.FromStream(MemoryStream)
        Return image
    End Function

    Public Shared Function CheckForInternetConnection() As Boolean
        Try
            Using client = New WebClient()
                Using stream = client.OpenRead("http://www.google.com")
                    Return True
                End Using
            End Using
        Catch
            Return False
        End Try
    End Function
    Public Shared Function parseParams(ByRef obj() As Object) As Object
        For i As Integer = 0 To obj.Length - 1
            Try
                If obj.GetValue(i) = Nothing Then
                    obj.SetValue(DBNull.Value, i)
                End If
            Catch ex As Exception
                obj.SetValue(DBNull.Value, i)
            End Try

        Next
        Return obj
    End Function
    Public Shared Function formatHospitalNumber(ByVal str As String) 'by IDRIZ
        Dim chars As Char() = str.ToCharArray()
        Dim str1 As String = ""
        Dim str2 As String = ""
        If str = "" Then
            str2 = ""
        Else
            For i = 0 To chars.Length
                If i = 2 Then
                    str2 = str2 + "-"
                    str2 = str2 + chars(i).ToString()
                ElseIf i = 4 Then
                    str2 = str2 + "-"
                    str2 = str2 + chars(i).ToString()
                ElseIf i = chars.Length - 1 Then
                    str1 = chars(i).ToString()
                    str2 = str2 + str1
                    Exit For
                ElseIf i = chars.Length Then
                    str2 = str2 + str1
                    Exit For
                Else
                    str1 = chars(i).ToString()
                    str2 = str2 + str1
                End If
            Next


        End If
        Return str2
    End Function
End Class
