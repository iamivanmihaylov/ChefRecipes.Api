namespace ChefRecipes.Api.Web.Controllers
{
    using System.Diagnostics;

    using ChefRecipes.Api.Web.ViewModels;
    using ChefRecipes.Api.Web.ViewModels.Recipes;
    using Microsoft.AspNetCore.Mvc;

    public class RecipeController : BaseApiController
    {
        [HttpGet]
        public IActionResult Get()
        {
            return this.Ok();
        }

        [HttpGet("{recipeId:int}")]
        public IActionResult Get(int recipeId)
        {
            return this.Ok(recipeId);
        }

        [HttpDelete("{recipeId:int}")]
        public IActionResult Delete(int recipeId)
        {
            return this.Ok();
        }

        [HttpPut("{recipeId:int}")]
        public IActionResult Update(int recipeId, [FromBody]RecipeUpdateModel recipeUpdateModel)
        {
            return this.Ok();
        }

        [HttpPost]
        public IActionResult Create([FromBody]RecipeCreateModel recipeObject)
        {
            return this.Ok();
        }

        [HttpGet("{userId:string}")]
        public IActionResult ByUserId(string userId)
        {
            return this.Ok();
        }
    }
}
