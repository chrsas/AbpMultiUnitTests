using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Sdt.EntityFrameworkCore
{
    public static class SdtDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<SdtDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<SdtDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
