namespace Maplink.Local.Api.Examples.Wrappers
{
    public interface IHttpClient
    {
        HttpResponse DoAGetRequest(HttpRequest httpRequest);
        HttpResponse DoAPostRequest(HttpRequest httpRequest);
    }
}