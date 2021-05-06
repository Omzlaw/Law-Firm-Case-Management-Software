using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using LFCMS.Configuration;
using LFCMS.Web;

namespace LFCMS.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class LFCMSDbContextFactory : IDesignTimeDbContextFactory<LFCMSDbContext>
    {
        public LFCMSDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<LFCMSDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            LFCMSDbContextConfigurer.Configure(builder, configuration.GetConnectionString(LFCMSConsts.ConnectionStringName));

            return new LFCMSDbContext(builder.Options);
        }
    }
}
