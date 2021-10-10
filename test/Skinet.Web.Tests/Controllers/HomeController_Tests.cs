using System.Threading.Tasks;
using Skinet.Models.TokenAuth;
using Skinet.Web.Controllers;
using Shouldly;
using Xunit;

namespace Skinet.Web.Tests.Controllers
{
    public class HomeController_Tests: SkinetWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}