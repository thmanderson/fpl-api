using System.Linq;
using Xunit;
using System.Collections.Generic;
using Core.Model;
using Core.Helpers;

namespace CoreTests
{
    [Trait("TestCategory", "UnitTests")]
    public class TeamRetrieverTests
    {
        [Fact]
        public void GetAllTeamsGivesFullList()
        {
            // Arrange & Act
            var teams = TeamRetriever.GetAllTeams();
            List<Team> teamsList = teams.ToList();

            // Assert
            Assert.True(teamsList.Count == 20);
        }
    }
}
