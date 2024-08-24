using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Ordering;

public static class OrderingModule
{
    public static IServiceCollection AddOrderingModule(this IServiceCollection services, IConfiguration configuration)
    {
        // services.AddDbContext<OrderingDbContext>(options =>
        // {
        //     options.UseSqlServer("Server=.;Database=Ordering;Trusted_Connection=True;");
        // });

        // services.AddScoped<IOrderRepository, OrderRepository>();

        return services;
    }

    public static IApplicationBuilder UseOrderingModule(this IApplicationBuilder app)
    {
        // app.UseEndpoints(endpoints =>
        // {
        //     endpoints.MapControllers();
        // });

        return app;
    }
}
