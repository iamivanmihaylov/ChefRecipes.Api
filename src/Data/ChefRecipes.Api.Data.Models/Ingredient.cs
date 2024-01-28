using ChefRecipes.Api.Data.Common.Models;

namespace ChefRecipes.Api.Data.Models
{
    public class Ingredient : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public virtual ICollection<CookingPreparationStep> CookingPreparationSteps { get; set; }
    }
}