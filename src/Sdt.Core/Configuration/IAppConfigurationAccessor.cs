using Microsoft.Extensions.Configuration;

namespace Sdt.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}
