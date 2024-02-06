using Microsoft.AspNetCore.Mvc;

namespace ChefRecipes.Api.Web.Controllers
{
    public class AuthenticationController : BaseApiController
    {
        public IActionResult CreateAuthoriztionCode()
        {
            return this.Ok();
        }

        public IActionResult CreateAuthorizationToken()
        {
            return this.Ok();
        }

        public IActionResult RefreshAuthorizationToken()
        {
            return this.Ok();
        }
    }
}
