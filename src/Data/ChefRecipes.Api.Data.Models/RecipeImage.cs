using ChefRecipes.Api.Data.Common.Models;

namespace ChefRecipes.Api.Data.Models
{
    public class RecipeImage : BaseDeletableModel<int>
    {
        public virtual Recipe Recipe { get; set; }

        public int RecipeId { get; set; }

        public string ImageUrl { get; set; }
    }
}
