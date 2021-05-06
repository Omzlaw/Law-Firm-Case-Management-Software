using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace LFCMS.EntityFrameworkCore
{
    public static class LFCMSDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<LFCMSDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<LFCMSDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
