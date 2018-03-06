using Abp.Application.Services.Dto;

namespace Sdt.Application.Channels.DealerCorrelation.Dtos
{
    public class DealerListDto : AuditedEntityDto
    {
        ////BCC/ BEGIN CUSTOM CODE SECTION
        ////ECC/ END CUSTOM CODE SECTION
        public string Code { get; set; }

        public string Name { get; set; }
        public string ShortName { get; set; }
        public DcsDealerType Type { get; set; }
        public DcsDealerSubNetworkType? SubNetworkType { get; set; }
        public string SubNetworkCode { get; set; }
        public string CreatorName { get; set; }
        public string ModifierName { get; set; }
        public DcsMasterDataStatus Status { get; set; }
    }
}
