using System.Threading.Tasks;
using Abp.Application.Services;
using Sdt.Sessions.Dto;

namespace Sdt.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
