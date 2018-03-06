using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;
using Sdt.Common;

namespace Sdt.DealerCorrelation.DealerSaleInfoes
{
    [Table("DealerSalesInfo")]
    public partial class DealerSalesInfo : AuditedEntity, IRowVersion
    {
        public const int RemarkLength = 500;

        public int BranchId { get; set; }
        public int DealerId { get; set; }

        public Dealer Dealer { get; set; }

        [StringLength(SdtConsts.DefaultStringValueLength)]
        public string SalesHotline { get; set; }

        [StringLength(SdtConsts.DefaultStringValueLength)]
        public string ShopProperty { get; set; }

        [StringLength(SdtConsts.DefaultStringValueLength)]
        public string ShopLevel { get; set; }

        [StringLength(SdtConsts.DefaulCodeLength)]
        public string ErpServiceCode { get; set; }
        public DcsBaseDataStatus Status { get; set; }

        [StringLength(RemarkLength)]
        public string Remark { get; set; }

        [StringLength(SdtConsts.DefaultNameLength)]
        public string CreatorName { get; set; }

        [StringLength(SdtConsts.DefaultNameLength)]
        public string ModifierName { get; set; }

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

        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
