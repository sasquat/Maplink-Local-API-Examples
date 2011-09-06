namespace Maplink.Api.ClientExamples
{
    public static class RouteXmlBodyTemplates
    {
        public const string GetRouteBodyTemplate = @"<getRoute>
    <rs>
        <RouteStop>
            <description>{0}</description>
            <point>
                <x>{1}</x>
                <y>{2}</y>
            </point>
        </RouteStop>
        <RouteStop>
            <description>{3}</description>
            <point>
                <x>{4}</x>
                <y>{5}</y>
            </point>
        </RouteStop>
    </rs>
    <ro>
        <language>portugues</language>
        <routeDetails>
            <descriptionType>1</descriptionType>
            <routeType>1</routeType>
            <optimizeRoute>true</optimizeRoute>
            <poiRoute />
            <barriersList />
            <barrierPoints />
        </routeDetails>
        <vehicle>
            <tankCapacity>10</tankCapacity>
            <averageConsumption>1</averageConsumption>
            <fuelPrice>3</fuelPrice>
            <averageSpeed>50</averageSpeed>
            <tollFeeCat>1</tollFeeCat>
        </vehicle>
    </ro>
    <token>{6}</token>
</getRoute>";

        public const string SetRouteFenceTemplate = @"<setRouteFence>
    <routeId>{0}</routeId>
    <meters>{1}</meters>
    <token>{2}</token>
</setRouteFence>";

        public const string CheckFenceTemplate = @"<checkFence>
    <routeId>{0}</routeId>
    <point>
        <x>{1}</x>
        <y>{2}</y>
    </point>
    <token>{3}</token>
</checkFence>";
    }
}