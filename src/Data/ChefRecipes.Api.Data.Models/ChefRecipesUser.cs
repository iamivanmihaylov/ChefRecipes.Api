// ReSharper disable VirtualMemberCallInConstructor
namespace ChefRecipes.Api.Data.Models
{
    using System;
    using System.Collections.Generic;

    using ChefRecipes.Api.Data.Common.Models;

    using Microsoft.AspNetCore.Identity;

    public class ChefRecipesUser : IdentityUser, IAuditInfo, IDeletableEntity
    {
        public ChefRecipesUser()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Roles = new HashSet<IdentityUserRole<string>>();
            this.Claims = new HashSet<IdentityUserClaim<string>>();
            this.Logins = new HashSet<IdentityUserLogin<string>>();
            this.Recipes = new HashSet<Recipe>();
        }

        // User info
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public LevelOfExperience LevelOfExperience { get; set; }

        public ulong Experience { get; set; }

        public string ProfilePicture { get; set; }


        // Audit info
        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        // Deletable entity
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public virtual ICollection<IdentityUserRole<string>> Roles { get; set; }

        public virtual ICollection<IdentityUserClaim<string>> Claims { get; set; }

        public virtual ICollection<IdentityUserLogin<string>> Logins { get; set; }

        public virtual ICollection<Recipe> Recipes { get; set; }
    }
}
