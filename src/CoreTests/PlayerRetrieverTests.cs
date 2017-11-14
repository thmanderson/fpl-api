using System.Linq;
using Xunit;
using Xunit.Extensions;
using System.Collections.Generic;
using Core.Model;
using Core.Helpers;

namespace CoreTests
{
    [Trait("TestCategory", "UnitTests")]
    public class PlayerRetrieverTests
    {
        [Fact]
        public void TotalPlayersReturnedEqualsFullSeason()
        {
            // Arrange & Act
            var players = PlayerRetriever.GetAllPlayers();
            List<Player> playerList = players.ToList();
            int expectedCount = 566;
            int actualCount = playerList.Count;

            // Assert
            Assert.True(actualCount == expectedCount, "Number of players, " + actualCount + ", is greater than expected value," + expectedCount + ". ");
        }
    }
}