Imports System.Drawing.Drawing2D
Public Class frmCategory
#Region "Variables"
    Dim erp As New ErrorProvider
    Public isSave As Boolean
    Public myFormStatus As enFormStatus
    Public CategoryCode As Integer
    Dim CategoryCodeOld As Integer
    Dim indicator As Integer
    Enum enFormStatus
        browsing = 0            'edit fields disabled
        add = 1
        edit = 2
        view = 3
    End Enum
#End Region
#Region "Form Events"

    Private Sub frmCategory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EnableFields()
        Call LoadCategoryType()
        If myFormStatus = enFormStatus.browsing Or myFormStatus = enFormStatus.edit Then
            Me.cmbCategoryType.DataSource = Nothing
            Call LoadRecord(CategoryCode)
            ' Me.tsSave.Text = "Update"
        Else
            Me.tsSave.Text = "Save"
        End If
        Me.tsSave.Image = modGlobal.save_icon
        Me.tsClose.Image = modGlobal.close_icon
        indicator += 1
        Me.KeyPreview = True
    End Sub
    Private Sub frmCategory_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.Control = True And e.KeyCode = Keys.S Then
            If isSave = False And myFormStatus <> enFormStatus.browsing Then
                subSave()
            End If
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub paintForm(ByVal sender As Object, ByVal e As PaintEventArgs)
        Dim mGraphics As Graphics = e.Graphics
        Dim pen1 As Pen = New Pen(Color.FromArgb(252, 254, 255), 1)
        Dim Area1 As Rectangle = New Rectangle(0, 0, Me.Width - 1, Me.Height - 1) '253, 254, 255
        Dim LGB As LinearGradientBrush = New LinearGradientBrush(Area1, Color.FromArgb(252, 254, 255), Color.FromArgb(227, 237, 253), LinearGradientMode.Vertical)
        mGraphics.FillRectangle(LGB, Area1)
        mGraphics.DrawRectangle(pen1, Area1)
    End Sub
    Private Sub txtCategoryDescription_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCategoryDescription.Leave
        isFieldValidCategoryDescription(Me.txtCategoryDescription)
    End Sub
#Region "ToolStrip Actions"
    Private Sub tsSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSave.Click
        subSave()
    End Sub
    Private Sub tsCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsCancel.Click
        isSave = False
        Me.Close()
    End Sub
    Private Sub tsClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsClose.Click
        Me.Close()
    End Sub
#End Region
#End Region


#Region "Methods"
    Private Sub subSave()
        If AllDataEntryFieldsAreValid() = False Then
            Exit Sub
        End If
        'If MsgBox("Are you sure you want to " & Me.tsSave.Text.ToLower() & " this record? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, modGlobal.msgboxTitle) = MsgBoxResult.Yes Then
        SaveRecord()
        'MessageBox.Show("Record successfully " & Me.tsSave.Text.ToLower() & "d.", modGlobal.msgboxTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
        If myFormStatus = enFormStatus.add Then
            Me.tsSave.Visible = False
            If MessageBox.Show("Would you like to create another new entry?", modGlobal.msgboxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                myFormStatus = enFormStatus.add
                clearFields()
                Me.tsSave.Visible = True
                isSave = False
            Else
                Me.myFormStatus = enFormStatus.browsing
                EnableFields()
                isSave = True
            End If
        Else
            Me.myFormStatus = enFormStatus.browsing
            EnableFields()
            isSave = True
        End If
        'End If
    End Sub
#Region "New Methods"
    Sub New(ByVal FormStatus As enFormStatus)
        InitializeComponent()
        myFormStatus = FormStatus
        InitForm()
    End Sub
#End Region
#Region "Validation"
    Private Function AllDataEntryFieldsAreValid() As Boolean
        Dim blnValid As Boolean = True
        'If isFieldValidCategoryCode(Me.txtCategoryCode) = False Then
        '    blnValid = False
        'End If
        If isFieldValidCategoryDescription(Me.txtCategoryDescription) = False Then
            blnValid = False
        End If
        Return blnValid
    End Function
    Private Sub ResetAllErrorProviders()
        'SetErrorProvider(Me.txtCategoryCode)
        SetErrorProvider(Me.txtCategoryDescription)
    End Sub
    Private Sub SetErrorProvider(ByVal ctl As Control, Optional ByVal strErrorMessage As String = "")
        erp.SetError(ctl, strErrorMessage)
    End Sub
#End Region
    Private Sub InitForm()
        LoadCategoryType()
        Me.tsSave.Image = modGlobal.save_icon
        Me.tsClose.Image = modGlobal.close_icon
    End Sub
    Private Sub EnableFields()
        Me.tsCancel.Visible = False
        If myFormStatus = enFormStatus.add Then
        ElseIf myFormStatus = enFormStatus.browsing Then
            Me.tsCancel.Visible = False
            Me.tsSave.Visible = False
            'Me.txtCategoryCode.Enabled = False
            Me.txtCategoryDescription.Enabled = False
            Me.cmbCategoryType.Enabled = False
            'Me.chkAutoGen.Visible = False
            Me.chkIsactive.Enabled = False
            Me.chkISDiscountable.Enabled = False
            Me.txtMemo.Enabled = False
            Me.chkIsvatable.Enabled = False
        ElseIf myFormStatus = enFormStatus.edit Then
            'Me.chkAutoGen.Visible = False
            'Me.txtCategoryCode.Enabled = False
        End If
    End Sub
    Private Sub clearFields()
        Me.tsCancel.Visible = False
        Me.tsCancel.Visible = False
        Me.tsSave.Visible = True
        'Me.txtCategoryCode.Clear()
        Me.txtCategoryDescription.Clear()
        cmbCategoryType.SelectedIndex = -1
        'Me.chkAutoGen.Checked = False
        Me.chkIsactive.Checked = True
        'Me.chkISDiscountable.Checked = False
        'Me.chkIsvatable.Checked = False
    End Sub
    Private Function isFieldValidCategoryCode(ByVal ctl As Control) As Boolean
        Dim isValid As Boolean = True
        'If ctl.Text = "" Then
        '    If Me.chkAutoGen.Checked = False Then
        '        SetErrorProvider(ctl, "Field is required.")
        '        isValid = False
        '    Else
        '        SetErrorProvider(ctl)
        '    End If
        'ElseIf txtCategoryCode.Text <> CategoryCode And myFormStatus <> enFormStatus.browsing Then
        '    Dim dt As DataTable = clsCategory.getCategoriesCodeExisting(Me.txtCategoryCode.Text)
        '    If dt.Rows.Count > 0 Then
        '        SetErrorProvider(txtCategoryCode, "This code is already existing to our database.")
        '        isValid = False
        '    Else
        '        SetErrorProvider(ctl)
        '    End If
        'Else
        '    SetErrorProvider(ctl)
        '    isValid = True
        'End If
        Return isValid
    End Function
    Private Function isFieldValidCategoryDescription(ByVal ctl As Control) As Boolean
        Dim isValid As Boolean
        If ctl.Text = "" Then
            SetErrorProvider(txtCategoryDescription, "Field is required.")
            isValid = False
        Else
            SetErrorProvider(ctl)
            isValid = True
        End If
        Return isValid
    End Function
    Private Sub LoadRecord(ByVal CategoryCode As String)
        Dim dtItemCat As New DataTable
        Dim myItemCat As New clsitems
        Call LoadCategoryType()
        CategoryCodeOld = CategoryCode
        dtItemCat = clsitems.getItemCategory(3, CategoryCode)
        'Me.txtCategoryCode.Text = dtItemCat.Rows(0).Item("itemcatcode").ToString()
        Me.txtCategoryDescription.Text = dtItemCat.Rows(0).Item("itemcatdescription").ToString()
        Me.cmbCategoryType.SelectedValue = dtItemCat.Rows(0).Item("itemcattype").ToString().Trim()
        Me.chkIsactive.Checked = dtItemCat.Rows(0).Item("isactive")
        'Me.chkISDiscountable.Checked = dtItemCat.Rows(0).Item("Is Discountable")
        'Me.txtMemo.Text = dtItemCat.Rows(0).Item("Memo").ToString()
        'Me.chkIsvatable.Checked = dtItemCat.Rows(0)("Is Vatable")
        'If myFormStatus = enFormStatus.edit Then
        '    'Me.txtCategoryCode.Enabled = False
        '    Me.Label3.Location = New Point(2, 55)
        '    Me.Label1.Visible = False
        '    Me.txtCategoryDescription.Size = New Size(344, 85)
        '    Me.txtCategoryDescription.Location = New Point(151, 49)
        '    'Me.Label3.BackColor = Color.FromArgb(73, 163, 75)
        'End If
    End Sub
    Private Sub SaveRecord()
        Dim myItemCat As New clsitems
        'If Me.chkAutoGen.Checked = True Then
        '    myItemCat.itemcatcode = ""
        'Else
        myItemCat.ItemCatCode = Me.CategoryCodeOld
        'End If
        myItemCat.itemcatdescription = Me.txtCategoryDescription.Text
        myItemCat.itemcattype = Me.cmbCategoryType.SelectedValue
        myItemCat.isdiscountable = Me.chkISDiscountable.Checked
        myItemCat.isactive = Me.chkIsactive.Checked
        myItemCat.isdefault = False
        myItemCat.CUdate = Utility.GetServerDate
        myItemCat.createdby = modGlobal.employeeid
        myItemCat.updatedby = modGlobal.employeeid
        'myItemCat.isvatable = Me.chkIsvatable.Checked
        If myFormStatus = enFormStatus.add Then
            Me.CategoryCode = myItemCat.SaveItemCategory(True)
            Call SaveLog("Libraries", "New item category: " & myItemCat.itemcatdescription)
        Else
            myItemCat.SaveItemCategory(False, Me.CategoryCode)
            Call SaveLog("Libraries", "Update item category: " & myItemCat.itemcatdescription)
        End If
    End Sub
    Public Sub LoadCategoryType()
        Me.cmbCategoryType.DataSource = Nothing
        Me.cmbCategoryType.Items.Add(New DictionaryEntry("Inventory", "I"))
        Me.cmbCategoryType.Items.Add(New DictionaryEntry("Diagnostic Supplies", "D"))  'Added 2018-03-03
        Me.cmbCategoryType.Items.Add(New DictionaryEntry("Fixed Asset", "F"))
        Me.cmbCategoryType.Items.Add(New DictionaryEntry("Laboratory", "L"))
        Me.cmbCategoryType.Items.Add(New DictionaryEntry("Imaging", "R"))  'Added 2018-03-03
        Me.cmbCategoryType.Items.Add(New DictionaryEntry("Procedure", "P"))
        Me.cmbCategoryType.Items.Add(New DictionaryEntry("Services", "S"))
        Me.cmbCategoryType.Items.Add(New DictionaryEntry("Expense", "E"))
        Me.cmbCategoryType.Items.Add(New DictionaryEntry("Expense Type 2", "E2"))
        Me.cmbCategoryType.Items.Add(New DictionaryEntry("Petty Cash", "PC"))
        Me.cmbCategoryType.Items.Add(New DictionaryEntry("Other Income", "OI"))
        Me.cmbCategoryType.Items.Add(New DictionaryEntry("Other", "O"))  'Added 2018-03-03
        Me.cmbCategoryType.DisplayMember = "Key"
        Me.cmbCategoryType.ValueMember = "Value"
        Me.cmbCategoryType.DataSource = Me.cmbCategoryType.Items
    End Sub
#End Region

End Class