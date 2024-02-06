using Microsoft.AspNetCore.Mvc;

namespace ChefRecipes.Api.Web.Controllers
{
    public class PreparationStepsController : BaseApiController
    {
        [HttpGet]
        public IActionResult Get()
        {
            return this.Ok();
        }

        [HttpDelete]
        public IActionResult Delete(int recipeId)
        {
            return this.Ok();
        }

        [HttpPost]
        public IActionResult Create(int recipeId)
        {
            return this.Ok();
        }

        [HttpPut]
        public IActionResult Update(int recipeId, int stepId, [FromBody] object stepObject)
        {
            return this.Ok();
        }
    }
}
