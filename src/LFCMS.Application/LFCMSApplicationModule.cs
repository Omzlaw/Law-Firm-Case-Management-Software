using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LFCMS.Authorization;

namespace LFCMS
{
    [DependsOn(
        typeof(LFCMSCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class LFCMSApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<LFCMSAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(LFCMSApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
