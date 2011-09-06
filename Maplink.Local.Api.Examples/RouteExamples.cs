using System;
using Maplink.Local.Api.Examples.Wrappers;

namespace Maplink.Local.Api.Examples
{
    public class RouteExamples
    {
        private readonly IHttpClient _httpClient;

        public RouteExamples()
        {
            _httpClient = new HttpClient();
        }

        public HttpResponse GetRoute(
            string originDescription,
            string originLatitude,
            string originLongitude,
            string destinationDescription,
            string destinationLatitude,
            string destinationLongitude,
            string token,
            string uri)
        {
            var request = new HttpRequest
            {
                ContentType = "text/xml",
                Uri = uri,
                Body = String.Format(
                  RouteXmlBodyTemplates.GetRouteBodyTemplate,
                  originDescription,
                  originLongitude,
                  originLatitude,
                  destinationDescription,
                  destinationLongitude,
                  destinationLatitude,
                  token)
            };

            return _httpClient.DoAPostRequest(request);
        }

        public HttpResponse SetRouteFence(
            string routeId,
            string meters,
            string token,
            string uri)
        {
            var request = new HttpRequest
            {
                ContentType = "text/xml",
                Uri = uri,
                Body = String.Format(
                  RouteXmlBodyTemplates.SetRouteFenceTemplate,
                  routeId,
                  meters,
                  token)
            };

            return _httpClient.DoAPostRequest(request);
        }

        public HttpResponse CheckFence(
            string routeId,
            string latitude,
            string longitude,
            string token,
            string uri)
        {
            var request = new HttpRequest
            {
                ContentType = "text/xml",
                Uri = uri,
                Body = String.Format(
                  RouteXmlBodyTemplates.CheckFenceTemplate,
                  routeId,
                  longitude,
                  latitude,
                  token)
            };

            return _httpClient.DoAPostRequest(request);
        }
    }
}