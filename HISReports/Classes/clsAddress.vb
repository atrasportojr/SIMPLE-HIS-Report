Public Class clsAddress
#Region "Variable"
    Dim operation As Integer
    Public vRegid As Long
    Public vRegionID As Long
    Public RegionCode As String
    Public Region As String
    Public isdefault As Boolean
    Public isActive As Boolean
    Public employeeID As Long
    Public CUdate As DateTime
#End Region
   
#Region "Methods"
    Public Shared Function GenericVerification(ByVal sOP As Integer, Optional ByVal cRegion As String = "", Optional ByVal cRegionCode As String = "", Optional ByVal cRagionid As Long = 0, Optional ByVal cMunid As Long = 0) As DataTable
        Dim par() As String = {"operation", "sOperation", "RegionCode", "Region", "RegionID"}
        Dim parVal() As String = {0, sOP, cRegionCode, cRegion, cRagionid}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.setparam(par, parVal, "spaddress", 0)
    End Function
    Public Shared Function GenericVerification1(ByVal sOP As Integer, Optional ByVal Search As String = "") As DataTable
        Dim par() As String = {"operation", "sOperation", "Search"}
        Dim parVal() As String = {0, sOP, Search}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.setparam(par, parVal, "spaddress", 0)
    End Function
    Public Shared Function MainSearch(ByVal sOP As Integer, Optional ByVal csearch As String = "", Optional ByVal cfilterby As String = "") As DataTable
        Dim par() As String = {"operation", "sOperation", "search", "filterby"}
        Dim parVal() As String = {0, sOP, csearch, cfilterby}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.setparam(par, parVal, "spaddress", 0)
    End Function
    Public Function SaveRegion(ByVal isNew As Boolean, Optional ByVal regionid As Long = 0) As Long
        Dim sOperation As Integer
        If isNew Then
            operation = 1
        Else
            operation = 2
        End If
        Dim par() As String = {"operation", "sOperation", "RegionID", "Regioncode", "Region", "isactive", "EmployeeID", "CUDate", "NewPK"}
        Dim parval() As String = {Me.operation, sOperation, regionid, RegionCode, Region, isActive, employeeID, CUdate, operation}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.setparam(par, parval, "spAddress", 2)
    End Function
    Public Function SaveProvince(ByVal isNew As Boolean, Optional ByVal sOperation As Long = 0, Optional ByVal ProvinceID As Long = 0) As Long
        If isNew Then
            operation = 1
        Else
            operation = 2
        End If
        Dim par() As String = {"operation", "sOperation", "RegID", "ProvinceID", "RegionID", "Region", "isactive", "isdefault", "EmployeeID", "CUDate", "NewPK"}
        Dim parval() As String = {Me.operation, sOperation, vRegid, ProvinceID, Me.vRegionID, Region, isActive, isdefault, employeeID, CUdate, operation}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.setparam(par, parval, "spAddress", 2)
    End Function
    Public Function SaveDefault(Optional ByVal sOperation As Long = 0, Optional ByVal ProvinceID As Long = 0) As Long
        Dim par() As String = {"operation", "sOperation", "RegID", "ProvinceID", "RegionID", "isdefault"}
        Dim parval() As String = {2, sOperation, vRegid, ProvinceID, Me.vRegionID, isdefault}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.setparam(par, parval, "spAddress", 1)
    End Function
#End Region
End Class
