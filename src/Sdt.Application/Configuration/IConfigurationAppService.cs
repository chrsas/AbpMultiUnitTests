using System.Threading.Tasks;
using Sdt.Configuration.Dto;

namespace Sdt.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
