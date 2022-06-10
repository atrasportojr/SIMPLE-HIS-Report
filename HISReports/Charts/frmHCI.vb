Imports System.IO
Imports System.Data.SqlClient
Imports System.ComponentModel

Public Class frmHCI

    Private Sub frmHCI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InitFormDefault()
    End Sub

#Region "Variables"
    Public issave As Boolean
    Public myFormStatus As enFormStatus
    Private Erp As New ErrorProvider

    Public HCIId As Long

    Enum enFormStatus
        add = 0
        edit = 1
        browsing = 2
    End Enum
#End Region
    Private Sub setError(ByVal ctl As Control, Optional ByVal strErrorMessage As String = "")
        Erp.SetError(ctl, strErrorMessage)
    End Sub

    Private Sub InitFormDefault()
        Me.CenterToScreen()
        If myFormStatus = enFormStatus.edit Then
            Call loadDetails()
        ElseIf myFormStatus = enFormStatus.browsing Then

            Me.txthciname.ReadOnly = True
            Me.txthcicode.ReadOnly = True
            Me.txthouseno.ReadOnly = True
            Me.txtbarangay.ReadOnly = True
            Me.txtcitymunicipality.ReadOnly = True
            Me.txtprovince.ReadOnly = True
            Me.txtZipCode.ReadOnly = True
            Me.chkIsactive.Visible = False

            Me.tsSave.Visible = False
            Me.ToolStripSeparator2.Visible = False
        End If
    End Sub
    Private Sub loadDetails()
        Dim dt As DataTable = clsHCI.getHCI(1, Me.HCIId)
        Me.txthcicode.Text = Utility.NullToEmptyString(dt.Rows(0).Item("hcicode"))
        Me.txthciname.Text = Utility.NullToEmptyString(dt.Rows(0).Item("hciname"))
        Me.txthouseno.Text = Utility.NullToEmptyString(dt.Rows(0).Item("bldgnonamestreet"))
        Me.txtbarangay.Text = Utility.NullToEmptyString(dt.Rows(0).Item("barangay"))
        Me.txtcitymunicipality.Text = Utility.NullToEmptyString(dt.Rows(0).Item("citymunicipality"))
        Me.txtprovince.Text = Utility.NullToEmptyString(dt.Rows(0).Item("province"))
        Me.txtZipCode.Text = Utility.NullToEmptyString(dt.Rows(0).Item("zipcode"))
        Me.chkIsactive.Checked = Utility.NullToBoolean(dt.Rows(0).Item("isactive"))
    End Sub

    Private Sub loadAddress(ByRef barangayid As Long)
        Dim dt As DataTable = clsAddress.GenericVerification(12, "", "", barangayid)
        Me.txtbarangay.Text = dt.Rows(0).Item("barangayname")
        Me.txtcitymunicipality.Text = dt.Rows(0).Item("municipalityname")
        Me.txtprovince.Text = dt.Rows(0).Item("provincename")
    End Sub

    Private Function subSave() As Boolean
        Dim isvalid As Boolean = True

        If Trim(Me.txthciname.Text) = "" Then
            isvalid = False
            setError(Me.txthciname, "This field is required!")
        Else
            setError(Me.txthciname)
        End If

        Return isvalid
    End Function

    Private Sub txtQuantity_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim textBox As TextBox = DirectCast(sender, TextBox)
        If Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or (e.KeyChar = "." And textBox.Text.IndexOf(".") < 0)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub tsSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSave.Click
        If subSave() Then
            Dim x As New clsHCI
            With x
                .hciid = Me.HCIId
                .hcicode = Me.txthcicode.Text
                .hciname = Me.txthciname.Text
                .bldgnonamestreet = Me.txthouseno.Text
                .barangay = Me.txtbarangay.Text
                .citymunicipality = Me.txtcitymunicipality.Text
                .province = Me.txtprovince.Text
                .zipcode = Me.txtZipCode.Text
                .isrhu = False
                .memo = ""
                .isactive = Me.chkIsactive.Checked
                If Me.HCIId = 0 Then
                    Me.HCIId = .saveHealthCareInstitution(True)
                Else
                    .saveHealthCareInstitution(False)
                End If
                Me.issave = True
                Me.Close()
            End With
        End If
    End Sub

    Private Sub closetoolstrip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closetoolstrip.Click
        Me.Close()
    End Sub

    Private Sub txtcharge_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim textBox As TextBox = DirectCast(sender, TextBox)
        If Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or (e.KeyChar = "." And textBox.Text.IndexOf(".") < 0)) Then
            e.Handled = True
        End If
    End Sub
End Class