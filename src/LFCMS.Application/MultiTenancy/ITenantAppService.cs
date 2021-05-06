using Abp.Application.Services;
using LFCMS.MultiTenancy.Dto;

namespace LFCMS.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

