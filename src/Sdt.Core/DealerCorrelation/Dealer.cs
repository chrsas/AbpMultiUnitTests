using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Sdt.Common;
using Sdt.Companies;

namespace Sdt.DealerCorrelation
{
    [Table("Dealer")]
    public partial class Dealer : AuditedEntity, IRowVersion
    {
        [Required]

        [StringLength(SdtConsts.DefaulCodeLength)]
        public string Code { get; set; }
        [Required]

        [StringLength(SdtConsts.DefaultNameLength)]
        public string Name { get; set; }

        [StringLength(SdtConsts.DefaultNameLength)]
        public string ShortName { get; set; }
        public DcsDealerType Type { get; set; }
        public DcsDealerSubNetworkType? SubNetworkType { get; set; }

        [StringLength(SdtConsts.DefaulCodeLength)]
        public string SubNetworkCode { get; set; }

        [StringLength(SdtConsts.DefaultNameLength)]
        public string CreatorName { get; set; }

        [StringLength(SdtConsts.DefaultNameLength)]
        public string ModifierName { get; set; }
        public DcsMasterDataStatus Status { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }

        public Company Company { get; set; }
    }
}
