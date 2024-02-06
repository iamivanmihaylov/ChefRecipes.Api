namespace ChefRecipes.Api.Web.Controllers
{
    using System.Diagnostics;

    using ChefRecipes.Api.Web.ViewModels;
    using ChefRecipes.Api.Web.ViewModels.Recipes;
    using Microsoft.AspNetCore.Mvc;

    public class RecipeController : BaseApiController
    {
        [HttpGet]
        public IActionResult GetAll([FromQuery] int? page = 0)
        {
            return this.Ok();
        }

        [HttpGet("{recipeId:int}")]
        public IActionResult GetById(int recipeId)
        {
            return this.Ok(recipeId);
        }

        [HttpDelete("{recipeId:int}")]
        public IActionResult DeleteById(int recipeId)
        {
            return this.Ok();
        }

        [HttpPut("{recipeId:int}")]
        public IActionResult UpdateById(int recipeId, [FromBody] RecipeUpdateModel recipeUpdateModel)
        {
            return this.Ok();
        }

        [HttpPost]
        public IActionResult Create([FromBody] RecipeCreateModel recipeObject)
        {
            return this.Ok();
        }

        [HttpGet("{userId}")]
        public IActionResult ByUserId(string userId, [FromQuery]int page)
        {
            return this.Ok();
        }
    }
}
