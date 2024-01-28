using ChefRecipes.Api.Data.Common.Models;

namespace ChefRecipes.Api.Data.Models
{

    public class RecipeCommentLike : BaseDeletableModel<int>
    {
        public virtual RecipeComment RecipeComment { get; set; }

        public int RecipeCommentId { get; set; }

        public virtual ChefRecipesUser User { get; set; }

        public string UserId { get; set; }
    }
}