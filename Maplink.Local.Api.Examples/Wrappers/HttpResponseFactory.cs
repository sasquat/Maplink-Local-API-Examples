using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace Maplink.Local.Api.Examples.Wrappers
{
    public class HttpResponseFactory : IHttpResponseFactory
    {
        private static readonly IEnumerable<int> SuccessfulCodes = new List<int>
                                                                       {
                                                                           (int) HttpStatusCode.OK,
                                                                           (int) HttpStatusCode.Created,
                                                                           (int) HttpStatusCode.Accepted,
                                                                           (int) HttpStatusCode.NonAuthoritativeInformation,
                                                                           (int) HttpStatusCode.NoContent,
                                                                           (int) HttpStatusCode.ResetContent,
                                                                           (int) HttpStatusCode.PartialContent
                                                                       };
        
        public HttpResponse Create(
            int statusCode,
            IEnumerable<KeyValuePair<string, string>> headers,
            string body)
        {
            return new HttpResponse
                       {
                           StatusCode = statusCode,
                           Headers = headers,
                           Body = body,
                           Success = SuccessfulCodes.Contains(statusCode)
                       };
        }
    }
}