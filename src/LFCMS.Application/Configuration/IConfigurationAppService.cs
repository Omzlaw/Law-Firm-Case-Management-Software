using System.Threading.Tasks;
using LFCMS.Configuration.Dto;

namespace LFCMS.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
