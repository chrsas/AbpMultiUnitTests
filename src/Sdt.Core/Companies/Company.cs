using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;
using JetBrains.Annotations;
using Sdt.Common;
using Sdt.DealerCorrelation;

namespace Sdt.Companies
{
    [Table("Company")]
    public partial class Company : AuditedEntity, IRowVersion
    {
        public DcsCompanyType Type { get; set; }

        [Required]
        [StringLength(SdtConsts.DefaulCodeLength)]
        public string Code { get; set; }

        [Required]
        [StringLength(SdtConsts.DefaultNameLength)]
        public string Name { get; set; }

        [StringLength(SdtConsts.DefaultShortNameLength)]
        public string ShortName { get; set; }

        public int? RegionId { get; set; }

        [StringLength(SdtConsts.DefaultShortNameLength)]
        public string ProvinceName { get; set; }

        [StringLength(SdtConsts.DefaultShortNameLength)]
        public string CityName { get; set; }

        [StringLength(SdtConsts.DefaultShortNameLength)]
        public string CountyName { get; set; }

        public DateTime? FoundDate { get; set; }

        [StringLength(SdtConsts.DefaultStringValueLength)]
        public string ContactPerson { get; set; }

        [StringLength(SdtConsts.DefaultStringValueLength)]
        public string ContactPhone { get; set; }

        [StringLength(SdtConsts.DefaultShortStringValueLength)]
        public string Fax { get; set; }

        [StringLength(SdtConsts.DefaultLongStringValueLength)]
        public string ContactAddress { get; set; }

        [StringLength(SdtConsts.DefaultStringValueLength)]
        public string ContactPostCode { get; set; }

        [StringLength(SdtConsts.DefaultStringValueLength)]
        public string ContactMail { get; set; }

        [StringLength(SdtConsts.DefaulCodeLength)]
        public string RegisterCode { get; set; }

        [StringLength(SdtConsts.DefaultNameLength)]
        public string RegisterName { get; set; }
        public int? CorporateNature { get; set; }

        [StringLength(SdtConsts.DefaultStringValueLength)]
        public string LegalRepresentative { get; set; }
        public DcsCustomerIdDocumentType? IdDocumentType { get; set; }

        [StringLength(SdtConsts.DefaultShortStringValueLength)]
        public string IdDocumentNumber { get; set; }

        [Column(TypeName = "decimal(19, 4)")]
        public decimal? RegisterCapital { get; set; }

        public DateTime? RegisterDate { get; set; }

        [StringLength(SdtConsts.DefaultLongStringValueLength)]
        public string BusinessScope { get; set; }

        [StringLength(SdtConsts.DefaultLongStringValueLength)]
        public string BusinessAddress { get; set; }

        [StringLength(SdtConsts.DefaultShortStringValueLength)]
        public string CityCategory { get; set; }

        [StringLength(SdtConsts.DefaultRemarkLength)]
        public string Remark { get; set; }
        public DcsMasterDataStatus? Status { get; set; }

        [StringLength(SdtConsts.DefaultNameLength)]
        public string CreatorName { get; set; }

        [StringLength(SdtConsts.DefaultNameLength)]
        public string ModifierName { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }

        [CanBeNull]
        public Dealer Dealer { get; set; }
    }
}
