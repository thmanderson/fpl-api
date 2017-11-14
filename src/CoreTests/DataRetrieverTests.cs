using System.Linq;
using Xunit;
using Xunit.Extensions;
using System.Collections.Generic;
using Core;
using Core.Helpers;

namespace Core.Tests
{
    [Trait("TestCategory", "UnitTests")]
    public class DataRetrieverTests
    {
        [Fact]
        public void TotalFixturesReturnedEqualsFullSeason()
        {
            // Arrange & Act
            var fixtures = DataRetriever.GetAllFixtures();
            List<Fixture> fixturesList = fixtures.ToList();

            int expectedCount = 380;
            int actualCount = fixturesList.Count;

            // Assert
            Assert.True(Equals(actualCount, expectedCount), "Expected number of fixtures: " + expectedCount + ", Actual number of fixtures returned: " + actualCount);
        }

        [Fact]
        public void TotalPlayersReturnedEqualsFullSeason()
        {
            // Arrange & Act
            var players = DataRetriever.GetAllPlayers();
            List<Player> playerList = players.ToList();
            int expectedCount = 566;
            int actualCount = playerList.Count;

            // Assert
            Assert.True(actualCount == expectedCount, "Number of players, " + actualCount + ", is greater than expected value," + expectedCount + ". ");
        }

        [Fact]
        public void GetAllTeamsGivesFullList()
        {
            // Arrange & Act
            var teams = DataRetriever.GetAllTeams();
            List<Team> teamsList = teams.ToList();

            // Assert
            Assert.True(teamsList.Count == 20);
        }
    }
}
