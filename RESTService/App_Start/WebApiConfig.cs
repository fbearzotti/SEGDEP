using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json.Serialization;
using System.Web.Http.OData.Builder;
using System.Web.Http.OData.Extensions;
using RESTService.Datos;

namespace RESTService
{
  public static class WebApiConfig
  {
    public static void Register(HttpConfiguration config)
    {
      // Web API configuration and services
      // Configure Web API to use only bearer token authentication.
      config.SuppressDefaultHostAuthentication();
      config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));

      // Web API routes
      config.MapHttpAttributeRoutes();

      config.Routes.MapHttpRoute(
          name: "DefaultApi",
          routeTemplate: "api/{controller}/{id}",
          defaults: new { id = RouteParameter.Optional }
      );

      // Web API routes
      ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
      builder.EntitySet<categorias>("categorias");
      builder.EntitySet<temporadas>("temporadas");
      builder.EntitySet<categoriasPersonas>("categoriasPersonas");
      builder.EntitySet<eventos>("eventos");
      builder.EntitySet<medidas>("medidas");
      builder.EntitySet<partidos>("partidos");
      builder.EntitySet<entrenadores>("entrenadores");
      builder.EntitySet<entrenamientos>("entrenamientos");
      builder.EntitySet<jugadores>("jugadores");
      builder.EntitySet<personas>("personas");
      builder.EntitySet<asistenciaEntrenamientos>("asistenciaEntrenamientos");
      builder.EntitySet<categoriasPersonas>("categoriasPersonas");
      builder.EntitySet<clubes>("clubes");
      builder.EntitySet<destrezasPersonas>("destrezasPersonas");
      builder.EntitySet<eventos>("eventos");
      builder.EntitySet<localidades>("localidades");
      builder.EntitySet<medidas>("medidas");
      builder.EntitySet<pagos>("pagos");
      builder.EntitySet<tipoPersonas>("tipoPersonas");
      builder.EntitySet<posicionesPersonas>("posicionesPersonas");
      builder.EntitySet<tipoDocumentos>("tipoDocumentos");
      config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    }
  }
}
