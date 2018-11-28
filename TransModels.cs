using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_ERP.Models
{
    public class Trans_Drivers
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Code { get; set; }
        public string NameA { get; set; }
        public string NameE { get; set; }
        [ForeignKey("CompanyId")]
        public Sys_Companies Sys_Companies { get; set; }
        public int CompanyId { get; set; }
        public int ClassificationId { get; set; }
        [ForeignKey("NationalityId")]
        public Sys_Countries Sys_Countries { get; set; }
        public int? NationalityId { get; set; }
        public string ResidencyNo { get; set; }
        public UserControl_GHDate_NotNull ResidencyExpireDate { get; set; } //تاريخ الانتهاء
        public string Guarantor { get; set; }
        public string Tel1 { get; set; }
        public string Tel2 { get; set; }
        public string Email { get; set; }
        [ForeignKey("RepliesAccountId")]
        public GL_ChartOfAccounts GL_ChartOfAccounts { get; set; }
        public int? RepliesAccountId { get; set; }
        public string PortPermitType { get; set; }
        public string PortPermitNo { get; set; }
        public UserControl_GHDate_NotNull PermitExpireDate { get; set; } //تاريخ الانتهاء
        public string LicenceNo { get; set; }
        public UserControl_GHDate_NotNull LicenceExpireDate { get; set; } //تاريخ الانتهاء


        [ForeignKey("EmployeesId")]
        public HR_Employees HR_Employees { get; set; }
        public int? EmployeesId { get; set; }

        public string Notes { get; set; }
        public int? Create_Uid { get; set; }
        public Nullable<DateTime> Create_Date { get; set; }
        public int? Write_Uid { get; set; }
        public Nullable<DateTime> Write_Date { get; set; }
        public Boolean? Post { get; set; }
        public int? Post_Uid { get; set; }
        public Nullable<DateTime> Post_Date { get; set; }
        public Boolean? Deleted { get; set; }
        public int? Delete_Uid { get; set; }
        public Nullable<DateTime> Delete_Date { get; set; }

    }
    public class Trans_TrucksTypes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Code { get; set; }
        public string NameA { get; set; }
        public string NameE { get; set; }
        [ForeignKey("CompanyId")]
        public Sys_Companies Sys_Companies { get; set; }
        public int CompanyId { get; set; }
        public string Notes { get; set; }
        public int? Create_Uid { get; set; }
        public Nullable<DateTime> Create_Date { get; set; }
        public int? Write_Uid { get; set; }
        public Nullable<DateTime> Write_Date { get; set; }
        public Boolean? Post { get; set; }
        public int? Post_Uid { get; set; }
        public Nullable<DateTime> Post_Date { get; set; }
        public Boolean? Deleted { get; set; }
        public int? Delete_Uid { get; set; }
        public Nullable<DateTime> Delete_Date { get; set; }

    }
    public class Trans_Trucks
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Code { get; set; }
        [ForeignKey("CompanyId")]
        public Sys_Companies Sys_Companies { get; set; }
        public int CompanyId { get; set; }
        [ForeignKey("TrucksTypeId")]
        public Trans_TrucksTypes Trans_TrucksTypes { get; set; }
        public int? TrucksTypeId { get; set; }
        public int ClassificationId { get; set; }
        public string PlateNo { get; set; }
        public string FormNo { get; set; }
        public string ChassisNo { get; set; }
        public string MotorNo { get; set; }
        public string Model { get; set; }
        public string BrandName { get; set; }
        public int? ManufacturingYear { get; set; }

        //Tab 1
        public string CarCondition { get; set; }
        [ForeignKey("ColorId")]
        public Sys_Colors Sys_Colors { get; set; }
        public int? ColorId { get; set; }
        public UserControl_GHDate_NotNull PurchaseDate { get; set; }
        [ForeignKey("CostCenterId")]
        public GL_ChartOfCostCenter GL_ChartOfCostCenter { get; set; }
        public int? CostCenterId { get; set; }
        public string LaghmarhNo { get; set; }
        public string FileNo { get; set; }
        [ForeignKey("DriverId")]
        public Trans_Drivers Trans_Drivers { get; set; }
        public int? DriverId { get; set; }
        public string AlsofhFrontNo { get; set; }
        public string AlsofhRearNo { get; set; }
        public string PomegranateFrontNo { get; set; }
        public string PomegranateRearNo { get; set; }
        public string PortPermitType { get; set; }
        public string PortPermitNo { get; set; }
        public string OperatingCardNo { get; set; }
        public string InsuranceCompany { get; set; }
        public string InsuranceNo { get; set; }

        [ForeignKey("AssetId")]
        public FA_Assets FA_Assets { get; set; }
        public int? AssetId { get; set; }

        public string Notes { get; set; }
        //Tab 2
        public UserControl_GHDate_NotNull FormExpireDate { get; set; } //تاريخ الانتهاء
        public UserControl_GHDate_NotNull PeriodicInspectionExpireDate { get; set; } //تاريخ الانتهاء
        public UserControl_GHDate_NotNull InsuranceExpireDate { get; set; } //تاريخ الانتهاء
        public UserControl_GHDate_NotNull PortPermitExpireDate { get; set; } //تاريخ الانتهاء
        public UserControl_GHDate_NotNull OperatingCardExpireDate { get; set; } //تاريخ الانتهاء
        public int? Create_Uid { get; set; }
        public Nullable<DateTime> Create_Date { get; set; }
        public int? Write_Uid { get; set; }
        public Nullable<DateTime> Write_Date { get; set; }
        public Boolean? Post { get; set; }
        public int? Post_Uid { get; set; }
        public Nullable<DateTime> Post_Date { get; set; }
        public Boolean? Deleted { get; set; }
        public int? Delete_Uid { get; set; }
        public Nullable<DateTime> Delete_Date { get; set; }
        [ForeignKey("MasterId")]
        public List<Trans_TrucksCounter> Trans_TrucksCounter { get; set; }
        [ForeignKey("MasterId")]
        public List<Trans_TruckAccessoriesDtl> Trans_TruckAccessoriesDtl { get; set; }
    }
    public class Trans_TrucksCounter
    {
        [Key]
        public int Id { get; set; }
        public int MasterId { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public decimal Value { get; set; }
        public string Notes { get; set; }
    }
    public class Trans_TruckAccessoriesDtl
    {
        [Key]
        public int Id { get; set; }
        public int  MasterId { get; set; }
        public int TransactionType { get; set; }
        [NotMapped]
        public string TransactionName { get; set; }
        public DateTime AccessoriesDate { get; set; } //تاريخ 
        [ForeignKey("AccessoriesId")]                  
        public Trans_TruckAccessories Trans_TruckAccessories { get; set; }
        public int? AccessoriesId { get; set; }
        [NotMapped]
        public string AccessoriesName { get; set; }
        public string Notes { get; set; }
        [ForeignKey("UserID")]
        public Priv_Users Priv_Users { get; set; }
        public int? UserID { get; set; }
        [NotMapped]
        public string UserName { get; set; }

    }
    public class Trans_Routes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Code { get; set; }
        public string NameA { get; set; }
        public string NameE { get; set; }
        [ForeignKey("CompanyId")]
        public Sys_Companies Sys_Companies { get; set; }
        public int CompanyId { get; set; }
        public string Notes { get; set; }
        public decimal? TotalKilometers { get; set; }
        public decimal? TotalHours { get; set; }
        public decimal? UnloadingAndLoadingTime { get; set; }
        public int? Create_Uid { get; set; }
        public Nullable<DateTime> Create_Date { get; set; }
        public int? Write_Uid { get; set; }
        public Nullable<DateTime> Write_Date { get; set; }
        public Boolean? Post { get; set; }
        public int? Post_Uid { get; set; }
        public Nullable<DateTime> Post_Date { get; set; }
        public Boolean? Deleted { get; set; }
        public int? Delete_Uid { get; set; }
        public Nullable<DateTime> Delete_Date { get; set; }
        [ForeignKey("MasterId")]
        public List<Trans_RoutesDtl> Trans_RoutesDtl { get; set; }

    }
    public class Trans_RoutesDtl
    {
        [Key]
        public int Id { get; set; }
        public int MasterId { get; set; }
        [ForeignKey("CityId")]              // From Location
        public Sys_Cities Sys_Cities { get; set; }
        public int? CityId { get; set; }
        [NotMapped]
        public string FromCity { get; set; }


        [ForeignKey("CitiesId")]                  // To Location
        public Sys_Cities City { get; set; }
        public int? CitiesId { get; set; }
        [NotMapped]
        public string ToCity { get; set; }

        public decimal Kilometers { get; set; }
        public decimal TripTime { get; set; }
        public string Notes { get; set; }
    }
    public class Trans_Operations
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public int MemberShipId { get; set; }
        [ForeignKey("CompanyId")]
        public Sys_Companies Sys_Companies { get; set; }
        [Required]
        public int CompanyId { get; set; }
        public string Code { get; set; }
        public string NameA { get; set; }
        public string NameE { get; set; }
        public string Color { get; set; }
        public bool IsInternal { get; set; } // اجراء داخلى فقط لا يمكن العميل من الاطلاع عليه
        public string Notes { get; set; }
        public int? Create_Uid { get; set; }
        public Nullable<DateTime> Create_Date { get; set; }
        public int? Write_Uid { get; set; }
        public Nullable<DateTime> Write_Date { get; set; }
        public Boolean? Post { get; set; }
        public int? Post_Uid { get; set; }
        public Nullable<DateTime> Post_Date { get; set; }
        public Boolean? Deleted { get; set; }
        public int? Delete_Uid { get; set; }
        public Nullable<DateTime> Delete_Date { get; set; }
    }
    public class Trans_Settings
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        [ForeignKey("CompanyId")]
        public Sys_Companies Sys_Companies { get; set; }
        public int CompanyId { get; set; }
        [ForeignKey("BranchId")]
        public Sys_Branches Sys_Branches { get; set; }
        public int BranchId { get; set; }
        public bool CreateTransferVoucher { get; set; }
        public bool ShowTypeLocation { get; set; }
        [ForeignKey("TransportExpensesAccountId")]
        public GL_ChartOfAccounts GL_ChartOfAccountsTransport { get; set; }
        public int? TransportExpensesAccountId { get; set; }
        public int? SerialType { get; set; } // 1 = Continuous Across all Jobs  2 = Separate by Job Type
        [ForeignKey("TransportAllowancesAccountId")]
        public GL_ChartOfAccounts GL_ChartOfAccountsTransportAllowances { get; set; }
        public int? TransportAllowancesAccountId { get; set; }
        [ForeignKey("DieselAllowancesAccountId")]
        public GL_ChartOfAccounts GL_ChartOfAccountsDieselAllowances { get; set; }
        public int? DieselAllowancesAccountId { get; set; }
        [ForeignKey("TransportIncomeAccountId")]
        public GL_ChartOfAccounts GL_ChartOfAccountsTransportIncome { get; set; }
        public int? TransportIncomeAccountId { get; set; }
        [ForeignKey("StoringIncomeAccountId")]
        public GL_ChartOfAccounts GL_ChartOfAccountsStoringIncome { get; set; }
        public int? StoringIncomeAccountId { get; set; }
        [ForeignKey("UnloadingAndLoadingIncomeAccountId")]
        public GL_ChartOfAccounts GL_ChartOfAccountsUnloadingAndLoadingIncome { get; set; }
        public int? UnloadingAndLoadingIncomeAccountId { get; set; }

        public int? IfWaybillBySupplierRedirectVoucherTo { get; set; }

        [ForeignKey("TransportationExpensesAccountForCurrentYearId")]
        public GL_ChartOfAccounts TransportationExpensesAccountForCurrentYear { get; set; }
        public int? TransportationExpensesAccountForCurrentYearId { get; set; }
        [ForeignKey("RouteWasChanged")]
        public Trans_Operations Trans_Operations { get; set; }
        public int? RouteWasChanged { get; set; }
        public string AttachmentPath { get; set; }
        public int? CloseContainerOn { get; set; } 
        public int? Create_Uid { get; set; }
        public Nullable<DateTime> Create_Date { get; set; }
        public int? Write_Uid { get; set; }
        public Nullable<DateTime> Write_Date { get; set; }
        public Boolean? Post { get; set; }
        public int? Post_Uid { get; set; }
        public Nullable<DateTime> Post_Date { get; set; }
        public Boolean? Deleted { get; set; }
        public int? Delete_Uid { get; set; }
        public Nullable<DateTime> Delete_Date { get; set; }
        [ForeignKey("MasterId")]
        public List<Trans_SettingsCustomerPricing> Trans_SettingsCustomerPricing { get; set; }
        [ForeignKey("MasterId")]
        public List<Trans_SettingsSupplierPricing> Trans_SettingsSupplierPricing { get; set; }
        [ForeignKey("MasterId")]
        public List<Trans_SettingsDriverPricing> Trans_SettingsDriverPricing { get; set; }
    }
    public class Trans_SettingsCustomerPricing
    {
        [Key]
        public int Id { get; set; }
        public int MasterId { get; set; }
        public int CustomerId { get; set; }
        [ForeignKey("RouteId")]
        public Trans_Routes Trans_Routes { get; set; }
        public int? RouteId { get; set; }
        [NotMapped]
        public string RouteName { get; set; }
        [ForeignKey("GoodsTypeId")]
        public CC_GoodsTypes CC_GoodsTypes { get; set; }
        public int? GoodsTypeId { get; set; }     
        [NotMapped]
        public string GoodsTypeName { get; set; }
        public decimal TransportPrice { get; set; }
        public int? PricingPolicy { get; set; } // (1- قيمة ثابتة  2- الاعتماد على الكمية         3- الاعتماد على الوزن  3- الاعتماد على المسافة)
        [NotMapped]
        public string PricingPolicyName { get; set; }
    }
    public class Trans_SettingsSupplierPricing
    {
        [Key]
        public int Id { get; set; }
        public int MasterId { get; set; }
        public int SupplierId { get; set; }
        [ForeignKey("RouteId")]
        public Trans_Routes Trans_Routes { get; set; }
        public int? RouteId { get; set; }
        [NotMapped]
        public string RouteName { get; set; }
        [ForeignKey("GoodsTypeId")]
        public CC_GoodsTypes CC_GoodsTypes { get; set; }
        public int? GoodsTypeId { get; set; }
        [NotMapped]
        public string GoodsTypeName { get; set; }
        public decimal TransportPrice { get; set; }
        public int? PricingPolicy { get; set; } // (1- قيمة ثابتة  2- الاعتماد على الكمية         3- الاعتماد على الوزن  3- الاعتماد على المسافة)
        [NotMapped]
        public string PricingPolicyName { get; set; }
    }
    public class Trans_SettingsDriverPricing
    {
        [Key]
        public int Id { get; set; }
        public int MasterId { get; set; }
        public int DriverId { get; set; }
        [ForeignKey("RouteId")]
        public Trans_Routes Trans_Routes { get; set; }
        public int? RouteId { get; set; }
        [NotMapped]
        public string RouteName { get; set; }
        [ForeignKey("GoodsTypeId")]
        public CC_GoodsTypes CC_GoodsTypes { get; set; }
        public int? GoodsTypeId { get; set; }
        [NotMapped]
        public string GoodsTypeName { get; set; }
        public decimal? TransportAllowances { get; set; }
        public decimal? DieselAllowances { get; set; } 

    }
    public class Trans_Waybill
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public int MemberShipId { get; set; }
        [ForeignKey("CompanyId")]
        public Sys_Companies Sys_Companies { get; set; }
        public int CompanyId { get; set; }
        [ForeignKey("BranchId")]
        public Sys_Branches Sys_Branches { get; set; }
        public int BranchId { get; set; }
        public string Code { get; set; }
        public UserControl_GHDate_NotNull NoteDate { get; set; }
        public string CustomerReference { get; set; }
        public int Source { get; set; }
        public int? GoodsTransport { get; set; } //(1:10) 1:Port-Yard  2:Port-Customer-Yard  3:Port-Customer-agent  4:Yard-Customer-Yard  5:Yard-Customer-agent  6:Yard-agent  7:Yard-Yard  8:Customer-Port  9:Customer-Customer   10:Port-Port
        [ForeignKey("JobBranchId")]
        public Sys_Branches Sys_JobBranches { get; set; }
        public int? JobBranchId { get; set; }
        [ForeignKey("JobTypeId")]
        public CC_JobTypes CC_JobTypes { get; set; }
         public int? JobTypeId { get; set; }
        [ForeignKey("JobId")]
        public CC_Jobs CC_Jobs { get; set; }
        public int? JobId { get; set; }
        public string TransPurchaseOrder { get; set; }
        public string CCPurchaseOrder { get; set; }
        [ForeignKey("JobtransBranchId")]
        public Sys_Branches Sys_TransBranches { get; set; }
        public int? JobtransBranchId { get; set; }
        [ForeignKey("TransJobTypeId")]
        public Trans_JobTypes Trans_JobTypes { get; set; }
        public int? TransJobTypeId { get; set; }

        [ForeignKey("TransJobId")]
        public Trans_Jobs Trans_Jobs { get; set; }
        public int? TransJobId { get; set; }

        [ForeignKey("WarehousesId")]
        public Trans_CustomerWarehouses Trans_CustomerWarehouses { get; set; }
        public int? WarehousesId { get; set; }

        public UserControl_GHDate_NotNull JobDate { get; set; }
        public UserControl_GHDate_NotNull TransJobDate { get; set; }
        public int? CustomerId { get; set; }
        public string MasterBLNO { get; set; }
        public string HouseBLNO { get; set; }
        public decimal? OriginalQuantity { get; set; }
        [ForeignKey("RouteId")]
        public Trans_Routes Trans_Routes { get; set; }
        public int? RouteId { get; set; }
        public decimal? CustomerPrice { get; set; }
        public string Receiver { get; set; }
        public string ReceiverAddress { get; set; }
        public string ReceiverTel { get; set; }
        public string ReceiverEmail { get; set; }
        public decimal? TransferredQuantity { get; set; }
        [ForeignKey("GoodsTypeId")]
        public CC_GoodsTypes CC_GoodsTypes { get; set; }
        public int? GoodsTypeId { get; set; } // نوع البضاعة
        public string GoodsDescription { get; set; } // وصف البضاعة  
        public string ContainerNo { get; set; }
        public decimal? Weight { get; set; }
        [ForeignKey("AgentId")]
        public CC_Agents CC_Agents { get; set; }
        public int? AgentId { get; set; } // الوكيل /الخط الملاحي
        public int? AllowDays { get; set; } //ايام السماح
        public int? CustomAllowDays { get; set; } //ايام السماح
        [ForeignKey("VesselId")]
        public CC_Vessels CC_Vessels { get; set; }
        public int? VesselId { get; set; } // الباخرة
        [ForeignKey("ArrivalPortId")]
        public Sys_Ports Sys_Ports { get; set; }

        public int? ArrivalPortId { get; set; }
        public string CustomsBAYAN { get; set; }
        public string DeliveryOrder { get; set; }
        [ForeignKey("JobLocationId")]
        public CC_Locations CC_Locations { get; set; }
        public int? JobLocationId { get; set; } // موقع المعاملة
        public int? TransportationType { get; set; }
        [ForeignKey("SupplierId")]
        public Sys_Partners Sys_Partners { get; set; }
        public int? SupplierId { get; set; }
        public decimal? TransportationFees { get; set; }
        public decimal? DieselAllowances { get; set; }
        public decimal? TransportAllowances { get; set; }
        [ForeignKey("DriverId")]
        public Trans_Drivers Trans_Drivers { get; set; }
        public int? DriverId { get; set; }
        [ForeignKey("TruckId")]
        public Trans_Trucks Trans_Trucks { get; set; }
        public int? TruckId { get; set; }
        public decimal? UnloadingAndLoading { get; set; }
        public decimal? StoringFees { get; set; }
        public decimal? MeterReadingAtTheStart { get; set; }
        public decimal? MeterReadingAtTheEnd { get; set; }
        public decimal? TotalDistance { get; set; }
        public string Notes { get; set; }
        public string FollowUpNotes { get; set; }
        public bool? IsaWaybillllowance { get; set; } // اثبات البدل
        [ForeignKey("DailyVoucherId")]
        public GL_DailyVoucher GL_DailyVoucher { get; set; }
        public int? DailyVoucherId { get; set; }
        public bool ISEmptyReturned { get; set; }
        public bool ISDocumentsReceived { get; set; }
        public bool IsLoad { get; set; }
        public bool ISDeliveredToCustomer { get; set; }
        public UserControl_GHDate_NotNull VesselArrivalDate { get; set; }
        public UserControl_GHDate_NotNull CustomFeesDate { get; set; }
        public UserControl_GHDate_NotNull AgentFeesDate { get; set; }
        public UserControl_GHDate_NotNull PortExitDate { get; set; }
        public UserControl_GHDate_NotNull CustomerLoadingDate { get; set; }
        public UserControl_GHDate_NotNull CustomerAccessDate { get; set; }
        public UserControl_GHDate_NotNull UnloadingGoodsDate { get; set; }
        public UserControl_GHDate_NotNull EmptyReturnedDate { get; set; }
        public UserControl_GHDate_NotNull DocumentsReceivedDate { get; set; }
        public bool HasInvoice { get; set; } // Connected with supplier invoice for transportation fees
        public int? InvoiceId { get; set; } // Connected with supplier invoice for transportation fees
        public bool HasCCInvoice { get; set; } // Connected with Transportation invoice or customer clearance invoice if waybill invoiced in one don't appear in other -- Related to customer
        public int? CCInvoiceId { get; set; }  // Connected with Transportation invoice or customer clearance invoice if waybill invoiced in one don't appear in other -- Related to customer
        public int? Create_Uid { get; set; }
        public Nullable<DateTime> Create_Date { get; set; }
        public int? Write_Uid { get; set; }
        public Nullable<DateTime> Write_Date { get; set; }
        public Boolean? Post { get; set; }
        public int? Post_Uid { get; set; }
        public Nullable<DateTime> Post_Date { get; set; }
        public Boolean? Deleted { get; set; }
        public int? Delete_Uid { get; set; }
        public Nullable<DateTime> Delete_Date { get; set; }
        [ForeignKey("MasterId")]
        public List<Trans_WaybillDtl> Trans_WaybillDtl { get; set; }
        [ForeignKey("MasterId")]
        public List<Trans_WaybillAttachments> Trans_WaybillAttachments { get; set; }
        [ForeignKey("MasterId")]
        public List<Trans_ServicesDuties> Trans_ServicesDuties { get; set; }
    }
    public class Trans_WaybillDtl
    {
        [Key]
        public int Id { get; set; }
        public int MasterId { get; set; }
        [ForeignKey("OperationId")]
        public Trans_Operations Trans_Operations { get; set; }
        public int OperationId { get; set; }
        [NotMapped]
        public string OperationName { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; }
        public string Notes { get; set; }
        [DataType(DataType.Date)]
        public DateTime InsertionDate { get; set; }
        public int? UserId { get; set; }
        [NotMapped]
        public string UserName { get; set; }
    }
    public class Trans_ServicesDuties
    {
        [Key]
        public int Id { get; set; }
        public int MasterId { get; set; }
   
        [ForeignKey("ServiceId")]
        public Yard_Services Yard_Services { get; set; }
        [NotMapped]
        public string ServiceName { get; set; }
        public int ServiceId { get; set; }
        public decimal Value { get; set; } // سعر الخدمة يحسب اذا كان هناك تسعير لها ان لم يكن يتم اختيار السعر الافتراضي للخدمة
    }
    public class Trans_Invoices
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        [ForeignKey("CompanyId")]
        public Sys_Companies Sys_Companies { get; set; }
        public int CompanyId { get; set; }
        [ForeignKey("BranchId")]
        public Sys_Branches Sys_Branches { get; set; }
        public int BranchId { get; set; }
        [ForeignKey("FinancialYearId")]
        public GL_FinancialYears GL_FinancialYears { get; set; }
        public int FinancialYearId { get; set; }
        public string Code { get; set; }
        public UserControl_GHDate_NotNull TransactDate { get; set; }
        [ForeignKey("CustomerId")]
        public Sys_Partners Sys_Partners { get; set; }
        public int? CustomerId { get; set; }
        public decimal TransportationFees { get; set; }
        public decimal StoringFees { get; set; }
        public decimal UnloadingAndLoading { get; set; }
        public decimal ServicesFees { get; set; }
        public decimal Total { get; set; }
        public decimal? Taxes { get; set; }
        public decimal Net { get; set; }
        public decimal Remain { get; set; }
        [ForeignKey("DailyVoucherId")]
        public GL_DailyVoucher GL_DailyVoucher { get; set; }
        public int DailyVoucherId { get; set; }
        public string Notes { get; set; }
        public int? Create_Uid { get; set; }
        public Nullable<DateTime> Create_Date { get; set; }
        public int? Write_Uid { get; set; }
        public Nullable<DateTime> Write_Date { get; set; }
        public Boolean? Post { get; set; }
        public int? Post_Uid { get; set; }
        public Nullable<DateTime> Post_Date { get; set; }
        public Boolean? Deleted { get; set; }
        public int? Delete_Uid { get; set; }
        public Nullable<DateTime> Delete_Date { get; set; }
        [ForeignKey("MasterId")]
        public List<Trans_InvoicesDtl> Trans_InvoicesDtl { get; set; }
        [ForeignKey("MasterId")]
        public List<Trans_InvoicesTaxes> Trans_InvoicesTaxes { get; set; }
    }
    public class Trans_InvoicesDtl
    {
        [Key]
        public int Id { get; set; }
        public int MasterId { get; set; }
        [ForeignKey("WaybillId")]
        public Trans_Waybill Trans_Waybill { get; set; }
        public int? WaybillId { get; set; }
        [NotMapped]
        public string WaybillCode { get; set; }
        [DataType(DataType.Date)]
        public DateTime? WaybillDate { get; set; }
        public string ContainerNo { get; set; }
        [ForeignKey("GoodsTypeId")]
        public CC_GoodsTypes CC_GoodsTypes { get; set; }
        public int? GoodsTypeId { get; set; } // نوع البضاعة
        [NotMapped]
        public string GoodsTypeName { get; set; }
        public string GoodsDescription { get; set; } // وصف البضاعة  
        public decimal TransportationFees { get; set; }
        public decimal StoringFees { get; set; }
        public decimal UnloadingAndLoading { get; set; }
        public decimal ServicesFees { get; set; }
        public decimal Total { get; set; }
    }
    public class Trans_InvoicesTaxes
    {
        [Key]
        public int Id { get; set; }
        public int MasterId { get; set; }
        [ForeignKey("TaxId")]
        public Sys_Taxes Sys_Taxes { get; set; }
        public int? TaxId { get; set; }
        [NotMapped]
        public string TaxName { get; set; }
        public int TaxType { get; set; }
        public bool ApplyBeforDiscount { get; set; }
        public decimal Value { get; set; }
        public decimal AppliedValue { get; set; }
        public string Notes { get; set; }
    }
    public class Trans_InvoicePaid
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public int MemberShipId { get; set; }
        [ForeignKey("CompanyId")]
        public Sys_Companies Sys_Companies { get; set; }
        public int CompanyId { get; set; }
        [ForeignKey("BranchId")]
        public Sys_Branches Sys_Branches { get; set; }
        public int BranchId { get; set; }
        [ForeignKey("FinancialYearId")]
        public GL_FinancialYears GL_FinancialYears { get; set; }
        public int FinancialYearId { get; set; }
        public int PayWay { get; set; }  // 1 Cash 2 check 3 Transfer
        public string Code { get; set; }
        public string PaperCode { get; set; }
        public UserControl_GHDate_NotNull TransactDate { get; set; }
        public string PayPerson { get; set; }
        public string PayPersonTel { get; set; }
        public string PayPersonAddress { get; set; }
        [ForeignKey("DebitAccountId")]
        public GL_ChartOfAccounts GL_ChartOfAccounts { get; set; }
        public int DebitAccountId { get; set; }
        [ForeignKey("BankId")]
        public GL_Banks GL_Banks { get; set; }
        public int? BankId { get; set; }

        [ForeignKey("SalesManId")]
        public HR_Employees HR_Employees { get; set; }
        public int? SalesManId { get; set; }
        public string CheckTransferNo { get; set; }
        public bool CheckUnderCollection { get; set; }
        public decimal? BankFees { get; set; }
        public UserControl_GHDate_NotNull CheckTransferDate { get; set; }
        public string Beneficiary { get; set; }
        public string City { get; set; }
        public decimal Total { get; set; }
        public decimal? DifferanceInLocal { get; set; }  // فرق العملة بين سعر الصرف اثناء اصدار الفاتورة وسعر الصرف اثناء اصدار السداد

        [ForeignKey("PartnerId")]
        public Sys_Partners Sys_Partners { get; set; }
        public int? PartnerId { get; set; }

        [ForeignKey("CurrencyId")]
        public Sys_Currencies Sys_Currencies { get; set; }
        public int? CurrencyId { get; set; }
        public float? Rate { get; set; }

        [ForeignKey("DailyVoucherId")]
        public GL_DailyVoucher GL_DailyVoucher { get; set; }
        public int DailyVoucherId { get; set; }
        public string Notes { get; set; }
        public int? Create_Uid { get; set; }
        public Nullable<DateTime> Create_Date { get; set; }
        public int? Write_Uid { get; set; }
        public Nullable<DateTime> Write_Date { get; set; }
        public Boolean? Post { get; set; }
        public int? Post_Uid { get; set; }
        public Nullable<DateTime> Post_Date { get; set; }
        public Boolean? Deleted { get; set; }
        public int? Delete_Uid { get; set; }
        public Nullable<DateTime> Delete_Date { get; set; }

        [ForeignKey("MasterId")]
        public List<Trans_InvoicePaidDtl> Trans_InvoicePaidDtl { get; set; }


    }
    public class Trans_InvoicePaidDtl
    {
        //لابد ان تكون كل الفواتير الموجودة بالتفاصيل بنفس عملة السند
        [Key]
        public int Id { get; set; }
        public int MasterId { get; set; }
        [ForeignKey("InvoiceId")]
        public Trans_Invoices CC_Invoices { get; set; }
        public int InvoiceId { get; set; }
        [NotMapped]
        public string InvoiceCode { get; set; }

        [DataType(DataType.Date)]
        public DateTime InvoiceDate { get; set; }
        public decimal Net { get; set; }
        public decimal Paid { get; set; }
        public float Rate { get; set; }
        public decimal Remain { get; set; }
        public decimal PaidValue { get; set; } // قيمة السداد
        [NotMapped]
        public decimal DiffInUpdate { get; set; }// الفرق في القيمة في حاله التعديل
        [NotMapped]
        public decimal OldValue { get; set; }
        public string Notes { get; set; }
    }
    public class Trans_WaybillAttachments
    {
        [Key]
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public int MasterId { get; set; }
        [NotMapped]
        public string Path { get; set; }
        public string FileName { get; set; }
        public string Description { get; set; }
    }
    public class Trans_SupplierInvoices
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        [ForeignKey("CompanyId")]
        public Sys_Companies Sys_Companies { get; set; }
        public int CompanyId { get; set; }
        [ForeignKey("BranchId")]
        public Sys_Branches Sys_Branches { get; set; }
        public int BranchId { get; set; }
        [ForeignKey("FinancialYearId")]
        public GL_FinancialYears GL_FinancialYears { get; set; }
        public int FinancialYearId { get; set; }
        public string Code { get; set; }
        public UserControl_GHDate_NotNull TransactDate { get; set; }
        [ForeignKey("SupplierId")]
        public Sys_Partners Sys_Partners { get; set; }
        public int? SupplierId { get; set; }
        public decimal Total { get; set; }
        public decimal? Taxes { get; set; }
        public decimal Net { get; set; }
        public decimal Remain { get; set; }
        [ForeignKey("DailyVoucherId")]
        public GL_DailyVoucher GL_DailyVoucher { get; set; }
        public int DailyVoucherId { get; set; }
        public string Notes { get; set; }
        public int? Create_Uid { get; set; }
        public Nullable<DateTime> Create_Date { get; set; }
        public int? Write_Uid { get; set; }
        public Nullable<DateTime> Write_Date { get; set; }
        public Boolean? Post { get; set; }
        public int? Post_Uid { get; set; }
        public Nullable<DateTime> Post_Date { get; set; }
        public Boolean? Deleted { get; set; }
        public int? Delete_Uid { get; set; }
        public Nullable<DateTime> Delete_Date { get; set; }
        [ForeignKey("MasterId")]
        public List<Trans_SupplierInvoicesDtl> Trans_SupplierInvoicesDtl { get; set; }
        [ForeignKey("MasterId")]
        public List<Trans_SupplierInvoicesTaxes> Trans_SupplierInvoicesTaxes { get; set; }
    }
    public class Trans_SupplierInvoicesDtl
    {
        [Key]
        public int Id { get; set; }
        public int MasterId { get; set; }
        [ForeignKey("WaybillId")]
        public Trans_Waybill Trans_Waybill { get; set; }
        public int? WaybillId { get; set; }
        [NotMapped]
        public string WaybillCode { get; set; }
        [DataType(DataType.Date)]
        public DateTime? WaybillDate { get; set; }
        public string ContainerNo { get; set; }
        [ForeignKey("GoodsTypeId")]
        public CC_GoodsTypes CC_GoodsTypes { get; set; }
        public int? GoodsTypeId { get; set; } // نوع البضاعة
        [NotMapped]
        public string GoodsTypeName { get; set; }
        [ForeignKey("RouteId")]
        public Trans_Routes Trans_Routes { get; set; }
        public int? RouteId { get; set; } // نوع البضاعة
        [NotMapped]
        public string RouteName { get; set; }
        public string GoodsDescription { get; set; } // وصف البضاعة  
        public decimal TransportationFees { get; set; }
    }
    public class Trans_SupplierInvoicesTaxes
    {
        [Key]
        public int Id { get; set; }
        public int MasterId { get; set; }
        [ForeignKey("TaxId")]
        public Sys_Taxes Sys_Taxes { get; set; }
        public int? TaxId { get; set; }
        [NotMapped]
        public string TaxName { get; set; }
        public int TaxType { get; set; }
        public bool ApplyBeforDiscount { get; set; }
        public decimal Value { get; set; }
        public decimal AppliedValue { get; set; }
        public string Notes { get; set; }
    }
    public class Trans_SupplierInvoicePaid
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public int MemberShipId { get; set; }
        [ForeignKey("CompanyId")]
        public Sys_Companies Sys_Companies { get; set; }
        public int CompanyId { get; set; }
        [ForeignKey("BranchId")]
        public Sys_Branches Sys_Branches { get; set; }
        public int BranchId { get; set; }
        [ForeignKey("FinancialYearId")]
        public GL_FinancialYears GL_FinancialYears { get; set; }
        public int FinancialYearId { get; set; }
        public int PayWay { get; set; }  // 1 Cash 2 check 3 Transfer
        public string Code { get; set; }
        public string PaperCode { get; set; }
        public UserControl_GHDate_NotNull TransactDate { get; set; }
        public string PayPerson { get; set; }
        public string PayPersonTel { get; set; }
        public string PayPersonAddress { get; set; }
        [ForeignKey("CreditAccountId")]
        public GL_ChartOfAccounts GL_ChartOfAccounts { get; set; }
        public int CreditAccountId { get; set; }
        [ForeignKey("BankId")]
        public GL_Banks GL_Banks { get; set; }
        public int? BankId { get; set; }

        [ForeignKey("SalesManId")]
        public HR_Employees HR_Employees { get; set; }
        public int? SalesManId { get; set; }
        public string CheckTransferNo { get; set; }
        public bool CheckUnderCollection { get; set; }
        public decimal? BankFees { get; set; }
        public UserControl_GHDate_NotNull CheckTransferDate { get; set; }
        public string Beneficiary { get; set; }
        public string City { get; set; }
        public decimal Total { get; set; }
        public decimal? DifferanceInLocal { get; set; }  // فرق العملة بين سعر الصرف اثناء اصدار الفاتورة وسعر الصرف اثناء اصدار السداد

        [ForeignKey("PartnerId")]
        public Sys_Partners Sys_Partners { get; set; }
        public int? PartnerId { get; set; }

        [ForeignKey("CurrencyId")]
        public Sys_Currencies Sys_Currencies { get; set; }
        public int? CurrencyId { get; set; }
        public float? Rate { get; set; }

        [ForeignKey("DailyVoucherId")]
        public GL_DailyVoucher GL_DailyVoucher { get; set; }
        public int DailyVoucherId { get; set; }
        public string Notes { get; set; }
        public int? Create_Uid { get; set; }
        public Nullable<DateTime> Create_Date { get; set; }
        public int? Write_Uid { get; set; }
        public Nullable<DateTime> Write_Date { get; set; }
        public Boolean? Post { get; set; }
        public int? Post_Uid { get; set; }
        public Nullable<DateTime> Post_Date { get; set; }
        public Boolean? Deleted { get; set; }
        public int? Delete_Uid { get; set; }
        public Nullable<DateTime> Delete_Date { get; set; }

        [ForeignKey("MasterId")]
        public List<Trans_SupplierInvoicePaidDtl> Trans_SupplierInvoicePaidDtl { get; set; }


    }
    public class Trans_SupplierInvoicePaidDtl
    {
        //لابد ان تكون كل الفواتير الموجودة بالتفاصيل بنفس عملة السند
        [Key]
        public int Id { get; set; }
        public int MasterId { get; set; }
        [ForeignKey("InvoiceId")]
        public Trans_SupplierInvoices Trans_Invoices { get; set; }
        public int InvoiceId { get; set; }
        [NotMapped]
        public string InvoiceCode { get; set; }

        [DataType(DataType.Date)]
        public DateTime InvoiceDate { get; set; }
        public decimal Net { get; set; }
        public decimal Paid { get; set; }
        public float Rate { get; set; }
        public decimal Remain { get; set; }
        public decimal PaidValue { get; set; } // قيمة السداد
        [NotMapped]
        public decimal DiffInUpdate { get; set; }// الفرق في القيمة في حاله التعديل
        [NotMapped]
        public decimal OldValue { get; set; }
        public string Notes { get; set; }
    }
    public class Trans_CustomerWarehouses
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("CompanyId")]
        public Sys_Companies Sys_Companies { get; set; }
        public int CompanyId { get; set; }

        [ForeignKey("CustomerID")]
        public Sys_Partners Sys_Partners { get; set; }
        public int CustomerID { get; set; }
        public string Code { get; set; }
        public string NameA { get; set; }
        public string NameE { get; set; }
        public string Address { get; set; }
        public string Manager { get; set; } // المدير المسؤال
        public string Notes { get; set; }
        public string Telephone { get; set; }
    }
    public class Trans_JobTypes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Code { get; set; }
        public string NameA { get; set; }
        public string NameE { get; set; }
        //public int SerialType { get; set; } // متصل 1 منفصل حسب السنه المالية 2
        public string SymbolBeforeSerial { get; set; } // رمز قبل السريال
        //public bool UseFinantialYearInSerial { get; set; }
        public bool IsDefault { get; set; }
        public string AttachmentPath { get; set; }
        public string ImagesPath { get; set; }
       
        public string Notes { get; set; }
        public int? Create_Uid { get; set; }
        public Nullable<DateTime> Create_Date { get; set; }
        public int? Write_Uid { get; set; }
        public Nullable<DateTime> Write_Date { get; set; }
        public Boolean? Post { get; set; }
        public int? Post_Uid { get; set; }
        public Nullable<DateTime> Post_Date { get; set; }
        public Boolean? Deleted { get; set; }
        public int? Delete_Uid { get; set; }
        public Nullable<DateTime> Delete_Date { get; set; }
    }
    public class Trans_Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Code { get; set; }
        [ForeignKey("CompanyId")]
        public Sys_Companies Sys_Companies { get; set; }
        public int CompanyId { get; set; }
        [ForeignKey("BranchId")]
        public Sys_Branches Sys_Branches { get; set; }
        public int BranchId { get; set; }
        public string Notes { get; set; }
        public UserControl_GHDate_NotNull OrderDate { get; set; }
        public int? Create_Uid { get; set; }
        public Nullable<DateTime> Create_Date { get; set; }
        public int? Write_Uid { get; set; }
        public Nullable<DateTime> Write_Date { get; set; }
        public Boolean? Post { get; set; }
        public int? Post_Uid { get; set; }
        public Nullable<DateTime> Post_Date { get; set; }
        public Boolean? Deleted { get; set; }
        public int? Delete_Uid { get; set; }
      public Nullable<DateTime> Delete_Date { get; set; }
    }
    public class Trans_OrderDtl
    {

        [Key]
        public int Id { get; set; }
        public int MasterId { get; set; }

        public int Source { get; set; }
        [NotMapped]
        public string Text { get; set; }
        [ForeignKey("JobTypesId")]
        public Trans_JobTypes Trans_JobTypes { get; set; }
        public int? JobTypesId { get; set; }
        [NotMapped]
        public string JobTypesName { get; set; }

        [ForeignKey("JobId")]
        public CC_Jobs CC_Jobs { get; set; }
        public int? JobId { get; set; }
        [NotMapped]
        public string JobName { get; set; }
        public string CustomerName { get; set; }

        public string ContainerNo { get; set; }
        [ForeignKey("RouteId")]
        public Trans_Routes Trans_Routes { get; set; }
        public int? RouteId { get; set; }
        [NotMapped]
        public string RouteName { get; set; }
        public string DriverName { get; set; }
        public string TruckName { get; set; }
    }
    public class Trans_Jobs
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [ForeignKey("CompanyId")]
        public Sys_Companies Sys_Companies { get; set; }
        public int CompanyId { get; set; }

        [ForeignKey("BranchId")]
        public Sys_Branches Sys_Branches { get; set; }
        public int BranchId { get; set; }

        [ForeignKey("FinancialYearId")]
        public GL_FinancialYears GL_FinancialYears { get; set; }
        public int FinancialYearId { get; set; }


        // Header Data Without Tab
        [ForeignKey("JobTypeId")]
        public Trans_JobTypes Trans_JobTypes { get; set; }
        public int JobTypeId { get; set; } // Every Type have serial like journal type in voucher page
        public string Code { get; set; } //There found function to calculate the code depend on setting in JobTypes Form
        public UserControl_GHDate_NotNull TransactDate { get; set; } //تاريخ المعاملة

        [ForeignKey("CustomerId")]
        public Sys_Partners Sys_Partners { get; set; }
        public int CustomerId { get; set; }
        public string CustomerReference { get; set; } // مرجع العميل
        public string PurchaseOrder { get; set; } // امر الشراء

        public int? HoldIn { get; set; } //(1:3) 1:Port 2:Yard 3:Deliver
        [NotMapped]
        public string HoldName { get; set; }
        public string MasterBLNO { get; set; } // البوليصة الرئيسية
        public string HouseBLNO { get; set; } // البوليصة الداخلية

      
       
        public bool? IsInspection { get; set; } // تمت المعاينة
       
        public bool? IsPaid { get; set; } // تم السداد
       
        public bool? IsLoaded { get; set; } // تم التحميل
       
        public int? Create_Uid { get; set; }
        public Nullable<DateTime> Create_Date { get; set; }
        public int? Write_Uid { get; set; }
        public Nullable<DateTime> Write_Date { get; set; }
        public Boolean? Post { get; set; }
        public int? Post_Uid { get; set; }
        public Nullable<DateTime> Post_Date { get; set; }
        public Boolean? Deleted { get; set; }
        public int? Delete_Uid { get; set; }
        public Nullable<DateTime> Delete_Date { get; set; }

        //Goods Tab  البضاعة
        [ForeignKey("MasterId")]
        public List<Trans_JobGoods> Trans_JobGoods { get; set; }

        //Containers Tab  الحاويات
        [ForeignKey("MasterId")]
        public List<Trans_JobContainers> Trans_JobContainers { get; set; }

        //Receipt Documents Tab   المستندات المستلمة
        [ForeignKey("MasterId")]
        public List<Trans_JobDocuments> Trans_JobDocuments { get; set; }

    

        [ForeignKey("MasterId")]
        public List<Trans_JobGallery> Trans_JobGallery { get; set; }

        [ForeignKey("MasterId")]
        public List<Trans_JobAttachments> Trans_JobAttachments { get; set; }
    }
    public class Trans_JobGoods
    {
        [Key]
        public int Id { get; set; }
        public int MasterId { get; set; }

        [ForeignKey("GoodsTypeId")]
        public CC_GoodsTypes CC_GoodsTypes { get; set; }
        public int GoodsTypeId { get; set; } // نوع البضاعة
        [NotMapped]
        public string GoodsTypeName { get; set; }
        public decimal Quantity { get; set; }
        public decimal? NoOfPackages { get; set; } // عدد الطرود

        [ForeignKey("PackagesUnitId")]
        public CC_Units CC_Units { get; set; }
        public int? PackagesUnitId { get; set; } // نوع الطرود
        [NotMapped]
        public string PackagesUnitName { get; set; }
        public decimal? GrossWeight { get; set; } // الوزن القائم
        public decimal? NetWeight { get; set; } // الوزن الصافي
        public string Notes { get; set; }

    }
    public class Trans_JobContainers
    {
        [Key]
        public int Id { get; set; }
        public int MasterId { get; set; }
        public string ContainerNo { get; set; } // رقم الحاوية

        [ForeignKey("ContainerTypeId")]
        public CC_GoodsTypes CC_GoodsTypes { get; set; }
        public int ContainerTypeId { get; set; } // نوع الحاوية
        [NotMapped]
        public string ContainerTypeName { get; set; }
        public decimal? NoOfPackages { get; set; } // عدد الطرود
        public decimal? GrossWeight { get; set; } // الوزن القائم
        public decimal? NetWeight { get; set; } // الوزن الصافي
        public string Destination { get; set; } // الوجهة
        public bool IsTransfer { get; set; }
        public int? RouteId { get; set; }
        [NotMapped]
        public string TransRoutesName { get; set; }

        [ForeignKey("WarehousesId")]
        public Trans_CustomerWarehouses Trans_CustomerWarehouses { get; set; }
        public int ? WarehousesId { get; set; }
        public string WarehouseName { get; set; }
    }
    public class Trans_JobDocuments
    {
        [Key]
        public int Id { get; set; }
        public int MasterId { get; set; }

        [ForeignKey("DocumentTypeId")]
        public CC_DocumentsTypes CC_DocumentsTypes { get; set; }
        public int DocumentTypeId { get; set; } // نوع المستند
        [NotMapped]
        public string DocumentTypeName { get; set; }
        public int Type { get; set; } // 1 Original  2- Image
        [NotMapped]
        public string TypeName { get; set; }
        public int Numbers { get; set; } // One default with new row
        public string Notes { get; set; }

    }
    public class Trans_JobGallery
    {
        [Key]
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public int MasterId { get; set; }
        [NotMapped]
        public string Path { get; set; }
        public string FileName { get; set; }
        public string Description { get; set; }
    }
    public class Trans_JobAttachments
    {
        [Key]
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }
        public int MasterId { get; set; }
        [NotMapped]
        public string Path { get; set; }
        public string FileName { get; set; }
        public string Description { get; set; }
    }
   
    public class Trans_TruckAccessories
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public int MemberShipId { get; set; }
        [ForeignKey("CompanyId")]
        public Sys_Companies Sys_Companies { get; set; }
        [Required]
        public int CompanyId { get; set; }
        public string Code { get; set; }
        public string NameA { get; set; }
        public string NameE { get; set; }
       
        public string Notes { get; set; }
        public int? Create_Uid { get; set; }
        public Nullable<DateTime> Create_Date { get; set; }
        public int? Write_Uid { get; set; }
        public Nullable<DateTime> Write_Date { get; set; }
        public Boolean? Post { get; set; }
        public int? Post_Uid { get; set; }
        public Nullable<DateTime> Post_Date { get; set; }
        public Boolean? Deleted { get; set; }
        public int? Delete_Uid { get; set; }
        public Nullable<DateTime> Delete_Date { get; set; }
    }
    public class Trans_DriversTransfer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public int MemberShipId { get; set; }
        [ForeignKey("CompanyId")]
        public Sys_Companies Sys_Companies { get; set; }
        public int CompanyId { get; set; }
        public string Code { get; set; }
        public UserControl_GHDate_NotNull TransactDate { get; set; }
        [ForeignKey("TrucksId")]
        public Trans_Trucks Trans_Trucks { get; set; }
        public int? TrucksId { get; set; }
        [ForeignKey("CurrentDriversId")]
        public Trans_Drivers Trans_Drivers { get; set; }
        public int? CurrentDriversId { get; set; }
        [ForeignKey("TransferDriversId")]
        public Trans_Drivers TransDriversTransfer { get; set; }
        public int? TransferDriversId { get; set; }
        public string Notes { get; set; }
        public int? Create_Uid { get; set; }
        public Nullable<DateTime> Create_Date { get; set; }
        public int? Write_Uid { get; set; }
        public Nullable<DateTime> Write_Date { get; set; }
        public Boolean? Post { get; set; }
        public int? Post_Uid { get; set; }
        public Nullable<DateTime> Post_Date { get; set; }
        public Boolean? Deleted { get; set; }
        public int? Delete_Uid { get; set; }
        public Nullable<DateTime> Delete_Date { get; set; }
    }
    public class Trans_DriversAllowanceReasons
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        [ForeignKey("CompanyId")]
        public Sys_Companies Sys_Companies { get; set; }
        public int CompanyId { get; set; }
        public string Code { get; set; }
        public string NameA { get; set; }
        public string NameE { get; set; }
        public decimal DefaultPrice { get; set; }
        public bool LoadOnCustomer { get; set; }
        public string Notes { get; set; }
        public int? Create_Uid { get; set; }
        public Nullable<DateTime> Create_Date { get; set; }
        public int? Write_Uid { get; set; }
        public Nullable<DateTime> Write_Date { get; set; }
        public Boolean? Post { get; set; }
        public int? Post_Uid { get; set; }
        public Nullable<DateTime> Post_Date { get; set; }
        public Boolean? Deleted { get; set; }
        public int? Delete_Uid { get; set; }
        public Nullable<DateTime> Delete_Date { get; set; }
    }
    public class Trans_AdditionalDriversAllowance
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Code { get; set; }
        public UserControl_GHDate_NotNull Date { get; set; } //تاريخ 
        [ForeignKey("CompanyId")]
        public Sys_Companies Sys_Companies { get; set; }
        public int CompanyId { get; set; }
        [ForeignKey("DriverId")]
        public Trans_Drivers Trans_Drivers { get; set; }
        public int? DriverId { get; set; }
        public string Notes { get; set; }
        public decimal ? Total { get; set; }
        public int? Create_Uid { get; set; }
        public Nullable<DateTime> Create_Date { get; set; }
        public int? Write_Uid { get; set; }
        public Nullable<DateTime> Write_Date { get; set; }
        public Boolean? Post { get; set; }
        public int? Post_Uid { get; set; }
        public Nullable<DateTime> Post_Date { get; set; }
        public Boolean? Deleted { get; set; }
        public int? Delete_Uid { get; set; }
        public Nullable<DateTime> Delete_Date { get; set; }
        [ForeignKey("MasterId")]
        public List<Trans_AdditionalDriversAllowanceDtl> Trans_AdditionalDriversAllowanceDtl { get; set; }
    }
    public class Trans_AdditionalDriversAllowanceDtl
    {
        [Key]
        public int Id { get; set; }
        public int MasterId { get; set; }
        [ForeignKey("WaybillId")]
        public Trans_Waybill Trans_Waybill { get; set; }
        public int? WaybillId { get; set; }
        [NotMapped]
        public string WaybillCode { get; set; }

        [ForeignKey("ReasonsId")]
        public Trans_DriversAllowanceReasons Trans_DriversAllowanceReasons { get; set; }
        public int? ReasonsId { get; set; }
        [NotMapped]
        public string ReasonsName { get; set; }
        public string Notes { get; set; }
        public decimal  Price { get; set; }
    }
    public class Trans_DriversAllowance 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        [ForeignKey("CompanyId")]
        public Sys_Companies Sys_Companies { get; set; }
        public int CompanyId { get; set; }
        [ForeignKey("BranchId")]
        public Sys_Branches Sys_Branches { get; set; }
        public int BranchId { get; set; }
        [ForeignKey("DriverId")]
        public Trans_Drivers Trans_Drivers { get; set; }
        public int DriverId { get; set; }
        public string Code { get; set; }
        public UserControl_GHDate_NotNull TransactDate { get; set; }
        public decimal? Total { get; set; }
        [ForeignKey("DailyVoucherId")]
        public GL_DailyVoucher GL_DailyVoucher { get; set; }
        public int DailyVoucherId { get; set; }
        public string Notes { get; set; }
        public int? Create_Uid { get; set; }
        public Nullable<DateTime> Create_Date { get; set; }
        public int? Write_Uid { get; set; }
        public Nullable<DateTime> Write_Date { get; set; }
        public Boolean? Post { get; set; }
        public int? Post_Uid { get; set; }
        public Nullable<DateTime> Post_Date { get; set; }
        public Boolean? Deleted { get; set; }
        public int? Delete_Uid { get; set; }
        public Nullable<DateTime> Delete_Date { get; set; }
        [ForeignKey("MasterId")]
        public List<Trans_DriversAllowanceDtl> Trans_DriversAllowanceDtl { get; set; }

    }
    public class Trans_DriversAllowanceDtl
    {
        [Key]
        public int Id { get; set; }
        public int MasterId { get; set; }
        [ForeignKey("WaybillId")]
        public Trans_Waybill Trans_Waybill { get; set; }
        public int? WaybillId { get; set; }
        [NotMapped]
        public string WaybillCode { get; set; }
        [DataType(DataType.Date)]
        public DateTime? WaybillDate { get; set; }
        public string ContainerNo { get; set; }
        [ForeignKey("CustomerId")]
        public Sys_Partners Sys_Partners { get; set; }
        public int? CustomerId { get; set; } 
        [NotMapped]
        public string CustomerName { get; set; }
        [ForeignKey("RouteId")]
        public Trans_Routes Trans_Routes { get; set; }
        public int? RouteId { get; set; } 
        [NotMapped]
        public string RouteName { get; set; }
        public decimal ? DieselAllowances { get; set; } // بدل ديزل
        public decimal ? TransportAllowances { get; set; } // بدل طريق  
        public decimal?Extracost { get; set; } //تكلفه اضافية
        public bool IsDriversAllowance { get; set; } // اثبات البدل للسائق
        public decimal ? Total{ get ; set ; }
        
    }
}

