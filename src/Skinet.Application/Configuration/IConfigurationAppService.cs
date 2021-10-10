using System.Threading.Tasks;
using Skinet.Configuration.Dto;

namespace Skinet.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
