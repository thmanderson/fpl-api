using System.Linq;
using Xunit;
using System.Collections.Generic;

namespace Core.Helpers.Tests
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
            List<Player> playerList = DataRetriever.GetAllPlayers().ToList();
            int expectedCount = 568;
            int actualCount = playerList.Count;

            // Assert
            Assert.True(actualCount == expectedCount, "Number of players, " + actualCount + ", is greater than expected value," + expectedCount + ". ");
        }

        [Fact]
        public void PlayersByFirstname()
        {
            // Arrange & Act
            string testName = "Sterling";
            List<Player> output = DataRetriever.GetPlayer(testName).ToList();
            int expectedCount = 1;
            int actualCount = output.Count;

            // Assert
            Assert.True(expectedCount == actualCount, "Should be " + expectedCount + " player with second name " + testName + ", but " + actualCount + " were found.");
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

        [Fact]
        public void CanGetDetailedPlayer()
        {
            var detailedPlayer = DataRetriever.GetDetailedPlayerSummary(1);

            Assert.True(detailedPlayer.PreviousSeasons[0].Minutes == 1620);
        }
    }
}
