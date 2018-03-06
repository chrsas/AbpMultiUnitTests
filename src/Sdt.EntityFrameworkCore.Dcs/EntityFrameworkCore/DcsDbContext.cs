using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Sdt.Companies;
using Sdt.DealerCorrelation;
using Sdt.DealerCorrelation.DealerSaleInfoes;

namespace Sdt.Dcs.EntityFrameworkCore
{
    public class DcsDbContext : AbpDbContext
    {
        public virtual DbSet<Company> Companies { get; set; }

        public virtual DbSet<Dealer> Dealers { get; set; }

        public virtual DbSet<DealerMarketDptRelation> DealerMarketDptRelations { get; set; }

        public virtual DbSet<DealerSalesInfo> DealerSalesInfoes { get; set; }

        public virtual DbSet<DealerSalesInfoHistory> DealerSalesInfoHistories { get; set; }

        public DcsDbContext(DbContextOptions<DcsDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Company>()
                .HasOne(c => c.Dealer)
                .WithOne(d => d.Company)
                .HasForeignKey<Dealer>(d => d.Id);
        }
    }
}
