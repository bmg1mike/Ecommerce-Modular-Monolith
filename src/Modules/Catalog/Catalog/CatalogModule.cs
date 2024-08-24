using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Catalog;

public static class CatalogModule
{
    public static IServiceCollection AddCatalogModule(this IServiceCollection services, IConfiguration configuration)
    {
        // services.AddDbContext<CatalogDbContext>(options =>
        // {
        //     options.UseSqlServer("Server=.;Database=Catalog;Trusted_Connection=True;");
        // });

        // services.AddScoped<IProductRepository, ProductRepository>();

        return services;
    }

    public static IApplicationBuilder UseCatalogModule(this IApplicationBuilder app)
    {
        // app.UseEndpoints(endpoints =>
        // {
        //     endpoints.MapControllers();
        // });

        return app;
    }
}
