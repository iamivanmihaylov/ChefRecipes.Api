using ChefRecipes.Api.Web.ViewModels.Recipes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ChefRecipes.Api.Web.Controllers
{
    public class CommentController : BaseApiController
    {
        [HttpPost]
        public IActionResult Like(string userId, int commentId)
        {
            return this.Ok();
        }

        [HttpDelete]
        public IActionResult Dislike(string userId, int commentId)
        {
            return this.Ok();
        }

        [HttpPost]
        public IActionResult Create([FromBody] RecipeCreateModel createModel)
        {
            return this.Ok(createModel);
        }

        [HttpGet("{recipeId:int}")]
        public IActionResult GetByRecipeId(int recipeId, [FromQuery] int? page)
        {
            return this.Ok();
        }

        [HttpDelete("{commentId:int}")]
        public IActionResult Delete(int commentId)
        {
            return this.Ok();
        }
    }
}
