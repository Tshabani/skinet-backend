using System.Threading.Tasks;
using Abp.Application.Services;
using Skinet.Sessions.Dto;

namespace Skinet.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
