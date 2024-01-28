using ChefRecipes.Api.Data.Common.Models;

namespace ChefRecipes.Api.Data.Models
{
    public class RecipeIngredient : BaseDeletableModel<int>
    {
        public virtual Recipe Recipe { get; set; }

        public int RecipeId { get; set; }

        public virtual Ingredient Ingredient { get; set; }

        public int IngredientId { get; set; }

        public int Magnitude { get; set; }

        public Units Units { get; set; }
    }
}
