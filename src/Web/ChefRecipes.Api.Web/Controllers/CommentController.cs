using Microsoft.AspNetCore.Mvc;

namespace ChefRecipes.Api.Web.Controllers
{
    public class CommentController : BaseApiController
    {
        [HttpGet("{recipeId:int}")]
        public IActionResult GetAll(int recipeId, [FromQuery] object filtersObject)
        {
            return this.Ok();
        }

        [HttpPost("{recipeId:int}")]
        public IActionResult CreateComment(int recipeId, [FromQuery] int parentCommentId, [FromBody] object inputModel)
        {
            return this.Ok();
        }

        [HttpDelete("{recipeId:int}/{commentId:int}")]
        public IActionResult DeleteComment(int recipeId, int commentId)
        {
            return this.Ok();
        }
    }
}
