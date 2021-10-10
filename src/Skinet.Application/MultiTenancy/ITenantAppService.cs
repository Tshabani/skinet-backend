using Abp.Application.Services;
using Skinet.MultiTenancy.Dto;

namespace Skinet.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

