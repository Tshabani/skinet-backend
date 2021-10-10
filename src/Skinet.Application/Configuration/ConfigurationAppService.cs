using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Skinet.Configuration.Dto;

namespace Skinet.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : SkinetAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
