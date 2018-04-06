using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FPL.Core.Data;
using FPL.Core.Model;
using Xunit;

namespace FPL.Core.Tests
{
    [Trait("TestCategory", "UnitTests")]
    public class PlayerGetterTests
    {
        [Fact]
        public void TotalPlayersReturnedIsCorrect()
        {
            // Arrange & Act
            var dataGetter = new DataGetter();
            var playerGetter = new PlayerGetter(dataGetter);
            int lowerExpectedCount = 500;
            int upperExpectedCount = 700;

            IEnumerable<IPlayer> playerList = playerGetter.GetAllPlayers(false);
            int actualCount = playerList.Count();

            // Assert
            Assert.True(
                actualCount >= lowerExpectedCount && actualCount <= upperExpectedCount,
                "Number of players, " + actualCount + ", is outside the expected limit of: " + lowerExpectedCount + " to " + upperExpectedCount);
        }
    }
}
