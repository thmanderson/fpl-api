using System.Collections.Generic;
using FPL.Core.Data;
using Newtonsoft.Json.Linq;
using Xunit;

namespace FPL.Core.Data.Tests
{
    [Trait("TestCategory", "UnitTests")]
    public class PlayerTests
    {
        private JObject testPlayerJson;
        private PlayerDataSummary testRawData;
        private Player testPlayer;

        internal void TestSetup()
        {
            testPlayerJson = JObject.Parse
                (@"{'minutes':15,'points_per_game':150,'total_points':150,'now_cost':60}");
            testRawData = testPlayerJson.ToObject<PlayerDataSummary>();
            testPlayer = new Player(testRawData);
        }

        [Fact]
        public void PointsPerGameTest()
        {
            TestSetup();
            double expectedValue = 150;
            double actualValue = testPlayer.PointsPerGame();

            Assert.True(expectedValue == actualValue, 
                "Expected Value for " + testPlayer.DataSummary.FirstName + " " + testPlayer.DataSummary.SecondName + ": " + expectedValue + ", Actual Value: " + actualValue);
        }

        [Fact]
        public void PointersPer90Test()
        {
            TestSetup();
            double expectedValue = 900;
            double actualValue = testPlayer.PointsPerNinety();

            Assert.True(expectedValue == actualValue, 
                "Expected Value for " + testPlayer.DataSummary.FirstName + " " + testPlayer.DataSummary.SecondName + ": " + expectedValue + ", Actual Value: " + actualValue);
        }

        [Fact]
        public void PointsPer90PerMilTest()
        {
            TestSetup();
            double expectedValue = 15;
            double actualValue = testPlayer.PointsPerNinetyPerMillion();

            Assert.True(expectedValue == actualValue,
                "Expected Value for " + testPlayer.DataSummary.FirstName + " " + testPlayer.DataSummary.SecondName + ": " + expectedValue + ", Actual Value: " + actualValue);

        }
    }
}
