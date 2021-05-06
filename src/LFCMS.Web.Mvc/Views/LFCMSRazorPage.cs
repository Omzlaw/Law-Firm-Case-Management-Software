using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace LFCMS.Web.Views
{
    public abstract class LFCMSRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected LFCMSRazorPage()
        {
            LocalizationSourceName = LFCMSConsts.LocalizationSourceName;
        }
    }
}
