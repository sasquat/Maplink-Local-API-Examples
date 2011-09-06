using System.Collections.Generic;

namespace Maplink.Api.ClientExamples.Wrappers
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