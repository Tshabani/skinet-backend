using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Skinet.EntityFrameworkCore
{
    public static class SkinetDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<SkinetDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<SkinetDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
