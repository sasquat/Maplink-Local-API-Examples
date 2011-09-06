using System.Collections.Generic;

namespace Maplink.Local.Api.Examples.Wrappers
{
    public class HttpRequest
    {
        public HttpRequest()
        {
            Headers = new Dictionary<string, string>();
        }

        public string Uri { get; set; }
        public string Body { get; set; }
        public string ContentType { get; set; }
        public IEnumerable<KeyValuePair<string, string>> Headers { get; set; }
    }
}