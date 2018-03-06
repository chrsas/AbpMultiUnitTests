using System.Threading.Tasks;
using Abp.Application.Services;

namespace Sdt.FeatureVarify
{
    public interface IFeatureVarifyAppService : IApplicationService
    {
        Task GetSdtFriendlyException();
    }
}
