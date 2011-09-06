using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace Maplink.Local.Api.Examples.Wrappers
{
    public class HttpClient : IHttpClient
    {
        private readonly IWebResponseExtractor _webResponseExtractor;
        private readonly IWebRequestBuilder _webRequestBuilder;

        public HttpClient()
            : this(new WebResponseExtractor(), new WebRequestBuilder())
        {
        }

        public HttpClient(
            IWebResponseExtractor webResponseExtractor, 
            IWebRequestBuilder webRequestBuilder)
        {
            _webResponseExtractor = webResponseExtractor;
            _webRequestBuilder = webRequestBuilder;
        }

        public HttpResponse DoAGetRequest(HttpRequest httpRequest)
        {
            var webRequestBuilder =
                _webRequestBuilder
                    .For(httpRequest.Uri)
                    .WithContentType(httpRequest.ContentType)
                    .WithHttpMethod("GET");

            AddHeadersOnWebResponseBuilder(httpRequest.Headers, webRequestBuilder);

            return ProcessRequest(webRequestBuilder.Build());
        }

        public HttpResponse DoAPostRequest(HttpRequest httpRequest)
        {
            var webRequestBuilder =
                _webRequestBuilder
                    .For(httpRequest.Uri)
                    .WithContentType(httpRequest.ContentType)
                    .WithHttpMethod("POST")
                    .WithBody(httpRequest.Body, Encoding.UTF8);

            AddHeadersOnWebResponseBuilder(httpRequest.Headers, webRequestBuilder);

            return ProcessRequest(webRequestBuilder.Build());
        }

        private static void AddHeadersOnWebResponseBuilder(
            IEnumerable<KeyValuePair<string, string>> requestHeaders,
            IWebRequestBuilder webRequestBuilder)
        {
            if (requestHeaders == null)
            {
                return;
            }

            requestHeaders
                    .ToList()
                    .ForEach(header => webRequestBuilder.InsertHeader(header.Key, header.Value));
        }

        private HttpResponse ProcessRequest(WebRequest webRequest)
        {
            try
            {
                return _webResponseExtractor.ExtractResponse(webRequest.GetResponse(), Encoding.UTF8);
            }
            catch (WebException exception)
            {
                return _webResponseExtractor.ExtractResponse(exception.Response, Encoding.UTF8);
            }
        }
    }
}
