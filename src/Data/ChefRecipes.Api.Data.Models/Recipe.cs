using ChefRecipes.Api.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChefRecipes.Api.Data.Models
{
    public class Recipe : BaseDeletableModel<int>
    {
        public Recipe()
        {
            this.RecipeImages = new HashSet<RecipeImage>();
            this.RecipeLikes = new HashSet<RecipeLike>();
            this.RecipeIngredients = new HashSet<RecipeIngredient>();
            this.RecipeComments = new HashSet<RecipeComment>();
        }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Category { get; set; }

        public int NumberOfPortions { get; set; }

        public TimeSpan PreparationTime { get; set; }

        public TimeSpan CookingTime { get; set; }

        public virtual ICollection<RecipeImage> RecipeImages { get; set; }

        public virtual ICollection<RecipeLike> RecipeLikes { get; set; }

        public virtual ICollection<RecipeIngredient> RecipeIngredients { get; set; }

        public virtual ICollection<RecipeComment> RecipeComments { get; set; }

    }
}
