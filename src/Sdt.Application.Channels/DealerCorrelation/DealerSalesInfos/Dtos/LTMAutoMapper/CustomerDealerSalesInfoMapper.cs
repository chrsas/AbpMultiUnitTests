using AutoMapper;
using Sdt.DealerCorrelation.DealerSaleInfoes;

namespace Sdt.Application.Channels.DealerCorrelation.DealerSalesInfos.Dtos.LTMAutoMapper
{
    /// <summary>
    /// 配置DealerSalesInfo的AutoMapper
    /// </summary>
    internal static class CustomerDealerSalesInfoMapper
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
            //    configuration.CreateMap <DealerSalesInfo, DealerSalesInfoDto>();
            configuration.CreateMap<DealerSalesInfo, DealerSalesInfoListDto>();
                //.ForMember(d => d.DealerCode, options => options.MapFrom(input => input.Dealer.Code))
                //.ForMember(d => d.DealerCompanyBusinessScope, options => options.MapFrom(input => input.Dealer.Company.BusinessScope))
                //.ForMember(d => d.DealerCompanyFoundDate, options => options.MapFrom(input => input.Dealer.Company.FoundDate))
                //.ForMember(d => d.DealerCompanyLegalRepresentative, options => options.MapFrom(input => input.Dealer.Company.LegalRepresentative))
                //.ForMember(d => d.DealerCompanyRegisterCapital, options => options.MapFrom(input => input.Dealer.Company.RegisterCapital))
                //.ForMember(d => d.DealerCreateTime, options => options.MapFrom(input => input.Dealer.CreationTime))
                //.ForMember(d => d.DealerCreatorName, options => options.MapFrom(input => input.Dealer.CreatorName))
                //.ForMember(d => d.DealerModifierName, options => options.MapFrom(input => input.Dealer.ModifierName))
                //.ForMember(d => d.DealerModifyTime, options => options.MapFrom(input => input.Dealer.LastModificationTime))
                //.ForMember(d => d.DealerName, options => options.MapFrom(input => input.Dealer.Name))
                //.ForMember(d => d.DealerShortName, options => options.MapFrom(input => input.Dealer.ShortName))
                //.ForMember(d => d.DealerStatus, options => options.MapFrom(input => input.Dealer.Status))
                //.ForMember(d => d.DealerType, options => options.MapFrom(input => input.Dealer.Type));
            configuration.CreateMap<DealerSalesInfoEditDto, DealerSalesInfo>();
            // configuration.CreateMap<CreateDealerSalesInfoInput, DealerSalesInfo>();
            //        configuration.CreateMap<DealerSalesInfo, GetDealerSalesInfoForEditOutput>();
        }
    }
}
