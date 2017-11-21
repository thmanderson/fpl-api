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

            int expectedCount = 569;
            int actualCount = playerList.Count;

            // Assert
            Assert.True(actualCount == expectedCount, "Number of players, " + actualCount + ", is greater than expected value," + expectedCount + ". ");
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
    }
}
