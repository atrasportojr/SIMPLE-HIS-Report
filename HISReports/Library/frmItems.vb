Imports System.Drawing.Drawing2D

Public Class frmItems
    Inherits Windows.Forms.Form

#Region "Variables"
    Dim erp As New ErrorProvider
    Private util As New Utility
    Public isSave As Boolean
    Public myFormStatus As enFormStatus
    Public itemcode As String = 0
    Dim olditemcode As Integer = 0
    Dim SupplierNo As Integer = 0
    Private isvalidname As Boolean
    Public ishospitalitem As Boolean = True
    Dim itemgenericid As String
    Dim dtItemCode As DataTable
    Dim data1 As Double
    Dim data2 As String
    Dim indicator As Integer
    Dim aftervalidate As Integer
    Enum enFormStatus
        browsing = 0            'edit fields disabled
        add = 1
        edit = 2
        view = 3
    End Enum
#End Region

#Region "validation"
    Private Sub ResetAllErrorProviders()
        SetErrorProvider(Me.txtItemCode)
        SetErrorProvider(Me.txtItemDescription)
        SetErrorProvider(Me.cmbItemCategory)
        SetErrorProvider(Me.lblSupplier)
        SetErrorProvider(Me.cmbUnitOfMeasurement)
        SetErrorProvider(Me.txtQtyPerPack)
        SetErrorProvider(Me.txtEstUnitCost)
        SetErrorProvider(Me.txtEstNewUnitCost)
        SetErrorProvider(Me.txtPrice1)
        SetErrorProvider(Me.txtPrice2)
        SetErrorProvider(Me.txtPrice3)
        SetErrorProvider(Me.cmbItemType)
        'SetErrorProvider(Me.chkPhilHealth)
    End Sub
    Private Sub SetErrorProvider(ByVal ctl As Control, Optional ByVal strErrorMessage As String = "")
        erp.SetError(ctl, strErrorMessage)
    End Sub
    Private Function AllDataEntryFieldsAreValid() As Boolean
        Dim blnValid As Boolean = True
       
        If isvalidnameitemname() = False Then
            blnValid = False
            Return blnValid
            Exit Function
        End If
        If isFieldValid(Me.cmbUnitOfMeasurement) = False Then
            blnValid = False
            Return blnValid
            Exit Function
        End If
        If isFieldValid(Me.cmbItemCategory) = False Then
            blnValid = False
            Return blnValid
            Exit Function
        End If
        If isFieldValid(Me.cmbItemType) = False Then
            blnValid = False
            Return blnValid
            Exit Function
        End If
        If isFieldValid(Me.cmbItemCategory) = False Then
            blnValid = False
            Return blnValid
            Exit Function
        End If

        If isFieldValid(Me.lblSupplier) = False Then
            blnValid = False
            Return blnValid
            Exit Function
        End If
        If isFieldValid(Me.txtEstUnitCost) = False Then
            blnValid = False
            Return blnValid
            Exit Function
        End If
        If isFieldValid(Me.txtPrice1) = False Then
            blnValid = False
            Return blnValid
            Exit Function
        End If
        If isFieldValid(Me.txtPrice2) = False Then
            blnValid = False
            Return blnValid
            Exit Function
        End If
        If isFieldValid(Me.txtPrice3) = False Then
            blnValid = False
            Return blnValid
            Exit Function
        End If

        If isFieldValid(Me.txtItemDescription) = False Then
            blnValid = False
            Return blnValid
            Exit Function
        End If
        If isFieldValid(Me.txtgenericname) = False Then
            blnValid = False
            Return blnValid
            Exit Function
        End If
        If SupplierNo <= 0 Then
            SetErrorProvider(btnloadSupplier, "This field is required")
            blnValid = False
            Return blnValid
            Exit Function
        End If
        'If itemgenericid <= 0 Then
        '    SetErrorProvider(btngenericname, "This field is required")
        '    blnValid = False
        '    Return blnValid
        '    Exit Function
        'End If
        Return blnValid
    End Function
    Private Function isFieldValid(ByVal ctl As Control)
        Dim isValid As Boolean
        If ctl.Text = "" Then
            SetErrorProvider(ctl, "This field is required.")
            isValid = False
        Else
            ResetAllErrorProviders()
            isValid = True
        End If
        Return isValid
    End Function

#End Region
#Region "Methods"
    Public Sub LoadSearchGeneric()
        Dim SearchName As String = "Generic Name"
        Dim fSearchGeneric As New frmSearchEngine()
        fSearchGeneric.mModuleName = frmSearchEngine.ModuleName.GenericName
        fSearchGeneric.Text = "Generic Name"
        fSearchGeneric.ShowDialog()
        If fSearchGeneric.issave = False Then
            Exit Sub
        End If
        itemgenericid = fSearchGeneric.mKey
        lblgenericname.Text = fSearchGeneric.mvalue
    End Sub

    Public Sub LoadSearchManufacturer()
        Dim fSearchGeneric As New frmSearchEngine()
        If Me.ishospitalitem Then
            fSearchGeneric.mModuleName = frmSearchEngine.ModuleName.HospitalSuppliers
        Else
            fSearchGeneric.mModuleName = frmSearchEngine.ModuleName.NonHospitalSuppliers
        End If
        fSearchGeneric.Text = "Supplier"
        fSearchGeneric.ShowDialog()
        If fSearchGeneric.issave = False Then
            Exit Sub
        End If
        SupplierNo = fSearchGeneric.mKey
        lblSupplier.Text = fSearchGeneric.mvalue
    End Sub
    Private Sub issalesitem(ByVal ctr As Boolean)
        txtEstUnitCost.Enabled = ctr
        txtEstNewUnitCost.Enabled = ctr

        txtPrice1MarkUp.Enabled = ctr
        txtPrice2MarkUp.Enabled = ctr
        txtPrice3Markup.Enabled = ctr

        p1.Enabled = ctr
        p2.Enabled = ctr
        p3.Enabled = ctr

        txtPrice1.Enabled = ctr
        txtPrice2.Enabled = ctr
        txtPrice3.Enabled = ctr
    End Sub
#End Region
#Region "Events"
#Region "ToolStrip Action"
    Private Sub tsSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsSave.Click
        subsave()
    End Sub
    Private Sub tsClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsClose.Click
        Me.Close()
    End Sub
#End Region
    Private Sub frmItems_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.Control = True And e.KeyCode = Keys.S Then
            If isSave = False And myFormStatus <> enFormStatus.browsing Then
                subsave()
            End If
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    'Private Sub paintForm(ByVal sender As Object, ByVal e As PaintEventArgs)
    '    Dim mGraphics As Graphics = e.Graphics
    '    Dim pen1 As Pen = New Pen(Color.FromArgb(252, 254, 255), 1)
    '    Dim Area1 As Rectangle = New Rectangle(0, 0, Me.Width - 1, Me.Height - 1) '253, 254, 255
    '    Dim LGB As LinearGradientBrush = New LinearGradientBrush(Area1, Color.FromArgb(252, 254, 255), Color.FromArgb(227, 237, 253), LinearGradientMode.Vertical)
    '    mGraphics.FillRectangle(LGB, Area1)
    '    mGraphics.DrawRectangle(pen1, Area1)
    'End Sub
    Private Sub frmItems_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        subLoad(myFormStatus)
    End Sub
    'Private Sub cmbRetailItem_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '    'AutoComplete(cmbRetailItem, e, True)
    'End Sub
    'Private Sub txtItemCode_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
    '    isItemCodeExist(Me.txtItemCode)
    'End Sub
    'Private Sub txtItemSpecification_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    isFieldValid(Me.txtItemSpecification)
    'End Sub
    Private Sub cmbItemCategory_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbItemCategory.Leave
        isFieldValid(Me.cmbItemCategory)
    End Sub
    'Private Sub cmbSupplier_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    isFieldValid(Me.lblSupplier)
    'End Sub
    'Private Sub txtUnit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    isFieldValid(Me.txtUnit)
    'End Sub
    Private Sub txtQtyPerPack_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQtyPerPack.Leave
        isFieldValid(Me.txtQtyPerPack)
    End Sub
    'Private Sub txtRetailUnit_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    isFieldValid(Me.txtRetailUnit)
    'End Sub
    Private Sub txtEstUnitCost_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEstUnitCost.Leave
        isFieldValid(Me.txtEstUnitCost)
    End Sub
    Private Sub txtEstNewUnitCost_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEstNewUnitCost.Leave
        isFieldValid(Me.txtEstNewUnitCost)
    End Sub
    'Private Sub txtFreeGroupItems_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    isFieldValid(Me.txtFreeGroupItems)
    'End Sub
    'Private Sub txtFreePerGroupItems_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    isFieldValid(Me.txtFreePerGroupItems)
    'End Sub
    Private Sub txtPrice1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrice1.Leave
        isFieldValid(Me.txtPrice1)
    End Sub
    Private Sub txtPrice2_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrice2.Leave
        isFieldValid(Me.txtPrice2)
    End Sub
    Private Sub txtPrice3_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrice3.Leave
        isFieldValid(Me.txtPrice3)
    End Sub
    Private Sub cmbItemType_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbItemType.Leave
        isFieldValid(Me.cmbItemType)
    End Sub
    Private Sub chkPhilHealth_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'isFieldValid(Me.chkPhilHealth)
    End Sub
    'Private Sub chkcustomize_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If myFormStatus = enFormStatus.add Then
    '        If chkcustomize.Checked Then
    '            Me.txtItemCode.Enabled = True
    '        Else
    '            Me.txtItemCode.Clear()
    '            Me.txtItemCode.Enabled = False
    '            Me.txtItemCode.Text = data2 'formatItemCode(data2)
    '        End If
    '    End If
    'End Sub
    'Private Sub txtDrugCode_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDrugCode.Leave
    '    isFieldValid(Me.txtDrugCode)
    'End Sub
    'Private Sub txtDrugDescription_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDrugDescription.Leave
    '    isFieldValid(Me.txtDrugDescription)
    'End Sub
    Private Sub txtEstNewUnitCost_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEstNewUnitCost.TextChanged
        'sender.Text = IsSpecialCharacter(sender.Text)
        If indicator > 0 And aftervalidate > 0 Then
            computeMarkUpRate()
        Else
            Me.p1.Text = Me.txtEstNewUnitCost.Text
            Me.p2.Text = Me.txtEstNewUnitCost.Text
            Me.p3.Text = Me.txtEstNewUnitCost.Text
        End If
    End Sub
    'Private Sub txtPrice1MarkUp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrice1MarkUp.TextChanged
    '    If indicator > 0 Then
    '        Me.txtPrice1MarkUp.Text = IsNumeric(Me.txtPrice1MarkUp.Text)
    '        computeMarkUpRate()
    '    End If
    'End Sub
    'Private Sub txtPrice2MarkUp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrice2MarkUp.TextChanged
    '    If indicator > 0 Then
    '        Me.txtPrice2MarkUp.Text = IsNumeric(Me.txtPrice2MarkUp.Text)
    '        computeMarkUpRate()
    '    End If
    'End Sub
    'Private Sub txtPrice3Markup_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrice3Markup.TextChanged
    '    If indicator > 0 Then
    '        Me.txtPrice3Markup.Text = IsNumeric(Me.txtPrice3Markup.Text)
    '        computeMarkUpRate()
    '    End If
    'End Sub
    'Private Sub btnloaddoctors_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim frm As New frmSearchEngine
    '    frm.mModuleName = "DRRefund"
    '    frm.ShowDialog()
    '    If frm.issave = True Then
    '        lblDoctorsID.Text = frm.mKey
    '        txtItemDescription.Text = frm.mLastName
    '    End If
    'End Sub
    'Private Sub cmbItemCategory_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbItemCategory.SelectedValueChanged
    '    If indicator > 0 Then
    '        If cmbItemCategory.SelectedValue = 60 Then
    '            btnloaddoctors.Enabled = True
    '        Else
    '            lblDoctorsID.Text = ""
    '            txtItemDescription.Text = Oldval
    '            btnloaddoctors.Enabled = False
    '        End If
    '    End If
    'End Sub
#End Region

#Region "Methods"
    Private Sub subLoad(ByVal frmstatus As String)
        EnableFields()
        Call LoadItemType()
        Call LoadItemCat()
        'Call LoadRetailItem()
        Call LoadUnitofMeasurements()
        If frmstatus = enFormStatus.browsing Or frmstatus = enFormStatus.edit Then
            'Me.tsSave.Text = "Update"
            LoadREcord()
            'If cmbItemCategory.SelectedValue = 60 And frmstatus <> enFormStatus.browsing Then
            '    'btnloaddoctors.Enabled = True
            'End If
        Else
            dtItemCode = clsitems.getitemcode(12, Me.itemcode)
            data1 = Val(dtItemCode.Rows(0).Item("itemcode"))
            data2 = CInt(data1).ToString("D10")
            Me.txtItemCode.Text = data2 'formatItemCode(data2)
            Me.txtItemCode.Enabled = False
            'Me.chkisPurchaseitems.Checked = True
            Me.chkIsSalesItems.Checked = True
            Me.tsSave.Visible = True
        End If
        Me.tsSave.Image = modGlobal.save_icon
        Me.tsClose.Image = modGlobal.close_icon
        'Me.tsnew.Image = modGlobal.new_icon
        'Me.tsEdit.Image = modGlobal.edit_icon
        'Me.tsView.Image = modGlobal.view_icon
        'Me.btnloaddoctors.Image = modGlobal.search_icon
        indicator += 1
        Me.KeyPreview = True
    End Sub
    Private Sub subsave()
        If AllDataEntryFieldsAreValid() = False Then
            Exit Sub
        Else
            ResetAllErrorProviders()
            'If MsgBox("Are you sure you want to " & Me.tsSave.Text.ToLower() & " this record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, modGlobal.msgboxTitle) = MsgBoxResult.Yes Then
            SaveRecord()
            MsgBox("Record successfully " & Me.tsSave.Text.ToLower() & "d.", vbInformation, modGlobal.msgboxTitle)
            If myFormStatus = enFormStatus.add Then
                Me.tsSave.Visible = False
                If MessageBox.Show("Would you like to create another new entry?", modGlobal.msgboxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    subLoad(enFormStatus.add)
                    clearAllFields()
                    isSave = False
                Else
                    myFormStatus = enFormStatus.browsing
                    EnableFields()
                    isSave = True
                End If
            Else
                myFormStatus = enFormStatus.browsing
                EnableFields()
                isSave = True
            End If
            'End If
        End If
    End Sub
    Private Sub EnableFields()
        If myFormStatus = enFormStatus.add Then
        ElseIf myFormStatus = enFormStatus.edit Then
            'Me.chkcustomize.Enabled = False
            Me.txtItemCode.Enabled = False
        ElseIf myFormStatus = enFormStatus.browsing Then
            'Me.btnloaddoctors.Enabled = False
            Me.txtItemCode.Enabled = False
            Me.txtitemname.Enabled = False
            Me.txtItemDescription.Enabled = False
            Me.btngenericname.Enabled = False
            Me.txtgenericname.Enabled = False
            Me.btnloadSupplier.Enabled = False
            'Me.txtItemSpecification.Enabled = False
            Me.cmbItemCategory.Enabled = False
            btnadditemcategory.Enabled = False
            Me.btnaddunitmeasurement.Enabled = False
            Me.txtQtyPerPack.Enabled = False
            'Me.txtRetailUnit.Enabled = False
            Me.txtEstUnitCost.Enabled = False
            Me.txtEstNewUnitCost.Enabled = False
            'Me.txtFreeGroupItems.Enabled = False
            'Me.txtFreePerGroupItems.Enabled = False
            Me.txtPrice1.Enabled = False
            Me.txtPrice2.Enabled = False
            Me.txtPrice3.Enabled = False
            'Me.ToolStrip2.Enabled = False
            Me.p1.Enabled = False
            Me.p2.Enabled = False
            Me.p3.Enabled = False
            Me.cmbItemType.Enabled = False
            'Me.chkPhilHealth.Enabled = False
            'Me.cmbNoCopies.Enabled = False
            'Me.btnGenBarcode.Enabled = False
            Me.txtPrice1MarkUp.Enabled = False
            Me.txtPrice2MarkUp.Enabled = False
            Me.txtPrice3Markup.Enabled = False
            'Me.txtBarcode.Enabled = False
            'Me.cmbRetailItem.Enabled = False
            'Me.txtDrugCode.Enabled = False
            'Me.txtDrugDescription.Enabled = False
            Me.cmbUnitOfMeasurement.Enabled = False
            'Me.txtUnitDescription.Enabled = False
            'Me.txtUnitCode.Enabled = False
            'Me.chkcustomize.Enabled = False
            Me.tsSave.Visible = False
            Me.chkIsSalesItems.Enabled = False
            'Me.chkisPurchaseitems.Enabled = False
            Me.chkIsactive.Enabled = False
            'Me.cmbItemtaxtype.Enabled = False
            'Me.txtMemo.Enabled = False
        End If
    End Sub
    Private Sub clearAllFields()
        Me.txtItemDescription.Clear()
        'Me.txtItemSpecification.Clear()
        Me.txtgenericname.Clear()
        'Me.txtUnit.Text = "0"
        Me.txtQtyPerPack.Text = "0"
        'Me.txtRetailUnit.Text = "0"
        Me.txtEstUnitCost.Text = "0"
        Me.txtEstNewUnitCost.Text = "0"
        'Me.txtFreeGroupItems.Text = "0"
        'Me.txtFreePerGroupItems.Text = "0"
        Me.txtPrice1.Text = "0"
        Me.txtPrice2.Text = "0"
        Me.txtPrice3.Text = "0"
        Me.p1.Text = "0"
        Me.p2.Text = "0"
        Me.p3.Text = "0"
        'Me.txtBarcode.Clear()
        'Me.txtDrugDescription.Clear()
        'Me.chkcustomize.Checked = False
        Me.tsSave.Visible = True
        'Me.chkisPurchaseitems.Checked = 1
        Me.chkIsSalesItems.Checked = 1
        Me.chkIsactive.Checked = 1
        'Me.txtMemo.Clear()

    End Sub
    Public Sub SaveRecord()
        With New clsitems
            .ItemCode = Me.txtItemCode.Text
            .itemname = Me.txtitemname.Text
            .ItemDescription = Me.txtItemDescription.Text
            .GenericID = Me.itemgenericid
            .GenericName = Me.txtgenericname.Text
            .SupplierNo = Me.SupplierNo
            .ItemCatCode = Me.cmbItemCategory.SelectedValue
            .unitmeasurementID = Me.cmbUnitOfMeasurement.SelectedValue

            .Unit = Me.cmbUnitOfMeasurement.Text
            .PerPack = Val(Me.txtQtyPerPack.Text) 'EmptyToZero(Me.txtQtyPerPack.Text)
            'myItems.RetailUnit = CDbl(Me.txtRetailUnit.Text)
            .EstUnitCost = CDbl(Me.txtEstUnitCost.Text)
            .EstNewUnitCost = CDbl(Me.txtEstNewUnitCost.Text)
            'myItems.FreeItemsGroupItems = CDbl(Me.txtFreeGroupItems.Text)
            'myItems.FreeItemsPerGroupItems = CDbl(Me.txtFreePerGroupItems.Text)
            .Price1 = CDbl(Me.txtPrice1.Text)
            .Price2 = CDbl(Me.txtPrice2.Text)
            .Price3 = CDbl(Me.txtPrice3.Text)
            .MarkUpPrice1 = CDbl(Me.txtPrice1MarkUp.Text)
            .MarkUpPrice2 = CDbl(Me.txtPrice2MarkUp.Text)
            .MarkUpPrice3 = CDbl(Me.txtPrice3Markup.Text)
            .UnitCode = Me.cmbUnitOfMeasurement.SelectedValue
            'myItems.UnitDescription = Me.txtUnitDescription.Text
            'myItems.DrugCode = Me.txtDrugCode.SelectedValue
            'myItems.DrugDescription = Me.txtDrugDescription.Text
            'myItems.BarCode = Me.txtBarcode.Text
            .Salesitems = Me.chkIsSalesItems.Checked
            'myItems.PurchaseItems = Me.chkisPurchaseitems.Checked
            .isactive = Me.chkIsactive.Checked
            'myItems.itemsmemo = Me.txtMemo.Text
            'myItems.itemtaxtypeid = Me.cmbItemtaxtype.SelectedValue
            'If cmbRetailItem.Text = "" Then
            '    myItems.RetailItem = ""
            'Else
            '    myItems.RetailItem = Me.cmbRetailItem.SelectedValue
            'End If
            'If Me.cmbItemType.Text = "Medicines" Then
            '    myItems.producttype = "M"
            'ElseIf Me.cmbItemType.Text = "X-ray" Then
            '    myItems.producttype = "X"
            'ElseIf Me.cmbItemType.Text = "Drugs" Then
            '    myItems.producttype = "D"
            'Else
            '    myItems.producttype = "L"
            'End If
            'If Me.cmbItemType.Text = "Medicines" Then
            '    .RetailItem = "M"
            'ElseIf Me.cmbItemType.Text = "X-ray" Then
            '    .RetailItem = "X"
            'ElseIf Me.cmbItemType.Text = "Drugs" Then
            '    .RetailItem = "D"
            'Else
            '    .RetailItem = "L"
            'End If
            .RetailItem = cmbItemType.SelectedValue.ToString
            '.PhilHealth = IIf(Me.chkPhilHealth.Checked, 1, 0)
            .IsHospitalItem = Me.ishospitalitem
            .createdby = modGlobal.employeeid
            .updatedby = modGlobal.employeeid
            .CUdate = Utility.GetServerDate
            If myFormStatus = enFormStatus.add Then
                .saveItems(True)
                Call SaveLog("Libraries", "New item: " & .ItemCode & " (" & Me.txtitemname.Text & ")")
            Else
                .saveItems(False)
                Call SaveLog("Libraries", "Update item: " & .ItemCode & " (" & Me.txtitemname.Text & ")")
            End If
        End With

    End Sub
    Public Sub LoadItemCat()
        Me.cmbItemCategory.DataSource = clsitems.getitem(1, "")
        Me.cmbItemCategory.DisplayMember = "itemcatdescription"
        Me.cmbItemCategory.ValueMember = "itemcatcode"

        'Me.cmbItemtaxtype.DataSource = clsItems.getItemTaxType()
        'Me.cmbItemtaxtype.DisplayMember = "description"
        'Me.cmbItemtaxtype.ValueMember = "itemtaxtypeid"
    End Sub
    Public Sub LoadItemType()
        With Me.cmbItemType
            .DataSource = Nothing
            .Items.Add(New DictionaryEntry("Medicine", "M"))
            .Items.Add(New DictionaryEntry("Laboratory", "L"))
            .DataSource = .Items
            .DisplayMember = "Key"
            .ValueMember = "Value"
            .SelectedIndex = 0
        End With
    End Sub
    Public Sub LoadUnitofMeasurements()
        With Me.cmbUnitOfMeasurement
            .DataSource = clsitems.getitem(13, "")
            .DisplayMember = "unitdescription"
            .ValueMember = "unitcode"
            .SelectedValue = 0
        End With
    End Sub
    'Public Sub loadDrugCode(Optional ByVal str As String = "")
    '    Me.txtDrugCode.DataSource = clsItems.getBFAD(str)
    '    Me.txtDrugCode.DisplayMember = "DrugCode"
    '    Me.txtDrugCode.ValueMember = "DrugCode"
    '    Me.txtDrugCode.SelectedIndex = -1
    '    Dim dt As DataTable = Me.txtDrugCode.DataSource
    '    Me.txtDrugCode.AutoCompleteMode = AutoCompleteMode.Append
    '    Me.txtDrugCode.AutoCompleteSource = AutoCompleteSource.CustomSource
    '    Dim x As New AutoCompleteStringCollection
    '    For i = 0 To dt.Rows.Count - 1
    '        x.Add(dt.Rows(i).Item("DrugCode").ToString())
    '    Next
    '    Me.txtDrugCode.AutoCompleteCustomSource = x
    '    Me.txtDrugCode.SelectedIndex = -1
    'End Sub
    'Private Sub loadDrug(ByVal str As String)
    '    'Dim frmdrugcode As New frmDrugItems(str)
    '    'If str = 0 Then
    '    '    frmdrugcode.dtitems.Size = New Size(778, 334)
    '    '    frmdrugcode.dtitems.Location = New Point(5, 101)
    '    'End If
    '    'frmdrugcode.drugcode = Me.txtDrugCode.SelectedValue
    '    'frmdrugcode.desc = Me.txtDrugDescription.Text
    '    'frmdrugcode.ShowDialog()
    '    'If frmdrugcode.issSave Then
    '    '    If str = 1 Or str = 2 Then
    '    '        loadDrugCode()
    '    '    End If
    '    '    Me.txtDrugCode.SelectedValue = frmdrugcode.selectedvalueifneworedit
    '    'End If
    'End Sub
    'Public Sub LoadRetailItem()
    '    Dim dt As New DataTable()
    '    If myFormStatus = enFormStatus.add Then
    '        'dt = clsItems.getItemsforRetailItem(cmbRetailItem.Text)
    '    Else
    '        'dt = clsItems.getItemsforRetailItemEdit(itemscode)
    '    End If
    '    Me.cmbRetailItem.DataSource = dt
    '    Me.cmbRetailItem.DisplayMember = "itemdescription"
    '    Me.cmbRetailItem.ValueMember = "itemcode"

    '    Me.cmbRetailItem.AutoCompleteMode = AutoCompleteMode.SuggestAppend
    '    Me.cmbRetailItem.AutoCompleteSource = AutoCompleteSource.CustomSource
    '    Dim x As New AutoCompleteStringCollection

    '    For ctr = 0 To dt.Rows.Count - 1
    '        x.Add(dt.Rows(ctr)("itemdescription").ToString())
    '    Next
    '    Me.cmbRetailItem.AutoCompleteCustomSource = x
    '    Me.cmbRetailItem.SelectedIndex = -1
    '    Me.cmbItemType.SelectedIndex = 0

    'End Sub
    Public Sub LoadREcord()
        Dim dtItem As New DataTable
        dtItem = clsitems.getitem(4, itemcode)
        Me.txtItemCode.Text = dtItem.Rows(0).Item("itemcode").ToString
        Me.txtitemname.Text = dtItem.Rows(0).Item("itemdescription").ToString
        Me.txtItemDescription.Text = dtItem.Rows(0).Item("itemdescription").ToString
        'Me.itemgenericid = dtItem.Rows(0).Item("genericid").ToString
        Me.lblgenericname.Text = dtItem.Rows(0).Item("itemspecs").ToString
        Me.txtgenericname.Text = dtItem.Rows(0).Item("itemspecs").ToString
        Me.lblSupplier.Text = dtItem.Rows(0).Item("suppliername").ToString
        Me.cmbItemCategory.SelectedValue = dtItem.Rows(0).Item("itemcatcode")
        Me.SupplierNo = Utility.NullToZero(dtItem.Rows(0).Item("supplierno"))
        'Me.txtUnit.Text = dtItem.Rows(0).Item("unit").ToString
        Me.txtQtyPerPack.Text = dtItem.Rows(0).Item("perpack").ToString
        'Me.txtRetailUnit.Text = dtItem.Rows(0).Item("retailunit").ToString
        Dim EstUnitCost As Double = CDbl(dtItem.Rows(0).Item("estunitcost").ToString)
        Dim EstNewUnitCost As Double = CDbl(dtItem.Rows(0).Item("estnewunitcost").ToString)
        Me.txtEstUnitCost.Text = EstUnitCost.ToString("N2")
        Me.txtEstNewUnitCost.Text = EstNewUnitCost.ToString("N2")
        'Me.txtFreeGroupItems.Text = dtItem.Rows(0).Item("freeitemsgroupitems").ToString
        'Me.txtFreePerGroupItems.Text = dtItem.Rows(0).Item("freeitemspergroupitems").ToString
        Me.txtPrice1.Text = dtItem.Rows(0).Item("price1").ToString
        Me.txtPrice2.Text = dtItem.Rows(0).Item("price2").ToString
        Me.txtPrice3.Text = dtItem.Rows(0).Item("price3").ToString
        Me.cmbItemType.Text = dtItem.Rows(0).Item("producttype").ToString
        Me.chkIsSalesItems.Checked = IIf(IsDBNull(dtItem.Rows(0).Item("Is Sales items")), True, dtItem.Rows(0).Item("Is Sales items"))
        'Me.chkisPurchaseitems.Checked = IIf(IsDBNull(dtItem.Rows(0).Item("Is Purchase Items")), True, dtItem.Rows(0).Item("Is Purchase Items"))
        Me.chkIsactive.Checked = IIf(IsDBNull(dtItem.Rows(0).Item("isactive")), True, dtItem.Rows(0).Item("isactive"))
        'Me.cmbItemtaxtype.SelectedValue = IIf(IsDBNull(dtItem.Rows(0).Item("itemtaxtypeid")), 0, dtItem.Rows(0).Item("itemtaxtypeid"))
        'Me.txtMemo.Text = dtItem.Rows(0).Item("itemsmemo").ToString()
        If IsDBNull(dtItem.Rows(0).Item("unitcode")) = False Then
            Me.cmbUnitOfMeasurement.SelectedValue = dtItem.Rows(0).Item("unitcode")
        Else
            Me.cmbUnitOfMeasurement.SelectedValue = -1
        End If
        'Me.txtBarcode.Text = dtItem.Rows(0).Item("itembarcode").ToString()
        'If IsDBNull(dtItem.Rows(0).Item("retailitemcode")) = False Then
        '    Me.cmbRetailItem.SelectedValue = dtItem.Rows(0).Item("retailitemcode")
        'Else
        '    Me.cmbRetailItem.SelectedValue = -1
        'End If

        'Me.txtUnitCode.Text = dtItem.Rows(0).Item("unitcode").ToString
        'Me.txtUnitDescription.Text = dtItem.Rows(0).Item("unitdescription").ToString
        'If IsDBNull(dtItem.Rows(0).Item("drugcode")) = False Then
        '    Me.txtDrugCode.SelectedValue = dtItem.Rows(0).Item("drugcode")
        'Else
        '    Me.txtDrugCode.SelectedValue = -1
        'End If

        'Me.txtDrugDescription.Text = dtItem.Rows(0).Item("drugdescription").ToString

        'If IsDBNull(dtItem.Rows(0).Item("philhealth")) Then
        '    Me.chkPhilHealth.Checked = False
        'Else
        '    Me.chkPhilHealth.Checked = dtItem.Rows(0).Item("philhealth")
        'End If
        'If myFormStatus = enFormStatus.edit Then
        'Me.chkcustomize.Visible = False
        'Me.Label1.Visible = False
        'Me.txtItemCode.Visible = False
        'Me.Label3.Location = New Point(40, 149)
        'Me.Label28.Location = New Point(120, 124)
        'Me.txtBarcode.Location = New Point(178, 122)
        'Me.txtItemDescription.Location = New Point(179, 148)
        'Me.txtItemDescription.Size = New Size(222, 125)
        'Me.chkcustomize.Enabled = False
        'End If
    End Sub
    Private Sub computeMarkUpRate()
        Try
            Me.txtPrice1.Text = (((CDbl(Me.txtPrice1MarkUp.Text) / 100) * CDbl(Me.p1.Text)) + CDbl(Me.p1.Text)).ToString("n2")
        Catch ex As Exception
            Me.txtPrice1.Text = "0.00"
        End Try
        Try
            Me.txtPrice2.Text = (((CDbl(Me.txtPrice2MarkUp.Text) / 100) * CDbl(Me.p2.Text)) + CDbl(Me.p2.Text)).ToString("n2")
        Catch ex As Exception
            Me.txtPrice2.Text = "0.00"
        End Try
        Try
            Me.txtPrice3.Text = (((CDbl(Me.txtPrice3Markup.Text) / 100) * CDbl(Me.p3.Text)) + CDbl(Me.p3.Text)).ToString("n2")
        Catch ex As Exception
            Me.txtPrice3.Text = "0.00"
        End Try
    End Sub

    Private Sub SCValidate(ByVal sender As Control, ByVal e As EventArgs) Handles txtEstUnitCost.TextChanged, txtPrice1.TextChanged, txtPrice2.TextChanged, txtPrice3.TextChanged, p1.TextChanged, p2.TextChanged, p2.TextChanged, txtPrice1MarkUp.TextChanged, txtPrice2MarkUp.TextChanged, txtPrice3Markup.TextChanged, txtEstNewUnitCost.TextChanged
        If indicator > 0 Then
            'sender.Text = IsSpecialCharacter(sender.Text)
            aftervalidate += 1
        End If
    End Sub
#End Region

    Private Sub chkIsSalesItems_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIsSalesItems.CheckedChanged
        issalesitem(chkIsSalesItems.Checked)
    End Sub

    Private Sub btnaddunitmeasurement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaddunitmeasurement.Click
        Dim frmmeasurement As New frmMeasurements
        frmmeasurement.myCurrentFormStatus = frmMeasurements.enFormStatus.add
        frmmeasurement.ShowDialog()
        If (frmmeasurement.UnitID > 0 And frmmeasurement.chkActive.Checked = True) Then
            LoadUnitofMeasurements()
            Me.cmbUnitOfMeasurement.SelectedValue = frmmeasurement.UnitID
        End If
    End Sub

    Private Sub btngenericname_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngenericname.Click
        LoadSearchGeneric()
    End Sub

    Private Sub btnloadSupplier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnloadSupplier.Click
        LoadSearchManufacturer()
    End Sub

    Private Sub txtitemname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtitemname.TextChanged
        If txtitemname.Text = "" Then
            SetErrorProvider(txtitemname, "This field is required!")
        Else
            isvalidnameitemname()
        End If
    End Sub

    Private Function isvalidnameitemname() As Boolean
        'Dim dtRecord As New DataTable
        'dtRecord = clsitems.GenericVerification("Item", 9, txtitemname.Text, itemcode)
        'If txtitemname.Text = "" Then
        '    SetErrorProvider(Me.txtitemname, "This field is required.")
        '    isvalidname = False
        'ElseIf dtRecord.Rows(0).Item("isExist") > 0 Then
        '    SetErrorProvider(Me.txtitemname, "Item Name already exists in the database.")
        '    isvalidname = False
        'Else
        '    SetErrorProvider(Me.txtitemname)
        isvalidname = True
        'End If
        Return isvalidname
    End Function

    Private Sub txtEstUnitCost_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEstUnitCost.KeyPress
        If IsNumeric(txtEstUnitCost.Text + e.KeyChar) Or e.KeyChar = vbBack Then
            e.Handled = False
            Try
                p1.Text = CDbl(txtEstUnitCost.Text + e.KeyChar)
                p2.Text = CDbl(txtEstUnitCost.Text + e.KeyChar)
                p3.Text = CDbl(txtEstUnitCost.Text + e.KeyChar)
            Catch ex As Exception
                p1.Text = "0.00"
                p2.Text = "0.00"
                p3.Text = "0.00"
            End Try
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnadditemcategory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadditemcategory.Click
        Dim fcategory As New frmCategory(frmCategory.enFormStatus.add)
        fcategory.ShowDialog()
        If (fcategory.CategoryCode > 0 And fcategory.chkIsactive.Checked = True) Then
            LoadItemCat()
            Me.cmbItemCategory.SelectedValue = fcategory.CategoryCode
        End If
    End Sub

    Private Sub txtPrice1MarkUp_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrice3Markup.KeyPress, txtPrice2MarkUp.KeyPress, txtPrice1MarkUp.KeyPress
        If IsNumeric(sender.Text + e.KeyChar) Or e.KeyChar = vbBack Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub SCValidate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrice1MarkUp.TextChanged, txtPrice2MarkUp.TextChanged, txtPrice3Markup.TextChanged, txtEstUnitCost.TextChanged, txtPrice3.TextChanged, txtPrice2.TextChanged, txtPrice1.TextChanged, p2.TextChanged, p1.TextChanged
        computeMarkUpRate()
    End Sub

    Private Sub txtEstNewUnitCost_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEstNewUnitCost.KeyPress
        If IsNumeric(sender.Text + e.KeyChar) Or e.KeyChar = vbBack Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class