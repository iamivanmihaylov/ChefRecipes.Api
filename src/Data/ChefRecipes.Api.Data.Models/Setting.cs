namespace ChefRecipes.Api.Data.Models
{
    using ChefRecipes.Api.Data.Common.Models;

    public class Setting : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public string Value { get; set; }
    }
}
