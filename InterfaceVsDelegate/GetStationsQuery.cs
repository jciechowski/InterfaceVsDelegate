using System.Collections.Generic;

namespace InterfaceVsDelegate
{
    public class GetStationsQueryWithInterface
    {
        private readonly IStationRepository _stationRepository;

        public GetStationsQueryWithInterface(IStationRepository stationRepository) =>
            _stationRepository = stationRepository;

        public IReadOnlyCollection<Station> Handle() => _stationRepository.GetAllStations();
    }

    public class GetStationsQueryWithDelegate
    {
        private readonly AllStations _allStations;

        public GetStationsQueryWithDelegate(AllStations allStations) => _allStations = allStations;

        public IReadOnlyCollection<Station> Handle() => _allStations();
    }
}