using System;
using Maplink.Api.ClientExamples.Wrappers;

namespace Maplink.Api.ClientExamples
{
    public class MapRenderExamples
    {
        private readonly IHttpClient _httpClient;

        public MapRenderExamples()
        {
            _httpClient = new HttpClient();
        }

        public HttpResponse GetZoomRadius(
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
                    MapRenderXmlBodyTemplates.GetZoomRadiusTemplate,
                    longitude,
                    latitude,
                    token)
            };

            return _httpClient.DoAPostRequest(request);
        }

        public HttpResponse GetMap(
            string latitudeMin,
            string longitudeMin,
            string latitudeMax,
            string longitudeMax,
            string token,
            string uri)
        {
            var request = new HttpRequest
            {
                ContentType = "text/xml",
                Uri = uri,
                Body = String.Format(
                    MapRenderXmlBodyTemplates.GetMapTemplate,
                    longitudeMin,
                    latitudeMin,
                    longitudeMax,
                    latitudeMax,
                    token)
            };

            return _httpClient.DoAPostRequest(request);
        }
    }
}