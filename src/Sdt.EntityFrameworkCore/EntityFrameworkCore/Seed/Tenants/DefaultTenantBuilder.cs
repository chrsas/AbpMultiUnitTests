using System.Linq;
using Microsoft.EntityFrameworkCore;
using Abp.MultiTenancy;
using Sdt.Editions;
using Sdt.MultiTenancy;

namespace Sdt.EntityFrameworkCore.Seed.Tenants
{
    public class DefaultTenantBuilder
    {
        private readonly SdtDbContext _context;

        public DefaultTenantBuilder(SdtDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateDefaultTenant();
        }

        private void CreateDefaultTenant()
        {
            // Default tenant

            var defaultTenant = _context.Tenants.IgnoreQueryFilters().FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant != null)
                return;
            defaultTenant = new Tenant(Tenant.DefaultTenantName, Tenant.DefaultName, TenantCategory.Branch) { Id = Tenant.DefaultId };

            var defaultEdition = _context.Editions.IgnoreQueryFilters().FirstOrDefault(e => e.Name == EditionManager.DefaultEditionName);
            if (defaultEdition != null)
            {
                defaultTenant.EditionId = defaultEdition.Id;
            }

            _context.Tenants.Add(defaultTenant);
            _context.SaveChanges();
        }
    }
}
