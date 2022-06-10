Public Class clsAdmissionNewborn
    Public admissionid As Long
    Public newborncare As Boolean
    Public newbornhearing As Boolean
    Public newbornscreening As Boolean
    Public filtercardno As String
    Public immediatedrying As Boolean
    Public earlyskintoskin As Boolean
    Public timelycordclamping As Boolean
    Public eyeprophylaxis As Boolean
    Public weighing As Boolean
    Public vitkadministration As Boolean
    Public bcgvacination As Boolean
    Public nonseparationbreatfeeding As Boolean
    Public hepatitisb As Boolean
    Public nbsphenykytonuria As Boolean
    Public nbsG6PD As Boolean
    Public nbsGalactosemia As Boolean
    Public nbshypothyroidism As Boolean
    Public nbshyperplasia As Boolean
    Public newbornshearingresult As String = ""
    Public newbornshearingregistryno As String = ""
    Public birthlength As String = ""
    Public headcirc As String = ""
    Public chestcirc As String = ""
    Public abdomincirc As String = ""
    Public apgarA1 As Integer = 0
    Public apgarP1 As Integer = 0
    Public apgarG1 As Integer = 0
    Public apgarAC1 As Integer = 0
    Public apgarR1 As Integer = 0
    Public apgarA5 As Integer = 0
    Public apgarP5 As Integer = 0
    Public apgarG5 As Integer = 0
    Public apgarAC5 As Integer = 0
    Public apgarR5 As Integer = 0
    Public apgarscore5 As Integer = 0


    Public sub Save()
        Dim strPar() As String = {"operation",
                                    "soperation",
                                    "admissionid",
                                    "newborncare",
                                    "newbornshearing",
                                    "newbornscreening",
                                    "filtercardno",
                                    "immediatedrying",
                                    "earlyskintoskin",
                                    "timelycordclamping",
                                    "eyeprophylaxis",
                                    "weighing",
                                    "vitkadministration",
                                    "bcgvacination",
                                    "nonseparationbreatfeeding",
                                    "hepatitisb",
                                    "nbsphenykytonuria",
                                    "nbsG6PD",
                                    "nbsGalactosemia",
                                    "nbshypothyroidism",
                                    "nbshyperplasia",
                                    "newbornshearingresult",
                                    "newbornshearingregistryno",
                                    "birthlength",
                                    "headcirc",
                                    "chestcirc",
                                    "abdomincirc",
                                    "apgarA1",
                                    "apgarP1",
                                    "apgarG1",
                                    "apgarAC1",
                                    "apgarR1",
                                    "apgarA5",
                                    "apgarP5",
                                    "apgarG5",
                                    "apgarAC5",
                                    "apgarR5",
                                    "apgarscore5"}
        Dim strVar() As Object = {1,
                                        0,
                                        admissionid,
                                        newborncare,
                                        newbornhearing,
                                        newbornscreening,
                                        filtercardno,
                                        immediatedrying,
                                        earlyskintoskin,
                                        timelycordclamping,
                                        eyeprophylaxis,
                                        weighing,
                                        vitkadministration,
                                        bcgvacination,
                                        nonseparationbreatfeeding,
                                        hepatitisb,
                                        nbsphenykytonuria,
                                        nbsG6PD,
                                        nbsGalactosemia,
                                        nbshypothyroidism,
                                        nbshyperplasia,
                                        newbornshearingresult,
                                        newbornshearingregistryno,
                                        birthlength,
                                        headcirc,
                                        chestcirc,
                                        abdomincirc,
                                        apgarA1,
                                        apgarP1,
                                        apgarG1,
                                        apgarAC1,
                                        apgarR1,
                                        apgarA5,
                                        apgarP5,
                                        apgarG5,
                                        apgarAC5,
                                        apgarR5,
                                        apgarscore5}

        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : s.SetParam(strPar, strVar, "spAdmissionNewborn", 1)
    End Sub

    Public Sub getNewborn()
        Dim strPar() As String = {"operation", "soperation", "admissionid"}
        Dim strVar() As Object = {0, 0, admissionid}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring)
        Dim dt As DataTable = s.setparam(strPar, strVar, "spAdmissionNewborn", 0)
        If dt.Rows.Count > 0 Then
            newborncare = dt.Rows(0).Item("newborncare")
            newbornhearing = dt.Rows(0).Item("newbornshearing")
            newbornscreening = dt.Rows(0).Item("newbornscreening")
            filtercardno = Utility.NullToEmptyString(dt.Rows(0).Item("filtercardno"))
            immediatedrying = dt.Rows(0).Item("immediatedrying")
            earlyskintoskin = dt.Rows(0).Item("earlyskintoskin")
            timelycordclamping = dt.Rows(0).Item("timelycordclamping")
            eyeprophylaxis = dt.Rows(0).Item("eyeprophylaxis")
            weighing = dt.Rows(0).Item("weighing")
            vitkadministration = dt.Rows(0).Item("vitkadministration")
            bcgvacination = dt.Rows(0).Item("bcgvacination")
            nonseparationbreatfeeding = dt.Rows(0).Item("nonseparationbreatfeeding")
            hepatitisb = dt.Rows(0).Item("hepatitisb")
            nbsphenykytonuria = Utility.NullToBoolean(dt.Rows(0).Item("nbsphenykytonuria"))
            nbsG6PD = Utility.NullToBoolean(dt.Rows(0).Item("nbsG6PD"))
            nbsGalactosemia = Utility.NullToBoolean(dt.Rows(0).Item("nbsGalactosemia"))
            nbshypothyroidism = Utility.NullToBoolean(dt.Rows(0).Item("nbshypothyroidism"))
            nbshyperplasia = Utility.NullToBoolean(dt.Rows(0).Item("nbshyperplasia"))
            newbornshearingresult = Utility.NullToEmptyString(dt.Rows(0).Item("newbornshearingresult"))
            newbornshearingregistryno = Utility.NullToEmptyString(dt.Rows(0).Item("newbornshearingregistryno"))
            birthlength = Utility.NullToEmptyString(dt.Rows(0).Item("birthlength"))
            headcirc = Utility.NullToEmptyString(dt.Rows(0).Item("headcirc"))
            chestcirc = Utility.NullToEmptyString(dt.Rows(0).Item("chestcirc"))
            abdomincirc = Utility.NullToEmptyString(dt.Rows(0).Item("abdomincirc"))
            apgarA1 = Utility.NullToZero(dt.Rows(0).Item("apgarA1"))
            apgarP1 = Utility.NullToZero(dt.Rows(0).Item("apgarP1"))
            apgarG1 = Utility.NullToZero(dt.Rows(0).Item("apgarG1"))
            apgarAC1 = Utility.NullToZero(dt.Rows(0).Item("apgarAC1"))
            apgarR1 = Utility.NullToZero(dt.Rows(0).Item("apgarR1"))
            apgarA5 = Utility.NullToZero(dt.Rows(0).Item("apgarA5"))
            apgarP5 = Utility.NullToZero(dt.Rows(0).Item("apgarP5"))
            apgarG5 = Utility.NullToZero(dt.Rows(0).Item("apgarG5"))
            apgarAC5 = Utility.NullToZero(dt.Rows(0).Item("apgarAC5"))
            apgarR5 = Utility.NullToZero(dt.Rows(0).Item("apgarR5"))
            apgarscore5 = Utility.NullToZero(dt.Rows(0).Item("apgarscore5"))
        End If
    End Sub
    Public Shared Function genericcls(ByVal sop As Integer, ByVal admissionid As Long) As DataTable
        Dim strPar() As String = {"operation", "soperation", "admissionid"}
        Dim strVar() As Object = {0, sop, admissionid}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring)
        Return s.SetParam(strPar, strVar, "spAdmissionNewborn", 0)
    End Function
End Class
