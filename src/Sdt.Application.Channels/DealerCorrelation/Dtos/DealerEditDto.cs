using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;

namespace Sdt.Application.Channels.DealerCorrelation.Dtos
{
    public class DealerEditDto : EntityDto
    {
        ////BCC/ BEGIN CUSTOM CODE SECTION
        ////ECC/ END CUSTOM CODE SECTION

        [Required]
        [StringLength(SdtConsts.DefaulCodeLength)]
        public string Code { get; set; }

        [Required]
        [StringLength(SdtConsts.DefaultNameLength)]
        public string Name { get; set; }

        [StringLength(SdtConsts.DefaultNameLength)]
        public string ShortName { get; set; }

        public DcsDealerType Type { get; set; }
        //public DcsDealerSubNetworkType? SubNetworkType { get; set; }

        //[StringLength(SdtConsts.DefaulCodeLength)]
        //public string SubNetworkCode { get; set; }

        //[StringLength(SdtConsts.DefaultNameLength)]
        //public string CreatorName { get; set; }

        //[StringLength(SdtConsts.DefaultNameLength)]
        //public string ModifierName { get; set; }

        //public DcsMasterDataStatus Status { get; set; }
        //public byte[] RowVersion { get; set; }

        public CompanyEditDto Company { get; set; }
    }
}
