using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Sdt.Authorization.Roles;
using Sdt.Authorization.Users;
using Sdt.MultiTenancy;
using Sdt.Common;
using Sdt.EntityFrameworkCore.EntityConfigurations;

namespace Sdt.EntityFrameworkCore
{
    public class SdtDbContext : AbpZeroDbContext<Tenant, Role, User, SdtDbContext>
    {
        public SdtDbContext(DbContextOptions<SdtDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new TenantConfiguration());
        }

        private static bool NoneAnnotationDateTime(IMutableProperty property)
        {
            return (property.ClrType == typeof(DateTime) || property.ClrType == typeof(DateTime?)) &&
                   !property.GetAnnotations().Any();
        }
    }
}
