using System.Linq;
using Xunit;
using Xunit.Extensions;
using System.Collections.Generic;
using Core.Model;
using Core.Helpers;

namespace CoreTests
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
