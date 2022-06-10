Public Class frmReasonForReferral
    Sub New(ByRef formstatus As enFormStatus)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.myCurrentFormStatus = formstatus
    End Sub
    Private Sub frmReferralReason_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If myCurrentFormStatus <> enFormStatus.add Then
            LoadRecord()
        End If
        Call EnableFields()
        Me.tsSaved.Image = modGlobal.save_icon
        Me.tsClosed.Image = modGlobal.close_icon
    End Sub
#Region "Variables"
    Public isSave As Boolean
    Public reasonreferralno As Long
    Public myCurrentFormStatus As enFormStatus
    Dim isValidName As Boolean = True
    Dim dtRecord As New DataTable
    Public oldDescription As String
    Dim tempmemo As String
    Dim erp As New ErrorProvider

    Enum enFormStatus
        browsing = 0
        add = 1
        edit = 2
        view = 3
    End Enum
#End Region
#Region "Methods"
    Private Sub LoadRecord()
        Dim DtRecord As New DataTable
        DtRecord = clsAdmissiondetails.genericcls(44, reasonreferralno)
        txtDescription.Text = DtRecord.Rows(0).Item("description")
        txtMemo.Text = DtRecord.Rows(0).Item("memo")
        Me.chkActive.Checked = DtRecord.Rows(0).Item("isactive")
    End Sub

    Private Sub Save()
        Dim x As New clsReasonForRefferal

        With x
            .Oldreasonreferralno = Me.reasonreferralno
            .description = Me.txtDescription.Text
            .isactive = Me.chkActive.Checked
            .createdbyid = modGlobal.employeeid
            .updatedbyid = modGlobal.employeeid
            .datecreated = Utility.GetServerDate
            .dateupdated = .datecreated

            If myCurrentFormStatus = enFormStatus.add Then
                reasonreferralno = .saveReferralReason(0, True)
                oldDescription = txtDescription.Text
            Else
                .saveReferralReason(0, False)
            End If
        End With
        myCurrentFormStatus = enFormStatus.browsing
        isSave = True
        Call EnableFields()
    End Sub
    Private Sub Saved()
        If isValidName = False Or Trim(txtDescription.Text) = "" Then
            Exit Sub
        End If
        If myCurrentFormStatus = enFormStatus.add Then
            If MsgBox("Are you sure want to save this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, modGlobal.msgboxTitle) = MsgBoxResult.Yes Then
                Call Save()
                MsgBox("Records successfully saved.", MessageBoxIcon.Information + MessageBoxButtons.OK, modGlobal.msgboxTitle)
            End If
        ElseIf myCurrentFormStatus = enFormStatus.edit Then
            If MsgBox("Are you sure you want to update this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, modGlobal.msgboxTitle) = MsgBoxResult.Yes Then
                Call Save()
                MsgBox("Record successfully updated.", MessageBoxIcon.Information + MessageBoxButtons.OK, modGlobal.msgboxTitle)
            End If
        End If
    End Sub
    Private Sub EnableFields()
        If myCurrentFormStatus = enFormStatus.browsing Then
            Me.txtDescription.Enabled = False
            Me.txtMemo.Enabled = False
            Me.chkActive.Enabled = False
            Me.tsSaved.Visible = False
            Me.ToolStripSeparator1.Visible = False
            Me.tsClosed.Visible = True
            Me.tsCancels.Visible = False
        ElseIf myCurrentFormStatus = enFormStatus.add Or myCurrentFormStatus = enFormStatus.edit Then
            Me.txtDescription.Enabled = True
            Me.txtMemo.Enabled = True
            Me.chkActive.Enabled = True
            Me.tsSaved.Visible = True
            Me.ToolStripSeparator1.Visible = True
            Me.tsClosed.Visible = True
            Me.tsCancels.Visible = False
        End If
    End Sub
    Private Function isFieldValidNameItemType() As Boolean
        dtRecord = New DataTable
        dtRecord = clsitems.GenericVerification("ItemType", 12, txtMemo.Text, 0, txtDescription.Text)
        If txtMemo.Text = "" Then
            SetErrorProvider(Me.txtMemo, "This field is required.")
            isValidName = False
        ElseIf dtRecord.Rows(0).Item("isExist") > 0 Then
            SetErrorProvider(Me.txtMemo, "Item Type Name already exists in the database.")
            isValidName = False
        Else
            SetErrorProvider(Me.txtMemo)
            isValidName = True
        End If
        Return isValidName
        Return True
    End Function
    'Private Function isFieldValidNameItemTypeCode() As Boolean
    '    dtRecord = New DataTable
    '    dtRecord = clsitems.GenericVerification("ItemType", 11, txtMemo.Text, 0, txtDescription.Text)
    '    If txtDescription.Text = "" Then
    '        SetErrorProvider(Me.txtDescription, "This field is required.")
    '        isValidName = False
    '    ElseIf dtRecord.Rows(0).Item("isExist") > 0 Then
    '        SetErrorProvider(Me.txtDescription, "Item Type Code already exists in the database.")
    '        isValidName = False
    '    Else
    '        SetErrorProvider(Me.txtDescription)
    '        isValidName = True
    '    End If
    '    Return isValidName
    '    Return True
    'End Function
    Private Sub SetErrorProvider(ByVal ctl As Control, Optional ByVal strErrorMessage As String = "")
        erp.SetError(ctl, strErrorMessage)
    End Sub
    Private Sub frmClose()
        If myCurrentFormStatus <> enFormStatus.browsing Then
            If MsgBox("Are you sure you want to close this form?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, modGlobal.msgboxTitle) = MsgBoxResult.Yes Then
                Me.Close()
                isSave = False
            End If
        Else
            Me.Close()
            isSave = True
        End If
    End Sub
#End Region

    Private Sub tsSaved_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSaved.Click
        Call Saved()
    End Sub


    'Private Sub txtDescription_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescription.TextChanged
    '    If myCurrentFormStatus = enFormStatus.edit And txtDescription.Focused = True Then
    '        If tempDescription <> Me.txtDescription.Text Then
    '            isFieldValidNameItemTypeCode()
    '        Else
    '            SetErrorProvider(txtDescription)
    '        End If
    '    ElseIf myCurrentFormStatus = enFormStatus.add And txtDescription.Focused = True Then
    '        isFieldValidNameItemTypeCode()
    '    Else
    '        Exit Sub
    '    End If
    'End Sub

    'Private Sub txtMeasurement_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMemo.TextChanged
    '    If myCurrentFormStatus = enFormStatus.edit And txtMemo.Focused = True Then
    '        If tempDescription  <> Me..Text Then
    '            isFieldValidNameItemType()
    '        Else
    '            SetErrorProvider(txtMemo)
    '        End If
    '    ElseIf myCurrentFormStatus = enFormStatus.add And txtMemo.Focused = True Then
    '        isFieldValidNameItemType()
    '    Else
    '        Exit Sub
    '    End If
    'End Sub

    Private Sub tsClosed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsClosed.Click
        Call frmClose()
    End Sub
End Class