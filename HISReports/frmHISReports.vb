Public Class frmHISReports
    Public reportcode As Integer = -1
    Public subreportcode As Integer = -1
    Public patientid As Long
    Public patientname As String
    Dim tt As New ToolTip

    Private Sub frmHISReports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call SetClearToolTips()
        Call LoadPeriod()
        Call LoadAdmissionType()
        afterload = False
        Call LoadReports()
        Me.afterload = True
        Call LoadSubReports()
        If reportcode > -1 Then
            Me.cmbReports.SelectedValue = reportcode
            If subreportcode > -1 Then
                Me.cmbSubreports.SelectedValue = subreportcode
                Call LoadReportFilters()
                Me.txtpatient.Text = Me.patientname
            End If
        End If
    End Sub

#Region "Variables"
    Private afterload As Boolean
    Private employeeid, supplierid As Long
    Private operation, soperation As Integer
    Private crystalreportname As String
    Private icd10code, itemcode, lotno As String
    Public admissionid As Long
    Private filters As String()
    Private storedProc, itemcatcode, officecode As String
    Private subreportdescription As String

    Enum reportfilters
        admissiontype = 0
        daterange = 1
        patient = 2
        icd10code = 3
        procedure = 4
        dateselect = 5
        monthlyselect = 6
        admissions = 7
        purpose = 8
        employee = 9
        supplier = 10
        office = 11
        asofdate = 12
        itemcategory = 13
        item = 14
        lotno = 15
        search = 16
        showlotno = 17
        nearexpirymonth = 18
        customdate = 19
        reportdescription = 20
        userloginname = 21
        removeoperation = 22
        includeoverdueonly = 23
        yearselect = 24
    End Enum
#End Region

#Region "Methods"
    Private Sub LoadAdmissionType()
        With Me.cmbadmissiontype
            .DataSource = Nothing
            .Items.Add(New DictionaryEntry("Inpatients", "IPD"))
            .Items.Add(New DictionaryEntry("Outpatients", "OPD"))
            .Items.Add(New DictionaryEntry("Emergency", "ER"))
            .Items.Add(New DictionaryEntry("View All", "ALL"))
            .DataSource = .Items
            .DisplayMember = "Key"
            .ValueMember = "Value"
        End With
    End Sub
    Private Sub LoadPeriod()
        With Me.cmbPeriod
            .Items.Add(New DictionaryEntry("Daily", "0"))
            .Items.Add(New DictionaryEntry("Weekly", "1"))
            .Items.Add(New DictionaryEntry("Monthly", "2"))
            .Items.Add(New DictionaryEntry("Quarterly", "3"))
            .Items.Add(New DictionaryEntry("Yearly", "4"))
            .Items.Add(New DictionaryEntry("As of", "6"))
            .Items.Add(New DictionaryEntry("Custom", "5"))
            .DataSource = .Items
            .DisplayMember = "Key"
            .ValueMember = "Value"
        End With
    End Sub
    Private Sub LoadReports()
        With Me.cmbReports
            .DataSource = clsHISReports.genericcls(0, , , modGlobal.employeeid)
            .ValueMember = "reportcode"
            .DisplayMember = "reportdescription"
            If .Items.Count > 0 Then
                .SelectedIndex = 0
            End If
        End With
    End Sub
    Private Sub LoadSubReports()
        If Me.cmbReports.SelectedValue > 0 Then
            afterload = False
            With Me.cmbSubreports
                .DataSource = clsHISReports.genericcls(1, Me.cmbReports.SelectedValue, , modGlobal.employeeid)
                .ValueMember = "subreportcode"
                .DisplayMember = "subreportdescription"
                afterload = True
                If .Items.Count > 0 Then
                    .SelectedIndex = 0
                    Call LoadReportFilters()
                End If
            End With
        End If
    End Sub
    Private Sub ClearValues()
        Me.officecode = ""
        Me.txtOffice.Clear()
        Me.supplierid = 0
        Me.txtSupplier.Clear()
        Me.employeeid = 0
        Me.txtEmployee.Clear()
        Me.itemcode = ""
        Me.txtItem.Clear()
        Me.lotno = ""
        Me.txtLotNo.Clear()
        Me.itemcatcode = ""
        Me.txtItemCategory.Clear()
        Me.admissionid = 0
        Me.txtadmission.Clear()
        Me.icd10code = ""
        Me.txtICD10Code.Clear()
        Me.txtprocedure.Clear()
        Me.patientid = 0
        Me.txtpatient.Clear()
        Me.txtPurpose.Clear()
        Me.txtSearch.Clear()
        Me.txtEntryData.Text = "0"
    End Sub
    Private Sub SetClearToolTips()
        tt.SetToolTip(lblClearOffice, "Clear selected office")
        tt.SetToolTip(lblClearItem, "Clear selected item")
        tt.SetToolTip(lblClearLotno, "Clear selected lotno")
        tt.SetToolTip(lblClearCategory, "Clear selected category")
        tt.SetToolTip(lblClearSupplier, "Clear selected supplier")
        tt.SetToolTip(lblClearICD10, "Clear selected ICD10")
        tt.SetToolTip(lblClearEmployee, "Clear selected employee")
        tt.SetToolTip(lblClearPatient, "Clear selected patient")
        tt.SetToolTip(lblClearProcedure, "Clear selected procedure")
        tt.SetToolTip(lblClearAdmission, "Clear selected admission")
    End Sub
    Private Sub LoadReportFilters()
        If Me.cmbSubreports.SelectedValue > 0 Then
            Dim dt As DataTable = clsHISReports.genericcls(2, Me.cmbSubreports.SelectedValue)
            Me.subreportdescription = Utility.NullToEmptyString(dt.Rows(0).Item("subreportdescription"))
            Me.crystalreportname = Utility.NullToEmptyString(dt.Rows(0).Item("reportfilename"))
            Me.operation = Utility.NullToZero(dt.Rows(0).Item("operation"))
            Me.soperation = Utility.NullToZero(dt.Rows(0).Item("soperation"))
            Me.storedProc = Utility.NullToEmptyString(dt.Rows(0).Item("storedproc"))
            filters = Utility.NullToEmptyString(dt.Rows(0).Item("filters")).Split(";")
            Me.gpfilteradmissiontype.Visible = False
            Me.gpfilterdatarange.Visible = False
            Me.gpfiltericd10.Visible = False
            Me.gpfilterprocedure.Visible = False
            Me.gpfilterpatient.Visible = False
            Me.gpfilterpickdate.Visible = False
            Me.gpfiltermonthly.Visible = False
            Me.gpfilteradmissions.Visible = False
            Me.gpfilterpurpose.Visible = False
            Me.gpfilteremployee.Visible = False
            Me.gpfiltersupplier.Visible = False
            Me.gpfilteroffice.Visible = False
            Me.gpfilteritemcategory.Visible = False
            Me.gpfilteritem.Visible = False
            Me.gpfilterlotno.Visible = False
            Me.gpfiltersearch.Visible = False
            Me.gpfiltercbshow.Visible = False
            Me.gpfilterentrydata.Visible = False
            Me.gpfilteryearly.Visible = False

            For Each Filter As String In filters
                Select Case Filter
                    Case reportfilters.admissiontype
                        Me.gpfilteradmissiontype.Visible = True
                        Me.gpfilteradmissiontype.BringToFront()
                    Case reportfilters.daterange
                        Me.gpfilterdatarange.Visible = True
                        Me.cmbPeriod.SelectedValue = "0"
                        Me.gpfilterdatarange.BringToFront()
                    Case reportfilters.icd10code
                        Me.gpfiltericd10.Visible = True
                        Me.gpfiltericd10.BringToFront()
                    Case reportfilters.procedure
                        Me.gpfilterprocedure.Visible = True
                        Me.gpfilterprocedure.BringToFront()
                    Case reportfilters.patient
                        Me.gpfilterpatient.Visible = True
                        Me.gpfilterpatient.BringToFront()
                    Case reportfilters.dateselect
                        Me.gpfilterpickdate.Visible = True
                        Me.gpfilterpickdate.BringToFront()
                    Case reportfilters.monthlyselect
                        Me.gpfiltermonthly.Visible = True
                        Me.gpfiltermonthly.BringToFront()
                    Case reportfilters.admissions
                        Me.gpfilteradmissions.Visible = True
                        Me.gpfilteradmissions.BringToFront()
                    Case reportfilters.purpose
                        Me.gpfilterpurpose.Visible = True
                        Me.gpfilterpurpose.BringToFront()
                    Case reportfilters.employee
                        Me.gpfilteremployee.Visible = True
                        Me.gpfilteremployee.BringToFront()
                    Case reportfilters.supplier
                        Me.gpfiltersupplier.Visible = True
                        Me.gpfiltersupplier.BringToFront()
                    Case reportfilters.office
                        Me.gpfilteroffice.Visible = True
                        Me.gpfilteroffice.BringToFront()
                    Case reportfilters.asofdate
                        Me.gpfilterdatarange.Visible = True
                        Me.cmbPeriod.SelectedValue = "6"
                        Me.gpfilterdatarange.BringToFront()
                    Case reportfilters.itemcategory
                        Me.gpfilteritemcategory.Visible = True
                        Me.gpfilteritemcategory.BringToFront()
                    Case reportfilters.item
                        Me.gpfilteritem.Visible = True
                        Me.gpfilteritem.BringToFront()
                    Case reportfilters.lotno
                        Me.gpfilterlotno.Visible = True
                        Me.gpfilterlotno.BringToFront()
                    Case reportfilters.search
                        Me.gpfiltersearch.Visible = True
                        Me.gpfiltersearch.BringToFront()
                    Case reportfilters.showlotno
                        Me.gpfiltercbshow.Visible = True
                        Me.cbShow.Text = "Show Lot Number"
                        Me.gpfiltercbshow.BringToFront()
                    Case reportfilters.nearexpirymonth
                        Me.gpfilterentrydata.Visible = True
                        Me.Label21.Text = "Near Exp. in Month"
                        Me.gpfilterentrydata.BringToFront()
                    Case reportfilters.customdate
                        Me.gpfilterdatarange.Visible = True
                        Me.cmbPeriod.SelectedValue = "5"
                        Me.gpfilterdatarange.BringToFront()
                    Case reportfilters.includeoverdueonly
                        Me.gpfiltercbshow.Visible = True
                        Me.cbShow.Text = "Include Overdue Invoice Only"
                        Me.gpfiltercbshow.BringToFront()
                    Case reportfilters.yearselect
                        Me.gpfilteryearly.Visible = True
                        Me.gpfilteryearly.BringToFront()
                End Select
            Next

            Call LoadReport()
        End If
    End Sub
    Private Sub LoadReport()
        Try
            'Dim crpt = Activator.CreateInstance(Type.GetType(My.Application.Info.AssemblyName & "." & Me.crystalreportname))
            Dim crpt = Activator.CreateInstance(Type.GetType("HISReports." & Me.crystalreportname))
            If Not crpt Is Nothing Then
                Dim x As New clsHISReports

                x.storedProc = Me.storedProc
                x.mainStrPar.Add("operation")       '0
                x.mainStrVal.Add(Me.operation)      '0
                x.mainStrPar.Add("soperation")      '1
                x.mainStrVal.Add(Me.soperation)     '1

                For Each Filter As String In filters
                    Select Case Filter
                        Case reportfilters.admissiontype
                            x.mainStrPar.Add("admissiontype")
                            x.mainStrVal.Add(Me.cmbadmissiontype.SelectedValue)
                        Case reportfilters.daterange
                            x.mainStrPar.Add("filterby")
                            x.mainStrVal.Add(CLng(Me.cmbPeriod.SelectedValue))

                            x.mainStrPar.Add("startdate")
                            x.mainStrVal.Add(Me.dtpStartdate.Value.Date)

                            x.mainStrPar.Add("enddate")
                            x.mainStrVal.Add(Me.dtpenddate.Value.Date)
                        Case reportfilters.icd10code
                            x.mainStrPar.Add("icd10code")
                            x.mainStrVal.Add(Me.icd10code)
                        Case reportfilters.procedure
                            x.mainStrPar.Add("icd10code")
                            x.mainStrVal.Add(Me.icd10code)
                        Case reportfilters.patient
                            x.mainStrPar.Add("PatientID")
                            x.mainStrVal.Add(Me.patientid)
                        Case reportfilters.dateselect
                            x.mainStrPar.Add("startdate")
                            x.mainStrVal.Add(Me.dtppickdate.Value.Date)
                        Case reportfilters.monthlyselect
                            x.mainStrPar.Add("startdate")
                            x.mainStrVal.Add(Me.dtpmonthly.Value.Date)
                        Case reportfilters.admissions
                            x.mainStrPar.Add("admissionid")
                            x.mainStrVal.Add(Me.admissionid)
                        Case reportfilters.purpose
                            x.mainStrPar.Add("remarks")
                            x.mainStrVal.Add(Me.txtPurpose.Text)
                        Case reportfilters.employee
                            x.mainStrPar.Add("employeeid")
                            x.mainStrVal.Add(Me.employeeid)
                        Case reportfilters.supplier
                            x.mainStrPar.Add("supplierid")
                            x.mainStrVal.Add(Me.supplierid)
                        Case reportfilters.office
                            x.mainStrPar.Add("officecode")
                            x.mainStrVal.Add(Me.officecode)
                        Case reportfilters.itemcategory
                            x.mainStrPar.Add("itemcatcode")
                            x.mainStrVal.Add(Me.itemcatcode)
                        Case reportfilters.item
                            x.mainStrPar.Add("itemcode")
                            x.mainStrVal.Add(Me.itemcode)
                        Case reportfilters.lotno
                            x.mainStrPar.Add("lotno")
                            x.mainStrVal.Add(Me.lotno)
                        Case reportfilters.search
                            x.mainStrPar.Add("search")
                            x.mainStrVal.Add(Me.txtSearch.Text)
                        Case reportfilters.showlotno, reportfilters.includeoverdueonly
                            x.mainStrPar.Add("isshow")
                            x.mainStrVal.Add(Me.cbShow.Checked)
                        Case reportfilters.nearexpirymonth
                            x.mainStrPar.Add("noofmonths")
                            x.mainStrVal.Add(Me.txtEntryData.Text)
                        Case reportfilters.reportdescription
                            x.mainStrPar.Add("subreportdescription")
                            x.mainStrVal.Add(Me.subreportdescription)
                        Case reportfilters.userloginname
                            x.mainStrPar.Add("employeeloginname")
                            x.mainStrVal.Add(modGlobal.ufullName)
                        Case reportfilters.removeoperation
                            Dim inx As Integer = 0
                            If x.mainStrPar.Contains("operation") = True Then
                                inx = x.mainStrPar.IndexOf("operation")
                                x.mainStrPar.RemoveAt(inx)
                                x.mainStrVal.RemoveAt(inx)
                            End If

                            inx = 0
                            If x.mainStrPar.Contains("soperation") = True Then
                                inx = x.mainStrPar.IndexOf("soperation")
                                x.mainStrPar.RemoveAt(inx)
                                x.mainStrVal.RemoveAt(inx)
                            End If
                        Case reportfilters.yearselect
                            x.mainStrPar.Add("year")
                            x.mainStrVal.Add(Me.dtpYearly.Value.Year)
                    End Select
                Next

                Dim dtRecord As DataTable = x.getReport
                Select Case Me.crystalreportname
                    Case "crptClinicalDischargeSummary_LHI"

                        Dim inx As Integer = 0
                        If x.mainStrPar.Contains("filterby") = True Then
                            inx = x.mainStrPar.IndexOf("filterby")
                            x.mainStrVal.RemoveAt(inx)
                            x.mainStrVal.Insert(inx, 0)
                        Else
                            x.mainStrPar.Add("filterby")
                            x.mainStrVal.Add(0)
                        End If
                        If x.mainStrPar.Contains("soperation") = True Then
                            inx = x.mainStrPar.IndexOf("soperation")
                            x.mainStrVal.RemoveAt(inx)
                            x.mainStrVal.Insert(inx, 24)
                        End If

                        inx = 0
                        Dim dt As DataTable = x.getReport
                        crpt.Subreports(0).SetDataSource(dt)
                        If x.mainStrPar.Contains("filterby") = True Then
                            inx = x.mainStrPar.IndexOf("filterby")
                            x.mainStrVal.RemoveAt(inx)
                            x.mainStrVal.Insert(inx, 1)
                        Else
                            x.mainStrPar.Add("filterby")
                            x.mainStrVal.Add(1)
                        End If

                        dt = x.getReport
                        crpt.Subreports(1).SetDataSource(dt)
                End Select
                crpt.SetDataSource(dtRecord)
                Me.cprtViewer.ReportSource = crpt
                Me.cprtViewer.Zoom(1)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, modGlobal.msgboxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub LoadDateRange()
        Try
            If afterload Then
                afterload = False
                Me.dtpStartdate.Enabled = True
                Me.dtpenddate.Enabled = False
                dtpStartdate.Value = Utility.GetServerDate
                dtpenddate.Value = dtpStartdate.Value
                Select Case cmbPeriod.SelectedValue
                    Case "0"
                        Me.dtpenddate.Value = Me.dtpStartdate.Value
                    Case "1"
                        Dim dayDiff As Integer = Me.dtpStartdate.Value.DayOfWeek - DayOfWeek.Sunday
                        Me.dtpStartdate.Value = Me.dtpStartdate.Value.AddDays(-dayDiff)
                        Me.dtpenddate.Value = Me.dtpStartdate.Value.AddDays(6)
                    Case "2"
                        Me.dtpStartdate.Value = New DateTime(Me.dtpStartdate.Value.Year, Me.dtpStartdate.Value.Month, 1)
                        Me.dtpenddate.Value = Me.dtpStartdate.Value.AddMonths(1).AddDays(-1)
                    Case "3"
                        Dim quarterNumber As Integer = (Me.dtpStartdate.Value.Month - 1) / 3 + 1
                        Me.dtpStartdate.Value = New DateTime(Me.dtpStartdate.Value.Year, (quarterNumber - 1) * 3 + 1, 1)
                        Me.dtpenddate.Value = Me.dtpStartdate.Value.AddMonths(3).AddDays(-1)
                    Case "4"
                        Me.dtpStartdate.Value = New DateTime(Me.dtpStartdate.Value.Year, 1, 1)
                        Me.dtpenddate.Value = New DateTime(Me.dtpStartdate.Value.Year, 12, 31)
                    Case "5"
                        Me.dtpenddate.Enabled = True
                        Me.dtpStartdate.Value = DateAdd(DateInterval.Month, -1, dtpenddate.Value)
                    Case "6"
                        Me.dtpStartdate.Enabled = False
                        Me.dtpenddate.Enabled = True
                        Me.dtpStartdate.Value = Me.dtpenddate.Value

                End Select
                afterload = True
            End If

        Catch ex As Exception

        End Try
    End Sub
#End Region

    Private Sub cmbReports_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbReports.SelectedValueChanged
        If afterload Then
            Call ClearValues()
            Call LoadSubReports()
        End If
    End Sub

    Private Sub cmbSubreports_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSubreports.SelectedValueChanged
        If afterload Then
            Call LoadReportFilters()
        End If
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Call LoadReport()
    End Sub

    Private Sub btnsearchicd10code_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearchicd10code.Click
        Dim f As New frmSearchEngine
        f.mModuleName = "ICD10Diagnosis"
        f.ShowDialog()
        If f.issave Then
            Me.icd10code = f.mKey
            Me.txtICD10Code.Text = f.mvalue
            Call LoadReport()
        End If
    End Sub

    Private Sub btnsearchprocedure_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearchprocedure.Click
        Dim f As New frmSearchEngine
        f.mModuleName = "Procedures"
        f.ShowDialog()
        If f.issave Then
            Me.icd10code = f.mKey
            Me.txtprocedure.Text = f.mKey & " - " & f.mvalue
            Call LoadReport()
        End If
    End Sub

    Private Sub btnSearchPatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchPatient.Click
        Dim f As New frmSearchEngine
        f.mModuleName = frmSearchEngine.ModuleName.Patient
        f.Isnewborn = False
        f.isexpired = False
        If Me.cmbReports.SelectedValue = 6 Then
            If Me.cmbSubreports.SelectedValue = 10 Then 'Birth Certificate
                f.Isnewborn = True
            ElseIf Me.cmbSubreports.SelectedValue = 11 Then ''Death Certificate
                f.isexpired = True
            End If
        End If
        f.ShowDialog()
        If f.issave Then
            Me.patientid = f.mKey
            Me.txtpatient.Text = f.mvalue
            Call LoadReport()
        End If
    End Sub

    Private Sub cmbPeriod_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPeriod.SelectedValueChanged
        If afterload Then
            Call LoadDateRange()
        End If
    End Sub

    Private Sub dtpStartdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpStartdate.ValueChanged
        If afterload Then
            Call LoadDateRange()
        End If
    End Sub
    Private Sub dtpenddate_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpenddate.ValueChanged
        If afterload Then
            Call LoadDateRange()
        End If
    End Sub

    Private Sub btnsearchadmission_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearchadmission.Click
        Dim f As New frmSearchEngine
        f.mModuleName = frmSearchEngine.ModuleName.Admission
        f.ShowDialog()
        If f.issave Then
            Me.admissionid = f.mKey
            Me.txtadmission.Text = f.mvalue
            Call LoadReport()
        End If
    End Sub

    Private Sub btnSearchEmployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchEmployee.Click
        Dim f As New frmSearchEngine
        f.mModuleName = frmSearchEngine.ModuleName.Employees
        f.ShowDialog()
        If f.issave Then
            Me.employeeid = f.mKey
            Me.txtEmployee.Text = f.mvalue
            Call LoadReport()
        End If
    End Sub

    Private Sub btnSearchSupplier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchSupplier.Click
        Dim f As New frmSearchEngine
        f.mModuleName = frmSearchEngine.ModuleName.HospitalSuppliers
        f.ShowDialog()
        If f.issave Then
            Me.supplierid = f.mKey
            Me.txtSupplier.Text = f.mvalue
            Call LoadReport()
        End If
    End Sub

    Private Sub btnSearchOffice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchOffice.Click
        Dim f As New frmSearchEngine
        f.mModuleName = frmSearchEngine.ModuleName.Offices
        f.ShowDialog()
        If f.issave Then
            Me.officecode = f.mKey
            Me.txtOffice.Text = f.mvalue
            Call LoadReport()
        End If
    End Sub

  
    Private Sub btnSearchItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchItem.Click
        Dim f As New frmSearchEngine
        f.mModuleName = frmSearchEngine.ModuleName.Items
        f.ShowDialog()
        If f.issave Then
            Me.itemcode = f.mKey
            Me.txtItem.Text = f.mvalue
            Call LoadReport()
        End If
    End Sub

    Private Sub btnSearchItemCategory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchItemCategory.Click
        Dim f As New frmSearchEngine
        f.mModuleName = frmSearchEngine.ModuleName.ItemCategory
        f.ShowDialog()
        If f.issave Then
            Me.itemcatcode = f.mKey
            Me.txtItemCategory.Text = f.mvalue
            Call LoadReport()
        End If
    End Sub

    Private Sub btnSearchLotno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchLotno.Click
        Dim f As New frmSearchEngine
        f.mModuleName = frmSearchEngine.ModuleName.LotNo
        f.itemcode = Me.itemcode
        f.officecode = Me.officecode
        f.ShowDialog()
        If f.issave Then
            Me.lotno = f.mKey
            Me.txtLotNo.Text = f.mKey
            Call LoadReport()
        End If
    End Sub

    Private Sub lblClearOffice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClearOffice.Click
        Me.officecode = ""
        Me.txtOffice.Clear()
    End Sub
    Private Sub lblClearItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClearItem.Click
        Me.itemcode = ""
        Me.txtItem.Clear()
    End Sub
    Private Sub lblClearLotno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClearLotno.Click
        Me.lotno = ""
        Me.txtLotNo.Clear()
    End Sub

    Private Sub lblClearCategory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClearCategory.Click
        Me.itemcatcode = ""
        Me.txtItemCategory.Clear()
    End Sub

    Private Sub lblClearSupplier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClearSupplier.Click
        Me.supplierid = 0
        Me.txtSupplier.Clear()
    End Sub

    Private Sub lblClearEmployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClearEmployee.Click
        Me.employeeid = 0
        Me.txtEmployee.Clear()
    End Sub

    Private Sub lblClearICD10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClearICD10.Click
        Me.icd10code = ""
        Me.txtICD10Code.Text = ""
    End Sub

    Private Sub lblClearAdmission_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClearAdmission.Click
        Me.admissionid = 0
        Me.txtadmission.Text = ""
    End Sub

    Private Sub lblClearPatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClearPatient.Click
        Me.patientid = 0
        Me.txtpatient.Clear()
    End Sub

    Private Sub lblClearProcedure_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClearProcedure.Click
        Me.icd10code = ""
        Me.txtprocedure.Clear()
    End Sub
End Class
