Imports System.IO
Imports System.Data.SqlClient
Imports System.ComponentModel
Imports System.Xml.Serialization
Imports System.Xml
Public Class frmRequestedBy

#Region "Variables"
    Public isLoginValid As Boolean
    Public RequestedByID As Long
    Public isSubModal As Boolean
    Private erp As New ErrorProvider
    Private tooltip As New ToolTip
#End Region

    Private Sub frmSetup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InitFormDefault()
    End Sub
    Private Sub ProceedLogin()
        Dim dtRecord As DataTable = clsUsers.GetUser(0, Me.txtUser.Text, clsJCypher.StringCipher.Encrypt(Me.txtPass.Text, cypherpassphrase), 0)
        If dtRecord.Rows.Count <> 0 Then
            Me.RequestedByID = dtRecord.Rows(0).Item("employeeid")
            Me.isLoginValid = True
        Else
            Me.isSubModal = True
        End If
        Me.Close()
    End Sub
    Private Sub btnSignIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSignIn.Click
        Me.Cursor = Cursors.WaitCursor
        Call ProceedLogin()

    End Sub
    Private Sub txtUser_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUser.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtPass.Focus()
            Me.txtPass.SelectAll()
        End If
    End Sub

    Private Sub txtPass_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtPass.MouseClick
        txtPass.SelectAll()
    End Sub
    Private Sub txtPass_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPass.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSignIn_Click(sender, e)
        End If
    End Sub

    Private Sub InitFormDefault()
        Me.CenterToScreen()
    End Sub
End Class