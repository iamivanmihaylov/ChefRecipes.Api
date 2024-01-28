using ChefRecipes.Api.Data.Common.Models;

namespace ChefRecipes.Api.Data.Models
{
    public class CookingPreparationStepVideo : BaseDeletableModel<int>
    {
        public virtual CookingPreparationStep CookingPreparationStep { get; set; }

        public int CookingPreparationStepId { get; set; }

        public string VideoUrl { get; set; }
    }
}