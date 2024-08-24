using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Basket;

public static class BasketModule
{
    public static IServiceCollection AddBasketModule(this IServiceCollection services, IConfiguration configuration)
    {
        // services.AddDbContext<BasketDbContext>(options =>
        // {
        //     options.UseSqlServer("Server=.;Database=Basket;Trusted_Connection=True;");
        // });

        // services.AddScoped<IBasketRepository, BasketRepository>();

        return services;
    }

    public static IApplicationBuilder UseBasketModule(this IApplicationBuilder app)
    {
        // app.UseEndpoints(endpoints =>
        // {
        //     endpoints.MapControllers();
        // });

        return app;
    }
}
