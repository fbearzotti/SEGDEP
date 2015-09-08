using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.OData.Builder;
using System.Web.Http.OData.Extensions;
using Servicio.Datos;

namespace Servicio
{
  public static class WebApiConfig
  {
    public static void Register(HttpConfiguration config)
    {

      ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
      builder.EntitySet<categorias>("categorias");
      builder.EntitySet<destrezasNiveles>("destrezasNiveles");
      builder.EntitySet<temporadas>("temporadas");
      builder.EntitySet<categoriasPersonas>("categoriasPersonas");
      builder.EntitySet<destrezasPersonas>("destrezasPersonas");
      builder.EntitySet<eventos>("eventos");
      builder.EntitySet<salud>("salud");
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
      builder.EntitySet<pagos>("pagos");
      builder.EntitySet<salud>("salud");
      builder.EntitySet<tipoPersonas>("tipoPersonas");
      builder.EntitySet<posicionesPersonas>("posicionesPersonas");
      builder.EntitySet<tipoDocumentos>("tipoDocumentos");
      builder.EntitySet<entrenamientos>("entrenamientos");
      builder.EntitySet<asistenciaEntrenamientos>("asistenciaEntrenamientos");
      builder.EntitySet<climas>("climas");
      builder.EntitySet<tipoSesion>("tipoSesion");
      builder.EntitySet<estadoCampos>("estadoCampos");
      builder.EntitySet<destrezas>("destrezas");
      builder.EntitySet<destrezasGrupos>("destrezasGrupos");
      builder.EntitySet<destrezasNiveles>("destrezasNiveles");
      builder.EntitySet<vPersonas>("vPersonas");
      config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
      config.MapHttpAttributeRoutes();

      config.Routes.MapHttpRoute(
          name: "DefaultApi",
          routeTemplate: "api/{controller}/{id}",
          defaults: new { id = RouteParameter.Optional }
      );
    }
  }
}
