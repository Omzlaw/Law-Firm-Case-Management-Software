using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace LFCMS.Controllers
{
    public abstract class LFCMSControllerBase: AbpController
    {
        protected LFCMSControllerBase()
        {
            LocalizationSourceName = LFCMSConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
