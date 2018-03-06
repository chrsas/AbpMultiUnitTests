using System.Threading.Tasks;
using Abp.Application.Services;
using Sdt.Authorization.Accounts.Dto;

namespace Sdt.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
