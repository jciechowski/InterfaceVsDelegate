using System.Collections.Generic;

namespace InterfaceVsDelegate
{
    public interface IStationRepository
    {
        IReadOnlyCollection<Station> GetAllStations();
    }

    public class StationRepository : IStationRepository
    {
        public IReadOnlyCollection<Station> GetAllStations() => new List<Station>
        {
            new Station("Gdansk"),
            new Station("Sopot"),
            new Station("Gdynia")
        };
    }
}