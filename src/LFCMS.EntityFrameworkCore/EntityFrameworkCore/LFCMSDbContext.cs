using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using LFCMS.Authorization.Roles;
using LFCMS.Authorization.Users;
using LFCMS.MultiTenancy;

namespace LFCMS.EntityFrameworkCore
{
    public class LFCMSDbContext : AbpZeroDbContext<Tenant, Role, User, LFCMSDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public LFCMSDbContext(DbContextOptions<LFCMSDbContext> options)
            : base(options)
        {
        }
    }
}
