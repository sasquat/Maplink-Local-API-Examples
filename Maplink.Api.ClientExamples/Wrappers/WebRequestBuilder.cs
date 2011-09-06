using System.IO;
using System.Net;
using System.Text;

namespace Maplink.Api.ClientExamples.Wrappers
{
    public class WebRequestBuilder : IWebRequestBuilder
    {
        private HttpWebRequest _request;

        public IWebRequestBuilder For(string uri)
        {
            _request = (HttpWebRequest)WebRequest.Create(uri);
            _request.KeepAlive = false;
            _request.AllowAutoRedirect = true;

            return this;
        }

        public IWebRequestBuilder WithHttpMethod(string method)
        {
            _request.Method = method;

            return this;
        }

        public IWebRequestBuilder InsertHeader(string name, string value)
        {
            _request.Headers.Add(name, value);

            return this;
        }

        public IWebRequestBuilder WithContentType(string contentType)
        {
            _request.ContentType = contentType;

            return this;
        }

        public IWebRequestBuilder WithBody(string body, Encoding encoding)
        {
            using(var requestStream = _request.GetRequestStream())
            {
                using (var streamWriter = new StreamWriter(requestStream, encoding))
                {
                    streamWriter.Write(body);
                }
            }

            return this;
        }

        public HttpWebRequest Build()
        {
            return _request;
        }
    }
}