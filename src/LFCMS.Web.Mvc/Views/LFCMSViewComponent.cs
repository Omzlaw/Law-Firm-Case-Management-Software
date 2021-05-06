using Abp.AspNetCore.Mvc.ViewComponents;

namespace LFCMS.Web.Views
{
    public abstract class LFCMSViewComponent : AbpViewComponent
    {
        protected LFCMSViewComponent()
        {
            LocalizationSourceName = LFCMSConsts.LocalizationSourceName;
        }
    }
}
