using System.Collections.Generic;

namespace Maplink.Api.ClientExamples.Wrappers
{
    public interface IHttpResponseFactory
    {
        HttpResponse Create(
            int statusCode,
            IEnumerable<KeyValuePair<string, string>> headers,
            string body);
    }
}