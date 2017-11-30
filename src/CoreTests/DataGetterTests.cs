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
            List<PlayerDataSummary> playerList = DataGetter.GetPlayerSummaryAll().ToList();

            int lowerExpectedCount = 500;
            int upperExpectedCount = 700;
            int actualCount = playerList.Count;

            // Assert
            Assert.True(
                actualCount >= lowerExpectedCount && actualCount <= upperExpectedCount, 
                "Number of players, " + actualCount + ", is outside the expected limit of: " + lowerExpectedCount + " to " + upperExpectedCount);
        }

        [Theory]
        [InlineData(1, "Cech")]
        [InlineData(44, "Ibe")]
        public void FindPlayerSummaryByIdWorks(int PlayerId, string ExpectedName)
        {
            // Arrange & Act
            var Player = DataGetter.GetPlayerSummary(PlayerId);
            string ActualName = Player.SecondName;

            // Assert
            Assert.True(ActualName == ExpectedName, "Expected player with name " + ExpectedName + " but " + ActualName + " was returned.");
        }

        [Theory]
        [InlineData("Raheem", "Sterling", true)]
        [InlineData("Tom", "Anderson", false)]
        public void FindPlayerSummary(string FirstName, string SecondName, bool ExpectedExists)
        {
            // Arrange & Act
            var Player = DataGetter.GetPlayerSummary(FirstName, SecondName);
            bool ActualExists = !(Player == null);

            // Assert
            Assert.True(ExpectedExists.Equals(ActualExists), "Searching if player " + FirstName + " " + SecondName + " exists by name failed");

        }

        [Fact]
        public void TotalNumberOfTeamsIsCorrect()
        {
            // Arrange & Act
            var teams = DataGetter.GetAllTeams().ToList();
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
            var team = DataGetter.GetTeam(TeamId);
            string actualTeam = team.Name;

            // Assert
            Assert.True(expectedTeam == actualTeam, "Expected team with ID " + TeamId + " to be " + expectedTeam + " but found " + actualTeam + " instead.");
        }
    }
}
