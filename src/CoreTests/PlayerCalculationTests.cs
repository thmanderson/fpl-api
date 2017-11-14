﻿using Core.Data;
using Newtonsoft.Json.Linq;
using Xunit;

namespace Core.Tests
{
    [Trait("TestCategory", "UnitTests")]
    public class PlayerCalculationTests
    {
        private JObject testPlayerJson;
        private RawPlayerData testRawData;
        private Player testPlayer;

        internal void TestSetup()
        {
            testPlayerJson = JObject.Parse
                (@"{'minutes':15,'points_per_game':150,'total_points':150,'now_cost':60}");
            testRawData = testPlayerJson.ToObject<RawPlayerData>();
            testPlayer = new Player(testRawData);
        }

        [Fact]
        public void PointsPerGameTest()
        {
            TestSetup();
            double expectedValue = 150;
            double actualValue = PlayerCalculation.PointsPerGame(testPlayer);

            Assert.True(expectedValue == actualValue, 
                "Expected Value for " + testPlayer.Data.FirstName + " " + testPlayer.Data.SecondName + ": " + expectedValue + ", Actual Value: " + actualValue);
        }

        [Fact]
        public void PointersPer90Test()
        {
            TestSetup();
            double expectedValue = 900;
            double actualValue = PlayerCalculation.PointsPer90(testPlayer);

            Assert.True(expectedValue == actualValue, 
                "Expected Value for " + testPlayer.Data.FirstName + " " + testPlayer.Data.SecondName + ": " + expectedValue + ", Actual Value: " + actualValue);
        }

        [Fact]
        public void PointsPer90PerMilTest()
        {
            TestSetup();
            double expectedValue = 15;
            double actualValue = PlayerCalculation.PointsPer90PerMillion(testPlayer);

            Assert.True(expectedValue == actualValue,
                "Expected Value for " + testPlayer.Data.FirstName + " " + testPlayer.Data.SecondName + ": " + expectedValue + ", Actual Value: " + actualValue);

        }
    }
}
