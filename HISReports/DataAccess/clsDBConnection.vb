Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class clsDBConnection
#Region "Variables"
    Dim DBCon As New SqlConnection


#End Region

#Region "Properties"
    Public ReadOnly Property GDBConn() As SqlConnection
        Get
            Return DBCon
        End Get
    End Property
#End Region

#Region "Methods"
    Public Sub CreateOpenConnection()
         
        'DBCon.ConnectionString = ConfigurationManager.AppSettings(constringmap) ' Module1.returnDB(Module1.globalDB)
        'DBCon.ConnectionString = "Data Source=192.168.1.207;Initial Catalog=" + Module1.globalDB + "; User ID=sa;Password=S1mpleSoftech;"
        DBCon.ConnectionString = gconnectionstring
        DBCon.Open()
    End Sub

    'Public Sub CreateOpenConnection(ByVal databasename As String)
    '    Dim version_cnt As Integer = 5
    '    Dim s As String = "Close"
    '    'Do
    '    '    Try
    '    '        DBCon.ConnectionString = "Data Source=SQL500" + version_cnt.ToString() + ".Smarterasp.net;Initial Catalog= DB_9AB170_" + databasename + ";User Id=DB_9AB170_" + databasename + "_admin;Password=simplesoftech;"
    '    '        DBCon.Open()
    '    '        s = DBCon.State().ToString()
    '    '    Catch ex As Exception
    '    '        version_cnt = version_cnt + 1
    '    '    End Try
    '    'Loop Until s = "Open"


    '    ' local server only
    '    Try

    '        DBCon.ConnectionString = "Server=192.168.1.33; Data Source=SOFTWORKS1-PC\SQLEXPRESS;Database=" + databasename + ";User Id=sa; Password=simple;"
    '        DBCon.Open()
    '        'Dim s As String = DBCon.State().ToString()
    '    Catch ex As Exception
    '    End Try

    'End Sub

    Public Sub CloseDestroyConnection()
        If Not DBCon.State = ConnectionState.Closed Then
            DBCon.Close()
        End If
        DBCon = Nothing
    End Sub

    '**********************************
    'author: toni
    'added date: April 13, 2010
    '**********************************
    Public Function BeginTransaction() As SqlTransaction
        Dim myTrans As SqlTransaction
        If Not DBCon.State = ConnectionState.Closed Then
            myTrans = DBCon.BeginTransaction()
        End If
        Return myTrans
    End Function
    Public Sub CommitTransaction(ByVal myTrans As SqlTransaction)
        If Not DBCon.State = ConnectionState.Closed Then
            myTrans.Commit()
        End If
    End Sub
    Public Sub RollbackTransaction(ByVal myTrans As SqlTransaction)
        If Not DBCon.State = ConnectionState.Closed Then
            myTrans.Rollback()
        End If
    End Sub

#End Region
End Class
