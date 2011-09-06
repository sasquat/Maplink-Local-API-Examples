using System.Net;
using System.Text;

namespace Maplink.Api.ClientExamples.Wrappers
{
    public interface IWebResponseExtractor
    {
        HttpResponse ExtractResponse(WebResponse response, Encoding encoding);
    }
}