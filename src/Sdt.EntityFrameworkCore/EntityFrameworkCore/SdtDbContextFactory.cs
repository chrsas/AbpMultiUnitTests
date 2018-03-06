using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Sdt.Configuration;
using Sdt.Web;

namespace Sdt.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class SdtDbContextFactory : IDesignTimeDbContextFactory<SdtDbContext>
    {
        public SdtDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<SdtDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            SdtDbContextConfigurer.Configure(builder, configuration.GetConnectionString(SdtConsts.ConnectionStringName));

            return new SdtDbContext(builder.Options);
        }
    }
}
