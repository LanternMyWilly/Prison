using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;
using System.Reflection;
using Stoelendans.Repositories;

namespace Prison.Web.Extensions
{
    public static class StartUpExtensions
    {
        public static void RegisterDependencies(this IServiceCollection services)
        {
            #region Repsitories
            services.AddTransient<IRepository<Models.Entities.Prison.Prison>, Repository<Models.Entities.Prison.Prison>>();
            #endregion
        }

        public static void RegisterApiVersioning(this IServiceCollection services)
        {
            services.AddApiVersioning(x => {
                x.DefaultApiVersion = new ApiVersion(1, 0);
                x.AssumeDefaultVersionWhenUnspecified = true;
                x.ReportApiVersions = true;
            });
        }

        public static void RegisterMediatR(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
        }

        public static void RegisterSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(x => {
                x.SwaggerDoc("v1", new OpenApiInfo() { Title = "Prison Api", Version = "v1" });
                // Set the comments path for the Swagger JSON and UI.
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                x.IncludeXmlComments(xmlPath);
            });
        }
    }
}
