using System.Threading.Tasks;
using Sdt.Common;
using Sdt.FeatureVarify;
using Xunit;

namespace Sdt.Tests.FeatureVarify
{
    public class FeatureVarifyAppService_Tests : SdtTestBase
    {
        private readonly IFeatureVarifyAppService _featureVarifyService;

        public FeatureVarifyAppService_Tests()
        {
            _featureVarifyService = Resolve<IFeatureVarifyAppService>();
        }

        [Fact]
        public async Task Should_Get_400_Exception()
        {
            // Act
            await Assert.ThrowsAsync<SdtFriendlyException>(
                async () => await _featureVarifyService.GetSdtFriendlyException());
        }
    }
}
