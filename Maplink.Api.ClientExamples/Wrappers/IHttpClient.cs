namespace Maplink.Api.ClientExamples.Wrappers
{
    public interface IHttpClient
    {
        HttpResponse DoAGetRequest(HttpRequest httpRequest);
        HttpResponse DoAPostRequest(HttpRequest httpRequest);
    }
}