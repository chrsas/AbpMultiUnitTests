using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Sdt.Dcs.EntityFrameworkCore
{
    public static class DcsDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<DcsDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<DcsDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
