using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ItSutra.DemoGame.EntityFrameworkCore
{
    public static class DemoGameDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<DemoGameDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<DemoGameDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
