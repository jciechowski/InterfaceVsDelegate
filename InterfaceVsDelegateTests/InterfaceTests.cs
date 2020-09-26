using System.Collections.Generic;
using InterfaceVsDelegate;
using Xunit;

namespace InterfaceVsDelegateTests
{
    public class InterfaceTests
    {
        [Fact]
        public void ShouldReturnData()
        {
            var getStationsQuery = new GetStationsQueryWithInterface(new StationRepositoryMock());

            var result = getStationsQuery.Handle();

            Assert.Contains(new Station("Gdansk"), result);
        }
    }

    public class StationRepositoryMock : IStationRepository
    {
        public IReadOnlyCollection<Station> GetAllStations() => new List<Station>
        {
            new Station("Gdansk")
        };
    }
}