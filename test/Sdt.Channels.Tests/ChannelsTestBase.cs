using System;
using System.Linq;
using System.Threading.Tasks;
using Abp;
using Abp.Authorization.Users;
using Abp.EntityFrameworkCore;
using Abp.Events.Bus;
using Abp.Events.Bus.Entities;
using Abp.Reflection.Extensions;
using Abp.Runtime.Session;
using Abp.TestBase;
using Microsoft.EntityFrameworkCore;
using Sdt.Application.Channels;
using Sdt.Authorization.Users;
using Sdt.Channels.Tests.TestDatas;
using Sdt.Dcs.EntityFrameworkCore;
using Sdt.EntityFrameworkCore;
using Sdt.EntityFrameworkCore.Seed.Host;
using Sdt.EntityFrameworkCore.Seed.Tenants;
using Sdt.MultiTenancy;
using Sdt.Tests;

namespace Sdt.Channels.Tests
{
    public abstract class ChannelsTestBase : SdtTestBase
    {
        protected ChannelsTestBase()
        {
            void NormalizeDbContext(DcsDbContext context)
            {
                context.EntityChangeEventHelper = NullEntityChangeEventHelper.Instance;
                context.EventBus = NullEventBus.Instance;
                context.SuppressAutoSetTenantId = true;
            }

            UsingBusinessDbContext(context =>
            {
                NormalizeDbContext(context);
                new BusinessTestDataBuilder(context, AbpSession.TenantId.Value).Create();
            });
        }

        protected override void PreInitialize()
        {
            AbpBootstrapper = AbpBootstrapper.Create<ChannelsTestModule>(options =>
            {
                options.IocManager = LocalIocManager;
            });
        }

        #region UsingDbContext

        //protected IDisposable UsingTenantId(int? tenantId)
        //{
        //    var previousTenantId = AbpSession.TenantId;
        //    AbpSession.TenantId = tenantId;
        //    return new DisposeAction(() => AbpSession.TenantId = previousTenantId);
        //}

        protected void UsingBusinessDbContext(Action<DcsDbContext> action)
        {
            UsingBusinessDbContext(AbpSession.TenantId, action);
        }

        protected Task UsingBusinessDbContextAsync(Func<DcsDbContext, Task> action)
        {
            return UsingBusinessDbContextAsync(AbpSession.TenantId, action);
        }

        protected T UsingBusinessDbContext<T>(Func<DcsDbContext, T> func)
        {
            return UsingBusinessDbContext(AbpSession.TenantId, func);
        }

        protected Task<T> UsingBusinessDbContextAsync<T>(Func<DcsDbContext, Task<T>> func)
        {
            return UsingBusinessDbContextAsync(AbpSession.TenantId, func);
        }

        protected void UsingBusinessDbContext(int? tenantId, Action<DcsDbContext> action)
        {
            using (UsingTenantId(tenantId))
            {
                using (var context = LocalIocManager.Resolve<DcsDbContext>())
                {
                    action(context);
                    context.SaveChanges();
                }
            }
        }

        protected async Task UsingBusinessDbContextAsync(int? tenantId, Func<DcsDbContext, Task> action)
        {
            using (UsingTenantId(tenantId))
            {
                using (var context = LocalIocManager.Resolve<DcsDbContext>())
                {
                    await action(context);
                    await context.SaveChangesAsync();
                }
            }
        }

        protected T UsingBusinessDbContext<T>(int? tenantId, Func<DcsDbContext, T> func)
        {
            T result;

            using (UsingTenantId(tenantId))
            {
                using (var context = LocalIocManager.Resolve<DcsDbContext>())
                {
                    result = func(context);
                    context.SaveChanges();
                }
            }

            return result;
        }

        protected async Task<T> UsingBusinessDbContextAsync<T>(int? tenantId, Func<DcsDbContext, Task<T>> func)
        {
            T result;

            using (UsingTenantId(tenantId))
            {
                using (var context = LocalIocManager.Resolve<DcsDbContext>())
                {
                    result = await func(context);
                    await context.SaveChangesAsync();
                }
            }

            return result;
        }

        #endregion
    }
}
