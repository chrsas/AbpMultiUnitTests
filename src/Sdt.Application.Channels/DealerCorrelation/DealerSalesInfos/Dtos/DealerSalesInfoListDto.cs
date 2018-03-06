using System;
using Abp.Application.Services.Dto;

namespace Sdt.Application.Channels.DealerCorrelation.DealerSalesInfos.Dtos
{
    public class DealerSalesInfoListDto : EntityDto
    {
        ////BCC/ BEGIN CUSTOM CODE SECTION
        ////ECC/ END CUSTOM CODE SECTION
        public int DealerId { get; set; }
        public string DealerCode { get; set; }
        public string DealerName { get; set; }
        public string DealerShortName { get; set; }
        public DcsDealerType DealerType { get; set; }
        public string DealerCreatorName { get; set; }
        public string DealerModifierName { get; set; }
        public DcsMasterDataStatus DealerStatus { get; set; }
        public DateTime? DealerCompanyFoundDate { get; set; }
        public string DealerCompanyLegalRepresentative { get; set; }
        public decimal? DealerCompanyRegisterCapital { get; set; }
        public string DealerCompanyBusinessScope { get; set; }
        public string SalesHotline { get; set; }
        public string ShopProperty { get; set; }
        public string ShopLevel { get; set; }
        public string ErpServiceCode { get; set; }
        public DateTime? DealerCreateTime { get; set; }
        public DateTime? DealerModifyTime { get; set; }
    }
}
