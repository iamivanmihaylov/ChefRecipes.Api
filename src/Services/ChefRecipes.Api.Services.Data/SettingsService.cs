namespace ChefRecipes.Api.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using ChefRecipes.Api.Data.Common.Repositories;
    using ChefRecipes.Api.Data.Models;
    using ChefRecipes.Api.Services.Mapping;

    public class SettingsService : ISettingsService
    {
        private readonly IDeletableEntityRepository<Setting> settingsRepository;

        public SettingsService(IDeletableEntityRepository<Setting> settingsRepository)
        {
            this.settingsRepository = settingsRepository;
        }

        public int GetCount()
        {
            return this.settingsRepository.AllAsNoTracking().Count();
        }

        public IEnumerable<T> GetAll<T>()
        {
            return this.settingsRepository.All().To<T>().ToList();
        }
    }
}
