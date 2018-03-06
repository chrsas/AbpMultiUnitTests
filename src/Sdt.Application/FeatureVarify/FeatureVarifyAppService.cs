using System.Threading.Tasks;
using Sdt.Common;

namespace Sdt.FeatureVarify
{
    public class FeatureVarifyAppService : IFeatureVarifyAppService
    {
        public Task GetSdtFriendlyException()
        {
            throw new SdtFriendlyException("抛出一个SdtFriendlyException，状态码400");
        }
    }
}
