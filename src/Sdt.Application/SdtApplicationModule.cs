using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Sdt.Authorization;

namespace Sdt
{
    [DependsOn(
        typeof(SdtCoreModule),
        typeof(AbpAutoMapperModule))]
    public class SdtApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<SdtAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(SdtApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
