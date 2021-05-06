using System.Threading.Tasks;
using Abp.Application.Services;
using LFCMS.Sessions.Dto;

namespace LFCMS.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
