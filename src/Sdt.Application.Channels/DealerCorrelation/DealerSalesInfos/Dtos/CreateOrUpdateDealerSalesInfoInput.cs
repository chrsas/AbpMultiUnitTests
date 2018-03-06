using System.ComponentModel.DataAnnotations;

namespace Sdt.Application.Channels.DealerCorrelation.DealerSalesInfos.Dtos
{
    public class CreateOrUpdateDealerSalesInfoInput
    {
        ////BCC/ BEGIN CUSTOM CODE SECTION
        ////ECC/ END CUSTOM CODE SECTION
        [Required]
        public DealerSalesInfoEditDto DealerSalesInfo { get; set; }

    }
}
