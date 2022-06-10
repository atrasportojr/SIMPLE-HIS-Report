Public Class frmPhilHealthEntry
    Inherits System.Windows.Forms.Form

#Region "Variables"
    Public myCurrentFormStatus As enFormStatus
    Public isSave As Boolean
    Public PhilHealthNo As String
    Private PhilMemberNo As String
    Public Patientid As Long
    Public admissionid As Long
    Dim erp As New ErrorProvider
    Private Const MF_BYPOSITION = &H400
    Private Const MF_REMOVE = &H1000
    Private Const MF_DISABLED = &H2
    Private dtPHIC As New DataTable
    Public oldPhilHealthNo As String
    Dim newPhilHealthRecord As New clsPhilHealth
    Dim dtPhilHealthRec As New DataTable
    Dim mphilmemberno As String
    Dim mlastname As String
    Dim mfirstname As String
    Dim mmiddlename As String
    Dim isvalid As Boolean = True
    Dim isvalidNo As Boolean = True
    Enum enFormStatus
        browsing = 0
        add = 1
        edit = 2
        view = 3
    End Enum

#End Region

#Region "Validation"
    Private Sub txtPhilMemberNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPhilMemberNo.TextChanged
        'isFieldValidphilno(txtPhilMemberNo)
        
        If myCurrentFormStatus = enFormStatus.edit And Replace(txtPhilMemberNo.Focused, "-", "") <> "" Then
            If mphilmemberno <> Me.txtPhilMemberNo.Text Then
                isFieldValidphilno(txtPhilMemberNo)
            Else
                SetErrorProvider(A1)
                isvalidNo = True
            End If
        ElseIf myCurrentFormStatus = enFormStatus.add And Replace(txtPhilMemberNo.Focused, "-", "") <> "" Then
            isFieldValidphilno(txtPhilMemberNo)
        Else
            Exit Sub
        End If
    End Sub
    Private Sub txtPhilFirstName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPhilFirstName.TextChanged
        'isFieldValidFName(txtPhilFirstName)
        If myCurrentFormStatus = enFormStatus.edit And (txtPhilFirstName.Focused = True Or txtPhilFirstName.Enabled = False) Then
            If mfirstname <> Me.txtPhilFirstName.Text Then
                isFieldValidFName(txtPhilFirstName)
            Else
                SetErrorProvider(A3)
                isvalid = True
            End If
        ElseIf myCurrentFormStatus = enFormStatus.add And (txtPhilFirstName.Focused = True Or txtPhilFirstName.Enabled = False) Then
            isFieldValidFName(txtPhilFirstName)
        Else
            Exit Sub
        End If
    End Sub
    Private Sub txtPhilLastName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPhilLastName.TextChanged
        'isFieldValidLName(txtPhilLastName)
        If myCurrentFormStatus = enFormStatus.edit And (txtPhilLastName.Focused = True Or txtPhilLastName.Enabled = False) Then
            If mlastname <> Me.txtPhilLastName.Text Then
                isFieldValidLName(txtPhilLastName)
            Else
                SetErrorProvider(A2)
                isvalid = True
            End If
        ElseIf myCurrentFormStatus = enFormStatus.add And (txtPhilLastName.Focused = True Or txtPhilLastName.Enabled = False) Then
            isFieldValidLName(txtPhilLastName)
        Else
            Exit Sub
        End If
    End Sub
    Private Sub txtPhilMiddleName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPhilMiddleName.TextChanged
        'isFieldValidMName(txtPhilMiddleName)
        If myCurrentFormStatus = enFormStatus.edit And (txtPhilMiddleName.Focused = True Or txtPhilMiddleName.Enabled = False) Then
            If mmiddlename <> Me.txtPhilMiddleName.Text Then
                isFieldValidMName(txtPhilMiddleName)
            Else
                SetErrorProvider(A4)
                isvalid = True
            End If
        ElseIf myCurrentFormStatus = enFormStatus.add And (txtPhilMiddleName.Focused = True Or txtPhilMiddleName.Enabled = False) Then
            isFieldValidMName(txtPhilMiddleName)
        Else
            Exit Sub
        End If
    End Sub
    Private Sub ResetAllErrorProviders()
        SetErrorProvider(Me.A1)
        SetErrorProvider(Me.A3)
        SetErrorProvider(Me.A2)
        SetErrorProvider(Me.A4)
    End Sub
    Private Sub SetErrorProvider(ByVal ctl As Control, Optional ByVal strErrorMessage As String = "")
        erp.SetError(ctl, strErrorMessage)
    End Sub
    Private Function isFieldValidphilno(ByVal PhilNo As Control)
        'Dim isValidPhilno As Boolean
            If PhilNo.Text = "__-_________-_" Then
            SetErrorProvider(A1, "This field is required.")
            isvalidNo = False
            ElseIf PhilNo.Text = "  -         -" Then
            SetErrorProvider(A1, "This field is required.")
            isvalidNo = False
            ElseIf PhilNo.Text = " " Then
            SetErrorProvider(A1, "This field is required.")
            isvalidNo = False
        ElseIf newPhilHealthRecord.IsExist(txtPhilMemberNo.Text) = True Then
            SetErrorProvider(A1, "This record already exists in the database.")
            isvalidNo = False
            Else
            SetErrorProvider(A1)
            isvalidNo = True
            End If
        Return isvalid
    End Function
    Private Function isFieldValidLName(ByRef vLName As Control) As Boolean
        'Dim isValidLName As Boolean
        dtPhilHealthRec = clsPhilHealth.isPhilMemberNoExist(4, Trim(Me.txtPhilLastName.Text), Trim(Me.txtPhilFirstName.Text), Trim(Me.txtPhilMiddleName.Text))
        If vLName.Text = "" Then
            SetErrorProvider(Me.A2, "This field is required.")
            isvalid = False
        ElseIf dtPhilHealthRec.Rows.Count > 0 Then
            If Trim(Me.txtPhilLastName.Text).Equals(mlastname, StringComparison.CurrentCultureIgnoreCase) _
                             And Trim(Me.txtPhilFirstName.Text).Equals(mfirstname, StringComparison.CurrentCultureIgnoreCase) _
                            And Trim(Me.txtPhilMiddleName.Text).Equals(mmiddlename, StringComparison.CurrentCultureIgnoreCase) Then
                isvalid = True
            Else
                SetErrorProvider(Me.A2, "This record already exists in the database.")
                isvalid = False
            End If
        Else
            SetErrorProvider(A2)
            SetErrorProvider(A3)
            SetErrorProvider(A4)
            isvalid = True

        End If
            Return isvalid
    End Function
    Private Function isFieldValidFName(ByRef vFName As Control) As Boolean
        'Dim isValidFName As Boolean
        dtPhilHealthRec = clsPhilHealth.isPhilMemberNoExist(4, Trim(Me.txtPhilLastName.Text), Trim(Me.txtPhilFirstName.Text), Trim(Me.txtPhilMiddleName.Text))
        If vFName.Text = "" Then
            SetErrorProvider(Me.A3, "This field is required.")
            isvalid = False
        ElseIf dtPhilHealthRec.Rows.Count > 0 Then
            If Trim(Me.txtPhilLastName.Text).Equals(mlastname, StringComparison.CurrentCultureIgnoreCase) _
                             And Trim(Me.txtPhilFirstName.Text).Equals(mfirstname, StringComparison.CurrentCultureIgnoreCase) _
                            And Trim(Me.txtPhilMiddleName.Text).Equals(mmiddlename, StringComparison.CurrentCultureIgnoreCase) Then
                isvalid = True
            Else
                SetErrorProvider(Me.A3, "This record already exists in the database.")
                isvalid = False
            End If
           
        Else
            SetErrorProvider(A3)
            SetErrorProvider(A4)
            SetErrorProvider(A2)
            isvalid = True

        End If
        Return isvalid
    End Function
    Private Function isFieldValidMName(ByRef vMName As Control) As Boolean
        'Dim isValidMName As Boolean
        dtPhilHealthRec = clsPhilHealth.isPhilMemberNoExist(4, Trim(Me.txtPhilLastName.Text), Trim(Me.txtPhilFirstName.Text), Trim(Me.txtPhilMiddleName.Text))
        If vMName.Text = "" Then
            SetErrorProvider(Me.A4, "This field is required.")
            isvalid = False
        ElseIf dtPhilHealthRec.Rows.Count > 0 Then
            If Trim(Me.txtPhilLastName.Text).Equals(mlastname, StringComparison.CurrentCultureIgnoreCase) _
                            And Trim(Me.txtPhilFirstName.Text).Equals(mfirstname, StringComparison.CurrentCultureIgnoreCase) _
                           And Trim(Me.txtPhilMiddleName.Text).Equals(mmiddlename, StringComparison.CurrentCultureIgnoreCase) Then
                isvalid = True
            Else

                SetErrorProvider(Me.A4, "This record already exists in the database.")
                isvalid = False
            End If
        Else
            SetErrorProvider(A4)
            SetErrorProvider(A3)
            SetErrorProvider(A2)
            isvalid = True

        End If
        Return isvalid
    End Function
    Private Function ValidateAllFields() As Boolean
        If isFieldValidphilno(txtPhilMemberNo) = False Then
            isvalid = False
        End If
        If isFieldValidLName(txtPhilLastName) = False Then
            isvalid = False
        End If
        If isFieldValidFName(txtPhilFirstName) = False Then
            isvalid = False
        End If
        If isFieldValidMName(txtPhilMiddleName) = False Then
            isvalid = False
        End If
        Return isvalid
    End Function
#End Region

#Region "Method"
    Private Sub frmPhilHealthEntry_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.Control = True And e.KeyCode = Keys.S Then
            If isvalid = False Or isvalidNo = False Or LTrim(txtPhilMemberNo.Text) = "-         -" Or Trim(txtPhilFirstName.Text) = "" Or _
             Trim(txtPhilLastName.Text) = "" Or Trim(txtPhilMiddleName.Text) = "" Then
                If myCurrentFormStatus = enFormStatus.add Then
                    ValidateAllFields()
                End If
                Exit Sub
            End If
            If isSave = False And myCurrentFormStatus <> enFormStatus.browsing Then
                SaveRecords()
            End If
        ElseIf e.KeyCode = Keys.Escape Then
            If myCurrentFormStatus <> enFormStatus.browsing Then
                If MsgBox("Are you sure you want to close this form?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, modGlobal.msgboxTitle) = MsgBoxResult.Yes Then
                    Me.Close()
                End If
            Else
                Me.Close()
            End If
        End If

    End Sub
    Private Sub frmPhilHealthEntry_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Show()
        txtPhilMemberNo.Focus()
        Call LoadImage()
        Call LoadToCombox()
        Call PopulateReltoMember()
        If myCurrentFormStatus = enFormStatus.browsing Or myCurrentFormStatus = enFormStatus.edit Then
            Me.tsSave1.Text = "Update"
            Me.oldPhilHealthNo = Me.PhilHealthNo
            Call LoadRecords()
            Call EnableFields()
            Exit Sub
        ElseIf myCurrentFormStatus = enFormStatus.add And admissionid > 0 Then
            Call LoadRecords()
        End If

    End Sub
    Private Sub tsSave1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSave1.Click
        If isvalid = False Or isvalidNo = False Or LTrim(txtPhilMemberNo.Text) = "-         -" Or Trim(txtPhilFirstName.Text) = "" Or _
        Trim(txtPhilLastName.Text) = "" Or Trim(txtPhilMiddleName.Text) = "" Then
            If myCurrentFormStatus = enFormStatus.add Then
                ValidateAllFields()
            End If
            Exit Sub
        End If
        SaveRecords()
        'isSave = True
    End Sub
    Private Sub tsclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsclose.Click
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

#Region "New Method"
    Private Sub LoadImage()
        Me.tsSave1.Image = modGlobal.save_icon
        Me.tsclose.Image = modGlobal.close_icon
    End Sub
    Private Sub LoadToCombox()
        'Me.cmbPhilMembershipCat.Items.Add(New DictionaryEntry("Not Applicable", "0"))
        'Me.cmbPhilMembershipCat.Items.Add(New DictionaryEntry("Employed-Gov't", "1"))
        'Me.cmbPhilMembershipCat.Items.Add(New DictionaryEntry("Employed-Private", "2"))
        'Me.cmbPhilMembershipCat.Items.Add(New DictionaryEntry("Indigent Member", "3"))
        'Me.cmbPhilMembershipCat.Items.Add(New DictionaryEntry("Individual Paying-OWWA", "4"))
        'Me.cmbPhilMembershipCat.Items.Add(New DictionaryEntry("Individual Paying-Self Employment", "5"))
        'Me.cmbPhilMembershipCat.Items.Add(New DictionaryEntry("Non-Paying Member", "6"))
        'Me.cmbPhilMembershipCat.Items.Add(New DictionaryEntry("Pantawid Pamilya", "7"))

        'Me.cmbPhilMembershipCat.DisplayMember = "Key"
        'Me.cmbPhilMembershipCat.ValueMember = "Value"
        'Me.cmbPhilMembershipCat.DataSource = Me.cmbPhilMembershipCat.Items
        'Me.cmbPhilMembershipCat.SelectedIndex = "0"
        Me.cmbPhilMembershipCat.DataSource = clsPhilHealth.genericcls(6)
        Me.cmbPhilMembershipCat.DisplayMember = "membershipcategory"
        Me.cmbPhilMembershipCat.ValueMember = "membershipcategorycode"
        Me.cmbPhilMembershipCat.SelectedIndex = 0
    End Sub
    Private Sub PopulateReltoMember()
        Me.cmbRelToMember.Items.Add(New DictionaryEntry("Child", "Child"))
        Me.cmbRelToMember.Items.Add(New DictionaryEntry("Parent", "Parent"))
        Me.cmbRelToMember.Items.Add(New DictionaryEntry("Spouse", "Spouse"))

        Me.cmbRelToMember.DisplayMember = "Key"
        Me.cmbRelToMember.ValueMember = "Value"
        Me.cmbRelToMember.DataSource = Me.cmbRelToMember.Items
        Me.cmbRelToMember.SelectedIndex = "0"
    End Sub
    Private Sub SaveRecords()
        PhilHealthNo = Me.txtPhilMemberNo.Text
        'If ValidateAllFields() = False Then
        '    Exit Sub
        'End If

        If myCurrentFormStatus = enFormStatus.add Then
            If MsgBox("Are you sure you want to save this record?", vbQuestion + MsgBoxStyle.YesNo, modGlobal.msgboxTitle) = MsgBoxResult.No Then
                Exit Sub
            End If
        ElseIf myCurrentFormStatus = enFormStatus.edit Then
            If MsgBox("Are you sure you want to update this record?", vbQuestion + MsgBoxStyle.YesNo, modGlobal.msgboxTitle) = MsgBoxResult.No Then
                Exit Sub
            End If
        End If
        'oldPhilHealthNo = PhilHealthNo
        newPhilHealthRecord.PhilHealthNo = PhilHealthNo
        newPhilHealthRecord.PhilLastName = Trim(Me.txtPhilLastName.Text)
        newPhilHealthRecord.PhilFirstName = Trim(Me.txtPhilFirstName.Text)
        newPhilHealthRecord.PhilMiddleName = Trim(Me.txtPhilMiddleName.Text)
        newPhilHealthRecord.PhilSuffix = Trim(Me.txtPhilSuffix.Text)
        newPhilHealthRecord.PhilMembershipCatCode = Me.cmbPhilMembershipCat.SelectedValue
        newPhilHealthRecord.PhilAvailmentType = Me.txtAvailmenttype.Text
        newPhilHealthRecord.PhilHouseNo = Me.txtPhilHouseNo.Text
        newPhilHealthRecord.PhilBarangay = Me.txtPhilBrgy.Text
        newPhilHealthRecord.PhilCityMunicipality = Me.txtPhilCityMunicipality.Text
        newPhilHealthRecord.PhilProvince = Me.txtPhilProvince.Text
        newPhilHealthRecord.PhilZipCode = Me.txtPhilZipCode.Text
        newPhilHealthRecord.PhilDateofBirth = Me.dtpPhilHealthBirthDate.Value
        newPhilHealthRecord.PhilEmailAdd = Me.txtPhilEmailAdd.Text
        newPhilHealthRecord.PhilMobileNo = Me.txtPhilMobileNo.Text
        newPhilHealthRecord.PhilLandLineNo = Me.txtPhilLandline.Text
        newPhilHealthRecord.PhilEmpNo = Me.txtPhilempno.Text
        newPhilHealthRecord.PhilEmpContactNo = Me.txtPhilEmpContactNo.Text
        newPhilHealthRecord.PhilEmpBusName = Me.txtPhilEmpBusName.Text
        newPhilHealthRecord.PhilEmpBldgNo = Me.txtPhilEmpBldgNo.Text
        newPhilHealthRecord.PhilEmpCityMunicipality = Me.txtPhilEmpCityMunicipality.Text
        newPhilHealthRecord.PhilEmpProvince = Me.txtPhilEmpProvince.Text
        newPhilHealthRecord.PhilEmpZipCode = Me.txtPhilEmpZipCode.Text
        newPhilHealthRecord.unitroomnofloor = Me.txtunitroomnofloor.Text
        newPhilHealthRecord.buildingname = Me.txtbuildingname.Text
        newPhilHealthRecord.lotblockhousebldngno = Me.txtlotblockhousebldgno.Text
        newPhilHealthRecord.country = Me.txtcountry.Text
        newPhilHealthRecord.relationshiptomember = Me.cmbRelToMember.SelectedValue
        If Me.rbMale.Checked = True Then
            newPhilHealthRecord.gender = "M"
        Else
            newPhilHealthRecord.gender = "F"
        End If
        If myCurrentFormStatus = enFormStatus.add Then
            newPhilHealthRecord.Save(True)
        Else
            newPhilHealthRecord.PhilHealthNo = PhilHealthNo
            newPhilHealthRecord.Save(False, oldPhilHealthNo)
        End If
        If admissionid > 0 Then
            newPhilHealthRecord.UpdateAdmission(admissionid)
        End If
        If myCurrentFormStatus = enFormStatus.add Then
            MsgBox("Record successfully saved.", vbInformation + MsgBoxStyle.OkOnly, modGlobal.msgboxTitle)
        ElseIf myCurrentFormStatus = enFormStatus.edit Then
            MsgBox("Record successfully updated.", vbInformation + MsgBoxStyle.OkOnly, modGlobal.msgboxTitle)
        End If
        myCurrentFormStatus = enFormStatus.browsing
        isSave = True
        Call EnableFields()
    End Sub
    Private Sub LoadPHICMemberRecords(ByVal patientid As Long)
        Dim dt As DataTable = clsPhilHealth.genericcls(8, "", patientid)
        Me.txtPhilMemberNo.Text = Utility.NullToEmptyString(dt.Rows(0).Item("philhealthno"))
        Me.txtPhilLastName.Text = Utility.NullToEmptyString(dt.Rows(0).Item("lname"))
        Me.txtPhilFirstName.Text = Utility.NullToEmptyString(dt.Rows(0).Item("fname"))
        Me.txtPhilMiddleName.Text = Utility.NullToEmptyString(dt.Rows(0).Item("mname"))
        Me.dtpPhilHealthBirthDate.Value = Utility.NullToEmptyString(dt.Rows(0).Item("bdate"))
        Me.txtPhilLandline.Text = Utility.NullToEmptyString(dt.Rows(0).Item("telephoneno"))
        Me.txtPhilMobileNo.Text = Utility.NullToEmptyString(dt.Rows(0).Item("mobileno"))
        Me.txtPhilEmailAdd.Text = Utility.NullToEmptyString(dt.Rows(0).Item("emailaddress"))
        Me.txtPhilHouseNo.Text = Utility.NullToEmptyString(dt.Rows(0).Item("hns"))
        Me.txtPhilBrgy.Text = Utility.NullToEmptyString(dt.Rows(0).Item("bgry"))
        Me.txtPhilCityMunicipality.Text = Utility.NullToEmptyString(dt.Rows(0).Item("mun"))
        Me.txtPhilProvince.Text = Utility.NullToEmptyString(dt.Rows(0).Item("prov"))
        Me.chkispatphilhealthmember.Checked = Utility.NullToZero(dt.Rows(0).Item("isphilhealthmember"))
    End Sub
    Private Sub LoadRecords()
        dtPHIC = clsPhilHealth.LoadPHIC(PhilHealthNo)
        If dtPHIC.Rows.Count = 0 And admissionid > 0 Then
            dtPHIC = clsPhilHealth.genericcls(7, Patientid)
            If dtPHIC.Rows.Count = 0 Then
                MsgBox("Patientid does not exist.", vbInformation + MsgBoxStyle.OkOnly, modGlobal.msgboxTitle)
                Me.Close()
                Exit Sub
            End If
        End If
        
        If Trim(PhilHealthNo) <> "" Then
            mphilmemberno = dtPHIC.Rows(0).Item("philhealthno")
            Me.txtPhilMemberNo.Text = mphilmemberno
            Me.cmbPhilMembershipCat.SelectedValue = Trim(dtPHIC.Rows(0).Item("membershipcategorycode"))
            Me.txtAvailmenttype.Text = Utility.NullToEmptyString(dtPHIC.Rows(0).Item("availmenttype"))
            Me.txtPhilZipCode.Text = dtPHIC.Rows(0).Item("zipcode")
            Me.txtPhilempno.Text = dtPHIC.Rows(0).Item("philhealthemployeeno")
            Me.txtPhilEmpContactNo.Text = dtPHIC.Rows(0).Item("emplyrcontactno")
            Me.txtPhilEmpBusName.Text = dtPHIC.Rows(0).Item("emplyrbusinessname")
            Me.txtPhilEmpBldgNo.Text = dtPHIC.Rows(0).Item("emplyrbuildingnonamestreet")
            Me.txtPhilEmpCityMunicipality.Text = dtPHIC.Rows(0).Item("emplyrcitymunicipality")
            Me.txtPhilEmpProvince.Text = dtPHIC.Rows(0).Item("emplyrprovince")
            Me.txtPhilEmpZipCode.Text = dtPHIC.Rows(0).Item("emplyrzipcode")
            Me.txtunitroomnofloor.Text = Utility.NullToEmptyString(dtPHIC.Rows(0).Item("unitroomnofloor"))
            Me.txtbuildingname.Text = Utility.NullToEmptyString(dtPHIC.Rows(0).Item("buildingname"))
            Me.txtlotblockhousebldgno.Text = Utility.NullToEmptyString(dtPHIC.Rows(0).Item("lotblockhousebldngno"))
            Me.txtcountry.Text = Utility.NullToEmptyString(dtPHIC.Rows(0).Item("country"))
            Me.cmbRelToMember.SelectedValue = IIf(Utility.NullToEmptyString(dtPHIC.Rows(0).Item("relationshiptomember")) = "", "Child", dtPHIC.Rows(0).Item("relationshiptomember"))
        End If

        mlastname = dtPHIC.Rows(0).Item("lastname")
        mfirstname = dtPHIC.Rows(0).Item("firstname")
        mmiddlename = dtPHIC.Rows(0).Item("middlename")
        Me.txtPhilLastName.Text = mlastname
        Me.txtPhilFirstName.Text = mfirstname
        Me.txtPhilMiddleName.Text = mmiddlename
        Me.txtPhilHouseNo.Text = Utility.NullToEmptyString(dtPHIC.Rows(0).Item("housenonamestreet"))
        Me.txtPhilBrgy.Text = Utility.NullToEmptyString(dtPHIC.Rows(0).Item("barangay"))
        Me.txtPhilCityMunicipality.Text = Utility.NullToEmptyString(dtPHIC.Rows(0).Item("citymunicipality"))
        Me.txtPhilProvince.Text = Utility.NullToEmptyString(dtPHIC.Rows(0).Item("province"))
        Me.dtpPhilHealthBirthDate.Value = Utility.NullToDefaultDateFormat(dtPHIC.Rows(0).Item("dateofbirth"))
        Me.txtPhilEmailAdd.Text = Utility.NullToEmptyString(dtPHIC.Rows(0).Item("emailaddress"))
        Me.txtPhilMobileNo.Text = Utility.NullToEmptyString(dtPHIC.Rows(0).Item("mobileno"))
        Me.txtPhilLandline.Text = Utility.NullToEmptyString(dtPHIC.Rows(0).Item("landlineno"))

        If Trim(dtPHIC.Rows(0).Item("Gender").ToString) = "F" Then
            rbFemale.Checked = True
        Else
            rbMale.Checked = True
        End If
    End Sub
    Private Sub EnableFields()
        If myCurrentFormStatus = enFormStatus.browsing Then
            Me.ToolStripSeparator1.Visible = 0
            Me.tbgeneral.Enabled = False
            Me.tbemployeerinfo.Enabled = False
            Me.tsSave1.Visible = False
        End If
    End Sub
    Private Sub DisableFields(ByVal x As Boolean)
        If x = True Then
            Me.txtPhilMemberNo.Text = Nothing
            Me.txtPhilLastName.Text = Nothing
            Me.txtPhilFirstName.Text = Nothing
            Me.txtPhilMiddleName.Text = Nothing
            Me.dtpPhilHealthBirthDate.Value = Utility.GetServerDate
            Me.txtPhilMobileNo.Text = Nothing
            Me.txtPhilEmailAdd.Text = Nothing
            Me.txtPhilLandline.Text = Nothing
        End If
        Me.txtPhilMemberNo.Enabled = x
        Me.txtPhilLastName.Enabled = x
        Me.txtPhilFirstName.Enabled = x
        Me.txtPhilMiddleName.Enabled = x
        Me.dtpPhilHealthBirthDate.Enabled = x
        Me.txtPhilMobileNo.Enabled = x
        Me.txtPhilEmailAdd.Enabled = x
        Me.txtPhilLandline.Enabled = x
    End Sub
#End Region

    'Private Sub chkispatphilhealthmember_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkispatphilhealthmember.CheckedChanged
    '    If chkispatphilhealthmember.Checked = True Then
    '        Me.Show()
    '        Me.txtPhilMemberNo.Focus()
    '        Me.txtPhilMemberNo.SelectAll()
    '        Dim frm As New frmSearchEngine
    '        frm.mModuleName = "Patient PHIC Member"
    '        frm.ShowDialog()
    '        If frm.issave = False Then
    '            chkispatphilhealthmember.Checked = False
    '        ElseIf frm.issave = True Then
    '            Call DisableFields(False)
    '            Call LoadPHICMemberRecords(frm.mKey)

    '        End If
    '        frm = Nothing
    '    Else
    '        Call DisableFields(True)
    '    End If
    'End Sub
End Class
