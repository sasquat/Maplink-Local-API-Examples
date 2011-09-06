namespace Maplink.Local.Api.Examples
{
    public static class FindAddressXmlBodyTemplates
    {
        public const string DefaultSearchOptionsTemplate = @"<ao>
        <usePhonetic>true</usePhonetic>
        <searchType>2</searchType>
        <resultRange>
            <pageIndex>0</pageIndex>
            <recordsPerPage>10</recordsPerPage>
        </resultRange>
    </ao>";

        public const string FindAddressRequestBodyTemplate = @"<?xml version=""1.0"" encoding=""utf-8""?>
<findAddress xmlns=""http://webservices.maplink2.com.br"">
    <address>
        <street>{0}</street>
        <houseNumber>{1}</houseNumber>
        <zip></zip>
        <district></district>
        <city>
            <name>Sao Paulo</name>
            <state>SP</state>
        </city>
    </address>
    {2}
    <token>{3}</token>
</findAddress>";

        public const string FindCityRequestBodyTemplate = @"<?xml version=""1.0"" encoding=""utf-8""?>
<findCity xmlns=""http://webservices.maplink2.com.br"">
    <cidade>
        <name>{0}</name>
        <state>{1}</state>
    </cidade>
    {2}
    <token>{3}</token>
</findCity>";

        public const string FindPoiRequestBodyTemplate = @"<?xml version=""1.0"" encoding=""utf-8""?>
<findPOI xmlns=""http://webservices.maplink2.com.br"">
    <name>{0}</name>
    <city>
        <name>{1}</name>
        <state>{2}</state>
    </city>
    {3}
    <token>{4}</token>
</findPOI>";

        public const string GetAddressRequestBodyTemplate = @"<?xml version=""1.0"" encoding=""utf-8""?>
<getAddress xmlns=""http://webservices.maplink2.com.br"">
    <point>
        <x>{0}</x>
        <y>{1}</y>
    </point>
    <token>{2}</token>
    <tolerance>10</tolerance>
</getAddress>";

        public const string GetIntersectionRequestBodyTemplate = @"<getIntersection>
    <street1>{0}</street1>
    <street2>{1}</street2>
    <city>
        <name>Sao Paulo</name>
        <state>SP</state>
    </city>
    <token>{2}</token>
</getIntersection>";
    }
}