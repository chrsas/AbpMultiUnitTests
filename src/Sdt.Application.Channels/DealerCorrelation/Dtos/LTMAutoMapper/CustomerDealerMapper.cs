using AutoMapper;
using Sdt.DealerCorrelation;

namespace Sdt.Application.Channels.DealerCorrelation.Dtos.LTMAutoMapper
{
    /// <summary>
    /// 配置Dealer的AutoMapper
    /// </summary>
    internal static class CustomerDealerMapper
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
            //    configuration.CreateMap <Dealer, DealerEditDto>();
            configuration.CreateMap<Dealer, DealerListDto>();
            configuration.CreateMap<DealerEditDto, Dealer>();
            // configuration.CreateMap<CreateDealerInput, Dealer>();
            //        configuration.CreateMap<Dealer, GetDealerForEditOutput>();
        }
    }
}
