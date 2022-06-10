Public Class frmMeasurements

    Private Sub frmMeasurements_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EnableFields()
        If myCurrentFormStatus <> enFormStatus.add Then
            LoadRecord()
        End If
        Me.tsSaved.Image = modGlobal.save_icon
        Me.tsClosed.Image = modGlobal.close_icon
        tsCancels.Image = modGlobal.cancel_icon
    End Sub
#Region "Variables"
    Public UnitID As Long
    Public isSave As Boolean
    Public myCurrentFormStatus As enFormStatus
    Dim isValidName As Boolean = True
    Dim dtRecord As New DataTable
    Dim tempMeasurementName As String
    Dim tempMeasurementcode As String
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
        Dim dtRecord As New DataTable
        dtRecord = clsitems.getUnit(2, UnitID)
        Me.tempMeasurementcode = dtRecord.Rows(0).Item("unitcode")
        Me.tempMeasurementName = dtRecord.Rows(0).Item("unitdescription")
        Me.txtMeasurementCode.Text = tempMeasurementcode
        Me.txtMeasurement.Text = tempMeasurementName
    End Sub
    Private Sub Save()
        Dim cItems As New clsitems

        With cItems
            .unitmeasurementName = Me.txtMeasurement.Text
            .unitmeasurementcode = Me.txtMeasurementCode.Text
            .isactive = Me.chkActive.Checked
            .createdby = modGlobal.employeeid
            .updatedby = modGlobal.employeeid
            .CUdate = Utility.GetServerDate

            If myCurrentFormStatus = enFormStatus.add Then
                UnitID = cItems.SaveMeasurement(True)
                Call SaveLog("Libraries", "New Unit of Measurement: " & Me.txtMeasurementCode.Text & " (" & Me.txtMeasurement.Text & ")")
            Else
                .SaveMeasurement(False, UnitID)
                Call SaveLog("Libraries", "Update Unit of Measurement: " & Me.txtMeasurementCode.Text & " (" & Me.txtMeasurement.Text & ")")
            End If
        End With
        myCurrentFormStatus = enFormStatus.browsing
        isSave = True
        Call EnableFields()
    End Sub
    Private Sub Saved()
        If isValidName = False Or Trim(txtMeasurement.Text) = "" Or Trim(txtMeasurement.Text) = "" Then
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
            Me.txtMeasurementCode.Enabled = False
            Me.txtMeasurement.Enabled = False
            Me.chkActive.Enabled = False
            Me.tsSaved.Visible = False
            Me.ToolStripSeparator1.Visible = False
            Me.tsClosed.Visible = True
            Me.tsCancels.Visible = False
        ElseIf myCurrentFormStatus = enFormStatus.add Or myCurrentFormStatus = enFormStatus.edit Then
            Me.txtMeasurementCode.Enabled = True
            Me.txtMeasurement.Enabled = True
            Me.chkActive.Enabled = True
            Me.tsSaved.Visible = True
            Me.ToolStripSeparator1.Visible = True
            Me.tsClosed.Visible = True
            Me.tsCancels.Visible = False
        End If
    End Sub
    Private Function isFieldValidNameMeasurement() As Boolean
        dtRecord = New DataTable
        If tempMeasurementName <> Me.txtMeasurement.Text Then
            dtRecord = clsitems.getUnit(3, txtMeasurement.Text)
            If txtMeasurement.Text = "" Then
                SetErrorProvider(Me.txtMeasurement, "This field is required.")
                isValidName = False
            ElseIf dtRecord.Rows.Count > 0 Then
                SetErrorProvider(Me.txtMeasurement, "Unit Name already exists in the database.")
                isValidName = False
            Else
                SetErrorProvider(Me.txtMeasurement)
                isValidName = True
            End If
            Return isValidName
        End If

        Return True
    End Function
    Private Function isFieldValidNameMeasurementCode() As Boolean
        dtRecord = New DataTable
        If tempMeasurementcode <> Me.txtMeasurementCode.Text Then
            dtRecord = clsitems.getUnit(2, txtMeasurementCode.Text)
            If txtMeasurementCode.Text = "" Then
                SetErrorProvider(Me.txtMeasurementCode, "This field is required.")
                isValidName = False
            ElseIf dtRecord.Rows.Count > 0 Then
                SetErrorProvider(Me.txtMeasurementCode, "Unit Code already exists in the database.")
                isValidName = False
            Else
                SetErrorProvider(Me.txtMeasurementCode)
                isValidName = True
            End If
            Return isValidName
        End If

        Return True
    End Function
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


    Private Sub txtMeasurementCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMeasurementCode.TextChanged
        If myCurrentFormStatus = enFormStatus.edit And txtMeasurementCode.Focused = True Then
            If tempMeasurementcode <> Me.txtMeasurementCode.Text Then
                isFieldValidNameMeasurementCode()
            Else
                SetErrorProvider(txtMeasurementCode)
            End If
        ElseIf myCurrentFormStatus = enFormStatus.add And txtMeasurementCode.Focused = True Then
            isFieldValidNameMeasurementCode()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub txtMeasurement_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMeasurement.TextChanged
        If myCurrentFormStatus = enFormStatus.edit And txtMeasurement.Focused = True Then
            If tempMeasurementName <> Me.txtMeasurement.Text Then
                isFieldValidNameMeasurement()
            Else
                SetErrorProvider(txtMeasurement)
            End If
        ElseIf myCurrentFormStatus = enFormStatus.add And txtMeasurement.Focused = True Then
            isFieldValidNameMeasurement()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub tsClosed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsClosed.Click
        Call frmClose()
    End Sub
End Class