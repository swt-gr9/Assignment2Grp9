using System;

namespace AirTrafficMonitoringSystem.DataFormatter
{
    internal interface IDataFormatter
    {
        Plane.Plane FormatFromString(String planeinfo);
    }
}