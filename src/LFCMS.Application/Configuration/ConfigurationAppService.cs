using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using LFCMS.Configuration.Dto;

namespace LFCMS.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : LFCMSAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
