using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using LFCMS.Controllers;

namespace LFCMS.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : LFCMSControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
