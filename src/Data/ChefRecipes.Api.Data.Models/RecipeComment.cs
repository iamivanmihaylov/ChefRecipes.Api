using ChefRecipes.Api.Data.Common.Models;

namespace ChefRecipes.Api.Data.Models
{
    public class RecipeComment : BaseDeletableModel<int>
    {
        public RecipeComment()
        {
            this.RecipeCommentLikes = new HashSet<RecipeCommentLike>();
        }

        public virtual Recipe Recipe { get; set; }

        public int RecipeId { get; set; }

        public virtual ChefRecipesUser User { get; set; }

        public string UserId { get; set; }

        public string Text { get; set; }

        public virtual ICollection<RecipeCommentLike> RecipeCommentLikes { get; set; }
    }
}