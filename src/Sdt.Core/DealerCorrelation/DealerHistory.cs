using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sdt.DealerCorrelation
{
    [Table("DealerHistory")]
    public partial class DealerHistory
    {
        public int Id { get; set; }
        public int RecordId { get; set; }
        [Required]
        
        [StringLength(50)]
        public string Code { get; set; }
        [Required]
        
        [StringLength(100)]
        public string Name { get; set; }
        
        [StringLength(50)]
        public string ShortName { get; set; }
        public int? FilerId { get; set; }
        
        [StringLength(100)]
        public string FilerName { get; set; }
        
        public DateTime? FileTime { get; set; }
        
        public DateTime? CreateTime { get; set; }
        public int? CreatorId { get; set; }
        
        [StringLength(100)]
        public string CreatorName { get; set; }
        
        public DateTime? ModifyTime { get; set; }
        public int? ModifierId { get; set; }
        
        [StringLength(100)]
        public string ModifierName { get; set; }
        public int Status { get; set; }
        public int Type { get; set; }
        public int? SubNetworkType { get; set; }
    }
}
