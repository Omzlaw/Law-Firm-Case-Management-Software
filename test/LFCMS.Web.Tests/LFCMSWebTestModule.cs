using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LFCMS.EntityFrameworkCore;
using LFCMS.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace LFCMS.Web.Tests
{
    [DependsOn(
        typeof(LFCMSWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class LFCMSWebTestModule : AbpModule
    {
        public LFCMSWebTestModule(LFCMSEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LFCMSWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(LFCMSWebMvcModule).Assembly);
        }
    }
}