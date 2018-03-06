using System.ComponentModel.DataAnnotations;

namespace Sdt.Application.Channels.DealerCorrelation.Dtos
{
    public class CreateOrUpdateDealerInput
    {
        ////BCC/ BEGIN CUSTOM CODE SECTION
        ////ECC/ END CUSTOM CODE SECTION
        [Required]
        public DealerEditDto Dealer { get; set; }
    }
}
