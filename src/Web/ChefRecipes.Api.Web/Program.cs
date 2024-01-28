using System.Reflection;
using ChefRecipes.Api.Common;
using ChefRecipes.Api.Data;
using ChefRecipes.Api.Data.Common;
using ChefRecipes.Api.Data.Common.Repositories;
using ChefRecipes.Api.Data.Models;
using ChefRecipes.Api.Data.Repositories;
using ChefRecipes.Api.Data.Seeding;
using ChefRecipes.Api.Services.Data;
using ChefRecipes.Api.Services.Mapping;
using ChefRecipes.Api.Services.Messaging;
using ChefRecipes.Api.Web.ViewModels;
using Docker.DotNet;
using Docker.DotNet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
ConfigureServices(builder.Services, builder.Configuration);
var app = builder.Build();
Configure(app);
app.Run();

void ConfigureServices(IServiceCollection services, IConfiguration configuration)
{
    services.AddDbContext<ApplicationDbContext>(
        options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

    services.AddDefaultIdentity<ChefRecipesUser>(IdentityOptionsProvider.GetIdentityOptions)
        .AddRoles<ApplicationRole>()
        .AddEntityFrameworkStores<ApplicationDbContext>();

    services.AddRouting(options => options.LowercaseUrls = true);

    services.AddSwaggerGen();
    services.AddSingleton(configuration);

    // Data repositories
    services.AddScoped(typeof(IDeletableEntityRepository<>), typeof(EfDeletableEntityRepository<>));
    services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>));
    services.AddScoped<IDbQueryRunner, DbQueryRunner>();

    // Application services
    services.AddTransient<IEmailSender, NullMessageSender>();
    services.AddTransient<ISettingsService, SettingsService>();
}

void Configure(WebApplication app)
{
    // Seed data on application startup
    using (var serviceScope = app.Services.CreateScope())
    {
        var dbContext = serviceScope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        dbContext.Database.Migrate();

        new ApplicationDbContextSeeder().SeedAsync(dbContext, serviceScope.ServiceProvider)
            .GetAwaiter()
            .GetResult();
    }

    AutoMapperConfig.RegisterMappings(typeof(ErrorViewModel).GetTypeInfo().Assembly);

    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI(c =>
        {
            c.SwaggerEndpoint("/swagger/v1/swagger.json", GlobalConstants.SystemName);
            c.InjectStylesheet("/swagger/custom.css");
            c.RoutePrefix = string.Empty;
        });

        app.UseMigrationsEndPoint();
    }
    else
    {
        app.UseHsts();
    }

    app.UseHttpsRedirection();

    app.UseAuthentication();
    app.UseAuthorization();
    app.UseRouting();

    app.MapControllers();
}
