using ChefRecipes.Api.Data.Common.Models;

namespace ChefRecipes.Api.Data.Models
{
    public class RecipeLike : BaseDeletableModel<int>
    {
        public virtual Recipe Recipe { get; set; }

        public int RecipeId { get; set; }

        public virtual ChefRecipesUser User { get; set; }

        public string UserId { get; set; }

    }
}
