Public Class clsitems
#Region "Variables"
    Private mItemCodeOld As String
    Private mItemCode As String          'primary key
    Private mItemCatCode As String
    Private mItemDescription As String
    Private mItemSpecs As String
    Private mUnit As String
    Private mRetailUnit As String
    Private mLotNo As String
    Private mExpiryDate As Date
    Private mEstUnitCost As Double
    Private mEstNewUnitCost As Double
    Private mIsHospitalItem As Boolean

    Private mSupplierNo As Integer
    Private mSupplierName As String
    Private mTinNumber As String
    Private mBIRPermitNo As String
    Private msuppliertypeid As Integer
    Private mIsHospitalSupplier As Boolean

    Private mPerPack As Decimal
    Private mFreeItemsPerGroupItems As Decimal
    Private mFreeItemsGroupItems As Decimal
    Private mPrice As Decimal
    Private mPrice1 As Decimal
    Private mPrice2 As Decimal
    Private mPrice3 As Decimal

    Private mMarkUpPrice1 As Decimal
    Private mMarkUpPrice2 As Decimal
    Private mMarkUpPrice3 As Decimal
    Private misfromtpt As Boolean

    Private mPhilHealth As Integer

    Private mDrugDescription As String
    Private mUnitDescription As String
    Private mUnitCode As String
    Private mDrugCode As String
    Private mBarCode As String
    Private mRetailItem As String

    Private mIssalesitems As Boolean
    Private mIsPurchaseItems As Boolean


    Private mitemtaxtypeid As String
    Private mitemsmemo As String
    Private misactive As Boolean
    Private misdefault As Boolean

    Public DrugCode1 As String
    Public GenericID As Integer
    Public GenericCode As String
    Public GenericName As String
    Public OLDDrugCode1 As String

    Public clinicid As Long
    Public server_id As Long
    Public issync As Boolean

    Public itemname As String
    Public itemtypename As String
    Public itemcatdescription As String
    Public itemcattype As String
    Public isdiscountable As Boolean

    Public unitmeasurementID As Integer
    Public unitmeasurementName As String
    Public unitmeasurementcode As String
    Public createdby As Long
    Public updatedby As Long
    Public CUdate As Date
    Public UID As Long

#End Region
#Region " Properties "
    Public Property itemtaxtypeid() As String
        Get
            Return mitemtaxtypeid
        End Get
        Set(ByVal Value As String)
            mitemtaxtypeid = Value
        End Set
    End Property
    Public Property itemsmemo() As String
        Get
            Return mitemsmemo
        End Get
        Set(ByVal Value As String)
            mitemsmemo = Value
        End Set
    End Property
    Public Property isactive() As Boolean
        Get
            Return misactive
        End Get
        Set(ByVal Value As Boolean)
            misactive = Value
        End Set
    End Property
    Public Property isdefault() As Boolean
        Get
            Return misdefault
        End Get
        Set(ByVal Value As Boolean)
            misdefault = Value
        End Set
    End Property

    Public Property BarCode() As String
        Get
            Return mBarCode
        End Get
        Set(ByVal Value As String)
            mBarCode = Value
        End Set
    End Property
    Public Property RetailItem() As String
        Get
            Return mRetailItem
        End Get
        Set(ByVal Value As String)
            mRetailItem = Value
        End Set
    End Property

    Public Property DrugDescription() As String
        Get
            Return mDrugDescription
        End Get
        Set(ByVal Value As String)
            mDrugDescription = Value
        End Set
    End Property
    Public Property UnitDescription() As String
        Get
            Return mUnitDescription
        End Get
        Set(ByVal Value As String)
            mUnitDescription = Value
        End Set
    End Property
    Public Property UnitCode() As String
        Get
            Return mUnitCode
        End Get
        Set(ByVal Value As String)
            mUnitCode = Value
        End Set
    End Property
    Public Property DrugCode() As String
        Get
            Return mDrugCode
        End Get
        Set(ByVal Value As String)
            mDrugCode = Value
        End Set
    End Property

    Public Property ItemCodeOld() As String
        Get
            Return mItemCodeOld
        End Get
        Set(ByVal Value As String)
            mItemCodeOld = Value
        End Set
    End Property

    Public Property ItemCode() As String
        Get
            Return mItemCode
        End Get
        Set(ByVal Value As String)
            mItemCode = Value
        End Set
    End Property
    Public Property ItemCatCode() As String
        Get
            Return mItemCatCode
        End Get
        Set(ByVal Value As String)
            mItemCatCode = Value
        End Set
    End Property
    Public Property ItemDescription() As String
        Get
            Return mItemDescription
        End Get
        Set(ByVal Value As String)
            mItemDescription = Value

        End Set
    End Property

    Public Property ItemSpecs() As String
        Get
            Return mItemSpecs
        End Get
        Set(ByVal Value As String)
            mItemSpecs = Value
        End Set
    End Property

    Public Property Unit() As String
        Get
            Return mUnit
        End Get
        Set(ByVal Value As String)
            mUnit = Value
        End Set
    End Property
    Public Property RetailUnit() As Double
        Get
            Return mRetailUnit
        End Get
        Set(ByVal Value As Double)
            mRetailUnit = Value
        End Set
    End Property
    Public Property EstUnitCost() As Double
        Get
            Return mEstUnitCost
        End Get
        Set(ByVal Value As Double)
            mEstUnitCost = Value
        End Set
    End Property

    Public Property EstNewUnitCost() As Double
        Get
            Return mEstNewUnitCost
        End Get
        Set(ByVal Value As Double)
            mEstNewUnitCost = Value
        End Set
    End Property
    Public Property IsHospitalItem() As Boolean
        Get
            Return mIsHospitalItem
        End Get
        Set(ByVal Value As Boolean)
            mIsHospitalItem = Value
        End Set
    End Property

    Public Property SupplierNo() As Integer
        Get
            Return mSupplierNo
        End Get
        Set(ByVal Value As Integer)
            mSupplierNo = Value
        End Set
    End Property
    Public Property TinNumber() As String
        Get
            Return mTinNumber
        End Get
        Set(ByVal Value As String)
            mTinNumber = Value
        End Set
    End Property
    Public Property BIRPermitNo() As String
        Get
            Return mBIRPermitNo
        End Get
        Set(ByVal Value As String)
            mBIRPermitNo = Value
        End Set
    End Property
    Public Property suppliertypeid() As Integer
        Get
            Return msuppliertypeid
        End Get
        Set(ByVal Value As Integer)
            msuppliertypeid = Value
        End Set
    End Property
    Public Property IsHospitalSupplier() As Boolean
        Get
            Return mIsHospitalSupplier
        End Get
        Set(ByVal Value As Boolean)
            mIsHospitalSupplier = Value
        End Set
    End Property
    Public Property SupplierName() As String
        Get
            Return mSupplierName
        End Get
        Set(ByVal Value As String)
            mSupplierName = Value
        End Set
    End Property

    Public Property PerPack() As Decimal
        Get
            Return mPerPack
        End Get
        Set(ByVal Value As Decimal)
            mPerPack = Value
        End Set
    End Property

    Public Property FreeItemsPerGroupItems() As Decimal
        Get
            Return mFreeItemsPerGroupItems
        End Get
        Set(ByVal Value As Decimal)
            mFreeItemsPerGroupItems = Value
        End Set
    End Property
    Public Property FreeItemsGroupItems() As Decimal
        Get
            Return mFreeItemsGroupItems
        End Get
        Set(ByVal Value As Decimal)
            mFreeItemsGroupItems = Value
        End Set
    End Property
    Public Property Price() As Decimal
        Get
            Return mPrice
        End Get
        Set(ByVal Value As Decimal)
            mPrice = Value
        End Set
    End Property
    Public Property Price1() As Decimal
        Get
            Return mPrice1
        End Get
        Set(ByVal Value As Decimal)
            mPrice1 = Value
        End Set
    End Property
    Public Property Price2() As Decimal
        Get
            Return mPrice2
        End Get
        Set(ByVal Value As Decimal)
            mPrice2 = Value
        End Set
    End Property
    Public Property Price3() As Decimal
        Get
            Return mPrice3
        End Get
        Set(ByVal Value As Decimal)
            mPrice3 = Value
        End Set
    End Property
    Public Property MarkUpPrice1() As Decimal
        Get
            Return mMarkUpPrice1
        End Get
        Set(ByVal Value As Decimal)
            mMarkUpPrice1 = Value
        End Set
    End Property
    Public Property MarkUpPrice2() As Decimal
        Get
            Return mMarkUpPrice2
        End Get
        Set(ByVal Value As Decimal)
            mMarkUpPrice2 = Value
        End Set
    End Property
    Public Property MarkUpPrice3() As Decimal
        Get
            Return mMarkUpPrice3
        End Get
        Set(ByVal Value As Decimal)
            mMarkUpPrice3 = Value
        End Set
    End Property
    Public Property isfromtpt() As Decimal
        Get
            Return misfromtpt
        End Get
        Set(ByVal Value As Decimal)
            misfromtpt = Value
        End Set
    End Property
    Public Property PhilHealth() As Integer
        Get
            Return mPhilHealth
        End Get
        Set(ByVal Value As Integer)
            mPhilHealth = Value
        End Set
    End Property

    Public Property Salesitems() As Boolean
        Get
            Return mIssalesitems
        End Get
        Set(ByVal Value As Boolean)
            mIssalesitems = Value
        End Set
    End Property
    Public Property PurchaseItems() As Boolean
        Get
            Return mIsPurchaseItems
        End Get
        Set(ByVal Value As Boolean)
            mIsPurchaseItems = Value
        End Set
    End Property
#End Region
#Region "Methods"
    Public Shared Function getitem(ByRef soperation As Integer, ByRef search As String, Optional ByRef isactive As Boolean = True, Optional ByRef ishospitalitem As Boolean = True) As DataTable
        Dim strPar() As String = {"operation", "soperation", "search", "isactive", "ishospitalitem", "createdbyid", "searchcattype"}
        Dim strVal() As String = {0, soperation, search, isactive, ishospitalitem, modGlobal.employeeid, "I"}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring)
        Return s.SetParam(strPar, strVal, "spItems", 0)
    End Function
    Public Shared Function getItemCategory(ByRef soperation As Integer, ByRef search As String) As DataTable
        Dim strPar() As String = {"operation", "soperation", "search"}
        Dim strVal() As String = {0, soperation, search}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring)
        Return s.SetParam(strPar, strVal, "spItemCategory", 0)
    End Function
    Public Shared Function getSupplier(ByRef soperation As Integer, ByRef search As String, Optional ByRef isactive As Integer = 1, Optional ByRef ishospitalsupplier As Boolean = True) As DataTable
        Dim strPar() As String = {"operation", "soperation", "search", "isactive", "ishospitalsupplier"}
        Dim strVal() As String = {0, soperation, search, isactive, ishospitalsupplier}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring)
        Return s.SetParam(strPar, strVal, "spSuppliers", 0)
    End Function

    Public Shared Function getUnit(ByRef soperation As Integer, ByRef search As String, Optional ByRef isactive As Boolean = True) As DataTable
        Dim strPar() As String = {"operation", "soperation", "search", "isactive"}
        Dim strVal() As String = {0, soperation, search, isactive}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring)
        Return s.SetParam(strPar, strVal, "spUnitOfMeasurement", 0)
    End Function
    Public Shared Function getitemcode(ByRef soperation As Integer, ByRef itemcode As String) As DataTable
        Dim strPar() As String = {"operation", "soperation", "search"}
        Dim strVal() As String = {0, soperation, itemcode}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring)
        Return s.SetParam(strPar, strVal, "spItems", 0)
    End Function

    Public Function saveItems(ByVal isNew As Boolean) As String
        Dim sOperation As Integer
        Dim operation As Integer
        If isNew Then
            operation = 1
            sOperation = 2
        Else
            operation = 2
            sOperation = 2
        End If
        Dim strPar() As String = {"operation", "soperation", "search", "itemcode",
                                   "retailitemcode", "itemcatdescription", "itemdescription",
                                   "itemspecs", "supplierno", "unitcode", "estnewunitcost",
                                   "estunitcost", "isactive", "producttype", "createdbyid", "updatedbyid",
                                   "price1", "price2", "price3", "issalesitems", "perpack", "ishospitalitem", "NewPK"}
        Dim strVal() As String = {operation, sOperation, Me.ItemCode, Me.ItemCode,
                                  "", ItemCatCode, itemname,
                                  GenericName, SupplierNo, unitmeasurementID, mEstUnitCost,
                                  mEstNewUnitCost, isactive, RetailItem, createdby, updatedby,
                                  mPrice1, mPrice2, mPrice3, mIssalesitems, mPerPack, IsHospitalItem, 1}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.SetParam(strPar, strVal, "spItems", 2)
    End Function
    Public Shared Function getItemswCode(ByRef sop As Integer, ByRef itemcode As Long)
        Dim strPar() As String = {"operation", "soperation", "itemcode"}
        Dim strVal() As String = {0, 4, itemcode}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring)
        Return s.SetParam(strPar, strVal, "spItems", 0)
    End Function
    Public Shared Function GenericVerification(ByVal target As String, ByVal sOP As Integer, Optional ByVal targetname As String = "",
                                               Optional ByVal targetid As String = "", Optional ByVal targetcode As String = "", Optional ByVal ishospital As Boolean = True) As DataTable
        Dim par() As String = {}
        Dim parVal() As String = {}
        Select Case target
            Case "Measurement"
                par = {"operation", "soperation", "unitdescription", "unitshortname"}
                parVal = {0, sOP, targetname, targetcode}
            Case "Generic"
                par = {"operation", "soperation", "genericname", "genericcode"}
                parVal = {0, sOP, targetname, targetcode}
            Case "Manufacturer", "Supplier"
                par = {"operation", "soperation", "supplier", "supplierid", "ishospitalsupplier"}
                parVal = {0, sOP, targetname, targetid, ishospital}
            Case "Item"
                par = {"operation", "soperation", "itemdescription", "itemcode"}
                parVal = {0, sOP, targetname, targetid}
            Case "ItemType"
                par = {"operation", "soperation", "itemtypecode", "itemtypename"}
                parVal = {0, sOP, targetcode, targetname}
        End Select
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.SetParam(par, parVal, "spItems", 0)
    End Function
    Public Function SaveGeneric(ByVal isNew As Boolean, Optional ByVal GenID As Integer = 0) As Long
        Dim sOperation As Integer
        Dim operation As Integer
        If isNew Then
            operation = 1
            sOperation = 1
        Else
            operation = 2
            sOperation = 1
        End If
        Dim par() As String = {"operation", "soperation", "genericid", "genericcode", "genericname", "isactive",
                               "clinicid", "server_id", "createdbyid", "datecreated", "updatedbyid", "dateupdated", "issync", "NewPK"}
        Dim parval() As String = {operation, sOperation, GenID, GenericCode, GenericName, isactive,
                                  clinicid, server_id, createdby, CUdate, updatedby, CUdate, issync, operation}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.SetParam(par, parval, "spItems", 2)
        'Dim s As New Public_Modules
        'Return s.RETURN_NEWPK("spItems", par, parval)
    End Function
    Public Function SaveSupplier(ByVal isNew As Boolean) As Long
        Dim sOperation As Integer
        Dim operation As Integer
        If isNew Then
            operation = 1
            sOperation = 0
        Else
            operation = 2
            sOperation = 3
        End If
        Dim par() As String = {"operation", "soperation", "supplierno", "suppliername", "tin", "birpermitno", "isactive",
                                "sp_createdbyid", "sp_updatedbyid", "ishospitalsupplier", "suppliertypeid", "NewPK"}
        Dim parval() As String = {operation, sOperation, SupplierNo, SupplierName, TinNumber, BIRPermitNo, IIf(isactive, 1, 0),
                                  createdby, updatedby, IsHospitalSupplier, suppliertypeid, operation}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.SetParam(par, parval, "spSuppliers", 2)
    End Function
    Public Function SaveItemCategory(ByVal isNew As Boolean, Optional ByVal itemcatid As String = "") As Object
        Dim sOperation As Integer
        Dim operation As Integer
        If isNew Then
            operation = 1
            sOperation = 0
        Else
            operation = 2
            sOperation = 0
        End If
        Dim par() As String = {"operation", "soperation", "itemcatcodeold", "itemcatcode", "itemcatdescription", "itemcattype", "isactive",
                                "createdbyid", "updatedbyid", "NewPK"}
        Dim parval() As Object = {operation, sOperation, itemcatid, itemcatid, itemcatdescription, itemcattype, isactive,
                                  createdby, updatedby, operation}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : Return s.SetParam(par, parval, "spItemCategory", 2)
        'Dim s As New Public_Modules
        'Return s.RETURN_NEWPK("spItems", par, parval)
    End Function
    Public Sub SaveItemType(ByVal isNew As Boolean, Optional ByVal ItemtypeCode As String = "")
        Dim sOperation As Integer
        Dim operation As Integer
        If isNew Then
            operation = 1
            sOperation = 4
        Else
            operation = 2
            sOperation = 4
        End If
        Dim par() As String = {"operation", "soperation", "itemtypecode", "itemtypename", "isactive", "isdefault", "createdbyid", "datecreated",
                               "updatedbyid", "dateupdated", "issync", "clinicid"}
        Dim parval() As String = {operation, sOperation, ItemtypeCode, itemtypename, isactive, isdefault, createdby, CUdate,
                                updatedby, CUdate, issync, clinicid}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : s.SetParam(par, parval, "spItems", 1)
    End Sub
    Public Function SaveMeasurement(ByVal isNew As Boolean, Optional ByVal measurementid As Integer = 0) As Long
        Dim sOperation As Integer
        Dim operation As Integer
        If isNew Then
            operation = 1
            sOperation = 0
        Else
            operation = 2
            sOperation = 0
        End If

        Dim par() As String = {"operation", "soperation", "Oldunitcode", "unitcode", "unitdescription", "isactive",
                                "createdby", "updatedby", "NewPK"}
        Dim parval() As String = {operation, sOperation, measurementid, unitmeasurementcode, unitmeasurementName, isactive,
                                createdby, updatedby, operation}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring)
        Return s.SetParam(par, parval, "spUnitOfMeasurement", 2)
        'Dim dt As DataTable = s.setparam(par, parval, "spItems", 0)
        'UID = dt.Rows(0).Item("NewPK")
        'Return UID
    End Function

    Public Shared Sub updateitemmapping(ByRef itemcode As String, ByRef drugcode As String)
        Dim strPar() As String = {"operation", "soperation", "itemcode", "philhealthdrugcode"}
        Dim strVal() As String = {2, 3, itemcode, drugcode}
        Dim s As New simpleadapter.SimpleAdapter(gconnectionstring) : s.SetParam(strPar, strVal, "spItems", 1)
    End Sub
#End Region


End Class
