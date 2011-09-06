using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace Maplink.Local.Api.Examples.Wrappers
{
    public class WebResponseExtractor : IWebResponseExtractor
    {
        private readonly IHttpResponseFactory _httpResponseFactory;

        public WebResponseExtractor()
            : this(new HttpResponseFactory())
        {
        }

        public WebResponseExtractor(IHttpResponseFactory httpResponseFactory)
        {
            _httpResponseFactory = httpResponseFactory;
        }

        public HttpResponse ExtractResponse(WebResponse response, Encoding encoding)
        {
            string body;
            int statusCode;
            IEnumerable<KeyValuePair<string, string>> headers;
            using (var webResponse = (HttpWebResponse)response)
            {
                statusCode = (int)webResponse.StatusCode;
                headers = ExtractHeaderFrom(webResponse);
                using (var reader = new StreamReader(webResponse.GetResponseStream(), encoding))
                {
                    body = reader.ReadToEnd();
                }
            }

            return _httpResponseFactory.Create(statusCode, headers, body);
        }

        private static IEnumerable<KeyValuePair<string, string>> ExtractHeaderFrom(HttpWebResponse webResponse)
        {
            return webResponse
                .Headers
                .AllKeys
                .Select(
                    headerKey =>
                    new KeyValuePair<string, string>(
                        headerKey,
                        webResponse.GetResponseHeader(headerKey))).ToList();
        }
    }
}