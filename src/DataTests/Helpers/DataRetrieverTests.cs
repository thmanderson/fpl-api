using System.Linq;
using System.Collections.Generic;
using FPL.Data.Helpers;
using Xunit;

namespace FPL.Data.Helpers.Tests
{
    [Trait("TestCategory", "UnitTests")]
    public class DataRetrieverTests
    {
        [Fact]
        public void TotalFixturesReturnedEqualsFullSeason()
        {
            // Arrange & Act
            List<FixtureData> fixturesList = DataRetriever.GetAllFixtures().ToList();

            int expectedCount = 380;
            int actualCount = fixturesList.Count;

            // Assert
            Assert.True(Equals(actualCount, expectedCount), "Expected number of fixtures: " + expectedCount + ", Actual number of fixtures returned: " + actualCount);
        }

        [Fact]
        public void TotalPlayersReturnedEqualsFullSeason()
        {
            // Arrange & Act
            List<PlayerDataSummary> playerList = DataRetriever.GetAllPlayers().ToList();

            int expectedCount = 569;
            int actualCount = playerList.Count;

            // Assert
            Assert.True(actualCount == expectedCount, "Number of players, " + actualCount + ", is greater than expected value," + expectedCount + ". ");
        }

        [Fact]
        public void PlayersByFirstname()
        {
            // Arrange & Act
            string testName = "Sterling";
            List<PlayerDataSummary> output = DataRetriever.GetPlayer(testName).ToList();
            int expectedCount = 1;
            int actualCount = output.Count;

            // Assert
            Assert.True(expectedCount == actualCount, "Should be " + expectedCount + " player with second name " + testName + ", but " + actualCount + " were found.");
        }

        [Fact]
        public void GetAllTeamsGivesFullList()
        {
            // Arrange & Act
            var teamsList = DataRetriever.GetAllTeams().ToList();

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
