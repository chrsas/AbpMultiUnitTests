using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Sdt.Application.Channels.DealerCorrelation.DealerSalesInfos.Dtos.LTMAutoMapper;
using Sdt.Authorization;
using Sdt.DealerCorrelation.Dealers.Authorization;
using Sdt.DealerCorrelation.DealerSaleInfoes.Authorization;

namespace Sdt.Application.Channels
{
    [DependsOn(
        typeof(SdtCoreModule),
        typeof(AbpAutoMapperModule),
        typeof(SdtApplicationModule))]
    public class ChannelsApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<DealerAppAuthorizationProvider>();
            Configuration.Authorization.Providers.Add<DealerSalesInfoAppAuthorizationProvider>();

            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomerDealerSalesInfoMapper.CreateMappings);
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ChannelsApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
