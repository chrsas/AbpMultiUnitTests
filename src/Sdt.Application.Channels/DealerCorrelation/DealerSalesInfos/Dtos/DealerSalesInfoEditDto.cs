using System;
using System.ComponentModel.DataAnnotations;
using Sdt.Application.Channels.DealerCorrelation.Dtos;
using Sdt.DealerCorrelation.DealerSaleInfoes;

namespace Sdt.Application.Channels.DealerCorrelation.DealerSalesInfos.Dtos
{
    public class DealerSalesInfoEditDto
    {
        ////BCC/ BEGIN CUSTOM CODE SECTION
        ////ECC/ END CUSTOM CODE SECTION
        public int Id { get; set; }
        public int DealerId { get; set; }
        public DcsDealerType DealerType { get; set; }

        [StringLength(SdtConsts.DefaultStringValueLength)]
        public string SalesHotline { get; set; }

        [StringLength(SdtConsts.DefaultStringValueLength)]
        public string ShopProperty { get; set; }

        [StringLength(SdtConsts.DefaultStringValueLength)]
        public string ShopLevel { get; set; }

        public DateTime? CancellationTime { get; set; }

        [StringLength(SdtConsts.DefaulCodeLength)]
        public string ErpServiceCode { get; set; }
        //public DcsBaseDataStatus Status { get; set; }

        //[StringLength(DealerSalesInfo.RemarkLength)]
        //public string Remark { get; set; }
        public DateTime? SubscriptionTime { get; set; }

        [StringLength(SdtConsts.DefaultNameLength)]
        public string GroupName { get; set; }
        public DateTime? DegradeTime { get; set; }

        [StringLength(SdtConsts.DefaultLongStringValueLength)]
        public string Address { get; set; }

        [StringLength(SdtConsts.DefaultStringValueLength)]
        public string ZipCode { get; set; }

        [StringLength(SdtConsts.DefaultShortStringValueLength)]
        public string Fax { get; set; }

        [StringLength(SdtConsts.DefaultShortStringValueLength)]
        public string Email { get; set; }
        public byte[] RowVersion { get; set; }

        public DealerEditDto Dealer { get; set; }
    }
}
