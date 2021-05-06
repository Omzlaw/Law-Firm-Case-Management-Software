using System.Threading.Tasks;
using LFCMS.Models.TokenAuth;
using LFCMS.Web.Controllers;
using Shouldly;
using Xunit;

namespace LFCMS.Web.Tests.Controllers
{
    public class HomeController_Tests: LFCMSWebTestBase
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