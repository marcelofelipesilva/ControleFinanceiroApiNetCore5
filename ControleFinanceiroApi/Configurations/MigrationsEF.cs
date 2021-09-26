using System.Linq;
using ControleFinanceiroApi.Infra.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ControleFinanceiroApi.Configurations
{
    public static class EntityFrameworkExtensions {
      
        public static IApplicationBuilder UseApplyMigration(this IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                using (var ControleFinanceiroApiDbContext = serviceScope.ServiceProvider.GetService<ControleFinanceiroApiDbContext>())
                {
                    var migracoesPendentes = ControleFinanceiroApiDbContext.Database.GetPendingMigrations();

                    if (migracoesPendentes.Count() == 0)
                    {
                        return app;
                    }

                    ControleFinanceiroApiDbContext.Database.Migrate();
                }
            }

            return app;
        }
    }
}