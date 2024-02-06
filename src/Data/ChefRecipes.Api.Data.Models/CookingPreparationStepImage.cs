using ChefRecipes.Api.Data.Common.Models;

namespace ChefRecipes.Api.Data.Models
{
    public class CookingPreparationStepImage : BaseDeletableModel<int>
    {
        public string ImageUrl { get; set; }

        public virtual CookingPreparationStep CookingPreparationStep { get; set; }

    }
}