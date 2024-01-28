using ChefRecipes.Api.Data.Common.Models;

namespace ChefRecipes.Api.Data.Models
{

    public class CookingPreparationTutorial : BaseDeletableModel<int>
    {
        public CookingPreparationTutorial()
        {
            this.CookingPreparationSteps = new HashSet<CookingPreparationStep>();
        }

        public virtual Recipe Recipe { get; set; }

        public int RecipeId { get; set; }

        public virtual ICollection<CookingPreparationStep> CookingPreparationSteps { get; set; }

    }
}