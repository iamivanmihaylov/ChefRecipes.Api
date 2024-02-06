using Microsoft.AspNetCore.Mvc;

namespace ChefRecipes.Api.Web.Controllers
{
    public class LikeController : BaseApiController
    {
        [HttpPost("recipe/{recipeId:int}")]
        public IActionResult LikeRecipe(int recipeId)
        {
            return this.Ok();
        }

        [HttpPost("comment/{commentId:int}")]
        public IActionResult LikeComment(int commentId)
        {
            return this.Ok();
        }
    }
}
