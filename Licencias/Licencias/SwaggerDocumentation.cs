using System.Web.Http;
using Swashbuckle.Swagger.Annotations;
using Microsoft.EntityFrameworkCore;

namespace LicenciasAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configura Swagger
            config
                .EnableSwagger(c =>
                {
                    c.SingleApiVersion("v1", "Licencias API");
                    c.IncludeXmlComments(GetXmlCommentsPath());
                })
                .EnableSwaggerUi();

            // Rutas de la API
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }

