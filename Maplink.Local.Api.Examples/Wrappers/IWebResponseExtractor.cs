using System.Net;
using System.Text;

namespace Maplink.Local.Api.Examples.Wrappers
{
    public interface IWebResponseExtractor
    {
        HttpResponse ExtractResponse(WebResponse response, Encoding encoding);
    }
}