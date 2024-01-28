using ChefRecipes.Api.Data.Common.Models;

namespace ChefRecipes.Api.Data.Models
{
    public class CookingPreparationStep : BaseDeletableModel<int>
    {
        public CookingPreparationStep()
        {
            this.CookingPreparationStepImages = new HashSet<CookingPreparationStepImage>();
            this.CookingPreparationStepVideos = new HashSet<CookingPreparationStepVideo>();
            this.NeededIngredients = new HashSet<Ingredient>();
        }

        public string Instructions { get; set; }

        public TimeSpan? TimeForCurrentStep { get; set; }

        public virtual ICollection<CookingPreparationStepImage> CookingPreparationStepImages { get; set; }

        public virtual ICollection<CookingPreparationStepVideo> CookingPreparationStepVideos { get; set; }

        public virtual ICollection<Ingredient> NeededIngredients { get; set; }
    }
}