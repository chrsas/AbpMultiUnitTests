using Abp.Modules;
using Abp.Zero.EntityFrameworkCore;
using Castle.MicroKernel.Registration;
using NSubstitute;
using Sdt.Application.Channels;
using Sdt.Channels.Tests.DependencyInjection;
using Sdt.Dcs.EntityFrameworkCore;
using Sdt.Tests;

namespace Sdt.Channels.Tests
{
    [DependsOn(
        typeof(ChannelsApplicationModule),
        typeof(DcsEntityFrameworkModule),
        typeof(SdtTestModule)
    )]
    public class ChannelsTestModule : AbpModule
    {
        public ChannelsTestModule(DcsEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;
        }

        public override void PreInitialize()
        {
            RegisterFakeService<AbpZeroDbMigrator<DcsDbContext>>();
        }

        public override void Initialize()
        {
            ServiceCollectionRegistrar.Register(IocManager);
        }

        private void RegisterFakeService<TService>() where TService : class
        {
            IocManager.IocContainer.Register(
                Component.For<TService>()
                    .UsingFactoryMethod(() => Substitute.For<TService>())
                    .LifestyleSingleton()
            );
        }
    }
}
