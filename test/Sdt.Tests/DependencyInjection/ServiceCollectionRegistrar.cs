using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Castle.MicroKernel.Registration;
using Castle.Windsor.MsDependencyInjection;
using Abp.Dependency;
using Sdt.EntityFrameworkCore;
using Sdt.Identity;

namespace Sdt.Tests.DependencyInjection
{
    public static class ServiceCollectionRegistrar
    {
        public static IServiceProvider ServiceProdiver { get; private set; }

        public static void Register(IIocManager iocManager)
        {
            var services = new ServiceCollection();

            IdentityRegistrar.Register(services);

            services.AddEntityFrameworkInMemoryDatabase();

            ServiceProdiver = WindsorRegistrationHelper.CreateServiceProvider(iocManager.IocContainer, services);

            var builder = new DbContextOptionsBuilder<SdtDbContext>();
            builder.UseInMemoryDatabase(Guid.NewGuid().ToString()).UseInternalServiceProvider(ServiceProdiver);

            iocManager.IocContainer.Register(
                Component
                    .For<DbContextOptions<SdtDbContext>>()
                    .Instance(builder.Options)
                    .LifestyleSingleton()
            );
        }
    }
}
