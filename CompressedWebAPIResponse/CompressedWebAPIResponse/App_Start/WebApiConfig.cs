using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Web.Http;
using CompressedWebAPIResponse.Compression;
using Newtonsoft.Json;

namespace CompressedWebAPIResponse
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // Applying data compression.
            config.MessageHandlers.Add(new DataCompressionHandler()); 
            config.EnableSystemDiagnosticsTracing();

            var jsonFormatter = new JsonMediaTypeFormatter();

            jsonFormatter.SerializerSettings.Formatting = Formatting.Indented;
            jsonFormatter.SerializerSettings.DateFormatHandling = DateFormatHandling.IsoDateFormat;
            jsonFormatter.SerializerSettings.DateTimeZoneHandling = DateTimeZoneHandling.Utc;

            config.Services.Replace(typeof(IContentNegotiator), new JsonContentNegotiator(jsonFormatter));
        }
    }

    public class JsonContentNegotiator : IContentNegotiator
    {
        private readonly JsonMediaTypeFormatter _jsonFormatter;

        public JsonContentNegotiator(
            JsonMediaTypeFormatter formatter)
        {
            _jsonFormatter = formatter;
        }

        public ContentNegotiationResult Negotiate(
            Type type,
            HttpRequestMessage request,
            IEnumerable<MediaTypeFormatter> formatters)
        {
            var result = new ContentNegotiationResult(_jsonFormatter, new MediaTypeHeaderValue("application/json"));
            return result;
        }
    }
}
