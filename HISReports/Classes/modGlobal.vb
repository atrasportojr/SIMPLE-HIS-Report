Imports System.Data.SqlClient
Module modGlobal
    Public msgboxTitle As String = "SIMPLE HIS"
    Public gconnectionstring = ""
    Public hospitalname As String = "Lutheran"
    Public cypherpassphrase As String = ""

    Public employeeid As Long
    Public userid As Long
    Public sourceOfficeCode As String = "017"
    Public ClinicID As Long = 4
    Public themecolor3 As Color = Color.CadetBlue

    Public ulastName As String
    Public ufirstName As String
    Public ufullName As String
    Public cancel_icon As Image = My.Resources.delete_16x16
    Public close_icon As Image = My.Resources.delete_16x16
    Public delete_icon As Image = My.Resources.delete_16x16
    Public remove_icon As Image = My.Resources.delete_16x16
    Public load_item_icon As Image = My.Resources.add_16
    Public select_record_icon As Image = My.Resources.ic_select
    Public add_icon As Image = My.Resources.add_16
    'Public tools_icon As Image = My.Resources.tools
    Public view_icon As Image = My.Resources.view_maintoolstrip
    Public print_icon As Image = My.Resources.printer
    Public save_icon As Image = My.Resources.ic_save
    Public search_icon As Image = My.Resources.search_glyph
    Public pencil_icon As Image = My.Resources.edit
    'Public female_icon As Image = My.Resources.female
    'Public male_icon As Image = My.Resources.male
    Public edit_icon As Image = My.Resources.edit
    Public camera_icon, folder_picture_icon As Image


    Public Function SQLTestConnection(ByRef servername As String, ByRef databasename As String, ByRef authtype As Integer,
                                    ByRef username As String, ByRef password As String) As Integer
        Dim i As Integer = 0
        Dim str As String = Nothing
        Try
            If authtype = 0 Then
                str = "Data Source=" & servername & ";Initial Catalog=" & databasename & ";Trusted_Connection=True;Connection Timeout=60"
            ElseIf authtype = 1 Then
                str = "Data Source=" & servername & ";Initial Catalog=" & databasename & "; User ID=" & username & ";Password=" & password & ";Connection Timeout=60"
            End If

            gconnectionstring = str
            Dim _conn As New SqlConnection(str)
            If _conn.State = ConnectionState.Closed Then
                _conn.Open()
                i = _conn.State
            End If
        Catch ex As Exception
            gconnectionstring = ""
            MessageBox.Show(ex.Message, "CONNECTION ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return i
    End Function

    Public Class fmain
        Public Shared subModule As String = "Inpatients"
        Class cmbFilterBy
            Public Shared SelectedIndex As Integer = 0
        End Class
        Public Shared visAdmit As String = "SubAdmitPatient"
    End Class
    Sub SaveLog(ByVal usermodule As String, ByVal userAction As String)
        'Dim logs As New clsUserLogs

        'logs.username = ufullName & "(" & userName & ")"
        'logs.usermodule = usermodule
        'logs.action = userAction
        'logs.logdate = Utility.GetServerDate()
        'logs.SaveLog()
    End Sub
    Enum AccountModule
        modNone = 0
        modEmergency = 17
        modOutpatient = 18
        modInpatients = 19
    End Enum

    Enum AccountSubModule
        smodNone = 0
        smodDiagnosis = 20
        smodNursingNotes = 57
        smodProgressNotes = 58
        smodOperativeRecord = 63
        smodIVFluidSheet = 64

        'smodItemStockCard = 28
        'smodItemReceivingHistory = 29
        'smodItemTransferHistory = 30
        'smodReportCashier = 31
        'smodReportFinance = 33
        'smodReportInventory = 34
        'smodReportLaboratory = 35
        'smodReportMedicalRecords = 36
        'smodReportPharmacy = 37
        'smodReportPhilHealth = 38
        'smodReportRadiologyUltratrasound = 39
        'smodReportForms = 40
        'smodItemChargesHistory = 41
        'smodItemEmpChargesHistory = 42
        'smodItemAdjustmentHistory = 43
        'smodItemReturnToSupplierHistory = 44
        'smodExpenseIssuanceHistory = 45
    End Enum

    Public canAdd As Boolean
    Public canEdit As Boolean
    Public canView As Boolean
    Public canDelete As Boolean
    Public canApprove As Boolean
    Public canInspect As Boolean
    Public canCheck As Boolean
    Public canReceive As Boolean
    Public canIssue As Boolean
    Public canVerify As Boolean

    Dim dtModule As New DataTable
    Dim dtsModule As New DataTable

    ''' <summary>
    ''' 
    ''' </summary>
    Sub GetUserModules(ByVal accMod As Integer)
        'Dim idx As Integer
        'Dim dtModule As New DataTable

        'dtModule = clsAuthentication.getUsersModules(authId)

        If dtModule.Rows.Count > 0 Then
            Dim row As DataRow = dtModule.Rows.Find(accMod)
            If Not (row Is Nothing) Then
                canAdd = row("canadd")
                canEdit = row("canedit")
                canDelete = row("candelete")
                canView = row("canview")
                canApprove = row("canapprove")
                canInspect = row("caninspect")
                canCheck = row("cancheck")
                canReceive = row("canreceive")
                canIssue = row("canissue")
                canVerify = row("canverify")
            Else
                canAdd = False
                canEdit = False
                canDelete = False
                canView = False
                canApprove = False
                canInspect = False
                canCheck = False
                canReceive = False
                canIssue = False
                canVerify = False
            End If
        End If
    End Sub

    Sub LoadUserModules()
        Dim dpk(1) As DataColumn
        dtModule = clsUsers.GetUser(2, "", "", modGlobal.employeeid)
        dpk(0) = dtModule.Columns("modcode")
        dtModule.PrimaryKey = dpk
    End Sub
    Sub LoadUserSubModules()
        Dim dpk(1) As DataColumn
        dtsModule = clsUsers.GetUser(3, "", "", modGlobal.employeeid)
        dpk(0) = dtsModule.Columns("submodcode")
        dtsModule.PrimaryKey = dpk
    End Sub
    Function GetUserSubModulesVisibility(ByVal authId As Integer, ByVal accSubMod As Integer) As Boolean
        Dim sw As Boolean
        Try
            If dtsModule.Rows.Count > 0 Then
                Dim Row As DataRow = dtsModule.Rows.Find(accSubMod)
                If Row Is Nothing Then
                    sw = False
                End If
                If Row("canaccess") = False Then
                    sw = False
                Else
                    sw = True
                End If
            End If
        Catch ex As Exception

        End Try

        Return sw
    End Function


    Sub setUserInfo()
        Dim dt As DataTable = clsUsers.GetUser(1, "", "", employeeid)
        sourceOfficeCode = dt.Rows(0).Item("officecode")
        ulastName = dt.Rows(0).Item("lastname")
        ufirstName = dt.Rows(0).Item("firstname")
        ufullName = ufirstName & " " & ulastName
        Dim dtHospInfo As DataTable = clsHospitalInfo.getInfo(0, "")
        'Select Case IsDBNull(dtHospInfo.Rows(0)("new_icon"))
        '    Case True
        '        new_icon = Nothing
        '    Case Else
        '        Dim tempphoto As Byte() = dtHospInfo.Rows(0)("new_icon")
        '        If tempphoto.Length = 0 Then
        '            new_icon = Nothing
        '        Else
        '            new_icon = Utility.convertImage(dtHospInfo.Rows(0)("new_icon")) 'image here
        '        End If
        'End Select
        hospitalname = dtHospInfo.Rows(0).Item("HospName")

        Select Case IsDBNull(dtHospInfo.Rows(0)("edit_icon"))
            Case True
                edit_icon = Nothing
            Case Else
                Dim tempphoto As Byte() = dtHospInfo.Rows(0)("edit_icon")
                If tempphoto.Length = 0 Then
                    edit_icon = Nothing
                Else
                    edit_icon = Utility.convertImage(dtHospInfo.Rows(0)("edit_icon")) 'image here
                End If
        End Select

        Select Case IsDBNull(dtHospInfo.Rows(0)("cancel_icon"))
            Case True
                cancel_icon = Nothing
            Case False
                Dim tempphoto As Byte() = dtHospInfo.Rows(0)("cancel_icon")
                If tempphoto.Length = 0 Then
                    cancel_icon = Nothing
                Else
                    cancel_icon = Utility.convertImage(dtHospInfo.Rows(0)("cancel_icon")) 'image here
                End If
        End Select

        Select Case IsDBNull(dtHospInfo.Rows(0)("print_icon"))
            Case True
                print_icon = Nothing
            Case Else
                Dim tempphoto As Byte() = dtHospInfo.Rows(0)("print_icon")
                If tempphoto.Length = 0 Then
                    print_icon = Nothing
                Else
                    print_icon = Utility.convertImage(dtHospInfo.Rows(0)("print_icon")) 'image here
                End If
        End Select


        Select Case IsDBNull(dtHospInfo.Rows(0)("save_icon"))
            Case True
                save_icon = Nothing
            Case False
                Dim tempphoto As Byte() = dtHospInfo.Rows(0)("save_icon")
                If tempphoto.Length = 0 Then
                    save_icon = Nothing
                Else
                    save_icon = Utility.convertImage(dtHospInfo.Rows(0)("save_icon")) 'image here
                End If
        End Select

        Select Case IsDBNull(dtHospInfo.Rows(0)("close_icon"))
            Case True
                close_icon = Nothing
            Case False
                Dim tempphoto As Byte() = dtHospInfo.Rows(0)("close_icon")
                If tempphoto.Length = 0 Then
                    close_icon = Nothing
                Else
                    close_icon = Utility.convertImage(dtHospInfo.Rows(0)("close_icon")) 'image here
                End If
        End Select

        Select Case IsDBNull(dtHospInfo.Rows(0)("search_icon"))
            Case True
                search_icon = Nothing
            Case False
                Dim tempphoto As Byte() = dtHospInfo.Rows(0)("search_icon")
                If tempphoto.Length = 0 Then
                    search_icon = Nothing
                Else
                    search_icon = Utility.convertImage(dtHospInfo.Rows(0)("search_icon")) 'image here
                End If
        End Select

        'Select Case IsDBNull(dtHospInfo.Rows(0)("select_record_icon"))
        '    Case True
        '        select_record_icon = Nothing
        '    Case False
        '        Dim tempphoto As Byte() = dtHospInfo.Rows(0)("select_record_icon")
        '        If tempphoto.Length = 0 Then
        '            select_record_icon = Nothing
        '        Else
        '            select_record_icon = Utility.convertImage(dtHospInfo.Rows(0)("select_record_icon")) 'image here
        '        End If
        'End Select

        'Select Case IsDBNull(dtHospInfo.Rows(0)("create_new_record_icon"))
        '    Case True
        '        create_new_record_icon = Nothing
        '    Case False
        '        Dim tempphoto As Byte() = dtHospInfo.Rows(0)("create_new_record_icon")
        '        If tempphoto.Length = 0 Then
        '            create_new_record_icon = Nothing
        '        Else
        '            create_new_record_icon = Utility.convertImage(dtHospInfo.Rows(0)("create_new_record_icon")) 'image here
        '        End If
        'End Select

        'Select Case IsDBNull(dtHospInfo.Rows(0)("inspect_icon"))
        '    Case True
        '        inspect_icon = Nothing
        '    Case False
        '        Dim tempphoto As Byte() = dtHospInfo.Rows(0)("inspect_icon")
        '        If tempphoto.Length = 0 Then
        '            inspect_icon = Nothing
        '        Else
        '            inspect_icon = Utility.convertImage(dtHospInfo.Rows(0)("inspect_icon")) 'image here
        '        End If
        'End Select

        'Select Case IsDBNull(dtHospInfo.Rows(0)("checked_icon"))
        '    Case True
        '        checked_icon = Nothing
        '    Case False
        '        Dim tempphoto As Byte() = dtHospInfo.Rows(0)("checked_icon")
        '        If tempphoto.Length = 0 Then
        '            checked_icon = Nothing
        '        Else
        '            checked_icon = Utility.convertImage(dtHospInfo.Rows(0)("checked_icon")) 'image here
        '        End If
        'End Select

        'Select Case IsDBNull(dtHospInfo.Rows(0)("accept_icon"))
        '    Case True
        '        accept_icon = Nothing
        '    Case Else
        '        Dim tempphoto As Byte() = dtHospInfo.Rows(0)("accept_icon")
        '        If tempphoto.Length = 0 Then
        '            accept_icon = Nothing
        '        Else
        '            accept_icon = Utility.convertImage(dtHospInfo.Rows(0)("accept_icon")) 'image here
        '        End If
        'End Select

        'Select Case IsDBNull(dtHospInfo.Rows(0)("realease_icon"))
        '    Case True
        '        realease_icon = Nothing
        '    Case Else
        '        Dim tempphoto As Byte() = dtHospInfo.Rows(0)("realease_icon")
        '        If tempphoto.Length = 0 Then
        '            realease_icon = Nothing
        '        Else
        '            realease_icon = Utility.convertImage(dtHospInfo.Rows(0)("realease_icon")) 'image here
        '        End If
        'End Select

        'Select Case IsDBNull(dtHospInfo.Rows(0)("receive_icon"))
        '    Case True
        '        receive_icon = Nothing
        '    Case Else
        '        Dim tempphoto As Byte() = dtHospInfo.Rows(0)("receive_icon")
        '        If tempphoto.Length = 0 Then
        '            receive_icon = Nothing
        '        Else
        '            receive_icon = Utility.convertImage(dtHospInfo.Rows(0)("receive_icon")) 'image here
        '        End If
        'End Select

        'Select Case IsDBNull(dtHospInfo.Rows(0)("issue_icon"))
        '    Case True
        '        issue_icon = Nothing
        '    Case Else
        '        Dim tempphoto As Byte() = dtHospInfo.Rows(0)("issue_icon")
        '        If tempphoto.Length = 0 Then
        '            issue_icon = Nothing
        '        Else
        '            issue_icon = Utility.convertImage(dtHospInfo.Rows(0)("issue_icon")) 'image here
        '        End If
        'End Select


        'Select Case IsDBNull(dtHospInfo.Rows(0)("post_icon"))
        '    Case True
        '        post_icon = Nothing
        '    Case Else
        '        Dim tempphoto As Byte() = dtHospInfo.Rows(0)("post_icon")
        '        If tempphoto.Length = 0 Then
        '            post_icon = Nothing
        '        Else
        '            post_icon = Utility.convertImage(dtHospInfo.Rows(0)("post_icon")) 'image here
        '        End If
        'End Select


        ''add

        'Select Case IsDBNull(dtHospInfo.Rows(0)("philhealth_icon"))
        '    Case True
        '        philhealth_icon = Nothing
        '    Case Else
        '        Dim tempphoto As Byte() = dtHospInfo.Rows(0)("philhealth_icon")
        '        If tempphoto.Length = 0 Then
        '            philhealth_icon = Nothing
        '        Else
        '            philhealth_icon = Utility.convertImage(dtHospInfo.Rows(0)("philhealth_icon")) 'image here
        '        End If
        'End Select

        Select Case IsDBNull(dtHospInfo.Rows(0)("camera_icon"))
            Case True
                camera_icon = Nothing
            Case Else
                Dim tempphoto As Byte() = dtHospInfo.Rows(0)("camera_icon")
                If tempphoto.Length = 0 Then
                    camera_icon = Nothing
                Else
                    camera_icon = Utility.convertImage(dtHospInfo.Rows(0)("camera_icon")) 'image here
                End If
        End Select

        Select Case IsDBNull(dtHospInfo.Rows(0)("pencil_icon"))
            Case True
                pencil_icon = Nothing
            Case Else
                Dim tempphoto As Byte() = dtHospInfo.Rows(0)("pencil_icon")
                If tempphoto.Length = 0 Then
                    pencil_icon = Nothing
                Else
                    pencil_icon = Utility.convertImage(dtHospInfo.Rows(0)("pencil_icon")) 'image here
                End If
        End Select
        Select Case IsDBNull(dtHospInfo.Rows(0)("folder_picture_icon"))
            Case True
                folder_picture_icon = Nothing
            Case Else
                Dim tempphoto As Byte() = dtHospInfo.Rows(0)("folder_picture_icon")
                If tempphoto.Length = 0 Then
                    folder_picture_icon = Nothing
                Else
                    folder_picture_icon = Utility.convertImage(dtHospInfo.Rows(0)("folder_picture_icon")) 'image here
                End If
        End Select
        Select Case IsDBNull(dtHospInfo.Rows(0)("load_item_icon"))
            Case True
                load_item_icon = Nothing
            Case Else
                Dim tempphoto As Byte() = dtHospInfo.Rows(0)("load_item_icon")
                If tempphoto.Length = 0 Then
                    load_item_icon = Nothing
                Else
                    load_item_icon = Utility.convertImage(dtHospInfo.Rows(0)("load_item_icon")) 'image here
                End If
        End Select
        'Select Case IsDBNull(dtHospInfo.Rows(0)("remove_icon"))
        '    Case True
        '        remove_icon = Nothing
        '    Case Else
        '        Dim tempphoto As Byte() = dtHospInfo.Rows(0)("remove_icon")
        '        If tempphoto.Length = 0 Then
        '            remove_icon = Nothing
        '        Else
        '            remove_icon = Utility.convertImage(dtHospInfo.Rows(0)("remove_icon")) 'image here
        '        End If
        'End Select
        'Select Case IsDBNull(dtHospInfo.Rows(0)("male_icon"))
        '    Case True
        '        male_icon = Nothing
        '    Case Else
        '        Dim tempphoto As Byte() = dtHospInfo.Rows(0)("male_icon")
        '        If tempphoto.Length = 0 Then
        '            male_icon = Nothing
        '        Else
        '            male_icon = Utility.convertImage(dtHospInfo.Rows(0)("male_icon")) 'image here
        '        End If
        'End Select
        'Select Case IsDBNull(dtHospInfo.Rows(0)("female_icon"))
        '    Case True
        '        female_icon = Nothing
        '    Case Else
        '        Dim tempphoto As Byte() = dtHospInfo.Rows(0)("female_icon")
        '        If tempphoto.Length = 0 Then
        '            female_icon = Nothing
        '        Else
        '            female_icon = Utility.convertImage(dtHospInfo.Rows(0)("female_icon")) 'image here
        '        End If
        'End Select
        'Select Case IsDBNull(dtHospInfo.Rows(0)("extract_icon"))
        '    Case True
        '        extract_icon = Nothing
        '    Case Else
        '        Dim tempphoto As Byte() = dtHospInfo.Rows(0)("extract_icon")
        '        If tempphoto.Length = 0 Then
        '            extract_icon = Nothing
        '        Else
        '            extract_icon = Utility.convertImage(dtHospInfo.Rows(0)("extract_icon")) 'image here
        '        End If
        'End Select
        'Select Case IsDBNull(dtHospInfo.Rows(0)("continue_icon"))
        '    Case True
        '        continue_icon = Nothing
        '    Case Else
        '        Dim tempphoto As Byte() = dtHospInfo.Rows(0)("continue_icon")
        '        If tempphoto.Length = 0 Then
        '            continue_icon = Nothing
        '        Else
        '            continue_icon = Utility.convertImage(dtHospInfo.Rows(0)("continue_icon")) 'image here
        '        End If
        'End Select
        Select Case IsDBNull(dtHospInfo.Rows(0)("view_icon"))
            Case True
                view_icon = Nothing
            Case Else
                Dim tempphoto As Byte() = dtHospInfo.Rows(0)("view_icon")
                If tempphoto.Length = 0 Then
                    view_icon = Nothing
                Else
                    view_icon = Utility.convertImage(dtHospInfo.Rows(0)("view_icon")) 'image here
                End If
        End Select

    End Sub
End Module
