using System;
using System.Collections.Generic;
using System.Text;
using Core;
using Core.Helpers;
using Core.Model;
using Xunit;

namespace CoreTests
{
    [Trait("TestCategory", "UnitTests")]
    public class PlayerCalculationTests
    {
        [Fact]
        public void PointsPerGameTest()
        {
            int playerId = 77;
            double expectedValue = 100;
            var player = PlayerRetriever.GetPlayer(playerId);
            double actualValue = PlayerCalculations.PointsPerGame(player);

            Assert.True(expectedValue == actualValue, "Expected Value for " + player.Data.FirstName + " " + player.Data.SecondName + ": " + expectedValue + ", Actual Value: " + actualValue);
        }
    }
}
