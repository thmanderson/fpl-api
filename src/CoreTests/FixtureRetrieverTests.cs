using System.Linq;
using Xunit;
using System.Collections.Generic;
using fpl_api.Model;
using fpl_api.Helpers;

namespace Tests
{
    [Trait("TestCategory", "UnitTests")]
    public class FixtureRetrieverTests
    {
        [Fact]
        public void GetAllFixturesGivesFullList()
        {
            // Arrange & Act
            var fixtures = FixtureRetriever.GetAllFixtures();
            List<Fixture> fixturesList = fixtures.ToList();

            // Assert
            Assert.True(fixturesList.Count == 380);
        }
    }
}
