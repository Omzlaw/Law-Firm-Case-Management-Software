using System.Threading.Tasks;
using Abp.Application.Services;
using LFCMS.Authorization.Accounts.Dto;

namespace LFCMS.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
