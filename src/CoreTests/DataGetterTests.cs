using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FPL.Core.Data;
using Xunit;

namespace FPL.Core.Tests
{
    [Trait("TestCategory", "UnitTests")]
    public class DataGetterTests
    {
        [Fact]
        public void TotalPlayersReturnedIsCorrect()
        {
            // Arrange & Act
            var dataGetter = new DataGetter();
            int lowerExpectedCount = 500;
            int upperExpectedCount = 700;

            List<PlayerDataSummary> playerList = dataGetter.GetPlayerSummaryAll().ToList();
            int actualCount = playerList.Count;

            // Assert
            Assert.True(
                actualCount >= lowerExpectedCount && actualCount <= upperExpectedCount, 
                "Number of players, " + actualCount + ", is outside the expected limit of: " + lowerExpectedCount + " to " + upperExpectedCount);
        }

        [Theory]
        [InlineData(1, "Cech")]
        [InlineData(44, "Arter")]
        public void FindPlayerSummaryByIdWorks(int PlayerId, string ExpectedName)
        {
            // Arrange & Act
            var dataGetter = new DataGetter();
            var Player = dataGetter.GetPlayerSummary(PlayerId);
            string ActualName = Player.SecondName;

            // Assert
            Assert.True(ActualName == ExpectedName, "Expected player with name " + ExpectedName + " but " + ActualName + " was returned.");
        }

        [Fact]
        public void TotalNumberOfTeamsIsCorrect()
        {
            // Arrange & Act
            var dataGetter = new DataGetter();
            var teams = dataGetter.GetAllTeamData().ToList();
            int expectedCount = 20;
            int actualCount = teams.Count();

            // Assert
            Assert.True(expectedCount == actualCount, "Expected to find " + expectedCount + " teams in the league, but actually found " + actualCount);
        }

        [Theory]
        [InlineData(0, "Arsenal")]
        public void FindTeamByIdWorks(int TeamId, string expectedTeam)
        {
            // Arrange & Act
            var dataGetter = new DataGetter();
            var team = dataGetter.GetTeamData(TeamId);
            string actualTeam = team.Name;

            // Assert
            Assert.True(expectedTeam == actualTeam, "Expected team with ID " + TeamId + " to be " + expectedTeam + " but found " + actualTeam + " instead.");
        }

        [Theory]
        [InlineData(380)]
        public void GetAllFixturesWorks(int expectedResult)
        {
            var dataGetter = new DataGetter();
            var teams = dataGetter.GetAllFixtureData();
            var actualResult = teams.Count();

            Assert.True(expectedResult == actualResult, "Expected to find " + expectedResult + " fixtures, but " + actualResult + " were found.");
        }
    }
}
