namespace Maplink.Local.Api.Examples
{
    public static class MapRenderXmlBodyTemplates
    {
        public const string GetZoomRadiusTemplate = @"<getZoomRadius xmlns=""http://webservices.maplink2.com.br"">
    <routeId></routeId>
    <maptype>png</maptype>
    <point>
        <x>{0}</x>
        <y>{1}</y>
    </point>
    <radius>500</radius>
    <mo>
        <scaleBar>true</scaleBar>
        <mapSize>
            <width>500</width>
            <height>500</height>
        </mapSize>
    </mo>
    <token>{2}</token>
</getZoomRadius>";

        public const string GetMapTemplate = @"<getMap xmlns=""http://webservices.maplink2.com.br"">
    <routeId></routeId>
    <maptype>png</maptype>
    <extent>
        <XMin>{0}</XMin>
        <YMin>{1}</YMin>
        <XMax>{2}</XMax>
        <YMax>{3}</YMax>
    </extent>
    <mo>
        <scaleBar>true</scaleBar>
        <mapSize>
            <width>500</width>
            <height>500</height>
        </mapSize>
    </mo>
    <token>{4}</token>
</getMap>";
    }
}