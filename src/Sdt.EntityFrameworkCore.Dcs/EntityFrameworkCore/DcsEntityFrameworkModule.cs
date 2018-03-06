using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using Sdt.Configuration;
using Sdt.Dcs.EntityFrameworkCore.Seed;

namespace Sdt.Dcs.EntityFrameworkCore
{
    [DependsOn(
        typeof(SdtCoreModule),
        typeof(AbpZeroCoreEntityFrameworkCoreModule))]
    public class DcsEntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

        public override void PreInitialize()
        {
            if (SkipDbContextRegistration)
                return;
            Configuration.Modules.AbpEfCore().AddDbContext<DcsDbContext>(options =>
            {
                if (options.ExistingConnection != null)
                {
                    DcsDbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
                }
                else
                {
                    var configurationAccessor = IocManager.Resolve<IAppConfigurationAccessor>();
                    var connectionString = configurationAccessor.Configuration["ConnectionStrings:DcsEntity"];
                    DcsDbContextConfigurer.Configure(options.DbContextOptions, connectionString);
                }
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DcsEntityFrameworkModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            if (!SkipDbSeed)
            {
                SeedHelper.SeedHostDb(IocManager);
            }
        }
    }
}
