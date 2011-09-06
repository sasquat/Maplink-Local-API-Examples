using System.Collections.Generic;

namespace Maplink.Local.Api.Examples.Wrappers
{
    public interface IHttpResponseFactory
    {
        HttpResponse Create(
            int statusCode,
            IEnumerable<KeyValuePair<string, string>> headers,
            string body);
    }
}