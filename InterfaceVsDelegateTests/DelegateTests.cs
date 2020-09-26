using System.Collections.Generic;
using InterfaceVsDelegate;
using Xunit;

namespace InterfaceVsDelegateTests
{
    public class DelegateTests
    {
        [Fact]
        public void ShouldReturnData()
        {
            AllStations stationsMock = () => new List<Station>
            {
                new Station("Gdansk")
            };
            var getStationsQuery = new GetStationsQueryWithDelegate(stationsMock);

            var result = getStationsQuery.Handle();

            Assert.Contains(new Station("Gdansk"), result);
        }
    }
}