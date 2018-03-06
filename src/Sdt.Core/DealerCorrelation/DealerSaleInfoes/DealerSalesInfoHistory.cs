using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;

namespace Sdt.DealerCorrelation.DealerSaleInfoes
{
    [Table("DealerSalesInfoHistory")]
    public partial class DealerSalesInfoHistory : AuditedEntity
    {
        public int RecordId { get; set; }

        public DealerSalesInfo DealerSalesInfo { get; set; }
        public int BranchId { get; set; }
        public int DealerId { get; set; }

        [StringLength(SdtConsts.DefaultStringValueLength)]
        public string SalesHotline { get; set; }

        [StringLength(SdtConsts.DefaultStringValueLength)]
        public string ShopProperty { get; set; }

        [StringLength(SdtConsts.DefaultStringValueLength)]
        public string ShopLevel { get; set; }

        public DcsBaseDataStatus Status { get; set; }

        [StringLength(DealerSalesInfo.RemarkLength)]
        public string Remark { get; set; }

        [StringLength(SdtConsts.DefaultNameLength)]
        public string CreatorName { get; set; }

        [StringLength(SdtConsts.DefaultNameLength)]
        public string ModifierName { get; set; }

        public int? FilerId { get; set; }

        [StringLength(SdtConsts.DefaultNameLength)]
        public string FilerName { get; set; }

        public DateTime? FileTime { get; set; }

        public DateTime? SubscriptionTime { get; set; }

        [StringLength(SdtConsts.DefaultNameLength)]
        public string GroupName { get; set; }

        public DateTime? DegradeTime { get; set; }

        public DateTime? CancellationTime { get; set; }

        [StringLength(SdtConsts.DefaultLongStringValueLength)]
        public string Address { get; set; }

        [StringLength(SdtConsts.DefaultStringValueLength)]
        public string ZipCode { get; set; }

        [StringLength(SdtConsts.DefaultShortStringValueLength)]
        public string Fax { get; set; }

        [StringLength(SdtConsts.DefaultShortStringValueLength)]
        public string Email { get; set; }
    }
}
