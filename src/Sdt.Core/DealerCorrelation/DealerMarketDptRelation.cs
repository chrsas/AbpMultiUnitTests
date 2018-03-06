using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;

namespace Sdt.DealerCorrelation
{
    [Table("DealerMarketDptRelation")]
    public partial class DealerMarketDptRelation : Entity
    {
        public int MarketId { get; set; }
        public int DealerId { get; set; }
        public int BranchId { get; set; }
        public DcsBaseDataStatus Status { get; set; }
    }
}
