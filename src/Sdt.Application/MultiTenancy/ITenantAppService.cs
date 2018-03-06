using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Sdt.MultiTenancy.Dto;

namespace Sdt.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
