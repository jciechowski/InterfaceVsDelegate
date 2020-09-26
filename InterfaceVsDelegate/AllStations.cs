using System.Collections.Generic;

namespace InterfaceVsDelegate
{
    public delegate IReadOnlyCollection<Station> AllStations();

    public static class Stations
    {
        public static IReadOnlyCollection<Station> Get() => new List<Station>
        {
            new Station("Gdansk"),
            new Station("Sopot"),
            new Station("Gdynia")
        };
    }
}