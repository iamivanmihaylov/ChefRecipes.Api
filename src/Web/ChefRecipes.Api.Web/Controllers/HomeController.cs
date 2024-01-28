namespace ChefRecipes.Api.Web.Controllers
{
    using System.Diagnostics;

    using ChefRecipes.Api.Web.ViewModels;

    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("/api/[controller]/[action]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            return this.Ok("Kur");
        }

        [HttpGet]
        public IActionResult Privacy()
        {
            return this.Ok();
        }
    }
}
