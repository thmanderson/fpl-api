using System.Linq;
using System.Collections.Generic;
using FPL.Core;
using Xunit;

namespace FPL.Data.Helpers.Tests
{
    [Trait("TestCategory", "UnitTests")]
    public class DataRetrieverTests
    {
        private DataRetriever DataRetriever = new DataRetriever();

        /*
        [Fact]
        public void TotalFixturesReturnedEqualsFullSeason()
        {
            // Arrange & Act
            List<FixtureData> fixturesList = DataRetriever.GetAllFixtures().ToList();

            int expectedCount = 380;
            int actualCount = fixturesList.Count;

            // Assert
            Assert.True(Equals(actualCount, expectedCount), "Expected number of fixtures: " + expectedCount + ", Actual number of fixtures returned: " + actualCount);
        } */

        [Fact]
        public void TotalPlayersReturnedEqualsFullSeason()
        {
            // Arrange & Act
            List<IPlayer> playerList = DataRetriever.GetAllPlayers().ToList();

            int expectedCount = 569;
            int actualCount = playerList.Count;

            // Assert
            Assert.True(actualCount == expectedCount, "Number of players, " + actualCount + ", is greater than expected value," + expectedCount + ". ");
        }

        /*
        [Fact]
        public void PlayersByFirstname()
        {
            // Arrange & Act
            string firstName = "Raheem";
            string secondName = "Sterling";
            IPlayer output = DataRetriever.GetPlayer(firstName, secondName);

            // Assert
            Assert.True(output != null, "Should return a player");
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
            var detailedPlayer = DataRetriever.GetPlayerDetailed(1);

            Assert.True(detailedPlayer.PreviousSeasons[0].Minutes == 1620);
        }
        */
    }
}
