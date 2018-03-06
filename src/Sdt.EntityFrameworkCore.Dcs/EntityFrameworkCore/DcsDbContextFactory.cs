using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Sdt.Configuration;
using Sdt.Web;

namespace Sdt.Dcs.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class DcsDbContextFactory : IDesignTimeDbContextFactory<DcsDbContext>
    {
        public DcsDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<DcsDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DcsDbContextConfigurer.Configure(builder, configuration.GetConnectionString(SdtConsts.DcsConnectionStringName));

            return new DcsDbContext(builder.Options);
        }
    }
}
