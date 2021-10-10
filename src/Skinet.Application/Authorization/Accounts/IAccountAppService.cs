using System.Threading.Tasks;
using Abp.Application.Services;
using Skinet.Authorization.Accounts.Dto;

namespace Skinet.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
