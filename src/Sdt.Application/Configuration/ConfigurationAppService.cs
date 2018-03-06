using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Sdt.Configuration.Dto;

namespace Sdt.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : SdtAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
