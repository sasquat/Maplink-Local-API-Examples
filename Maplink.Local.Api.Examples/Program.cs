using System;
using System.Linq;
using Maplink.Local.Api.Examples.Wrappers;

namespace Maplink.Local.Api.Examples
{
    class Program
    {
        private static readonly FindAddressExamples FindAddressExamples;
        private static readonly RouteExamples RouteExamples;
        private static readonly MapRenderExamples MapRenderExamples;
        private const string Token = "{seu-token-aqui}";
        private const string AddressFinderUrl = "http://192.168.2.19:8080/MapLinkAPI/AddressFinder";
        private const string RouteUrl = "http://192.168.2.19:8080/MapLinkAPI/Route";
        private const string MapRenderUrl = "http://192.168.2.19:8080/MapLinkAPI/MapRender";


        static Program()
        {
            FindAddressExamples = new FindAddressExamples();
            RouteExamples = new RouteExamples();
            MapRenderExamples = new MapRenderExamples();
        }

        static void Main(string[] args)
        {
            var responseFromFindAddress = GetResponseFromFindAddress();
            var responseFromFindCity = GetResponseFromFindCity();
            var responseFromFindPoi = GetResponseFromFindPoi();
            var responseFromGetAddress = GetResponseFromGetAddress();
            var responseFromGetIntersection = GetResponseFromGetIntersection();
            var responseFromGetRoute = GetResponseFromGetRoute();
            var responseFromSetRouteFence = GetResponseFromSetRouteFence();
            var responseFromCheckFence = GetResponseFromCheckFence();
            var responseFromGetZoomRadius = GetResponseFromGetZoomRadius();
            var responseFromGetMap = GetResponseFromGetMap();
                
            PrintResponse(responseFromFindAddress);
            PrintResponse(responseFromFindCity);
            PrintResponse(responseFromFindPoi);
            PrintResponse(responseFromGetAddress);
            PrintResponse(responseFromGetIntersection);
            PrintResponse(responseFromGetRoute);
            PrintResponse(responseFromSetRouteFence);
            PrintResponse(responseFromCheckFence);
            PrintResponse(responseFromGetZoomRadius);
            PrintResponse(responseFromGetMap);

            Console.Read();
        }

        private static HttpResponse GetResponseFromCheckFence()
        {
            return RouteExamples.CheckFence("192.168.2.19_1315257779889", "-23.5924345", "-46.692039861", Token, RouteUrl);
        }

        private static HttpResponse GetResponseFromSetRouteFence()
        {
            return RouteExamples.SetRouteFence("192.168.2.19_1315257779889", "1000", Token, RouteUrl);
        }

        private static HttpResponse GetResponseFromGetMap()
        {
            return MapRenderExamples.GetMap(
                "-23.597290772",
                "-46.692039861",
                "-23.58757826",
                "-46.681501139",
                Token,
                MapRenderUrl);
        }

        private static HttpResponse GetResponseFromGetZoomRadius()
        {
            return MapRenderExamples.GetZoomRadius("-23.5924345", "-46.6867705", Token, MapRenderUrl);
        }

        private static void PrintResponse(HttpResponse response)
        {
            Console.WriteLine("==================================");
            Console.WriteLine(response.Success);
            Console.WriteLine(response.StatusCode);
            response.Headers.ToList().ForEach(header => Console.WriteLine("{0}: {1}", header.Key, header.Value));
            Console.WriteLine(String.Empty);
            Console.WriteLine(response.Body);
        }

        private static HttpResponse GetResponseFromGetRoute()
        {
            var responseFromGetRoute =
                RouteExamples
                    .GetRoute(
                        "Rua Funchal, 129",
                        "-23.5924345",
                        "-46.6867705",
                        "Avenida Paulista, 129",
                        "-23.5701859",
                        "-46.645769",
                        Token,
                        RouteUrl);

            return responseFromGetRoute;
        }

        private static HttpResponse GetResponseFromFindPoi()
        {
            var responseFromFindPoi =
                FindAddressExamples
                    .FindPoi(
                        "banco",
                        "Sao Paulo",
                        "SP",
                        Token,
                        AddressFinderUrl);

            return responseFromFindPoi;
        }

        private static HttpResponse GetResponseFromFindCity()
        {
            var responseFromFindCity =
                FindAddressExamples
                    .FindCity(
                        "São Paulo",
                        "SP",
                        Token,
                        AddressFinderUrl);

            return responseFromFindCity;
        }

        private static HttpResponse GetResponseFromFindAddress()
        {
            var responseFromFindAddress =
                FindAddressExamples
                    .FindAddress(
                        "Rua Funchal",
                        "129",
                        Token,
                        AddressFinderUrl);

            return responseFromFindAddress;
        }

        private static HttpResponse GetResponseFromGetAddress()
        {
            var responseFromFindAddress =
                FindAddressExamples
                    .GetAddress(
                        "-23.5924345",
                        "-46.6867705",
                        Token,
                        AddressFinderUrl);

            return responseFromFindAddress;
        }

        private static HttpResponse GetResponseFromGetIntersection()
        {
            var responseFromFindAddress =
                FindAddressExamples
                    .GetIntersection(
                        "Av Reboucas",
                        "Av Brg. Faria Lima",
                        Token,
                        AddressFinderUrl);

            return responseFromFindAddress;
        }
    }
}
