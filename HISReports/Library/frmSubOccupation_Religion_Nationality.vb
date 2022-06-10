Public Class frmSubOccupation_Religion_Nationality

#Region "Variables"
    Public isSave As Boolean
    Public myFormStatus As enFormStatus
    Public myactionStatus As actionStatus
    Dim indicator, rowless As Integer
    Public isvalidname As Boolean
    Public oldid As Integer = 0
    Public oldDescription As String
    Public data As New DataTable()
    Dim erp As New ErrorProvider()
#End Region

#Region "New Methods"
    Public Enum enFormStatus
        browsing = 0
        add = 1
        edit = 2
        view = 3
    End Enum
    Public Enum actionStatus
        Occupation = 0
        Religion = 1
        Nationality = 2
        Manufacturer = 3
    End Enum
    Sub New(ByVal FormStatus As enFormStatus, ByVal ActionStatus As actionStatus)
        InitializeComponent()
        Me.Text = ActionStatus.ToString()
        myFormStatus = FormStatus
        myactionStatus = ActionStatus
        Me.Text = myactionStatus.ToString()
        Me.lblDescription.Text = myactionStatus.ToString()
    End Sub
#End Region

#Region "Methods"
    Private Sub clearField()
        Me.txtDescription.Clear()
        Me.chkIsActive.Checked = True
        Me.chkIsDefault.Checked = False
        Me.txtMemo.Clear()
    End Sub
    Private Sub enabledField(ByVal sw As Boolean)
        Me.txtDescription.Enabled = sw
        Me.chkIsActive.Enabled = sw
        Me.chkIsDefault.Enabled = sw
        Me.txtMemo.Enabled = sw
        Me.tsSave.Visible = sw
        If myactionStatus = actionStatus.Manufacturer Then
            Me.txtMemo.Visible = False
            Me.lblmemo.Visible = False
        End If
    End Sub
    Private Sub subload()
        data = Nothing
        'Me.tsSave.Text = "Update"
        Select Case myFormStatus
            Case enFormStatus.add
                Me.tsSave.Text = "Save"
                enabledField(True)
                clearField()
                Me.tsSave.Visible = True
            Case enFormStatus.edit
                Select Case myactionStatus
                    Case actionStatus.Nationality
                        data = clsOccupationReligionNationality.getInfo(8, "", oldid)
                        Me.oldDescription = data.Rows(0)("Nationality").ToString()
                        Me.txtMemo.Text = data.Rows(0)("nt_memo").ToString()
                    Case actionStatus.Occupation
                        data = clsOccupationReligionNationality.getInfo(0, "", oldid)
                        Me.oldDescription = data.Rows(0)("description").ToString()
                        Me.txtMemo.Text = data.Rows(0)("oc_memo").ToString()
                    Case actionStatus.Religion
                        data = clsOccupationReligionNationality.getInfo(4, "", oldid)
                        Me.oldDescription = data.Rows(0)("religion").ToString()
                        Me.txtMemo.Text = data.Rows(0)("rl_memo").ToString()
                    Case actionStatus.Manufacturer
                        data = clsitems.getitem(18, oldid, 1)
                        Me.oldDescription = data.Rows(0)("supplier").ToString()
                End Select
                Me.txtDescription.Text = oldDescription
                Me.chkIsActive.Checked = data.Rows(0)("isactive")
                Me.chkIsDefault.Checked = data.Rows(0)("isdefault")
                enabledField(True)
            Case Else
                Select Case myactionStatus
                    Case actionStatus.Nationality
                        data = clsOccupationReligionNationality.getInfo(8, "", oldid)
                        Me.txtDescription.Text = data.Rows(0)("Nationality").ToString()
                        Me.txtMemo.Text = data.Rows(0)("nt_memo").ToString()
                    Case actionStatus.Occupation
                        data = clsOccupationReligionNationality.getInfo(14, "", oldid)
                        Me.txtDescription.Text = data.Rows(0)("description").ToString()
                        Me.txtMemo.Text = data.Rows(0)("oc_memo").ToString()
                    Case actionStatus.Religion
                        data = clsOccupationReligionNationality.getInfo(6, "", oldid)
                        Me.txtDescription.Text = data.Rows(0)("religion").ToString()
                        Me.txtMemo.Text = data.Rows(0)("rl_memo").ToString()
                    Case actionStatus.Manufacturer
                        data = clsitems.getitem(18, oldid, 1)
                        Me.txtDescription.Text = data.Rows(0)("supplier").ToString()
                End Select
                Me.chkIsActive.Checked = data.Rows(0)("isactive")
                Me.chkIsDefault.Checked = data.Rows(0)("isdefault")
                enabledField(False)
                Me.tsSave.Visible = False
        End Select

        Me.tsSave.Image = modGlobal.save_icon
        Me.tsClose.Image = modGlobal.close_icon
        Me.KeyPreview = True
    End Sub
    Private Sub subSave()
        If Not isFieldValidNameDescription() Or Trim(txtDescription.Text) = "" Or Trim(txtDescription.Text) = "" Then
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to " & Me.tsSave.Text & " these record?", modGlobal.msgboxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If myactionStatus = actionStatus.Manufacturer Then
                'With New clsitems
                '    .SupplierNo = Me.oldid
                '    .SupplierName = Me.txtDescription.Text
                '    .isactive = Me.chkIsActive.Checked
                '    .IsHospitalSupplier = True
                '    .issync = False
                '    .CUdate = Utility.GetServerDate
                '    .createdby = modGlobal.employeeid
                '    .updatedby = modGlobal.employeeid
                '    If myFormStatus = enFormStatus.add Then
                '        .server_id = 0
                '        oldid = .SaveSupplier(True)
                '        oldDescription = txtDescription.Text
                '        MessageBox.Show("Record successfully saved.", modGlobal.msgboxTitle)
                '        enabledField(False)
                '        Me.tsSave.Visible = False
                '    Else
                '        .SaveSupplier(False)
                '    End If
                'End With
                'enabledField(False)
            Else
                With New clsOccupationReligionNationality
                    .Oldid = Me.oldid
                    .Description = Me.txtDescription.Text
                    .isactive = Me.chkIsActive.Checked
                    .isdefault = Me.chkIsDefault.Checked
                    .memo = Me.txtMemo.Text
                    If myFormStatus = enFormStatus.add Then
                        .createdby = modGlobal.employeeid
                        oldid = .save("spOccupation_Religion_Nationality", True, myactionStatus)
                        Me.oldDescription = Me.txtDescription.Text
                        'MessageBox.Show("Record successfully " & Me.tsSave.Text & "ed", modGlobal.msgboxTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.tsSave.Visible = False
                        If MessageBox.Show("Would you like to create another new entry?", modGlobal.msgboxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                            enabledField(True)
                            clearField()
                        Else
                            enabledField(False)
                            Me.tsSave.Visible = False
                        End If
                    Else
                        .updatedby = modGlobal.employeeid
                        .save("spOccupation_Religion_Nationality", False, myactionStatus)
                        Me.oldDescription = Me.txtDescription.Text
                        'MessageBox.Show("Record successfully " & Me.tsSave.Text & "d", modGlobal.msgboxTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        enabledField(False)
                        Me.tsSave.Visible = False
                    End If
                End With
            End If
            isSave = True
        Else
            Return
        End If
    End Sub
#Region "Validation"
    Private Function AllDataEntryFieldsAreValid() As Boolean
        Dim blnValid As Boolean = True
        If isFieldValid(Me.txtDescription) = False Then
            blnValid = False
        End If
        Return blnValid
    End Function
    Private Sub ResetAllErrorProviders()
        SetErrorProvider(Me.txtDescription)
    End Sub
    Private Sub SetErrorProvider(ByVal ctl As Control, Optional ByVal strErrorMessage As String = "")
        erp.SetError(ctl, strErrorMessage)
    End Sub
   
#End Region
#End Region

#Region "Events"
    Private Sub tsSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSave.Click
        subSave()
    End Sub
    Private Sub tsClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsClose.Click
        Me.Close()
    End Sub
    Private Sub frmSubOccupation_Religion_Nationality_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        subload()
    End Sub
    Private Sub frmSubOccupation_Religion_Nationality_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.Control = True And e.KeyCode = Keys.S Then
            Me.tsSave.PerformClick()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.tsClose.PerformClick()
        End If
    End Sub
#End Region

    Private Function isFieldValidNameDescription() As Boolean
        If myactionStatus = actionStatus.Manufacturer Then
            Dim dtRecord As New DataTable
            Dim target As String = myactionStatus.ToString()
            dtRecord = clsitems.GenericVerification(target, 5, txtDescription.Text, oldid)
            If txtDescription.Text = "" Then
                SetErrorProvider(Me.txtDescription, "This field is required.")
                isvalidname = False
            ElseIf dtRecord.Rows(0).Item("isExist") > 0 Then
                SetErrorProvider(Me.txtDescription, target + " already exists in the database.")
                isvalidname = False
            Else
                SetErrorProvider(Me.txtDescription)
                isvalidname = True
            End If
            Return isvalidname
        Else
            isvalidname = isFieldValid(txtDescription)
            Return isvalidname
        End If

        Return True
    End Function
    Private Function isFieldValid(ByVal ctl As Control) As Boolean
        Dim isValid As Boolean = False
        Dim soperation As Integer
        data = Nothing
        If Me.oldDescription <> ctl.Text Then
            Select Case ctl.Text
                Case ""
                    SetErrorProvider(ctl, "Field is required.")
                Case Else
                    Select Case myactionStatus
                        Case actionStatus.Nationality
                            soperation = 3
                        Case actionStatus.Occupation
                            soperation = 2
                        Case actionStatus.Religion
                            soperation = 7
                    End Select
                    data = clsOccupationReligionNationality.getInfo(soperation, ctl.Text, oldid)
                    Select Case data.Rows.Count
                        Case Is > 0
                            SetErrorProvider(ctl, "Value name: " & ctl.Text & " is already exist in our database.")
                        Case Else
                            SetErrorProvider(ctl)
                            isValid = True
                    End Select
            End Select
        End If

        Return isValid
    End Function

    Private Sub txtDescription_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescription.Leave
        If myFormStatus = enFormStatus.edit Then
            If oldDescription <> Me.txtDescription.Text Then
                isFieldValidNameDescription()
            Else
                SetErrorProvider(txtDescription)
            End If
        ElseIf myFormStatus = enFormStatus.add Then
            isFieldValidNameDescription()
        Else
            Exit Sub
        End If
    End Sub
End Class