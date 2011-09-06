using System;
using Maplink.Api.ClientExamples.Wrappers;

namespace Maplink.Api.ClientExamples
{
    public class FindAddressExamples
    {
        private readonly IHttpClient _httpClient;

        public FindAddressExamples()
        {
            _httpClient = new HttpClient();
        }

        public HttpResponse FindAddress(
            string street,
            string number,
            string token,
            string uri)
        {
            var request = new HttpRequest
                              {
                                  ContentType = "text/xml",
                                  Uri = uri,
                                  Body = String.Format(
                                      FindAddressXmlBodyTemplates.FindAddressRequestBodyTemplate, 
                                      street,
                                      number,
                                      FindAddressXmlBodyTemplates.DefaultSearchOptionsTemplate,
                                      token)
                              };

            return _httpClient.DoAPostRequest(request);
        }

        public HttpResponse FindCity(
            string city,
            string state,
            string token,
            string uri)
        {
            var request = new HttpRequest
                              {
                                  ContentType = "text/xml",
                                  Uri = uri,
                                  Body = String.Format(
                                    FindAddressXmlBodyTemplates.FindCityRequestBodyTemplate, 
                                    city, 
                                    state,
                                    FindAddressXmlBodyTemplates.DefaultSearchOptionsTemplate,
                                    token)
                              };

            return _httpClient.DoAPostRequest(request);
        }

        public HttpResponse FindPoi(
            string place,
            string city,
            string state,
            string token,
            string uri)
        {
            var request = new HttpRequest
                              {
                                  ContentType = "text/xml",
                                  Uri = uri,
                                  Body = String.Format(
                                    FindAddressXmlBodyTemplates.FindPoiRequestBodyTemplate, 
                                    place, 
                                    city,
                                    state,
                                    FindAddressXmlBodyTemplates.DefaultSearchOptionsTemplate,
                                    token)
                              };

            return _httpClient.DoAPostRequest(request);
        }

        public HttpResponse GetAddress(
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
                                    FindAddressXmlBodyTemplates.GetAddressRequestBodyTemplate, 
                                    longitude, 
                                    latitude,
                                    token)
                              };

            return _httpClient.DoAPostRequest(request);
        }

        public HttpResponse GetIntersection(
            string street1,
            string street2,
            string token,
            string uri)
        {
            var request = new HttpRequest
                              {
                                  ContentType = "text/xml",
                                  Uri = uri,
                                  Body = String.Format(
                                    FindAddressXmlBodyTemplates.GetIntersectionRequestBodyTemplate,
                                    street1,
                                    street2,
                                    token)
                              };

            return _httpClient.DoAPostRequest(request);
        }
    }
}